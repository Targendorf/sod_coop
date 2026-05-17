using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side side-job lifecycle diff: 1 Hz over
/// <c>SideJobController.Instance.allJobsDictionary</c>.
///
/// Tracks <c>(jobID → JobState byte)</c>; on flip re-broadcasts via the
/// existing <see cref="Sync.SideJobSync.BroadcastStateChange"/> path. Newly-
/// appearing jobs (not present in the previous tick) re-broadcast via
/// <see cref="Sync.SideJobSync.BroadcastFromCtor"/>.
///
/// <para>Replaces the disabled patches at:
/// <list type="bullet">
///   <item><c>SideJob..ctor</c> — caught here as a "new entry in dict" event.</item>
///   <item><c>SideJob.SetJobState</c> — caught here as a state-flip diff.</item>
/// </list>
/// </para>
///
/// <para>Player-call (accept) and Rewarded events stay event-based via
/// <see cref="ZdoEvents.SIDE_JOB_PLAYER_CALL"/> /
/// <see cref="ZdoEvents.SIDE_JOB_REWARDED"/> — those are one-shot
/// transitions that don't have a clean stable poll-state anchor.</para>
/// </summary>
public static class SideJobPoller
{
    public const float TICK_HZ = 1f;
    public const string NAME   = "side-jobs";

    private static readonly Dictionary<int, byte> _last = new();
    private static bool _initialized;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _initialized = false;
        _last.Clear();
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForSideJobs) return;
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
            var ctrl = global::SideJobController.Instance;
            if (ctrl == null) return;
            var dict = ctrl.allJobsDictionary;
            if (dict == null) return;

            // Baseline: just snapshot, no broadcast.
            if (!_initialized)
            {
                _initialized = true;
                _last.Clear();
                foreach (var kv in dict)
                {
                    var j = kv.Value;
                    if (j == null) continue;
                    _last[j.jobID] = (byte)j.state;
                }
                return;
            }

            foreach (var kv in dict)
            {
                var j = kv.Value;
                if (j == null) continue;
                int  id     = j.jobID;
                byte curSt  = (byte)j.state;

                if (!_last.TryGetValue(id, out byte prev))
                {
                    // New job since last tick.
                    _last[id] = curSt;
                    try { Sync.SideJobSync.BroadcastFromCtor(j); }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[SideJobPoller] new ctor: {ex.Message}"); }
                    continue;
                }

                if (prev != curSt)
                {
                    _last[id] = curSt;
                    try { Sync.SideJobSync.BroadcastStateChange(j, j.state); }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[SideJobPoller] state change: {ex.Message}"); }
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SideJobPoller] tick: {ex.Message}"); }
    }
}
