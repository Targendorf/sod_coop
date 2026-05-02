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

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _healthInitialized = false;
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

            try { z.Set(ZdoKeys.Trespassing,         p.isTrespassing);          } catch { }
            try { z.Set(ZdoKeys.IllegalActionActive, p.illegalActionActive);    } catch { }
            try { z.Set(ZdoKeys.IllegalAreaActive,   p.illegalAreaActive);      } catch { }
            try { z.Set(ZdoKeys.IllegalStatus,       (byte)(p.illegalStatus ? 1 : 0)); } catch { }
            try { z.Set(ZdoKeys.Escalation,          p.trespassingEscalation);  } catch { }

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
                    _lastHealth = curHealth;
                }
                else if (curHealth > _lastHealth)
                {
                    _lastHealth = curHealth;     // healed — refresh baseline silently
                }
            }
            catch { /* currentHealth getter may throw mid-init */ }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerPoller] tick: {ex.Message}"); }
    }
}
