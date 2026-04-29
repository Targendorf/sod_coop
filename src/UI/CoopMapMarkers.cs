using System.Collections.Generic;
using SoDCoop.Player;
using UnityEngine;

namespace SoDCoop.UI;

/// <summary>
/// Adds remote-player markers to SoD's <c>MapController</c> so when the
/// player opens the city map (M by default) they see where their coop
/// partners are.
///
/// <para><b>How:</b> SoD already supports tracking arbitrary world
/// transforms on the map via <c>MapController.AddNewTrackedObject</c>.
/// We register each <see cref="SoDCoop.Player.RemotePlayer"/>'s transform
/// on every <c>OpenMap</c> postfix; SoD then projects their world position
/// onto the map UI every frame the map is open. No per-frame work for us.</para>
///
/// <para>Idempotency: a HashSet tracks (mapInstance, playerId) tuples so a
/// re-open doesn't re-register the same player twice. The set resets on
/// <see cref="Reset"/> (called from RemotePlayerManager despawn paths
/// indirectly via MapController teardown — practically we just leak a
/// few HashSet entries per session, harmless).</para>
///
/// <para>Sprite: re-uses <c>MapController.fastTravelIcon</c> (a recognisable
/// arrow/marker shape) tinted cyan so it visually reads as "the OTHER
/// player" vs the local player's own marker (which SoD draws in its
/// default colour).</para>
/// </summary>
public static class CoopMapMarkers
{
    /// <summary>Cyan-ish, high contrast against the map's beige paper.</summary>
    private static readonly Color MARKER_COLOR = new(0.20f, 0.80f, 0.95f, 1f);

    /// <summary>Pixel size on the map (matches default SoD pin size).</summary>
    private static readonly Vector2 MARKER_SIZE = new(28f, 28f);

    /// <summary>Tracks (MapController.instanceID, playerId) we've already added.</summary>
    private static readonly HashSet<(int mapId, int playerId)> _registered = new();

    /// <summary>
    /// Called from a Harmony postfix on <c>MapController.OpenMap</c>. Idempotent.
    /// </summary>
    public static void OnMapOpened(MapController map)
    {
        if (map == null) return;
        try
        {
            var players = RemotePlayerManager.Players;
            if (players == null || players.Count == 0) return;

            var icon = map.fastTravelIcon;
            if (icon == null)
            {
                Plugin.Log.LogInfo("[CoopMapMarkers] MapController.fastTravelIcon is null — skipping (will retry next open).");
                return;
            }

            int mapId = map.GetInstanceID();
            int added = 0;
            foreach (var kv in players)
            {
                var rp = kv.Value;
                if (rp == null || rp.transform == null) continue;
                var key = (mapId, kv.Key);
                if (_registered.Contains(key)) continue;

                map.AddNewTrackedObject(
                    rp.transform,
                    icon,
                    MARKER_SIZE,
                    MARKER_COLOR,
                    /*isDynamic*/ true,
                    /*buttonReference*/ null);
                _registered.Add(key);
                added++;
            }
            if (added > 0)
                Plugin.Log.LogInfo($"[CoopMapMarkers] registered {added} remote-player marker(s) on map.");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"CoopMapMarkers.OnMapOpened: {ex.Message}");
        }
    }

    /// <summary>
    /// Drop the registry — call when sessions end so a fresh map open in a
    /// future session starts clean (the MapController instance ID will
    /// have changed anyway, so leaks are bounded, but better hygiene).
    /// </summary>
    public static void Reset() => _registered.Clear();
}
