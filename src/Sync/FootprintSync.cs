using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Bloody / dirty footprint decals.
///
/// Architecture:
///   • Host broadcasts BOTH NPC and host-player footsteps (clients have AI
///     disabled so NPCs never trigger Setup() locally there).
///   • Clients broadcast ONLY their local player's footsteps. Their visual
///     NPCs may still fire FootstepLeft/Right animation events while the
///     animator runs walking, but those broadcasts must be suppressed
///     (otherwise we'd duplicate every footprint on every machine).
///   • Receiver reconstructs a <c>GameplayController.Footprint</c> from the
///     wire fields and feeds it to a fresh <c>FootprintController</c> from
///     the pool, under <see cref="IsApplyingRemote"/> so the patch doesn't
///     re-broadcast.
///
/// Cross-machine identity is implicit: each footprint carries
/// (humanID, position, euler, dirt, blood, roomID, timestamp). No globally
/// unique footprint id exists, but exact-match via these fields is the same
/// way SoD's save format identifies them.
/// </summary>
public static class FootprintSync
{
    public static bool IsApplyingRemote { get; private set; }

    /// <summary>
    /// FootprintController.Setup is invoked as a side-effect of multiple SoD
    /// methods (animation events, save loading, citizen sim ticks). When we
    /// apply any other remote action that internally results in a footstep,
    /// the inner Setup call must NOT re-broadcast — its outer event will
    /// have its own broadcast already in flight.
    /// </summary>
    public static bool ShouldSuppressBroadcast =>
        IsApplyingRemote
        || WorldStateSync.IsApplyingRemote
        || ItemSync.IsApplyingRemote
        || CitizenDeathSync.IsApplyingRemote
        || CaseBoardSync.IsApplyingRemote
        || FingerprintSync.IsApplyingRemote
        || DamageSync.IsApplyingRemote
        || EvidenceSync.IsApplyingRemote;

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Broadcast a footprint described by an existing Footprint data object.
    /// Caller (the Harmony patch on FootprintController.Setup) is expected to
    /// have already filtered: clients only call this for their local player,
    /// the host calls it for everything.
    /// </summary>
    public static void BroadcastAdd(GameplayController.Footprint fp)
    {
        if (!NetworkManager.IsConnected) return;
        if (ShouldSuppressBroadcast) return;
        if (fp == null) return;

        try
        {
            var packet = new FootprintAddPacket
            {
                HumanId   = fp.hID,
                RoomId    = fp.rID,
                Position  = fp.wP,
                EulerRot  = fp.eU,
                Dirt      = fp.str,
                Blood     = fp.bl,
                Timestamp = fp.t,
                SenderId  = NetworkManager.LocalPlayerId,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.FootprintAdd, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"FootprintSync.BroadcastAdd: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Late-join snapshot of every active footprint. Walks
    /// <c>GameplayController.Instance.footprintsList</c> and emits one
    /// FootprintAdd packet per entry. Receiver replays them via
    /// <see cref="ApplyAdd"/> exactly like a live broadcast.
    ///
    /// <para>Dedup: receiver's footprintsList is fresh (client must be on
    /// main menu to join, so no save-side prints exist on their machine).
    /// Sending host's snapshot directly populates client's list with
    /// matching entries — no duplicates in practice.</para>
    ///
    /// <para>Cost: bounded by footprintsList.Count (typically dozens to
    /// low hundreds). Each entry → one packet of ~50 bytes.</para>
    /// </summary>
    public static void SendSnapshotTo(NetPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var gc = global::GameplayController.Instance;
            var list = gc?.footprintsList;
            if (list == null || list.Count == 0) return;

            int sent = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var fp = list[i];
                if (fp == null) continue;

                var pkt = new FootprintAddPacket
                {
                    HumanId   = fp.hID,
                    RoomId    = fp.rID,
                    Position  = fp.wP,
                    EulerRot  = fp.eU,
                    Dirt      = fp.str,
                    Blood     = fp.bl,
                    Timestamp = fp.t,
                    SenderId  = NetworkManager.LocalPlayerId,
                };
                _writer.Reset();
                pkt.Serialize(_writer);
                NetworkManager.SendTo(peer, PacketType.FootprintAdd, _writer, DeliveryMethod.ReliableOrdered);
                sent++;
            }
            Plugin.Log.LogInfo($"[FootprintSync] snapshot: footprints={sent} → {peer.Address}:{peer.Port}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"FootprintSync.SendSnapshotTo: {ex.Message}");
        }
    }

    /// <summary>
    /// Host-only star-topology remap. Re-serialises a FootprintAdd from
    /// raw <paramref name="body"/> bytes with <c>HumanId</c> rewritten to
    /// the sender's twin humanID. Returns null if no remap needed.
    /// </summary>
    public static NetDataWriter RemapForForward(byte[] body, int bodyLen, int senderId, NetDataWriter outBuf)
    {
        if (!NetworkManager.IsHost) return null;
        int twin = TwinManager.GetTwinHumanIDForSender(senderId);
        if (twin <= 0) return null;

        try
        {
            var reader = new NetDataReader(body, 0, bodyLen);
            var p = new FootprintAddPacket();
            p.Deserialize(reader);
            p.HumanId = twin;
            outBuf.Reset();
            p.Serialize(outBuf);
            return outBuf;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"FootprintSync.RemapForForward: {ex.Message}");
            return null;
        }
    }

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.FootprintAdd) return;

