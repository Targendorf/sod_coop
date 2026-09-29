using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side evidence-note text poller. Walks
/// <c>GameplayController.Instance.evidenceDictionary</c> at 5 Hz, hashes
/// each evidence's <c>notes</c> dictionary, and on hash change broadcasts
/// each (DataKey, text) entry via the existing
/// <see cref="SoDCoop.Sync.EvidenceSync.BroadcastSetNote"/> path.
///
/// <para>Replaces the disabled hot patch on <c>Evidence.SetNote</c>
/// (was at <c>GamePatches.cs:1257</c>). The patch was disabled because
/// SetNote fires thousands of times during init burst (every seeded
/// evidence note); this poller naturally captures those into baseline
/// during init-grace and only broadcasts on player-driven changes.</para>
///
/// <para>Field verification: <c>Evidence.notes: Dictionary&lt;DataKey,
/// string&gt;</c> — Evidence.cs:2190.</para>
/// </summary>
public static class EvidenceNotePoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "evidence-notes";

    /// <summary>(evID → hash of all notes concatenated). Tracked per-evidence
    /// for cheap diff detection; on mismatch we walk and broadcast each
    /// entry idempotently.</summary>
    private static readonly Dictionary<string, int> _baseline = new();

    /// <summary>Evidence entries hashed per tick. At 5 Hz, 64/tick covers a few
    /// thousand pieces of evidence every handful of seconds while costing a
    /// fixed sliver of a frame instead of the whole city walk.</summary>
    private const int SWEEP_PER_TICK = 64;
    private static int _sweepCursor;

    // Runs on every peer (2026-09-29): host-only, a client's own notes never
    // left the client — the Evidence.SetNote patch it replaced is disabled.
    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick, WarmupBaseline);

    /// <summary>True once the sweep has passed over the whole roster at least
    /// once. Until then first sight of an evidence only records its notes: a
    /// client's warmup runs on the main menu (no world, nothing seeded), so its
    /// first pass would otherwise broadcast every seeded note in the city.</summary>
    private static bool _primed;
    private static int _primeSwept;

    /// <summary>Another peer's note was just written to <paramref name="ev"/>:
    /// take it as the baseline so it is not sent back.</summary>
    public static void NotifyRemote(string evId, global::Evidence ev)
    {
        if (string.IsNullOrEmpty(evId) || ev == null) return;
        try
        {
            var notes = ev.notes;
            _baseline[evId] = (notes == null || notes.Count == 0) ? 0 : HashNotes(notes);
        }
        catch { }
    }

    public static void ResetPriming()
    {
        _primed = false;
        _primeSwept = 0;
    }

    /// <summary>World unload: the baseline describes the world being torn down.</summary>
    public static void ResetBaseline()
    {
        _baseline.Clear();
        _sweepCursor = 0;
        ResetPriming();
    }

    /// <summary>Pre-seed <see cref="_baseline"/> with the current note hash
    /// for every evidence so the first real tick sees a clean baseline and
    /// only broadcasts notes that change AFTER a peer connected. Without
    /// this, the first post-connect tick would re-broadcast every seeded
    /// evidence's full notes set (snapshot already delivered them).</summary>
    public static void WarmupBaseline()
    {
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;
            var dict = gc.evidenceDictionary;
            if (dict == null) return;
            int count = 0;
            foreach (var kv in dict)
            {
                string evId = kv.Key;
                var ev = kv.Value;
                if (ev == null || string.IsNullOrEmpty(evId)) continue;
                var notes = ev.notes;
                if (notes == null || notes.Count == 0) { _baseline[evId] = 0; continue; }
                _baseline[evId] = HashNotes(notes);
                count++;
            }
            if (count > 0)
                Plugin.Log.LogInfo($"[EvidenceNotePoller] warmup: pre-seeded {count} evidence-note baseline(s) (no broadcast)");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceNotePoller] warmup: {ex.Message}"); }
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvidenceNote) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            // Amortized sweep over a managed cache instead of enumerating the
            // live Il2Cpp dictionary every tick.
            //
            // The old loop walked every piece of evidence in the city at 5 Hz,
            // marshalling each string key and hashing every note character by
            // character. Measured on the 2026-07-30 playtest: 259 ms per tick
            // on average, the single most expensive poller, and a large part of
            // why the host's coop layer sat at ~197 ms per frame (~5 FPS).
            //
            // Notes only change when a player writes one, so there is nothing
            // to gain from re-hashing the whole city 5 times a second. Walking
            // a bounded slice per tick keeps the same detection with a fixed,
            // small per-frame cost.
            if (!EvidenceRosterCache.TryGetRoster(out var ids, out var evidence)) return;

            int total = evidence.Count;
            int sweep = Math.Min(SWEEP_PER_TICK, total);
            bool primingBatch = !_primed;
            if (primingBatch)
            {
                _primeSwept += sweep;
                if (_primeSwept >= total) _primed = true;
            }
            for (int n = 0; n < sweep; n++)
            {
                if (_sweepCursor >= total) _sweepCursor = 0;
                int idx = _sweepCursor++;

                string evId = ids[idx];
                var ev = evidence[idx];
                if (ev == null || string.IsNullOrEmpty(evId)) continue;

                var notes = ev.notes;
                if (notes == null || notes.Count == 0)
                {
                    _baseline[evId] = 0;
                    continue;
                }

                int currentHash = HashNotes(notes);
                bool known = _baseline.TryGetValue(evId, out var prev);
                if (known && prev == currentHash)
                    continue;
                _baseline[evId] = currentHash;
                // First sight during the priming pass: record only.
                if (!known && primingBatch) continue;

                // Broadcast each note entry. EvidenceSync.BroadcastSetNote is
                // idempotent at the receiver (text-equal check before SetNote
                // call), so re-broadcast on every hash change is safe.
                BroadcastEntries(evId, notes);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceNotePoller] tick: {ex.Message}"); }
    }

    private static int HashNotes(Il2CppSystem.Collections.Generic.Dictionary<Evidence.DataKey, string> notes)
    {
        // FNV-1a over (key,text) pairs. Iteration order on the il2cpp dict is
        // implementation-defined but stable per-tick on the same host, which
        // is all we need (host owns the truth).
        uint h = SoDCoop.Zdo.Hash32.OFFSET32;
        foreach (var kv in notes)
        {
            int k = (int)kv.Key;
            h = (h ^ (byte)(k & 0xff)) * SoDCoop.Zdo.Hash32.PRIME32;
            h = (h ^ (byte)((k >> 8) & 0xff)) * SoDCoop.Zdo.Hash32.PRIME32;
            string s = kv.Value ?? "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                h = (h ^ (byte)(c & 0xff)) * SoDCoop.Zdo.Hash32.PRIME32;
                h = (h ^ (byte)((c >> 8) & 0xff)) * SoDCoop.Zdo.Hash32.PRIME32;
            }
        }
        return unchecked((int)h);
    }

    private static void BroadcastEntries(string evId, Il2CppSystem.Collections.Generic.Dictionary<Evidence.DataKey, string> notes)
    {
        // Build a per-key broadcast: for each (DataKey, text) pair, emit one
        // SetNote packet/event. Most evidences have 1-3 notes; total wire is small.
        foreach (var kv in notes)
        {
            try
            {
                // Phase G.5 (Wave 3.3): unified RPC via ZdoEvents.EVIDENCE_SET_NOTE.
                // Receiver applies via EvidenceSync.ApplySetNoteFromZdo.
                if (ZdoFeatureFlags.UseZdoForEvents)
                {
                    var keys = new byte[] { (byte)kv.Key };
                    ZdoEvents.SendEvidenceSetNote(evId, keys, kv.Value ?? "");
                }
                else
                {
                    var keyList = new Il2CppSystem.Collections.Generic.List<Evidence.DataKey>();
                    keyList.Add(kv.Key);
                    SoDCoop.Sync.EvidenceSync.BroadcastSetNote(evId, keyList, kv.Value ?? "");
                }
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceNotePoller] broadcast {evId}: {ex.Message}"); }
        }
    }
}
