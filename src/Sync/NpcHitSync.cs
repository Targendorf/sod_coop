using System;
using System.Collections.Generic;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Zdo;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// A client's hits on citizens (and on other players' bodies) sent to the host,
/// which applies them to its own world — the only world whose citizens can fight
/// back, fall unconscious, call the police or die for everyone.
///
/// <para><b>What was broken (2026-09-29):</b> damage replication is host → client
/// only. <c>NpcDamagePoller</c> reads the HOST's citizens, and the
/// <c>Actor.RecieveDamage</c> patch that once reported a client's hits is inside a
/// comment block. A client punching someone lowered that citizen's health on the
/// client alone; the host's copy stood there unhurt, and the next state update
/// for that citizen wrote the host's full health straight back. A client could
/// not knock anyone out, win a fight, or be seen attacking.</para>
///
/// <para><b>Detection:</b> the citizens near this client are frozen and driven by
/// the host (<see cref="CitizenPositionSync"/>), so the only thing on this
/// machine that can hurt them is the local player. Every health write the mod
/// itself makes (<see cref="DamageSync"/>, <c>CitizenResolver</c>) is reported
/// through <see cref="NotifyRemoteHealth"/>, so any remaining drop is ours. The
/// host applies it with the client's twin as the attacker, so its citizens react
/// to the right person, and its damage poller then replicates the result to
/// everyone — the attacking client's copy is already there and skips it
/// (<c>DamageSync</c> reconciles on the carried health-after).</para>
/// </summary>
public static class NpcHitSync
{
    public const string EVENT_NAME = "npc-hit";
    public const string POLLER_NAME = "npc-hit";

    private const float TICK_HZ = 10f;
    /// <summary>Melee reach plus a thrown object's short flight.</summary>
    private const float WATCH_RADIUS_M = 10f;
    /// <summary>Drops at or below this per tick are bleeding / regen noise.</summary>
    private const float HIT_EPSILON = 0.5f;
    /// <summary>Sanity cap on one reported hit.</summary>
    private const float MAX_HIT = 500f;

    private static readonly Dictionary<int, float> _lastHp = new();
    private static readonly List<KeyValuePair<int, global::Human>> _candidates = new();
    private static readonly NetDataWriter _w = new();

    public static void Register()
    {
        ZdoEventDispatcher.Register(EVENT_NAME, OnNpcHit);
        ZdoPollerHost.RegisterAnyPeer(POLLER_NAME, 1f / TICK_HZ, ClientTick);
    }

    public static void Reset()
    {
        _lastHp.Clear();
        _lastRestrained.Clear();
    }

    /// <summary>The mod itself just set <paramref name="humanId"/>'s health (a
    /// replicated host hit, a state update). Not the local player's doing.</summary>
    public static void NotifyRemoteHealth(int humanId, float hp)
    {
        if (NetworkManager.IsHost) return;
        _lastHp[humanId] = hp;
    }

    // ════════════════════════════════════════════════════════════════════
    // Client
    // ════════════════════════════════════════════════════════════════════

    private static void ClientTick(float now)
    {
        if (NetworkManager.IsHost) return;

        Vector3 me;
        try
        {
            var p = global::Player.Instance;
            if (p == null) return;
            me = p.transform.position;
        }
        catch { return; }

        _candidates.Clear();
        CitizenPositionSync.CollectDriven(_candidates);
        AddOtherPlayersBodies();

        float r2 = WATCH_RADIUS_M * WATCH_RADIUS_M;
        for (int i = 0; i < _candidates.Count; i++)
        {
            int id = _candidates[i].Key;
            var h = _candidates[i].Value;
            if (h == null) continue;

            float hp;
            bool dead;
            Vector3 pos;
            try { hp = h.currentHealth; dead = h.isDead; pos = h.transform.position; }
            catch { continue; }

            CheckRestrained(id, h);

            if (!_lastHp.TryGetValue(id, out float last)) { _lastHp[id] = hp; continue; }
            _lastHp[id] = hp;

            float drop = last - hp;
            if (drop <= HIT_EPSILON) continue;
            if ((pos - me).sqrMagnitude > r2) continue;

            // Belt and braces: a drop that lands on the host's own value came
            // from the host, whatever path wrote it.
            var z = ZdoMan.FindBySodId(ZdoTypeTag.Citizen, id);
            if (z != null && z.HasKey(ZdoKeys.CurrentHealth)
                && Mathf.Abs(z.GetFloat(ZdoKeys.CurrentHealth, hp) - hp) <= HIT_EPSILON)
                continue;

            Send(id, Mathf.Min(drop, MAX_HIT), lethal: dead);
        }
    }

