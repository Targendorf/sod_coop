using System;
using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side NPC-damage diff: 5 Hz over <c>CityData.Instance.citizenDictionary</c>.
/// Tracks <c>(humanID → currentHealth)</c>; on a downward step
/// (oldHealth - newHealth &gt; <see cref="DAMAGE_EPSILON"/>) re-emits a damage
/// event via the existing <see cref="Sync.DamageSync.BroadcastDamage"/> path.
///
/// <para>Replaces the still-active patch at
/// <c>Actor.RecieveDamage</c> for the NPC case (player damage is
/// intentionally never synced — see DamageSync.cs class doc).</para>
///
/// <para><b>Field verification</b> (Assembly-CSharp_Dump/Actor.cs):
/// <c>Actor.currentHealth</c> float at line 1701, <c>maximumHealth</c> at 1714.</para>
///
/// <para><b>Data degradation</b> (acceptable per migration plan §5):
/// the original RecieveDamage carries (attacker, hitPos/Dir, spatter
/// presets, ragdoll, shockMP, enableKill, allowRecoil, ragdollForceMP).
/// The poll only knows victim and amount-of-loss. We re-emit with
/// sentinels:
/// <list type="bullet">
///   <item>attacker = -1 (unknown)</item>
///   <item>hitPos = victim.transform.position; hitDir = (0, 1, 0)</item>
///   <item>spatter presets = null (DamageSync's ResolveSpatterPreset returns null gracefully)</item>
///   <item>forceRagdoll = false; allowRecoil = true; shockMP = 1f; ragdollForceMP = 1f</item>
///   <item>enableKill = (currentHealth &lt;= 0) — capture the killing blow</item>
/// </list>
/// Visual fidelity (precise blood spatter, ragdoll force) is reduced;
/// gameplay (NPC takes damage / dies) is preserved.</para>
///
/// <para>Heal events (health going up) are intentionally ignored — SoD
/// applies them deterministically from save-state, no player-action
/// sync needed.</para>
/// </summary>
public static class NpcDamagePoller
{
    public const float TICK_HZ = 5f;
    public const string NAME   = "npc-damage";

    /// <summary>Below this delta, ignore — SoD's bleed tick can write 0.0001
    /// drops every frame which we don't want to broadcast.</summary>
    private const float DAMAGE_EPSILON = 0.5f;

    private static readonly Dictionary<int, float> _last = new();
    private static bool _initialized;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick, WarmupBaseline);

    public static void ResetBaseline()
    {
        _initialized = false;
        _last.Clear();
    }

    /// <summary>Force the next real tick to re-snapshot health without
    /// broadcasting. Wired through <see cref="ZdoPollerHost"/> on every
    /// HasPeers gain so a reconnecting joiner doesn't trigger phantom
    /// damage events for any health drift since the prior session's
    /// baseline.</summary>
    public static void WarmupBaseline() => ResetBaseline();

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForNpcDamage) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            // Baseline pass: snapshot, no broadcast (avoids re-emitting
            // every saved citizen's prior-session damage on first tick).
            if (!_initialized)
            {
                _initialized = true;
                _last.Clear();
                foreach (var kv in dict)
                {
                    var c = kv.Value;
                    if (c == null) continue;
                    _last[c.humanID] = c.currentHealth;
                }
                return;
            }

            foreach (var kv in dict)
            {
                var c = kv.Value;
                if (c == null) continue;
                int   id  = c.humanID;
                float cur = c.currentHealth;

                if (!_last.TryGetValue(id, out float prev))
                {
                    _last[id] = cur;
                    continue;
                }

                float delta = prev - cur;
                if (delta <= DAMAGE_EPSILON)
                {
                    // Health up or unchanged or trivial drop. Refresh baseline
                    // anyway so a long heal back doesn't leak old values.
                    _last[id] = cur;
                    continue;
                }

                _last[id] = cur;

                Vector3 pos = Vector3.zero;
                try { if (c.transform != null) pos = c.transform.position; } catch { }

                // Phase G.5 (Wave 2.2): unified RPC channel via
                // ZdoEvents.NPC_DAMAGE_RICH instead of legacy NpcDamage packet.
                if (ZdoFeatureFlags.UseZdoForEvents)
                {
                    try { ZdoEvents.SendNpcDamage(id, -1, delta, pos, Vector3.up, enableKill: cur <= 0f); }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[NpcDamagePoller] zdo: {ex.Message}"); }
                }
                else
                {
                    try
                    {
                        Sync.DamageSync.BroadcastDamage(
                            victimHumanId:    id,
                            attackerHumanId:  -1,
                            amount:           delta,
                            hitPosition:      pos,
                            hitDirection:     Vector3.up,
                            forwardSpatter:   null,
                            backSpatter:      null,
                            eraseMode:        SpatterSimulation.EraseMode.useDespawnTime,
                            forceRagdoll:     false,
                            ragdollDuration:  0f,
                            shockMP:          1f,
                            enableKill:       cur <= 0f,
                            allowRecoil:      true,
                            ragdollForceMP:   1f);
                    }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[NpcDamagePoller] broadcast: {ex.Message}"); }
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[NpcDamagePoller] tick: {ex.Message}"); }
    }
}
