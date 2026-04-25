using SoDCoop.Network;
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
        
        Plugin.Log.LogInfo("SyncManager initialized.");
    }
    
    public static void Shutdown()
    {
        IsActive = false;
        
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
            
            // Player Packets: 10-29
            if ((int)type >= 10 && (int)type <= 29)
            {
                PlayerSync?.OnPacketReceived(type, reader, senderId);
            }
            // World Packets: 30-59 + 1 (WorldSeed) + Critical (100+)
            else if (((int)type >= 30 && (int)type <= 59) || type == PacketType.WorldSeed || (int)type >= 100)
            {
                WorldSync?.OnPacketReceived(type, reader, senderId);
            }
            // Case Packets: 60-79
            else if ((int)type >= 60 && (int)type <= 79)
            {
                CaseSync?.OnPacketReceived(type, reader, senderId);
            }
            
            if (type == PacketType.TimeSync)
            {
                TimeSync?.OnPacketReceived(type, reader, senderId);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error handling packet {type} from player {senderId}: {ex}");
        }
    }
}
