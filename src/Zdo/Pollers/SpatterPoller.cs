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

    private static int _cursor;
    private static uint _seq = 1;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

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
            }
            _cursor = count;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SpatterPoller] tick: {ex.Message}"); }
    }
}
