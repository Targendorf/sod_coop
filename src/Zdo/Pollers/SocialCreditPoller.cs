using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-only social-credit (reputation) poller. Reads
/// <c>GameplayController.Instance.socialCredit</c> at 1 Hz, broadcasts on
/// diff via <see cref="ZdoEvents.SOCIAL_CREDIT"/>. Receivers stamp the
/// value into their own GameplayController so wanted-level escalation +
/// district restriction logic uses host's authoritative score everywhere.
///
/// <para>Without this, a host who commits a crime and gets caught accrues
/// social-credit penalties — but the client's GameplayController stays at
/// the launch value, so on the client side the player can still cross
/// guarded thresholds the host would be blocked at, and vice versa.</para>
///
/// <para>Field discovery: <c>GameplayController.socialCredit</c> int
/// (Assembly-CSharp_Dump/GameplayController.cs:4005).</para>
/// </summary>
public static class SocialCreditPoller
{
    public const float TICK_HZ = 1f;
    public const string NAME = "social-credit";

    private static bool _initialized;
    private static int  _last;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline() { _initialized = false; _last = 0; }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        if (!SoDCoop.Network.NetworkManager.IsHost) return;
        if (!SoDCoop.Network.NetworkManager.HasPeers) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag / IsHost / HasPeers gates so the field-drift
    /// probe exercises the real SoD-field-deref path even on a solo host.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            var gc = global::GameplayController.Instance;
            if (gc == null) return;

            int cur;
            try { cur = gc.socialCredit; } catch { return; }

            if (!_initialized) { _initialized = true; _last = cur; return; }
            if (cur == _last) return;

            _last = cur;
            try
            {
                SoDCoop.Zdo.ZdoEvents.SendSocialCredit(cur);
                Plugin.Log.LogDebug($"[SocialCreditPoller] broadcast socialCredit={cur}");
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[SocialCreditPoller] send: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SocialCreditPoller] tick: {ex.Message}"); }
    }
}
