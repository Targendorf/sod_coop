using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Shared infrastructure for mirroring <c>Evidence</c> creation across machines.
///
/// Why diff-based, not direct patch on EvidenceCreator.CreateEvidence:
///   The case-generation pipeline calls CreateEvidence hundreds of times during
///   world init for procedural cases. That generation is deterministic from the
///   world seed, so each machine builds the same evidence dictionary on its
///   own — no sync needed. Patching CreateEvidence globally would spam the
///   network with redundant packets.
///
/// Strategy: callers (TakePicture patch today; future Give/UseItem/etc) wrap
/// their player-driven action with <see cref="SnapshotEvidenceKeys"/> +
/// <see cref="BroadcastNewEvidenceSince"/> diff. Only evidence created during
/// that scope crosses the wire.
///
/// Identity: <see cref="Evidence.evID"/> is a string. We send it on the wire
/// and re-create on receivers with the same id — guarantees cross-machine
/// references (case-board pin lookup, FactLinks, Toolbox.findEvidenceById)
/// stay aligned.
/// </summary>
public static class EvidenceSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    /// <summary>Lazy <c>EvidencePreset.name</c> → preset registry.</summary>
    private static Dictionary<string, EvidencePreset> _presetByName;

    // ─────────────────────────────────────────────────────────────────────────
    //  Diff helpers
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>Take a snapshot of the current evidenceDictionary keys.</summary>
    public static HashSet<string> SnapshotEvidenceKeys()
    {
        var snap = new HashSet<string>();
        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return snap;
            foreach (var kv in dict)
                if (!string.IsNullOrEmpty(kv.Key)) snap.Add(kv.Key);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.SnapshotEvidenceKeys: {ex.Message}");
        }
        return snap;
    }

    /// <summary>
    /// Walk the current evidenceDictionary and broadcast every entry whose
    /// evID is NOT in the snapshot. Caller takes the snapshot before invoking
    /// the player action; this method is called after.
    /// </summary>
    public static void BroadcastNewEvidenceSince(HashSet<string> snapshot)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (snapshot == null) return;

        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                if (string.IsNullOrEmpty(kv.Key)) continue;
                if (snapshot.Contains(kv.Key)) continue;
                var ev = kv.Value;
                if (ev == null) continue;
                BroadcastEvidence(ev);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.BroadcastNewEvidenceSince: {ex.Message}");
        }
    }

    private static void BroadcastEvidence(Evidence ev)
    {
        try
        {
            var preset = ev.preset;
            if (preset == null || string.IsNullOrEmpty(preset.name)) return;
            if (string.IsNullOrEmpty(ev.evID)) return;

            string parentId = "";
            try { parentId = ev.parent?.evID ?? ""; } catch { }

            int ownerId = -1, writerId = -1, receiverId = -1;
            try { ownerId    = ev.belongsTo?.humanID ?? -1; } catch { }
            try { writerId   = ev.writer?.humanID   ?? -1; } catch { }
            try { receiverId = ev.reciever?.humanID ?? -1; } catch { }

            var packet = new EvidenceCreatePacket
            {
                EvId            = ev.evID,
                PresetName      = preset.name,
                ParentEvId      = parentId,
                OwnerHumanId    = ownerId,
                WriterHumanId   = writerId,
                ReceiverHumanId = receiverId,
                ForceDiscovery  = true,        // player-driven creation always reveals
                SenderId        = NetworkManager.LocalPlayerId,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.EvidenceCreate, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[EvidenceSync] broadcast evID=\"{ev.evID}\" preset=\"{preset.name}\" parent=\"{parentId}\"");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.BroadcastEvidence: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.EvidenceCreate) return;

        try
        {
            var p = new EvidenceCreatePacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyCreate(p, senderId);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyCreate(EvidenceCreatePacket p, int senderId)
    {
        if (string.IsNullOrEmpty(p.EvId) || string.IsNullOrEmpty(p.PresetName)) return;

        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict != null && dict.ContainsKey(p.EvId)) return; // already have it

            var preset = ResolvePreset(p.PresetName);
            if (preset == null)
            {
                Plugin.Log.LogWarning($"[EvidenceSync] ApplyCreate: preset \"{p.PresetName}\" not found");
                return;
            }

            // Phase B.2: remote-client created evidence is attributed via the
            // WriterHumanId field — that's the actual creator. Remap it to
            // the sender's twin citizen on the host. Owner / Receiver are
            // semantic (subject of a photo, recipient of a vmail) and stay
            // as the originator labelled them.
            int writerId = p.WriterHumanId;
            int twin = TwinManager.GetTwinHumanIDForSender(senderId);
            if (twin > 0) writerId = twin;

            // Resolve owner / writer / receiver Humans by humanID. May be null.
            Human owner    = ResolveHuman(p.OwnerHumanId);
            Human writer   = ResolveHuman(writerId);
            Human receiver = ResolveHuman(p.ReceiverHumanId);

            // Resolve parent Evidence by evID. May be null.
            Evidence parent = null;
            if (!string.IsNullOrEmpty(p.ParentEvId))
            {
                if (dict != null) dict.TryGetValue(p.ParentEvId, out parent);
            }

            IsApplyingRemote = true;
            try
            {
                EvidenceCreator.Instance.CreateEvidence(
                    preset,
                    p.EvId,
                    /*controller*/ null,
                    owner, writer, receiver,
                    parent,
                    p.ForceDiscovery,
                    /*passedObjects*/ null);
                Plugin.Log.LogInfo($"[EvidenceSync] applied evidence evID=\"{p.EvId}\" preset=\"{p.PresetName}\"");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.ApplyCreate failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup helpers
    // ─────────────────────────────────────────────────────────────────────────

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

    private static EvidencePreset ResolvePreset(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;

        if (_presetByName != null && _presetByName.TryGetValue(name, out var cached))
            return cached;

        try
        {
            _presetByName = new Dictionary<string, EvidencePreset>();
            var all = Resources.FindObjectsOfTypeAll<EvidencePreset>();
            if (all == null) return null;
            for (int i = 0; i < all.Length; i++)
            {
                var p = all[i];
                if (p == null) continue;
                var n = p.name;
                if (string.IsNullOrEmpty(n)) continue;
                _presetByName[n] = p;
            }
            Plugin.Log.LogInfo($"[EvidenceSync] indexed {_presetByName.Count} EvidencePreset assets");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.ResolvePreset: {ex.Message}");
            return null;
        }

        return _presetByName.TryGetValue(name, out var fresh) ? fresh : null;
    }
}
