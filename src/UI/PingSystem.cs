using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.UI;

/// <summary>
/// Map ping system: middle-mouse drops a world marker that all other players see.
///
/// Local: on MMB-down, raycast from the camera. Hit = ping point; miss = drop at
/// camera-forward * 50m. Send MapPingPacket to peers.
///
/// Receive: append to _activePings; OnGUI projects each ping's world position
/// into screen space and draws a small marker + the sender's name. Pings expire
/// after LIFETIME seconds.
///
/// Plus pause overlay: tracks Time.timeScale locally; when it transitions
/// 0↔non-0 we send PauseStatePacket so others see a banner.
/// </summary>
public static class PingSystem
{
    #region Tuning

    private const KeyCode PING_KEY        = KeyCode.Mouse2;     // middle mouse
    private const float   PING_RAY_RANGE  = 200f;
    private const float   LIFETIME        = 8f;                 // seconds
    private const float   MARKER_SIZE_NEAR = 22f;
    private const float   MARKER_SIZE_FAR  = 10f;

    #endregion

    private struct ActivePing
    {
        public int     PlayerId;
        public string  PlayerName;
        public Vector3 Position;
        public float   ExpiresAt;
    }

    private static readonly List<ActivePing> _activePings = new();
    private static readonly NetDataWriter _writer = new();

    // Pause tracking
    private static bool _wasPausedLocally;
    /// <summary>Per-player remote pause state, used by HUD overlay.</summary>
    private static readonly Dictionary<int, bool> _remotePaused = new();

    // -------------------------------------------------------------------------

    public static void Update()
    {
        if (!NetworkManager.IsConnected) return;

        // Drop expired pings.
        float now = Time.unscaledTime;
        for (int i = _activePings.Count - 1; i >= 0; i--)
        {
            if (_activePings[i].ExpiresAt < now)
                _activePings.RemoveAt(i);
        }

        // Local input — middle mouse drops a ping.
        try
        {
            if (Input.GetKeyDown(PING_KEY))
                TryDropLocalPing();
        }
        catch { }

        // Pause-state polling — the SessionData.TogglePause Harmony patch is the
        // primary signal, but we also poll Time.timeScale as a fallback in case
        // SoD takes a code path the patch doesn't cover (alt-tab, focus loss, ...).
        try
        {
            bool paused = Time.timeScale == 0f;
            if (paused != _wasPausedLocally)
            {
                _wasPausedLocally = paused;
                BroadcastPauseState(paused);
            }
        }
        catch { }
    }

    /// <summary>
    /// Called from the SessionData.TogglePause Harmony patch — gives us a clean
    /// signal exactly when SoD flips its own pause state, no timing guesswork.
    /// </summary>
    public static void NotifyLocalPauseChanged(bool isPaused)
    {
        if (isPaused == _wasPausedLocally) return;
        _wasPausedLocally = isPaused;
        BroadcastPauseState(isPaused);
    }

    // -------------------------------------------------------------------------
    //  Ping outbound
    // -------------------------------------------------------------------------

