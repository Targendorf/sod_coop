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
///
/// <para><b>Runs on every peer (2026-09-29).</b> It used to be host-only, so a
/// CLIENT pressing a lift button called the lift on the client alone: the host's
/// car never came, and from then on the two cars ran different schedules. On a
/// client it now watches only the lifts next to the local player — inside the
/// frozen, host-driven radius, where the player is the only one pressing
/// buttons — and a call the host sent us is rebaselined by
/// <see cref="NotifyRemoteCall"/> so it is not echoed back.</para>
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

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    /// <summary>Client: horizontal distance from the lift shaft within which
    /// the local player can be the one pressing its buttons.</summary>
    private const float CLIENT_WATCH_RADIUS_M = 12f;

    /// <summary>A call arriving from another machine was just applied to
    /// <paramref name="e"/>: take its new count as the baseline so this
    /// machine doesn't report it as its own.</summary>
    public static void NotifyRemoteCall(Elevator e)
    {
        try
        {
            if (e == null || e.building == null || e.bottom == null || e.calls == null) return;
            var k = new Key { BuildingId = e.building.buildingID, Bottom = e.bottom.globalTileCoord };
            _lastTotal[k] = SumCalls(e.calls);
        }
        catch { }
    }

    public static void ResetBaseline()
    {
        _initialized = false;
        _lastTotal.Clear();
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForElevators) return;
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
            var list = SessionData.Instance?.activeElevators;
            if (list == null) return;

            bool isHost = Network.NetworkManager.IsHost;
            Vector3 me = default;
            if (!isHost)
            {
                try
                {
                    var p = global::Player.Instance;
                    if (p == null) return;
                    me = p.transform.position;
                }
                catch { return; }
            }

            for (int i = 0; i < list.Count; i++)
            {
                var e = list[i];
                if (e == null || e.building == null || e.bottom == null) continue;
                if (e.calls == null) continue;

                if (!isHost)
                {
                    // Only lifts beside us; a far one is being called by this
                    // machine's own citizens, which the host must not hear.
                    Vector3 shaft;
                    try { var so = e.spawnedObject; if (so == null) continue; shaft = so.position; }
                    catch { continue; }
                    float dx = shaft.x - me.x, dz = shaft.z - me.z;
                    if (dx * dx + dz * dz > CLIENT_WATCH_RADIUS_M * CLIENT_WATCH_RADIUS_M)
                    {
                        // Keep the baseline current so walking up to a lift
                        // doesn't read its old calls as new.
                        var kf = new Key { BuildingId = e.building.buildingID, Bottom = e.bottom.globalTileCoord };
                        _lastTotal[kf] = SumCalls(e.calls);
                        continue;
                    }
                }

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
