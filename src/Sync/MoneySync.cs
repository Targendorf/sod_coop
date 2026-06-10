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

    /// <param name="notifyPollerBaseline">When true (default), advances
    /// <see cref="SoDCoop.Zdo.Pollers.MoneyPoller"/>'s diff baseline by
    /// <paramref name="amount"/> after a successful broadcast — the wallet is
    /// about to reflect this credit (the AddMoney patch fires POST-add), and
    /// without the bump the poller would see the same credit as a fresh local
    /// delta next tick and broadcast it a SECOND time (double-credit on
    /// receivers). The poller itself passes false — it advances its own
    /// baseline before calling here.</param>
    public static void BroadcastAddMoney(int amount, bool displayMessage, string reason, bool notifyPollerBaseline = true)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (amount == 0) return;       // no-op transactions don't need network traffic

        // Asymmetric policy: only credits propagate. Debits (purchases at
        // shops, rent, fees) stay local — same wallet model as the
        // separate-inventory design.
        if (amount < 0)
        {
            Plugin.Log.LogDebug($"[MoneySync] local debit {amount} (reason=\"{reason}\") — not broadcast");
            return;
        }

        if (notifyPollerBaseline)
        {
            try { SoDCoop.Zdo.Pollers.MoneyPoller.NotifyExternalCredit(amount); } catch { }
        }

        // Round 10: prefer the unified ZdoEventRpc channel when the events
        // flag is on. Falls back to the legacy MoneyAdded packet otherwise.
        // The patch on GameplayController.AddMoney still triggers this call —
        // wire format swap only, not a polling migration.
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendMoneyAdded(amount, displayMessage, reason); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"MoneySync.BroadcastAddMoney (ZDO event): {ex.Message}"); }
            Plugin.Log.LogDebug($"[MoneySync] zdo-event +{amount} reason=\"{reason}\"");
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
            Plugin.Log.LogDebug($"[MoneySync] broadcast {amount:+#;-#} reason=\"{reason}\"");
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
                Plugin.Log.LogDebug($"[MoneySync] applied +{amount} from player {senderIdForLog} (reason=\"{reason}\")");
            }
            finally
            {
                IsApplyingRemote = false;
            }

            // CRITICAL — advance the money poller's diff baseline by the credit
            // we just applied. IsApplyingRemote only guards the AddMoney PATCH
            // (same call stack); the POLLER diffs the wallet a tick later, sees
            // this credit as a fresh local delta, and broadcasts it BACK to the
            // sender → infinite +N echo loop (playtest 2026-06-10: ~1.4 Hz,
            // 93 rounds, +9300 inflation, permanent background churn on both
            // machines). Baseline accounting is the only correct fix for a
            // poll-later race.
            try { SoDCoop.Zdo.Pollers.MoneyPoller.NotifyExternalCredit(amount); } catch { }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"MoneySync.ApplyAddMoneyImpl failed: {ex.Message}");
        }
    }
}
