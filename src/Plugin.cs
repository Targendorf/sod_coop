using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using System.Linq;
using System.Reflection;
using SoDCoop.Network;
using SoDCoop.Sync;
using SoDCoop.Player;
using SoDCoop.UI;
using SoDCoop.Integration;
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
    /// True after the synchronous PatchAll at plugin load (v5 architecture).
    /// Set once and never flipped — patches are installed for the lifetime
    /// of the process; save-load fast-bails patch bodies via
    /// SoDCoop.Sync.SyncGate.IsOpen instead of unpatching/re-patching
    /// (which corrupts trampolines, see commit history pre-d030363).
    /// </summary>
    private static bool _patchesApplied;
    
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
        Log.LogInfo("Initializing Harmony patches at plugin load...");
        _harmony = new Harmony(PluginInfo.PLUGIN_GUID);

        var sw = System.Diagnostics.Stopwatch.StartNew();
        _harmony.PatchAll(Assembly.GetExecutingAssembly());
        sw.Stop();
        _patchesApplied = true;
        Log.LogInfo($"Applied {_harmony.GetPatchedMethods().Count()} Harmony patches at plugin load in {sw.Elapsed.TotalSeconds:F2}s.");

        // World generation (new game) and save-load BOTH cost ~5x with patches
        // attached due to IL2CPP wrapper trampoline marshalling on every call
        // to a patched method during SoD's heavy init burst. Save-load fires
        // SOD.Common.OnBeforeLoad which we'd hook for Pause — but new-game
        // creation doesn't fire that event, so we'd pay full wrapper cost.
        //
        // Instead: pause IMMEDIATELY after the install. Patches are pre-built
        // (Harmony state set up, native detours installed by Dobby) but
        // logically off — wrappers become near-passthrough.
        //
        // Resume fires when the WORLD becomes ready (covers both new-game and
        // save-load paths) AND a 60s post-ready cool-down elapses AND the
        // user has produced at least one input. See ScheduleResume for the
        // gate logic.
        PausePatchesForLoad();

        SoDCoop.Sync.WorldReadyGate.OnWorldReady += OnWorldReadyForResume;
        SoDCoop.Sync.WorldReadyGate.OnWorldUnready += OnWorldUnreadyForRePause;
    }

    /// <summary>WorldReadyGate observed the world becoming live. Schedule a
    /// gated Resume — patches re-attach once the post-ready cool-down + first
    /// user input gate are satisfied. No-op if patches aren't paused
    /// (e.g. someone already resumed).</summary>
    private static void OnWorldReadyForResume()
    {
        try
        {
            if (!IsPatchPaused) return;
            Log.LogInfo("[Resume] WorldReady observed — scheduling Resume.");
            ScheduleResume();
        }
        catch (System.Exception ex) { Log.LogError($"OnWorldReadyForResume: {ex}"); }
    }

    /// <summary>World went away (player returned to menu / between saves).
    /// If patches are currently active, pause them again so the next world
    /// load starts from a clean paused state. If already paused (e.g. user
    /// went to menu before Resume gates ever fired), no-op.</summary>
    private static void OnWorldUnreadyForRePause()
    {
        try
        {
            if (IsPatchPaused) return;
            Log.LogInfo("[Resume] WorldUnready observed — re-pausing patches for next load.");
            PausePatchesForLoad();
        }
        catch (System.Exception ex) { Log.LogError($"OnWorldUnreadyForRePause: {ex}"); }
    }

    // ─── Patch lifecycle: Pause + Smart Resume ───────────────────────────
    //
    // Save-load with patches attached costs 200s+ wall-clock because IL2CPP
    // wrapper trampolines marshal args on every call. To make save-load
    // tolerable we UnpatchSelf on OnBeforeLoad — patches are attached to
    // SoD's heaviest restoration methods, but UnpatchSelf nominally clears
    // HarmonyX's patch records. (Whether it actually undoes the native
    // detour is debatable; empirically save-load returns to ~50s, so it's
    // working enough.)
    //
    // Resume is deferred. The previous "Resume 2s after OnAfterLoad" caused
    // trampoline corruption because SoD's post-load init burst keeps running
    // for 5+ minutes — methods re-detoured while on the active call stack
    // froze the game. New design: Resume only fires when BOTH:
    //   1. 60+ seconds elapsed since OnAfterLoad (init-burst cool-down)
    //   2. ≥1 user input observed since WorldReady (game is interactive)
    //
    // If this still freezes empirically, the next iteration will spread the
    // re-PatchAll across 10 seconds (1 patch per 200ms) so at any moment
    // only one method is being re-detoured.

    public static bool IsPatchPaused { get; private set; }

    /// <summary>Wall-clock at OnAfterLoad; the 60s delay is measured from here.</summary>
    private static float _resumeEarliestAt;

    /// <summary>True once user input has been observed after WorldReady.
    /// Reset on next OnBeforeLoad.</summary>
    private static bool _userInputSeenSinceReady;

    /// <summary>Set true by ScheduleResume; cleared by DrainPendingResume on success.</summary>
    private static bool _resumePending;

    /// <summary>Counter for unique Harmony instance ids (HarmonyX caches state per id;
    /// reusing after UnpatchSelf double-attaches trampolines).</summary>
    private static int _harmonySessionCounter;

    /// <summary>Called from SodCommonBridge.OnBeforeLoad. Removes all Harmony
    /// patches so SoD's save-load runs at near-vanilla speed.</summary>
    public static void PausePatchesForLoad()
    {
        if (IsPatchPaused) return;
        var inst = Instance;
        if (inst?._harmony == null) return;
        try
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            inst._harmony.UnpatchSelf();
            sw.Stop();
            IsPatchPaused = true;
            // Reset gates so the next ScheduleResume waits fresh.
            _resumePending = false;
            _userInputSeenSinceReady = false;
            _resumeEarliestAt = 0f;
            Log.LogInfo($"Harmony patches PAUSED — UnpatchSelf in {sw.Elapsed.TotalSeconds:F2}s.");
        }
        catch (System.Exception ex)
        {
            Log.LogError($"PausePatchesForLoad failed: {ex}");
        }
    }

    /// <summary>Called from SodCommonBridge.OnAfterLoad. Sets up the gates.
    /// Actual Resume fires from DrainPendingResume once gates open.</summary>
    public static void ScheduleResume()
    {
        if (!IsPatchPaused) return;
        _resumeEarliestAt = UnityEngine.Time.unscaledTime + 60f;
        _resumePending = true;
        Log.LogInfo($"Patch resume scheduled. Gates: " +
                    $"earliestAt={_resumeEarliestAt:F1}s (T+60s) AND user input post-WorldReady. " +
                    $"SyncGate stays closed until Resume completes.");
    }

    /// <summary>Called every frame from CoopUpdateRunner.Update. Watches for
    /// the gates; fires Resume when both are open.</summary>
    public static void DrainPendingResume()
    {
        if (!_resumePending) return;

        // Gate 1: detect any user input post-WorldReady.
        if (!_userInputSeenSinceReady && SoDCoop.Sync.WorldReadyGate.IsWorldReady)
        {
            try
            {
                if (UnityEngine.Input.anyKeyDown
                    || UnityEngine.Input.GetMouseButtonDown(0)
                    || UnityEngine.Input.GetMouseButtonDown(1))
                {
                    _userInputSeenSinceReady = true;
                    Log.LogInfo($"[Resume gate] First user input observed at " +
                                $"{UnityEngine.Time.unscaledTime:F1}s — input gate open.");
                }
            }
            catch { /* Input may throw at unexpected init points; swallow. */ }
        }

        // Both gates: time AND input.
        if (UnityEngine.Time.unscaledTime < _resumeEarliestAt) return;
        if (!_userInputSeenSinceReady) return;

        _resumePending = false;
        ResumePatchesAfterLoad();
        SoDCoop.Sync.SyncGate.Open();
    }

    /// <summary>Re-applies every patch on a fresh Harmony instance.
    /// HarmonyX state is per-instance — reusing the original after
    /// UnpatchSelf produced double-detours; a fresh id avoids that.</summary>
    public static void ResumePatchesAfterLoad()
    {
        if (!IsPatchPaused) return;
        var inst = Instance;
        if (inst == null) { IsPatchPaused = false; return; }
        try
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            _harmonySessionCounter++;
            inst._harmony = new HarmonyLib.Harmony($"{PluginInfo.PLUGIN_GUID}.session{_harmonySessionCounter}");
            inst._harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
            sw.Stop();
            IsPatchPaused = false;
            Log.LogInfo($"Harmony patches RESUMED — fresh instance #{_harmonySessionCounter}, " +
                        $"PatchAll in {sw.Elapsed.TotalSeconds:F2}s " +
                        $"({inst._harmony.GetPatchedMethods().Count()} live).");
        }
        catch (System.Exception ex)
        {
            Log.LogError($"ResumePatchesAfterLoad failed: {ex}");
            // Leave IsPatchPaused = true so subsequent attempts no-op.
        }
    }

    private void InitializeSystems()
    {
        Log.LogInfo($"Stable client GUID: {SoDCoop.Player.CharacterIdentity.ClientGuid}");

        Log.LogInfo("Initializing network manager...");
        NetworkManager.Initialize();
        
        Log.LogInfo("Initializing sync manager...");
        SyncManager.Initialize();
        
        Log.LogInfo("Initializing world-ready gate...");
        WorldReadyGate.Initialize();

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
            string ip   = NetworkManager.LastHostIp;
            int    port = NetworkManager.LastHostPort;
            if (string.IsNullOrEmpty(ip) || port <= 0) return;

            // Pull host's display name out of the player roster (if any).
            string hostName = "Host";
            foreach (var p in NetworkManager.Players.Values)
            {
                if (p != null && p.IsHost && !string.IsNullOrEmpty(p.PlayerName))
                {
                    hostName = p.PlayerName;
                    break;
                }
            }
            SoDCoop.Network.SessionStore.Record(ip, port, hostName);
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
        try
        {
            Plugin.DrainPendingResume();   // ← Smart Resume gate check
            WorldReadyGate.Tick();
            NetworkManager.Update();
            SyncManager.Update();
            CoopUI.Update();
            PingSystem.Update();
            SoDCoop.Sync.InventorySync.Update();
            SoDCoop.Sync.HostStatusSync.Update();
            SoDCoop.Sync.PlayerSuspicionSync.Update();
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error in CoopUpdateRunner.Update: {ex}");
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
