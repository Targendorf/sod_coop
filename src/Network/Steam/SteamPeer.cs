using System;
using LiteNetLib;
using Steamworks;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Connection wrapper for a remote peer. Despite the name, also hosts the
/// LiteNetLib direct-IP transport now — the type stayed "SteamPeer" to avoid
/// renaming everywhere the rest of the code passes a peer around (Sync.*
/// snapshot helpers, ZdoMan, ZdoEventDispatcher, PeerSendQueue, all the
/// 99-entry <see cref="Network.PacketType"/> handlers).
///
/// <para>One instance per remote (host has one per client; client has one
/// for the host). For the Steam transport, owns the underlying
/// <see cref="HSteamNetConnection"/>. For the LiteNetLib transport,
/// <see cref="LitePeer"/> is set instead and <see cref="Connection"/> stays
/// at <c>HSteamNetConnection.Invalid</c>. The active
/// <see cref="Network.NetworkManager.ActiveTransport"/> kind tells callers
/// which path to dispatch through.</para>
/// </summary>
public sealed class SteamPeer
{
    /// <summary>Underlying SteamNetworkingSockets connection handle. Invalid
    /// for IP-based peers.</summary>
    public HSteamNetConnection Connection { get; }

    /// <summary>The remote user's Steam ID. Stable identity for friend
    /// invites, profile lookups, and reconnect-by-identity. Zero for
    /// IP-based peers.</summary>
    public CSteamID SteamId { get; }

    /// <summary>LiteNetLib peer reference for the direct-IP transport. Null
    /// for Steam-based peers.</summary>
    public global::LiteNetLib.NetPeer LitePeer { get; }

    /// <summary>Endpoint string for IP-based peers — "ip:port". Empty for
    /// Steam-based peers (Steam doesn't expose IPs).</summary>
    public string Endpoint { get; }

    /// <summary>Bag for the host-side connection-data payload (currently
    /// the client's stable per-installation GUID — see
    /// <see cref="Player.CharacterIdentity.ClientGuid"/>). Set after the
    /// first inbound message that carries it; null until then.</summary>
    public string ClientGuid { get; set; }

    /// <summary>Generic tag slot mirroring LiteNetLib's <c>NetPeer.Tag</c> —
    /// kept for any caller that stored ad-hoc state on the old NetPeer.</summary>
    public object Tag { get; set; }

    /// <summary>Pretty identifier for log lines — SteamID for Steam peers,
    /// "ip:port" for IP peers.</summary>
    public string DisplayName => SteamId.m_SteamID != 0
        ? SteamId.m_SteamID.ToString()
        : (string.IsNullOrEmpty(Endpoint) ? "<unknown>" : Endpoint);

    /// <summary>Steam-transport ctor.</summary>
    public SteamPeer(HSteamNetConnection conn, CSteamID steamId)
    {
        Connection = conn;
        SteamId = steamId;
        LitePeer = null;
        Endpoint = "";
    }

    /// <summary>LiteNetLib-transport ctor.</summary>
    public SteamPeer(global::LiteNetLib.NetPeer litePeer)
    {
        Connection = HSteamNetConnection.Invalid;
        SteamId = new CSteamID(0);
        LitePeer = litePeer;
        // LiteNetLib 1.2.0 exposes Address (port + ip text) on NetPeer.
        try
        {
            if (litePeer == null) { Endpoint = ""; }
            else
            {
                var addr = litePeer.Address;
                Endpoint = addr != null ? $"{addr}:{litePeer.Port}" : "";
            }
        }
        catch { Endpoint = ""; }
    }

    /// <summary>Send a raw payload through the active transport. Routes to
    /// either Steam or LiteNetLib depending on which transport this peer was
    /// constructed for.</summary>
    public bool Send(byte[] payload, DeliveryMethod delivery)
    {
        if (payload == null || payload.Length == 0) return false;
        if (LitePeer != null)
            return LiteNet.LiteNetTransport.Send(this, payload, 0, payload.Length, delivery);
        return SteamTransport.Send(this, payload, 0, payload.Length, delivery);
    }
}
