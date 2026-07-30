using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Zdo;

/// <summary>
/// Tile-bucketed spatial index over <see cref="Zdo"/>s that have a known
/// host-side world position. Replaces the linear scan of
/// <c>ZdoMan._spatialZdos</c> in <c>EvaluatePeerCatchup</c> — that scan was
/// O(N_spatial) per peer-movement-debounced catch-up eval, walking ~2000
/// ZDOs (citizens + lights + doors + switches + computers) every time a
/// peer crossed the 50 m re-eval threshold. With 4 peers moving through a
/// dense city that was 8000+ distance checks per catch-up burst on the host
/// main thread.
///
/// <para>This grid partitions the world into <see cref="TILE_SIZE_M"/>-sided
/// square cells keyed by <c>(cellX, cellZ)</c>. Query walks only the cells
/// overlapping the query radius — for <see cref="ZdoMan.CULL_RADIUS_M"/> of
/// 150 m and a 100 m tile that's a 3×3 window (9 cells), each typically
/// holding a handful of ZDOs. So the catch-up eval becomes O(visible
/// cells × ZDOs/cell) instead of O(all spatial ZDOs).</para>
///
/// <para>Single-threaded (Unity main only). No locking — every caller
/// (<see cref="ZdoMan.NotifyZdoPosition"/>, <see cref="Move"/>,
/// <see cref="Remove"/>, <see cref="Query"/>) runs inside the
/// <c>CoopUpdateRunner.Update</c> cascade.</para>
///
/// <para><b>Robustness:</b> NaN / Infinity coordinates are rejected on
/// <see cref="Insert"/>/<see cref="Move"/> (the ZDO just isn't indexed) so a
/// bad transform can't poison a cell key forever. A ZDO whose position
/// changes cells is moved atomically: removed from the old cell, added to
/// the new one.</para>
/// </summary>
public static class SpatialGrid
{
    /// <summary>Cell size in world units. Matches the SoD city-tile grid
    /// (~100 m per CityTile) so each cell naturally clusters the entities
    /// that share a tile. <see cref="ZdoMan.CULL_RADIUS_M"/> (150 m) spans
    /// ~1.5 tiles, so a cull query touches a 3×3 cell window.</summary>
    public const float TILE_SIZE_M = 100f;
    private const float INV_TILE = 1f / TILE_SIZE_M;

    /// <summary>Cells keyed by (cellX, cellZ). Lazily created; cells are
    /// removed from the dictionary when they become empty to keep the map
    /// tight across citizen migration.</summary>
    private static readonly Dictionary<(int cx, int cz), HashSet<Zdo>> _cells = new();

    /// <summary>Per-ZDO record of which cell it currently lives in, so
    /// <see cref="Move"/> can remove it from the old cell in O(1) without
    /// scanning. Cleared on <see cref="Remove"/>.</summary>
    private static readonly Dictionary<Zdo, (int cx, int cz)> _zdoCell = new();

    /// <summary>Reusable scratch list for <see cref="Query"/> results.
    /// Cleared at the start of each Query call; the caller must consume it
    /// synchronously before the next Query. Single-threaded, so safe as a
    /// static singleton.</summary>
    private static readonly List<Zdo> _queryScratch = new();

    private static (int cx, int cz) CellOf(Vector3 pos)
    {
        // Floor (not truncate) so negative coordinates land in the right
        // cell — a position at x=-0.5f is in cell -1, not cell 0.
        return (FloorToInt(pos.x * INV_TILE), FloorToInt(pos.z * INV_TILE));
    }

    private static int FloorToInt(float f)
    {
        int i = (int)f;
        return f < i ? i - 1 : i;
    }

    /// <summary>Index <paramref name="z"/> at its current
    /// <see cref="Zdo.HostPosition"/>. No-op if the position is NaN/Infinity
    /// or the ZDO is already indexed at the same cell. Idempotent.</summary>
    public static void Insert(Zdo z)
    {
        if (z == null) return;
        // Guard: only index ZDOs whose HostPosition has actually been stamped
        // by a poller. ZDOs whose HostPosition is still default(Vector3)
        // (HasHostPosition==false) used to be inserted at cell (0,0), so every
        // peer near the world origin got ALL non-spatial ZDOs (Money, Case,
        // Evidence, Vmail...) in their catch-up diff — 16k+ entries for a
        // single peer movement (playtest 2026-06-16: catch-up queued 16854
        // ZDOs = 93% of the registry). Global/non-spatial ZDOs bypass the
        // grid entirely; spatial ones get inserted on first NotifyZdoPosition.
        if (!z.HasHostPosition) return;
        Vector3 pos = z.HostPosition;
        if (!float.IsFinite(pos.x) || !float.IsFinite(pos.z)) return;

        var cell = CellOf(pos);
        if (_zdoCell.TryGetValue(z, out var existing))
        {
            if (existing.cx == cell.cx && existing.cz == cell.cz) return; // same cell, no move
            RemoveInternal(z, existing);
        }
        AddToCell(z, cell);
    }

