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
                    // Per-citizen diff baselines. Without these, a return-to-
                    // menu → re-host of the same seed left these dictionaries
                    // holding humanID→state entries pointing at the PREVIOUS
                    // world's (now destroyed) citizens. IL2CPP null-equality
                    // made every probe silently skip, so citizen anim /
                    // speech / vitals sync went dark for the whole session
                    // with zero errors logged. CitizenRosterCache.Reset
                    // below already covered the shared roster snapshot, but
                    // each poller keeps its OWN diff state on top of it.
                    SoDCoop.Zdo.Pollers.CitizenAnimationPoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.CitizenStatePoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.SpeechBubblePoller.ResetBaseline();
                    SoDCoop.Zdo.Pollers.SocialCreditPoller.ResetBaseline();
                    // Network-driven citizens: drop the driven set before SoD
                    // destroys the citizens. Otherwise the dictionary holds
                    // destroyed Human refs, and the AI re-enable on release
                    // would be aimed at dead components.
                    SoDCoop.Sync.CitizenPositionSync.Reset();
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
                    // Shared citizen roster cache (used by all per-citizen
                    // pollers) — same stale-reference concern as DoorPoller.
                    SoDCoop.Zdo.Pollers.CitizenRosterCache.Reset();
                    // UnpatchSelf so SoD's save-load runs without IL2CPP wrapper
                    // trampoline marshalling cost on patched methods. Empirically
                    // this brought save-load from 200s+ → ~50s in Phase 1 logs.
                    // Re-PatchAll happens via Plugin.SchedulePatchResume +
                    // gradual install after WorldReady + 60s cool-down + first
                    // user input (see Plugin.cs).
                    Plugin.PausePatchesForLoad();
                    Plugin.Log.LogInfo($"[SODCommon] OnBeforeLoad: {args?.FilePath} — timer started, gate closed, ZdoMan cleared, patches paused");
                    // Phase 1: capture save size + hash before SoD reads it.
                    LogSaveTransferDiagnostics("OnBeforeLoad", args?.FilePath);
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
                    // Phase 1: confirm the file that was just loaded (size
                    // post-write may differ from pre-load if SoD rewrites it).
                    LogSaveTransferDiagnostics("OnAfterLoad", args?.FilePath);

                    // Capture the loaded save's path as a Save-Transfer source.
                    // Loading does not rewrite the file, so it is still a valid
                    // (if not live-current) snapshot of this world. Marked
                    // NOT-fresh so SendSaveToPeer can say so in the log and the
                    // opt-in force-save path knows to re-capture.
                    //
                    // Without this, the common "load a save → host" flow left
                    // HostSavePath null and every join silently fell back to
                    // share-code.
                    try
                    {
                        string loadedPath = args?.FilePath;
                        if (!string.IsNullOrEmpty(loadedPath))
                        {
                            SoDCoop.Sync.SaveTransfer.HostSavePath = loadedPath;
                            SoDCoop.Sync.SaveTransfer.HostSavePathIsFresh = false;
                            Plugin.Log.LogInfo($"[SaveTransfer] host save source set from load: '{loadedPath}' (not live-current).");
                        }
                    }
                    catch { /* non-fatal — SendSaveToPeer degrades to share-code */ }
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
                    // Phase 1: capture freshly-written save size + hash. This
                    // is the file Save-Transfer would ship to clients, so its
                    // size + format shape calibrates the chunked channel.
                    LogSaveTransferDiagnostics("OnAfterSave", args?.FilePath);
                    // Persist ZDO registry to disk alongside SoD's save (host only).
                    if (SoDCoop.Network.NetworkManager.IsHost)
                    {
                        try { SoDCoop.Zdo.ZdoMan.SaveToDisk(); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"ZdoMan.SaveToDisk: {ex.Message}"); }

                        // Capture the host's save file path so Save-Transfer
                        // (Mode 3) has a file to ship to joining clients.
                        // Set on every save — the path is stable across saves
                        // for the same city, but a save-as / new-city would
                        // change it. Without this, SendSaveToPeer would have
                        // no file to read and fall back to share-code.
                        try
                        {
                            string savePath = args?.FilePath;
                            if (!string.IsNullOrEmpty(savePath))
                            {
                                SoDCoop.Sync.SaveTransfer.HostSavePath = savePath;
                                // Written by an actual save this session → the
                                // file matches the host's live state.
                                SoDCoop.Sync.SaveTransfer.HostSavePathIsFresh = true;
                            }
                        }
                        catch { /* non-fatal — SaveTransfer falls back gracefully */ }

                        // Phase 4: live re-sync. If clients are connected and
                        // the just-written save differs from the last one we
                        // pushed, re-ship the save to every client so their
                        // world reflects the host's new state (e.g. host
                        // loaded a checkpoint, or SoD auto-saved after a time
                        // skip). Each client reloads via LoadGame and re-ACKs.
                        try
                        {
                            int pushed = SoDCoop.Sync.SaveTransfer.ResyncToAllClients();
                            if (pushed > 0)
                                Plugin.Log.LogInfo($"[SODCommon] OnAfterSave: live re-sync pushed to {pushed} client(s).");
                        }
                        catch (Exception ex) { Plugin.Log.LogWarning($"SaveTransfer.ResyncToAllClients: {ex.Message}"); }
                    }
                }
                catch (Exception ex) { Plugin.Log.LogError($"OnAfterSave handler: {ex.Message}"); }
            };

            IsAvailable = true;
            _hooked = true;
            Plugin.Log.LogInfo("SOD.Common bridge initialized (SaveGame hooks armed).");

            // ── Save-Transfer diagnostics (Phase 1) ─────────────────────────
            // Log the Unity persistent-data root so we can confirm where SoD
            // stores its saves without guessing. On Windows this is typically
            // %userprofile%\AppData\LocalLow\<company>\<product>\ — the exact
            // company/product name isn't in the Assembly-CSharp dump, so we
            // surface it here for the Phase 1 playtest.
            try
            {
                string pdp = global::UnityEngine.Application.persistentDataPath;
                Plugin.Log.LogInfo($"[SaveTransfer/Diag] Application.persistentDataPath = '{pdp}'");
                // Also enumerate any *.save / *.cityinfo files already in that
                // directory so we see the on-disk shape before the user even
                // triggers a save-load. Sizes here calibrate the chunked-
                // transfer budget for Phase 3.
                try
                {
                    var dir = new System.IO.DirectoryInfo(pdp);
                    if (dir.Exists)
                    {
                        var files = dir.GetFiles("*", System.IO.SearchOption.TopDirectoryOnly);
                        long totalBytes = 0;
                        int saveLike = 0;
                        foreach (var f in files)
                        {
                            totalBytes += f.Length;
                            string ext = System.IO.Path.GetExtension(f.Name).ToLowerInvariant();
                            if (ext == ".save" || ext == ".cityinfo" || ext == ".json")
                            {
                                saveLike++;
                                Plugin.Log.LogInfo($"[SaveTransfer/Diag] existing save-like file: '{f.Name}' {f.Length} bytes");
                            }
                        }
                        Plugin.Log.LogInfo($"[SaveTransfer/Diag] persistentDataPath holds {files.Length} file(s), {saveLike} save-like, {totalBytes} bytes total");
                    }
                    else
                    {
                        Plugin.Log.LogWarning($"[SaveTransfer/Diag] persistentDataPath does not exist yet: '{pdp}'");
                    }
                }
                catch (Exception dex) { Plugin.Log.LogWarning($"[SaveTransfer/Diag] directory enumerate: {dex.Message}"); }
            }
            catch (Exception pex) { Plugin.Log.LogWarning($"[SaveTransfer/Diag] persistentDataPath read: {pex.Message}"); }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"SOD.Common not available or API mismatch: {ex.GetType().Name}: {ex.Message}");
            IsAvailable = false;
        }
    }

    /// <summary>Phase 1 diagnostic: log everything we can learn about a save
    /// file at the given path — size, SHA-256, first-bytes hex peek. Called
    /// from OnBeforeLoad / OnAfterSave so one playtest yields the exact save
    /// location + size + a content fingerprint for Phase 3 calibration
    /// (chunk size, transfer timeout, machine-specific-field detection).
    ///
    /// <para>Deliberately tolerant: a missing/unreadable file logs a warning
    /// and returns — the save hooks must still complete their primary work
    /// (gate close, ZdoMan clear, etc.) regardless of whether diagnostics
    /// succeed.</para></summary>
    private static void LogSaveTransferDiagnostics(string label, string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
        {
            Plugin.Log.LogInfo($"[SaveTransfer/Diag] {label}: args.FilePath is null/empty — no file diagnostics available.");
            return;
        }
        try
        {
            var fi = new System.IO.FileInfo(filePath);
            if (!fi.Exists)
            {
                Plugin.Log.LogInfo($"[SaveTransfer/Diag] {label}: '{filePath}' does not exist (yet) — size unknown.");
                return;
            }
            long bytes = fi.Length;
            // SHA-256 over the full file. SoD saves are multi-MB JSON; hashing
            // is O(N) but sub-second for typical sizes. Used in Phase 4 (live
            // re-sync) to decide whether a new save differs from the last one
            // we pushed — here it's just calibration data.
            string sha = "(unreadable)";
            string head = "";
            try
            {
                using (var fs = fi.OpenRead())
                {
                    using (var sha256 = System.Security.Cryptography.SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(fs);
                        sha = System.BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                // First 64 bytes as hex — lets us eyeball whether the file is
                // JSON (starts with '{' = 0x7B) or binary, and whether it
                // carries a machine-specific prefix.
                using (var fs = fi.OpenRead())
                {
                    int toRead = (int)Math.Min(64L, fs.Length);
                    byte[] headBytes = new byte[toRead];
                    int read = fs.Read(headBytes, 0, toRead);
                    var sb = new System.Text.StringBuilder(read * 3);
                    for (int i = 0; i < read; i++) { if (i > 0) sb.Append(' '); sb.Append(headBytes[i].ToString("x2")); }
                    head = sb.ToString();
                }
            }
            catch (Exception hex) { sha = "(hash failed: " + hex.Message + ")"; }

            Plugin.Log.LogInfo(
                $"[SaveTransfer/Diag] {label}: '{filePath}' | size={bytes} bytes ({bytes / 1024.0:F1} KB) | " +
                $"sha256={sha} | head64={head}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SaveTransfer/Diag] {label}: diagnostics failed for '{filePath}': {ex.Message}");
        }
    }
}
