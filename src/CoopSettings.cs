using BepInEx.Configuration;

namespace SoDCoop;

/// <summary>
/// Persistent user preferences for the coop mod's overlays.
///
/// Storage: BepInEx writes / reads <c>BepInEx/config/com.sodcoop.mod.cfg</c>
/// automatically. Each <see cref="ConfigEntry{T}"/> is mutated in-place by
/// the settings UI (<see cref="UI.Coop.Panels.SettingsPanel"/>) and BepInEx
/// flushes the file on shutdown — so toggles survive across game restarts
/// without us touching disk explicitly.
///
/// Only flags that affect in-world overlay visibility live here; networking
/// and gameplay invariants stay code-driven.
/// </summary>
public static class CoopSettings
{
    /// <summary>Top-right player list with vitals bars.</summary>
    public static ConfigEntry<bool> ShowStatusHUD;

    /// <summary>Bottom-left chat window.</summary>
    public static ConfigEntry<bool> ShowChatWindow;

    /// <summary>Floating "Player Name · 12m" label above other players' heads.</summary>
    public static ConfigEntry<bool> ShowNameTags;

    /// <summary>Transient overlay banners (sleep notification, phone ring), top-right area.</summary>
    public static ConfigEntry<bool> ShowOverlayBanners;

    /// <summary>
    /// Forced UI language code (en / ru / uk / es / zh / de) or "auto"
    /// to follow <c>Game.Instance.language</c>. See
    /// <see cref="SoDCoop.Localization.L"/> for the resolution chain.
    /// </summary>
    public static ConfigEntry<string> LanguageOverride;

    public static void Initialize(ConfigFile config)
    {
        ShowStatusHUD = config.Bind(
            "Overlays", "ShowStatusHUD", true,
            "Show the top-right player list with name, host marker, and vitals bars while in a coop session.");

        ShowChatWindow = config.Bind(
            "Overlays", "ShowChatWindow", true,
            "Show the bottom-left chat window while in a coop session.");

        ShowNameTags = config.Bind(
            "Overlays", "ShowNameTags", true,
            "Show floating name labels above remote players' heads. Disable for a cleaner first-person view.");

        ShowOverlayBanners = config.Bind(
            "Overlays", "ShowOverlayBanners", true,
            "Show transient banners (\"X is asleep\", incoming-call sync). Disable for a quieter HUD.");

        LanguageOverride = config.Bind(
            "General", "LanguageOverride", "auto",
            "UI language for the coop mod. Use \"auto\" to follow the game's current language. " +
            "Explicit codes: en, ru, uk, es, zh, de. Re-resolved on plugin load and on each save load.");
    }
}
