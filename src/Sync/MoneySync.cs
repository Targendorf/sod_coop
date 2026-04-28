using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors <c>GameplayController.AddMoney</c> calls so every player ends up
/// with the same balance shift — quest rewards, evidence sales, found cash,
/// fees, and any other money flow that goes through the central credit API.
///
/// The user requirement: when one player completes a job and earns 500 cred,
/// BOTH players should receive 500 cred independently. We implement this by
/// patching AddMoney postfix and re-invoking the same call (with identical
/// amount + message + reason) on every other peer.
///
/// Echo dedup via SenderId — if our own broadcast bounces back through the
/// host's star topology, we ignore it.
///
/// Caveat: if a future SoD code path triggers AddMoney from deterministic
/// case generation (the same way both clients independently spawn
/// procedural cases), each machine would call AddMoney AND broadcast,
/// leading to double-credit. Most current paths are player-action-driven
/// (sell evidence, complete side-job), so this risk is low. If it shows up
/// in testing, we'd need a per-event id tag to dedup.
/// </summary>
public static class MoneySync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastAddMoney(int amount, bool displayMessage, string reason)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (amount == 0) return;       // no-op transactions don't need network traffic

        try
        {
            var packet = new MoneyAddedPacket
            {
                SenderId       = NetworkManager.LocalPlayerId,
                Amount         = amount,
                DisplayMessage = displayMessage,
                Reason         = reason ?? "",
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.MoneyAdded, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[MoneySync] broadcast {amount:+#;-#} reason=\"{reason}\"");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"MoneySync.BroadcastAddMoney: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.MoneyAdded) return;

        try
        {
            var p = new MoneyAddedPacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyAddMoney(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"MoneySync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyAddMoney(MoneyAddedPacket p)
    {
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;

            IsApplyingRemote = true;
            try
            {
                gc.AddMoney(p.Amount, p.DisplayMessage, p.Reason ?? "");
                Plugin.Log.LogInfo($"[MoneySync] applied {p.Amount:+#;-#} from player {p.SenderId} (reason=\"{p.Reason}\")");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"MoneySync.ApplyAddMoney failed: {ex.Message}");
        }
    }
}
