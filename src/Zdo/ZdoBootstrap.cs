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
        // Per-citizen idle/arms anim state (host → clients via ZdoEventRpc).
        // No resolver needed: ZdoEvents.OnCitizenAnimState applies directly to
        // the receiver's live citizen via SetIdleAnimationState + SetArmsBoolState.
        CitizenAnimationPoller.Register();
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
        ZdoResolverRegistry.Register(new LocalPlayerResolver());
        LocalPlayerPoller.Register();
        PlayerInputPoller.Register();
        PauseStatePoller.Register();
        MoneyPoller.Register();
        ZdoResolverRegistry.Register(new ComputerResolver());
        ComputerStatePoller.Register();
        MurderPoller.Register();

        // ── Phase G: Event RPCs ──
        ZdoEvents.RegisterAll();

        // ── Round 2: weather, elevators, evidence creation, case status, side jobs ──
        ZdoResolverRegistry.Register(new WeatherResolver());
        WeatherPoller.Register();
        ElevatorPoller.Register();
        EvidenceCreationPoller.Register();
        CaseStatusPoller.Register();
        ZdoResolverRegistry.Register(new SideJobResolver());
        SideJobPoller.Register();

        // ── Round 3: case-board pin/move/string ──
        ZdoResolverRegistry.Register(new CaseResolver());
        CaseBoardPoller.Register();

        // ── Round 5: NPC damage diff (currentHealth per citizen) ──
        NpcDamagePoller.Register();

        // ── Round 7: body-discovery via Murder.state transition ──
        MurderDiscoveryPoller.Register();

        // ── Round 10: held-item polling moved off legacy CoopUpdateRunner ──
        HeldItemPoller.Register();

        Plugin.Log.LogInfo("[ZdoBootstrap] resolvers + pollers + events registered.");
    }
}
