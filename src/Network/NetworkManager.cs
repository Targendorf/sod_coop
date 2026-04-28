using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using SoDCoop.Player;
using SoDCoop.Sync;

namespace SoDCoop.Network;

/// <summary>
/// Connection state of the network.
/// </summary>
public enum ConnectionState
{
    Disconnected,
    Connecting,
    Connected,
    Hosting
}

/// <summary>
/// Manages P2P network connections using LiteNetLib.
/// Supports both Host-Client and Direct IP connections.
/// </summary>
public static class NetworkManager
{
    #region Constants
    
    private const int DEFAULT_PORT = 7777;
    private const string CONNECTION_KEY = "SoDCoop_v1";
    private const int MAX_PLAYERS = 4;
    private const int DISCONNECT_TIMEOUT = 5000; // ms
    private const int UPDATE_INTERVAL = 15; // ms
    
    #endregion
    
    #region Properties
    
    /// <summary>
    /// Whether this instance is the host (server).
    /// </summary>
    public static bool IsHost { get; private set; }
    
    /// <summary>
    /// Whether connected to a session (as host or client).
    /// </summary>
    public static bool IsConnected => State == ConnectionState.Connected || State == ConnectionState.Hosting;
    
    /// <summary>
    /// Current connection state.
    /// </summary>
    public static ConnectionState State { get; private set; } = ConnectionState.Disconnected;
    
    /// <summary>
    /// Local player's network ID.
    /// </summary>
    public static int LocalPlayerId { get; private set; } = -1;
    
    /// <summary>
    /// Local player's display name. Set to "FirstName Surname" once character
    /// is known (host: read from Game.Instance at StartHost; client: assigned
    /// by host via handshake or after CharacterSubmit).
    /// </summary>
    public static string LocalPlayerName { get; set; } = "Player";

    /// <summary>
    /// Local player's in-game first name. Mirrored into <see cref="LocalPlayerName"/>.
    /// </summary>
    public static string LocalFirstName { get; private set; } = "";

    /// <summary>
    /// Local player's in-game surname. Mirrored into <see cref="LocalPlayerName"/>.
    /// </summary>
    public static string LocalSurname { get; private set; } = "";

    /// <summary>
    /// Raised on the client when the host requests a character (no record yet
    /// for our clientGuid in the host's seed). Carries (hostFirstName,
    /// hostSurname, cityName) for context UI.
    /// </summary>
    public static event Action<string, string, string> OnCharacterCreationRequired;

    /// <summary>
    /// Raised on the client when the host rejects a submitted character (e.g.
    /// validation failed). Carries a human-readable reason so the creation
    /// panel can surface it to the user.
    /// </summary>
    public static event Action<string> OnCharacterRejected;
    
    /// <summary>
    /// Connected peer (for client: the host; for host: null).
    /// </summary>
    public static NetPeer HostPeer { get; private set; }
    
    /// <summary>
    /// List of connected client peers (only valid on host).
    /// </summary>
    public static IReadOnlyList<NetPeer> Clients => _clients;
    
    /// <summary>
    /// All connected players info.
    /// </summary>
    public static IReadOnlyDictionary<int, PlayerNetInfo> Players => _players;
    
    /// <summary>
    /// Current latency to host (client) or 0 (host).
    /// </summary>
    public static int Ping => HostPeer?.Ping ?? 0;
    
    #endregion
    
    #region Events
    
    public static event Action OnConnected;
    public static event Action<string> OnDisconnected;
    public static event Action<int, string> OnPlayerJoined;
    public static event Action<int, string> OnPlayerLeft;
    public static event Action<PacketType, NetPacketReader, int> OnPacketReceived;
    
    #endregion
    
    #region Private Fields
    
    private static NetManager _netManager;
    private static EventBasedNetListener _listener;
    private static readonly List<NetPeer> _clients = new();
    private static readonly Dictionary<int, PlayerNetInfo> _players = new();
    /// <summary>Used by handlers to BUILD payloads (handshake/joined/left).</summary>
    private static readonly NetDataWriter _writer = new();
    /// <summary>Used inside SendTo/SendToAll/SendToHost to WRAP payload with type-prefix.
    /// Must be distinct from <see cref="_writer"/> so callers can pass _writer as data
    /// without aliasing.</summary>
    private static readonly NetDataWriter _sendWrapper = new();
    private static int _nextPlayerId = 1;
    
