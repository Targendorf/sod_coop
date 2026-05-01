using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Citizen"/> state to the live <c>Citizen</c>
/// looked up by <c>__sodId = humanID</c>. Currently outfit-only on the
/// non-host side; <c>inBed</c>, <c>asleep</c>, <c>restrained</c>, <c>stunned</c>
/// are display-only on receiving peers because client-side AI is intentionally
/// ignored (host-authoritative, see spec section 7.2). The ZDO state is
/// preserved for snapshot replay so a late-joiner gets the host's truth.
/// </summary>
public sealed class CitizenResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Citizen;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        // Host is the authority; never apply on the host.
        if (SoDCoop.Network.NetworkManager.IsHost) return;

        int humanId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (humanId == int.MinValue) return;

        try
        {
            if (z.HasKey(ZdoKeys.OutfitCategory))
            {
                byte cat = z.GetByte(ZdoKeys.OutfitCategory, 0);
                SoDCoop.Sync.NpcOutfitSync.ApplyByHumanId(humanId, cat);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] apply: {ex.Message}"); }
    }
}
