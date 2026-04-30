using System;
using System.Collections.Generic;

namespace SoDCoop.Player;

/// <summary>
/// Read-only catalog of city citizens whose wardrobes can be "borrowed" by
/// the appearance editor. The user cycles through entries with the
/// <c>Wardrobe source</c> row in <c>AppearancePanel</c>; on Apply the
/// selected citizen's <c>List&lt;OutfitClothes&gt;</c> for the current
/// category is wired into the local twin so the twin renders identical
/// clothing to that citizen.
///
/// <para>Cached per session — built lazily on first access from
/// <c>CityData.Instance.citizenDictionary</c>. Sorted by humanID for a
/// stable cycling order. Filters out the local player, host's own
/// player citizen, and any currently-claimed twin (we don't want the
/// list to suggest "borrow yourself").</para>
/// </summary>
public static class CitizenWardrobeBrowser
{
    public class Entry
    {
        public int    HumanID;
        public string DisplayName;     // citizenName or "first surname"
        public string Subtitle;        // job preset name if available, else ethnicity / age hint

        public override string ToString() => $"{DisplayName} (#{HumanID})";
    }

    private static List<Entry> _cache;
    private static int _cachedAtCitizenCount = -1;

    /// <summary>
    /// Re-queries the city if the citizen count has changed since last call.
    /// Otherwise returns the cached list. Returns an empty list if no city
    /// is loaded.
    /// </summary>
    public static IReadOnlyList<Entry> All
    {
        get
        {
            try
            {
                var city = global::CityData.Instance;
                if (city == null || city.citizenDictionary == null)
                    return _cache ?? new List<Entry>();

                int count = city.citizenDictionary.Count;
                if (_cache != null && count == _cachedAtCitizenCount)
                    return _cache;

                Rebuild(city);
                return _cache;
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"CitizenWardrobeBrowser.All: {ex.Message}");
                return _cache ?? new List<Entry>();
            }
        }
    }

    /// <summary>How many entries the cycle picker should expose.</summary>
    public static int Count => All.Count;

    /// <summary>Look up an entry by humanID (0 → null).</summary>
    public static Entry GetByHumanId(int humanId)
    {
        if (humanId <= 0) return null;
        var list = All;
        for (int i = 0; i < list.Count; i++)
            if (list[i].HumanID == humanId) return list[i];
        return null;
    }

    /// <summary>Index of an entry in the cycle order, or -1.</summary>
    public static int IndexOfHumanId(int humanId)
    {
        if (humanId <= 0) return -1;
        var list = All;
        for (int i = 0; i < list.Count; i++)
            if (list[i].HumanID == humanId) return i;
        return -1;
    }

    public static Entry GetByIndex(int idx)
    {
        var list = All;
        if (list.Count == 0) return null;
        if (idx < 0) idx = (idx % list.Count + list.Count) % list.Count;
        if (idx >= list.Count) idx %= list.Count;
        return list[idx];
    }

    /// <summary>Force re-cache on the next All access. Call from
    /// <c>WorldReadyGate.OnWorldReady</c> if you suspect citizenDictionary churned.</summary>
    public static void Invalidate()
    {
        _cache = null;
        _cachedAtCitizenCount = -1;
    }

    // ─────────────────────────────────────────────────────────────────────

    private static void Rebuild(global::CityData city)
    {
        var list = new List<Entry>();
        try
        {
            int playerHumanId = -1;
            try { playerHumanId = global::Player.Instance?.humanID ?? -1; } catch { }

            // Skip currently-claimed twins so the player doesn't see their own
            // identity (or a teammate's) suggested as a wardrobe source. Host
            // is authoritative on twin set; clients can't query it but the
            // small leak (clients see twins as candidates) is harmless — they
            // just cycle through one extra entry that's identical to a peer.
            HashSet<int> twins = null;
            try
            {
                if (Network.NetworkManager.IsHost)
                    twins = new HashSet<int>(SoDCoop.Sync.TwinManager.GetAllTwinHumanIDsForCurrentSeed());
            }
            catch { }

            var ids = new List<int>(city.citizenDictionary.Count);
            foreach (var kv in city.citizenDictionary) ids.Add(kv.Key);
            ids.Sort();

            foreach (var id in ids)
            {
                if (id == playerHumanId) continue;
                if (twins != null && twins.Contains(id)) continue;
                if (!city.citizenDictionary.TryGetValue(id, out var human) || human == null) continue;

                bool dead = false;
                try { dead = human.isDead; } catch { }
                if (dead) continue;
                if (human.outfitController == null) continue;
                if (human.outfitController.outfits == null) continue;
                if (human.outfitController.outfits.Count == 0) continue;

                string display = SafeDisplayName(human, id);
                string subtitle = SafeSubtitle(human);
                list.Add(new Entry
                {
                    HumanID     = id,
                    DisplayName = display,
                    Subtitle    = subtitle,
                });
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"CitizenWardrobeBrowser.Rebuild: {ex.Message}");
        }

        _cache = list;
        _cachedAtCitizenCount = city.citizenDictionary?.Count ?? 0;
        Plugin.Log.LogInfo($"[CitizenWardrobeBrowser] cached {list.Count} citizens with usable wardrobes.");
    }

    private static string SafeDisplayName(global::Human human, int id)
    {
        try
        {
            string name = human.citizenName;
            if (!string.IsNullOrWhiteSpace(name)) return name.Trim();
            string fn = (human.firstName ?? "").Trim();
            string sn = (human.surName ?? "").Trim();
            if (fn.Length > 0 || sn.Length > 0) return $"{fn} {sn}".Trim();
        }
        catch { }
        return $"Citizen #{id}";
    }

    private static string SafeSubtitle(global::Human human)
    {
        try
        {
            // Job preset name — gives the user a hint about the outfit style
            // (e.g. "Forensic Tech", "Bartender"). Optional; empty if missing.
            var occ = human.job?.preset;
            if (occ != null)
            {
                string occName = occ.name;
                if (!string.IsNullOrWhiteSpace(occName)) return occName;
            }
        }
        catch { }
        return "";
    }
}
