using System;

namespace SoDCoop.Integration;

/// <summary>
/// Thin wrapper over SOD.Common (Venomaus). All access is reflection-soft via try/catch
/// so the mod still loads if SOD.Common is missing or the API changes.
///
/// MVP usage: just confirm we can reach Lib.SaveGame events and log fires.
/// Future: hook OnAfterSave on host → ship save file to clients;
///         hook OnBeforeLoad on client → swap in the host's save.
/// </summary>
public static class SodCommonBridge
{
    public static bool IsAvailable { get; private set; }
    private static bool _hooked;

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
                try { Plugin.Log.LogInfo($"[SODCommon] OnBeforeLoad: {args?.FilePath}"); }
                catch (Exception ex) { Plugin.Log.LogError($"OnBeforeLoad handler: {ex.Message}"); }
            };
            lib.OnAfterLoad += (sender, args) =>
            {
                try { Plugin.Log.LogInfo($"[SODCommon] OnAfterLoad: {args?.FilePath}"); }
                catch (Exception ex) { Plugin.Log.LogError($"OnAfterLoad handler: {ex.Message}"); }
            };
            lib.OnBeforeSave += (sender, args) =>
            {
                try { Plugin.Log.LogInfo($"[SODCommon] OnBeforeSave: {args?.FilePath}"); }
                catch (Exception ex) { Plugin.Log.LogError($"OnBeforeSave handler: {ex.Message}"); }
            };
            lib.OnAfterSave += (sender, args) =>
            {
                try { Plugin.Log.LogInfo($"[SODCommon] OnAfterSave: {args?.FilePath}"); }
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
