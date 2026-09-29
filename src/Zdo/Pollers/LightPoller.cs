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

    /// <summary>Lights examined per tick by the reconciliation sweep. At 10 Hz,
    /// 256/tick covers a few thousand lights every ~1-2 s at a fraction of the
    /// interop cost of walking the whole cache each tick.</summary>
    private const int SWEEP_PER_TICK = 256;
    private static int _sweepCursor;

    /// <summary>Directory entries classified per tick (one GetComponentInChildren
    /// tree walk each, ~44 µs measured). 120/tick keeps a tick near 5 ms; a
    /// 10 000-entry city is indexed within ~8 s of the first peer joining.</summary>
    private const int SCAN_PER_TICK = 120;

    /// <summary>Lights by position, so every light near a player is checked
    /// every tick — see <see cref="StaticSpatialIndex"/>.</summary>
    private static readonly StaticSpatialIndex _index = new();
    private static readonly List<UnityEngine.Vector3> _anchors = new();
    private static readonly List<int> _near = new();
    private static readonly HashSet<int> _nearSeen = new();

    /// <summary>Directory prefix already classified. <see cref="SwitchPoller"/>
    /// only considers interactables below this, so it never takes an unscanned
    /// light for a plain switch.</summary>
    public static int ScannedTo => _scannedTo;

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
        // Retained for API compatibility only. SwitchPoller used to call this
        // with the full directory count, which forced the ENTIRE light scan —
        // thousands of tree walks — into whichever frame SwitchPoller happened
        // to run in (143 ms on the 2026-07-30 host). It now reads ScannedTo and
        // follows the bounded scan instead; this is capped the same way in case
        // anything else ever calls it.
        if (throughCount <= _scannedTo) return;
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;
            int hard = System.Math.Min(System.Math.Min(throughCount, dir.Count), _scannedTo + SCAN_PER_TICK);
            ScanRange(dir, _scannedTo, hard);
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
        _sweepCursor = 0;
        _index.Clear();
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

            // в”Ђв”Ђ Bounded incremental scan в”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђ
            // Each new interactable costs a GetComponentInChildren tree walk to
            // learn whether it carries a LightController. The first tick after a
            // peer joins used to walk the ENTIRE directory at once вЂ” ~10 000
            // tree walks in one frame, 437 ms on the 2026-07-30 host. SoD's
            // directory grows by appending, so resuming from _scannedTo in
            // SCAN_PER_TICK slices is safe and spreads the warm-up over a few
            // seconds. SwitchPoller only considers interactables below
            // ScannedTo, so it can never mistake an unscanned light for a switch.
            if (dir.Count > _scannedTo)
            {
                int end = Math.Min(dir.Count, _scannedTo + SCAN_PER_TICK);
                ScanRange(dir, _scannedTo, end);
                _scannedTo = end;
            }

            // в”Ђв”Ђ Tier 1: every light near a player, every tick в”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђ
            // LightController.SetOn is NOT patched (the attribute is commented
            // out вЂ” lights toggle constantly under NPC schedules), so this
            // poller is the only path; an earlier note here claimed otherwise.
            // Lights in view of any player are checked at the full 10 Hz.
            PollerAnchors.CollectNear(_index, _anchors, _near, _nearSeen);
            for (int k = 0; k < _near.Count; k++) PushLight(_near[k]);

            // в”Ђв”Ђ Tier 2: amortized sweep over the rest of the city в”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђв”Ђ
            // SWEEP_PER_TICK per tick, wrapping. Walking every light at 10 Hz
            // was the class of per-tick IL2CPP cost that held pollers at
            // 700-1600 ms/frame (playtest 2026-06-23); lights nobody can see
            // converge within a couple of seconds.
            int lightSweep = Math.Min(SWEEP_PER_TICK, _lightControllers.Count);
            for (int n = 0; n < lightSweep; n++)
            {
                if (_sweepCursor >= _lightControllers.Count) _sweepCursor = 0;
                int i = _sweepCursor++;
                if (_nearSeen.Contains(i)) continue;   // tier 1 already did it
                PushLight(i);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LightPoller] tick: {ex.Message}"); }
    }

    /// <summary>Classify directory entries [from, to): cache every light and
    /// index it by position.</summary>
    private static void ScanRange(Il2CppSystem.Collections.Generic.List<Interactable> dir, int from, int to)
    {
        for (int i = from; i < to; i++)
        {
            var inter = dir[i];
            if (inter == null || inter.spawnedObject == null) continue;
            LightController light = null;
            try { light = inter.spawnedObject.GetComponentInChildren<LightController>(true); } catch { }
            if (light == null) continue;
            _lightIds.Add(inter.id);
            _lightControllers.Add(light);
            _lightInteractableIds.Add(inter.id);
            try { _index.Add(_lightControllers.Count - 1, inter.wPos); } catch { }
        }
    }

    private static void PushLight(int i)
    {
        if (i < 0 || i >= _lightControllers.Count) return;
        var light = _lightControllers[i];
        if (light == null) return; // Unity destroyed вЂ” drop next tick.
        int id = _lightIds[i];

        Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Light, id, owner: ZdoMan.LocalPeerUid, persistent: true);
        // First time we see this Light, stamp its (static) world position onto
        // the ZDO for sector-cull. Lights don't move.
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