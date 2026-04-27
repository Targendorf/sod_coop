using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

namespace SoDCoop.Sync;

/// <summary>
/// AI Command Streaming NPC sync.
///
/// Because host and client share the same world seed, their NavMesh topologies are
/// identical. Instead of streaming per-frame positions and lerping, the host streams
/// NavMeshAgent destinations + behaviour states. The client re-runs the same
/// NavMeshAgent commands locally, producing smooth natively-animated movement.
///
/// Host:
///   - Every COMMAND_SCAN_RATE (10 Hz) check each in-range citizen.
///   - If destination / speed / behaviour changed → CitizenCommandBatch (ReliableOrdered).
///   - Every CORRECTION_INTERVAL (3 s) send authoritative positions for moving citizens
///     so floating-point drift never accumulates → CitizenCorrectionBatch (Sequenced).
///
/// Client:
///   - CitizenCommandBatch → enable NavMeshAgent, SetDestination, SetSpeed.
///   - CitizenCorrectionBatch → Warp if drift > threshold.
///   - SoD's own AI scheduler still runs on the client (same seed/time), so it often
///     picks the same destination independently; commands keep them in sync.
///
/// Host-side citizens are NEVER touched — host runs normal authoritative simulation.
/// </summary>
public class WorldSync
{
    #region Tuning

    private const float COMMAND_SCAN_RATE    = 0.1f;   // s — host scans for destination changes (10 Hz)
    private const float CORRECTION_INTERVAL  = 3.0f;   // s — authoritative position correction
    private const float NPC_SYNC_RANGE       = 50f;    // m around any player
    private const int   MAX_CMDS_PER_BATCH   = 30;
    private const int   MAX_CORR_PER_BATCH   = 30;
    private const float MIN_DEST_DELTA       = 0.3f;   // m — resend if destination moved more than this
    private const float MIN_SPEED_DELTA      = 0.2f;   // m/s — resend if speed changed more than this
    private const float CORRECTION_LERP_DIST = 0.5f;   // m — soft nudge above this
    private const float CORRECTION_SNAP_DIST = 4.0f;   // m — hard snap above this
    private const float WALK_SPEED_THRESHOLD = 2.5f;   // m/s — above this = Running state

    #endregion

    public int SyncedSeed { get; private set; }

    private float _lastCommandScan;
    private float _lastCorrectionScan;
    private readonly NetDataWriter _writer = new();

    // ── Host-side: per-citizen last-sent state ────────────────────────────────
    private readonly Dictionary<int, HostSentState> _hostSent = new();

    // ── Client-side: per-citizen agent/behaviour tracking ────────────────────
    private readonly Dictionary<int, ClientCitizenState> _clientStates = new();

    private struct HostSentState
    {
        public Vector3               LastDestination;
        public float                 LastSpeed;
        public CitizenBehaviourState LastBehaviour;
        public bool                  IsDead;
        public float                 LastCommandSentAt;
        public float                 LastCorrectionSentAt;
    }

    private struct ClientCitizenState
    {
        public bool                  RootMotionDisabled;
        public CitizenBehaviourState BehaviourState;
        public bool                  IsDead;
    }

    // -------------------------------------------------------------------------
    //  Update
    // -------------------------------------------------------------------------

    public void Update()
    {
        if (!NetworkManager.IsConnected) return;
        if (!WorldReadyGate.IsWorldReady) return;

        if (!NetworkManager.IsHost) return;

        float now = Time.unscaledTime;

        if (now - _lastCommandScan >= COMMAND_SCAN_RATE)
        {
            _lastCommandScan = now;
            HostScanCommands(now);
        }

        if (now - _lastCorrectionScan >= CORRECTION_INTERVAL)
        {
            _lastCorrectionScan = now;
            HostSendCorrections(now);
        }
    }

    // -------------------------------------------------------------------------
    //  Host: scan for changed destinations → CitizenCommandBatch
    // -------------------------------------------------------------------------

