using System;
using System.Collections.Generic;
using System.IO;
using LiteNetLib;
using SoDCoop.Network.Steam;
using LiteNetLib.Utils;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Zdo;

/// <summary>
/// Singleton ZDO registry + change-detection driver. Owns:
///   • Primary index: <c>ZDOID → Zdo</c>.
///   • Secondary index by <see cref="ZdoTypeTag"/>.
///   • Per-tick delta flush (default 10 Hz) — collects every dirty ZDO,
///     serialises into one <see cref="PacketType.ZdoDeltaBatch"/>, sends
///     to all peers, clears dirty flags.
///   • Snapshot build / apply for late joiners.
///   • Persistence to disk under <c>&lt;BepInEx&gt;/config/com.sodcoop.mod/zdo/</c>.
///
/// <para>All mutation happens on the Unity main thread inside the
/// <c>CoopUpdateRunner.Update</c> cascade — no locks.</para>
/// </summary>
public static class ZdoMan
{
    public const byte WIRE_VERSION = 1;
    /// <summary>Delta flush rate. 20 Hz since 2026-09-29: remote players'
    /// positions ride the LocalPlayer ZDO, so this IS their send rate, and at
    /// 10 Hz RemotePlayer's 120 ms interpolation delay covered only 1.2 send
    /// intervals — every lost or late packet dropped playback into
    /// extrapolation (the ≥2-interval rule). Per-flush batches halve in size,
    /// so the byte cost is about the same; only the packet count doubles.</summary>
    public const float DEFAULT_FLUSH_HZ = 20f;
    public const int   DEFAULT_COMPRESSION_THRESHOLD = 100;

    /// <summary>Local peer's stable uid (FNV-1a-64 of profile clientGuid).
    /// Set on first call to <see cref="EnsureLocalPeerUid"/>.</summary>
    public static ulong LocalPeerUid { get; private set; }

    /// <summary>Monotonic counter for ZDOIDs minted on this peer.</summary>
    private static uint _nextSequence = 1u;

    private static readonly Dictionary<ZDOID, Zdo> _byId = new();
    private static readonly Dictionary<ZdoTypeTag, HashSet<Zdo>> _byType = new();

    /// <summary>O(1) lookup index: (tag, int sodId) → Zdo. Replaces the
    /// previous linear scan in <see cref="FindBySodId"/>, which was the main
    /// freeze cause: pollers like CitizenStatePoller and LightPoller call
    /// <see cref="GetOrCreateBySodId"/> per object per tick (~336–1500 calls)
    /// and the linear scan made each tick O(N²) on the host main thread.
    /// HasPeers gates poller execution, so the cost only kicked in the
    /// instant a joiner connected — exactly the freeze the user observed.</summary>
    private static readonly Dictionary<(ZdoTypeTag tag, int sodId), Zdo> _bySodIdInt = new();

    /// <summary>O(1) lookup index for string-keyed ZDOs (Evidence.evID, etc.).</summary>
    private static readonly Dictionary<(ZdoTypeTag tag, string sodIdStr), Zdo> _bySodIdStr = new();

    /// <summary>Live dirty set, fed by <see cref="Zdo.MarkDirty"/>. Replaces the
    /// per-flush O(N_zdos) scan of <see cref="_byId"/> that used to look for
    /// <c>IsDirty == true</c>. With ~19 000 ZDOs in a typical session the
    /// previous pattern was 19 K dictionary iterations × 10 Hz = 190 K
    /// pointless null-checks per second on the host main thread; now the
    /// flush only walks the actual dirty list, which is empty most ticks.
    /// Mirrors Valheim's <c>ZDOMan.m_changed</c> collection.</summary>
    private static readonly HashSet<Zdo> _dirty = new();

    /// <summary>Called from <see cref="Zdo.MarkDirty"/> when a ZDO transitions
    /// from clean to dirty. ZDO that goes clean→dirty→clean within one flush
    /// tick still ends up in this set on the dirty edge; ClearDirty removes it.</summary>
    internal static void NotifyZdoDirty(Zdo z) => _dirty.Add(z);

    /// <summary>Called from <see cref="Zdo.ClearDirty"/> when a ZDO has been
    /// flushed (or its receive-side mutations explicitly cleared after a
    /// remote-originated apply, so it doesn't echo back). Keeps
    /// <see cref="_dirty"/> in sync with the actual dirty set instead of
    /// drifting; previously a remote-driven ClearDirty (e.g. after
    /// <see cref="ApplyDeltaBatch"/> applied a peer's delta to a local
    /// ZDO) wouldn't remove the ZDO from <see cref="_dirty"/>, leading
    /// to next flush serialising an empty entry for it.</summary>
    internal static void NotifyZdoClean(Zdo z) => _dirty.Remove(z);

    // ── Sector culling (Nebula DSP-mod pattern) ─────────────────────────
    /// <summary>Tile size in world units. The SoD city is a ~600 × 500 m
    /// grid of CityTiles, each ~100 m on a side; we use that as our
    /// natural sector grid. ZDOs whose <see cref="Zdo.HostPosition"/> is
    /// further than <see cref="CULL_RADIUS_M"/> from a peer's last-known
    /// position are skipped in that peer's per-flush dispatch.</summary>
    public const float CULL_RADIUS_M = 150f;
    /// <summary>Squared form of <see cref="CULL_RADIUS_M"/> — distance
    /// comparison stays sqrMagnitude to avoid the per-check sqrt.</summary>
    private const float CULL_RADIUS_M_SQ = CULL_RADIUS_M * CULL_RADIUS_M;

    /// <summary>Stamp the host-side world position onto a ZDO. Called by
    /// pollers as they observe SoD's entity transforms. For static-position
    /// entities (Lights, Doors, Switches, Computers) call once at first
    /// observation; for dynamic ones (Citizens, Footprints) call every
    /// tick. The cost is a single Vector3 assignment + a bool — doesn't
    /// touch the dirty set. Position is HOST-LOCAL only; never serialised.</summary>
    public static void NotifyZdoPosition(Zdo z, UnityEngine.Vector3 pos)
    {
        if (z == null) return;
        z.HostPosition = pos;
        z.HasHostPosition = true;
        // Indexed into the tile-bucketed spatial grid so catch-up queries
        // are O(visible cells) instead of O(N_spatial) linear scan. The grid
        // handles same-cell no-op + cross-cell move atomically.
        SpatialGrid.Insert(z);
    }

    /// <summary>Spatial index of every ZDO with a known host position. Was a
    /// flat <c>HashSet&lt;Zdo&gt;</c> that <see cref="EvaluatePeerCatchup"/>
    /// walked linearly (~2 K entries per peer movement); now a tile-bucketed
    /// grid (<see cref="SpatialGrid"/>) so the catch-up query touches only
    /// the 3×3 cell window around the peer.</summary>

    /// <summary>Per-peer "ZDOs currently in sector-cull range" snapshot.
    /// Diffed each <see cref="EvaluatePeerCatchup"/> call to find newly-
    /// entered ZDOs and queue them for a full-state resend so the peer
    /// gets accurate state for static entities (doors, lights, switches,
    /// computers) that were last changed when they were out of range.</summary>
    private static readonly Dictionary<int, HashSet<Zdo>> _inRangeForPeer = new();

    /// <summary>Per-peer "ZDOs that need a full-state resend on the next
    /// flush." Filled by <see cref="EvaluatePeerCatchup"/> when peer walks
    /// into a previously out-of-range cluster. Drained per flush.</summary>
    private static readonly Dictionary<int, HashSet<Zdo>> _pendingResendForPeer = new();

    /// <summary>Min XZ distance moved before we re-evaluate which ZDOs are
    /// in range of a peer. Half the cull radius — if peer moved less than
    /// this, no ZDO can have crossed in/out (peer's view of the world is
    /// still the same set of cull cells). Saves the per-position-packet
    /// O(spatial) walk; otherwise PlayerPosition at 30 Hz × 2000 ZDOs =
    /// 60 K iterations/sec/peer when running.</summary>
    private const float CATCHUP_REEVAL_M = 50f;

    /// <summary>Re-evaluate at least this often even when the peer stands
    /// still — see the note in <see cref="EvaluatePeerCatchup"/>.</summary>
    private const float CATCHUP_REEVAL_S = 2f;
    private static readonly Dictionary<int, float> _lastCatchupAt = new();
    private const float CATCHUP_REEVAL_M_SQ = CATCHUP_REEVAL_M * CATCHUP_REEVAL_M;

    /// <summary>Called from <c>PlayerSync.OnRemotePlayerPosition</c> when a
    /// peer's broadcast position arrives. Detects "peer moved into a new
    /// sector" and queues full-state resend for newly-visible ZDOs so the
    /// peer doesn't see stale state for entities they walked into.
    ///
    /// <para>Citizens need it as much as doors: their position is stamped
    /// with <see cref="NotifyZdoPosition"/>, which marks nothing dirty, so a
    /// citizen moving into range brings no state with it. Hence the time-based
    /// re-evaluation on top of the movement-based one.</para></summary>
    public static void EvaluatePeerCatchup(int peerId, UnityEngine.Vector3 newPeerPos)
    {
        if (!NetworkManager.IsHost) return;
        if (!NetworkManager.Players.TryGetValue(peerId, out var info) || info == null) return;

        // Debounce: skip the diff if the peer hasn't moved far enough to
        // cross a cull boundary AND the last evaluation is recent. The time
        // half matters: citizens move by themselves. A citizen whose state
        // changed while out of range and then WALKED into range of a peer
        // standing still was never caught up — its position is stamped with
        // NotifyZdoPosition, which (despite an older note here) marks nothing
        // dirty — so a stake-out saw everyone arrive with stale state.
        float nowT = UnityEngine.Time.unscaledTime;
        if (info.HasCatchupBaseline)
        {
            float ddx = newPeerPos.x - info.LastCatchupPos.x;
            float ddz = newPeerPos.z - info.LastCatchupPos.z;
            _lastCatchupAt.TryGetValue(peerId, out float lastAt);
            if (ddx * ddx + ddz * ddz < CATCHUP_REEVAL_M_SQ && nowT - lastAt < CATCHUP_REEVAL_S) return;
        }
        info.LastCatchupPos = newPeerPos;
        info.HasCatchupBaseline = true;
        _lastCatchupAt[peerId] = nowT;

        if (!_pendingResendForPeer.TryGetValue(peerId, out var pending))
        {
            pending = new HashSet<Zdo>();
            _pendingResendForPeer[peerId] = pending;
        }
        if (!_inRangeForPeer.TryGetValue(peerId, out var prevInRange))
        {
            prevInRange = new HashSet<Zdo>();
            _inRangeForPeer[peerId] = prevInRange;
        }

        // Query the spatial grid for ZDOs within cull radius of the peer.
        // This is the hot path that used to linear-scan the whole spatial
        // set (~2 K entries) on every peer-movement-debounced eval; the grid
        // walks only the 3×3 cell window around the peer and returns exactly
        // the in-range set, distance-checked.
        var inRange = SpatialGrid.Query(newPeerPos, CULL_RADIUS_M);
        foreach (var z in inRange)
        {
            if (!prevInRange.Contains(z)) pending.Add(z);
        }
        // Move the queried set into the peer's persistent slot. Reuse
        // prevInRange (already allocated) as the new container instead of
        // allocating a fresh HashSet.
        prevInRange.Clear();
        foreach (var z in inRange) prevInRange.Add(z);
        // _inRangeForPeer[peerId] already references prevInRange via
        // TryGetValue above, so no re-assignment needed.

        if (pending.Count > 0)
        {
            // Bound: don't let pending grow without limit if peer position
            // jitters across the cull boundary — stale entries get drained
            // on the next flush regardless.
            Plugin.Log.LogDebug($"[ZdoMan] peer {peerId} entered range of {pending.Count} new ZDOs (catch-up queued).");
        }
    }

    /// <summary>Drop all per-peer catch-up state for a peer (called on
    /// disconnect to bound memory growth). Includes the per-peer
    /// DataRevision cursor stored on <see cref="PlayerNetInfo.LastSeenRev"/>
    /// — caller does this by removing the player slot itself, but if the
    /// player slot is being kept around for any reason (e.g. still in the
    /// reconnect-grace window), this method is a no-op for the cursor and
    /// the grace-window reconnect path handles the cursor instead.</summary>
    internal static void OnPeerDisconnectedForCatchup(int peerId)
    {
        _inRangeForPeer.Remove(peerId);
        _pendingResendForPeer.Remove(peerId);
        _lastCatchupAt.Remove(peerId);
        // Cursor lives on PlayerNetInfo.LastSeenRev; the caller
        // (NetworkManager.FinalisePendingDisconnects) removes the whole
        // slot, which drops the cursor with it. No work to do here.
    }

    /// <summary>Pending ownership transfers awaiting wire delivery.</summary>
    private static readonly Queue<(ZDOID id, ulong newOwner)> _pendingOwnershipBroadcast = new();

    private static float _nextFlushAt;
    private static uint  _flushTickCounter;
    private static bool  _initialized;

    public static event Action<Zdo> OnZdoCreated;
    public static event Action<Zdo> OnZdoDestroyed;
    public static event Action<Zdo, ulong /*old*/, ulong /*new*/> OnOwnershipChanged;

    // Reusable scratch writers / readers.
    private static readonly NetDataWriter _flushScratch = new();
    private static readonly NetDataWriter _snapshotScratch = new();
    private static readonly NetDataWriter _payloadScratch = new();

    // Reusable scratch sets — single-threaded main-thread Update path, so
    // these are safe as static singletons. Each call site MUST Clear() before
    // using. Avoids per-flush HashSet allocations: 4 peers × 10 Hz =
    // 40 GC-tracked allocations/sec previously.
    private static readonly HashSet<Zdo> _sentInThisPacketScratch = new();
    // Materialised drain list for capped catch-up (bug #3): we Take(N) ZDOs
    // out of the pending HashSet per flush so a 1000+ entry teleport doesn't
    // produce a single multi-MB head-of-line packet.
    private static readonly List<Zdo> _pendingDrainScratch = new();

