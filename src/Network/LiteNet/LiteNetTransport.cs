using System;
using System.Collections.Generic;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network.Steam;

namespace SoDCoop.Network.LiteNet;

/// <summary>
/// Direct-IP transport on top of LiteNetLib UDP. Mirrors the public surface
/// of <see cref="SteamTransport"/> so <c>NetworkManager</c> can dispatch
/// either path identically — same events, same Send / Pump / Close shape,
/// same <see cref="SteamPeer"/> peer type. The wire format and the 99-entry
/// PacketType dispatch are unchanged; this class only delivers raw bytes.
///
/// <para>Used as a fallback for Steam Datagram Relay's
/// <c>FindingRoute → ClosedByPeer</c> failure mode (where SDR routing
/// can't establish a path despite both peers having Current relay
/// availability), and for LAN play where neither peer wants Steam in the
/// loop. The host opens a UDP listen socket on a chosen port; clients
/// connect by typing IP + port.</para>
///
/// <para>Caveats:
/// <list type="bullet">
///   <item>Port forwarding is the user's responsibility (or LAN only).</item>
///   <item>UDP is not encrypted — LiteNetLib's <c>ConnectionKey</c> only
///         deters casual tampering, it's not crypto.</item>
///   <item>Friend's IP address is exposed to the host (and vice versa via
///         the connection). Steam SDR avoided this; here it's a trade-off
///         for the simpler routing.</item>
/// </list></para>
/// </summary>
public static class LiteNetTransport
{
    public const int DEFAULT_PORT = 7777;
    private const string CONNECTION_KEY = "SoDCoop_v1";
    private const int DISCONNECT_TIMEOUT_MS = 5000;
    private const int UPDATE_INTERVAL_MS = 15;
    private const int MAX_PEERS = 4;

    /// <summary>Delivered to the consumer once per fully-received message.
    /// Same shape as <see cref="SteamTransport.OnMessage"/>.</summary>
    public delegate void ReceiveHandler(SteamPeer sender, byte[] payload, int length);

    public static event ReceiveHandler OnMessage;

    /// <summary>Host: a remote peer just finished the LiteNetLib handshake.</summary>
    public static event Action<SteamPeer> OnPeerConnected;

    /// <summary>A peer disconnected (timeout / explicit). Carries a human-
    /// readable reason.</summary>
    public static event Action<SteamPeer, string> OnPeerDisconnected;

    /// <summary>Client: our outbound connection just succeeded.</summary>
    public static event Action<SteamPeer> OnConnected;

    /// <summary>Client: outbound connection failed (could not reach host).</summary>
    public static event Action<string> OnConnectFailed;

    private static NetManager           _net;
    private static EventBasedNetListener _listener;
    private static readonly NetDataWriter _connWriter = new();

    /// <summary>Live peers keyed by LiteNetLib NetPeer reference.</summary>
    private static readonly Dictionary<NetPeer, SteamPeer> _peers = new();

    public static bool IsActive => _net != null && _net.IsRunning;

    public static IEnumerable<SteamPeer> Peers => _peers.Values;

    // ─── Lifecycle ─────────────────────────────────────────────────────────

    private static void EnsureNetManager()
    {
        if (_net != null) return;
        _listener = new EventBasedNetListener();
        _listener.ConnectionRequestEvent += OnConnectionRequest;
        _listener.PeerConnectedEvent     += OnPeerConnectedInternal;
        _listener.PeerDisconnectedEvent  += OnPeerDisconnectedInternal;
        _listener.NetworkReceiveEvent    += OnNetworkReceive;
        _listener.NetworkErrorEvent      += OnNetworkError;

        _net = new NetManager(_listener)
        {
            AutoRecycle             = true,
            DisconnectTimeout       = DISCONNECT_TIMEOUT_MS,
            UpdateTime              = UPDATE_INTERVAL_MS,
            IPv6Enabled             = false,
            NatPunchEnabled         = false, // direct IP only — no Steam-style NAT punch here
            EnableStatistics        = true,
            // BetterNetworking-Valheim parity tuning (verbatim from the pre-
            // Steam transport): predictable retransmits + reconnect cadence
            // under 4-player burst load.
            PingInterval               = 1000,
            ReconnectDelay             = 500,
            MaxConnectAttempts         = 10,
            ChannelsCount              = 4,
            UnconnectedMessagesEnabled = false,
        };
    }

    // ─── Host: listen ──────────────────────────────────────────────────────

