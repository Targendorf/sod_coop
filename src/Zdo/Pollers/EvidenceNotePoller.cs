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

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvidenceNote) return;
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;
            var dict = gc.evidenceDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                string evId = kv.Key;
                var ev = kv.Value;
                if (ev == null || string.IsNullOrEmpty(evId)) continue;

                var notes = ev.notes;
                if (notes == null || notes.Count == 0)
                {
                    _baseline[evId] = 0;
                    continue;
                }

                int currentHash = HashNotes(notes);
                if (_baseline.TryGetValue(evId, out var prev) && prev == currentHash)
                    continue;
                _baseline[evId] = currentHash;

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
        // SetNote packet. Most evidences have 1-3 notes; total wire is small.
        foreach (var kv in notes)
        {
            try
            {
                var keyList = new Il2CppSystem.Collections.Generic.List<Evidence.DataKey>();
                keyList.Add(kv.Key);
                SoDCoop.Sync.EvidenceSync.BroadcastSetNote(evId, keyList, kv.Value ?? "");
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[EvidenceNotePoller] broadcast {evId}: {ex.Message}"); }
        }
    }
}
