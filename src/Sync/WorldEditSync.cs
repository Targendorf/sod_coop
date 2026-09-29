using System;
using System.Collections.Generic;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Zdo;
using SoDCoop.Zdo.Pollers;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// A client's edits to the shared world — opening or closing a door, locking or
/// picking a lock, flipping a light switch, opening a drawer, turning on a TV —
/// sent to the host, which applies them and replicates them to everyone like any
/// other host change. Plus the other direction: anything in reach of the local
/// player that has drifted from the host's state is put back.
///
/// <para><b>What was broken (2026-09-29):</b> the ONLY paths for door, lock,
/// light and switch state are the host-side pollers (<c>DoorPoller</c>,
/// <c>LightPoller</c>, <c>SwitchPoller</c>); the Harmony patches that once sent
/// a client's own changes are all commented out, and the pollers only ever read
/// the HOST's world. So a door the client opened stayed closed on the host and
/// for every other player, a door the client lock-picked stayed locked for the
/// host, a light the client switched on stayed off. Nothing ever corrected the
/// client either, because the host's ZDO for that door never changed. Two
/// players standing in the same room saw different rooms, permanently.</para>
///
/// <para><b>Model:</b> client-predicted, host-authoritative. The client's change
/// is visible to it at once (the game already applied it); the request goes to
/// the host, the host applies it to its own world, and the host's pollers
/// replicate the result to every peer, including back to us. If the host's
/// state still disagrees after <see cref="PENDING_TIMEOUT_S"/> — the request was
/// refused or lost — or the object drifted for any other reason (local AI on
/// this machine), the host's state is re-applied here.</para>
///
/// <para><b>Telling our edit from a host update:</b> both change the live
/// object between two ticks. A change that lands ON the host's ZDO value was the
/// resolver applying the host; a change AWAY from it (or on an object the host
/// has no ZDO for yet) is ours. Only objects within
/// <see cref="WATCH_RADIUS_M"/> of the local player are watched — that is where
/// the player can reach, and inside it the NPCs are frozen and host-driven by
/// <see cref="CitizenPositionSync"/>, so nobody else on this machine is flipping
/// things there.</para>
/// </summary>
public static class WorldEditSync
{
    public const string EVENT_NAME = "world-edit";
    public const string POLLER_NAME = "world-edit";

    private const float TICK_HZ = 10f;

    /// <summary>Radius around the local player that is watched. Interaction
    /// reach is ~2-3 m; the margin covers a door the player swings while
    /// walking through it.</summary>
    private const float WATCH_RADIUS_M = 6f;

    /// <summary>Vertical reach of the watch: the player's floor, not the whole
    /// tower stacked in the same horizontal cells.</summary>
    private const float WATCH_MAX_DY_M = 3.5f;

    /// <summary>Wider ring, checked a few times a second, where doors and
    /// lights are only CORRECTED to the host's state (nothing there is the
    /// player's doing). Covers the street and the rooms around the player —
    /// what they are about to walk into.</summary>
    private const float RING_RADIUS_M = 25f;
    private const float RING_MAX_DY_M = 6f;
    private const int RING_EVERY_N_TICKS = 5;
    private const float RING_RECONCILE_AFTER_S = 2.5f;

    /// <summary>After the player flips a switch, its lights change here before
    /// the host's Light ZDO catches up. Don't "correct" them meanwhile.</summary>
    private const float LIGHT_EDIT_GRACE_S = 3f;

    /// <summary>How long our own request may take to come back through the
    /// host's poller + delta flush before we stop waiting for it. A round trip
    /// is RTT + ~0.2 s; this is generous.</summary>
    private const float PENDING_TIMEOUT_S = 3f;

    /// <summary>A disagreement with the host must persist this long before it
    /// is corrected — rides out the moment between a host update arriving and
    /// its resolver applying it.</summary>
    private const float RECONCILE_AFTER_S = 1f;

    /// <summary>Edits sent per tick, at most. A guard against a runaway loop,
    /// not a limit a player can reach.</summary>
    private const int MAX_SENDS_PER_TICK = 32;

