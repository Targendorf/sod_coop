using System;
using UnityEngine;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Replays host spatter events, each at most once (a ZDO can arrive more than
/// once), keeping only the most recent registered — see
/// <see cref="TransientZdoLog"/>.
/// </summary>
public sealed class SpatterResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Spatter;

    private static readonly TransientZdoLog _log = new(256);

    /// <summary>World unload: the registry is cleared with the world.</summary>
    public static void Reset() => _log.Clear();

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
            if (string.IsNullOrEmpty(preset)) return;   // incomplete — a later delta finishes it
            if (!_log.Track(z.Id)) return;               // already applied
            SoDCoop.Sync.SpatterSync.ApplyAddDirect(origin, target, preset, erase, forceType, countMul, stickActors);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SpatterResolver] apply: {ex.Message}"); }
    }
}
