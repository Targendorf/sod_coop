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
    /// <summary>Virtual port: u16 both peers agree on. Valheim, Risk of Rain
    /// 2, and most other Steam-P2P-using games use 0. SoD is single-player,
    /// no cross-talk risk. The previous value 4242 was untested folklore —
    /// the field accepts any u16 but Steam relays sanity-check the listen
    /// socket presence per-vport, and a non-default vport on a vanilla SoD
    /// install (with no listener at vport 4242 in the relay's view of this
    /// SteamID) causes the routing pass to fall back to slower paths and
    /// eventually time out at FindingRoute. Match the world.</summary>
    public const int VIRTUAL_PORT = 0;

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

    /// <summary>Captured at plugin init (Unity main thread). Used by
    /// <see cref="OnConnectionStatusChanged"/> and <see cref="Pump"/> to
    /// assert they're not being driven off a worker thread — under IL2CPP
    /// some Steam SDK builds historically dispatched callbacks off the
    /// thread that called RunCallbacks. We funnel via SteamCallbacks.RunCallbacks
    /// which runs from NetworkManager.Update() (Unity main thread), so any
    /// other observed thread id means the SDK invariant we rely on for
    /// non-locked dictionary access has been violated.</summary>
    private static int _mainThreadId;

    /// <summary>Capture the current thread id as the "main thread" baseline
    /// for later assertion logging. Idempotent — last call wins, but in
    /// practice it's invoked exactly once from <see cref="NetworkManager.Initialize"/>
    /// on plugin load.</summary>
    public static void RememberMainThread()
    {
        _mainThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
        Plugin.Log.LogInfo($"[SteamTransport] main thread id remembered: {_mainThreadId}");
    }

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
            // Force the SDR auth-cert request before opening the listen
            // socket. Without an issued cert the relay layer will accept
            // inbound rendezvous packets but can't validate them, leaving
            // the connection stuck in FindingRoute until the 10 s default
            // timeout fires. InitAuthentication is async — by the time the
            // first peer dials in (typically several seconds later) the
            // cert is in hand.
            int authRc = SteamSocketsNative.InitAuthentication();
            Plugin.Log.LogInfo($"[SteamTransport] InitAuthentication kicked off, rc={authRc}");

            // Bypass managed SteamNetworkingSockets.CreateListenSocketP2P /
            // CreatePollGroup — those silently return fake handles under
            // IL2CPP interop. Listen socket "exists" managed-side but Steam
            // runtime never registered it, so inbound P2P never lands. Native
            // P/Invoke goes straight to steam_api64.dll.
            uint hSocket = SteamSocketsNative.CreateListenSocketP2P(VIRTUAL_PORT);
            uint hPoll   = SteamSocketsNative.CreatePollGroup();

            if (hSocket == 0)
            {
                Plugin.Log.LogError("[SteamTransport] CreateListenSocketP2P (native) returned Invalid.");
                _pollGroup = HSteamNetPollGroup.Invalid;
                return false;
            }

            _listenSocket = new HSteamListenSocket(hSocket);
            _pollGroup    = hPoll == 0 ? HSteamNetPollGroup.Invalid : new HSteamNetPollGroup(hPoll);

            Plugin.Log.LogInfo($"[SteamTransport] listening on virtual port {VIRTUAL_PORT} (native, hSocket={hSocket}, hPollGroup={hPoll}).");
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

            // Force the SDR auth-cert request on the joiner side too, before
            // dialing. Same reason as the host: without a cert the relay
            // can't validate routing and FindingRoute times out.
            int authRc = SteamSocketsNative.InitAuthentication();
            Plugin.Log.LogInfo($"[SteamTransport] InitAuthentication (joiner) kicked off, rc={authRc}");

            if (_pollGroup == HSteamNetPollGroup.Invalid)
            {
                uint hPoll = SteamSocketsNative.CreatePollGroup();
                if (hPoll != 0) _pollGroup = new HSteamNetPollGroup(hPoll);
            }

            // Bypass managed ConnectP2P (same IL2CPP wrapper issue as
            // CreateListenSocketP2P — silently returns a fake handle that
            // doesn't actually correspond to a Steam-registered connection).
            uint hConn = SteamSocketsNative.ConnectP2P(hostSteamId.m_SteamID, VIRTUAL_PORT);
            if (hConn == 0)
            {
                Plugin.Log.LogError($"[SteamTransport] ConnectP2P (native) → invalid handle for host {hostSteamId.m_SteamID}");
                try { OnConnectFailed?.Invoke("Steam returned invalid connection handle"); } catch { }
                return false;
            }

            var conn = new HSteamNetConnection(hConn);
            if (_pollGroup != HSteamNetPollGroup.Invalid)
                SteamSocketsNative.SetConnectionPollGroup(hConn, _pollGroup.m_HSteamNetPollGroup);

            var peer = new SteamPeer(conn, hostSteamId);
            _peers[conn] = peer;

            Plugin.Log.LogInfo($"[SteamTransport] dialing host {hostSteamId.m_SteamID} on virtual port {VIRTUAL_PORT} (native, hConn={hConn}).");
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
            int result = SteamSocketsNative.SendMessageToConnection(
                peer.Connection.m_HSteamNetConnection, ptr, (uint)length, flags, out outMsgNumber);

            // Steam EResult: 1 = OK
            if (result != 1)
            {
                Plugin.Log.LogWarning($"[SteamTransport] Send → EResult={result} (peer={peer.DisplayName} len={length})");
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
        if (_mainThreadId != 0 && System.Threading.Thread.CurrentThread.ManagedThreadId != _mainThreadId)
        {
            Plugin.Log.LogError($"[SteamTransport] Pump fired on thread {System.Threading.Thread.CurrentThread.ManagedThreadId}, expected main {_mainThreadId} — driving native receive off-main is unsupported.");
            // Don't bail — log loud, continue. Better to corrupt state visibly than to silently drop the callback.
        }

        if (_pollGroup == HSteamNetPollGroup.Invalid) return;

        // Allocate one unmanaged buffer of IntPtr[RECV_BATCH] that the native
        // ReceiveMessagesOnPollGroup fills in. Reusing it across calls would
        // be marginally faster but per-frame allocation is fine — only
        // RECV_BATCH=64 IntPtrs per frame.
        IntPtr msgPtrsBuf = Marshal.AllocHGlobal(IntPtr.Size * RECV_BATCH);
        try
        {
            int got = SteamSocketsNative.ReceiveMessagesOnPollGroup(
                _pollGroup.m_HSteamNetPollGroup, msgPtrsBuf, RECV_BATCH);
            if (got <= 0) return;

            for (int i = 0; i < got; i++)
            {
                IntPtr msgPtr = Marshal.ReadIntPtr(msgPtrsBuf, i * IntPtr.Size);
                if (msgPtr == IntPtr.Zero) continue;
                try
                {
                    // SteamNetworkingMessage_t native layout (Pack=8, from
                    // steamnetworkingtypes.h):
                    //   offset 0    void* m_pData              (8 B)
                    //   offset 8    int   m_cbSize             (4 B)
                    //   offset 12   HSteamNetConnection m_conn (uint32, 4 B)
                    //   offset 16   SteamNetworkingIdentity m_identityPeer (136 B)
                    //   offset 152  int64 m_nConnUserData
                    //   ... (rest ignored for receive)
                    //
                    // BUG fix: previously we read hConn from offset 16 — that's
                    // the start of m_identityPeer (m_eType = 16 for SteamID).
                    // LookupPeer(new HSteamNetConnection(16)) always returned
                    // null, so every inbound message was silently dropped.
                    // This is why Steam connect succeeded (FindingRoute →
                    // Connected) but the bootstrap handshake never advanced —
                    // host saw the peer, accepted, then never received any
                    // packets from it.
                    IntPtr pData = Marshal.ReadIntPtr(msgPtr, 0);
                    int    cbSize = Marshal.ReadInt32(msgPtr, 8);
                    uint   hConn = (uint)Marshal.ReadInt32(msgPtr, 12);

                    var peer = LookupPeer(new HSteamNetConnection(hConn));
                    if (peer != null && cbSize > 0 && pData != IntPtr.Zero)
                    {
                        byte[] buf = new byte[cbSize];
                        Marshal.Copy(pData, buf, 0, cbSize);
                        try { OnMessage?.Invoke(peer, buf, cbSize); }
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
                    SteamSocketsNative.ReleaseMessage(msgPtr);
                }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SteamTransport] Pump: {ex.GetType().Name}: {ex.Message}");
        }
        finally
        {
            Marshal.FreeHGlobal(msgPtrsBuf);
        }
    }

    private static SteamPeer LookupPeer(HSteamNetConnection conn)
    {
        return _peers.TryGetValue(conn, out var p) ? p : null;
    }

    // ─── Connection-status callback (Steam → us) ───────────────────────────

    /// <summary>
    /// Connection-status callback handler. Takes primitives instead of the
    /// IL2Cpp <c>SteamNetConnectionStatusChangedCallback_t</c> shim — that
    /// type isn't blittable / lacks layout metadata under IL2Cpp interop, so
    /// <see cref="System.Runtime.InteropServices.Marshal.PtrToStructure"/>
    /// can't decode it. Caller (SteamCallbacks) reads the bytes from the raw
    /// pointer and passes the few fields we actually use.
    ///
    /// <para><paramref name="hListenSocket"/> is <c>m_info.m_hListenSocket</c>
    /// — non-zero iff this connection arrived on one of our listen sockets,
    /// i.e. it's INBOUND. Zero/invalid means we created this connection
    /// ourselves via <c>ConnectP2P</c> and it's OUTBOUND. State alone can't
    /// tell us — both inbound-just-arrived and outbound-just-dialled appear
    /// as None→Connecting.</para>
    /// </summary>
    public static void OnConnectionStatusChanged(uint hConn, ulong remoteSteamId64, uint hListenSocket, int oldStateRaw, int newStateRaw, string endDebug)
    {
        if (_mainThreadId != 0 && System.Threading.Thread.CurrentThread.ManagedThreadId != _mainThreadId)
        {
            Plugin.Log.LogError($"[SteamTransport] OnConnectionStatusChanged fired on thread {System.Threading.Thread.CurrentThread.ManagedThreadId}, expected main {_mainThreadId} — Steam SDK threading invariant violated. Subsequent dictionary access may corrupt state.");
            // Don't bail — log loud, continue. Better to corrupt state visibly than to silently drop the callback.
        }

        var conn   = new HSteamNetConnection(hConn);
        var oldSt  = (ESteamNetworkingConnectionState)oldStateRaw;
        var newSt  = (ESteamNetworkingConnectionState)newStateRaw;
        var remote = new CSteamID(remoteSteamId64);
        bool isInbound = hListenSocket != 0;

        // Diagnostic: trace every state transition so we can verify the
        // manual byte decode is producing sane values. Drop once stable.
        try { Plugin.Log.LogInfo($"[SteamTransport] OnConnStatus: conn={hConn} remote={remoteSteamId64} inbound={isInbound} {oldSt}→{newSt}"); } catch { }

        try
        {
            // None→Connecting: connection just appeared. Two cases:
            //   • inbound (m_hListenSocket != 0): a remote dialed our listen
            //     socket — host side, must AcceptConnection.
            //   • outbound (m_hListenSocket == 0): we just called ConnectP2P
            //     ourselves — client side, nothing to do, wait for Connected.
            if (newSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connecting
                && oldSt == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_None)
            {
                if (!isInbound)
                {
                    // Our own outbound dial. Steam reports it; nothing to do.
                    return;
                }
                if (_listenSocket == HSteamListenSocket.Invalid)
                {
                    // We're a client and somehow got an inbound connection
                    // (unexpected — listen socket must already exist for an
                    // inbound to arrive). Close it.
                    SteamSocketsNative.CloseConnection(hConn, 0, "client refused inbound", false);
                    return;
                }

                // Validate: must be a member of our lobby.
                if (!IsLobbyMember(remote))
                {
                    Plugin.Log.LogWarning($"[SteamTransport] reject {remote.m_SteamID} — not a member of lobby {SteamLobby.CurrentLobby.m_SteamID}");
                    SteamSocketsNative.CloseConnection(hConn, 0, "not in lobby", false);
                    return;
                }

                if (_peers.Count >= MAX_PEERS)
                {
                    Plugin.Log.LogWarning($"[SteamTransport] reject {remote.m_SteamID} — server full ({_peers.Count}/{MAX_PEERS})");
                    SteamSocketsNative.CloseConnection(hConn, 0, "server full", false);
                    return;
                }

                int acceptRc = SteamSocketsNative.AcceptConnection(hConn);
                Plugin.Log.LogInfo($"[SteamTransport] AcceptConnection (native) {remote.m_SteamID}: EResult={acceptRc}");
                if (acceptRc != 1)
                {
                    Plugin.Log.LogWarning($"[SteamTransport] AcceptConnection failed for {remote.m_SteamID}: EResult={acceptRc}");
                    SteamSocketsNative.CloseConnection(hConn, 0, $"accept failed {acceptRc}", false);
                    return;
                }

                if (_pollGroup != HSteamNetPollGroup.Invalid)
                    SteamSocketsNative.SetConnectionPollGroup(hConn, _pollGroup.m_HSteamNetPollGroup);

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
                string reason = string.IsNullOrEmpty(endDebug) ? newSt.ToString() : endDebug;
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
                try { SteamSocketsNative.CloseConnection(hConn, 0, "ack close", false); } catch { }
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
            try { SteamSocketsNative.CloseConnection(c.m_HSteamNetConnection, 0, reason ?? "shutdown", false); } catch { }
        }
        _peers.Clear();
    }

    public static void Shutdown()
    {
        try { CloseAllPeers("transport shutdown"); } catch { }

        if (_listenSocket != HSteamListenSocket.Invalid)
        {
            try { SteamSocketsNative.CloseListenSocket(_listenSocket.m_HSteamListenSocket); } catch { }
            _listenSocket = HSteamListenSocket.Invalid;
        }

        if (_pollGroup != HSteamNetPollGroup.Invalid)
        {
            try { SteamSocketsNative.DestroyPollGroup(_pollGroup.m_HSteamNetPollGroup); } catch { }
            _pollGroup = HSteamNetPollGroup.Invalid;
        }
    }

    /// <summary>Close a single peer connection. Used by NetworkManager.Disconnect
    /// for explicit kicks (e.g. after CharacterReset).</summary>
    public static void CloseConnection(SteamPeer peer, string reason)
    {
        if (peer == null) return;
        try { SteamSocketsNative.CloseConnection(peer.Connection.m_HSteamNetConnection, 0, reason ?? "closed", false); } catch { }
        _peers.Remove(peer.Connection);
    }
}
