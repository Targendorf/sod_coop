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
    /// Whether <see cref="_harmony"/> currently has its 66 sync patches
    /// applied. We install lazily on the first <c>OnConnected</c> and
    /// remove on <c>OnDisconnected</c> so single-player world generation
    /// doesn't pay the per-call IL2CPP marshalling cost of patches whose
    /// bodies would early-bail anyway.
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
        //   v1: PatchAll synchronously at plugin load → stable, but SP
        //       world-gen / save-load is ~5x slower because IL2CPP marshals
        //       heavy parameter types on every call regardless of our
        //       `!IsConnected` early-bail.
        //   v2: lazy install on first OnConnected, unpatch on disconnect →
        //       fast SP, but ate a 5-10 min synchronous freeze on click-Host.
        //   v3: progressive (one type per frame) at click-Host → fast SP,
        //       no freeze, BUT MonoMod's IL2CPP detour backend crashed with
        //       a fatal "Internal CLR error 0x80131506" inside
        //       CompileMethodHook. Suspect: Assembly.GetTypes() /
        //       GetCustomAttributes called on a "warm" runtime triggered
        //       JIT compilation that MonoMod was hooking unsafely.
        //
        //   v4 (this): pre-cache the patch type list NOW (cold runtime —
        //       MonoMod state is stable), but DON'T apply yet. The
        //       progressive installer kicks in on SOD.Common's OnAfterLoad
        //       (right after the user finishes loading any save), draining
        //       one type per frame from the cache. This way:
        //         • Save load itself runs without our patches active —
        //           the user gets vanilla load times.
        //         • Patches install in the gameplay phase, with a visible
        //           banner showing progress; the menu / world stay
        //           responsive.
        //         • The fragile reflection (GetTypes / GetCustomAttributes)
        //           runs ONCE at plugin load on a cold JIT, not at game-
        //           time when MonoMod's hook state can be unstable.
        Log.LogInfo("Initializing Harmony (deferred-progressive install)...");
        _harmony = new Harmony(PluginInfo.PLUGIN_GUID);

        var swScan = System.Diagnostics.Stopwatch.StartNew();
        try
        {
            var asm = Assembly.GetExecutingAssembly();
            foreach (var t in asm.GetTypes())
            {
                if (t.GetCustomAttributes(typeof(HarmonyPatch), inherit: true).Length > 0)
                    _cachedPatchTypes.Add(t);
            }
        }
        catch (System.Exception ex)
        {
            Log.LogError($"Cold-JIT patch-type scan failed: {ex}");
        }
        swScan.Stop();

        Log.LogInfo($"Pre-cached {_cachedPatchTypes.Count} Harmony patch type(s) in {swScan.Elapsed.TotalSeconds:F2}s. Install starts on first save load.");
    }

    // ─── Deferred progressive installer ──────────────────────────────────
    private static readonly System.Collections.Generic.List<System.Type> _cachedPatchTypes = new();
    private static readonly System.Collections.Generic.Queue<System.Type> _pendingPatchTypes = new();
    private static int  _totalPatchTypesQueued;
    private static bool _patchInstallerRunning;
    private static System.Diagnostics.Stopwatch _installSw;

    public static bool IsInstallingPatches => _patchInstallerRunning;
    public static int  PatchTypesRemaining => _pendingPatchTypes.Count;
    public static int  PatchTypesTotal     => _totalPatchTypesQueued;

    /// <summary>
    /// Called from the SOD.Common <c>OnAfterLoad</c> hook the first time
    /// the user finishes loading a save in this session. Queues every
    /// pre-cached patch type for progressive install on the main update
    /// loop; <see cref="DrainPatchInstaller"/> processes one per frame.
    /// Idempotent — subsequent saves don't re-queue.
    /// </summary>
    public static void StartProgressiveInstall()
    {
        if (_patchesApplied || _patchInstallerRunning) return;
        if (_cachedPatchTypes.Count == 0)
        {
            Log.LogWarning("StartProgressiveInstall: no cached patch types — was InitializeHarmony skipped?");
            return;
        }
        _pendingPatchTypes.Clear();
        foreach (var t in _cachedPatchTypes) _pendingPatchTypes.Enqueue(t);
        _totalPatchTypesQueued = _pendingPatchTypes.Count;
        _patchInstallerRunning = true;
        _installSw = System.Diagnostics.Stopwatch.StartNew();
        Log.LogInfo($"Progressive Harmony install: queued {_totalPatchTypesQueued} type(s) — one per frame.");
    }

    /// <summary>Called every frame from <c>CoopUpdateRunner.Update</c>.</summary>
    public static void DrainPatchInstaller()
    {
        if (!_patchInstallerRunning) return;
        var inst = Instance;
        if (inst == null || inst._harmony == null) { _patchInstallerRunning = false; return; }

        if (_pendingPatchTypes.Count == 0)
        {
            _patchInstallerRunning = false;
            _patchesApplied = true;
            int actuallyApplied = 0;
            try { actuallyApplied = inst._harmony.GetPatchedMethods().Count(); } catch { }
            double dt = _installSw?.Elapsed.TotalSeconds ?? 0;
            Log.LogInfo($"Progressive Harmony install: done. {actuallyApplied} patch method(s) live (across {_totalPatchTypesQueued} types) in {dt:F2}s.");
            return;
        }

        var t = _pendingPatchTypes.Dequeue();
        try
        {
            inst._harmony.CreateClassProcessor(t).Patch();
        }
        catch (System.Exception ex)
        {
            // Log and continue — one bad patch shouldn't doom the rest.
            Log.LogWarning($"Progressive patcher: skipped {t?.FullName} ({ex.GetType().Name}: {ex.Message}).");
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
            // Drain at most one Harmony patch per frame so installing 67
            // IL2CPP-marshalled patches doesn't freeze the UI when the user
            // clicks Host / Join.
            Plugin.DrainPatchInstaller();

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
