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
        Log.LogInfo("Initializing Harmony (lazy-patch mode)...");
        _harmony = new Harmony(PluginInfo.PLUGIN_GUID);

        // We do NOT call PatchAll here. The 66 sync-related patches all
        // perform a `!NetworkManager.IsConnected` early-bail in their
        // bodies — but in IL2CPP, Harmony marshals every declared
        // parameter (e.g. `Il2CppSystem.Collections.Generic.List<DataKey>`
        // for Evidence.SetNote) BEFORE the body runs. During SoD's
        // single-player new-world generation those methods are called
        // tens of thousands of times, and the cumulative marshalling
        // overhead is enough to balloon a 3-minute world-gen into 15+
        // minutes (verified by user report).
        //
        // Instead, defer PatchAll to the moment we actually start
        // hosting or successfully join — when at least one of those
        // patches has work to do — and unpatch on disconnect so a
        // subsequent world reload returns to native speed. See
        // `EnsurePatchesApplied` / `RemovePatches`.
        NetworkManager.OnConnected    += EnsurePatchesApplied;
        NetworkManager.OnDisconnected += RemovePatchesOnDisconnect;

        Log.LogInfo("Harmony ready — patches will install on first connect / host.");
    }

    // ─── Progressive patch installer ─────────────────────────────────────
    // PatchAll across 67 IL2CPP-marshalled patches blocks the main thread
    // for many seconds (the SideJob constructor patch in particular hits a
    // failed-init retry loop that's even slower). Doing it synchronously
    // on the OnConnected event froze the game for minutes after clicking
    // Host. Instead we drain a queue one type per frame from the main
    // Update loop — the user just sees a brief log of progress and the
    // menu stays interactive throughout.

    private static readonly System.Collections.Generic.Queue<System.Type> _pendingPatchTypes = new();
    private static int _totalPatchTypesQueued;
    private static bool _patchInstallerRunning;

    // ─── Public progress accessors for the install-progress banner UI ────
    /// <summary>True while the progressive patcher is mid-flight. UI uses
    /// this to gate the loading-bar banner.</summary>
    public static bool IsInstallingPatches => _patchInstallerRunning;

    /// <summary>Number of patch types still pending. Decreases each frame
    /// as <see cref="DrainPatchInstaller"/> drains the queue.</summary>
    public static int PatchTypesRemaining => _pendingPatchTypes.Count;

    /// <summary>Total number of patch types queued at the start of the
    /// current install run. Banner shows X / Total.</summary>
    public static int PatchTypesTotal => _totalPatchTypesQueued;

    /// <summary>
    /// Kick off the progressive patcher. Idempotent; subsequent calls while
    /// installation is still draining are no-ops. After full drain, sets
    /// <see cref="_patchesApplied"/> = true.
    /// </summary>
    private void EnsurePatchesApplied()
    {
        if (_patchesApplied || _harmony == null) return;
        if (_patchInstallerRunning) return;
        try
        {
            // Discover every type carrying [HarmonyPatch] in our assembly.
            var asm = Assembly.GetExecutingAssembly();
            int queued = 0;
            foreach (var t in asm.GetTypes())
            {
                if (t.GetCustomAttributes(typeof(HarmonyPatch), inherit: true).Length > 0)
                {
                    _pendingPatchTypes.Enqueue(t);
                    queued++;
                }
            }
            _totalPatchTypesQueued = queued;
            _patchInstallerRunning = queued > 0;
            Log.LogInfo($"Progressive Harmony patcher: queued {queued} patch type(s) — installing one per frame.");
        }
        catch (System.Exception ex)
        {
            Log.LogError($"EnsurePatchesApplied (queueing): {ex}");
            _patchInstallerRunning = false;
        }
    }

    /// <summary>
    /// Drains one patch type per frame from the queue. Called from
    /// <see cref="CoopUpdateRunner.Update"/>. When the queue empties, marks
    /// <see cref="_patchesApplied"/> true so other code paths know syncing
    /// is fully wired up. Errors on individual patches are logged and
    /// skipped so a single bad signature can't stall the entire install.
    /// </summary>
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
            Log.LogInfo($"Progressive Harmony patcher: done. {actuallyApplied} patch method(s) live (across {_totalPatchTypesQueued} types).");
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

    private void RemovePatchesOnDisconnect(string _) => RemovePatches();

    private void RemovePatches()
    {
        // Always reset the progressive-installer state so a half-finished
        // install on a previous connect doesn't keep draining patches into
        // a now-disconnected session.
        _pendingPatchTypes.Clear();
        _patchInstallerRunning = false;

        if (_harmony == null) return;
        try
        {
            _harmony.UnpatchSelf();
            if (_patchesApplied) Log.LogInfo("Removed Harmony sync patches (disconnected).");
            _patchesApplied = false;
        }
        catch (System.Exception ex)
        {
            Log.LogError($"UnpatchSelf on disconnect failed: {ex}");
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
