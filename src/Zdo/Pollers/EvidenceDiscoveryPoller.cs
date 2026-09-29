using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// "This fact about this piece of evidence is now known" — replicated between
/// ALL peers, in both directions.
///
/// <para><b>What was broken (2026-09-29):</b> discoveries (lives-at, works-at,
/// phone location, found-at …) are how an investigation's knowledge grows, and
/// they were not synchronised at all. The <c>Evidence.AddDiscovery</c> patch was
/// disabled in Phase E because it fires thousands of times during a save load,
/// and — unlike doors, lights or notes — nothing replaced it. Whatever one
/// player learned, the other never learned; the case boards drifted apart from
/// the first clue.</para>
///
/// <para><b>How:</b> a bounded sweep over <see cref="EvidenceRosterCache"/>
/// watching each evidence's <c>discoveryProgress</c> count, plus a hot set —
/// evidence that gained a discovery in the last minute is checked every tick,
/// since discoveries cluster on what a player is working on. New entries go out
/// on the existing <c>EVIDENCE_DISCOVERY</c> event; receivers add them through
/// <c>EvidenceSync.ApplyDiscoveryFromZdo</c> (deduplicated) and rebaseline here
/// via <see cref="NotifyRemote"/>, so nothing bounces back. First sight of an
/// evidence only records its count — existing knowledge is already in every
/// peer's world (the join ships a save).</para>
/// </summary>
public static class EvidenceDiscoveryPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "evidence-discovery";

    /// <summary>Roster entries examined per tick. Two IL2CPP reads each; at 5 Hz
    /// a 5 000-entry roster is covered every ~5 s.</summary>
    private const int SWEEP_PER_TICK = 200;

    /// <summary>How long an evidence stays in the every-tick hot set after it
    /// last gained a discovery.</summary>
    private const float HOT_FOR_S = 60f;

    private static readonly Dictionary<string, int> _lastCount = new();
    private static readonly Dictionary<string, (global::Evidence ev, float until)> _hot = new();
    private static readonly List<string> _expired = new();
    private static int _cursor;

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick, WarmupBaseline);

    public static void ResetBaseline()
    {
        _lastCount.Clear();
        _hot.Clear();
        _cursor = 0;
    }

    public static void WarmupBaseline() => ResetBaseline();

    /// <summary>A discovery from another peer was just added to
    /// <paramref name="ev"/> here.</summary>
    public static void NotifyRemote(string evId, global::Evidence ev)
    {
        if (string.IsNullOrEmpty(evId) || ev == null) return;
        try
        {
            var prog = ev.discoveryProgress;
            _lastCount[evId] = prog != null ? prog.Count : 0;
            _hot[evId] = (ev, UnityEngine.Time.unscaledTime + HOT_FOR_S);
        }
        catch { }
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        try
        {
            if (!EvidenceRosterCache.TryGetRoster(out var ids, out var evidence)) return;

            // Hot set first — every tick.
            _expired.Clear();
            foreach (var kv in _hot)
            {
                if (now > kv.Value.until) { _expired.Add(kv.Key); continue; }
                Check(kv.Key, kv.Value.ev, now);
            }
            for (int i = 0; i < _expired.Count; i++) _hot.Remove(_expired[i]);

            // Bounded wrapping sweep over the rest.
            int n = Math.Min(SWEEP_PER_TICK, evidence.Count);
            for (int k = 0; k < n; k++)
            {
                if (_cursor >= evidence.Count) _cursor = 0;
                int i = _cursor++;
                string id = ids[i];
                if (_hot.ContainsKey(id)) continue;
                Check(id, evidence[i], now);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceDiscoveryPoller] tick: {ex.Message}"); }
    }

    private static void Check(string evId, global::Evidence ev, float now)
    {
        if (ev == null) return;
        Il2CppSystem.Collections.Generic.List<global::Evidence.Discovery> prog;
        int count;
        try { prog = ev.discoveryProgress; count = prog != null ? prog.Count : 0; }
        catch { return; }

        if (!_lastCount.TryGetValue(evId, out int prev)) { _lastCount[evId] = count; return; }
        if (count == prev) return;
        _lastCount[evId] = count;
        if (count < prev) return;

        for (int i = prev; i < count; i++)
        {
            byte disc;
            try { disc = (byte)prog[i]; } catch { continue; }
            try { ZdoEvents.SendEvidenceDiscovery(evId, disc); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceDiscoveryPoller] send: {ex.Message}"); }
        }
        _hot[evId] = (ev, now + HOT_FOR_S);
    }
}
