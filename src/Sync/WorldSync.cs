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
    // 1e6 = effectively no gate. NPCs sync across the entire map regardless of
    // distance to any player. SoD's tiered tick-rate system handles host-side
    // CPU cost; what kept the bandwidth bounded was the deadband in destination/
    // speed deltas (NPCs only emit when their target actually changes), so
    // dropping the range gate doesn't flood the wire — idle NPCs still don't
    // send. See PromoteRemoteTickRates for the companion fix that prevents
    // tick-rate divergence between host and clients in different parts of town.
    private const float NPC_SYNC_RANGE       = 1_000_000f;
    private const int   MAX_CMDS_PER_BATCH   = 30;
    private const int   MAX_CORR_PER_BATCH   = 30;
    private const float MIN_DEST_DELTA       = 0.3f;   // m — resend if destination moved more than this
    private const float MIN_SPEED_DELTA      = 0.2f;   // m/s — resend if speed changed more than this
    private const float CORRECTION_LERP_DIST = 0.5f;   // m — soft nudge above this
    private const float CORRECTION_SNAP_DIST = 4.0f;   // m — hard snap above this
    private const float WALK_SPEED_THRESHOLD = 2.5f;   // m/s — above this = Running state

    // ── Ownership transfer (client interaction) ───────────────────────────────
    private const float OWNERSHIP_SCAN_RATE     = 0.3f;   // s — how often client checks for nearby citizens
    private const float OWNERSHIP_CLAIM_DIST    = 2.5f;   // m — claim ownership inside this radius
    private const float OWNERSHIP_RELEASE_DIST  = 4.5f;   // m — release outside this radius (hysteresis)

    #endregion

    public int SyncedSeed { get; private set; }

    private float _lastCommandScan;
    private float _lastCorrectionScan;
    private float _lastOwnershipScan;
    private readonly NetDataWriter _writer = new();
    private readonly NetDataWriter _ownershipWriter = new();

    // ── Ownership tracking ────────────────────────────────────────────────────
    /// <summary>Host-side: which player owns each citizen (missing = host owns).</summary>
    private readonly Dictionary<int, int> _citizenOwners = new();

    /// <summary>Client-side: which citizens THIS client currently owns (interaction range).</summary>
    private readonly HashSet<int> _myOwnedCitizens = new();

    /// <summary>Both sides: citizens whose AI is currently paused due to client ownership.</summary>
    private readonly HashSet<int> _pausedAI = new();

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
        public bool                  AIControllerDisabled; // NewAIController.enabled = false done
        public bool                  RootMotionDisabled;   // applyRootMotion = false done
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

        float now = Time.unscaledTime;

        if (NetworkManager.IsHost)
        {
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

            // Throttled per-frame promotion of NPC tick rates to match the
            // closest peer's needs. Without this, an NPC far from the host but
            // close to a client would tick rarely on the host (low rate ⇒
            // rare destination updates ⇒ stale movement on the client).
            PromoteRemoteTickRates();
        }
        else
        {
            // Client: scan nearby citizens to claim/release ownership for interactions.
            if (now - _lastOwnershipScan >= OWNERSHIP_SCAN_RATE)
            {
                _lastOwnershipScan = now;
                ClientOwnershipScan();
            }
        }
    }

    // -------------------------------------------------------------------------
    //  Client-side ownership scanner — claim nearby citizens, release distant
    // -------------------------------------------------------------------------

    private void ClientOwnershipScan()
    {
        try
        {
            var localPlayer = global::Player.Instance;
            if (localPlayer == null) return;

            Vector3 myPos = localPlayer.transform.position;
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            // Step 1: release citizens we own that drifted out of range / disappeared.
            // Buffer to a list — can't modify HashSet during iteration.
            List<int> toRelease = null;
            foreach (var id in _myOwnedCitizens)
            {
                var human = NetworkIdResolver.GetHuman(id);
                if (human == null || human.gameObject == null)
                {
                    (toRelease ??= new()).Add(id);
                    continue;
                }
                float d = Vector3.Distance(human.transform.position, myPos);
                if (d > OWNERSHIP_RELEASE_DIST)
                    (toRelease ??= new()).Add(id);
            }
            if (toRelease != null)
                foreach (var id in toRelease) ClientReleaseOwnership(id);

            // Step 2: claim nearby citizens we don't already own.
            foreach (var kv in dict)
            {
                int id = kv.Key;
                if (_myOwnedCitizens.Contains(id)) continue;

                var human = kv.Value;
                if (human == null || human.gameObject == null) continue;
                if (IsLocalPlayerHuman(human)) continue;
                if (SafeIsDead(human)) continue;

                float d = Vector3.Distance(human.transform.position, myPos);
                if (d < OWNERSHIP_CLAIM_DIST)
                    ClientClaimOwnership(id, human);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"ClientOwnershipScan: {ex.Message}");
        }
    }

    private void ClientClaimOwnership(int citizenId, Human human)
    {
        _myOwnedCitizens.Add(citizenId);

        // Notify host so it pauses its own AI for this citizen and stops broadcasting.
        SendOwnershipPacket(PacketType.CitizenOwnershipClaim, citizenId);

        // Locally re-enable SoD's AI so dialog / combat / fear etc. work natively.
        EnableAIController(human);
        EnableRootMotion(human);
        _pausedAI.Remove(citizenId);

        Plugin.Log.LogInfo($"[Ownership] Claimed citizen {citizenId} (interaction range)");
    }

    private void ClientReleaseOwnership(int citizenId)
    {
        if (!_myOwnedCitizens.Remove(citizenId)) return;

        SendOwnershipPacket(PacketType.CitizenOwnershipRelease, citizenId);

        // Disable local AI again — host resumes authoritative control.
        var human = NetworkIdResolver.GetHuman(citizenId);
        if (human != null && human.gameObject != null)
        {
            DisableAIController(human);
            DisableRootMotion(human);
        }

        // Force a re-init of clientStates so the next host command re-applies cleanly.
        if (_clientStates.TryGetValue(citizenId, out var s))
        {
            s.AIControllerDisabled = true;  // we just disabled it
            s.RootMotionDisabled   = true;
            _clientStates[citizenId] = s;
        }

        Plugin.Log.LogInfo($"[Ownership] Released citizen {citizenId} (left interaction range)");
    }

    private void SendOwnershipPacket(PacketType type, int citizenId)
    {
        var packet = new CitizenOwnershipPacket
        {
            Type      = type,
            CitizenId = citizenId,
            OwnerId   = NetworkManager.LocalPlayerId,
        };
        _ownershipWriter.Reset();
        packet.Serialize(_ownershipWriter);
        NetworkManager.SendToHost(type, _ownershipWriter, DeliveryMethod.ReliableOrdered);
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

                int  id     = kv.Key;

                // Skip citizens currently owned by a client — they're being driven
                // by that client's local AI for an interaction (dialog, combat, etc.).
                if (_citizenOwners.ContainsKey(id)) continue;

                var pos = human.transform.position;
                if (!IsAnchorReachable(pos, anchors)) continue;

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

                // Skip client-owned citizens — they don't need correction during interaction.
                if (_citizenOwners.ContainsKey(kv.Key)) continue;

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
            case PacketType.CitizenOwnershipClaim:
                OnOwnershipClaim(reader, senderId);
                break;
            case PacketType.CitizenOwnershipRelease:
                OnOwnershipRelease(reader, senderId);
                break;
        }
    }

    // -------------------------------------------------------------------------
    //  Ownership packet handlers (host-side authority + client mirror)
    // -------------------------------------------------------------------------

    private void OnOwnershipClaim(NetPacketReader reader, int senderId)
    {
        var p = new CitizenOwnershipPacket();
        p.Deserialize(reader);

        if (!NetworkManager.IsHost) return;  // only host tracks ownership table

        _citizenOwners[p.CitizenId] = p.OwnerId;

        // Pause host-side AI for this citizen so it stays put while the client
        // interacts with it. Saved to _pausedAI so we know to re-enable on release.
        var human = NetworkIdResolver.GetHuman(p.CitizenId);
        if (human != null && human.gameObject != null && _pausedAI.Add(p.CitizenId))
        {
            DisableAIController(human);
        }

        Plugin.Log.LogInfo($"[Ownership] Client {p.OwnerId} claimed citizen {p.CitizenId}");
    }

    private void OnOwnershipRelease(NetPacketReader reader, int senderId)
    {
        var p = new CitizenOwnershipPacket();
        p.Deserialize(reader);

        if (!NetworkManager.IsHost) return;

        // Only release if the sender actually owned it (prevent stray packets clearing state).
        if (_citizenOwners.TryGetValue(p.CitizenId, out var current) && current == p.OwnerId)
        {
            _citizenOwners.Remove(p.CitizenId);
        }

        // Resume host-side AI.
        if (_pausedAI.Remove(p.CitizenId))
        {
            var human = NetworkIdResolver.GetHuman(p.CitizenId);
            if (human != null && human.gameObject != null)
                EnableAIController(human);
        }

        // Force a re-send of this citizen's state on the next scan tick.
        _hostSent.Remove(p.CitizenId);

        Plugin.Log.LogInfo($"[Ownership] Client {p.OwnerId} released citizen {p.CitizenId}");
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
        // We own this citizen for an interaction — let SoD's AI drive it locally.
        if (_myOwnedCitizens.Contains(cmd.CitizenId)) return;

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
        // Skip if we own this citizen — SoD's local AI is driving it.
        if (_myOwnedCitizens.Contains(corr.CitizenId)) return;

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
    ///
    /// On first call (per citizen):
    ///   1. Disable NewAIController — stops SoD's scheduler from overwriting
    ///      NavMeshAgent.destination every frame (~60 Hz). Without this, SoD wins 9
    ///      out of 10 frames and our 10 Hz SetDestination has no lasting effect.
    ///   2. Disable Animator root motion — prevents animation delta-pos from
    ///      fighting our NavMeshAgent-driven movement.
    ///
    /// NavMeshAgent stays ENABLED so the citizen pathfinds locally using the
    /// destination we supply from the host — smooth movement, correct animation.
    /// </summary>
    private NavMeshAgent GetOrEnableAgent(Human human, int citizenId)
    {
        try
        {
            var agent = GetAgent(human);
            if (agent == null) return null;

            if (!agent.enabled) agent.enabled = true;

            _clientStates.TryGetValue(citizenId, out var s);
            bool changed = false;

            // One-time: kill SoD's AI scheduler so it stops competing with us.
            if (!s.AIControllerDisabled)
            {
                DisableAIController(human);
                s.AIControllerDisabled = true;
                changed = true;
            }

            // One-time: disable root motion so animation doesn't write delta-pos to transform.
            if (!s.RootMotionDisabled)
            {
                DisableRootMotion(human);
                s.RootMotionDisabled = true;
                changed = true;
            }

            if (changed) _clientStates[citizenId] = s;

            return agent;
        }
        catch { return null; }
    }

    /// <summary>
    /// Disable SoD's NewAIController MonoBehaviour on this citizen.
    /// Setting enabled=false stops all Update/FixedUpdate callbacks — the citizen's
    /// schedule, goal evaluation, and NavMeshAgent writes all cease.
    /// NavMeshAgent stays alive and usable; we drive it via SetDestination.
    /// </summary>
    private static void DisableAIController(Human human)
    {
        try
        {
            var comp = human.gameObject.GetComponent("NewAIController");
            if (comp == null) return;
            var ai = comp.TryCast<NewAIController>();
            if (ai != null && ai.enabled)
            {
                ai.enabled = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[WorldSync] DisableAIController({human.humanID}): {ex.Message}");
        }
    }

    /// <summary>Inverse of DisableAIController — used when ownership is transferred.</summary>
    private static void EnableAIController(Human human)
    {
        try
        {
            var comp = human.gameObject.GetComponent("NewAIController");
            if (comp == null) return;
            var ai = comp.TryCast<NewAIController>();
            if (ai != null && !ai.enabled)
            {
                ai.enabled = true;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[WorldSync] EnableAIController({human.humanID}): {ex.Message}");
        }
    }

    /// <summary>Inverse of DisableRootMotion — used when ownership is transferred.</summary>
    private static void EnableRootMotion(Human human)
    {
        try
        {
            var animators = human.GetComponentsInChildren<Animator>(true);
            if (animators == null) return;
            for (int i = 0; i < animators.Count; i++)
            {
                var anim = animators[i];
                if (anim != null) anim.applyRootMotion = true;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"EnableRootMotion({human.humanID}): {ex.Message}");
        }
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

    // ─────────────────────────────────────────────────────────────────────────
    //  Tick-rate promotion for remote players.
    //
    //  SoD's NewAIController.UpdateTickRate computes desiredTickRate from the
    //  distance to the LOCAL Player.Instance. In a co-op scenario where the
    //  host's local player is far from an NPC but a client's player is right
    //  next to it, the host would keep the NPC at veryLow tick rate — meaning
    //  destination updates fire rarely and the client sees the NPC stutter or
    //  freeze.
    //
    //  Fix: each frame, walk a window of the citizen dictionary and compare
    //  every NPC's distance to ALL remote players. If any peer is closer than
    //  the bracket the host's local distance assigned, force-promote
    //  desiredTickRate. We never demote — SoD's own logic already handles
    //  demotion via UpdateTickRate. Throttle to NPCS_PER_PROMOTE_FRAME per
    //  frame to keep CPU bounded; full coverage of ~1500 NPCs at 50/frame
    //  takes ~30 frames (~0.5 s at 60fps).
    // ─────────────────────────────────────────────────────────────────────────

    private const int   NPCS_PER_PROMOTE_FRAME = 50;
    private const float TICK_HIGH_DIST    = 15f;
    private const float TICK_MED_DIST     = 35f;
    private const float TICK_LOW_DIST     = 80f;
    private const float TICK_VLOW_DIST    = 200f;
    private static int  _promoteCursor;
    private static readonly List<int> _citizenKeyCache = new();
    private static int _citizenKeyCacheStamp;

    private static void PromoteRemoteTickRates()
    {
        try
        {
            // Gather remote-player positions once per frame.
            var remoteCount = 0;
            // Stack-allocated mini-buffer would be nicer; List allocation per
            // call is fine, only one list of ≤4 entries.
            var remotePositions = new List<Vector3>(4);
            foreach (var rp in Player.RemotePlayerManager.GetAllPlayers())
            {
                if (rp == null || rp.gameObject == null) continue;
                remotePositions.Add(rp.transform.position);
                remoteCount++;
            }
            if (remoteCount == 0) return;

            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null || dict.Count == 0) return;

            // Refresh the key cache periodically so we iterate stable keys
            // even if the dict gets churned (NPCs spawn/despawn).
            if (_citizenKeyCacheStamp != dict.Count)
            {
                _citizenKeyCache.Clear();
                foreach (var kv in dict) _citizenKeyCache.Add(kv.Key);
                _citizenKeyCacheStamp = dict.Count;
                _promoteCursor = 0;
            }
            if (_citizenKeyCache.Count == 0) return;

            int processed = 0;
            while (processed < NPCS_PER_PROMOTE_FRAME)
            {
                if (_promoteCursor >= _citizenKeyCache.Count) _promoteCursor = 0;
                int humanId = _citizenKeyCache[_promoteCursor++];
                processed++;

                if (!dict.TryGetValue(humanId, out var human) || human == null) continue;
                if (human.transform == null) continue;
                if (SafeIsDead(human)) continue;
                if (IsLocalPlayerHuman(human)) continue;

                var aic = GetNewAIController(human);
                if (aic == null) continue;

                // Min distance from this NPC to any peer.
                Vector3 npcPos = human.transform.position;
                float minDist = float.MaxValue;
                for (int i = 0; i < remotePositions.Count; i++)
                {
                    float d = Vector3.Distance(npcPos, remotePositions[i]);
                    if (d < minDist) minDist = d;
                }

                NewAIController.AITickRate target;
                if      (minDist < TICK_HIGH_DIST)  target = NewAIController.AITickRate.veryHigh;
                else if (minDist < TICK_MED_DIST)   target = NewAIController.AITickRate.high;
                else if (minDist < TICK_LOW_DIST)   target = NewAIController.AITickRate.medium;
                else if (minDist < TICK_VLOW_DIST)  target = NewAIController.AITickRate.low;
                else                                target = NewAIController.AITickRate.veryLow;

                // Only promote (never demote — host's own UpdateTickRate
                // handles that on its tick from local Player distance).
                if ((int)target > (int)aic.desiredTickRate)
                {
                    try
                    {
                        aic.desiredTickRate = target;
                        // forceUpdate=true re-buckets the controller into the
                        // appropriate CitizenBehaviour list so it actually
                        // ticks at the new cadence on the host's next frame.
                        aic.UpdateTickRate(true);
                    }
                    catch { /* SetTickRate quirks — non-fatal */ }
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"WorldSync.PromoteRemoteTickRates: {ex.Message}");
        }
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
        _citizenOwners.Clear();
        _myOwnedCitizens.Clear();
        _pausedAI.Clear();
    }
}
