using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Per-frame polling of local <c>FirstPersonItemController</c> state, replacing
/// Harmony patches on <c>SetRaised</c> / <c>SetFlashlight</c>. Pattern adopted
/// from MegaBonk.Multiplayer's <c>InputDriver</c>: an injected poller in the
/// existing <see cref="ZdoPollerHost"/> tick fan-out, diff-detect against last
/// state, broadcast only on flip.
///
/// <para><b>Why:</b> after the first save-load, Harmony patches are dead
/// (one-shot UnpatchSelf, see <c>Plugin.PausePatchesForLoad</c> — re-PatchAll
/// crashes via MonoMod.CompileMethodHook). Player-input event broadcasts that
/// rely on patches stop working. Polling via <c>FirstPersonItemController.Instance</c>
/// is patch-independent and survives the save-load cycle.</para>
///
/// <para><b>Field verification</b> (Assembly-CSharp_Dump/FirstPersonItemController.cs):
/// <c>isRaised: bool</c> at line 2539, <c>flashlight: bool</c> at line 2565.</para>
///
/// <para>One-shot events (MeleeAttack, Block, CounterAttack, place/throw,
/// give, pickup) remain patch-driven during the active-patches window and
/// stop after first save-load. Migrating those requires either: (a) tracking
/// player-input animation/cooldown state for diff, or (b) exposing the
/// placement-via-snapshot pattern as a poller — left as follow-up work.</para>
/// </summary>
public static class PlayerInputPoller
{
    /// <summary>30 Hz feels responsive but is light: a single bool read per
    /// tick on FPS state. Throttled in <see cref="ZdoPollerHost"/> so we
    /// don't fire 60+ times per second.</summary>
    public const float TICK_HZ = 30f;

    /// <summary>New interactable-directory entries examined per tick for
    /// place/throw detection. See the note at the call site.</summary>
    private const int NEW_ITEMS_PER_TICK = 256;
    public const string NAME = "player-input";

    private static bool _initialized;
    private static bool _lastRaised;
    private static bool _lastFlashlight;
    private static int  _lastInteractableCount = -1;

    // ── Combat-action detection (post-patch-death fallback) ──────────────
    /// <summary>Last-tick value of FirstPersonItemController.attackMainDelay.
    /// A rising edge — value jumping from ~0 to a positive cooldown — signals
    /// MeleeAttack just fired. Mirrors what the FPItemController.MeleeAttack
    /// Harmony patch does, except this path keeps working after the
    /// one-shot UnpatchSelf (see Plugin.PausePatchesForLoad).</summary>
    private static float _lastAttackMainDelay;
    /// <summary>Same idea for Block (secondary-attack delay rising edge).</summary>
    private static float _lastAttackSecondaryDelay;
    /// <summary>True when counterAttackActor was non-null on the previous
    /// tick — used as the diff baseline for CounterAttack detection.</summary>
    private static bool _lastCounterActive;
    /// <summary>Wall-clock of the most recent broadcast for each combat
    /// action. Used as a debounce so the patch (when alive) and this poller
    /// don't double-broadcast the same swing — patch broadcasts first via
    /// MarkBroadcasted, poller's rising edge then sees the recent timestamp
    /// and silently skips.</summary>
    private static readonly float[] _lastBroadcastAt = new float[3];
    private const float COMBAT_DEBOUNCE_S = 0.30f;
    /// <summary>Above this, attackMainDelay is considered "in cooldown" =
    /// just got reset by an attack. Below it, the field has decayed back to
    /// zero and the next reset will register as a rising edge.</summary>
    private const float COMBAT_DELAY_THRESHOLD = 0.05f;

    /// <summary>Last-tick set of interactableIDs the local player held in any
    /// inventory slot. Diff against current tick → diff = (added → pickup,
    /// removed → drop). Lets us catch pick-up / drop without per-method
    /// patches on FirstPersonItemController.PickUpItem / EmptySlot.</summary>
    private static readonly System.Collections.Generic.HashSet<int> _lastSlotIds = new();

    /// <summary>Per-tick scratch set of currently-held slot IDs. Reused across
    /// ticks (Clear() at the top of the slot-diff block) instead of allocating
    /// a fresh HashSet 30 times per second — that was a steady ~1800
    /// Gen0 allocations/minute feeding the GC and producing periodic hitches.
    /// Single-threaded (Unity main), so safe as a static singleton.</summary>
    private static readonly System.Collections.Generic.HashSet<int> _curSlotIdsScratch = new();

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// This poller has no bypass-able gates, so probe just forwards to Tick.</summary>
    internal static void ProbeBody(float now) => Tick(now);

