using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
using Il2CppInterop.Runtime;

namespace SoDCoop.Sync;

/// <summary>
/// Megabonk-style NPC sync.
///
/// Host:
///   - Every WORLD_SYNC_RATE seconds scan citizens within NPC_SYNC_RANGE of any player.
///   - Delta-filter: only include citizens that moved/rotated/changed isDead, or are stale.
///   - Pack ≤ MAX_NPCS_PER_BATCH per packet, send via PacketType.CitizenStateBatch (Sequenced).
///
/// Client:
///   - First time we receive state for a citizen, we DISABLE its NavMeshAgent so SoD's AI
///     stops driving its position locally. (Equivalent of megabonk-together prefix-blocking
///     EnemyMovementRb.MyFixedUpdate; we use component disable since SoD's AI class names
///     are not known without source.)
///   - Then we apply the host position via snapshot interpolation: keep last + current target,
///     lerp transform between them across the WORLD_SYNC_RATE window.
///   - When the world unloads (return to menu), all client-side state is dropped.
///
/// Host-side citizens are NEVER touched — host runs its normal authoritative simulation.
/// </summary>
public class WorldSync
{
    #region Tuning

    // Increased from 0.5s (2Hz) → 0.2s (5Hz):
    // At 1.5m/s walk speed, 2Hz gives 0.75m gaps between packets (visible pop even with interp).
    // 5Hz gives 0.3m gaps which lerp invisibly within the window.
    private const float WORLD_SYNC_RATE       = 0.2f;   // s between batches (5 Hz)
    private const float FORCE_RESYNC_INTERVAL = 3f;     // s — re-send a citizen even if static
    // Raised from 20 → 30 to compensate for the higher packet frequency
    private const int   MAX_NPCS_PER_BATCH    = 30;
    private const float NPC_SYNC_RANGE        = 50f;    // m around any player

    // Lowered from 0.5m → 0.1m to catch slow-moving citizens (e.g. idle shuffles)
    private const float MIN_MOVE_DELTA  = 0.1f;
    private const float MIN_ANGLE_DELTA = 10f;

    private const float TELEPORT_DIST   = 8f;   // m — snap rather than lerp above this

    // TODO(known-limitation): NPC visual hash mismatch
    // Host and client load different cities → same humanID may have different outfits/meshes.
    // MVP fix: host should include a deterministic VisualHash (e.g. humanID ^ outfitSeed) per
    // citizen in CitizenStatePacket so the client can swap to the closest-matching local citizen.
    // For now this is a known limitation — positions sync correctly, appearance may differ.

    #endregion

    public int SyncedSeed { get; private set; }

    private float _lastBroadcastTime;
    private readonly NetDataWriter _writer = new();

    /// <summary>Per-citizen last sent state (host).</summary>
    private readonly Dictionary<int, HostSentState> _hostSent = new();

    /// <summary>Per-citizen client-side interp state. Populated only on client.</summary>
    private readonly Dictionary<int, ClientCitizenState> _clientStates = new();

    /// <summary>Citizens whose NavMeshAgent we've already disabled on this client.</summary>
    private readonly HashSet<int> _aiDisabled = new();

    private struct HostSentState
    {
        public Vector3    Position;
        public Quaternion Rotation;
        public bool       IsDead;
        public float      SentAt;
    }

    private struct ClientCitizenState
    {
        public Vector3    PrevPosition;
        public Quaternion PrevRotation;
        public Vector3    TargetPosition;
        public Quaternion TargetRotation;
        public float      AppliedAt;          // local time when we received the latest packet
        public bool       IsDead;
    }

    // -------------------------------------------------------------------------
    //  Update
    // -------------------------------------------------------------------------

    public void Update()
    {
        if (!NetworkManager.IsConnected) return;
        if (!WorldReadyGate.IsWorldReady) return;

        if (NetworkManager.IsHost)
            HostTick();
        else
            ClientTick();
    }

    // -------------------------------------------------------------------------
    //  Host: scan, delta-filter, broadcast
    // -------------------------------------------------------------------------