    /// <summary>Forget objects not seen for this long, so the table follows the
    /// player around the city instead of growing with it.</summary>
    private const float FORGET_AFTER_S = 30f;

    private const byte KIND_DOOR = 1;
    private const byte KIND_SWITCH = 2;
    /// <summary>Local-only (never sent): a light's on/off, reconciled.</summary>
    private const byte KIND_LIGHT = 3;

    // Door bits.
    private const byte DOOR_CLOSED = 1;
    private const byte DOOR_LOCKED = 2;
    // Switch bits: sw0..sw3.
    private const byte SW0 = 1, SW1 = 2, SW2 = 4, SW3 = 8;

    private sealed class Watched
    {
        public byte Live;            // last value read from the live object
        public bool Pending;         // we sent an edit and are waiting for the host
        public float PendingUntil;
        public float DivergedSince = -1f;
        public float LastSeen;
    }

    private static readonly Dictionary<long, Watched> _watched = new();
    private static readonly List<int> _near = new();
    private static readonly HashSet<int> _nearSeen = new();
    private static readonly List<long> _forgetScratch = new();
    private static readonly NetDataWriter _w = new();
    private static float _nextForgetAt;
    private static int _sentThisTick;
    private static int _tick;
    private static float _lastSwitchEditAt = -100f;

    /// <summary>Light controllers by directory index, and the indices known
    /// (for now) not to be lights. Built as the player walks around.</summary>
    private static readonly Dictionary<int, LightController> _lightByDirIdx = new();
    private static readonly HashSet<int> _notLight = new();
    private static float _nextLightClassResetAt;

    public static void Register()
    {
        ZdoEventDispatcher.Register(EVENT_NAME, OnWorldEdit);
        ZdoPollerHost.RegisterAnyPeer(POLLER_NAME, 1f / TICK_HZ, ClientTick);
    }

    public static void Reset()
    {
        _watched.Clear();
        _near.Clear();
        _nearSeen.Clear();
        _lightByDirIdx.Clear();
        _notLight.Clear();
    }

    private static long Key(byte kind, int id) => ((long)kind << 32) | (uint)id;

    // ════════════════════════════════════════════════════════════════════
    // Client
    // ════════════════════════════════════════════════════════════════════

