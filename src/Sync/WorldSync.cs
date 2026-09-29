using System.Collections.Generic;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// World seed announcement, citizen interaction ownership, and host-side AI
/// tick-rate promotion for citizens near remote players.
///
/// <para><b>What this class no longer does, and why.</b> It used to be the NPC
/// movement sync, as "AI command streaming": the host scanned every citizen in
/// the city at 10 Hz and streamed NavMeshAgent destinations (ReliableOrdered,
/// map-wide), plus authoritative positions every 3 s, and the client drove a
/// local NavMeshAgent towards each destination. SoD does not use Unity's
/// NavMesh at all — the string <c>NavMeshAgent</c> appears nowhere in the game
/// assembly; citizens walk SoD's own node graph under <c>NewAIController</c>.
/// So <c>GetComponent("NavMeshAgent")</c> always returned null, which meant:</para>
/// <list type="bullet">
///   <item><description>The command stream was pure waste — two GetComponent
///   lookups per citizen per tick on the host, serialised and shipped reliably
///   to clients that dropped every one of them.</description></item>
///   <item><description>The 3 s corrections fell through to direct
///   <c>transform.position</c> writes — snaps past 4 m, 30 % nudges past 0.5 m —
///   while the client's local AI kept walking the citizen its own way, so
///   pedestrians popped every few seconds.</description></item>
///   <item><description>Ownership release switched the client's AI off "so the
///   host resumes authoritative control", but nothing on the host was driving
///   the client's copy, so every citizen a client brushed past became a
///   statue.</description></item>
/// </list>
/// <para>Citizen movement is now owned solely by <see cref="CitizenPositionSync"/>
/// (host-authoritative, interpolated, near each peer). The command/correction
/// packet types are still recognised and ignored so a peer on an older build
/// can't push them into another handler.</para>
///
/// <para><b>What remains:</b></para>
/// <list type="bullet">
///   <item><description><b>World seed</b> announcement on connect.</description></item>
///   <item><description><b>Interaction ownership</b> — a citizen within
///   <see cref="OWNERSHIP_CLAIM_DIST"/> of a client is handed to that client's
///   local AI (dialog, fear, combat reactions run natively there) and held still
///   on the host until released. <see cref="CitizenPositionSync"/> steps aside
///   for owned citizens and takes them back on release.</description></item>
///   <item><description><b>Tick-rate promotion</b> — SoD LODs NPC AI by distance
///   to the LOCAL player, so on the host a citizen next to a client but far from
///   the host would tick rarely, and the positions CitizenPositionSync streams
///   for it would be sparse and jerky. The host promotes those citizens to the
///   rate their nearest peer needs.</description></item>
/// </list>
/// </summary>
public class WorldSync
{
    #region Tuning

    private const float OWNERSHIP_SCAN_RATE    = 0.3f;   // s — client ownership scan cadence
    private const float OWNERSHIP_CLAIM_DIST   = 2.5f;   // m — claim inside this radius
    private const float OWNERSHIP_RELEASE_DIST = 4.5f;   // m — release outside this radius (hysteresis)

    #endregion

    public int SyncedSeed { get; private set; }

    private float _lastOwnershipScan;
    private readonly NetDataWriter _writer = new();
    private readonly NetDataWriter _ownershipWriter = new();

    // ── Ownership ──────────────────────────────────────────────────────────

    /// <summary>Host: citizen id → owning player id (absent = host owns).</summary>
    private readonly Dictionary<int, int> _citizenOwners = new();

    /// <summary>Host: citizens whose host-side AI we paused because a client
    /// owns them. Tracked separately so we only ever re-enable AI we disabled.</summary>
    private readonly HashSet<int> _pausedAI = new();

    /// <summary>Client: citizens THIS client currently owns.</summary>
    private readonly HashSet<int> _myOwnedCitizens = new();

    private readonly List<int> _scratchIds = new();

    /// <summary>True when this client currently owns <paramref name="citizenId"/>
    /// for an interaction. <see cref="CitizenPositionSync"/> consults this so it
    /// never fights the local AI during a conversation or fight.</summary>
    public bool IsOwnedLocally(int citizenId) => _myOwnedCitizens.Contains(citizenId);

    /// <summary>Host: player id that owns <paramref name="citizenId"/>, or -1 when
    /// the host owns it.</summary>
    public int GetOwnerPlayerId(int citizenId)
        => _citizenOwners.TryGetValue(citizenId, out var owner) ? owner : -1;