    #endregion
    
    #region Initialization
    
    public static void Initialize()
    {
        Plugin.Log.LogInfo("NetworkManager initializing...");
        
        _listener = new EventBasedNetListener();
        SetupListeners();
        
        _netManager = new NetManager(_listener)
        {
            AutoRecycle = true,
            DisconnectTimeout = DISCONNECT_TIMEOUT,
            UpdateTime = UPDATE_INTERVAL,
            IPv6Enabled = false,
            NatPunchEnabled = true,
            EnableStatistics = true
        };
        
        Plugin.Log.LogInfo("NetworkManager initialized.");
    }
    
    public static void Shutdown()
    {
        Disconnect();
        _netManager?.Stop();
        _netManager = null;
        _listener = null;
        Plugin.Log.LogInfo("NetworkManager shutdown.");
    }
    
    private static void SetupListeners()
    {
        _listener.ConnectionRequestEvent += OnConnectionRequest;
        _listener.PeerConnectedEvent += OnPeerConnected;
        _listener.PeerDisconnectedEvent += OnPeerDisconnected;
        _listener.NetworkReceiveEvent += OnNetworkReceive;
        _listener.NetworkErrorEvent += OnNetworkError;
    }
    
    #endregion
    
    #region Host/Connect/Disconnect
    
