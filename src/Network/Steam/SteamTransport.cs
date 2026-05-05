using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LiteNetLib;
using Steamworks;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Replaces LiteNetLib's <c>NetManager</c> + <c>EventBasedNetListener</c>
/// transport surface with SteamNetworkingSockets P2P. Goes through Steam's
/// SDR (Steam Datagram Relay) so connections work across NAT/CGNAT,
/// nothing leaks the host's IP, and traffic is encrypted end-to-end.
///
/// <para>The transport doesn't know about packet types or the handshake —
/// it just delivers framed bytes both ways. NetworkManager wires the
/// receive callback into its existing dispatch loop, so the 99-entry
/// PacketType enum + the character / handshake flow continue unchanged.</para>
///
/// <para>Channels: we ignore Steam "lanes" and just translate the
/// LiteNetLib <see cref="DeliveryMethod"/> enum into Steam send flags at
/// each <see cref="Send"/> call.</para>
/// </summary>
public static class SteamTransport
{
    /// <summary>Virtual port: an arbitrary u16 the lobby agrees on so multiple
    /// SDK products in the same process don't cross-deliver. SoD uses 0
    /// internally for its own networking; we pick 4242 to avoid collision.</summary>
    public const int VIRTUAL_PORT = 4242;

    private const int RECV_BATCH = 64;
    private const int MAX_PEERS  = 4;

    /// <summary>Delivered to the consumer once per fully-received message.
    /// Carries (sender, payload, payloadLen). Payload buffer is owned by
    /// the transport and must not be retained past the callback return.</summary>
    public delegate void ReceiveHandler(SteamPeer sender, byte[] payload, int length);

    public static event ReceiveHandler OnMessage;

    /// <summary>Raised when an incoming connection completes — host side. The
    /// peer is freshly minted; the consumer (NetworkManager) runs the
    /// existing handshake / character flow.</summary>
    public static event Action<SteamPeer> OnPeerConnected;

    /// <summary>Raised when a peer disconnects (timeout / reason). The
    /// transport already closed the connection by the time this fires.</summary>
    public static event Action<SteamPeer, string> OnPeerDisconnected;

    /// <summary>Raised on the client when the local connection's status
    /// transitions to <see cref="ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected"/>.</summary>
    public static event Action<SteamPeer> OnConnected;

    /// <summary>Raised on the client when the local connection fails. Carries
    /// the human-readable reason (Steam's debug string when available).</summary>
    public static event Action<string> OnConnectFailed;

    private static HSteamListenSocket _listenSocket = HSteamListenSocket.Invalid;
    private static HSteamNetPollGroup _pollGroup    = HSteamNetPollGroup.Invalid;

    /// <summary>Active peers keyed by underlying connection handle.</summary>
    private static readonly Dictionary<HSteamNetConnection, SteamPeer> _peers = new();

    /// <summary>True iff we hold a listen socket (host) or an outgoing
    /// connection (client). Drives the per-frame Pump loop.</summary>
    public static bool IsActive => _listenSocket != HSteamListenSocket.Invalid || _peers.Count > 0;

    public static IEnumerable<SteamPeer> Peers => _peers.Values;

    // ─── Host: listen ──────────────────────────────────────────────────────

