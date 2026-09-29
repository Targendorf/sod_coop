using System;
using System.Collections.Generic;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Zdo;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Host-authoritative position replication for the citizens standing near each
/// client, so both players see the same people in the same places.
///
/// <para><b>Why this exists.</b> Until now NOTHING synced citizen positions —
/// not one byte. The design bet that SoD's city is deterministic from its seed,
/// so every machine's local AI would walk the same 336 citizens along the same
/// routes and they'd stay aligned for free. Only the deterministic part is the
/// *schedule* (who works where, who lives where). The *execution* is not: each
/// machine advances NPC movement against its own frame times, its own
/// pathfinding progress and its own global RNG consumption order, and the two
/// players stand in different places so different NPCs get near-field AI on
/// each machine. Any one of those desynchronises positions within minutes, and
/// nothing ever pulled them back. Players reported exactly that: the same
/// citizen in two different places.</para>
///
/// <para><b>Scope.</b> A client only needs the citizens near <i>itself</i> to
/// match the host's copy — nobody can see a mismatch across the city. So the
/// host sends each peer only what is inside that peer's own
/// <see cref="SYNC_RADIUS_M"/>: on the order of tens of citizens, not 336, and
/// the cost does not grow with peer count.</para>
///
/// <para><b>Host cost is essentially zero.</b> The positions are already in the
/// ZDO registry: <c>CitizenStatePoller</c> stamps <see cref="Zdo.HostPosition"/>
/// every tick for sector culling, and <see cref="SpatialGrid"/> already indexes
/// them. So this reads no new SoD fields and adds no IL2CPP interop on the host
/// — which matters, because per-tick interop volume in the pollers was the
/// measured cause of the host's frame stalls.</para>
///
/// <para><b>Client side</b> freezes the local AI for the citizens it is being
/// told about (<c>ai.enabled = false</c> — the same mechanism
/// <see cref="TwinManager"/> already uses to pin player twins) and drives their
/// transform from interpolated network snapshots instead. Without the freeze the
/// local AI and the network would fight over the same transform every frame and
/// the NPC would rubber-band. When a citizen stops being reported — the client
/// walked away — its AI is handed back so it resumes normal behaviour rather
/// than standing frozen forever.</para>
///
/// <para><b>Walk animation</b> is fed from the interpolated velocity, because a
/// frozen AI publishes no speed and the body would otherwise slide along in its
/// idle pose. The two parameter names on SoD's citizen rig are already known
/// from the RemotePlayer work (<c>moveSpeed</c> raw m/s, <c>walkAnimSpeed</c>
/// normalised 0..1 driving the walk-cycle blend tree; playtest 2026-06-16
/// proved that feeding only the first still leaves the body in idle), so this
/// hashes them directly instead of enumerating every NPC's animator.</para>
///
/// <para>Twins are excluded on both sides: a twin citizen IS a player's body
/// and is owned by <see cref="TwinManager"/> / <c>RemotePlayer</c>. Driving one
/// from here would fight the player-position channel.</para>
/// </summary>
public static class CitizenPositionSync
{
    // ── Tunables ────────────────────────────────────────────────────────

    /// <summary>Send rate. The receiver interpolates, so this does not need to
    /// be frame rate — but at 10 Hz a pedestrian turning a corner visibly cut
    /// it, and the render delay (about one send interval plus jitter) was a
    /// quarter of a second. 15 Hz costs ~11 KB/s for 40 citizens.</summary>
    public const float SYNC_HZ = 15f;
    public const string POLLER_NAME = "npc-pos";

    /// <summary>Radius around a peer whose citizens get position sync.
    /// Deliberately much tighter than <see cref="ZdoMan.CULL_RADIUS_M"/> (150 m):
    /// past a few tens of metres a citizen's exact position is not
    /// distinguishable, and every metre of radius costs both bandwidth and one
    /// more NPC whose AI is frozen on the client. 60 m comfortably covers a
    /// street and any interior.</summary>
    private const float SYNC_RADIUS_M = 60f;