    private static void ClientTick(float now)
    {
        if (NetworkManager.IsHost) return;
        if (!NetworkManager.IsConnected) return;

        Vector3 me;
        try
        {
            var p = global::Player.Instance;
            if (p == null) return;
            me = p.transform.position;
        }
        catch { return; }

        _sentThisTick = 0;
        _tick++;
        bool ringTick = _tick % RING_EVERY_N_TICKS == 0;

        // ── Doors: edits within reach, drift correction in the wider ring ──
        _near.Clear();
        _nearSeen.Clear();
        DoorLookup.Query(me, ringTick ? RING_RADIUS_M : WATCH_RADIUS_M, _near, _nearSeen,
                         ringTick ? RING_MAX_DY_M : WATCH_MAX_DY_M);
        for (int k = 0; k < _near.Count; k++)
        {
            var door = DoorLookup.DoorAt(_near[k]);
            if (door == null) continue;
            int id = DoorLookup.IdAt(_near[k]);
            byte live;
            try { live = (byte)((door.isClosed ? DOOR_CLOSED : 0) | (door.isLocked ? DOOR_LOCKED : 0)); }
            catch { continue; }

            byte auth = 0, mask = 0;
            var z = ZdoMan.FindBySodId(ZdoTypeTag.Door, id);
            if (z != null)
            {
                if (z.HasKey(ZdoKeys.Closed)) { mask |= DOOR_CLOSED; if (z.GetBool(ZdoKeys.Closed, true)) auth |= DOOR_CLOSED; }
                if (z.HasKey(ZdoKeys.Locked)) { mask |= DOOR_LOCKED; if (z.GetBool(ZdoKeys.Locked, false)) auth |= DOOR_LOCKED; }
            }
            Step(KIND_DOOR, id, live, auth, mask, now, InReach(me, DoorLookup.PosAt(_near[k])));
        }

        // ── Switches (drawers, cabinets, TVs, radios, light switches) ────
        InteractableSpatialCache.Advance();
        _near.Clear();
        _nearSeen.Clear();
        InteractableSpatialCache.Query(me, WATCH_RADIUS_M, _near, _nearSeen, WATCH_MAX_DY_M);
        for (int k = 0; k < _near.Count; k++)
        {
            var inter = InteractableSpatialCache.Get(_near[k]);
            if (inter == null) continue;

            int id;
            byte live;
            try
            {
                id = inter.id;
                // Doors travel on their own channel; an item in someone's
                // inventory is not part of the room.
                if (DoorLookup.IsDoorInteractable(id)) continue;
                if (inter.inInventory != null) continue;
                live = (byte)((inter.sw0 ? SW0 : 0) | (inter.sw1 ? SW1 : 0) | (inter.sw2 ? SW2 : 0) | (inter.sw3 ? SW3 : 0));
            }
            catch { continue; }

            byte auth = 0, mask = 0;
            var z = ZdoMan.FindBySodId(ZdoTypeTag.Switch, id);
            if (z != null)
            {
                // SwitchPoller writes all four keys together.
                mask = SW0 | SW1 | SW2 | SW3;
                if (z.GetBool(ZdoKeys.On, false))  auth |= SW0;
                if (z.GetBool(ZdoKeys.Sw1, false)) auth |= SW1;
                if (z.GetBool(ZdoKeys.Sw2, false)) auth |= SW2;
                if (z.GetBool(ZdoKeys.Sw3, false)) auth |= SW3;
            }
            if (Step(KIND_SWITCH, id, live, auth, mask, now, canEdit: true)) _lastSwitchEditAt = now;
        }

        // ── Lights: drift correction only (the player changes lights through
        // switches, which are sent above) ───────────────────────────────────
        if (ringTick && now - _lastSwitchEditAt > LIGHT_EDIT_GRACE_S) ReconcileLights(me, now);

        if (now >= _nextForgetAt)
        {
            _nextForgetAt = now + 5f;
            _forgetScratch.Clear();
            foreach (var kv in _watched)
                if (now - kv.Value.LastSeen > FORGET_AFTER_S) _forgetScratch.Add(kv.Key);
            for (int i = 0; i < _forgetScratch.Count; i++) _watched.Remove(_forgetScratch[i]);
        }
        if (now >= _nextLightClassResetAt)
        {
            // A light whose controller wasn't wired yet when we looked gets
            // another chance; confirmed lights stay cached.
            _nextLightClassResetAt = now + 10f;
            _notLight.Clear();
        }
    }

    private static bool InReach(Vector3 me, Vector3 pos)
    {
        float dx = pos.x - me.x, dz = pos.z - me.z;
        return dx * dx + dz * dz <= WATCH_RADIUS_M * WATCH_RADIUS_M && Mathf.Abs(pos.y - me.y) <= WATCH_MAX_DY_M;
    }

    /// <summary>Lights in the ring around the player that disagree with the
    /// host's Light ZDO — switched by this machine's AI while the player was
    /// elsewhere — are put back. Nothing else corrects them: the host's ZDO
    /// only reaches us when the HOST's light changes.</summary>
    private static void ReconcileLights(Vector3 me, float now)
    {
        _near.Clear();
        _nearSeen.Clear();
        InteractableSpatialCache.Query(me, RING_RADIUS_M, _near, _nearSeen, RING_MAX_DY_M);
        for (int k = 0; k < _near.Count; k++)
        {
            int dirIdx = _near[k];
            if (_notLight.Contains(dirIdx)) continue;
            var inter = InteractableSpatialCache.Get(dirIdx);
            if (inter == null) continue;

            if (!_lightByDirIdx.TryGetValue(dirIdx, out var lc) || lc == null)
            {
                try { lc = inter.lightController; } catch { lc = null; }
                if (lc == null) { _notLight.Add(dirIdx); continue; }
                _lightByDirIdx[dirIdx] = lc;
            }

            int id;
            byte live;
            try { id = inter.id; live = (byte)(lc.isOn ? 1 : 0); }
            catch { _lightByDirIdx.Remove(dirIdx); continue; }

            var z = ZdoMan.FindBySodId(ZdoTypeTag.Light, id);
            if (z == null || !z.HasKey(ZdoKeys.On)) continue;
            byte auth = (byte)(z.GetBool(ZdoKeys.On, false) ? 1 : 0);
            Step(KIND_LIGHT, id, live, auth, 1, now, canEdit: false);
        }
    }

