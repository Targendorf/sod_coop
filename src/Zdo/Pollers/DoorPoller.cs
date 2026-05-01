using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side 10 Hz diff over <c>CityData.Instance.doorDictionary</c> →
/// writes <c>(closed, locked)</c> keys to the matching <see cref="ZdoTypeTag.Door"/>
/// ZDO. Replaces the disabled hot-path patches at
/// <c>src/Patches/GamePatches.cs:26</c> (<c>NewDoor.OnOpen</c>),
/// <c>src/Patches/GamePatches.cs:48</c> (<c>NewDoor.OnClose</c>), and
/// the lock state currently routed through
/// <c>WorldStateSync.BroadcastDoorLockState</c>.
/// </summary>
public static class DoorPoller
{
    public const float TICK_HZ = 10f;
    public const string NAME = "doors";

    public static void Register()
    {
        ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForDoors) return;

        try
        {
            var dict = CityData.Instance?.doorDictionary;
            if (dict == null) return;

            // Iterate via the Il2Cpp dictionary's Values collection.
            foreach (var kv in dict)
            {
                var door = kv.Value;
                if (door == null) continue;
                var inter = door.doorInteractable;
                if (inter == null) continue;
                int id = inter.id;

                Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Door, id, owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.Closed, door.isClosed);
                z.Set(ZdoKeys.Locked, door.isLocked);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[DoorPoller] tick: {ex.Message}"); }
    }
}
