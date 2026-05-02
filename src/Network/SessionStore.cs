using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;

namespace SoDCoop.Network;

/// <summary>
/// Client-side history of co-op sessions the user has joined. Lets the
/// main menu offer one-click "rejoin" instead of forcing the user back
/// through the Steam friends list every time.
///
/// <para>Persisted as plain text in
/// <c>BepInEx/config/SoDCoop/sessions.txt</c>. Capped at
/// <see cref="MaxEntries"/>; the oldest entry is dropped on overflow.
/// Records are sorted newest-first when read out.</para>
///
/// <para>Keyed by host's SteamID — there are no IPs in the Steam-only
/// transport. <see cref="LobbyId"/> is also recorded but lobbies are
/// short-lived and won't survive between sessions; we only retry by
/// SteamID via the Steam overlay's "Join Game" affordance.</para>
/// </summary>
public static class SessionStore
{
    public class Entry
    {
        public ulong  HostSteamId;
        public ulong  LobbyId;          // typically 0 by the time a user comes back
        public string HostName;         // human-friendly host display, e.g. "John Smith"
        public long   LastConnectedUnix;

        public string Endpoint => HostSteamId.ToString();

        public DateTime LastConnected => DateTimeOffset.FromUnixTimeSeconds(LastConnectedUnix).LocalDateTime;
    }

    public const int MaxEntries = 10;

    private static readonly object _lock = new();
    private static List<Entry> _entries;
    private static bool _loaded;

    public static IReadOnlyList<Entry> All
    {
        get { EnsureLoaded(); return _entries; }
    }

    /// <summary>
    /// Insert or refresh a session row. Returns the stored entry. Trims to
    /// <see cref="MaxEntries"/> by dropping the oldest tails.
    /// </summary>
    public static Entry Record(ulong hostSteamId, ulong lobbyId, string hostName)
    {
        if (hostSteamId == 0) return null;
        EnsureLoaded();

        Entry existing = null;
        for (int i = 0; i < _entries.Count; i++)
        {
            if (_entries[i].HostSteamId == hostSteamId)
            {
                existing = _entries[i];
                _entries.RemoveAt(i);
                break;
            }
        }

        var entry = existing ?? new Entry { HostSteamId = hostSteamId };
        entry.HostSteamId       = hostSteamId;
        entry.LobbyId           = lobbyId;
        entry.HostName          = string.IsNullOrEmpty(hostName) ? entry.HostName : hostName;
        entry.LastConnectedUnix = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        _entries.Insert(0, entry);

        while (_entries.Count > MaxEntries)
            _entries.RemoveAt(_entries.Count - 1);

        SaveAll();
        return entry;
    }

    public static bool Forget(ulong hostSteamId)
    {
        EnsureLoaded();
        int removed = _entries.RemoveAll(e => e.HostSteamId == hostSteamId);
        if (removed > 0) SaveAll();
        return removed > 0;
    }

    /// <summary>Most recent entry, or null if history is empty.</summary>
    public static Entry MostRecent
    {
        get { EnsureLoaded(); return _entries.Count > 0 ? _entries[0] : null; }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  IO
    // ─────────────────────────────────────────────────────────────────────

    private static void EnsureLoaded()
    {
        if (_loaded) return;
        lock (_lock)
        {
            if (_loaded) return;
            try { Load(); }
            catch (Exception ex) { Plugin.Log.LogError($"[SessionStore] load failed: {ex}"); _entries = new List<Entry>(); }
            _loaded = true;
        }
    }

    private static void Load()
    {
        _entries = new List<Entry>();
        string path = Path.Combine(ConfigDir, "sessions.txt");
        if (!File.Exists(path)) return;

        foreach (var raw in File.ReadAllLines(path))
        {
            if (string.IsNullOrWhiteSpace(raw) || raw[0] == '#') continue;
            var parts = raw.Split('|');
            if (parts.Length < 4) continue;
            if (!ulong.TryParse(parts[0], out var sid)) continue;
            ulong.TryParse(parts[1], out var lobby);
            long.TryParse(parts[3], out var ts);

            _entries.Add(new Entry
            {
                HostSteamId       = sid,
                LobbyId           = lobby,
                HostName          = parts[2],
                LastConnectedUnix = ts,
            });
        }

        _entries.Sort((a, b) => b.LastConnectedUnix.CompareTo(a.LastConnectedUnix));
        Plugin.Log.LogInfo($"[SessionStore] loaded {_entries.Count} session(s).");
    }

    private static void SaveAll()
    {
        try
        {
            string path = Path.Combine(ConfigDir, "sessions.txt");
            using var sw = new StreamWriter(path, append: false);
            sw.WriteLine("# SoDCoop recent sessions (most recent first)");
            sw.WriteLine("# format: hostSteamId|lobbyId|hostName|lastConnectedUnix");
            foreach (var e in _entries)
            {
                sw.WriteLine(string.Join("|",
                    e.HostSteamId.ToString(),
                    e.LobbyId.ToString(),
                    Sanitize(e.HostName ?? ""),
                    e.LastConnectedUnix.ToString()));
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SessionStore] save failed: {ex}");
        }
    }

    private static string Sanitize(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        return s.Replace('|', '_').Replace('\n', ' ').Replace('\r', ' ').Replace('\t', ' ');
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
                Plugin.Log.LogError($"[SessionStore] cannot create config dir: {ex.Message}");
                return Paths.ConfigPath;
            }
        }
    }

    public static string FormatAgo(Entry e)
    {
        if (e == null) return "";
        try
        {
            var diff = DateTimeOffset.UtcNow - DateTimeOffset.FromUnixTimeSeconds(e.LastConnectedUnix);
            if (diff.TotalSeconds < 60)  return "just now";
            if (diff.TotalMinutes < 60)  return $"{(int)diff.TotalMinutes}m ago";
            if (diff.TotalHours   < 24)  return $"{(int)diff.TotalHours}h ago";
            if (diff.TotalDays    < 7)   return $"{(int)diff.TotalDays}d ago";
            return e.LastConnected.ToString("yyyy-MM-dd");
        }
        catch { return ""; }
    }
}
