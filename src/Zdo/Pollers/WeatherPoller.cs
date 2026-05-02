using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side weather diff: 1 Hz over <c>SessionData.Instance</c> read of
/// <c>currentRain / currentWind / currentSnow / currentLightning / currentFog</c>.
/// Replaces the disabled <c>SessionData.SetWeather</c> Harmony patch at
/// <c>src/Patches/GamePatches.cs</c>.
///
/// <para>Reuses the existing <see cref="Sync.WeatherSync.BroadcastSetWeather"/>
/// helper as the transport — same packet, same apply path on receivers — so
/// the migration is purely about the trigger source (poller diff vs Harmony
/// postfix). When SoD's own weather scheduler mutates the live values, the
/// poller catches it on the next tick and pushes the change.</para>
///
/// <para>Epsilon = 0.005f — coarser than visible perception, fine enough to
/// catch any genuine weather-state transition. Keeps idle weather from
/// emitting noise broadcasts when SoD's interpolation jitters by 0.0001.</para>
/// </summary>
public static class WeatherPoller
{
    public const float TICK_HZ = 1f;
    public const string NAME   = "weather";

    private const float EPSILON = 0.005f;

    private static bool  _initialized;
    private static float _lastRain, _lastWind, _lastSnow, _lastLightning, _lastFog;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _initialized = false;
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForWeather) return;
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
                return;
            }

            if (System.Math.Abs(rain - _lastRain) < EPSILON
             && System.Math.Abs(wind - _lastWind) < EPSILON
             && System.Math.Abs(snow - _lastSnow) < EPSILON
             && System.Math.Abs(lit  - _lastLightning) < EPSILON
             && System.Math.Abs(fog  - _lastFog) < EPSILON) return;

            _lastRain = rain; _lastWind = wind; _lastSnow = snow;
            _lastLightning = lit; _lastFog = fog;

            // Re-use legacy transport — packet, dispatch, IsApplyingRemote echo
            // suppression all already exist in WeatherSync. Migration is about
            // the trigger source, not the wire format.
            try
            {
                Sync.WeatherSync.BroadcastSetWeather(rain, wind, snow, lit, fog,
                    transitionSpeed: 0.1f, instant: false);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[WeatherPoller] broadcast: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[WeatherPoller] tick: {ex.Message}"); }
    }
}
