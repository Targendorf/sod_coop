using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;

namespace SoDCoop.Sync;

/// <summary>
/// Host-authoritative weather sync.
///
/// SoD drives weather through <c>SessionData.SetWeather(rain, wind, snow, lightning, fog,
/// transitionSpeed, instant)</c> on a <c>weatherChangeTimer</c>. We let the host run that
/// scheduler normally and broadcast every SetWeather call. Clients have their local
/// SetWeather blocked at the prefix unless the call originates from <see cref="IsApplyingRemote"/>,
/// so the only weather they ever see is what the host tells them.
///
/// On every player-joined event, the host re-broadcasts its current weather state so
/// late-joiners snap to the right look immediately.
/// </summary>
public static class WeatherSync
{
    /// <summary>
    /// True while we're applying a packet from the host. The SetWeather prefix
    /// honours this flag to let the call through; the postfix honours it to skip
    /// re-broadcasting (avoids the echo loop on the host as well, harmlessly).
    /// </summary>
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();
    private static bool _hooked;

    public static void Initialize()
    {
        if (_hooked) return;
        // Host pushes a fresh snapshot to whoever connects. Existing peers re-apply
        // idempotently (same values → SoD's SetWeather is a no-op transition target).
        NetworkManager.OnPlayerJoined += OnPlayerJoined;
        _hooked = true;
    }

    public static void Shutdown()
    {
        if (!_hooked) return;
        NetworkManager.OnPlayerJoined -= OnPlayerJoined;
        _hooked = false;
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound (host only)
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Broadcast a SetWeather call. Host-only; if a client somehow ends up here
    /// (shouldn't, the prefix blocks them) we still no-op.
    /// </summary>
    public static void BroadcastSetWeather(
        float rain, float wind, float snow, float lightning, float fog,
        float transitionSpeed, bool instant)
    {
        if (!NetworkManager.IsConnected) return;
        if (!NetworkManager.IsHost) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new WeatherStatePacket
            {
                Rain = rain, Wind = wind, Snow = snow,
                Lightning = lightning, Fog = fog,
                TransitionSpeed = transitionSpeed,
                Instant = instant,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.WeatherSync, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastSetWeather: {ex.Message}");
        }
    }

    /// <summary>
    /// Read SessionData's current weather state and broadcast it. Used to give a
    /// fresh snapshot to a just-joined client, and any time we want to force a resync.
    /// </summary>
    public static void BroadcastCurrentWeather(bool instant = false)
    {
        try
        {
            var sd = SessionData.Instance;
            if (sd == null) return;

            BroadcastSetWeather(
                sd.currentRain, sd.currentWind, sd.currentSnow,
                sd.currentLightning, sd.currentFog,
                transitionSpeed: instant ? 1f : 0.1f,
                instant: instant);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastCurrentWeather: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type != PacketType.WeatherSync) return;

        try
        {
            var p = new WeatherStatePacket();
            p.Deserialize(reader);
            ApplyWeather(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"WeatherSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyWeather(WeatherStatePacket p)
        => ApplyFromZdo(p.Rain, p.Wind, p.Snow, p.Lightning, p.Fog, p.TransitionSpeed, p.Instant);

    /// <summary>
    /// ZDO entry-point — invoked from <c>WeatherResolver.Apply</c> after a
    /// <see cref="ZdoTypeTag.Weather"/> delta arrives. Mirrors the legacy
    /// packet apply path (same SetWeather call, same IsApplyingRemote
    /// guard) but skips the per-feature legacy wire entirely.
    /// </summary>
    public static void ApplyFromZdo(float rain, float wind, float snow,
                                    float lightning, float fog,
                                    float transitionSpeed = 0.1f, bool instant = false)
    {
        var sd = SessionData.Instance;
        if (sd == null) return;

        IsApplyingRemote = true;
        try
        {
            sd.SetWeather(rain, wind, snow, lightning, fog, transitionSpeed, instant);
            Plugin.Log.LogInfo(
                $"[WeatherSync] applied (zdo) rain={rain:F2} wind={wind:F2} snow={snow:F2} " +
                $"lit={lightning:F2} fog={fog:F2} instant={instant}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"WeatherSync.ApplyFromZdo: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Events
    // ─────────────────────────────────────────────────────────────────────────

    private static void OnPlayerJoined(int playerId, string playerName)
    {
        // Only the host pushes weather; clients ignore.
        if (!NetworkManager.IsHost) return;
        try
        {
            BroadcastCurrentWeather(instant: false);
            Plugin.Log.LogInfo($"[WeatherSync] sent current weather to new peer {playerName} ({playerId})");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"WeatherSync.OnPlayerJoined({playerId}): {ex.Message}");
        }
    }
}
