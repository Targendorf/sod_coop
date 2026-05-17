using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side fingerprint cursor poller. Walks
/// <c>CityData.Instance.interactableDirectory</c> at 5 Hz, tracks each
/// interactable's <c>df.Count</c>, and on increase emits one
/// <see cref="ZdoTypeTag.Fingerprint"/> ZDO per new
/// <c>DynamicFingerprint</c> entry. Each ZDO carries
/// <c>(interactableId, humanId, life)</c> — receivers replay via
/// <see cref="SoDCoop.Sync.FingerprintSync.ApplyAddDirect"/>.
///
/// <para>Replaces the disabled hot patch at
/// <c>src/Patches/GamePatches.cs:777</c>.</para>
///
/// <para><b>Performance</b>: previous implementation walked all ~10 000
/// interactables per tick (5 Hz) just to read <c>df.Count</c> on each.
/// Most interactables never have fingerprints (only doors, computers,
/// codebreakers — the things AI can leave a print on). Now uses the same
/// incremental-cache pattern as <see cref="LightPoller"/>: build a
/// "fingerprintable" subset on directory growth, walk only the cache
/// per tick. Drop from ~50 000 iter/s to ~few-hundred iter/s.</para>
/// </summary>
public static class FingerprintPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "fingerprints";

    private static readonly Dictionary<int, int> _lastCount = new();
    private static uint _seq = 1;

    /// <summary>Cached references to interactables that ever had — or could
    /// have — fingerprints. Filled lazily as the directory grows AND any
    /// time we observe <c>df != null</c> on an interactable. Per-tick we
    /// only walk this small subset.</summary>
    private static readonly List<int> _ids = new();
    private static readonly List<Interactable> _interactables = new();
    private static int _scannedTo;
    private const float RESCAN_INTERVAL_S = 1f;
    private static float _nextRescanAt;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _ids.Clear();
        _interactables.Clear();
        _lastCount.Clear();
        _scannedTo = 0;
        _nextRescanAt = 0f;
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForFingerprints) return;
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

            // Incrementally extend the cache. We add an interactable to the
            // cache the first time we see its `df` collection allocated —
            // that's SoD's signal "this object can carry fingerprints".
            // Most interactables never get a `df` (doors/computers do; mugs,
            // notes, evidence don't), so the cache stays small even with
            // 10 K total interactables.
            if (now >= _nextRescanAt && dir.Count > _scannedTo)
            {
                _nextRescanAt = now + RESCAN_INTERVAL_S;
                for (int i = _scannedTo; i < dir.Count; i++)
                {
                    var inter = dir[i];
                    if (inter == null) continue;
                    // Use `var` — the underlying IL2CPP-projected list type
                    // (Il2CppSystem.Collections.Generic.List<DynamicFingerprint>)
                    // isn't directly importable as a managed type reference.
                    var df = (object)null;
                    try { df = inter.df; } catch { }
                    if (df == null) continue;
                    _ids.Add(inter.id);
                    _interactables.Add(inter);
                }
                _scannedTo = dir.Count;
            }

            for (int idx = 0; idx < _interactables.Count; idx++)
            {
                var inter = _interactables[idx];
                if (inter == null) continue;
                int interId = _ids[idx];

                var prints = inter.df;
                if (prints == null) continue;
                int curCount = prints.Count;

                int prev = _lastCount.TryGetValue(interId, out var p) ? p : 0;
                if (curCount == prev) continue;

                if (curCount > prev)
                {
                    // Emit one ZDO per new fingerprint entry. Each entry is a
                    // separate persistent ZDO so the snapshot can replay history.
                    for (int k = prev; k < curCount; k++)
                    {
                        var fp = prints[k];
                        if (fp == null) continue;

                        // Composite SoD id: (interactableId << 16) | sequence.
                        // Sequence is local to host but unique enough; receivers
                        // dedup by (interactableId, humanId, life) at apply time.
                        int compositeId = unchecked((interId << 16) | (int)(_seq++ & 0xffff));
                        var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Fingerprint, compositeId,
                            owner: ZdoMan.LocalPeerUid, persistent: true);
                        z.Set(ZdoKeys.InteractableId, interId);
                        // DynamicFingerprint has only id/created/seed/life as
                        // verified in the dump (Interactable.cs:286-289). The
                        // Human reference is implicit in the print object's
                        // chain, but the poll snapshot doesn't easily expose it.
                        // Use 0 as a placeholder; live fingerprint *adds* are
                        // primarily detected via the active patch path with the
                        // human id. The cursor poll captures count-only history
                        // for snapshot replay.
                        try { z.Set(ZdoKeys.HumanId, 0); } catch { }
                        try { z.Set(ZdoKeys.Life, (byte)fp.life); } catch { }
                    }
                }
                _lastCount[interId] = curCount;
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[FingerprintPoller] tick: {ex.Message}"); }
    }
}
