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

    /// <summary>Advance the diff baseline by a credit that was already
    /// handled by another path, so the next poll doesn't re-broadcast it.
    ///
    /// <para><b>This closes the money echo loop seen in playtest 2026-06-10:</b>
    /// peer A credits +100 → broadcast → peer B's <c>MoneySync.ApplyAddMoneyImpl</c>
    /// calls <c>gc.AddMoney(+100)</c>. The <c>IsApplyingRemote</c> guard
    /// suppresses B's AddMoney PATCH, but B's <b>poller</b> runs a tick later,
    /// sees wallet ↑100 vs its stale baseline, and broadcasts +100 back to A —
    /// who applies it, whose poller re-broadcasts it… +100 ping-pong at ~1.4 Hz
    /// forever (both logs showed 93 rounds, +9300 wallet inflation). A
    /// flag can't fix a poll-later race; only baseline accounting can.</para>
    ///
    /// <para>Called from (1) <c>MoneySync.ApplyAddMoneyImpl</c> — remote credits
    /// applied locally, and (2) <c>MoneySync.BroadcastAddMoney</c> — local
    /// credits the AddMoney patch already broadcast (otherwise the poller
    /// would broadcast the SAME credit a second time → double-credit on the
    /// receiver). Single-threaded (Unity main), so no races with Tick.</para></summary>
    internal static void NotifyExternalCredit(int amount)
    {
        if (_initialized) _lastMoney += amount;
        // Not yet initialized → the first Tick snapshots the wallet wholesale,
        // which already includes this credit. Nothing to do.
    }

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
                // notifyPollerBaseline: false — we already advanced _lastMoney
                // above; letting BroadcastAddMoney bump it again would
                // over-advance and swallow the next genuine credit.
                try { SoDCoop.Sync.MoneySync.BroadcastAddMoney(delta, displayMessage: false, reason: "(synced)", notifyPollerBaseline: false); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[MoneyPoller] broadcast: {ex.Message}"); }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[MoneyPoller] tick: {ex.Message}"); }
    }

    public static void ResetBaseline() => _initialized = false;
}
