using SoDCoop.Network;
using LiteNetLib;
using SoDCoop.Network.Steam;
using LiteNetLib.Utils;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors voicemail-thread creation across machines.
///
/// SoD's vmail system is largely deterministic: cases and side-jobs trigger
/// <c>Toolbox.NewVmailThread</c> from the same world-seed schedule, so each
/// machine independently builds the same list of vmails on its own. We sync
/// defensively for the cases where a non-deterministic player action does
/// trigger one — the receiver's apply path is idempotent (skip if threadID
/// already exists in the dictionary).
///
/// Listening / read-state isn't tracked by SoD's MessageThreadSave, so
/// there's no "marked as heard" event to mirror — that's local UX.
/// </summary>
public static class VmailSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastCreated(StateSaveData.MessageThreadSave thread)
    {
        if (!NetworkManager.IsConnected) return;
        if (!NetworkManager.HasPeers) return;
        if (WorldReadyGate.IsInInitGrace) return;
        if (IsApplyingRemote) return;
        if (thread == null) return;
        if (!BroadcastBudget.TryConsume("vmail.created")) return;

        try
        {
            var packet = new VmailCreatedPacket
            {
                SenderId      = NetworkManager.LocalPlayerId,
                ThreadId      = thread.threadID,
                TreeId        = thread.treeID ?? "",
                FromHumanId   = thread.participantA,
                ToAHumanId    = thread.participantB,
                ToBHumanId    = thread.participantC,
                ToCHumanId    = thread.participantD,
                TimeStamp     = thread.time,
                Progress      = 0,                                  // SoD passes 999 default; receiver matches
                DataSource    = (byte)thread.ds,
                DataSourceId  = thread.dsID,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.VmailCreated, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[VmailSync] thread broadcast id={thread.threadID} tree=\"{thread.treeID}\"");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"VmailSync.BroadcastCreated: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type != PacketType.VmailCreated) return;

        try
        {
            var p = new VmailCreatedPacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyCreated(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"VmailSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyCreated(VmailCreatedPacket p)
    {
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;

            // Idempotent: if we already have this threadID locally (because
            // deterministic case generation produced it), skip.
            var dict = gc.messageThreads;
            if (dict != null && dict.ContainsKey(p.ThreadId)) return;

            // Resolve participants. NewVmailThread picks the explicit-recipients
            // overload — pass humans we have, null where we don't.
            Human from = ResolveHuman(p.FromHumanId);
            Human toA  = ResolveHuman(p.ToAHumanId);
            Human toB  = ResolveHuman(p.ToBHumanId);
            Human toC  = ResolveHuman(p.ToCHumanId);

            if (from == null || string.IsNullOrEmpty(p.TreeId)) return;

            IsApplyingRemote = true;
            try
            {
                Toolbox.Instance.NewVmailThread(
                    from, toA, toB, toC,
                    /*cc*/ null,
                    p.TreeId,
                    p.TimeStamp,
                    /*progress*/ 999,
                    (StateSaveData.CustomDataSource)p.DataSource,
                    p.DataSourceId);
                Plugin.Log.LogInfo($"[VmailSync] applied vmail thread id={p.ThreadId} tree=\"{p.TreeId}\"");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"VmailSync.ApplyCreated failed: {ex.Message}");
        }
    }

    /// <summary>
    /// Push every existing vmail thread to a freshly-joined peer. Apply path
    /// is idempotent (skips already-known threadIDs), so a deterministic
    /// gen-side dedup happens naturally on the receiver. Only thread state
    /// is sent — listening / read flags aren't tracked by SoD's
    /// MessageThreadSave anyway.
    /// </summary>
    public static void SendSnapshotTo(SteamPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var gc = GameplayController.Instance;
            var dict = gc?.messageThreads;
            if (dict == null || dict.Count == 0) return;

            int sent = 0;
            foreach (var kv in dict)
            {
                var thread = kv.Value;
                if (thread == null) continue;

                var packet = new VmailCreatedPacket
                {
                    SenderId      = NetworkManager.LocalPlayerId,
                    ThreadId      = thread.threadID,
                    TreeId        = thread.treeID ?? "",
                    FromHumanId   = thread.participantA,
                    ToAHumanId    = thread.participantB,
                    ToBHumanId    = thread.participantC,
                    ToCHumanId    = thread.participantD,
                    TimeStamp     = thread.time,
                    Progress      = 0,
                    DataSource    = (byte)thread.ds,
                    DataSourceId  = thread.dsID,
                };
                _writer.Reset();
                packet.Serialize(_writer);
                NetworkManager.SendTo(peer, PacketType.VmailCreated, _writer, DeliveryMethod.ReliableOrdered);
                sent++;
            }
            Plugin.Log.LogInfo($"[VmailSync] snapshot: sent {sent} vmail thread(s) to peer {peer.SteamId.m_SteamID}.");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"VmailSync.SendSnapshotTo: {ex.Message}");
        }
    }

    private static Human ResolveHuman(int humanId)
    {
        if (humanId < 0) return null;
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict != null && dict.TryGetValue(humanId, out var h)) return h;
        }
        catch { }
        return null;
    }
}
