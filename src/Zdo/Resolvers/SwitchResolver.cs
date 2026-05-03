using System;
using SoDCoop.Sync;

namespace SoDCoop.Zdo.Resolvers;

public sealed class SwitchResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Switch;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        int sodId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (sodId == int.MinValue) return;
        try
        {
            // sw0 = main switch state (drawer open / TV on / radio playing).
            // SetSwitchState already replays the audio cue + animation that
            // SoD's interaction would have triggered locally.
            bool on = z.GetBool(ZdoKeys.On, false);
            WorldStateSync.ApplySwitchStateBySodId(sodId, on);

            // sw1..sw3 = custom1/2/3 — interactable-specific extra state.
            // For radios / TVs / music players these often hold "currently
            // playing" / "muted" / "paused" toggles independently from sw0.
            // Apply via SetSwtichByType(custom1/2/3) so any audio / lights
            // bound to that slot also fire on the receiver.
            ApplyCustomSwitchIfPresent(sodId, z, ZdoKeys.Sw1, global::InteractablePreset.Switch.custom1);
            ApplyCustomSwitchIfPresent(sodId, z, ZdoKeys.Sw2, global::InteractablePreset.Switch.custom2);
            ApplyCustomSwitchIfPresent(sodId, z, ZdoKeys.Sw3, global::InteractablePreset.Switch.custom3);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SwitchResolver] apply: {ex.Message}"); }
    }

    private static void ApplyCustomSwitchIfPresent(int sodId, Zdo z, int key,
        global::InteractablePreset.Switch slot)
    {
        if (!z.HasKey(key)) return;
        try
        {
            bool val = z.GetBool(key, false);
            WorldStateSync.ApplyCustomSwitchStateBySodId(sodId, slot, val);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SwitchResolver] custom-slot {slot} on {sodId}: {ex.Message}"); }
    }
}
