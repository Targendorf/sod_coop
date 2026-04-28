using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.UI;

/// <summary>
/// Main UI controller for the co-op mod.
/// Provides Host/Join interface, player list, and chat.
/// </summary>
public static class CoopUI
{
    #region State
    
    private static bool _showUI;
    private static UIState _currentState = UIState.MainMenu;
    private static string _connectIP = "127.0.0.1";
    private static string _connectPort = "7777";
    private static string _hostPort = "7777";
    private static string _playerName = "Player";
    private static string _chatInput = "";
    private static readonly List<ChatMessage> _chatMessages = new();
    private static Vector2 _chatScrollPosition;
    private static readonly NetDataWriter _chatWriter = new();
    
    #endregion
    
    #region Constants
    
    private const KeyCode TOGGLE_KEY = KeyCode.F9;
    private const float WINDOW_WIDTH = 350f;
    private const float WINDOW_HEIGHT = 450f;
    
    #endregion
    
    #region Window Rects
    
    private static Rect _mainWindowRect;
    private static Rect _chatWindowRect;
    
    #endregion
    
    public static void Initialize()
    {
        Plugin.Log.LogInfo("CoopUI initializing...");
        
        // Center main window
        _mainWindowRect = new Rect(
            (Screen.width - WINDOW_WIDTH) / 2,
            (Screen.height - WINDOW_HEIGHT) / 2,
            WINDOW_WIDTH,
            WINDOW_HEIGHT
        );
        
        // Position chat in bottom-left
        _chatWindowRect = new Rect(10, Screen.height - 250, 350, 240);
        
        // Load saved player name
        _playerName = PlayerPrefs.GetString("SoDCoop_PlayerName", "Player");
        
        // Subscribe to network events
        NetworkManager.OnConnected += OnConnected;
        NetworkManager.OnDisconnected += OnDisconnected;
        NetworkManager.OnPlayerJoined += OnPlayerJoined;
        NetworkManager.OnPlayerLeft += OnPlayerLeft;
        
        Plugin.Log.LogInfo("CoopUI initialized. Press F9 to open.");
    }
    
    public static void Shutdown()
    {
        NetworkManager.OnConnected -= OnConnected;
        NetworkManager.OnDisconnected -= OnDisconnected;
        NetworkManager.OnPlayerJoined -= OnPlayerJoined;
        NetworkManager.OnPlayerLeft -= OnPlayerLeft;
    }
    
    public static void Update()
    {
        // Toggle the new Canvas-based co-op menu with F9. The legacy IMGUI
        // window is no longer used for the lobby flow — see CoopMenuController.
        if (Input.GetKeyDown(TOGGLE_KEY))
        {
            try { SoDCoop.UI.Coop.CoopMenuController.Toggle(); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"Coop menu toggle: {ex.Message}"); }
        }

