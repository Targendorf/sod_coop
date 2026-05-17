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
                _last.Clear();
                foreach (var kv in dict)
                    if (!string.IsNullOrEmpty(kv.Key)) _last.Add(kv.Key);
                return;
            }

            // BroadcastNewEvidenceSince walks the dict + filters by snapshot.
            // We pass our previous tick's snapshot, then refresh it.
            try { Sync.EvidenceSync.BroadcastNewEvidenceSince(_last); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceCreationPoller] broadcast: {ex.Message}"); }

            _last.Clear();
            foreach (var kv in dict)
                if (!string.IsNullOrEmpty(kv.Key)) _last.Add(kv.Key);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceCreationPoller] tick: {ex.Message}"); }
    }
}
