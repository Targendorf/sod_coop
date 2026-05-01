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

    /// <summary>Build and broadcast a <c>ZdoEventRpc</c> with payload from
    /// <paramref name="payload"/> (already populated; do not include the name).</summary>
    public static void Send(string name, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (!NetworkManager.HasPeers) return;
        var w = _scratchOut;
        w.Reset();
        w.Put(Hash32.Of(name));
        if (payload != null && payload.Length > 0)
            w.Put(payload.Data, 0, payload.Length);
        NetworkManager.SendToAll(PacketType.ZdoEventRpc, w, delivery);
    }

    public static void SendTo(NetPeer peer, string name, NetDataWriter payload, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (peer == null) return;
        var w = _scratchOut;
        w.Reset();
        w.Put(Hash32.Of(name));
        if (payload != null && payload.Length > 0)
            w.Put(payload.Data, 0, payload.Length);
        NetworkManager.SendTo(peer, PacketType.ZdoEventRpc, w, delivery);
    }

    public static void Dispatch(NetDataReader r, int senderId)
    {
        try
        {
            int nameHash = r.GetInt();
            if (_byNameHash.TryGetValue(nameHash, out var entry))
            {
                entry.handler(r, senderId);
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

    private static readonly NetDataWriter _scratchOut = new();
}
