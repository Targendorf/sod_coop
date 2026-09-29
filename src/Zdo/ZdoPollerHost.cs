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
        /// <summary>True for pollers registered via <see cref="Register"/>
        /// (host-only). False for <see cref="RegisterAnyPeer"/>. Kept on the
        /// entry so both kinds can live in ONE scheduling list — see the
        /// starvation note on <see cref="Tick"/>.</summary>
        public bool HostOnly;
        /// <summary>Runs while the world is still in its post-load init grace
        /// (and SyncGate is closed). See <see cref="ExemptFromInitGrace"/>.</summary>
        public bool DuringInitGrace;

        // ── Per-poller cost accounting (rolled up every 10 s) ────────────
        public double SumMs;
        public double MaxMs;
        public int    Runs;
        /// <summary>Frames this poller was due but skipped for budget. A
        /// non-zero count here is the signal that sync is being throttled.</summary>
        public int    Skips;
    }

    private static readonly List<Entry> _hostPollers   = new();
    private static readonly List<Entry> _anyPeerPollers = new();

    /// <summary>Edge-trigger flag for HasPeers false→true transition. While
    /// false (no peers), pollers are gated off entirely; on the tick that
    /// observes the gain we fire warmups and skip the real callback that
    /// round so pollers see the next tick's state-after-warmup as the
    /// post-baseline reality.</summary>
    private static bool _hadPeers;

    /// <summary>Per-frame wall-clock budget for ALL poller callbacks combined.
    /// The scheduler runs due pollers, most-overdue first, until this is spent.
    ///
    /// <para>Replaces a fixed "max 3 callbacks per frame" cap that broke sync
    /// in two ways. First, it was blind to cost: three cheap pollers and three
    /// 200 ms pollers both counted as "3". Second, and worse, it interacted with
    /// list order — any-peer pollers were scanned before host-only ones, so
    /// once three any-peer callbacks fired, EVERY host poller (doors, lights,
    /// citizen state, animations — the entire world sync) was skipped, and the
    /// skip still pushed <c>NextAt</c> forward, so a starved poller never
    /// accumulated any priority to make up for it. On a host that was already
    /// hitching, world sync could stay starved indefinitely while the profiler
    /// showed the cap "working".</para>
    ///
    /// <para>A time budget plus most-overdue-first selection fixes both: cost
    /// is bounded in the unit that actually matters, and a poller that loses a
    /// frame becomes MORE overdue and therefore wins the next one. 6 ms leaves
    /// a 60 FPS frame (16.6 ms) most of its budget for the game itself.</para></summary>
    private const double POLLER_BUDGET_MS = 6.0;

    /// <summary>Emit the per-poller cost rollup this often. Answers "which
    /// poller is the expensive one" — the aggregate <c>pollers=700ms</c> bucket
    /// in CoopPerf covers ~25 pollers and cannot say which.</summary>
    private const float COST_ROLLUP_INTERVAL_S = 10f;
    private static float _nextCostRollupAt;

    private static readonly System.Diagnostics.Stopwatch _pollSw = new();

    /// <summary>Single scheduling list holding both host-only and any-peer
    /// pollers, so neither kind can systematically starve the other. Rebuilt
    /// only when a poller registers.</summary>
    private static readonly List<Entry> _schedule = new();

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
        var e = new Entry { Name = name, Callback = cb, Warmup = warmup, Interval = intervalSeconds, NextAt = 0f, HostOnly = true };
        _hostPollers.Add(e);
        _schedule.Add(e);
    }

    /// <summary>Register a poller that runs on every peer (host AND clients).
    /// Used by <see cref="Pollers.LocalPlayerPoller"/> — each peer captures
    /// their own <c>Player.Instance</c> state into their own
    /// <see cref="ZdoTypeTag.LocalPlayer"/> ZDO.</summary>
    /// <summary>Let the named poller run during the post-load init grace.
    ///
    /// <para><b>Why:</b> the grace exists so the scripted burst SoD runs after
    /// a load (evidence naming, vmail generation, seeded notes) isn't
    /// broadcast as player activity — it matters to the pollers that diff
    /// evidence, vmail and interactable-directory growth. It was applied to
    /// EVERY poller, including the one that sends the player's own position:
    /// for the first 30 s after any load a joiner stood frozen at its spawn
    /// on the host's screen, the host sent it no citizen positions (it needs
    /// the peer's position), and doors it opened were later reverted. Pollers
    /// that only ever diff against a first-sight baseline are safe during the
    /// burst and are exempted.</para></summary>
    public static void ExemptFromInitGrace(string name)
    {
        for (int i = 0; i < _schedule.Count; i++)
            if (_schedule[i].Name == name) _schedule[i].DuringInitGrace = true;
    }

    public static void RegisterAnyPeer(string name, float intervalSeconds, PollerCallback cb, WarmupCallback warmup = null)
    {
        if (cb == null) return;
        var e = new Entry { Name = name, Callback = cb, Warmup = warmup, Interval = intervalSeconds, NextAt = 0f, HostOnly = false };
        _anyPeerPollers.Add(e);
        _schedule.Add(e);
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
        // Init grace / closed SyncGate hold back all but the exempt pollers
        // (see ExemptFromInitGrace).
        bool graceOnly = WorldReadyGate.IsInInitGrace || !SyncGate.IsOpen;
        // A client polls nothing until it is in the host's world — see
        // ZdoMan.ClientSynced (joining from inside one's own game).
        if (!NetworkManager.IsHost && !ZdoMan.ClientSynced) return;

        // First tick after HasPeers transitioned false→true: warm up every
        // poller's baseline against the current SoD world state, then skip
        // the real callbacks this round. Without this, every diff-poller
        // (citizen-anim × 336 actors × 2 enums, speech-bubble, damage,
        // etc.) treats this tick as "everything is fresh dirty" and floods
        // the channel with 20k+ events for state the snapshot already
        // delivered authoritatively.
        // Warmups seed baselines and must see the world AFTER the init burst
        // (that is what the grace is for), so they wait for it to end; only the
        // exempt pollers — none of which has a warmup — run meanwhile.
        if (!_hadPeers && !graceOnly)
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

        // ── Budgeted, fair scheduling ────────────────────────────────────
        //
        // Walk the single schedule list picking the MOST OVERDUE due poller
        // each round, run it, and stop once POLLER_BUDGET_MS is spent. A
        // poller that loses a frame keeps its NextAt, so its overdue-ness
        // grows and it wins a later round — no poller can be starved by list
        // position or by a chattier neighbour.
        //
        // Selection is a linear scan per pick (~25 entries), repeated only a
        // few times per frame: cheaper than sorting, and allocation-free.
        bool isHost = NetworkManager.IsHost;
        double spentMs = 0.0;
        int ran = 0;

        while (true)
        {
            Entry pick = null;
            float bestOverdue = -1f;
            for (int i = 0; i < _schedule.Count; i++)
            {
                var p = _schedule[i];
                if (p.HostOnly && !isHost) continue;
                if (graceOnly && !p.DuringInitGrace) continue;
                float overdue = now - p.NextAt;
                if (overdue < 0f) continue;             // not due yet
                if (overdue > bestOverdue) { bestOverdue = overdue; pick = p; }
            }
            if (pick == null) break;                    // nothing due

            // Always run at least ONE poller per frame even if the budget is
            // already blown by a single expensive callback — otherwise a
            // poller that costs more than the whole budget would never run
            // again, which is precisely the silent-desync failure mode this
            // scheduler exists to prevent.
            if (ran > 0 && spentMs >= POLLER_BUDGET_MS)
            {
                // Everything still due is deferred, NOT skipped: leave NextAt
                // alone so it stays due and gains priority next frame.
                for (int i = 0; i < _schedule.Count; i++)
                {
                    var p = _schedule[i];
                    if (p.HostOnly && !isHost) continue;
                    if (graceOnly && !p.DuringInitGrace) continue;
                    if (now >= p.NextAt) p.Skips++;
                }
                break;
            }

            pick.NextAt = now + pick.Interval;
            _pollSw.Restart();
            try { pick.Callback(now); }
            catch (Exception ex) { Plugin.Log.LogError($"[ZdoPollerHost] {pick.Name}: {ex.Message}"); }
            finally
            {
                _pollSw.Stop();
                double ms = _pollSw.Elapsed.TotalMilliseconds;
                spentMs += ms;
                pick.SumMs += ms;
                pick.Runs++;
                if (ms > pick.MaxMs) pick.MaxMs = ms;
                ran++;
            }
        }

        LogCostRollup(now);
    }

    /// <summary>Emit a per-poller cost + deferral breakdown every
    /// <see cref="COST_ROLLUP_INTERVAL_S"/>, sorted by max cost. This is what
    /// turns CoopPerf's single <c>pollers=700ms</c> bucket into a named
    /// culprit; <c>defer</c> counts show whether the budget is throttling sync
    /// and which pollers are losing.</summary>
    private static void LogCostRollup(float now)
    {
        if (now < _nextCostRollupAt)
        {
            if (_nextCostRollupAt == 0f) _nextCostRollupAt = now + COST_ROLLUP_INTERVAL_S;
            return;
        }
        _nextCostRollupAt = now + COST_ROLLUP_INTERVAL_S;

        // Only report pollers whose max single run was non-trivial, so an idle
        // session stays quiet.
        System.Text.StringBuilder sb = null;
        int deferTotal = 0;
        for (int i = 0; i < _schedule.Count; i++)
        {
            var p = _schedule[i];
            deferTotal += p.Skips;
            if (p.MaxMs >= 1.0)
            {
                sb ??= new System.Text.StringBuilder();
                if (sb.Length > 0) sb.Append(' ');
                sb.Append($"{p.Name}={p.MaxMs:F0}/{(p.Runs > 0 ? p.SumMs / p.Runs : 0):F1}ms×{p.Runs}");
                if (p.Skips > 0) sb.Append($"(defer{p.Skips})");
            }
            p.SumMs = 0; p.MaxMs = 0; p.Runs = 0; p.Skips = 0;
        }

        if (sb != null)
        {
            Plugin.Log.LogInfo(
                $"[ZdoPollerHost] 10s per-poller max/avg×runs: {sb}" +
                (deferTotal > 0 ? $" — TOTAL DEFERRED {deferTotal} (budget {POLLER_BUDGET_MS:F0}ms/frame is throttling sync)" : ""));
        }
    }

    /// <summary>Drop all registered pollers. Currently unused — pollers are
    /// idempotent on re-register because identity is name-based.</summary>
    public static void Clear() { _hostPollers.Clear(); _anyPeerPollers.Clear(); _hadPeers = false; }
}
