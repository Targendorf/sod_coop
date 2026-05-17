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

    /// <summary>
    /// Diagnostic flag — when true, <c>Plugin.InitializeHarmony</c> skips
    /// <c>PatchAll</c> entirely. Co-op networking still loads but no SoD
    /// methods are detoured. Used to A/B-measure whether save-load slowness
    /// comes from Harmony patches (mod overhead) or from SoD itself.
    ///
    /// <para>How to use: set
    /// <c>com.sodcoop.mod.cfg → [Diagnostics] SkipHarmonyPatches = true</c>,
    /// restart the game, time the same save-load. If still slow → SoD's
    /// own save-load is the bottleneck. If much faster → patch overhead is
    /// the bottleneck and we need to drop more patches.</para>
    /// </summary>
    public static ConfigEntry<bool> SkipHarmonyPatches;

    /// <summary>
    /// Pre-2026-05-08 behaviour: <c>UnpatchSelf</c> at first SOD.Common
    /// <c>OnBeforeLoad</c>, never re-patch. This sped up the very first
    /// save-load (41 s instead of 229 s) when the mod had 30+ active
    /// Harmony patches, many of which fired heavily during entity
    /// reconstruction (Evidence/Case/Fact/Vmail).
    ///
    /// <para>Today only ~10 Harmony patches remain active — all of them
    /// player-input or rare-event paths (MeleeAttack, OpenMap, AddMoney,
    /// SetWeather, side-job hooks, etc.) which fire 0–1 times during a
    /// save-load. Keeping them attached should be free, and gets us back
    /// the Valheim-style "real-time write hooks" that UnpatchSelf killed.
    /// Default <c>false</c> — patches stay alive across save-load. Flip
    /// to <c>true</c> only if a future patch-set regression makes save-
    /// load slow again, in which case UnpatchSelf reverts to the safe
    /// fallback. Setting takes effect on the NEXT save-load.</para>
    /// </summary>
    public static ConfigEntry<bool> UnpatchAtSaveLoad;

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

        SkipHarmonyPatches = config.Bind(
            "Diagnostics", "SkipHarmonyPatches", false,
            "DIAGNOSTIC ONLY: skip Harmony PatchAll at plugin load to measure how much save-load " +
            "slowness comes from patches vs SoD itself. With this on, no coop sync features work " +
            "(no broadcast detection) — for testing load speed only. Restart game after toggling.");

        UnpatchAtSaveLoad = config.Bind(
            "Diagnostics", "UnpatchAtSaveLoad", false,
            "Legacy behaviour: UnpatchSelf at first save-load to speed it up. With the current " +
            "small patch set (~10 event-only patches) this is no longer needed; keeping patches " +
            "alive gives real-time write hooks (Valheim-style) for the entire session instead of " +
            "polling fallbacks after the first load. Set this to true only if save-load becomes " +
            "noticeably slow after a future patch-set expansion. Restart not required — takes " +
            "effect on the next save-load event.");
    }
}
