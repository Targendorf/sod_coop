using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using System.Linq;
using System.Reflection;
using SoDCoop.Network;
using SoDCoop.Network.Steam;
using SoDCoop.Sync;
using SoDCoop.Player;
using SoDCoop.UI;
using SoDCoop.Integration;
using SoDCoop.Zdo;
using UnityEngine;

namespace SoDCoop;

/// <summary>
/// Main BepInEx plugin for Shadow of Doubt Co-op Mod.
/// Enables P2P cooperative gameplay between multiple players.
/// </summary>
[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
[BepInProcess("Shadows of Doubt.exe")]
public class Plugin : BasePlugin
{
    /// <summary>
    /// Singleton instance of the plugin.
    /// </summary>
    public static Plugin Instance { get; private set; }
    
    /// <summary>
    /// Logger for the plugin.
    /// </summary>
    public static new ManualLogSource Log { get; private set; }
    
    /// <summary>
    /// Harmony instance for patching.
    /// </summary>
    private Harmony _harmony;

    /// <summary>
    /// GameObject that persists across scenes for network updates.
    /// </summary>
    private GameObject _updateRunner;

    public override void Load()
    {
        Instance = this;
        Log = base.Log;
        
        Log.LogInfo($"Loading {PluginInfo.PLUGIN_NAME} v{PluginInfo.PLUGIN_VERSION}...");

        try
        {
            // Persisted user toggles for overlay visibility. Bind first so any
            // system that reads CoopSettings.* during init sees real values
            // instead of null ConfigEntry refs.
            CoopSettings.Initialize(Config);

            // Resolve the UI language as soon as config is bound. This picks
            // up the user's LanguageOverride; the Game.Instance.language
            // fallback re-runs on world-ready (see WorldReadyGate hook).
            SoDCoop.Localization.L.Refresh();
            // Re-resolve every time a save loads so a player who switches
            // SoD's language between sessions sees the mod follow.
            SoDCoop.Sync.WorldReadyGate.OnWorldReady += () =>
            {
                try { SoDCoop.Localization.L.Refresh(); }
                catch (System.Exception ex) { Log.LogWarning($"L.Refresh on world-ready: {ex.Message}"); }
            };

            // Register our MonoBehaviour types with IL2CPP so AddComponent<> works.
            RegisterIl2CppTypes();

            // Initialize Harmony patching
            InitializeHarmony();

            // Initialize core systems
            InitializeSystems();

            // Snapshot Steam launch args BEFORE the update runner starts so
            // the per-frame TryDrain can pick up an auto-join the moment
            // Steam callbacks come online. Friend → "Join Game" while our
            // copy of SoD wasn't running ⇒ Steam launches us with
            // "+connect_lobby <id>".
            SteamLaunchArgs.Parse();

            // Create update runner
            CreateUpdateRunner();
            
            Log.LogInfo($"{PluginInfo.PLUGIN_NAME} loaded successfully!");
            Log.LogInfo("Press F9 to open the Co-op menu.");
        }
        catch (System.Exception ex)
        {
            Log.LogError($"Failed to load {PluginInfo.PLUGIN_NAME}: {ex}");
            throw;
        }
    }

    public override bool Unload()
    {
        Log.LogInfo($"Unloading {PluginInfo.PLUGIN_NAME}...");
        
        // Disconnect from network
        NetworkManager.Shutdown();
        
        // Cleanup sync systems
        SyncManager.Shutdown();
        
        // Unpatch all Harmony patches
        _harmony?.UnpatchSelf();
        
        // Destroy update runner
        if (_updateRunner != null)
        {
            Object.Destroy(_updateRunner);
        }
        
        return base.Unload();
    }

    private void RegisterIl2CppTypes()
    {
        TryRegister<CoopUpdateRunner>();
        TryRegister<RemotePlayer>();
        TryRegister<BillboardLabel>();
    }

    private static void TryRegister<T>() where T : class
    {
        var name = typeof(T).Name;
        try
        {
            ClassInjector.RegisterTypeInIl2Cpp<T>();
            Log.LogInfo($"IL2CPP injection OK: {name}");
        }
        catch (System.Exception ex)
        {
            // Don't kill the whole plugin if one type fails — log loudly and degrade.
            // Most failures here are signature-resolution NREs in Il2CppInterop's
            // ConvertMethodInfo, which leave the type partially registered but usually
            // good enough for AddComponent to still work in practice.
            Log.LogError($"IL2CPP injection FAILED for {name}: {ex.GetType().Name}: {ex.Message}");
        }
    }

    private void InitializeHarmony()
    {
        // Iteration history:
        //   v1: PatchAll synchronously at plugin load → stable. SP world-gen
        //       / save-load is ~5x slower because IL2CPP marshals heavy
        //       parameter types on every call regardless of our
        //       `!IsConnected` early-bail.
        //   v2: lazy install on first OnConnected, unpatch on disconnect →
        //       fast SP, but ate a 5-10 min synchronous freeze on click-Host.
        //   v3: progressive (one type per frame) at click-Host → fast SP,
        //       no freeze, BUT MonoMod's IL2CPP detour backend crashed with
        //       a fatal "Internal CLR error 0x80131506" inside
        //       CompileMethodHook on first install attempt at game-time.
        //   v4: pre-cache types via Assembly.GetTypes() at plugin load
        //       (cold JIT), defer install to OnAfterLoad with progressive
        //       drain → CRASHES at plugin load time. The
        //       `t.GetCustomAttributes(typeof(HarmonyPatch))` call
        //       triggers a JIT compile that MonoMod's hook handles
        //       differently than Harmony's own internal attribute
        //       discovery. Same fatal CompileMethodHook error.
        //
        //   v5 (this) = back to v1: synchronous PatchAll at plugin load.
        //       Stable. The SP slowdown is a known cost we'll address by
        //       hand-trimming heavy parameter signatures patch-by-patch
        //       (the Evidence.SetNote disable in commit 3997294 was the
        //       first such trim; more to follow if user reports specific
        //       paths still being slow).
        _harmony = new Harmony(PluginInfo.PLUGIN_GUID);

        if (CoopSettings.SkipHarmonyPatches?.Value == true)
        {
            Log.LogWarning("[DIAGNOSTIC] CoopSettings.SkipHarmonyPatches=true — Harmony PatchAll SKIPPED. " +
                           "Co-op detection paths are inactive; this build is only useful to measure " +
                           "save-load speed without patch overhead.");
        }
        else
        {
            Log.LogInfo("Initializing Harmony patches at plugin load...");
            var sw = System.Diagnostics.Stopwatch.StartNew();
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
            sw.Stop();
            Log.LogInfo($"Applied {_harmony.GetPatchedMethods().Count()} Harmony patches at plugin load in {sw.Elapsed.TotalSeconds:F2}s.");
        }

        // Pause patches IMMEDIATELY after install. Patches are pre-built
        // (Harmony state set up, native detours installed by Dobby) but
        // logically off — wrappers become near-passthrough. This covers
        // new-game world-gen which doesn't fire SOD.Common.OnBeforeLoad.
        // Resume fires from WorldReadyGate.OnWorldReady → SchedulePatchResume.
        PausePatchesForLoad();

        SoDCoop.Sync.WorldReadyGate.OnWorldReady += OnWorldReadyForResume;
        SoDCoop.Sync.WorldReadyGate.OnWorldUnready += OnWorldUnreadyForRePause;

        // Defensive maintenance: probe every poller once on first world-ready
        // so a renamed SoD field (after a major patch) surfaces as a loud
        // "FIELD DRIFT" error instead of a silent sync regression.
        SoDCoop.Sync.WorldReadyGate.OnWorldReady += OnWorldReadyForPollerProbe;
    }

    private static bool _pollerProbeRan;
    private static void OnWorldReadyForPollerProbe()
    {
        if (_pollerProbeRan) return;
        _pollerProbeRan = true;
        try { SoDCoop.Zdo.Pollers.PollerHealthCheck.RunProbe(); }
        catch (System.Exception ex) { Log.LogError($"[PollerHealthCheck] probe itself crashed: {ex}"); }
    }

    private static void OnWorldReadyForResume()
    {
        try
        {
            // Bug #5: load persisted ZDOs after the world is ready (so
            // resolvers can deref Human/Interactable refs cleanly). Host-only
            // — joiners always receive state via the host's snapshot push.
            // Order matters: load AFTER world is ready, BEFORE pollers fire.
            if (SoDCoop.Network.NetworkManager.IsHost)
            {
                try { SoDCoop.Zdo.ZdoMan.LoadFromDisk(); }
                catch (System.Exception ex) { Log.LogWarning($"ZdoMan.LoadFromDisk failed: {ex.Message}"); }
            }

            if (!IsPatchPaused) return;
            Log.LogInfo("[Resume] WorldReady observed — scheduling Resume.");
            SchedulePatchResume();
        }
        catch (System.Exception ex) { Log.LogError($"OnWorldReadyForResume: {ex}"); }
    }

    private static void OnWorldUnreadyForRePause()
    {
        try
        {
            // Bug #5: persist ZDOs to disk BEFORE the unready cascade clears
            // the registry. Host-only; SaveToDisk is a no-op when there's
            // nothing to save. Wrapped separately so a save failure doesn't
            // skip the patch re-pause below.
            if (SoDCoop.Network.NetworkManager.IsHost)
            {
                try { SoDCoop.Zdo.ZdoMan.SaveToDisk(); }
                catch (System.Exception ex) { Log.LogWarning($"ZdoMan.SaveToDisk failed: {ex.Message}"); }
            }

            if (IsPatchPaused) return;
            Log.LogInfo("[Resume] WorldUnready observed — re-pausing patches for next load.");
            PausePatchesForLoad();
        }
        catch (System.Exception ex) { Log.LogError($"OnWorldUnreadyForRePause: {ex}"); }
    }

    // ─── One-shot UnpatchSelf — never re-PatchAll (CompileMethodHook crash) ─
    //
    // Empirical results (user playtest 2026-05-02):
    //   • PatchAll attached + body-bail on SyncGate.IsOpen=false: save-load 229s.
    //   • UnpatchSelf on OnBeforeLoad + body-bail: save-load 41s. 5.6x speedup.
    //   • Re-PatchAll after UnpatchSelf (gradual or batch): fatal CLR crash in
    //     MonoMod.CompileMethodHook (Internal CLR error 0x80131506). Same
    //     failure mode Phase 1 v3/v4 ran into — IL2CPP detour backend can't
    //     re-compile method hooks at game-time.
    //
    // Decision: UnpatchSelf is one-shot. Patches die after first OnBeforeLoad
    // and stay dead for the session. Coop falls back to ZDO pollers (host-side
    // state replication) + ZdoEvents (chat / map-ping / pause banner) which
    // don't need Harmony patches at all.
    //
    // Known regression: Harmony-patched player-input events (raise weapon,
    // toggle flashlight, place codebreaker, throw grenade, take photo, give
    // item, NPC handcuff, computer login, etc.) stop broadcasting after the
    // first save-load. User must restart the game to re-attach patches.
    //
    // Future migration: convert each [HarmonyPatch] into a host/local poller
    // (similar to existing DoorPoller / LightPoller / etc.) so patches become
    // unnecessary entirely.

    public static bool IsPatchPaused { get; private set; }

    /// <summary>Save-load handler. Behaviour controlled by
    /// <see cref="CoopSettings.UnpatchAtSaveLoad"/>:
    /// <list type="bullet">
    ///   <item><b>false (default)</b> — keep all Harmony patches attached.
    ///       Real-time write hooks survive across save-load (Valheim-style),
    ///       no polling fallback needed for the patches that ARE installed.
    ///       Safe with the current ~10 event-only patch set; previous
    ///       30+ load-heavy patch set required UnpatchSelf because patches
    ///       like Evidence.AddDiscovery / Case.SetStatus fired thousands
    ///       of times per save-load.</item>
    ///   <item><b>true</b> — legacy: UnpatchSelf on first save-load, dead
    ///       for session. Use only if a future regression slows save-load
    ///       and we can't immediately identify the culprit patch.</item>
    /// </list>
    /// Idempotent — once paused (legacy mode), stays paused for the session.</summary>
    public static void PausePatchesForLoad()
    {
        if (IsPatchPaused) return;
        var inst = Instance;
        if (inst?._harmony == null) return;

        // New default: keep patches alive across save-load. Only strip
        // them if the user explicitly opts back into the legacy fast-load
        // path via CoopSettings.UnpatchAtSaveLoad.
        bool stripPatches = CoopSettings.UnpatchAtSaveLoad?.Value == true;
        if (!stripPatches)
        {
            // Mark as "paused" semantically so SyncGate stays closed
            // through the load even though patches remain attached. The
            // body-bail check inside each patch (`if (!SyncGate.IsOpen)
            // return;`) makes attached-but-paused patches near-zero-cost
            // for invocations during the load. SyncGate re-opens at
            // init-grace close, same as before.
            IsPatchPaused = true;
            Log.LogInfo("Harmony patches KEPT ATTACHED through save-load — body-bail via SyncGate. " +
                        "Real-time write hooks remain live for the session (no UnpatchSelf). " +
                        "(Toggle CoopSettings.UnpatchAtSaveLoad=true to revert to legacy fast-load behaviour.)");
            return;
        }

        try
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            inst._harmony.UnpatchSelf();
            sw.Stop();
            IsPatchPaused = true;
            Log.LogInfo($"Harmony patches PAUSED (legacy one-shot, no resume) — UnpatchSelf in {sw.Elapsed.TotalSeconds:F2}s. " +
                        $"Player-input event broadcasts deactivated until game restart. " +
                        $"ZDO pollers and ZdoEvents continue to operate.");
        }
        catch (System.Exception ex)
        {
            Log.LogError($"PausePatchesForLoad failed: {ex}");
        }
    }

    /// <summary>Called from SodCommonBridge.OnAfterLoad. Re-PatchAll path is
    /// disabled (crashes via MonoMod.CompileMethodHook on IL2CPP backend).
    /// Just opens SyncGate so polling-side broadcasts can flow.</summary>
    public static void SchedulePatchResume()
    {
        // No-op. Kept as the public hook so SodCommonBridge doesn't need to
        // change every time we revisit this question. The actual SyncGate
        // open happens via WorldReadyGate's init-grace-close path.
        Log.LogInfo("[Patches] SchedulePatchResume: no-op (re-PatchAll disabled to avoid CompileMethodHook crash). " +
                    "SyncGate will open at init-grace close for poller-driven broadcasts.");
    }

    /// <summary>Per-frame poller used to be the gradual-Resume driver. Now a
    /// no-op; kept for binary-compat in CoopUpdateRunner.Update.</summary>
    public static void DrainPendingResume() { /* no-op */ }

    private void InitializeSystems()
    {
        Log.LogInfo($"Stable client GUID: {SoDCoop.Player.CharacterIdentity.ClientGuid}");

        Log.LogInfo("Initializing network manager...");
        NetworkManager.Initialize();
        
        Log.LogInfo("Initializing sync manager...");
        SyncManager.Initialize();
        
        Log.LogInfo("Initializing world-ready gate...");
        WorldReadyGate.Initialize();

        Log.LogInfo("Initializing ZdoMan (unified replication)...");
        ZdoMan.Initialize();
        ZdoBootstrap.RegisterAll();
        // Wipe in-memory ZDO registry between sessions so a return-to-menu
        // doesn't carry stale state into the next world.
        WorldReadyGate.OnWorldUnready += () =>
        {
            // Flush any batched events still in the queue before the world
            // tears down. Without this, events enqueued by the last poller
            // tick (citizen anim flips, speech bubbles) that hadn't hit their
            // per-frame Pump yet would be silently dropped. They reference
            // citizens/actors that are about to be destroyed, but Pump ships
            // to PEERS whose worlds are still up, so the state is still
            // meaningful on the receiving end.
            try { SoDCoop.Zdo.ZdoEventDispatcher.PumpPendingEventBatch(); }
            catch (System.Exception ex) { Log.LogWarning($"ZdoEventDispatcher.PumpPendingEventBatch on unready: {ex.Message}"); }
            try { ZdoMan.Clear(); } catch (System.Exception ex) { Log.LogWarning($"ZdoMan.Clear: {ex.Message}"); }
            // The citizen roster cache must drop with the world too. Its
            // count-change rebuild heuristic can't detect "same city (or a
            // city with an identical citizen count) reloaded via a path that
            // skips SodCommonBridge.OnBeforeLoad" — e.g. return-to-menu then
            // re-host the same seed: 336 == 336 means no rebuild, and every
            // per-citizen poller would silently iterate destroyed Human refs
            // (Unity null-equality makes them all skip) for the whole
            // session — a total citizen-sync outage with no errors logged.
            try { SoDCoop.Zdo.Pollers.CitizenRosterCache.Reset(); }
            catch (System.Exception ex) { Log.LogWarning($"CitizenRosterCache.Reset: {ex.Message}"); }
            // Same lifetime rule as the citizen roster: the cached Evidence
            // references belong to the world being torn down.
            try { SoDCoop.Zdo.Pollers.EvidenceRosterCache.Reset(); }
            catch (System.Exception ex) { Log.LogWarning($"EvidenceRosterCache.Reset: {ex.Message}"); }
            // Applied-print dedup is per world: the next one has fresh ZDO ids.
            try { SoDCoop.Zdo.Resolvers.FingerprintResolver.Reset(); }
            catch (System.Exception ex) { Log.LogWarning($"FingerprintResolver.Reset: {ex.Message}"); }
            // Transient-event logs and cursors: per world, like the registry
            // they index.
            try
            {
                SoDCoop.Zdo.Resolvers.FootprintResolver.Reset();
                SoDCoop.Zdo.Resolvers.SpatterResolver.Reset();
                SoDCoop.Zdo.Pollers.FootprintPoller.ResetBaseline();
                SoDCoop.Zdo.Pollers.SpatterPoller.ResetBaseline();
            }
            catch (System.Exception ex) { Log.LogWarning($"transient-event reset: {ex.Message}"); }
            // Forget which twin we hid — the reload rebuilds the citizen rig
            // with its renderers back on, so the hide has to be re-applied.
            try { SoDCoop.Sync.TwinManager.ResetOwnTwinHidden(); }
            catch (System.Exception ex) { Log.LogWarning($"TwinManager.ResetOwnTwinHidden: {ex.Message}"); }
        };

        Log.LogInfo("Initializing remote player manager...");
        RemotePlayerManager.Initialize();
        
        Log.LogInfo("Initializing UI...");
        CoopUI.Initialize();
        SoDCoop.UI.Coop.CoopMenuController.Initialize();
        SoDCoop.UI.Coop.AppearancePreviewStage.Initialize();

        Log.LogInfo("Initializing SOD.Common bridge...");
        SodCommonBridge.Initialize();

        // Record successful client-side joins so the main menu can offer
        // one-click rejoin in future sessions.
        NetworkManager.OnConnected += RecordCurrentSessionToHistory;
    }

    /// <summary>
    /// Persists "I just successfully joined this host" into
    /// <see cref="SoDCoop.Network.SessionStore"/> so the main menu can
    /// surface the host as a one-click "rejoin" entry next time the user
    /// opens the menu (even days later, after restarting SoD).
    /// </summary>
    private static void RecordCurrentSessionToHistory()
    {
        try
        {
            if (NetworkManager.IsHost) return;          // we're hosting, nothing to record
            ulong hostSteamId = NetworkManager.LastHostSteamId.m_SteamID;
            ulong lobbyId     = NetworkManager.LastLobbyId.m_SteamID;
            if (hostSteamId == 0) return;

            // Prefer the host's in-game character name (from the player
            // roster) over the Steam display name we cached at lobby time.
            string hostName = NetworkManager.LastHostName ?? "";
            foreach (var p in NetworkManager.Players.Values)
            {
                if (p != null && p.IsHost && !string.IsNullOrEmpty(p.PlayerName))
                {
                    hostName = p.PlayerName;
                    break;
                }
            }
            SoDCoop.Network.SessionStore.Record(hostSteamId, lobbyId, hostName);
        }
        catch (System.Exception ex)
        {
            Log.LogWarning($"RecordCurrentSessionToHistory: {ex.Message}");
        }
    }

    private void CreateUpdateRunner()
    {
        _updateRunner = new GameObject("SoDCoop_UpdateRunner");
        Object.DontDestroyOnLoad(_updateRunner);
        _updateRunner.hideFlags = HideFlags.HideAndDontSave;
        _updateRunner.AddComponent<CoopUpdateRunner>();
    }
}

