using System;
using UnityEngine;

namespace SoDCoop.Zdo.Resolvers;

public sealed class SpatterResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Spatter;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;
        try
        {
            Vector3 origin = z.GetVector3(ZdoKeys.SpatterOrigin);
            Vector3 target = z.GetVector3(ZdoKeys.SpatterTarget);
            string preset = z.GetString(ZdoKeys.SpatterPreset, "");
            byte erase = z.GetByte(ZdoKeys.SpatterErase, 0);
            byte forceType = z.GetByte(ZdoKeys.SpatterForceType, 0);
            float countMul = z.GetFloat(ZdoKeys.SpatterCountMul, 1f);
            bool stickActors = z.GetBool(ZdoKeys.SpatterStickActors, false);
            if (string.IsNullOrEmpty(preset)) return;
            SoDCoop.Sync.SpatterSync.ApplyAddDirect(origin, target, preset, erase, forceType, countMul, stickActors);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SpatterResolver] apply: {ex.Message}"); }
    }
}
