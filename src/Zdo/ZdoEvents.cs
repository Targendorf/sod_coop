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
        ZdoEventDispatcher.Send(NPC_DAMAGE_RICH, _w);
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
