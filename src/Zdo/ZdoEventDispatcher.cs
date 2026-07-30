using System;
using System.Collections.Generic;
using LiteNetLib;
using SoDCoop.Network.Steam;
using LiteNetLib.Utils;
using SoDCoop.Network;

namespace SoDCoop.Zdo;

/// <summary>
/// Name-keyed registry for fire-and-forget RPC events (chat, banners, pings,
/// side-job accept/handin). The transport replaces ~30 hand-written event
/// packets with a single <c>ZdoEventRpc</c> packet whose body is
/// <c>nameHash + payload</c>.
///
/// <para>Adding a new event = one <see cref="Register"/> call at init plus a
/// matching <see cref="Send"/> call site. No new packet enum entry, no
/// dispatcher branch.</para>
/// </summary>
public static class ZdoEventDispatcher
{
    public delegate void Handler(NetDataReader payload, int senderId);

    private static readonly Dictionary<int, (string name, Handler handler)> _byNameHash = new();

    public static void Register(string name, Handler handler)
    {
        int h = Hash32.Of(name);
        if (_byNameHash.TryGetValue(h, out var existing))
        {
            // Allow rebind during hot-reload-style scenarios (rare in our model).
            _byNameHash[h] = (name, handler);
            return;
        }
        _byNameHash[h] = (name, handler);
    }

    public static void Unregister(string name) => _byNameHash.Remove(Hash32.Of(name));

    /// <summary>Wire frame: <c>byte flags + int innerLen + int payloadLen + payload[payloadLen]</c>.
    /// Flags bit 0 = compressed (zstd-3). Inner payload starts with <c>int nameHash</c>
    /// followed by user payload bytes. Phase G.5 wire-tuning: payloads ≥100 B
    /// are zstd-compressed (matches BetterNetworking-Valheim threshold).</summary>
    private const int COMPRESSION_THRESHOLD = 100;

    /// <summary>Build and broadcast a <c>ZdoEventRpc</c> with payload from
    /// <paramref name="payload"/> (already populated; do not include the name).
    ///
    /// <para>If <paramref name="originPos"/> is non-null AND we're host, the
    /// dispatch culls per-peer using the same <see cref="ZdoMan.CULL_RADIUS_M"/>
    /// budget ZDO state replication uses. This is the right behaviour for
    /// high-frequency spatial events (citizen anim state at 5 Hz × N
    /// citizens, speech bubbles, combat hits) where peers far from the
    /// origin cannot visually observe the event anyway and shouldn't pay
    /// the bandwidth. Non-spatial events (chat, map ping, side-job, money,
    /// evidence facts, case board, banners) pass <c>null</c> and broadcast
    /// to every peer like before.</para>
    ///
    /// <para>Joiner-side (non-host) always broadcasts — we only have one
    /// peer (the host) and the host re-broadcasts to others via the
    /// generic packet relay (see <see cref="NetworkManager"/>). Even if a
    /// joiner had multiple peers, it doesn't track peer positions, so
    /// per-peer culling isn't possible there.</para>
    ///
    /// <para>If a peer hasn't reported a position yet (just connected,
    /// pre-PlayerSync), it's treated as <b>out-of-range</b> and the spatial
    /// event is skipped. Without this guard, a fresh joiner whose first
    /// PlayerPosition packet hasn't arrived yet would receive every spatial
    /// event in the world (animations, speech bubbles, damage) for the
    /// first 1–2 s while their LastKnownPosition is unset — burst of 20k+
    /// events, hard host-side stutter. Snapshot already carries the
    /// authoritative initial state; the small handful of transient events
    /// (a sweeping animation flip, an in-flight speech bubble) that the
    /// joiner misses during that window aren't observable anyway because
    /// the loading screen is still up.</para>
    /// </summary>
    public static void Send(string name, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered, UnityEngine.Vector3? originPos = null)
        => Send(name, payload, delivery, originPos, batch: false);

