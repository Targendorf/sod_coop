using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Citizen"/> state to the live <c>Citizen</c>
/// looked up by <c>__sodId = humanID</c>. Receivers mirror outfit, restrained,
/// stunned, asleep, in-bed transitions so guard / suspicion / animation
/// systems on the client see the same actor state the host does. The ZDO
/// state is preserved for snapshot replay so a late-joiner gets the host's
/// truth.
///
/// <para>Idempotent on receivers: setters are guarded with
/// <c>IsApplyingRemote</c> in the legacy syncs we re-use, so the call doesn't
/// echo back. Same-value writes are a no-op on the SoD side.</para>
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
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] outfit apply: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Restrained))
            {
                bool  restrained = z.GetBool (ZdoKeys.Restrained, false);
                float duration   = z.GetFloat(ZdoKeys.RestrainedDuration, 0f);
                SoDCoop.Sync.InventorySync.ApplyRestrainedByHumanId(humanId, restrained, duration);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] restrained apply: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Stunned))
            {
                bool stunned = z.GetBool(ZdoKeys.Stunned, false);
                SoDCoop.Sync.InventorySync.ApplyStunnedByHumanId(humanId, stunned);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] stunned apply: {ex.Message}"); }

        // Drunk + bleeding are visual-only on the receiver — stamp them
        // directly via the public Citizen field setter; SoD's animation /
        // spatter system reads them on the next tick.
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null || !dict.TryGetValue(humanId, out var c) || c == null) return;

            if (z.HasKey(ZdoKeys.Drunk))
            {
                try { c.drunk = z.GetFloat(ZdoKeys.Drunk, 0f); } catch { }
            }
            if (z.HasKey(ZdoKeys.Bleeding))
            {
                try { c.bleeding = z.GetFloat(ZdoKeys.Bleeding, 0f); } catch { }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] drunk/bleeding apply: {ex.Message}"); }
    }
}