    /// <summary>Move <paramref name="z"/> to <paramref name="newPos"/>. If
    /// the new position lands in the same cell as the old, only the ZDO's
    /// <see cref="Zdo.HostPosition"/> field is updated (no cell bookkeeping).
    /// Caller is responsible for having already written newPos into
    /// z.HostPosition BEFORE calling this — or use the 2-arg
    /// <see cref="Insert"/> overload after writing.</summary>
    public static void Move(Zdo z, Vector3 newPos)
    {
        if (z == null) return;
        if (!float.IsFinite(newPos.x) || !float.IsFinite(newPos.z))
        {
            // Bad new position — drop the ZDO from the grid entirely so a
            // stale cell entry doesn't linger.
            Remove(z);
            return;
        }
        z.HostPosition = newPos;
        z.HasHostPosition = true;
        Insert(z);
    }

    private static void AddToCell(Zdo z, (int cx, int cz) cell)
    {
        if (!_cells.TryGetValue(cell, out var set))
        {
            set = new HashSet<Zdo>();
            _cells[cell] = set;
        }
        set.Add(z);
        _zdoCell[z] = cell;
    }

    private static void RemoveInternal(Zdo z, (int cx, int cz) cell)
    {
        if (_cells.TryGetValue(cell, out var set))
        {
            set.Remove(z);
            if (set.Count == 0) _cells.Remove(cell);
        }
    }

    /// <summary>Remove <paramref name="z"/> from the grid entirely. No-op if
    /// it wasn't indexed. Called from <see cref="ZdoMan.Destroy"/> so a
    /// destroyed ZDO doesn't linger in a cell (and a future Query doesn't
    /// deref a freed ZDO).</summary>
    public static void Remove(Zdo z)
    {
        if (z == null) return;
        if (_zdoCell.TryGetValue(z, out var cell))
        {
            RemoveInternal(z, cell);
            _zdoCell.Remove(z);
        }
    }

    /// <summary>Return all indexed ZDOs whose <see cref="Zdo.HostPosition"/>
    /// is within <paramref name="radius"/> metres (XZ-plane only) of
    /// <paramref name="center"/>. The returned list is a static scratch —
    /// consume it synchronously, do not retain across the next Query.
    ///
    /// <para>Walks only the cells overlapping the query radius: for a 150 m
    /// radius on a 100 m tile that's a 3×3 window (≤9 cells), vs. the old
    /// O(N_spatial) linear scan over the whole ~2000-ZDO set. ZDOs in the
    /// window but outside the radius are filtered by the exact distance
    /// check, same as before.</para></summary>
    public static List<Zdo> Query(Vector3 center, float radius)
    {
        _queryScratch.Clear();
        if (radius <= 0f) return _queryScratch;

        // Cell range overlapping the query disc.
        int minCx = FloorToInt((center.x - radius) * INV_TILE);
        int maxCx = FloorToInt((center.x + radius) * INV_TILE);
        int minCz = FloorToInt((center.z - radius) * INV_TILE);
        int maxCz = FloorToInt((center.z + radius) * INV_TILE);
        float radiusSq = radius * radius;

        for (int cx = minCx; cx <= maxCx; cx++)
        {
            for (int cz = minCz; cz <= maxCz; cz++)
            {
                if (!_cells.TryGetValue((cx, cz), out var set)) continue;
                foreach (var z in set)
                {
                    if (z == null) continue;
                    Vector3 p = z.HostPosition;
                    float dx = p.x - center.x;
                    float dz = p.z - center.z;
                    if (dx * dx + dz * dz <= radiusSq)
                        _queryScratch.Add(z);
                }
            }
        }
        return _queryScratch;
    }

    /// <summary>Number of ZDOs currently indexed. Diagnostic only.</summary>
    public static int Count => _zdoCell.Count;

    /// <summary>Drop every cell + ZDO mapping. Called from
    /// <see cref="ZdoMan.Clear"/> so the grid doesn't carry stale entries
    /// across sessions.</summary>
    public static void Clear()
    {
        _cells.Clear();
        _zdoCell.Clear();
    }
}
