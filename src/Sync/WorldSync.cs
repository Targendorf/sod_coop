using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;
using System.Collections.Generic;

namespace SoDCoop.Sync;

/// <summary>
/// Handles synchronization of world state including NPCs, objects, and world events.
/// Uses delta compression and priority-based updates.
/// </summary>
public class WorldSync
{
    #region Constants
    
    /// <summary>
    /// How often to send world state updates.
    /// </summary>
    private const float WORLD_SYNC_RATE = 0.1f; // 10 Hz
    
    /// <summary>
    /// How often to send full world checksum for validation.
    /// </summary>
    private const float CHECKSUM_RATE = 1.0f;
    
    /// <summary>
    /// Maximum NPCs to sync per update to avoid packet size issues.
    /// </summary>
    private const int MAX_NPCS_PER_UPDATE = 20;
    
    /// <summary>
    /// Range around players within which NPCs are synced.
    /// </summary>
    private const float NPC_SYNC_RANGE = 50f;
    
    #endregion
    
    #region Properties
    
    /// <summary>
    /// The world seed used for generation (synced from host).
    /// </summary>
    public int SyncedSeed { get; private set; }
    
    #endregion
    
    #region Private Fields
    
    private float _lastWorldSyncTime;
    private float _lastChecksumTime;
    private readonly NetDataWriter _writer = new();
    private readonly Dictionary<int, CitizenSyncState> _citizenStates = new();
    
    #endregion
    
    public void Update()
    {
        // MVP: world/NPC sync disabled. Each client runs its own simulation.
        // Re-enable once Citizen IL2CPP wrappers are verified at runtime.
        return;
    }
    
    /// <summary>
    /// Sync the world generation seed to all clients.
    /// Called by host when game starts.
    /// </summary>
    public void SyncWorldSeed()
    {
        if (!NetworkManager.IsHost) return;
        
        // Get the current city's seed
        // This will need to be adapted to the actual game's city generation system
        int seed = GetCurrentWorldSeed();
        string cityName = GetCurrentCityName();
        int citySize = GetCurrentCitySize();
        
        SyncedSeed = seed;
        
        var packet = new WorldSeedPacket
        {
            Seed = seed,
            CityName = cityName,
            CitySize = citySize
        };
        
        _writer.Reset();
        packet.Serialize(_writer);
        
        NetworkManager.SendToAll(PacketType.WorldSeed, _writer, DeliveryMethod.ReliableOrdered);
        
        Plugin.Log.LogInfo($"World seed synced: {seed}, City: {cityName}");
    }
    
    private void SyncNearbyNPCs()
    {
        // Get all player positions (local + remote)
        var playerPositions = GetAllPlayerPositions();
        if (playerPositions.Count == 0) return;
        
        // Find NPCs near any player
        var nearbyNPCs = FindNPCsNearPlayers(playerPositions, NPC_SYNC_RANGE);
        
        // Limit to prevent packet bloat
        int count = Mathf.Min(nearbyNPCs.Count, MAX_NPCS_PER_UPDATE);
        
        if (count == 0) return;
        
        // Build batch packet
        _writer.Reset();
        _writer.Put(count);
        
        for (int i = 0; i < count; i++)
        {
            var npc = nearbyNPCs[i];
            WriteCitizenState(_writer, npc);
        }
        
        NetworkManager.SendToAll(PacketType.CitizenStateBatch, _writer, DeliveryMethod.Sequenced);
    }
    
    private void SendWorldChecksum()
    {
        // Calculate a simple checksum of world state for validation
        uint checksum = CalculateWorldChecksum();
        
        _writer.Reset();
        _writer.Put(checksum);
        _writer.Put(Time.time);
        
        NetworkManager.SendToAll(PacketType.WorldChecksum, _writer, DeliveryMethod.ReliableOrdered);
    }
    
    public void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        // Client-side: handle world state updates from host
        if (NetworkManager.IsHost) return;
        
