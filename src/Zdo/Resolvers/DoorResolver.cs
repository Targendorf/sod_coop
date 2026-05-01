using System;
using SoDCoop.Sync;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Translates a <see cref="ZdoTypeTag.Door"/> ZDO into the corresponding
/// <c>NewDoor.SetOpen</c> / <c>SetLocked</c> mutations on the live SoD
/// object found by <c>__sodId = Interactable.id</c>.
///
/// <para>Idempotent: re-applies the same state without re-running animations
/// because <c>WorldStateSync.IsApplyingRemote</c> guards the patch postfixes
/// from echoing back. Apply uses the existing legacy lookup helpers to find
/// the door so we don't duplicate dnSpy-derived field discovery.</para>
/// </summary>
public sealed class DoorResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Door;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        int sodId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (sodId == int.MinValue) return;

        // Re-use legacy lookup + setters via reflection-free callthrough.
        // WorldStateSync.ApplyDoorStatePublic exposes the existing helper
        // (added in this phase to keep the lookup logic in one place).
        try
        {
            bool closed = z.GetBool(ZdoKeys.Closed, true);
            WorldStateSync.ApplyDoorStateBySodId(sodId, closed);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[DoorResolver] closed apply: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Locked))
            {
                bool locked = z.GetBool(ZdoKeys.Locked, false);
                bool playSound = z.GetBool(ZdoKeys.PlaySound, false);
                WorldStateSync.ApplyDoorLockBySodId(sodId, locked, playSound);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[DoorResolver] lock apply: {ex.Message}"); }
    }
}