    // -------------------------------------------------------------------------
    //  Update
    // -------------------------------------------------------------------------

    public void Update()
    {
        if (!NetworkManager.IsConnected) return;
        if (!WorldReadyGate.IsWorldReady) return;

        if (NetworkManager.IsHost)
        {
            PromoteRemoteTickRates();
            return;
        }

        float now = Time.unscaledTime;
        if (now - _lastOwnershipScan >= OWNERSHIP_SCAN_RATE)
        {
            _lastOwnershipScan = now;
            ClientOwnershipScan();
        }
    }

    // -------------------------------------------------------------------------
    //  Client: ownership scan
    // -------------------------------------------------------------------------

    private void ClientOwnershipScan()
    {
        try
        {
            var localPlayer = global::Player.Instance;
            if (localPlayer == null) return;
            Vector3 myPos = localPlayer.transform.position;

            // Release owned citizens that drifted out of range or disappeared.
            if (_myOwnedCitizens.Count > 0)
            {
                _scratchIds.Clear();
                foreach (var id in _myOwnedCitizens)
                {
                    var human = NetworkIdResolver.GetHuman(id);
                    if (human == null || human.gameObject == null) { _scratchIds.Add(id); continue; }
                    if (Vector3.Distance(human.transform.position, myPos) > OWNERSHIP_RELEASE_DIST)
                        _scratchIds.Add(id);
                }
                for (int i = 0; i < _scratchIds.Count; i++) ClientReleaseOwnership(_scratchIds[i]);
            }

            // Claim nearby citizens. Walks the shared managed roster instead of
            // enumerating the live Il2Cpp citizenDictionary every scan.
            if (!Zdo.Pollers.CitizenRosterCache.TryGetRoster(out var ids, out var citizens)) return;
            for (int i = 0; i < citizens.Count; i++)
            {
                int id = ids[i];
                if (id == 0 || _myOwnedCitizens.Contains(id)) continue;

                // Never claim a twin. A twin IS a player's body — the local
                // player's own (hidden) decoy, or another player's visible body
                // driven by RemotePlayer. Claiming one re-enabled its AI here, and
                // the release later re-enabled it on the HOST, where it then
                // fought RemotePlayer for the same transform.
                if (TwinManager.IsTwin(id)) continue;

                var human = citizens[i];
                if (human == null || human.gameObject == null) continue;
                if (IsLocalPlayerHuman(human)) continue;
                if (SafeIsDead(human)) continue;

                if (Vector3.Distance(human.transform.position, myPos) < OWNERSHIP_CLAIM_DIST)
                    ClientClaimOwnership(id, human);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"ClientOwnershipScan: {ex.Message}");
        }
    }

    private void ClientClaimOwnership(int citizenId, global::Human human)
    {
        _myOwnedCitizens.Add(citizenId);

        // Host pauses its own AI for this citizen until we release it.
        SendOwnershipPacket(PacketType.CitizenOwnershipClaim, citizenId);

        // Hand the citizen to the local AI so dialog / fear / combat run
        // natively. CitizenPositionSync releases it first, restoring the AI
        // and root-motion state it recorded when it took the citizen over.
        CitizenPositionSync.ReleaseForLocalOwnership(citizenId);
        SetAIEnabled(human, true);

        Plugin.Log.LogDebug($"[Ownership] Claimed citizen {citizenId} (interaction range)");
    }

