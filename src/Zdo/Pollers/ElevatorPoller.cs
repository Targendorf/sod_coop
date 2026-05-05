using System;
using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side elevator-call diff: 5 Hz over <c>SessionData.Instance.activeElevators</c>.
/// Tracks per-elevator <c>(buildingID, bottomTileCoord) → totalCallsCount</c>.
/// When the count grows we walk the <c>Elevator.calls</c> dictionary and
/// re-broadcast the most recent call entry via the existing
/// <see cref="Sync.ElevatorSync.BroadcastCall"/> transport.
///
/// <para>Why count-diff rather than diff-the-dictionary: SoD's
/// <c>calls Dictionary&lt;int, List&lt;ElevatorCall&gt;&gt;</c> is structured
/// per-floor, and individual entries are timestamped + consumed by SoD's own
/// elevator AI. We don't need to mirror the whole list — we only need to
/// notice "a new call just happened" and re-issue the same trigger. Repeat
/// calls of the same (floor, up) are idempotent on the receiver
/// (Elevator.CallElevator dedup).</para>
///
/// <para>Replaces the disabled
/// <c>Elevator.CallElevator</c> Harmony patch.</para>
/// </summary>
public static class ElevatorPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME   = "elevators";

    private struct Key
    {
        public int       BuildingId;
        public Vector3Int Bottom;

        public override int GetHashCode()
            => unchecked(BuildingId * 397 ^ Bottom.GetHashCode());
        public override bool Equals(object o)
            => o is Key k && k.BuildingId == BuildingId && k.Bottom == Bottom;
    }

    private static readonly Dictionary<Key, int> _lastTotal = new();
    private static bool _initialized;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _initialized = false;
        _lastTotal.Clear();
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForElevators) return;
        try
        {
            var list = SessionData.Instance?.activeElevators;
            if (list == null) return;

            for (int i = 0; i < list.Count; i++)
            {
                var e = list[i];
                if (e == null || e.building == null || e.bottom == null) continue;
                if (e.calls == null) continue;

                int total = SumCalls(e.calls);
                var k = new Key { BuildingId = e.building.buildingID, Bottom = e.bottom.globalTileCoord };

                if (!_lastTotal.TryGetValue(k, out int prev))
                {
                    _lastTotal[k] = total;
                    continue;     // baseline
                }

                if (total <= prev)
                {
                    _lastTotal[k] = total;
                    continue;
                }

                // Count grew — find the newest call entry and re-broadcast it.
                _lastTotal[k] = total;
                if (!_initialized) continue;     // skip the very first growth across all elevators
                BroadcastLatest(e);
            }

            _initialized = true;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ElevatorPoller] tick: {ex.Message}"); }
    }

    private static int SumCalls(Il2CppSystem.Collections.Generic.Dictionary<int, Il2CppSystem.Collections.Generic.List<Elevator.ElevatorCall>> calls)
    {
        int total = 0;
        try
        {
            foreach (var kv in calls)
            {
                var l = kv.Value;
                if (l != null) total += l.Count;
            }
        }
        catch { }
        return total;
    }

    private static void BroadcastLatest(Elevator e)
    {
        try
        {
            // Find the most-recently-added call. SoD doesn't timestamp them
            // on the public surface; "newest" here = last entry of last list.
            int newestFloor = -1;
            bool newestUp   = true;
            foreach (var kv in e.calls)
            {
                var l = kv.Value;
                if (l == null || l.Count == 0) continue;
                var last = l[l.Count - 1];
                if (last == null) continue;
                newestFloor = kv.Key;
                newestUp    = last.callUp;
            }

            if (newestFloor < 0) return;
            // Phase G.5 (Wave 2.4): unified RPC channel via
            // ZdoEventDispatcher.ELEVATOR_CALL. Receiver applies via
            // ElevatorSync.ApplyCallFromZdo.
            if (ZdoFeatureFlags.UseZdoForEvents)
            {
                try { ZdoEvents.SendElevatorCall(e.building.buildingID, e.bottom.globalTileCoord, newestFloor, newestUp); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[ElevatorPoller] zdo: {ex.Message}"); }
            }
            else
            {
                Sync.ElevatorSync.BroadcastCall(e, newestFloor, newestUp);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ElevatorPoller] broadcast: {ex.Message}"); }
    }
}
