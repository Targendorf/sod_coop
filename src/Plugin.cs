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

    /// <summary>One-shot UnpatchSelf. Called from SodCommonBridge.OnBeforeLoad
    /// and from WorldReadyGate.OnWorldUnready. Idempotent — once paused,
    /// stays paused for the session.</summary>
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
            Log.LogInfo($"Harmony patches PAUSED (one-shot, no resume) — UnpatchSelf in {sw.Elapsed.TotalSeconds:F2}s. " +
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
