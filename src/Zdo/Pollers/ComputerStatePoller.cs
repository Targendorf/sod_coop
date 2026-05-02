using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side computer state poller. Walks
/// <c>CityData.Instance.interactableDirectory</c> looking for
/// <c>ComputerController</c> components, tracks each computer's
/// <c>loggedInAs.humanID</c> and <c>currentApp.name</c>, broadcasts on
/// diff via existing <see cref="SoDCoop.Sync.ComputerSync.BroadcastLogin"/>
/// / <see cref="SoDCoop.Sync.ComputerSync.BroadcastApp"/>.
///
/// <para>Field verification (Assembly-CSharp_Dump/ComputerController.cs):
/// <c>loggedInAs: Human</c> at line 439, <c>currentApp: CruncherAppPreset</c>
/// at line 318.</para>
///
/// <para>Replaces Harmony patches on <c>ComputerController.SetLoggedIn</c>
/// and <c>SetComputerApp</c>. Patch-independent → survives save-load cycle.</para>
/// </summary>
public static class ComputerStatePoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "computer-state";

    private struct Snapshot { public int LoggedInHumanId; public string AppName; }
    private static readonly Dictionary<int, Snapshot> _last = new();

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            for (int i = 0; i < dir.Count; i++)
            {
                var inter = dir[i];
                if (inter == null || inter.spawnedObject == null) continue;
                ComputerController computer = null;
                try { computer = inter.spawnedObject.GetComponentInChildren<ComputerController>(true); } catch { }
                if (computer == null) continue;

                int humanId;
                string appName;
                try
                {
                    humanId = computer.loggedInAs?.humanID ?? 0;
                    appName = computer.currentApp != null ? computer.currentApp.name : "";
                }
                catch { continue; }

                if (!_last.TryGetValue(inter.id, out var snap))
                {
                    _last[inter.id] = new Snapshot { LoggedInHumanId = humanId, AppName = appName };
                    continue;
                }
                if (snap.LoggedInHumanId != humanId || snap.AppName != appName)
                {
                    // Phase G.5 (Wave 2.1): write to per-computer ZDO. Receiver's
                    // ComputerResolver.Apply reads the keys and dispatches via
                    // ComputerSync.ApplyLoginFromZdo / ApplyAppFromZdo.
                    try
                    {
                        var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Computer, inter.id,
                            owner: ZdoMan.LocalPeerUid, persistent: true);
                        z.Set(ZdoKeys.LoggedInHumanId, humanId);
                        z.Set(ZdoKeys.AppPreset,       appName ?? "");
                    }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[ComputerStatePoller] zdo write: {ex.Message}"); }
                }
                _last[inter.id] = new Snapshot { LoggedInHumanId = humanId, AppName = appName };
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ComputerStatePoller] tick: {ex.Message}"); }
    }
}
