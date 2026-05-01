using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>Generic switch (drawer/cabinet/fridge/safe) state poller. Filters
/// out lights to avoid double-broadcast (LightPoller owns lights).</summary>
public static class SwitchPoller
{
    public const float TICK_HZ = 10f;
    public const string NAME = "switches";

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForSwitches) return;
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            for (int i = 0; i < dir.Count; i++)
            {
                var inter = dir[i];
                if (inter == null) continue;
                if (SoDCoop.Sync.WorldStateSync.IsLightInteractable(inter)) continue;

                Zdo z = ZdoMan.FindBySodId(ZdoTypeTag.Switch, inter.id);
                if (z == null && !inter.sw0) continue; // skip default-state switches to bound state size
                z ??= ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Switch, inter.id, owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.On, inter.sw0);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SwitchPoller] tick: {ex.Message}"); }
    }
}