    // ── Stats (5s rolling counters; logged from TickDeltaFlush) ─────────
    private static long  _stats_dirtyCount;
    private static long  _stats_bytesSent;
    private static long  _stats_relBytes;     // Bytes sent on ReliableOrdered channel.
    private static long  _stats_seqBytes;     // Bytes sent on Sequenced channel.
    private static long  _stats_culled;
    private static long  _stats_pendingResent;
    /// <summary>Bug #cursor: number of (peer, ZDO) pairs skipped this 5 s
    /// window because the peer's <c>LastSeenRev</c> already contains a
    /// revision &gt;= the ZDO's current <c>DataRevision</c>. Lets us see
    /// the cursor doing its job (especially after reconnect, where it
    /// should account for nearly the whole pre-existing world).</summary>
    private static long  _stats_cursorSkip;
    private static float _nextStatsLogAt;

    /// <summary>Per-build scratch list of (Zdo, revisionAtSerialise) pairs
    /// written into the most recent <see cref="_payloadScratch"/>. After a
    /// successful <see cref="WrapAndSendTo"/>, the host walks this and
    /// stamps each pair into the peer's <see cref="PlayerNetInfo.LastSeenRev"/>
    /// — that's the optimistic cursor update. We cache the revision at
    /// serialise time (not at update time) so a same-tick re-mutation
    /// doesn't accidentally mark the peer as having seen the newer rev.</summary>
    private static readonly List<(Zdo z, uint rev)> _serialisedThisBuild = new();

    /// <summary>Bug #3: cap the catch-up resend per-flush per-peer. Without
    /// this, a peer teleporting 500 m can drain 1000–2000 full-state ZDOs
    /// into a single ReliableOrdered packet, blocking the channel for
    /// seconds. Remaining entries stay in <see cref="_pendingResendForPeer"/>
    /// and are drained over subsequent flushes.</summary>
    private const int MAX_CATCHUP_PER_FLUSH = 100;

    /// <summary>Per-peer per-flush dirty-delta serialization budget, in
    /// approximate payload bytes (Valheim ZDOMan pattern — bounded send, not
    /// "serialize everything every tick"). Once a peer's delta packet reaches
    /// this size in <see cref="BuildPayloadFromDirty"/>, the remaining dirty
    /// ZDOs that still qualify for that peer (passed cull + cursor + class) are
    /// pushed to its <see cref="_pendingResendForPeer"/> set instead of
    /// serialised, and drained (Pass-1 catch-up) on the next flush — so nothing
    /// is lost, and previously-cut ZDOs get priority next tick (natural
    /// fairness, no per-peer distance sort needed).
    ///
    /// <para>This is a SAFETY CAP for bursts, not a constant throttle: after
    /// the CitizenStatePoller cadence split, normal flushes are well under
    /// budget. It only engages on spikes — the ~1 Hz vitals slow-lane tick, a
    /// player entering a dense area, mass NPC events, or 3-4 peers — where it
    /// spreads the spike across ~2-3 flushes (≤300 ms) instead of one host
    /// frame stall. 16 KB uncompressed ≈ 5-8 KB on the wire after zstd.</para></summary>
    private const int MAX_DELTA_BYTES_PER_FLUSH = 16384;

    /// <summary>Scratch list of ZDOs cut by the per-flush budget in the most
    /// recent <see cref="BuildPayloadFromDirty"/> call. The caller moves these
    /// into the peer's pending-resend set after sending. Cleared at the start
    /// of every BuildPayloadFromDirty.</summary>
    private static readonly List<Zdo> _budgetOverflowScratch = new();

    // ── Lifecycle ─────────────────────────────────────────────────────

    public static void Initialize()
    {
        if (_initialized) return;
        EnsureLocalPeerUid();
        _initialized = true;
        _nextFlushAt = 0f;
        Plugin.Log.LogInfo($"[ZdoMan] initialized, localPeerUid={LocalPeerUid:X16}");
    }

    public static void Shutdown()
    {
        Clear();
        _initialized = false;
    }

