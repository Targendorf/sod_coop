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
    /// Detach the player's current visual from the RemotePlayer wrapper,
    /// add a single Rigidbody + CapsuleCollider, and apply a hit impulse so
    /// the body falls like a sack. The detached corpse becomes a free-
    /// floating GameObject; the wrapper transform keeps following snapshot
    /// updates (with the nametag label hovering at the player's "current"
    /// position — usually frozen since dead players don't move).
    ///
    /// <para>Returns the detached corpse GameObject so the caller can hold
    /// onto it and pass it back to <see cref="DestroyCorpseAndRespawnVisual"/>
    /// on revive. Returns null if no visual is currently attached.</para>
    /// </summary>
    public static GameObject DetachVisualAsCorpse(int playerId, Vector3 hitDirection)
    {
        try
        {
            if (!_citizenVisuals.TryGetValue(playerId, out var visual) || visual == null)
            {
                // Player is on capsule fallback — detach the capsule instead.
                if (!_players.TryGetValue(playerId, out var rp) || rp == null) return null;
                visual = FindCapsuleChild(rp.gameObject);
                if (visual == null) return null;
            }

            // Capture world pose before reparenting so the corpse stays put.
            Vector3 worldPos = visual.transform.position;
            Quaternion worldRot = visual.transform.rotation;
            visual.transform.SetParent(null, false);
            visual.transform.position = worldPos;
            visual.transform.rotation = worldRot;
            visual.name = $"RemotePlayer_{playerId}_corpse";

            // Freeze any animator so the body doesn't keep playing idle/walk
            // while flopping.
            try
            {
                foreach (var anim in visual.GetComponentsInChildren<Animator>(true))
                    if (anim != null) anim.enabled = false;
            }
            catch { }

            // Add basic rigidbody + capsule collider so it drops and lies on
            // the floor. CitizenVisualCloner stripped the original ragdoll
            // bones, so this is a single-rigidbody fake — visually reads as
            // "a body fell over" without true bone-level ragdoll.
            var rb = visual.GetComponent<Rigidbody>();
            if (rb == null) rb = visual.AddComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity  = true;
            rb.mass        = 70f;
            try { rb.drag = 0.5f; rb.angularDrag = 1.5f; } catch { }

            var col = visual.GetComponent<Collider>();
            if (col == null)
            {
                var cap = visual.AddComponent<CapsuleCollider>();
                cap.height    = 1.7f;
                cap.radius    = 0.32f;
                cap.center    = new Vector3(0f, 0.85f, 0f);
                cap.direction = 1; // Y-axis
            }
            else
            {
                col.enabled = true;
            }

            // Hit impulse: push slightly back-and-up plus a random tumble.
            Vector3 dir = hitDirection.sqrMagnitude > 0.0001f ? hitDirection.normalized : -visual.transform.forward;
            Vector3 impulse = dir * 4.5f + Vector3.up * 2.5f;
            rb.AddForce(impulse, ForceMode.Impulse);
            rb.AddTorque(Random.insideUnitSphere * 4f, ForceMode.Impulse);

            // Stop tracking — the visual is no longer "the player's avatar".
            _citizenVisuals.Remove(playerId);

            return visual;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DetachVisualAsCorpse({playerId}): {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Destroys a previously-detached corpse and re-attaches a fresh visual
    /// to the RemotePlayer wrapper. Called on revive (PlayerVitals.IsDead
    /// transition true→false).
    /// </summary>
    public static void DestroyCorpseAndRespawnVisual(int playerId, GameObject corpse)
    {
        try
        {
            if (corpse != null)
            {
                Object.Destroy(corpse);
            }
            // Re-show capsule fallback in case the upgrade can't run yet.
            if (_players.TryGetValue(playerId, out var rp) && rp != null && rp.gameObject != null)
            {
                SetCapsuleActive(rp.gameObject, true);
            }
            // If the world is still loaded, re-clone a fresh body.
            if (WorldReadyGate.IsWorldReady)
            {
                TryUpgradeVisual(playerId);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DestroyCorpseAndRespawnVisual({playerId}): {ex.Message}");
        }
    }

    /// <summary>Show or hide a remote player's stand-in body — the cloned
    /// citizen visual plus the capsule fallback — while leaving the nametag
    /// label and the RemotePlayer wrapper itself alone.
    ///
    /// <para>Used when the player's TWIN citizen takes over as the visible
    /// body (see <c>RemotePlayer.DriveTwin</c>). The stand-in is a stripped
    /// clone of a RANDOM citizen picked by seed — it was built before twins
    /// existed and is not the player's actual character. The twin is: it
    /// carries their chosen appearance, name and outfit, and it is a real
    /// <c>Human</c> the game's AI can perceive. Showing both would put two
    /// bodies in the same spot.</para></summary>
    public static void SetStandInVisualVisible(int playerId, bool visible)
    {
        try
        {
            if (_citizenVisuals.TryGetValue(playerId, out var v) && v != null && v.activeSelf != visible)
                v.SetActive(visible);

            if (_players.TryGetValue(playerId, out var rp) && rp != null && rp.gameObject != null)
            {
                for (int i = 0; i < rp.gameObject.transform.childCount; i++)
                {
                    var child = rp.gameObject.transform.GetChild(i);
                    if (child == null || child.name != "CapsuleVisual") continue;
                    if (child.gameObject.activeSelf != visible) child.gameObject.SetActive(visible);
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[RemotePlayerManager] SetStandInVisualVisible({playerId},{visible}): {ex.Message}");
        }
    }

    private static GameObject FindCapsuleChild(GameObject root)
    {
        if (root == null) return null;
        for (int i = 0; i < root.transform.childCount; i++)
        {
            var child = root.transform.GetChild(i);
            if (child != null && child.name == "CapsuleVisual" && child.gameObject.activeSelf)
                return child.gameObject;
        }
        return null;
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

        // If a position packet already created this RemotePlayer with a
        // placeholder name, just update the existing instance instead of
        // duplicating it.
        if (_players.TryGetValue(playerId, out var existing) && existing != null)
        {
            existing.UpdateName(playerName);
            return;
        }

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
