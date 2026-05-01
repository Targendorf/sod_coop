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

    private static readonly List<Entry> _pollers = new();

    public static void Register(string name, float intervalSeconds, PollerCallback cb)
    {
        if (cb == null) return;
        _pollers.Add(new Entry { Name = name, Callback = cb, Interval = intervalSeconds, NextAt = 0f });
    }

    public static void Tick(float now)
    {
        if (!NetworkManager.IsHost) return;
        if (!NetworkManager.HasPeers) return;
        if (!WorldReadyGate.IsWorldReady) return;
        if (WorldReadyGate.IsInInitGrace) return;
        if (!SyncGate.IsOpen) return;

        for (int i = 0; i < _pollers.Count; i++)
        {
            var p = _pollers[i];
            if (now < p.NextAt) continue;
            p.NextAt = now + p.Interval;
            try { p.Callback(now); }
            catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {p.Name}: {ex.Message}"); }
        }
    }

    /// <summary>Drop all registered pollers. Currently unused — pollers are
    /// idempotent on re-register because identity is name-based.</summary>
    public static void Clear() => _pollers.Clear();
}
