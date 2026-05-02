using System;
using System.Collections.Generic;
using LiteNetLib;
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
    /// <paramref name="payload"/> (already populated; do not include the name).</summary>
    public static void Send(string name, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (!NetworkManager.HasPeers) return;
        BuildFrame(name, payload);
        NetworkManager.SendToAll(PacketType.ZdoEventRpc, _scratchOut, delivery);
    }

    public static void SendTo(NetPeer peer, string name, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
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
}
