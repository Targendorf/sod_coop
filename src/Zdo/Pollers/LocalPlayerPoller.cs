using System;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Per-peer self-state poller. Each peer (host AND clients) writes their
/// own <c>Player.Instance</c> state into a <see cref="ZdoTypeTag.LocalPlayer"/>
/// ZDO owned by themselves. Position is captured at 1 Hz here for
/// snapshot/persist value — high-rate position (20 Hz) continues via the
/// legacy <see cref="SoDCoop.Sync.PlayerSync"/> packet channel during the
/// transition.
///
/// <para>The ZDO is keyed by <c>__sodId = LocalPlayerId</c>; ownership
/// derives from the peer's <c>ZdoMan.LocalPeerUid</c>. On every other
/// peer's machine the same ZDO appears via delta replication — they read
/// it for snapshot consistency but the existing legacy <c>RemotePlayer</c>
/// handles per-frame visual.</para>
///
/// <para>Field verification (Assembly-CSharp_Dump):
/// <c>Human.nourishment / hydration / energy / drunk</c> float (Human.cs:7808+);
/// <c>Actor.isDead</c> bool (Actor.cs:1009);
/// <c>Actor.isTrespassing</c> bool (Actor.cs:1035);
/// <c>Actor.illegalActionActive / illegalAreaActive / illegalStatus</c> bool;
/// <c>Actor.trespassingEscalation</c> int.</para>
///
/// <para>Bypass condition: poller does NOT gate on
/// <c>NetworkManager.IsHost</c> — every peer writes their own LocalPlayer
/// ZDO. The standard <see cref="ZdoPollerHost"/> host-only gate is overridden
/// here by registering with the special <see cref="ZdoPollerHost.RegisterAnyPeer"/>
/// helper.</para>
/// </summary>
public static class LocalPlayerPoller
{
    /// <summary>Fast-lane tick rate — drives position / rotation / velocity
    /// writes into the LocalPlayer ZDO. 15 Hz matches the high end of the
    /// legacy PlayerSync adaptive rate (walk 15 Hz, run 30 Hz) while staying
    /// well under the ZDO flush rate (10 Hz) so a position write always has
    /// a flush ready to ship it. Position is the only fast-lane field;
    /// everything else rides the <see cref="SLOW_EVERY"/> cadence to avoid
    /// re-dirtying the ZDO 15× per second with continuously-decaying vitals
    /// / cosmetic flags that only need ~1 Hz.</summary>
    public const float TICK_HZ = 20f;   // one fresh sample per 20 Hz delta flush
    public const string NAME = "local-player";

    /// <summary>How many fast ticks between slow-lane passes. At
    /// <see cref="TICK_HZ"/>=20 a value of 20 makes the slow lane run at
    /// ~1 Hz — matching the previous whole-poller rate for vitals /
    /// apartments / damage-diff / activity.</summary>
    private const int SLOW_EVERY = 20;
    private static int _tickCounter;

    /// <summary>Below this delta, ignore — SoD's bleed tick can write tiny
    /// fractional drops every frame which we don't want to broadcast.</summary>
    private const float DAMAGE_EPSILON = 1f;

    /// <summary>Position deadband. Player.transform advances every rendered
    /// frame by a sub-millimetre amount even when "standing still" (camera
    /// bob, idle sway). Without a deadband Zdo.Set(Vector3) re-dirties the
    /// ZDO every fast tick → 15 dirty/sec × N peers of pointless position
    /// serialisation. 1 cm is well below perceptible remote-player jitter.</summary>
    private const float POSITION_DEADBAND_SQ = 0.01f * 0.01f;

    private static bool  _healthInitialized;
    private static float _lastHealth;
    private static UnityEngine.Vector3 _lastPos;
    private static bool _posBaselined;

