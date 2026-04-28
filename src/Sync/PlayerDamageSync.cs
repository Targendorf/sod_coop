using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Player;
using SoDCoop.UI;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors damage taken by the LOCAL player as discrete events to peers.
///
/// <para>Why this is separate from <see cref="DamageSync"/>: NPC damage is
/// fully replayed on every machine via <c>Actor.RecieveDamage</c>, including
/// blood spatter, ragdoll forces, and shock. Player damage is different:
/// each machine owns its own player-health state, so we don't replay the
/// damage call — we just notify peers that a damage event happened so they
/// can show a banner and a "downed" visual. HP value remains local.</para>
///
/// <para>Architecture mirrors the broadcast/apply pair in DamageSync. The
/// local <c>Actor.RecieveDamage</c> Harmony patch detects when the victim
/// is the local <c>Player.Instance</c> and calls <see cref="BroadcastDamage"/>
/// instead of the NPC path.</para>
/// </summary>
public static class PlayerDamageSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────
    //  Outbound — called from the patched Actor.RecieveDamage when victim is local player
    // ─────────────────────────────────────────────────────────────────────

    public static void BroadcastDamage(
        int attackerHumanId,
        float amount,
        Vector3 hitPosition,
        Vector3 hitDirection,
        bool isLethal)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new PlayerDamagePacket
            {
                SenderId        = NetworkManager.LocalPlayerId,
                PlayerId        = NetworkManager.LocalPlayerId,
                AttackerHumanId = attackerHumanId,
                Amount          = amount,
                HitPosition     = hitPosition,
                HitDirection    = hitDirection,
                IsLethal        = isLethal,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerDamage, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[PlayerDamageSync] broadcast self-damage amount={amount:F1} lethal={isLethal} attacker={attackerHumanId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PlayerDamageSync.BroadcastDamage: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.PlayerDamage) return;

        try
        {
            var p = new PlayerDamagePacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return; // own echo
            ApplyDamage(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"PlayerDamageSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyDamage(PlayerDamagePacket p)
    {
        try
        {
            // Resolve display name for the chat banner.
            string victimName = "A player";
            try
            {
                if (NetworkManager.Players != null
                    && NetworkManager.Players.TryGetValue(p.PlayerId, out var info)
                    && !string.IsNullOrEmpty(info?.PlayerName))
                {
                    victimName = info.PlayerName;
                }
            }
            catch { }

            string banner = p.IsLethal
                ? $"☠ {victimName} is down!"
                : $"💢 {victimName} is hurt ({p.Amount:F0})";
            try { CoopUI.AddChatMessage(-1, "System", banner); } catch { }

            // Toggle the visible "downed" pose on the matching RemotePlayer.
            // For non-lethal hits we still set Down=false — the receiver sees
            // a brief banner only. Lethal hits trigger the persistent down pose,
            // which gets cleared by either a fresh damage packet with isLethal=false
            // or by the PlayerVitals isDead bit flipping back to false.
            var rp = RemotePlayerManager.GetPlayer(p.PlayerId);
            if (rp != null && p.IsLethal)
            {
                IsApplyingRemote = true;
                try { rp.SetDown(true, p.HitDirection); } finally { IsApplyingRemote = false; }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"PlayerDamageSync.ApplyDamage failed: {ex.Message}");
        }
    }
}
