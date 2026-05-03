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
    public const float TICK_HZ = 1f;
    public const string NAME = "local-player";

    /// <summary>Below this delta, ignore — SoD's bleed tick can write tiny
    /// fractional drops every frame which we don't want to broadcast.</summary>
    private const float DAMAGE_EPSILON = 1f;

    private static bool  _healthInitialized;
    private static float _lastHealth;

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
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForPlayerState) return;
        try
        {
            var p = global::Player.Instance;
            if (p == null) return;
            if (NetworkManager.LocalPlayerId < 0) return;

            int sodId = NetworkManager.LocalPlayerId;
            var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.LocalPlayer, sodId,
                owner: ZdoMan.LocalPeerUid, persistent: false);

            try { z.Set(ZdoKeys.Pos, p.transform.position); } catch { }
            try { z.Set(ZdoKeys.Rot, p.transform.rotation); } catch { }

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
                    Vector3 pos = Vector3.zero;
                    try { if (p.transform != null) pos = p.transform.position; } catch { }

                    // Phase G.5 (Wave 1.6): unified RPC via
                    // ZdoEventDispatcher.PLAYER_DAMAGE_RICH instead of legacy
                    // PlayerDamage packet. Receiver-side ZdoEvents.OnPlayerDamageRich
                    // calls PlayerDamageSync.ApplyFromZdo.
                    if (ZdoFeatureFlags.UseZdoForEvents)
                    {
                        try { ZdoEvents.SendPlayerDamage(-1, delta, pos, Vector3.up, lethal); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] dmg zdo: {ex.Message}"); }
                    }
                    else
                    {
                        try
                        {
                            Sync.PlayerDamageSync.BroadcastDamage(
                                attackerHumanId: -1,
                                amount:          delta,
                                hitPosition:     pos,
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
