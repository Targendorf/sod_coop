using System;
using UnityEngine;

namespace SoDCoop.Zdo.Resolvers;

public sealed class FootprintResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Footprint;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;
        try
        {
            int humanId = z.GetInt(ZdoKeys.HumanId, -1);
            if (humanId < 0) return;
            int roomId = z.GetInt(ZdoKeys.RoomId, -1);
            Vector3 pos = z.GetVector3(ZdoKeys.Pos);
            Vector3 euler = z.GetVector3(ZdoKeys.FootprintEuler);
            float dirt = z.GetFloat(ZdoKeys.DirtFloat);
            float blood = z.GetFloat(ZdoKeys.BloodFloat);
            float ts = z.GetFloat(ZdoKeys.FootprintTimestamp);
            SoDCoop.Sync.FootprintSync.ApplyAddDirect(humanId, pos, euler, dirt, blood, roomId, ts);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[FootprintResolver] apply: {ex.Message}"); }
    }
}
