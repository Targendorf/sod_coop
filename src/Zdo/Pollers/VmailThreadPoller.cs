using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side vmail thread presence poller. Walks
/// <c>GameplayController.Instance.messageThreads</c>
/// (<c>Dictionary&lt;int, MessageThreadSave&gt;</c>) at 2 Hz and:
/// <list type="bullet">
///   <item>For each new threadID: creates a <see cref="ZdoTypeTag.VmailThread"/>
///   ZDO (host-owned, persistent) so snapshot replay carries it.</item>
///   <item>Calls <c>VmailSync.BroadcastCreated(thread)</c> for legacy
///   real-time delivery via the existing <c>VmailCreated</c> packet path.</item>
/// </list>
/// <para>Replaces the hot Harmony patch on
/// <c>Toolbox.NewVmailThread</c> (was at <c>GamePatches.cs:1517</c>) which
/// fired thousands of times during SoD's init burst and dominated wrapper
/// cost. The poller is gated on <c>WorldReadyGate.IsInInitGrace == false</c>
/// via <see cref="ZdoPollerHost"/>, so init-burst threads end up in baseline
/// without broadcast.</para>
/// </summary>
public static class VmailThreadPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "vmail-threads";

    private static readonly HashSet<int> _seenIds = new();

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForVmail) return;
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;
            var dict = gc.messageThreads;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                int threadID = kv.Key;
                var thread   = kv.Value;
                if (thread == null) continue;

                if (_seenIds.Contains(threadID)) continue;
                _seenIds.Add(threadID);

                // Persistent ZDO for snapshot/disk.
                var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.VmailThread, threadID,
                    owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.ThreadId, threadID);

                // Legacy real-time broadcast (kept until legacy VmailSync
                // packet path is dropped in Phase H).
                try { SoDCoop.Sync.VmailSync.BroadcastCreated(thread); } catch { }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[VmailThreadPoller] tick: {ex.Message}"); }
    }
}
