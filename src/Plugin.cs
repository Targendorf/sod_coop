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
    }

    private static void OnWorldReadyForResume()
    {
        try
        {
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
            if (IsPatchPaused) return;
            Log.LogInfo("[Resume] WorldUnready observed — re-pausing patches for next load.");
            PausePatchesForLoad();
        }
        catch (System.Exception ex) { Log.LogError($"OnWorldUnreadyForRePause: {ex}"); }
    }

    // ─── Pause/Resume + gradual re-PatchAll (revived from archive/phase1-gradual-resume) ─
    //
    // ZDO spec sec 5.2 said "install once, never re-install — body-bail handles it".
    // That premise turned out to be wrong: `SyncGate.IsOpen=false` body-bail does NOT
    // eliminate IL2CPP wrapper trampoline marshalling cost on patched methods, so
    // save-load on a heavy save still took 200+ s with patches attached. Vanilla SoD
    // loads the same save fast → patches are the dominant overhead even when their
    // bodies bail in <1µs.
    //
    // Trade-off accepted by reviving this path:
    //   • Save-load: fast (Phase 1 reported ~50s vs 200+s).
    //   • Risk:   re-PatchAll on second save-load may stack Dobby detours and crash
    //             on ESC after re-load (the trampoline-corruption issue ZDO spec
    //             tried to eliminate). Mitigation: gradual install at 1 patch class
    //             per 100ms after `WorldReady + 60s + first user input` so init burst
    //             is fully done before any detour is re-installed.
    //   • If the second save-load DOES crash, the user reverts to plain
    //     archive/phase1-gradual-resume branch which has the same code without ZDO
    //     adds.

    public static bool IsPatchPaused { get; private set; }

    /// <summary>Wall-clock at OnAfterLoad; the 60s delay is measured from here.</summary>
    private static float _resumeEarliestAt;

    /// <summary>True once user input has been observed after WorldReady.</summary>
    private static bool _userInputSeenSinceReady;

    /// <summary>Set true by SchedulePatchResume; cleared by DrainPendingResume on success.</summary>
    private static bool _resumePending;

    /// <summary>Counter for unique Harmony instance ids (HarmonyX caches state per id;
    /// reusing after UnpatchSelf double-attaches trampolines).</summary>
    private static int _harmonySessionCounter;

    private const float GRADUAL_INTERVAL_S = 0.1f;
    private static System.Collections.Generic.List<System.Type> _gradualTypes;
    private static int _gradualIndex;
    private static float _gradualNextAt;
    private static bool _gradualResumeInProgress;

    /// <summary>Called from SodCommonBridge.OnBeforeLoad. UnpatchSelf so SoD's
    /// save-load runs at near-vanilla speed.</summary>
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

    /// <summary>Called from SodCommonBridge.OnAfterLoad. Sets the gates;
    /// actual Resume fires from DrainPendingResume on subsequent frames.</summary>
    public static void SchedulePatchResume()
    {
        if (!IsPatchPaused) return;
        _resumeEarliestAt = UnityEngine.Time.unscaledTime + 60f;
        _resumePending = true;
        Log.LogInfo($"Patch resume scheduled. Gates: " +
                    $"earliestAt={_resumeEarliestAt:F1}s (T+60s) AND user input post-WorldReady. " +
                    $"SyncGate stays closed until Resume completes.");
    }

    /// <summary>Called every frame from CoopUpdateRunner.Update. Watches the
    /// gates; fires gradual Resume when both are open.</summary>
    public static void DrainPendingResume()
    {
        if (!_resumePending && !_gradualResumeInProgress) return;

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

        if (UnityEngine.Time.unscaledTime < _resumeEarliestAt) return;
        if (!_userInputSeenSinceReady) return;

        if (_gradualResumeInProgress)
        {
            DrainGradualResume(UnityEngine.Time.unscaledTime);
            return;
        }

        if (_resumePending)
        {
            _resumePending = false;
            ResumePatchesAfterLoad();
        }
    }

    /// <summary>Kicks off the gradual install — one Harmony class processor
    /// per 100ms tick — to avoid the trampoline corruption that crashed
    /// re-attaching all 49 detours at once.</summary>
    public static void ResumePatchesAfterLoad()
    {
        if (!IsPatchPaused) return;
        var inst = Instance;
        if (inst == null) { IsPatchPaused = false; return; }

        try
        {
            _harmonySessionCounter++;
            inst._harmony = new HarmonyLib.Harmony($"{PluginInfo.PLUGIN_GUID}.session{_harmonySessionCounter}");

            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            _gradualTypes = new System.Collections.Generic.List<System.Type>();
            foreach (var t in asm.GetTypes())
            {
                bool hasAttr = false;
                try
                {
                    hasAttr = t.GetCustomAttributes(typeof(HarmonyLib.HarmonyPatch), inherit: false).Length > 0
                          || t.GetCustomAttributes(typeof(HarmonyLib.HarmonyPatch), inherit: true).Length  > 0;
                }
                catch { }
                if (hasAttr) _gradualTypes.Add(t);
            }

            _gradualIndex = 0;
            _gradualNextAt = UnityEngine.Time.unscaledTime;
            _gradualResumeInProgress = true;
            Log.LogInfo($"Gradual Resume started: {_gradualTypes.Count} patch classes to re-attach " +
                        $"at {GRADUAL_INTERVAL_S * 1000:F0}ms intervals " +
                        $"(estimated total {_gradualTypes.Count * GRADUAL_INTERVAL_S:F1}s). " +
                        $"Fresh Harmony id: {inst._harmony.Id}");
        }
        catch (System.Exception ex)
        {
            Log.LogError($"ResumePatchesAfterLoad init failed: {ex}");
            IsPatchPaused = false;
            _gradualResumeInProgress = false;
        }
    }

    /// <summary>Per-frame driver for gradual Resume. Attaches at most ONE
    /// patch class per call, throttled to <see cref="GRADUAL_INTERVAL_S"/>.</summary>
    private static bool DrainGradualResume(float now)
    {
        if (!_gradualResumeInProgress) return false;
        if (now < _gradualNextAt) return true;

        var inst = Instance;
        if (inst?._harmony == null || _gradualTypes == null)
        {
            _gradualResumeInProgress = false;
            IsPatchPaused = false;
            return false;
        }

        if (_gradualIndex >= _gradualTypes.Count)
        {
            _gradualResumeInProgress = false;
            IsPatchPaused = false;
            int liveCount = 0;
            try { liveCount = inst._harmony.GetPatchedMethods().Count(); } catch { }
            Log.LogInfo($"Gradual Resume COMPLETE — {_gradualIndex} classes attached, " +
                        $"{liveCount} live patched methods. Session id: {inst._harmony.Id}");
            _gradualTypes = null;
            SoDCoop.Sync.SyncGate.Open();
            return false;
        }

        var type = _gradualTypes[_gradualIndex++];
        try
        {
            var processor = inst._harmony.CreateClassProcessor(type);
            processor.Patch();
        }
        catch (System.Exception ex)
        {
            Log.LogWarning($"Gradual Resume: failed to attach {type.FullName}: {ex.Message}");
        }
        _gradualNextAt = now + GRADUAL_INTERVAL_S;
        return true;
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

        Log.LogInfo("Initializing ZdoMan (unified replication)...");
        ZdoMan.Initialize();
        ZdoBootstrap.RegisterAll();
        // Wipe in-memory ZDO registry between sessions so a return-to-menu
        // doesn't carry stale state into the next world.
        WorldReadyGate.OnWorldUnready += () =>
        {
            try { ZdoMan.Clear(); } catch (System.Exception ex) { Log.LogWarning($"ZdoMan.Clear: {ex.Message}"); }
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
            Plugin.DrainPendingResume();   // ← Pause/Resume gate check (revived from archive)
            WorldReadyGate.Tick();
            NetworkManager.Update();
            SyncManager.Update();
            CoopUI.Update();
            PingSystem.Update();
            SoDCoop.Sync.InventorySync.Update();
            SoDCoop.Sync.HostStatusSync.Update();
            SoDCoop.Sync.PlayerSuspicionSync.Update();
            // ZDO unified delta-flush: collects every dirty ZDO into one
            // batched packet at 10 Hz and ships compressed (zstd-3) when
            // payload exceeds 100 B. Replaces ~30 per-feature Broadcast
            // call sites once Phase H is complete.
            SoDCoop.Zdo.ZdoMan.TickDeltaFlush(Time.unscaledTime);
            // Drive registered host-side pollers (doors, lights, citizens, …).
            SoDCoop.Zdo.ZdoPollerHost.Tick(Time.unscaledTime);
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
