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

    public static void SendMapPing(ulong playerPeer, UnityEngine.Vector3 pos)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        _w.Reset();
        _w.Put(playerPeer);
        _w.Put(pos.x); _w.Put(pos.y); _w.Put(pos.z);
        ZdoEventDispatcher.Send(MAP_PING, _w, DeliveryMethod.Sequenced);
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
            Plugin.Log.LogInfo($"[ZdoEvents.OnChat] {senderId}/{name}: {text}");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnChat] {ex.Message}"); }
    }

    private static void OnMapPing(NetDataReader r, int senderId)
    {
        try
        {
            ulong peer = r.GetULong();
            float x = r.GetFloat(), y = r.GetFloat(), z = r.GetFloat();
            Plugin.Log.LogInfo($"[ZdoEvents.OnMapPing] sender={senderId} peer={peer:X16} ({x:F1},{y:F1},{z:F1})");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoEvents.OnMapPing] {ex.Message}"); }
    }

    private static void OnPauseBanner(NetDataReader r, int senderId)    { /* surfaced by PingSystem; payload-less for now */ _ = r; _ = senderId; }
    private static void OnPhoneBanner(NetDataReader r, int senderId)    { _ = r; _ = senderId; }
    private static void OnSideJobBanner(NetDataReader r, int senderId)  { _ = r; _ = senderId; }
    private static void OnSideJobAccept(NetDataReader r, int senderId)  { _ = r; _ = senderId; }
    private static void OnSideJobHandIn(NetDataReader r, int senderId)  { _ = r; _ = senderId; }
    private static void OnCrimeDiscovered(NetDataReader r, int senderId){ _ = r; _ = senderId; }
    private static void OnNpcDamage(NetDataReader r, int senderId)      { _ = r; _ = senderId; }
    private static void OnPlayerDamage(NetDataReader r, int senderId)   { _ = r; _ = senderId; }
}
