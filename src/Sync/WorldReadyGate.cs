using System;
using System.Diagnostics;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Tracks whether the SoD game world is fully loaded (city + citizens + local player).
/// Other systems use this to defer work that needs the live game (e.g., cloning a citizen
/// visual for a RemotePlayer). State is polled at low frequency from CoopUpdateRunner —
/// the game has no event we can subscribe to that covers all transitions reliably.
/// </summary>
public static class WorldReadyGate
{
    /// <summary>True when CityData/Citizens/Player are all live.</summary>
    public static bool IsWorldReady { get; private set; }

    /// <summary>Time.unscaledTime when the world flipped to ready (or 0 if never).</summary>
    public static float WorldReadyAt { get; private set; }

    /// <summary>
    /// "World is ready" fires early in SoD's load sequence (city + citizens + Player exist),
    /// but SoD then continues with **massive** scripted setup: per-citizen evidence naming
    /// via <c>Evidence.SetNote</c>, vmail thread generation, case-board timeline events,
    /// etc. — easily thousands of mutation calls. We don't want to broadcast any of those:
    /// they're deterministic from the world seed and identical on every machine. This grace
    /// window suppresses Evidence / Vmail / equivalent broadcasts for a few seconds after
    /// world-ready, after which any remaining mutation is genuinely player-driven.
    /// </summary>
    public const float INIT_GRACE_SECONDS = 30f;

    /// <summary>True for the first <see cref="INIT_GRACE_SECONDS"/> after world-ready.</summary>
    public static bool IsInInitGrace =>
        IsWorldReady && (Time.unscaledTime - WorldReadyAt) < INIT_GRACE_SECONDS;

    /// <summary>Fires once when the world transitions to ready.</summary>
    public static event Action OnWorldReady;

    /// <summary>Fires once when the world transitions away from ready (e.g., return to menu).</summary>
    public static event Action OnWorldUnready;

    private const float POLL_INTERVAL = 1f;
    private static float _nextPollTime;
    private static bool _initialized;

    // Wall-clock instrumentation. _sinceInit is reset at plugin load so we
    // can quote "world ready after Xs since plugin started"; _sinceReady is
    // reset on each ready-flip so we can quote "init grace closed after Xs".
    // Wall clock (Stopwatch) — not Time.unscaledTime — because Time freezes
    // during scene transitions, which is exactly when the long load happens.
    private static readonly Stopwatch _sinceInit  = new();
    private static readonly Stopwatch _sinceReady = new();
    private static bool _graceClosedLogged;

    public static void Initialize()
    {
        if (_initialized) return;
        _initialized = true;
        IsWorldReady = false;
        _nextPollTime = 0f;
        _sinceInit.Restart();
        Plugin.Log.LogInfo("WorldReadyGate initialized.");
    }

    public static void Shutdown()
    {
        OnWorldReady = null;
        OnWorldUnready = null;
        IsWorldReady = false;
        _initialized = false;
    }

    /// <summary>Call from a per-frame Update; internally throttled.</summary>
    public static void Tick()
    {
        if (!_initialized) return;

        float now = Time.unscaledTime;
        if (now < _nextPollTime) return;
        _nextPollTime = now + POLL_INTERVAL;

        // Log grace-window close once + open SyncGate. With the one-shot
        // UnpatchSelf model (Plugin.cs), patches stay dead after the first
        // save-load, so SyncGate.Open here only enables poller broadcasts —
        // no patch bodies run because no patches are attached.
        if (IsWorldReady && !_graceClosedLogged && !IsInInitGrace)
        {
            _graceClosedLogged = true;
            Plugin.Log.LogInfo($"WorldReadyGate: init-grace window closed after " +
                $"{_sinceReady.Elapsed.TotalSeconds:F1}s wall-clock (configured {INIT_GRACE_SECONDS}s).");
            SyncGate.Open();
        }

        bool ready = ComputeReady();
        if (ready == IsWorldReady) return;

        IsWorldReady = ready;
        if (ready)
        {
            WorldReadyAt = Time.unscaledTime;
            _sinceReady.Restart();
            _graceClosedLogged = false;
            // If a save-load is in flight, also report the precise OnBeforeLoad→ready
            // span (the actual user-perceived "click Load → game playable" cost,
            // independent of however long the user idled on the title screen).
            string loadSpan = "";
            try
            {
                if (Integration.SodCommonBridge.IsLoadInFlight)
                    loadSpan = $" — save-load wall-clock so far {Integration.SodCommonBridge.CurrentLoadSeconds:F1}s";
            }
            catch { }
            Plugin.Log.LogInfo($"WorldReadyGate: world is READY after " +
                $"{_sinceInit.Elapsed.TotalSeconds:F1}s since plugin load{loadSpan} — " +
                $"init-grace window is {INIT_GRACE_SECONDS}s.");
            try { OnWorldReady?.Invoke(); }
            catch (Exception ex) { Plugin.Log.LogError($"OnWorldReady handler threw: {ex}"); }
        }
        else
        {
            WorldReadyAt = 0f;
            _sinceReady.Reset();
            _graceClosedLogged = false;
            Plugin.Log.LogInfo("WorldReadyGate: world UNLOADED (returned to menu / between saves).");
            BroadcastBudget.Reset();
            // Close the patch gate — we're between saves, no need to do
            // any sync work, and the next save load needs the burst window
            // protected again.
            SyncGate.Close();
            try { OnWorldUnready?.Invoke(); }
            catch (Exception ex) { Plugin.Log.LogError($"OnWorldUnready handler threw: {ex}"); }
        }
    }

    private static bool ComputeReady()
    {
        try
        {
            var city = CityData.Instance;
            if (city == null) return false;
            if (city.citizenDictionary == null || city.citizenDictionary.Count == 0) return false;
            if (global::Player.Instance == null) return false;
            return true;
        }
        catch
        {
            return false;
        }
    }
}
