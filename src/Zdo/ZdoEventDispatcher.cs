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
    {
        if (!NetworkManager.HasPeers) return;
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

            byte[] body = new byte[bodyLen];
            for (int i = 0; i < bodyLen; i++) body[i] = r.GetByte();

            NetDataReader inner;
            if ((flags & 0x01) != 0)
            {
                byte[] decompressed = ZdoCompression.Decompress(body, innerLen);
                inner = new NetDataReader(decompressed);
            }
            else
            {
                inner = new NetDataReader(body);
            }

            int nameHash = inner.GetInt();
            if (_byNameHash.TryGetValue(nameHash, out var entry))
            {
                entry.handler(inner, senderId);
            }
            else
            {
                Plugin.Log.LogWarning($"[ZdoEventDispatcher] unknown event hash {nameHash:X8} from sender {senderId}");
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoEventDispatcher] dispatch failed: {ex.Message}");
        }
    }

    private static readonly NetDataWriter _scratchOut   = new();
    private static readonly NetDataWriter _innerScratch = new();

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
