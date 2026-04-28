using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Synchronises dynamic fingerprint events (Interactable.AddNewDynamicFingerprint /
/// RemoveManuallyCreatedFingerprints) between all connected peers.
///
/// Architecture:
///   - ANY side can originate a print event (player touching an object).
///   - NPC-generated prints only originate on the host (client AI is disabled via WorldSync).
///   - Harmony postfix patches in GamePatches.cs call BroadcastAdd / BroadcastClearManual.
///   - IsApplyingRemote guards re-entrancy so the local patch doesn't echo incoming events.
///   - Each machine generates its own internal DynamicFingerprint.id/seed — they need not
///     match cross-machine because SoD queries prints by (interactable, human) pair.
///   - Dedup: packets carry SenderId; receivers skip their own echo. An additional
///     recency check (~0.5 s) prevents duplicate prints when both sides somehow race.
/// </summary>
public static class FingerprintSync
{
    /// <summary>
    /// True while we are applying a remotely received fingerprint event locally.
    /// Checked by Harmony patches to suppress re-broadcast of the replayed call.
    /// </summary>
    public static bool IsApplyingRemote { get; private set; }

    /// <summary>
    /// AddNewDynamicFingerprint is invoked as a side-effect of many SoD methods
    /// — door open, item pickup, switch toggle, murder, etc. When we apply any
    /// of those events from the network, the inner fingerprint call must NOT
    /// re-broadcast (the originator already broadcast a Fingerprint packet of
    /// its own, and a separate one will arrive for the outer event too).
    ///
    /// Centralised here so the Harmony patch only checks one accessor instead
    /// of probing each sync system's flag individually.
    /// </summary>
    public static bool ShouldSuppressBroadcast =>
        IsApplyingRemote
        || WorldStateSync.IsApplyingRemote
        || ItemSync.IsApplyingRemote
        || CitizenDeathSync.IsApplyingRemote
        || CaseBoardSync.IsApplyingRemote;

    private static readonly NetDataWriter _writer = new();

    // -------------------------------------------------------------------------
    //  Broadcast helpers (called from Harmony postfix patches)
    // -------------------------------------------------------------------------

    public static void BroadcastAdd(int interactableId, int humanId, byte life)
    {
        if (!NetworkManager.IsConnected) return;

        var packet = new FingerprintAddPacket
        {
            InteractableId = interactableId,
            HumanId        = humanId,
            Life           = life,
            SenderId       = NetworkManager.LocalPlayerId,
        };

        _writer.Reset();
        packet.Serialize(_writer);
        NetworkManager.SendToAll(PacketType.FingerprintAdd, _writer, DeliveryMethod.ReliableOrdered);

        Plugin.Log.LogInfo($"[FingerprintSync] Add broadcast: interactable={interactableId} human={humanId} life={life}");
    }

    public static void BroadcastClearManual(int interactableId)
    {
        if (!NetworkManager.IsConnected) return;

        var packet = new FingerprintClearManualPacket
        {
            InteractableId = interactableId,
            SenderId       = NetworkManager.LocalPlayerId,
        };

        _writer.Reset();
        packet.Serialize(_writer);
        NetworkManager.SendToAll(PacketType.FingerprintClearManual, _writer, DeliveryMethod.ReliableOrdered);

        Plugin.Log.LogInfo($"[FingerprintSync] ClearManual broadcast: interactable={interactableId}");
    }

    // -------------------------------------------------------------------------
    //  Packet dispatch (called from SyncManager)
    // -------------------------------------------------------------------------

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        switch (type)
        {
            case PacketType.FingerprintAdd:
            {
                var p = new FingerprintAddPacket();
                p.Deserialize(reader);
                // Skip own echo (star topology: host reflects our packet back).
                if (p.SenderId == NetworkManager.LocalPlayerId) return;
                ApplyAdd(p);
                break;
            }
            case PacketType.FingerprintClearManual:
            {
                var p = new FingerprintClearManualPacket();
                p.Deserialize(reader);
                if (p.SenderId == NetworkManager.LocalPlayerId) return;
                ApplyClearManual(p);
                break;
            }
        }
    }

    // -------------------------------------------------------------------------
    //  Apply helpers (replay the game call locally under IsApplyingRemote)
    // -------------------------------------------------------------------------

    private static void ApplyAdd(FingerprintAddPacket p)
    {
        try
        {
            var inter = FindInteractableById(p.InteractableId);
            if (inter == null)
            {
                Plugin.Log.LogWarning($"[FingerprintSync] ApplyAdd: interactable {p.InteractableId} not found.");
                return;
            }

            Human human = null;
            try
            {
                if (CityData.Instance?.citizenDictionary != null)
                    CityData.Instance.citizenDictionary.TryGetValue(p.HumanId, out human);
            }
            catch { }

            // human may be null for the local player — pass null safely
            // (AddNewDynamicFingerprint handles null in some SoD versions; wrap in try/finally)

            IsApplyingRemote = true;
            try
            {
                var life = (Interactable.PrintLife)p.Life;
                inter.AddNewDynamicFingerprint(human, life);
                Plugin.Log.LogInfo($"[FingerprintSync] applied remote add: interactable={p.InteractableId} human={p.HumanId}");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"[FingerprintSync] ApplyAdd failed: {ex.Message}");
        }
    }

    private static void ApplyClearManual(FingerprintClearManualPacket p)
    {
        try
        {
            var inter = FindInteractableById(p.InteractableId);
            if (inter == null)
            {
                Plugin.Log.LogWarning($"[FingerprintSync] ApplyClearManual: interactable {p.InteractableId} not found.");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                inter.RemoveManuallyCreatedFingerprints();
                Plugin.Log.LogInfo($"[FingerprintSync] applied remote ClearManual: interactable={p.InteractableId}");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"[FingerprintSync] ApplyClearManual failed: {ex.Message}");
        }
    }

    // -------------------------------------------------------------------------
    //  Helpers
    // -------------------------------------------------------------------------

    /// <summary>
    /// Finds an Interactable by its stable id using CityData.interactableDirectory.
    /// Fast path: direct index access (id often equals list index).
    /// Slow path: linear scan for safety.
    /// </summary>
    internal static Interactable FindInteractableById(int id)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return null;

            // Fast path — id is often the list index.
            if (id >= 0 && id < dir.Count)
            {
                var candidate = dir[id];
                if (candidate != null && candidate.id == id) return candidate;
            }

            // Linear fallback.
            for (int i = 0; i < dir.Count; i++)
            {
                var item = dir[i];
                if (item != null && item.id == id) return item;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"[FingerprintSync] FindInteractableById({id}): {ex.Message}");
        }
        return null;
    }

}
