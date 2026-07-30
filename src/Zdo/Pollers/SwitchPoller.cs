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

    // ── Two-tier per-tick walk ──────────────────────────────────────────
    //
    // The cache above is "every non-light interactable", which on a real city
    // is essentially the whole directory: ~10 000 entries. The old per-tick
    // loop read sw0..sw3 plus a null check on EVERY one of them at 10 Hz —
    // ~50 000 IL2CPP calls per tick, 500 000/s, all on the host main thread.
    // That is the measured host stall (playtest 2026-06-23: pollers held
    // 700-1600 ms/frame, host at 1.4 FPS). Note the "skip if all-default"
    // early-out sat AFTER the four field reads, so it saved a ZDO allocation
    // but never saved the interop.
    //
    // It was also redundant: Interactable.SetSwitchState is Harmony-patched
    // (GamePatches.Interactable_SetSwitchState_Patch) and broadcasts every
    // flip the instant it happens. The sweep's only real job is reconciliation
    // — catching state the patch could have missed (patch paused during load,
    // state changed by a code path that bypasses the setter).
    //
    // So: tier 1 re-pushes the small TRACKED set (interactables already known
    // non-default) every tick, and tier 2 sweeps a bounded SLICE of the full
    // cache per tick, wrapping around. Real-time response comes from the
    // patch; the sweep guarantees eventual consistency.

    /// <summary>Indices into <see cref="_interactables"/> known to be
    /// switch-bearing (non-default state seen at least once, so a ZDO
    /// exists). Walked in full every tick — small, typically tens of entries.</summary>
    private static readonly List<int> _tracked = new();
    /// <summary>Interactable ids already in <see cref="_tracked"/>, for O(1)
    /// dedup when the sweep promotes a new one.</summary>
    private static readonly HashSet<int> _trackedIds = new();

    /// <summary>Cache entries examined per tick by the reconciliation sweep.
    /// At 10 Hz, 128/tick covers a 10 000-entry directory every ~8 s while
    /// costing ~640 IL2CPP calls per tick instead of ~50 000.</summary>
    private const int SWEEP_PER_TICK = 128;
    private static int _sweepCursor;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _ids.Clear();
        _interactables.Clear();
        _scannedTo = 0;
        _nextRescanAt = 0f;
        _tracked.Clear();
        _trackedIds.Clear();
        _sweepCursor = 0;
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

            if (_interactables.Count == 0) return;

            // ── Tier 1: tracked (known switch-bearing) — every tick ───────
            // Small set, so full-rate polling here is cheap and keeps state
            // that returns to all-defaults reaching receivers promptly.
            for (int t = 0; t < _tracked.Count; t++)
            {
                int i = _tracked[t];
                if (i < 0 || i >= _interactables.Count) continue;
                PushState(_interactables[i], _ids[i], createIfDefault: true);
            }

            // ── Tier 2: bounded reconciliation sweep ──────────────────────
            // Walk SWEEP_PER_TICK entries and wrap. Promotes anything found in
            // a non-default state into the tracked tier. Real-time changes
            // arrive via the SetSwitchState Harmony patch; this only has to
            // guarantee we converge eventually.
            int sweep = Math.Min(SWEEP_PER_TICK, _interactables.Count);
            for (int n = 0; n < sweep; n++)
            {
                if (_sweepCursor >= _interactables.Count) _sweepCursor = 0;
                int i = _sweepCursor++;

                int id = _ids[i];
                if (_trackedIds.Contains(id)) continue;   // tier 1 already has it

                if (PushState(_interactables[i], id, createIfDefault: false))
                {
                    _tracked.Add(i);
                    _trackedIds.Add(id);
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SwitchPoller] tick: {ex.Message}"); }
    }

    /// <summary>Read <paramref name="inter"/>'s four switch bits and mirror them
    /// onto its Switch ZDO.
    ///
    /// <para><paramref name="createIfDefault"/> false means "only touch this
    /// interactable if it is interesting" — no ZDO is created for something
    /// sitting in the all-defaults state, which is the overwhelming majority of
    /// the directory (mugs, notes, chairs). True is used for the tracked tier,
    /// where a ZDO already exists and a return to all-defaults is itself a
    /// state change receivers must see.</para></summary>
    /// <returns>True if this interactable is switch-bearing (non-default state,
    /// or already has a ZDO) and therefore belongs in the tracked tier.</returns>
    private static bool PushState(Interactable inter, int id, bool createIfDefault)
    {
        if (inter == null) return false;

        bool s0 = false, s1 = false, s2 = false, s3 = false;
        const bool display = true;
        try { s0 = inter.sw0; s1 = inter.sw1; s2 = inter.sw2; s3 = inter.sw3; } catch { return false; }

        Zdo z = ZdoMan.FindBySodId(ZdoTypeTag.Switch, id);
        bool allDefault = !s0 && !s1 && !s2 && !s3 && display;
        if (z == null)
        {
            if (allDefault && !createIfDefault) return false;
            if (allDefault && createIfDefault) return true;   // tracked but nothing to write
            z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Switch, id, owner: ZdoMan.LocalPeerUid, persistent: true);
        }

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
        return true;
    }
}
