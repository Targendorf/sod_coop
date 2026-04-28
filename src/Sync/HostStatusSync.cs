using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Host-side broadcast of lobby/lifecycle phase + world descriptor. Drives
/// the client's lobby UI ("Host is loading…", "Host in game: New Babylon").
///
/// Status is pushed every <see cref="BROADCAST_INTERVAL"/> seconds plus on
/// any phase change. Clients store the latest snapshot in <see cref="LastFromHost"/>.
/// </summary>
public static class HostStatusSync
{
    private const float BROADCAST_INTERVAL = 2.0f;

    private static readonly NetDataWriter _writer = new();
    private static float  _lastBroadcastTime;
    private static byte   _lastBroadcastPhase = 255;

    public static HostStatusPacket LastFromHost { get; private set; }
    public static bool             HasHostStatus { get; private set; }

    /// <summary>
    /// Compute the current phase from game state. Called by both the live
    /// broadcast loop and on-demand probes.
    /// </summary>
    public static HostPhase ComputeLocalPhase()
    {
        try
        {
            // Most reliable signal: WorldReadyGate flips to ready once the
            // city + Player.Instance are spawned and walkable.
            if (WorldReadyGate.IsWorldReady) return HostPhase.InGame;

            // CityConstructor.Instance != null AND world not ready → loading.
            if (CityConstructor.Instance != null) return HostPhase.LoadingWorld;
        }
        catch { }
        return HostPhase.InMainMenu;
    }

    public static void Update()
    {
        if (!NetworkManager.IsConnected) return;
        if (!NetworkManager.IsHost) return;

        var phase = ComputeLocalPhase();
        float now = Time.unscaledTime;

        // Broadcast if interval elapsed OR phase changed.
        bool intervalElapsed = (now - _lastBroadcastTime) >= BROADCAST_INTERVAL;
        bool phaseChanged    = (byte)phase != _lastBroadcastPhase;
        if (!intervalElapsed && !phaseChanged) return;

        _lastBroadcastTime  = now;
        _lastBroadcastPhase = (byte)phase;

        try
        {
            var packet = new HostStatusPacket
            {
                Phase        = (byte)phase,
                HostNickname = NetworkManager.LocalPlayerName ?? "Host",
                CityName     = ResolveCityName(),
                ShareSeed    = ResolveSeed(),
                GameTime     = ResolveGameTime(),
                PlayerCount  = ResolvePlayerCount(),
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.HostStatus, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"HostStatusSync.Update: {ex.Message}");
        }
    }

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.HostStatus) return;

        try
        {
            var p = new HostStatusPacket();
            p.Deserialize(reader);
            // Only the host sends this — but we're defensive.
            if (NetworkManager.IsHost) return;
            LastFromHost = p;
            HasHostStatus = true;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"HostStatusSync.OnPacketReceived: {ex.Message}");
        }
    }

    public static void Clear()
    {
        LastFromHost = default;
        HasHostStatus = false;
        _lastBroadcastPhase = 255;
        _lastBroadcastTime = 0f;
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Local probes
    // ─────────────────────────────────────────────────────────────────────────

    private static string ResolveCityName()
    {
        try { return CityData.Instance?.cityName ?? ""; }
        catch { return ""; }
    }

    private static string ResolveSeed()
    {
        try
        {
            var sd = SessionData.Instance;
            if (sd == null) return "";
            // SoD's seed string is buried; try a few candidates.
            var t = sd.GetIl2CppType();
            // We don't have a reliable single field — fall back to citySeed via Toolbox if exposed.
            // For now we leave seed empty unless a fast path is added; the
            // join-code derivation is host-side helper, not strictly required here.
            return "";
        }
        catch { return ""; }
    }

    private static float ResolveGameTime()
    {
        try { return SessionData.Instance?.gameTime ?? 0f; }
        catch { return 0f; }
    }

    private static int ResolvePlayerCount()
    {
        try { return 1 + (NetworkManager.Players?.Count ?? 0); }
        catch { return 1; }
    }
}
