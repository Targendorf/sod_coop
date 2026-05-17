using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side body-discovery poller. Walks
/// <c>MurderController.Instance.activeMurders</c> at 1 Hz and watches each
/// <c>Murder.state</c> for the transition into
/// <see cref="Murder.MurderState.unsolved"/> — that's the moment SoD opens
/// a case in response to a discovered body. On flip, broadcasts via the
/// existing <see cref="SoDCoop.Sync.CitizenDeathSync.BroadcastDiscovery"/>
/// path so peers see the same banner / case-creation event.
///
/// <para>Field discovery (Assembly-CSharp_Dump/MurderController.cs):
/// <c>MurderState</c> enum at line 128 — values <c>none / acquireEuipment /
/// research / waitForLocation / travellingTo / executing / post /
/// escaping / unsolved / solved</c>. <c>Murder.state</c> property at line
/// 1011. <c>MurderController.activeMurders</c> List&lt;Murder&gt; at line
/// 5279.</para>
///
/// <para>Replaces the Harmony patch on
/// <c>MurderController.OnVictimDiscovery</c>.</para>
/// </summary>
public static class MurderDiscoveryPoller
{
    public const float TICK_HZ = 1f;
    public const string NAME   = "murder-discovery";

    private static readonly Dictionary<int, byte> _lastState = new();
    private static bool _initialized;

    /// <summary>Murder.MurderState.unsolved == 8 per the dump enum order
    /// (zero-indexed). Hardcoded because Il2Cpp enum interop on nested
    /// types is fiddly.</summary>
    private const byte STATE_UNSOLVED = 8;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick, WarmupBaseline);

    public static void ResetBaseline()
    {
        _initialized = false;
        _lastState.Clear();
    }

    /// <summary>Force the next real tick to re-snapshot murder states
    /// without broadcasting. Wired through <see cref="ZdoPollerHost"/> on
    /// every HasPeers gain.</summary>
    public static void WarmupBaseline() => ResetBaseline();

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForMurderDiscovery) return;
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
            var ctrl = MurderController.Instance;
            if (ctrl == null) return;
            var list = ctrl.activeMurders;
            if (list == null) return;

            // Baseline: snapshot, no broadcast (avoids re-emitting any saved
            // 'unsolved' murders on first tick after world ready).
            if (!_initialized)
            {
                _initialized = true;
                _lastState.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    var m = list[i];
                    if (m == null) continue;
                    _lastState[m.murderID] = (byte)m.state;
                }
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                var m = list[i];
                if (m == null) continue;
                int  mid = m.murderID;
                byte cur = (byte)m.state;

                if (!_lastState.TryGetValue(mid, out byte prev))
                {
                    _lastState[mid] = cur;
                    continue;
                }
                if (prev == cur) continue;
                _lastState[mid] = cur;

                // Discovery = transition into "unsolved". Other transitions
                // (executing→post→escaping etc.) are pre-discovery and
                // host-deterministic from the world seed; we don't sync them.
                if (cur == STATE_UNSOLVED && prev != STATE_UNSOLVED)
                {
                    // Phase G.5 (Wave 1.5): unified RPC channel via
                    // ZdoEventDispatcher.MURDER_DISCOVERED. Receiver-side
                    // ZdoEvents.OnMurderDiscovered calls
                    // CitizenDeathSync.ApplyDiscoveryFromZdo.
                    if (ZdoFeatureFlags.UseZdoForEvents)
                        ZdoEvents.SendMurderDiscovered();
                    else
                    {
                        try { SoDCoop.Sync.CitizenDeathSync.BroadcastDiscovery(); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[MurderDiscoveryPoller] broadcast: {ex.Message}"); }
                    }
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[MurderDiscoveryPoller] tick: {ex.Message}"); }
    }
}
