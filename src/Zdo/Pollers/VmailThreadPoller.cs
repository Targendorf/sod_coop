namespace SoDCoop.Zdo.Pollers;

/// <summary>Vmail thread presence poller (host). Currently a no-op stub
/// during the transition; legacy <c>VmailSync</c> still owns vmail
/// broadcasts. The hot patch on <c>Toolbox.NewVmailThread</c> will be
/// disabled once this poller is wired to the live thread set.</summary>
public static class VmailThreadPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "vmail-threads";
    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);
    private static void Tick(float now) { _ = now; /* legacy VmailSync owns broadcast */ }
}
