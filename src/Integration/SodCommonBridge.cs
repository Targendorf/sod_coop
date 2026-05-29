using System;
using System.Diagnostics;

namespace SoDCoop.Integration;

/// <summary>
/// Thin wrapper over SOD.Common (Venomaus). All access is reflection-soft via try/catch
/// so the mod still loads if SOD.Common is missing or the API changes.
///
/// Currently used for two things:
///   1. Diagnostic timing of save load / save write (wall-clock so we can
///      see the actual cost of our Harmony patches during the bulk-init
///      phase, when "since plugin load" timestamps are dominated by user
///      idle time on the title screen).
///   2. Future: hook OnAfterSave on host → ship save file to clients;
///      hook OnBeforeLoad on client → swap in the host's save.
/// </summary>
public static class SodCommonBridge
{
    public static bool IsAvailable { get; private set; }
    private static bool _hooked;

    /// <summary>Wall-clock seconds the most recent OnBeforeLoad → OnAfterLoad
    /// span took. Useful for narrowing down "is save load the slow bit, or
    /// something else?" without staring at relative log timestamps.</summary>
    public static double LastLoadSeconds { get; private set; }
    public static double LastSaveSeconds { get; private set; }

    /// <summary>True between OnBeforeLoad and OnAfterLoad. WorldReadyGate
    /// reads this to decide whether to log the in-flight load duration when
    /// world ready trips, since SOD.Common's OnAfterLoad doesn't reliably
    /// fire at the same point the world becomes playable.</summary>
    public static bool IsLoadInFlight => _loadSw.IsRunning;

    /// <summary>Wall-clock seconds since OnBeforeLoad, while a load is in flight.</summary>
    public static double CurrentLoadSeconds => _loadSw.Elapsed.TotalSeconds;

    private static readonly Stopwatch _loadSw = new();
    private static readonly Stopwatch _saveSw = new();

    public static void Initialize()
    {
        if (_hooked) return;
        try
        {
            // Touching Lib triggers SOD.Common static init; if the DLL isn't loaded
            // we'll catch TypeLoadException / FileNotFoundException here.
            var lib = SOD.Common.Lib.SaveGame;
            if (lib == null)
            {
                Plugin.Log.LogWarning("SOD.Common: Lib.SaveGame is null, skipping hooks.");
                return;
            }

            lib.OnBeforeLoad += (sender, args) =>
            {
                try
                {
                    _loadSw.Restart();
                    // Close the gate so any in-flight patch body fast-bails.
                    SoDCoop.Sync.SyncGate.Close();
                    // Wipe in-memory ZDO state — the host's authoritative ZDO
                    // registry is rebuilt from the saved disk file (if any) +
                    // first-tick poller diffs after world becomes ready.
                    SoDCoop.Zdo.ZdoMan.Clear();
                    // Reset poller baselines so the first post-load tick doesn't
                    // emit a stale state diff (e.g. raised flag carried over from
                    // pre-load session).
                    SoDCoop.Zdo.Pollers.LocalPlayerPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.PlayerInputPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.PauseStatePoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.MoneyPoller.ResetBaseline();
                    // Round 2 baselines.
                    SoDCoop.Zdo.Pollers.WeatherPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.ElevatorPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.EvidenceCreationPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.CaseStatusPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.SideJobPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.CaseBoardPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.NpcDamagePoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.MurderPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.MurderDiscoveryPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.HeldItemPoller.ResetBaseline();
                    // Round 8 (2026-05-08): scan caches for the heavy
                    // GetComponentInChildren-based pollers. Without these
                    // resets, save-load would leave the caches pointing at
                    // destroyed Unity components → silent dropouts on the
                    // next tick. Cache rebuild on first post-load tick.
                    SoDCoop.Zdo.Pollers.LightPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.ComputerStatePoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.SwitchPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.FingerprintPoller.ResetBaseline();
                    // DoorPoller now caches (id, door) pairs rebuilt on count
                    // change — reset clears the cache so it doesn't point at
                    // doors destroyed by the world reload.
                    SoDCoop.Zdo.Pollers.DoorPoller.ResetBaseline();
                    // UnpatchSelf so SoD's save-load runs without IL2CPP wrapper
                    // trampoline marshalling cost on patched methods. Empirically
                    // this brought save-load from 200s+ → ~50s in Phase 1 logs.
                    // Re-PatchAll happens via Plugin.SchedulePatchResume +
                    // gradual install after WorldReady + 60s cool-down + first
                    // user input (see Plugin.cs).
                    Plugin.PausePatchesForLoad();
                    Plugin.Log.LogInfo($"[SODCommon] OnBeforeLoad: {args?.FilePath} — timer started, gate closed, ZdoMan cleared, patches paused");
                }
                catch (Exception ex) { Plugin.Log.LogError($"OnBeforeLoad handler: {ex.Message}"); }
            };
            lib.OnAfterLoad += (sender, args) =>
            {
                try
                {
                    _loadSw.Stop();
                    LastLoadSeconds = _loadSw.Elapsed.TotalSeconds;
                    Plugin.Log.LogInfo($"[SODCommon] OnAfterLoad: {args?.FilePath} — save-load wall-clock {LastLoadSeconds:F2}s");
                    // Try to load the persisted ZdoMan dump for this save (if any).
                    SoDCoop.Zdo.ZdoMan.LoadFromDisk();
                    // Schedule patch Resume — fires when both gates open
                    // (60s post-OnAfterLoad cool-down + first user input).
                    // SyncGate stays CLOSED until Resume completes — every
                    // patch body checks it as the first instruction.
                    Plugin.SchedulePatchResume();
                }
                catch (Exception ex) { Plugin.Log.LogError($"OnAfterLoad handler: {ex.Message}"); }
            };
            lib.OnBeforeSave += (sender, args) =>
            {
                try
                {
                    _saveSw.Restart();
                    Plugin.Log.LogInfo($"[SODCommon] OnBeforeSave: {args?.FilePath} — timer started");
                }
                catch (Exception ex) { Plugin.Log.LogError($"OnBeforeSave handler: {ex.Message}"); }
            };
            lib.OnAfterSave += (sender, args) =>
            {
                try
                {
                    _saveSw.Stop();
                    LastSaveSeconds = _saveSw.Elapsed.TotalSeconds;
                    Plugin.Log.LogInfo($"[SODCommon] OnAfterSave: {args?.FilePath} — save-write wall-clock {LastSaveSeconds:F2}s");
                    // Persist ZDO registry to disk alongside SoD's save (host only).
                    if (SoDCoop.Network.NetworkManager.IsHost)
                    {
                        try { SoDCoop.Zdo.ZdoMan.SaveToDisk(); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"ZdoMan.SaveToDisk: {ex.Message}"); }
                    }
                }
                catch (Exception ex) { Plugin.Log.LogError($"OnAfterSave handler: {ex.Message}"); }
            };

            IsAvailable = true;
            _hooked = true;
            Plugin.Log.LogInfo("SOD.Common bridge initialized (SaveGame hooks armed).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"SOD.Common not available or API mismatch: {ex.GetType().Name}: {ex.Message}");
            IsAvailable = false;
        }
    }
}
