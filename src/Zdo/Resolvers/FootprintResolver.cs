using System;
using UnityEngine;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Replays host footprints. Each footprint ZDO is applied at most once
/// (<c>ApplyAddDirect</c> appends, and a ZDO can arrive more than once), and the
/// receiver only keeps the most recent ones registered — see
/// <see cref="TransientZdoLog"/>; a footprint has done its job once it's in the
/// world.
/// </summary>
public sealed class FootprintResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Footprint;

    private static readonly TransientZdoLog _log = new(512);

    /// <summary>World unload: the registry is cleared with the world.</summary>
    public static void Reset() => _log.Clear();

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;
        try
        {
            int humanId = z.GetInt(ZdoKeys.HumanId, -1);
            if (humanId < 0) return;   // incomplete — a later delta finishes it
            if (!_log.Track(z.Id)) return;   // already applied
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
