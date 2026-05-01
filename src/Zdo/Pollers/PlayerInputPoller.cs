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
    public const string NAME = "player-input";

    private static bool _initialized;
    private static bool _lastRaised;
    private static bool _lastFlashlight;
    private static int  _lastInteractableCount = -1;

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

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
                try { SoDCoop.Sync.InventorySync.BroadcastPlacedSince(_lastInteractableCount); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] place: {ex.Message}"); }
                _lastInteractableCount = curInteractables;
            }
            else if (curInteractables < _lastInteractableCount)
            {
                // Directory shrank (save-reset / scene unload). Re-baseline.
                _lastInteractableCount = curInteractables;
            }

            if (!_initialized)
            {
                _initialized = true;
                _lastRaised = raised;
                _lastFlashlight = flashlight;
                return;     // baseline — no broadcast
            }

            if (raised != _lastRaised)
            {
                _lastRaised = raised;
                try { SoDCoop.Sync.InventorySync.BroadcastRaised(raised); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] raised broadcast: {ex.Message}"); }
            }

            if (flashlight != _lastFlashlight)
            {
                _lastFlashlight = flashlight;
                try { SoDCoop.Sync.InventorySync.BroadcastFlashlight(flashlight); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[PlayerInputPoller] flashlight broadcast: {ex.Message}"); }
            }
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
    }
}
