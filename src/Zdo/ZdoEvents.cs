using System;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;

namespace SoDCoop.Zdo;

/// <summary>
/// Registry of all <see cref="ZdoEventDispatcher"/> RPC handlers. Adding a
/// new event = one <see cref="ZdoEventDispatcher.Register"/> call here plus
/// a matching <see cref="Send*"/> helper.
///
/// <para>Currently scaffolding — Phase G migrates chat / map-ping / banners
/// over from per-feature packets to <see cref="PacketType.ZdoEventRpc"/>.
/// During the migration window legacy event paths and ZDO event paths
/// coexist; <see cref="ZdoFeatureFlags.UseZdoForEvents"/> gates the cutover.</para>
/// </summary>
public static class ZdoEvents
{
    // ── Event names (FNV-1a hashed at registration) ──
    public const string CHAT                = "chat";
    public const string MAP_PING            = "map-ping";
    public const string PAUSE_BANNER        = "pause-banner";
    public const string PHONE_BANNER        = "phone-banner";
    public const string SIDE_JOB_BANNER     = "side-job-banner";
    public const string SIDE_JOB_ACCEPT     = "side-job-accept";
    public const string SIDE_JOB_HANDIN     = "side-job-handin";
    public const string CRIME_DISCOVERED    = "crime-scene-discovered";
    public const string NPC_DAMAGE          = "npc-damage-banner";
    public const string PLAYER_DAMAGE       = "player-damage-banner";

    // ── Round 2 events (one-shot animations / lifecycle pings) ──
    /// <summary>Player pressed Melee/Block/Counter — payload: <c>(int playerId, byte actionKind)</c>.</summary>
    public const string COMBAT_ACTION       = "combat-action";

    /// <summary>SideJob.OnPlayerCall fired (player accepted) — payload: <c>(int jobId)</c>.</summary>
    public const string SIDE_JOB_PLAYER_CALL = "side-job-player-call";

    /// <summary>SideJob.OnRewarded fired — payload: <c>(int jobId, int reward)</c>.</summary>
    public const string SIDE_JOB_REWARDED    = "side-job-rewarded";

    /// <summary>AddMoney fired — payload: <c>(int amount, bool displayMessage, string reason)</c>.
    /// Credits-only (debits are local per MoneySync asymmetric policy).</summary>
    public const string MONEY_ADDED          = "money-added";

    /// <summary>NPC body discovered → case opens. No payload — host-side
    /// MurderDiscoveryPoller fires once on Murder.state→unsolved.</summary>
    public const string MURDER_DISCOVERED    = "murder-discovered";

    /// <summary>Player took damage — payload: <c>(int playerId, int attackerHumanId,
    /// float amount, Vector3 hitPos, Vector3 hitDir, bool lethal)</c>.</summary>
    public const string PLAYER_DAMAGE_RICH   = "player-damage-rich";

    /// <summary>Item picked up by a player — payload: <c>(int playerId, int interactableId)</c>.</summary>
    public const string ITEM_PICKUP          = "item-pickup";

    /// <summary>Item dropped by a player — payload: <c>(int playerId, int interactableId)</c>.</summary>
    public const string ITEM_DROP            = "item-drop";

    /// <summary>NPC took damage — payload: <c>(int victimHumanId, int attackerHumanId,
    /// float amount, Vector3 hitPos, Vector3 hitDir, bool enableKill)</c>. Spatter
    /// presets are not carried — receivers use defaults.</summary>
    public const string NPC_DAMAGE_RICH      = "npc-damage-rich";

    /// <summary>Elevator floor button pressed — payload: <c>(int buildingId,
    /// int btmX, int btmY, int btmZ, int newFloor, bool upButton)</c>.</summary>
    public const string ELEVATOR_CALL        = "elevator-call";

    /// <summary>Player placed an item — payload: <c>(int playerId, int sourceId,
    /// string presetName, Vector3 pos, Vector3 euler)</c>.</summary>
    public const string ITEM_PLACE           = "item-place";

    /// <summary>Player threw an item — payload: <c>(int playerId, int sourceId,
    /// string presetName, Vector3 pos, Vector3 euler, Vector3 linVel, Vector3 angVel)</c>.</summary>
    public const string ITEM_THROW           = "item-throw";

    /// <summary>Evidence note text changed — payload: <c>(string evId,
    /// byte[] dataKeys, string text)</c>. Replaces the disabled hot patch on
    /// <c>Evidence.SetNote</c>; receiver applies via
    /// <c>EvidenceSync.ApplySetNoteFromZdo</c>.</summary>
    public const string EVIDENCE_SET_NOTE    = "evidence-set-note";

    /// <summary>Evidence created — payload: <c>(string evId, string presetName,
    /// string parentEvId, int ownerHumanId, int writerHumanId, int receiverHumanId,
    /// bool forceDiscovery)</c>. Receiver invokes EvidenceCreator.CreateEvidence.</summary>
    public const string EVIDENCE_CREATE      = "evidence-create";

    /// <summary>Evidence discovery flag added — payload: <c>(string evId, byte discovery)</c>.</summary>
    public const string EVIDENCE_DISCOVERY   = "evidence-discovery";

    /// <summary>Evidence custom name set — payload: <c>(string evId, byte dataKey, string name)</c>.</summary>
    public const string EVIDENCE_CUSTOM_NAME = "evidence-custom-name";

    /// <summary>Case board card pinned — payload: <c>(int caseId, string evId,
    /// byte[] dataKeys, Vector2 pos, bool forceAutoPin)</c>.</summary>
    public const string CB_PIN               = "cb-pin";

    /// <summary>Case board card unpinned — payload: <c>(int caseId, string evId,
    /// byte[] dataKeys)</c>.</summary>
    public const string CB_UNPIN             = "cb-unpin";

    /// <summary>Case board card moved — payload: <c>(int caseId, string evId,
    /// byte[] dataKeys, Vector2 pos)</c>.</summary>
    public const string CB_MOVE              = "cb-move";