    /// <summary>Frame-batched variant for hot-path poller-driven events
    /// (citizen anim state, speech bubbles, NPC damage). When
    /// <paramref name="batch"/> is true the event is appended to
    /// <see cref="_pendingBatch"/> instead of being shipped immediately;
    /// <see cref="PumpPendingEventBatch"/> (called once per frame from
    /// <c>CoopUpdateRunner.Update</c>) coalesces every queued event into a
    /// single <c>ZdoEventRpc</c> packet with a count prefix.
    ///
    /// <para>Why: each <see cref="Send"/> used to issue its own
    /// <see cref="NetworkManager.SendTo"/>/<see cref="NetworkManager.SendToAll"/>
    /// = one Steam-socket send. Pollers easily generate dozens of events per
    /// frame (CitizenAnimationPoller caps at 32/tick × 5 Hz = up to 160
    /// individual packets/sec). Each tiny packet (~8–30 B) paid the full
    /// per-send syscall + Steam frame overhead AND never crossed the 100 B
    /// zstd threshold so nothing compressed. Batching collapses N sends into
    /// one, lets the combined payload compress, and bounds per-frame send
    /// count to O(1) regardless of how chatty the pollers are.</para>
    ///
    /// <para>Cold events (chat, ping, money, evidence, case-board, one-shot
    /// game events) pass <c>batch: false</c> and ship immediately — their
    /// latency is user-visible and they're rare enough that per-packet
    /// overhead is irrelevant.</para>
    ///
    /// <para>Thread safety: same as the rest of the dispatcher — Unity main
    /// thread only. <see cref="PumpPendingEventBatch"/> is the sole drainer,
    /// called from the Update cascade.</para></summary>
    public static void Send(string name, NetDataWriter payload, DeliveryMethod delivery, UnityEngine.Vector3? originPos, bool batch)
    {
        if (!NetworkManager.HasPeers) return;

        if (batch)
        {
            EnqueueBatch(name, payload, delivery, originPos);
            return;
        }

        ShipSingle(name, payload, delivery, originPos);
    }

    // ── Frame batching state ──────────────────────────────────────────────
    //
    // Hot-path events from pollers (CitizenAnimationPoller, SpeechBubblePoller,
    // NpcDamagePoller, spatter/footprint) are queued here instead of shipped
    // immediately. PumpPendingEventBatch (once per frame) walks the queue and
    // emits ONE ZdoEventRpc packet per (delivery-class, spatial-class) bucket
    // — collapsing N per-frame sends into O(1) sends.
    //
    // Single-threaded (Unity main); all access is from Send (poller tick) and
    // PumpPendingEventBatch (Update cascade), never concurrent.

    private struct PendingEvent
    {
        public int NameHash;
        public byte[] Body;       // captured payload bytes (length = BodyLen)
        public int BodyLen;
        public DeliveryMethod Delivery;
        public bool HasOrigin;
        public UnityEngine.Vector3 Origin;
    }

    private static readonly List<PendingEvent> _pendingBatch = new();

    /// <summary>Capture <paramref name="payload"/> into a pooled buffer and
    /// queue it for the next <see cref="PumpPendingEventBatch"/>.
    ///
    /// <para>Bodies are rented from <see cref="System.Buffers.ArrayPool{T}"/>
    /// and returned in <see cref="DrainPendingBatch"/>. The queue's whole point
    /// is cutting per-event overhead, and the batchable senders are the
    /// chattiest paths in the mod (CitizenAnimationPoller alone caps at 32
    /// events/tick × 5 Hz = up to 160/s), so a fresh <c>new byte[]</c> per
    /// event would trade the send-count win for steady Gen0 churn. Rented
    /// buffers are usually larger than <c>BodyLen</c>, hence every consumer
    /// slices by <c>BodyLen</c> and never by <c>Body.Length</c>.</para></summary>
    private static void EnqueueBatch(string name, NetDataWriter payload, DeliveryMethod delivery, UnityEngine.Vector3? originPos)
    {
        int nameHash = Hash32.Of(name);
        int bodyLen = payload?.Length ?? 0;
        byte[] body = bodyLen > 0
            ? System.Buffers.ArrayPool<byte>.Shared.Rent(bodyLen)
            : System.Array.Empty<byte>();
        if (bodyLen > 0) System.Buffer.BlockCopy(payload.Data, 0, body, 0, bodyLen);

        _pendingBatch.Add(new PendingEvent
        {
            NameHash = nameHash,
            Body = body,
            BodyLen = bodyLen,
            Delivery = delivery,
            HasOrigin = originPos.HasValue,
            Origin = originPos ?? UnityEngine.Vector3.zero,
        });
    }

