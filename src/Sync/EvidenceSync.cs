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
        try
        {
            switch (type)
            {
                case PacketType.EvidenceCreate:
                {
                    var p = new EvidenceCreatePacket();
                    p.Deserialize(reader);
                    if (p.SenderId == NetworkManager.LocalPlayerId) return;
                    ApplyCreate(p, senderId);
                    break;
                }
                case PacketType.EvidenceDiscoveryAdd:
                {
                    var p = new EvidenceDiscoveryAddPacket();
                    p.Deserialize(reader);
                    if (p.SenderId == NetworkManager.LocalPlayerId) return;
                    ApplyDiscovery(p);
                    break;
                }
                case PacketType.EvidenceSetNote:
                {
                    var p = new EvidenceSetNotePacket();
                    p.Deserialize(reader);
                    if (p.SenderId == NetworkManager.LocalPlayerId) return;
                    ApplySetNote(p);
                    break;
                }
                case PacketType.EvidenceCustomName:
                {
                    var p = new EvidenceCustomNamePacket();
                    p.Deserialize(reader);
                    if (p.SenderId == NetworkManager.LocalPlayerId) return;
                    ApplyCustomName(p);
                    break;
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.OnPacketReceived: {ex.Message}");
        }
    }

    /// <summary>
    /// Called from the <c>Evidence.AddDiscovery</c> Harmony postfix on the
    /// originating machine. Broadcasts the evID + Discovery enum byte so
    /// peers can replay the same discovery on their copy of the evidence.
    /// </summary>
    public static void BroadcastDiscovery(string evId, byte discovery)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;

        try
        {
            var packet = new EvidenceDiscoveryAddPacket
            {
                SenderId  = NetworkManager.LocalPlayerId,
                EvId      = evId,
                Discovery = discovery,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.EvidenceDiscoveryAdd, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[EvidenceSync] broadcast discovery evID=\"{evId}\" disc={discovery}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.BroadcastDiscovery: {ex.Message}");
        }
    }

    /// <summary>
    /// Called from <c>Evidence.SetNote</c> Harmony postfix. Broadcasts the
    /// note text + the list of DataKey bytes so receivers can replay the
    /// per-key note.
    /// </summary>
    public static void BroadcastSetNote(string evId, Il2CppSystem.Collections.Generic.List<Evidence.DataKey> keys, string text)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;

        try
        {
            byte[] keyBytes;
            if (keys != null && keys.Count > 0)
            {
                keyBytes = new byte[keys.Count];
                for (int i = 0; i < keys.Count; i++) keyBytes[i] = (byte)keys[i];
            }
            else
            {
                keyBytes = System.Array.Empty<byte>();
            }

            var packet = new EvidenceSetNotePacket
            {
                SenderId = NetworkManager.LocalPlayerId,
                EvId     = evId,
                DataKeys = keyBytes,
                Text     = text ?? "",
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.EvidenceSetNote, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[EvidenceSync] broadcast SetNote evID=\"{evId}\" keys={keyBytes.Length} text.Len={text?.Length ?? 0}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.BroadcastSetNote: {ex.Message}");
        }
    }

    /// <summary>
    /// Called from <c>Evidence.AddOrSetCustomName</c> Harmony postfix
    /// (single-DataKey overload). Broadcasts evID + DataKey byte + the
    /// custom name string.
    /// </summary>
    public static void BroadcastCustomName(string evId, Evidence.DataKey dk, string customName)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;

        try
        {
            var packet = new EvidenceCustomNamePacket
            {
                SenderId   = NetworkManager.LocalPlayerId,
                EvId       = evId,
                DataKey    = (byte)dk,
                CustomName = customName ?? "",
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.EvidenceCustomName, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[EvidenceSync] broadcast CustomName evID=\"{evId}\" dk={dk} name=\"{customName}\"");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.BroadcastCustomName: {ex.Message}");
        }
    }

    private static void ApplySetNote(EvidenceSetNotePacket p)
    {
        if (string.IsNullOrEmpty(p.EvId)) return;
        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(p.EvId, out var ev) || ev == null) return;

            var keyList = new Il2CppSystem.Collections.Generic.List<Evidence.DataKey>();
            if (p.DataKeys != null)
            {
                for (int i = 0; i < p.DataKeys.Length; i++)
                    keyList.Add((Evidence.DataKey)p.DataKeys[i]);
            }

            IsApplyingRemote = true;
            try
            {
                ev.SetNote(keyList, p.Text ?? "");
                Plugin.Log.LogInfo($"[EvidenceSync] applied SetNote evID=\"{p.EvId}\" keys={p.DataKeys?.Length ?? 0}");
            }
            finally { IsApplyingRemote = false; }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.ApplySetNote failed: {ex.Message}");
        }
    }

    private static void ApplyCustomName(EvidenceCustomNamePacket p)
    {
        if (string.IsNullOrEmpty(p.EvId)) return;
        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(p.EvId, out var ev) || ev == null) return;

            IsApplyingRemote = true;
            try
            {
                ev.AddOrSetCustomName((Evidence.DataKey)p.DataKey, p.CustomName ?? "");
                Plugin.Log.LogInfo($"[EvidenceSync] applied CustomName evID=\"{p.EvId}\" dk={p.DataKey}");
            }
            finally { IsApplyingRemote = false; }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.ApplyCustomName failed: {ex.Message}");
        }
    }

    private static void ApplyDiscovery(EvidenceDiscoveryAddPacket p)
    {
        if (string.IsNullOrEmpty(p.EvId)) return;

        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(p.EvId, out var ev) || ev == null)
            {
                // Not always present — maybe the evidence was created via
                // case generation that the host hasn't broadcast (case-gen
                // pipeline runs deterministic per-seed and is silent).
                Plugin.Log.LogInfo($"[EvidenceSync] ApplyDiscovery: evID=\"{p.EvId}\" not found locally — skipping.");
                return;
            }

            // Skip if the same Discovery value is already in discoveryProgress
            // (idempotency — SoD's AddDiscovery may also self-dedup, but
            // checking here avoids a useless cross-machine roundtrip on
            // redundant signals).
            try
            {
                var prog = ev.discoveryProgress;
                if (prog != null)
                {
                    var target = (Evidence.Discovery)p.Discovery;
                    for (int i = 0; i < prog.Count; i++)
                    {
                        if (prog[i] == target)
                        {
                            return;
                        }
                    }
                }
            }
            catch { }

            IsApplyingRemote = true;
            try
            {
                ev.AddDiscovery((Evidence.Discovery)p.Discovery);
                Plugin.Log.LogInfo($"[EvidenceSync] applied discovery evID=\"{p.EvId}\" disc={p.Discovery}");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.ApplyDiscovery failed: {ex.Message}");
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
