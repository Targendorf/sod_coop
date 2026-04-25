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
            Plugin.Log.LogInfo("WorldReadyGate: world is READY (city + citizens + player live).");
            try { OnWorldReady?.Invoke(); }
            catch (Exception ex) { Plugin.Log.LogError($"OnWorldReady handler threw: {ex}"); }
        }
        else
        {
            Plugin.Log.LogInfo("WorldReadyGate: world UNLOADED (returned to menu / between saves).");
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