/// <summary>
/// Plugin metadata constants.
/// </summary>
public static class PluginInfo
{
    public const string PLUGIN_GUID = "com.sodcoop.mod";
    public const string PLUGIN_NAME = "SoD Coop";
    public const string PLUGIN_VERSION = "0.1.0";
}

/// <summary>
/// MonoBehaviour that runs network and sync updates every frame.
/// </summary>
public class CoopUpdateRunner : MonoBehaviour
{
    public CoopUpdateRunner(System.IntPtr ptr) : base(ptr) { }

    void Update()
    {
        CoopPerf.FrameStart();
        try
        {
            Plugin.DrainPendingResume();   // ← Pause/Resume gate check (revived from archive)
            WorldReadyGate.Tick();
            CoopPerf.Sample("net", () => NetworkManager.Update());
            SteamLaunchArgs.TryDrain();    // ← honours +connect_lobby <id> launch arg once Steam is up
            CoopPerf.Sample("sync", () => SyncManager.Update());
            CoopUI.Update();
            PingSystem.Update();
            // InventorySync.Update is now a no-op alias; held-item polling
            // runs through HeldItemPoller on the unified ZdoPollerHost tick.
            // SoDCoop.Sync.InventorySync.Update();
            SoDCoop.Sync.HostStatusSync.Update();
            SoDCoop.Sync.PlayerSuspicionSync.Update();
            // Hide our own twin once its id lands (it arrives at handshake,
            // after FreezeAllTwins has already run). Guarded by an id compare,
            // so this is two field reads once it's done.
            SoDCoop.Sync.TwinManager.HideOwnTwinBody();
            // Interpolate + apply host-authoritative citizen positions. Must run
            // every frame (not on the poller cadence) — it renders between 10 Hz
            // snapshots, same contract as RemotePlayer. No-op on the host and
            // when nothing is being driven.
            CoopPerf.Sample("npcpos", () => SoDCoop.Sync.CitizenPositionSync.Update());
            // Drive registered host-side pollers (doors, lights, citizens, …)
            // BEFORE the delta flush — pollers mark ZDOs dirty + enqueue
            // batched events, then the flush ships both in the same frame.
            CoopPerf.Sample("pollers", () => SoDCoop.Zdo.ZdoPollerHost.Tick(Time.unscaledTime));
            // Coalesce any batched events (citizen anim / speech / etc.) the
            // poller tick just enqueued into one ZdoEventRpc packet per
            // (delivery, spatial) bucket. No-op when the queue is empty.
            CoopPerf.Sample("evbatch", () => SoDCoop.Zdo.ZdoEventDispatcher.PumpPendingEventBatch());
            // ZDO unified delta-flush: collects every dirty ZDO into one
            // batched packet at 10 Hz and ships compressed (zstd-3) when
            // payload exceeds 100 B. Replaces ~30 per-feature Broadcast
            // call sites once Phase H is complete.
            CoopPerf.Sample("flush", () => SoDCoop.Zdo.ZdoMan.TickDeltaFlush(Time.unscaledTime));
            // Drain async snapshot sends — zstd of the join-time snapshot
            // now runs on the thread pool; this ships it whenever a worker
            // finishes. No-op when the queue is empty.
            CoopPerf.Sample("snap", () => SoDCoop.Zdo.ZdoMan.PumpPendingSnapshotSends());
            // Drain pending save-transfer sends (Mode 3 chunked host→joiner
            // save file stream). No-op when the queue is empty — typically
            // only non-empty for a few frames right after a peer joins while
            // WorldBootstrap=SaveTransfer.
            CoopPerf.Sample("save", () => SoDCoop.Sync.SaveTransfer.PumpPendingTransfers());
            // Drain amortized joiner-side resolver applies (snapshot restore /
            // post-load catch-up) at a bounded per-frame rate. No-op when empty.
            CoopPerf.Sample("resolve", () => SoDCoop.Zdo.ZdoMan.PumpPendingResolverApplies());
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error in CoopUpdateRunner.Update: {ex}");
        }
        finally
        {
            CoopPerf.FrameEnd();
        }
    }

