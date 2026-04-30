using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Client-side roster of co-op character profiles. Each profile bundles a
/// stable per-character <c>ClientGuid</c> (so the host treats it as a
/// distinct identity), a player-facing display name, in-world first /
/// surname, and an <see cref="AppearanceConfig"/>. The user picks one
/// "active" profile from the main menu, and that profile drives both
/// connection identity and what the host stores under
/// <c>CharacterStore</c>.
///
/// <para>Persisted as plain text in
/// <c>BepInEx/config/SoDCoop/profiles.txt</c> + a single-int
/// <c>active_profile.txt</c> alongside. Format reproduces the
/// <c>CharacterStore</c> on-disk style for consistency / hand-debugability.</para>
///
/// <para><b>Migration</b>: on first run after the profiles feature lands,
/// the legacy single-installation guid (PlayerPrefs key
/// <c>SoDCoop_ClientGuid</c>) is promoted to "Profile #1 (legacy)" so any
/// existing host-side records under that guid keep their
/// (twin / name / appearance) association seamlessly. The legacy
/// PlayerPrefs entry is left in place — harmless and lets the user roll
/// back if the new code path goes wrong.</para>
/// </summary>
public static class ProfileStore
{
    public class Profile
    {
        public int    Id;
        public string DisplayName = "";
        public string FirstName   = "";
        public string Surname     = "";
        public string ClientGuid  = "";
        public AppearanceConfig Appearance = AppearanceConfig.Default;

        public string FullName =>
            string.IsNullOrEmpty(Surname)
                ? (FirstName ?? "")
                : $"{FirstName} {Surname}";

        public bool HasName => !string.IsNullOrWhiteSpace(FirstName);
    }

    private const string LEGACY_PREF_KEY = "SoDCoop_ClientGuid";

    private static readonly object _lock = new();
    private static List<Profile> _profiles;
    private static int _activeId = -1;
    private static int _nextId   = 1;
    private static bool _loaded;

    // ─────────────────────────────────────────────────────────────────────
    //  Public API
    // ─────────────────────────────────────────────────────────────────────

    public static IReadOnlyList<Profile> All
    {
        get { EnsureLoaded(); return _profiles; }
    }

    public static Profile Active
    {
        get
        {
            EnsureLoaded();
            for (int i = 0; i < _profiles.Count; i++)
                if (_profiles[i].Id == _activeId) return _profiles[i];
            return null;
        }
    }

    public static Profile GetById(int id)
    {
        EnsureLoaded();
        for (int i = 0; i < _profiles.Count; i++)
            if (_profiles[i].Id == id) return _profiles[i];
        return null;
    }

    /// <summary>Mint a brand-new profile with a fresh guid. Returns the new instance.</summary>
    public static Profile Create(string displayName, string firstName, string surName, AppearanceConfig appearance)
    {
        EnsureLoaded();
        var p = new Profile
        {
            Id          = _nextId++,
            DisplayName = displayName ?? "",
            FirstName   = firstName ?? "",
            Surname     = surName ?? "",
            ClientGuid  = Guid.NewGuid().ToString("N"),
            Appearance  = appearance,
        };
        _profiles.Add(p);
        if (_activeId < 0) _activeId = p.Id;     // first profile becomes active
        SaveAll();
        Plugin.Log.LogInfo($"[ProfileStore] created profile #{p.Id} \"{p.DisplayName}\" guid={p.ClientGuid}");
        return p;
    }

    /// <summary>Persist edits made to a profile reference returned from <see cref="GetById"/>.</summary>
    public static void Save(Profile p)
    {
        if (p == null) return;
        EnsureLoaded();
        SaveAll();
    }

    public static bool Delete(int id)
    {
        EnsureLoaded();
        int idx = _profiles.FindIndex(x => x.Id == id);
        if (idx < 0) return false;
        bool wasActive = _profiles[idx].Id == _activeId;
        _profiles.RemoveAt(idx);
        if (wasActive)
            _activeId = _profiles.Count > 0 ? _profiles[0].Id : -1;
        SaveAll();
        return true;
    }