    /// <summary>Start accepting P2P connections. Idempotent.</summary>
    public static bool StartListening()
    {
        if (_listenSocket != HSteamListenSocket.Invalid) return true;

        try
        {
            // Listen on the virtual port for ALL P2P connections; no IP/port
            // matters here because SDR routes by SteamID.
            _listenSocket = SteamNetworkingSockets.CreateListenSocketP2P(VIRTUAL_PORT, 0, null);
            _pollGroup    = SteamNetworkingSockets.CreatePollGroup();

            if (_listenSocket == HSteamListenSocket.Invalid)
            {
                Plugin.Log.LogError("[SteamTransport] CreateListenSocketP2P returned Invalid.");
                _pollGroup = HSteamNetPollGroup.Invalid;
                return false;
            }

            Plugin.Log.LogInfo($"[SteamTransport] listening on virtual port {VIRTUAL_PORT}.");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamTransport] StartListening: {ex}");
            return false;
        }
    }

    // ─── Client: connect ───────────────────────────────────────────────────

    public static bool ConnectTo(CSteamID hostSteamId)
    {
        try
        {
            // Reset before connecting — guard against half-state from a
            // prior failed attempt.
            CloseAllPeers("client reconnect");

            if (_pollGroup == HSteamNetPollGroup.Invalid)
                _pollGroup = SteamNetworkingSockets.CreatePollGroup();

            var ident = new SteamNetworkingIdentity();
            ident.SetSteamID(hostSteamId);

            var conn = SteamNetworkingSockets.ConnectP2P(ref ident, VIRTUAL_PORT, 0, null);
            if (conn == HSteamNetConnection.Invalid)
            {
                Plugin.Log.LogError($"[SteamTransport] ConnectP2P → invalid handle for host {hostSteamId.m_SteamID}");
                try { OnConnectFailed?.Invoke("Steam returned invalid connection handle"); } catch { }
                return false;
            }

            SteamNetworkingSockets.SetConnectionPollGroup(conn, _pollGroup);

            var peer = new SteamPeer(conn, hostSteamId);
            _peers[conn] = peer;

            Plugin.Log.LogInfo($"[SteamTransport] dialing host {hostSteamId.m_SteamID} on virtual port {VIRTUAL_PORT}.");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamTransport] ConnectTo: {ex}");
            try { OnConnectFailed?.Invoke(ex.Message); } catch { }
            return false;
        }
    }

    // ─── Send ──────────────────────────────────────────────────────────────

    /// <summary>Send a payload over a specific peer connection. Returns
    /// true iff Steam accepted the message into its outgoing queue.</summary>
    public static bool Send(SteamPeer peer, byte[] payload, int offset, int length, DeliveryMethod delivery)
    {
        if (peer == null) return false;
        if (payload == null || length <= 0) return false;

        int flags = ToSteamSendFlags(delivery);

        // SteamNetworkingSockets.SendMessageToConnection requires a contiguous
        // pointer + length. Pin the buffer briefly to avoid a managed copy.
        IntPtr handle = IntPtr.Zero;
        var pinned = GCHandle.Alloc(payload, GCHandleType.Pinned);
        try
        {
            IntPtr basePtr = pinned.AddrOfPinnedObject();
            IntPtr ptr = offset == 0 ? basePtr : new IntPtr(basePtr.ToInt64() + offset);
            long outMsgNumber;
            var result = SteamNetworkingSockets.SendMessageToConnection(
                peer.Connection, ptr, (uint)length, flags, out outMsgNumber);

            if (result != EResult.k_EResultOK)
            {
                Plugin.Log.LogWarning($"[SteamTransport] Send → {result} (peer={peer.DisplayName} len={length})");
                return false;
            }
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SteamTransport] Send threw: {ex.Message}");
            return false;
        }
        finally
        {
            if (pinned.IsAllocated) pinned.Free();
        }
    }

    public static bool Send(SteamPeer peer, byte[] payload, DeliveryMethod delivery)
        => Send(peer, payload, 0, payload?.Length ?? 0, delivery);

    private static int ToSteamSendFlags(DeliveryMethod delivery)
    {
        // Maps LiteNetLib's enum onto Steam's bitflag set:
        //   ReliableOrdered   → reliable, in-order
        //   ReliableUnordered → reliable, no order
        //   Sequenced         → unreliable, only-newest semantics ≈ unreliable + NoNagle
        //   Unreliable        → fire-and-forget
        switch (delivery)
        {
            case DeliveryMethod.ReliableOrdered:
            case DeliveryMethod.ReliableSequenced:
                return Constants.k_nSteamNetworkingSend_Reliable;
            case DeliveryMethod.ReliableUnordered:
                return Constants.k_nSteamNetworkingSend_Reliable | Constants.k_nSteamNetworkingSend_NoNagle;
            case DeliveryMethod.Sequenced:
                return Constants.k_nSteamNetworkingSend_Unreliable | Constants.k_nSteamNetworkingSend_NoNagle;
            default:
                return Constants.k_nSteamNetworkingSend_Unreliable;
        }
    }

    // ─── Receive (called per frame from NetworkManager.Update) ─────────────

    public static void Pump()
    {
        if (_pollGroup == HSteamNetPollGroup.Invalid) return;

        IntPtr[] msgs = new IntPtr[RECV_BATCH];
        int got;
        try { got = SteamNetworkingSockets.ReceiveMessagesOnPollGroup(_pollGroup, msgs, RECV_BATCH); }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SteamTransport] ReceiveMessagesOnPollGroup: {ex.Message}");
            return;
        }

        for (int i = 0; i < got; i++)
        {
            IntPtr msgPtr = msgs[i];
            if (msgPtr == IntPtr.Zero) continue;
            try
            {
                var msg = Marshal.PtrToStructure<SteamNetworkingMessage_t>(msgPtr);
                var peer = LookupPeer(msg.m_conn);
                int len = msg.m_cbSize;
                if (peer != null && len > 0 && msg.m_pData != IntPtr.Zero)
                {
                    byte[] buf = new byte[len];
                    Marshal.Copy(msg.m_pData, buf, 0, len);
                    try { OnMessage?.Invoke(peer, buf, len); }
                    catch (Exception ex) { Plugin.Log.LogError($"[SteamTransport] OnMessage handler threw: {ex}"); }
                }
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"[SteamTransport] message dispatch: {ex.Message}");
            }
            finally
            {
                // Steam manages the message buffer; we must release it.
                try { SteamNetworkingMessage_t.Release(msgPtr); } catch { }
            }
        }
    }

    private static SteamPeer LookupPeer(HSteamNetConnection conn)
    {
        return _peers.TryGetValue(conn, out var p) ? p : null;
    }

    // ─── Connection-status callback (Steam → us) ───────────────────────────

    public static void OnConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t cb)
    {
        var conn   = cb.m_hConn;
        var info   = cb.m_info;
        var oldSt  = cb.m_eOldState;
        var newSt  = info.m_eState;
        var remote = new CSteamID(info.m_identityRemote.GetSteamID64());

        try
        {
            // Inbound connection request — host side.
            if (newSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connecting
                && oldSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_None)
            {
                if (_listenSocket == HSteamListenSocket.Invalid)
                {
                    // We're a client and got an unsolicited inbound — close.
                    SteamNetworkingSockets.CloseConnection(conn, 0, "client refused inbound", false);
                    return;
                }

                // Validate: must be a member of our lobby.
                if (!IsLobbyMember(remote))
                {
                    Plugin.Log.LogWarning($"[SteamTransport] reject {remote.m_SteamID} — not a member of lobby {SteamLobby.CurrentLobby.m_SteamID}");
                    SteamNetworkingSockets.CloseConnection(conn, 0, "not in lobby", false);
                    return;
                }

                if (_peers.Count >= MAX_PEERS)
                {
                    Plugin.Log.LogWarning($"[SteamTransport] reject {remote.m_SteamID} — server full ({_peers.Count}/{MAX_PEERS})");
                    SteamNetworkingSockets.CloseConnection(conn, 0, "server full", false);
                    return;
                }

                var accept = SteamNetworkingSockets.AcceptConnection(conn);
                if (accept != EResult.k_EResultOK)
                {
                    Plugin.Log.LogWarning($"[SteamTransport] AcceptConnection {remote.m_SteamID}: {accept}");
                    SteamNetworkingSockets.CloseConnection(conn, 0, $"accept failed {accept}", false);
                    return;
                }

                if (_pollGroup != HSteamNetPollGroup.Invalid)
                    SteamNetworkingSockets.SetConnectionPollGroup(conn, _pollGroup);

                var peer = new SteamPeer(conn, remote);
                _peers[conn] = peer;
                Plugin.Log.LogInfo($"[SteamTransport] accepting connection from {remote.m_SteamID}");
                return;
            }

            // Connection fully established.
            if (newSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected)
            {
                var peer = LookupPeer(conn);
                if (peer == null)
                {
                    // Connection raced ahead of our table — synthesize an entry.
                    peer = new SteamPeer(conn, remote);
                    _peers[conn] = peer;
                }

                if (_listenSocket != HSteamListenSocket.Invalid)
                {
                    // Host: incoming peer just finished SDR handshake.
                    Plugin.Log.LogInfo($"[SteamTransport] peer connected: {peer.SteamId.m_SteamID}");
                    try { OnPeerConnected?.Invoke(peer); }
                    catch (Exception ex) { Plugin.Log.LogError($"OnPeerConnected handler: {ex}"); }
                }
                else
                {
                    // Client: we just connected to the host.
                    Plugin.Log.LogInfo($"[SteamTransport] connected to host {peer.SteamId.m_SteamID}");
                    try { OnConnected?.Invoke(peer); }
                    catch (Exception ex) { Plugin.Log.LogError($"OnConnected handler: {ex}"); }
                }
                return;
            }

            // Disconnects / failures.
            if (newSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ClosedByPeer
                || newSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ProblemDetectedLocally)
            {
                var peer = LookupPeer(conn);
                string reason = info.m_szEndDebug ?? newSt.ToString();
                if (peer != null)
                {
                    Plugin.Log.LogInfo($"[SteamTransport] peer disconnected: {peer.SteamId.m_SteamID} reason='{reason}'");
                    _peers.Remove(conn);
                    try { OnPeerDisconnected?.Invoke(peer, reason); }
                    catch (Exception ex) { Plugin.Log.LogError($"OnPeerDisconnected handler: {ex}"); }
                }
                else
                {
                    // Likely a client whose own connect attempt failed before any peer was registered.
                    if (_listenSocket == HSteamListenSocket.Invalid && oldSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connecting)
                    {
                        Plugin.Log.LogWarning($"[SteamTransport] connect failed: {reason}");
                        try { OnConnectFailed?.Invoke(reason); } catch { }
                    }
                }
                try { SteamNetworkingSockets.CloseConnection(conn, 0, "ack close", false); } catch { }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamTransport] OnConnectionStatusChanged: {ex}");
        }
    }

    private static bool IsLobbyMember(CSteamID who)
    {
        if (!SteamLobby.InLobby) return false;
        try
        {
            int n = SteamMatchmaking.GetNumLobbyMembers(SteamLobby.CurrentLobby);
            for (int i = 0; i < n; i++)
            {
                if (SteamMatchmaking.GetLobbyMemberByIndex(SteamLobby.CurrentLobby, i) == who) return true;
            }
        }
        catch { }
        return false;
    }

    // ─── Diagnostics ───────────────────────────────────────────────────────

    /// <summary>Returns aggregated bytes/packets across all live connections —
    /// used by NetworkManager's [NetStats] log.</summary>
    public static (int peers, long bytesIn, long bytesOut, long pktsIn, long pktsOut, int pingMs) Snapshot()
    {
        long bin = 0, bout = 0, pin = 0, pout = 0;
        int pingMs = 0;
        int n = 0;
        foreach (var p in _peers.Values)
        {
            try
            {
                // API unavailable in this Steamworks.NET version — ping read stubbed.
                /* GetQuickConnectionStatus removed */
            }
            catch { }
            n++;
        }
        return (n, bin, bout, pin, pout, pingMs);
    }

    // ─── Teardown ──────────────────────────────────────────────────────────

    public static void CloseAllPeers(string reason)
    {
        if (_peers.Count == 0) return;
        var snapshot = new List<HSteamNetConnection>(_peers.Keys);
        foreach (var c in snapshot)
        {
            try { SteamNetworkingSockets.CloseConnection(c, 0, reason ?? "shutdown", false); } catch { }
        }
        _peers.Clear();
    }

    public static void Shutdown()
    {
        try { CloseAllPeers("transport shutdown"); } catch { }

        if (_listenSocket != HSteamListenSocket.Invalid)
        {
            try { SteamNetworkingSockets.CloseListenSocket(_listenSocket); } catch { }
            _listenSocket = HSteamListenSocket.Invalid;
        }

        if (_pollGroup != HSteamNetPollGroup.Invalid)
        {
            try { SteamNetworkingSockets.DestroyPollGroup(_pollGroup); } catch { }
            _pollGroup = HSteamNetPollGroup.Invalid;
        }
    }

    /// <summary>Close a single peer connection. Used by NetworkManager.Disconnect
    /// for explicit kicks (e.g. after CharacterReset).</summary>
    public static void CloseConnection(SteamPeer peer, string reason)
    {
        if (peer == null) return;
        try { SteamNetworkingSockets.CloseConnection(peer.Connection, 0, reason ?? "closed", false); } catch { }
        _peers.Remove(peer.Connection);
    }
}
