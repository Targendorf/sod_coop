using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>Phone call active-state poller (host). Currently scaffolding —
/// the legacy <c>PhoneSync</c> banner-broadcasts still drive UI; this
/// poller keeps a consolidated ZDO so snapshot replication is consistent.</summary>
public static class PhoneCallPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "phone-calls";

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForPhoneCalls) return;
        // No-op for now — legacy PhoneSync owns active-call broadcast banners.
        _ = now;
    }
}