    /// <summary>One object, one tick: detect our own edit, wait for the host to
    /// confirm it, or correct a drift from the host's state.</summary>
    /// <param name="auth">The host's value, as far as the ZDO registry knows.</param>
    /// <param name="mask">Which bits of <paramref name="auth"/> are known. Zero
    /// when the host has no ZDO for the object (it never saw it leave its
    /// default state) — then nothing is corrected, only our edits are sent.</param>
    /// <param name="canEdit">The player can reach the object. Outside reach a
    /// change is never taken for the player's own — it is drift, and drift is
    /// corrected.</param>
    /// <returns>True when an edit was sent.</returns>
    private static bool Step(byte kind, int id, byte live, byte auth, byte mask, float now, bool canEdit)
    {
        long key = Key(kind, id);
        if (!_watched.TryGetValue(key, out var w))
        {
            // First sight: baseline only. It may already differ from the host;
            // that is corrected below on a later tick, never "sent" as ours.
            _watched[key] = new Watched { Live = live, LastSeen = now };
            return false;
        }
        w.LastSeen = now;

        byte changed = (byte)(live ^ w.Live);

        if (changed != 0)
        {
            // The change landed on the host's value → it was the host's update
            // being applied here, not the player.
            if ((changed & ~mask) == 0 && (live & mask) == (auth & mask))
            {
                w.Live = live;
                w.Pending = false;
                w.DivergedSince = -1f;
                return false;
            }

            if (canEdit)
            {
                // Over the cap: leave Live as it was so the change is seen
                // again, and sent, next tick.
                if (_sentThisTick >= MAX_SENDS_PER_TICK) return false;
                _sentThisTick++;
                w.Live = live;
                SendEdit(kind, id, live, changed);
                w.Pending = true;
                w.PendingUntil = now + PENDING_TIMEOUT_S;
                w.DivergedSince = -1f;
                return true;
            }
        }
        w.Live = live;

        if (mask == 0) return false;   // host state unknown — nothing to reconcile against

        if ((live & mask) == (auth & mask))
        {
            w.Pending = false;
            w.DivergedSince = -1f;
            return false;
        }

        // Our own edit, still on its way through the host.
        if (w.Pending && now < w.PendingUntil) return false;
        w.Pending = false;

        if (w.DivergedSince < 0f) { w.DivergedSince = now; return false; }
        // Out of reach the disagreement is usually the two clocks firing the
        // same scheduled change a moment apart — give the host longer.
        if (now - w.DivergedSince < (canEdit ? RECONCILE_AFTER_S : RING_RECONCILE_AFTER_S)) return false;

        w.DivergedSince = -1f;
        ApplyHostState(kind, id, live, auth, mask);
        return false;
    }

    private static string KindName(byte kind) => kind == KIND_DOOR ? "door" : kind == KIND_LIGHT ? "light" : "switch";

    private static int _edits, _corrections;
    private static float _nextStatsAt;

