using System;
using LiteNetLib;
using Steamworks;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Connection wrapper for a Steam P2P peer. Replaces the LiteNetLib
/// <c>NetPeer</c> reference everywhere the rest of the code passes a peer
/// around (Sync.* snapshot helpers, ZdoMan, ZdoEventDispatcher, PeerSendQueue).
///
/// <para>One instance per remote (host has one per client; client has one
/// for the host). Owns the underlying <see cref="HSteamNetConnection"/>; the
/// transport closes that handle when the peer goes away.</para>
/// </summary>
public sealed class SteamPeer
{
    /// <summary>Underlying SteamNetworkingSockets connection handle.</summary>
    public HSteamNetConnection Connection { get; }

    /// <summary>The remote user's Steam ID. Stable identity for friend
    /// invites, profile lookups, and reconnect-by-identity.</summary>
    public CSteamID SteamId { get; }

    /// <summary>Bag for the host-side connection-data payload (currently
    /// the client's stable per-installation GUID — see
    /// <see cref="Player.CharacterIdentity.ClientGuid"/>). Set after the
    /// first inbound message that carries it; null until then.</summary>
    public string ClientGuid { get; set; }

    /// <summary>Generic tag slot mirroring LiteNetLib's <c>NetPeer.Tag</c> —
    /// kept for any caller that stored ad-hoc state on the old NetPeer.</summary>
    public object Tag { get; set; }

    /// <summary>Pretty identifier for log lines — the SteamID as a decimal
    /// string. Friends-only invites mean we never see anonymous IPs anyway,
    /// and SteamFriends.GetFriendPersonaName(steamId) can resolve a real
    /// name on demand.</summary>
    public string DisplayName => SteamId.m_SteamID.ToString();

    public SteamPeer(HSteamNetConnection conn, CSteamID steamId)
    {
        Connection = conn;
        SteamId = steamId;
    }

    /// <summary>Send a raw payload through the underlying Steam connection.
    /// Used by <see cref="SoDCoop.Zdo.PeerSendQueue"/> when draining backpressure.</summary>
    public bool Send(byte[] payload, DeliveryMethod delivery)
    {
        if (payload == null || payload.Length == 0) return false;
        return SteamTransport.Send(this, payload, 0, payload.Length, delivery);
    }
}
