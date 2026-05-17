using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Per-peer money diff poller. Reads <c>GameplayController.Instance.money</c>
/// (the local player's wallet) at 2 Hz and broadcasts deltas through the
/// existing <see cref="SoDCoop.Sync.MoneySync.BroadcastAddMoney"/> path.
///
/// <para>Field verification: <c>GameplayController.money: int</c> at
/// Assembly-CSharp_Dump/GameplayController.cs:3979.</para>
///
/// <para>Replaces the Harmony patch on <c>GameplayController.AddMoney</c>.
/// Loses the per-call <c>displayMessage</c> + <c>reason</c> metadata
/// (we only see the post-state via polling) — acceptable degradation,
/// receivers still see the credit flow via the asymmetric MoneySync model
/// (credits flow to everyone, debits stay local). Reason becomes a generic
/// "(synced)" tag.</para>
/// </summary>
public static class MoneyPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "money";

    private static bool _initialized;
    private static int _lastMoney;

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// This poller has no bypass-able gates, so probe just forwards to Tick.</summary>
    internal static void ProbeBody(float now) => Tick(now);

    private static void Tick(float now)
    {
        try
        {
            var gc = GameplayController.Instance;
            if (gc == null) return;
            int current = gc.money;
            if (!_initialized)
            {
                _initialized = true;
                _lastMoney = current;
                return;
            }
            int delta = current - _lastMoney;
            if (delta == 0) return;
            _lastMoney = current;
            // Only broadcast credits — MoneySync's existing asymmetric model
            // says debits stay local. Polling can't distinguish credit
            // sources (quest, evidence sale, found cash) so reason is generic.
            if (delta > 0)
            {
                try { SoDCoop.Sync.MoneySync.BroadcastAddMoney(delta, displayMessage: false, reason: "(synced)"); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[MoneyPoller] broadcast: {ex.Message}"); }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[MoneyPoller] tick: {ex.Message}"); }
    }

    public static void ResetBaseline() => _initialized = false;
}
