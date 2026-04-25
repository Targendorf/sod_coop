using System.Collections.Generic;
using SoDCoop.Sync;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Manages all remote players in the game world.
///
/// Lifecycle:
///   - SpawnRemotePlayer always creates the capsule fallback immediately, so position
///     packets arriving before the world is loaded still produce a visible avatar.
///   - When WorldReadyGate flips to ready (city + citizens + Player exist), we upgrade
///     every player's visual to a citizen-body clone.
///   - When the gate flips to unready (back to menu), we revert the visual to the capsule
///     because the cloned citizen objects reference now-destroyed assets.
/// </summary>
public static class RemotePlayerManager
{
    public static IReadOnlyDictionary<int, RemotePlayer> Players => _players;

    private static readonly Dictionary<int, RemotePlayer> _players = new();
    private static readonly Dictionary<int, GameObject>   _citizenVisuals = new(); // playerId -> cloned visual child
    private static GameObject _prefab;
    private static bool _eventsHooked;
    private static bool _gateHooked;

    public static void Initialize()
    {
        Plugin.Log.LogInfo("RemotePlayerManager initializing (deferred prefab + world-ready gate)...");

        if (!_eventsHooked)
        {
            Network.NetworkManager.OnPlayerJoined += OnPlayerJoined;
            Network.NetworkManager.OnPlayerLeft   += OnPlayerLeft;
            Network.NetworkManager.OnDisconnected += OnDisconnected;
            _eventsHooked = true;
        }

        if (!_gateHooked)
        {
            WorldReadyGate.OnWorldReady   += OnWorldReady;
            WorldReadyGate.OnWorldUnready += OnWorldUnready;
            _gateHooked = true;
        }
    }

    public static void Shutdown()
    {
        DespawnAll();

        if (_eventsHooked)
        {
            Network.NetworkManager.OnPlayerJoined -= OnPlayerJoined;
            Network.NetworkManager.OnPlayerLeft   -= OnPlayerLeft;
            Network.NetworkManager.OnDisconnected -= OnDisconnected;
            _eventsHooked = false;
        }

        if (_gateHooked)
        {
            WorldReadyGate.OnWorldReady   -= OnWorldReady;
            WorldReadyGate.OnWorldUnready -= OnWorldUnready;
            _gateHooked = false;
        }

        if (_prefab != null)
        {
            Object.Destroy(_prefab);
            _prefab = null;
        }

        Plugin.Log.LogInfo("RemotePlayerManager shutdown.");
    }

    private static void EnsurePrefab()
    {
        if (_prefab != null) return;

        _prefab = new GameObject("SoDCoop_RemotePlayerPrefab");
        _prefab.SetActive(false);
        _prefab.hideFlags = HideFlags.HideAndDontSave;
        Object.DontDestroyOnLoad(_prefab);

        // Capsule fallback visual.
        var capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.name = "CapsuleVisual";
        Object.Destroy(capsule.GetComponent<Collider>());
        capsule.transform.SetParent(_prefab.transform, false);
        capsule.transform.localPosition = new Vector3(0f, 1f, 0f);
        capsule.transform.localScale    = new Vector3(0.5f, 1f, 0.5f);

        var shader = Shader.Find("HDRP/Lit")
                  ?? Shader.Find("Universal Render Pipeline/Lit")
                  ?? Shader.Find("Standard")
                  ?? Shader.Find("Sprites/Default");
        if (shader != null)
        {
            var mat = new Material(shader) { color = new Color(0.2f, 0.6f, 1f, 1f) };
            capsule.GetComponent<MeshRenderer>().material = mat;
        }

        // Anchor for screen-space name tag overlay (no in-world text).
        var labelGO = new GameObject("NameLabel");
        labelGO.transform.SetParent(_prefab.transform, false);
        labelGO.transform.localPosition = new Vector3(0f, 2.1f, 0f);

        _prefab.AddComponent<RemotePlayer>();

        Plugin.Log.LogInfo("Remote player prefab created lazily.");
    }

