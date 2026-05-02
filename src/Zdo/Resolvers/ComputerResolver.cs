using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Computer"/> ZDO state to the live
/// <c>ComputerController</c> looked up via the per-computer
/// <c>__sodId = Interactable.id</c>.
///
/// <para>Phase G.5 (Wave 2.1): handles
/// <see cref="ZdoKeys.LoggedInHumanId"/> and <see cref="ZdoKeys.AppPreset"/>
/// keys. Replaces the legacy ComputerLogin / ComputerApp packet wire.</para>
/// </summary>
public sealed class ComputerResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Computer;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        if (SoDCoop.Network.NetworkManager.IsHost) return;

        int interactableId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (interactableId == int.MinValue) return;

        try
        {
            if (z.HasKey(ZdoKeys.LoggedInHumanId))
            {
                int humanId = z.GetInt(ZdoKeys.LoggedInHumanId, -1);
                SoDCoop.Sync.ComputerSync.ApplyLoginFromZdo(interactableId, humanId);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ComputerResolver] login: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.AppPreset))
            {
                string presetName = z.GetString(ZdoKeys.AppPreset, "");
                if (!string.IsNullOrEmpty(presetName))
                    SoDCoop.Sync.ComputerSync.ApplyAppFromZdo(interactableId, presetName, forceUpdate: false);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ComputerResolver] app: {ex.Message}"); }
    }
}