    /// <summary>Entries per packet. 60 × 18 B + 5 ≈ 1085 B keeps us under the
    /// ~1200 B practical limit for an unreliable datagram, so a busy street
    /// splits across packets instead of being fragmented by the transport.</summary>
    private const int MAX_ENTRIES_PER_PACKET = 60;

    /// <summary>Render delay bounds. Playback runs behind the HOST's clock by an
    /// adaptive delay — one send interval plus twice the smoothed lateness,
    /// see <see cref="RemoteClock"/>.
    ///
    /// <para><b>What this replaced:</b> a fixed 250 ms behind the ARRIVAL time
    /// of the newest sample, interpolating between only the two newest
    /// samples. Those two are one send interval apart and the newer one had
    /// just arrived, so "250 ms ago" was always before the older one: the
    /// blend factor clamped to 0 every frame and each citizen sat on its
    /// previous sample, then jumped to the next — pedestrians moved in 10 Hz
    /// steps. The delay was raised from 120 ms precisely to smooth them, and
    /// made it worse.</para></summary>
    private const float MIN_DELAY_S = 0.09f;
    private const float MAX_DELAY_S = 0.40f;

    /// <summary>Samples kept per citizen: ~0.4 s at <see cref="SYNC_HZ"/>,
    /// enough to cover <see cref="MAX_DELAY_S"/>.</summary>
    private const int SAMPLE_CAP = 8;

    /// <summary>Longest we coast past the newest sample on its velocity when
    /// the next one is late.</summary>
    private const float MAX_EXTRAPOLATION_S = 0.12f;

    /// <summary>Smoothing rate for the speed fed to the walk cycle.</summary>
    private const float ANIM_SPEED_RATE = 10f;

    /// <summary>Jump further than this between snapshots and we snap instead of
    /// interpolating — the citizen was teleported by SoD (lift, vehicle, spawn)
    /// and sliding them across the map would look far worse.</summary>
    private const float TELEPORT_M = 8f;

    /// <summary>No update for this long means the client walked out of range.
    /// Hand the citizen back to its local AI. Must be comfortably longer than
    /// one send interval so ordinary packet loss doesn't cause AI flapping.</summary>
    private const float STALE_TIMEOUT_S = 1.5f;


    // ── Host state ──────────────────────────────────────────────────────

    private static readonly NetDataWriter _writer = new();

    // ── Client state ────────────────────────────────────────────────────

    /// <summary>Per-citizen interpolation + ownership state. A class, not a
    /// struct, so the per-frame apply mutates in place without a dictionary
    /// write-back.</summary>
    private sealed class NpcState
    {
        public global::Human Human;
        public Animator Anim;
        public bool AnimResolved;

        /// <summary>Host samples, oldest first, timed on the host's clock.</summary>
        public readonly List<Sample> Samples = new(SAMPLE_CAP);
        /// <summary>Smoothed playback speed, m/s.</summary>
        public float AnimSpeed;

        public float LastRecvTime;
        /// <summary>True while we hold this citizen's AI disabled. Tracked so
        /// we only ever re-enable AI we ourselves turned off — a citizen whose
        /// AI was already disabled for a game reason (twin, dead, unloaded)
        /// must not be switched on by us.</summary>
        public bool WeFroze;

        /// <summary>Root motion suppressed while we drive the transform — see
        /// <see cref="RootMotionGuard"/>. Restored on release.</summary>
        public readonly RootMotionGuard RootMotion = new();
    }

    private struct Sample
    {
        public float   T;
        public Vector3 Pos;
        public float   Yaw;
    }

    private static readonly Dictionary<int, NpcState> _npcs = new();

    /// <summary>The host's clock as seen from here. One for all citizens —
    /// every sample comes from the same machine and tick.</summary>
    private static readonly RemoteClock _hostClock = new();
    private static readonly List<int> _dropScratch = new();

