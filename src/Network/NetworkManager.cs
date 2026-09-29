using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using SoDCoop.Network.Steam;
using SoDCoop.Player;
using SoDCoop.Sync;
using Steamworks;
using UnityEngine;

namespace SoDCoop.Network;

/// <summary>
/// Connection state of the network.
/// </summary>
public enum ConnectionState
{
    Disconnected,
    /// <summary>Lobby creation pending (host) or LobbyEnter pending (client).</summary>
    Connecting,
    Connected,
    Hosting,
    /// <summary>Client lost the connection and is briefly waiting before
    /// surfacing a hard disconnect to the UI. Steam P2P doesn't auto-redial
    /// the way LiteNetLib's reconnect loop did — once the lobby is gone,
    /// the user has to be re-invited.</summary>
    Reconnecting
}

/// <summary>
/// P2P session manager backed by Steam SDR + a friends-only lobby. Replaces
/// the previous LiteNetLib UDP/IP transport — there are no IPs, ports, or
/// join codes any more. Hosts create a lobby + listen socket; friends accept
/// invites via the Steam overlay (which fires <c>GameLobbyJoinRequested_t</c>
/// → auto-join). The 99-entry <see cref="PacketType"/> dispatch and the
/// character/handshake flow are unchanged from the LiteNetLib era — only the
/// transport beneath them has swapped out.
/// </summary>
public static class NetworkManager
{
    #region Constants

    private const int MAX_PLAYERS = 4;

    /// <summary>
    /// Wire-format protocol version. Bumped whenever a packet's layout
    /// changes in an incompatible way (new fields, reordered fields, key
    /// hash collisions resolved by renaming, etc.). Joiner sends this in
    /// the bootstrap <see cref="PacketType.CharacterSubmit"/> packet
    /// immediately after their connection completes; host compares against
    /// its own value and rejects with <see cref="PacketType.CharacterRejected"/>
    /// on mismatch instead of letting silently-misaligned bytes corrupt
    /// the session.
    ///
    /// <para><b>When to bump:</b> any change in
    /// <see cref="Sync.PlayerPositionPacket"/>, <see cref="Zdo.ZdoWire"/>
    /// value type set, packet enum entries, snapshot wire envelope, or
    /// the bootstrap handshake itself. The version is intentionally a
    /// small int so 65 535 future bumps fit in an u16 if we ever decide
    /// to shrink the field.</para>
    /// </summary>
    /// <summary>v1: original bootstrap (version + guid).
    /// v2: bootstrap appends an optional <c>joinerWorldAlreadyLoaded</c> flag
    /// followed by <c>joinerSeed</c> + <c>joinerShareCode</c> when the joiner
    /// is already in a city (Mode 2 — connect with pre-loaded world). If the
    /// flag is false (or absent for an older client), the host falls back to
    /// the legacy auto-generate flow (Mode 1).</summary>
    public const int PROTOCOL_VERSION = 2;

    /// <summary>
    /// Seconds we keep a disconnected player's slot alive waiting for them to
    /// reconnect with the same clientGuid. Covers wifi blips and momentary
    /// route flaps. After this expires the player is finalised: removed
    /// from <see cref="_players"/>, PlayerLeft broadcast.
    /// </summary>
    private const float RECONNECT_GRACE_S = 5f;

    /// <summary>How long the client tolerates a dropped Steam connection
    /// before falling back to a hard disconnect. SDR doesn't support
    /// silent re-dial — the lobby may have been destroyed — so this is just
    /// a short wait so transient blips don't pop the user back to the menu.</summary>
    private const float RECONNECT_TIMEOUT_S = 8f;

    #endregion

    #region Properties

    public static bool IsHost { get; private set; }

    public static bool IsConnected => State == ConnectionState.Connected || State == ConnectionState.Hosting;

    public static ConnectionState State { get; private set; } = ConnectionState.Disconnected;

    public static int LocalPlayerId { get; private set; } = -1;

    public static string LocalPlayerName { get; set; } = "Player";
    public static string LocalFirstName { get; private set; } = "";
    public static string LocalSurname { get; private set; } = "";

    public static event Action<string, string, string> OnCharacterCreationRequired;
    public static event Action<string> OnCharacterRejected;

    /// <summary>Raised on the client when the Steam connection drops. Carries
    /// the Steam-supplied debug string. UI consumers should show a
    /// "reconnecting…" banner; world / sync state stays alive briefly to
    /// hide one-frame blips, then transitions to OnDisconnected.</summary>
    public static event Action<string> OnConnectionLost;

    /// <summary>Raised after a transient drop is followed by a successful
    /// reconnect to the same host. Currently never fires under Steam P2P
    /// (no auto-redial), kept for API parity in case we add lobby-mediated
    /// reconnect later.</summary>
    public static event Action OnReconnected;

    /// <summary>The host peer (client side) or null on host.</summary>
    public static SteamPeer HostPeer { get; private set; }

    public static IReadOnlyList<SteamPeer> Clients => _clients;
    public static IReadOnlyDictionary<int, PlayerNetInfo> Players => _players;

    /// <summary>Latency to host in ms (client) or 0 (host). Sourced from
    /// SteamNetworkingSockets.GetQuickConnectionStatus.</summary>
    public static int Ping
    {
        get
        {
            if (HostPeer == null) return 0;
            try
            {
                // GetQuickConnectionStatus unavailable in this Steamworks.NET version.
                    return 0; /* old: return s.m_nPing; */
            }
            catch { }
            return 0;
        }
    }

    public static bool HasPeers
    {
        get
        {
            if (IsHost) return _clients.Count > 0;
            return HostPeer != null && State == ConnectionState.Connected;
        }
    }

    /// <summary>Steam lobby / host identifiers cached for the SessionStore
    /// "rejoin recent" affordance and the UI to display "Hosted by …".</summary>
    public static CSteamID LastHostSteamId { get; private set; }
    public static CSteamID LastLobbyId     { get; private set; }
    public static string   LastHostName    { get; private set; } = "";

    public static string LastDisconnectReason { get; private set; } = "";

    /// <summary>HumanID of the citizen the host has chosen as the local
    /// player's twin in its world. Reads 0 pre-character-assignment.
    /// Used by Zdo resolvers to mirror authoritative twin-vitals / crouch /
    /// KO state onto Player.Instance so the local HUD matches the host's
    /// truth (instead of drifting independently from the local Player tick).</summary>
    public static int MyTwinHumanID
    {
        get
        {
            if (LocalPlayerId < 0) return 0;
            return _players.TryGetValue(LocalPlayerId, out var info) ? info.TwinHumanID : 0;
        }
    }

    #endregion

    #region Events

    public static event Action OnConnected;
    public static event Action<string> OnDisconnected;
    public static event Action<int, string> OnPlayerJoined;
    public static event Action<int, string> OnPlayerLeft;
    public static event Action<PacketType, NetDataReader, int> OnPacketReceived;

    #endregion

    #region Private Fields

    private static readonly List<SteamPeer> _clients = new();
    private static readonly Dictionary<int, PlayerNetInfo> _players = new();
    /// <summary>Reverse map of <see cref="_players"/> keyed by peer reference.
    /// Updated alongside every <c>info.Peer = …</c> mutation so
    /// <see cref="GetPlayerIdByPeer"/> can resolve in O(1) instead of an
    /// O(N_players) linear scan on every inbound packet / per-peer flush.
    /// SteamPeer has no custom Equals override → identity-based hashing,
    /// which is what we want (distinct peer references map separately).</summary>
    private static readonly Dictionary<SteamPeer, int> _peerToPlayerId = new();
    /// <summary>Used by handlers to BUILD payloads (handshake/joined/left).</summary>
    private static readonly NetDataWriter _writer = new();
    /// <summary>Used inside SendTo/SendToAll/SendToHost to WRAP payload with type-prefix.
    /// Must be distinct from <see cref="_writer"/> so callers can pass _writer as data
    /// without aliasing.</summary>
    private static readonly NetDataWriter _sendWrapper = new();
    private static int _nextPlayerId = 1;

    /// <summary>Set by <see cref="Disconnect"/> so the OnPeerDisconnected handler
    /// distinguishes a user-initiated tear-down from a transient drop.</summary>
    private static bool _userInitiatedDisconnect;
    private static float _reconnectStartedAt;
    public static float ReconnectingSeconds => State == ConnectionState.Reconnecting
        ? Mathf.Max(0f, Time.unscaledTime - _reconnectStartedAt)
        : 0f;
    public static float ReconnectingTimeoutS => RECONNECT_TIMEOUT_S;

    #endregion

    #region Initialization

    public static void Initialize()
    {
        Plugin.Log.LogInfo("NetworkManager initializing...");

        // Capture the Unity main-thread id so SteamTransport can assert
        // that its Steam-callback / Pump entry points aren't being driven
        // off a worker thread (some IL2CPP SDK builds have historically
        // dispatched callbacks off-main).
        SteamTransport.RememberMainThread();

        // Hook BOTH transports' callbacks. Both deliver the same shape
        // (SteamPeer-wrapped events) so handlers don't care which path
        // fired. The active transport is chosen at host/connect time.
        SteamCallbacks.Initialize();
        SteamTransport.OnPeerConnected         += HandleTransportPeerConnected;
        SteamTransport.OnPeerDisconnected      += HandleTransportPeerDisconnected;
        SteamTransport.OnConnected             += HandleTransportClientConnected;
        SteamTransport.OnConnectFailed         += HandleTransportConnectFailed;
        SteamTransport.OnMessage               += HandleTransportMessage;

        LiteNet.LiteNetTransport.OnPeerConnected     += HandleTransportPeerConnected;
        LiteNet.LiteNetTransport.OnPeerDisconnected  += HandleTransportPeerDisconnected;
        LiteNet.LiteNetTransport.OnConnected         += HandleTransportClientConnected;
        LiteNet.LiteNetTransport.OnConnectFailed     += HandleTransportConnectFailed;
        LiteNet.LiteNetTransport.OnMessage           += HandleTransportMessage;

        Plugin.Log.LogInfo("NetworkManager initialized.");
    }

    public static void Shutdown()
    {
        Disconnect();
        SteamTransport.OnPeerConnected         -= HandleTransportPeerConnected;
        SteamTransport.OnPeerDisconnected      -= HandleTransportPeerDisconnected;
        SteamTransport.OnConnected             -= HandleTransportClientConnected;
        SteamTransport.OnConnectFailed         -= HandleTransportConnectFailed;
        SteamTransport.OnMessage               -= HandleTransportMessage;
        SteamTransport.Shutdown();

        LiteNet.LiteNetTransport.OnPeerConnected     -= HandleTransportPeerConnected;
        LiteNet.LiteNetTransport.OnPeerDisconnected  -= HandleTransportPeerDisconnected;
        LiteNet.LiteNetTransport.OnConnected         -= HandleTransportClientConnected;
        LiteNet.LiteNetTransport.OnConnectFailed     -= HandleTransportConnectFailed;
        LiteNet.LiteNetTransport.OnMessage           -= HandleTransportMessage;
        LiteNet.LiteNetTransport.Shutdown();

        Plugin.Log.LogInfo("NetworkManager shutdown.");
    }

    #endregion

    #region Host/Connect/Disconnect

    /// <summary>
    /// Begin hosting a session. Creates a friends-only Steam lobby; once
    /// Steam confirms it, <see cref="OnSteamLobbyHostReady"/> finishes the
    /// host-side bring-up. Returns true if the request was issued — actual
    /// "ready" arrives via <see cref="OnConnected"/>.
    /// </summary>
    /// <summary>
    /// Active network transport kind. Set when the user clicks Host or Join;
    /// drives <see cref="Update"/>'s pump dispatch and the per-peer Send
    /// helper. <c>None</c> means we're disconnected and no transport is
    /// active.
    /// </summary>
    public enum TransportKind { None, Steam, IP }
    public static TransportKind ActiveTransport { get; private set; } = TransportKind.None;

