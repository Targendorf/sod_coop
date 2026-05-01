namespace SoDCoop.Zdo.Resolvers;

public sealed class WeatherResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Weather;

    public void Apply(Zdo z)
    {
        // Weather is one ZDO singleton owned by host; legacy WeatherSync
        // handles the SoD-side mutation. The ZDO is informational + late-
        // join state delivery.
        _ = z;
    }
}
