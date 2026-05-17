using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>Generic switch (drawer/cabinet/fridge/safe) state poller. Filters
/// out lights to avoid double-broadcast (LightPoller owns lights).
///
/// <para><b>Performance</b>: previous implementation walked the full
/// <c>interactableDirectory</c> (~10 000 entries) every 100 ms and called
/// <see cref="WorldStateSync.IsLightInteractable"/> on each — and that
/// helper itself ran <c>GetComponentInChildren&lt;LightController&gt;(true)</c>,
/// a Unity tree-walk. Combined with <see cref="LightPoller"/> doing the
/// same component lookup, host main-thread was burning ~200 K Unity API
/// calls per second on filter overhead.</para>
///
/// <para>Mimics Valheim's ZDOMan pattern: never iterate the full game
/// world per tick. Instead, maintain an incrementally-built cache of
/// "interactables we care about" (= non-light, non-null) and walk only
/// that cache. Lights are filtered ONCE at scan time via the O(1)
/// <see cref="LightPoller.IsKnownLight"/> set rather than being
/// re-detected per tick.</para>
/// </summary>
public static class SwitchPoller
{
    public const float TICK_HZ = 10f;
    public const string NAME = "switches";

    /// <summary>Cached interactable references (parallel to <see cref="_ids"/>).
    /// Lights and obviously-non-switchable items are excluded at scan time;
    /// per-tick iteration touches only this list.</summary>
    private static readonly List<int> _ids = new();
    private static readonly List<Interactable> _interactables = new();
    private static int _scannedTo;

    /// <summary>How often to re-scan the directory. SoD spawns new
    /// interactables continuously (NPC writes, dropped items, evidence) —
    /// the incremental scan resumes from <see cref="_scannedTo"/> so this
    /// is bounded work even on the periodic rescan.</summary>
    private const float RESCAN_INTERVAL_S = 1f;
    private static float _nextRescanAt;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _ids.Clear();
        _interactables.Clear();
        _scannedTo = 0;
        _nextRescanAt = 0f;
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForSwitches) return;
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
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            // Incrementally extend the cache. Walks only [_scannedTo, dir.Count).
            // Filter out lights (LightPoller owns those) so the per-tick path
            // doesn't have to re-check each tick.
            if (now >= _nextRescanAt && dir.Count > _scannedTo)
            {
                _nextRescanAt = now + RESCAN_INTERVAL_S;
                // Force LightPoller's scan up to the same point first, so
                // the IsKnownLight HashSet is correct for every Interactable
                // we're about to look at. Without this they race: if
                // SwitchPoller ticks before LightPoller's first scan, the
                // light-set is empty and we'd add lights to our own cache,
                // double-broadcasting their state via Switch ZDOs.
                LightPoller.EnsureScannedThrough(dir.Count);

                for (int i = _scannedTo; i < dir.Count; i++)
                {
                    var inter = dir[i];
                    if (inter == null) continue;
                    if (LightPoller.IsKnownLight(inter.id)) continue;
                    _ids.Add(inter.id);
                    _interactables.Add(inter);
                }
                _scannedTo = dir.Count;
            }

            // Per-tick: iterate the cached subset. Field reads on
            // Interactable.sw0..3 are direct property accesses, not Unity
            // component lookups — cost is O(N_cache) µs.
            for (int i = 0; i < _interactables.Count; i++)
            {
                var inter = _interactables[i];
                if (inter == null) continue;

                bool s0 = false, s1 = false, s2 = false, s3 = false;
                bool display = true;
                try { s0 = inter.sw0; s1 = inter.sw1; s2 = inter.sw2; s3 = inter.sw3; } catch { }

                Zdo z = ZdoMan.FindBySodId(ZdoTypeTag.Switch, _ids[i]);
                // Bound state-table size: skip "all four switches in default
                // state AND default-display=true" interactables until something
                // flips. An existing ZDO is always re-pushed (in case state
                // went back to all-defaults, which the receiver still needs
                // to know about).
                if (z == null && !s0 && !s1 && !s2 && !s3 && display) continue;
                z ??= ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Switch, _ids[i], owner: ZdoMan.LocalPeerUid, persistent: true);
                // Static-position stamp for sector-cull.
                if (!z.HasHostPosition)
                {
                    try { ZdoMan.NotifyZdoPosition(z, inter.wPos); } catch { }
                }
                z.Set(ZdoKeys.On,      s0);
                z.Set(ZdoKeys.Sw1,     s1);
                z.Set(ZdoKeys.Sw2,     s2);
                z.Set(ZdoKeys.Sw3,     s3);
                z.Set(ZdoKeys.Display, display);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SwitchPoller] tick: {ex.Message}"); }
    }
}
