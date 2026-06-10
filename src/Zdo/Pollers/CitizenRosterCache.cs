using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Shared managed cache of the live citizen roster, used by every
/// per-citizen poller (CitizenStatePoller, CitizenAnimationPoller,
/// SpeechBubblePoller, NpcDamagePoller, MurderPoller).
///
/// <para><b>Why:</b> each of those pollers used to enumerate
/// <c>CityData.Instance.citizenDictionary</c> independently every tick.
/// Enumerating an Il2Cpp dictionary is a per-element native interop call
/// (enumerator MoveNext + Key + Value each cross the managed/native
/// boundary), and with 5 pollers × ~336 citizens × 2-10 Hz that added up
/// to tens of thousands of interop calls per second on the host main
/// thread — pure overhead, since the roster itself almost never changes
/// after city generation. Same pattern as <see cref="LightPoller"/> /
/// <see cref="DoorPoller"/>: cache parallel managed lists, rebuild only
/// when the dictionary's Count changes.</para>
///
/// <para>The cached <c>humanID</c> comes from the dictionary KEY, saving
/// the per-citizen <c>c.humanID</c> interop field read the pollers used
/// to do. SoD keys citizenDictionary by humanID (verified: MurderPoller
/// used kv.Key as the id; InventorySync resolves via TryGetValue(humanId)).</para>
///
/// <para><b>Lifecycle:</b> <see cref="Reset"/> is wired into
/// <c>SodCommonBridge.OnBeforeLoad</c> alongside the other scan caches so
/// a world reload drops the stale Human references (destroyed Unity
/// objects). Per-element <c>citizens[i] == null</c> guards in the pollers
/// behave identically on cached refs — Unity's overloaded null-equality
/// flows through Il2CppInterop.</para>
/// </summary>
public static class CitizenRosterCache
{
    private static readonly List<int> _ids = new();
    private static readonly List<global::Human> _citizens = new();

    /// <summary>citizenDictionary.Count at the last rebuild. -1 forces a
    /// rebuild on first access.</summary>
    private static int _cachedCount = -1;

    /// <summary>Fetch the cached roster as parallel (ids, citizens) lists,
    /// rebuilding from the live dictionary if its Count changed. Returns
    /// false when the city isn't loaded or the roster is empty. Callers
    /// must NOT mutate the returned lists.</summary>
    public static bool TryGetRoster(out List<int> ids, out List<global::Human> citizens)
    {
        ids = _ids;
        citizens = _citizens;
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return false;

            int count = dict.Count;
            if (count != _cachedCount)
            {
                _ids.Clear();
                _citizens.Clear();
                foreach (var kv in dict)
                {
                    var c = kv.Value;
                    if (c == null) continue;
                    _ids.Add(kv.Key);
                    _citizens.Add(c);
                }
                _cachedCount = count;
                Plugin.Log.LogDebug($"[CitizenRosterCache] rebuilt: {_citizens.Count} citizens (dict count {count}).");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[CitizenRosterCache] TryGetRoster: {ex.Message}");
            return false;
        }
        return _citizens.Count > 0;
    }

    /// <summary>Drop the cache. Called on world unload/reload so stale
    /// Human references to destroyed Unity objects are not iterated.
    /// Rebuilds lazily on the next TryGetRoster.</summary>
    public static void Reset()
    {
        _ids.Clear();
        _citizens.Clear();
        _cachedCount = -1;
    }
}
