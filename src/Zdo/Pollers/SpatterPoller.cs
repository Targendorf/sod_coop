using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side spatter cursor poller. Walks
/// <c>GameplayController.Instance.spatter</c> at 2 Hz; on tail-append, emits
/// one <see cref="ZdoTypeTag.Spatter"/> ZDO per new
/// <c>SpatterSimulation</c>. Receivers replay via
/// <see cref="SoDCoop.Sync.SpatterSync.ApplyAddDirect"/>.
/// </summary>
public static class SpatterPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "spatter";

    /// <summary>Index into the spatter list already replicated. -1 = not yet
    /// baselined; the first observation records the length and emits nothing.
    /// Same reasoning as FootprintPoller._cursor: it used to start at 0 and had
    /// no reset, so the first tick replayed every existing spatter.</summary>
    private static int _cursor = -1;
    private static uint _seq = 1;

    /// <summary>Only the most recent spatter events stay in the registry; see
    /// <see cref="TransientZdoLog"/>.</summary>
    private static readonly TransientZdoLog _log = new(256);

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    /// <summary>World unload: forget the cursor and the log.</summary>
    public static void ResetBaseline()
    {
        _cursor = -1;
        _log.Clear();
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForSpatter) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;
            var list = gc.spatter;
            if (list == null) return;
            int count = list.Count;
            if (_cursor < 0)
            {
                _cursor = count;   // baseline — see _cursor
                return;
            }
            if (count <= _cursor)
            {
                if (count < _cursor) _cursor = count;
                return;
            }

            for (int k = _cursor; k < count; k++)
            {
                var sim = list[k];
                if (sim == null) continue;

                int compositeId = unchecked((int)(_seq++ & 0x7fffffff));
                var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Spatter, compositeId,
                    owner: ZdoMan.LocalPeerUid, persistent: true);

                try { z.Set(ZdoKeys.SpatterOrigin,      sim.worldOrigin); } catch { }
                try { z.Set(ZdoKeys.SpatterTarget,      sim.worldTarget); } catch { }
                try { z.Set(ZdoKeys.SpatterPreset,      sim.preset != null ? sim.preset.name : sim.presetStr); } catch { }
                try { z.Set(ZdoKeys.SpatterErase,       (byte)sim.eraseMode); } catch { }
                try { z.Set(ZdoKeys.SpatterForceType,   (byte)sim.force); } catch { }
                try { z.Set(ZdoKeys.SpatterCountMul,    sim.spatterCountMultiplier); } catch { }
                try { z.Set(ZdoKeys.SpatterStickActors, sim.stickToActors); } catch { }
                _log.Track(z.Id);
            }
            _cursor = count;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SpatterPoller] tick: {ex.Message}"); }
    }
}
