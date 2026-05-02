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
        if (!NetworkManager.HasPeers) return;
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

            // Phase G.5 (Wave 3.4): unified RPC channel via
            // ZdoEvents.EVIDENCE_CREATE. Receiver applies via
            // EvidenceSync.ApplyCreateFromZdo.
            if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
            {
                try { SoDCoop.Zdo.ZdoEvents.SendEvidenceCreate(ev.evID, preset.name, parentId, ownerId, writerId, receiverId, true); }
                catch (System.Exception ex) { Plugin.Log.LogWarning($"EvidenceSync.BroadcastEvidence (zdo): {ex.Message}"); }
                Plugin.Log.LogInfo($"[EvidenceSync] zdo create evID=\"{ev.evID}\" preset=\"{preset.name}\"");
                return;
            }

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

    /// <summary>
    /// Push every Evidence's discoveryProgress + custom-name + sticky-note
    /// state to a freshly-joined peer. Discovery is the big one for
    /// investigation continuity — without this, late-joiner's case-board
    /// shows everything as "unknown" until they personally re-discover
    /// each fact, even if the host already cracked the case.
    ///
    /// <para>Idempotency: ApplyDiscovery dedups against existing
    /// discoveryProgress, ApplySetNote / ApplyCustomName overwrite (which
    /// matches what the originating broadcast would have done anyway).</para>
    /// </summary>
    public static void SendSnapshotTo(NetPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null || dict.Count == 0) return;

            int discoveries = 0;
            foreach (var kv in dict)
            {
                var ev = kv.Value;
                if (ev == null) continue;
                string evId = ev.evID;
                if (string.IsNullOrEmpty(evId)) continue;

                // Discovery progress.
                try
                {
                    var prog = ev.discoveryProgress;
                    if (prog != null && prog.Count > 0)
                    {
                        for (int i = 0; i < prog.Count; i++)
                        {
                            var p = new EvidenceDiscoveryAddPacket
                            {
                                SenderId  = NetworkManager.LocalPlayerId,
                                EvId      = evId,
                                Discovery = (byte)prog[i],
                            };
                            _writer.Reset();
                            p.Serialize(_writer);
                            NetworkManager.SendTo(peer, PacketType.EvidenceDiscoveryAdd, _writer, DeliveryMethod.ReliableOrdered);
                            discoveries++;
                        }
                    }
                }
                catch { }
            }
            Plugin.Log.LogInfo($"[EvidenceSync] snapshot: sent {discoveries} discovery record(s) to peer {peer.Address}:{peer.Port}.");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.SendSnapshotTo: {ex.Message}");
        }
    }

    /// <summary>
    /// Host-only star-topology remap. Re-serialises an EvidenceCreate from
    /// raw <paramref name="body"/> bytes with <c>WriterHumanId</c> rewritten
    /// to the sender's twin humanID. Owner / Receiver fields are semantic
    /// (photo subject, vmail recipient) and stay as the originator set
    /// them. Returns null if no remap needed.
    /// </summary>
    public static NetDataWriter RemapForForward(byte[] body, int bodyLen, int senderId, NetDataWriter outBuf)
    {
        if (!NetworkManager.IsHost) return null;
        int twin = TwinManager.GetTwinHumanIDForSender(senderId);
        if (twin <= 0) return null;

        try
        {
            var reader = new NetDataReader(body, 0, bodyLen);
            var p = new EvidenceCreatePacket();
            p.Deserialize(reader);
            p.WriterHumanId = twin;
            outBuf.Reset();
            p.Serialize(outBuf);
            return outBuf;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EvidenceSync.RemapForForward: {ex.Message}");
            return null;
        }
    }

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
        if (!NetworkManager.HasPeers) return;
        if (WorldReadyGate.IsInInitGrace) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;
        if (!BroadcastBudget.TryConsume("evidence.discovery")) return;

        // Phase G.5 (Wave 3.5): unified RPC channel via ZdoEvents.
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendEvidenceDiscovery(evId, discovery); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"EvidenceSync.BroadcastDiscovery (zdo): {ex.Message}"); }
            return;
        }

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
        if (!NetworkManager.HasPeers) return;
        if (WorldReadyGate.IsInInitGrace) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;
        if (!BroadcastBudget.TryConsume("evidence.note")) return;

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

            // Phase G.5: unified RPC.
            if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
            {
                SoDCoop.Zdo.ZdoEvents.SendEvidenceSetNote(evId, keyBytes, text ?? "");
                return;
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
        if (!NetworkManager.HasPeers) return;
        if (WorldReadyGate.IsInInitGrace) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;
        if (!BroadcastBudget.TryConsume("evidence.customname")) return;

        // Phase G.5 (Wave 3.5): unified RPC.
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendEvidenceCustomName(evId, (byte)dk, customName ?? ""); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"EvidenceSync.BroadcastCustomName (zdo): {ex.Message}"); }
            return;
        }

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
        => ApplySetNoteFromZdo(p.EvId, p.DataKeys, p.Text);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnEvidenceSetNote</c>.</summary>
    public static void ApplySetNoteFromZdo(string evId, byte[] dataKeys, string text)
    {
        if (string.IsNullOrEmpty(evId)) return;
        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(evId, out var ev) || ev == null) return;

            var keyList = new Il2CppSystem.Collections.Generic.List<Evidence.DataKey>();
            if (dataKeys != null)
            {
                for (int i = 0; i < dataKeys.Length; i++)
                    keyList.Add((Evidence.DataKey)dataKeys[i]);
            }

            IsApplyingRemote = true;
            try
            {
                ev.SetNote(keyList, text ?? "");
                Plugin.Log.LogInfo($"[EvidenceSync] applied SetNote evID=\"{evId}\" keys={dataKeys?.Length ?? 0}");
            }
            finally { IsApplyingRemote = false; }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.ApplySetNote failed: {ex.Message}");
        }
    }

    private static void ApplyCustomName(EvidenceCustomNamePacket p)
        => ApplyCustomNameFromZdo(p.EvId, p.DataKey, p.CustomName);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnEvidenceCustomName</c>.</summary>
    public static void ApplyCustomNameFromZdo(string evId, byte dataKey, string customName)
    {
        if (string.IsNullOrEmpty(evId)) return;
        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(evId, out var ev) || ev == null) return;

            IsApplyingRemote = true;
            try
            {
                ev.AddOrSetCustomName((Evidence.DataKey)dataKey, customName ?? "");
                Plugin.Log.LogInfo($"[EvidenceSync] applied CustomName evID=\"{evId}\" dk={dataKey}");
            }
            finally { IsApplyingRemote = false; }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"EvidenceSync.ApplyCustomName failed: {ex.Message}");
        }
    }

    private static void ApplyDiscovery(EvidenceDiscoveryAddPacket p)
        => ApplyDiscoveryFromZdo(p.EvId, p.Discovery);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnEvidenceDiscovery</c>.</summary>
    public static void ApplyDiscoveryFromZdo(string evId, byte discovery)
    {
        if (string.IsNullOrEmpty(evId)) return;

        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(evId, out var ev) || ev == null)
            {
                Plugin.Log.LogInfo($"[EvidenceSync] ApplyDiscovery: evID=\"{evId}\" not found locally — skipping.");
                return;
            }

            try
            {
                var prog = ev.discoveryProgress;
                if (prog != null)
                {
                    var target = (Evidence.Discovery)discovery;
                    for (int i = 0; i < prog.Count; i++)
                    {
                        if (prog[i] == target) return;
                    }
                }
            }
            catch { }

            IsApplyingRemote = true;
            try
            {
                ev.AddDiscovery((Evidence.Discovery)discovery);
                Plugin.Log.LogInfo($"[EvidenceSync] applied discovery evID=\"{evId}\" disc={discovery}");
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
        => ApplyCreateFromZdo(p.EvId, p.PresetName, p.ParentEvId,
            p.OwnerHumanId, p.WriterHumanId, p.ReceiverHumanId, p.ForceDiscovery, senderId);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnEvidenceCreate</c>.</summary>
    public static void ApplyCreateFromZdo(string evId, string presetName, string parentEvId,
                                           int ownerHumanId, int writerHumanId, int receiverHumanId,
                                           bool forceDiscovery, int senderId)
    {
        if (string.IsNullOrEmpty(evId) || string.IsNullOrEmpty(presetName)) return;

        try
        {
            var dict = GameplayController.Instance?.evidenceDictionary;
            if (dict != null && dict.ContainsKey(evId)) return; // already have it

            var preset = ResolvePreset(presetName);
            if (preset == null)
            {
                Plugin.Log.LogWarning($"[EvidenceSync] ApplyCreate: preset \"{presetName}\" not found");
                return;
            }

            // Twin remap of writer humanID for client-originated creation.
            int writerId = writerHumanId;
            int twin = TwinManager.GetTwinHumanIDForSender(senderId);
            if (twin > 0) writerId = twin;

            Human owner    = ResolveHuman(ownerHumanId);
            Human writer   = ResolveHuman(writerId);
            Human receiver = ResolveHuman(receiverHumanId);

            Evidence parent = null;
            if (!string.IsNullOrEmpty(parentEvId))
            {
                if (dict != null) dict.TryGetValue(parentEvId, out parent);
            }

            IsApplyingRemote = true;
            try
            {
                EvidenceCreator.Instance.CreateEvidence(
                    preset, evId, null, owner, writer, receiver,
                    parent, forceDiscovery, null);
                Plugin.Log.LogInfo($"[EvidenceSync] applied evidence evID=\"{evId}\" preset=\"{presetName}\"");
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
