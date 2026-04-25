using LiteNetLib;
using LiteNetLib.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

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
    /// Local player's display name.
    /// </summary>
    public static string LocalPlayerName { get; set; } = "Player";
    
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
    private static readonly NetDataWriter _writer = new();
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
            
            // Add self to players list
            _players[LocalPlayerId] = new PlayerNetInfo
            {
                PlayerId = LocalPlayerId,
                PlayerName = LocalPlayerName,
                IsHost = true
            };
            
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
            
            _writer.Reset();
            _writer.Put(LocalPlayerName);
            
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
        
        _writer.Reset();
        _writer.Put((byte)type);
        _writer.Put(data.Data, 0, data.Length);
        
        if (IsHost)
        {
            foreach (var client in _clients)
            {
                client.Send(_writer, delivery);
            }
        }
        else
        {
            HostPeer?.Send(_writer, delivery);
        }
    }
    
    /// <summary>
    /// Send a packet to a specific peer.
    /// </summary>
    public static void SendTo(NetPeer peer, PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (peer == null) return;
        
        _writer.Reset();
        _writer.Put((byte)type);
        _writer.Put(data.Data, 0, data.Length);
        peer.Send(_writer, delivery);
    }
    
    /// <summary>
    /// Send a packet to the host (client only).
    /// </summary>
    public static void SendToHost(PacketType type, NetDataWriter data, DeliveryMethod delivery = DeliveryMethod.ReliableOrdered)
    {
        if (IsHost || HostPeer == null) return;
        
        _writer.Reset();
        _writer.Put((byte)type);
        _writer.Put(data.Data, 0, data.Length);
        HostPeer.Send(_writer, delivery);
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
        
        // Read player name from connection data
        var reader = request.Data;
        var playerName = reader.TryGetString(out var name) ? name : "Unknown";
        
        var peer = request.Accept();
        Plugin.Log.LogInfo($"Player '{playerName}' connecting from {peer.Address}:{peer.Port}");
    }
    
    private static void OnPeerConnected(NetPeer peer)
    {
        if (IsHost)
        {
            // Host: new client connected
            _clients.Add(peer);
            
            int playerId = _nextPlayerId++;
            var playerName = $"Player {playerId}"; // TODO: get from handshake
            
            _players[playerId] = new PlayerNetInfo
            {
                PlayerId = playerId,
                PlayerName = playerName,
                Peer = peer,
                IsHost = false
            };
            
            // Send player their assigned ID
            _writer.Reset();
            _writer.Put(playerId);
            _writer.Put(_players.Count);
            foreach (var player in _players.Values)
            {
                _writer.Put(player.PlayerId);
                _writer.Put(player.PlayerName);
                _writer.Put(player.IsHost);
            }
            SendTo(peer, PacketType.Handshake, _writer);
            
            // Notify existing players about new player
            _writer.Reset();
            _writer.Put(playerId);
            _writer.Put(playerName);
            foreach (var client in _clients)
            {
                if (client != peer)
                {
                    SendTo(client, PacketType.PlayerJoined, _writer);
                }
            }
            
            Plugin.Log.LogInfo($"Player '{playerName}' (ID: {playerId}) connected. Total: {_clients.Count + 1}");
            OnPlayerJoined?.Invoke(playerId, playerName);
        }
        else
        {
            // Client: connected to host
            State = ConnectionState.Connected;
            Plugin.Log.LogInfo($"Connected to host at {peer.Address}:{peer.Port}");
            OnConnected?.Invoke();
        }
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
            foreach (var kvp in _players)
            {
                if (kvp.Value.Peer == peer)
                {
                    playerId = kvp.Key;
                    playerName = kvp.Value.PlayerName;
                    break;
                }
            }
            
            if (playerId >= 0)
            {
                _players.Remove(playerId);
                
                // Notify other players
                _writer.Reset();
                _writer.Put(playerId);
                foreach (var client in _clients)
                {
                    SendTo(client, PacketType.PlayerLeft, _writer);
                }
                
                Plugin.Log.LogInfo($"Player '{playerName}' (ID: {playerId}) disconnected: {disconnectInfo.Reason}");
                OnPlayerLeft?.Invoke(playerId, playerName);
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
    
    private static void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channel, DeliveryMethod deliveryMethod)
    {
        try
        {
            var packetType = (PacketType)reader.GetByte();
            int senderId = GetPlayerIdByPeer(peer);
            
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
                    
                default:
                    // Forward to registered handlers
                    OnPacketReceived?.Invoke(packetType, reader, senderId);
                    break;
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
            
            _players[id] = new PlayerNetInfo
            {
                PlayerId = id,
                PlayerName = name,
                IsHost = isHost
            };
        }
        
        Plugin.Log.LogInfo($"Handshake complete. Assigned ID: {LocalPlayerId}. Players online: {playerCount}");
    }
    
    private static void HandlePlayerJoined(NetPacketReader reader)
    {
        int playerId = reader.GetInt();
        string playerName = reader.GetString();
        
        _players[playerId] = new PlayerNetInfo
        {
            PlayerId = playerId,
            PlayerName = playerName,
            IsHost = false
        };
        
        Plugin.Log.LogInfo($"Player '{playerName}' (ID: {playerId}) joined.");
        OnPlayerJoined?.Invoke(playerId, playerName);
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
    public string PlayerName { get; set; }
    public bool IsHost { get; set; }
    public NetPeer Peer { get; set; }
}
