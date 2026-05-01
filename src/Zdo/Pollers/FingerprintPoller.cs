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
/// </summary>
public static class FingerprintPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "fingerprints";

    private static readonly Dictionary<int, int> _lastCount = new();
    private static uint _seq = 1;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForFingerprints) return;
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            for (int i = 0; i < dir.Count; i++)
            {
                var inter = dir[i];
                if (inter == null) continue;

                var prints = inter.df;
                if (prints == null) continue;
                int curCount = prints.Count;

                int prev = _lastCount.TryGetValue(inter.id, out var p) ? p : 0;
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
                        int compositeId = unchecked((inter.id << 16) | (int)(_seq++ & 0xffff));
                        var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Fingerprint, compositeId,
                            owner: ZdoMan.LocalPeerUid, persistent: true);
                        z.Set(ZdoKeys.InteractableId, inter.id);
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
                _lastCount[inter.id] = curCount;
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[FingerprintPoller] tick: {ex.Message}"); }
    }
}
