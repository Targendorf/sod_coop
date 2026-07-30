using BepInEx.Configuration;

namespace SoDCoop;

/// <summary>
/// How the host's world is reproduced on a joining client. Set per-host via
/// the Coop menu; read in <c>NetworkManager.AssignCharacterAndCompleteHandshake</c>
/// to decide between the two bootstrap paths.
/// </summary>
public enum WorldBootstrapMode
{
    /// <summary><b>Default.</b> Host sends its full save file to the joiner
    /// via a chunked reliable stream; the joiner loads it through SoD's
    /// normal Load Game path. Guarantees an identical world (every NPC
    /// schedule, every door state, every murder state) by construction —
    /// no ZDO snapshot can drift because the worlds start byte-identical.
    /// Tutorial is skipped automatically (loading a save never fires
    /// ChapterIntro.OnGameStart). Costs one save-file transfer on first
    /// join; re-syncs automatically when the host saves again.</summary>
    SaveTransfer = 0,

    /// <summary>Legacy fast-connect path. Host sends only a share-code
    /// (seed + city size + name); the joiner regenerates the city locally
    /// via SoD's "Generate from Share Code" pipeline. Cheaper connect (no
    /// file transfer) but the two worlds can diverge on any non-
    /// deterministic SoD state (NPC schedule jitter, murder RNG, citizen
    /// roster ordering) that the ZDO snapshot doesn't cover. Tutorial
    /// suppression relies on <c>JoinedSessionActive</c> Harmony patches.</summary>
    ShareCode = 1,
}

/// <summary>
/// NPC animation sync mode for the CitizenAnimationPoller. Controls how
/// per-citizen idle/arms animation states (sweeping, cooking, typing, etc.)
/// propagate from host to clients.
/// </summary>
public enum CitizenAnimSyncMode
{
    /// <summary>Disabled — the poller never runs. SoD's deterministic AI
    /// computes the same animation states on every client from the same
    /// seed, so no network sync is needed. Best performance; minor visual
    /// divergence when a player interacts with an NPC (the NPC's idle
    /// pose may lag behind its dialogue / state until the schedule
    /// naturally re-converges).</summary>
    Disabled = 0,

    /// <summary>Automatic — the poller scans only NPCs within cull range
    /// (~150m) of connected players, so only ~30-50 citizens per tick
    /// instead of all 336. Balances visual accuracy near players with low
    /// host-side cost. Recommended default.</summary>
    Auto = 1,

    /// <summary>Fixed Hz — the poller scans ALL citizens at the configured
    /// rate (see CitizenAnimSyncHz). Most visually accurate, highest cost.
    /// Use only on powerful host machines with few players.</summary>
    FixedHz = 2,
}

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

    /// <summary>How a joining client acquires the host's world. See
    /// <see cref="WorldBootstrapMode"/> for the trade-off between
    /// <see cref="WorldBootstrapMode.SaveTransfer"/> (identical-world
    /// guarantee, one file transfer on join) and
    /// <see cref="WorldBootstrapMode.ShareCode"/> (fast connect, may
    /// diverge). Host-side setting — the host's choice applies to every
    /// joining client. Clients that don't support SaveTransfer fall back
    /// to ShareCode automatically.</summary>
    public static ConfigEntry<WorldBootstrapMode> WorldBootstrap;

    /// <summary>Only relevant when <see cref="WorldBootstrap"/> =
    /// <see cref="WorldBootstrapMode.SaveTransfer"/>. When true, the
    /// client accepts incoming save transfers (first-join + live re-sync
    /// when the host saves) without prompting. When false, a dialog asks
    /// the player before overwriting their world with the host's save —
    /// useful when a client wants to preserve their own progress in a
    /// world that diverged from the host's.</summary>
    public static ConfigEntry<bool> SaveTransferAutoAccept;

    /// <summary>Host-side, opt-in. Capture a fresh save before shipping it to a
    /// joining client, so the base world the joiner loads matches the host's
    /// live state exactly rather than the state at the host's last save/load.
    /// Off by default: it calls <c>SaveStateController.CaptureSaveStateAsync</c>
    /// mid-session, and it is not yet confirmed by playtest that doing so
    /// leaves the game's notion of "current save" untouched. The capture always
    /// writes to a dedicated coop file and never over the player's own
    /// saves.</summary>
    public static ConfigEntry<bool> SaveTransferForceSaveOnJoin;

    /// <summary>Host-authoritative position replication for citizens near each
    /// client. On by default: without it nothing syncs citizen positions at all
    /// and the two players drift into seeing the same person in different
    /// places, because only SoD's citizen *schedule* is deterministic from the
    /// seed — the movement execution is not. See <c>CitizenPositionSync</c>.</summary>
    public static ConfigEntry<bool> SyncCitizenPositions;

    /// <summary>How NPC idle/arms animation states (sweeping, cooking, typing,
    /// etc.) are synced from host to clients. <see cref="CitizenAnimSyncMode"/>
    /// for options.</summary>
    public static ConfigEntry<CitizenAnimSyncMode> CitizenAnimSync;

    /// <summary>When CitizenAnimSync = FixedHz, the scan rate for the
    /// CitizenAnimationPoller. 1 = cheapest, 5 = smoothest.</summary>
    public static ConfigEntry<int> CitizenAnimSyncHz;

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

        WorldBootstrap = config.Bind(
            "Networking", "WorldBootstrap", WorldBootstrapMode.SaveTransfer,
            "How a joining client acquires the host's world. SaveTransfer (default): host sends " +
            "its save file, client loads it — identical world guaranteed, tutorial auto-skipped. " +
            "ShareCode: client regenerates the city from a seed share-code — faster connect but " +
            "the two worlds may diverge on non-deterministic SoD state. Host-side setting.");

        SaveTransferAutoAccept = config.Bind(
            "Networking", "SaveTransferAutoAccept", true,
            "When WorldBootstrap=SaveTransfer: automatically accept incoming save transfers " +
            "(first-join + live re-sync when host saves) without prompting. Set false to get a " +
            "confirmation dialog before the host's save overwrites your world.");

        SaveTransferForceSaveOnJoin = config.Bind(
            "Networking", "SaveTransferForceSaveOnJoin", false,
            "When WorldBootstrap=SaveTransfer: capture a fresh save right before shipping it to a " +
            "joining client, so their base world matches your live state exactly instead of your last " +
            "save/load. Writes to a dedicated coop file — never over your own saves. Off by default " +
            "because saving mid-session this way is not yet playtest-verified; leave it off and just " +
            "save before friends join for the same result.");

        SyncCitizenPositions = config.Bind(
            "Networking", "SyncCitizenPositions", true,
            "Host sends the positions of citizens near each client so both players see the same " +
            "people in the same places. Clients freeze those citizens' local AI and drive them from " +
            "the host instead. Turn off to fall back to purely local NPC simulation (cheaper, but " +
            "the two worlds drift apart visibly over a session).");

        CitizenAnimSync = config.Bind(
            "Performance", "CitizenAnimSync", CitizenAnimSyncMode.Auto,
            "NPC animation sync (host → clients). Disabled: no sync (best perf, minor visual " +
            "divergence near NPCs you interact with). Auto (default): scan only NPCs near connected " +
            "players (~30-50 instead of 336). FixedHz: scan ALL NPCs at the rate below (most " +
            "accurate, highest cost).");

        CitizenAnimSyncHz = config.Bind(
            "Performance", "CitizenAnimSyncHz", 2,
            "When CitizenAnimSync=FixedHz: scan rate in Hz (1-5). Lower = cheaper.");
    }
}
