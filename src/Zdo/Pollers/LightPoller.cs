using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>Host-side 10 Hz diff over light interactables → writes
/// <c>on</c> key to the <see cref="ZdoTypeTag.Light"/> ZDO.
///
/// <para><b>Performance</b>: the previous implementation walked the full
/// <c>interactableDirectory</c> (~10 000 entries on a typical city) and
/// called <c>GetComponentInChildren&lt;LightController&gt;(true)</c> on
/// every entry every 100 ms. That's a Unity tree-walk through the entire
/// transform hierarchy of each interactable — even ones with no light —
/// totalling millions of native API hits per second on the host main
/// thread, which is the dominant cause of the host-side hitching the user
/// reported. Now we maintain a one-time-built cache of (interactable id,
/// LightController) pairs, extended only when the directory grows. Per-
/// tick cost drops to ~N_lights field reads (typically 500–1500), no
/// component lookups at all.</para></summary>
public static class LightPoller
{
    public const float TICK_HZ = 10f;
    public const string NAME = "lights";

    /// <summary>Cached (interactableId, controller) pairs. Stored as parallel
    /// arrays so the per-tick loop is two indexed reads, no struct unpacking.</summary>
    private static readonly List<int> _lightIds = new();
    private static readonly List<LightController> _lightControllers = new();

    /// <summary>O(1) "is this Interactable backed by a LightController?" lookup,
    /// shared with <see cref="WorldStateSync.IsLightInteractable"/> and
    /// <see cref="SwitchPoller"/>. Populated as a side-effect of the LightPoller's
    /// directory scan. Without this, every per-tick caller would have to do
    /// a fresh <c>GetComponentInChildren&lt;LightController&gt;(true)</c>
    /// which is a Unity tree-walk; SwitchPoller alone was running that
    /// 10 000 times per tick at 10 Hz to filter lights out of its sweep.</summary>
    private static readonly HashSet<int> _lightInteractableIds = new();
    public static bool IsKnownLight(int interactableId) =>
        _lightInteractableIds.Contains(interactableId);

    /// <summary>Force the directory scan to advance through the prefix
    /// <c>[0, throughCount)</c> right now, regardless of poller schedule.
    /// Called by other pollers (e.g. <see cref="SwitchPoller"/>) before they
    /// query <see cref="IsKnownLight"/> so the light-set is populated for
    /// every interactable they're about to look at — without this the
    /// pollers race and SwitchPoller could miss lights, double-broadcasting
    /// switch state for them.</summary>
    public static void EnsureScannedThrough(int throughCount)
    {
        if (throughCount <= _scannedTo) return;
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;
            int hard = System.Math.Min(throughCount, dir.Count);
            for (int i = _scannedTo; i < hard; i++)
            {
                var inter = dir[i];
                if (inter == null || inter.spawnedObject == null) continue;
                LightController light = null;
                try { light = inter.spawnedObject.GetComponentInChildren<LightController>(true); } catch { }
                if (light == null) continue;
                _lightIds.Add(inter.id);
                _lightControllers.Add(light);
                _lightInteractableIds.Add(inter.id);
            }
            _scannedTo = hard;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LightPoller] EnsureScannedThrough: {ex.Message}"); }
    }

    /// <summary>How far we've already scanned through interactableDirectory.
    /// Next tick resumes from here so freshly-spawned interactables still
    /// get picked up without re-walking the prefix every tick.</summary>
    private static int _scannedTo;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    /// <summary>Drop the cache on world unload — interactables get destroyed
    /// when SoD reloads / returns-to-menu, and a stale cache would write to
    /// dead components.</summary>
    public static void ResetBaseline()
    {
        _lightIds.Clear();
        _lightControllers.Clear();
        _lightInteractableIds.Clear();
        _scannedTo = 0;
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForLights) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path even when the poller would normally be
    /// short-circuited.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            // Incrementally extend the cache for any newly-added interactables.
            // SoD's directory grows by appending — earlier indices keep their
            // identities, so resuming from `_scannedTo` is safe.
            if (dir.Count > _scannedTo)
            {
                for (int i = _scannedTo; i < dir.Count; i++)
                {
                    var inter = dir[i];
                    if (inter == null || inter.spawnedObject == null) continue;
                    LightController light = null;
                    try { light = inter.spawnedObject.GetComponentInChildren<LightController>(true); } catch { }
                    if (light == null) continue;
                    _lightIds.Add(inter.id);
                    _lightControllers.Add(light);
                    _lightInteractableIds.Add(inter.id);
                }
                _scannedTo = dir.Count;
            }

            // Per-tick: just iterate the cached LightControllers — no Unity
            // component lookups. ZdoMan.GetOrCreateBySodId is O(1) via the
            // (tag, sodId) lookup index.
            for (int i = 0; i < _lightControllers.Count; i++)
            {
                var light = _lightControllers[i];
                if (light == null) continue; // Unity destroyed — drop next tick.
                int id = _lightIds[i];

                Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Light, id, owner: ZdoMan.LocalPeerUid, persistent: true);
                // First time we see this Light, stamp its (static) world
                // position onto the ZDO for sector-cull. Lights don't move,
                // so we don't need to refresh per tick.
                if (!z.HasHostPosition)
                {
                    try
                    {
                        var go = light.gameObject;
                        if (go != null) ZdoMan.NotifyZdoPosition(z, go.transform.position);
                    }
                    catch { }
                }
                z.Set(ZdoKeys.On, light.isOn);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LightPoller] tick: {ex.Message}"); }
    }
}