    /// <summary>Per-peer send dispatch. Routes by what kind of peer this is
    /// (Steam connection vs LiteNetLib peer). The 99-entry packet-type
    /// dispatch and wire format are unchanged across transports.</summary>
    private static bool TransportSend(SteamPeer peer, byte[] data, int offset, int length, DeliveryMethod delivery)
    {
        if (peer == null) return false;
        return peer.LitePeer != null
            ? LiteNet.LiteNetTransport.Send(peer, data, offset, length, delivery)
            : SteamTransport.Send(peer, data, offset, length, delivery);
    }

    private static void TransportCloseConnection(SteamPeer peer, string reason)
    {
        if (peer == null) return;
        if (peer.LitePeer != null) LiteNet.LiteNetTransport.CloseConnection(peer, reason);
        else                       SteamTransport.CloseConnection(peer, reason);
    }

    /// <summary>For the IP transport: the port the host is listening on, or
    /// the port the client connected to. Display-only.</summary>
    public static int LocalPort { get; private set; }
    public static string LastHostIp { get; private set; } = "";
    public static int LastHostPort { get; private set; }

    public static bool StartHost()
    {
        if (IsConnected || State == ConnectionState.Connecting)
        {
            Plugin.Log.LogWarning("Already connected. Disconnect first.");
            return false;
        }

        // World must be loaded before hosting. SoD's city-data, citizen
        // roster, Player.Instance — all the things the ZDO snapshot, the
        // share-code, and the twin assignment depend on — only exist once
        // a save is loaded or a new city generated. Hosting from the main
        // menu would leave the host with no world to replicate; the first
        // joining client would hit null CityData and fail the handshake.
        // The HostPanel UI already disables the Start button when
        // !IsWorldReady, but this is the authoritative guard for any other
        // entry point (Steam invite auto-accept, future dedicated-server
        // path, etc.).
        if (!SoDCoop.Sync.WorldReadyGate.IsWorldReady)
        {
            Plugin.Log.LogWarning("[NetworkManager] StartHost rejected: world not loaded yet. Load or generate a city first.");
            return false;
        }

        // Plugin may have loaded before SoD's SteamAPIController; retry
        // initialization here. Idempotent — no-op if already hooked.
        SteamCallbacks.Initialize();
        if (!SteamCallbacks.IsInitialized)
        {
            Plugin.Log.LogError("[NetworkManager] StartHost: Steam not initialized — is the game running through Steam?");
            return false;
        }

        IsHost = true;
        State = ConnectionState.Connecting;
        ActiveTransport = TransportKind.Steam;

        // Save-Transfer hint: if the host has never saved this session, the
        // joining client will fall back to share-code (Mode 1) which can
        // diverge. Surface this proactively so the host knows to press Save
        // once before friends join. (We can't auto-capture here because the
        // SOD.Common SaveGame API is async + main-thread-bound; the existing
        // OnAfterSave hook captures HostSavePath on the next manual save.)
        if (string.IsNullOrEmpty(SoDCoop.Sync.SaveTransfer.HostSavePath))
        {
            Plugin.Log.LogWarning(
                "[NetworkManager] Save-Transfer: host has no save file yet. Save your game once " +
                "(Esc → Save) so joining clients get an identical world via Save-Transfer instead of " +
                "the share-code path (which can diverge).");
        }

        SteamLobby.CreateLobbyAsync();
        return true;
    }

    /// <summary>Start hosting on a UDP port via LiteNetLib. Alternative to
    /// <see cref="StartHost"/> for situations where Steam SDR routing fails
    /// (route-finding timeout) or LAN-only sessions.</summary>
    public static bool StartHostIP(int port)
    {
        if (IsConnected || State == ConnectionState.Connecting)
        {
            Plugin.Log.LogWarning("Already connected. Disconnect first.");
            return false;
        }

        // Same world-ready guard as StartHost — see comment there. Hosting
        // from the main menu produces a lobby with no city to replicate.
        if (!SoDCoop.Sync.WorldReadyGate.IsWorldReady)
        {
            Plugin.Log.LogWarning("[NetworkManager] StartHostIP rejected: world not loaded yet. Load or generate a city first.");
            return false;
        }

        IsHost = true;
        State = ConnectionState.Connecting;
        ActiveTransport = TransportKind.IP;

        if (!LiteNet.LiteNetTransport.StartListening(port))
        {
            IsHost = false;
            State = ConnectionState.Disconnected;
            ActiveTransport = TransportKind.None;
            Plugin.Log.LogError($"[NetworkManager] StartHostIP({port}) — listen failed.");
            return false;
        }

        // No async lobby step for direct IP — we go straight to "Hosting".
        LocalPort = port;
        State = ConnectionState.Hosting;
        LocalPlayerId = 0;

        var (hostFirst, hostSur) = CharacterStore.ReadHostCharacter();
        if (string.IsNullOrEmpty(hostFirst) && string.IsNullOrEmpty(hostSur))
        {
            hostFirst = "Host";
            hostSur = "";
        }
        LocalFirstName = hostFirst;
        LocalSurname = hostSur;
        LocalPlayerName = string.IsNullOrEmpty(hostSur) ? hostFirst : $"{hostFirst} {hostSur}";

        int hostTwin = 0;
        try { hostTwin = global::Player.Instance?.humanID ?? 0; } catch { }
        // Diagnostic: clients resolve the host's body through this id
        // (RemotePlayer.TryResolveTwin). When it is 0 — or points at something
        // absent from citizenDictionary — the host falls back to the stand-in
        // clone on every client, which renders fine but is invisible to those
        // clients' game AI. The 2026-07-30 playtest hit exactly that and the
        // log could not say which of the two it was.
        try
        {
            bool inRoster = false;
            var cd = global::CityData.Instance?.citizenDictionary;
            if (cd != null && hostTwin > 0) inRoster = cd.TryGetValue(hostTwin, out var _);
            Plugin.Log.LogInfo($"[NetworkManager] host twin humanID={hostTwin} inCitizenDictionary={inRoster}");
        }
        catch { }
        _players[LocalPlayerId] = new PlayerNetInfo
        {
            PlayerId = LocalPlayerId,
            PlayerName = LocalPlayerName,
            FirstName = LocalFirstName,
            Surname = LocalSurname,
            IsHost = true,
            TwinHumanID = hostTwin,
            CharacterAssigned = true,
        };
        try { TwinManager.ReapplyAll(CharacterStore.CurrentSeed()); }
        catch (Exception ex) { Plugin.Log.LogWarning($"TwinManager.ReapplyAll: {ex.Message}"); }

        Plugin.Log.LogInfo($"Hosting via direct IP on port {port}. Friends connect to your-public-ip:{port}.");
        OnConnected?.Invoke();
        return true;
    }

    /// <summary>Connect to a host by IP+port via LiteNetLib. Alternative to
    /// <see cref="Connect(CSteamID)"/>.</summary>
    public static bool ConnectIP(string ip, int port)
    {
        if (IsConnected || State == ConnectionState.Connecting)
        {
            Plugin.Log.LogWarning("Already connected. Disconnect first.");
            return false;
        }

        IsHost = false;
        State = ConnectionState.Connecting;
        ActiveTransport = TransportKind.IP;
        LocalFirstName = "";
        LocalSurname = "";
        LocalPlayerName = "Player";
        LastHostIp = ip ?? "";
        LastHostPort = port;
        _userInitiatedDisconnect = false;

        if (!LiteNet.LiteNetTransport.ConnectTo(ip, port))
        {
            State = ConnectionState.Disconnected;
            ActiveTransport = TransportKind.None;
            OnDisconnected?.Invoke("Failed to dial host");
            return false;
        }

        return true;
    }

    /// <summary>
    /// Connect to a host by their Steam lobby ID. Auto-invoked by the Steam
    /// overlay's "Join Game" path; UI also calls it from the Friends button
    /// once the user picks an inviter.
    /// </summary>
    public static bool Connect(CSteamID lobbyId)
    {
        if (IsConnected || State == ConnectionState.Connecting)
        {
            Plugin.Log.LogWarning("Already connected. Disconnect first.");
            return false;
        }

        SteamCallbacks.Initialize();
        if (!SteamCallbacks.IsInitialized)
        {
            Plugin.Log.LogError("[NetworkManager] Connect: Steam not initialized.");
            return false;
        }

        IsHost = false;
        State = ConnectionState.Connecting;
        LocalFirstName = "";
        LocalSurname = "";
        LocalPlayerName = "Player";

        SteamLobby.JoinLobby(lobbyId);
        return true;
    }

    public static void Disconnect()
    {
        if (!IsConnected && State != ConnectionState.Connecting && State != ConnectionState.Reconnecting) return;

        Plugin.Log.LogInfo("Disconnecting...");

        _userInitiatedDisconnect = true;

        if (ActiveTransport == TransportKind.IP)
        {
            LiteNet.LiteNetTransport.CloseAllPeers("user disconnect");
            // No lobby for IP transport.
        }
        else
        {
            SteamTransport.CloseAllPeers("user disconnect");
            SteamLobby.LeaveLobby();
        }

        _clients.Clear();
        _players.Clear();
        _peerToPlayerId.Clear();

        IsHost = false;
        State = ConnectionState.Disconnected;
        ActiveTransport = TransportKind.None;
        LocalPlayerId = -1;
        HostPeer = null;
        LastHostSteamId = CSteamID.Nil;
        LastLobbyId = CSteamID.Nil;

        OnDisconnected?.Invoke("User disconnected");
    }

    #endregion

    #region SteamLobby callback shims

    /// <summary>Called by <see cref="SteamLobby"/> after the host's lobby is
    /// successfully created. Spins up the listen socket and finishes
    /// host-side bring-up.</summary>
    internal static void OnSteamLobbyHostReady()
    {
        if (!IsHost) return;

        if (!SteamTransport.StartListening())
        {
            Plugin.Log.LogError("[NetworkManager] Listen socket creation failed — aborting host.");
            Disconnect();
            return;
        }

        State = ConnectionState.Hosting;
        LocalPlayerId = 0;

        var (hostFirst, hostSur) = CharacterStore.ReadHostCharacter();
        if (string.IsNullOrEmpty(hostFirst) && string.IsNullOrEmpty(hostSur))
        {
            hostFirst = "Host";
            hostSur = "";
            Plugin.Log.LogWarning("[NetworkManager] Game.Instance has no player name yet — using fallback 'Host'.");
        }
        LocalFirstName = hostFirst;
        LocalSurname = hostSur;
        LocalPlayerName = string.IsNullOrEmpty(hostSur) ? hostFirst : $"{hostFirst} {hostSur}";

        // Host's "twin" IS the host's own player citizen — Player.Instance.humanID
        // (best-effort; Player.Instance may briefly be null on first frame
        // post-load, in which case TwinHumanID stays 0 and the next handshake
        // resend would carry it). Stored so clients see host's TwinHumanID
        // alongside everyone else's via the standard packet path.
        int hostTwin = 0;
        try { hostTwin = global::Player.Instance?.humanID ?? 0; } catch { }
        // Diagnostic: clients resolve the host's body through this id
        // (RemotePlayer.TryResolveTwin). When it is 0 — or points at something
        // absent from citizenDictionary — the host falls back to the stand-in
        // clone on every client, which renders fine but is invisible to those
        // clients' game AI. The 2026-07-30 playtest hit exactly that and the
        // log could not say which of the two it was.
        try
        {
            bool inRoster = false;
            var cd = global::CityData.Instance?.citizenDictionary;
            if (cd != null && hostTwin > 0) inRoster = cd.TryGetValue(hostTwin, out var _);
            Plugin.Log.LogInfo($"[NetworkManager] host twin humanID={hostTwin} inCitizenDictionary={inRoster}");
        }
        catch { }

        _players[LocalPlayerId] = new PlayerNetInfo
        {
            PlayerId = LocalPlayerId,
            PlayerName = LocalPlayerName,
            FirstName = LocalFirstName,
            Surname = LocalSurname,
            IsHost = true,
            TwinHumanID = hostTwin,
            CharacterAssigned = true,
        };

        try { TwinManager.ReapplyAll(CharacterStore.CurrentSeed()); }
        catch (Exception ex) { Plugin.Log.LogWarning($"TwinManager.ReapplyAll: {ex.Message}"); }

        LastLobbyId = SteamLobby.CurrentLobby;
        LastHostSteamId = SteamLobby.HostSteamId;
        LastHostName = LocalPlayerName;

        Plugin.Log.LogInfo($"Hosting via Steam (lobby={LastLobbyId.m_SteamID}). Waiting for players...");
        OnConnected?.Invoke();
    }