    void OnGUI()
    {
        try
        {
            CoopUI.OnGUI();
            // PingSystem renders world-space pings triggered by player action;
            // not a passive HUD, so it stays ungated.
            PingSystem.OnGUI();
            if (CoopSettings.ShowOverlayBanners?.Value ?? true)
            {
                SoDCoop.Sync.PhoneSync.OnGUI();
                SoDCoop.Sync.PlayerStateSync.OnGUI();
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error in CoopUpdateRunner.OnGUI: {ex}");
        }
    }
}

/// <summary>
/// Built-in frame-cost attribution for the co-op layer. Answers the one
/// question every laggy-playtest log so far could NOT answer: when the host
/// drops frames, is the time going into OUR per-frame work
/// (CoopUpdateRunner.Update cascade) or into the game itself?
///
/// Two outputs, both throttled and cheap:
///  • A 10-second rollup: avg/max milliseconds the coop layer spent per
///    frame (logged only when max ≥ 1 ms so idle sessions stay silent).
///  • A frame-spike attribution line whenever the WHOLE game frame took
///    ≥ 200 ms: how much of that spike was the coop layer vs the game.
///    "[CoopPerf] FRAME SPIKE 512 ms — coop layer 3.1 ms" exonerates the
///    netcode; "— coop layer 480 ms" convicts it.
///
/// Costs one Stopwatch restart/stop per frame — negligible.
/// </summary>
public static class CoopPerf
{
    private static readonly System.Diagnostics.Stopwatch _sw = new();
    private static double _maxMs;
    private static double _sumMs;
    private static int    _frames;
    private static float  _nextRollupAt;
    private static float  _lastFrameTime;

