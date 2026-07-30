using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Shared managed snapshot of <c>GameplayController.Instance.evidenceDictionary</c>,
/// used by the evidence pollers instead of re-enumerating the live Il2Cpp
/// dictionary every tick.
///
/// <para><b>Why:</b> that dictionary holds every piece of evidence in the city
/// and enumerating it is a per-element interop crossing — worse, the string
/// keys marshal into freshly allocated managed strings on every single pass.
/// EvidenceNotePoller walked it once per tick and EvidenceCreationPoller walked
/// it TWICE, both at 5 Hz, on the host main thread. Measured on the 2026-07-30
/// playtest: evidence-notes 259 ms average per tick, evidence-creation 224 ms,
/// which together with fingerprints held the host's coop layer at ~197 ms per
/// frame — about 5 FPS — and forced 737 poller deferrals per 10 s, so the
/// throttle meant to protect the frame rate was starving sync at the same
/// time.</para>
///
/// <para>Same shape as <see cref="CitizenRosterCache"/>: parallel managed
/// lists, rebuilt only when the live dictionary's Count changes. Evidence is
/// created rarely, so in the steady state a rebuild never happens and callers
/// walk plain managed lists.</para>
/// </summary>
public static class EvidenceRosterCache
{
    private static readonly List<string> _ids = new();
    private static readonly List<global::Evidence> _evidence = new();

    /// <summary>evidenceDictionary.Count at the last rebuild. -1 forces a
    /// rebuild on first access.</summary>
    private static int _cachedCount = -1;

    /// <summary>Live dictionary Count as of the last <see cref="TryGetRoster"/>
    /// call. Lets a caller answer "did anything get created or destroyed since
    /// last tick?" without touching the dictionary itself.</summary>
    public static int LastSeenCount => _cachedCount;

    /// <summary>Fetch the cached evidence roster as parallel (ids, evidence)
    /// lists, rebuilding from the live dictionary if its Count changed. Returns
    /// false when no world is loaded or there is no evidence. Callers must NOT
    /// mutate the returned lists.</summary>
    public static bool TryGetRoster(out List<string> ids, out List<global::Evidence> evidence)
    {
        ids = _ids;
        evidence = _evidence;
        try
        {
            var gc = global::GameplayController.Instance;
            var dict = gc?.evidenceDictionary;
            if (dict == null) return false;

            int count = dict.Count;
            if (count != _cachedCount)
            {
                _ids.Clear();
                _evidence.Clear();
                foreach (var kv in dict)
                {
                    var ev = kv.Value;
                    if (ev == null) continue;
                    string id = kv.Key;
                    if (string.IsNullOrEmpty(id)) continue;
                    _ids.Add(id);
                    _evidence.Add(ev);
                }
                _cachedCount = count;
                Plugin.Log.LogDebug($"[EvidenceRosterCache] rebuilt: {_evidence.Count} entries (dict count {count}).");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[EvidenceRosterCache] TryGetRoster: {ex.Message}");
            return false;
        }
        return _evidence.Count > 0;
    }

    /// <summary>Force a rebuild on the next access. Called on world unload so
    /// stale Evidence references to a destroyed world are never walked.</summary>
    public static void Reset()
    {
        _ids.Clear();
        _evidence.Clear();
        _cachedCount = -1;
    }
}
