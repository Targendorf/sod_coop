using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Fingerprint"/> ZDOs to live SoD state via
/// the existing <see cref="SoDCoop.Sync.FingerprintSync.ApplyAddDirect"/>
/// path. Fires once per ZDO observed (snapshot restore + delta apply); the
/// AddNewDynamicFingerprint call is idempotent on dedup-by-(interactable, human).
/// </summary>
public sealed class FingerprintResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Fingerprint;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;   // host originates; never replay
        try
        {
            int interactableId = z.GetInt(ZdoKeys.InteractableId, -1);
            int humanId        = z.GetInt(ZdoKeys.HumanId, 0);
            byte life          = z.GetByte(ZdoKeys.Life, 0);
            if (interactableId < 0) return;
            SoDCoop.Sync.FingerprintSync.ApplyAddDirect(interactableId, humanId, life);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[FingerprintResolver] apply: {ex.Message}"); }
    }
}