    internal static void OnSteamLobbyCreateFailed(string reason)
    {
        Plugin.Log.LogError($"[NetworkManager] hosting aborted: {reason}");
        IsHost = false;
        State = ConnectionState.Disconnected;
        LastDisconnectReason = reason;
        OnDisconnected?.Invoke($"Host failed: {reason}");
    }

    /// <summary>Called by <see cref="SteamLobby"/> after the client
    /// successfully entered a lobby. Fires the actual SteamNetworkingSockets
    /// connect to the host.</summary>
    internal static void OnSteamLobbyJoined(CSteamID lobbyId, CSteamID hostId, string hostName)
    {
        if (IsHost) return;

        LastLobbyId = lobbyId;
        LastHostSteamId = hostId;
        LastHostName = hostName ?? "";
        _userInitiatedDisconnect = false;

        if (!SteamTransport.ConnectTo(hostId))
        {
            State = ConnectionState.Disconnected;
            OnDisconnected?.Invoke("Failed to dial host");
        }
    }

    #endregion

    #region Send Methods

    public static void SendToAll(PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (!IsConnected) return;
        if (data == _sendWrapper)
        {
            Plugin.Log.LogError("[NetworkManager.SendToAll] caller passed _sendWrapper as data — would alias-corrupt. Aborting.");
            return;
        }

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);

