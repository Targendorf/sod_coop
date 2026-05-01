using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>Evidence note text poller (host). Replaces the hot patch on
/// <c>Evidence.SetNote</c>. Currently scaffolding — the legacy
/// EvidenceSync still owns SetNote broadcasts.</summary>
public static class EvidenceNotePoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "evidence-notes";

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvidenceNote) return;
        // No-op — legacy EvidenceSync owns note broadcast during transition.
        _ = now;
    }
}