        if (type == PacketType.WorldSeed)
        {
            var packet = new WorldSeedPacket();
            packet.Deserialize(reader);
            OnWorldSeedReceived(packet);
        }
        else if (type == PacketType.CitizenStateBatch)
        {
            OnCitizenStateBatch(reader);
        }
        else if (type == PacketType.CitizenDeath || type == PacketType.CrimeCommitted)
        {
            // Handle critical events
            // Assuming simple structure for now: [byte type][int id][float time]
            // Actually WorldSync.SendCriticalEvent sends: [byte eventType][int targetId][float time]
            // But PacketType was consumed.
            // Wait, SendCriticalEvent uses writer.Put((byte)eventType) INSIDE the data?
            // "NetworkManager.SendToAll(packetType, _writer..."
            // PacketType is the header. The payload starts with eventType byte?
            // Re-checking SendCriticalEvent in WorldSync.cs:
            /*
            _writer.Put((byte)eventType);
            _writer.Put(targetId);
            */
            // Yes.
            
            try 
            {
                var eventType = (CriticalEventType)reader.GetByte();
                var targetId = reader.GetInt();
                // Apply event...
                Plugin.Log.LogInfo($"Received critical event: {eventType} on {targetId}");
                
                // If it's a death, find the human and kill them
                if (eventType == CriticalEventType.CitizenDeath)
                {
                    var human = NetworkIdResolver.GetHuman(targetId);
                    if (human != null && !human.isDead)
                    {
                        human.SetHealth(0);
                    }
                }
            }
            catch {}
        }
    }
    
    public void OnWorldSeedReceived(WorldSeedPacket packet)
    {
        SyncedSeed = packet.Seed;
        Plugin.Log.LogInfo($"Received world seed: {packet.Seed}, City: {packet.CityName}");
        
        // TODO: If world generation hasn't happened yet, use this seed
        // Otherwise, validate that seeds match
    }
    
    public void OnCitizenStateBatch(NetPacketReader reader)
    {
        int count = reader.GetInt();
        
        for (int i = 0; i < count; i++)
        {
            var state = ReadCitizenState(reader);
            ApplyCitizenState(state);
        }
    }
    
    #region Helpers
    
    private int GetCurrentWorldSeed()
    {
        try
        {
            if (CityData.Instance != null)
            {
                // CityData.seed is a string (deterministic hash input); derive a stable int.
                var s = CityData.Instance.seed;
                return string.IsNullOrEmpty(s) ? 0 : s.GetHashCode();
            }
        }
        catch { }
        return 0;
    }
    
    private string GetCurrentCityName()
    {
        try
        {
            if (CityData.Instance != null)
            {
                return CityData.Instance.cityName ?? "Unknown City";
            }
        }
        catch { }
        return "Unknown City";
    }
    
    private int GetCurrentCitySize()
    {
        try
        {
            if (CityData.Instance != null)
            {
                // CityData.citySize is a Vector2 (grid W x H); pack into a single int.
                var v = CityData.Instance.citySize;
                return ((int)v.x << 16) | ((int)v.y & 0xFFFF);
            }
        }
        catch { }
        return 1;
    }
    
    private List<Vector3> GetAllPlayerPositions()
    {
        var positions = new List<Vector3>();
        
        // Local player using Player.Instance
        try
        {
            var localPlayer = global::Player.Instance;
            if (localPlayer != null)
            {
                positions.Add(localPlayer.transform.position);
            }
        }
        catch { }
        
        // Remote players
        foreach (var remote in Player.RemotePlayerManager.GetAllPlayers())
        {
            if (remote != null)
            {
                positions.Add(remote.transform.position);
            }
        }
        
        return positions;
    }
    
    private List<CitizenInfo> FindNPCsNearPlayers(List<Vector3> playerPositions, float range)
    {
        var result = new List<CitizenInfo>();
        
        try
        {
            if (CityData.Instance?.citizenDictionary == null) return result;

            foreach (var kvp in CityData.Instance.citizenDictionary)
            {
                var human = kvp.Value;
                if (human == null || human.gameObject == null) continue;

                var humanPos = human.transform.position;

                foreach (var playerPos in playerPositions)
                {
                    if (Vector3.Distance(humanPos, playerPos) <= range)
                    {
                        int stableId = kvp.Key;

                        result.Add(new CitizenInfo
                        {
                            Id = stableId,
                            Position = humanPos,
                            Rotation = human.transform.rotation,
                            CurrentAction = 0,
                            CurrentLocationId = human.currentRoom != null ? human.currentRoom.GetInstanceID() : 0,
                            IsDead = human.isDead,
                            IsUnconscious = human.isStunned
                        });
                        break;
                    }
                }

                if (result.Count >= MAX_NPCS_PER_UPDATE) break;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error finding NPCs: {ex.Message}");
        }
        
        return result;
    }
    
    private void WriteCitizenState(NetDataWriter writer, CitizenInfo citizen)
    {
        var packet = new CitizenStatePacket
        {
            CitizenId = citizen.Id,
            Position = citizen.Position,
            Rotation = citizen.Rotation,
            CurrentAction = citizen.CurrentAction,
            CurrentLocationId = citizen.CurrentLocationId,
            IsDead = citizen.IsDead,
            IsUnconscious = citizen.IsUnconscious
        };
        
        packet.Serialize(writer);
    }
    
    private CitizenStatePacket ReadCitizenState(NetPacketReader reader)
    {
        var packet = new CitizenStatePacket();
        packet.Deserialize(reader);
        return packet;
    }
    
    private void ApplyCitizenState(CitizenStatePacket state)
    {
        try
        {
            var human = NetworkIdResolver.GetHuman(state.CitizenId);
            if (human != null)
            {
                // Smooth interpolation could be added here, but for now just snap
                // Only snap if distance is significant to avoid jitter
                float dist = Vector3.Distance(human.transform.position, state.Position);
                if (dist > 0.1f)
                {
                    human.transform.position = state.Position;
                }
                
                // Always sync rotation
                if (Quaternion.Angle(human.transform.rotation, state.Rotation) > 5f)
                {
                    human.transform.rotation = state.Rotation;
                }

                // Sync basic states
                if (human.isDead != state.IsDead) human.SetHealth(state.IsDead ? 0 : 100); // Rough approximation
                if (human.isStunned != state.IsUnconscious) human.isStunned = state.IsUnconscious;
                
                // Sync animation/action if needed (requires more complex AI sync)
                // human.ai.currentAction = (AIAction)state.CurrentAction;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error applying citizen state: {ex.Message}");
        }
    }
    
    private uint CalculateWorldChecksum()
    {
        // Simple checksum based on key world state
        // Used to detect desync
        uint checksum = 0;
        
        // Hash important world state elements
        // This is a placeholder - actual implementation depends on game
        
        return checksum;
    }
    
    /// <summary>
    /// Send a critical world event that must be immediately synced.
    /// </summary>
    public void SendCriticalEvent(CriticalEventType eventType, int targetId)
    {
        if (!NetworkManager.IsHost) return;
        
        _writer.Reset();
        _writer.Put((byte)eventType);
        _writer.Put(targetId);
        _writer.Put(Time.time);
        
        var packetType = eventType switch
        {
            CriticalEventType.CitizenDeath => PacketType.CitizenDeath,
            CriticalEventType.CrimeCommitted => PacketType.CrimeCommitted,
            _ => PacketType.CitizenDeath
        };
        
        NetworkManager.SendToAll(packetType, _writer, DeliveryMethod.ReliableOrdered);
    }
    
    #endregion
}

/// <summary>
/// Critical event types that require immediate sync.
/// </summary>
public enum CriticalEventType
{
    CitizenDeath,
    CrimeCommitted,
    ArrestMade,
    CaseSolved
}

/// <summary>
/// Cached citizen state for delta detection.
/// </summary>
public struct CitizenSyncState
{
    public Vector3 LastPosition;
    public Quaternion LastRotation;
    public int LastAction;
    public float LastSyncTime;
}

/// <summary>
/// Wrapper for citizen/NPC data.
/// </summary>
public struct CitizenInfo
{
    public int Id;
    public Vector3 Position;
    public Quaternion Rotation;
    public int CurrentAction;
    public int CurrentLocationId;
    public bool IsDead;
    public bool IsUnconscious;
}
