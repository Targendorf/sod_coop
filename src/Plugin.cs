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
