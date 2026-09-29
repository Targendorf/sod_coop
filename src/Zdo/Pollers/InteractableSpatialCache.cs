using System;
using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Every interactable in the city, by directory index, with a position index —
/// built incrementally, a bounded slice per call, and shared by everything that
/// needs "what is near this player": <see cref="FingerprintPoller"/> (prints
/// near players) and <c>WorldEditSync</c> (what the local player just flipped).
///
/// <para>Positions are taken when an entry is first scanned. The objects the
/// callers care about — fixtures, furniture, doors, switches — do not move;
/// an item that is later carried off is simply found by its old position, which
/// only costs a wasted read.</para>
/// </summary>
internal static class InteractableSpatialCache
{
    /// <summary>Directory entries classified per call. Two cheap reads each (the
    /// entry and its <c>wPos</c>), no component tree walk, so a 10 000-entry
    /// directory is indexed within a few seconds.</summary>
    private const int SCAN_PER_CALL = 400;

    private static readonly List<Interactable> _all = new();
    private static readonly StaticSpatialIndex _index = new();
    private static int _scannedTo;

    /// <summary>Directory index up to which entries are cached.</summary>
    public static int ScannedTo => _scannedTo;

    public static void Reset()
    {
        _all.Clear();
        _index.Clear();
        _scannedTo = 0;
    }

    /// <summary>Scan the next slice of the live directory. Cheap no-op once the
    /// whole directory is cached; resets itself if the directory shrank (a new
    /// world under us).</summary>
    public static void Advance()
    {
        Il2CppSystem.Collections.Generic.List<Interactable> dir;
        try { dir = CityData.Instance?.interactableDirectory; } catch { return; }
        if (dir == null) return;

        int count;
        try { count = dir.Count; } catch { return; }
        if (count < _scannedTo) Reset();

        int end = Math.Min(count, _scannedTo + SCAN_PER_CALL);
        for (int i = _scannedTo; i < end; i++)
        {
            Interactable inter = null;
            try { inter = dir[i]; } catch { }
            _all.Add(inter);
            if (inter == null) continue;
            try { _index.Add(i, inter.wPos); } catch { }
        }
        _scannedTo = end;
    }

    /// <summary>The cached interactable at directory index <paramref name="dirIdx"/>,
    /// or null.</summary>
    public static Interactable Get(int dirIdx)
        => dirIdx >= 0 && dirIdx < _all.Count ? _all[dirIdx] : null;

    /// <summary>Directory indices within <paramref name="radius"/> (horizontal)
    /// of <paramref name="center"/>, appended to <paramref name="results"/>.</summary>
    public static void Query(Vector3 center, float radius, List<int> results, HashSet<int> seen,
                             float maxDy = float.PositiveInfinity)
        => _index.Query(center, radius, results, seen, maxDy);

    /// <summary>Same, around every player the host keeps responsive.</summary>
    public static void QueryNearPlayers(List<Vector3> anchors, List<int> near, HashSet<int> seen)
        => PollerAnchors.CollectNear(_index, anchors, near, seen);
}
