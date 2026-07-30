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

    /// <summary>Send rate. Matches the ZDO delta flush; the receiver
    /// interpolates, so this does not need to be frame rate.</summary>
    public const float SYNC_HZ = 10f;
    public const string POLLER_NAME = "npc-pos";

    /// <summary>Radius around a peer whose citizens get position sync.
    /// Deliberately much tighter than <see cref="ZdoMan.CULL_RADIUS_M"/> (150 m):
    /// past a few tens of metres a citizen's exact position is not
    /// distinguishable, and every metre of radius costs both bandwidth and one
    /// more NPC whose AI is frozen on the client. 60 m comfortably covers a
    /// street and any interior.</summary>
    private const float SYNC_RADIUS_M = 60f;

    /// <summary>Entries per packet. 60 × 16 B + 1 ≈ 961 B keeps us under the
    /// ~1200 B practical limit for an unreliable datagram, so a busy street
    /// splits across packets instead of being fragmented by the transport.</summary>
    private const int MAX_ENTRIES_PER_PACKET = 60;

    /// <summary>Render this far behind the newest snapshot so there is always a
    /// later sample to interpolate towards. One send interval plus a little
    /// slack.</summary>
    private const float INTERP_DELAY_S = 0.12f;

    /// <summary>Jump further than this between snapshots and we snap instead of
    /// interpolating — the citizen was teleported by SoD (lift, vehicle, spawn)
    /// and sliding them across the map would look far worse.</summary>
    private const float TELEPORT_M = 8f;

    /// <summary>No update for this long means the client walked out of range.
    /// Hand the citizen back to its local AI. Must be comfortably longer than
    /// one send interval so ordinary packet loss doesn't cause AI flapping.</summary>
    private const float STALE_TIMEOUT_S = 1.5f;

    /// <summary>Below this interpolated speed the citizen is treated as
    /// standing still: no facing update (so they don't spin on jitter) and idle
    /// walk animation.</summary>
    private const float MOVING_SPEED_EPS = 0.05f;

    /// <summary>Facing turn rate, degrees/second, when following movement
    /// direction.</summary>
    private const float TURN_DEG_PER_S = 540f;

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

        public Vector3 PrevPos;
        public float   PrevTime;
        public Vector3 CurPos;
        public float   CurTime;
        public bool    HasPrev;

        public float LastRecvTime;
        /// <summary>True while we hold this citizen's AI disabled. Tracked so
        /// we only ever re-enable AI we ourselves turned off — a citizen whose
        /// AI was already disabled for a game reason (twin, dead, unloaded)
        /// must not be switched on by us.</summary>
        public bool WeFroze;
    }

    private static readonly Dictionary<int, NpcState> _npcs = new();
    private static readonly List<int> _dropScratch = new();

    private static int _animMoveSpeedHash = -1;
    private static int _animWalkSpeedHash = -1;

    // ════════════════════════════════════════════════════════════════════
    // Host
    // ════════════════════════════════════════════════════════════════════

    public static void Register() => ZdoPollerHost.Register(POLLER_NAME, 1f / SYNC_HZ, HostTick);

    private static void HostTick(float now)
    {
        if (CoopSettings.SyncCitizenPositions?.Value == false) return;
        if (!NetworkManager.IsHost) return;
        if (!NetworkManager.HasPeers) return;

        try
        {
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

                    Vector3 p = z.HostPosition;
                    _writer.Put(humanId);
                    _writer.Put(p.x);
                    _writer.Put(p.y);
                    _writer.Put(p.z);
                    written++;

                    if (written >= MAX_ENTRIES_PER_PACKET)
                    {
                        FlushPacket(peer, written);
                        written = 0;
                        BeginPacket();
                    }
                }
                if (written > 0) FlushPacket(peer, written);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenPositionSync] HostTick: {ex.Message}"); }
    }

    /// <summary>Reserve the count byte; patched in by <see cref="FlushPacket"/>
    /// once we know how many entries actually made it in.</summary>
    private static void BeginPacket()
    {
        _writer.Reset();
        _writer.Put((byte)0);
    }

    private static void FlushPacket(Network.Steam.SteamPeer peer, int count)
    {
        _writer.Data[0] = (byte)count;
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
            int count = r.GetByte();
            float now = Time.unscaledTime;

            for (int i = 0; i < count; i++)
            {
                // 16 B per entry — bail out rather than read past a truncated
                // frame (LiteNetLib hands us oversized reused buffers).
                if (r.AvailableBytes < 16) break;

                int humanId = r.GetInt();
                float x = r.GetFloat(), y = r.GetFloat(), z = r.GetFloat();
                if (humanId == 0) continue;
                if (TwinManager.IsTwin(humanId)) continue;

                var pos = new Vector3(x, y, z);

                if (!_npcs.TryGetValue(humanId, out var st))
                {
                    st = new NpcState { CurPos = pos, CurTime = now, HasPrev = false };
                    if (!TryBind(humanId, st)) continue;   // citizen not present locally
                    _npcs[humanId] = st;
                }
                else
                {
                    // Shift the sample window forward.
                    st.PrevPos  = st.CurPos;
                    st.PrevTime = st.CurTime;
                    st.CurPos   = pos;
                    st.CurTime  = now;
                    st.HasPrev  = true;
                }

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
        float renderTime = now - INTERP_DELAY_S;
        float dt = Time.unscaledDeltaTime;

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

            Transform t;
            try { t = human.transform; } catch { _dropScratch.Add(kv.Key); continue; }
            if (t == null) { _dropScratch.Add(kv.Key); continue; }

            // ── Interpolate ──────────────────────────────────────────────
            Vector3 target;
            float speed = 0f;
            if (!st.HasPrev)
            {
                target = st.CurPos;
            }
            else if (Vector3.Distance(st.PrevPos, st.CurPos) > TELEPORT_M)
            {
                // SoD moved them discontinuously (lift, vehicle, respawn).
                target = st.CurPos;
            }
            else
            {
                float span = Mathf.Max(st.CurTime - st.PrevTime, 0.0001f);
                float f = Mathf.Clamp01((renderTime - st.PrevTime) / span);
                target = Vector3.Lerp(st.PrevPos, st.CurPos, f);
                speed = Vector3.Distance(st.PrevPos, st.CurPos) / span;
            }

            try { t.position = target; } catch { _dropScratch.Add(kv.Key); continue; }

            // ── Facing follows movement ──────────────────────────────────
            if (speed > MOVING_SPEED_EPS && st.HasPrev)
            {
                Vector3 dir = st.CurPos - st.PrevPos;
                dir.y = 0f;
                if (dir.sqrMagnitude > 0.0001f)
                {
                    try
                    {
                        var want = Quaternion.LookRotation(dir.normalized, Vector3.up);
                        t.rotation = Quaternion.RotateTowards(t.rotation, want, TURN_DEG_PER_S * dt);
                    }
                    catch { }
                }
            }

            DriveWalkAnimation(st, speed);
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
    }
}
