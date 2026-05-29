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
    public const float DEFAULT_FLUSH_HZ = 10f;
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
        _spatialZdos.Add(z);
    }

    /// <summary>Subset of <see cref="_byId"/> that has a known host
    /// position — i.e. that participates in sector culling. Maintained
    /// by <see cref="NotifyZdoPosition"/>. The catch-up path walks this
    /// instead of the full registry (~19 K) which would be O(N) per
    /// peer movement; typical city has ~2 K spatial ZDOs (Citizens +
    /// Lights + Doors + Switches + Computers).</summary>
    private static readonly HashSet<Zdo> _spatialZdos = new();

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
    private const float CATCHUP_REEVAL_M_SQ = CATCHUP_REEVAL_M * CATCHUP_REEVAL_M;

    /// <summary>Called from <c>PlayerSync.OnRemotePlayerPosition</c> when a
    /// peer's broadcast position arrives. Detects "peer moved into a new
    /// sector" and queues full-state resend for newly-visible ZDOs so the
    /// peer doesn't see stale state for entities they walked into.
    ///
    /// <para>For dynamic-position ZDOs (Citizens) catch-up isn't strictly
    /// required: their CitizenStatePoller stamps a fresh position every
    /// tick, which marks the Pos key dirty whenever they move enough,
    /// which the per-peer flush ships if they're now in range. The static-
    /// position ZDOs (doors, lights, switches) are the ones that need
    /// help — their state writes happen on interaction, not per tick, so
    /// there's no natural "re-emit" loop for a peer entering their
    /// vicinity.</para></summary>
    public static void EvaluatePeerCatchup(int peerId, UnityEngine.Vector3 newPeerPos)
    {
        if (!NetworkManager.IsHost) return;
        if (!NetworkManager.Players.TryGetValue(peerId, out var info) || info == null) return;

        // Debounce: skip the diff if peer hasn't moved far enough to
        // possibly cross a cull boundary.
        if (info.HasCatchupBaseline)
        {
            float ddx = newPeerPos.x - info.LastCatchupPos.x;
            float ddz = newPeerPos.z - info.LastCatchupPos.z;
            if (ddx * ddx + ddz * ddz < CATCHUP_REEVAL_M_SQ) return;
        }
        info.LastCatchupPos = newPeerPos;
        info.HasCatchupBaseline = true;

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

        // Walk the spatial subset, recompute the new in-range set, queue
        // the diff (newly-entered) for resend.
        // Bug #2: build into shared scratch, then promote to peer's slot
        // by swapping (the previous in-range set is dropped — its memory
        // becomes the new scratch). Avoids one HashSet allocation per
        // position-change-debounced eval.
        _newInRangeScratch.Clear();
        foreach (var z in _spatialZdos)
        {
            if (!z.HasHostPosition) continue;
            float dx = z.HostPosition.x - newPeerPos.x;
            float dz = z.HostPosition.z - newPeerPos.z;
            if (dx * dx + dz * dz > CULL_RADIUS_M_SQ) continue;
            _newInRangeScratch.Add(z);
            if (!prevInRange.Contains(z)) pending.Add(z);
        }
        // Move scratch contents into peer's persistent slot. Reuse prevInRange
        // as the new container (it's already allocated) instead of
        // allocating a new HashSet — copy from scratch into it.
        prevInRange.Clear();
        foreach (var z in _newInRangeScratch) prevInRange.Add(z);
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
    private static readonly HashSet<Zdo> _newInRangeScratch = new();
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

    public static void Clear()
    {
        _byId.Clear();
        _byType.Clear();
        _bySodIdInt.Clear();
        _bySodIdStr.Clear();
        _dirty.Clear();
        _spatialZdos.Clear();
        _inRangeForPeer.Clear();
        _pendingResendForPeer.Clear();
        _pendingOwnershipBroadcast.Clear();
        // Session-scoped state that previously leaked across host/menu/host
        // cycles: the auth-reject log throttle grew unbounded under a
        // misbehaving/version-mismatched peer, and a stale pending snapshot
        // entry (peer dropped mid-join while its compress Task was in flight)
        // would fire one bogus send next session. Clear both on world-unready.
        _authRejectLogThrottle.Clear();
        _pendingSnapshotSends.Clear();
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

    /// <summary>
    /// Walk every ZDO currently in the registry and apply it via the
    /// resolver pipeline. Used by joiner-side post-load to catch up on
    /// state that streamed in while SoD's city was still generating
    /// (resolvers were skipped at that time to avoid NREs against
    /// not-yet-existing Human / Interactable refs).
    /// </summary>
    public static void ApplyAllToLiveWorld()
    {
        try
        {
            int n = 0, errors = 0;
            foreach (var z in _byId.Values)
            {
                try { Resolvers.ZdoResolverRegistry.Apply(z); n++; }
                catch (Exception ex)
                {
                    errors++;
                    if (errors <= 5)
                        Plugin.Log.LogWarning($"[ZdoMan] catch-up apply failed for {z.Id} ({z.ZdoTypeTag}): {ex.Message}");
                }
            }
            Plugin.Log.LogInfo($"[ZdoMan] catch-up apply: {n} ZDOs ({errors} errors).");
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
        // a future EvaluatePeerCatchup walk would deref a freed ZDO.
        _spatialZdos.Remove(z);
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
        _nextFlushAt = now + interval;
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
                    $"peers={NetworkManager.Clients.Count}");
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
        // Sequenced — idempotent overwrite state. Loss of a single packet is
        // recovered by the next 10 Hz flush; receiver always has a valid
        // (possibly stale) version.
        ZdoTypeTag.Citizen        => DeliveryMethod.Sequenced,
        ZdoTypeTag.PlayerTwin     => DeliveryMethod.Sequenced,
        ZdoTypeTag.LocalPlayer    => DeliveryMethod.Sequenced,
        ZdoTypeTag.Footprint      => DeliveryMethod.Sequenced,
        ZdoTypeTag.Fingerprint    => DeliveryMethod.Sequenced,
        ZdoTypeTag.Spatter        => DeliveryMethod.Sequenced,
        ZdoTypeTag.Weather        => DeliveryMethod.Sequenced,

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
            WrapAndSend(PacketType.ZdoOwnershipTransfer, _payloadScratch);
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

                // Translate ZDO state into live SoD-side mutations — only
                // when our world is loaded. Snapshot is normally sent AFTER
                // ClientWorldReady fires (so this is true), but during
                // reconnect-snapshot or any racy path where snapshot lands
                // before SoD's CityData is up, we'd otherwise NRE inside
                // resolvers that walk Human/Interactable refs that don't
                // exist yet.
                if (SoDCoop.Sync.WorldReadyGate.IsWorldReady)
                    Resolvers.ZdoResolverRegistry.Apply(z);
            }
            Plugin.Log.LogInfo($"[ZdoMan] restored {count} ZDOs from snapshot.");
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

    /// <summary>Queue entry for an in-flight async snapshot send.
    /// Serialisation runs on the main thread (touches the live ZDO
    /// registry); compression runs on a thread-pool worker; transmission
    /// happens on a later main-thread frame once the compress Task
    /// completes (drained from <see cref="PumpPendingSnapshotSends"/>).</summary>
    private struct PendingSnapshotSend
    {
        public SteamPeer Peer;
        public System.Threading.Tasks.Task<byte[]> CompressTask;
        public byte[] Payload;       // uncompressed body (kept alive for length + fallback only)
        public int    PayloadLen;
        public int    ZdoCount;
        public ulong  PeerSteamId;
        public int    PeerId;
        public float  EnqueuedAt;
    }

    /// <summary>Per-host queue of pending async snapshot sends. Drained
    /// once per frame from <see cref="PumpPendingSnapshotSends"/>.
    /// Typically holds 0–1 entries; only grows during concurrent joins.</summary>
    private static readonly List<PendingSnapshotSend> _pendingSnapshotSends = new();

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

    /// <summary>Push a full ZDO snapshot to <paramref name="peer"/>.
    ///
    /// <para>Serialisation walks the live <c>_byId</c> registry and so must
    /// run on the Unity main thread (no locks elsewhere — see class
    /// summary). It costs ~50–150 ms on a typical 5-20K ZDO city: a
    /// single-frame stall but not catastrophic.</para>
    ///
    /// <para><b>Compression</b> (zstd, level 3, 1–2 MB → 100–200 KB) used
    /// to run on the same frame and **doubled** that stall. It is now
    /// dispatched to the .NET thread pool via
    /// <see cref="ZdoCompression.CompressOffThread"/>, and the actual
    /// network send is deferred to the next frame on which the compress
    /// Task has completed. Drained by <see cref="PumpPendingSnapshotSends"/>
    /// from <c>CoopUpdateRunner.Update</c>.</para>
    ///
    /// <para>Result for the joiner: host's per-frame stall is roughly
    /// halved at the cost of one extra frame of latency on the snapshot,
    /// which the joiner can't see anyway (they're on a loading screen).
    /// </para></summary>
    public static void SendSnapshotTo(SteamPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;
        try
        {
            // Main-thread step: serialise the live registry. This must
            // happen synchronously here; mutating ZDOs from a worker
            // thread would race with the main-thread flush loop.
            byte[] payload = SerializeAllForSnapshot();
            int payloadLen = payload.Length;
            int count = Count;
            int peerId = NetworkManager.GetPlayerIdByPeer(peer);

            // Off-thread step: zstd-compress the serialised payload.
            // CompressOffThread allocates its own Compressor so the
            // shared one in ZdoCompression isn't touched concurrently.
            var compressTask = System.Threading.Tasks.Task.Run(
                () => ZdoCompression.CompressOffThread(payload, payloadLen));

            _pendingSnapshotSends.Add(new PendingSnapshotSend
            {
                Peer          = peer,
                CompressTask  = compressTask,
                Payload       = payload,
                PayloadLen    = payloadLen,
                ZdoCount      = count,
                PeerSteamId   = peer.SteamId.m_SteamID,
                PeerId        = peerId,
                EnqueuedAt    = Time.unscaledTime,
            });
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] SendSnapshotTo (enqueue): {ex.Message}");
        }
    }

    /// <summary>Drain completed async snapshot compress tasks and emit
    /// the wire packets. Called once per frame from
    /// <c>CoopUpdateRunner.Update</c>. Safe to call when the queue is
    /// empty (early-returns).</summary>
    public static void PumpPendingSnapshotSends()
    {
        if (_pendingSnapshotSends.Count == 0) return;

        for (int i = _pendingSnapshotSends.Count - 1; i >= 0; i--)
        {
            var p = _pendingSnapshotSends[i];

            // Skip until the worker thread has finished compressing.
            if (!p.CompressTask.IsCompleted) continue;

            _pendingSnapshotSends.RemoveAt(i);

            byte[] compressed;
            try
            {
                compressed = p.CompressTask.Result;
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[ZdoMan] async compress task faulted for {p.PeerSteamId}: {ex.Message}");
                continue;
            }

            try
            {
                _snapshotEmitScratch.Reset();
                byte flags = 0x01; // compressed
                _snapshotEmitScratch.Put(flags);
                _snapshotEmitScratch.Put((ushort)0); // uncompressedLen unused for snapshot
                _snapshotEmitScratch.Put(p.PayloadLen);
                _snapshotEmitScratch.Put(compressed.Length);
                _snapshotEmitScratch.Put(compressed, 0, compressed.Length);

                NetworkManager.SendTo(p.Peer, PacketType.ZdoSnapshot, _snapshotEmitScratch, DeliveryMethod.ReliableOrdered);

                // The snapshot is now on the wire. Enable live delta/event
                // traffic to this peer — ordering is guaranteed (snapshot
                // first, then deltas) because every per-peer send path gates
                // on WorldReady, which we only flip here, post-send.
                NetworkManager.MarkPeerWorldReady(p.PeerId);

                float elapsedMs = (Time.unscaledTime - p.EnqueuedAt) * 1000f;
                Plugin.Log.LogInfo(
                    $"[ZdoMan] async snapshot sent to {p.PeerSteamId}: " +
                    $"{p.PayloadLen} → {compressed.Length} B, {p.ZdoCount} ZDOs, " +
                    $"compress+wait={elapsedMs:F0} ms.");

                // Seed the peer's per-peer DataRevision cursor with the
                // current revision of every ZDO we just shipped. Without
                // this, the first delta flush after the snapshot would
                // re-include every dirty ZDO regardless of cursor — and
                // any future reconnect-grace path would have an empty
                // cursor, defeating the gap-fill optimisation.
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
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[ZdoMan] PumpPendingSnapshotSends emit: {ex.Message}");
            }
        }
    }

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
            ushort _ = r.GetUShort(); // unused
            int uncompressedLen = r.GetInt();
            int compressedLen = r.GetInt();
            // Bug #4: bulk-copy compressed body in one memcpy.
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
}
