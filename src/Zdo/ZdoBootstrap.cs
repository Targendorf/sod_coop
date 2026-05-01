using SoDCoop.Zdo.Pollers;
using SoDCoop.Zdo.Resolvers;

namespace SoDCoop.Zdo;

/// <summary>
/// Single registration entry-point for every ZDO resolver and poller.
/// Called from <c>Plugin.InitializeSystems</c> after <c>ZdoMan.Initialize</c>.
///
/// <para>Per-feature pollers self-register and gate their work on
/// <see cref="ZdoFeatureFlags"/> + the standard
/// (host-only / world-ready / not-in-grace / SyncGate-open) gating in
/// <see cref="ZdoPollerHost"/>.</para>
/// </summary>
public static class ZdoBootstrap
{
    public static void RegisterAll()
    {
        // ── Phase B: Doors ──
        ZdoResolverRegistry.Register(new DoorResolver());
        DoorPoller.Register();

        // ── Phase C: Lights, switches, citizen state, phone calls ──
        ZdoResolverRegistry.Register(new LightResolver());
        LightPoller.Register();
        ZdoResolverRegistry.Register(new SwitchResolver());
        SwitchPoller.Register();
        ZdoResolverRegistry.Register(new CitizenResolver());
        CitizenStatePoller.Register();
        ZdoResolverRegistry.Register(new PhoneCallResolver());
        PhoneCallPoller.Register();

        // ── Phase D: Forensics ──
        ZdoResolverRegistry.Register(new FingerprintResolver());
        FingerprintPoller.Register();
        ZdoResolverRegistry.Register(new FootprintResolver());
        FootprintPoller.Register();
        ZdoResolverRegistry.Register(new SpatterResolver());
        SpatterPoller.Register();

        // ── Phase E: Case board + evidence + vmail ──
        ZdoResolverRegistry.Register(new EvidenceObjectResolver());
        ZdoResolverRegistry.Register(new VmailThreadResolver());
        VmailThreadPoller.Register();
        EvidenceNotePoller.Register();

        // ── Phase F: Player state ──
        LocalPlayerPoller.Register();

        // ── Phase G: Event RPCs ──
        ZdoEvents.RegisterAll();

        Plugin.Log.LogInfo("[ZdoBootstrap] resolvers + pollers + events registered.");
    }
}