        // Drive the new menu's per-frame poll (lobby / host status refresh).
        try { SoDCoop.UI.Coop.CoopMenuController.Update(); } catch { }
    }

    public static void OnGUI()
    {
        // In-world overlays remain IMGUI: nametags, player vitals HUD, chat.
        // The lobby / setup menu is now a Canvas (CoopMenuController), so we
        // intentionally don't draw the old GUILayout.Window here anymore.
        if (NetworkManager.IsConnected)
        {
            NameTagOverlay.Draw();
            DrawPlayerListHUD();
            DrawChatWindow();
        }
    }
    
    private static void DrawMainWindow(int windowId)
    {
        GUILayout.BeginVertical();
        
        switch (_currentState)
        {
            case UIState.MainMenu:
                DrawMainMenu();
                break;
            case UIState.Hosting:
                DrawHostingScreen();
                break;
            case UIState.Connecting:
                DrawConnectingScreen();
                break;
            case UIState.Lobby:
                DrawLobbyScreen();
                break;
            case UIState.InGame:
                DrawInGameScreen();
                break;
        }
        
        GUILayout.EndVertical();
        GUI.DragWindow();
    }
    
    private static void DrawMainMenu()
    {
        GUILayout.Label("Welcome to Shadow of Doubt Co-op!", GUI.skin.label);
        GUILayout.Space(20);
        
        // Player name
        GUILayout.Label("Your Name:");
        _playerName = GUILayout.TextField(_playerName, 20);
        NetworkManager.LocalPlayerName = _playerName;
        
        GUILayout.Space(20);
        
        // Host section
        GUILayout.Label("── Host Game ──", GUI.skin.label);
        GUILayout.BeginHorizontal();
        GUILayout.Label("Port:", GUILayout.Width(50));
        _hostPort = GUILayout.TextField(_hostPort, 6);
        GUILayout.EndHorizontal();
        
        if (GUILayout.Button("Host Game", GUILayout.Height(40)))
        {
            SavePlayerName();
            if (int.TryParse(_hostPort, out int port))
            {
                if (NetworkManager.StartHost(port))
                {
                    _currentState = UIState.Lobby;
                }
            }
        }
        
        GUILayout.Space(20);
        
        // Join section
        GUILayout.Label("── Join Game ──", GUI.skin.label);
        GUILayout.BeginHorizontal();
        GUILayout.Label("IP:", GUILayout.Width(30));
        _connectIP = GUILayout.TextField(_connectIP);
        GUILayout.Label(":", GUILayout.Width(10));
        _connectPort = GUILayout.TextField(_connectPort, 6, GUILayout.Width(60));
        GUILayout.EndHorizontal();
        
        if (GUILayout.Button("Join Game", GUILayout.Height(40)))
        {
            SavePlayerName();
            if (int.TryParse(_connectPort, out int port))
            {
                if (NetworkManager.Connect(_connectIP, port))
                {
                    _currentState = UIState.Connecting;
                }
            }
        }
        
        GUILayout.FlexibleSpace();
        
        // Close button
        if (GUILayout.Button("Close"))
        {
            _showUI = false;
        }
    }
    
    private static void DrawHostingScreen()
    {
        GUILayout.Label("Hosting game...", GUI.skin.label);
        GUILayout.Label($"Port: {_hostPort}");
        GUILayout.Label($"Status: {NetworkManager.State}");
        
        GUILayout.FlexibleSpace();
        
        if (GUILayout.Button("Stop Hosting"))
        {
            NetworkManager.Disconnect();
            _currentState = UIState.MainMenu;
        }
    }
    
    private static void DrawConnectingScreen()
    {
        GUILayout.Label("Connecting...", GUI.skin.label);
        GUILayout.Label($"Server: {_connectIP}:{_connectPort}");
        GUILayout.Label($"Status: {NetworkManager.State}");
        
        GUILayout.FlexibleSpace();
        
        if (GUILayout.Button("Cancel"))
        {
            NetworkManager.Disconnect();
            _currentState = UIState.MainMenu;
        }
    }
    
    private static void DrawLobbyScreen()
    {
        GUILayout.Label("── Lobby ──", GUI.skin.label);
        GUILayout.Space(10);
        
        // Connection info
        if (NetworkManager.IsHost)
        {
            GUILayout.Label($"Hosting on port {_hostPort}");
            GUILayout.Label("Share your IP with friends to connect!");
        }
        else
        {
            GUILayout.Label($"Connected to {_connectIP}:{_connectPort}");
            GUILayout.Label($"Ping: {NetworkManager.Ping}ms");
        }
        
        GUILayout.Space(10);
        
        // Player list
        GUILayout.Label("Players:");
        GUILayout.BeginVertical(GUI.skin.box);
        foreach (var player in NetworkManager.Players.Values)
        {
            string prefix = player.IsHost ? "[HOST] " : "";
            string you = player.PlayerId == NetworkManager.LocalPlayerId ? " (You)" : "";
            GUILayout.Label($"{prefix}{player.PlayerName}{you}");
        }
        GUILayout.EndVertical();
        
        GUILayout.FlexibleSpace();
        
        // Disconnect button
        if (GUILayout.Button("Disconnect", GUILayout.Height(30)))
        {
            NetworkManager.Disconnect();
            _currentState = UIState.MainMenu;
        }
        
        // Close button
        if (GUILayout.Button("Close (stay connected)"))
        {
            _showUI = false;
        }
    }
    
    private static void DrawInGameScreen()
    {
        DrawLobbyScreen(); // Same as lobby for now
    }
    
    /// <summary>
    /// Persistent top-right player list shown whenever connected — independent of F9.
    /// Does not steal mouse input (uses GUI.Label + a non-interactive Box).
    /// </summary>
    private static void DrawPlayerListHUD()
    {
        var players = NetworkManager.Players;
        if (players == null) return;

        const float w = 240f, lineH = 18f, barH = 5f, barGap = 2f, pad = 6f;
        float rowH = lineH + (barH + barGap) * 3 + 4f;
        float h = pad * 2 + lineH + players.Count * rowH;
        var rect = new Rect(Screen.width - w - 10f, 10f, w, h);

        GUI.Box(rect, "");
        GUI.Label(new Rect(rect.x + pad, rect.y + pad, rect.width - pad * 2, lineH),
            $"Players online: {players.Count}");

        int i = 0;
        foreach (var p in players.Values)
        {
            float rowY = rect.y + pad + lineH + i * rowH;

            string prefix = p.IsHost ? "[H] " : "    ";
            string suffix = p.PlayerId == NetworkManager.LocalPlayerId ? "  (you)" : "";

            // Vitals — local from Player.Instance, remote from PlayerSync cache.
            float nour = 1f, hyd = 1f, ene = 1f;
            bool dead = false;
            if (p.PlayerId == NetworkManager.LocalPlayerId)
            {
                try
                {
                    var local = global::Player.Instance;
                    if (local != null)
                    {
                        nour = local.nourishment;
                        hyd  = local.hydration;
                        ene  = local.energy;
                        dead = local.isDead;
                    }
                }
                catch { }
            }
            else if (Sync.PlayerSync.RemoteVitals.TryGetValue(p.PlayerId, out var v))
            {
                nour = PlayerVitalsPacket.Unpack(v.Nourishment);
                hyd  = PlayerVitalsPacket.Unpack(v.Hydration);
                ene  = PlayerVitalsPacket.Unpack(v.Energy);
                dead = v.IsDead;
            }

            string deadTag = dead ? "  X" : "";
            GUI.Label(new Rect(rect.x + pad, rowY, rect.width - pad * 2, lineH),
                $"{prefix}{p.PlayerName}{suffix}{deadTag}");

            float barX = rect.x + pad;
            float barW = rect.width - pad * 2;
            float by = rowY + lineH;
            DrawBar(new Rect(barX, by, barW, barH), nour, new Color(0.85f, 0.55f, 0.10f));
            DrawBar(new Rect(barX, by + barH + barGap, barW, barH), hyd, new Color(0.20f, 0.55f, 0.95f));
            DrawBar(new Rect(barX, by + (barH + barGap) * 2, barW, barH), ene, new Color(0.95f, 0.85f, 0.20f));

            i++;
        }
    }

    private static Texture2D _barFill;
    private static Texture2D _barBg;
    private static void DrawBar(Rect r, float fill01, Color color)
    {
        if (_barBg == null)   _barBg   = MakeTexture(2, 2, new Color(0.05f, 0.05f, 0.05f, 0.8f));
        if (_barFill == null) _barFill = MakeTexture(2, 2, Color.white);

        GUI.DrawTexture(r, _barBg);
        if (fill01 > 0f)
        {
            var prev = GUI.color;
            GUI.color = color;
            GUI.DrawTexture(new Rect(r.x, r.y, r.width * Mathf.Clamp01(fill01), r.height), _barFill);
            GUI.color = prev;
        }
    }

    private static void DrawChatWindow()
    {
        _chatWindowRect = GUILayout.Window(
            12346,
            _chatWindowRect,
            (GUI.WindowFunction)DrawChatWindowContent,
            "Chat"
        );
    }
    
    private static void DrawChatWindowContent(int windowId)
    {
        GUILayout.BeginVertical();
        
        // Chat messages
        _chatScrollPosition = GUILayout.BeginScrollView(
            _chatScrollPosition,
            GUILayout.Height(170)
        );
        
        foreach (var msg in _chatMessages)
        {
            GUILayout.Label($"[{msg.PlayerName}]: {msg.Text}");
        }
        
        GUILayout.EndScrollView();
        
        // Input field
        GUILayout.BeginHorizontal();
        _chatInput = GUILayout.TextField(_chatInput, 100);
        
        if (GUILayout.Button("Send", GUILayout.Width(60)) || 
            (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return && GUI.GetNameOfFocusedControl() == "chatInput"))
        {
            SendChatMessage();
        }
        GUILayout.EndHorizontal();
        
        GUILayout.EndVertical();
        GUI.DragWindow();
    }
    
    private static void SendChatMessage()
    {
        if (string.IsNullOrWhiteSpace(_chatInput)) return;
        if (!NetworkManager.IsConnected) { _chatInput = ""; return; }

        // Show locally first.
        AddChatMessage(NetworkManager.LocalPlayerId, _playerName, _chatInput);

        // Build and send.
        var packet = new ChatMessagePacket
        {
            PlayerId = NetworkManager.LocalPlayerId,
            PlayerName = _playerName,
            Message = _chatInput,
            Timestamp = Time.unscaledTime,
        };
        _chatWriter.Reset();
        packet.Serialize(_chatWriter);
        NetworkManager.SendToAll(PacketType.ChatMessage, _chatWriter, DeliveryMethod.ReliableOrdered);

        _chatInput = "";
    }

    /// <summary>Called by SyncManager on incoming PacketType.ChatMessage.</summary>
    public static void OnChatPacketReceived(NetPacketReader reader, int senderId)
    {
        try
        {
            var packet = new ChatMessagePacket();
            packet.Deserialize(reader);

            // Don't double-display our own messages (we add them locally on send).
            if (packet.PlayerId == NetworkManager.LocalPlayerId) return;

            AddChatMessage(packet.PlayerId, packet.PlayerName, packet.Message);

            // Host: rebroadcast to all OTHER clients so 3+ player chats fan out.
            if (NetworkManager.IsHost)
            {
                var fwd = new NetDataWriter();
                packet.Serialize(fwd);
                foreach (var client in NetworkManager.Clients)
                {
                    // Skip the original sender (we don't have its peer here cheaply, so just send to all;
                    // sender will filter via PlayerId == LocalPlayerId on its end).
                    NetworkManager.SendTo(client, PacketType.ChatMessage, fwd, DeliveryMethod.ReliableOrdered);
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"OnChatPacketReceived: {ex.Message}");
        }
    }
    
    public static void AddChatMessage(int playerId, string playerName, string text)
    {
        _chatMessages.Add(new ChatMessage
        {
            PlayerId = playerId,
            PlayerName = playerName,
            Text = text,
            Timestamp = Time.time
        });
        
        // Keep only last 50 messages
        while (_chatMessages.Count > 50)
        {
            _chatMessages.RemoveAt(0);
        }
        
        // Scroll to bottom
        _chatScrollPosition = new Vector2(0, float.MaxValue);
    }
    
    #region Helpers
    
    private static void SavePlayerName()
    {
        PlayerPrefs.SetString("SoDCoop_PlayerName", _playerName);
        PlayerPrefs.Save();
    }
    
    private static Texture2D MakeTexture(int width, int height, Color color)
    {
        Color[] pixels = new Color[width * height];
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = color;
        }
        
        Texture2D texture = new Texture2D(width, height);
        texture.SetPixels(pixels);
        texture.Apply();
        return texture;
    }
    
    #endregion
    
    #region Event Handlers
    
    private static void OnConnected()
    {
        _currentState = UIState.Lobby;
        AddChatMessage(-1, "System", "Connected to session!");
    }
    
    private static void OnDisconnected(string reason)
    {
        _currentState = UIState.MainMenu;
        AddChatMessage(-1, "System", $"Disconnected: {reason}");
    }
    
    private static void OnPlayerJoined(int playerId, string playerName)
    {
        AddChatMessage(-1, "System", $"{playerName} joined the game.");
    }
    
    private static void OnPlayerLeft(int playerId, string playerName)
    {
        AddChatMessage(-1, "System", $"{playerName} left the game.");
    }
    
    #endregion
}

/// <summary>
/// UI state machine states.
/// </summary>
public enum UIState
{
    MainMenu,
    Hosting,
    Connecting,
    Lobby,
    InGame
}

/// <summary>
/// Chat message data.
/// </summary>
public struct ChatMessage
{
    public int PlayerId;
    public string PlayerName;
    public string Text;
    public float Timestamp;
}