    private void HostTick()
    {
        float now = Time.unscaledTime;
        if (now - _lastBroadcastTime < WORLD_SYNC_RATE) return;
        _lastBroadcastTime = now;

        var anchors = GetAnchorPositions();
        if (anchors.Count == 0) return;

        var batch = new List<CitizenStatePacket>(MAX_NPCS_PER_BATCH);

        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                if (batch.Count >= MAX_NPCS_PER_BATCH) break;

                var human = kv.Value;
                if (human == null || human.gameObject == null) continue;

                // Don't sync the host's local player (it's already a Human in some games).
                if (IsLocalPlayerHuman(human)) continue;

                var pos = human.transform.position;
                if (!IsAnchorReachable(pos, anchors)) continue;

                int  id     = kv.Key;
                bool isDead = SafeIsDead(human);

                bool send;
                if (_hostSent.TryGetValue(id, out var prev))
                {
                    bool moved        = Vector3.Distance(pos, prev.Position) > MIN_MOVE_DELTA;
                    bool rotated      = Quaternion.Angle(human.transform.rotation, prev.Rotation) > MIN_ANGLE_DELTA;
                    bool stateChanged = prev.IsDead != isDead;
                    bool stale        = now - prev.SentAt > FORCE_RESYNC_INTERVAL;
                    send = moved || rotated || stateChanged || stale;
                }
                else
                {
                    send = true; // first contact
                }

                if (!send) continue;

                batch.Add(new CitizenStatePacket
                {
                    CitizenId         = id,
                    Position          = pos,
                    Rotation          = human.transform.rotation,
                    CurrentAction     = 0,
                    CurrentLocationId = 0,  // InstanceID is per-process — useless across machines
                    IsDead            = isDead,
                    IsUnconscious     = false,
                });

                _hostSent[id] = new HostSentState
                {
                    Position = pos,
                    Rotation = human.transform.rotation,
                    IsDead   = isDead,
                    SentAt   = now,
                };
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"WorldSync.HostTick: {ex.Message}");
            return;
        }

        if (batch.Count == 0) return;

        _writer.Reset();
        _writer.Put(batch.Count);
        foreach (var p in batch)
        {
            p.Serialize(_writer);
        }
        NetworkManager.SendToAll(PacketType.CitizenStateBatch, _writer, DeliveryMethod.Sequenced);
    }

    // -------------------------------------------------------------------------
    //  Client: per-frame interpolation toward host targets
    // -------------------------------------------------------------------------

    private void ClientTick()
    {
        if (_clientStates.Count == 0) return;

        float now = Time.unscaledTime;

        foreach (var kv in _clientStates)
        {
            var human = NetworkIdResolver.GetHuman(kv.Key);
            if (human == null || human.gameObject == null) continue;

            var s = kv.Value;
            if (s.IsDead) continue; // dead citizens — don't move them

            // Lerp factor: how far through the WORLD_SYNC_RATE window we are.
            float t = Mathf.Clamp01((now - s.AppliedAt) / WORLD_SYNC_RATE);
            human.transform.position = Vector3.Lerp(s.PrevPosition, s.TargetPosition, t);
            human.transform.rotation = Quaternion.Slerp(s.PrevRotation, s.TargetRotation, t);
        }
    }

    // -------------------------------------------------------------------------
    //  Receive
    // -------------------------------------------------------------------------

    public void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        switch (type)
        {
            case PacketType.WorldSeed:
                {
                    var p = new WorldSeedPacket();
                    p.Deserialize(reader);
                    SyncedSeed = p.Seed;
                    Plugin.Log.LogInfo($"World seed synced: {p.Seed}, City: {p.CityName}");
                    break;
                }
            case PacketType.CitizenStateBatch:
                OnCitizenBatch(reader);
                break;
            case PacketType.CitizenDeath:
                OnCitizenDeath(reader);
                break;
        }
    }

    private void OnCitizenBatch(NetPacketReader reader)
    {
        if (NetworkManager.IsHost) return; // host doesn't apply its own broadcast

        try
        {
            int count = reader.GetInt();
            float now = Time.unscaledTime;

            for (int i = 0; i < count; i++)
            {
                var p = new CitizenStatePacket();
                p.Deserialize(reader);
                ApplyCitizenState(p, now);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"OnCitizenBatch: {ex.Message}");
        }
    }

    private void OnCitizenDeath(NetPacketReader reader)
    {
        try
        {
            int id = reader.GetInt();
            // No SetHealth call — SoD API not confirmed. Just drop the citizen from sync state
            // so we stop driving its transform; the host-driven death animation will play locally
            // when the actual death state arrives in the next batch.
            if (_clientStates.TryGetValue(id, out var s))
            {
                s.IsDead = true;
                _clientStates[id] = s;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"OnCitizenDeath: {ex.Message}");
        }
    }

    private void ApplyCitizenState(CitizenStatePacket packet, float now)
    {
        var human = NetworkIdResolver.GetHuman(packet.CitizenId);
        if (human == null || human.gameObject == null) return;

        // First contact: kill the AI driver so it doesn't fight our transform writes.
        // This is the megabonk-together equivalent of prefix-blocking EnemyMovementRb.
        if (!_aiDisabled.Contains(packet.CitizenId))
        {
            _aiDisabled.Add(packet.CitizenId);
            DisableAI(human);
        }

        // Build / update interp record. On big jumps (room/floor change) snap directly.
        Vector3 currentPos = human.transform.position;
        bool teleport = !_clientStates.ContainsKey(packet.CitizenId)
                     || Vector3.Distance(currentPos, packet.Position) > TELEPORT_DIST;

        if (teleport)
        {
            human.transform.position = packet.Position;
            human.transform.rotation = packet.Rotation;
            _clientStates[packet.CitizenId] = new ClientCitizenState
            {
                PrevPosition   = packet.Position,
                PrevRotation   = packet.Rotation,
                TargetPosition = packet.Position,
                TargetRotation = packet.Rotation,
                AppliedAt      = now,
                IsDead         = packet.IsDead,
            };
            return;
        }

        var prev = _clientStates[packet.CitizenId];
        _clientStates[packet.CitizenId] = new ClientCitizenState
        {
            // PrevPosition is "where we are visually right now", so the next lerp starts smoothly.
            PrevPosition   = currentPos,
            PrevRotation   = human.transform.rotation,
            TargetPosition = packet.Position,
            TargetRotation = packet.Rotation,
            AppliedAt      = now,
            IsDead         = packet.IsDead,
        };
    }

    /// <summary>
    /// Stop SoD's AI from driving this citizen on the client.
    ///
    /// 1. NavMeshAgent: stop + clear path + disable.
    ///    Use string-based GetComponent to bypass IL2CPP generic method store
    ///    initialization failure for GetComponent&lt;NavMeshAgent&gt;().
    ///
    /// 2. Animator root motion: set applyRootMotion=false so the animation
    ///    clip no longer writes delta-position/rotation to the transform.
    ///    Without this, the idle/walk animation's root motion fights our
    ///    per-frame transform writes and makes citizens "walk backwards".
    /// </summary>
    private static void DisableAI(Human human)
    {
        // ── NavMeshAgent ───────────────────────────────────────────────────
        try
        {
            var agentComp = human.gameObject.GetComponent("NavMeshAgent");
            if (agentComp != null)
            {
                var agent = agentComp.TryCast<NavMeshAgent>();
                if (agent != null && agent.enabled)
                {
                    agent.isStopped = true;
                    try { agent.ResetPath(); } catch { }
                    agent.enabled = false;
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DisableAI NavMeshAgent({human.humanID}): {ex.Message}");
        }

        // ── Animator root motion ───────────────────────────────────────────
        // Animator is a standard UnityEngine type; generic GetComponent works.
        try
        {
            // Search citizen's whole hierarchy — SoD may keep the Animator on a child.
            var animators = human.GetComponentsInChildren<Animator>(true);
            if (animators != null)
            {
                for (int i = 0; i < animators.Count; i++)
                {
                    var anim = animators[i];
                    if (anim != null)
                        anim.applyRootMotion = false;
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DisableAI Animator({human.humanID}): {ex.Message}");
        }
    }

    // -------------------------------------------------------------------------
    //  World seed (host)
    // -------------------------------------------------------------------------

    public void SyncWorldSeed()
    {
        if (!NetworkManager.IsHost) return;

        var packet = new WorldSeedPacket
        {
            Seed     = GetCurrentWorldSeed(),
            CityName = GetCurrentCityName(),
            CitySize = GetCurrentCitySize(),
        };
        _writer.Reset();
        packet.Serialize(_writer);
        NetworkManager.SendToAll(PacketType.WorldSeed, _writer, DeliveryMethod.ReliableOrdered);
        Plugin.Log.LogInfo($"World seed synced: {packet.Seed}, City: {packet.CityName}");
    }

    // -------------------------------------------------------------------------
    //  Helpers
    // -------------------------------------------------------------------------

    /// <summary>All player positions (local + remote) — citizen sync radius is measured against any of these.</summary>
    private static List<Vector3> GetAnchorPositions()
    {
        var list = new List<Vector3>(4);
        try
        {
            var local = global::Player.Instance;
            if (local != null) list.Add(local.transform.position);
        }
        catch { }

        foreach (var rp in Player.RemotePlayerManager.GetAllPlayers())
        {
            if (rp == null || rp.gameObject == null) continue;
            list.Add(rp.transform.position);
        }
        return list;
    }

    private static bool IsAnchorReachable(Vector3 pos, List<Vector3> anchors)
    {
        for (int i = 0; i < anchors.Count; i++)
            if (Vector3.Distance(pos, anchors[i]) <= NPC_SYNC_RANGE) return true;
        return false;
    }

    private static bool IsLocalPlayerHuman(Human human)
    {
        try
        {
            var p = global::Player.Instance;
            return p != null && p.gameObject == human.gameObject;
        }
        catch { return false; }
    }

    private static bool SafeIsDead(Human human)
    {
        try { return human.isDead; } catch { return false; }
    }

    private static int GetCurrentWorldSeed()
    {
        try
        {
            var city = CityData.Instance;
            if (city != null && !string.IsNullOrEmpty(city.seed))
                return city.seed.GetHashCode();
        }
        catch { }
        return 0;
    }

    private static string GetCurrentCityName()
    {
        try { return CityData.Instance?.cityName ?? "Unknown"; }
        catch { return "Unknown"; }
    }

    private static int GetCurrentCitySize()
    {
        try
        {
            var v = CityData.Instance?.citySize ?? Vector2.zero;
            return ((int)v.x << 16) | ((int)v.y & 0xFFFF);
        }
        catch { return 0; }
    }

    public void ClearClientState()
    {
        _clientStates.Clear();
        _aiDisabled.Clear();
        _hostSent.Clear();
    }
}