        if (IsHost)
        {
            for (int i = 0; i < _clients.Count; i++)
            {
                TransportSend(_clients[i], _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
            }
        }
        else if (HostPeer != null)
        {
            TransportSend(HostPeer, _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
        }
    }

    /// <summary>Send one framed packet to a single peer.
    ///
    /// <para><b>Returns true iff the transport accepted the message into its
    /// outgoing queue.</b> A false return is NOT cosmetic: Steam rejects sends
    /// once the per-connection send buffer (2 MB, see
    /// <c>SteamSocketsNative</c>) is saturated, and the message is then
    /// dropped outright — there is no transport-level retry. Callers that
    /// stream a payload across frames (<c>ZdoMan.PumpPendingSnapshotSends</c>,
    /// <c>SaveTransfer.PumpPendingTransfers</c>) MUST check this and hold
    /// their cursor so the rejected slice is re-sent next frame; advancing
    /// blindly punches a permanent hole in the stream, which for a snapshot
    /// means the joiner's reassembly never completes and for a save transfer
    /// means a SHA-256 mismatch at the end.</para></summary>
    public static bool SendTo(SteamPeer peer, PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (peer == null) return false;
        if (data == _sendWrapper)
        {
            Plugin.Log.LogError("[NetworkManager.SendTo] caller passed _sendWrapper as data — would alias-corrupt. Aborting.");
            return false;
        }

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);
        return TransportSend(peer, _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
    }

    public static void SendToHost(PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (IsHost || HostPeer == null) return;
        if (data == _sendWrapper)
        {
            Plugin.Log.LogError("[NetworkManager.SendToHost] caller passed _sendWrapper as data — would alias-corrupt. Aborting.");
            return;
        }

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);
        TransportSend(HostPeer, _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
    }

    #endregion

    #region Update

    /// <summary>Last wall-clock time we tried to initialize Steam callbacks.
    /// If the plugin loaded before SoD's SteamAPIController init'd Steam,
    /// the first attempt fails and we re-try once per second so friend
    /// invites (GameLobbyJoinRequested) start firing as soon as possible.</summary>
    private static float _nextSteamInitRetryAt;

    public static void Update()
    {
        if (!SteamCallbacks.IsInitialized)
        {
            float t = Time.unscaledTime;
            if (t >= _nextSteamInitRetryAt)
            {
                _nextSteamInitRetryAt = t + 1f;
                SteamCallbacks.Initialize();
            }
        }

        SteamCallbacks.RunCallbacks();
        if (ActiveTransport == TransportKind.IP) LiteNet.LiteNetTransport.Pump();
        else                                     SteamTransport.Pump();

        if (IsHost) FinalisePendingDisconnects();
        else if (State == ConnectionState.Reconnecting) TickReconnect();
        TickStatsLog();
    }

    private const float STATS_LOG_INTERVAL_S = 30f;
    private static float _nextStatsLogAt;

    private static void TickStatsLog()
    {
        if (!IsConnected) return;
        float now = Time.unscaledTime;
        if (now < _nextStatsLogAt) return;
        _nextStatsLogAt = now + STATS_LOG_INTERVAL_S;

        try
        {
            var snap = ActiveTransport == TransportKind.IP
                ? LiteNet.LiteNetTransport.Snapshot()
                : SteamTransport.Snapshot();
            int peers = IsHost ? _clients.Count : (HostPeer != null ? 1 : 0);
            string label = ActiveTransport == TransportKind.IP ? "ip" : "steam";
            Plugin.Log.LogInfo(
                $"[NetStats] peers={peers} ({label}) ping={snap.pingMs}ms");
        }
        catch { }
    }

    private static void TickReconnect()
    {
        float now = Time.unscaledTime;

        // Steam SDR doesn't support silent re-dial — once the connection's
        // dead, the lobby may also be gone. Wait a short grace and then
        // surface a hard disconnect to the UI.
        if (now - _reconnectStartedAt >= RECONNECT_TIMEOUT_S)
        {
            string final = string.IsNullOrEmpty(LastDisconnectReason)
                ? "Connection lost"
                : $"Connection lost ({LastDisconnectReason})";
            Plugin.Log.LogWarning($"[NetworkManager] reconnect window expired — surfacing disconnect: {final}");
            State = ConnectionState.Disconnected;
            HostPeer = null;
            _players.Clear();
            _peerToPlayerId.Clear();
            LastHostSteamId = CSteamID.Nil;
            OnDisconnected?.Invoke(final);
        }
    }

    private static void FinalisePendingDisconnects()
    {
        if (_players.Count == 0) return;
        float now = Time.unscaledTime;

        List<int> toRemove = null;
        foreach (var kvp in _players)
        {
            var p = kvp.Value;
            if (p == null || !p.IsAwaitingReconnect) continue;
            if (now - p.DisconnectedAt < RECONNECT_GRACE_S) continue;
            (toRemove ??= new List<int>()).Add(kvp.Key);
        }
        if (toRemove == null) return;

        foreach (var id in toRemove)
        {
            if (!_players.TryGetValue(id, out var info)) continue;
            string name = info.PlayerName;
            _players.Remove(id);

            _writer.Reset();
            _writer.Put(id);
            for (int i = 0; i < _clients.Count; i++)
            {
                SendTo(_clients[i], PacketType.PlayerLeft, _writer);
            }
            Plugin.Log.LogInfo($"Player '{name}' (ID: {id}) reconnect-grace expired — finalising disconnect.");
            // Drop ZdoMan's per-peer catch-up state (in-range and pending-
            // resend HashSets) so they don't leak across long sessions.
            try { SoDCoop.Zdo.ZdoMan.OnPeerDisconnectedForCatchup(id); } catch { }
            OnPlayerLeft?.Invoke(id, name);
        }
    }

    #endregion

    #region Transport handlers

    private static void HandleTransportPeerConnected(SteamPeer peer)
    {
        if (!IsHost)
        {
            // Defensive — listen socket only exists on host.
            return;
        }

        if (_clients.Count >= MAX_PLAYERS - 1)
        {
            Plugin.Log.LogWarning($"[NetworkManager] reject {peer.DisplayName} — server full.");
            TransportCloseConnection(peer, "server full");
            return;
        }

        // Reserve a slot but mark not-yet-assigned so we don't broadcast a
        // half-formed peer to others until we know their identity. The
        // client auto-ships its clientGuid in the first CharacterSubmit
        // packet (see HandleTransportClientConnected on the client side).
        int playerId = _nextPlayerId++;
        _players[playerId] = new PlayerNetInfo
        {
            PlayerId = playerId,
            PlayerName = $"Player {playerId}",
            Peer = peer,
            IsHost = false,
            ClientGuid = "",
            CharacterAssigned = false,
        };
        _peerToPlayerId[peer] = playerId;
        Plugin.Log.LogInfo($"[NetworkManager] peer {peer.SteamId.m_SteamID} connected — slot {playerId} reserved, awaiting bootstrap.");
    }

    private static void HandleTransportPeerDisconnected(SteamPeer peer, string reason)
    {
        if (!IsHost)
        {
            // Client: the host connection dropped. Surface a brief
            // Reconnecting window so the world / sync state isn't ripped
            // out under one-frame blips, then fall through to a hard
            // disconnect via TickReconnect after RECONNECT_TIMEOUT_S. SDR
            // doesn't auto-redial — if the lobby's gone, the user has to
            // accept a fresh invite.
            LastDisconnectReason = reason ?? "";

            if (_userInitiatedDisconnect)
            {
                State = ConnectionState.Disconnected;
                HostPeer = null;
                _players.Clear();
                _peerToPlayerId.Clear();
                _userInitiatedDisconnect = false;
                Plugin.Log.LogInfo($"Disconnected from host: {reason}");
                OnDisconnected?.Invoke(reason ?? "user disconnected");
                return;
            }

            State = ConnectionState.Reconnecting;
            HostPeer = null;
            _reconnectStartedAt = Time.unscaledTime;
            Plugin.Log.LogWarning($"[NetworkManager] connection lost ({reason}) — waiting up to {RECONNECT_TIMEOUT_S}s before surfacing disconnect.");
            try { OnConnectionLost?.Invoke(reason ?? ""); } catch { }
            return;
        }

        // Host: a client connection died. Strip from the broadcast list.
        _clients.Remove(peer);

        int playerId = GetPlayerIdByPeer(peer);
        PlayerNetInfo info = null;
        if (playerId >= 0) _players.TryGetValue(playerId, out info);

        if (playerId < 0 || info == null)
        {
            // Defensive: keep the reverse map free of dead references even
            // if the slot is gone (shouldn't happen, but cheap insurance).
            _peerToPlayerId.Remove(peer);
            return;
        }

        if (!info.CharacterAssigned)
        {
            _peerToPlayerId.Remove(peer);
            _players.Remove(playerId);
            Plugin.Log.LogInfo($"Pending peer (ID: {playerId}) gave up before character creation: {reason}");
            return;
        }

        // Remove the peer→id mapping BEFORE nullifying info.Peer so the
        // reverse map never holds a stale reference to a closed peer.
        _peerToPlayerId.Remove(peer);
        info.DisconnectedAt = Time.unscaledTime;
        info.Peer = null;
        Plugin.Log.LogInfo($"Player '{info.PlayerName}' (ID: {playerId}) disconnected: {reason} — awaiting reconnect for {RECONNECT_GRACE_S}s.");
    }

    /// <summary>Client-side: the SteamNetworkingSockets connect succeeded.
    /// Now ship our clientGuid so the host can resolve our identity.</summary>
    private static void HandleTransportClientConnected(SteamPeer peer)
    {
        if (IsHost) return;

        bool wasReconnecting = State == ConnectionState.Reconnecting;
        State = ConnectionState.Connected;
        HostPeer = peer;

        // Ship clientGuid as the first packet — host's Handshake handler
        // looks for the GUID on the inbound connection-data exchange.
        // Prepend PROTOCOL_VERSION so host can hard-reject mismatched
        // builds before any state-bearing packet starts flowing. Older
        // hosts (no version field) interpret our int as the start of a
        // u16-prefixed string, get garbage GUID, and reject via the
        // existing "missing client GUID" path — same outcome from both
        // ends regardless of which side was upgraded.
        _writer.Reset();
        _writer.Put(PROTOCOL_VERSION);
        _writer.Put(CharacterIdentity.ClientGuid);

        // Mode 2 (connect-with-pre-loaded-world): if the joiner is already
        // in a city when they hit Connect, advertise our seed + share-code
        // so the host can short-circuit the auto-generate flow. If the
        // seeds match the host accepts and skips WorldDescriptor + the
        // 60s loading screen + the tutorial replay; if they mismatch the
        // host rejects with a guidance message. Older hosts (PROTOCOL_VERSION
        // = 1) reject us at the version check before ever touching these
        // bytes, so the trailing fields are safe to always include.
        bool joinerWorldAlreadyLoaded = false;
        string joinerSeed = "";
        string joinerShareCode = "";
        try
        {
            if (SoDCoop.Sync.WorldReadyGate.IsWorldReady)
            {
                var city = global::CityData.Instance;
                if (city != null && !string.IsNullOrEmpty(city.seed))
                {
                    joinerSeed = city.seed ?? "";
                    int sizeX = (int)city.citySize.x;
                    int sizeY = (int)city.citySize.y;
                    string cityName = city.cityName ?? "";
                    string version = !string.IsNullOrEmpty(city.cityBuiltWith)
                        ? city.cityBuiltWith
                        : UnityEngine.Application.version;
                    try
                    {
                        var tb = global::Toolbox.Instance;
                        if (tb != null)
                            joinerShareCode = tb.GetShareCode(cityName, sizeX, sizeY, version, joinerSeed) ?? "";
                    }
                    catch (Exception sx)
                    {
                        Plugin.Log.LogWarning($"[NetworkManager] joiner GetShareCode threw: {sx.Message}");
                    }
                    joinerWorldAlreadyLoaded = true;
                    Plugin.Log.LogInfo(
                        $"[NetworkManager] bootstrap: world already loaded (Mode 2) — " +
                        $"seed='{joinerSeed}' shareCode='{joinerShareCode}'");
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[NetworkManager] bootstrap world-state probe: {ex.Message}"); }

        _writer.Put(joinerWorldAlreadyLoaded);
        if (joinerWorldAlreadyLoaded)
        {
            _writer.Put(joinerSeed);
            _writer.Put(joinerShareCode);
        }

        // Trailing capability flag: this client supports Save-Transfer
        // (host sends its save file; client loads it via LoadGame). Older
        // clients that don't write this field are detected by the host
        // via AvailableBytes guard → fall back to share-code automatically.
        _writer.Put(true); // supportsSaveTransfer

        SendToHost(PacketType.CharacterSubmit, _writer);
        // ↑ Bootstrapping: we use CharacterSubmit as the GUID-bearing first
        // packet because (a) it's already host→client validated and (b) it
        // already triggers the character-assignment flow downstream. The
        // host's HandleCharacterSubmit reads the GUID from the slot's
        // PlayerNetInfo (set at HandleTransportPeerConnected time) before
        // touching the firstName/surName fields, so it doesn't matter that
        // those are empty at this stage. Once profile-driven submit kicks
        // in (via OnCharacterCreationRequired), the client re-sends with
        // real names.

        if (wasReconnecting)
        {
            Plugin.Log.LogInfo($"[NetworkManager] reconnected to host {peer.SteamId.m_SteamID} after {Time.unscaledTime - _reconnectStartedAt:F1}s — awaiting recovery handshake.");
            try { OnReconnected?.Invoke(); } catch (Exception ex) { Plugin.Log.LogWarning($"OnReconnected handler: {ex.Message}"); }
        }
        else
        {
            Plugin.Log.LogInfo($"Connected to host {peer.SteamId.m_SteamID} (waiting for handshake / character flow)");
        }
    }

    private static void HandleTransportConnectFailed(string reason)
    {
        if (IsHost) return;

        Plugin.Log.LogError($"[NetworkManager] connect failed: {reason}");
        LastDisconnectReason = reason ?? "";
        State = ConnectionState.Disconnected;
        HostPeer = null;
        try { SteamLobby.LeaveLobby(); } catch { }
        OnDisconnected?.Invoke($"Connect failed: {reason}");
    }

    /// <summary>Used for star-topology rebroadcast: when host receives a packet from
    /// client A, it must forward the same bytes to clients B, C, ... so all
    /// peers see each other's events.</summary>
    private static readonly NetDataWriter _forwardWrapper = new();
    private static readonly NetDataWriter _remapScratch = new();

    /// <summary>
    /// Allowlist for packets that the host should rebroadcast to other clients
    /// when received from one client (star-topology relay for client-originated
    /// gameplay events).
    ///
    /// Allowlist (was: denylist before 2026-05-09) — adding a new packet type
    /// no longer accidentally exposes it to peers. Default is now <c>false</c>
    /// (do NOT forward); admin / debug / control-plane / host-authoritative
    /// packets stay safely host-only without explicit annotation.
    ///
    /// Classification rule: <c>return true</c> only for packets that are
    /// emitted by clients via <c>SendToAll</c> as a "tell every other peer
    /// about my local action" broadcast (player-driven gameplay events).
    /// Anything host-authored, host-authoritative, or part of the
    /// connection / character / world-load handshake stays in the default
    /// (<c>false</c>) bucket. When in doubt: do NOT add to the allowlist.
    ///
    /// Reviewed-by: software-architect 2026-05-09.
    /// </summary>
    private static bool IsForwardableFromClient(PacketType type)
    {
        switch (type)
        {
            // ── Player movement / animation / inventory (10-29) ────────────
            // Each client broadcasts its own avatar state; host relays to peers.
            case PacketType.PlayerPosition:        // 20Hz position/rotation
            case PacketType.PlayerAnimation:       // animation state
            case PacketType.PlayerInventory:       // full inventory sync
            case PacketType.PlayerInteraction:     // interact w/ object/NPC
            case PacketType.PlayerPickup:          // picked up item
            case PacketType.PlayerDrop:            // dropped item
            case PacketType.PlayerEquip:           // equipped weapon/tool
            case PacketType.PlayerUseItem:         // consumed/used item
            case PacketType.PlayerStatus:          // health/status change
            case PacketType.PlayerVitals:          // vitals HUD bars
            case PacketType.ItemHeld:              // currently-held item id
            case PacketType.ItemRaised:            // combat-ready toggle
            case PacketType.ItemFlashlight:        // flashlight on/off
            case PacketType.ItemAction:            // melee/block/counter
            case PacketType.ItemPlaceVisual:       // tactical item placement
            case PacketType.ItemGive:              // gave item to NPC
            case PacketType.NpcRestrained:         // handcuff state
            case PacketType.NpcStunned:            // stun state
            case PacketType.ItemPlaceRemove:       // pickup of placed item
            case PacketType.ItemThrow:             // threw projectile

            // ── Player-driven world events (30-41) ─────────────────────────
            case PacketType.EvidenceCreate:        // player created evidence (remapped on forward)
            case PacketType.NpcDamage:             // non-lethal damage to NPC
            case PacketType.ElevatorCall:          // pressed elevator button
            case PacketType.DoorLockState:         // lockpick / key unlock
            case PacketType.ComputerLogin:         // logged in/out of computer
            case PacketType.ComputerApp:           // changed foreground app
            case PacketType.VmailCreated:          // vmail thread created
            case PacketType.PlayerHandoff:         // player→player item handoff
            case PacketType.PlayerInBed:           // got in/out of bed
            case PacketType.PlayerAsleep:          // fell asleep / woke up
            case PacketType.MoneyAdded:            // wallet change (each peer replays locally)

            // ── World object state changes (50-56) ─────────────────────────
            // Doors/lights/switches: any peer can flip them.
            // Forensics: client-authored prints/spatter, remapped on forward.
            case PacketType.DoorState:             // open/close
            case PacketType.LightState:            // light on/off
            case PacketType.SwitchState:           // generic switch toggle
            // FingerprintAdd is deliberately NOT forwarded any more. A client's
            // own prints now reach the host, which adds them to its world, and
            // FingerprintPoller replicates them to every client as ZDO prints.
            // Forwarding the raw packet as well would give every other client
            // in a 3+ session each of those prints twice.
            case PacketType.FingerprintClearManual:
            case PacketType.FootprintAdd:          // (remapped on forward)
            case PacketType.SpatterAdd:            // blood/dirt spatter

            // ── Case board / investigation (60-75) ─────────────────────────
            // Each player edits their own case board; mirror across peers.
            case PacketType.CaseProgress:
            case PacketType.EvidenceFound:
            case PacketType.Interrogation:
            case PacketType.CaseBoard:
            case PacketType.CaseBoardPin:
            case PacketType.CaseBoardUnpin:
            case PacketType.CaseBoardMove:
            case PacketType.CaseBoardString:
            case PacketType.CaseBoardHide:
            case PacketType.CaseBoardStatus:
            case PacketType.CaseBoardResolveAnswer:
            case PacketType.CaseBoardResolve:
            case PacketType.CaseBoardFactName:
            case PacketType.CaseBoardStringRemove:
            case PacketType.Arrest:
            case PacketType.CaseResult:

            // ── UI / chat / pings (80-83) ──────────────────────────────────
            case PacketType.ChatMessage:           // text chat
            case PacketType.MapPing:               // map marker
            case PacketType.Waypoint:              // placed waypoint
            case PacketType.PauseState:            // pause overlay banner

            // ── Critical events authored by the client (100+) ──────────────
            case PacketType.CitizenDeath:          // murder/accident witnessed locally
            case PacketType.CrimeCommitted:        // crime committed
            case PacketType.CrimeSceneDiscovered:  // discovered crime scene
            case PacketType.PhoneCallNotify:       // phone-call banner
            case PacketType.PlayerDamage:          // local player took damage
            case PacketType.PlayerSuspicion:       // trespass / illegal-action flags
            case PacketType.PlayerOutfit:          // disguise/outfit change
            case PacketType.EvidenceDiscoveryAdd:  // discovery convergence
            case PacketType.EvidenceSetNote:       // evidence note
            case PacketType.EvidenceCustomName:    // evidence custom-name override
            case PacketType.PlayerAppearance:      // appearance customization (remapped on forward)

            // ── ZDO unified RPC (203) ──────────────────────────────────────
            // Client-authored fire-and-forget events (chat, ping, side-job
            // accept/handin, etc.) dispatched by name hash. Note:
            // ZdoDeltaBatch / ZdoSnapshot / ZdoOwnershipTransfer are NOT in
            // this list — those are host-authoritative state transport.
            case PacketType.ZdoEventRpc:
                return true;

            // Default: NOT forwardable. New packets stay host-only until
            // explicitly classified above. This covers, by design:
            //   • Connection / handshake: Handshake, WorldSeed, PlayerJoined,
            //     PlayerLeft, Ping, ReadyState, GameStart,
            //     CharacterCreationRequired, CharacterSubmit, CharacterReset,
            //     CharacterRejected.
            //   • Host → all broadcasts: HostStatus, SideJobNotification,
            //     NpcOutfit, TimeSync, WeatherSync.
            //   • Host-authoritative world transport: CitizenState/Batch,
            //     ObjectState, WorldSnapshotRequest/Snapshot/Delta/Checksum,
            //     CitizenCommandBatch, CitizenCorrectionBatch,
            //     CitizenOwnershipClaim/Release.
            //   • Client → host-only requests: SideJobAcceptRequest,
            //     SideJobHandInRequest, ClientWorldReady.
            //   • Host → joiner-only payloads: WorldDescriptor, ZdoSnapshot,
            //     ZdoDeltaBatch, ZdoOwnershipTransfer, ZdoVersionMismatch.
            // If you add a new client-originated gameplay packet, add it to
            // the allowlist above. If you add a new admin/debug/control-plane
            // packet, leave it here in the default — it will stay host-only.
            default:
                return false;
        }
    }

    /// <summary>Delivery class to use when relaying a client packet to the
    /// other clients. Mirrors the channel the original sender used: overwrite/
    /// position-state traffic goes Sequenced (late packets can be dropped by
    /// the transport without head-of-line blocking the next frame), one-shot
    /// state-transition traffic goes ReliableOrdered (must arrive in order).
    ///
    /// <para>Before this map existed the host forced every forwarded packet
    /// onto ReliableOrdered, which meant a client's 20–30 Hz
    /// <see cref="PacketType.PlayerPosition"/> relayed to other clients
    /// stalled behind retransmits on any packet loss — a direct cause of
    /// remote-player stutter under lossy links. Sequenced lets the transport
    /// drop the stale position frame and apply the next one instead.</para>
    ///
    /// <para>Sequenced set: the per-feature Sync send sites that already use
    /// <c>DeliveryMethod.Sequenced</c> for their client→host leg
    /// (PlayerSync.SendPosition, InventorySync.BroadcastAction,
    /// FootprintSync, SpatterSync, FingerprintSync).</para></summary>
    private static DeliveryMethod ForwardDeliveryFor(PacketType type)
    {
        switch (type)
        {
            // Overwrite / position-state — latest-wins, stale frames droppable.
            case PacketType.PlayerPosition:
            case PacketType.PlayerAnimation:
            case PacketType.PlayerVitals:
            case PacketType.ItemAction:          // melee/block/counter (Sequenced at source)
            case PacketType.FootprintAdd:
            case PacketType.SpatterAdd:
                return DeliveryMethod.Sequenced;

            // Everything else: state transitions, one-shot events, mutations
            // whose loss leaves a visible unrecoverable divergence.
            default:
                return DeliveryMethod.ReliableOrdered;
        }
    }

    /// <summary>Receives a fully-framed message from the Steam transport.
    /// Wire format: <c>byte type + payload bytes</c> (same as the LiteNetLib
    /// era; the type byte was prepended in SendToAll/SendTo/SendToHost).</summary>
    private static void HandleTransportMessage(SteamPeer peer, byte[] payload, int length)
    {
        byte[] forwardBody = null;
        int forwardBodyLen = 0;
        try
        {
            var reader = new NetDataReader(payload, 0, length);
            var packetType = (PacketType)reader.GetByte();
            int senderId = GetPlayerIdByPeer(peer);

            // Capture body before dispatch (which advances the reader) so
            // we can rebroadcast to other clients.
            //
            // ArrayPool: rebroadcast fires for every forwardable client packet
            // (PlayerPosition / PlayerAnimation / Footprint / Fingerprint /
            // …) — that's dozens of allocs per second per client in a busy
            // session. The rented buffer is returned in the finally block
            // below so it never escapes this method.
            if (IsHost && _clients.Count >= 2 && IsForwardableFromClient(packetType))
            {
                forwardBodyLen = reader.AvailableBytes;
                if (forwardBodyLen > 0)
                {
                    forwardBody = System.Buffers.ArrayPool<byte>.Shared.Rent(forwardBodyLen);
                    Buffer.BlockCopy(reader.RawData, reader.Position, forwardBody, 0, forwardBodyLen);
                }
            }

            switch (packetType)
            {
                case PacketType.Handshake:
                    HandleHandshake(reader);
                    break;
                case PacketType.PlayerJoined:
                    HandlePlayerJoined(reader);
                    break;
                case PacketType.PlayerLeft:
                    HandlePlayerLeft(reader);
                    break;
                case PacketType.CharacterCreationRequired:
                    HandleCharacterCreationRequired(reader);
                    break;
                case PacketType.CharacterSubmit:
                    HandleCharacterSubmit(reader, peer);
                    break;
                case PacketType.CharacterReset:
                    HandleCharacterReset(peer);
                    break;
                case PacketType.CharacterRejected:
                    HandleCharacterRejected(reader);
                    break;
                case PacketType.WorldDescriptor:
                    HandleWorldDescriptor(reader);
                    break;
                case PacketType.ClientWorldReady:
                    if (IsHost) HandleClientWorldReady(peer);
                    break;
                default:
                    OnPacketReceived?.Invoke(packetType, reader, senderId);
                    break;
            }

            if (forwardBody != null && _clients.Count >= 2)
            {
                try
                {
                    NetDataWriter remapped = packetType switch
                    {
                        PacketType.FingerprintAdd   => SoDCoop.Sync.FingerprintSync.RemapForForward(forwardBody, forwardBodyLen, senderId, _remapScratch),
                        PacketType.FootprintAdd     => SoDCoop.Sync.FootprintSync.RemapForForward(forwardBody, forwardBodyLen, senderId, _remapScratch),
                        PacketType.EvidenceCreate   => SoDCoop.Sync.EvidenceSync.RemapForForward(forwardBody, forwardBodyLen, senderId, _remapScratch),
                        PacketType.PlayerAppearance => SoDCoop.Sync.AppearanceSync.RemapForForward(forwardBody, forwardBodyLen, senderId, _remapScratch),
                        _ => null,
                    };

                    _forwardWrapper.Reset();
                    _forwardWrapper.Put((byte)packetType);
                    if (remapped != null)
                        _forwardWrapper.Put(remapped.Data, 0, remapped.Length);
                    else
                        _forwardWrapper.Put(forwardBody, 0, forwardBodyLen);

                    // Forward at the delivery class that matches the original
                    // sender's intent. The transport-level message we received
                    // doesn't carry the channel, but for each forwardable
                    // packet type we know whether the sender used Sequenced
                    // (overwrite/position state — late packets can be dropped)
                    // or ReliableOrdered (state transitions — must arrive).
                    // Forcing everything through Reliable — as the old code did
                    // — meant a client's 20-30 Hz PlayerPosition relayed to
                    // other clients head-of-line-blocked on any packet loss:
                    // every dropped position stalled the next several frames
                    // of remote-player movement. Sequenced just skips the
                    // stale frame and applies the next.
                    DeliveryMethod fwdDelivery = ForwardDeliveryFor(packetType);
                    for (int i = 0; i < _clients.Count; i++)
                    {
                        var c = _clients[i];
                        if (c == peer) continue;
                        TransportSend(c, _forwardWrapper.Data, 0, _forwardWrapper.Length, fwdDelivery);
                    }
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogWarning($"HandleTransportMessage forward-send: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"Error processing packet: {ex}");
        }
        finally
        {
            // Return the pooled buffer regardless of whether forwarding ran
            // or threw. clearArray:false is safe — body bytes are not secrets.
            if (forwardBody != null)
                System.Buffers.ArrayPool<byte>.Shared.Return(forwardBody, clearArray: false);
        }
    }

    #endregion

    #region Host-side handshake helpers

    private static void SendCharacterRejected(SteamPeer peer, string reason)
    {
        _writer.Reset();
        _writer.Put(reason ?? "Character rejected by host.");
        SendTo(peer, PacketType.CharacterRejected, _writer);
    }

    private static void SendCharacterCreationRequired(SteamPeer peer)
    {
        string cityName = CharacterStore.CurrentCityName();
        _writer.Reset();
        _writer.Put(LocalFirstName ?? "");
        _writer.Put(LocalSurname ?? "");
        _writer.Put(cityName ?? "");
        SendTo(peer, PacketType.CharacterCreationRequired, _writer);
    }

    /// <summary>Host-only. Promotes a peer from "pending character" to
    /// "fully joined": stamps the assigned name into PlayerNetInfo, sends
    /// Handshake to the new peer (so it learns the full player list incl.
    /// itself), and broadcasts PlayerJoined to existing peers so they see
    /// the new player appear.</summary>
    private static void AssignCharacterAndCompleteHandshake(SteamPeer peer, int playerId, string firstName, string surName)
    {
        if (!_players.TryGetValue(playerId, out var info))
        {
            Plugin.Log.LogWarning($"[NetworkManager] AssignCharacter: no PlayerNetInfo for {playerId}");
            return;
        }

        info.FirstName = firstName ?? "";
        info.Surname = surName ?? "";
        info.PlayerName = string.IsNullOrEmpty(info.Surname) ? info.FirstName : $"{info.FirstName} {info.Surname}";
        info.CharacterAssigned = true;

        // Resolve the client's twin via TwinManager (host-only) so the
        // Handshake / PlayerJoined writes below carry it. Receivers cache
        // it per-player and use it for vitals / crouch / KO mirroring
        // (see CitizenResolver "is this MY twin?" stamp path).
        try
        {
            string seed = CharacterStore.CurrentSeed();
            var rec = CharacterStore.TryGet(seed, info.ClientGuid);
            if (rec != null && rec.HumanID > 0) info.TwinHumanID = rec.HumanID;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[NetworkManager] resolve twin id for player {playerId}: {ex.Message}"); }

        if (!_clients.Contains(peer)) _clients.Add(peer);

        _writer.Reset();
        _writer.Put(playerId);
        _writer.Put(_players.Count);
        foreach (var p in _players.Values)
        {
            _writer.Put(p.PlayerId);
            _writer.Put(p.PlayerName);
            _writer.Put(p.IsHost);
            _writer.Put(p.FirstName ?? "");
            _writer.Put(p.Surname ?? "");
            // Trailing field — receivers read with a HasMoreBytes guard so
            // mixed-version peers stay compatible. Zero on host's own slot
            // until ResolveHostOwnTwinId() catches Player.Instance.humanID.
            _writer.Put(p.TwinHumanID);
        }
        SendTo(peer, PacketType.Handshake, _writer);

        _writer.Reset();
        _writer.Put(playerId);
        _writer.Put(info.PlayerName);
        _writer.Put(info.FirstName ?? "");
        _writer.Put(info.Surname ?? "");
        _writer.Put(info.TwinHumanID);
        for (int i = 0; i < _clients.Count; i++)
        {
            var client = _clients[i];
            if (client != peer)
            {
                SendTo(client, PacketType.PlayerJoined, _writer);
            }
        }

        Plugin.Log.LogInfo($"Player '{info.PlayerName}' (ID: {playerId}) fully joined. Total: {_clients.Count + 1}");
        OnPlayerJoined?.Invoke(playerId, info.PlayerName);

        // ── Mode 2 short-circuit: if the joiner already has the city
        // loaded (and the seed matched our hostSeed at bootstrap time),
        // skip the WorldDescriptor send entirely — they don't need to
        // re-generate, and they aren't going to fire ClientWorldReady
        // for us either (that's owned by WorldAutoLoad, which is bypassed
        // in Mode 2). Send the snapshot synchronously instead.
        if (info.SkipAutoLoad)
        {
            Plugin.Log.LogInfo(
                $"[NetworkManager] Mode 2: skipping WorldDescriptor for {peer.DisplayName} — " +
                $"firing snapshot immediately.");
            HandleClientWorldReady(peer);
            return;
        }

        // ── Mode 3 (Save-Transfer): if the host's WorldBootstrap setting ──
        // is SaveTransfer AND the client advertised support in its bootstrap
        // packet, ship the host's save file instead of a share-code. The
        // client loads it via SoD's LoadGame path → identical world by
        // construction. Falls back to Mode 1 (share-code) if the client
        // doesn't support it, the host setting is ShareCode, or the save
        // file can't be read. The ZDO snapshot stays deferred until the
        // client's save-load completes and fires ClientWorldReady (same
        // tail as Mode 1 — WorldAutoLoad.OnWorldReadyAfterAutoLoad sends
        // it after the load finishes).
        bool wantSaveTransfer = CoopSettings.WorldBootstrap?.Value == WorldBootstrapMode.SaveTransfer;
        if (wantSaveTransfer && info.SupportsSaveTransfer)
        {
            if (SoDCoop.Sync.SaveTransfer.SendSaveToPeer(peer))
            {
                Plugin.Log.LogInfo(
                    $"[NetworkManager] Mode 3 (Save-Transfer) started for {peer.DisplayName} — " +
                    $"save file enqueued, awaiting client load + ClientWorldReady.");
                return;
            }
            // SendSaveToPeer returned false (no save file / read error) →
            // fall through to Mode 1 share-code as a safe fallback.
            Plugin.Log.LogWarning(
                $"[NetworkManager] Save-Transfer requested but unavailable for {peer.DisplayName} — " +
                $"falling back to share-code (Mode 1).");
        }

        // ── Auto-load (Mode 1): send WorldDescriptor so the joiner can ──
        // regenerate the host's exact city locally before applying the
        // ZDO snapshot.
        SendWorldDescriptorTo(peer);

        // ── ZDO snapshot is DEFERRED until the joiner signals world-ready ──
        // (PacketType.ClientWorldReady). On a fresh join, the joiner is on
        // the main menu when it gets here — it can't apply state until SoD's
        // city generation completes (~30s). Snapshot fires from
        // HandleClientWorldReady() once the joiner is in the city.
        //
        // The legacy AppearanceSync snapshot is also gated on the same
        // signal, so it lands after the city is built.
    }

    /// <summary>
    /// Sends the host's current city descriptor (seed, share-code, name,
    /// size) to a freshly-joined peer so its mod can drive SoD's
    /// "Generate from share code" flow on its end.
    /// </summary>
    private static void SendWorldDescriptorTo(SteamPeer peer)
    {
        try
        {
            var city = global::CityData.Instance;
            if (city == null)
            {
                Plugin.Log.LogWarning("[NetworkManager] SendWorldDescriptorTo: CityData.Instance is null — skipping.");
                return;
            }
            var size = city.citySize; // Vector2 (rounded down to int per axis)
            int sizeX = (int)size.x;
            int sizeY = (int)size.y;
            string cityName = city.cityName ?? "";
            string seed     = city.seed     ?? "";
            // city.cityBuiltWith holds the game build version ("41.04" etc.) —
            // that's the `version` field of SoD's share-code envelope.
            string version  = !string.IsNullOrEmpty(city.cityBuiltWith)
                                ? city.cityBuiltWith
                                : UnityEngine.Application.version;

            // Toolbox.GetShareCode(cityName, sizeX, sizeY, version, seed) is the
            // EXACT same encoder SoD uses when the user clicks "Copy share-code"
            // on the city panel. The result is a base64-ish blob that
            // MainMenuController.ParseShareCode round-trips back into all five
            // CityControls fields. Sending only the raw seed string was wrong —
            // ParseShareCode would silently leave size/name/version unset and
            // ConfirmCityGeneration would no-op (which is what we observed on
            // the joiner's first test: ParseShareCode "applied" then nothing).
            string shareCode = "";
            try
            {
                var tb = global::Toolbox.Instance;
                if (tb != null)
                    shareCode = tb.GetShareCode(cityName, sizeX, sizeY, version, seed) ?? "";
            }
            catch (Exception sx)
            {
                Plugin.Log.LogWarning($"[NetworkManager] Toolbox.GetShareCode threw: {sx.Message}");
            }
            if (string.IsNullOrEmpty(shareCode))
            {
                // Build a deterministic fallback so the joiner has *something*.
                shareCode = seed;
                Plugin.Log.LogWarning("[NetworkManager] WorldDescriptor: GetShareCode returned empty — falling back to bare seed (joiner generation will likely fail).");
            }

            var pkt = new SoDCoop.Sync.WorldDescriptorPacket
            {
                Seed       = seed,
                CityName   = cityName,
                ShareCode  = shareCode,
                CitySizeX  = sizeX,
                CitySizeY  = sizeY,
            };
            _writer.Reset();
            pkt.Serialize(_writer);
            SendTo(peer, PacketType.WorldDescriptor, _writer);
            Plugin.Log.LogInfo(
                $"[NetworkManager] sent WorldDescriptor to {peer.DisplayName}: " +
                $"seed='{pkt.Seed}' city='{pkt.CityName}' shareCode='{pkt.ShareCode}' size=({pkt.CitySizeX}x{pkt.CitySizeY})");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[NetworkManager] SendWorldDescriptorTo: {ex}");
        }
    }

    /// <summary>
    /// Joiner-side handler for <see cref="PacketType.WorldDescriptor"/>.
    /// Hands the descriptor off to <see cref="SoDCoop.Sync.WorldAutoLoad"/>
    /// which calls into SoD's MainMenuController to start city generation.
    /// </summary>
    private static void HandleWorldDescriptor(NetDataReader reader)
    {
        try
        {
            var pkt = new SoDCoop.Sync.WorldDescriptorPacket();
            pkt.Deserialize(reader);
            SoDCoop.Sync.WorldAutoLoad.OnDescriptorReceived(pkt);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[NetworkManager] HandleWorldDescriptor: {ex}");
        }
    }

    /// <summary>
    /// Host-side handler for <see cref="PacketType.ClientWorldReady"/>:
    /// joiner has finished generating the city and wants the snapshot.
    /// Now safe to send AppearanceSync + ZDO state.
    /// </summary>
    private static void HandleClientWorldReady(SteamPeer peer)
    {
        Plugin.Log.LogInfo($"[NetworkManager] {peer.DisplayName} reports WorldReady — sending snapshots.");
        try { SoDCoop.Sync.AppearanceSync.SendSnapshotTo(peer); } catch (Exception ex) { Plugin.Log.LogWarning($"AppearanceSync.SendSnapshotTo: {ex.Message}"); }
        // NOTE: the ZDO snapshot is enqueued here but actually ships a frame
        // or two later from ZdoMan.PumpPendingSnapshotSends (async compress).
        // The peer's WorldReady flag — which enables live delta/event traffic —
        // is set there, AFTER the snapshot packet goes out, so the peer never
        // receives a delta before the snapshot that seeds the ZDO it touches.
        try { SoDCoop.Zdo.ZdoMan.SendSnapshotTo(peer); }          catch (Exception ex) { Plugin.Log.LogWarning($"ZdoMan.SendSnapshotTo: {ex.Message}"); }
    }

    /// <summary>Host-only. Mark a peer as fully world-ready (loaded + has its
    /// ZDO snapshot), enabling live per-peer delta/event sends to it. Called
    /// by <c>ZdoMan.PumpPendingSnapshotSends</c> the moment the snapshot
    /// packet actually ships. Idempotent.</summary>
    internal static void MarkPeerWorldReady(int peerId)
    {
        if (peerId < 0) return;
        if (_players.TryGetValue(peerId, out var info) && info != null && !info.WorldReady)
        {
            info.WorldReady = true;
            Plugin.Log.LogInfo(
                $"[NetworkManager] peer {peerId} ('{info.PlayerName}') is WorldReady — " +
                $"live delta/event traffic enabled.");
        }
    }

    /// <summary>Host-only. Mark a peer as NOT world-ready, stopping all live
    /// per-peer delta / event / ownership / citizen-position sends to it until
    /// its next snapshot ships.
    ///
    /// <para><b>Why this has to exist.</b> <see cref="PlayerNetInfo.WorldReady"/>
    /// used to be set true in exactly one place and never cleared, so a peer
    /// stayed "ready" forever once it had been ready once. Two paths take a
    /// peer's world away underneath that flag:</para>
    /// <list type="bullet">
    ///   <item><description><b>Live save-transfer re-sync</b> — the host pushes
    ///   a fresh save, the client calls LoadGame and spends the next 30-110 s
    ///   with no world at all, while the host happily keeps streaming deltas at
    ///   it.</description></item>
    ///   <item><description><b>Reconnect</b> — the restored slot carries the
    ///   previous session's <c>WorldReady == true</c>, so the host resumes
    ///   streaming the instant the peer is re-registered, before the resume
    ///   delta or snapshot that seeds those ZDOs has shipped.</description></item>
    /// </list>
    /// <para>Both reproduce exactly the failure the gate was introduced to fix:
    /// deltas arriving at a peer that cannot apply them, wasted main-thread
    /// serialise on the host and a reliable-channel head-of-line stall.</para></summary>
    internal static void MarkPeerWorldNotReady(int peerId, string reason)
    {
        if (peerId < 0) return;
        if (_players.TryGetValue(peerId, out var info) && info != null && info.WorldReady)
        {
            info.WorldReady = false;
            Plugin.Log.LogInfo(
                $"[NetworkManager] peer {peerId} ('{info.PlayerName}') is NO LONGER WorldReady ({reason}) — " +
                $"live delta/event traffic suspended until its next snapshot ships.");
        }
    }

    /// <summary>Host-only convenience: clear the world-ready flag for the peer
    /// behind <paramref name="peer"/>.</summary>
    internal static void MarkPeerWorldNotReady(SteamPeer peer, string reason)
        => MarkPeerWorldNotReady(GetPlayerIdByPeer(peer), reason);

    #endregion

    #region Packet Handlers

    private static void HandleHandshake(NetDataReader reader)
    {
        LocalPlayerId = reader.GetInt();
        int playerCount = reader.GetInt();

        _players.Clear();
        for (int i = 0; i < playerCount; i++)
        {
            int id = reader.GetInt();
            string name = reader.GetString();
            bool isHost = reader.GetBool();
            string firstName = reader.GetString();
            string surName = reader.GetString();
            // Optional trailing field — older host builds skip it; default 0
            // means "twin not yet assigned" (vitals mirroring stays inactive).
            int twinId = reader.AvailableBytes >= 4 ? reader.GetInt() : 0;

            _players[id] = new PlayerNetInfo
            {
                PlayerId = id,
                PlayerName = name,
                FirstName = firstName,
                Surname = surName,
                IsHost = isHost,
                TwinHumanID = twinId,
                CharacterAssigned = true,
            };

            if (id == LocalPlayerId)
            {
                LocalFirstName = firstName;
                LocalSurname = surName;
                LocalPlayerName = name;
            }
        }

        Plugin.Log.LogInfo($"Handshake complete. Assigned ID: {LocalPlayerId}. Players online: {playerCount}. I am '{LocalPlayerName}'. MyTwin#={MyTwinHumanID}.");

        // Pre-spawn RemotePlayers for every peer already in the roster. Without
        // this, the joiner never creates a RemotePlayer for the host (the host
        // joined before us, so OnPlayerJoined already fired on the host's side
        // and was NOT relayed to us). The result: the joiner doesn't see the
        // host's avatar until the host happens to send a position update — and
        // even then, ApplyPositionState only feeds an existing RemotePlayer.
        // Spawning here ensures the host's avatar appears as soon as the first
        // ZDO position delta arrives.
        try
        {
            foreach (var kv in _players)
            {
                int pid = kv.Key;
                var info = kv.Value;
                if (info == null || pid == LocalPlayerId) continue;
                if (SoDCoop.Player.RemotePlayerManager.GetPlayer(pid) == null)
                {
                    string n = string.IsNullOrEmpty(info.PlayerName) ? $"Player {pid}" : info.PlayerName;
                    SoDCoop.Player.RemotePlayerManager.SpawnRemotePlayer(pid, n);
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[NetworkManager] pre-spawn RemotePlayers on handshake: {ex.Message}"); }

        OnConnected?.Invoke();
    }

    private static void HandlePlayerJoined(NetDataReader reader)
    {
        int playerId = reader.GetInt();
        string playerName = reader.GetString();
        string firstName = reader.GetString();
        string surName = reader.GetString();
        int twinId = reader.AvailableBytes >= 4 ? reader.GetInt() : 0;

        _players[playerId] = new PlayerNetInfo
        {
            PlayerId = playerId,
            PlayerName = playerName,
            FirstName = firstName,
            Surname = surName,
            IsHost = false,
            TwinHumanID = twinId,
            CharacterAssigned = true,
        };

        Plugin.Log.LogInfo($"Player '{playerName}' (ID: {playerId}) joined.");
        OnPlayerJoined?.Invoke(playerId, playerName);
    }

    private static void HandleCharacterCreationRequired(NetDataReader reader)
    {
        string hostFirst = reader.GetString();
        string hostSur = reader.GetString();
        string cityName = reader.GetString();

        Plugin.Log.LogInfo($"[NetworkManager] host requested character creation (host: \"{hostFirst} {hostSur}\", city: \"{cityName}\")");
        OnCharacterCreationRequired?.Invoke(hostFirst, hostSur, cityName);
    }

    /// <summary>Host-side. The first <see cref="PacketType.CharacterSubmit"/>
    /// from a freshly-connected client always carries just the clientGuid
    /// (no names) — that's the bootstrap packet shipped by
    /// <see cref="HandleTransportClientConnected"/>. Subsequent submits carry
    /// real names.</summary>
    private static void HandleCharacterSubmit(NetDataReader reader, SteamPeer peer)
    {
        if (!IsHost) return;

        // Decode: either {guid} (bootstrap) or {firstName, surName} (real).
        // Easiest way to distinguish: peer's slot has CharacterAssigned=false
        // AND ClientGuid is empty → expect bootstrap (one string).
        int playerId = -1;
        PlayerNetInfo info = null;
        foreach (var kvp in _players)
        {
            if (kvp.Value.Peer == peer) { playerId = kvp.Key; info = kvp.Value; break; }
        }
        if (info == null)
        {
            Plugin.Log.LogWarning($"[NetworkManager] CharacterSubmit from unknown peer {peer.DisplayName}");
            return;
        }

        bool isBootstrap = !info.CharacterAssigned && string.IsNullOrEmpty(info.ClientGuid);
        if (isBootstrap)
        {
            // Read protocol version FIRST. Mismatched mod versions would
            // otherwise corrupt every subsequent packet silently — better
            // to fail loud immediately than chase symptoms. AvailableBytes
            // guard tolerates older joiners that don't ship the field.
            int joinerVersion = -1;
            try { if (reader.AvailableBytes >= 4) joinerVersion = reader.GetInt(); } catch { }
            if (joinerVersion != PROTOCOL_VERSION)
            {
                string reason = joinerVersion < 0
                    ? "client did not send a protocol version (out-of-date mod build)"
                    : $"protocol mismatch — host runs version {PROTOCOL_VERSION}, client runs version {joinerVersion}";
                Plugin.Log.LogWarning($"[NetworkManager] rejecting {peer.DisplayName}: {reason}");
                SendCharacterRejected(peer, reason);
                TransportCloseConnection(peer, "protocol version mismatch");
                return;
            }

            string guid = reader.GetString();
            if (string.IsNullOrEmpty(guid))
            {
                Plugin.Log.LogWarning($"[NetworkManager] bootstrap CharacterSubmit from {peer.DisplayName} carried empty GUID — disconnecting.");
                TransportCloseConnection(peer, "missing client GUID");
                return;
            }

            info.ClientGuid = guid;
            peer.ClientGuid = guid;

            // Mode 2 (connect-with-pre-loaded-world): joiner advertises that
            // it already has the city loaded. If our seed matches, we skip
            // the WorldDescriptor send and the 60s SoD generation flow
            // (avoiding tutorial-replay + 484m teleport burst). If seeds
            // mismatch, reject with a guidance message — running Mode 2
            // against the wrong world would diverge state badly. If the
            // joiner sends false (or the field is absent — pre-v2 bug
            // or third-party tooling), fall through to Mode 1 / legacy.
            bool joinerWorldAlreadyLoaded = false;
            try { if (reader.AvailableBytes >= 1) joinerWorldAlreadyLoaded = reader.GetBool(); } catch { }
            if (joinerWorldAlreadyLoaded)
            {
                string joinerSeed = "";
                string joinerShareCode = "";
                try { joinerSeed = reader.GetString(); } catch { }
                try { joinerShareCode = reader.GetString(); } catch { }

                string hostSeed = "";
                try { hostSeed = global::CityData.Instance?.seed ?? ""; } catch { }

                if (string.IsNullOrEmpty(hostSeed))
                {
                    Plugin.Log.LogWarning(
                        $"[NetworkManager] joiner reports Mode 2 world-loaded but host has no CityData yet — " +
                        $"falling through to Mode 1.");
                    // info.SkipAutoLoad stays false → legacy path runs.
                }
                else if (string.Equals(joinerSeed, hostSeed, StringComparison.Ordinal))
                {
                    info.SkipAutoLoad = true;
                    Plugin.Log.LogInfo(
                        $"[NetworkManager] Mode 2 accepted for {peer.DisplayName}: " +
                        $"seed='{joinerSeed}' matches host — skipping WorldDescriptor send.");
                }
                else
                {
                    // Build a host share-code so the user can paste it into
                    // their main menu and try again.
                    string hostShareCode = "";
                    try
                    {
                        var tb = global::Toolbox.Instance;
                        var city = global::CityData.Instance;
                        if (tb != null && city != null)
                        {
                            int sx = (int)city.citySize.x;
                            int sy = (int)city.citySize.y;
                            string ver = !string.IsNullOrEmpty(city.cityBuiltWith)
                                ? city.cityBuiltWith : UnityEngine.Application.version;
                            hostShareCode = tb.GetShareCode(city.cityName ?? "", sx, sy, ver, hostSeed) ?? "";
                        }
                    }
                    catch (Exception sx) { Plugin.Log.LogWarning($"[NetworkManager] mismatch share-code build: {sx.Message}"); }

                    string reason =
                        $"World seed mismatch — your world's seed ('{joinerSeed}') doesn't match the host's ('{hostSeed}'). " +
                        (string.IsNullOrEmpty(hostShareCode)
                            ? "Return to the main menu and join from there to auto-generate the host's world."
                            : $"Return to the main menu and either join from there (auto-generate) or generate the host's world manually with share-code: {hostShareCode}");
                    Plugin.Log.LogWarning(
                        $"[NetworkManager] Mode 2 rejected for {peer.DisplayName}: " +
                        $"joinerSeed='{joinerSeed}' hostSeed='{hostSeed}' shareCode='{joinerShareCode}'");
                    SendCharacterRejected(peer, reason);
                    TransportCloseConnection(peer, "world seed mismatch");
                    return;
                }
            }

            // Trailing capability flag: the client advertised Save-Transfer
            // support (host ships its save file, client loads via LoadGame).
            // Older clients that don't write this field are detected via the
            // AvailableBytes guard and default to false → host falls back to
            // share-code (Mode 1) automatically. Read AFTER the Mode 2 block
            // because it's the last field in the bootstrap packet.
            try { if (reader.AvailableBytes >= 1) info.SupportsSaveTransfer = reader.GetBool(); }
            catch { /* mixed-version client — leave SupportsSaveTransfer=false */ }

            // Reconnect path: same clientGuid is in the grace window. Restore
            // the existing slot, swap in the new SteamPeer reference, send a
            // fresh Handshake so they re-sync. Drop the freshly-allocated slot.
            var (existingId, existingInfo) = FindPendingReconnect(guid);
            if (existingId >= 0 && existingInfo != null && existingId != playerId)
            {
                Plugin.Log.LogInfo($"[NetworkManager] reconnect: restoring playerId={existingId} ({existingInfo.PlayerName}) for {peer.SteamId.m_SteamID}");
                // Drop the freshly-allocated bootstrap slot AND its reverse-map
                // entry — the new peer is going to be re-pointed at the
                // reconnecting (existing) playerId, not this throwaway slot.
                _peerToPlayerId.Remove(peer);
                _players.Remove(playerId); // discard the bootstrap slot
                existingInfo.Peer = peer;
                existingInfo.DisconnectedAt = 0f;
                _peerToPlayerId[peer] = existingId;
                if (!_clients.Contains(peer)) _clients.Add(peer);

                // The restored slot still carries the PREVIOUS session's
                // WorldReady=true. Clear it before the peer is re-registered
                // for sends, or the per-peer flush starts streaming deltas the
                // moment _clients contains this peer again — ahead of the
                // resume-delta / snapshot below that seeds the ZDOs those
                // deltas refer to. Re-armed once the resume actually ships.
                MarkPeerWorldNotReady(existingId, "reconnect — awaiting resume/snapshot");

                _writer.Reset();
                _writer.Put(existingId);
                _writer.Put(_players.Count);
                foreach (var p in _players.Values)
                {
                    _writer.Put(p.PlayerId);
                    _writer.Put(p.PlayerName);
                    _writer.Put(p.IsHost);
                    _writer.Put(p.FirstName ?? "");
                    _writer.Put(p.Surname ?? "");
                    _writer.Put(p.TwinHumanID);
                }
                SendTo(peer, PacketType.Handshake, _writer);

                // Phase H: pre-ZDO snapshots removed (see same block in
                // AssignCharacterAndCompleteHandshake). Only AppearanceSync
                // remains on legacy.
                try { SoDCoop.Sync.AppearanceSync.SendSnapshotTo(peer); } catch (Exception ex) { Plugin.Log.LogWarning($"AppearanceSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                // Reconnect path: try the cursor-delta resume first.
                // Peer's LastSeenRev was preserved across the grace
                // window — if it's populated we can ship just the
                // ZDOs whose DataRevision moved during the disconnect
                // (typically a few KB). If the cursor is empty (peer
                // disconnected before we ever ran a flush against
                // them, or session was never snapshotted) fall back
                // to the legacy full snapshot.
                try
                {
                    bool delivered = SoDCoop.Zdo.ZdoMan.SendDeltaSinceCursorTo(peer);
                    if (delivered)
                    {
                        // The cursor-delta path ships synchronously and is the
                        // peer's complete catch-up, so it — unlike the chunked
                        // snapshot, which arms the flag from its own pump —
                        // must re-arm WorldReady itself. Without this the peer
                        // would stay suspended by the clear above and never
                        // receive another delta.
                        MarkPeerWorldReady(existingId);
                    }
                    else
                    {
                        SoDCoop.Zdo.ZdoMan.SendSnapshotTo(peer);
                    }
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogWarning($"ZdoMan.Send(Delta|Snapshot)To (reconnect): {ex.Message}");
                }
                return;
            }

            // Fresh client — look up existing character record by (seed, guid).
            string seed = CharacterStore.CurrentSeed();
            var existing = CharacterStore.TryGet(seed, guid);
            if (existing != null)
            {
                Plugin.Log.LogInfo($"[NetworkManager] returning client {guid} → {existing.FirstName} {existing.Surname}");
                AssignCharacterAndCompleteHandshake(peer, playerId, existing.FirstName, existing.Surname);
            }
            else
            {
                Plugin.Log.LogInfo($"[NetworkManager] new client {guid} for seed \"{seed}\" — requesting character creation");
                SendCharacterCreationRequired(peer);
            }
            return;
        }

        // Real submission: validated names from the client.
        string firstName = reader.GetString();
        string surName = reader.GetString();

        if (info.CharacterAssigned)
        {
            Plugin.Log.LogWarning($"[NetworkManager] CharacterSubmit but {playerId} is already assigned — ignoring resubmission.");
            return;
        }

        var err = CharacterStore.ValidateName(firstName) ?? CharacterStore.ValidateName(surName);
        if (err != null)
        {
            Plugin.Log.LogWarning($"[NetworkManager] rejected character submit: {err}");
            SendCharacterRejected(peer, err);
            return;
        }

        string seedFresh = CharacterStore.CurrentSeed();
        var saved = CharacterStore.Save(seedFresh, info.ClientGuid, firstName, surName);

        int twinHumanID = TwinManager.EnsureTwinAssigned(seedFresh, saved);
        if (twinHumanID > 0)
            Plugin.Log.LogInfo($"[NetworkManager] {firstName} {surName} → twin citizen humanID={twinHumanID}");

        AssignCharacterAndCompleteHandshake(peer, playerId, firstName, surName);
    }

    private static (int playerId, PlayerNetInfo info) FindPendingReconnect(string clientGuid)
    {
        if (string.IsNullOrEmpty(clientGuid)) return (-1, null);
        foreach (var kvp in _players)
        {
            var p = kvp.Value;
            if (p == null) continue;
            if (!p.IsAwaitingReconnect) continue;
            if (string.IsNullOrEmpty(p.ClientGuid)) continue;
            if (p.ClientGuid != clientGuid) continue;
            return (kvp.Key, p);
        }
        return (-1, null);
    }

    private static void HandleCharacterRejected(NetDataReader reader)
    {
        string reason = reader.GetString();
        Plugin.Log.LogWarning($"[NetworkManager] host rejected our character: {reason}");
        OnCharacterRejected?.Invoke(reason);
    }

    private static void HandleCharacterReset(SteamPeer peer)
    {
        if (!IsHost) return;

        string clientGuid = null;
        int playerId = -1;
        foreach (var kvp in _players)
        {
            if (kvp.Value.Peer == peer)
            {
                playerId = kvp.Key;
                clientGuid = kvp.Value.ClientGuid;
                break;
            }
        }
        if (string.IsNullOrEmpty(clientGuid))
        {
            Plugin.Log.LogWarning($"[NetworkManager] CharacterReset from peer {peer.DisplayName} with no clientGuid — ignoring.");
            return;
        }

        Plugin.Log.LogInfo($"[NetworkManager] CharacterReset from playerId={playerId} clientGuid={clientGuid}");

        try { TwinManager.ReleaseRecord(CharacterStore.CurrentSeed(), clientGuid); }
        catch (Exception ex) { Plugin.Log.LogWarning($"TwinManager.ReleaseRecord: {ex.Message}"); }

        try { TransportCloseConnection(peer, "character reset"); } catch { }
    }

    public static void RequestCharacterReset()
    {
        if (IsHost || HostPeer == null)
        {
            Plugin.Log.LogWarning("[NetworkManager] RequestCharacterReset called outside client context — ignored.");
            return;
        }
        _writer.Reset();
        SendToHost(PacketType.CharacterReset, _writer);
    }

    /// <summary>
    /// Client-only. Sends the player-typed first / surname to the host in
    /// reply to a <see cref="PacketType.CharacterCreationRequired"/>.
    /// </summary>
    public static void SubmitCharacter(string firstName, string surName)
    {
        if (IsHost || HostPeer == null)
        {
            Plugin.Log.LogWarning("[NetworkManager] SubmitCharacter called outside of client context — ignored.");
            return;
        }

        _writer.Reset();
        _writer.Put(firstName ?? "");
        _writer.Put(surName ?? "");
        SendToHost(PacketType.CharacterSubmit, _writer);
    }

    private static void HandlePlayerLeft(NetDataReader reader)
    {
        int playerId = reader.GetInt();

        if (_players.TryGetValue(playerId, out var player))
        {
            _players.Remove(playerId);
            Plugin.Log.LogInfo($"Player '{player.PlayerName}' (ID: {playerId}) left.");
            OnPlayerLeft?.Invoke(playerId, player.PlayerName);
        }
    }

    #endregion

    #region Helpers

    /// <summary>Reverse the SteamPeer→PlayerId mapping. Public so subsystems
    /// (e.g. <c>ZdoMan</c>'s per-peer culled dispatch) can resolve a peer's
    /// PlayerNetInfo without redoing the dictionary walk themselves.
    /// O(1) via <see cref="_peerToPlayerId"/> reverse map (was O(N_players)
    /// linear scan — hot on host's HandleTransportMessage and ZdoMan's
    /// per-peer flush). Map is maintained alongside every <c>info.Peer</c>
    /// mutation in the connect / disconnect / reconnect paths.</summary>
    public static int GetPlayerIdByPeer(SteamPeer peer)
    {
        if (peer == null) return -1;
        return _peerToPlayerId.TryGetValue(peer, out var id) ? id : -1;
    }

    #endregion
}

/// <summary>
/// Information about a connected player.
/// </summary>
public class PlayerNetInfo
{
    public int PlayerId { get; set; }
    public string PlayerName { get; set; }
    public string FirstName { get; set; } = "";
    public string Surname { get; set; } = "";
    public bool IsHost { get; set; }

    /// <summary>The remote peer, or null when the player is the local host
    /// (or is currently in the reconnect-grace window).</summary>
    public SteamPeer Peer { get; set; }

    public string ClientGuid { get; set; } = "";

    /// <summary>Host-assigned humanID of the citizen acting as this player's
    /// twin in the host's world. Pushed to every peer in the Handshake +
    /// PlayerJoined packets so receivers can map peer-id ↔ citizen for
    /// vitals / crouch / KO mirroring (CitizenResolver reads this to detect
    /// "is this citizen MY twin? then also stamp Player.Instance vitals").
    /// 0 = not yet assigned (pre-character-creation).</summary>
    public int TwinHumanID { get; set; }

    public bool CharacterAssigned { get; set; }
    public float DisconnectedAt { get; set; }
    public bool IsAwaitingReconnect => DisconnectedAt > 0f;

    /// <summary>Mode 2 (connect-with-pre-loaded-world): joiner advertised
    /// at bootstrap time that they already have our city loaded (their
    /// seed matched ours). Host skips <c>SendWorldDescriptorTo</c> — the
    /// joiner doesn't need SoD's 60s "Generate from share-code" flow,
    /// the tutorial replay it triggers, or the 484m default-spawn
    /// teleport. Snapshot fires synchronously from
    /// <c>AssignCharacterAndCompleteHandshake</c> instead of waiting for
    /// <c>ClientWorldReady</c> (which the joiner won't send because
    /// WorldAutoLoad is bypassed).</summary>
    public bool SkipAutoLoad { get; set; }

    /// <summary>True if this peer's client advertised Save-Transfer support
    /// in its bootstrap <c>CharacterSubmit</c> packet. The host reads this
    /// in <c>AssignCharacterAndCompleteHandshake</c> to decide between
    /// Mode 3 (save-transfer: ship the host's save file) and Mode 1
    /// (share-code city-gen) when <c>CoopSettings.WorldBootstrap</c> is
    /// <c>SaveTransfer</c>. A peer on an older build that doesn't write
    /// this field defaults to false → host falls back to share-code
    /// automatically (mixed-version safety).</summary>
    public bool SupportsSaveTransfer { get; set; }

    /// <summary>True once this peer has finished loading the world AND
    /// received its full ZDO snapshot — i.e. it is ready to receive and
    /// apply live delta/event traffic. Set by
    /// <c>ZdoMan.PumpPendingSnapshotSends</c> right after the snapshot
    /// packet actually goes out (NOT at character-submit, NOT at
    /// ClientWorldReady — both fire before the snapshot lands).
    ///
    /// <para><b>Why this exists:</b> previously the host began streaming
    /// 10 Hz ZDO deltas and spatial events to a peer the instant it was
    /// added to <c>_clients</c> (character-submit), which happens while the
    /// joiner is still on SoD's ~30 s city-generation loading screen. That
    /// peer cannot apply any of it — the live SoD objects don't exist yet —
    /// so every delta was serialised on the host main thread for nothing,
    /// shipped reliable-ordered (head-of-line stalling the channel), and on
    /// the joiner triggered a per-event NRE-and-swallow storm against null
    /// <c>CityData.Instance</c>. That is the "host lags before the client
    /// has even loaded" symptom. Gating all per-peer sends on this flag
    /// eliminates the wasted work entirely; the snapshot delivers the full
    /// authoritative baseline the moment the peer is genuinely ready.</para>
    ///
    /// <para>Ordering guarantee: set only after the snapshot send, so a
    /// peer never receives a delta for a ZDO before the snapshot that
    /// creates it.</para></summary>
    public bool WorldReady { get; set; }

    /// <summary>Peer's most recent broadcast world position. Updated by
    /// <c>PlayerSync</c> when a <see cref="PacketType.PlayerPosition"/>
    /// packet arrives. Used by <c>ZdoMan</c> for sector culling: ZDOs
    /// far from this position aren't included in this peer's per-flush
    /// dispatch (Valheim-style "send only what's near"). Default
    /// <c>(0, 0, 0)</c> means "no position yet known" — sender treats
    /// it as "send everything" until the first position update lands.</summary>
    public UnityEngine.Vector3 LastKnownPosition { get; set; }

    /// <summary>True iff <see cref="LastKnownPosition"/> has ever been set
    /// from a real packet (i.e. not still its zero default). Used by
    /// the cull predicate to avoid filtering with a meaningless position
    /// during the first second of a peer's session.</summary>
    public bool HasKnownPosition { get; set; }

    /// <summary>Position at which we last did a full sector-cull catch-up
    /// evaluation for this peer. <see cref="ZdoMan.EvaluatePeerCatchup"/>
    /// debounces re-eval until the peer has moved at least
    /// <c>CATCHUP_REEVAL_M</c> from this anchor — otherwise a 30 Hz
    /// PlayerPosition stream would burn O(spatial-zdos) walks every
    /// position packet.</summary>
    public UnityEngine.Vector3 LastCatchupPos { get; set; }

    /// <summary>True iff <see cref="LastCatchupPos"/> is meaningful.
    /// First eval establishes the baseline; subsequent evals diff against
    /// it.</summary>
    public bool HasCatchupBaseline { get; set; }

    /// <summary>Per-peer DataRevision cursor (Valheim ZDOMan.m_dataRevisions
    /// pattern). For each ZDOID, records the highest <c>Zdo.DataRevision</c>
    /// that has already been serialised into a packet sent to this peer.
    ///
    /// <para>Optimistic-update model: we bump the cursor entry as soon as
    /// the wire send completes — we don't wait for an explicit ack channel.
    /// LiteNetLib / Steam SDR's <c>ReliableOrdered</c> delivery guarantees
    /// the bytes will land or the connection will close (which we surface
    /// via <see cref="IsAwaitingReconnect"/>). On reconnect we keep the
    /// cursor across the grace window so we can resume "send everything
    /// the peer hasn't seen" instead of re-snapshotting 1.4 MB.</para>
    ///
    /// <para>The cursor closes two architectural gaps simultaneously:</para>
    /// <list type="bullet">
    /// <item><description>Sector-cull state loss: when a ZDO mutates while
    /// the peer is out of cull range, the dirty key is cleared after flush
    /// (it was sent to other in-range peers). With the cursor, the peer's
    /// next position-driven catch-up sweep walks the spatial set, finds
    /// every ZDO whose <c>DataRevision &gt; cursor</c>, and ships them as
    /// full-state — guaranteed convergence.</description></item>
    /// <item><description>Reconnect snapshot redundancy: instead of a full
    /// snapshot on every reconnect-during-grace, the host sends only ZDOs
    /// whose <c>DataRevision</c> changed during the disconnect window.
    /// Typical case: a few KB instead of ~88 KB compressed.</description></item>
    /// </list>
    ///
    /// <para>Memory budget: ~19 K ZDOs × 4 peers × ~16 B/entry ≈ 1.2 MB
    /// worst case. Acceptable.</para></summary>
    public Dictionary<SoDCoop.Zdo.ZDOID, uint> LastSeenRev { get; set; }
        = new Dictionary<SoDCoop.Zdo.ZDOID, uint>();
}
