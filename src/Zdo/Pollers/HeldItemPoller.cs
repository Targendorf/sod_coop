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

    private static void Tick(float now)
    {
        try
        {
            // Legacy InventorySync.Update is the implementation; we just
            // drive its scheduling. When the legacy path is fully retired
            // the poll body moves here verbatim.
            SoDCoop.Sync.InventorySync.PollHeldItem();
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[HeldItemPoller] tick: {ex.Message}"); }
    }
}
