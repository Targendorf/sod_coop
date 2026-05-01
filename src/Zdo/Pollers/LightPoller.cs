using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>Host-side 10 Hz diff over light interactables → writes
/// <c>on</c> key to the <see cref="ZdoTypeTag.Light"/> ZDO.</summary>
public static class LightPoller
{
    public const float TICK_HZ = 10f;
    public const string NAME = "lights";

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForLights) return;
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            for (int i = 0; i < dir.Count; i++)
            {
                var inter = dir[i];
                if (inter == null || inter.spawnedObject == null) continue;
                LightController light = null;
                try { light = inter.spawnedObject.GetComponentInChildren<LightController>(true); } catch { }
                if (light == null) continue;

                Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Light, inter.id, owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.On, light.isOn);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LightPoller] tick: {ex.Message}"); }
    }
}