    /// <summary>Last-tick set of address IDs the local player owned. Diff
    /// against current tick → diff = (added → SendApartmentOwned add,
    /// removed → SendApartmentOwned remove). Each peer broadcasts its own
    /// diff so receivers can union-merge into their own
    /// Player.Instance.apartmentsOwned.</summary>
    private static readonly System.Collections.Generic.HashSet<int> _lastApartmentIds = new();
    private static bool _apartmentsInitialized;

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _healthInitialized = false;
        _apartmentsInitialized = false;
        _lastApartmentIds.Clear();
        _posBaselined = false;
        _tickCounter = 0;
    }

    /// <summary>Resolve the player's current coarse-grained activity from
    /// the live <c>Player.Instance</c> field set. Priority is meaningful:
    /// lockpicking wins over computer-use (you might briefly be at a
    /// computer while picking its physical lock); hiding wins over
    /// searching (hiding is rare + visually distinct). isLockpicking is
    /// the explicit player bool (Player.cs:3040). The other states are
    /// inferred from non-null Interactable references that SoD assigns
    /// while the matching interaction is active.</summary>
    private static SoDCoop.Player.PlayerActivity ResolvePlayerActivity(global::Player p)
    {
        try
        {
            try { if (p.isLockpicking) return SoDCoop.Player.PlayerActivity.Lockpicking; } catch { }
            try { if (p.hidingInteractable   != null) return SoDCoop.Player.PlayerActivity.Hiding;       } catch { }
            try { if (p.computerInteractable != null) return SoDCoop.Player.PlayerActivity.ComputerUse;  } catch { }
            try { if (p.phoneInteractable    != null) return SoDCoop.Player.PlayerActivity.PhoneCall;    } catch { }
            try { if (p.searchInteractable   != null) return SoDCoop.Player.PlayerActivity.Searching;    } catch { }
        }
        catch { }
        return SoDCoop.Player.PlayerActivity.None;
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForPlayerState) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private const float KEYFRAME_INTERVAL_S = 1f;
    private static float _nextKeyframeAt;

    private static void TickInner(float now)
    {
        try
        {
            var p = global::Player.Instance;
            if (p == null) return;
            if (NetworkManager.LocalPlayerId < 0) return;

            int sodId = NetworkManager.LocalPlayerId;
            var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.LocalPlayer, sodId,
                owner: ZdoMan.LocalPeerUid, persistent: false);

            // Keyframe the discrete keys once a second. This ZDO rides the
            // Sequenced channel for its position stream, and Set() never
            // re-sends an unchanged value — so a single lost packet used to
            // leave the other side showing the wrong held item, a torch that
            // was switched off, a crouch that ended, or a "downed" pose, until
            // that value happened to change again.
            if (now >= _nextKeyframeAt)
            {
                _nextKeyframeAt = now + KEYFRAME_INTERVAL_S;
                z.Touch(ZdoKeys.Held);
                z.Touch(ZdoKeys.Raised);
                z.Touch(ZdoKeys.Flashlight);
                z.Touch(ZdoKeys.Crouched);
                z.Touch(ZdoKeys.Ko);
                z.Touch(ZdoKeys.Dead);
                z.Touch(ZdoKeys.Activity);
                z.Touch(ZdoKeys.CurrentHealth);
            }

            // ── FAST LANE (every tick, 15 Hz) ─────────────────────────────
            // Position / rotation / velocity — the only fields that need
            // high-rate sync for smooth remote-player interpolation. A
            // position deadband swallows sub-cm camera-bob jitter so the ZDO
            // isn't re-dirtied every tick when the player is "standing still".
            //
            // IMPORTANT: use Player.playerContainer (world-space body root at
            // foot level), NOT p.transform (camera-height parent ~1.6m above
            // the feet). Using .transform made remote players float above the
            // ground AND produced wild teleport deltas (519m, 1946m) because
            // the camera rig can be at a very different position during
            // loading / scene transitions.
            UnityEngine.Vector3 pos = default;
            try
            {
                var anchor = p.playerContainer;
                pos = (anchor != null) ? anchor.position : p.transform.position;
            }
            catch { pos = p.transform.position; }
            bool posMoved = true;
            if (_posBaselined)
            {
                float dx = pos.x - _lastPos.x;
                float dz = pos.z - _lastPos.z;
                float dy = pos.y - _lastPos.y;
                posMoved = (dx * dx + dy * dy + dz * dz) >= POSITION_DEADBAND_SQ;
            }
            if (posMoved)
            {
                try { z.Set(ZdoKeys.Pos, pos); } catch { }
                // Velocity from position delta over the fast-tick interval.
                // Receiver's RemotePlayer uses it for short-term extrapolation
                // when a position delta is late — without it, a stalled packet
                // freezes the avatar in place instead of coasting.
                float dt = 1f / TICK_HZ;
                if (_posBaselined)
                {
                    UnityEngine.Vector3 vel = new Vector3(
                        (pos.x - _lastPos.x) / dt,
                        (pos.y - _lastPos.y) / dt,
                        (pos.z - _lastPos.z) / dt);
                    try { z.Set(ZdoKeys.Velocity, vel); } catch { }
                }
                _lastPos = pos;
                _posBaselined = true;
            }
            try { z.Set(ZdoKeys.Rot, p.transform.rotation); } catch { }

            // Slow lane fires once every SLOW_EVERY fast ticks (~1 Hz).
            bool slowTick = (_tickCounter++ % SLOW_EVERY) == 0;
            if (!slowTick) return;

            // ── SLOW LANE (~1 Hz) ─────────────────────────────────────────
            // Vitals (continuous-decay floats), discrete state flags, activity,
            // trespass — all gameplay/HUD fields that don't need 15 Hz.

            try { z.Set(ZdoKeys.Nourishment, p.nourishment); } catch { }
            try { z.Set(ZdoKeys.Hydration,   p.hydration);   } catch { }
            try { z.Set(ZdoKeys.Energy,      p.energy);      } catch { }
            try { z.Set(ZdoKeys.Dead,        p.isDead);      } catch { }
            try { z.Set(ZdoKeys.CurrentHealth, p.currentHealth); } catch { }

            // Stance + KO — each peer authoritative for its own. Receivers
            // mirror onto the matching twin citizen so other players see the
            // crouched / unconscious state on the body in their world.
            try { z.Set(ZdoKeys.Crouched, p.isCrouched);          } catch { }
            try { z.Set(ZdoKeys.Ko,       p.playerKOInProgress);  } catch { }

            // Coarse-grained activity tag — lockpicking / computer / phone /
            // search / hide. Receiver maps onto the twin citizen's
            // armsBoolAnimationState / idleAnimationState (NPC anim states
            // ship in the base game and animate the twin appropriately).
            try { z.Set(ZdoKeys.Activity, (byte)ResolvePlayerActivity(p)); } catch { }

            try { z.Set(ZdoKeys.Trespassing,         p.isTrespassing);          } catch { }
            try { z.Set(ZdoKeys.IllegalActionActive, p.illegalActionActive);    } catch { }
            try { z.Set(ZdoKeys.IllegalAreaActive,   p.illegalAreaActive);      } catch { }
            try { z.Set(ZdoKeys.IllegalStatus,       (byte)(p.illegalStatus ? 1 : 0)); } catch { }
            try { z.Set(ZdoKeys.Escalation,          p.trespassingEscalation);  } catch { }

            // Phase G.5 (Wave 1.3-4): held-item + raised + flashlight on
            // LocalPlayer ZDO — pure ZDO transport replacing legacy
            // ItemHeldPacket / ItemRaisedPacket / ItemFlashlightPacket.
            try
            {
                var fpc = FirstPersonItemController.Instance;
                if (fpc != null)
                {
                    int heldId = SoDCoop.Sync.InventorySync.SnapshotHeldItemId();
                    z.Set(ZdoKeys.Held,       heldId);
                    z.Set(ZdoKeys.Raised,     fpc.isRaised);
                    z.Set(ZdoKeys.Flashlight, fpc.flashlight);
                }
            }
            catch { /* mid-init */ }

            // Player damage diff — broadcasts a banner + downed pose to peers
            // when local health drops. Replaces the player-victim branch of
            // the (now-disabled) Actor.RecieveDamage patch. Player health
            // itself is per-machine state, but the discrete damage event
            // gets a banner and (on lethal) a downed RemotePlayer.
            try
            {
                float curHealth = p.currentHealth;
                if (!_healthInitialized)
                {
                    _healthInitialized = true;
                    _lastHealth = curHealth;
                }
                else if (_lastHealth - curHealth > DAMAGE_EPSILON)
                {
                    float delta = _lastHealth - curHealth;
                    bool  lethal = curHealth <= 0f;
                    Vector3 dmgPos = Vector3.zero;
                    try { if (p.transform != null) dmgPos = p.transform.position; } catch { }

                    // Phase G.5 (Wave 1.6): unified RPC via
                    // ZdoEventDispatcher.PLAYER_DAMAGE_RICH instead of legacy
                    // PlayerDamage packet. Receiver-side ZdoEvents.OnPlayerDamageRich
                    // calls PlayerDamageSync.ApplyFromZdo.
                    if (ZdoFeatureFlags.UseZdoForEvents)
                    {
                        try { ZdoEvents.SendPlayerDamage(-1, delta, dmgPos, Vector3.up, lethal); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] dmg zdo: {ex.Message}"); }
                    }
                    else
                    {
                        try
                        {
                            Sync.PlayerDamageSync.BroadcastDamage(
                                attackerHumanId: -1,
                                amount:          delta,
                                hitPosition:     dmgPos,
                                hitDirection:    Vector3.up,
                                isLethal:        lethal);
                        }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] dmg broadcast: {ex.Message}"); }
                    }
                    _lastHealth = curHealth;
                }
                else if (curHealth > _lastHealth)
                {
                    _lastHealth = curHealth;     // healed — refresh baseline silently
                }
            }
            catch { /* currentHealth getter may throw mid-init */ }

            // Apartment-ownership diff. Each peer broadcasts its own
            // additions / removals so the union ends up on every peer's
            // Player.Instance.apartmentsOwned (coop treats apartments as
            // shared — anyone can use any owned address). On the very first
            // tick we just baseline without broadcasting.
            try
            {
                var owned = p.apartmentsOwned;
                var curIds = new System.Collections.Generic.HashSet<int>();
                if (owned != null)
                {
                    for (int i = 0; i < owned.Count; i++)
                    {
                        var a = owned[i];
                        if (a == null) continue;
                        try { if (a.id > 0) curIds.Add(a.id); } catch { }
                    }
                }

                if (!_apartmentsInitialized)
                {
                    _apartmentsInitialized = true;
                    _lastApartmentIds.Clear();
                    foreach (var id in curIds) _lastApartmentIds.Add(id);
                }
                else
                {
                    // New entries — broadcast adds.
                    foreach (var id in curIds)
                    {
                        if (_lastApartmentIds.Contains(id)) continue;
                        try { ZdoEvents.SendApartmentOwned(id, added: true); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] apt add: {ex.Message}"); }
                    }
                    // Removed entries — broadcast removes.
                    foreach (var id in _lastApartmentIds)
                    {
                        if (curIds.Contains(id)) continue;
                        try { ZdoEvents.SendApartmentOwned(id, added: false); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] apt remove: {ex.Message}"); }
                    }

                    _lastApartmentIds.Clear();
                    foreach (var id in curIds) _lastApartmentIds.Add(id);
                }
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] apartments diff: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] tick: {ex.Message}"); }
    }
}