    private static int _animMoveSpeedHash = -1;
    private static int _animWalkSpeedHash = -1;

    // ════════════════════════════════════════════════════════════════════
    // Host
    // ════════════════════════════════════════════════════════════════════

    public static void Register()
    {
        ZdoPollerHost.Register(POLLER_NAME, 1f / SYNC_HZ, HostTick);
        ZdoPollerHost.RegisterAnyPeer(INTEREST_POLLER_NAME, 1f / INTEREST_HZ, ClientInterestTick);
        ZdoEventDispatcher.Register(INTEREST_EVENT, OnInterest);
    }

    // ── Client-side interest ────────────────────────────────────────────
    //
    // The host picks which citizens to stream by where they are in ITS world.
    // A citizen whose copy on this client wandered close to the player while
    // the host has it across the city was never picked — so it was never
    // frozen, kept walking on the client's own AI, and stood next to the
    // player on one machine and nowhere near on the other: exactly the "same
    // person in two places / people only I can see" report. The client now
    // tells the host which citizens are near it HERE; the host streams those
    // too, with their real positions, and they snap back to where they
    // actually are.

    public const string INTEREST_POLLER_NAME = "npc-interest";
    public const string INTEREST_EVENT = "npc-interest";
    private const float INTEREST_HZ = 2f;
    /// <summary>A report older than this is ignored — the client has moved on.</summary>
    private const float INTEREST_TTL_S = 1.5f;
    private const int MAX_INTEREST_IDS = 96;

    /// <summary>Host: the latest citizens each client reported near itself.</summary>
    private static readonly Dictionary<int, (List<int> ids, float at)> _interest = new();
    private static readonly HashSet<int> _writtenScratch = new();
    private static readonly List<int> _interestScratch = new();
    private static readonly HashSet<int> _twinScratch = new();
    private static readonly NetDataWriter _interestWriter = new();

    private static void ClientInterestTick(float now)
    {
        if (NetworkManager.IsHost) return;
        if (CoopSettings.SyncCitizenPositions?.Value == false) return;

        try
        {
            var player = global::Player.Instance;
            if (player == null) return;
            Vector3 me = player.transform.position;

            if (!SoDCoop.Zdo.Pollers.CitizenRosterCache.TryGetRoster(out var ids, out var citizens)) return;

            // Twins are player bodies, driven by RemotePlayer / hidden as ours.
            _twinScratch.Clear();
            var players = NetworkManager.Players;
            if (players != null)
                foreach (var kv in players)
                    if (kv.Value != null && kv.Value.TwinHumanID > 0) _twinScratch.Add(kv.Value.TwinHumanID);

            float r2 = SYNC_RADIUS_M * SYNC_RADIUS_M;
            _interestScratch.Clear();
            for (int i = 0; i < citizens.Count && _interestScratch.Count < MAX_INTEREST_IDS; i++)
            {
                int id = ids[i];
                // Already streamed to us: the host has it near us too.
                if (_npcs.ContainsKey(id)) continue;
                if (_twinScratch.Contains(id)) continue;
                if (SyncManager.WorldSync?.IsOwnedLocally(id) == true) continue;
                var c = citizens[i];
                if (c == null) continue;
                Vector3 p;
                try { p = c.transform.position; } catch { continue; }
                if ((p - me).sqrMagnitude > r2) continue;
                _interestScratch.Add(id);
            }
            if (_interestScratch.Count == 0) return;

            _interestWriter.Reset();
            _interestWriter.Put((ushort)_interestScratch.Count);
            for (int i = 0; i < _interestScratch.Count; i++) _interestWriter.Put(_interestScratch[i]);
            // Superseded by the next report half a second later — no retransmit.
            ZdoEventDispatcher.Send(INTEREST_EVENT, _interestWriter, DeliveryMethod.Sequenced);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenPositionSync] interest: {ex.Message}"); }
    }