    public static bool StartListening(int port)
    {
        EnsureNetManager();
        if (_net.IsRunning && _net.LocalPort == port) return true;

        try
        {
            if (!_net.Start(port))
            {
                Plugin.Log.LogError($"[LiteNetTransport] Start({port}) returned false — port in use?");
                return false;
            }
            Plugin.Log.LogInfo($"[LiteNetTransport] listening on UDP port {port}.");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[LiteNetTransport] StartListening: {ex}");
            return false;
        }
    }

    // ─── Client: connect ───────────────────────────────────────────────────

    public static bool ConnectTo(string ip, int port)
    {
        EnsureNetManager();
        if (string.IsNullOrEmpty(ip))
        {
            Plugin.Log.LogError("[LiteNetTransport] ConnectTo: empty IP.");
            return false;
        }

        try
        {
            CloseAllPeers("client reconnect");

            // Client side also needs Start() so the socket is up before
            // Connect. Bind to an ephemeral local port (0).
            if (!_net.IsRunning && !_net.Start())
            {
                Plugin.Log.LogError("[LiteNetTransport] ConnectTo: Start() failed.");
                return false;
            }

            _connWriter.Reset();
            _connWriter.Put(CONNECTION_KEY);
            var peer = _net.Connect(ip, port, _connWriter);
            if (peer == null)
            {
                Plugin.Log.LogError($"[LiteNetTransport] Connect({ip}:{port}) returned null.");
                try { OnConnectFailed?.Invoke("Connect returned null"); } catch { }
                return false;
            }

            // Don't insert into _peers yet — PeerConnectedEvent does that.
            Plugin.Log.LogInfo($"[LiteNetTransport] dialing {ip}:{port}.");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[LiteNetTransport] ConnectTo: {ex}");
            try { OnConnectFailed?.Invoke(ex.Message); } catch { }
            return false;
        }
    }

    // ─── Send ──────────────────────────────────────────────────────────────

    public static bool Send(SteamPeer peer, byte[] payload, int offset, int length, DeliveryMethod delivery)
    {
        if (peer == null || peer.LitePeer == null) return false;
        if (payload == null || length <= 0) return false;
        try
        {
            peer.LitePeer.Send(payload, offset, length, delivery);
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[LiteNetTransport] Send threw: {ex.Message}");
            return false;
        }
    }

    public static bool Send(SteamPeer peer, byte[] payload, DeliveryMethod delivery)
        => Send(peer, payload, 0, payload?.Length ?? 0, delivery);

    // ─── Receive ───────────────────────────────────────────────────────────

    /// <summary>Per-frame pump. <c>NetworkManager.Update()</c> calls this when
    /// the active transport is IP-based.</summary>
    public static void Pump()
    {
        if (_net == null) return;
        try { _net.PollEvents(); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LiteNetTransport] PollEvents: {ex.Message}"); }
    }

    // ─── Listener handlers ────────────────────────────────────────────────

    private static void OnConnectionRequest(ConnectionRequest request)
    {
        try
        {
            if (_peers.Count >= MAX_PEERS)
            {
                Plugin.Log.LogWarning($"[LiteNetTransport] reject {request.RemoteEndPoint} — server full.");
                request.Reject();
                return;
            }
            // Validate connection key — anyone with the wrong key (different
            // mod version, casual prober) gets rejected.
            request.AcceptIfKey(CONNECTION_KEY);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[LiteNetTransport] OnConnectionRequest: {ex}");
            try { request.Reject(); } catch { }
        }
    }