    // Frame spikes are counted here and reported once per rollup instead of
    // one log line each — see FrameStart.
    private static int    _spikeCount;
    private static double _worstSpikeMs;
    private static double _worstSpikeCoopMs;

    // Per-subsystem accumulators. The Sample() helper records into these so
    // the 10s rollup can attribute the coop-layer cost to its biggest
    // contributor — without this, "coop layer avg=350ms/frame" tells us
    // nothing about WHICH subsystem is the culprit (playtest 2026-06-16:
    // host stayed at 600-1000ms/frame for the whole session after a peer
    // joined, but dirty/5s was only 55-238 — the cost was somewhere else
    // and the aggregate counter couldn't say where).
    private static readonly System.Collections.Generic.Dictionary<string, double> _subSum = new();
    private static readonly System.Collections.Generic.Dictionary<string, double> _subMax = new();
    private static readonly System.Diagnostics.Stopwatch _subSw = new();

    private const float ROLLUP_INTERVAL_S  = 10f;
    private const float SPIKE_THRESHOLD_S  = 0.2f;   // whole-frame spike: 200 ms
    private const double ROLLUP_MIN_MAX_MS = 1.0;    // stay silent when idle
    // Only log subsystem breakdown when the total exceeds this — keeps idle
    // sessions quiet.
    private const double SUB_LOG_MIN_MS = 5.0;

