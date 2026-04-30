using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using SoDCoop.Player;

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

        /// <summary>
        /// Phase B: humanID of the city citizen this client has "claimed" as
        /// their in-world identity (twin strategy). 0 = not yet assigned;
        /// <see cref="TwinManager"/> picks one and stamps the name on first
        /// use, then re-applies on every host startup.
        /// </summary>
        public int HumanID;

        /// <summary>
        /// Per-client appearance customization (debug-override fields applied
        /// to the twin citizen on every machine). Defaults to
        /// <see cref="AppearanceConfig.Default"/> with <c>IsCustomized=false</c>
        /// — meaning the twin retains its seeded vanilla look.
        /// </summary>
        public AppearanceConfig Appearance = AppearanceConfig.Default;
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

    /// <summary>All records currently persisted for the given seed.</summary>
    public static IEnumerable<Record> AllForSeed(string seed)
    {
        return LoadSeed(seed).Values;
    }

    /// <summary>
    /// Re-write the on-disk file for a seed from the in-memory bucket. Use
    /// this after mutating a record in place (e.g. <see cref="Record.HumanID"/>
    /// after <see cref="TwinManager"/> picks a citizen).
    /// </summary>
    public static void Persist(string seed)
    {
        var bucket = LoadSeed(seed);
        WriteSeedFile(seed, bucket);
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
                        HumanID       = parts.Length > 4 && int.TryParse(parts[4], out var h) ? h : 0,
                        Appearance    = (parts.Length > 5 && !string.IsNullOrEmpty(parts[5]))
                                            ? DecodeAppearance(parts[5])
                                            : AppearanceConfig.Default,
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
            sw.WriteLine("# format v6: clientGuid|firstName|surName|createdAtUnix|humanID|appearanceB64");
            foreach (var rec in bucket.Values)
            {
                string appB64 = EncodeAppearance(rec.Appearance);
                sw.WriteLine($"{rec.ClientGuid}|{rec.FirstName}|{rec.Surname}|{rec.CreatedAtUnix}|{rec.HumanID}|{appB64}");
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[CharacterStore] write \"{path}\" failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Appearance helpers
    // ─────────────────────────────────────────────────────────────────────

    private static string EncodeAppearance(AppearanceConfig cfg)
    {
        try { return Convert.ToBase64String(cfg.ToBytes()); }
        catch { return ""; }
    }

    private static AppearanceConfig DecodeAppearance(string b64)
    {
        try { return AppearanceConfig.FromBytes(Convert.FromBase64String(b64)); }
        catch { return AppearanceConfig.Default; }
    }

    /// <summary>
    /// Update the stored appearance for a client and persist the seed file.
    /// Returns true if the record existed and was updated.
    /// </summary>
    public static bool SetAppearance(string seed, string clientGuid, AppearanceConfig cfg)
    {
        var bucket = LoadSeed(seed);
        if (!bucket.TryGetValue(clientGuid, out var rec)) return false;
        rec.Appearance = cfg;
        WriteSeedFile(seed, bucket);
        return true;
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
