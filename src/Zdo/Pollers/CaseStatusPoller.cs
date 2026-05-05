using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side per-case status diff: 1 Hz over <c>CasePanelController.Instance.activeCases</c>.
/// Tracks <c>(caseID → caseStatus byte)</c>; on flip re-broadcasts via the
/// existing <see cref="Sync.CaseBoardSync.BroadcastStatus"/> path.
///
/// <para>Replaces the disabled <c>Case.SetStatus</c> Harmony patch. Pin /
/// unpin / move / string-link mutations are <b>not</b> covered by this
/// poller — they're complex per-case dictionary diffs and stay patch-driven
/// for now. This poller covers the main investigation-progress signal
/// (Open → Solved → Resolved).</para>
///
/// <para>SoD's <c>cancelObjectives</c> arg to <c>SetStatus</c> isn't
/// observable from the polled state; we re-issue with <c>false</c>, which
/// is the safe default (existing objectives are preserved).</para>
/// </summary>
public static class CaseStatusPoller
{
    public const float TICK_HZ = 1f;
    public const string NAME   = "case-status";

    private static readonly Dictionary<int, byte> _last = new();
    private static bool _initialized;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _initialized = false;
        _last.Clear();
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForCaseStatus) return;
        try
        {
            var list = CasePanelController.Instance?.activeCases;
            if (list == null) return;

            // Baseline pass — record but don't broadcast.
            if (!_initialized)
            {
                _initialized = true;
                _last.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    var c = list[i];
                    if (c == null) continue;
                    _last[c.id] = (byte)c.caseStatus;
                }
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                var c = list[i];
                if (c == null) continue;
                byte cur = (byte)c.caseStatus;
                if (!_last.TryGetValue(c.id, out byte prev) || prev != cur)
                {
                    _last[c.id] = cur;
                    // Phase G.5 (Wave 1.2): write to per-case ZDO instead of
                    // calling legacy CaseBoardSync.BroadcastStatus. Receiver-
                    // side CaseResolver.Apply reads the status key and calls
                    // CaseBoardSync.ApplyStatusFromZdo.
                    try
                    {
                        var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Case, c.id,
                            owner: ZdoMan.LocalPeerUid, persistent: true);
                        z.Set(ZdoKeys.CaseStatus, cur);
                    }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[CaseStatusPoller] zdo write: {ex.Message}"); }
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CaseStatusPoller] tick: {ex.Message}"); }
    }
}
