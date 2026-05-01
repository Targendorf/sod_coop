namespace SoDCoop.Zdo.Pollers;

/// <summary>Citizen state poller — outfit/sleep/restrain/stun. Currently a
/// no-op stub during the transition; legacy Sync classes still detect and
/// broadcast each surface. Re-enabled in a future phase once the SoD field
/// names (per-version) are verified — see spec section 12.2.</summary>
public static class CitizenStatePoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "citizens";
    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);
    private static void Tick(float now) { _ = now; /* legacy paths own broadcast */ }
}
