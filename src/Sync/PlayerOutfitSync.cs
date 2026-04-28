using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;

namespace SoDCoop.Sync;

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

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
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
