using System.Collections.Generic;
using SoDCoop.Network;
using SoDCoop.Player;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Local-player-driven state events that other peers care about visually:
///   • In-bed transition (lying down)
///   • Asleep / awake
///
/// We patch the <c>Actor</c> base methods (which Player inherits) and filter
/// to "actor is the local Player.Instance" before broadcasting. NPCs sleep
/// per their own AI, deterministic from world seed + host-driven sim — no
/// sync needed for them.
///
/// Receivers store the state on RemotePlayer and best-effort poke the
/// citizen-clone animator's "isAsleep" / "isInBed" parameters. A HUD banner
/// (right-stack, same style as PhoneSync) shows "💤 PlayerName is asleep"
/// while a peer is sleeping so you don't wait for them.
/// </summary>
public static class PlayerStateSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    /// <summary>Per-player asleep state, used by the HUD overlay.</summary>
    private static readonly Dictionary<int, bool> _remoteAsleep = new();
    public static IReadOnlyDictionary<int, bool> RemoteAsleep => _remoteAsleep;

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastInBed(bool isInBed, bool isLowBed)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new PlayerInBedPacket
            {
                PlayerId = NetworkManager.LocalPlayerId,
                IsInBed  = isInBed,
                IsLowBed = isLowBed,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerInBed, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[PlayerStateSync] in-bed broadcast {isInBed} (low={isLowBed})");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PlayerStateSync.BroadcastInBed: {ex.Message}");
        }
    }

    public static void BroadcastAsleep(bool isAsleep)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new PlayerAsleepPacket
            {
                PlayerId = NetworkManager.LocalPlayerId,
                IsAsleep = isAsleep,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerAsleep, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[PlayerStateSync] asleep broadcast {isAsleep}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PlayerStateSync.BroadcastAsleep: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.PlayerInBed)
            {
                var p = new PlayerInBedPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                ApplyInBed(p);
            }
            else if (type == PacketType.PlayerAsleep)
            {
                var p = new PlayerAsleepPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                ApplyAsleep(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"PlayerStateSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyInBed(PlayerInBedPacket p)
    {
        var rp = RemotePlayerManager.GetPlayer(p.PlayerId);
        if (rp == null) return;

        IsApplyingRemote = true;
        try { rp.ApplyInBed(p.IsInBed, p.IsLowBed); }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"ApplyInBed: {ex.Message}"); }
        finally { IsApplyingRemote = false; }
    }

    private static void ApplyAsleep(PlayerAsleepPacket p)
    {
        _remoteAsleep[p.PlayerId] = p.IsAsleep;

        var rp = RemotePlayerManager.GetPlayer(p.PlayerId);
        if (rp == null) return;

        IsApplyingRemote = true;
        try { rp.ApplyAsleep(p.IsAsleep); }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"ApplyAsleep: {ex.Message}"); }
        finally { IsApplyingRemote = false; }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  HUD overlay — "💤 PlayerName is asleep" banner
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnGUI()
    {
        if (_remoteAsleep.Count == 0) return;

        // Find any remote player currently asleep.
        string sleepingName = null;
        foreach (var kv in _remoteAsleep)
        {
            if (!kv.Value) continue;
            if (NetworkManager.Players.TryGetValue(kv.Key, out var info))
                sleepingName = info.PlayerName;
            else
                sleepingName = $"Player {kv.Key}";
            break;     // show first one
        }

        if (sleepingName == null) return;

        const float w = 280f, h = 26f;
        var rect = new Rect(Screen.width - w - 12f, 76f, w, h);  // below pause + phone banners

        var prev = GUI.color;
        GUI.color = new Color(0.40f, 0.30f, 0.65f, 0.85f);   // muted purple
        GUI.Box(rect, "");
        GUI.color = Color.white;
        var style = new GUIStyle
        {
            alignment = TextAnchor.MiddleCenter,
            fontStyle = FontStyle.Bold,
            fontSize  = 13,
        };
        style.normal.textColor = Color.white;
        GUI.Label(rect, $"💤 {sleepingName} is asleep", style);
        GUI.color = prev;
    }

    public static void Clear()
    {
        _remoteAsleep.Clear();
    }
}
