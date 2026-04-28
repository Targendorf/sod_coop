using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Per-kind token bucket that caps how many same-kind broadcasts we'll
/// send per second. Defends against generator bursts (case-gen at midnight,
/// daily news, periodic schedule events) that would otherwise route hundreds
/// of postfix-driven Broadcast* calls through SendToAll in a single frame
/// and flood connected clients.
///
/// Usage:
///   if (!BroadcastBudget.TryConsume("evidence.note")) return;
///
/// Buckets are lazily created. Default capacity = 60, refill = 30/sec — i.e.
/// sustained ~30 broadcasts/sec per kind, with a 60-event burst headroom.
/// Numbers are intentionally generous: legitimate player actions almost
/// never exceed them, but a multi-thousand-event init burst gets clipped
/// hard.
///
/// Drops are silent in the hot path; a single warning per kind is logged
/// when a kind starts dropping, with a periodic stats summary every 30s
/// while drops are accumulating.
/// </summary>
public static class BroadcastBudget
{
    private const float DEFAULT_CAPACITY      = 60f;
    private const float DEFAULT_REFILL_PER_SEC = 30f;
    private const float STATS_INTERVAL_SECONDS = 30f;

    private class Bucket
    {
        public float Tokens;
        public float LastRefillTime;
        public long  Sent;
        public long  Dropped;
        public long  DroppedSinceLastReport;
        public bool  WarnedOnce;
    }

    private static readonly Dictionary<string, Bucket> _buckets = new();
    private static float _nextStatsReportTime;

    /// <summary>
    /// Try to consume one token from the named bucket. Returns false if the
    /// bucket is empty (caller should drop the broadcast). Thread-unsafe —
    /// callers are all on the Unity main thread.
    /// </summary>
    public static bool TryConsume(string kind, float capacity = DEFAULT_CAPACITY,
                                  float refillPerSec = DEFAULT_REFILL_PER_SEC)
    {
        if (!_buckets.TryGetValue(kind, out var b))
        {
            b = new Bucket { Tokens = capacity, LastRefillTime = Time.unscaledTime };
            _buckets[kind] = b;
        }

        // Refill based on wall time since last touch.
        float now = Time.unscaledTime;
        float dt  = now - b.LastRefillTime;
        if (dt > 0f)
        {
            b.Tokens = Mathf.Min(capacity, b.Tokens + dt * refillPerSec);
            b.LastRefillTime = now;
        }

        MaybeReportStats(now);

        if (b.Tokens >= 1f)
        {
            b.Tokens -= 1f;
            b.Sent++;
            return true;
        }

        b.Dropped++;
        b.DroppedSinceLastReport++;
        if (!b.WarnedOnce)
        {
            b.WarnedOnce = true;
            Plugin.Log.LogWarning($"[BroadcastBudget] rate-limit hit on \"{kind}\" — " +
                $"dropping further broadcasts of this kind until refill (cap={capacity:F0}, refill={refillPerSec:F0}/s).");
        }
        return false;
    }

    private static void MaybeReportStats(float now)
    {
        if (now < _nextStatsReportTime) return;
        _nextStatsReportTime = now + STATS_INTERVAL_SECONDS;

        // Only log if there's been recent activity worth reporting.
        bool anyDrops = false;
        foreach (var kv in _buckets)
        {
            if (kv.Value.DroppedSinceLastReport > 0) { anyDrops = true; break; }
        }
        if (!anyDrops) return;

        var sb = new System.Text.StringBuilder();
        sb.Append("[BroadcastBudget] last 30s drops:");
        foreach (var kv in _buckets)
        {
            var b = kv.Value;
            if (b.DroppedSinceLastReport == 0) continue;
            sb.Append($" {kv.Key}={b.DroppedSinceLastReport}(total {b.Dropped})");
            b.DroppedSinceLastReport = 0;
        }
        Plugin.Log.LogWarning(sb.ToString());
    }

    /// <summary>Reset all buckets — call when the world unloads so stale state doesn't leak across sessions.</summary>
    public static void Reset()
    {
        _buckets.Clear();
        _nextStatsReportTime = 0f;
    }
}