    private void ClientReleaseOwnership(int citizenId)
    {
        if (!_myOwnedCitizens.Remove(citizenId)) return;

        SendOwnershipPacket(PacketType.CitizenOwnershipRelease, citizenId);

        // Deliberately do NOT switch the local AI off here. The old code did,
        // expecting host commands to take over — they never could (see the
        // class notes), so every released citizen froze into a statue.
        // CitizenPositionSync picks the citizen back up on its next packet —
        // the release radius is 4.5 m, well inside its sync radius — and
        // freezes + drives it then. With CitizenPositionSync switched off, the
        // local AI simply keeps running, which is the correct fallback.

        Plugin.Log.LogDebug($"[Ownership] Released citizen {citizenId} (left interaction range)");
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
    //  Host: ownership table
    // -------------------------------------------------------------------------

    private void OnOwnershipClaim(NetDataReader reader, int senderId)
    {
        var p = new CitizenOwnershipPacket();
        p.Deserialize(reader);
        if (!NetworkManager.IsHost) return;

        // Trust the transport, not the payload: OwnerId is whatever the sender
        // chose to write.
        int owner = senderId >= 0 ? senderId : p.OwnerId;
        if (owner < 0) return;

        // Twins are player bodies, never interaction targets — refuse, so a
        // claim from an older client can't unfreeze one on release.
        if (TwinManager.IsTwin(p.CitizenId)) return;

        // First claimant keeps it. Overwriting would let a second client take
        // over mid-interaction, and the first client's release would then be
        // refused while the citizen stayed paused.
        if (_citizenOwners.TryGetValue(p.CitizenId, out var current) && current != owner) return;

        _citizenOwners[p.CitizenId] = owner;

        // Hold the citizen still on the host while the client interacts, so it
        // doesn't wander off on the authoritative side mid-conversation.
        var human = NetworkIdResolver.GetHuman(p.CitizenId);
        if (human != null && human.gameObject != null && _pausedAI.Add(p.CitizenId))
            SetAIEnabled(human, false);

        Plugin.Log.LogDebug($"[Ownership] Client {owner} claimed citizen {p.CitizenId}");
    }

    private void OnOwnershipRelease(NetDataReader reader, int senderId)
    {
        var p = new CitizenOwnershipPacket();
        p.Deserialize(reader);
        if (!NetworkManager.IsHost) return;

        int owner = senderId >= 0 ? senderId : p.OwnerId;

        // Only the owner can release. The old code removed the owner entry
        // conditionally but resumed the host AI UNconditionally, so any stray
        // release restarted a citizen another client was still talking to.
        if (!_citizenOwners.TryGetValue(p.CitizenId, out var current) || current != owner) return;
        _citizenOwners.Remove(p.CitizenId);
        ResumeHostAI(p.CitizenId);

        Plugin.Log.LogDebug($"[Ownership] Client {owner} released citizen {p.CitizenId}");
    }

    private void ResumeHostAI(int citizenId)
    {
        if (!_pausedAI.Remove(citizenId)) return;
        var human = NetworkIdResolver.GetHuman(citizenId);
        if (human != null && human.gameObject != null) SetAIEnabled(human, true);
    }

    /// <summary>Host: a player left. Release every citizen they owned.
    ///
    /// <para>Nothing did this before — the ownership state was never cleared
    /// anywhere — so a client that disconnected while standing next to someone
    /// left that citizen's host-side AI switched off for the rest of the
    /// session.</para></summary>
    public void OnPeerLeft(int playerId)
    {
        if (!NetworkManager.IsHost || _citizenOwners.Count == 0) return;
        _scratchIds.Clear();
        foreach (var kv in _citizenOwners)
            if (kv.Value == playerId) _scratchIds.Add(kv.Key);
        for (int i = 0; i < _scratchIds.Count; i++)
        {
            _citizenOwners.Remove(_scratchIds[i]);
            ResumeHostAI(_scratchIds[i]);
        }
        if (_scratchIds.Count > 0)
            Plugin.Log.LogInfo($"[Ownership] player {playerId} left — released {_scratchIds.Count} citizen(s) back to host AI.");
    }

    /// <summary>Session over. The host resumes AI for every citizen it paused;
    /// everything is forgotten so a stale id can't carry into the next world.</summary>
    public void OnSessionEnded()
    {
        if (_pausedAI.Count > 0)
        {
            _scratchIds.Clear();
            foreach (var id in _pausedAI) _scratchIds.Add(id);
            for (int i = 0; i < _scratchIds.Count; i++) ResumeHostAI(_scratchIds[i]);
        }
        _citizenOwners.Clear();
        _pausedAI.Clear();
        _myOwnedCitizens.Clear();
    }

    /// <summary>Kept for API compatibility; see <see cref="OnSessionEnded"/>.</summary>
    public void ClearClientState() => OnSessionEnded();

    // -------------------------------------------------------------------------
    //  Packets
    // -------------------------------------------------------------------------

    public void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
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
            case PacketType.CitizenOwnershipClaim:
                OnOwnershipClaim(reader, senderId);
                break;
            case PacketType.CitizenOwnershipRelease:
                OnOwnershipRelease(reader, senderId);
                break;

            // Retired NavMesh command stream (see class notes). Recognised and
            // dropped so an older peer's packets can't reach another handler.
            // CitizenDeath is owned by CitizenDeathSync.
            case PacketType.CitizenCommandBatch:
            case PacketType.CitizenCorrectionBatch:
            case PacketType.CitizenDeath:
                break;
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

    // ─────────────────────────────────────────────────────────────────────────
    //  Tick-rate promotion for remote players (host).
    //
    //  SoD's NewAIController.UpdateTickRate derives desiredTickRate from the
    //  distance to the LOCAL Player.Instance. A citizen right next to a client
    //  but far from the host's own player would otherwise sit at veryLow on the
    //  host — and the host is the authority CitizenPositionSync streams from,
    //  so that citizen would reach the client as sparse, jerky positions.
    //
    //  Each frame, walk a window of the citizen roster, compare each citizen's
    //  distance to every remote player, and promote desiredTickRate when a peer
    //  needs more than the host's local distance assigned. Never demote — SoD's
    //  own UpdateTickRate handles that. NPCS_PER_PROMOTE_FRAME bounds the cost.
    // ─────────────────────────────────────────────────────────────────────────

    private const int   NPCS_PER_PROMOTE_FRAME = 50;
    private const float TICK_HIGH_DIST    = 15f;
    private const float TICK_MED_DIST     = 35f;
    private const float TICK_LOW_DIST     = 80f;
    private const float TICK_VLOW_DIST    = 200f;
    private static int  _promoteCursor;
    private static readonly List<Vector3> _remotePositions = new(4);

    private static void PromoteRemoteTickRates()
    {
        try
        {
            _remotePositions.Clear();
            foreach (var rp in SoDCoop.Player.RemotePlayerManager.GetAllPlayers())
            {
                if (rp == null || rp.gameObject == null) continue;
                _remotePositions.Add(rp.transform.position);
            }
            if (_remotePositions.Count == 0) return;

            if (!Zdo.Pollers.CitizenRosterCache.TryGetRoster(out var ids, out var citizens)) return;
            int total = citizens.Count;
            if (total == 0) return;

            int steps = Mathf.Min(NPCS_PER_PROMOTE_FRAME, total);
            for (int n = 0; n < steps; n++)
            {
                if (_promoteCursor >= total) _promoteCursor = 0;
                int idx = _promoteCursor++;

                var human = citizens[idx];
                if (human == null) continue;
                if (TwinManager.IsTwin(ids[idx])) continue;   // frozen player bodies
                if (SafeIsDead(human)) continue;
                if (IsLocalPlayerHuman(human)) continue;

                NewAIController aic;
                try { aic = human.ai; } catch { continue; }
                if (aic == null) continue;

                Vector3 npcPos;
                try { npcPos = human.transform.position; } catch { continue; }

                float minDist = float.MaxValue;
                for (int i = 0; i < _remotePositions.Count; i++)
                {
                    float d = Vector3.Distance(npcPos, _remotePositions[i]);
                    if (d < minDist) minDist = d;
                }

                NewAIController.AITickRate target;
                if      (minDist < TICK_HIGH_DIST)  target = NewAIController.AITickRate.veryHigh;
                else if (minDist < TICK_MED_DIST)   target = NewAIController.AITickRate.high;
                else if (minDist < TICK_LOW_DIST)   target = NewAIController.AITickRate.medium;
                else if (minDist < TICK_VLOW_DIST)  target = NewAIController.AITickRate.low;
                else                                target = NewAIController.AITickRate.veryLow;

                if ((int)target > (int)aic.desiredTickRate)
                {
                    try
                    {
                        aic.desiredTickRate = target;
                        // forceUpdate=true re-buckets the controller so it
                        // actually ticks at the new cadence next frame.
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

    // -------------------------------------------------------------------------
    //  Helpers
    // -------------------------------------------------------------------------

    private static void SetAIEnabled(global::Human human, bool enabled)
    {
        try
        {
            var ai = human.ai;
            if (ai != null && ai.enabled != enabled) ai.enabled = enabled;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[WorldSync] SetAIEnabled({enabled}): {ex.Message}");
        }
    }

    private static bool IsLocalPlayerHuman(global::Human human)
    {
        try
        {
            var p = global::Player.Instance;
            return p != null && p.gameObject == human.gameObject;
        }
        catch { return false; }
    }

    private static bool SafeIsDead(global::Human human)
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
}
