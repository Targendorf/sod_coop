using System;
using SoDCoop.Sync;

namespace SoDCoop.Zdo.Resolvers;

public sealed class LightResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Light;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        int sodId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (sodId == int.MinValue) return;
        try
        {
            bool on = z.GetBool(ZdoKeys.On, false);
            WorldStateSync.ApplyLightStateBySodId(sodId, on);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LightResolver] apply: {ex.Message}"); }
    }
}
