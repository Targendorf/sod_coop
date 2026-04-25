using UnityEngine;
using System.Collections.Generic;

namespace SoDCoop.Sync;

/// <summary>
/// Helper class to resolve stable network IDs for game objects.
/// Unity's GetInstanceID() is not stable across clients, so we need a way to map
/// objects to IDs that are consistent for all players.
/// </summary>
public static class NetworkIdResolver
{
    // Cache for performance
    private static readonly Dictionary<int, int> _instanceToNetworkId = new();
    private static readonly Dictionary<int, int> _networkToInstanceId = new();
    
    /// <summary>
    /// gets a stable network ID for a citizen component.
    /// Uses the citizen's internal ID if available, or its humanID/ticketID.
    /// </summary>
    public static int GetNetworkId(Human human)
    {
        if (human == null) return -1;
        
        // Return 0 if it's the player (host/local)
        if (human.isPlayer)
        {
            // Note: This needs careful handling as "isPlayer" might be true for remote players too if not handled right
            // We usually handle players separately via PlayerSync
            return 0;
        }

        // Try to use the citizen's persisted ID
        // Shadows of Doubt citizens usually have a 'humanID' or are stored in CityData.Instance.citizenDirectory
        // We will assume for now that we can iterate the directory to find them if they don't have a direct ID field exposed yet
        
        // Ideally: return human.humanID;
        // Fallback or verify with directory:
        
        int instanceId = human.GetInstanceID();
        
        if (_instanceToNetworkId.TryGetValue(instanceId, out int cachedId))
        {
            return cachedId;
        }
        
        // Use humanID (stable, persisted int ID set by the game)
        try
        {
            int stableId = human.humanID;
            if (stableId != 0)
            {
                CacheId(instanceId, stableId);
                return stableId;
            }
        }
        catch (System.Exception e)
        {
            Plugin.Log.LogError($"Error looking up citizen ID: {e.Message}");
        }

        return -1;
    }

    /// <summary>
    /// Resolves a network ID back to a Human component.
    /// </summary>
    public static Human GetHuman(int networkId)
    {
        if (networkId == -1) return null;
        if (networkId == 0) return global::Player.Instance;

        try
        {
            if (CityData.Instance?.citizenDictionary != null &&
                CityData.Instance.citizenDictionary.TryGetValue(networkId, out var citizen) &&
                citizen != null)
            {
                CacheId(citizen.GetInstanceID(), networkId);
                return citizen;
            }
        }
        catch (System.Exception e)
        {
            Plugin.Log.LogError($"Error resolving human from ID {networkId}: {e.Message}");
        }

        return null;
    }
    
    private static void CacheId(int instanceId, int networkId)
    {
        _instanceToNetworkId[instanceId] = networkId;
        _networkToInstanceId[networkId] = instanceId;
    }
    
    public static void ClearCache()
    {
        _instanceToNetworkId.Clear();
        _networkToInstanceId.Clear();
    }
}