    public static void SetActive(int id)
    {
        EnsureLoaded();
        if (GetById(id) == null) return;
        _activeId = id;
        SaveAll();
        Plugin.Log.LogInfo($"[ProfileStore] active profile = #{id}");
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Load / save
    // ─────────────────────────────────────────────────────────────────────

    private static void EnsureLoaded()
    {
        if (_loaded) return;
        lock (_lock)
        {
            if (_loaded) return;
            try { LoadAll(); }
            catch (Exception ex) { Plugin.Log.LogError($"[ProfileStore] load failed: {ex}"); _profiles = new List<Profile>(); }
            _loaded = true;

            // First-time migration: if no profiles on disk, promote the
            // legacy guid (if any) to a starter profile so existing host
            // records keep working.
            if (_profiles.Count == 0)
                MigrateLegacyGuid();
        }
    }

    private static void LoadAll()
    {
        _profiles = new List<Profile>();
        _activeId = -1;
        _nextId   = 1;

        string profilesPath = Path.Combine(ConfigDir, "profiles.txt");
        string activePath   = Path.Combine(ConfigDir, "active_profile.txt");

        if (File.Exists(profilesPath))
        {
            foreach (var raw in File.ReadAllLines(profilesPath))
            {
                if (string.IsNullOrWhiteSpace(raw) || raw[0] == '#') continue;
                var parts = raw.Split('|');
                if (parts.Length < 5) continue;
                if (!int.TryParse(parts[0], out var id)) continue;

                var p = new Profile
                {
                    Id          = id,
                    DisplayName = parts[1],
                    FirstName   = parts[2],
                    Surname     = parts[3],
                    ClientGuid  = parts[4],
                    Appearance  = (parts.Length > 5 && !string.IsNullOrEmpty(parts[5]))
                                      ? DecodeAppearance(parts[5])
                                      : AppearanceConfig.Default,
                };
                if (string.IsNullOrEmpty(p.ClientGuid)) continue;
                _profiles.Add(p);
                if (id >= _nextId) _nextId = id + 1;
            }
            Plugin.Log.LogInfo($"[ProfileStore] loaded {_profiles.Count} profile(s).");
        }

        if (File.Exists(activePath))
        {
            try
            {
                var s = File.ReadAllText(activePath).Trim();
                if (int.TryParse(s, out var id)) _activeId = id;
            }
            catch { }
        }

        if (_activeId < 0 && _profiles.Count > 0)
            _activeId = _profiles[0].Id;
    }

    private static void SaveAll()
    {
        try
        {
            string profilesPath = Path.Combine(ConfigDir, "profiles.txt");
            using (var sw = new StreamWriter(profilesPath, append: false))
            {
                sw.WriteLine("# SoDCoop profiles (client-side)");
                sw.WriteLine("# format: id|displayName|firstName|surName|clientGuid|appearanceB64");
                foreach (var p in _profiles)
                {
                    string b64 = "";
                    try { b64 = Convert.ToBase64String(p.Appearance.ToBytes()); } catch { }
                    sw.WriteLine(string.Join("|",
                        p.Id.ToString(),
                        Sanitize(p.DisplayName),
                        Sanitize(p.FirstName),
                        Sanitize(p.Surname),
                        p.ClientGuid,
                        b64));
                }
            }

            string activePath = Path.Combine(ConfigDir, "active_profile.txt");
            File.WriteAllText(activePath, _activeId.ToString());
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ProfileStore] save failed: {ex}");
        }
    }

    private static string Sanitize(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        return s.Replace('|', '_').Replace('\n', ' ').Replace('\r', ' ').Replace('\t', ' ');
    }

    private static AppearanceConfig DecodeAppearance(string b64)
    {
        try { return AppearanceConfig.FromBytes(Convert.FromBase64String(b64)); }
        catch { return AppearanceConfig.Default; }
    }

    private static string ConfigDir
    {
        get
        {
            try
            {
                string dir = Path.Combine(Paths.ConfigPath, "SoDCoop");
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                return dir;
            }
            catch (Exception ex)
            {
                Plugin.Log.LogError($"[ProfileStore] cannot create config dir: {ex.Message}");
                return Paths.ConfigPath;
            }
        }
    }

    private static void MigrateLegacyGuid()
    {
        try
        {
            string legacy = "";
            try { legacy = PlayerPrefs.GetString(LEGACY_PREF_KEY, ""); } catch { }
            if (string.IsNullOrEmpty(legacy)) return;

            var p = new Profile
            {
                Id          = _nextId++,
                DisplayName = "Default (legacy)",
                FirstName   = "",
                Surname     = "",
                ClientGuid  = legacy,
                Appearance  = AppearanceConfig.Default,
            };
            _profiles.Add(p);
            _activeId = p.Id;
            SaveAll();
            Plugin.Log.LogInfo($"[ProfileStore] migrated legacy clientGuid into profile #{p.Id} \"{p.DisplayName}\".");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ProfileStore] legacy migration failed: {ex.Message}");
        }
    }
}