    /// <summary>
    /// Start hosting a game session.
    /// </summary>
    public static bool StartHost(int port = DEFAULT_PORT)
    {
        if (IsConnected)
        {
            Plugin.Log.LogWarning("Already connected. Disconnect first.");
            return false;
        }
        
        try
        {
            if (!_netManager.Start(port))
            {
                Plugin.Log.LogError($"Failed to start host on port {port}");
                return false;
            }
            
            IsHost = true;
            State = ConnectionState.Hosting;
            LocalPlayerId = 0; // Host is always ID 0

            // Pull host's character name from SoD's Game singleton — host doesn't
            // get prompted for a nickname; their in-game character IS who they are
            // online. If the host started hosting before loading a save (degenerate
            // case), the names come back empty and we fall back to "Host".
            var (hostFirst, hostSur) = CharacterStore.ReadHostCharacter();
            if (string.IsNullOrEmpty(hostFirst) && string.IsNullOrEmpty(hostSur))
            {
                hostFirst = "Host";
                hostSur   = "";
                Plugin.Log.LogWarning("[NetworkManager] Game.Instance has no player name yet — using fallback 'Host'.");
            }
            LocalFirstName  = hostFirst;
            LocalSurname    = hostSur;
            LocalPlayerName = string.IsNullOrEmpty(hostSur) ? hostFirst : $"{hostFirst} {hostSur}";

            // Add self to players list
            _players[LocalPlayerId] = new PlayerNetInfo
            {
                PlayerId = LocalPlayerId,
                PlayerName = LocalPlayerName,
                FirstName = LocalFirstName,
                Surname = LocalSurname,
                IsHost = true,
                CharacterAssigned = true,
            };

            // Phase B.1: re-stamp every previously-assigned client twin's
            // name onto its citizen. SoD reloads citizens from the save with
            // their original procedurally-generated names; we have to
            // re-apply our overrides every host startup.
            try { TwinManager.ReapplyAll(CharacterStore.CurrentSeed()); }
            catch (Exception ex) { Plugin.Log.LogWarning($"TwinManager.ReapplyAll: {ex.Message}"); }
            
            Plugin.Log.LogInfo($"Hosting on port {port}. Waiting for players...");
            OnConnected?.Invoke();
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"Failed to start host: {ex}");
            return false;
        }
    }
    
    /// <summary>
    /// Connect to a host by IP address.
    /// </summary>
    public static bool Connect(string ip, int port = DEFAULT_PORT)
    {
        if (IsConnected)
        {
            Plugin.Log.LogWarning("Already connected. Disconnect first.");
            return false;
        }
        
        try
        {
            if (!_netManager.Start())
            {
                Plugin.Log.LogError("Failed to start client network");
                return false;
            }
            
            IsHost = false;
            State = ConnectionState.Connecting;

            // Send our stable client GUID in the connection-data so the host
            // can look up (or kick off creation of) our character record for
            // this seed. Reset cached local names — host will tell us what
            // we are after the handshake (or after CharacterSubmit roundtrip).
            LocalFirstName = "";
            LocalSurname   = "";
            LocalPlayerName = "Player";

            _writer.Reset();
            _writer.Put(CharacterIdentity.ClientGuid);

            var peer = _netManager.Connect(ip, port, _writer);
            if (peer == null)
            {
                Plugin.Log.LogError($"Failed to connect to {ip}:{port}");
                _netManager.Stop();
                State = ConnectionState.Disconnected;
                return false;
            }
            
            HostPeer = peer;
            Plugin.Log.LogInfo($"Connecting to {ip}:{port}...");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"Failed to connect: {ex}");
            State = ConnectionState.Disconnected;
            return false;
        }
    }
    
    /// <summary>
    /// Disconnect from the current session.
    /// </summary>
    public static void Disconnect()
    {
        if (!IsConnected && State != ConnectionState.Connecting) return;
        
        Plugin.Log.LogInfo("Disconnecting...");
        
        _netManager.DisconnectAll();
        _netManager.Stop();
        
        _clients.Clear();
        _players.Clear();
        
        IsHost = false;
        State = ConnectionState.Disconnected;
        LocalPlayerId = -1;
        HostPeer = null;
        
        OnDisconnected?.Invoke("User disconnected");
    }
    
    #endregion
    
    #region Send Methods
    
    /// <summary>
    /// Send a packet to all connected peers.
    /// </summary>
    public static void SendToAll(PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (!IsConnected) return;

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);

        if (IsHost)
        {
            foreach (var client in _clients)
            {
                client.Send(_sendWrapper, delivery);
            }
        }
        else
        {
            HostPeer?.Send(_sendWrapper, delivery);
        }
    }

    /// <summary>
    /// Send a packet to a specific peer.
    /// </summary>
    public static void SendTo(NetPeer peer, PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (peer == null) return;

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);
        peer.Send(_sendWrapper, delivery);
    }

    /// <summary>
    /// Send a packet to the host (client only).
    /// </summary>
    public static void SendToHost(PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (IsHost || HostPeer == null) return;

        _sendWrapper.Reset();
        _sendWrapper.Put((byte)type);
        _sendWrapper.Put(data.Data, 0, data.Length);
        HostPeer.Send(_sendWrapper, delivery);
    }
    
    #endregion
    
    #region Update
    
    public static void Update()
    {
        _netManager?.PollEvents();
    }
    
    #endregion
    
    #region Event Handlers
    
    private static void OnConnectionRequest(ConnectionRequest request)
    {
        if (!IsHost)
        {
            request.Reject();
            return;
        }
        
        if (_clients.Count >= MAX_PLAYERS - 1)
        {
            Plugin.Log.LogWarning("Connection rejected: Server full");
            request.Reject();
            return;
        }
        
        // Read the client's stable GUID from the connection-data; the host
        // uses it to look up an existing character record (or kick off
        // creation) for the current world seed.
        var reader = request.Data;
        var clientGuid = reader.TryGetString(out var guid) ? guid : "";
        if (string.IsNullOrEmpty(clientGuid))
        {
            Plugin.Log.LogWarning($"Connection rejected: missing client GUID from {request.RemoteEndPoint}");
            request.Reject();
            return;
        }

        var peer = request.Accept();
        peer.Tag = clientGuid;
        Plugin.Log.LogInfo($"Client GUID '{clientGuid}' connecting from {peer.Address}:{peer.Port}");
    }

    private static void OnPeerConnected(NetPeer peer)
    {
        if (IsHost)
        {
            // Host: new client connected. Branch on whether we already have a
            // character record for their guid in the current world seed.
            // We deliberately do NOT add the peer to _clients yet — that's
            // done in AssignCharacterAndCompleteHandshake once we know they
            // have a name. Otherwise SendToAll would broadcast world state
            // to a peer that hasn't received its handshake yet.
            int playerId = _nextPlayerId++;
            string clientGuid = (peer.Tag as string) ?? "";
            string seed = CharacterStore.CurrentSeed();

            // Reserve a slot but mark not-yet-assigned so we don't broadcast a
            // half-formed peer to others until we have a real name.
            _players[playerId] = new PlayerNetInfo
            {
                PlayerId = playerId,
                PlayerName = $"Player {playerId}",
                Peer = peer,
                IsHost = false,
                ClientGuid = clientGuid,
                CharacterAssigned = false,
            };

            var existing = CharacterStore.TryGet(seed, clientGuid);
            if (existing != null)
            {
                Plugin.Log.LogInfo($"[NetworkManager] returning client {clientGuid} → {existing.FirstName} {existing.Surname}");
                AssignCharacterAndCompleteHandshake(peer, playerId, existing.FirstName, existing.Surname);
            }
            else
            {
                Plugin.Log.LogInfo($"[NetworkManager] new client {clientGuid} for seed \"{seed}\" — requesting character creation");
                SendCharacterCreationRequired(peer);
            }
        }
        else
        {
            // Client: TCP connection established. We do NOT fire OnConnected
            // yet — that waits until the full Handshake arrives (which the
            // host sends either immediately or after our CharacterSubmit
            // round-trip).
            State = ConnectionState.Connected;
            Plugin.Log.LogInfo($"Connected to host at {peer.Address}:{peer.Port} (waiting for handshake / character flow)");
        }
    }

    /// <summary>
    /// Host-only. Sends a CharacterRejected packet with a human-readable
    /// reason. The client's creation panel surfaces the reason in red and
    /// stays open for re-submission.
    /// </summary>
    private static void SendCharacterRejected(NetPeer peer, string reason)
    {
        _writer.Reset();
        _writer.Put(reason ?? "Character rejected by host.");
        SendTo(peer, PacketType.CharacterRejected, _writer);
    }

    /// <summary>
    /// Host-only. Sends the CharacterCreationRequired packet to a peer that
    /// has no record yet for this world seed. Carries the host's own
    /// character name + city name as context for the creation UI.
    /// </summary>
    private static void SendCharacterCreationRequired(NetPeer peer)
    {
        string cityName = CharacterStore.CurrentCityName();

        _writer.Reset();
        _writer.Put(LocalFirstName ?? "");
        _writer.Put(LocalSurname ?? "");
        _writer.Put(cityName ?? "");
        SendTo(peer, PacketType.CharacterCreationRequired, _writer);
    }

    /// <summary>
    /// Host-only. Promotes a peer from "pending character" to "fully joined":
    /// stamps the assigned name into PlayerNetInfo, sends Handshake to the new
    /// peer (so it learns the full player list incl. itself), and broadcasts
    /// PlayerJoined to existing peers so they see the new player appear.
    /// </summary>
    private static void AssignCharacterAndCompleteHandshake(NetPeer peer, int playerId, string firstName, string surName)
    {
        if (!_players.TryGetValue(playerId, out var info))
        {
            Plugin.Log.LogWarning($"[NetworkManager] AssignCharacter: no PlayerNetInfo for {playerId}");
            return;
        }

        info.FirstName = firstName ?? "";
        info.Surname   = surName ?? "";
        info.PlayerName = string.IsNullOrEmpty(info.Surname)
            ? info.FirstName
            : $"{info.FirstName} {info.Surname}";
        info.CharacterAssigned = true;

        // Now that the peer has a name, add them to the broadcast list so
        // they start receiving world-state SendToAll traffic.
        if (!_clients.Contains(peer)) _clients.Add(peer);

        // Send the new client its full handshake (player list incl. itself).
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

        // Notify existing peers (everyone except the new joiner).
        _writer.Reset();
        _writer.Put(playerId);
        _writer.Put(info.PlayerName);
        _writer.Put(info.FirstName ?? "");
        _writer.Put(info.Surname ?? "");
        foreach (var client in _clients)
        {
            if (client != peer)
            {
                SendTo(client, PacketType.PlayerJoined, _writer);
            }
        }

        Plugin.Log.LogInfo($"Player '{info.PlayerName}' (ID: {playerId}) fully joined. Total: {_clients.Count + 1}");
        OnPlayerJoined?.Invoke(playerId, info.PlayerName);

        // Phase SJ.2: push current side-job state to the freshly-joined peer
        // so they see all jobs that already exist (we only broadcast on
        // create / state-change otherwise — mid-session joiners would miss
        // everything generated before they connected).
        try { SoDCoop.Sync.SideJobSync.SendSnapshotTo(peer); }
        catch (Exception ex) { Plugin.Log.LogWarning($"SideJobSync.SendSnapshotTo: {ex.Message}"); }
    }
    
    private static void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
    {
        if (IsHost)
        {
            // Host: client disconnected
            _clients.Remove(peer);

            // Find and remove player
            int playerId = -1;
            string playerName = "Unknown";
            bool wasAssigned = false;
            foreach (var kvp in _players)
            {
                if (kvp.Value.Peer == peer)
                {
                    playerId = kvp.Key;
                    playerName = kvp.Value.PlayerName;
                    wasAssigned = kvp.Value.CharacterAssigned;
                    break;
                }
            }

            if (playerId >= 0)
            {
                _players.Remove(playerId);

                // Only notify other peers if this player had actually been
                // announced to them via PlayerJoined. Pre-character-creation
                // disconnects are silent — no one else knew they existed.
                if (wasAssigned)
                {
                    _writer.Reset();
                    _writer.Put(playerId);
                    foreach (var client in _clients)
                    {
                        SendTo(client, PacketType.PlayerLeft, _writer);
                    }
                    Plugin.Log.LogInfo($"Player '{playerName}' (ID: {playerId}) disconnected: {disconnectInfo.Reason}");
                    OnPlayerLeft?.Invoke(playerId, playerName);
                }
                else
                {
                    Plugin.Log.LogInfo($"Pending peer (ID: {playerId}) gave up before character creation: {disconnectInfo.Reason}");
                }
            }
        }
        else
        {
            // Client: disconnected from host
            State = ConnectionState.Disconnected;
            HostPeer = null;
            _players.Clear();
            
            Plugin.Log.LogInfo($"Disconnected from host: {disconnectInfo.Reason}");
            OnDisconnected?.Invoke(disconnectInfo.Reason.ToString());
        }
    }
    
    /// <summary>
    /// Used for star-topology rebroadcast: when host receives a packet from
    /// client A, it must forward the same bytes to clients B, C, ... so all
    /// peers see each other's events. Distinct from <see cref="_sendWrapper"/>
    /// to avoid aliasing during nested dispatch.
    /// </summary>
    private static readonly NetDataWriter _forwardWrapper = new();

    /// <summary>
    /// Packet types that are NOT host-rebroadcast to other clients.
    /// Mostly handshake / connection-flow packets that have specific
    /// host↔single-peer semantics, plus packets host already broadcasts
    /// itself via SendToAll (HostStatus, SideJobNotification).
    /// </summary>
    private static bool IsForwardableFromClient(PacketType type)
    {
        switch (type)
        {
            case PacketType.Handshake:                  // host→client only
            case PacketType.PlayerJoined:               // host→client only
            case PacketType.PlayerLeft:                 // host→client only
            case PacketType.CharacterCreationRequired:  // host→single client
            case PacketType.CharacterSubmit:            // client→host only (no fan-out)
            case PacketType.CharacterReset:             // client→host only
            case PacketType.CharacterRejected:          // host→single client
            case PacketType.HostStatus:                 // host originates, already SendToAll
            case PacketType.SideJobNotification:        // host originates
            case PacketType.SideJobAcceptRequest:       // client→host only; host re-broadcasts upsert
            case PacketType.SideJobHandInRequest:       // client→host only; host re-broadcasts upsert
                return false;
            default:
                return true;
        }
    }

    private static void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channel, DeliveryMethod deliveryMethod)
    {
        try
        {
            var packetType = (PacketType)reader.GetByte();
            int senderId = GetPlayerIdByPeer(peer);

            // Host-side star-topology rebroadcast: capture the body bytes
            // BEFORE dispatch (which advances the reader), then forward to
            // all *other* clients after dispatch completes. The originating
            // peer is skipped to avoid self-echo. Sender preservation: the
            // SenderId field inside the packet body stays at the original
            // client's LocalPlayerId (host-assigned), so receiving clients
            // correctly distinguish "from peer N" vs their own echo.
            byte[] forwardBody = null;
            int    forwardBodyLen = 0;
            if (IsHost && _clients.Count >= 2 && IsForwardableFromClient(packetType))
            {
                try
                {
                    forwardBodyLen = reader.AvailableBytes;
                    if (forwardBodyLen > 0)
                    {
                        forwardBody = new byte[forwardBodyLen];
                        System.Buffer.BlockCopy(reader.RawData, reader.Position, forwardBody, 0, forwardBodyLen);
                    }
                }
                catch (System.Exception ex)
                {
                    Plugin.Log.LogWarning($"OnNetworkReceive forward-capture: {ex.Message}");
                    forwardBody = null;
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
                    // Forward to registered handlers
                    OnPacketReceived?.Invoke(packetType, reader, senderId);
                    break;
            }

            // Star-topology forward to other clients (host only). After
            // dispatch so any host-side modification (e.g. forensics
            // attribution remap on Apply) has had a chance to run on the
            // host's local state. Body bytes themselves are forwarded raw
            // so receiving clients see the same SenderId / payload the
            // originating client sent.
            if (forwardBody != null && _clients.Count >= 2)
            {
                try
                {
                    _forwardWrapper.Reset();
                    _forwardWrapper.Put((byte)packetType);
                    _forwardWrapper.Put(forwardBody, 0, forwardBodyLen);
                    foreach (var c in _clients)
                    {
                        if (c == peer) continue; // skip originator
                        c.Send(_forwardWrapper, deliveryMethod);
                    }
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogWarning($"OnNetworkReceive forward-send: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"Error processing packet: {ex}");
        }
    }
    
    private static void OnNetworkError(IPEndPoint endPoint, SocketError error)
    {
        Plugin.Log.LogError($"Network error from {endPoint}: {error}");
    }
    
    #endregion
    
    #region Packet Handlers
    
    private static void HandleHandshake(NetPacketReader reader)
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

            // Mirror our own character into the local fields used by the rest
            // of the codebase (chat, nametags, HUD).
            if (id == LocalPlayerId)
            {
                LocalFirstName  = firstName;
                LocalSurname    = surName;
                LocalPlayerName = name;
            }
        }

        Plugin.Log.LogInfo($"Handshake complete. Assigned ID: {LocalPlayerId}. Players online: {playerCount}. I am '{LocalPlayerName}'.");

        // NOW we can fire OnConnected — the lobby flow is allowed to proceed.
        OnConnected?.Invoke();
    }

    private static void HandlePlayerJoined(NetPacketReader reader)
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

    /// <summary>
    /// Client-side. Host has no character record for our (seed, clientGuid)
    /// pair — surfaces the host's name + city name to the UI so it can show
    /// "Welcome to &lt;city&gt;! Create your character." Also raises
    /// <see cref="OnCharacterCreationRequired"/> so the menu opens the
    /// creation panel.
    /// </summary>
    private static void HandleCharacterCreationRequired(NetPacketReader reader)
    {
        string hostFirst = reader.GetString();
        string hostSur   = reader.GetString();
        string cityName  = reader.GetString();

        Plugin.Log.LogInfo($"[NetworkManager] host requested character creation (host: \"{hostFirst} {hostSur}\", city: \"{cityName}\")");
        OnCharacterCreationRequired?.Invoke(hostFirst, hostSur, cityName);
    }

    /// <summary>
    /// Host-side. A client has just submitted the first/surname for their
    /// character. Validate, persist, then complete the deferred handshake.
    /// </summary>
    private static void HandleCharacterSubmit(NetPacketReader reader, NetPeer peer)
    {
        if (!IsHost) return;

        string firstName = reader.GetString();
        string surName   = reader.GetString();

        int playerId = -1;
        PlayerNetInfo info = null;
        foreach (var kvp in _players)
        {
            if (kvp.Value.Peer == peer) { playerId = kvp.Key; info = kvp.Value; break; }
        }
        if (info == null)
        {
            Plugin.Log.LogWarning($"[NetworkManager] CharacterSubmit from unknown peer {peer.Address}:{peer.Port}");
            return;
        }
        if (info.CharacterAssigned)
        {
            Plugin.Log.LogWarning($"[NetworkManager] CharacterSubmit but {playerId} is already assigned — ignoring resubmission.");
            return;
        }

        // Server-side validation. The client UI also validates, but never
        // trust the wire.
        var err = CharacterStore.ValidateName(firstName) ?? CharacterStore.ValidateName(surName);
        if (err != null)
        {
            Plugin.Log.LogWarning($"[NetworkManager] rejected character submit: {err}");
            SendCharacterRejected(peer, err);
            return;
        }

        string seed = CharacterStore.CurrentSeed();
        var saved = CharacterStore.Save(seed, info.ClientGuid, firstName, surName);

        // Phase B.1: pick (or re-confirm) a city citizen as this client's
        // in-world identity, and stamp the chosen name onto that Human so
        // SoD's NPC dialog / IDs / banking see them as a real person. The
        // resulting humanID is persisted into the same record.
        int twinHumanID = TwinManager.EnsureTwinAssigned(seed, saved);
        if (twinHumanID > 0)
            Plugin.Log.LogInfo($"[NetworkManager] {firstName} {surName} → twin citizen humanID={twinHumanID}");

        AssignCharacterAndCompleteHandshake(peer, playerId, firstName, surName);
    }

    /// <summary>
    /// Client-side. Host rejected our submitted character (validation failed).
    /// Surfaces the reason via <see cref="OnCharacterRejected"/> so the
    /// creation panel can show it in red.
    /// </summary>
    private static void HandleCharacterRejected(NetPacketReader reader)
    {
        string reason = reader.GetString();
        Plugin.Log.LogWarning($"[NetworkManager] host rejected our character: {reason}");
        OnCharacterRejected?.Invoke(reason);
    }

    /// <summary>
    /// Host-side. A client requested to forget its character record on this
    /// world. We delete the record + unfreeze their old twin citizen + kick
    /// the peer. The client is responsible for wiping its own local
    /// clientGuid (see <see cref="Player.CharacterIdentity.Reset"/>).
    /// </summary>
    private static void HandleCharacterReset(NetPeer peer)
    {
        if (!IsHost) return;

        // Find the player's record by peer.
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
            Plugin.Log.LogWarning($"[NetworkManager] CharacterReset from peer {peer.Address}:{peer.Port} with no clientGuid — ignoring.");
            return;
        }

        Plugin.Log.LogInfo($"[NetworkManager] CharacterReset from playerId={playerId} clientGuid={clientGuid}");

        try { TwinManager.ReleaseRecord(CharacterStore.CurrentSeed(), clientGuid); }
        catch (Exception ex) { Plugin.Log.LogWarning($"TwinManager.ReleaseRecord: {ex.Message}"); }

        // Disconnect the peer with a reason. Client-side OnPeerDisconnected
        // will fire and the UI will route back to Main; we trust the client
        // to call CharacterIdentity.Reset() locally before reconnecting.
        try { peer.Disconnect(); } catch { }
    }

    /// <summary>
    /// Client-only. Asks the host to forget our character record on its
    /// world. Triggers a host-initiated disconnect; the caller should then
    /// wipe the local clientGuid via <see cref="Player.CharacterIdentity.Reset"/>.
    /// </summary>
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
    
    private static void HandlePlayerLeft(NetPacketReader reader)
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
    
    private static int GetPlayerIdByPeer(NetPeer peer)
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

    /// <summary>
    /// Display name — kept for backwards-compat with everything that already
    /// reads <see cref="PlayerName"/> (chat, nametags, HUD). Always set to
    /// "<see cref="FirstName"/> <see cref="Surname"/>" once the character is
    /// known.
    /// </summary>
    public string PlayerName { get; set; }

    /// <summary>In-game first name. Empty until character creation completes.</summary>
    public string FirstName { get; set; } = "";

    /// <summary>In-game surname. Empty until character creation completes.</summary>
    public string Surname { get; set; } = "";

    public bool IsHost { get; set; }
    public NetPeer Peer { get; set; }

    /// <summary>
    /// Stable per-installation identifier (only meaningful on the host, used
    /// to look up the persisted character record per-seed). Empty for the
    /// host's own self-record.
    /// </summary>
    public string ClientGuid { get; set; } = "";

    /// <summary>
    /// Host-side flag: false during the brief window between LiteNetLib
    /// connect and character creation completion. While false, the player
    /// is NOT broadcast to other clients (no PlayerJoined fired) so they
    /// don't see a half-formed peer.
    /// </summary>
    public bool CharacterAssigned { get; set; }
}