    /// <summary>Case board string-link added — payload: <c>(int caseId,
    /// string fromEvId, byte[] fromKeys, string toEvId, byte[] toKeys, byte colour)</c>.</summary>
    public const string CB_STRING            = "cb-string";

    /// <summary>Case board string-link removed — payload matches CB_STRING minus colour.</summary>
    public const string CB_STRING_REMOVE     = "cb-string-remove";

    /// <summary>Citizen idle / arms animation state delta.
    /// Payload: int humanId, byte idleAnimationState, byte armsBoolAnimationState.
    /// Host-only sender (CitizenAnimationPoller); receivers locally call
    /// SetIdleAnimationState + SetArmsBoolState on the matching citizen so
    /// dancers / sitters / phone-talkers / cooks animate identically on
    /// every peer.</summary>
    public const string CITIZEN_ANIM_STATE   = "citizen-anim-state";

    /// <summary>Social-credit (reputation) snapshot delta.
    /// Payload: int newSocialCredit. Host-only sender (SocialCreditPoller);
    /// receivers stamp <c>GameplayController.Instance.socialCredit</c> so
    /// the wanted-level / district-restriction logic uses the host's
    /// authoritative score everywhere.</summary>
    public const string SOCIAL_CREDIT        = "social-credit";

    /// <summary>Player apartment-ownership add/remove delta.
    /// Payload: int senderPlayerId, int addressId, byte op (1=add, 0=remove).
    /// Each peer broadcasts its own diff against last tick. Receivers merge
    /// into local <c>Player.Instance.apartmentsOwned</c> — coop treats
    /// apartments as shared so any player can use any purchased address.</summary>
    public const string APARTMENT_OWNED      = "apartment-owned";

    /// <summary>One speech-bubble line spoken by an Actor (citizen OR player
    /// twin). Payload: int speakerHumanId, string text, byte shout
    /// (1 = shouting). Sent by <see cref="Pollers.SpeechBubblePoller"/>
    /// when an Actor's active speech bubble transitions from "null /
    /// typewriting" to "final text revealed". Receivers look up the Actor
    /// by humanId and call <c>speechController.Speak(text, shout)</c> so
    /// the same bubble appears over their head locally — sideline players
    /// can read what NPCs and other players are saying to each other.</summary>
    public const string SPEECH_BUBBLE        = "speech-bubble";

    public static void RegisterAll()
    {
        ZdoEventDispatcher.Register(CHAT,             OnChat);
        ZdoEventDispatcher.Register(MAP_PING,         OnMapPing);
        ZdoEventDispatcher.Register(PAUSE_BANNER,     OnPauseBanner);
        ZdoEventDispatcher.Register(PHONE_BANNER,     OnPhoneBanner);
        ZdoEventDispatcher.Register(SIDE_JOB_BANNER,  OnSideJobBanner);
        ZdoEventDispatcher.Register(SIDE_JOB_ACCEPT,  OnSideJobAccept);
        ZdoEventDispatcher.Register(SIDE_JOB_HANDIN,  OnSideJobHandIn);
        ZdoEventDispatcher.Register(CRIME_DISCOVERED, OnCrimeDiscovered);
        ZdoEventDispatcher.Register(NPC_DAMAGE,       OnNpcDamage);
        ZdoEventDispatcher.Register(PLAYER_DAMAGE,    OnPlayerDamage);

        // Round 2
        ZdoEventDispatcher.Register(COMBAT_ACTION,         OnCombatAction);
        ZdoEventDispatcher.Register(SIDE_JOB_PLAYER_CALL,  OnSideJobPlayerCall);
        ZdoEventDispatcher.Register(SIDE_JOB_REWARDED,     OnSideJobRewarded);

        // Round 10
        ZdoEventDispatcher.Register(MONEY_ADDED,           OnMoneyAdded);

        // Phase G.5 wave 1
        ZdoEventDispatcher.Register(MURDER_DISCOVERED,     OnMurderDiscovered);
        ZdoEventDispatcher.Register(PLAYER_DAMAGE_RICH,    OnPlayerDamageRich);
        ZdoEventDispatcher.Register(ITEM_PICKUP,           OnItemPickup);
        ZdoEventDispatcher.Register(ITEM_DROP,             OnItemDrop);
        ZdoEventDispatcher.Register(NPC_DAMAGE_RICH,       OnNpcDamageRich);
        ZdoEventDispatcher.Register(ELEVATOR_CALL,         OnElevatorCall);
        ZdoEventDispatcher.Register(ITEM_PLACE,            OnItemPlace);
        ZdoEventDispatcher.Register(ITEM_THROW,            OnItemThrow);
        ZdoEventDispatcher.Register(EVIDENCE_SET_NOTE,     OnEvidenceSetNote);
        ZdoEventDispatcher.Register(EVIDENCE_CREATE,       OnEvidenceCreate);
        ZdoEventDispatcher.Register(EVIDENCE_DISCOVERY,    OnEvidenceDiscovery);
        ZdoEventDispatcher.Register(EVIDENCE_CUSTOM_NAME,  OnEvidenceCustomName);
        ZdoEventDispatcher.Register(CB_PIN,                OnCbPin);
        ZdoEventDispatcher.Register(CB_UNPIN,              OnCbUnpin);
        ZdoEventDispatcher.Register(CB_MOVE,               OnCbMove);
        ZdoEventDispatcher.Register(CB_STRING,             OnCbString);
        ZdoEventDispatcher.Register(CB_STRING_REMOVE,      OnCbStringRemove);
        ZdoEventDispatcher.Register(CITIZEN_ANIM_STATE,    OnCitizenAnimState);
        ZdoEventDispatcher.Register(SOCIAL_CREDIT,         OnSocialCredit);
        ZdoEventDispatcher.Register(APARTMENT_OWNED,       OnApartmentOwned);
        ZdoEventDispatcher.Register(SPEECH_BUBBLE,         OnSpeechBubble);
    }