    /// <summary>Measure a subsystem call and fold its cost into the per-
    /// subsystem accumulators. Use via
    /// <c>CoopPerf.Sample("flush", () => ZdoMan.TickDeltaFlush(...))</c>.
    /// Threading: main thread only (same as the rest of CoopPerf).</summary>
    public static void Sample(string name, System.Action body)
    {
        _subSw.Restart();
        try { body(); }
        finally
        {
            _subSw.Stop();
            double ms = _subSw.Elapsed.TotalMilliseconds;
            _subSum[name] = (_subSum.TryGetValue(name, out var s) ? s : 0.0) + ms;
            if (!_subMax.TryGetValue(name, out var m) || ms > m) _subMax[name] = ms;
        }
    }

    public static void FrameStart()
    {
        // Whole-frame spike detection via unscaled delta between OUR Update
        // calls (≈ the game's frame time; unaffected by pause timeScale).
        float now = Time.unscaledTime;
        if (_lastFrameTime > 0f)
        {
            float frameDt = now - _lastFrameTime;
            if (frameDt >= SPIKE_THRESHOLD_S)
            {
                // Counted, not logged. One line per spike is fine when spikes
                // are rare and useless when they are not: on the 2026-07-30
                // playtest the host sat at ~5 FPS, so EVERY frame tripped the
                // threshold and this single statement produced 763 of the
                // log's 1420 lines — 54% of the file, drowning the errors the
                // log exists to surface. The 10 s rollup below reports the
                // count and the worst offender, which is all the per-spike
                // line ever really carried.
                _spikeCount++;
                double spikeMs = frameDt * 1000.0;
                if (spikeMs > _worstSpikeMs)
                {
                    _worstSpikeMs = spikeMs;
                    _worstSpikeCoopMs = _sw.Elapsed.TotalMilliseconds;
                }
            }
        }
        _lastFrameTime = now;
        _sw.Restart();
    }

