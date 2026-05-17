using System;
using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// One-shot startup self-test. Each poller's <c>ProbeBody(float)</c> is
/// registered here as an <see cref="Action{T}"/> delegate at bootstrap
/// time, and <see cref="RunProbe"/> invokes them in turn so an unhandled
/// IL2CPP NRE from a renamed SoD field surfaces as a loud "FIELD DRIFT"
/// error at world-ready instead of as a silent sync regression after a
/// SoD patch.
///
/// <para><b>Why delegate-based, not reflection</b>: an earlier version
/// used <see cref="System.Reflection.MethodInfo.Invoke"/> to discover
/// <c>ProbeBody</c> via reflection. That trips the same fatal
/// <c>0x80131506</c> CLR error that <c>Plugin.PausePatchesForLoad</c>
/// documents (MonoMod's <c>DetourRuntimeNETCore30Platform.CompileMethodHook</c>
/// can't compile dynamic-invoke shims under BepInEx's IL2CPP detour
/// backend). <see cref="Delegate.Invoke"/> on a pre-built
/// <see cref="Action{T}"/> targets a method that's already JIT-compiled,
/// so it bypasses CompileMethodHook entirely.</para>
///
/// <para>Each poller exposes <c>ProbeBody</c> as a probe-only entry point
/// that bypasses the bypass-able gates (feature flag, IsHost, HasPeers)
/// so the probe exercises the actual SoD-field-deref path even when the
/// poller would normally short-circuit (solo host, feature flag off,
/// etc.). Content guards like <c>CityData.Instance == null</c> are
/// preserved inside the probed body so the probe is benign on empty
/// fixtures.</para>
/// </summary>
public static class PollerHealthCheck
{
    /// <summary>Registered probes, keyed by poller NAME for log clarity.
    /// Populated from <c>ZdoBootstrap.RegisterAll</c> alongside each
    /// poller's <see cref="ZdoPollerHost.Register"/> call.</summary>
    private static readonly Dictionary<string, Action<float>> _probes = new();

    /// <summary>Register a poller probe. Idempotent — re-registration
    /// overwrites the existing delegate (allows hot-reload-style
    /// scenarios in dev).</summary>
    public static void RegisterProbe(string name, Action<float> probe)
    {
        if (string.IsNullOrEmpty(name) || probe == null) return;
        _probes[name] = probe;
    }

    public static void RunProbe()
    {
        // Pollers dereference CityData fields (citizenDictionary,
        // interactableDirectory). Skip if the world isn't actually populated
        // yet — that would log false-positive NREs on empty fixtures.
        if (CityData.Instance == null)
        {
            Plugin.Log.LogWarning("[PollerHealthCheck] skipped — CityData not ready");
            return;
        }

        if (_probes.Count == 0)
        {
            Plugin.Log.LogWarning("[PollerHealthCheck] skipped — no probes registered (ZdoBootstrap.RegisterAll didn't run yet?)");
            return;
        }

        int passed = 0, failed = 0;
        var fails = new List<string>();
        float now = Time.unscaledTime;

        foreach (var kv in _probes)
        {
            try
            {
                // Direct delegate invoke — no reflection. The Action<float>
                // points at a regular static method that's already JIT'd.
                kv.Value(now);
                passed++;
            }
            catch (Exception ex)
            {
                // Unwrap if some inner runtime wrapped the original exception.
                var msg = ex.GetType().Name + ": " + ex.Message;
                if (ex.InnerException != null)
                    msg = ex.InnerException.GetType().Name + ": " + ex.InnerException.Message;
                failed++;
                fails.Add($"{kv.Key}: {msg}");
            }
        }

        if (failed == 0)
        {
            Plugin.Log.LogInfo($"[PollerHealthCheck] all {passed} pollers OK");
        }
        else
        {
            Plugin.Log.LogError($"[PollerHealthCheck] FIELD DRIFT DETECTED — {failed}/{passed + failed} pollers threw on probe:");
            foreach (var f in fails) Plugin.Log.LogError($"  - {f}");
            Plugin.Log.LogError("[PollerHealthCheck] sync may be partially broken — most likely SoD updated and renamed fields. Check above for which pollers/fields.");
        }
    }
}
