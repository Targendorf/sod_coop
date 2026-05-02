using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors NPC outfit changes from host to clients.
///
/// <para>SoD citizens swap clothes during the day (work shift → uniform,
/// home → casual, sleeping → pajamas). This runs in their AI tick, which
/// only executes on the host (clients have NPC AI disabled). Without
/// this broadcast, clients see the initial seeded outfit forever — a
/// citizen wearing pajamas on the host is still in their work uniform on
/// the client.</para>
///
/// <para>Wire: humanID + outfit-category byte. Receiver finds the citizen
/// in <c>CityData.Instance.citizenDictionary</c> and replays SoD's
/// SetCurrentOutfit under <see cref="IsApplyingRemote"/> so the patch
/// doesn't re-broadcast.</para>
/// </summary>
public static class NpcOutfitSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    public static void BroadcastNpcOutfit(int humanId, byte category)
    {
        if (!NetworkManager.IsConnected) return;
        if (!NetworkManager.IsHost) return; // only host's AI drives NPC outfits
        if (!NetworkManager.HasPeers) return;
        if (WorldReadyGate.IsInInitGrace) return; // skip the seeded init burst
        if (IsApplyingRemote) return;
        if (humanId <= 0) return;
        if (!BroadcastBudget.TryConsume("npc.outfit")) return;

        try
        {
            var packet = new NpcOutfitPacket
            {
                SenderId = NetworkManager.LocalPlayerId,
                HumanId  = humanId,
                Category = category,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.NpcOutfit, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[NpcOutfitSync] broadcast humanID={humanId} cat={category}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"NpcOutfitSync.BroadcastNpcOutfit: {ex.Message}");
        }
    }

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type != PacketType.NpcOutfit) return;
        try
        {
            var p = new NpcOutfitPacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyOutfit(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"NpcOutfitSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyOutfit(NpcOutfitPacket p)
    {
        ApplyByHumanId(p.HumanId, p.Category);
    }

    /// <summary>Apply an outfit category by Human id. Public so the ZDO
    /// CitizenResolver can replay the same path without re-implementing the
    /// IsApplyingRemote re-entrancy guard or the
    /// <c>CitizenOutfitController.SetCurrentOutfit</c> argument shape.</summary>
    public static void ApplyByHumanId(int humanId, byte category)
    {
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(humanId, out var human) || human == null) return;
            var ctrl = human.outfitController;
            if (ctrl == null) return;
            // Skip if no actual change to avoid re-running clothes load + animator.
            if ((byte)ctrl.currentOutfit == category) return;

            IsApplyingRemote = true;
            try
            {
                ctrl.SetCurrentOutfit((ClothesPreset.OutfitCategory)category, false, false, true);
                Plugin.Log.LogInfo($"[NpcOutfitSync] applied humanID={humanId} cat={category}");
            }
            finally { IsApplyingRemote = false; }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"NpcOutfitSync.ApplyByHumanId: {ex.Message}");
        }
    }

    /// <summary>
    /// Reverse-lookup: given a CitizenOutfitController, find the humanID of
    /// the owning citizen. Walks the controller's parent chain to grab the
    /// Human component. Returns 0 on failure.
    /// </summary>
    public static int ResolveOwningHumanId(CitizenOutfitController ctrl)
    {
        if (ctrl == null) return 0;
        try
        {
            var go = ctrl.gameObject;
            if (go == null) return 0;
            var human = go.GetComponentInParent<Human>();
            return human?.humanID ?? 0;
        }
        catch { return 0; }
    }
}

/// <summary>
/// Mirrors player outfit / disguise changes onto the host's twin citizen.
///
/// <para><b>Why:</b> SoD's guards / co-workers / suspicion-checks read the
/// person's current outfit category to decide whether they belong in the
/// area (a security uniform unlocks restricted zones, a work-issue
/// uniform makes you a co-worker). On the client's machine the player's
/// own outfit category flips when they pick on a uniform — but on the
/// host the twin citizen stayed in whatever it was wearing originally.
/// Result: client thinks they're disguised, host's guards still chase.</para>
///
/// <para><b>Architecture:</b> Harmony postfix on
/// <c>CitizenOutfitController.SetCurrentOutfit</c> only fires the
/// broadcast when the patched controller belongs to the local
/// <c>Player.Instance</c> — NPC outfit changes happen on host's AI tick
/// and don't need client-broadcast. Client sends the new outfit category
/// (a single byte enum). Host applies via the twin's own
/// <c>SetCurrentOutfit</c> so SoD's loading + visual-update path runs
/// natively. The apply path is host-only — other peers don't have a
/// host-side twin reference to act on.</para>
/// </summary>
public static class PlayerOutfitSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────
    //  Outbound — called from Harmony postfix in GamePatches.cs
    // ─────────────────────────────────────────────────────────────────────

    public static void BroadcastSetOutfit(byte category)
    {
        if (!NetworkManager.IsConnected) return;
        if (NetworkManager.IsHost) return;        // host's own outfit IS the host citizen
        if (IsApplyingRemote) return;

        try
        {
            var packet = new PlayerOutfitPacket
            {
                PlayerId = NetworkManager.LocalPlayerId,
                Category = category,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerOutfit, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[PlayerOutfitSync] sent category={category}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PlayerOutfitSync.BroadcastSetOutfit: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Inbound — host-only apply
    // ─────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type != PacketType.PlayerOutfit) return;

        try
        {
            var p = new PlayerOutfitPacket();
            p.Deserialize(reader);
            ApplyToTwin(p, senderId);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"PlayerOutfitSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyToTwin(PlayerOutfitPacket p, int senderId)
    {
        if (!NetworkManager.IsHost) return;

        int twinHumanId = TwinManager.GetTwinHumanIDForSender(senderId);
        if (twinHumanId <= 0) return;

        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(twinHumanId, out var twin) || twin == null) return;

            var ctrl = twin.outfitController;
            if (ctrl == null)
            {
                Plugin.Log.LogWarning($"[PlayerOutfitSync] twin humanID={twinHumanId} has no outfitController.");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                var cat = (ClothesPreset.OutfitCategory)p.Category;
                ctrl.SetCurrentOutfit(cat, /*forceLoad*/ false, /*forceReload*/ false, /*ignoreIfDead*/ true);
                Plugin.Log.LogInfo($"[PlayerOutfitSync] applied outfit category={cat} to twin humanID={twinHumanId}");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PlayerOutfitSync.ApplyToTwin: {ex.Message}");
        }
    }
}