    private static void OnPeerConnectedInternal(NetPeer netPeer)
    {
        try
        {
            var peer = new SteamPeer(netPeer);
            _peers[netPeer] = peer;

            // Distinguish host-side accept from client-side dial completion
            // by looking at whether we have a listen port open (host) or are
            // in dialer-only mode (client).
            // NetManager.IsServer is set by StartHost(port) — but we don't
            // have a clean toggle here. Instead, infer: if we Connect()'d
            // exactly one outbound, this fires for it. The cleaner path is
            // for NetworkManager to set a flag before calling our entry
            // points, but we can also reason from peer count after add.
            // For now, fire OnConnected on client (single peer) and
            // OnPeerConnected on host (multi-peer).
            // Caller side is determined by NetworkManager.IsHost when it
            // dispatches; both handlers exist regardless.
            if (NetworkManager.IsHost)
            {
                Plugin.Log.LogInfo($"[LiteNetTransport] peer connected: {peer.Endpoint}");
                try { OnPeerConnected?.Invoke(peer); }
                catch (Exception ex) { Plugin.Log.LogError($"OnPeerConnected handler: {ex}"); }
            }
            else
            {
                Plugin.Log.LogInfo($"[LiteNetTransport] connected to host: {peer.Endpoint}");
                try { OnConnected?.Invoke(peer); }
                catch (Exception ex) { Plugin.Log.LogError($"OnConnected handler: {ex}"); }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[LiteNetTransport] OnPeerConnectedInternal: {ex}");
        }
    }

    private static void OnPeerDisconnectedInternal(NetPeer netPeer, DisconnectInfo info)
    {
        try
        {
            string reason = info.Reason.ToString();
            if (info.AdditionalData != null && info.AdditionalData.AvailableBytes > 0)
            {
                try { reason += " (" + info.AdditionalData.GetString() + ")"; } catch { }
            }
            if (_peers.TryGetValue(netPeer, out var peer))
            {
                _peers.Remove(netPeer);
                Plugin.Log.LogInfo($"[LiteNetTransport] peer disconnected: {peer.Endpoint} reason='{reason}'");
                try { OnPeerDisconnected?.Invoke(peer, reason); }
                catch (Exception ex) { Plugin.Log.LogError($"OnPeerDisconnected handler: {ex}"); }
            }
            else if (!NetworkManager.IsHost)
            {
                // Client-side connect failed before peer was registered.
                Plugin.Log.LogWarning($"[LiteNetTransport] connect failed: {reason}");
                try { OnConnectFailed?.Invoke(reason); } catch { }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[LiteNetTransport] OnPeerDisconnectedInternal: {ex}");
        }
    }

    private static void OnNetworkReceive(NetPeer netPeer, NetPacketReader reader, byte channel, DeliveryMethod delivery)
    {
        try
        {
            if (!_peers.TryGetValue(netPeer, out var peer)) { reader.Recycle(); return; }
            int len = reader.AvailableBytes;
            if (len <= 0) { reader.Recycle(); return; }
            byte[] buf = new byte[len];
            Buffer.BlockCopy(reader.RawData, reader.Position, buf, 0, len);
            try { OnMessage?.Invoke(peer, buf, len); }
            catch (Exception ex) { Plugin.Log.LogError($"[LiteNetTransport] OnMessage handler threw: {ex}"); }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[LiteNetTransport] OnNetworkReceive: {ex.Message}");
        }
        finally
        {
            try { reader.Recycle(); } catch { }
        }
    }

    private static void OnNetworkError(System.Net.IPEndPoint endpoint, System.Net.Sockets.SocketError error)
    {
        Plugin.Log.LogWarning($"[LiteNetTransport] network error from {endpoint}: {error}");
    }

    // ─── Diagnostics ───────────────────────────────────────────────────────

    public static (int peers, long bytesIn, long bytesOut, long pktsIn, long pktsOut, int pingMs) Snapshot()
    {
        int n = _peers.Count;
        int pingMs = 0;
        long bin = 0, bout = 0, pin = 0, pout = 0;
        try
        {
            if (_net != null && _net.Statistics != null)
            {
                bin  = (long)_net.Statistics.BytesReceived;
                bout = (long)_net.Statistics.BytesSent;
                pin  = (long)_net.Statistics.PacketsReceived;
                pout = (long)_net.Statistics.PacketsSent;
            }
            // Client: report the host's ping as the displayed ping.
            foreach (var p in _peers.Values)
            {
                if (p.LitePeer != null) { pingMs = p.LitePeer.Ping; break; }
            }
        }
        catch { }
        return (n, bin, bout, pin, pout, pingMs);
    }

    // ─── Teardown ──────────────────────────────────────────────────────────

    public static void CloseAllPeers(string reason)
    {
        if (_peers.Count == 0) return;
        var snapshot = new List<NetPeer>(_peers.Keys);
        foreach (var np in snapshot)
        {
            try { np.Disconnect(); } catch { }
        }
        _peers.Clear();
    }

    public static void CloseConnection(SteamPeer peer, string reason)
    {
        if (peer == null || peer.LitePeer == null) return;
        try { peer.LitePeer.Disconnect(); } catch { }
        _peers.Remove(peer.LitePeer);
    }

    public static void Shutdown()
    {
        try { CloseAllPeers("transport shutdown"); } catch { }
        try { _net?.Stop(); } catch { }
        _net = null;
        _listener = null;
    }
}