    private static readonly NetDataWriter _w = new();

    // ── Helpers (Phase G call sites) ──

    public static void SendChat(string playerName, string text)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(playerName ?? "");
        _w.Put(text ?? "");
        ZdoEventDispatcher.Send(CHAT, _w);
    }

    public static void SendMapPing(string playerName, UnityEngine.Vector3 pos)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(playerName ?? "");
        _w.Put(pos.x); _w.Put(pos.y); _w.Put(pos.z);
        ZdoEventDispatcher.Send(MAP_PING, _w, DeliveryMethod.ReliableOrdered);
    }

    /// <summary>
    /// Combat one-shot animation event. Sequenced delivery — late frames can
    /// be dropped, the next stomps anyway. Receiver looks up the
    /// <c>RemotePlayer</c> by sender peer-id and pulses the matching animator
    /// trigger via <c>RemotePlayer.ApplyAction</c>. Mirrors what the legacy
    /// <c>InventorySync.BroadcastAction</c> + <c>ItemActionPacket</c> path
    /// did, but via the unified RPC channel.
    /// </summary>
    public static void SendCombatAction(byte actionKind)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(SoDCoop.Network.NetworkManager.LocalPlayerId);
        _w.Put(actionKind);
        ZdoEventDispatcher.Send(COMBAT_ACTION, _w, DeliveryMethod.Sequenced);
    }

    /// <summary>Host-only. Broadcast a single citizen's idle/arms animation
    /// state. Called by <c>CitizenAnimationPoller</c> on diff against the
    /// previous tick's snapshot; receivers locally apply via
    /// <c>SetIdleAnimationState</c> + <c>SetArmsBoolState</c> so
    /// dancers/sitters/cooks animate identically across peers.</summary>
    public static void SendCitizenAnimState(int humanId, byte idleState, byte armsState)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        if (!SoDCoop.Network.NetworkManager.IsHost) return;
        _w.Reset();
        _w.Put(humanId);
        _w.Put(idleState);
        _w.Put(armsState);

        // Spatial cull: anim state is purely visual — peer in another
        // district doesn't need a 5 Hz × N citizens stream they can't see.
        // Pull citizen position from CityData; if unresolvable we fall
        // through to a broadcast (better than dropping the event).
        UnityEngine.Vector3? originPos = null;
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict != null
                && dict.TryGetValue(humanId, out var c)
                && c != null
                && c.transform != null)
            {
                originPos = c.transform.position;
            }
        }
        catch { }

        // Sequenced: late frames can be dropped, the next state stomps anyway.
        ZdoEventDispatcher.Send(CITIZEN_ANIM_STATE, _w, DeliveryMethod.Sequenced, originPos);
    }

    /// <summary>Host-only. Broadcast the current social-credit (reputation)
    /// score. Called from <c>SocialCreditPoller</c> on diff against the
    /// previous tick's snapshot; receivers stamp
    /// <c>GameplayController.Instance.socialCredit</c> so the wanted-level
    /// / district-restriction logic uses host's authoritative score
    /// everywhere.</summary>
    public static void SendSocialCredit(int credit)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        if (!SoDCoop.Network.NetworkManager.IsHost) return;
        _w.Reset();
        _w.Put(credit);
        ZdoEventDispatcher.Send(SOCIAL_CREDIT, _w, DeliveryMethod.ReliableOrdered);
    }

    /// <summary>Broadcast one speech bubble line for the given Actor (by
    /// humanId). Host broadcasts NPC bubbles; each peer (including host)
    /// broadcasts their own player's bubbles using their twin humanId so
    /// the same Actor exists in every receiver's CityData. Sequenced —
    /// late lines can be skipped, the next line stomps anyway.</summary>
    public static void SendSpeechBubble(int speakerHumanId, string text, bool shout)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        if (string.IsNullOrEmpty(text)) return;
        _w.Reset();
        _w.Put(speakerHumanId);
        _w.Put(text);
        _w.Put(shout ? (byte)1 : (byte)0);

        // Spatial cull: bubbles are head-attached visuals. A peer 400 m
        // across the city won't see the bubble even if they receive the
        // packet (Actor isn't in their camera frustum, and chat already
        // covers cross-district communication anyway).
        UnityEngine.Vector3? originPos = null;
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict != null
                && dict.TryGetValue(speakerHumanId, out var c)
                && c != null
                && c.transform != null)
            {
                originPos = c.transform.position;
            }
        }
        catch { }

        ZdoEventDispatcher.Send(SPEECH_BUBBLE, _w, DeliveryMethod.Sequenced, originPos);
    }

    /// <summary>Broadcast a per-player apartment ownership add or remove.
    /// Each peer sends its own diff every tick so the union ends up on
    /// every receiver's Player.Instance.apartmentsOwned. Host included —
    /// host's purchases reach clients via the same path.</summary>
    public static void SendApartmentOwned(int addressId, bool added)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(SoDCoop.Network.NetworkManager.LocalPlayerId);
        _w.Put(addressId);
        _w.Put(added ? (byte)1 : (byte)0);
        ZdoEventDispatcher.Send(APARTMENT_OWNED, _w, DeliveryMethod.ReliableOrdered);
    }

    public static void SendSideJobPlayerCall(int jobId)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(jobId);
        ZdoEventDispatcher.Send(SIDE_JOB_PLAYER_CALL, _w);
    }

    public static void SendSideJobRewarded(int jobId, int reward)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(jobId);
        _w.Put(reward);
        ZdoEventDispatcher.Send(SIDE_JOB_REWARDED, _w);
    }

    /// <summary>
    /// AddMoney one-shot event. Carries amount + displayMessage + reason
    /// so the receiver shows the same banner text the originating player
    /// saw. Replaces the legacy MoneyAdded packet wire (kept as fallback
    /// when UseZdoForEvents is off for diagnostic A/B).
    /// </summary>
    public static void SendMoneyAdded(int amount, bool displayMessage, string reason)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(amount);
        _w.Put(displayMessage);
        _w.Put(reason ?? "");
        ZdoEventDispatcher.Send(MONEY_ADDED, _w);
    }

    /// <summary>Body-discovery banner — no payload, fires once on host.</summary>
    public static void SendMurderDiscovered()
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        ZdoEventDispatcher.Send(MURDER_DISCOVERED, _w);
    }

    public static void SendPlayerDamage(int attackerHumanId, float amount,
                                        UnityEngine.Vector3 hitPos, UnityEngine.Vector3 hitDir, bool lethal)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(SoDCoop.Network.NetworkManager.LocalPlayerId);
        _w.Put(attackerHumanId);
        _w.Put(amount);
        _w.Put(hitPos.x); _w.Put(hitPos.y); _w.Put(hitPos.z);
        _w.Put(hitDir.x); _w.Put(hitDir.y); _w.Put(hitDir.z);
        _w.Put(lethal);
        ZdoEventDispatcher.Send(PLAYER_DAMAGE_RICH, _w);
    }

    public static void SendItemPickup(int interactableId)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(SoDCoop.Network.NetworkManager.LocalPlayerId);
        _w.Put(interactableId);
        ZdoEventDispatcher.Send(ITEM_PICKUP, _w);
    }

    public static void SendItemDrop(int interactableId)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(SoDCoop.Network.NetworkManager.LocalPlayerId);
        _w.Put(interactableId);
        ZdoEventDispatcher.Send(ITEM_DROP, _w);
    }

    public static void SendNpcDamage(int victimHumanId, int attackerHumanId, float amount,
                                     UnityEngine.Vector3 hitPos, UnityEngine.Vector3 hitDir,
                                     bool enableKill)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(victimHumanId);
        _w.Put(attackerHumanId);
        _w.Put(amount);
        _w.Put(hitPos.x); _w.Put(hitPos.y); _w.Put(hitPos.z);
        _w.Put(hitDir.x); _w.Put(hitDir.y); _w.Put(hitDir.z);
        _w.Put(enableKill);
        // Spatial: a hit on an NPC across the city has no observable
        // effect for distant peers (vitals + animations replicate via
        // ZDO state which is already sector-culled).
        ZdoEventDispatcher.Send(NPC_DAMAGE_RICH, _w, DeliveryMethod.ReliableOrdered, hitPos);
    }

    public static void SendElevatorCall(int buildingId, UnityEngine.Vector3Int btm,
                                        int newFloor, bool upButton)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(buildingId);
        _w.Put(btm.x); _w.Put(btm.y); _w.Put(btm.z);
        _w.Put(newFloor);
        _w.Put(upButton);
        ZdoEventDispatcher.Send(ELEVATOR_CALL, _w);
    }

    public static void SendItemPlace(int sourceId, string presetName,
                                     UnityEngine.Vector3 pos, UnityEngine.Vector3 euler)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(SoDCoop.Network.NetworkManager.LocalPlayerId);
        _w.Put(sourceId);
        _w.Put(presetName ?? "");
        _w.Put(pos.x); _w.Put(pos.y); _w.Put(pos.z);
        _w.Put(euler.x); _w.Put(euler.y); _w.Put(euler.z);
        ZdoEventDispatcher.Send(ITEM_PLACE, _w);
    }

    public static void SendItemThrow(int sourceId, string presetName,
                                     UnityEngine.Vector3 pos, UnityEngine.Vector3 euler,
                                     UnityEngine.Vector3 linVel, UnityEngine.Vector3 angVel)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(SoDCoop.Network.NetworkManager.LocalPlayerId);
        _w.Put(sourceId);
        _w.Put(presetName ?? "");
        _w.Put(pos.x); _w.Put(pos.y); _w.Put(pos.z);
        _w.Put(euler.x); _w.Put(euler.y); _w.Put(euler.z);
        _w.Put(linVel.x); _w.Put(linVel.y); _w.Put(linVel.z);
        _w.Put(angVel.x); _w.Put(angVel.y); _w.Put(angVel.z);
        ZdoEventDispatcher.Send(ITEM_THROW, _w);
    }

    public static void SendEvidenceSetNote(string evId, byte[] dataKeys, string text)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(evId ?? "");
        int keyCount = dataKeys?.Length ?? 0;
        _w.Put(keyCount);
        for (int i = 0; i < keyCount; i++) _w.Put(dataKeys[i]);
        _w.Put(text ?? "");
        ZdoEventDispatcher.Send(EVIDENCE_SET_NOTE, _w);
    }

    public static void SendEvidenceCreate(string evId, string presetName, string parentEvId,
                                          int ownerHumanId, int writerHumanId, int receiverHumanId,
                                          bool forceDiscovery)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(evId ?? "");
        _w.Put(presetName ?? "");
        _w.Put(parentEvId ?? "");
        _w.Put(ownerHumanId);
        _w.Put(writerHumanId);
        _w.Put(receiverHumanId);
        _w.Put(forceDiscovery);
        ZdoEventDispatcher.Send(EVIDENCE_CREATE, _w);
    }

    public static void SendEvidenceDiscovery(string evId, byte discovery)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(evId ?? "");
        _w.Put(discovery);
        ZdoEventDispatcher.Send(EVIDENCE_DISCOVERY, _w);
    }

    public static void SendEvidenceCustomName(string evId, byte dataKey, string customName)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(evId ?? "");
        _w.Put(dataKey);
        _w.Put(customName ?? "");
        ZdoEventDispatcher.Send(EVIDENCE_CUSTOM_NAME, _w);
    }

    public static void SendCbPin(int caseId, string evId, byte[] dataKeys,
                                 UnityEngine.Vector2 pos, bool forceAutoPin)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(caseId);
        _w.Put(evId ?? "");
        int kc = dataKeys?.Length ?? 0;
        _w.Put(kc);
        for (int i = 0; i < kc; i++) _w.Put(dataKeys[i]);
        _w.Put(pos.x); _w.Put(pos.y);
        _w.Put(forceAutoPin);
        ZdoEventDispatcher.Send(CB_PIN, _w);
    }

    public static void SendCbUnpin(int caseId, string evId, byte[] dataKeys)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(caseId);
        _w.Put(evId ?? "");
        int kc = dataKeys?.Length ?? 0;
        _w.Put(kc);
        for (int i = 0; i < kc; i++) _w.Put(dataKeys[i]);
        ZdoEventDispatcher.Send(CB_UNPIN, _w);
    }

    public static void SendCbMove(int caseId, string evId, byte[] dataKeys, UnityEngine.Vector2 pos)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(caseId);
        _w.Put(evId ?? "");
        int kc = dataKeys?.Length ?? 0;
        _w.Put(kc);
        for (int i = 0; i < kc; i++) _w.Put(dataKeys[i]);
        _w.Put(pos.x); _w.Put(pos.y);
        ZdoEventDispatcher.Send(CB_MOVE, _w);
    }

    public static void SendCbString(int caseId, string fromEvId, byte[] fromKeys,
                                    string toEvId, byte[] toKeys, byte colour)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(caseId);
        _w.Put(fromEvId ?? "");
        int fk = fromKeys?.Length ?? 0; _w.Put(fk);
        for (int i = 0; i < fk; i++) _w.Put(fromKeys[i]);
        _w.Put(toEvId ?? "");
        int tk = toKeys?.Length ?? 0; _w.Put(tk);
        for (int i = 0; i < tk; i++) _w.Put(toKeys[i]);
        _w.Put(colour);
        ZdoEventDispatcher.Send(CB_STRING, _w);
    }

    public static void SendCbStringRemove(int caseId, string fromEvId, byte[] fromKeys,
                                          string toEvId, byte[] toKeys)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(caseId);
        _w.Put(fromEvId ?? "");
        int fk = fromKeys?.Length ?? 0; _w.Put(fk);
        for (int i = 0; i < fk; i++) _w.Put(fromKeys[i]);
        _w.Put(toEvId ?? "");
        int tk = toKeys?.Length ?? 0; _w.Put(tk);
        for (int i = 0; i < tk; i++) _w.Put(toKeys[i]);
        ZdoEventDispatcher.Send(CB_STRING_REMOVE, _w);
    }

    // ── Handlers ──
    //
    // During Phase G migration the legacy ChatMessage / MapPing packet types
    // still own UI rendering. These handlers are intentionally minimal — they
    // log receipt and let the legacy CoopUI / PingSystem code render via the
    // existing packet pathway. Phase G call sites that flip the flag will
    // route via ZdoEventDispatcher.Send instead, and these handlers will be
    // expanded to drive the UI directly.

    private static void OnChat(NetDataReader r, int senderId)
    {
        try
        {
            string name = r.GetString();
            string text = r.GetString();
            // Surface to the existing CoopUI chat panel.
            try { SoDCoop.UI.CoopUI.AppendIncomingChat(senderId, name, text); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnChat] CoopUI.AppendIncomingChat: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnChat] {ex.Message}"); }
    }

    private static void OnMapPing(NetDataReader r, int senderId)
    {
        try
        {
            string name = r.GetString();
            float x = r.GetFloat(), y = r.GetFloat(), z = r.GetFloat();
            try { SoDCoop.UI.PingSystem.AppendRemotePing(senderId, name, new UnityEngine.Vector3(x, y, z)); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnMapPing] AppendRemotePing: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnMapPing] {ex.Message}"); }
    }

    private static void OnPauseBanner(NetDataReader r, int senderId)
    {
        try
        {
            int senderPlayerId = r.GetInt();
            bool paused = r.GetBool();
            try { SoDCoop.UI.PingSystem.HandlePauseBanner(senderPlayerId, paused); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnPauseBanner] PingSystem: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnPauseBanner] {ex.Message}"); }
    }
    private static void OnPhoneBanner(NetDataReader r, int senderId)    { _ = r; _ = senderId; }
    private static void OnSideJobBanner(NetDataReader r, int senderId)  { _ = r; _ = senderId; }
    private static void OnSideJobAccept(NetDataReader r, int senderId)  { _ = r; _ = senderId; }
    private static void OnSideJobHandIn(NetDataReader r, int senderId)  { _ = r; _ = senderId; }
    private static void OnCrimeDiscovered(NetDataReader r, int senderId){ _ = r; _ = senderId; }
    private static void OnNpcDamage(NetDataReader r, int senderId)      { _ = r; _ = senderId; }
    private static void OnPlayerDamage(NetDataReader r, int senderId)   { _ = r; _ = senderId; }

    private static void OnCombatAction(NetDataReader r, int senderId)
    {
        try
        {
            int  playerId  = r.GetInt();
            byte actionKind = r.GetByte();
            // Sender filters itself implicitly — its own LocalPlayerId payload
            // matches and the lookup returns null below. We still defend
            // against echoes by checking explicitly.
            if (playerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;

            var rp = SoDCoop.Player.RemotePlayerManager.GetPlayer(playerId);
            if (rp == null) return;
            try { rp.ApplyAction(actionKind); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCombatAction] ApplyAction: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCombatAction] {ex.Message}"); }
    }

    private static void OnSideJobPlayerCall(NetDataReader r, int senderId)
    {
        try
        {
            int jobId = r.GetInt();
            // Host is authoritative for side-job state — clients send this
            // RPC up to host, host runs OnPlayerCall on the real SideJob,
            // which flips accepted=true + advances state, then we
            // re-broadcast the upsert so all peers see the new state.
            // Mirrors the legacy SideJobSync.HandleAcceptRequest.
            if (!SoDCoop.Network.NetworkManager.IsHost) return;
            var ctrl = global::SideJobController.Instance;
            if (ctrl == null) return;
            var dict = ctrl.allJobsDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(jobId, out var job) || job == null)
            {
                Plugin.Log.LogWarning($"[ZdoEvents.OnSideJobPlayerCall] jobID={jobId} not in allJobsDictionary on host.");
                return;
            }

            SoDCoop.Sync.SideJobSync.RunOnPlayerCallAndRebroadcast(job, senderId);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnSideJobPlayerCall] {ex.Message}"); }
    }

    private static void OnMurderDiscovered(NetDataReader r, int senderId)
    {
        try
        {
            _ = r; _ = senderId;
            // Host originates; receivers replay the legacy banner via existing
            // CitizenDeathSync apply path.
            try { SoDCoop.Sync.CitizenDeathSync.ApplyDiscoveryFromZdo(); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnMurderDiscovered] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnMurderDiscovered] {ex.Message}"); }
    }

    private static void OnPlayerDamageRich(NetDataReader r, int senderId)
    {
        try
        {
            int playerId  = r.GetInt();
            int attacker  = r.GetInt();
            float amount  = r.GetFloat();
            float px = r.GetFloat(), py = r.GetFloat(), pz = r.GetFloat();
            float dx = r.GetFloat(), dy = r.GetFloat(), dz = r.GetFloat();
            bool lethal   = r.GetBool();
            if (playerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;
            try
            {
                SoDCoop.Sync.PlayerDamageSync.ApplyFromZdo(
                    playerId, attacker, amount,
                    new UnityEngine.Vector3(px, py, pz),
                    new UnityEngine.Vector3(dx, dy, dz),
                    lethal);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnPlayerDamageRich] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnPlayerDamageRich] {ex.Message}"); }
    }

    private static void OnItemPickup(NetDataReader r, int senderId)
    {
        try
        {
            int playerId       = r.GetInt();
            int interactableId = r.GetInt();
            if (playerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;
            try { SoDCoop.Sync.ItemSync.ApplyPickupFromZdo(playerId, interactableId); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemPickup] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemPickup] {ex.Message}"); }
    }

    private static void OnItemDrop(NetDataReader r, int senderId)
    {
        try
        {
            int playerId       = r.GetInt();
            int interactableId = r.GetInt();
            if (playerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;
            try { SoDCoop.Sync.ItemSync.ApplyDropFromZdo(playerId, interactableId); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemDrop] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemDrop] {ex.Message}"); }
    }

    private static void OnItemPlace(NetDataReader r, int senderId)
    {
        try
        {
            int playerId = r.GetInt();
            int sourceId = r.GetInt();
            string preset = r.GetString();
            float px = r.GetFloat(), py = r.GetFloat(), pz = r.GetFloat();
            float ex = r.GetFloat(), ey = r.GetFloat(), ez = r.GetFloat();
            if (playerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;
            try
            {
                SoDCoop.Sync.InventorySync.ApplyPlaceFromZdo(playerId, sourceId, preset,
                    new UnityEngine.Vector3(px, py, pz),
                    new UnityEngine.Vector3(ex, ey, ez));
            }
            catch (Exception ex2) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemPlace] apply: {ex2.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemPlace] {ex.Message}"); }
    }

    private static void OnEvidenceSetNote(NetDataReader r, int senderId)
    {
        try
        {
            string evId = r.GetString();
            int keyCount = r.GetInt();
            byte[] keys = keyCount > 0 ? new byte[keyCount] : System.Array.Empty<byte>();
            for (int i = 0; i < keyCount; i++) keys[i] = r.GetByte();
            string text = r.GetString();
            try { SoDCoop.Sync.EvidenceSync.ApplySetNoteFromZdo(evId, keys, text); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceSetNote] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceSetNote] {ex.Message}"); }
    }

    private static void OnEvidenceCreate(NetDataReader r, int senderId)
    {
        try
        {
            string evId       = r.GetString();
            string presetName = r.GetString();
            string parentEvId = r.GetString();
            int ownerId       = r.GetInt();
            int writerId      = r.GetInt();
            int receiverId    = r.GetInt();
            bool forceDisc    = r.GetBool();
            try { SoDCoop.Sync.EvidenceSync.ApplyCreateFromZdo(evId, presetName, parentEvId, ownerId, writerId, receiverId, forceDisc, senderId); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceCreate] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceCreate] {ex.Message}"); }
    }

    private static void OnEvidenceDiscovery(NetDataReader r, int senderId)
    {
        try
        {
            string evId = r.GetString();
            byte disc   = r.GetByte();
            try { SoDCoop.Sync.EvidenceSync.ApplyDiscoveryFromZdo(evId, disc); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceDiscovery] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceDiscovery] {ex.Message}"); }
    }

    private static void OnEvidenceCustomName(NetDataReader r, int senderId)
    {
        try
        {
            string evId = r.GetString();
            byte dk     = r.GetByte();
            string name = r.GetString();
            try { SoDCoop.Sync.EvidenceSync.ApplyCustomNameFromZdo(evId, dk, name); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceCustomName] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnEvidenceCustomName] {ex.Message}"); }
    }

    private static byte[] ReadByteList(NetDataReader r)
    {
        int n = r.GetInt();
        if (n <= 0) return System.Array.Empty<byte>();
        var arr = new byte[n];
        for (int i = 0; i < n; i++) arr[i] = r.GetByte();
        return arr;
    }

    private static void OnCbPin(NetDataReader r, int senderId)
    {
        try
        {
            int caseId = r.GetInt();
            string evId = r.GetString();
            byte[] dk = ReadByteList(r);
            float px = r.GetFloat(), py = r.GetFloat();
            bool forceAuto = r.GetBool();
            try { SoDCoop.Sync.CaseBoardSync.ApplyPinFromZdo(caseId, evId, dk, new UnityEngine.Vector2(px, py), forceAuto); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbPin] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbPin] {ex.Message}"); }
    }

    private static void OnCbUnpin(NetDataReader r, int senderId)
    {
        try
        {
            int caseId = r.GetInt();
            string evId = r.GetString();
            byte[] dk = ReadByteList(r);
            try { SoDCoop.Sync.CaseBoardSync.ApplyUnpinFromZdo(caseId, evId, dk); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbUnpin] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbUnpin] {ex.Message}"); }
    }

    private static void OnCbMove(NetDataReader r, int senderId)
    {
        try
        {
            int caseId = r.GetInt();
            string evId = r.GetString();
            byte[] dk = ReadByteList(r);
            float px = r.GetFloat(), py = r.GetFloat();
            try { SoDCoop.Sync.CaseBoardSync.ApplyMoveFromZdo(caseId, evId, dk, new UnityEngine.Vector2(px, py), senderId); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbMove] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbMove] {ex.Message}"); }
    }

    private static void OnCbString(NetDataReader r, int senderId)
    {
        try
        {
            int caseId = r.GetInt();
            string fromEv = r.GetString();
            byte[] fromK = ReadByteList(r);
            string toEv = r.GetString();
            byte[] toK = ReadByteList(r);
            byte colour = r.GetByte();
            try { SoDCoop.Sync.CaseBoardSync.ApplyStringFromZdo(caseId, fromEv, fromK, toEv, toK, colour); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbString] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbString] {ex.Message}"); }
    }

    private static void OnCbStringRemove(NetDataReader r, int senderId)
    {
        try
        {
            int caseId = r.GetInt();
            string fromEv = r.GetString();
            byte[] fromK = ReadByteList(r);
            string toEv = r.GetString();
            byte[] toK = ReadByteList(r);
            try { SoDCoop.Sync.CaseBoardSync.ApplyStringRemoveFromZdo(caseId, fromEv, fromK, toEv, toK); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbStringRemove] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCbStringRemove] {ex.Message}"); }
    }

    /// <summary>Receiver-side. Look up the citizen by humanID and call
    /// SetIdleAnimationState + SetArmsBoolState locally so dancers /
    /// sitters / cooks animate identically across peers. Host doesn't
    /// process its own broadcasts (sender filter); clients apply
    /// silently. Skips unknown humanIDs (citizen may have been despawned
    /// after the snapshot was taken).</summary>
    private static void OnCitizenAnimState(NetDataReader r, int senderId)
    {
        try
        {
            int  humanId   = r.GetInt();
            byte idleState = r.GetByte();
            byte armsState = r.GetByte();

            // Host echoes its own broadcasts back to itself via the
            // dispatcher fan-out; ignore — we already did the work locally.
            if (SoDCoop.Network.NetworkManager.IsHost) return;

            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(humanId, out var human) || human == null) return;
            var ac = human.animationController;
            if (ac == null) return;

            try { ac.SetIdleAnimationState((global::CitizenAnimationController.IdleAnimationState)idleState); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCitizenAnimState] SetIdleAnimationState({idleState}) on {humanId}: {ex.Message}"); }

            try { ac.SetArmsBoolState((global::CitizenAnimationController.ArmsBoolSate)armsState); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCitizenAnimState] SetArmsBoolState({armsState}) on {humanId}: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnCitizenAnimState] {ex.Message}"); }
    }

    /// <summary>Receiver-side. Look up the Actor by humanId and replay the
    /// speech bubble locally via SpeechController.Speak so observer peers
    /// see "the NPC just said this". Self-broadcasts are skipped (the
    /// Actor is already speaking on the sender's machine, nothing to do
    /// there). Empty text is silently ignored.</summary>
    private static void OnSpeechBubble(NetDataReader r, int senderId)
    {
        try
        {
            int speakerHumanId = r.GetInt();
            string text        = r.GetString();
            bool shout         = r.GetByte() == 1;

            if (string.IsNullOrEmpty(text)) return;

            // Skip self-echoes. Two cases:
            //   1. Host: speaker is host's own player citizen — Player.
            //      Instance.humanID matches the broadcast humanId.
            //   2. Client: speaker is client's twin citizen on the world —
            //      MyTwinHumanID matches. The bubble already showed
            //      locally on client's Player.Instance; replaying on the
            //      twin citizen object would create a duplicate visual.
            try
            {
                int myHuman = 0;
                try { myHuman = global::Player.Instance?.humanID ?? 0; } catch { }
                if (myHuman > 0 && speakerHumanId == myHuman) return;

                int myTwin = SoDCoop.Network.NetworkManager.MyTwinHumanID;
                if (myTwin > 0 && speakerHumanId == myTwin) return;
            }
            catch { }

            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(speakerHumanId, out var human) || human == null) return;
            var sc = human.speechController;
            if (sc == null) return;

            try
            {
                // Simple-string Speak overload (SpeechController.cs:1045):
                //   void Speak(string ddsMessage, bool shout, bool interupt,
                //              Human speakAbout, SideJob sideJob,
                //              Human.InteractionDialogInstance interactionInstance)
                sc.Speak(text, shout, /*interupt:*/ false, /*speakAbout:*/ null,
                         /*sideJob:*/ null, /*interactionInstance:*/ null);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnSpeechBubble] Speak({speakerHumanId}): {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnSpeechBubble] {ex.Message}"); }
    }

    /// <summary>Receiver-side. Merge the sender's apartment-ownership delta
    /// into local <c>Player.Instance.apartmentsOwned</c>. Self-broadcasts
    /// are skipped (sender is us). Looking up by addressID via
    /// <c>CityData.Instance.addressDictionary</c>.</summary>
    private static void OnApartmentOwned(NetDataReader r, int senderId)
    {
        try
        {
            int senderPlayerId = r.GetInt();
            int addressId      = r.GetInt();
            byte op            = r.GetByte();

            if (senderPlayerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;

            var addrs = global::CityData.Instance?.addressDictionary;
            if (addrs == null) return;
            if (!addrs.TryGetValue(addressId, out var addr) || addr == null) return;

            var p = global::Player.Instance;
            if (p == null) return;
            var owned = p.apartmentsOwned;
            if (owned == null) return;

            // List<NewAddress>.Contains uses reference equality which is
            // what we want here — the receiver and sender resolve the same
            // NewAddress object via the shared addressDictionary.
            bool isAdd = op == 1;
            bool already = owned.Contains(addr);
            if (isAdd && !already)
            {
                try { owned.Add(addr); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnApartmentOwned] add: {ex.Message}"); }
                Plugin.Log.LogInfo($"[ZdoEvents.OnApartmentOwned] +addr#{addressId} from player {senderPlayerId}");
            }
            else if (!isAdd && already)
            {
                try { owned.Remove(addr); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnApartmentOwned] remove: {ex.Message}"); }
                Plugin.Log.LogInfo($"[ZdoEvents.OnApartmentOwned] -addr#{addressId} from player {senderPlayerId}");
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnApartmentOwned] {ex.Message}"); }
    }

    /// <summary>Receiver-side. Stamp the host-broadcast social-credit score
    /// onto the local GameplayController so wanted-level / restriction
    /// checks use the authoritative number. Idempotent: same-value writes
    /// are skipped to avoid retriggering any ChangedSocialCredit events.</summary>
    private static void OnSocialCredit(NetDataReader r, int senderId)
    {
        try
        {
            int credit = r.GetInt();
            if (SoDCoop.Network.NetworkManager.IsHost) return;

            var gc = global::GameplayController.Instance;
            if (gc == null) return;

            int cur = 0;
            try { cur = gc.socialCredit; } catch { }
            if (cur == credit) return;
            try { gc.socialCredit = credit; }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnSocialCredit] set: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnSocialCredit] {ex.Message}"); }
    }

    private static void OnItemThrow(NetDataReader r, int senderId)
    {
        try
        {
            int playerId = r.GetInt();
            int sourceId = r.GetInt();
            string preset = r.GetString();
            float px = r.GetFloat(), py = r.GetFloat(), pz = r.GetFloat();
            float ex = r.GetFloat(), ey = r.GetFloat(), ez = r.GetFloat();
            float lvx = r.GetFloat(), lvy = r.GetFloat(), lvz = r.GetFloat();
            float avx = r.GetFloat(), avy = r.GetFloat(), avz = r.GetFloat();
            if (playerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;
            try
            {
                SoDCoop.Sync.InventorySync.ApplyThrowFromZdo(playerId, sourceId, preset,
                    new UnityEngine.Vector3(px, py, pz),
                    new UnityEngine.Vector3(ex, ey, ez),
                    new UnityEngine.Vector3(lvx, lvy, lvz),
                    new UnityEngine.Vector3(avx, avy, avz));
            }
            catch (Exception ex2) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemThrow] apply: {ex2.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnItemThrow] {ex.Message}"); }
    }

    private static void OnElevatorCall(NetDataReader r, int senderId)
    {
        try
        {
            int buildingId = r.GetInt();
            int bx = r.GetInt(), by = r.GetInt(), bz = r.GetInt();
            int newFloor = r.GetInt();
            bool upButton = r.GetBool();
            try
            {
                SoDCoop.Sync.ElevatorSync.ApplyCallFromZdo(
                    buildingId, new UnityEngine.Vector3Int(bx, by, bz), newFloor, upButton);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnElevatorCall] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnElevatorCall] {ex.Message}"); }
    }

    private static void OnNpcDamageRich(NetDataReader r, int senderId)
    {
        try
        {
            int victim    = r.GetInt();
            int attacker  = r.GetInt();
            float amount  = r.GetFloat();
            float px = r.GetFloat(), py = r.GetFloat(), pz = r.GetFloat();
            float dx = r.GetFloat(), dy = r.GetFloat(), dz = r.GetFloat();
            bool enableKill = r.GetBool();
            try
            {
                SoDCoop.Sync.DamageSync.ApplyFromZdo(
                    victim, attacker, amount,
                    new UnityEngine.Vector3(px, py, pz),
                    new UnityEngine.Vector3(dx, dy, dz),
                    enableKill);
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnNpcDamageRich] apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnNpcDamageRich] {ex.Message}"); }
    }

    private static void OnMoneyAdded(NetDataReader r, int senderId)
    {
        try
        {
            int    amount         = r.GetInt();
            bool   displayMessage = r.GetBool();
            string reason         = r.GetString();
            // Echo dedup: if we sent this, ignore. Mirrors legacy
            // MoneySync.OnPacketReceived behaviour.
            if (senderId == SoDCoop.Network.NetworkManager.LocalPlayerId) return;

            // Credits only (defensive — MoneySync.SendMoneyAdded gates this
            // upstream too).
            if (amount <= 0) return;

            try { SoDCoop.Sync.MoneySync.ApplyAddMoneyFromZdo(amount, displayMessage, reason); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnMoneyAdded] Apply: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnMoneyAdded] {ex.Message}"); }
    }

    private static void OnSideJobRewarded(NetDataReader r, int senderId)
    {
        try
        {
            int jobId  = r.GetInt();
            int reward = r.GetInt();
            _ = reward;     // host re-derives from job.reward; payload kept for log/banner
            // Mirrors SideJobSync.HandleHandInRequest.
            if (!SoDCoop.Network.NetworkManager.IsHost) return;
            var ctrl = global::SideJobController.Instance;
            if (ctrl == null) return;
            var dict = ctrl.allJobsDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(jobId, out var job) || job == null)
            {
                Plugin.Log.LogWarning($"[ZdoEvents.OnSideJobRewarded] jobID={jobId} not in allJobsDictionary on host.");
                return;
            }

            SoDCoop.Sync.SideJobSync.RunOnRewardedAndRebroadcast(job, senderId);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnSideJobRewarded] {ex.Message}"); }
    }
}
