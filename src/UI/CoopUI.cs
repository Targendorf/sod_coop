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
        // Each overlay is independently gated by a CoopSettings toggle so the
        // user can hide individual pieces from the Settings panel.
        if (NetworkManager.IsConnected)
        {
            if (CoopSettings.ShowNameTags?.Value      ?? true) NameTagOverlay.Draw();
            if (CoopSettings.ShowStatusHUD?.Value     ?? true) DrawPlayerListHUD();
            if (CoopSettings.ShowChatWindow?.Value    ?? true) DrawChatWindow();
        }

        // Reconnect banner: visible only while the auto-reconnect loop is
        // actively retrying. World state is preserved beneath; this is just
        // a heads-up so the player doesn't think the game froze.
        if (NetworkManager.State == SoDCoop.Network.ConnectionState.Reconnecting)
            DrawReconnectBanner();

        // Patch-install banner: visible while the progressive Harmony
        // installer is draining its queue right after Host / Join was
        // clicked. Tells the user "I'm still setting things up" so a
        // half-second of laggy menu doesn't look like a freeze.
        if (Plugin.IsInstallingPatches)
            DrawPatchInstallBanner();
    }

    private static void DrawPatchInstallBanner()
    {
        try
        {
            int total     = Mathf.Max(1, Plugin.PatchTypesTotal);
            int remaining = Plugin.PatchTypesRemaining;
            int done      = Mathf.Clamp(total - remaining, 0, total);
            float frac    = (float)done / total;

            float w = 380f;
            float h = 56f;
            // Position lower than the reconnect banner so they can co-exist
            // visually if both fire (rare — but the install one is most
            // common right after click-Host on a fresh session).
            float yOffset = NetworkManager.State == SoDCoop.Network.ConnectionState.Reconnecting ? 130f : 60f;
            var rect = new Rect((Screen.width - w) * 0.5f, yOffset, w, h);

            var prevColor = GUI.color;

            // Backdrop.
            GUI.color = new Color(0f, 0f, 0f, 0.85f);
            GUI.DrawTexture(rect, Texture2D.whiteTexture);

            // Amber border.
            GUI.color = new Color(0.95f, 0.62f, 0.20f, 1f);
            GUI.DrawTexture(new Rect(rect.x, rect.y, rect.width, 2f), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(rect.x, rect.y + rect.height - 2f, rect.width, 2f), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(rect.x, rect.y, 2f, rect.height), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(rect.x + rect.width - 2f, rect.y, 2f, rect.height), Texture2D.whiteTexture);

            // Progress bar inside, near the bottom edge.
            var barOuter = new Rect(rect.x + 12f, rect.y + rect.height - 14f, rect.width - 24f, 6f);
            GUI.color = new Color(0.20f, 0.20f, 0.24f, 1f);
            GUI.DrawTexture(barOuter, Texture2D.whiteTexture);
            var barFill = new Rect(barOuter.x, barOuter.y, barOuter.width * frac, barOuter.height);
            GUI.color = new Color(0.95f, 0.62f, 0.20f, 1f);
            GUI.DrawTexture(barFill, Texture2D.whiteTexture);

            // Label.
            GUI.color = new Color(0.96f, 0.94f, 0.86f, 1f);
            var style = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.UpperCenter,
                fontSize = 14,
                fontStyle = FontStyle.Bold,
                wordWrap = false,
            };
            var labelRect = new Rect(rect.x, rect.y + 6f, rect.width, 22f);
            GUI.Label(labelRect, $"🔧  Setting up co-op sync…  {done} / {total}", style);

            GUI.color = prevColor;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DrawPatchInstallBanner: {ex.Message}");
        }
    }

    private static void DrawReconnectBanner()
    {
        try
        {
            float elapsed = NetworkManager.ReconnectingSeconds;
            float total   = NetworkManager.ReconnectingTimeoutS;
            string reason = NetworkManager.LastDisconnectReason;

            float w = 380f;
            float h = 56f;
            var rect = new Rect((Screen.width - w) * 0.5f, 60f, w, h);

            var prevColor = GUI.color;

            // Soft black backdrop.
            GUI.color = new Color(0f, 0f, 0f, 0.85f);
            GUI.DrawTexture(rect, Texture2D.whiteTexture);

            // Amber border (use a thin overlay rect for a 2px outline feel).
            GUI.color = new Color(0.95f, 0.62f, 0.20f, 1f);
            GUI.DrawTexture(new Rect(rect.x, rect.y, rect.width, 2f), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(rect.x, rect.y + rect.height - 2f, rect.width, 2f), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(rect.x, rect.y, 2f, rect.height), Texture2D.whiteTexture);
            GUI.DrawTexture(new Rect(rect.x + rect.width - 2f, rect.y, 2f, rect.height), Texture2D.whiteTexture);

            GUI.color = new Color(0.96f, 0.94f, 0.86f, 1f);
            var style = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 16,
                fontStyle = FontStyle.Bold,
                wordWrap = true,
            };
            string body = string.IsNullOrEmpty(reason)
                ? $"🔌  Connection lost — reconnecting…  {elapsed:F0}s / {total:F0}s"
                : $"🔌  Connection lost ({reason}) — reconnecting…  {elapsed:F0}s / {total:F0}s";
            GUI.Label(rect, body, style);

            GUI.color = prevColor;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DrawReconnectBanner: {ex.Message}");
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

            // Host→other-clients fan-out is now handled generically in
            // NetworkManager.OnNetworkReceive (star-topology forward) — we
            // don't manually rebroadcast here anymore.
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
