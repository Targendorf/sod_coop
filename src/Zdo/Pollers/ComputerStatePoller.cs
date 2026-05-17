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
///
/// <para><b>Performance</b>: same caching strategy as <see cref="LightPoller"/>.
/// The previous implementation called
/// <c>GetComponentInChildren&lt;ComputerController&gt;(true)</c> on every
/// interactable in the city every 500 ms; that's a Unity tree-walk through
/// ~10 000 transform hierarchies. Now we cache (id, controller) pairs once
/// and just iterate the small cached list per tick.</para>
/// </summary>
public static class ComputerStatePoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "computer-state";

    private struct Snapshot { public int LoggedInHumanId; public string AppName; }
    private static readonly Dictionary<int, Snapshot> _last = new();

    /// <summary>Cache of ComputerControllers keyed by parallel index with
    /// <see cref="_computerIds"/>. Built incrementally as
    /// <c>interactableDirectory</c> grows.</summary>
    private static readonly List<int> _computerIds = new();
    private static readonly List<ComputerController> _computers = new();
    private static int _scannedTo;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// This poller has no bypass-able gates, so probe just forwards to Tick.</summary>
    internal static void ProbeBody(float now) => Tick(now);

    /// <summary>Drop the cache on world unload.</summary>
    public static void ResetBaseline()
    {
        _computerIds.Clear();
        _computers.Clear();
        _scannedTo = 0;
        _last.Clear();
    }

    private static void Tick(float now)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            // Incrementally extend the cache.
            if (dir.Count > _scannedTo)
            {
                for (int i = _scannedTo; i < dir.Count; i++)
                {
                    var inter = dir[i];
                    if (inter == null || inter.spawnedObject == null) continue;
                    ComputerController computer = null;
                    try { computer = inter.spawnedObject.GetComponentInChildren<ComputerController>(true); } catch { }
                    if (computer == null) continue;
                    _computerIds.Add(inter.id);
                    _computers.Add(computer);
                }
                _scannedTo = dir.Count;
            }

            for (int i = 0; i < _computers.Count; i++)
            {
                var computer = _computers[i];
                if (computer == null) continue;
                int interId = _computerIds[i];

                int humanId;
                string appName;
                try
                {
                    humanId = computer.loggedInAs?.humanID ?? 0;
                    appName = computer.currentApp != null ? computer.currentApp.name : "";
                }
                catch { continue; }

                if (!_last.TryGetValue(interId, out var snap))
                {
                    _last[interId] = new Snapshot { LoggedInHumanId = humanId, AppName = appName };
                    continue;
                }
                if (snap.LoggedInHumanId != humanId || snap.AppName != appName)
                {
                    // Phase G.5 (Wave 2.1): write to per-computer ZDO. Receiver's
                    // ComputerResolver.Apply reads the keys and dispatches via
                    // ComputerSync.ApplyLoginFromZdo / ApplyAppFromZdo.
                    try
                    {
                        var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Computer, interId,
                            owner: ZdoMan.LocalPeerUid, persistent: true);
                        // Static position — stamp once for sector-cull.
                        if (!z.HasHostPosition)
                        {
                            try { ZdoMan.NotifyZdoPosition(z, computer.gameObject.transform.position); } catch { }
                        }
                        z.Set(ZdoKeys.LoggedInHumanId, humanId);
                        z.Set(ZdoKeys.AppPreset,       appName ?? "");
                    }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[ComputerStatePoller] zdo write: {ex.Message}"); }
                }
                _last[interId] = new Snapshot { LoggedInHumanId = humanId, AppName = appName };
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[ComputerStatePoller] tick: {ex.Message}"); }
    }
}
