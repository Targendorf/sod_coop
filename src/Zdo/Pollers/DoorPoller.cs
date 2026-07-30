using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side 10 Hz diff over <c>CityData.Instance.doorDictionary</c> →
/// writes <c>(closed, locked)</c> keys to the matching <see cref="ZdoTypeTag.Door"/>
/// ZDO. Replaces the disabled hot-path patches at
/// <c>src/Patches/GamePatches.cs:26</c> (<c>NewDoor.OnOpen</c>),
/// <c>src/Patches/GamePatches.cs:48</c> (<c>NewDoor.OnClose</c>), and
/// the lock state currently routed through
/// <c>WorldStateSync.BroadcastDoorLockState</c>.
///
/// <para><b>Performance</b>: the previous implementation enumerated the live
/// Il2Cpp <c>doorDictionary</c> every tick and re-dereferenced
/// <c>door.doorInteractable.id</c> per door per tick. Iterating an Il2Cpp
/// dictionary is itself a per-element native call, and the city has hundreds
/// of doors. We now cache parallel (id, door) arrays and only rebuild them
/// when the dictionary's <c>Count</c> changes (doors are added/removed
/// rarely — building access, new tenants). The per-tick loop then reads two
/// managed-list slots + two field derefs (<c>isClosed</c>, <c>isLocked</c>)
/// per door, no dictionary enumeration. Same pattern as
/// <see cref="LightPoller"/>.</para>
/// </summary>
public static class DoorPoller
{
    public const float TICK_HZ = 10f;
    public const string NAME = "doors";

    /// <summary>Cached (id, door) pairs as parallel lists. Rebuilt whenever
    /// <see cref="_cachedCount"/> diverges from the live dictionary count.</summary>
    private static readonly List<int> _doorIds = new();
    private static readonly List<NewDoor> _doors = new();

    /// <summary>doorDictionary.Count at the last cache (re)build. -1 forces a
    /// rebuild on the first tick.</summary>
    private static int _cachedCount = -1;

    /// <summary>Doors examined per tick by the reconciliation sweep. At 10 Hz,
    /// 256/tick covers a few thousand doors every ~1-2 s at a fraction of the
    /// interop cost of walking the whole cache each tick.</summary>
    private const int SWEEP_PER_TICK = 256;
    private static int _sweepCursor;

    public static void Register()
    {
        ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);
    }

    /// <summary>Drop the cache on world unload — doors get destroyed when SoD
    /// reloads / returns-to-menu, and a stale cache would write to dead
    /// components. Cache rebuilds on the first post-load tick.</summary>
    public static void ResetBaseline()
    {
        _doorIds.Clear();
        _doors.Clear();
        _cachedCount = -1;
        _sweepCursor = 0;
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForDoors) return;
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
            var dict = CityData.Instance?.doorDictionary;
            if (dict == null) return;

            // Rebuild only when door membership changes (rare: building access,
            // new tenants). The common path skips the Il2Cpp dictionary
            // enumeration entirely and iterates the cached managed lists.
            if (dict.Count != _cachedCount)
            {
                _doorIds.Clear();
                _doors.Clear();
                foreach (var kv in dict)
                {
                    var d = kv.Value;
                    if (d == null) continue;
                    var di = d.doorInteractable;
                    if (di == null) continue;
                    _doorIds.Add(di.id);
                    _doors.Add(d);
                }
                _cachedCount = dict.Count;
            }

            // ── Amortized reconciliation sweep ────────────────────────────
            // Walk only SWEEP_PER_TICK doors per tick, wrapping around, rather
            // than the whole cache. A SoD city has thousands of doors and the
            // old loop read isClosed + isLocked + a null check on every one at
            // 10 Hz — tens of thousands of IL2CPP calls per tick on the host
            // main thread, which is the class of cost that held pollers at
            // 700-1600 ms/frame (playtest 2026-06-23).
            //
            // Real-time response does not depend on this loop: NewDoor.OnOpen,
            // OnClose and SetLocked are all Harmony-patched and broadcast the
            // instant they fire, whoever opened the door. The sweep only has to
            // guarantee eventual convergence for state a patch could have
            // missed (patch paused during load, or a path that bypasses the
            // setters), so full coverage every few seconds is ample.
            int doorSweep = Math.Min(SWEEP_PER_TICK, _doors.Count);
            for (int n = 0; n < doorSweep; n++)
            {
                if (_sweepCursor >= _doors.Count) _sweepCursor = 0;
                int i = _sweepCursor++;

                var door = _doors[i];
                if (door == null) continue; // Unity destroyed — rebuild picks it up on next count change.
                int id = _doorIds[i];

                Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Door, id, owner: ZdoMan.LocalPeerUid, persistent: true);
                // Static position — stamp once for sector-cull.
                if (!z.HasHostPosition)
                {
                    try
                    {
                        var inter = door.doorInteractable;
                        if (inter != null) ZdoMan.NotifyZdoPosition(z, inter.wPos);
                    }
                    catch { }
                }
                z.Set(ZdoKeys.Closed, door.isClosed);
                z.Set(ZdoKeys.Locked, door.isLocked);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[DoorPoller] tick: {ex.Message}"); }
    }
}