    public static RemotePlayer SpawnRemotePlayer(int playerId, string playerName)
    {
        if (playerId < 0)
        {
            Plugin.Log.LogWarning($"Refusing to spawn RemotePlayer with invalid id {playerId}");
            return null;
        }
        if (playerId == Network.NetworkManager.LocalPlayerId) return null;
        if (_players.TryGetValue(playerId, out var existing) && existing != null) return existing;

        try
        {
            EnsurePrefab();

            var go = Object.Instantiate(_prefab);
            go.name = $"RemotePlayer_{playerId}_{playerName}";
            Object.DontDestroyOnLoad(go);
            go.SetActive(true);

            var rp = go.GetComponent<RemotePlayer>();
            rp.Initialize(playerId, playerName);

            _players[playerId] = rp;
            Plugin.Log.LogInfo($"Spawned RemotePlayer {playerName} (ID: {playerId})");

            // If the world is already loaded, upgrade visuals immediately.
            // Otherwise the gate event handler will do it once everything's ready.
            if (WorldReadyGate.IsWorldReady)
            {
                TryUpgradeVisual(playerId);
            }

            return rp;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"SpawnRemotePlayer({playerId}) failed: {ex}");
            return null;
        }
    }

    public static RemotePlayer GetPlayer(int playerId)
        => _players.TryGetValue(playerId, out var p) ? p : null;

    public static IEnumerable<RemotePlayer> GetAllPlayers() => _players.Values;

    public static void RemovePlayer(int playerId)
    {
        if (_citizenVisuals.TryGetValue(playerId, out var v))
        {
            if (v != null) Object.Destroy(v);
            _citizenVisuals.Remove(playerId);
        }

        if (_players.TryGetValue(playerId, out var p))
        {
            if (p != null && p.gameObject != null) Object.Destroy(p.gameObject);
            _players.Remove(playerId);
            Plugin.Log.LogInfo($"Removed RemotePlayer {playerId}");
        }
    }

    /// <summary>
    /// Try to clone a citizen body and parent it under the remote player. Hides the capsule
    /// fallback on success. Idempotent — does nothing if already upgraded.
    /// </summary>
    private static void TryUpgradeVisual(int playerId)
    {
        if (!_players.TryGetValue(playerId, out var rp) || rp == null || rp.gameObject == null) return;
        if (_citizenVisuals.TryGetValue(playerId, out var existing) && existing != null) return;

        try
        {
            var clone = CitizenVisualCloner.TryCloneRandomCitizenVisual(playerId);
            if (clone == null) return;

            var root = rp.gameObject;
            clone.transform.SetParent(root.transform, false);
            clone.transform.localPosition = Vector3.zero;
            clone.transform.localRotation = Quaternion.identity;

            // Hide capsule, keep NameLabel anchor.
            SetCapsuleActive(root, false);

            _citizenVisuals[playerId] = clone;

            // Re-resolve animator on the RemotePlayer now that a real rig is present.
            rp.OnVisualUpgraded();

            Plugin.Log.LogInfo($"RemotePlayer {playerId} visual upgraded to citizen body.");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"TryUpgradeVisual({playerId}) failed: {ex.Message}");
        }
    }

    /// <summary>
    /// Drop the citizen-clone visual and re-show the capsule fallback. Called when the
    /// game world unloads (returning to menu) — citizen objects there are destroyed and
    /// our clone holds dangling references.
    /// </summary>
    private static void RevertToCapsule(int playerId)
    {
        if (!_players.TryGetValue(playerId, out var rp) || rp == null || rp.gameObject == null) return;

        if (_citizenVisuals.TryGetValue(playerId, out var clone))
        {
            if (clone != null) Object.Destroy(clone);
            _citizenVisuals.Remove(playerId);
        }

        SetCapsuleActive(rp.gameObject, true);
        rp.OnVisualReverted();
    }

    private static void SetCapsuleActive(GameObject root, bool active)
    {
        for (int i = 0; i < root.transform.childCount; i++)
        {
            var child = root.transform.GetChild(i);
            if (child.name == "CapsuleVisual") child.gameObject.SetActive(active);
        }
    }

    private static void DespawnAll()
    {
        foreach (var v in _citizenVisuals.Values)
            if (v != null) Object.Destroy(v);
        _citizenVisuals.Clear();

        foreach (var p in _players.Values)
            if (p != null && p.gameObject != null) Object.Destroy(p.gameObject);
        _players.Clear();
    }

    private static void OnPlayerJoined(int playerId, string playerName)
    {
        if (playerId < 0) return;
        if (playerId == Network.NetworkManager.LocalPlayerId) return;
        SpawnRemotePlayer(playerId, playerName);
    }

    private static void OnPlayerLeft(int playerId, string _) => RemovePlayer(playerId);
    private static void OnDisconnected(string _) => DespawnAll();

    private static void OnWorldReady()
    {
        // Upgrade everyone who's still on the capsule fallback.
        foreach (var kv in _players)
        {
            if (!_citizenVisuals.ContainsKey(kv.Key))
                TryUpgradeVisual(kv.Key);
        }
    }

    private static void OnWorldUnready()
    {
        // Citizen-clones now reference dead objects — revert all.
        var ids = new List<int>(_citizenVisuals.Keys);
        foreach (var id in ids) RevertToCapsule(id);
    }
}