    /// <summary>Name + ms of the subsystem that had the largest single-frame
    /// max this rollup window. Empty string if no subsystem has been
    /// sampled yet.</summary>
    private static string TopSubsystem()
    {
        if (_subMax.Count == 0) return "";
        string topName = "";
        double topMs = 0.0;
        foreach (var kv in _subMax)
        {
            if (kv.Value > topMs) { topMs = kv.Value; topName = kv.Key; }
        }
        return topMs >= SUB_LOG_MIN_MS ? $"{topName}={topMs:F0}ms" : "";
    }

    public static void FrameEnd()
    {
        _sw.Stop();
        double ms = _sw.Elapsed.TotalMilliseconds;
        _sumMs += ms;
        _frames++;
        if (ms > _maxMs) _maxMs = ms;

        float now = Time.unscaledTime;
        if (now >= _nextRollupAt)
        {
            if (_frames > 0 && _maxMs >= ROLLUP_MIN_MAX_MS)
            {
                // Per-subsystem breakdown: show sum (avg × frames) and max
                // for each subsystem, sorted by sum descending. Only emit
                // subsystems whose max exceeded SUB_LOG_MIN_MS so idle
                // sessions stay quiet. This is what pinpoints the culprit
                // when the aggregate "coop layer avg=350ms" is too coarse.
                System.Text.StringBuilder sb = null;
                if (_subMax.Count > 0)
                {
                    // Collect entries with non-trivial cost, sort by max desc.
                    var entries = new System.Collections.Generic.List<(string name, double max, double sum)>();
                    foreach (var kv in _subMax)
                    {
                        if (kv.Value >= SUB_LOG_MIN_MS)
                        {
                            _subSum.TryGetValue(kv.Key, out var s);
                            entries.Add((kv.Key, kv.Value, s));
                        }
                    }
                    if (entries.Count > 0)
                    {
                        entries.Sort((a, b) => b.max.CompareTo(a.max));
                        sb = new System.Text.StringBuilder(" [");
                        for (int i = 0; i < entries.Count; i++)
                        {
                            if (i > 0) sb.Append(' ');
                            // name=maxMs/avgMs (avg = sum / frames)
                            sb.Append($"{entries[i].name}={entries[i].max:F0}/{(entries[i].sum / _frames):F1}ms");
                        }
                        sb.Append(']');
                    }
                }
                string spikes = _spikeCount > 0
                    ? $", spikes={_spikeCount} worst={_worstSpikeMs:F0}ms(coop {_worstSpikeCoopMs:F0}ms)"
                    : "";
                Plugin.Log.LogInfo(
                    $"[CoopPerf] 10s: coop layer avg={_sumMs / _frames:F2} ms/frame, max={_maxMs:F1} ms, frames={_frames}{spikes}{sb}");
            }
            _nextRollupAt = now + ROLLUP_INTERVAL_S;
            _maxMs = 0; _sumMs = 0; _frames = 0;
            _spikeCount = 0; _worstSpikeMs = 0; _worstSpikeCoopMs = 0;
            _subSum.Clear();
            _subMax.Clear();
        }
    }
}