    private static void TryDropLocalPing()
    {
        var cam = Camera.main;
        if (cam == null) return;

        Vector3 origin = cam.transform.position;
        Vector3 dir    = cam.transform.forward;

        Vector3 pingPos;
        if (Physics.Raycast(origin, dir, out var hit, PING_RAY_RANGE,
                            ~0, QueryTriggerInteraction.Ignore))
        {
            pingPos = hit.point;
        }
        else
        {
            pingPos = origin + dir * 50f;
        }

        // Show locally immediately.
        AppendPing(NetworkManager.LocalPlayerId, NetworkManager.LocalPlayerName ?? "You", pingPos);

        // Phase G: dispatch via ZdoEventRpc when the flag is on.
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            // Reuse the existing writer to build payload: name + pos.
            _writer.Reset();
            _writer.Put(NetworkManager.LocalPlayerName ?? "Player");
            _writer.Put(pingPos.x); _writer.Put(pingPos.y); _writer.Put(pingPos.z);
            SoDCoop.Zdo.ZdoEventDispatcher.Send(SoDCoop.Zdo.ZdoEvents.MAP_PING, _writer, LiteNetLib.DeliveryMethod.ReliableOrdered);
        }
        else
        {
            var packet = new MapPingPacket
            {
                PlayerId   = NetworkManager.LocalPlayerId,
                PlayerName = NetworkManager.LocalPlayerName ?? "Player",
                Position   = pingPos,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.MapPing, _writer, DeliveryMethod.ReliableOrdered);
        }
    }

    /// <summary>Public entry for ZdoEvents.OnMapPing handler. Surfaces a
    /// remote ping to the existing AppendPing rendering path.</summary>
    public static void AppendRemotePing(int senderId, string playerName, UnityEngine.Vector3 pos)
    {
        if (senderId == NetworkManager.LocalPlayerId) return;
        AppendPing(senderId, playerName ?? "?", pos);
    }

    // -------------------------------------------------------------------------
    //  Pause outbound
    // -------------------------------------------------------------------------

    private static void BroadcastPauseState(bool paused)
    {
        try
        {
            // Phase G: dispatch via ZdoEventRpc when the flag is on.
            if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
            {
                _writer.Reset();
                _writer.Put(NetworkManager.LocalPlayerId);
                _writer.Put(paused);
                SoDCoop.Zdo.ZdoEventDispatcher.Send(SoDCoop.Zdo.ZdoEvents.PAUSE_BANNER, _writer);
            }
            else
            {
                var packet = new PauseStatePacket
                {
                    PlayerId = NetworkManager.LocalPlayerId,
                    IsPaused = paused,
                };
                _writer.Reset();
                packet.Serialize(_writer);
                NetworkManager.SendToAll(PacketType.PauseState, _writer, DeliveryMethod.ReliableOrdered);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastPauseState: {ex.Message}");
        }
    }

    /// <summary>Public entry for ZdoEvents.OnPauseBanner. Updates the
    /// per-player paused-flag map used by the chat panel.</summary>
    public static void HandlePauseBanner(int senderPlayerId, bool paused)
    {
        if (senderPlayerId == NetworkManager.LocalPlayerId) return;
        _remotePaused[senderPlayerId] = paused;
    }

    // -------------------------------------------------------------------------
    //  Receive
    // -------------------------------------------------------------------------

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.MapPing)
            {
                var p = new MapPingPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                AppendPing(p.PlayerId, p.PlayerName, p.Position);
            }
            else if (type == PacketType.PauseState)
            {
                var p = new PauseStatePacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                _remotePaused[p.PlayerId] = p.IsPaused;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"PingSystem.OnPacketReceived({type}): {ex.Message}");
        }
    }

    private static void AppendPing(int playerId, string name, Vector3 pos)
    {
        _activePings.Add(new ActivePing
        {
            PlayerId   = playerId,
            PlayerName = name ?? "",
            Position   = pos,
            ExpiresAt  = Time.unscaledTime + LIFETIME,
        });
    }

    // -------------------------------------------------------------------------
    //  Render
    // -------------------------------------------------------------------------

    private static GUIStyle _labelStyle;
    private static Texture2D _dotTex;

    public static void OnGUI()
    {
        if (!NetworkManager.IsConnected) return;

        DrawPings();
        DrawPauseOverlay();
    }

    private static void DrawPings()
    {
        if (_activePings.Count == 0) return;

        var cam = Camera.main;
        if (cam == null) return;

        if (_dotTex == null)
        {
            _dotTex = new Texture2D(2, 2);
            for (int x = 0; x < 2; x++)
                for (int y = 0; y < 2; y++)
                    _dotTex.SetPixel(x, y, Color.white);
            _dotTex.Apply();
        }

        if (_labelStyle == null)
        {
            _labelStyle = new GUIStyle();
            _labelStyle.alignment = TextAnchor.MiddleCenter;
            _labelStyle.fontStyle = FontStyle.Bold;
            _labelStyle.normal.textColor = Color.white;
        }

        float now = Time.unscaledTime;
        for (int i = 0; i < _activePings.Count; i++)
        {
            var ping = _activePings[i];

            Vector3 sp = cam.WorldToScreenPoint(ping.Position);
            if (sp.z <= 0f) continue;  // behind camera

            float ageT      = (ping.ExpiresAt - now) / LIFETIME;          // 1→0 over lifetime
            float dist      = sp.z;
            float size      = Mathf.Lerp(MARKER_SIZE_FAR, MARKER_SIZE_NEAR,
                                         Mathf.Clamp01(1f - dist / 80f));
            float alpha     = Mathf.Clamp01(ageT * 1.5f);                  // fade out last 0.66s
            // Small bobbing animation
            float bob       = Mathf.Sin(now * 4f) * 3f;
            float screenX   = sp.x;
            float screenY   = Screen.height - sp.y + bob;                  // GUI y-down

            // Marker dot (yellow)
            var prev = GUI.color;
            GUI.color = new Color(1f, 0.85f, 0.10f, alpha);
            GUI.DrawTexture(new Rect(screenX - size / 2f, screenY - size / 2f, size, size), _dotTex);

            // Label below the dot
            GUI.color = new Color(1f, 1f, 1f, alpha);
            _labelStyle.fontSize = (int)Mathf.Lerp(11, 16, Mathf.Clamp01(1f - dist / 60f));
            GUI.Label(new Rect(screenX - 100f, screenY + size / 2f + 2f, 200f, 22f),
                $"{ping.PlayerName} pinged here", _labelStyle);
            GUI.color = prev;
        }
    }

    private static void DrawPauseOverlay()
    {
        // Find any remote player currently paused.
        if (_remotePaused.Count == 0) return;

        string pausedName = null;
        foreach (var kv in _remotePaused)
        {
            if (!kv.Value) continue;
            if (NetworkManager.Players.TryGetValue(kv.Key, out var info))
                pausedName = info.PlayerName;
            else
                pausedName = $"Player {kv.Key}";
            break; // show first one
        }

        if (pausedName == null) return;

        // Banner at top-center.
        const float w = 320f, h = 28f;
        var rect = new Rect((Screen.width - w) / 2f, 8f, w, h);

        var prev = GUI.color;
        GUI.color = new Color(0.95f, 0.85f, 0.20f, 0.85f);
        GUI.Box(rect, "");
        GUI.color = Color.black;
        var style = new GUIStyle { alignment = TextAnchor.MiddleCenter, fontStyle = FontStyle.Bold };
        style.normal.textColor = Color.black;
        GUI.Label(rect, $"⏸ {pausedName} is in menu", style);
        GUI.color = prev;
    }

    // -------------------------------------------------------------------------

    public static void ClearAll()
    {
        _activePings.Clear();
        _remotePaused.Clear();
        _wasPausedLocally = false;
    }
}