    public static void EnsureLocalPeerUid()
    {
        if (LocalPeerUid != 0ul) return;
        try
        {
            string guid = Player.CharacterIdentity.ClientGuid;
            LocalPeerUid = Hash32.Of64(guid);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] could not resolve clientGuid: {ex.Message}; using volatile uid");
            LocalPeerUid = (ulong)Guid.NewGuid().GetHashCode();
        }
    }

    /// <summary>Client: true once the host's snapshot has been applied to the
    /// world we are in now — i.e. we are in the HOST's world, not our own.
    /// Cleared with the registry (world unload / load) and on disconnect.
    ///
    /// <para>Gates every client-side poller. A player who connects while in
    /// their own game keeps playing that world for the seconds it takes the
    /// host to capture and ship its save; without the gate the client pollers
    /// ran against that foreign world and reported its doors, switches,
    /// prints and items to the host by id — where the same ids name
    /// different objects.</para></summary>
    public static bool ClientSynced { get; private set; }

    public static void MarkClientUnsynced() => ClientSynced = false;

    public static void Clear()
    {
        ClientSynced = false;
        _byId.Clear();
        _byType.Clear();
        _bySodIdInt.Clear();
        _bySodIdStr.Clear();
        _dirty.Clear();
        SpatialGrid.Clear();
        _inRangeForPeer.Clear();
        _pendingResendForPeer.Clear();
        _pendingOwnershipBroadcast.Clear();
        // Drop any half-received chunked snapshot. A partial stream that
        // survived into a new session would be appended to by the next
        // header-less chunk and restored as a fragment.
        ResetChunkReassembly();
        // Drop any half-sent chunked snapshot: the entries pin multi-MB
        // buffers and reference peers from the session being torn down.
        _pendingSnapshotSends.Clear();
        // Session-scoped state that previously leaked across host/menu/host
        // cycles: the auth-reject log throttle grew unbounded under a
        // misbehaving/version-mismatched peer, and a stale pending snapshot
        // entry (peer dropped mid-join while its compress Task was in flight)
        // would fire one bogus send next session. Clear both on world-unready.
        _authRejectLogThrottle.Clear();
        _pendingSnapshotSends.Clear();
        // Amortized resolver-apply queue is session-scoped too: a queue
        // drained mid-way when the world unloads must not replay stale
        // applies into the next session's freshly-generated city.
        _pendingResolverApply.Clear();
        _pendingResolverApplySet.Clear();
        _resolverApplyDrainTotal = 0;
        _nextSequence = 1u;
        _flushTickCounter = 0u;
    }

    /// <summary>Read the ZDO's current (SodId / SodIdStr) keys and stamp them
    /// into <see cref="_bySodIdInt"/> / <see cref="_bySodIdStr"/>. Idempotent
    /// — safe to call after every mutation that *might* have set the SodId
    /// (delta apply, snapshot restore, GetOrCreate).</summary>
    private static void IndexSodId(Zdo z)
    {
        if (z == null) return;
        int sid = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (sid != int.MinValue)
            _bySodIdInt[(z.ZdoTypeTag, sid)] = z;
        var sstr = z.GetString(ZdoKeys.SodIdStr, null);
        if (!string.IsNullOrEmpty(sstr))
            _bySodIdStr[(z.ZdoTypeTag, sstr)] = z;
    }

    /// <summary>Drop the ZDO from the (tag, sodId) indices. Called from
    /// <see cref="Destroy"/>.</summary>
    private static void UnindexSodId(Zdo z)
    {
        if (z == null) return;
        int sid = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (sid != int.MinValue)
            _bySodIdInt.Remove((z.ZdoTypeTag, sid));
        var sstr = z.GetString(ZdoKeys.SodIdStr, null);
        if (!string.IsNullOrEmpty(sstr))
            _bySodIdStr.Remove((z.ZdoTypeTag, sstr));
    }

    // ── Create / Lookup / Destroy ─────────────────────────────────────

    public static Zdo Create(ZdoTypeTag tag, ulong owner = 0ul, bool persistent = true)
    {
        EnsureLocalPeerUid();
        ZDOID id = new ZDOID(LocalPeerUid, _nextSequence++);
        if (owner == 0ul) owner = LocalPeerUid;
        var z = new Zdo(id, tag, owner, persistent);
        Register(z);
        OnZdoCreated?.Invoke(z);
        return z;
    }

    private static void Register(Zdo z)
    {
        _byId[z.Id] = z;
        if (!_byType.TryGetValue(z.ZdoTypeTag, out var set))
        {
            set = new HashSet<Zdo>();
            _byType[z.ZdoTypeTag] = set;
        }
        set.Add(z);
    }

    public static Zdo Lookup(ZDOID id)
    {
        return _byId.TryGetValue(id, out var z) ? z : null;
    }

    public static IEnumerable<Zdo> AllOfType(ZdoTypeTag tag)
    {
        return _byType.TryGetValue(tag, out var set) ? (IEnumerable<Zdo>)set : Array.Empty<Zdo>();
    }

    public static int Count => _byId.Count;

    // ── Amortized resolver apply (joiner-side catch-up) ──────────────

    /// <summary>FIFO queue of ZDOs awaiting a resolver apply, drained at
    /// <see cref="RESOLVER_APPLIES_PER_FRAME"/> per frame by
    /// <see cref="PumpPendingResolverApplies"/>. Exists because the two
    /// joiner-side "apply the whole world" paths (snapshot restore and
    /// post-load catch-up) used to walk the entire ~20 K-ZDO registry and
    /// run every resolver inline in a single frame — a multi-hundred-ms
    /// hitch exactly when the client spawns into the world.
    ///
    /// <para>Amortizing is safe because resolvers read the ZDO's CURRENT
    /// registry state at apply time (not a captured snapshot): a delta
    /// arriving and applying inline before the amortized baseline apply
    /// runs is harmless — the later queued apply just re-applies the same
    /// freshest state (idempotent). Queue order only affects how quickly
    /// a given object visually catches up, never correctness.</para></summary>
    private static readonly List<Zdo> _pendingResolverApply = new();

    /// <summary>Dedup companion to <see cref="_pendingResolverApply"/> —
    /// a ZDO already queued isn't queued twice (re-applying the same
    /// current state twice would be wasted work, not a bug).</summary>
    private static readonly HashSet<Zdo> _pendingResolverApplySet = new();

    /// <summary>Resolver applies drained per frame. 1500/frame clears a
    /// ~20 K registry in ~13 frames (~0.2 s at 60 fps) instead of one
    /// 300+ ms single-frame stall.</summary>
    private const int RESOLVER_APPLIES_PER_FRAME = 1500;

    /// <summary>Running count of applies performed in the current drain
    /// cycle — reported once in the queue-drained log line, then reset.</summary>
    private static int _resolverApplyDrainTotal;

    /// <summary>Queue <paramref name="z"/> for an amortized resolver apply.
    /// No-op if it's null or already queued.</summary>
    private static void EnqueueResolverApply(Zdo z)
    {
        if (z == null) return;
        if (!_pendingResolverApplySet.Add(z)) return;
        _pendingResolverApply.Add(z);
    }

    /// <summary>Drain up to <see cref="RESOLVER_APPLIES_PER_FRAME"/> queued
    /// resolver applies. Called once per frame from
    /// <c>CoopUpdateRunner.Update</c>; early-returns when the queue is
    /// empty. Errors are throttled to 5 log lines per call (same pattern
    /// as the old inline catch-up loop) so one broken resolver can't spam
    /// the BepInEx log thousands of times in a single drain.</summary>
    public static void PumpPendingResolverApplies()
    {
        if (_pendingResolverApply.Count == 0) return;

        int take = Math.Min(RESOLVER_APPLIES_PER_FRAME, _pendingResolverApply.Count);
        int errors = 0;
        for (int i = 0; i < take; i++)
        {
            var z = _pendingResolverApply[i];
            _pendingResolverApplySet.Remove(z);
            // Skip ZDOs destroyed (or replaced in the registry) while
            // queued — mirrors the old inline loops, which only ever saw
            // live registry entries.
            if (!_byId.TryGetValue(z.Id, out var live) || !ReferenceEquals(live, z)) continue;
            try
            {
                Resolvers.ZdoResolverRegistry.Apply(z);
                _resolverApplyDrainTotal++;
            }
            catch (Exception ex)
            {
                errors++;
                if (errors <= 5)
                    Plugin.Log.LogWarning($"[ZdoMan] amortized resolver apply failed for {z.Id} ({z.ZdoTypeTag}): {ex.Message}");
            }
        }
        // FIFO drain from the front: RemoveRange(0, take) is a single
        // memmove of the survivors (~150 KB of refs worst case) — far
        // cheaper than the resolver applies themselves, and it preserves
        // enqueue order so earlier-restored ZDOs catch up first.
        _pendingResolverApply.RemoveRange(0, take);

        if (_pendingResolverApply.Count == 0)
        {
            Plugin.Log.LogInfo($"[ZdoMan] amortized resolver apply complete ({_resolverApplyDrainTotal} total).");
            _resolverApplyDrainTotal = 0;
        }
    }

    /// <summary>
    /// Schedule every ZDO currently in the registry for a resolver apply.
    /// Used by joiner-side post-load to catch up on state that streamed in
    /// while SoD's city was still generating (resolvers were skipped at
    /// that time to avoid NREs against not-yet-existing Human /
    /// Interactable refs).
    ///
    /// <para>The applies are NOT performed inline — each registry ZDO is
    /// queued via <see cref="EnqueueResolverApply"/> and drained by
    /// <see cref="PumpPendingResolverApplies"/> at
    /// <see cref="RESOLVER_APPLIES_PER_FRAME"/> per frame. Applying all
    /// ~20 K resolvers in one frame cost 300+ ms exactly when the client
    /// spawned in; amortized, the same work spreads over ~13 frames
    /// (~0.2 s). Safe because resolvers read each ZDO's CURRENT registry
    /// state at apply time — any delta that lands (and applies inline)
    /// before a queued baseline apply runs is simply re-applied
    /// idempotently by the queued one.</para>
    /// </summary>
    public static void ApplyAllToLiveWorld()
    {
        try
        {
            foreach (var z in _byId.Values)
                EnqueueResolverApply(z);
            Plugin.Log.LogInfo($"[ZdoMan] catch-up apply scheduled for {_pendingResolverApply.Count} ZDOs (amortized at {RESOLVER_APPLIES_PER_FRAME}/frame).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] ApplyAllToLiveWorld: {ex}");
        }
    }

    public static void Destroy(ZDOID id)
    {
        if (!_byId.TryGetValue(id, out var z)) return;
        _byId.Remove(id);
        if (_byType.TryGetValue(z.ZdoTypeTag, out var set)) set.Remove(z);
        UnindexSodId(z);
        // Remove from the live dirty set so the next flush doesn't try to
        // serialise a destroyed ZDO. (HashSet.Remove on a missing entry is
        // a no-op, so this is safe regardless of dirty state.)
        _dirty.Remove(z);
        // Remove from spatial index + per-peer catch-up sets — otherwise
        // a future EvaluatePeerCatchup query would deref a freed ZDO.
        SpatialGrid.Remove(z);
        foreach (var kv in _inRangeForPeer)         kv.Value.Remove(z);
        foreach (var kv in _pendingResendForPeer)   kv.Value.Remove(z);
        OnZdoDestroyed?.Invoke(z);
    }

    /// <summary>Find a ZDO of <paramref name="tag"/> whose <c>__sodId</c> key
    /// matches <paramref name="sodId"/>. O(1) via <see cref="_bySodIdInt"/>.</summary>
    public static Zdo FindBySodId(ZdoTypeTag tag, int sodId)
    {
        return _bySodIdInt.TryGetValue((tag, sodId), out var z) ? z : null;
    }

    /// <summary>Variant for ZDOs keyed by string SoD ids (e.g. <c>Evidence.evID</c>).
    /// O(1) via <see cref="_bySodIdStr"/>.</summary>
    public static Zdo FindBySodIdStr(ZdoTypeTag tag, string sodIdStr)
    {
        if (sodIdStr == null) return null;
        return _bySodIdStr.TryGetValue((tag, sodIdStr), out var z) ? z : null;
    }

    /// <summary>Get-or-create with sodId stamped automatically.</summary>
    public static Zdo GetOrCreateBySodId(ZdoTypeTag tag, int sodId, ulong owner = 0ul, bool persistent = true)
    {
        var existing = FindBySodId(tag, sodId);
        if (existing != null) return existing;
        var z = Create(tag, owner, persistent);
        z.Set(ZdoKeys.SodId, sodId);
        z.Set(ZdoKeys.Type, (byte)tag);
        _bySodIdInt[(tag, sodId)] = z;
        return z;
    }

    /// <summary>Variant for ZDOs keyed by string SoD ids.</summary>
    public static Zdo GetOrCreateBySodIdStr(ZdoTypeTag tag, string sodIdStr, ulong owner = 0ul, bool persistent = true)
    {
        var existing = FindBySodIdStr(tag, sodIdStr);
        if (existing != null) return existing;
        var z = Create(tag, owner, persistent);
        z.Set(ZdoKeys.SodIdStr, sodIdStr);
        z.Set(ZdoKeys.Type, (byte)tag);
        if (!string.IsNullOrEmpty(sodIdStr))
            _bySodIdStr[(tag, sodIdStr)] = z;
        return z;
    }

    // ── Ownership ─────────────────────────────────────────────────────

    public static void TransferOwnership(ZDOID id, ulong newOwner)
    {
        var z = Lookup(id);
        if (z == null) return;
        ulong old = z.OwnerPeer;
        if (old == newOwner) return;
        z.SetOwnerInternal(newOwner);
        OnOwnershipChanged?.Invoke(z, old, newOwner);
        _pendingOwnershipBroadcast.Enqueue((id, newOwner));
    }

    /// <summary>True if this peer is allowed to write to <paramref name="z"/>.
    /// Owners may write; the host may always write (host-authoritative model
    /// for AI-driven ZDOs).</summary>
    public static bool CanWrite(Zdo z)
    {
        if (z.OwnerPeer == LocalPeerUid) return true;
        if (NetworkManager.IsHost) return true;
        return false;
    }

    // ── Per-tick delta flush ──────────────────────────────────────────

    /// <summary>Called from <c>CoopUpdateRunner.Update</c>. Throttled to
    /// the configured flush rate; no-op when not connected or world not ready.</summary>
    public static void TickDeltaFlush(float now)
    {
        if (!_initialized) return;
        if (!NetworkManager.HasPeers) return;
        if (now < _nextFlushAt) return;

        float interval = 1f / Mathf.Clamp(DEFAULT_FLUSH_HZ, 1f, 30f);
        // From the due time, not from now — see ZdoPollerHost.Tick: `now +
        // interval` made the 20 Hz flush a ~16 Hz one with uneven gaps.
        float next = _nextFlushAt + interval;
        _nextFlushAt = next > now ? next : now + interval * 0.5f;
        _flushTickCounter++;

        // Drain ownership transfers first so ownership-relevant deltas have
        // up-to-date authority by the time they hit the wire.
        DrainOwnershipTransfers();

        // Collect dirty ZDOs.
        BuildAndSendDeltaBatch();

        // Bug #6: rolling 5-second stats. Only emits when there's traffic
        // to report, otherwise idle sessions would spam the log every 5 s.
        if (now >= _nextStatsLogAt)
        {
            _nextStatsLogAt = now + 5f;
            // Drain event-channel counters every tick so they don't pile
            // up across idle minutes. Roll them into the same log line
            // alongside ZDO state traffic — one [ZdoStats] line covers
            // both replication channels.
            ZdoEventDispatcher.SampleStatsAndReset(out var evSent, out var evCullSkip, out var evBytes);
            if (NetworkManager.HasPeers
                && (_stats_dirtyCount + _stats_pendingResent + _stats_cursorSkip + evSent + evCullSkip) > 0)
            {
                Plugin.Log.LogInfo(
                    $"[ZdoStats] dirty/5s={_stats_dirtyCount} pending/5s={_stats_pendingResent} " +
                    $"culled/5s={_stats_culled} cursorSkip/5s={_stats_cursorSkip} " +
                    $"bytes/5s={_stats_bytesSent} (rel={_stats_relBytes} seq={_stats_seqBytes}) " +
                    $"ev/5s={evSent} evCull/5s={evCullSkip} evBytes/5s={evBytes} " +
                    // Clients.Count is the HOST's roster and is always 0 on a
                    // joiner, so this line used to report peers=0 on a perfectly
                    // healthy client while NetStats on the same machine said
                    // peers=1 — misleading in exactly the situation you read the
                    // log for. A joiner has one peer whenever it is connected.
                    $"peers={(NetworkManager.IsHost ? NetworkManager.Clients.Count : (NetworkManager.IsConnected ? 1 : 0))}");
            }
            _stats_dirtyCount = 0;
            _stats_pendingResent = 0;
            _stats_culled = 0;
            _stats_cursorSkip = 0;
            _stats_bytesSent = 0;
            _stats_relBytes = 0;
            _stats_seqBytes = 0;
        }
    }

    private static readonly List<Zdo> _dirtyScratch = new();

    /// <summary>
    /// Maps ZDO type tag to delivery class:
    /// <list type="bullet">
    /// <item><description><c>ReliableOrdered</c>: state-transition events whose
    /// loss is visible (door open/close, light on/off, switch flipped, evidence
    /// created / discovered, computer login, money txn, vmail / phonecall,
    /// case / case-board updates, item place / pickup, side-job state). MUST
    /// arrive — peer can't recover by re-polling.</description></item>
    /// <item><description><c>Sequenced</c>: idempotent overwrite state (citizen
    /// position / animstate / vitals, footprint adds, fingerprint adds,
    /// spatter, weather, local-player overwrite). Latest-wins; stale packets
    /// can be dropped by transport without harm. Reduces head-of-line blocking
    /// under packet loss because the channel doesn't retransmit-stall the
    /// following deltas — under 150 ms ping a single drop on a 10 Hz channel
    /// stalls 300+ ms of state on Reliable, but Sequenced just skips the
    /// stale frame and applies the next one.</description></item>
    /// </list>
    /// Default for unknown / unmapped tags is <c>ReliableOrdered</c> — losing
    /// an event is worse than retransmit head-of-line cost.
    /// </summary>
    private static DeliveryMethod GetDeliveryFor(ZdoTypeTag tag) => tag switch
    {
        // Sequenced — only for ZDOs whose keys are rewritten continuously, so
        // a lost packet really is replaced by the next flush.
        //
        // CORRECTION (2026-09-29): the flush ships per-KEY DELTAS and Zdo.Set
        // ignores unchanged values, so "the next flush recovers a loss" is
        // only true for keys that keep changing. A dropped (or late —
        // Sequenced also discards out-of-order packets) delta carrying a
        // citizen's Restrained / Stunned / InBed / Outfit / Dead, or a
        // one-shot fingerprint / footprint / spatter creation, was gone for
        // good — and the peer cursor recorded it as delivered, so no catch-up
        // ever re-sent it. Those now ride ReliableOrdered. LocalPlayer stays
        // Sequenced for its position stream; its discrete keys are re-sent
        // once a second by LocalPlayerPoller (Zdo.Touch) instead.
        ZdoTypeTag.PlayerTwin     => DeliveryMethod.Sequenced,
        ZdoTypeTag.LocalPlayer    => DeliveryMethod.Sequenced,
        ZdoTypeTag.Weather        => DeliveryMethod.Sequenced,
        ZdoTypeTag.Citizen        => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Footprint      => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Fingerprint    => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Spatter        => DeliveryMethod.ReliableOrdered,

        // ReliableOrdered — state transitions, one-shot creations, mutations
        // whose loss leaves a visible, unrecoverable divergence.
        ZdoTypeTag.Door           => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Light          => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Switch         => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Elevator       => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Computer       => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Case           => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.CaseBoardCard  => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.CaseBoardString=> DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.EvidenceObject => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Money          => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.VmailThread    => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.PhoneCall      => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.SideJob        => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Time           => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.PlacedItem     => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.ThrownItem     => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.HeldItem       => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.InventoryAction=> DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.SurveillanceTape => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.PauseState     => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.Chat           => DeliveryMethod.ReliableOrdered,
        ZdoTypeTag.MapPing        => DeliveryMethod.ReliableOrdered,

        // Default to Reliable for unknowns / safety.
        _ => DeliveryMethod.ReliableOrdered,
    };

    /// <summary>
    /// Drain the dirty set and send filtered per-peer batches.
    ///
    /// <para><b>Sector culling (Nebula DSP-mod pattern):</b> instead of
    /// blasting the same delta packet to every peer regardless of where
    /// they are in the city, we compute each peer's last-known position
    /// (broadcast by their PlayerSync at 5–30 Hz) and skip ZDOs whose
    /// <see cref="Zdo.HostPosition"/> is &gt; <see cref="CULL_RADIUS_M"/>
    /// metres away. ZDOs without a position (Money, Weather, Case,
    /// VmailThread, LocalPlayer) are global and always sent.</para>
    ///
    /// <para>Bandwidth win on a typical SoD city (6×5 tiles, ~600×500 m):
    /// a peer in one corner only receives ~25–40 % of citizen+light
    /// deltas vs. global broadcast. Combined with the sequential ID +
    /// per-peer packet, this is the same architecture pattern Subnautica's
    /// Nitrox and DSP's Nebula use for state replication, modulo tile
    /// granularity. We don't yet do per-peer cursor tracking (Valheim-
    /// grade) so a packet drop loses the delta for that peer — but
    /// LiteNetLib / Steam SDR's ReliableOrdered channel covers that.</para>
    ///
    /// <para>For peer-tile-change catch-up (peer walks into a previously
    /// out-of-range area and needs the current state of ZDOs there), the
    /// joiner-side will send an explicit <see cref="PacketType.ClientWorldReady"/>-
    /// style request next time it's implemented; for now the next time
    /// any of those out-of-range ZDOs becomes dirty (which polling
    /// guarantees within a tick), the peer in their new range will get
    /// it. State converges within a poller cycle (≤200 ms).</para>
    /// </summary>
    private static void BuildAndSendDeltaBatch()
    {
        bool hasDirty = _dirty.Count > 0;
        bool hasAnyPending = false;
        if (NetworkManager.IsHost)
        {
            foreach (var kv in _pendingResendForPeer)
                if (kv.Value.Count > 0) { hasAnyPending = true; break; }
        }
        if (!hasDirty && !hasAnyPending) return;

        // Snapshot the dirty set into a list so we can iterate while clearing.
        // Valheim's ZDOMan does the same: drain m_changed into a local list,
        // then ClearDirty() each one as we serialise it.
        _dirtyScratch.Clear();
        if (hasDirty)
        {
            foreach (var z in _dirty) _dirtyScratch.Add(z);
            _dirty.Clear();
        }

        // ── Joiner side: just one peer (the host) ───────────────────────
        // Joiner has no other peers to filter against; send all dirty as
        // one packet using the legacy broadcast path. Joiners never
        // generate catch-up resends.
        if (!NetworkManager.IsHost)
        {
            // Joiner side: only one peer (the host). No cursor — host is
            // authoritative and tracks its own state directly; joiner-
            // side cursor would be redundant.
            //
            // Two-class split: Reliable pass first (state transitions),
            // Sequenced pass second (overwrite state). Even with one peer
            // the head-of-line argument still holds: a dropped citizen-
            // position packet shouldn't stall the next door-open event
            // behind it (and vice versa, a dropped door event must
            // retransmit but it shouldn't stall a fresher position).
            BuildPayloadFromDirty(_dirtyScratch, applyCull: false, peerPos: default, peerPending: null, peerCursor: null, targetClass: DeliveryMethod.ReliableOrdered);
            if (_lastSerialisedCount > 0)
                WrapAndSend(PacketType.ZdoDeltaBatch, _payloadScratch, DeliveryMethod.ReliableOrdered);

            BuildPayloadFromDirty(_dirtyScratch, applyCull: false, peerPos: default, peerPending: null, peerCursor: null, targetClass: DeliveryMethod.Sequenced);
            if (_lastSerialisedCount > 0)
                WrapAndSend(PacketType.ZdoDeltaBatch, _payloadScratch, DeliveryMethod.Sequenced);

            ClearDirtyKeysOnSerialised();
            return;
        }

        // ── Host side: per-peer dispatch with sector culling + catch-up ─
        var clients = NetworkManager.Clients;
        if (clients.Count == 0)
        {
            // No peers — drop dirty and move on. Pending resend lists for
            // disconnected peers were already cleared in
            // OnPeerDisconnectedForCatchup.
            ClearDirtyKeysOnSerialised();
            return;
        }

        for (int ci = 0; ci < clients.Count; ci++)
        {
            var peer = clients[ci];
            if (peer == null) continue;
            int peerId = NetworkManager.GetPlayerIdByPeer(peer);
            if (peerId < 0) continue;

            // ── WorldReady gate ─────────────────────────────────────────────
            // Skip peers that haven't finished loading the world AND received
            // their snapshot. Serialising + shipping deltas to a still-loading
            // joiner is the "host lags before the client even loaded" cause:
            // the peer can't apply any of it (live SoD objects don't exist),
            // it's pure wasted main-thread serialisation, and on ReliableOrdered
            // it head-of-line-stalls the channel. WorldReady flips true in
            // PumpPendingSnapshotSends once the snapshot actually ships.
            PlayerNetInfo info = null;
            NetworkManager.Players?.TryGetValue(peerId, out info);
            if (info == null || !info.WorldReady) continue;

            UnityEngine.Vector3 peerPos = UnityEngine.Vector3.zero;
            bool useCull = false;
            if (info.HasKnownPosition)
            {
                peerPos = info.LastKnownPosition;
                useCull = true;
            }

            // Drain peer's pending-resend list inside the same packet.
            // These ZDOs entered the peer's cull range since the last
            // catch-up eval — we serialise their FULL current state so
            // the receiver gets accurate state for static-position
            // entities (doors, lights, switches) whose last write
            // happened while the peer was out of range.
            HashSet<Zdo> peerPending = null;
            _pendingResendForPeer.TryGetValue(peerId, out peerPending);

            // Pull peer's per-peer DataRevision cursor (Valheim ZDOMan
            // pattern). Skips ZDOs whose latest revision the peer has
            // already received — typical hit on quiet ZDOs that share a
            // dirty tick with chatty neighbours but didn't actually
            // mutate from this peer's perspective.
            var peerCursor = info?.LastSeenRev;

            // Two-pass per-peer: Reliable batch (state transitions) and
            // Sequenced batch (overwrite state). Each pass produces its own
            // ZdoDeltaBatch packet on its own delivery channel, eliminating
            // head-of-line blocking between the two classes. Cursor stamping
            // happens after each successful send so a dropped Sequenced
            // packet doesn't poison the Reliable cursor or vice versa.
            //
            // NB: pending catch-up entries are split by tag inside
            // BuildPayloadFromDirty — a Door pending entry will only be
            // emitted on the Reliable pass, a Citizen pending entry only on
            // the Sequenced pass. They stay in peerPending across the two
            // BuildPayloadFromDirty calls; whichever pass matches their
            // class drains them.

            // Pass 1: Reliable.
            BuildPayloadFromDirty(_dirtyScratch, useCull, peerPos, peerPending, peerCursor, DeliveryMethod.ReliableOrdered);
            if (_lastSerialisedCount > 0)
            {
                WrapAndSendTo(peer, PacketType.ZdoDeltaBatch, _payloadScratch, DeliveryMethod.ReliableOrdered);
                if (peerCursor != null)
                {
                    for (int si = 0; si < _serialisedThisBuild.Count; si++)
                    {
                        var (sz, srev) = _serialisedThisBuild[si];
                        peerCursor[sz.Id] = srev;
                    }
                }
            }
            // Move budget-cut ZDOs into this peer's pending set so the next
            // flush's catch-up pass re-ships them (full state). Drain BEFORE
            // the next BuildPayloadFromDirty, which clears the overflow list.
            DrainBudgetOverflowToPending(peerId, ref peerPending);

            // Pass 2: Sequenced. Note: optimistic cursor update on
            // Sequenced is slightly weaker than on Reliable — a transport
            // drop won't be retransmitted, so the cursor may briefly claim
            // the peer has a revision they actually missed. The next 10 Hz
            // flush re-emits the latest revision (overwrite-state ZDOs are
            // re-dirtied by pollers) and the cursor self-corrects within
            // ≤200 ms. Acceptable for citizen position / footprints / etc.
            BuildPayloadFromDirty(_dirtyScratch, useCull, peerPos, peerPending, peerCursor, DeliveryMethod.Sequenced);
            if (_lastSerialisedCount > 0)
            {
                WrapAndSendTo(peer, PacketType.ZdoDeltaBatch, _payloadScratch, DeliveryMethod.Sequenced);
                if (peerCursor != null)
                {
                    for (int si = 0; si < _serialisedThisBuild.Count; si++)
                    {
                        var (sz, srev) = _serialisedThisBuild[si];
                        peerCursor[sz.Id] = srev;
                    }
                }
            }
            DrainBudgetOverflowToPending(peerId, ref peerPending);
        }

        // After all peers processed, clear dirty keys on every ZDO that
        // was in the snapshot. ZDOs that were filtered out for ALL peers
        // still have their dirty keys cleared — peers will re-receive the
        // current state on the next poller-driven Set() (within ~200 ms),
        // since pollers re-write the same fields.
        ClearDirtyKeysOnSerialised();
    }

    /// <summary>How many ZDOs were actually written into <see cref="_payloadScratch"/>
    /// by the most recent <see cref="BuildPayloadFromDirty"/> call. Lets
    /// the caller decide whether a wire send is worth doing.</summary>
    private static int _lastSerialisedCount;

    /// <summary>Move any ZDOs cut by the per-flush budget (recorded in
    /// <see cref="_budgetOverflowScratch"/> by the most recent
    /// <see cref="BuildPayloadFromDirty"/>) into the given peer's pending-resend
    /// set, creating the set if the peer had none. The next flush's Pass-1
    /// catch-up drains them (full state) — so a budget cut only DEFERS state by
    /// a flush or two, never drops it. Clears the overflow scratch.</summary>
    private static void DrainBudgetOverflowToPending(int peerId, ref HashSet<Zdo> peerPending)
    {
        if (_budgetOverflowScratch.Count == 0) return;
        if (peerPending == null)
        {
            peerPending = new HashSet<Zdo>();
            _pendingResendForPeer[peerId] = peerPending;
        }
        for (int i = 0; i < _budgetOverflowScratch.Count; i++)
            peerPending.Add(_budgetOverflowScratch[i]);
        _budgetOverflowScratch.Clear();
    }

    /// <summary>Serialise the dirty list (delta) and any peer-specific
    /// catch-up entries (full state) into <see cref="_payloadScratch"/>.
    /// Per-peer cull skips dirty ZDOs that fail the distance check;
    /// catch-up entries are always included regardless of cull because
    /// they were just selected from in-range. Drains the peer's pending
    /// list as a side effect.
    ///
    /// <para><paramref name="peerCursor"/> is the peer's per-peer
    /// DataRevision cursor (Valheim ZDOMan.m_dataRevisions pattern). When
    /// non-null, dirty entries with <c>cursor[id] &gt;= z.DataRevision</c>
    /// are skipped — peer already has at least this revision. Catch-up
    /// resend entries also honour the cursor: a peer that walks back
    /// into range of a ZDO it already has up-to-date doesn't need
    /// the full-state resend. The caller is responsible for stamping
    /// the cursor with the new revisions AFTER the wire send completes;
    /// we record per-build state into <see cref="_serialisedThisBuild"/>
    /// so the caller doesn't need to know our internal serialisation
    /// loop.</para></summary>
    private static void BuildPayloadFromDirty(List<Zdo> dirty, bool applyCull, UnityEngine.Vector3 peerPos, HashSet<Zdo> peerPending, Dictionary<ZDOID, uint> peerCursor, DeliveryMethod targetClass)
    {
        _payloadScratch.Reset();
        _payloadScratch.Put(_flushTickCounter);

        // Write a placeholder count; back-fill once we know how many we kept.
        int countByteOffset = _payloadScratch.Length;
        _payloadScratch.Put((ushort)0);

        int written = 0;
        _serialisedThisBuild.Clear();
        _budgetOverflowScratch.Clear();

        // De-dup: a ZDO present in BOTH dirty AND pending should only be
        // serialised once. Pending entries take priority (they include
        // the full key set, which subsumes the dirty subset). This is
        // a small set so a HashSet check is cheap.
        // Bug #2: reusable scratch — Clear() before use rather than
        // allocate per peer per flush.
        bool useDedup = peerPending != null && peerPending.Count > 0;
        if (useDedup) _sentInThisPacketScratch.Clear();

        // ── Pass 1: catch-up resend (full state) ────────────────────────
        // Bug #3: cap drain to MAX_CATCHUP_PER_FLUSH so a teleporting peer
        // doesn't produce a multi-MB head-of-line ReliableOrdered packet.
        // Materialise up to N entries into _pendingDrainScratch, serialise
        // them, then Remove() each from peerPending — leaving the rest for
        // future flushes. HashSet iteration order is undefined but stable
        // enough that successive flushes converge.
        //
        // Per-class split: we only emit pending entries whose tag matches
        // <paramref name="targetClass"/>. Mismatched entries stay in
        // peerPending and ride the *other* pass's packet — without this,
        // we'd re-classify the catch-up resend onto a Sequenced channel
        // for a Door (state transition) and the receiver might never see
        // it under loss.
        if (useDedup)
        {
            _pendingDrainScratch.Clear();
            int taken = 0;
            foreach (var z in peerPending)
            {
                if (taken >= MAX_CATCHUP_PER_FLUSH) break;
                if (GetDeliveryFor(z.ZdoTypeTag) != targetClass) continue;
                _pendingDrainScratch.Add(z);
                taken++;
            }
            for (int pi = 0; pi < _pendingDrainScratch.Count; pi++)
            {
                var z = _pendingDrainScratch[pi];
                if (z == null) continue;

                // Byte budget also applies to the catch-up pass. The count
                // cap alone (MAX_CATCHUP_PER_FLUSH=100) lets 100 FULL-state
                // ZDOs through — at a few hundred bytes each that's ~30 KB,
                // double the intended per-flush budget. Stop serialising at
                // the budget; un-drained entries simply stay in peerPending
                // (we only Remove() after a successful serialise below) and
                // ride the next flush.
                if (NetworkManager.IsHost && _payloadScratch.Length >= MAX_DELTA_BYTES_PER_FLUSH)
                    break;

                // Cursor short-circuit: peer already has this revision,
                // no point re-shipping full state. Drop from pending so
                // we don't keep evaluating it on subsequent flushes.
                if (peerCursor != null
                    && peerCursor.TryGetValue(z.Id, out var seen)
                    && seen >= z.DataRevision)
                {
                    peerPending.Remove(z);
                    _stats_cursorSkip++;
                    continue;
                }

                uint revAtSerialise = z.DataRevision;
                z.Id.Write(_payloadScratch);
                _payloadScratch.Put((byte)z.ZdoTypeTag);
                _payloadScratch.Put(revAtSerialise);
                int keyCountOffset = _payloadScratch.Length;
                _payloadScratch.Put((ushort)0);
                _enumWriter = _payloadScratch;
                _enumZdo = z;
                _enumKeyCount = 0;
                z.EnumerateAllKeys(_enumVisitor);
                int keyCount = _enumKeyCount;
                var pData = _payloadScratch.Data;
                pData[keyCountOffset]     = (byte)(keyCount & 0xff);
                pData[keyCountOffset + 1] = (byte)((keyCount >> 8) & 0xff);
                _sentInThisPacketScratch.Add(z);
                peerPending.Remove(z);
                _serialisedThisBuild.Add((z, revAtSerialise));
                written++;
                _stats_pendingResent++;
            }
            _pendingDrainScratch.Clear();
        }

        // ── Pass 2: dirty deltas (per-key delta, cull-filtered) ─────────
        for (int i = 0; i < dirty.Count; i++)
        {
            var z = dirty[i];
            if (useDedup && _sentInThisPacketScratch.Contains(z)) continue;

            // Per-class split: only ZDOs matching this pass's delivery
            // class go on the wire here. The other class is handled by
            // the caller's second BuildPayloadFromDirty pass.
            if (GetDeliveryFor(z.ZdoTypeTag) != targetClass) continue;

            if (applyCull && z.HasHostPosition)
            {
                float dx = z.HostPosition.x - peerPos.x;
                float dz = z.HostPosition.z - peerPos.z;
                // Horizontal distance only — vertical (Y) varies a lot
                // inside multi-storey buildings but the peer can still
                // see the entity through floor transitions. Saves one
                // float multiply per check.
                if (dx * dx + dz * dz > CULL_RADIUS_M_SQ)
                {
                    _stats_culled++;
                    continue;
                }
            }

            // Cursor short-circuit: peer already has this revision.
            // Cheap defence against same-revision rebroadcasts (e.g.
            // ZDO marked dirty, flushed once, peer receives it, then
            // a *different* key on the same ZDO gets dirtied in the
            // next tick — without the cursor we'd re-ship the original
            // already-acknowledged keys too. Dirty key set is cleared
            // in ClearDirtyKeysOnSerialised so this is mostly a
            // belt-and-braces guard, but it costs almost nothing.)
            uint revAtSerialise = z.DataRevision;
            if (peerCursor != null
                && peerCursor.TryGetValue(z.Id, out var seenRev)
                && seenRev >= revAtSerialise)
            {
                _stats_cursorSkip++;
                continue;
            }

            // Budget gate (Valheim bounded-send pattern): this ZDO qualified
            // for the peer (class + cull + cursor passed), but the packet is
            // already at the per-flush budget. Don't serialise it — defer it
            // to the peer's pending-resend set, drained (full-state, Pass 1)
            // on the next flush. Nothing is lost; deferred ZDOs get priority
            // next tick since Pass 1 runs before Pass 2.
            //
            // Host-only: the joiner path has no pending-resend set to defer
            // into, and its dirty set is tiny (just its own LocalPlayer / held
            // items) so it never approaches the budget anyway. Gating on
            // IsHost guarantees the joiner never silently drops a delta.
            if (NetworkManager.IsHost && _payloadScratch.Length >= MAX_DELTA_BYTES_PER_FLUSH)
            {
                _budgetOverflowScratch.Add(z);
                continue;
            }

            z.Id.Write(_payloadScratch);
            _payloadScratch.Put((byte)z.ZdoTypeTag);
            _payloadScratch.Put(revAtSerialise);
            _payloadScratch.Put((ushort)z.DirtyKeys.Count);
            foreach (var dk in z.DirtyKeys)
            {
                _payloadScratch.Put(dk.Key);
                ZdoWire.WriteValue(_payloadScratch, (ZdoValueType)dk.Value, z, dk.Key);
            }
            _serialisedThisBuild.Add((z, revAtSerialise));
            written++;
            _stats_dirtyCount++;
        }

        // Patch the count back into the placeholder slot. NetDataWriter
        // exposes Data + Length; little-endian u16 in-place.
        var data = _payloadScratch.Data;
        data[countByteOffset]     = (byte)(written & 0xff);
        data[countByteOffset + 1] = (byte)((written >> 8) & 0xff);
        _lastSerialisedCount = written;
    }

    /// <summary>Walk the dirty scratch and clear dirty-key dictionaries on
    /// each ZDO. Done once per flush, AFTER all peer-specific builds (so
    /// each peer's <see cref="BuildPayloadFromDirty"/> still saw the same
    /// dirty key set).</summary>
    private static void ClearDirtyKeysOnSerialised()
    {
        for (int i = 0; i < _dirtyScratch.Count; i++)
        {
            _dirtyScratch[i].ClearDirty();
        }
    }

    private static void DrainOwnershipTransfers()
    {
        while (_pendingOwnershipBroadcast.Count > 0)
        {
            var (id, newOwner) = _pendingOwnershipBroadcast.Dequeue();
            _payloadScratch.Reset();
            id.Write(_payloadScratch);
            _payloadScratch.Put(newOwner);

            if (NetworkManager.IsHost)
            {
                // Per-peer instead of broadcast: this was the last send path
                // that bypassed the per-peer WorldReady gate. A still-loading
                // joiner would receive transfers for ZDOs it doesn't have yet
                // (harmless — the snapshot carries authoritative ownership),
                // but the invariant "nothing flows to a not-ready peer" is
                // worth keeping absolute: it's what makes the loading window
                // cheap on both ends and the gate easy to reason about.
                var clients = NetworkManager.Clients;
                for (int i = 0; i < clients.Count; i++)
                {
                    var peer = clients[i];
                    if (peer == null) continue;
                    int peerId = NetworkManager.GetPlayerIdByPeer(peer);
                    if (peerId < 0) continue;
                    if (NetworkManager.Players == null
                        || !NetworkManager.Players.TryGetValue(peerId, out var info)
                        || info == null
                        || !info.WorldReady)
                        continue;
                    WrapAndSendTo(peer, PacketType.ZdoOwnershipTransfer, _payloadScratch);
                }
            }
            else
            {
                // Joiner: single peer (the host), which is always world-ready.
                WrapAndSend(PacketType.ZdoOwnershipTransfer, _payloadScratch);
            }
        }
    }

    /// <summary>Apply incoming delta batch to the local registry.
    ///
    /// <para>If the local world isn't loaded yet (joiner is still on the
    /// SoD loading screen after auto-load triggered, but city generation
    /// hasn't completed), we still ingest the ZDO mutations into our
    /// in-memory registry but SKIP the live-side resolver apply. The
    /// resolvers walk SoD's runtime objects (Human, Interactable, etc.)
    /// which don't exist yet → would NRE on every delta and spam the log.
    /// Once <see cref="Sync.WorldReadyGate.IsWorldReady"/> flips true, the
    /// host's <see cref="PacketType.ClientWorldReady"/>-triggered snapshot
    /// re-delivers the same state and resolvers run cleanly.</para></summary>
    /// <summary>Throttle for authority-rejection warnings. Key is
    /// (senderUid, ownerUid); value is next-allowed-log-time. Bounded
    /// growth: a misbehaving peer × N owned ZDOs would otherwise flood
    /// the BepInEx log every flush tick.</summary>
    private static readonly Dictionary<(ulong sender, ulong owner), float> _authRejectLogThrottle = new();

    /// <summary>Resolve a peer's stable uid (matches the ZDO ownership space)
    /// from the player-id reported by the transport. Mirrors
    /// <see cref="EnsureLocalPeerUid"/> — both sides hash the same
    /// ClientGuid via FNV-1a-64.</summary>
    private static ulong ResolveSenderUid(int senderId)
    {
        // senderId == -1 means "unknown peer" (loopback / pre-handshake).
        // Treat as host-self so we don't reject deltas during init.
        if (senderId < 0) return LocalPeerUid;
        if (NetworkManager.Players != null
            && NetworkManager.Players.TryGetValue(senderId, out var info)
            && info != null
            && !string.IsNullOrEmpty(info.ClientGuid))
        {
            return Hash32.Of64(info.ClientGuid);
        }
        return 0ul;
    }

    public static void ApplyDeltaBatch(NetDataReader r, int senderId = -1)
    {
        try
        {
            // Unwrap header (compression, length).
            var unwrapped = UnwrapHeader(r);
            uint  tick    = unwrapped.GetUInt();
            ushort count  = unwrapped.GetUShort();

            bool worldReady = SoDCoop.Sync.WorldReadyGate.IsWorldReady;

            // Bug #1: host-side authority validation. If a delta arrives
            // from a peer for a ZDO whose OwnerPeer is someone else (and
            // not host-self), drop the delta — joiner is trying to mutate
            // someone else's Money / Case / Citizen state. Joiner-side
            // skips this gate (host is the only trust source).
            bool enforceAuthority = NetworkManager.IsHost;
            ulong senderUid = enforceAuthority ? ResolveSenderUid(senderId) : 0ul;

            for (int i = 0; i < count; i++)
            {
                ZDOID id = ZDOID.Read(unwrapped);
                ZdoTypeTag tag = (ZdoTypeTag)unwrapped.GetByte();
                uint dataRev = unwrapped.GetUInt();
                ushort kcount = unwrapped.GetUShort();

                Zdo z = Lookup(id);
                if (z == null)
                {
                    // First time this peer hears about the ZDO. Auto-create with
                    // unknown owner — owner will be set authoritatively by a
                    // ZdoOwnershipTransfer packet or by the next snapshot.
                    z = new Zdo(id, tag, owner: 0ul, persistent: true);
                    Register(z);
                    OnZdoCreated?.Invoke(z);
                }

                // Bug #1: gate write authority. Read keys to advance the
                // reader position regardless (so the rest of the batch
                // stays parseable), but discard them via a scratch ZDO if
                // the sender isn't authorised. Drop predicate:
                //   - host-self may always write
                //   - the recorded OwnerPeer may write
                //   - OwnerPeer == 0 means "no owner yet" (auto-created
                //     above, or never claimed) — accept and let the
                //     downstream OwnershipTransfer settle authority
                bool authorised = true;
                if (enforceAuthority
                    && z.OwnerPeer != 0ul
                    && senderUid != z.OwnerPeer
                    && senderUid != LocalPeerUid)
                {
                    authorised = false;
                    var key = (senderUid, z.OwnerPeer);
                    float now = Time.realtimeSinceStartup;
                    if (!_authRejectLogThrottle.TryGetValue(key, out var nextAt) || now >= nextAt)
                    {
                        _authRejectLogThrottle[key] = now + 5f;
                        Plugin.Log.LogWarning(
                            $"[ZdoMan] auth-reject delta sender={senderUid:X16} owner={z.OwnerPeer:X16} " +
                            $"id={id} tag={tag} (joiner attempted to mutate non-owned ZDO)");
                    }
                }

                for (int k = 0; k < kcount; k++)
                {
                    int keyHash = unwrapped.GetInt();
                    if (authorised)
                    {
                        ZdoWire.ReadValueInto(unwrapped, keyHash, z);
                    }
                    else
                    {
                        // Drain the value into a throwaway ZDO so the
                        // reader advances past it. Cheap — single Zdo
                        // alloc isn't worth scratch-pooling because the
                        // path is the auth-reject (rare) one.
                        var scratch = new Zdo(default, tag, 0ul, false);
                        ZdoWire.ReadValueInto(unwrapped, keyHash, scratch);
                    }
                }

                if (!authorised) continue; // skip apply / index for rejected delta

                // Dirty flag is set by the Set() calls above; clear it because
                // these mutations originated remote and shouldn't echo back.
                z.ClearDirty();
                _ = dataRev; // currently advisory; honoured via ClearDirty no-rebroadcast policy.

                // Refresh the (tag, sodId) lookup index — the delta may have
                // just brought in __sodId / __sodIdStr from the host. Cheap
                // dictionary upsert; idempotent if the index is already set.
                IndexSodId(z);

                // Translate ZDO state into live SoD-side mutations — only
                // when our world is loaded. While loading, swallow.
                if (worldReady)
                    Resolvers.ZdoResolverRegistry.Apply(z);
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] ApplyDeltaBatch failed: {ex.Message}");
        }
    }

    public static void ApplyOwnershipTransfer(NetDataReader r)
    {
        try
        {
            var unwrapped = UnwrapHeader(r);
            ZDOID id = ZDOID.Read(unwrapped);
            ulong newOwner = unwrapped.GetULong();
            var z = Lookup(id);
            if (z == null) return;
            ulong old = z.OwnerPeer;
            z.SetOwnerInternal(newOwner);
            OnOwnershipChanged?.Invoke(z, old, newOwner);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] ApplyOwnershipTransfer failed: {ex.Message}");
        }
    }

    // ── Snapshot ──────────────────────────────────────────────────────

    /// <summary>Build the full registry as a single payload. Includes both
    /// persistent and transient ZDOs (joiner needs the full visible state).</summary>
    public static byte[] SerializeAllForSnapshot()
    {
        _snapshotScratch.Reset();
        SerializeAll(_snapshotScratch, persistentOnly: false);
        return CopyBytes(_snapshotScratch);
    }

    /// <summary>Persistent-only snapshot for disk write.</summary>
    public static byte[] SerializeAllPersistent()
    {
        _snapshotScratch.Reset();
        SerializeAll(_snapshotScratch, persistentOnly: true);
        return CopyBytes(_snapshotScratch);
    }

    private static void SerializeAll(NetDataWriter w, bool persistentOnly)
    {
        w.Put(WIRE_VERSION);
        // Count placeholder — patch in after iteration.
        int countPos = w.Length;
        w.Put((uint)0);
        uint actual = 0;
        foreach (var kv in _byId)
        {
            var z = kv.Value;
            if (persistentOnly && !z.Persistent) continue;
            z.Id.Write(w);
            w.Put((byte)z.ZdoTypeTag);
            w.Put(z.OwnerPeer);
            w.Put(z.Persistent);
            w.Put(z.DataRevision);
            w.Put(z.SchemaVersion);
            // Key count placeholder.
            int keyCountPos = w.Length;
            w.Put((ushort)0);
            _enumWriter = w;
            _enumZdo = z;
            _enumKeyCount = 0;
            z.EnumerateAllKeys(_enumVisitor);
            ushort kc = (ushort)_enumKeyCount;
            // Patch key count.
            byte[] data = w.Data;
            data[keyCountPos    ] = (byte)(kc & 0xff);
            data[keyCountPos + 1] = (byte)((kc >> 8) & 0xff);
            actual++;
        }
        // Patch total count.
        byte[] dat = w.Data;
        dat[countPos    ] = (byte)(actual & 0xff);
        dat[countPos + 1] = (byte)((actual >>  8) & 0xff);
        dat[countPos + 2] = (byte)((actual >> 16) & 0xff);
        dat[countPos + 3] = (byte)((actual >> 24) & 0xff);
    }

    /// <summary>Restore the full registry from a snapshot payload.
    ///
    /// <para>Registry ingestion (key reads + indexing) stays synchronous —
    /// it's cheap dictionary work. The live-side resolver applies are NOT
    /// run inline: each restored ZDO is queued via
    /// <see cref="EnqueueResolverApply"/> and drained by
    /// <see cref="PumpPendingResolverApplies"/> at
    /// <see cref="RESOLVER_APPLIES_PER_FRAME"/> per frame, because running
    /// ~20 K resolvers inside this loop stalled the joiner 300+ ms right
    /// as they spawned into the world.</para></summary>
    public static void RestoreFromSnapshot(byte[] payload)
    {
        if (payload == null || payload.Length == 0) return;
        try
        {
            var r = new NetDataReader(payload);
            byte ver = r.GetByte();
            if (ver != WIRE_VERSION)
            {
                Plugin.Log.LogWarning($"[ZdoMan] snapshot wire version mismatch: {ver} vs {WIRE_VERSION}");
                return;
            }
            uint count = r.GetUInt();
            for (uint i = 0; i < count; i++)
            {
                ZDOID id = ZDOID.Read(r);
                ZdoTypeTag tag = (ZdoTypeTag)r.GetByte();
                ulong owner = r.GetULong();
                bool persistent = r.GetBool();
                uint dataRev = r.GetUInt();
                byte schemaVer = r.GetByte();
                ushort keyCount = r.GetUShort();

                Zdo z = Lookup(id);
                if (z == null)
                {
                    z = new Zdo(id, tag, owner, persistent) { SchemaVersion = schemaVer };
                    Register(z);
                    OnZdoCreated?.Invoke(z);
                }
                else
                {
                    z.SetOwnerInternal(owner);
                    z.SchemaVersion = schemaVer;
                }

                for (int k = 0; k < keyCount; k++)
                {
                    int keyHash = r.GetInt();
                    ZdoWire.ReadValueInto(r, keyHash, z);
                }
                z.ClearDirty();
                _ = dataRev;

                // Snapshot just brought __sodId / __sodIdStr into this ZDO —
                // refresh the (tag, sodId) lookup index so subsequent
                // GetOrCreateBySodId calls hit O(1) instead of falling back
                // to Create + duplicate.
                IndexSodId(z);

                // Queue the live SoD-side resolver apply — only when our
                // world is loaded. Snapshot is normally sent AFTER
                // ClientWorldReady fires (so this is true), but during
                // reconnect-snapshot or any racy path where snapshot lands
                // before SoD's CityData is up, we'd otherwise NRE inside
                // resolvers that walk Human/Interactable refs that don't
                // exist yet.
                //
                // The apply itself is amortized across frames by
                // PumpPendingResolverApplies — running ~20 K resolvers
                // inline in this loop was a 300+ ms joiner hitch. Safe:
                // resolvers read the ZDO's current registry state at apply
                // time, so a delta that applies inline before the queued
                // baseline apply runs is simply re-applied idempotently.
                if (SoDCoop.Sync.WorldReadyGate.IsWorldReady)
                    EnqueueResolverApply(z);
            }
            Plugin.Log.LogInfo($"[ZdoMan] restored {count} ZDOs from snapshot.");
            if (!NetworkManager.IsHost && SoDCoop.Sync.WorldReadyGate.IsWorldReady)
            {
                ClientSynced = true;
                // Covers the join that loaded nothing (Mode 2: already in this
                // city, possibly across town from the host) as well as the
                // loads, which also arm at WorldReady.
                SoDCoop.Sync.JoinSpawn.Arm("host world synced");
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] RestoreFromSnapshot failed: {ex}");
        }
    }

    // ── Wire framing (header + optional zstd) ────────────────────────
    //
    // Framing logic itself lives in ZdoWireFrame (extracted 2026-05-09 as
    // part of the SRP-driven ZdoMan split — framing has nothing to do with
    // the registry / dirty / flush / cull / persistence concerns crowded
    // into this file). The thin shims below stay here so existing private
    // call sites in ZdoMan don't need to plumb _wrapScratch + stats counter
    // updates through every send-site, and so the byte-count stats
    // (_stats_bytesSent / _stats_relBytes / _stats_seqBytes) stay owned by
    // ZdoMan rather than leaking into the framing utility.

    private static readonly NetDataWriter _wrapScratch = new();

    /// <summary>Per-peer counterpart to <see cref="WrapAndSend"/>. Shim
    /// around <see cref="ZdoWireFrame.WrapAndSendTo"/> that owns the
    /// shared scratch buffer and updates ZdoMan's per-channel byte
    /// counters from the returned wire length.</summary>
    private static void WrapAndSendTo(SoDCoop.Network.Steam.SteamPeer peer, PacketType pt, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        int sent = ZdoWireFrame.WrapAndSendTo(peer, pt, payload, delivery, _wrapScratch);
        _stats_bytesSent += sent;
        if (delivery == DeliveryMethod.Sequenced) _stats_seqBytes += sent;
        else                                      _stats_relBytes += sent;
    }

    /// <summary>All-peers broadcast. Shim around
    /// <see cref="ZdoWireFrame.WrapAndSend"/>; same rationale as
    /// <see cref="WrapAndSendTo"/> for keeping it here.</summary>
    private static void WrapAndSend(PacketType pt, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        // Bug #6: count bytes-on-wire (joiner-side broadcast also passes
        // through here for the legacy single-packet path).
        int sent = ZdoWireFrame.WrapAndSend(pt, payload, delivery, _wrapScratch);
        _stats_bytesSent += sent;
        if (delivery == DeliveryMethod.Sequenced) _stats_seqBytes += sent;
        else                                      _stats_relBytes += sent;
    }

    /// <summary>Backwards-compat shim — see
    /// <see cref="ZdoWireFrame.UnwrapHeader"/>.</summary>
    private static NetDataReader UnwrapHeader(NetDataReader r) => ZdoWireFrame.UnwrapHeader(r);

    private static byte[] CopyBytes(NetDataWriter w)
    {
        byte[] copy = new byte[w.Length];
        Array.Copy(w.Data, copy, w.Length);
        return copy;
    }

    // ── Persistence ──────────────────────────────────────────────────
    //
    // Disk I/O lives in ZdoPersistence (extracted 2026-05-09 — see the
    // class-doc on ZdoPersistence for the SRP rationale). The shims
    // below stay here so existing callers in Plugin.cs / SodCommonBridge.cs
    // keep compiling without a path replacement on every call site;
    // new code should call ZdoPersistence.* directly.

    /// <summary>Backwards-compat shim — see <see cref="ZdoPersistence.PersistencePath"/>.</summary>
    public static string PersistencePath() => ZdoPersistence.PersistencePath();

    /// <summary>Backwards-compat shim — see <see cref="ZdoPersistence.SaveToDisk"/>.</summary>
    public static void SaveToDisk() => ZdoPersistence.SaveToDisk();

    /// <summary>Backwards-compat shim — see <see cref="ZdoPersistence.LoadFromDisk"/>.</summary>
    public static void LoadFromDisk() => ZdoPersistence.LoadFromDisk();

    // ── Snapshot push (host → joiner) ─────────────────────────────────

    /// <summary>Queue entry for an in-flight chunked snapshot send.
    ///
    /// <para><b>Pipeline:</b> serialise once on the main thread (walks the
    /// live <c>_byId</c> registry, so it cannot move off-thread) → zstd the
    /// WHOLE payload on a thread-pool worker → chunk the resulting
    /// <b>compressed</b> buffer across frames at
    /// <see cref="MAX_CHUNK_BYTES_PER_FRAME"/> per frame.</para>
    ///
    /// <para><b>Why compress-then-chunk and not chunk-then-compress:</b> an
    /// earlier revision shipped the chunks RAW (per-chunk zstd was judged not
    /// worth the overhead, and the whole-payload compress was dropped along
    /// with it). That put 1.5 MB on the wire where the previous atomic path
    /// had put ~150 KB — a 10× bandwidth regression — while leaving the
    /// serialise stall it was meant to fix completely untouched, because
    /// serialise was always the expensive half and it still runs
    /// synchronously in <see cref="SendSnapshotTo"/>. Compressing the full
    /// payload once off-thread and chunking the compressed bytes keeps both
    /// wins: the 10× compression ratio AND bounded per-frame send cost.</para>
    ///
    /// <para>Reassembly on the receiver is driven by <b>bytes received</b>
    /// against the header's announced compressed length, not by counting
    /// chunks. Byte-driven completion is robust to a short final chunk and to
    /// the host changing its chunk size between builds, and it leaves no
    /// "completed" predicate latched true after a restore.</para></summary>
    private struct PendingSnapshotSend
    {
        public SteamPeer Peer;
        /// <summary>FULL uncompressed snapshot body (WIRE_VERSION + count +
        /// ZDO records). Retained only until <see cref="CompressTask"/>
        /// completes — the wire carries the compressed form.</summary>
        public byte[] Payload;
        public int    PayloadLen;
        /// <summary>Off-thread zstd of the whole <see cref="Payload"/>.
        /// <see cref="PumpPendingSnapshotSends"/> skips this entry until the
        /// Task completes, then chunks its result.</summary>
        public System.Threading.Tasks.Task<byte[]> CompressTask;
        /// <summary>Compressed payload, populated from
        /// <see cref="CompressTask"/> on the first frame after it finishes.
        /// This — not <see cref="Payload"/> — is what gets chunked.</summary>
        public byte[] Compressed;
        public int    CompressedLen;
        public int    ZdoCount;
        public ulong  PeerSteamId;
        public int    PeerId;
        public float  EnqueuedAt;
        /// <summary>Byte offset into <see cref="Compressed"/> of the next
        /// chunk to send. Advances only when the transport ACCEPTS the slice
        /// (see the backpressure note in <see cref="PumpPendingSnapshotSends"/>).</summary>
        public int    Cursor;
        /// <summary>Number of chunks actually shipped (header included).
        /// Diagnostics only.</summary>
        public int    ChunksSent;
        /// <summary>Total chunk count written into the header chunk, for
        /// receiver-side progress logging only.</summary>
        public ushort TotalChunks;
        /// <summary>True once the header chunk (chunk 0) has been ACCEPTED by
        /// the transport. A rejected header is retried next frame.</summary>
        public bool   HeaderSent;
        /// <summary>Wall-clock of the last frame on which the transport
        /// accepted at least one byte. Used to abort a transfer that is
        /// permanently wedged (peer gone / send buffer never drains) instead
        /// of retrying forever and pinning a multi-MB buffer.</summary>
        public float  LastProgressAt;
    }

    /// <summary>Abort a snapshot send that has made zero forward progress for
    /// this long. Generous: a saturated 2 MB Steam send buffer on a slow
    /// uplink can legitimately stall for several seconds mid-drain, and the
    /// joiner is on a loading screen anyway. Only a genuinely dead peer or a
    /// permanently full buffer should ever trip it.</summary>
    private const float SNAPSHOT_STALL_TIMEOUT_S = 30f;

    /// <summary>Per-host queue of pending chunked snapshot sends. Drained
    /// chunk-by-chunk once per frame from <see cref="PumpPendingSnapshotSends"/>.
    /// Typically holds 0–1 entries; only grows during concurrent joins.</summary>
    private static readonly List<PendingSnapshotSend> _pendingSnapshotSends = new();

    /// <summary>Max compressed bytes handed to the transport per frame per
    /// pending snapshot. At 16 KB/frame a ~200 KB compressed snapshot drains
    /// in ~13 frames (~0.2 s at 60 fps) and each frame's send cost is
    /// sub-millisecond. Deliberately well under the sustained throughput of a
    /// modest uplink so the Steam send buffer has room to drain between
    /// frames — see the backpressure note in
    /// <see cref="PumpPendingSnapshotSends"/>.</summary>
    private const int MAX_CHUNK_BYTES_PER_FRAME = 16 * 1024;

    /// <summary>Size of each slice cut out of the compressed payload and
    /// shipped as one ReliableOrdered packet. Small slices keep per-frame
    /// granularity fine and limit the retransmit unit on packet loss.</summary>
    private const int SNAPSHOT_CHUNK_SIZE = 16 * 1024;

    /// <summary>Dedicated wire-build buffer for the async snapshot emit path.
    /// Kept separate from <see cref="_payloadScratch"/> (the delta-flush
    /// scratch) so the snapshot-emit and delta-flush paths can never clobber
    /// each other's half-built packet, even if call ordering changes or a
    /// re-entrant send is introduced later.</summary>
    private static readonly NetDataWriter _snapshotEmitScratch = new();

    // ── Allocation-free EnumerateAllKeys visitor ────────────────────────────
    // Zdo.EnumerateAllKeys takes an Action<int,byte>. Previously each call site
    // passed a lambda capturing the loop's `z` + a local key-counter, which
    // allocates a fresh closure object PER ZDO PER FLUSH — hundreds per flush ×
    // 10 Hz = thousands of Gen0 allocations/second during normal play, a steady
    // GC-pressure source that shows up as periodic frame hitches. Hoisting the
    // per-call state to static fields + a single cached delegate removes the
    // allocation entirely. Safe because all three call sites (delta flush,
    // snapshot serialise, cursor-delta) run only on the Unity main thread and
    // never re-enter EnumerateAllKeys.
    private static NetDataWriter _enumWriter;
    private static Zdo _enumZdo;
    private static int _enumKeyCount;
    private static readonly System.Action<int, byte> _enumVisitor = EnumVisit;
    private static void EnumVisit(int kHash, byte vType)
    {
        _enumWriter.Put(kHash);
        ZdoWire.WriteValue(_enumWriter, (ZdoValueType)vType, _enumZdo, kHash);
        _enumKeyCount++;
    }

    /// <summary>Push a full ZDO snapshot to <paramref name="peer"/> as a
    /// stream of chunked <see cref="PacketType.ZdoSnapshot"/> packets.
    ///
    /// <para><b>Serialisation</b> walks the live <c>_byId</c> registry ONCE
    /// here (must run on the Unity main thread — no locks elsewhere — but
    /// happens a single time per joiner, not per chunk). The resulting
    /// payload (typically 1–2 MB uncompressed) is queued on
    /// <see cref="_pendingSnapshotSends"/> and drained chunk-by-chunk by
    /// <see cref="PumpPendingSnapshotSends"/> at
    /// <see cref="MAX_CHUNK_BYTES_PER_FRAME"/> per frame.</para>
    ///
    /// <para><b>Compression</b> (zstd-3, 1–2 MB → 100–200 KB) runs on a
    /// thread-pool worker via <see cref="ZdoCompression.CompressOffThread"/>,
    /// which allocates its own Compressor so the shared main-thread one is
    /// never touched concurrently. <see cref="SerializeAllForSnapshot"/>
    /// returns a fresh array, so the worker owns its input outright.</para>
    ///
    /// <para><b>Wire format</b> (reuses <see cref="PacketType.ZdoSnapshot"/>
    /// with a flags bit so the receiver needs no new dispatch branch). Every
    /// frame carries the standard envelope
    /// <c>flags(1) | unused(2) | uncompLen(4) | bodyLen(4) | body[bodyLen]</c>:
    /// <list type="bullet">
    ///   <item><description>Header chunk: flags=0x03 (compressed +
    ///   chunked-start). Body is a zstd-compressed
    ///   <c>uint totalZdoCount + uint totalUncompressedLen +
    ///   uint totalCompressedLen + ushort totalChunks</c>.</description></item>
    ///   <item><description>Data chunk: flags=0x02 (chunked-continue).
    ///   <c>uncompLen=0</c> is the "this is a data chunk" sentinel; body is a
    ///   raw slice of the <b>already-compressed</b> snapshot
    ///   stream.</description></item>
    /// </list>
    /// The receiver appends data-chunk bodies until it holds
    /// <c>totalCompressedLen</c> bytes, decompresses once to
    /// <c>totalUncompressedLen</c>, and runs the standard
    /// <see cref="RestoreFromSnapshot"/> path. Drops and retransmits are
    /// ReliableOrdered's job; send-buffer rejections are ours (see
    /// <see cref="PumpPendingSnapshotSends"/>).</para></summary>
    public static void SendSnapshotTo(SteamPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        // One chunked stream per peer at a time. The receiver has a SINGLE
        // reassembly buffer, so two concurrent streams to the same peer would
        // interleave their chunks on the wire and be spliced together into
        // garbage — reassembly would still "complete" on byte count and hand
        // RestoreFromSnapshot a corrupt payload. Reachable whenever
        // ClientWorldReady arrives twice: a live save-transfer re-sync, a
        // reconnect that races the first snapshot, or a client that re-arms its
        // WorldReady handler.
        for (int i = 0; i < _pendingSnapshotSends.Count; i++)
        {
            if (ReferenceEquals(_pendingSnapshotSends[i].Peer, peer))
            {
                Plugin.Log.LogWarning(
                    $"[ZdoMan] snapshot already in flight for {peer.SteamId.m_SteamID} " +
                    $"({_pendingSnapshotSends[i].Cursor}/{_pendingSnapshotSends[i].CompressedLen} B sent) — " +
                    "ignoring duplicate request rather than interleaving two streams.");
                return;
            }
        }

        try
        {
            // One-shot serialise on the main thread — this walks the live
            // registry so it cannot move off-thread. It is also the expensive
            // half (~50-150 ms on a 20 K ZDO city); compress and send are
            // both amortised away from this frame below.
            byte[] payload = SerializeAllForSnapshot();
            int payloadLen = payload.Length;
            int count = Count;
            int peerId = NetworkManager.GetPlayerIdByPeer(peer);

            var compressTask = System.Threading.Tasks.Task.Run(
                () => ZdoCompression.CompressOffThread(payload, payloadLen));

            _pendingSnapshotSends.Add(new PendingSnapshotSend
            {
                Peer           = peer,
                Payload        = payload,
                PayloadLen     = payloadLen,
                CompressTask   = compressTask,
                Compressed     = null,
                CompressedLen  = 0,
                ZdoCount       = count,
                PeerSteamId    = peer.SteamId.m_SteamID,
                PeerId         = peerId,
                EnqueuedAt     = Time.unscaledTime,
                Cursor         = 0,
                ChunksSent     = 0,
                TotalChunks    = 0,   // known once the compressed length is
                HeaderSent     = false,
                LastProgressAt = Time.unscaledTime,
            });
            Plugin.Log.LogInfo(
                $"[ZdoMan] snapshot enqueued for {peer.SteamId.m_SteamID}: " +
                $"{payloadLen} B uncompressed, {count} ZDOs — compressing off-thread, " +
                $"will drain at {MAX_CHUNK_BYTES_PER_FRAME} B/frame.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] SendSnapshotTo (enqueue): {ex.Message}");
        }
    }

    /// <summary>Drain pending chunked snapshot sends. Called once per frame
    /// from <c>CoopUpdateRunner.Update</c>. Each frame, for each pending
    /// snapshot, emits the header chunk (once) + as many data chunks as
    /// fit in <see cref="MAX_CHUNK_BYTES_PER_FRAME"/>. When the last data
    /// chunk ships, the entry is finalised (peer marked world-ready, cursor
    /// seeded) and removed from the queue. Safe to call when the queue is
    /// empty (early-returns).</summary>
    public static void PumpPendingSnapshotSends()
    {
        if (_pendingSnapshotSends.Count == 0) return;

        // Iterate front-to-back: snapshot send order matters (a peer that
        // joined first should get their snapshot first). RemoveAt(i) on a
        // forward walk is O(N) but N is typically 0–1.
        for (int i = _pendingSnapshotSends.Count - 1; i >= 0; i--)
        {
            var p = _pendingSnapshotSends[i];
            if (p.Peer == null) { _pendingSnapshotSends.RemoveAt(i); continue; }

            try
            {
                // ── Wait for the off-thread compress ─────────────────────
                if (p.Compressed == null)
                {
                    if (p.CompressTask == null)
                    {
                        Plugin.Log.LogWarning($"[ZdoMan] snapshot for {p.PeerSteamId} has no compress task — dropping.");
                        _pendingSnapshotSends.RemoveAt(i);
                        continue;
                    }
                    if (!p.CompressTask.IsCompleted) continue;   // still compressing; retry next frame

                    byte[] compressed;
                    try { compressed = p.CompressTask.Result; }
                    catch (Exception ex)
                    {
                        Plugin.Log.LogWarning($"[ZdoMan] snapshot compress task faulted for {p.PeerSteamId}: {ex.Message}");
                        _pendingSnapshotSends.RemoveAt(i);
                        continue;
                    }

                    p.Compressed    = compressed;
                    p.CompressedLen = compressed.Length;
                    // The uncompressed payload is no longer needed — the wire
                    // carries the compressed form. Release it so a queued
                    // snapshot doesn't pin two multi-MB buffers.
                    p.Payload = null;

                    int dataChunks = (p.CompressedLen + SNAPSHOT_CHUNK_SIZE - 1) / SNAPSHOT_CHUNK_SIZE;
                    p.TotalChunks    = (ushort)Math.Min(ushort.MaxValue, dataChunks + 1);
                    p.LastProgressAt = Time.unscaledTime;
                    _pendingSnapshotSends[i] = p;

                    Plugin.Log.LogInfo(
                        $"[ZdoMan] snapshot compressed for {p.PeerSteamId}: " +
                        $"{p.PayloadLen} → {p.CompressedLen} B " +
                        $"({(p.PayloadLen > 0 ? (100.0 * p.CompressedLen / p.PayloadLen) : 0):F1}%), " +
                        $"{p.TotalChunks} chunks.");
                }

                int sentThisFrame = 0;
                // Set false by the first rejected send this frame. A rejected
                // slice must be re-sent — NOT skipped — so we stop the drain
                // immediately and keep the cursor where it is.
                bool accepted = true;

                // ── Header chunk (chunk 0) ───────────────────────────────
                // Tiny: totalZdoCount + total uncompressed len + total
                // compressed len + chunk count, itself zstd-compressed.
                if (!p.HeaderSent)
                {
                    _innerHdrScratch.Reset();
                    _innerHdrScratch.Put((uint)p.ZdoCount);
                    _innerHdrScratch.Put((uint)p.PayloadLen);
                    _innerHdrScratch.Put((uint)p.CompressedLen);
                    _innerHdrScratch.Put(p.TotalChunks);
                    int hdrInnerLen = _innerHdrScratch.Length;
                    byte[] hdrCompressed = ZdoCompression.Compress(_innerHdrScratch.Data, hdrInnerLen);

                    _snapshotEmitScratch.Reset();
                    // flags: bit0=compressed, bit1=chunked-start
                    _snapshotEmitScratch.Put((byte)0x03);
                    _snapshotEmitScratch.Put((ushort)0); // unused (legacy field)
                    _snapshotEmitScratch.Put(hdrInnerLen);
                    _snapshotEmitScratch.Put(hdrCompressed.Length);
                    _snapshotEmitScratch.Put(hdrCompressed, 0, hdrCompressed.Length);

                    if (NetworkManager.SendTo(p.Peer, PacketType.ZdoSnapshot, _snapshotEmitScratch, DeliveryMethod.ReliableOrdered))
                    {
                        p.HeaderSent = true;
                        p.ChunksSent++;
                        sentThisFrame += hdrCompressed.Length;
                        p.LastProgressAt = Time.unscaledTime;
                    }
                    else
                    {
                        // Send buffer full / peer gone. Retry the header next
                        // frame — data chunks must never precede it.
                        accepted = false;
                    }
                }

                // ── Data chunks (slices of the COMPRESSED payload) ───────
                //
                // Backpressure: Steam rejects a send once the per-connection
                // send buffer is saturated and DROPS the message — there is no
                // transport-level retry. Advancing the cursor past a rejected
                // slice punches a permanent hole in the stream, so the
                // joiner's reassembly can never complete while the host has
                // already flipped WorldReady and started streaming deltas
                // against a base state the client never got. Hence: only
                // advance on an accepted send, and stop the drain for this
                // frame on the first rejection so the buffer can breathe.
                //
                // Adaptive budget: when the game itself is hitching (long
                // frames), lift the per-frame cap so the drain still finishes
                // in reasonable wall-clock time. Capped at 4× — with real
                // backpressure in place an over-eager burst is self-limiting,
                // but there's no point queueing work the buffer will reject.
                int adaptiveBudget = MAX_CHUNK_BYTES_PER_FRAME;
                float dt = UnityEngine.Time.unscaledDeltaTime;
                if (dt > 0.05f)
                {
                    float scale = UnityEngine.Mathf.Clamp(dt / 0.0166f, 1f, 4f);
                    adaptiveBudget = (int)(MAX_CHUNK_BYTES_PER_FRAME * scale);
                }

                while (accepted && p.Cursor < p.CompressedLen && sentThisFrame < adaptiveBudget)
                {
                    int remaining = p.CompressedLen - p.Cursor;
                    int chunkLen = Math.Min(SNAPSHOT_CHUNK_SIZE, remaining);

                    _snapshotEmitScratch.Reset();
                    // flags: bit1=chunked-continue only. uncompLen=0 is the
                    // "this is a data chunk" sentinel (a header always has
                    // uncompLen>0), and the body is a raw slice of the
                    // already-compressed stream — not separately compressed.
                    _snapshotEmitScratch.Put((byte)0x02);
                    _snapshotEmitScratch.Put((ushort)0); // unused
                    _snapshotEmitScratch.Put(0);
                    _snapshotEmitScratch.Put(chunkLen);
                    _snapshotEmitScratch.Put(p.Compressed, p.Cursor, chunkLen);

                    if (!NetworkManager.SendTo(p.Peer, PacketType.ZdoSnapshot, _snapshotEmitScratch, DeliveryMethod.ReliableOrdered))
                    {
                        accepted = false;
                        break;   // cursor deliberately NOT advanced
                    }

                    p.Cursor += chunkLen;
                    p.ChunksSent++;
                    sentThisFrame += chunkLen;
                    p.LastProgressAt = Time.unscaledTime;
                }

                // Persist the mutated cursor/header fields back into the list slot.
                _pendingSnapshotSends[i] = p;

                // ── Abort a permanently wedged transfer ──────────────────
                if (p.Cursor < p.CompressedLen
                    && Time.unscaledTime - p.LastProgressAt > SNAPSHOT_STALL_TIMEOUT_S)
                {
                    Plugin.Log.LogError(
                        $"[ZdoMan] snapshot to {p.PeerSteamId} STALLED at {p.Cursor}/{p.CompressedLen} B " +
                        $"for {SNAPSHOT_STALL_TIMEOUT_S:F0} s — aborting. Peer stays not-world-ready " +
                        "(no deltas will be sent to it); they must rejoin.");
                    _pendingSnapshotSends.RemoveAt(i);
                    continue;
                }

                // ── Finalise once the last byte is shipped ───────────────
                if (p.Cursor >= p.CompressedLen)
                {
                    _pendingSnapshotSends.RemoveAt(i);

                    // Enable live delta/event traffic to this peer. Ordering
                    // is guaranteed (snapshot chunks first via ReliableOrdered,
                    // then deltas — every per-peer send path gates on
                    // WorldReady, which we only flip here).
                    NetworkManager.MarkPeerWorldReady(p.PeerId);

                    float elapsedMs = (Time.unscaledTime - p.EnqueuedAt) * 1000f;
                    Plugin.Log.LogInfo(
                        $"[ZdoMan] chunked snapshot complete for {p.PeerSteamId}: " +
                        $"{p.PayloadLen} → {p.CompressedLen} B on the wire, {p.ZdoCount} ZDOs, " +
                        $"{p.ChunksSent} chunks, serialize+compress+drain={elapsedMs:F0} ms.");

                    // Seed the peer's per-peer DataRevision cursor with the
                    // current revision of every ZDO we just shipped. Without
                    // this, the first delta flush after the snapshot would
                    // re-include every dirty ZDO regardless of cursor.
                    if (p.PeerId >= 0
                        && NetworkManager.Players != null
                        && NetworkManager.Players.TryGetValue(p.PeerId, out var info)
                        && info != null)
                    {
                        if (info.LastSeenRev == null)
                            info.LastSeenRev = new Dictionary<ZDOID, uint>(_byId.Count);
                        info.LastSeenRev.Clear();
                        foreach (var kv in _byId)
                            info.LastSeenRev[kv.Key] = kv.Value.DataRevision;
                    }
                }
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[ZdoMan] PumpPendingSnapshotSends emit: {ex.Message}");
                // Drop the snapshot on error — re-enqueuing risks a tight
                // failure loop. The joiner will see no WorldReady flip and
                // eventually time out; operator can investigate via the log.
                _pendingSnapshotSends.RemoveAt(i);
            }
        }
    }

    /// <summary>Scratch for the header chunk's tiny inner body
    /// (totalZdoCount + totalUncompressedLen + totalCompressedLen +
    /// totalChunks). Kept separate from
    /// <see cref="_snapshotEmitScratch"/> so we can compress the inner
    /// body before writing it into the emit scratch without aliasing.</summary>
    private static readonly NetDataWriter _innerHdrScratch = new();

    /// <summary>Resume-from-cursor variant of <see cref="SendSnapshotTo"/>.
    /// Walks the registry and ships full state for every ZDO whose
    /// <see cref="Zdo.DataRevision"/> exceeds the peer's last-seen
    /// revision (Valheim ZDOMan resume pattern). Used on reconnect-
    /// during-grace where the peer already has most of the world and
    /// we just need to deliver the deltas they missed during the
    /// disconnected window. The wire format reuses
    /// <see cref="PacketType.ZdoDeltaBatch"/> with full-state entries
    /// (every key serialised, like Pass 1 catch-up resend) so the
    /// receiver doesn't need a new opcode — same apply path as
    /// <see cref="ApplyDeltaBatch"/>.
    ///
    /// <para>Returns true if a delta packet was sent (peer's view was
    /// behind), false if the peer was already up-to-date (no packet
    /// needed). Caller can fall back to <see cref="SendSnapshotTo"/>
    /// if the peer's cursor is empty / null — that path is the
    /// initial-join fall-through.</para></summary>
    public static bool SendDeltaSinceCursorTo(SteamPeer peer)
    {
        if (peer == null) return false;
        if (!NetworkManager.IsHost) return false;

        int peerId = NetworkManager.GetPlayerIdByPeer(peer);
        if (peerId < 0) return false;
        if (NetworkManager.Players == null
            || !NetworkManager.Players.TryGetValue(peerId, out var info)
            || info == null
            || info.LastSeenRev == null
            || info.LastSeenRev.Count == 0)
        {
            return false; // No cursor — caller should snapshot instead.
        }

        var cursor = info.LastSeenRev;

        try
        {
            _payloadScratch.Reset();
            _payloadScratch.Put(_flushTickCounter);
            int countByteOffset = _payloadScratch.Length;
            _payloadScratch.Put((ushort)0);

            int written = 0;
            int skipped = 0;
            _serialisedThisBuild.Clear();

            // Walk registry: ship full state for every ZDO whose revision
            // moved past the cursor (or was never seen). Two equivalent
            // ways to read this: "deltas during the disconnect window" or
            // "everything the peer doesn't already have". Both are correct.
            foreach (var kv in _byId)
            {
                var z = kv.Value;
                uint rev = z.DataRevision;
                if (cursor.TryGetValue(z.Id, out var seen) && seen >= rev)
                {
                    skipped++;
                    continue;
                }

                z.Id.Write(_payloadScratch);
                _payloadScratch.Put((byte)z.ZdoTypeTag);
                _payloadScratch.Put(rev);
                int keyCountOffset = _payloadScratch.Length;
                _payloadScratch.Put((ushort)0);
                _enumWriter = _payloadScratch;
                _enumZdo = z;
                _enumKeyCount = 0;
                z.EnumerateAllKeys(_enumVisitor);
                int keyCount = _enumKeyCount;
                var pData = _payloadScratch.Data;
                pData[keyCountOffset]     = (byte)(keyCount & 0xff);
                pData[keyCountOffset + 1] = (byte)((keyCount >> 8) & 0xff);

                _serialisedThisBuild.Add((z, rev));
                written++;
            }

            var data = _payloadScratch.Data;
            data[countByteOffset]     = (byte)(written & 0xff);
            data[countByteOffset + 1] = (byte)((written >> 8) & 0xff);

            if (written == 0)
            {
                Plugin.Log.LogInfo($"[ZdoMan] cursor-delta to {peer.SteamId.m_SteamID}: peer up-to-date ({skipped} ZDOs skipped, no packet sent)");
                return true; // peer is up-to-date — still counts as "handled"
            }

            WrapAndSendTo(peer, PacketType.ZdoDeltaBatch, _payloadScratch);

            // Stamp the cursor with everything we just shipped — same
            // optimistic-update pattern as the per-tick flush path.
            for (int si = 0; si < _serialisedThisBuild.Count; si++)
            {
                var (sz, srev) = _serialisedThisBuild[si];
                cursor[sz.Id] = srev;
            }

            Plugin.Log.LogInfo($"[ZdoMan] cursor-delta to {peer.SteamId.m_SteamID}: sent {written} ZDOs (skipped {skipped} unchanged)");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] SendDeltaSinceCursorTo: {ex.Message}");
            return false;
        }
    }

    public static void HandleSnapshot(NetDataReader r)
    {
        try
        {
            byte flags = r.GetByte();
            ushort _ = r.GetUShort(); // unused (legacy field)
            int uncompressedLen = r.GetInt();
            int compressedLen = r.GetInt();

            // Bounds-check the announced body against what's actually on the
            // wire before allocating/copying — corrupt/truncated frames must
            // not read past the reader's logical end (LiteNetLib reuses
            // oversized receive buffers).
            if (compressedLen < 0 || compressedLen > r.AvailableBytes)
            {
                Plugin.Log.LogWarning($"[ZdoMan] snapshot frame bad length: compLen={compressedLen} available={r.AvailableBytes} flags={flags:X2}");
                return;
            }

            // ── Chunked snapshot stream ───────────────────────────────────
            // bit1 (0x02) = chunked. The header chunk also has bit0 (0x01,
            // compressed) and carries totalZdoCount + totalChunks. Data
            // chunks are bit1 only (0x02, UNcompressed) with uncompLen=0 as
            // the "this is a data chunk" sentinel; the receiver appends
            // their raw body to the reassembly buffer and, once the
            // announced total ZDO payload is complete, restores.
            if ((flags & 0x02) != 0)
            {
                HandleChunkedSnapshot(flags, uncompressedLen, compressedLen, r);
                return;
            }

            // ── Legacy atomic snapshot (forward-compat with older host) ───
            // Single compressed-or-raw body → restore immediately.
            byte[] body = new byte[compressedLen];
            Buffer.BlockCopy(r.RawData, r.Position, body, 0, compressedLen);
            r.SkipBytes(compressedLen);

            byte[] payload = (flags & 0x01) != 0
                ? ZdoCompression.Decompress(body, uncompressedLen)
                : body;

            RestoreFromSnapshot(payload);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] HandleSnapshot failed: {ex}");
        }
    }

    // ── Chunked snapshot reassembly state (client side) ───────────────────
    // Single in-flight reassembly at a time — the host sends a snapshot to
    // one peer at a time and the client only ever receives from one host.
    // If a new header chunk arrives mid-reassembly (host triggered a fresh
    // snapshot, e.g. reconnect during a partial stream), the old buffer is
    // discarded and reassembly restarts. Single-threaded (Unity main).
    private static System.IO.MemoryStream _chunkStream;
    private static uint _chunkExpectedZdos;
    private static ushort _chunkExpectedChunks;
    private static int _chunkReceivedChunks;
    private static float _chunkStartedAt;
    /// <summary>Total bytes of COMPRESSED payload the header announced. The
    /// completion test is <c>_chunkStream.Length &gt;= this</c>. Byte-driven
    /// rather than chunk-count-driven: robust to a short final chunk and to
    /// the host changing its chunk size, and — unlike a count comparison —
    /// it cannot stay latched true after a restore. 0 = no active
    /// reassembly.</summary>
    private static int _chunkExpectedCompressedLen;
    /// <summary>Uncompressed length the header announced, handed to zstd as
    /// the output size when the stream is complete.</summary>
    private static int _chunkExpectedUncompressedLen;

    /// <summary>Sanity cap on an announced snapshot size. A real 20 K ZDO city
    /// serialises to 1–2 MB and compresses to 100–200 KB, so 64 MB is orders
    /// of magnitude of headroom while still refusing a corrupt or hostile
    /// header that would otherwise have us grow a MemoryStream until the
    /// process dies.</summary>
    private const int MAX_SNAPSHOT_COMPRESSED_BYTES = 64 * 1024 * 1024;

    /// <summary>Drop any in-flight chunked-snapshot reassembly. Called on
    /// completion, on a fresh header, and from <see cref="Clear"/> so a
    /// partial stream never survives into the next session.</summary>
    private static void ResetChunkReassembly()
    {
        _chunkStream?.SetLength(0);
        _chunkExpectedZdos = 0;
        _chunkExpectedChunks = 0;
        _chunkReceivedChunks = 0;
        _chunkExpectedCompressedLen = 0;
        _chunkExpectedUncompressedLen = 0;
    }

    private static void HandleChunkedSnapshot(byte flags, int uncompressedLen, int compressedLen, NetDataReader r)
    {
        // Header chunk: flags == 0x03 (compressed + chunked-start). Its inner
        // body is (uint totalZdoCount + uint totalUncompressedLen +
        // uint totalCompressedLen + ushort totalChunks), itself zstd-compressed.
        if (flags == 0x03)
        {
            byte[] body = new byte[compressedLen];
            Buffer.BlockCopy(r.RawData, r.Position, body, 0, compressedLen);
            r.SkipBytes(compressedLen);

            byte[] hdr = ZdoCompression.Decompress(body, uncompressedLen);
            var hr = new NetDataReader(hdr);
            uint totalZdos     = hr.GetUInt();
            uint totalUncomp   = hr.GetUInt();
            uint totalComp     = hr.GetUInt();
            ushort totalChunks = hr.GetUShort();

            if (totalComp == 0 || totalComp > MAX_SNAPSHOT_COMPRESSED_BYTES
                || totalUncomp == 0 || totalUncomp > MAX_SNAPSHOT_COMPRESSED_BYTES)
            {
                Plugin.Log.LogError(
                    $"[ZdoMan] chunked snapshot header rejected: implausible lengths " +
                    $"(uncomp={totalUncomp} comp={totalComp}, cap={MAX_SNAPSHOT_COMPRESSED_BYTES}). " +
                    "Reassembly not started.");
                ResetChunkReassembly();
                return;
            }

            if (_chunkExpectedCompressedLen > 0)
            {
                Plugin.Log.LogWarning(
                    $"[ZdoMan] new snapshot header while previous reassembly incomplete " +
                    $"({_chunkStream?.Length ?? 0}/{_chunkExpectedCompressedLen} B) — discarding partial buffer.");
            }

            // (Re)initialise the reassembly buffer. Reusing the MemoryStream
            // instance keeps its already-grown capacity across joins, avoiding
            // a fresh multi-hundred-KB allocation each time.
            if (_chunkStream == null) _chunkStream = new System.IO.MemoryStream();
            else _chunkStream.SetLength(0);

            _chunkExpectedZdos            = totalZdos;
            _chunkExpectedChunks          = totalChunks;
            _chunkExpectedCompressedLen   = (int)totalComp;
            _chunkExpectedUncompressedLen = (int)totalUncomp;
            _chunkReceivedChunks          = 1;
            _chunkStartedAt               = Time.unscaledTime;
            Plugin.Log.LogInfo(
                $"[ZdoMan] chunked snapshot header: {totalZdos} ZDOs, {totalChunks} chunks, " +
                $"{totalComp} B compressed → {totalUncomp} B — buffering.");
            return;
        }

        // Data chunk: flags == 0x02, uncompLen=0 sentinel, raw slice of the
        // compressed stream.
        if (_chunkStream == null || _chunkExpectedCompressedLen <= 0)
        {
            // Data chunk with no active reassembly — a stale chunk from an
            // aborted stream, or a header we rejected/never saw. Drop it. The
            // host's WorldReady flip is what makes a genuinely lost header
            // visible: the join stalls and the stall timeout logs loudly.
            Plugin.Log.LogWarning("[ZdoMan] chunked data chunk with no active reassembly — dropping.");
            r.SkipBytes(compressedLen);
            return;
        }

        // Refuse to buffer past the announced total. Without this a host that
        // under-reports its length (corrupt header, version skew, hostile
        // peer) could grow this stream without bound.
        if (_chunkStream.Length + compressedLen > _chunkExpectedCompressedLen)
        {
            Plugin.Log.LogError(
                $"[ZdoMan] chunked snapshot overrun: have {_chunkStream.Length} B + {compressedLen} B " +
                $"exceeds announced {_chunkExpectedCompressedLen} B — aborting reassembly.");
            r.SkipBytes(compressedLen);
            ResetChunkReassembly();
            return;
        }

        // Append the slice. Write() handles capacity growth; writing into
        // GetBuffer() directly would risk IndexOutOfRange once Length +
        // chunkLen passes the internal buffer's capacity.
        _chunkStream.Write(r.RawData, r.Position, compressedLen);
        r.SkipBytes(compressedLen);
        _chunkReceivedChunks++;

        if (_chunkStream.Length < _chunkExpectedCompressedLen) return;   // more to come

        {
            byte[] compressedPayload = _chunkStream.ToArray();
            int zdos = (int)_chunkExpectedZdos;
            int expectUncomp = _chunkExpectedUncompressedLen;
            int chunks = _chunkReceivedChunks;
            float elapsedMs = (Time.unscaledTime - _chunkStartedAt) * 1000f;

            // Clear reassembly state BEFORE restoring: RestoreFromSnapshot is
            // a long call that can log/throw, and leaving the completion
            // predicate satisfied would let a stray follow-up chunk trigger a
            // second restore on a fragment.
            ResetChunkReassembly();

            byte[] payload;
            try
            {
                payload = ZdoCompression.Decompress(compressedPayload, expectUncomp);
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError(
                    $"[ZdoMan] chunked snapshot decompress failed ({compressedPayload.Length} B → " +
                    $"expected {expectUncomp} B): {ex.Message} — snapshot discarded, peer must rejoin.");
                return;
            }

            Plugin.Log.LogInfo(
                $"[ZdoMan] chunked snapshot reassembled: {compressedPayload.Length} → {payload.Length} B, " +
                $"{zdos} ZDOs, {chunks} chunks, {elapsedMs:F0} ms — restoring.");

            try { RestoreFromSnapshot(payload); }
            catch (Exception ex) { Plugin.Log.LogError($"[ZdoMan] chunked RestoreFromSnapshot failed: {ex}"); }
        }
    }
}
