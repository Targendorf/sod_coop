using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side phone-call presence poller. Walks
/// <c>TelephoneController.Instance.activeCalls</c> at 5 Hz and ensures each
/// active call has a live <see cref="ZdoTypeTag.PhoneCall"/> ZDO.
///
/// <para>ZDO id key: composite <c>(callerHumanId &lt;&lt; 16) | receiverHumanId</c>
/// stored in <c>__sodId</c>. Calls that disappear from <c>activeCalls</c> on
/// the next tick are GC'd by destroying their ZDOs.</para>
///
/// <para><b>Field verification</b>: <c>TelephoneController.activeCalls</c> is
/// <c>List&lt;TelephoneController.PhoneCall&gt;</c>; <c>PhoneCall.caller</c>
/// and <c>PhoneCall.receiver</c> are int Human ids
/// (Assembly-CSharp_Dump/TelephoneController.cs:430,443).</para>
/// </summary>
public static class PhoneCallPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "phone-calls";

    private static readonly HashSet<int> _seenThisTick = new();

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForPhoneCalls) return;
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
            var tc = TelephoneController.Instance;
            if (tc == null) return;
            var calls = tc.activeCalls;
            if (calls == null) return;

            _seenThisTick.Clear();

            for (int i = 0; i < calls.Count; i++)
            {
                var call = calls[i];
                if (call == null) continue;

                int caller = call.caller;
                int receiver = call.receiver;
                int compositeId = unchecked((caller << 16) | (receiver & 0xffff));

                _seenThisTick.Add(compositeId);

                Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.PhoneCall, compositeId, owner: ZdoMan.LocalPeerUid, persistent: false);
                z.Set(ZdoKeys.CallerId,   caller);
                z.Set(ZdoKeys.CalleeId,   receiver);
                z.Set(ZdoKeys.CallActive, true);
            }

            // GC: destroy any PhoneCall ZDO whose composite id is no longer
            // in activeCalls. Mark inactive first (clients can render an
            // "ended" state) then destroy on the next tick.
            var toDestroy = new List<ZDOID>();
            foreach (var z in ZdoMan.AllOfType(ZdoTypeTag.PhoneCall))
            {
                int id = z.GetInt(ZdoKeys.SodId, 0);
                if (!_seenThisTick.Contains(id))
                {
                    if (z.GetBool(ZdoKeys.CallActive, true))
                    {
                        z.Set(ZdoKeys.CallActive, false);
                    }
                    else
                    {
                        toDestroy.Add(z.Id);
                    }
                }
            }
            foreach (var id in toDestroy) ZdoMan.Destroy(id);
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[PhoneCallPoller] tick: {ex.Message}"); }
    }
}