    /// <summary>Host: a client's list of citizens near it in ITS world. In a 3+
    /// session the relay also hands it to the other clients, which ignore it.</summary>
    private static void OnInterest(NetDataReader r, int senderId)
    {
        if (!NetworkManager.IsHost) return;
        try
        {
            if (r.AvailableBytes < 2) return;
            int n = r.GetUShort();
            if (n > MAX_INTEREST_IDS) n = MAX_INTEREST_IDS;
            if (!_interest.TryGetValue(senderId, out var entry) || entry.ids == null)
                entry = (new List<int>(n), 0f);
            entry.ids.Clear();
            for (int i = 0; i < n && r.AvailableBytes >= 4; i++) entry.ids.Add(r.GetInt());
            entry.at = Time.unscaledTime;
            _interest[senderId] = entry;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenPositionSync] interest from {senderId}: {ex.Message}"); }
    }

    private static void HostTick(float now)
    {
        if (CoopSettings.SyncCitizenPositions?.Value == false) return;
        if (!NetworkManager.IsHost) return;
        if (!NetworkManager.HasPeers) return;

        try
        {
            _livePosThisTick.Clear();
            _tickTime = Time.unscaledTime;
            var clients = NetworkManager.Clients;
            for (int ci = 0; ci < clients.Count; ci++)
            {
                var peer = clients[ci];
                if (peer == null) continue;

                int peerId = NetworkManager.GetPlayerIdByPeer(peer);
                if (peerId < 0) continue;
                if (NetworkManager.Players == null
                    || !NetworkManager.Players.TryGetValue(peerId, out var info)
                    || info == null
                    || !info.WorldReady
                    || !info.HasKnownPosition) continue;

                // SpatialGrid.Query returns a shared scratch list — consume it
                // fully here and never re-query before we're done with it.
                var near = SpatialGrid.Query(info.LastKnownPosition, SYNC_RADIUS_M);

                int written = 0;
                _writtenScratch.Clear();
                BeginPacket();
                for (int i = 0; i < near.Count; i++)
                {
                    var z = near[i];
                    if (z == null) continue;
                    if (z.ZdoTypeTag != ZdoTypeTag.Citizen) continue;
                    if (!z.HasHostPosition) continue;

                    int humanId = z.GetInt(ZdoKeys.SodId, 0);
                    if (humanId == 0) continue;
                    // A twin IS a player's body — the player-position channel
                    // owns it. Driving it from here would fight RemotePlayer.
                    if (TwinManager.IsTwin(humanId)) continue;
                    // The peer owns this citizen for an interaction and is
                    // running it on its own AI; it discards these anyway.
                    if (SyncManager.WorldSync?.GetOwnerPlayerId(humanId) == peerId) continue;

                    if (!LivePosition(humanId, z, out Vector3 p)) continue;
                    _writtenScratch.Add(humanId);
                    _writer.Put(humanId);
                    _writer.Put(p.x);
                    _writer.Put(p.y);
                    _writer.Put(p.z);
                    _writer.Put(LiveYaw(humanId));
                    written++;

                    if (written >= MAX_ENTRIES_PER_PACKET)
                    {
                        FlushPacket(peer, written);
                        written = 0;
                        BeginPacket();
                    }
                }

                // Citizens the client reported near it in ITS world. Their
                // real position is usually far away — the client snaps them
                // there, which is the point.
                if (_interest.TryGetValue(peerId, out var interest)
                    && interest.ids != null
                    && now - interest.at <= INTEREST_TTL_S)
                {
                    for (int i = 0; i < interest.ids.Count; i++)
                    {
                        int humanId = interest.ids[i];
                        if (humanId == 0 || _writtenScratch.Contains(humanId)) continue;
                        if (TwinManager.IsTwin(humanId)) continue;
                        if (SyncManager.WorldSync?.GetOwnerPlayerId(humanId) == peerId) continue;
                        var z = ZdoMan.FindBySodId(ZdoTypeTag.Citizen, humanId);
                        if (!LivePosition(humanId, z, out Vector3 p)) continue;
                        _writtenScratch.Add(humanId);
                        _writer.Put(humanId);
                        _writer.Put(p.x);
                        _writer.Put(p.y);
                        _writer.Put(p.z);
                        _writer.Put(LiveYaw(humanId));
                        written++;

                        if (written >= MAX_ENTRIES_PER_PACKET)
                        {
                            FlushPacket(peer, written);
                            written = 0;
                            BeginPacket();
                        }
                    }
                }
                if (written > 0) FlushPacket(peer, written);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenPositionSync] HostTick: {ex.Message}"); }
    }

    /// <summary>Positions read this tick, so a citizen near several peers is
    /// read from the engine once.</summary>
    private static readonly Dictionary<int, Vector3> _livePosThisTick = new();

    /// <summary>The citizen's position NOW, read from its transform.
    ///
    /// <para>This used to send <c>z.HostPosition</c>, which CitizenStatePoller
    /// stamps at 5 Hz — and less often whenever the poller budget defers it —
    /// while this sync sends at 10 Hz. Every other packet repeated the previous
    /// position, so the receiver interpolated stop / double-length jump / stop,
    /// and the walk-speed it derives for the animator alternated between zero
    /// and twice the real speed: legs flickering on every pedestrian near the
    /// player. Only the tens of citizens actually being sent are read here, so
    /// the extra interop is small. The fresh value is written back to the ZDO,
    /// which keeps sector culling current for free.</para></summary>
    /// <summary>The citizen's facing (Y rotation), quantised to 16 bits
    /// (0.0055° steps). Read from the transform LivePosition just resolved.
    ///
    /// <para>Facing used to be derived on the client from the direction of
    /// movement only, so a citizen who turned without walking — to face the
    /// player in a conversation, to sit at a desk, to look at a body — kept
    /// facing wherever it had last walked.</para></summary>
    private static ushort LiveYaw(int humanId)
    {
        float yaw = 0f;
        try
        {
            var h = NetworkIdResolver.GetHuman(humanId);
            var t = h != null ? h.transform : null;
            if (t != null) yaw = t.eulerAngles.y;
        }
        catch { }
        return (ushort)Mathf.RoundToInt(Mathf.Repeat(yaw, 360f) / 360f * 65535f);
    }

    /// <param name="z">The citizen's ZDO, or null (a citizen named by a
    /// client's interest report may not have one yet).</param>
    /// <returns>False when there is no position to send at all.</returns>
    private static bool LivePosition(int humanId, SoDCoop.Zdo.Zdo z, out Vector3 p)
    {
        if (_livePosThisTick.TryGetValue(humanId, out p)) return true;
        bool have = false;
        if (z != null && z.HasHostPosition) { p = z.HostPosition; have = true; }
        try
        {
            var h = NetworkIdResolver.GetHuman(humanId);
            var t = h != null ? h.transform : null;
            if (t != null)
            {
                p = t.position;
                have = true;
                if (z != null) ZdoMan.NotifyZdoPosition(z, p);
            }
        }
        catch { /* fall back to the last stamped position */ }
        if (have) _livePosThisTick[humanId] = p;
        return have;
    }

    /// <summary>Byte offset of the entry count, after the host-time header.</summary>
    private const int COUNT_OFFSET = 4;

    /// <summary>Host time of the current tick's samples — every entry in the
    /// tick was read in the same frame.</summary>
    private static float _tickTime;

    /// <summary>Header: host sample time (float) + a reserved count byte,
    /// patched in by <see cref="FlushPacket"/> once we know how many entries
    /// actually made it in.</summary>
    private static void BeginPacket()
    {
        _writer.Reset();
        _writer.Put(_tickTime);
        _writer.Put((byte)0);
    }

    private static void FlushPacket(Network.Steam.SteamPeer peer, int count)
    {
        _writer.Data[COUNT_OFFSET] = (byte)count;
        // Sequenced: these are pure overwrite state. A late packet is worthless
        // because the next one supersedes it, and forcing them through the
        // reliable channel would head-of-line block real state transitions
        // behind retransmits of positions nobody needs any more.
        NetworkManager.SendTo(peer, PacketType.CitizenPositions, _writer, DeliveryMethod.Sequenced);
    }

    // ════════════════════════════════════════════════════════════════════
    // Client
    // ════════════════════════════════════════════════════════════════════

    public static void HandlePacket(NetDataReader r, int senderId)
    {
        // Host is the authority; it never applies these to itself.
        if (NetworkManager.IsHost) return;
        if (!WorldReadyGate.IsWorldReady) return;

        try
        {
            if (r.AvailableBytes < COUNT_OFFSET + 1) return;
            float hostTime = r.GetFloat();
            int count = r.GetByte();
            float now = Time.unscaledTime;

            // The host restarted its clock (new process) — samples buffered on
            // the old one can't be compared with the new ones.
            if (_hostClock.Observe(hostTime, now))
                foreach (var kv in _npcs) kv.Value.Samples.Clear();

            for (int i = 0; i < count; i++)
            {
                // 18 B per entry — bail out rather than read past a truncated
                // frame (LiteNetLib hands us oversized reused buffers).
                if (r.AvailableBytes < 18) break;

                int humanId = r.GetInt();
                float x = r.GetFloat(), y = r.GetFloat(), z = r.GetFloat();
                float yaw = r.GetUShort() / 65535f * 360f;
                if (humanId == 0) continue;
                if (TwinManager.IsTwin(humanId)) continue;

                // This client owns the citizen for an interaction (WorldSync
                // ownership): its local AI is running dialog / fear / combat.
                // Driving it from here would freeze that AI mid-conversation —
                // the exact risk flagged when this sync was introduced. It is
                // picked back up from the first packet after the release.
                if (SyncManager.WorldSync?.IsOwnedLocally(humanId) == true)
                {
                    if (_npcs.ContainsKey(humanId)) Release(humanId);
                    continue;
                }

                if (!_npcs.TryGetValue(humanId, out var st))
                {
                    st = new NpcState();
                    if (!TryBind(humanId, st)) continue;   // citizen not present locally
                    _npcs[humanId] = st;
                }

                var samples = st.Samples;
                // Same tick again (a packet split) or out of order: nothing new.
                if (samples.Count > 0 && hostTime <= samples[samples.Count - 1].T) { st.LastRecvTime = now; continue; }
                if (samples.Count >= SAMPLE_CAP) samples.RemoveAt(0);
                samples.Add(new Sample { T = hostTime, Pos = new Vector3(x, y, z), Yaw = yaw });

                st.LastRecvTime = now;
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenPositionSync] HandlePacket: {ex.Message}"); }
    }

    /// <summary>Resolve the live citizen for <paramref name="humanId"/> and take
    /// ownership of its movement by disabling its AI. Returns false when the
    /// citizen isn't available locally, in which case the caller drops the
    /// update rather than caching a dead entry.</summary>
    private static bool TryBind(int humanId, NpcState st)
    {
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return false;
            if (!dict.TryGetValue(humanId, out var c) || c == null) return false;
            st.Human = c;

            var ai = c.ai;
            if (ai != null && ai.enabled)
            {
                ai.enabled = false;
                st.WeFroze = true;
            }

            // We are about to feed moveSpeed/walkAnimSpeed while writing the
            // transform ourselves; left on, root motion would add its own
            // displacement after our write every frame.
            st.RootMotion.Suppress(c);

            // Its own AI is off from here on, so nothing on this machine will
            // pose it any more: take the host's pose (sitting, on the phone,
            // in bed…) from the citizen's ZDO now instead of leaving whatever
            // the local AI was last doing.
            try
            {
                SoDCoop.Zdo.Resolvers.CitizenResolver.ForgetPose(humanId);
                var z = ZdoMan.FindBySodId(ZdoTypeTag.Citizen, humanId);
                if (z != null) SoDCoop.Zdo.Resolvers.CitizenResolver.ApplyPose(c, z);
            }
            catch { }
            return true;
        }
        catch { return false; }
    }

    /// <summary>Per-frame interpolate + apply. Called from
    /// <c>CoopUpdateRunner.Update</c>.</summary>
    public static void Update()
    {
        if (_npcs.Count == 0) return;
        if (NetworkManager.IsHost) return;

        float now = Time.unscaledTime;
        float dt = Time.unscaledDeltaTime;
        _hostClock.Advance(dt, 1f / SYNC_HZ, MIN_DELAY_S, MAX_DELAY_S);
        float renderTime = _hostClock.RenderTime(now);
        float speedBlend = 1f - Mathf.Exp(-ANIM_SPEED_RATE * Mathf.Max(dt, 0f));

        _dropScratch.Clear();

        foreach (var kv in _npcs)
        {
            var st = kv.Value;

            // Stale → the client walked out of range. Give the citizen back to
            // its own AI so it resumes living instead of standing frozen.
            if (now - st.LastRecvTime > STALE_TIMEOUT_S)
            {
                _dropScratch.Add(kv.Key);
                continue;
            }

            var human = st.Human;
            if (human == null) { _dropScratch.Add(kv.Key); continue; }

            var samples = st.Samples;
            if (samples.Count == 0) continue;

            Transform t;
            try { t = human.transform; } catch { _dropScratch.Add(kv.Key); continue; }
            if (t == null) { _dropScratch.Add(kv.Key); continue; }

            // ── Interpolate on the host's clock ──────────────────────────
            Vector3 target;
            float yaw;
            float speed = 0f;
            var newest = samples[samples.Count - 1];
            if (renderTime >= newest.T)
            {
                // Next sample is late: coast briefly on the last pair's
                // velocity, then hold.
                target = newest.Pos;
                yaw = newest.Yaw;
                if (samples.Count >= 2)
                {
                    var prev = samples[samples.Count - 2];
                    float span = newest.T - prev.T;
                    if (span > 1e-3f && Vector3.Distance(prev.Pos, newest.Pos) <= TELEPORT_M)
                    {
                        Vector3 vel = (newest.Pos - prev.Pos) / span;
                        float ahead = renderTime - newest.T;
                        if (ahead < MAX_EXTRAPOLATION_S)
                        {
                            target += vel * ahead;
                            speed = vel.magnitude;
                        }
                        else target += vel * MAX_EXTRAPOLATION_S;
                    }
                }
            }
            else if (renderTime <= samples[0].T)
            {
                // Just bound (one sample) or the delay grew past the buffer.
                target = samples[0].Pos;
                yaw = samples[0].Yaw;
            }
            else
            {
                int i = samples.Count - 1;
                while (i > 0 && samples[i - 1].T > renderTime) i--;
                var a = samples[i - 1];
                var b = samples[i];
                float span = b.T - a.T;
                float f = span > 1e-4f ? Mathf.Clamp01((renderTime - a.T) / span) : 1f;
                if (Vector3.Distance(a.Pos, b.Pos) > TELEPORT_M)
                {
                    // SoD moved them discontinuously (lift, vehicle, respawn).
                    target = b.Pos;
                    yaw = b.Yaw;
                }
                else
                {
                    target = Vector3.Lerp(a.Pos, b.Pos, f);
                    yaw = Mathf.LerpAngle(a.Yaw, b.Yaw, f);
                    speed = span > 1e-3f ? Vector3.Distance(a.Pos, b.Pos) / span : 0f;
                }
            }

            try { t.position = target; } catch { _dropScratch.Add(kv.Key); continue; }
            // The host's facing, played on the same timeline as the position:
            // turning to face someone, sitting down at a desk.
            try { t.rotation = Quaternion.Euler(0f, yaw, 0f); } catch { }

            st.AnimSpeed += (speed - st.AnimSpeed) * speedBlend;
            DriveWalkAnimation(st, st.AnimSpeed);
        }

        for (int i = 0; i < _dropScratch.Count; i++) Release(_dropScratch[i]);
        _dropScratch.Clear();
    }

    /// <summary>Feed the citizen rig's locomotion parameters from the
    /// interpolated speed. A frozen AI publishes no speed, so without this the
    /// body slides along in its idle pose — the exact artefact the RemotePlayer
    /// work hit and fixed by driving BOTH parameters.</summary>
    private static void DriveWalkAnimation(NpcState st, float speed)
    {
        try
        {
            if (!st.AnimResolved)
            {
                st.AnimResolved = true;   // one attempt only — the tree walk is expensive
                try { st.Anim = st.Human.GetComponentInChildren<Animator>(); } catch { st.Anim = null; }
            }
            var anim = st.Anim;
            if (anim == null) return;

            if (_animMoveSpeedHash == -1)
            {
                // Names are already established for SoD's citizen rig, so hash
                // them directly rather than enumerating parameters per NPC.
                _animMoveSpeedHash = Animator.StringToHash("moveSpeed");
                _animWalkSpeedHash = Animator.StringToHash("walkAnimSpeed");
            }

            anim.SetFloat(_animMoveSpeedHash, speed);
            anim.SetFloat(_animWalkSpeedHash, Mathf.Clamp01(speed / 1.5f));
        }
        catch { /* animator missing or odd — position still syncs */ }
    }

    /// <summary>Stop driving <paramref name="humanId"/> and re-enable the AI we
    /// disabled. Only re-enables when <see cref="NpcState.WeFroze"/> is set, so
    /// a citizen whose AI was already off for a game reason stays off.</summary>
    private static void Release(int humanId)
    {
        if (!_npcs.TryGetValue(humanId, out var st)) return;
        _npcs.Remove(humanId);
        st.RootMotion.Restore();
        try
        {
            if (st.WeFroze && st.Human != null)
            {
                var ai = st.Human.ai;
                if (ai != null) ai.enabled = true;
            }
        }
        catch { }
    }

    /// <summary>Client: true while <paramref name="humanId"/> is driven from the
    /// host — its local AI is off and its pose comes from the host.</summary>
    internal static bool IsDriven(int humanId) => _npcs.ContainsKey(humanId);

    /// <summary>Client: the citizens currently driven from the host — the ones
    /// near this player.</summary>
    internal static void CollectDriven(List<KeyValuePair<int, global::Human>> into)
    {
        foreach (var kv in _npcs)
            if (kv.Value?.Human != null) into.Add(new KeyValuePair<int, global::Human>(kv.Key, kv.Value.Human));
    }

    /// <summary>Client: this citizen is about to be handed to the local AI for
    /// an interaction (<see cref="WorldSync"/> ownership claim). Stop driving it
    /// and give back the AI and root-motion state we took, so dialog, fear and
    /// combat run natively. The citizen is picked up again from the next packet
    /// once the claim is released.</summary>
    public static void ReleaseForLocalOwnership(int humanId) => Release(humanId);

    /// <summary>Hand every citizen back to its local AI and forget all state.
    /// Wired into disconnect and world unload — a citizen left frozen after the
    /// session ends would stand motionless in the player's single-player game.</summary>
    public static void Reset()
    {
        if (_npcs.Count > 0)
        {
            _dropScratch.Clear();
            foreach (var kv in _npcs) _dropScratch.Add(kv.Key);
            for (int i = 0; i < _dropScratch.Count; i++) Release(_dropScratch[i]);
            _dropScratch.Clear();
        }
        _npcs.Clear();
        _hostClock.Reset();
    }
}