    /// <summary>Return every queued event's pooled body and empty the queue.
    /// Must run even on an exception mid-drain, or the rented buffers leak out
    /// of the pool for the rest of the session.</summary>
    private static void ReleasePendingBatch()
    {
        for (int i = 0; i < _pendingBatch.Count; i++)
        {
            var body = _pendingBatch[i].Body;
            if (body != null && body.Length > 0)
                System.Buffers.ArrayPool<byte>.Shared.Return(body);
        }
        _pendingBatch.Clear();
    }

    /// <summary>Flush any queued batchable events. Called once per frame
    /// from <c>CoopUpdateRunner.Update</c> after <c>ZdoPollerHost.Tick</c>
    /// (so every poller's events for this frame are in the queue) and before
    /// <c>ZdoMan.TickDeltaFlush</c>. Emits at most a handful of
    /// <c>ZdoEventRpc</c> packets regardless of how many events queued: one
    /// per (delivery, spatial) bucket, with per-peer culling preserved for
    /// spatial events. No-op when the queue is empty.</summary>
    public static void PumpPendingEventBatch()
    {
        if (_pendingBatch.Count == 0) return;
        try { DrainPendingBatch(); }
        catch (Exception ex) { Plugin.Log.LogError($"[ZdoEventDispatcher] PumpPendingEventBatch: {ex.Message}"); }
        // Release + clear unconditionally: a bucket that threw mid-build must
        // not leave its rented bodies out of the pool, and a retained event
        // would be re-sent next frame.
        finally { ReleasePendingBatch(); }
    }

    /// <summary>Drain <see cref="_pendingBatch"/> into bucketed batched
    /// frames and ship them. Four buckets — the cross of
    /// {ReliableOrdered, Sequenced} × {spatial, non-spatial} — each becomes
    /// at most one packet per flush. Spatial buckets are dispatched per-peer
    /// (each event's origin tested against the peer's cull radius); a peer
    /// only receives the subset of the bucket that's in its range. Non-
    /// spatial buckets go to every world-ready peer.</summary>
    private static void DrainPendingBatch()
    {
        // Partition the queue into the four (delivery, spatial) buckets.
        // We don't sort — just four linear passes selecting matching entries.
        // Bucket sizes are bounded by the queue, which itself is bounded by
        // per-frame poller output (typically a few dozen).
        DrainBatchBucket(DeliveryMethod.ReliableOrdered, spatial: false);
        DrainBatchBucket(DeliveryMethod.ReliableOrdered, spatial: true);
        DrainBatchBucket(DeliveryMethod.Sequenced,       spatial: false);
        DrainBatchBucket(DeliveryMethod.Sequenced,       spatial: true);

        // The queue is released + cleared by PumpPendingEventBatch's finally,
        // so nothing is done here. Any event that didn't match a bucket (e.g.
        // an Unreliable delivery we don't currently emit) is dropped — none of
        // the current batchable Send* callers use Unreliable.
    }

