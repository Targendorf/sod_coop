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

    /// <summary>Optional warmup callback fired on the first tick after
    /// <see cref="NetworkManager.HasPeers"/> transitions false→true. Pollers
    /// that diff against a <c>_last</c> baseline use this to re-snapshot the
    /// current SoD state into their baseline <b>without broadcasting</b>,
    /// preventing a 300+ event burst when a joiner connects.</summary>
    public delegate void WarmupCallback();

    private sealed class Entry
    {
        public string Name;
        public PollerCallback Callback;
        public WarmupCallback Warmup;
        public float Interval;
        public float NextAt;
    }

    private static readonly List<Entry> _hostPollers   = new();
    private static readonly List<Entry> _anyPeerPollers = new();

    /// <summary>Edge-trigger flag for HasPeers false→true transition. While
    /// false (no peers), pollers are gated off entirely; on the tick that
    /// observes the gain we fire warmups and skip the real callback that
    /// round so pollers see the next tick's state-after-warmup as the
    /// post-baseline reality.</summary>
    private static bool _hadPeers;

    /// <summary>Max poller callbacks invoked per frame across ALL pollers (any-
    /// peer + host). When the game is hitching, multiple intervals elapse in a
    /// single long frame, so many pollers are "due" at once. Without a cap,
    /// running them all re-stalls the next frame → death spiral. The cap
    /// spreads the work across frames instead. 3/frame = enough headroom for
    /// 60 FPS steady state (3 callbacks = ~5-15ms) while keeping a hitch frame
    /// from spiraling.</summary>
    private const int MAX_POLLERS_PER_FRAME = 3;

    /// <summary>Register a host-only poller. Most pollers (door, light,
    /// vmail, etc.) use this — the host owns the world simulation and
    /// derives authoritative state from it.
    ///
    /// <para>Pass <paramref name="warmup"/> for pollers that diff against
    /// a baseline dictionary; it's invoked on the first tick after a peer
    /// connects so the baseline pre-loads with current state instead of
    /// firing a "everything looks new" burst across all citizens.</para></summary>
    public static void Register(string name, float intervalSeconds, PollerCallback cb, WarmupCallback warmup = null)
    {
        if (cb == null) return;
        _hostPollers.Add(new Entry { Name = name, Callback = cb, Warmup = warmup, Interval = intervalSeconds, NextAt = 0f });
    }

    /// <summary>Register a poller that runs on every peer (host AND clients).
    /// Used by <see cref="Pollers.LocalPlayerPoller"/> — each peer captures
    /// their own <c>Player.Instance</c> state into their own
    /// <see cref="ZdoTypeTag.LocalPlayer"/> ZDO.</summary>
    public static void RegisterAnyPeer(string name, float intervalSeconds, PollerCallback cb, WarmupCallback warmup = null)
    {
        if (cb == null) return;
        _anyPeerPollers.Add(new Entry { Name = name, Callback = cb, Warmup = warmup, Interval = intervalSeconds, NextAt = 0f });
    }

    public static void Tick(float now)
    {
        if (!NetworkManager.HasPeers)
        {
            // Drop the edge-trigger flag — next gain cycle warms up again.
            _hadPeers = false;
            return;
        }
        if (!WorldReadyGate.IsWorldReady) return;
        if (WorldReadyGate.IsInInitGrace) return;
        if (!SyncGate.IsOpen) return;

        // First tick after HasPeers transitioned false→true: warm up every
        // poller's baseline against the current SoD world state, then skip
        // the real callbacks this round. Without this, every diff-poller
        // (citizen-anim × 336 actors × 2 enums, speech-bubble, damage,
        // etc.) treats this tick as "everything is fresh dirty" and floods
        // the channel with 20k+ events for state the snapshot already
        // delivered authoritatively.
        if (!_hadPeers)
        {
            _hadPeers = true;
            int warmedAny  = 0;
            int warmedHost = 0;
            for (int i = 0; i < _anyPeerPollers.Count; i++)
            {
                var p = _anyPeerPollers[i];
                // Bump the next-due so we don't immediately fire the real
                // callback after warmup — give pollers a beat for SoD state
                // to settle past the connect handshake.
                p.NextAt = now + p.Interval;
                if (p.Warmup == null) continue;
                try { p.Warmup(); warmedAny++; }
                catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {p.Name} warmup: {ex.Message}"); }
            }
            if (NetworkManager.IsHost)
            {
                for (int i = 0; i < _hostPollers.Count; i++)
                {
                    var p = _hostPollers[i];
                    p.NextAt = now + p.Interval;
                    if (p.Warmup == null) continue;
                    try { p.Warmup(); warmedHost++; }
                    catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {p.Name} warmup: {ex.Message}"); }
                }
            }
            Plugin.Log.LogInfo($"[ZdoPollerHost] HasPeers gained — warmed {warmedAny} any-peer + {warmedHost} host poller baseline(s); deferring real ticks one interval");
            return;
        }

        // Any-peer pollers fire on every machine.
        // Adaptive skipping: when the game is already hitching (unscaledDeltaTime
        // >> poller interval), multiple pollers can be "due" at once. Running all
        // of them in a single frame re-stalls the next frame, which makes even
        // more pollers due — a death spiral (playtest 2026-06-23: host held at
        // 1.4 FPS for the entire session, pollers=700-1600ms/frame). Cap the
        // number of poller callbacks per frame so coop layer cost stays bounded
        // regardless of how many intervals elapsed.
        int fired = 0;
        for (int i = 0; i < _anyPeerPollers.Count; i++)
        {
            var p = _anyPeerPollers[i];
            if (now < p.NextAt) continue;
            if (fired >= MAX_POLLERS_PER_FRAME) { p.NextAt = now + p.Interval; continue; }
            p.NextAt = now + p.Interval;
            fired++;
            try { p.Callback(now); }
            catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {p.Name}: {ex.Message}"); }
        }

        // Host-only pollers — same adaptive cap.
        if (!NetworkManager.IsHost) return;
        for (int i = 0; i < _hostPollers.Count; i++)
        {
            var p = _hostPollers[i];
            if (now < p.NextAt) continue;
            if (fired >= MAX_POLLERS_PER_FRAME) { p.NextAt = now + p.Interval; continue; }
            p.NextAt = now + p.Interval;
            fired++;
            try { p.Callback(now); }
            catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {p.Name}: {ex.Message}"); }
        }
    }

    /// <summary>Drop all registered pollers. Currently unused — pollers are
    /// idempotent on re-register because identity is name-based.</summary>
    public static void Clear() { _hostPollers.Clear(); _anyPeerPollers.Clear(); _hadPeers = false; }
}
