using System.Collections.Generic;
using SoDCoop.Zdo.Pollers;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Door interactable id → <c>NewDoor</c>, plus a position index of every door.
///
/// <para><b>Why:</b> every door ZDO apply (<c>DoorResolver</c> →
/// <c>WorldStateSync.ApplyDoorState</c>) found its door by enumerating the whole
/// IL2CPP <c>doorDictionary</c> — thousands of per-element native calls for
/// ONE door. On a join the client queues the resolver for every door ZDO in the
/// snapshot (the host keeps one per door, thousands), so the catch-up did
/// thousands × thousands of calls, 1 500 applies per frame: seconds-long frames
/// exactly as the player spawns in. This map makes each lookup O(1), and is
/// rebuilt only when the dictionary's size changes (or the world reloads).</para>
/// </summary>
internal static class DoorLookup
{
    private static readonly Dictionary<int, NewDoor> _byInteractableId = new();
    private static readonly List<NewDoor> _doors = new();
    private static readonly List<int> _ids = new();
    private static readonly List<Vector3> _pos = new();
    private static readonly StaticSpatialIndex _index = new();
    private static int _cachedCount = -1;

    /// <summary>A miss on a door that should exist forces one rebuild, at most
    /// this often — a stale map (a door replaced without a count change) heals,
    /// while a ZDO for a door this world simply doesn't have can't trigger a
    /// full enumeration on every apply.</summary>
    private const float MISS_REBUILD_INTERVAL_S = 5f;
    private static float _nextMissRebuildAt;

    public static int Count => _doors.Count;

    public static void Reset()
    {
        _byInteractableId.Clear();
        _doors.Clear();
        _ids.Clear();
        _pos.Clear();
        _index.Clear();
        _cachedCount = -1;
        _nextMissRebuildAt = 0f;
    }

    /// <summary>Rebuild if the live dictionary's size changed. Returns false when
    /// there is no city.</summary>
    public static bool Refresh()
    {
        Il2CppSystem.Collections.Generic.Dictionary<int, NewDoor> dict;
        try { dict = CityData.Instance?.doorDictionary; } catch { return false; }
        if (dict == null) return false;
        int count;
        try { count = dict.Count; } catch { return false; }
        if (count != _cachedCount) Rebuild(dict, count);
        return true;
    }

    private static void Rebuild(Il2CppSystem.Collections.Generic.Dictionary<int, NewDoor> dict, int count)
    {
        _byInteractableId.Clear();
        _doors.Clear();
        _ids.Clear();
        _pos.Clear();
        _index.Clear();
        try
        {
            foreach (var kv in dict)
            {
                var d = kv.Value;
                if (d == null) continue;
                Interactable di;
                try { di = d.doorInteractable; } catch { continue; }
                if (di == null) continue;
                int id = di.id;
                Vector3 pos;
                try { pos = di.wPos; } catch { pos = new Vector3(float.NaN, float.NaN, float.NaN); }
                _byInteractableId[id] = d;
                _doors.Add(d);
                _ids.Add(id);
                _pos.Add(pos);
                _index.Add(_doors.Count - 1, pos);
            }
        }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"[DoorLookup] rebuild: {ex.Message}"); }
        _cachedCount = count;
    }

    /// <summary>The door whose <c>doorInteractable.id</c> is
    /// <paramref name="interactableId"/>, or null.</summary>
    public static NewDoor Find(int interactableId)
    {
        if (!Refresh()) return null;
        if (_byInteractableId.TryGetValue(interactableId, out var d) && d != null) return d;

        float now = Time.unscaledTime;
        if (now >= _nextMissRebuildAt)
        {
            _nextMissRebuildAt = now + MISS_REBUILD_INTERVAL_S;
            try
            {
                var dict = CityData.Instance?.doorDictionary;
                if (dict != null) Rebuild(dict, dict.Count);
            }
            catch { }
            if (_byInteractableId.TryGetValue(interactableId, out d) && d != null) return d;
        }
        return null;
    }

    public static bool IsDoorInteractable(int interactableId)
        => _byInteractableId.ContainsKey(interactableId);

    /// <summary>Door list indices within <paramref name="radius"/> of
    /// <paramref name="center"/>.</summary>
    public static void Query(Vector3 center, float radius, List<int> results, HashSet<int> seen,
                             float maxDy = float.PositiveInfinity)
    {
        if (!Refresh()) return;
        _index.Query(center, radius, results, seen, maxDy);
    }

    public static NewDoor DoorAt(int listIdx) => listIdx >= 0 && listIdx < _doors.Count ? _doors[listIdx] : null;
    public static int IdAt(int listIdx) => listIdx >= 0 && listIdx < _ids.Count ? _ids[listIdx] : 0;
    public static Vector3 PosAt(int listIdx) => listIdx >= 0 && listIdx < _pos.Count ? _pos[listIdx] : default;
}
