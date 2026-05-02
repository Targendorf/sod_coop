using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;

namespace SoDCoop.Sync;

/// <summary>
/// Asymmetric money sharing: <b>credits flow to everyone, debits stay local</b>.
///
/// Rationale (user requirement): inventories are private per-player, so
/// purchases at shops / vendors / NPCs should drain only the buyer's wallet.
/// Rewards on the other hand — quest hand-ins, evidence sales, found cash —
/// should be received by both teammates so co-op cooperation isn't a
/// zero-sum split.
///
/// Implementation:
///   • <c>addVal &gt; 0</c>: broadcast. Receivers replay AddMoney with the
///     same args; both wallets gain identically.
///   • <c>addVal &lt; 0</c>: local only. No broadcast — only the spender
///     loses money.
///   • <c>addVal == 0</c>: no-op, dropped.
///
/// Echo dedup via SenderId — if our own broadcast bounces back through the
/// host's star topology, we ignore it.
///
/// Caveat: if a future SoD code path triggers a positive AddMoney from
/// deterministic case generation (the same way both clients independently
/// spawn procedural cases), each machine would call AddMoney AND broadcast,
/// leading to double-credit. Most current paths are player-action-driven
/// (sell evidence, complete side-job, pickup found cash), so this risk is
/// low. If it shows up in testing, we'd need a per-event id tag to dedup.
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

        // Asymmetric policy: only credits propagate. Debits (purchases at
        // shops, rent, fees) stay local — same wallet model as the
        // separate-inventory design.
        if (amount < 0)
        {
            Plugin.Log.LogInfo($"[MoneySync] local debit {amount} (reason=\"{reason}\") — not broadcast");
            return;
        }

        // Round 10: prefer the unified ZdoEventRpc channel when the events
        // flag is on. Falls back to the legacy MoneyAdded packet otherwise.
        // The patch on GameplayController.AddMoney still triggers this call —
        // wire format swap only, not a polling migration.
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendMoneyAdded(amount, displayMessage, reason); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"MoneySync.BroadcastAddMoney (ZDO event): {ex.Message}"); }
            Plugin.Log.LogInfo($"[MoneySync] zdo-event +{amount} reason=\"{reason}\"");
            return;
        }

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

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
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
        => ApplyAddMoneyImpl(p.Amount, p.DisplayMessage, p.Reason, p.SenderId);

    /// <summary>
    /// ZDO entry-point invoked from <c>ZdoEvents.OnMoneyAdded</c>. Same
    /// apply behaviour as the legacy packet path; takes the IsApplyingRemote
    /// guard responsibility.
    /// </summary>
    public static void ApplyAddMoneyFromZdo(int amount, bool displayMessage, string reason)
        => ApplyAddMoneyImpl(amount, displayMessage, reason, senderIdForLog: -1);

    private static void ApplyAddMoneyImpl(int amount, bool displayMessage, string reason, int senderIdForLog)
    {
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;

            // Defensive: only accept credits. A debit means an older sender
            // didn't enforce the credit-only policy — drop so we don't
            // double-charge a teammate's purchase.
            if (amount <= 0)
            {
                Plugin.Log.LogWarning($"[MoneySync] dropping debit ({amount}) from player {senderIdForLog}");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                gc.AddMoney(amount, displayMessage, reason ?? "");
                Plugin.Log.LogInfo($"[MoneySync] applied +{amount} from player {senderIdForLog} (reason=\"{reason}\")");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"MoneySync.ApplyAddMoneyImpl failed: {ex.Message}");
        }
    }
}
