using System;
using SoDCoop.Sync;

namespace SoDCoop.Zdo.Resolvers;

public sealed class SwitchResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Switch;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        int sodId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (sodId == int.MinValue) return;
        try
        {
            bool on = z.GetBool(ZdoKeys.On, false);
            WorldStateSync.ApplySwitchStateBySodId(sodId, on);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SwitchResolver] apply: {ex.Message}"); }
    }
}
