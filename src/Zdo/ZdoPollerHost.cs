using System;
using System.Collections.Generic;
using SoDCoop.Network;
using SoDCoop.Sync;

namespace SoDCoop.Zdo;

/// <summary>
/// Per-tick fan-out for host-side ZDO change-detection pollers. Each poller
/// registers a callback + tick rate; <see cref="Tick"/> invokes due
/// callbacks gated on <see cref="WorldReadyGate.IsWorldReady"/>,
/// <see cref="WorldReadyGate.IsInInitGrace"/>, and host-only.
///
/// <para>Pollers are intentionally additive — a feature can be migrated
/// to ZDO without touching the legacy per-feature <c>BroadcastXxx</c> path,
/// then the legacy path is dropped in Phase H. <see cref="ZdoFeatureFlags"/>
/// gates the cutover atomically.</para>
/// </summary>
public static class ZdoPollerHost
{
    public delegate void PollerCallback(float now);

    private sealed class Entry
    {
        public string Name;
        public PollerCallback Callback;
        public float Interval;
        public float NextAt;
    }

    private static readonly List<Entry> _hostPollers   = new();
    private static readonly List<Entry> _anyPeerPollers = new();

    /// <summary>Register a host-only poller. Most pollers (door, light,
    /// vmail, etc.) use this — the host owns the world simulation and
    /// derives authoritative state from it.</summary>
    public static void Register(string name, float intervalSeconds, PollerCallback cb)
    {
        if (cb == null) return;
        _hostPollers.Add(new Entry { Name = name, Callback = cb, Interval = intervalSeconds, NextAt = 0f });
    }

    /// <summary>Register a poller that runs on every peer (host AND clients).
    /// Used by <see cref="Pollers.LocalPlayerPoller"/> — each peer captures
    /// their own <c>Player.Instance</c> state into their own
    /// <see cref="ZdoTypeTag.LocalPlayer"/> ZDO.</summary>
    public static void RegisterAnyPeer(string name, float intervalSeconds, PollerCallback cb)
    {
        if (cb == null) return;
        _anyPeerPollers.Add(new Entry { Name = name, Callback = cb, Interval = intervalSeconds, NextAt = 0f });
    }

    public static void Tick(float now)
    {
        if (!NetworkManager.HasPeers) return;
        if (!WorldReadyGate.IsWorldReady) return;
        if (WorldReadyGate.IsInInitGrace) return;
        if (!SyncGate.IsOpen) return;

        // Any-peer pollers fire on every machine.
        for (int i = 0; i < _anyPeerPollers.Count; i++)
        {
            var p = _anyPeerPollers[i];
            if (now < p.NextAt) continue;
            p.NextAt = now + p.Interval;
            try { p.Callback(now); }
            catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {p.Name}: {ex.Message}"); }
        }

        // Host-only pollers.
        if (!NetworkManager.IsHost) return;
        for (int i = 0; i < _hostPollers.Count; i++)
        {
            var p = _hostPollers[i];
            if (now < p.NextAt) continue;
            p.NextAt = now + p.Interval;
            try { p.Callback(now); }
            catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {p.Name}: {ex.Message}"); }
        }
    }

    /// <summary>Drop all registered pollers. Currently unused — pollers are
    /// idempotent on re-register because identity is name-based.</summary>
    public static void Clear() { _hostPollers.Clear(); _anyPeerPollers.Clear(); }
}
