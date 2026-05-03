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

                bool s0 = false, s1 = false, s2 = false, s3 = false;
                bool display = true;
                try { s0 = inter.sw0; s1 = inter.sw1; s2 = inter.sw2; s3 = inter.sw3; } catch { }
                try { display = inter.display; } catch { }

                Zdo z = ZdoMan.FindBySodId(ZdoTypeTag.Switch, inter.id);
                // Bound state-table size: skip "all four switches in default
                // state AND default-display=true" interactables until something
                // flips. An existing ZDO is always re-pushed (in case state
                // went back to all-defaults, which the receiver still needs
                // to know about). Triggering on display=false catches the
                // container sub-spawn items that are hidden until search.
                if (z == null && !s0 && !s1 && !s2 && !s3 && display) continue;
                z ??= ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Switch, inter.id, owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.On,      s0);
                z.Set(ZdoKeys.Sw1,     s1);
                z.Set(ZdoKeys.Sw2,     s2);
                z.Set(ZdoKeys.Sw3,     s3);
                z.Set(ZdoKeys.Display, display);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SwitchPoller] tick: {ex.Message}"); }
    }
}
