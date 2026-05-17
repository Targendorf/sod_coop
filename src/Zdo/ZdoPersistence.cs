using System;
using System.IO;

namespace SoDCoop.Zdo;

/// <summary>
/// Disk persistence for the ZDO registry. Extracted from <see cref="ZdoMan"/>
/// as part of the SRP-driven split: file I/O has no business living next
/// to the live registry, dirty-tracking, and flush logic.
///
/// <para>Save/Load are host-only at the call sites in
/// <c>Plugin.cs</c>/<c>SodCommonBridge.cs</c>; this class doesn't enforce
/// that itself — it just defers to <see cref="ZdoMan.SerializeAllPersistent"/>
/// which returns an empty payload when the registry is empty, making a
/// non-host call a harmless no-op.</para>
///
/// <para>State boundary: this class owns no fields. <see cref="ZdoMan"/>
/// keeps the (private) <c>_byId</c> dictionary and <c>_snapshotScratch</c>
/// writer; we round-trip through its public <c>SerializeAllPersistent</c>
/// / <c>RestoreFromSnapshot</c> API. Cleaner than reaching into ZdoMan's
/// guts here.</para>
/// </summary>
public static class ZdoPersistence
{
    /// <summary>Resolve the on-disk path for the current city seed.
    /// Returns null on any error (caller treats null as "skip persistence
    /// this session"). Creates the parent directory if needed.</summary>
    public static string PersistencePath()
    {
        try
        {
            string baseDir = Path.Combine(BepInEx.Paths.ConfigPath, "com.sodcoop.mod", "zdo");
            Directory.CreateDirectory(baseDir);
            string seed = "default";
            try
            {
                if (CityData.Instance != null)
                {
                    seed = CityData.Instance.cityName ?? "default";
                }
            }
            catch { }
            string sanitized = "";
            foreach (var c in seed) sanitized += char.IsLetterOrDigit(c) ? c : '_';
            return Path.Combine(baseDir, $"{sanitized}.sodzdo");
        }
        catch
        {
            return null;
        }
    }

    /// <summary>Serialise the persistent ZDO set, zstd-compress it, and
    /// atomically rename a .tmp file into place. Bug #5: must be called
    /// BEFORE the world-unready cascade clears <see cref="ZdoMan"/>'s
    /// registry, otherwise the file we save is empty.</summary>
    public static void SaveToDisk()
    {
        try
        {
            string path = PersistencePath();
            if (path == null) return;
            byte[] payload = ZdoMan.SerializeAllPersistent();
            byte[] compressed = ZdoCompression.Compress(payload, payload.Length);
            string tmp = path + ".tmp";
            File.WriteAllBytes(tmp, compressed);
            if (File.Exists(path)) File.Delete(path);
            File.Move(tmp, path);
            Plugin.Log.LogInfo($"[ZdoPersistence] saved {payload.Length} → {compressed.Length} B to {path}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoPersistence] SaveToDisk failed: {ex.Message}");
        }
    }

    /// <summary>Read the on-disk snapshot for the current city seed (if
    /// any) and replay it through <see cref="ZdoMan.RestoreFromSnapshot"/>.
    /// Bug #5: must be called AFTER the world is ready so resolvers can
    /// deref Human/Interactable refs. Joiners never go through this path
    /// — they always receive their seed state from the host's snapshot
    /// push instead.</summary>
    public static void LoadFromDisk()
    {
        try
        {
            string path = PersistencePath();
            if (path == null || !File.Exists(path)) return;
            byte[] compressed = File.ReadAllBytes(path);
            byte[] decompressed = ZdoCompression.Decompress(compressed, expectedLen: 0);
            ZdoMan.RestoreFromSnapshot(decompressed);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoPersistence] LoadFromDisk failed: {ex.Message}");
        }
    }
}
