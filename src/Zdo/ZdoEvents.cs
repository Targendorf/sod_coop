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
