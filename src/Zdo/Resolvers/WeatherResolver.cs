using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply singleton <see cref="ZdoTypeTag.Weather"/> ZDO state to the live
/// <c>SessionData.Instance</c> on receivers via <c>SetWeather</c>. Echo
/// suppression flows through the existing
/// <see cref="SoDCoop.Sync.WeatherSync.IsApplyingRemote"/> guard and the
/// <c>SessionData.SetWeather</c> client-prefix patch (which lets the call
/// through when <c>IsApplyingRemote == true</c>).
///
/// <para>Phase G.5 (Wave 1): replaces the legacy
/// <c>WeatherSync.BroadcastSetWeather</c> wire path with pure
/// <c>ZdoDeltaBatch</c> transport. Snapshot replay on late-join carries
/// the current weather state via the same five property keys.</para>
/// </summary>
public sealed class WeatherResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Weather;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        // Host owns the weather scheduler; never apply on host (would
        // overwrite its own SoD-driven values).
        if (SoDCoop.Network.NetworkManager.IsHost) return;

        try
        {
            var sd = SessionData.Instance;
            if (sd == null) return;

            // Read all five keys; defaults to current sd.* values to avoid
            // clobbering with zeros if a partial delta arrives mid-init.
            float rain = z.GetFloat(ZdoKeys.WeatherRain,      sd.currentRain);
            float wind = z.GetFloat(ZdoKeys.WeatherWind,      sd.currentWind);
            float snow = z.GetFloat(ZdoKeys.WeatherSnow,      sd.currentSnow);
            float lit  = z.GetFloat(ZdoKeys.WeatherLightning, sd.currentLightning);
            float fog  = z.GetFloat(ZdoKeys.WeatherFog,       sd.currentFog);

            // Use the legacy IsApplyingRemote guard so the SetWeather
            // patch's prefix lets the call through and SetWeather's
            // postfix doesn't echo.
            SoDCoop.Sync.WeatherSync.ApplyFromZdo(rain, wind, snow, lit, fog);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[WeatherResolver] apply: {ex.Message}"); }
    }
}