    private static void SendEdit(byte kind, int id, byte bits, byte changed)
    {
        _edits++;
        float now = Time.unscaledTime;
        if (now >= _nextStatsAt)
        {
            // Rolled-up, rate-limited: shows the path is alive without a line
            // per door.
            if (_nextStatsAt > 0f)
                Plugin.Log.LogInfo($"[WorldEditSync] last 60s: {_edits} edit(s) sent to host, {_corrections} object(s) corrected to host state.");
            _nextStatsAt = now + 60f;
            _edits = 0;
            _corrections = 0;
        }

        try
        {
            _w.Reset();
            _w.Put(kind);
            _w.Put(id);
            _w.Put(bits);
            _w.Put(changed);
            ZdoEventDispatcher.Send(EVENT_NAME, _w, DeliveryMethod.ReliableOrdered);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[WorldEditSync] send {kind}/{id}: {ex.Message}"); }
    }

    /// <summary>Put this machine's object back to the host's state.</summary>
    private static void ApplyHostState(byte kind, int id, byte live, byte auth, byte mask)
    {
        try
        {
            byte wrong = (byte)((live ^ auth) & mask);
            if (kind == KIND_DOOR)
            {
                if ((wrong & DOOR_CLOSED) != 0) WorldStateSync.ApplyDoorStateBySodId(id, (auth & DOOR_CLOSED) != 0);
                if ((wrong & DOOR_LOCKED) != 0) WorldStateSync.ApplyDoorLockBySodId(id, (auth & DOOR_LOCKED) != 0, playSound: false);
            }
            else if (kind == KIND_LIGHT)
            {
                WorldStateSync.ApplyLightStateBySodId(id, (auth & 1) != 0);
            }
            else
            {
                ApplySwitchBits(id, auth, wrong);
            }
            _corrections++;
            Plugin.Log.LogDebug($"[WorldEditSync] corrected {KindName(kind)} {id} to the host's state.");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[WorldEditSync] correct {kind}/{id}: {ex.Message}"); }
    }

    private static void ApplySwitchBits(int id, byte bits, byte which)
    {
        if ((which & SW0) != 0) WorldStateSync.ApplySwitchStateBySodId(id, (bits & SW0) != 0);
        if ((which & SW1) != 0) WorldStateSync.ApplyCustomSwitchStateBySodId(id, global::InteractablePreset.Switch.custom1, (bits & SW1) != 0);
        if ((which & SW2) != 0) WorldStateSync.ApplyCustomSwitchStateBySodId(id, global::InteractablePreset.Switch.custom2, (bits & SW2) != 0);
        if ((which & SW3) != 0) WorldStateSync.ApplyCustomSwitchStateBySodId(id, global::InteractablePreset.Switch.custom3, (bits & SW3) != 0);
    }

    // ════════════════════════════════════════════════════════════════════
    // Host
    // ════════════════════════════════════════════════════════════════════

    /// <summary>A client changed something in its world. Apply it to ours; the
    /// host pollers then replicate it to every peer. Only the bits the client
    /// actually changed are applied, so a lock state that had drifted on the
    /// client is not pushed onto the host along with a door it merely opened.
    ///
    /// <para>In a 3+ session the relay forwards the event to the other clients
    /// too; they ignore it and get the result from the host like everyone
    /// else.</para></summary>
    private static void OnWorldEdit(NetDataReader r, int senderId)
    {
        if (!NetworkManager.IsHost) return;
        if (!WorldReadyGate.IsWorldReady) return;
        try
        {
            if (r.AvailableBytes < 7) return;
            byte kind = r.GetByte();
            int id = r.GetInt();
            byte bits = r.GetByte();
            byte changed = r.GetByte();

            if (kind == KIND_DOOR)
            {
                if ((changed & DOOR_CLOSED) != 0) WorldStateSync.ApplyDoorStateBySodId(id, (bits & DOOR_CLOSED) != 0);
                if ((changed & DOOR_LOCKED) != 0) WorldStateSync.ApplyDoorLockBySodId(id, (bits & DOOR_LOCKED) != 0, playSound: true);
            }
            else if (kind == KIND_SWITCH)
            {
                ApplySwitchBits(id, bits, changed);
            }
            else return;

            Plugin.Log.LogDebug($"[WorldEditSync] player {senderId}: {(kind == KIND_DOOR ? "door" : "switch")} {id} bits={bits} changed={changed}");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[WorldEditSync] apply from {senderId}: {ex.Message}"); }
    }
}
