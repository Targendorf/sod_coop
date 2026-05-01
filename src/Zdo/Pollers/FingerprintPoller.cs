namespace SoDCoop.Zdo.Pollers;

public static class FingerprintPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "fingerprints";
    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);
    private static void Tick(float now) { _ = now; /* legacy FingerprintSync owns broadcast during transition */ }
}
