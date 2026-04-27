using HarmonyLib;
using SoDCoop.Sync;
using SoDCoop.UI;
using UnityEngine;
using SoDCoop.Network;

namespace SoDCoop.Patches;

/// <summary>
/// Harmony patches that detect local state changes in the game world
/// (doors opening/closing, lights toggling) and broadcast them to peers.
///
/// Re-entrancy is guarded inside Broadcast* via WorldStateSync.IsApplyingRemote
/// so applying a remote change doesn't cause an echo packet back.
///
/// Network IDs:
///   - Doors  : NewDoor.doorInteractable.id
///   - Lights : LightController.interactable.id
/// </summary>
public static class GamePatches
{
    // ─────────────────────────────────────────────────────────────────────────
    //  NewDoor.OnOpen / OnClose — fire AFTER the state changes.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(NewDoor), nameof(NewDoor.OnOpen))]
    public static class NewDoor_OnOpen_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(NewDoor __instance)
        {
            try
            {
                if (__instance == null) return;
                var inter = __instance.doorInteractable;
                if (inter == null) return;
                WorldStateSync.BroadcastDoorState(inter.id, isClosed: false);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"NewDoor.OnOpen patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(NewDoor), nameof(NewDoor.OnClose))]
    public static class NewDoor_OnClose_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(NewDoor __instance)
        {
            try
            {
                if (__instance == null) return;
                var inter = __instance.doorInteractable;
                if (inter == null) return;
                WorldStateSync.BroadcastDoorState(inter.id, isClosed: true);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"NewDoor.OnClose patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  SessionData.TogglePause(bool openDesktopMode) — pause UI / menu transition.
    //  Read Time.timeScale right after to determine the new pause state.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(SessionData), nameof(SessionData.TogglePause))]
    public static class SessionData_TogglePause_Patch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            try
            {
                bool nowPaused = Time.timeScale == 0f;
                PingSystem.NotifyLocalPauseChanged(nowPaused);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"SessionData.TogglePause patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  LightController.SetOn(bool val, bool instant)
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(LightController), nameof(LightController.SetOn))]
    public static class LightController_SetOn_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(LightController __instance, bool val)
        {
            try
            {
                if (__instance == null) return;
                var inter = __instance.interactable;
                if (inter == null) return;
                WorldStateSync.BroadcastLightState(inter.id, isOn: val);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"LightController.SetOn patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Item pickup / drop — FirstPersonItemController.PickUpItem / EmptySlot
    //
    //  PickUpItem returns bool; we only broadcast on success (__result == true).
    //  EmptySlot: we capture the interactableID in the prefix (before the slot is
    //  cleared), then broadcast the drop position in the postfix once the game has
    //  placed the object back in the world.  destroyObject==true means the item was
    //  consumed/binned — skip broadcast in that case.
    // ─────────────────────────────────────────────────────────────────────────

    // ─────────────────────────────────────────────────────────────────────────
    //  Interactable.SetSwitchState — drawers, cabinets, fridges, safes, etc.
    //  Lights are excluded because they go via the dedicated LightState packet
    //  (LightController.SetOn calls SetSwitchState internally — we'd double up).
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Interactable), nameof(Interactable.SetSwitchState))]
    public static class Interactable_SetSwitchState_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Interactable __instance, bool val)
        {
            try
            {
                if (__instance == null) return;
                if (WorldStateSync.IsApplyingRemote) return;
                // Filter out lights — they have their own LightState channel.
                if (WorldStateSync.IsLightInteractable(__instance)) return;
                WorldStateSync.BroadcastSwitchState(__instance.id, val);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Interactable.SetSwitchState patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.PickUpItem))]
    public static class FPItemController_PickUpItem_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Interactable pickUpThis, bool __result)
        {
            try
            {
                if (!__result) return;               // pick-up failed — nothing changed
                if (pickUpThis == null) return;
                if (ItemSync.IsApplyingRemote) return;
                ItemSync.BroadcastPickup(pickUpThis.id);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.PickUpItem patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.EmptySlot))]
    public static class FPItemController_EmptySlot_Patch
    {
        /// <summary>
        /// Capture the interactableID before the slot is cleared, pass it to the
        /// postfix via Harmony's __state mechanism.
        /// -1 means "skip broadcast" (destroyed item or no slot).
        /// </summary>
        [HarmonyPrefix]
        public static void Prefix(
            FirstPersonItemController.InventorySlot emptySlot,
            bool destroyObject,
            out int __state)
        {
            __state = -1;
            try
            {
                if (ItemSync.IsApplyingRemote) return;
                if (destroyObject) return;           // item consumed/binned — no drop event
                if (emptySlot == null) return;
                __state = emptySlot.interactableID;
            }
            catch { }
        }

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (__state < 0) return;
                ItemSync.BroadcastDrop(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.EmptySlot patch: {ex.Message}");
            }
        }
    }
}
