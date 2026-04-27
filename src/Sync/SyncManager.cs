using SoDCoop.Network;
using SoDCoop.UI;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Manages all synchronization subsystems.
/// </summary>
public static class SyncManager
{
    /// <summary>
    /// Player position and state synchronization.
    /// </summary>
    public static PlayerSync PlayerSync { get; private set; }
    
    /// <summary>
    /// World/NPC state synchronization.
    /// </summary>
    public static WorldSync WorldSync { get; private set; }
    
    /// <summary>
    /// Game time synchronization.
    /// </summary>
    public static TimeSync TimeSync { get; private set; }
    
    /// <summary>
    /// Investigation/case progress synchronization.
    /// </summary>
    public static CaseSync CaseSync { get; private set; }
    
    /// <summary>
    /// Whether sync systems are active.
    /// </summary>
    public static bool IsActive { get; private set; }
    
    public static void Initialize()
    {
        Plugin.Log.LogInfo("SyncManager initializing...");
        
        PlayerSync = new PlayerSync();
        WorldSync = new WorldSync();
        TimeSync = new TimeSync();
        CaseSync = new CaseSync();
        
        // Subscribe to network events
        NetworkManager.OnConnected += OnConnected;
        NetworkManager.OnDisconnected += OnDisconnected;
        NetworkManager.OnPacketReceived += OnPacketReceived;

        // Weather is host-authoritative; needs OnPlayerJoined to push state to late-joiners.
        WeatherSync.Initialize();

        Plugin.Log.LogInfo("SyncManager initialized.");
    }
    
    public static void Shutdown()
    {
        IsActive = false;

        WeatherSync.Shutdown();

        NetworkManager.OnConnected -= OnConnected;
        NetworkManager.OnDisconnected -= OnDisconnected;
        NetworkManager.OnPacketReceived -= OnPacketReceived;
        
        PlayerSync = null;
        WorldSync = null;
        TimeSync = null;
        CaseSync = null;
        
        Plugin.Log.LogInfo("SyncManager shutdown.");
    }
    
    public static void Update()
    {
        if (!IsActive || !NetworkManager.IsConnected) return;
        
        PlayerSync?.Update();
        WorldSync?.Update();
        TimeSync?.Update();
        CaseSync?.Update();
    }
    
    private static void OnConnected()
    {
        IsActive = true;
        Plugin.Log.LogInfo("SyncManager activated.");
        
        // If we're the host, sync the world seed
        if (NetworkManager.IsHost)
        {
            WorldSync?.SyncWorldSeed();
        }
    }
    
    private static void OnDisconnected(string reason)
    {
        IsActive = false;
        Plugin.Log.LogInfo($"SyncManager deactivated: {reason}");
    }
    
    private static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        // Route packet to appropriate sync system
        try
        {
            // We could use ranges from Packets.cs to optimize, but for now simple dispatch
            // Each manager checks if the type belongs to it
            
            // Item pickup / drop (14, 15) — handled by ItemSync, not PlayerSync.
            if (type == PacketType.PlayerPickup || type == PacketType.PlayerDrop)
            {
                ItemSync.OnPacketReceived(type, reader, senderId);
            }
            // Player Packets: 10-29 (excluding 14 and 15 handled above)
            else if ((int)type >= 10 && (int)type <= 29)
            {
                PlayerSync?.OnPacketReceived(type, reader, senderId);
            }
            // Doors + lights + switches (50-59) — go to WorldStateSync, not WorldSync.
            else if (type == PacketType.DoorState
                  || type == PacketType.LightState
                  || type == PacketType.SwitchState)
            {
                WorldStateSync.OnPacketReceived(type, reader, senderId);
            }
            // Weather (34) — host-authoritative, dedicated handler.
            else if (type == PacketType.WeatherSync)
            {
                WeatherSync.OnPacketReceived(type, reader, senderId);
            }
            // Citizen death + crime-scene discovery (100, 102).
            else if (type == PacketType.CitizenDeath || type == PacketType.CrimeSceneDiscovered)
            {
                CitizenDeathSync.OnPacketReceived(type, reader, senderId);
            }
            // Phone call notification banner (103).
            else if (type == PacketType.PhoneCallNotify)
            {
                PhoneSync.OnPacketReceived(type, reader, senderId);
            }
            // World Packets: 30-49 + 1 (WorldSeed) + Critical (100+) → WorldSync (NPCs, time, etc.)
            else if (((int)type >= 30 && (int)type <= 49) || type == PacketType.WorldSeed || (int)type >= 100)
            {
                WorldSync?.OnPacketReceived(type, reader, senderId);
            }
            // Shared case board (66-71) — own handler.
            else if (type == PacketType.CaseBoardPin
                  || type == PacketType.CaseBoardUnpin
                  || type == PacketType.CaseBoardMove
                  || type == PacketType.CaseBoardString
                  || type == PacketType.CaseBoardHide
                  || type == PacketType.CaseBoardStatus)
            {
                CaseBoardSync.OnPacketReceived(type, reader, senderId);
            }
            // Other Case Packets: 60-79
            else if ((int)type >= 60 && (int)type <= 79)
            {
                CaseSync?.OnPacketReceived(type, reader, senderId);
            }
            
            if (type == PacketType.TimeSync)
            {
                TimeSync?.OnPacketReceived(type, reader, senderId);
            }

            // Chat / UI packets (80-99)
            if (type == PacketType.ChatMessage)
            {
                CoopUI.OnChatPacketReceived(reader, senderId);
            }
            else if (type == PacketType.MapPing || type == PacketType.PauseState)
            {
                PingSystem.OnPacketReceived(type, reader, senderId);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error handling packet {type} from player {senderId}: {ex}");
        }
    }
}