        try
        {
            var p = new FootprintAddPacket();
            p.Deserialize(reader);
            // Echo dedup: if we sent this packet ourselves (host reflects in star
            // topology), drop it.
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyAdd(p, senderId);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"FootprintSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyAdd(FootprintAddPacket p, int senderId)
    {
        try
        {
            // Phase B.2: remote-client originated prints get attributed to the
            // sender's twin citizen instead of whatever local-machine humanID
            // they put in the packet (which is their local Player.Instance,
            // unrelated to host's city DB).
            int humanId = p.HumanId;
            int twin = TwinManager.GetTwinHumanIDForSender(senderId);
            if (twin > 0) humanId = twin;

            // Resolve owner Human. May be null for host-originated host-player
            // prints applied on a client (their citizenDictionary won't have
            // the host's player citizen) — Footprint ctor accepts null.
            Human human = ResolveHuman(humanId);

            // Resolve room (may be null — Footprint ctor accepts null forceRoom
            // and falls back to runtime detection).
            NewRoom room = ResolveRoom(p.RoomId);

            // Construct the data object identically to the originator. We
            // pass the (possibly remapped) humanId via the constructed
            // Footprint's hID field — see post-construction patch below.
            var fp = new GameplayController.Footprint(
                human, p.Position, p.EulerRot, p.Dirt, p.Blood, room);
            try { fp.hID = humanId; } catch { }

            // Force timestamp to match the originator so dedup / decay match
            // across machines.
            try { fp.t = p.Timestamp; } catch { }

            // Pull a FootprintController off the pool and let it set up the
            // visual decal. This is the same path SoD uses internally.
            var controller = FootprintController.GetNewFootprint();
            if (controller == null)
            {
                Plugin.Log.LogWarning("[FootprintSync] ApplyAdd: GetNewFootprint() returned null (pool exhausted?)");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                controller.Setup(fp);
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"FootprintSync.ApplyAdd failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup helpers
    // ─────────────────────────────────────────────────────────────────────────

    private static Human ResolveHuman(int humanId)
    {
        try
        {
            // Local player short-circuit — don't go through citizenDictionary.
            var local = global::Player.Instance;
            if (local != null && local.humanID == humanId) return local;

            var dict = CityData.Instance?.citizenDictionary;
            if (dict != null && dict.TryGetValue(humanId, out var h)) return h;
        }
        catch { }
        return null;
    }

    private static NewRoom ResolveRoom(int roomId)
    {
        try
        {
            var dict = CityData.Instance?.roomDictionary;
            if (dict != null && dict.TryGetValue(roomId, out var r)) return r;
        }
        catch { }
        return null;
    }
}
