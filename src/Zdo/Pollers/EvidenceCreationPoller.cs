using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side evidence-creation diff: 5 Hz over
/// <c>GameplayController.Instance.evidenceDictionary</c>. Tracks the previous
/// keyset; on each tick takes the same snapshot and broadcasts every newly-
/// added entry through the existing
/// <see cref="Sync.EvidenceSync.BroadcastNewEvidenceSince"/> path.
///
/// <para>Replaces the disabled patches that used the same snapshot pattern
/// at <c>FirstPersonItemController.TakePicture</c>,
/// <c>SurveillanceApp.SaveToTapeButton</c>,
/// <c>SurveillanceApp.AcquireNameButton</c>. The poller is source-agnostic:
/// any new evidence regardless of trigger gets caught and synced.</para>
///
/// <para>Caveat: there's a tick-window race where multiple new evidence
/// items in the same 200 ms get batched. EvidenceSync.BroadcastEvidence is
/// idempotent on the receiver (re-applies same evID = no-op) so this is
/// harmless; just a slightly larger packet on the next tick.</para>
/// </summary>
public static class EvidenceCreationPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME   = "evidence-creation";

    private static readonly HashSet<string> _last = new();
    private static bool _initialized;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick, WarmupBaseline);

    public static void ResetBaseline()
    {
        _initialized = false;
        _last.Clear();
    }

    /// <summary>Force the next real tick to re-snapshot the evidence keyset
    /// without broadcasting. Wired through <see cref="ZdoPollerHost"/> on
    /// every HasPeers gain.</summary>
    public static void WarmupBaseline() => ResetBaseline();

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvidenceCreation) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    /// <summary>evidenceDictionary.Count as of the previous tick. Drives the
    /// count-change fast path — see TickInner.</summary>
    private static int _lastCount = -1;

    /// <summary>How often to do a full walk regardless of Count, catching a
    /// create-and-destroy that lands inside a single tick and leaves the total
    /// unchanged. Rare enough that 10 s is ample.</summary>
    private const float RECONCILE_INTERVAL_S = 10f;
    private static float _nextReconcileAt;

    private static void RefreshSnapshot(Il2CppSystem.Collections.Generic.Dictionary<string, global::Evidence> dict)
    {
        _last.Clear();
        foreach (var kv in dict)
            if (!string.IsNullOrEmpty(kv.Key)) _last.Add(kv.Key);
    }

    private static void TickInner(float now)
    {
        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;

            // First tick: just snapshot, don't broadcast (would dump the whole
            // world's seeded evidence onto every client).
            if (!_initialized)
            {
                _initialized = true;
                RefreshSnapshot(dict);
                // Seed the fast-path baseline too, or the very next tick would
                // read _lastCount == -1, think the dictionary grew by
                // thousands, and do the full broadcast walk it just skipped.
                _lastCount = dict.Count;
                _nextReconcileAt = now + RECONCILE_INTERVAL_S;
                return;
            }

            // Count-change fast path.
            //
            // New evidence can only exist if the dictionary GREW. The old code
            // did two full enumerations of it every tick regardless — one
            // inside BroadcastNewEvidenceSince and one to refresh the snapshot
            // — and each pass marshals every Il2Cpp string key into a freshly
            // allocated managed string. On the 2026-07-30 playtest that cost
            // 224 ms per tick on average at 5 Hz, a large part of the ~197 ms
            // per frame the coop layer was burning on the host (~5 FPS).
            //
            // A single int compare replaces both walks in the steady state,
            // which is essentially always: evidence is created by player
            // actions, not continuously.
            int count = dict.Count;
            bool grew = count > _lastCount;
            bool changed = count != _lastCount;
            _lastCount = count;

            // Periodic reconcile catches the one case Count cannot see: an
            // item created and another destroyed within the same tick, leaving
            // the total unchanged.
            bool reconcileDue = now >= _nextReconcileAt;
            if (reconcileDue) _nextReconcileAt = now + RECONCILE_INTERVAL_S;

            if (!grew && !reconcileDue)
            {
                // Nothing new. Only resync the snapshot when the count moved
                // (i.e. something was destroyed), so the common path does no
                // enumeration at all.
                if (changed) RefreshSnapshot(dict);
                return;
            }

            // BroadcastNewEvidenceSince walks the dict + filters by snapshot.
            // We pass our previous tick's snapshot, then refresh it.
            try { Sync.EvidenceSync.BroadcastNewEvidenceSince(_last); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceCreationPoller] broadcast: {ex.Message}"); }

            RefreshSnapshot(dict);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceCreationPoller] tick: {ex.Message}"); }
    }
}
