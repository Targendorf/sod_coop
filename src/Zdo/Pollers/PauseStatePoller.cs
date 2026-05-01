using System;
using UnityEngine;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Per-peer pause state poller. Watches <c>Time.timeScale</c> for the
/// 1.0 ↔ 0.0 transitions that fire when SoD's <c>SessionData.TogglePause</c>
/// flips, and routes the change through the existing
/// <see cref="SoDCoop.UI.PingSystem.NotifyLocalPauseChanged"/> path (which
/// already broadcasts via Phase G ZdoEvents.PAUSE_BANNER).
///
/// <para>Replaces the Harmony patch on <c>SessionData.TogglePause</c> for
/// post-save-load survival. Patch dies after first save-load (one-shot
/// UnpatchSelf, see Plugin.cs); polling is patch-independent.</para>
/// </summary>
public static class PauseStatePoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "pause-state";

    private static bool _initialized;
    private static bool _lastPaused;

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        try
        {
            bool paused = Mathf.Approximately(Time.timeScale, 0f);
            if (!_initialized)
            {
                _initialized = true;
                _lastPaused = paused;
                return;
            }
            if (paused == _lastPaused) return;
            _lastPaused = paused;
            try { SoDCoop.UI.PingSystem.NotifyLocalPauseChanged(paused); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[PauseStatePoller] notify: {ex.Message}"); }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[PauseStatePoller] tick: {ex.Message}"); }
    }

    public static void ResetBaseline() => _initialized = false;
}
