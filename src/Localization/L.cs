using System.Collections.Generic;

namespace SoDCoop.Localization;

/// <summary>
/// Central facade for the mod's UI translations.
///
/// <para><b>Resolution order</b> for the active language code:</para>
/// <list type="number">
///   <item>If <see cref="CoopSettings.LanguageOverride"/> is set to a known
///         code (e.g. "ru"), use that. Lets the user force a language
///         independent of the game.</item>
///   <item>Otherwise read <c>Game.Instance.language</c> and normalise it
///         (SoD stores values like "english", "russian", or sometimes ISO
///         codes; we lower-case + map to our two-letter codes).</item>
///   <item>If neither resolves to a known dict, fall back to "en".</item>
/// </list>
///
/// <para><b>Key naming</b>: use lowercase, dot-separated namespacing
/// (e.g. <c>main.title</c>, <c>host.startBtn</c>). Missing keys for the
/// active language fall back to the EN dict; missing in EN too returns
/// the key itself (so unfilled placeholders are visible in-UI rather
/// than crashing).</para>
///
/// <para><see cref="Refresh"/> is called from <c>Plugin.Load</c> at startup
/// and from <c>WorldReadyGate.OnWorldReady</c> (so a save loaded
/// mid-session re-resolves the language). Panels that cache resolved
/// strings should re-read on Show / Refresh — most panels just call
/// <see cref="Get"/> inline so they pick up changes naturally.</para>
/// </summary>
public static class L
{
    /// <summary>Currently active language code, lowercase, two letters.</summary>
    public static string Lang { get; private set; } = "en";

    /// <summary>
    /// All known languages. Add new dicts in <see cref="Translations"/> and
    /// register them here. Order = dropdown order in any future picker.
    /// </summary>
    public static readonly string[] SupportedLanguages = { "en", "ru", "uk", "es", "zh", "de" };

    private static Dictionary<string, string> _active = Translations.En;
    private static readonly Dictionary<string, string> _fallback = Translations.En;

    /// <summary>
    /// Resolve and cache the active language. Cheap; safe to call any time
    /// (e.g. on world-ready transition, or after the user changes the
    /// override config).
    /// </summary>
    public static void Refresh()
    {
        string code = ResolveLanguageCode();
        if (code == Lang) return;

        Lang = code;
        _active = LookupDict(code) ?? Translations.En;
        Plugin.Log.LogInfo($"[L] active language: {code} ({_active.Count} keys)");
    }

    /// <summary>
    /// Look up a translated string by key. Falls back to EN, then to the
    /// key itself. Always returns non-null.
    /// </summary>
    public static string Get(string key)
    {
        if (string.IsNullOrEmpty(key)) return "";
        if (_active != null && _active.TryGetValue(key, out var v) && !string.IsNullOrEmpty(v)) return v;
        if (_fallback != null && _fallback.TryGetValue(key, out var fb) && !string.IsNullOrEmpty(fb)) return fb;
        return key;
    }

    /// <summary>printf-style helper. Same fallback rules as <see cref="Get(string)"/>.</summary>
    public static string Get(string key, params object[] args)
    {
        var fmt = Get(key);
        try { return string.Format(fmt, args); }
        catch { return fmt; }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Internals
    // ─────────────────────────────────────────────────────────────────────

    private static string ResolveLanguageCode()
    {
        // 1. Explicit override from BepInEx config (e.g. "ru", "en", "auto").
        try
        {
            var ovr = CoopSettings.LanguageOverride?.Value?.Trim().ToLowerInvariant();
            if (!string.IsNullOrEmpty(ovr) && ovr != "auto")
            {
                if (LookupDict(ovr) != null) return ovr;
                Plugin.Log.LogWarning($"[L] LanguageOverride=\"{ovr}\" not in supported set — falling back to game / en.");
            }
        }
        catch { }

        // 2. Read from SoD's Game.Instance.language. Format varies — normalise.
        try
        {
            var raw = global::Game.Instance?.language;
            if (!string.IsNullOrEmpty(raw))
            {
                var norm = NormaliseGameLanguage(raw);
                if (LookupDict(norm) != null) return norm;
            }
        }
        catch { }

        // 3. Last resort.
        return "en";
    }

    /// <summary>
    /// SoD stores language as something like "english", "russian", "deutsch",
    /// "中文", or sometimes already an ISO code depending on version. Map to
    /// our two-letter codes; unknown → "en".
    /// </summary>
    private static string NormaliseGameLanguage(string raw)
    {
        var s = raw.Trim().ToLowerInvariant();

        // Already a code we know.
        foreach (var c in SupportedLanguages) if (s == c) return c;

        // Common full names → ISO.
        if (s.StartsWith("eng")) return "en";
        if (s.StartsWith("rus") || s.Contains("русск")) return "ru";
        if (s.StartsWith("ukr") || s.Contains("укра")) return "uk";
        if (s.StartsWith("spa") || s.StartsWith("esp") || s.Contains("español")) return "es";
        if (s.StartsWith("zh")  || s.StartsWith("chi") || s.Contains("中文") || s.Contains("汉")) return "zh";
        if (s.StartsWith("ger") || s.StartsWith("deu") || s.Contains("deutsch")) return "de";

        return "en";
    }

    private static Dictionary<string, string> LookupDict(string code)
    {
        switch (code)
        {
            case "en": return Translations.En;
            case "ru": return Translations.Ru;
            case "uk": return Translations.Uk;
            case "es": return Translations.Es;
            case "zh": return Translations.Zh;
            case "de": return Translations.De;
            default:   return null;
        }
    }
}