    /// <summary>Handcuffing: the same one-way gap as hits. The
    /// <c>NewAIController.SetRestrained</c> patch is disabled and the host
    /// only polls its own citizens, so a client's arrest existed on the client
    /// until the next state update for that citizen took the cuffs off again.
    /// A local change that doesn't match the host's Restrained key is ours;
    /// it goes out on the existing NpcRestrained packet, which the host (and,
    /// through the relay, every other client) applies.</summary>
    private static void CheckRestrained(int id, global::Human h)
    {
        bool restrained;
        float duration;
        try
        {
            var ai = h.ai;
            if (ai == null) return;
            restrained = ai.restrained;
            duration = ai.restrainTime;
        }
        catch { return; }

        if (!_lastRestrained.TryGetValue(id, out bool last)) { _lastRestrained[id] = restrained; return; }
        if (last == restrained) return;
        _lastRestrained[id] = restrained;

        var z = ZdoMan.FindBySodId(ZdoTypeTag.Citizen, id);
        if (z != null && z.HasKey(ZdoKeys.Restrained) && z.GetBool(ZdoKeys.Restrained, false) == restrained)
            return;   // the host's state being applied here

        InventorySync.BroadcastRestrained(id, restrained, duration);
    }

    private static readonly Dictionary<int, bool> _lastRestrained = new();

    /// <summary>Other players' bodies (their twins) — hitting a teammate.
    /// <see cref="CitizenPositionSync"/> never drives those.</summary>
    private static void AddOtherPlayersBodies()
    {
        try
        {
            var players = NetworkManager.Players;
            var dict = global::CityData.Instance?.citizenDictionary;
            if (players == null || dict == null) return;
            int mine = NetworkManager.MyTwinHumanID;
            foreach (var kv in players)
            {
                int twin = kv.Value?.TwinHumanID ?? 0;
                if (twin <= 0 || twin == mine) continue;
                if (dict.TryGetValue(twin, out var h) && h != null)
                    _candidates.Add(new KeyValuePair<int, global::Human>(twin, h));
            }
        }
        catch { }
    }

    private static void Send(int victimId, float amount, bool lethal)
    {
        try
        {
            _w.Reset();
            _w.Put(victimId);
            _w.Put(amount);
            _w.Put(lethal);
            ZdoEventDispatcher.Send(EVENT_NAME, _w, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[NpcHitSync] reported hit on {victimId}: {amount:F1}{(lethal ? " (lethal)" : "")}");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[NpcHitSync] send: {ex.Message}"); }
    }

    // ════════════════════════════════════════════════════════════════════
    // Host
    // ════════════════════════════════════════════════════════════════════

    /// <summary>Apply a client's hit to our world, attributed to that client's
    /// body. A hit on the host's own body lands on the host player. Relayed
    /// copies in a 3+ session reach other clients too; they ignore it.</summary>
    private static void OnNpcHit(NetDataReader r, int senderId)
    {
        if (!NetworkManager.IsHost) return;
        if (!WorldReadyGate.IsWorldReady) return;
        try
        {
            if (r.AvailableBytes < 9) return;
            int victimId = r.GetInt();
            float amount = r.GetFloat();
            bool lethal = r.GetBool();
            if (!(amount > 0f)) return;
            amount = Mathf.Min(amount, MAX_HIT);

            int attackerId = TwinManager.GetTwinHumanIDForSender(senderId);

            // The host's own body is a hidden stand-in here; the host is
            // Player.Instance.
            int hostTwin = NetworkManager.MyTwinHumanID;
            if (hostTwin > 0 && victimId == hostTwin)
            {
                DamageSync.ApplyToLocalPlayer(amount, attackerId, lethal);
                return;
            }

            // A death replayed on the client can look like a hit before its
            // state arrives; the host's citizen is already gone.
            try
            {
                var dict = global::CityData.Instance?.citizenDictionary;
                if (dict != null && dict.TryGetValue(victimId, out var victim) && victim != null && victim.isDead) return;
            }
            catch { }

            DamageSync.ApplyHit(victimId, attackerId, amount, lethal);
            Plugin.Log.LogDebug($"[NpcHitSync] player {senderId} (twin {attackerId}) hit {victimId} for {amount:F1}");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[NpcHitSync] apply from {senderId}: {ex.Message}"); }
    }
}
