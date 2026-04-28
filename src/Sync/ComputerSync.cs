using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors high-level computer state changes between players so a co-op
/// teammate watching over your shoulder sees the same login session and
/// foreground app you do.
///
/// Synced state:
///   • <c>SetLoggedIn(Human)</c>  — who's logged in (humanID; -1 = logged out)
///   • <c>SetComputerApp(preset, force)</c> — which Cruncher app is open
///
/// NOT synced (out of scope for v1):
///   • Cursor position / clicks / typed text — too high-frequency, marginal value
///   • Database query results — re-derived locally from deterministic city data
///   • File system browse selection — local UI focus
///
/// Power on/off is already covered by WorldStateSync (the computer's
/// Interactable goes through SetSwitchState).
///
/// Cross-machine identity: <c>__instance.ic.interactable.id</c> — the
/// computer's parent Interactable id, deterministic from the world seed.
/// </summary>
public static class ComputerSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    /// <summary>Lazy <c>CruncherAppPreset.name</c> → preset registry.</summary>
    private static Dictionary<string, CruncherAppPreset> _appPresetByName;

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastLogin(int interactableId, int humanId)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (interactableId < 0) return;

        try
        {
            var packet = new ComputerLoginPacket
            {
                InteractableId = interactableId,
                HumanId        = humanId,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ComputerLogin, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[ComputerSync] login broadcast id={interactableId} human={humanId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ComputerSync.BroadcastLogin: {ex.Message}");
        }
    }

    public static void BroadcastApp(int interactableId, string presetName, bool forceUpdate)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (interactableId < 0) return;

        try
        {
            var packet = new ComputerAppPacket
            {
                InteractableId = interactableId,
                PresetName     = presetName ?? "",
                ForceUpdate    = forceUpdate,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ComputerApp, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[ComputerSync] app broadcast id={interactableId} preset=\"{presetName}\"");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ComputerSync.BroadcastApp: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.ComputerLogin)
            {
                var p = new ComputerLoginPacket();
                p.Deserialize(reader);
                ApplyLogin(p);
            }
            else if (type == PacketType.ComputerApp)
            {
                var p = new ComputerAppPacket();
                p.Deserialize(reader);
                ApplyApp(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"ComputerSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyLogin(ComputerLoginPacket p)
    {
        var cc = ResolveComputer(p.InteractableId);
        if (cc == null) return;

        Human human = null;
        if (p.HumanId >= 0)
        {
            try
            {
                var dict = CityData.Instance?.citizenDictionary;
                if (dict != null) dict.TryGetValue(p.HumanId, out human);
            }
            catch { }
        }

        IsApplyingRemote = true;
        try { cc.SetLoggedIn(human); }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"ApplyLogin({p.InteractableId}): {ex.Message}"); }
        finally { IsApplyingRemote = false; }
    }

    private static void ApplyApp(ComputerAppPacket p)
    {
        var cc = ResolveComputer(p.InteractableId);
        if (cc == null) return;

        CruncherAppPreset preset = null;
        if (!string.IsNullOrEmpty(p.PresetName))
            preset = ResolveAppPreset(p.PresetName);

        IsApplyingRemote = true;
        try { cc.SetComputerApp(preset, p.ForceUpdate); }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"ApplyApp({p.InteractableId}): {ex.Message}"); }
        finally { IsApplyingRemote = false; }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup helpers
    // ─────────────────────────────────────────────────────────────────────────

    private static ComputerController ResolveComputer(int interactableId)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return null;

            // Fast path — id == index.
            Interactable inter = null;
            if (interactableId >= 0 && interactableId < dir.Count)
            {
                var c = dir[interactableId];
                if (c != null && c.id == interactableId) inter = c;
            }
            if (inter == null)
            {
                for (int i = 0; i < dir.Count; i++)
                {
                    var c = dir[i];
                    if (c != null && c.id == interactableId) { inter = c; break; }
                }
            }
            if (inter?.spawnedObject == null) return null;

            return inter.spawnedObject.GetComponentInChildren<ComputerController>(true);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ComputerSync.ResolveComputer({interactableId}): {ex.Message}");
            return null;
        }
    }

    private static CruncherAppPreset ResolveAppPreset(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;

        if (_appPresetByName != null && _appPresetByName.TryGetValue(name, out var cached))
            return cached;

        try
        {
            _appPresetByName = new Dictionary<string, CruncherAppPreset>();
            var all = Resources.FindObjectsOfTypeAll<CruncherAppPreset>();
            if (all == null) return null;
            for (int i = 0; i < all.Length; i++)
            {
                var pr = all[i];
                if (pr == null) continue;
                var n = pr.name;
                if (string.IsNullOrEmpty(n)) continue;
                _appPresetByName[n] = pr;
            }
            Plugin.Log.LogInfo($"[ComputerSync] indexed {_appPresetByName.Count} CruncherAppPreset assets");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ComputerSync.ResolveAppPreset: {ex.Message}");
            return null;
        }

        return _appPresetByName.TryGetValue(name, out var fresh) ? fresh : null;
    }
}
