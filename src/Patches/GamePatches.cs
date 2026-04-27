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
    //  Human.Murder — fired whenever a citizen actually gets killed.
    //  Skip Player.Instance (the local player has no stable cross-machine ID).
    //  Skip while CitizenDeathSync.IsApplyingRemote so we don't echo.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Human), nameof(Human.Murder))]
    public static class Human_Murder_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Human __instance, Human killer, Interactable weapon)
        {
            try
            {
                if (__instance == null) return;
                if (CitizenDeathSync.IsApplyingRemote) return;
                // Don't broadcast deaths of the local player — there is no shared
                // identity for "the local player" across machines.
                if (global::Player.Instance != null && __instance.Pointer == global::Player.Instance.Pointer)
                    return;

                Vector3 pos = Vector3.zero;
                try { if (__instance.transform != null) pos = __instance.transform.position; } catch { }

                CitizenDeathSync.BroadcastDeath(
                    __instance.humanID,
                    killer != null ? killer.humanID : -1,
                    weapon != null ? weapon.id     : -1,
                    pos);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Human.Murder patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  MurderController.OnVictimDiscovery — fired the moment a player walks past
    //  a corpse. Mirroring it across the wire means the case is flagged
    //  discovered on every machine without each player having to find the body.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(MurderController), nameof(MurderController.OnVictimDiscovery))]
    public static class MurderController_OnVictimDiscovery_Patch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            try
            {
                if (CitizenDeathSync.IsApplyingRemote) return;
                CitizenDeathSync.BroadcastDiscovery();
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"MurderController.OnVictimDiscovery patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  TelephoneController.AddActiveCall / RemoveActiveCall — only the host
    //  emits banner notifications, since both machines run the same call
    //  scheduler and we don't want duplicate broadcasts.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(TelephoneController), nameof(TelephoneController.AddActiveCall))]
    public static class TelephoneController_AddActiveCall_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(TelephoneController.PhoneCall newCall)
        {
            try
            {
                if (newCall == null) return;
                if (!NetworkManager.IsHost) return;
                int caller = newCall.caller;
                string name = PhoneSync.ResolveCallerName(caller);
                PhoneSync.BroadcastCallStart(caller, name);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"TelephoneController.AddActiveCall patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(TelephoneController), nameof(TelephoneController.RemoveActiveCall))]
    public static class TelephoneController_RemoveActiveCall_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(TelephoneController.PhoneCall newCall)
        {
            try
            {
                if (newCall == null) return;
                if (!NetworkManager.IsHost) return;
                int caller = newCall.caller;
                string name = PhoneSync.ResolveCallerName(caller);
                PhoneSync.BroadcastCallEnd(caller, name);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"TelephoneController.RemoveActiveCall patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  SessionData.SetWeather — host-authoritative weather sync.
    //
    //  • Host: postfix broadcasts every successful SetWeather call.
    //  • Client: prefix blocks ALL local SetWeather calls except the ones we
    //    inject from WeatherSync.ApplyWeather (flag IsApplyingRemote=true). This
    //    silences SoD's local weatherChangeTimer on clients so they only ever
    //    see what the host broadcasts.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(SessionData), nameof(SessionData.SetWeather))]
    public static class SessionData_SetWeather_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix()
        {
            // Apply path always wins.
            if (WeatherSync.IsApplyingRemote) return true;

            // Single-player or pre-connection — let SoD do its thing.
            if (!NetworkManager.IsConnected) return true;

            // Host runs the authoritative weather scheduler.
            if (NetworkManager.IsHost) return true;

            // Connected client, not applying a remote packet → swallow the call.
            return false;
        }

        [HarmonyPostfix]
        public static void Postfix(
            float newRain, float newWind, float newSnow, float newLightning, float newFog,
            float newTransitionSpeed, bool updateInstantly)
        {
            try
            {
                if (WeatherSync.IsApplyingRemote) return;       // remote → don't echo
                if (!NetworkManager.IsConnected)  return;
                if (!NetworkManager.IsHost)       return;       // client never reaches here (prefix blocked)

                WeatherSync.BroadcastSetWeather(
                    newRain, newWind, newSnow, newLightning, newFog,
                    newTransitionSpeed, updateInstantly);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"SessionData.SetWeather patch: {ex.Message}");
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