    private void HostScanCommands(float now)
    {
        var anchors = GetAnchorPositions();
        if (anchors.Count == 0) return;

        var cmds = new List<CitizenCommandPacket>(MAX_CMDS_PER_BATCH);

        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                if (cmds.Count >= MAX_CMDS_PER_BATCH) break;

                var human = kv.Value;
                if (human == null || human.gameObject == null) continue;
                if (IsLocalPlayerHuman(human)) continue;

                var pos = human.transform.position;
                if (!IsAnchorReachable(pos, anchors)) continue;

                int  id     = kv.Key;
                bool isDead = SafeIsDead(human);

                var   agent = GetAgent(human);
                // Prefer NewAIController.currentDestinationPositon — this is what SoD's
                // pathfinder writes directly; NavMeshAgent.destination lags by one frame.
                var   aiCtrl = GetNewAIController(human);
                var   dest   = aiCtrl != null ? aiCtrl.currentDestinationPositon
                                              : (agent != null && agent.enabled ? agent.destination : pos);
                // movementAmount is 0-1 float; agent.speed is m/s — send both packed as speed
                float speed  = agent != null ? agent.speed : 0f;
                var   state  = InferBehaviourState(human, agent, aiCtrl, isDead);

                bool send;
                if (_hostSent.TryGetValue(id, out var prev))
                {
                    bool destMoved    = Vector3.Distance(dest, prev.LastDestination) > MIN_DEST_DELTA;
                    bool speedChanged = Mathf.Abs(speed - prev.LastSpeed)            > MIN_SPEED_DELTA;
                    bool stateChanged = state != prev.LastBehaviour || isDead != prev.IsDead;
                    bool stale        = now - prev.LastCommandSentAt > CORRECTION_INTERVAL;
                    send = destMoved || speedChanged || stateChanged || stale;
                }
                else
                {
                    send = true; // first contact
                }

                if (!send) continue;

                cmds.Add(new CitizenCommandPacket
                {
                    CitizenId      = id,
                    Destination    = dest,
                    Speed          = speed,
                    BehaviourState = state,
                    IsDead         = isDead,
                });

                _hostSent.TryGetValue(id, out var s);
                s.LastDestination   = dest;
                s.LastSpeed         = speed;
                s.LastBehaviour     = state;
                s.IsDead            = isDead;
                s.LastCommandSentAt = now;
                _hostSent[id]       = s;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"WorldSync.HostScanCommands: {ex.Message}");
            return;
        }

        if (cmds.Count == 0) return;

        _writer.Reset();
        _writer.Put(cmds.Count);
        foreach (var c in cmds) c.Serialize(_writer);

        // ReliableOrdered: destination changes must arrive in order, never dropped
        NetworkManager.SendToAll(PacketType.CitizenCommandBatch, _writer, DeliveryMethod.ReliableOrdered);
    }

    // -------------------------------------------------------------------------
    //  Host: periodic authoritative corrections → CitizenCorrectionBatch
    // -------------------------------------------------------------------------

    private void HostSendCorrections(float now)
    {
        var anchors = GetAnchorPositions();
        if (anchors.Count == 0) return;

        var corrs = new List<CitizenCorrectionPacket>(MAX_CORR_PER_BATCH);

        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                if (corrs.Count >= MAX_CORR_PER_BATCH) break;

                var human = kv.Value;
                if (human == null || human.gameObject == null) continue;
                if (IsLocalPlayerHuman(human)) continue;
                if (SafeIsDead(human)) continue;

                var pos = human.transform.position;
                if (!IsAnchorReachable(pos, anchors)) continue;

                // Skip stationary citizens — they don't accumulate drift
                if (_hostSent.TryGetValue(kv.Key, out var prev))
                {
                    if (prev.LastBehaviour == CitizenBehaviourState.Idle    ||
                        prev.LastBehaviour == CitizenBehaviourState.Sitting  ||
                        prev.LastBehaviour == CitizenBehaviourState.Sleeping ||
                        prev.LastBehaviour == CitizenBehaviourState.Talking)
                        continue;
                }

                corrs.Add(new CitizenCorrectionPacket
                {
                    CitizenId = kv.Key,
                    Position  = pos,
                    YawByte   = CitizenCorrectionPacket.CompressYaw(human.transform.rotation),
                });

                if (_hostSent.TryGetValue(kv.Key, out var s))
                {
                    s.LastCorrectionSentAt = now;
                    _hostSent[kv.Key] = s;
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"WorldSync.HostSendCorrections: {ex.Message}");
            return;
        }

        if (corrs.Count == 0) return;

        _writer.Reset();
        _writer.Put(corrs.Count);
        foreach (var c in corrs) c.Serialize(_writer);

        // Sequenced: drop older correction packets, only apply the latest
        NetworkManager.SendToAll(PacketType.CitizenCorrectionBatch, _writer, DeliveryMethod.Sequenced);
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
            case PacketType.CitizenCommandBatch:
                if (!NetworkManager.IsHost) OnCommandBatch(reader);
                break;
            case PacketType.CitizenCorrectionBatch:
                if (!NetworkManager.IsHost) OnCorrectionBatch(reader);
                break;
            case PacketType.CitizenDeath:
                OnCitizenDeath(reader);
                break;
        }
    }

    // ── Command batch ─────────────────────────────────────────────────────────

    private void OnCommandBatch(NetPacketReader reader)
    {
        try
        {
            int count = reader.GetInt();
            for (int i = 0; i < count; i++)
            {
                var cmd = new CitizenCommandPacket();
                cmd.Deserialize(reader);
                ApplyCitizenCommand(cmd);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"OnCommandBatch: {ex.Message}");
        }
    }

    private void ApplyCitizenCommand(CitizenCommandPacket cmd)
    {
        var human = NetworkIdResolver.GetHuman(cmd.CitizenId);
        if (human == null || human.gameObject == null) return;

        _clientStates.TryGetValue(cmd.CitizenId, out var s);
        s.BehaviourState = cmd.BehaviourState;
        s.IsDead         = cmd.IsDead;
        _clientStates[cmd.CitizenId] = s;

        // Dead or stationary — stop the agent
        if (cmd.IsDead || cmd.BehaviourState == CitizenBehaviourState.Dead)
        {
            StopAgent(human);
            return;
        }

        if (cmd.BehaviourState == CitizenBehaviourState.Sitting  ||
            cmd.BehaviourState == CitizenBehaviourState.Sleeping  ||
            cmd.BehaviourState == CitizenBehaviourState.Talking)
        {
            StopAgent(human);
            return;
        }

        // Moving — drive NavMeshAgent to host's destination
        try
        {
            var agent = GetOrEnableAgent(human, cmd.CitizenId);
            if (agent == null) return;

            agent.speed = cmd.Speed;

            if (Vector3.Distance(agent.destination, cmd.Destination) > MIN_DEST_DELTA)
                agent.SetDestination(cmd.Destination);

            if (agent.isStopped) agent.isStopped = false;

            // Tell SoD's animation controller the speed changed so the walk/run
            // blend tree updates immediately, not on the next AI tick.
            var animCtrl = GetAnimController(human);
            animCtrl?.UpdateMovementSpeed();
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyCitizenCommand({cmd.CitizenId}): {ex.Message}");
        }
    }

    // ── Correction batch ──────────────────────────────────────────────────────

    private void OnCorrectionBatch(NetPacketReader reader)
    {
        try
        {
            int count = reader.GetInt();
            for (int i = 0; i < count; i++)
            {
                var corr = new CitizenCorrectionPacket();
                corr.Deserialize(reader);
                ApplyCorrection(corr);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"OnCorrectionBatch: {ex.Message}");
        }
    }

    private void ApplyCorrection(CitizenCorrectionPacket corr)
    {
        var human = NetworkIdResolver.GetHuman(corr.CitizenId);
        if (human == null || human.gameObject == null) return;

        // Don't correct dead or truly stationary citizens
        if (_clientStates.TryGetValue(corr.CitizenId, out var s))
        {
            if (s.IsDead ||
                s.BehaviourState == CitizenBehaviourState.Sitting  ||
                s.BehaviourState == CitizenBehaviourState.Sleeping)
                return;
        }

        float drift = Vector3.Distance(human.transform.position, corr.Position);

        if (drift > CORRECTION_SNAP_DIST)
        {
            // Hard snap — citizen badly out of sync (teleport, room change)
            Plugin.Log.LogInfo($"Correction SNAP citizen {corr.CitizenId} drift={drift:F1}m");
            var agent = GetAgent(human);
            if (agent != null && agent.enabled)
                agent.Warp(corr.Position);
            else
                human.transform.position = corr.Position;

            human.transform.rotation = corr.GetRotation();
        }
        else if (drift > CORRECTION_LERP_DIST)
        {
            // Soft nudge — push 30% toward host position via NavMesh Warp
            Vector3 nudged = Vector3.Lerp(human.transform.position, corr.Position, 0.3f);
            var agent = GetAgent(human);
            if (agent != null && agent.enabled)
                agent.Warp(nudged);
            else
                human.transform.position = nudged;
        }
        // else: within tolerance — do nothing
    }

    // ── Citizen death ─────────────────────────────────────────────────────────

    private void OnCitizenDeath(NetPacketReader reader)
    {
        try
        {
            int id = reader.GetInt();
            var human = NetworkIdResolver.GetHuman(id);
            if (human != null) StopAgent(human);

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

    // -------------------------------------------------------------------------
    //  NavMeshAgent helpers (IL2CPP-safe — string-based GetComponent + TryCast)
    // -------------------------------------------------------------------------

    /// <summary>Get NavMeshAgent via string lookup to avoid IL2CPP generic-store failures.</summary>
    private static NavMeshAgent GetAgent(Human human)
    {
        try
        {
            var comp = human.gameObject.GetComponent("NavMeshAgent");
            return comp?.TryCast<NavMeshAgent>();
        }
        catch { return null; }
    }

    /// <summary>
    /// Get SoD's NewAIController — contains currentDestinationPositon and movementAmount,
    /// which are more direct than reading NavMeshAgent.destination.
    /// </summary>
    private static NewAIController GetNewAIController(Human human)
    {
        try
        {
            var comp = human.gameObject.GetComponent("NewAIController");
            return comp?.TryCast<NewAIController>();
        }
        catch { return null; }
    }

    /// <summary>
    /// Get SoD's CitizenAnimationController — exposes UpdateMovementSpeed(),
    /// ForceUpdateAnimationSate(), SetDead(), SetInBed() etc.
    /// From CitizenDiag we know it lives on the "Model" direct child of the citizen.
    /// CitizenAnimationController is an Assembly-CSharp type, so generic GetComponent works.
    /// </summary>
    private static CitizenAnimationController GetAnimController(Human human)
    {
        try
        {
            // Fast path: SoD always puts CitizenAnimationController on the "Model" child.
            var model = human.transform.Find("Model");
            if (model != null)
            {
                var comp = model.gameObject.GetComponent("CitizenAnimationController");
                if (comp != null) return comp.TryCast<CitizenAnimationController>();
            }
            // Fallback: search the whole hierarchy.
            return human.GetComponentInChildren<CitizenAnimationController>(true);
        }
        catch { return null; }
    }

    /// <summary>
    /// Get (or re-enable) a citizen's NavMeshAgent on the client.
    /// On first call also disables Animator root motion so it doesn't fight the agent.
    /// We intentionally leave the NavMeshAgent enabled — it is what makes the citizen
    /// walk. We disable SoD's high-level scheduler by overriding its destination every
    /// COMMAND_SCAN_RATE, which is fast enough that any counter-write is invisible.
    /// </summary>
    private NavMeshAgent GetOrEnableAgent(Human human, int citizenId)
    {
        try
        {
            var agent = GetAgent(human);
            if (agent == null) return null;

            if (!agent.enabled) agent.enabled = true;

            // One-time: disable root motion so animation doesn't write delta-pos to transform
            if (_clientStates.TryGetValue(citizenId, out var s) && !s.RootMotionDisabled)
            {
                DisableRootMotion(human);
                s.RootMotionDisabled = true;
                _clientStates[citizenId] = s;
            }

            return agent;
        }
        catch { return null; }
    }

    private static void StopAgent(Human human)
    {
        try
        {
            var agent = GetAgent(human);
            if (agent != null && agent.enabled)
            {
                agent.isStopped = true;
                try { agent.ResetPath(); } catch { }
            }
        }
        catch { }

        // Force the animation controller to update immediately so the idle
        // blend state kicks in right away (no walking-in-place artefact).
        try
        {
            var animCtrl = GetAnimController(human);
            animCtrl?.UpdateMovementSpeed();
        }
        catch { }
    }

    private static void DisableRootMotion(Human human)
    {
        try
        {
            var animators = human.GetComponentsInChildren<Animator>(true);
            if (animators == null) return;
            for (int i = 0; i < animators.Count; i++)
            {
                var anim = animators[i];
                if (anim != null) anim.applyRootMotion = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DisableRootMotion({human.humanID}): {ex.Message}");
        }
    }

    // -------------------------------------------------------------------------
    //  Behaviour inference (host side only)
    // -------------------------------------------------------------------------

    private static CitizenBehaviourState InferBehaviourState(
        Human human, NavMeshAgent agent, NewAIController aiCtrl, bool isDead)
    {
        if (isDead) return CitizenBehaviourState.Dead;

        // movementAmount (0-1) from NewAIController is the authoritative speed signal.
        // Fall back to NavMeshAgent.velocity if the AI controller isn't available.
        float moveAmt = aiCtrl?.movementAmount ?? (agent?.velocity.magnitude ?? 0f);

        if (agent == null || !agent.enabled || agent.isStopped || moveAmt < 0.05f)
            return CitizenBehaviourState.Idle;

        // speed > threshold → Running; otherwise Walking
        float agentSpeed = agent?.speed ?? 0f;
        if (agentSpeed > WALK_SPEED_THRESHOLD) return CitizenBehaviourState.Running;
        return CitizenBehaviourState.Walking;
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
        _hostSent.Clear();
    }
}
