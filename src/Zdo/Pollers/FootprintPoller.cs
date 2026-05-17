using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side footprint cursor poller. Walks
/// <c>GameplayController.Instance.footprintsList</c> at 5 Hz; on
/// tail-append, emits one <see cref="ZdoTypeTag.Footprint"/> ZDO per new
/// <c>Footprint</c> entry. Receivers replay via
/// <see cref="SoDCoop.Sync.FootprintSync.ApplyAddDirect"/>.
///
/// <para>Field verification (Assembly-CSharp_Dump/GameplayController.cs:962):
/// <c>Footprint.hID</c> int, <c>rID</c> int, <c>wP</c> Vector3, <c>eU</c>
/// Vector3, <c>str</c> float (dirt), <c>bl</c> float (blood),
/// <c>t</c> float (timestamp).</para>
/// </summary>
public static class FootprintPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "footprints";

    private static int _cursor;
    private static uint _seq = 1;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForFootprints) return;
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
            var list = gc.footprintsList;
            if (list == null) return;
            int count = list.Count;
            if (count <= _cursor)
            {
                // Either no growth, or list got cleared (count < cursor).
                if (count < _cursor) _cursor = count;
                return;
            }

            for (int k = _cursor; k < count; k++)
            {
                var fp = list[k];
                if (fp == null) continue;

                int compositeId = unchecked((fp.hID << 16) | (int)(_seq++ & 0xffff));
                var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Footprint, compositeId,
                    owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.HumanId, fp.hID);
                z.Set(ZdoKeys.RoomId,  fp.rID);
                z.Set(ZdoKeys.Pos,     fp.wP);
                z.Set(ZdoKeys.FootprintEuler, fp.eU);
                z.Set(ZdoKeys.DirtFloat,  fp.str);
                z.Set(ZdoKeys.BloodFloat, fp.bl);
                z.Set(ZdoKeys.FootprintTimestamp, fp.t);
            }
            _cursor = count;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[FootprintPoller] tick: {ex.Message}"); }
    }
}
