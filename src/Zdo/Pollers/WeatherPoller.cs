using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side weather diff: 1 Hz over <c>SessionData.Instance</c> read of
/// <c>currentRain / currentWind / currentSnow / currentLightning / currentFog</c>.
/// Replaces the disabled <c>SessionData.SetWeather</c> postfix.
///
/// <para><b>Phase G.5 (Wave 1):</b> wire format is now pure ZDO. Five
/// float keys live on a singleton <see cref="ZdoTypeTag.Weather"/> ZDO
/// (sodId = 0); on diff > <see cref="EPSILON"/> the dirty keys flush through
/// <c>ZdoMan.TickDeltaFlush</c> → zstd-compressed
/// <see cref="Network.PacketType.ZdoDeltaBatch"/>. Receivers apply via
/// <see cref="Resolvers.WeatherResolver"/> which calls
/// <c>SessionData.SetWeather</c> under <c>WeatherSync.IsApplyingRemote</c>.</para>
///
/// <para>The legacy <c>WeatherSync.BroadcastSetWeather</c> path is no
/// longer called from this poller. <c>WeatherSync</c> stays alive only for
/// the prefix-block on clients (<c>SessionData.SetWeather</c> patch) and
/// for snapshot back-compat during cutover.</para>
/// </summary>
public static class WeatherPoller
{
    public const float TICK_HZ = 1f;
    public const string NAME   = "weather";

    private const float EPSILON = 0.005f;

    private static bool  _initialized;
    private static float _lastRain, _lastWind, _lastSnow, _lastLightning, _lastFog;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline() => _initialized = false;

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForWeather) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            var sd = SessionData.Instance;
            if (sd == null) return;

            float rain = sd.currentRain;
            float wind = sd.currentWind;
            float snow = sd.currentSnow;
            float lit  = sd.currentLightning;
            float fog  = sd.currentFog;

            if (!_initialized)
            {
                _initialized = true;
                _lastRain = rain; _lastWind = wind; _lastSnow = snow;
                _lastLightning = lit; _lastFog = fog;
                // Still write the baseline into the ZDO so a late-joiner
                // gets the current weather via ZdoSnapshot.
                WriteToZdo(rain, wind, snow, lit, fog);
                return;
            }

            if (System.Math.Abs(rain - _lastRain) < EPSILON
             && System.Math.Abs(wind - _lastWind) < EPSILON
             && System.Math.Abs(snow - _lastSnow) < EPSILON
             && System.Math.Abs(lit  - _lastLightning) < EPSILON
             && System.Math.Abs(fog  - _lastFog) < EPSILON) return;

            _lastRain = rain; _lastWind = wind; _lastSnow = snow;
            _lastLightning = lit; _lastFog = fog;

            WriteToZdo(rain, wind, snow, lit, fog);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[WeatherPoller] tick: {ex.Message}"); }
    }

    private static void WriteToZdo(float rain, float wind, float snow, float lit, float fog)
    {
        // Singleton — sodId = 0 because there's only one weather state per world.
        var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Weather, 0,
            owner: ZdoMan.LocalPeerUid, persistent: true);
        z.Set(ZdoKeys.WeatherRain,      rain);
        z.Set(ZdoKeys.WeatherWind,      wind);
        z.Set(ZdoKeys.WeatherSnow,      snow);
        z.Set(ZdoKeys.WeatherLightning, lit);
        z.Set(ZdoKeys.WeatherFog,       fog);
    }
}
