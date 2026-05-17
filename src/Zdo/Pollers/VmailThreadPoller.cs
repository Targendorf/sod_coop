using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side vmail thread presence poller. Walks
/// <c>GameplayController.Instance.messageThreads</c>
/// (<c>Dictionary&lt;int, MessageThreadSave&gt;</c>) at 2 Hz and stamps a
/// <see cref="ZdoTypeTag.VmailThread"/> ZDO for each thread so snapshot
/// replay carries presence.
///
/// <para><b>Phase H change</b>: the legacy real-time broadcast
/// (<c>VmailSync.BroadcastCreated</c>) is no longer fired here. SoD's
/// vmail system is deterministic per world-seed — each peer generates the
/// same threads independently from <c>Toolbox.NewVmailThread</c>. The
/// previous behaviour replayed all ~600 init-burst threads as a packet
/// flood after init-grace closed, overwhelming the LiteNetLib buffer and
/// breaking subsequent packet framing. The first post-init-grace tick now
/// just primes the seen-set silently; only thread IDs that appear AFTER
/// priming are considered "real-time deltas" — and even those skip the
/// broadcast since both peers run the same deterministic pipeline.</para>
///
/// <para>The hot Harmony patch on <c>Toolbox.NewVmailThread</c> remains
/// disabled (Harmony was UnpatchSelf'd at plugin load); only this poller
/// touches vmail state on the host side.</para>
/// </summary>
public static class VmailThreadPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "vmail-threads";

    private static readonly HashSet<int> _seenIds = new();
    private static bool _primed;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForVmail) return;
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
            var gc = GameplayController.Instance;
            if (gc == null) return;
            var dict = gc.messageThreads;
            if (dict == null) return;

            int newPresent = 0;
            foreach (var kv in dict)
            {
                int threadID = kv.Key;
                var thread   = kv.Value;
                if (thread == null) continue;

                if (_seenIds.Contains(threadID)) continue;
                _seenIds.Add(threadID);
                newPresent++;

                // Persistent ZDO for snapshot/disk. Both peers stamp their
                // own — the IDs match because the seed schedule produces the
                // same threads on each side.
                var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.VmailThread, threadID,
                    owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.ThreadId, threadID);
            }

            // First tick after init-grace closes will see hundreds of
            // pre-existing init-burst threads. Log them as a batch (not 600+
            // individual broadcasts).
            if (!_primed && newPresent > 0)
            {
                _primed = true;
                Plugin.Log.LogInfo($"[VmailThreadPoller] primed: {newPresent} pre-existing thread(s) → silent (deterministic per seed).");
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[VmailThreadPoller] tick: {ex.Message}"); }
    }
}
