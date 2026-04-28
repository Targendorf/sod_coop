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
                // Damage with enableKill=true ends up here. If we're applying
                // a remote damage event, the originator already broadcast the
                // CitizenDeath that will follow — don't echo.
                if (DamageSync.IsApplyingRemote) return;
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
                if (!NetworkManager.IsConnected) return;

                // Detect OUTGOING player call: PhoneCall.callerNS is the
                // caller Human; if it's our local Player.Instance, this is
                // a call WE just initiated.
                bool isOutgoingFromMe = false;
                try
                {
                    var callerHuman = newCall.callerNS;
                    var localPlayer = global::Player.Instance;
                    if (callerHuman != null && localPlayer != null
                        && callerHuman.Pointer == localPlayer.Pointer)
                        isOutgoingFromMe = true;
                }
                catch { }

                if (isOutgoingFromMe)
                {
                    string callerName = NetworkManager.LocalPlayerName ?? "Player";
                    string calleeName = "Unknown";
                    try
                    {
                        // intendedReceiver Human is the NPC we're calling.
                        var ir = newCall.intendedReceiverNS;
                        if (ir != null && !string.IsNullOrEmpty(ir.citizenName))
                            calleeName = ir.citizenName;
                    }
                    catch { }
                    PhoneSync.BroadcastOutgoingPlayerCall(callerName, calleeName, isStarting: true);
                    return;
                }

                // Otherwise treat as incoming NPC call — host-authoritative
                // path so all peers see "Sarah is calling" exactly once.
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
                if (!NetworkManager.IsConnected) return;

                bool isOutgoingFromMe = false;
                try
                {
                    var callerHuman = newCall.callerNS;
                    var localPlayer = global::Player.Instance;
                    if (callerHuman != null && localPlayer != null
                        && callerHuman.Pointer == localPlayer.Pointer)
                        isOutgoingFromMe = true;
                }
                catch { }

                if (isOutgoingFromMe)
                {
                    string callerName = NetworkManager.LocalPlayerName ?? "Player";
                    string calleeName = "Unknown";
                    try
                    {
                        var ir = newCall.intendedReceiverNS;
                        if (ir != null && !string.IsNullOrEmpty(ir.citizenName))
                            calleeName = ir.citizenName;
                    }
                    catch { }
                    PhoneSync.BroadcastOutgoingPlayerCall(callerName, calleeName, isStarting: false);
                    return;
                }

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

    // ─────────────────────────────────────────────────────────────────────────
    //  One-shot combat actions (cosmetic broadcast).
    //  Damage and death already flow via CitizenDeathSync; these patches just
    //  let the OTHER player see your animation when you swing / block / counter.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.MeleeAttack))]
    public static class FPItemController_MeleeAttack_Patch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastAction(ItemActionKind.MeleeAttack);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.MeleeAttack patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.Block))]
    public static class FPItemController_Block_Patch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastAction(ItemActionKind.Block);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.Block patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.CounterAttack))]
    public static class FPItemController_CounterAttack_Patch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastAction(ItemActionKind.CounterAttack);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.CounterAttack patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Tactical placements — codebreaker / wedge / tracker / grenade-mine.
    //
    //  Strategy: snapshot CityData.interactableDirectory.Count in the prefix,
    //  then in the postfix walk new entries to find what got created and
    //  broadcast a visual-mock packet for each. This works without knowing
    //  exactly what each Place method spawns and adapts naturally to SoD
    //  versions / mods that change placement details.
    //
    //  IMPORTANT: this is host-authority-LITE — only the placer's machine has
    //  the real, functional Interactable; remote peers see a stripped visual.
    //  Functional gameplay (e.g. codebreaker scanning a door's code) only runs
    //  for the placer, which is acceptable since investigating a placed device
    //  is the placer's task anyway.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.PlaceCodebreaker))]
    public static class FPItemController_PlaceCodebreaker_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out int __state) => __state = InventorySync.SnapshotInteractableCount();

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastPlacedSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.PlaceCodebreaker patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.PlaceDoorWedge))]
    public static class FPItemController_PlaceDoorWedge_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out int __state) => __state = InventorySync.SnapshotInteractableCount();

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastPlacedSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.PlaceDoorWedge patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.PlaceTracker))]
    public static class FPItemController_PlaceTracker_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out int __state) => __state = InventorySync.SnapshotInteractableCount();

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastPlacedSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.PlaceTracker patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.PlaceGrenade))]
    public static class FPItemController_PlaceGrenade_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out int __state) => __state = InventorySync.SnapshotInteractableCount();

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastPlacedSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.PlaceGrenade patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Throws — ThrowCoin, ThrowFood, ThrowGrenade.  Diff-snapshot approach:
    //  the throw method spawns a projectile Interactable; we capture the new
    //  entries via interactableDirectory.Count delta and broadcast preset +
    //  initial transform + Rigidbody velocities. Receivers spawn an identical
    //  physics object on their machine.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.ThrowCoin))]
    public static class FPItemController_ThrowCoin_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out int __state) => __state = InventorySync.SnapshotForThrow();

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastThrownSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.ThrowCoin patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.ThrowFood))]
    public static class FPItemController_ThrowFood_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out int __state) => __state = InventorySync.SnapshotForThrow();

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastThrownSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.ThrowFood patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.ThrowGrenade))]
    public static class FPItemController_ThrowGrenade_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out int __state) => __state = InventorySync.SnapshotForThrow();

        [HarmonyPostfix]
        public static void Postfix(int __state)
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return;
                InventorySync.BroadcastThrownSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.ThrowGrenade patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  TakePicture — diff over evidenceDictionary so any new Evidence created
    //  by this player action (the photo + any sub-evidence the engine spawns
    //  alongside it) gets broadcast with stable evIDs.
    // ─────────────────────────────────────────────────────────────────────────

    // ─────────────────────────────────────────────────────────────────────────
    //  Surveillance app — Save-to-Tape and Acquire-Name both end up calling
    //  EvidenceCreator.CreateEvidence to mint EvidenceSurveillance / lead
    //  evidence. Same diff-over-evidenceDictionary pattern as TakePicture
    //  catches whatever the engine spawns and broadcasts it with stable evIDs.
    //
    //  Most of the surveillance flow comes for free in coop: SceneRecorder on
    //  each machine independently observes synced NPC positions, so playback
    //  content matches across peers. Only the "I saved this footage to tape"
    //  / "I identified this actor" decisions create new evidence that needs
    //  to be mirrored.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(SurveillanceApp), nameof(SurveillanceApp.SaveToTapeButton))]
    public static class SurveillanceApp_SaveToTape_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out System.Collections.Generic.HashSet<string> __state)
            => __state = EvidenceSync.SnapshotEvidenceKeys();

        [HarmonyPostfix]
        public static void Postfix(System.Collections.Generic.HashSet<string> __state)
        {
            try
            {
                if (EvidenceSync.IsApplyingRemote) return;
                EvidenceSync.BroadcastNewEvidenceSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"SurveillanceApp.SaveToTape patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(SurveillanceApp), nameof(SurveillanceApp.AcquireNameButton))]
    public static class SurveillanceApp_AcquireName_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out System.Collections.Generic.HashSet<string> __state)
            => __state = EvidenceSync.SnapshotEvidenceKeys();

        [HarmonyPostfix]
        public static void Postfix(System.Collections.Generic.HashSet<string> __state)
        {
            try
            {
                if (EvidenceSync.IsApplyingRemote) return;
                EvidenceSync.BroadcastNewEvidenceSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"SurveillanceApp.AcquireName patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.TakePicture))]
    public static class FPItemController_TakePicture_Patch
    {
        [HarmonyPrefix]
        public static void Prefix(out System.Collections.Generic.HashSet<string> __state)
            => __state = EvidenceSync.SnapshotEvidenceKeys();

        [HarmonyPostfix]
        public static void Postfix(System.Collections.Generic.HashSet<string> __state)
        {
            try
            {
                if (EvidenceSync.IsApplyingRemote) return;
                EvidenceSync.BroadcastNewEvidenceSince(__state);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.TakePicture patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Actor.RecieveDamage — non-lethal NPC hits.
    //
    //  Patches the virtual base method which fires for every Actor subtype
    //  (Citizen, Player). We filter out Player victims at broadcast time —
    //  player health is per-machine local state.
    //
    //  Spatter / footprint side-effects of the replayed call on receivers
    //  are suppressed via DamageSync.IsApplyingRemote being checked in the
    //  related ShouldSuppressBroadcast cascades.
    // ─────────────────────────────────────────────────────────────────────────

    // ─────────────────────────────────────────────────────────────────────────
    //  Player sleep / wake / in-bed transitions.
    //
    //  Patches the Actor base methods (Player inherits Actor) and filters to
    //  the LOCAL Player.Instance — NPCs sleep on their own deterministic
    //  schedule and don't need explicit sync for this.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Actor), nameof(Actor.SetInBed))]
    public static class Actor_SetInBed_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Actor __instance, bool newVal, bool isLowBed)
        {
            try
            {
                if (__instance == null) return;
                if (PlayerStateSync.IsApplyingRemote) return;
                var localPlayer = global::Player.Instance;
                if (localPlayer == null || __instance.Pointer != localPlayer.Pointer) return;
                PlayerStateSync.BroadcastInBed(newVal, isLowBed);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Actor.SetInBed patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(Actor), nameof(Actor.GoToSleep))]
    public static class Actor_GoToSleep_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Actor __instance)
        {
            try
            {
                if (__instance == null) return;
                if (PlayerStateSync.IsApplyingRemote) return;
                var localPlayer = global::Player.Instance;
                if (localPlayer == null || __instance.Pointer != localPlayer.Pointer) return;
                PlayerStateSync.BroadcastAsleep(true);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Actor.GoToSleep patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(Actor), nameof(Actor.WakeUp))]
    public static class Actor_WakeUp_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Actor __instance)
        {
            try
            {
                if (__instance == null) return;
                if (PlayerStateSync.IsApplyingRemote) return;
                var localPlayer = global::Player.Instance;
                if (localPlayer == null || __instance.Pointer != localPlayer.Pointer) return;
                PlayerStateSync.BroadcastAsleep(false);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Actor.WakeUp patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  GameplayController.AddMoney — quest rewards, sales, fees.
    //  Both players receive the same amount: when player A's machine fires
    //  AddMoney(500, ...), broadcast → player B's machine replays the same
    //  AddMoney call → B's wallet also gains 500.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(GameplayController), nameof(GameplayController.AddMoney))]
    public static class GameplayController_AddMoney_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(int addVal, bool displayMessage, string reason)
        {
            try
            {
                if (MoneySync.IsApplyingRemote) return;
                MoneySync.BroadcastAddMoney(addVal, displayMessage, reason);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"GameplayController.AddMoney patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Toolbox.NewVmailThread — voicemail thread creation.
    //
    //  Most vmails are deterministic from world seed (case generation runs
    //  identically on each machine), but defensive sync covers any
    //  player-action-driven creation. Receiver's apply path is idempotent
    //  (skip if threadID already in messageThreads dict).
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Toolbox), nameof(Toolbox.NewVmailThread),
        new System.Type[]
        {
            typeof(Human), typeof(Human), typeof(Human), typeof(Human),
            typeof(Il2CppSystem.Collections.Generic.List<Human>),
            typeof(string), typeof(float), typeof(int),
            typeof(StateSaveData.CustomDataSource), typeof(int),
        })]
    public static class Toolbox_NewVmailThread_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(StateSaveData.MessageThreadSave __result)
        {
            try
            {
                if (__result == null) return;
                if (VmailSync.IsApplyingRemote) return;
                VmailSync.BroadcastCreated(__result);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Toolbox.NewVmailThread patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  FirstPersonItemController.Give — detect remote-player target for
    //  player↔player handoff. If raycast hits a RemotePlayer avatar, run
    //  our handoff path and skip the original NPC-targeted Give logic.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(FirstPersonItemController), nameof(FirstPersonItemController.Give))]
    public static class FPItemController_Give_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix()
        {
            try
            {
                if (InventorySync.IsApplyingRemote) return true;
                if (!NetworkManager.IsConnected)   return true;

                var cam = Camera.main;
                if (cam == null) return true;

                if (!Physics.Raycast(cam.transform.position, cam.transform.forward,
                                     out var hit, 3.5f, ~0, QueryTriggerInteraction.Collide))
                    return true;

                // Walk up looking for a RemotePlayer component.
                var rp = hit.transform != null
                    ? hit.transform.GetComponentInParent<SoDCoop.Player.RemotePlayer>()
                    : null;
                if (rp == null) return true;       // not a remote player → let SoD handle

                // Initiate handoff. If it succeeds, suppress the original Give
                // (NPC-only logic would no-op anyway since RemotePlayer isn't a Human).
                if (InventorySync.TryHandoffToRemotePlayer(rp.PlayerId))
                    return false;

                return true;
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"FPItemController.Give patch: {ex.Message}");
                return true;
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  NewDoor.SetLocked — covers lockpicking, key use, scripted unlock.
    //  Patches the leaf state changer; every code path that flips door's
    //  locked state goes through here.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(NewDoor), nameof(NewDoor.SetLocked))]
    public static class NewDoor_SetLocked_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(NewDoor __instance, bool val, bool playSound)
        {
            try
            {
                if (__instance == null) return;
                if (WorldStateSync.IsApplyingRemote) return;
                var inter = __instance.doorInteractable;
                if (inter == null) return;
                WorldStateSync.BroadcastDoorLockState(inter.id, val, playSound);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"NewDoor.SetLocked patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  ComputerController state — login + foreground app.
    //  Power on/off already covered by Interactable.SetSwitchState patch.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(ComputerController), nameof(ComputerController.SetLoggedIn))]
    public static class ComputerController_SetLoggedIn_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(ComputerController __instance, Human newLogIn)
        {
            try
            {
                if (__instance == null) return;
                if (ComputerSync.IsApplyingRemote) return;
                var inter = __instance.ic?.interactable;
                if (inter == null) return;
                ComputerSync.BroadcastLogin(inter.id, newLogIn != null ? newLogIn.humanID : -1);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"ComputerController.SetLoggedIn patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(ComputerController), nameof(ComputerController.SetComputerApp))]
    public static class ComputerController_SetComputerApp_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(ComputerController __instance, CruncherAppPreset newApp, bool forceUpdate)
        {
            try
            {
                if (__instance == null) return;
                if (ComputerSync.IsApplyingRemote) return;
                var inter = __instance.ic?.interactable;
                if (inter == null) return;
                ComputerSync.BroadcastApp(inter.id, newApp != null ? newApp.name : "", forceUpdate);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"ComputerController.SetComputerApp patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Elevator.CallElevator — player pressed a floor button.
    //
    //  SoD elevators are physical objects (currentSpeed/desiredY) that both
    //  machines simulate independently. Once both replay the same
    //  CallElevator(newFloor, upButton), their physics march in lockstep —
    //  no need to stream per-frame Y positions. Echo dedup via SenderId.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Elevator), nameof(Elevator.CallElevator))]
    public static class Elevator_CallElevator_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Elevator __instance, int newFloor, bool upButton)
        {
            try
            {
                if (__instance == null) return;
                if (ElevatorSync.IsApplyingRemote) return;
                ElevatorSync.BroadcastCall(__instance, newFloor, upButton);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Elevator.CallElevator patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(Actor), nameof(Actor.RecieveDamage))]
    public static class Actor_RecieveDamage_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(
            Actor __instance,
            float amount,
            Actor fromWho,
            Vector3 damagePosition,
            Vector3 damageDirection,
            SpatterPatternPreset forwardSpatter,
            SpatterPatternPreset backSpatter,
            SpatterSimulation.EraseMode spatterErase,
            bool forceRagdoll,
            float forcedRagdollDuration,
            float shockMP,
            bool enableKill,
            bool allowRecoil,
            float ragdollForceMP)
        {
            try
            {
                if (__instance == null) return;
                if (DamageSync.IsApplyingRemote) return;
                if (PlayerDamageSync.IsApplyingRemote) return;

                // Player victim path — HP itself is per-machine state, but we
                // still want to notify peers of the discrete damage event so
                // they get a chat banner and (on lethal) a downed pose on the
                // RemotePlayer. Then early-return — the NPC broadcast below
                // doesn't apply.
                if (global::Player.Instance != null && __instance.Pointer == global::Player.Instance.Pointer)
                {
                    int playerAttackerHumanId = -1;
                    if (fromWho != null)
                    {
                        try { playerAttackerHumanId = fromWho.TryCast<Human>()?.humanID ?? -1; } catch { }
                    }
                    PlayerDamageSync.BroadcastDamage(
                        playerAttackerHumanId,
                        amount,
                        damagePosition,
                        damageDirection,
                        isLethal: enableKill);
                    return;
                }

                // Look up victim humanID via Human cast.
                var victimHuman = __instance.TryCast<Human>();
                if (victimHuman == null) return;

                int attackerHumanId = -1;
                if (fromWho != null)
                {
                    try { attackerHumanId = fromWho.TryCast<Human>()?.humanID ?? -1; } catch { }
                }

                DamageSync.BroadcastDamage(
                    victimHuman.humanID,
                    attackerHumanId,
                    amount,
                    damagePosition,
                    damageDirection,
                    forwardSpatter,
                    backSpatter,
                    spatterErase,
                    forceRagdoll,
                    forcedRagdollDuration,
                    shockMP,
                    enableKill,
                    allowRecoil,
                    ragdollForceMP);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Actor.RecieveDamage patch: {ex.Message}");
            }
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Phase SJ.1 — Side-job awareness sync.
    //
    //  Three patches:
    //   • SideJob ctor postfix — broadcast Created when host creates a job.
    //   • SideJob.SetJobState postfix — broadcast Posted / Ended transitions.
    //   • SideJobController.JobCreationCheck prefix on clients — neutered so
    //     clients don't manufacture their own divergent set of jobs (host
    //     authority).
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(SideJob), MethodType.Constructor,
                  typeof(JobPreset), typeof(SideJobController.JobPickData), typeof(bool))]
    public static class SideJob_Ctor_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(SideJob __instance)
        {
            try { SideJobSync.BroadcastFromCtor(__instance); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"SideJob ctor patch: {ex.Message}"); }
        }
    }

    [HarmonyPatch(typeof(SideJob), nameof(SideJob.SetJobState))]
    public static class SideJob_SetJobState_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(SideJob __instance, SideJob.JobState newState)
        {
            try { SideJobSync.BroadcastStateChange(__instance, newState); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"SideJob.SetJobState patch: {ex.Message}"); }
        }
    }

    /// <summary>
    /// Client-only: skip <c>JobCreationCheck</c> entirely. Without this the
    /// client's local SideJobController would invent its own set of jobs
    /// from its private RNG state, which would be invisible to (and
    /// inconsistent with) the host's authoritative set.
    /// </summary>
    [HarmonyPatch(typeof(SideJobController), nameof(SideJobController.JobCreationCheck))]
    public static class SideJobController_JobCreationCheck_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix()
        {
            try
            {
                if (NetworkManager.IsConnected && !NetworkManager.IsHost)
                {
                    return false; // skip original — clients don't generate jobs
                }
            }
            catch { }
            return true;
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Phase 3b — NPC state mutations & player-to-NPC item transfers.
    //
    //  We patch the LEAF state-changers (Human.TryGiveItem,
    //  NewAIController.SetRestrained, NewAIController.SetStunned) instead of
    //  the player-side actions (Give/Handcuff/Takedown). That way every code
    //  path that reaches them — player input, scripted scenes, cop arrests —
    //  is mirrored uniformly without us having to know all the call sites.
    //
    //  Filter: TryGiveItem is the only method that doesn't already imply
    //  player intent (it's also called for NPC↔NPC trades). We restrict the
    //  broadcast to "givenBy == local player" so deterministic NPC-NPC
    //  scripted gives don't double-fire across machines.
    //
    //  SetRestrained / SetStunned are invariably triggered by player or by
    //  NPC AI. NPC AI runs only on the host — clients have AI disabled — so
    //  there's no double-fire risk; SenderId echo dedup on the receiver side
    //  handles the rare race.
    // ─────────────────────────────────────────────────────────────────────────

    [HarmonyPatch(typeof(Human), nameof(Human.TryGiveItem))]
    public static class Human_TryGiveItem_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Human __instance, Interactable givenItem, Human givenBy,
                                   bool defaultSuccess, bool enableSpeech, bool __result)
        {
            try
            {
                if (!__result) return;        // give failed — nothing changed
                if (__instance == null || givenItem == null) return;
                if (InventorySync.IsApplyingRemote) return;

                // Only broadcast when the LOCAL player is the giver. NPC↔NPC
                // gives are deterministic and don't need a packet.
                var localPlayer = global::Player.Instance;
                if (localPlayer == null || givenBy == null) return;
                if (givenBy.Pointer != localPlayer.Pointer) return;

                InventorySync.BroadcastGive(
                    __instance.humanID, givenItem.id,
                    defaultSuccess, enableSpeech);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"Human.TryGiveItem patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(NewAIController), nameof(NewAIController.SetRestrained))]
    public static class NewAIController_SetRestrained_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(NewAIController __instance, bool val, float duration)
        {
            try
            {
                if (__instance == null) return;
                if (InventorySync.IsApplyingRemote) return;

                // Only broadcast for citizens, not the local player.
                var human = __instance.human;
                if (human == null) return;
                if (global::Player.Instance != null && human.Pointer == global::Player.Instance.Pointer) return;

                InventorySync.BroadcastRestrained(human.humanID, val, duration);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"NewAIController.SetRestrained patch: {ex.Message}");
            }
        }
    }

    [HarmonyPatch(typeof(NewAIController), nameof(NewAIController.SetStunned))]
    public static class NewAIController_SetStunned_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(NewAIController __instance, bool val)
        {
            try
            {
                if (__instance == null) return;
                if (InventorySync.IsApplyingRemote) return;

                var human = __instance.human;
                if (human == null) return;
                if (global::Player.Instance != null && human.Pointer == global::Player.Instance.Pointer) return;

                InventorySync.BroadcastStunned(human.humanID, val);
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"NewAIController.SetStunned patch: {ex.Message}");
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

                // If we picked up one of our OWN previously placed items
                // (codebreaker, doorwedge, etc), tell peers to nuke their
                // mirror as well. ItemSync's pickup packet alone wouldn't
                // help them because their Interactable has a different local id.
                if (InventorySync.IsLocalPlacement(pickUpThis.id))
                    InventorySync.BroadcastPlaceRemove(pickUpThis.id);
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