    private static void Tick(float now)
    {
        try
        {
            var fpc = FirstPersonItemController.Instance;
            if (fpc == null) return;

            bool raised, flashlight;
            try { raised     = fpc.isRaised;   } catch { return; }
            try { flashlight = fpc.flashlight; } catch { return; }

            // Place / Throw detection — diff CityData.interactableDirectory.Count
            // and broadcast each new entry as a placement-visual via the
            // existing InventorySync.BroadcastPlacedSince path. Patches at
            // FirstPersonItemController.Place* / Throw* did this themselves
            // by snapshotting count in prefix and broadcasting in postfix;
            // polling captures the same growth episodically.
            //
            // Caveat: polling can't distinguish "player placed" from "host
            // AI created an Interactable" — the Broadcast filters by preset
            // (only known-placeable presets emit a packet) so non-player
            // creations are skipped.
            int curInteractables = SoDCoop.Sync.InventorySync.SnapshotInteractableCount();
            if (_lastInteractableCount < 0)
            {
                _lastInteractableCount = curInteractables;
            }
            else if (curInteractables > _lastInteractableCount)
            {
                // BroadcastNewItemsSince classifies each new entry via
                // Rigidbody.velocity → place vs throw. Replaces the four
                // Place* patches and three Throw* patches.
                // Capped per tick and resumed from where it stopped: a burst of
                // thousands of new directory entries used to be walked in one
                // go (293 ms in a single run on the 2026-07-30 host). At 30 Hz a
                // few hundred per tick still drains any burst in well under a
                // second, and a player's own placement is caught next tick.
                try
                {
                    _lastInteractableCount = SoDCoop.Sync.InventorySync.BroadcastNewItemsSince(
                        _lastInteractableCount, NEW_ITEMS_PER_TICK);
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogWarning($"[PlayerInputPoller] place/throw: {ex.Message}");
                    _lastInteractableCount = curInteractables;
                }
            }
            else if (curInteractables < _lastInteractableCount)
            {
                // Directory shrank (save-reset / scene unload). Re-baseline.
                _lastInteractableCount = curInteractables;
            }

            // ── Pickup / drop diff (slot interactableIDs) ──
            // Walk fpc.slots, collect non-zero interactableIDs, diff against
            // _lastSlotIds. Added IDs → BroadcastPickup. Removed IDs →
            // BroadcastDrop. Replaces patches at FirstPersonItemController.
            // PickUpItem and EmptySlot post-save-load, when patches are dead.
            try
            {
                // Reuse the static scratch instead of allocating a fresh
                // HashSet 30 times per second.
                _curSlotIdsScratch.Clear();
                var curSlotIds = _curSlotIdsScratch;
                var slots = fpc.slots;
                if (slots != null)
                {
                    for (int i = 0; i < slots.Count; i++)
                    {
                        var s = slots[i];
                        if (s == null) continue;
                        int id = s.interactableID;
                        if (id <= 0) continue;
                        curSlotIds.Add(id);
                    }
                }

                if (_initialized)
                {
                    foreach (var id in curSlotIds)
                    {
                        if (!_lastSlotIds.Contains(id))
                        {
                            // Phase G.5 (Wave 1.7): unified RPC via
                            // ZdoEvents.ITEM_PICKUP. Receiver applies via
                            // ItemSync.ApplyPickupFromZdo.
                            if (ZdoFeatureFlags.UseZdoForEvents)
                            {
                                try { ZdoEvents.SendItemPickup(id); }
                                catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] pickup zdo: {ex.Message}"); }
                            }
                            else
                            {
                                try { SoDCoop.Sync.ItemSync.BroadcastPickup(id); }
                                catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] pickup: {ex.Message}"); }
                            }

                            // Place-remove for own previously-placed items
                            // stays on the legacy InventorySync path until
                            // Wave 3 PlacedItem ZDO migration replaces it.
                            try
                            {
                                if (SoDCoop.Sync.InventorySync.IsLocalPlacement(id))
                                    SoDCoop.Sync.InventorySync.BroadcastPlaceRemove(id);
                            }
                            catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] placeRemove: {ex.Message}"); }
                        }
                    }
                    foreach (var id in _lastSlotIds)
                    {
                        if (!curSlotIds.Contains(id))
                        {
                            if (ZdoFeatureFlags.UseZdoForEvents)
                            {
                                try { ZdoEvents.SendItemDrop(id); }
                                catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] drop zdo: {ex.Message}"); }
                            }
                            else
                            {
                                try { SoDCoop.Sync.ItemSync.BroadcastDrop(id); }
                                catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] drop: {ex.Message}"); }
                            }
                        }
                    }
                }

                _lastSlotIds.Clear();
                foreach (var id in curSlotIds) _lastSlotIds.Add(id);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] slot diff: {ex.Message}"); }

            // ── Combat-action edge detection ─────────────────────────────
            // Read the FPC cooldown timers + counter-attack actor pointer.
            // None of these throw if the underlying field is unassigned — IL2CPP
            // returns the default value, and counterAttackActor is naturally
            // null when there's no counter in flight.
            float curMain = 0f, curSec = 0f;
            bool curCounter = false;
            try { curMain     = fpc.attackMainDelay;       } catch { }
            try { curSec      = fpc.attackSecondaryDelay;  } catch { }
            try { curCounter  = fpc.counterAttackActor != null; } catch { }

            if (_initialized)
            {
                if (curMain > COMBAT_DELAY_THRESHOLD && _lastAttackMainDelay <= COMBAT_DELAY_THRESHOLD)
                    TryBroadcastCombat(SoDCoop.Network.ItemActionKind.MeleeAttack);
                if (curSec  > COMBAT_DELAY_THRESHOLD && _lastAttackSecondaryDelay <= COMBAT_DELAY_THRESHOLD)
                    TryBroadcastCombat(SoDCoop.Network.ItemActionKind.Block);
                if (curCounter && !_lastCounterActive)
                    TryBroadcastCombat(SoDCoop.Network.ItemActionKind.CounterAttack);
            }
            _lastAttackMainDelay      = curMain;
            _lastAttackSecondaryDelay = curSec;
            _lastCounterActive        = curCounter;

            if (!_initialized)
            {
                _initialized = true;
                _lastRaised = raised;
                _lastFlashlight = flashlight;
                return;     // baseline — no broadcast
            }

            // Phase G.5 (Wave 1.4): raised + flashlight diffs are emitted
            // via the LocalPlayer ZDO inside LocalPlayerPoller. No legacy
            // broadcast call here. The flip-tracking below is preserved
            // for now in case a future debug log wants the transition
            // event timing — body is otherwise inert.
            if (raised != _lastRaised) _lastRaised = raised;
            if (flashlight != _lastFlashlight) _lastFlashlight = flashlight;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] tick: {ex.Message}"); }
    }

    /// <summary>Called from <c>SodCommonBridge.OnBeforeLoad</c> to reset
    /// the diff baseline so the first post-load tick doesn't broadcast a
    /// stale flip.</summary>
    public static void ResetBaseline()
    {
        _initialized = false;
        _lastInteractableCount = -1;
        _lastSlotIds.Clear();
        _lastAttackMainDelay = 0f;
        _lastAttackSecondaryDelay = 0f;
        _lastCounterActive = false;
    }

    /// <summary>Called by the FPItemController combat patches AT broadcast
    /// time so the poller's rising-edge detector treats the same swing as
    /// already-handled. Without this, a fresh-session player would see
    /// every attack broadcast TWICE — once via the patch postfix and once
    /// via the poller catching the field reset on the next tick.</summary>
    public static void MarkCombatBroadcasted(SoDCoop.Network.ItemActionKind kind)
    {
        int idx = (int)kind;
        if (idx < 0 || idx >= _lastBroadcastAt.Length) return;
        _lastBroadcastAt[idx] = UnityEngine.Time.unscaledTime;
    }

    private static void TryBroadcastCombat(SoDCoop.Network.ItemActionKind kind)
    {
        try
        {
            int idx = (int)kind;
            if (idx >= 0 && idx < _lastBroadcastAt.Length)
            {
                float now = UnityEngine.Time.unscaledTime;
                if (now - _lastBroadcastAt[idx] < COMBAT_DEBOUNCE_S) return; // patch already fired
                _lastBroadcastAt[idx] = now;
            }
            SoDCoop.Sync.InventorySync.BroadcastAction(kind);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] combat broadcast: {ex.Message}"); }
    }
}
