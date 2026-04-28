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
    //  Case-board sync: Pin / Unpin / live-drag Move.
    //
    //  CasePanelController has two PinToCasePanel overloads (single key vs list)
    //  and one UnPinFromCasePanel. PinnedItemController.SetPostion fires every
    //  drag frame. All four route through CaseBoardSync, which throttles moves
    //  to 20 Hz internally. IsApplyingRemote guards prevent echo on replay.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(CasePanelController), nameof(CasePanelController.PinToCasePanel),
        new System.Type[]
        {
            typeof(Case), typeof(Evidence), typeof(Evidence.DataKey),
            typeof(bool), typeof(Vector2), typeof(bool),
        })]
    public static class CPC_PinToCasePanel_Single_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case toCase, Evidence ev, Evidence.DataKey evKey,
                                   bool forceAutoPin, Vector2 localPostion)
        {
            try
            {
                if (toCase == null || ev == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                var keys = new Il2CppSystem.Collections.Generic.List<Evidence.DataKey>();
                keys.Add(evKey);
                CaseBoardSync.BroadcastPin(toCase.id, ev.evID, keys, localPostion, forceAutoPin);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"CPC.PinToCasePanel(single) patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(CasePanelController), nameof(CasePanelController.PinToCasePanel),
        new System.Type[]
        {
            typeof(Case), typeof(Evidence),
            typeof(Il2CppSystem.Collections.Generic.List<Evidence.DataKey>),
            typeof(bool), typeof(Vector2), typeof(bool),
        })]
    public static class CPC_PinToCasePanel_List_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case toCase, Evidence ev,
                                   Il2CppSystem.Collections.Generic.List<Evidence.DataKey> evKeys,
                                   bool forceAutoPin, Vector2 localPostion)
        {
            try
            {
                if (toCase == null || ev == null || evKeys == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                CaseBoardSync.BroadcastPin(toCase.id, ev.evID, evKeys, localPostion, forceAutoPin);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"CPC.PinToCasePanel(list) patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(CasePanelController), nameof(CasePanelController.UnPinFromCasePanel))]
    public static class CPC_UnPinFromCasePanel_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case thisCase, Evidence ev,
                                   Il2CppSystem.Collections.Generic.List<Evidence.DataKey> evKeys)
        {
            try
            {
                if (thisCase == null || ev == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                CaseBoardSync.BroadcastUnpin(thisCase.id, ev.evID, evKeys);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"CPC.UnPinFromCasePanel patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(PinnedItemController), nameof(PinnedItemController.SetPostion))]
    public static class PIC_SetPostion_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(PinnedItemController __instance, Vector2 newPos)
        {
            try
            {
                if (__instance == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                var element = __instance.caseElement;
                if (element == null) return;
                CaseBoardSync.BroadcastMove(element, newPos);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"PIC.SetPostion patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Case.AddNewStringColour — connect a coloured thread between two pins.
    //  Case.SetHidden — hide / un-hide a fact card.
    //  Case.SetStatus  — mark case as solved / failed / etc.
    //
    //  ToggleHidden is intentionally not patched — game code routes it through
    //  SetHidden internally so a single patch covers both. If runtime shows
    //  otherwise, add a postfix on ToggleHidden that reads the new state.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Case), nameof(Case.AddNewStringColour))]
    public static class Case_AddNewStringColour_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case __instance, Evidence.FactLink link, InterfaceControls.EvidenceColours col)
        {
            try
            {
                if (__instance == null || link == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                var fromEv = link.thisEvidence;
                if (fromEv == null) return;
                // destinationEvidence is List<Evidence> (multi-target FactLink) — take first.
                if (link.destinationEvidence == null || link.destinationEvidence.Count == 0) return;
                var toEv = link.destinationEvidence[0];
                if (toEv == null) return;
                CaseBoardSync.BroadcastString(
                    __instance.id,
                    fromEv.evID, link.thisKeys,
                    toEv.evID,   link.destinationKeys,
                    (byte)col);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Case.AddNewStringColour patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(Case), nameof(Case.SetHidden))]
    public static class Case_SetHidden_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case __instance, Fact fact, bool val)
        {
            try
            {
                if (__instance == null || fact == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                CaseBoardSync.BroadcastHide(__instance.id, fact, val);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Case.SetHidden patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(Case), nameof(Case.SetStatus))]
    public static class Case_SetStatus_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case __instance, Case.CaseStatus newStatus, bool cancelObjectives)
        {
            try
            {
                if (__instance == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                CaseBoardSync.BroadcastStatus(__instance.id, (byte)newStatus, cancelObjectives);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Case.SetStatus patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  ResolveQuestion.SetProgress — player picks a suspect / location / time.
    //  Walk activeCases to find which Case owns this question + at what index.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Case.ResolveQuestion), nameof(Case.ResolveQuestion.SetProgress))]
    public static class ResolveQuestion_SetProgress_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case.ResolveQuestion __instance, float val, bool forceTrigger)
        {
            try
            {
                if (__instance == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                var (owner, idx) = CaseBoardSync.FindOwnerOfResolveQuestion(__instance);
                if (owner == null || idx < 0) return;
                CaseBoardSync.BroadcastResolveAnswer(owner.id, idx, val, forceTrigger);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"ResolveQuestion.SetProgress patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Case.Resolve — final hand-in. Either side can hand in a case (this is
    //  legitimate co-op behaviour: whoever's standing at the case-board does it).
    //  No conflict possible because Resolve flips isSolved and ApplyResolve
    //  short-circuits on already-solved cases.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Case), nameof(Case.Resolve))]
    public static class Case_Resolve_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Case __instance)
        {
            try
            {
                if (__instance == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                CaseBoardSync.BroadcastResolve(__instance.id);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Case.Resolve patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  StringController.RemoveCustomLink — player removes a thread.
    //
    //  We capture the connection identifier in the prefix because RemoveCustomLink
    //  may null out the StringController's `connection` field as part of its
    //  cleanup, leaving us unable to identify the link in the postfix.
    //  Broadcast happens unconditionally in the postfix using the captured
    //  identifier from __state.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(StringController), nameof(StringController.RemoveCustomLink))]
    public static class StringController_RemoveCustomLink_Patch
    {
        /// <summary>
        /// Frozen copy of the connection identifier captured in the prefix —
        /// safe to use in the postfix even if RemoveCustomLink nulls out
        /// connection / from / to during its cleanup.
        /// </summary>
        public class State
        {
            public bool   Valid;
            public int    CaseId;
            public string FromEvId;
            public byte[] FromKeys;
            public string ToEvId;
            public byte[] ToKeys;
        }

        [HarmonyPrefix]
        public static void Prefix(StringController __instance, out State __state)
        {
            __state = null;
            try
            {
                if (__instance == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;

                var conn = __instance.connection;
                var from = conn?.from?.caseElement;
                var to   = conn?.to?.caseElement;
                if (from == null || to == null) return;
                if (string.IsNullOrEmpty(from.id) || string.IsNullOrEmpty(to.id)) return;

                __state = new State
                {
                    Valid    = true,
                    CaseId   = from.caseID,
                    FromEvId = from.id,
                    FromKeys = SoDCoop.Sync.CaseBoardSync.SnapshotDataKeys(from.dk),
                    ToEvId   = to.id,
                    ToKeys   = SoDCoop.Sync.CaseBoardSync.SnapshotDataKeys(to.dk),
                };
            }
            catch { }
        }

        [HarmonyPostfix]
        public static void Postfix(State __state)
        {
            try
            {
                if (__state == null || !__state.Valid) return;
                CaseBoardSync.BroadcastStringRemoveById(
                    __state.CaseId,
                    __state.FromEvId, __state.FromKeys,
                    __state.ToEvId,   __state.ToKeys);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"StringController.RemoveCustomLink patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Fact.SetCustomName — player relabels a fact card. Virtual method.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Fact), nameof(Fact.SetCustomName))]
    public static class Fact_SetCustomName_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Fact __instance, string str)
        {
            try
            {
                if (__instance == null) return;
                if (CaseBoardSync.IsApplyingRemote) return;
                CaseBoardSync.BroadcastFactName(__instance, str);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Fact.SetCustomName patch: {ex.Message}");
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

    // ─────────────────────────────────────────────────────────────────────────
    //  Interactable.AddNewDynamicFingerprint — player or NPC leaves a print.
    //  Interactable.RemoveManuallyCreatedFingerprints — bulk-clear of manual prints.
    //
    //  Each side broadcasts its own contact events; the host also forwards
    //  NPC-driven events (clients have AI disabled so NPC contact never fires
    //  on them locally). Receivers replay the same call under
    //  FingerprintSync.IsApplyingRemote to suppress echo.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Interactable), nameof(Interactable.AddNewDynamicFingerprint))]
    public static class Interactable_AddNewDynamicFingerprint_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Interactable __instance, Human from, Interactable.PrintLife life)
        {
            try
            {
                if (__instance == null || from == null) return;
                // Suppress when this fingerprint is a side-effect of an Apply path
                // (door open / item pickup / switch / murder / case board) — the
                // originator already broadcast it and a separate FingerprintAdd
                // will arrive over the wire alongside the outer event.
                if (FingerprintSync.ShouldSuppressBroadcast) return;
                FingerprintSync.BroadcastAdd(__instance.id, from.humanID, (byte)life);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Interactable.AddNewDynamicFingerprint patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(Interactable), nameof(Interactable.RemoveManuallyCreatedFingerprints))]
    public static class Interactable_RemoveManuallyCreatedFingerprints_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Interactable __instance)
        {
            try
            {
                if (__instance == null) return;
                if (FingerprintSync.ShouldSuppressBroadcast) return;
                FingerprintSync.BroadcastClearManual(__instance.id);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Interactable.RemoveManuallyCreatedFingerprints patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  FootprintController.Setup — the visual entry point for every footstep
    //  decal. Host broadcasts NPC + own-player footsteps; clients broadcast
    //  ONLY their local player's footsteps (NPC visuals on clients fire
    //  walking-animation events too because we mirror their animator state,
    //  but those NPC prints are the host's responsibility — broadcasting from
    //  the client too would double them).
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(FootprintController), nameof(FootprintController.Setup))]
    public static class FootprintController_Setup_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(GameplayController.Footprint newFootprint)
        {
            try
            {
                if (newFootprint == null) return;
                if (FootprintSync.ShouldSuppressBroadcast) return;
                if (!NetworkManager.IsConnected) return;

                // Client filter: only our local player's footsteps. NPC prints
                // are the host's exclusive concern.
                if (!NetworkManager.IsHost)
                {
                    var localPlayer = global::Player.Instance;
                    if (localPlayer == null) return;
                    if (newFootprint.hID != localPlayer.humanID) return;
                }

                FootprintSync.BroadcastAdd(newFootprint);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FootprintController.Setup patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  SpatterSimulation.Execute — fires once per spatter pattern (blood spray
    //  from violence, gun shots, dripping items). Same broadcast policy as
    //  footprints: host always broadcasts, clients only when origin can be
    //  attributed to the local player. We can't easily attribute — spatter
    //  doesn't carry a humanID — so as a heuristic clients suppress entirely
    //  unless the closest Human at the origin is our local player.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(SpatterSimulation), nameof(SpatterSimulation.Execute))]
    public static class SpatterSimulation_Execute_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(SpatterSimulation __instance)
        {
            try
            {
                if (__instance == null) return;
                if (SpatterSync.ShouldSuppressBroadcast) return;
                if (!NetworkManager.IsConnected) return;

                // Client filter: only broadcast if origin is close to our
                // local player (i.e. the spatter probably came from us).
                // NPC-driven spatter on clients is impossible (AI off) so this
                // mainly catches the case where a synced animator fires a
                // damage-related event we don't want to mirror.
                if (!NetworkManager.IsHost)
                {
                    var localPlayer = global::Player.Instance;
                    if (localPlayer == null || localPlayer.transform == null) return;
                    var dist = Vector3.Distance(localPlayer.transform.position, __instance.worldOrigin);
                    if (dist > 5f) return;
                }

                SpatterSync.BroadcastFromSim(__instance);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"SpatterSimulation.Execute patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Held-item stance + flashlight (Phase 1 inventory visibility).
    //  Held item itself is poll-based in InventorySync.Update — no patch needed.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.SetRaised))]
    public static class FPItemController_SetRaised_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(bool val)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastRaised(val);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.SetRaised patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.SetFlashlight))]
    public static class FPItemController_SetFlashlight_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(bool val)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastFlashlight(val);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.SetFlashlight patch: {ex.Message}");
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
