using System;
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

    public static void Initialize()
    {
        if (_initialized) return;
        _initialized = true;
        IsWorldReady = false;
        _nextPollTime = 0f;
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

        bool ready = ComputeReady();
        if (ready == IsWorldReady) return;

        IsWorldReady = ready;
        if (ready)
        {
            WorldReadyAt = Time.unscaledTime;
            Plugin.Log.LogInfo($"WorldReadyGate: world is READY — init-grace window is {INIT_GRACE_SECONDS}s.");
            try { OnWorldReady?.Invoke(); }
            catch (Exception ex) { Plugin.Log.LogError($"OnWorldReady handler threw: {ex}"); }
        }
        else
        {
            WorldReadyAt = 0f;
            Plugin.Log.LogInfo("WorldReadyGate: world UNLOADED (returned to menu / between saves).");
            BroadcastBudget.Reset();
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