    /// <summary>Build and ship the batched frame for one bucket. Selects
    /// events from <see cref="_pendingBatch"/> whose (Delivery, HasOrigin)
    /// matches this bucket. Per-peer culling is applied for spatial buckets:
    /// each peer receives a per-peer frame containing only the in-range
    /// events. Non-spatial buckets emit one frame broadcast to every world-
    /// ready peer.</summary>
    private static void DrainBatchBucket(DeliveryMethod delivery, bool spatial)
    {
        // Count matching entries first so we can skip the bucket entirely if
        // empty (no frame, no send) and pre-size the scratch.
        int matchCount = 0;
        for (int i = 0; i < _pendingBatch.Count; i++)
        {
            var e = _pendingBatch[i];
            if (e.Delivery == delivery && e.HasOrigin == spatial) matchCount++;
        }
        if (matchCount == 0) return;

        if (!NetworkManager.IsHost)
        {
            // Joiner: one peer (host, always ready). Build one frame with ALL
            // matching events (no culling — joiner has no other peers to cull
            // against and the host re-broadcasts via the generic relay).
            BuildBatchFrame(delivery, spatial, _pendingBatch, peerPos: null);
            NetworkManager.SendToAll(PacketType.ZdoEventRpc, _scratchOut, delivery);
            _eventSent     += 1;
            _eventSentBytes += _scratchOut.Length;
            return;
        }

        // Host. Non-spatial bucket: one frame → every world-ready peer.
        // Spatial bucket: per-peer frame (only in-range events included).
        var clients = NetworkManager.Clients;
        if (spatial)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                var peer = clients[i];
                if (peer == null) continue;
                int peerId = NetworkManager.GetPlayerIdByPeer(peer);
                if (peerId < 0) continue;
                if (NetworkManager.Players == null
                    || !NetworkManager.Players.TryGetValue(peerId, out var info)
                    || info == null
                    || !info.WorldReady
                    || !info.HasKnownPosition)
                {
                    _eventCullSkip += matchCount;
                    continue;
                }

                BuildBatchFrame(delivery, spatial, _pendingBatch, peerPos: info.LastKnownPosition);
                if (_batchFrameEventCount == 0)
                {
                    // Whole bucket was out of range for this peer — no send.
                    _eventCullSkip += matchCount;
                    continue;
                }
                NetworkManager.SendTo(peer, PacketType.ZdoEventRpc, _scratchOut, delivery);
                _eventSent++;
                _eventSentBytes += _scratchOut.Length;
                _eventCullSkip += (matchCount - _batchFrameEventCount);
            }
        }
        else
        {
            BuildBatchFrame(delivery, spatial, _pendingBatch, peerPos: null);
            int frameLen = _scratchOut.Length;
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

                NetworkManager.SendTo(peer, PacketType.ZdoEventRpc, _scratchOut, delivery);
                _eventSent++;
                _eventSentBytes += frameLen;
            }
        }
    }

    /// <summary>Number of events written into <see cref="_scratchOut"/> by
    /// the most recent <see cref="BuildBatchFrame"/> call. Lets the caller
    /// detect "bucket was entirely out of range for this peer → skip send".</summary>
    private static int _batchFrameEventCount;

    /// <summary>Build a batched <c>ZdoEventRpc</c> frame into
    /// <see cref="_scratchOut"/>. Wire layout (flags bit2 = batched):
    /// <code>
    ///   byte flags            (bit0=compressed, bit2=batched)
    ///   int  innerLen         (decompressed body length)
    ///   int  payloadLen       (= compressed length if bit0 set)
    ///   byte[payloadLen]
    ///     ushort eventCount
    ///     repeat eventCount × { int nameHash; int bodyLen; byte[bodyLen] body }
    /// </code>
    /// For spatial buckets (<paramref name="peerPos"/> non-null), each event
    /// is culled against <paramref name="peerPos"/> before being written —
    /// only in-range events end up in this peer's frame.</summary>
    private static void BuildBatchFrame(DeliveryMethod delivery, bool spatial, List<PendingEvent> src, UnityEngine.Vector3? peerPos)
    {
        // Inner body first (so we can decide on compression once we know its
        // length), then wrap with the flags/length header.
        _innerScratch.Reset();
        ushort written = 0;
        float radiusSq = ZdoMan.CULL_RADIUS_M * ZdoMan.CULL_RADIUS_M;
        for (int i = 0; i < src.Count; i++)
        {
            var e = src[i];
            if (e.Delivery != delivery || e.HasOrigin != spatial) continue;

            if (spatial && peerPos.HasValue)
            {
                var p = peerPos.Value;
                float dx = e.Origin.x - p.x;
                float dz = e.Origin.z - p.z;
                if (dx * dx + dz * dz > radiusSq) continue; // out of range for this peer
            }

            _innerScratch.Put(e.NameHash);
            _innerScratch.Put(e.BodyLen);
            if (e.BodyLen > 0) _innerScratch.Put(e.Body, 0, e.BodyLen);
            written++;
        }

        // Count prefix sits at the START of the inner body.
        // Patch it in: write count into the first 2 bytes by rebuilding with
        // a prefix. Cheaper alternative: prepend via a temporary. Since this
        // runs at most a few times per frame we just rebuild into a second
        // scratch with the count prefix.
        _batchInnerPrefixScratch.Reset();
        _batchInnerPrefixScratch.Put(written);
        if (_innerScratch.Length > 0)
            _batchInnerPrefixScratch.Put(_innerScratch.Data, 0, _innerScratch.Length);

        int innerLen = _batchInnerPrefixScratch.Length;
        bool compress = innerLen >= COMPRESSION_THRESHOLD;

        _scratchOut.Reset();
        byte flags = 0x04; // bit2 = batched
        if (compress) flags |= 0x01;
        _scratchOut.Put(flags);
        _scratchOut.Put(innerLen);

        if (compress)
        {
            byte[] compressed = ZdoCompression.Compress(_batchInnerPrefixScratch.Data, innerLen);
            _scratchOut.Put(compressed.Length);
            _scratchOut.Put(compressed, 0, compressed.Length);
        }
        else
        {
            _scratchOut.Put(innerLen);
            _scratchOut.Put(_batchInnerPrefixScratch.Data, 0, innerLen);
        }

        _batchFrameEventCount = written;
    }

    /// <summary>Immediate (non-batched) ship path — the original per-event
    /// Send logic, extracted so the batch=false branch reads cleanly. Used
    /// for cold events (chat, ping, money, evidence, case-board) where
    /// latency is user-visible and per-packet overhead is irrelevant.</summary>
    private static void ShipSingle(string name, NetDataWriter payload, DeliveryMethod delivery, UnityEngine.Vector3? originPos)
    {
        BuildFrame(name, payload);

        // Per-peer cull on the host for spatial events. We deliberately
        // mirror ZdoMan's per-peer dispatch loop (Clients × Players) so
        // visibility stays consistent: if a peer can't see ZDO state at
        // this position, they shouldn't receive an RPC tagged with it.
        if (originPos.HasValue && NetworkManager.IsHost)
        {
            var pos = originPos.Value;
            float radiusSq = ZdoMan.CULL_RADIUS_M * ZdoMan.CULL_RADIUS_M;
            var clients = NetworkManager.Clients;
            int frameLen = _scratchOut.Length;
            for (int i = 0; i < clients.Count; i++)
            {
                var peer = clients[i];
                if (peer == null) continue;
                int peerId = NetworkManager.GetPlayerIdByPeer(peer);
                if (peerId < 0) continue;

                // Skip peers that are still loading (no snapshot yet) OR have
                // no confirmed position. A still-loading joiner can't apply
                // events (live SoD objects don't exist) and running its
                // handlers there throws+swallows NREs — the loading-time
                // freeze. WorldReady is set post-snapshot; HasKnownPosition
                // covers the cull. Snapshot delivers authoritative state.
                if (NetworkManager.Players == null
                    || !NetworkManager.Players.TryGetValue(peerId, out var info)
                    || info == null
                    || !info.WorldReady
                    || !info.HasKnownPosition)
                {
                    _eventCullSkip++;
                    continue;
                }

                float dx = pos.x - info.LastKnownPosition.x;
                float dz = pos.z - info.LastKnownPosition.z;
                if (dx * dx + dz * dz > radiusSq)
                {
                    _eventCullSkip++;
                    continue;
                }

                NetworkManager.SendTo(peer, PacketType.ZdoEventRpc, _scratchOut, delivery);
                _eventSent++;
                _eventSentBytes += frameLen;
            }
            return;
        }

        // Non-spatial event: broadcast to all *world-ready* peers.
        if (NetworkManager.IsHost)
        {
            // Per-peer loop (not SendToAll) so we can skip still-loading peers.
            // Sending a global event (chat, money, evidence, case-board, banner)
            // to a peer on the loading screen produces the same NRE-and-swallow
            // storm as spatial events — its handlers deref live SoD objects that
            // don't exist yet. The post-load snapshot carries authoritative
            // state for everything these events would have mutated.
            var clients = NetworkManager.Clients;
            int frameLen = _scratchOut.Length;
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

                NetworkManager.SendTo(peer, PacketType.ZdoEventRpc, _scratchOut, delivery);
                _eventSent++;
                _eventSentBytes += frameLen;
            }
        }
        else
        {
            // Joiner-side: only peer is the host (always ready). The host
            // re-broadcasts to other clients via the generic packet relay.
            NetworkManager.SendToAll(PacketType.ZdoEventRpc, _scratchOut, delivery);
            _eventSent     += 1;
            _eventSentBytes += _scratchOut.Length;
        }
    }

    public static void SendTo(SteamPeer peer, string name, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (peer == null) return;
        BuildFrame(name, payload);
        NetworkManager.SendTo(peer, PacketType.ZdoEventRpc, _scratchOut, delivery);
    }

    /// <summary>Construct the framed event payload into <see cref="_scratchOut"/>.</summary>
    private static void BuildFrame(string name, NetDataWriter payload)
    {
        // Inner payload — hash + body.
        _innerScratch.Reset();
        _innerScratch.Put(Hash32.Of(name));
        if (payload != null && payload.Length > 0)
            _innerScratch.Put(payload.Data, 0, payload.Length);

        int innerLen = _innerScratch.Length;
        bool compress = innerLen >= COMPRESSION_THRESHOLD;

        _scratchOut.Reset();
        byte flags = 0;
        if (compress) flags |= 0x01;
        _scratchOut.Put(flags);
        _scratchOut.Put(innerLen);

        if (compress)
        {
            byte[] compressed = ZdoCompression.Compress(_innerScratch.Data, innerLen);
            _scratchOut.Put(compressed.Length);
            _scratchOut.Put(compressed, 0, compressed.Length);
        }
        else
        {
            _scratchOut.Put(innerLen);
            _scratchOut.Put(_innerScratch.Data, 0, innerLen);
        }
    }

    /// <summary>Decode an incoming <c>ZdoEventRpc</c> frame and invoke the
    /// registered handler. Hot path — runs for EVERY incoming event packet,
    /// so the body is copied out of the transport reader with a single
    /// <see cref="Buffer.BlockCopy"/> into a rented
    /// <see cref="System.Buffers.ArrayPool{T}"/> buffer instead of a fresh
    /// allocation plus a per-byte <c>GetByte()</c> loop.
    ///
    /// <para><b>Pooling contract:</b> the rented buffer is returned in the
    /// <c>finally</c> below — and in the uncompressed path <c>inner</c>
    /// wraps that buffer directly — so handlers MUST consume the reader
    /// synchronously and MUST NOT retain it (or its <c>RawData</c>) past
    /// the call. All current handlers are parse-and-apply functions and
    /// satisfy this.</para></summary>
    public static void Dispatch(NetDataReader r, int senderId)
    {
        // ── Client-side world-ready guard (defense in depth) ────────────────
        // While the local world is still generating, the live SoD objects the
        // event handlers dereference (CityData.Instance, MurderController,
        // Player.Instance, …) don't exist. Running a handler now throws an NRE
        // that the inner try/catch swallows — but in IL2CPP each thrown+caught
        // exception costs real time, and a host streaming events during our
        // load produced a per-packet exception storm: a primary cause of the
        // loading-time freeze. The host now gates sends on the peer's
        // WorldReady flag so these shouldn't arrive during load anyway; this
        // is the belt-and-braces guard for Mode 2 / timing windows / forwarded
        // traffic. Dropping is safe — the ZDO snapshot carries authoritative
        // state and these RPC events are transient (anim flips, speech bubbles,
        // banners). The host is always world-ready, so host-side dispatch
        // (events from clients) is unaffected.
        if (!SoDCoop.Sync.WorldReadyGate.IsWorldReady) return;

        try
        {
            byte flags = r.GetByte();
            int innerLen = r.GetInt();
            int bodyLen  = r.GetInt();

            if (bodyLen <= 0) return;

            // The old per-byte GetByte() loop threw on truncated packets;
            // BlockCopy only validates against the *physical* array length
            // (LiteNetLib reuses oversized receive buffers), so we must
            // bounds-check the reader's logical size ourselves or a
            // truncated/corrupt frame would silently read trailing garbage.
            if (bodyLen > r.AvailableBytes)
            {
                Plugin.Log.LogWarning($"[ZdoEventDispatcher] truncated event frame from sender {senderId}: bodyLen={bodyLen} > available={r.AvailableBytes}");
                return;
            }

            // Rent, don't allocate — this path runs per incoming event
            // packet. NB: pooled buffers may be LARGER than bodyLen, so
            // every consumer below must be bounded by bodyLen explicitly
            // and never rely on body.Length.
            byte[] body = System.Buffers.ArrayPool<byte>.Shared.Rent(bodyLen);
            try
            {
                Buffer.BlockCopy(r.RawData, r.Position, body, 0, bodyLen);
                r.SkipBytes(bodyLen);

                NetDataReader inner;
                if ((flags & 0x01) != 0)
                {
                    // 3-arg overload bounds the zstd read to bodyLen — the
                    // pooled buffer carries stale bytes past the real frame.
                    byte[] decompressed = ZdoCompression.Decompress(body, bodyLen, innerLen);
                    inner = new NetDataReader(decompressed);
                }
                else
                {
                    // (source, offset, maxSize) ctor caps the readable
                    // length at bodyLen; the plain (byte[]) ctor would
                    // expose the pooled buffer's oversized tail to handlers.
                    inner = new NetDataReader(body, 0, bodyLen);
                }

                // Bit2 = batched frame. The inner body starts with a ushort
                // event count, followed by that many (int nameHash, int
                // bodyLen, byte[bodyLen]) triples. Each triple is dispatched
                // to its handler in order. Single-event frames (bit2 clear)
                // take the legacy path below.
                if ((flags & 0x04) != 0)
                {
                    int evCount = inner.GetUShort();
                    for (int ei = 0; ei < evCount; ei++)
                    {
                        int nameHash = inner.GetInt();
                        int evBodyLen = inner.GetInt();
                        if (evBodyLen > inner.AvailableBytes)
                        {
                            Plugin.Log.LogWarning($"[ZdoEventDispatcher] truncated batched event #{ei} from sender {senderId}: evBodyLen={evBodyLen} > available={inner.AvailableBytes}");
                            break;
                        }
                        if (_byNameHash.TryGetValue(nameHash, out var entry))
                        {
                            // Hand the handler a sub-reader bounded to exactly
                            // this event's body so it can't accidentally read
                            // into the next event's nameHash. Same ArrayPool
                            // contract as single-event path: consume sync,
                            // don't retain past the call.
                            //
                            // NOTE the third ctor arg is the ABSOLUTE END
                            // offset, not a length: LiteNetLib's SetSource does
                            // `_position = offset; _dataSize = maxSize;` and
                            // reports `AvailableBytes = _dataSize - _position`.
                            // Passing a bare length here made AvailableBytes
                            // under-report by `Position` (and go NEGATIVE from
                            // the second event onward — measured -18 on a
                            // 2-event batch). Reads still landed on the right
                            // bytes, so the current fixed-shape handlers
                            // happened to work, but any handler using the
                            // version-tolerant `if (r.AvailableBytes >= 1)`
                            // pattern used elsewhere in this codebase would
                            // silently skip its trailing fields.
                            var evReader = new NetDataReader(inner.RawData, inner.Position, inner.Position + evBodyLen);
                            inner.SkipBytes(evBodyLen);
                            try { entry.handler(evReader, senderId); }
                            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEventDispatcher] batched handler '{entry.name}' from sender {senderId}: {ex.Message}"); }
                        }
                        else
                        {
                            Plugin.Log.LogWarning($"[ZdoEventDispatcher] unknown event hash {nameHash:X8} from sender {senderId} (batched #{ei})");
                            inner.SkipBytes(evBodyLen);
                        }
                    }
                    return;
                }

                int nameHash2 = inner.GetInt();
                if (_byNameHash.TryGetValue(nameHash2, out var entry2))
                {
                    // Handler runs synchronously here, before the finally
                    // returns the pooled buffer that 'inner' may wrap.
                    entry2.handler(inner, senderId);
                }
                else
                {
                    Plugin.Log.LogWarning($"[ZdoEventDispatcher] unknown event hash {nameHash2:X8} from sender {senderId}");
                }
            }
            finally
            {
                System.Buffers.ArrayPool<byte>.Shared.Return(body, clearArray: false);
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoEventDispatcher] dispatch failed: {ex.Message}");
        }
    }

    private static readonly NetDataWriter _scratchOut   = new();
    private static readonly NetDataWriter _innerScratch = new();
    /// <summary>Second-stage inner body scratch for the batched path. The
    /// batched frame needs a count prefix at the START of the inner body,
    /// but events are appended as we discover them — so we write events
    /// into <see cref="_innerScratch"/> first, then prefix the count here
    /// when wrapping. Kept separate so the single-event
    /// <see cref="BuildFrame"/> path (which owns <see cref="_innerScratch"/>)
    /// can't collide with an in-flight batch build.</summary>
    private static readonly NetDataWriter _batchInnerPrefixScratch = new();

    // ── Bandwidth stats (rolling 5 s window, sampled by ZdoMan's stats tick) ─
    // _eventSent      = total per-peer SendTo / SendToAll fan-out count
    // _eventCullSkip  = per-peer skips due to spatial cull
    // _eventSentBytes = total bytes shipped (frame length × peers reached)
    //
    // ZdoMan reads + resets these in its 5 s [ZdoStats] tick (see
    // SampleStatsAndReset) so the event channel rolls into the same log
    // line that already shows ZDO dirty/pending/culled traffic.
    private static long _eventSent;
    private static long _eventCullSkip;
    private static long _eventSentBytes;

    /// <summary>Atomically read + reset the rolling event-bandwidth
    /// counters. Called by <see cref="ZdoMan"/>'s 5 s stats tick so RPC
    /// traffic shows up alongside ZDO traffic in the same log line.
    /// Returns 0/0/0 if no events were sent in the window.</summary>
    public static void SampleStatsAndReset(out long sent, out long cullSkip, out long sentBytes)
    {
        sent      = _eventSent;
        cullSkip  = _eventCullSkip;
        sentBytes = _eventSentBytes;
        _eventSent      = 0;
        _eventCullSkip  = 0;
        _eventSentBytes = 0;
    }
}
