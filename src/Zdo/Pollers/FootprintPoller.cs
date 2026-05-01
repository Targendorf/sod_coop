namespace SoDCoop.Zdo.Pollers;

public static class FootprintPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "footprints";
    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);
    private static void Tick(float now) { _ = now; /* legacy FootprintSync owns broadcast during transition */ }
}
