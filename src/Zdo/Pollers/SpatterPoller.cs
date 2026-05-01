namespace SoDCoop.Zdo.Pollers;

public static class SpatterPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "spatter";
    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);
    private static void Tick(float now) { _ = now; /* legacy SpatterSync owns broadcast during transition */ }
}
