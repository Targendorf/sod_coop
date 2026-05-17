using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-only. Polls every loaded citizen at 5 Hz for their two animation
/// state enums — <c>idleAnimationState</c> (sitting / sweeping / phone /
/// dancing / cooking / etc., 17 values) and <c>armsBoolAnimationState</c>
/// (resting / typing / smoking / reading / etc., 12 values) — and ships a
/// <see cref="ZdoEvents.CITIZEN_ANIM_STATE"/> event to clients only when
/// either changes for that citizen.
///
/// <para>Without this, client peers see SoD's procedural NPCs walking the
/// city in idle pose only — the host's local AI sets per-citizen idle
/// states that drive the dancing / cooking / phone-talking animations,
/// but those state writes never reach the client. The poller closes that
/// gap with O(diff) bandwidth: typical city tick churn is a handful of
/// state transitions per second across 300 citizens, not the full snapshot.</para>
///
/// <para><b>Field verification</b> (Assembly-CSharp_Dump):
/// <list type="bullet">
///   <item><c>Actor.animationController : CitizenAnimationController</c> (Actor.cs:1536)</item>
///   <item><c>CitizenAnimationController.idleAnimationState : IdleAnimationState</c> (1908)</item>
///   <item><c>CitizenAnimationController.armsBoolAnimationState : ArmsBoolSate</c> (1895)</item>
///   <item><c>SetIdleAnimationState(IdleAnimationState)</c> (2527) — receiver-side apply</item>
///   <item><c>SetArmsBoolState(ArmsBoolSate)</c> (2443) — receiver-side apply</item>
/// </list></para>
/// </summary>
public static class CitizenAnimationPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "citizen-anim";

    /// <summary>Last-broadcast (idle, arms) per citizen. Diff vs current
    /// tick → only changed pairs hit the wire.</summary>
    private static readonly Dictionary<int, (byte idle, byte arms)> _last = new();

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick, WarmupBaseline);

    /// <summary>Pre-seed <see cref="_last"/> with every citizen's current
    /// (idle, arms) state without broadcasting. Called by
    /// <see cref="ZdoPollerHost"/> on the first tick after a peer connects
    /// so the post-warmup tick sees a stable baseline and only emits
    /// genuine post-connect transitions. Without this, the first real tick
    /// would treat all 300+ citizens as "everything looks new" and flood
    /// the event channel with state the snapshot already delivered.</summary>
    public static void WarmupBaseline()
    {
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            int count = 0;
            foreach (var kv in dict)
            {
                var c = kv.Value;
                if (c == null) continue;
                int id = c.humanID;
                if (id == 0) continue;
                global::CitizenAnimationController ac;
                try { ac = c.animationController; } catch { continue; }
                if (ac == null) continue;
                byte idle, arms;
                try { idle = (byte)ac.idleAnimationState; }     catch { continue; }
                try { arms = (byte)ac.armsBoolAnimationState; } catch { continue; }
                _last[id] = (idle, arms);
                count++;
            }
            if (count > 0)
                Plugin.Log.LogDebug($"[CitizenAnimationPoller] warmup: pre-seeded {count} citizen anim baselines (no broadcast)");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenAnimationPoller] warmup: {ex.Message}"); }
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        if (!SoDCoop.Network.NetworkManager.IsHost) return;
        if (!SoDCoop.Network.NetworkManager.HasPeers) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag / IsHost / HasPeers gates so the field-drift
    /// probe exercises the real SoD-field-deref path even on a solo host.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    /// <summary>Soft per-tick send cap. Caps the broadcast burst on cold-start
    /// (when <see cref="_last"/> is empty or stale and the diff would otherwise
    /// emit 200-300 events in one frame). Real per-tick churn in an idle city
    /// is single digits, so this only kicks in during the recovery scenario.
    /// Excess deltas update <see cref="_last"/> silently — they'll be picked
    /// up by the next snapshot cursor or simply on the citizen's next real
    /// state change.</summary>
    private const int MAX_SENT_PER_TICK = 32;

    private static void TickInner(float now)
    {
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            // Cold-start guard: if WarmupBaseline never ran (or got Reset between
            // ticks) the diff loop would treat the entire roster as fresh and
            // emit one event per citizen. Detect this by checking _last vs dict
            // size — when the baseline is grossly under-populated, fall back to
            // a silent reseed and skip the broadcast pass for this tick.
            int dictCount = dict.Count;
            if (dictCount > 0 && _last.Count < dictCount / 2)
            {
                int reseed = 0;
                foreach (var kv in dict)
                {
                    var cc = kv.Value;
                    if (cc == null) continue;
                    int cid = cc.humanID;
                    if (cid == 0) continue;
                    global::CitizenAnimationController cac;
                    try { cac = cc.animationController; } catch { continue; }
                    if (cac == null) continue;
                    byte cidle, carms;
                    try { cidle = (byte)cac.idleAnimationState; }     catch { continue; }
                    try { carms = (byte)cac.armsBoolAnimationState; } catch { continue; }
                    _last[cid] = (cidle, carms);
                    reseed++;
                }
                Plugin.Log.LogDebug($"[CitizenAnimationPoller] cold-start reseed: filled baseline with {reseed} citizens (no broadcast).");
                return;
            }

            int sent = 0;
            int suppressed = 0;
            foreach (var kv in dict)
            {
                var c = kv.Value;
                if (c == null) continue;
                int id = c.humanID;
                if (id == 0) continue;

                global::CitizenAnimationController ac;
                try { ac = c.animationController; } catch { continue; }
                if (ac == null) continue;

                byte idle, arms;
                try { idle = (byte)ac.idleAnimationState; }       catch { continue; }
                try { arms = (byte)ac.armsBoolAnimationState; }   catch { continue; }

                if (_last.TryGetValue(id, out var prev) && prev.idle == idle && prev.arms == arms)
                    continue;

                _last[id] = (idle, arms);

                if (sent >= MAX_SENT_PER_TICK)
                {
                    // Update baseline silently — don't burst more than the cap.
                    // Receiver will see the new state on the citizen's next real
                    // transition or on next late-joiner snapshot.
                    suppressed++;
                    continue;
                }

                try
                {
                    SoDCoop.Zdo.ZdoEvents.SendCitizenAnimState(id, idle, arms);
                    sent++;
                }
                catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenAnimationPoller] send {id}: {ex.Message}"); }
            }

            // Light per-tick log only when there's actual churn — typical
            // idle city dictates this is mostly zero.
            if (sent > 0 || suppressed > 0)
                Plugin.Log.LogDebug($"[CitizenAnimationPoller] tick: {sent} anim-state delta(s){(suppressed > 0 ? $", {suppressed} suppressed (cap)" : "")}");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenAnimationPoller] tick: {ex.Message}"); }
    }

    /// <summary>Drop the diff baseline so the next post-load tick treats
    /// every citizen as freshly-discovered (forces a full re-broadcast).
    /// Called after world reset / save reload.</summary>
    public static void ResetBaseline() => _last.Clear();
}
