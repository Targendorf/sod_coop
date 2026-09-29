using System.Collections.Generic;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Cell-bucketed index over the STATIC objects in a poller's cache — doors,
/// lights, switch-bearing interactables, print-bearing interactables — keyed by
/// their index in that cache.
///
/// <para><b>Why:</b> those pollers used to walk their whole cache every tick,
/// tens of thousands of IL2CPP reads on the host main thread, which is what held
/// the host at a few FPS. They were cut down to a bounded wrapping sweep — right
/// for cost, but it made the sweep the ONLY path for these objects: the Harmony
/// patches that would have reported a door opening or a light switching the
/// moment it happened (NewDoor.OnOpen/OnClose/SetLocked, LightController.SetOn,
/// Interactable.SetSwitchState/AddNewDynamicFingerprint) are all disabled, since
/// NPCs trigger them constantly. A door a player opened could take a second or
/// more to open on the other machine, and a drawer opened for the first time up
/// to several seconds.</para>
///
/// <para>This index lets each poller check everything near ANY player every
/// tick — where a delay is actually visible — while the wrapping sweep keeps the
/// rest of the city converging. The objects never move, so each is indexed once
/// when it enters the cache.</para>
/// </summary>
internal sealed class StaticSpatialIndex
{
    private const float CELL_M = 32f;
    private const float INV_CELL = 1f / CELL_M;

    private readonly Dictionary<long, List<(int idx, Vector3 pos)>> _cells = new();

    public int Count { get; private set; }

    public void Clear()
    {
        _cells.Clear();
        Count = 0;
    }

    /// <summary>Index cache entry <paramref name="index"/> at <paramref name="pos"/>.
    /// Non-finite positions are ignored — the object still converges through the
    /// wrapping sweep.</summary>
    public void Add(int index, Vector3 pos)
    {
        if (!float.IsFinite(pos.x) || !float.IsFinite(pos.z)) return;
        long key = Key(FloorToInt(pos.x * INV_CELL), FloorToInt(pos.z * INV_CELL));
        if (!_cells.TryGetValue(key, out var list))
        {
            list = new List<(int, Vector3)>();
            _cells[key] = list;
        }
        list.Add((index, pos));
        Count++;
    }

    /// <summary>Append the cache indices within <paramref name="radius"/>
    /// (horizontal plane) of <paramref name="center"/> to <paramref name="results"/>,
    /// skipping any already in <paramref name="seen"/> — so several players
    /// standing in the same area don't cause the same object to be read twice.
    ///
    /// <para><paramref name="maxDy"/> bounds the vertical distance. The cells
    /// are horizontal, so without it a query inside a tower returns every floor
    /// stacked above and below — thousands of objects the player cannot see or
    /// reach, each costing IL2CPP reads in the caller. The check is on the
    /// position stored here, so filtering is free.</para></summary>
    public void Query(Vector3 center, float radius, List<int> results, HashSet<int> seen,
                      float maxDy = float.PositiveInfinity)
    {
        if (_cells.Count == 0 || radius <= 0f) return;
        if (!float.IsFinite(center.x) || !float.IsFinite(center.z)) return;

        int minX = FloorToInt((center.x - radius) * INV_CELL);
        int maxX = FloorToInt((center.x + radius) * INV_CELL);
        int minZ = FloorToInt((center.z - radius) * INV_CELL);
        int maxZ = FloorToInt((center.z + radius) * INV_CELL);
        float r2 = radius * radius;

        for (int cx = minX; cx <= maxX; cx++)
        {
            for (int cz = minZ; cz <= maxZ; cz++)
            {
                if (!_cells.TryGetValue(Key(cx, cz), out var list)) continue;
                for (int i = 0; i < list.Count; i++)
                {
                    var e = list[i];
                    float dx = e.pos.x - center.x;
                    float dz = e.pos.z - center.z;
                    if (dx * dx + dz * dz > r2) continue;
                    if (Mathf.Abs(e.pos.y - center.y) > maxDy) continue;
                    if (seen.Add(e.idx)) results.Add(e.idx);
                }
            }
        }
    }

    private static long Key(int cx, int cz) => ((long)cx << 32) ^ (uint)cz;

    private static int FloorToInt(float f)
    {
        int i = (int)f;
        return f < i ? i - 1 : i;
    }
}

/// <summary>
/// Positions of every player the host has to keep responsive: its own player
/// plus each connected peer whose position is known. Used by the static-object
/// pollers to find what is in view of someone.
/// </summary>
internal static class PollerAnchors
{
    /// <summary>Radius around each player inside which static objects are
    /// checked every poller tick rather than waiting for the city-wide sweep.
    /// Covers the room, the corridor and the street outside it.</summary>
    public const float NEAR_RADIUS_M = 40f;

    /// <summary>Vertical half-height of the near tier: the player's own floor
    /// and a few either side. Other floors of a tower are behind floors and
    /// ceilings; the wrapping sweep still converges them within seconds.</summary>
    public const float NEAR_MAX_DY_M = 12f;

    public static void Collect(List<Vector3> into)
    {
        into.Clear();
        try
        {
            var p = global::Player.Instance;
            if (p != null) into.Add(p.transform.position);
        }
        catch { }

        var players = NetworkManager.Players;
        if (players == null) return;
        foreach (var kv in players)
        {
            if (kv.Key == NetworkManager.LocalPlayerId) continue;
            var info = kv.Value;
            if (info == null || !info.HasKnownPosition) continue;
            into.Add(info.LastKnownPosition);
        }
    }

    /// <summary>Fill <paramref name="near"/> with every indexed object within
    /// <see cref="NEAR_RADIUS_M"/> of any player. <paramref name="seen"/> is
    /// cleared and left holding the same set, so the caller's wrapping sweep can
    /// skip what this tier already handled.</summary>
    public static void CollectNear(StaticSpatialIndex index, List<Vector3> anchors,
                                   List<int> near, HashSet<int> seen)
    {
        near.Clear();
        seen.Clear();
        if (index.Count == 0) return;
        Collect(anchors);
        for (int a = 0; a < anchors.Count; a++)
            index.Query(anchors[a], NEAR_RADIUS_M, near, seen, NEAR_MAX_DY_M);
    }
}
