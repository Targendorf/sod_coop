using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Lightweight phone-call notification sync.
///
/// PhoneCall objects in SoD are tightly coupled to audio events, dialog presets,
/// case schedules and AI conversation graphs — replaying them across the wire
/// would be very fragile. So instead of trying to replicate the call itself we
/// just emit a "📞 caller is on the phone" HUD banner on every connected peer
/// when the host's TelephoneController begins/ends a call.
///
/// SoD's call scheduler runs on every machine (deterministic from seed) so each
/// client locally hears their own ringing — what we add is a unified UI cue so
/// players can comment on calls without one of them being mute.
/// </summary>
public static class PhoneSync
{
    private const float BANNER_LIFETIME = 5f;

    private static readonly NetDataWriter _writer = new();

    private struct ActiveBanner
    {
        public string Text;
        public float ExpiresAt;
    }
    private static readonly List<ActiveBanner> _banners = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound (host)
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastCallStart(int callerHumanId, string callerName)
        => BroadcastIncoming(callerHumanId, callerName, isStarting: true);

    public static void BroadcastCallEnd(int callerHumanId, string callerName)
        => BroadcastIncoming(callerHumanId, callerName, isStarting: false);

    /// <summary>
    /// Host-authoritative broadcast for INCOMING calls (NPC → host's phone).
    /// Each machine independently sees its own incoming calls (deterministic
    /// from world seed), but we keep host-only broadcast here as a backstop
    /// and so the host's own banner appears.
    /// </summary>
    private static void BroadcastIncoming(int callerHumanId, string callerName, bool isStarting)
    {
        if (!NetworkManager.IsConnected) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var packet = new PhoneCallNotifyPacket
            {
                CallerHumanId = callerHumanId,
                CallerName    = callerName ?? "",
                IsStarting    = isStarting,
                CalleeName    = "",
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PhoneCallNotify, _writer, DeliveryMethod.ReliableOrdered);
            ShowBanner(packet);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PhoneSync.BroadcastIncoming: {ex.Message}");
        }
    }

    /// <summary>
    /// Broadcast for OUTGOING player calls (local player → NPC). Anyone can
    /// initiate a call (host or client), so this is broadcast from whoever's
    /// the caller. Banner reads "📞 PlayerName is calling NpcName".
    /// </summary>
    public static void BroadcastOutgoingPlayerCall(string callerPlayerName, string calleeName, bool isStarting)
    {
        if (!NetworkManager.IsConnected) return;

        try
        {
            var packet = new PhoneCallNotifyPacket
            {
                CallerHumanId = NetworkManager.LocalPlayerId,
                CallerName    = callerPlayerName ?? "Player",
                IsStarting    = isStarting,
                CalleeName    = calleeName ?? "Unknown",
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PhoneCallNotify, _writer, DeliveryMethod.ReliableOrdered);
            // Don't show our own banner — we already see the in-game phone UI.
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PhoneSync.BroadcastOutgoingPlayerCall: {ex.Message}");
        }
    }

    /// <summary>
    /// Resolve a Human's display name for the banner. Returns the citizen's
    /// citizenName if available, else "Unknown".
    /// </summary>
    public static string ResolveCallerName(int humanId)
    {
        try
        {
            if (humanId < 0) return "Unknown";
            var dict = CityData.Instance?.citizenDictionary;
            if (dict != null && dict.TryGetValue(humanId, out var human) && human != null)
                return human.citizenName ?? "Unknown";
        }
        catch { }
        return "Unknown";
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type != PacketType.PhoneCallNotify) return;

        try
        {
            var p = new PhoneCallNotifyPacket();
            p.Deserialize(reader);
            ShowBanner(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"PhoneSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ShowBanner(PhoneCallNotifyPacket p)
    {
        var caller = string.IsNullOrEmpty(p.CallerName) ? "Unknown" : p.CallerName;
        var verb   = p.IsStarting ? "is calling"        : "hung up";
        string text;
        if (!string.IsNullOrEmpty(p.CalleeName))
        {
            // Outgoing player call.
            text = p.IsStarting
                ? $"📞 {caller} is calling {p.CalleeName}"
                : $"📞 {caller} hung up on {p.CalleeName}";
        }
        else
        {
            // Incoming NPC call (or host-authoritative legacy path).
            text = $"📞 {caller} {verb}";
        }

        _banners.Add(new ActiveBanner
        {
            Text       = text,
            ExpiresAt  = Time.unscaledTime + BANNER_LIFETIME,
        });

        Plugin.Log.LogDebug($"[PhoneSync] banner: {text}");
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Render — banners stack at top-right; auto-expire
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnGUI()
    {
        if (_banners.Count == 0) return;

        float now = Time.unscaledTime;
        for (int i = _banners.Count - 1; i >= 0; i--)
        {
            if (_banners[i].ExpiresAt < now) _banners.RemoveAt(i);
        }
        if (_banners.Count == 0) return;

        const float w = 260f, h = 26f, padding = 6f;
        float x = Screen.width - w - 12f;
        float y = 44f;       // sit below the pause banner

        var bgPrev = GUI.color;
        var style = new GUIStyle
        {
            alignment = TextAnchor.MiddleCenter,
            fontStyle = FontStyle.Bold,
            fontSize  = 13,
        };
        style.normal.textColor = Color.black;

        for (int i = 0; i < _banners.Count; i++)
        {
            var b = _banners[i];
            float life = (b.ExpiresAt - now) / BANNER_LIFETIME;       // 1→0
            float alpha = Mathf.Clamp01(life * 1.6f);                 // fade at the end
            var rect = new Rect(x, y, w, h);

            GUI.color = new Color(0.4f, 0.85f, 1f, 0.85f * alpha);    // pale-cyan banner
            GUI.Box(rect, "");
            GUI.color = new Color(0f, 0f, 0f, alpha);
            GUI.Label(rect, b.Text, style);

            y += h + padding;
        }

        GUI.color = bgPrev;
    }

    public static void Clear() => _banners.Clear();
}
