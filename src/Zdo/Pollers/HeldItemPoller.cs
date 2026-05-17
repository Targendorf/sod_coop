using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Per-peer held-item poller. Watches <c>FirstPersonItemController.Instance.currentItem</c>
/// at 10 Hz and broadcasts the matching slot's <c>interactableID</c> via the
/// existing <see cref="SoDCoop.Sync.InventorySync"/> ItemHeld packet path
/// when it changes.
///
/// <para>Replaces the legacy <c>InventorySync.Update</c> per-frame poll
/// driven directly from <c>CoopUpdateRunner.Update</c>. Moving the work
/// into <see cref="ZdoPollerHost"/> gets us:
/// <list type="bullet">
///   <item>Unified gating (HasPeers / WorldReady / not-in-grace / SyncGate-open).</item>
///   <item>Real 10 Hz throttle instead of every-frame work.</item>
///   <item>Baseline reset on <c>OnBeforeLoad</c> alongside the other pollers.</item>
/// </list>
/// </para>
/// </summary>
public static class HeldItemPoller
{
    public const float TICK_HZ = 10f;
    public const string NAME   = "held-item";

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    /// <summary>Reset is delegated to the legacy InventorySync — it owns the
    /// _lastHeldId field. We just call its Update once after reset on the
    /// next tick to re-baseline.</summary>
    public static void ResetBaseline() => SoDCoop.Sync.InventorySync.ResetHeldItemBaseline();

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// This poller has no bypass-able gates, so probe just forwards to Tick.</summary>
    internal static void ProbeBody(float now) => Tick(now);

    private static void Tick(float now)
    {
        // Phase G.5 (Wave 1.3): no-op. LocalPlayerPoller now writes
        // ZdoKeys.Held to the LocalPlayer ZDO; LocalPlayerResolver applies
        // it on receivers. The legacy InventorySync.PollHeldItem broadcast
        // path is bypassed.
        //
        // Poller registration kept so save-load reset and the on-disk
        // ZdoBootstrap entry stay structurally consistent across builds;
        // the body becomes alive again only if a future feature flag
        // re-enables the legacy held-item wire (none planned).
        _ = now;
    }
}
