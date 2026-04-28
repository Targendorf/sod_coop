using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;

namespace SoDCoop.Sync;

/// <summary>
/// Host-side authoritative store of "which client GUID owns which named
/// character in which world seed". Persisted as a flat text file per seed
/// in <c>BepInEx/config/SoDCoop/characters_&lt;seed&gt;.txt</c>.
///
/// <para>File format (pipe-separated, one record per line):</para>
/// <code>
/// # SoDCoop characters for seed "&lt;seed&gt;"
/// &lt;clientGuid&gt;|&lt;firstName&gt;|&lt;surName&gt;|&lt;unixTime&gt;
/// </code>
///
/// <para>We deliberately don't pull in a JSON library — names are validated
/// to forbid the <c>|</c> separator at submission time, so plain text is
/// trivial and easy to debug by hand.</para>
///
/// <para>Used only on the host. Clients carry their own <see cref="Player.CharacterIdentity"/>
/// GUID and let the host tell them what their character name is.</para>
/// </summary>
public static class CharacterStore
{
    /// <summary>One persisted character record.</summary>
    public class Record
    {
        public string ClientGuid;
        public string FirstName;
        public string Surname;
        public long   CreatedAtUnix;
    }

    /// <summary>seed → (clientGuid → record). Lazily loaded on first access per seed.</summary>
    private static readonly Dictionary<string, Dictionary<string, Record>> _bySeed = new();

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
                Plugin.Log.LogError($"[CharacterStore] cannot create config dir: {ex.Message}");
                return Paths.ConfigPath; // last-resort fallback
            }
        }
    }

    private static string FileFor(string seed) =>
        Path.Combine(ConfigDir, $"characters_{Sanitize(seed)}.txt");

    private static string Sanitize(string s)
    {
        if (string.IsNullOrEmpty(s)) return "default";
        var bad = Path.GetInvalidFileNameChars();
        foreach (var c in bad) s = s.Replace(c, '_');
        return s;
    }

    /// <summary>Validates a player-supplied name fragment. Returns null on OK, error string otherwise.</summary>
    public static string ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return "Name cannot be empty.";
        if (name.Length > 32) return "Name must be 32 characters or fewer.";
        if (name.Contains('|') || name.Contains('\n') || name.Contains('\r') || name.Contains('\t'))
            return "Name contains forbidden characters.";
        return null;
    }

    /// <summary>Look up an existing record for this client in this seed, or null.</summary>
    public static Record TryGet(string seed, string clientGuid)
    {
        var bucket = LoadSeed(seed);
        return bucket.TryGetValue(clientGuid, out var rec) ? rec : null;
    }

    /// <summary>
    /// Persist a new (or replaced) character record for a client. Returns the
    /// stored record. Caller must have already validated the name fragments.
    /// </summary>
    public static Record Save(string seed, string clientGuid, string firstName, string surName)
    {
        var bucket = LoadSeed(seed);
        var rec = new Record
        {
            ClientGuid    = clientGuid,
            FirstName     = firstName,
            Surname       = surName,
            CreatedAtUnix = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
        };
        bucket[clientGuid] = rec;
        WriteSeedFile(seed, bucket);
        Plugin.Log.LogInfo($"[CharacterStore] saved {firstName} {surName} for {clientGuid} in seed \"{seed}\"");
        return rec;
    }

    /// <summary>Drop a client's record (future "kick from world" / reset feature).</summary>
    public static bool Delete(string seed, string clientGuid)
    {
        var bucket = LoadSeed(seed);
        if (!bucket.Remove(clientGuid)) return false;
        WriteSeedFile(seed, bucket);
        return true;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  IO
    // ─────────────────────────────────────────────────────────────────────

    private static Dictionary<string, Record> LoadSeed(string seed)
    {
        if (_bySeed.TryGetValue(seed, out var existing)) return existing;

        var bucket = new Dictionary<string, Record>();
        string path = FileFor(seed);
        try
        {
            if (File.Exists(path))
            {
                foreach (var raw in File.ReadAllLines(path))
                {
                    if (string.IsNullOrWhiteSpace(raw) || raw[0] == '#') continue;
                    var parts = raw.Split('|');
                    if (parts.Length < 3) continue;
                    var rec = new Record
                    {
                        ClientGuid    = parts[0],
                        FirstName     = parts[1],
                        Surname       = parts[2],
                        CreatedAtUnix = parts.Length > 3 && long.TryParse(parts[3], out var t) ? t : 0,
                    };
                    if (!string.IsNullOrEmpty(rec.ClientGuid))
                        bucket[rec.ClientGuid] = rec;
                }
                Plugin.Log.LogInfo($"[CharacterStore] loaded {bucket.Count} record(s) for seed \"{seed}\"");
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[CharacterStore] read \"{path}\" failed: {ex.Message}");
        }

        _bySeed[seed] = bucket;
        return bucket;
    }

    private static void WriteSeedFile(string seed, Dictionary<string, Record> bucket)
    {
        string path = FileFor(seed);
        try
        {
            using var sw = new StreamWriter(path, append: false);
            sw.WriteLine($"# SoDCoop characters for seed \"{seed}\"");
            foreach (var rec in bucket.Values)
            {
                sw.WriteLine($"{rec.ClientGuid}|{rec.FirstName}|{rec.Surname}|{rec.CreatedAtUnix}");
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[CharacterStore] write \"{path}\" failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Host-side current-world helpers
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Reads the current world's seed off <c>CityData.Instance</c>. Returns
    /// "default" if unavailable (host started hosting before the world is
    /// loaded — degenerate case but we still want to function).
    /// </summary>
    public static string CurrentSeed()
    {
        try
        {
            var city = global::CityData.Instance;
            if (city != null && !string.IsNullOrEmpty(city.seed)) return city.seed;
        }
        catch { }
        return "default";
    }

    /// <summary>Reads the current world's display city name, or "" if unavailable.</summary>
    public static string CurrentCityName()
    {
        try
        {
            var city = global::CityData.Instance;
            if (city != null && !string.IsNullOrEmpty(city.cityName)) return city.cityName;
        }
        catch { }
        return "";
    }

    /// <summary>
    /// Reads the host's own character name from SoD's Game singleton.
    /// Returns ("", "") if the host hasn't loaded a save yet — caller must
    /// handle that case (the lobby flow assumes the host is in-world).
    /// </summary>
    public static (string firstName, string surName) ReadHostCharacter()
    {
        try
        {
            var game = global::Game.Instance;
            if (game != null)
            {
                string fn = game.playerFirstName ?? "";
                string sn = game.playerSurname ?? "";
                return (fn, sn);
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[CharacterStore] ReadHostCharacter: {ex.Message}");
        }
        return ("", "");
    }
}
