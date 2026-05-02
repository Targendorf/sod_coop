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
                if (SteamNetworkingSockets.GetQuickConnectionStatus(HostPeer.Connection, out var s))
                    return s.m_nPing;
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

        // Hook the Steam transport callbacks once, statically. Multiple
        // Initialize/Shutdown cycles within one process re-use them.
        SteamCallbacks.Initialize();
        SteamTransport.OnPeerConnected     += HandleTransportPeerConnected;
        SteamTransport.OnPeerDisconnected  += HandleTransportPeerDisconnected;
        SteamTransport.OnConnected         += HandleTransportClientConnected;
        SteamTransport.OnConnectFailed     += HandleTransportConnectFailed;
        SteamTransport.OnMessage           += HandleTransportMessage;

        Plugin.Log.LogInfo("NetworkManager initialized.");
    }

    public static void Shutdown()
    {
        Disconnect();
        SteamTransport.OnPeerConnected     -= HandleTransportPeerConnected;
        SteamTransport.OnPeerDisconnected  -= HandleTransportPeerDisconnected;
        SteamTransport.OnConnected         -= HandleTransportClientConnected;
        SteamTransport.OnConnectFailed     -= HandleTransportConnectFailed;
        SteamTransport.OnMessage           -= HandleTransportMessage;
        SteamTransport.Shutdown();
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
    public static bool StartHost()
    {
        if (IsConnected || State == ConnectionState.Connecting)
        {
            Plugin.Log.LogWarning("Already connected. Disconnect first.");
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

        SteamLobby.CreateLobbyAsync();
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

        SteamTransport.CloseAllPeers("user disconnect");
        SteamLobby.LeaveLobby();

        _clients.Clear();
        _players.Clear();

        IsHost = false;
        State = ConnectionState.Disconnected;
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

        _players[LocalPlayerId] = new PlayerNetInfo
        {
            PlayerId = LocalPlayerId,
            PlayerName = LocalPlayerName,
            FirstName = LocalFirstName,
            Surname = LocalSurname,
            IsHost = true,
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

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);

        if (IsHost)
        {
            for (int i = 0; i < _clients.Count; i++)
            {
                SteamTransport.Send(_clients[i], _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
            }
        }
        else if (HostPeer != null)
        {
            SteamTransport.Send(HostPeer, _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
        }
    }

    public static void SendTo(SteamPeer peer, PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (peer == null) return;

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);
        SteamTransport.Send(peer, _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
    }

    public static void SendToHost(PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (IsHost || HostPeer == null) return;

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);
        SteamTransport.Send(HostPeer, _sendWrapper.Data, 0, _sendWrapper.Length, delivery);
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
        SteamTransport.Pump();

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
            var snap = SteamTransport.Snapshot();
            int peers = IsHost ? _clients.Count : (HostPeer != null ? 1 : 0);
            Plugin.Log.LogInfo(
                $"[NetStats] peers={peers} (steam) ping={snap.pingMs}ms");
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
            Plugin.Log.LogWarning($"[NetworkManager] reject {peer.SteamId.m_SteamID} — server full.");
            SteamTransport.CloseConnection(peer, "server full");
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

        int playerId = -1;
        PlayerNetInfo info = null;
        foreach (var kvp in _players)
        {
            if (kvp.Value.Peer == peer)
            {
                playerId = kvp.Key;
                info = kvp.Value;
                break;
            }
        }

        if (playerId < 0 || info == null) return;

        if (!info.CharacterAssigned)
        {
            _players.Remove(playerId);
            Plugin.Log.LogInfo($"Pending peer (ID: {playerId}) gave up before character creation: {reason}");
            return;
        }

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
        _writer.Reset();
        _writer.Put(CharacterIdentity.ClientGuid);
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

    private static bool IsForwardableFromClient(PacketType type)
    {
        switch (type)
        {
            case PacketType.Handshake:
            case PacketType.PlayerJoined:
            case PacketType.PlayerLeft:
            case PacketType.CharacterCreationRequired:
            case PacketType.CharacterSubmit:
            case PacketType.CharacterReset:
            case PacketType.CharacterRejected:
            case PacketType.HostStatus:
            case PacketType.SideJobNotification:
            case PacketType.SideJobAcceptRequest:
            case PacketType.SideJobHandInRequest:
                return false;
            default:
                return true;
        }
    }

    /// <summary>Receives a fully-framed message from the Steam transport.
    /// Wire format: <c>byte type + payload bytes</c> (same as the LiteNetLib
    /// era; the type byte was prepended in SendToAll/SendTo/SendToHost).</summary>
    private static void HandleTransportMessage(SteamPeer peer, byte[] payload, int length)
    {
        try
        {
            var reader = new NetDataReader(payload, 0, length);
            var packetType = (PacketType)reader.GetByte();
            int senderId = GetPlayerIdByPeer(peer);

            // Capture body before dispatch (which advances the reader) so
            // we can rebroadcast to other clients.
            byte[] forwardBody = null;
            int forwardBodyLen = 0;
            if (IsHost && _clients.Count >= 2 && IsForwardableFromClient(packetType))
            {
                forwardBodyLen = reader.AvailableBytes;
                if (forwardBodyLen > 0)
                {
                    forwardBody = new byte[forwardBodyLen];
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

                    // Best-effort: forward at the same delivery class. The
                    // transport-level message we just received doesn't tell
                    // us which channel was used, so default to ReliableOrdered
                    // for forwarded traffic (matches the legacy default).
                    for (int i = 0; i < _clients.Count; i++)
                    {
                        var c = _clients[i];
                        if (c == peer) continue;
                        SteamTransport.Send(c, _forwardWrapper.Data, 0, _forwardWrapper.Length, DeliveryMethod.ReliableOrdered);
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
        }
        SendTo(peer, PacketType.Handshake, _writer);

        _writer.Reset();
        _writer.Put(playerId);
        _writer.Put(info.PlayerName);
        _writer.Put(info.FirstName ?? "");
        _writer.Put(info.Surname ?? "");
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

        try { SoDCoop.Sync.SideJobSync.SendSnapshotTo(peer); }    catch (Exception ex) { Plugin.Log.LogWarning($"SideJobSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Sync.VmailSync.SendSnapshotTo(peer); }      catch (Exception ex) { Plugin.Log.LogWarning($"VmailSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Sync.EvidenceSync.SendSnapshotTo(peer); }   catch (Exception ex) { Plugin.Log.LogWarning($"EvidenceSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Sync.WorldStateSync.SendSnapshotTo(peer); } catch (Exception ex) { Plugin.Log.LogWarning($"WorldStateSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Sync.CaseBoardSync.SendSnapshotTo(peer); }  catch (Exception ex) { Plugin.Log.LogWarning($"CaseBoardSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Sync.ItemSync.SendSnapshotTo(peer); }       catch (Exception ex) { Plugin.Log.LogWarning($"ItemSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Sync.FootprintSync.SendSnapshotTo(peer); }  catch (Exception ex) { Plugin.Log.LogWarning($"FootprintSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Sync.AppearanceSync.SendSnapshotTo(peer); } catch (Exception ex) { Plugin.Log.LogWarning($"AppearanceSync.SendSnapshotTo: {ex.Message}"); }
        try { SoDCoop.Zdo.ZdoMan.SendSnapshotTo(peer); }          catch (Exception ex) { Plugin.Log.LogWarning($"ZdoMan.SendSnapshotTo: {ex.Message}"); }
    }

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

            _players[id] = new PlayerNetInfo
            {
                PlayerId = id,
                PlayerName = name,
                FirstName = firstName,
                Surname = surName,
                IsHost = isHost,
                CharacterAssigned = true,
            };

            if (id == LocalPlayerId)
            {
                LocalFirstName = firstName;
                LocalSurname = surName;
                LocalPlayerName = name;
            }
        }

        Plugin.Log.LogInfo($"Handshake complete. Assigned ID: {LocalPlayerId}. Players online: {playerCount}. I am '{LocalPlayerName}'.");
        OnConnected?.Invoke();
    }

    private static void HandlePlayerJoined(NetDataReader reader)
    {
        int playerId = reader.GetInt();
        string playerName = reader.GetString();
        string firstName = reader.GetString();
        string surName = reader.GetString();

        _players[playerId] = new PlayerNetInfo
        {
            PlayerId = playerId,
            PlayerName = playerName,
            FirstName = firstName,
            Surname = surName,
            IsHost = false,
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
            string guid = reader.GetString();
            if (string.IsNullOrEmpty(guid))
            {
                Plugin.Log.LogWarning($"[NetworkManager] bootstrap CharacterSubmit from {peer.DisplayName} carried empty GUID — disconnecting.");
                SteamTransport.CloseConnection(peer, "missing client GUID");
                return;
            }

            info.ClientGuid = guid;
            peer.ClientGuid = guid;

            // Reconnect path: same clientGuid is in the grace window. Restore
            // the existing slot, swap in the new SteamPeer reference, send a
            // fresh Handshake so they re-sync. Drop the freshly-allocated slot.
            var (existingId, existingInfo) = FindPendingReconnect(guid);
            if (existingId >= 0 && existingInfo != null && existingId != playerId)
            {
                Plugin.Log.LogInfo($"[NetworkManager] reconnect: restoring playerId={existingId} ({existingInfo.PlayerName}) for {peer.SteamId.m_SteamID}");
                _players.Remove(playerId); // discard the bootstrap slot
                existingInfo.Peer = peer;
                existingInfo.DisconnectedAt = 0f;
                if (!_clients.Contains(peer)) _clients.Add(peer);

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
                }
                SendTo(peer, PacketType.Handshake, _writer);

                try { SoDCoop.Sync.SideJobSync.SendSnapshotTo(peer); }    catch (Exception ex) { Plugin.Log.LogWarning($"SideJobSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                try { SoDCoop.Sync.VmailSync.SendSnapshotTo(peer); }      catch (Exception ex) { Plugin.Log.LogWarning($"VmailSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                try { SoDCoop.Sync.EvidenceSync.SendSnapshotTo(peer); }   catch (Exception ex) { Plugin.Log.LogWarning($"EvidenceSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                try { SoDCoop.Sync.WorldStateSync.SendSnapshotTo(peer); } catch (Exception ex) { Plugin.Log.LogWarning($"WorldStateSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                try { SoDCoop.Sync.CaseBoardSync.SendSnapshotTo(peer); }  catch (Exception ex) { Plugin.Log.LogWarning($"CaseBoardSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                try { SoDCoop.Sync.ItemSync.SendSnapshotTo(peer); }       catch (Exception ex) { Plugin.Log.LogWarning($"ItemSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                try { SoDCoop.Sync.FootprintSync.SendSnapshotTo(peer); }  catch (Exception ex) { Plugin.Log.LogWarning($"FootprintSync.SendSnapshotTo (reconnect): {ex.Message}"); }
                try { SoDCoop.Sync.AppearanceSync.SendSnapshotTo(peer); } catch (Exception ex) { Plugin.Log.LogWarning($"AppearanceSync.SendSnapshotTo (reconnect): {ex.Message}"); }
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

        try { SteamTransport.CloseConnection(peer, "character reset"); } catch { }
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

    private static int GetPlayerIdByPeer(SteamPeer peer)
    {
        foreach (var kvp in _players)
        {
            if (kvp.Value.Peer == peer)
                return kvp.Key;
        }
        return -1;
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

    public bool CharacterAssigned { get; set; }
    public float DisconnectedAt { get; set; }
    public bool IsAwaitingReconnect => DisconnectedAt > 0f;
}
