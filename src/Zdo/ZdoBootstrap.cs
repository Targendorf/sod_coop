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
        // Position replication for citizens near each peer. Registered right
        // after CitizenStatePoller because it consumes the HostPosition that
        // poller stamps — it reads no SoD fields of its own.
        SoDCoop.Sync.CitizenPositionSync.Register();
        // Client → host edits of doors / locks / switches, plus correcting
        // anything near the client that drifted from the host.
        SoDCoop.Sync.WorldEditSync.Register();
        // Client → host hits on citizens and other players' bodies.
        SoDCoop.Sync.NpcHitSync.Register();
        // Per-citizen idle/arms anim state (host → clients via ZdoEventRpc).
        // Mode is configurable via CoopSettings.CitizenAnimSync:
        //   Disabled — no poller, SoD AI is deterministic from the same seed.
        //   Auto (default) — spatial-culled scan near connected peers.
        //   FixedHz — full roster scan at configured rate.
        {
            var mode = CoopSettings.CitizenAnimSync?.Value ?? CitizenAnimSyncMode.Auto;
            if (mode != CitizenAnimSyncMode.Disabled)
            {
                int hz = CoopSettings.CitizenAnimSyncHz?.Value ?? 2;
                hz = UnityEngine.Mathf.Clamp(hz, 1, 5);
                CitizenAnimationPoller.Register(hz);
            }
        }
        // Game-wide reputation (socialCredit). Host authoritative; receivers
        // stamp into their own GameplayController via ZdoEvents.OnSocialCredit.
        SocialCreditPoller.Register();
        // Speech bubbles — host broadcasts NPC bubbles; each peer broadcasts
        // own player bubbles. Receivers replay locally via SpeechController.Speak
        // so observers see what NPCs and other players are saying.
        SpeechBubblePoller.Register();
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
        // Discoveries, both directions (the AddDiscovery patch is disabled
        // and nothing had replaced it).
        EvidenceDiscoveryPoller.Register();

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

        // ── PollerHealthCheck registry (delegate-based, NOT reflection) ──
        // Reflection-based probe lookup hit a fatal MonoMod CompileMethodHook
        // crash (0x80131506) at first WorldReady on the IL2CPP backend —
        // same failure mode that forced UnpatchSelf in Plugin.cs. Direct
        // Action<float> delegates target methods that are already JIT'd
        // and bypass the dynamic-invoke trampoline entirely. Each entry
        // here mirrors the poller registered above; if a new poller is
        // added, drop a matching line here too.
        PollerHealthCheck.RegisterProbe(DoorPoller.NAME,                DoorPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(LightPoller.NAME,               LightPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(SwitchPoller.NAME,              SwitchPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(CitizenStatePoller.NAME,        CitizenStatePoller.ProbeBody);
        // CitizenAnimationPoller disabled — see comment above.
        PollerHealthCheck.RegisterProbe(SocialCreditPoller.NAME,        SocialCreditPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(SpeechBubblePoller.NAME,        SpeechBubblePoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(PhoneCallPoller.NAME,           PhoneCallPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(FingerprintPoller.NAME,         FingerprintPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(FootprintPoller.NAME,           FootprintPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(SpatterPoller.NAME,             SpatterPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(VmailThreadPoller.NAME,         VmailThreadPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(EvidenceNotePoller.NAME,        EvidenceNotePoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(LocalPlayerPoller.NAME,         LocalPlayerPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(PlayerInputPoller.NAME,         PlayerInputPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(PauseStatePoller.NAME,          PauseStatePoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(MoneyPoller.NAME,               MoneyPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(ComputerStatePoller.NAME,       ComputerStatePoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(MurderPoller.NAME,              MurderPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(WeatherPoller.NAME,             WeatherPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(ElevatorPoller.NAME,            ElevatorPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(EvidenceCreationPoller.NAME,    EvidenceCreationPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(CaseStatusPoller.NAME,          CaseStatusPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(SideJobPoller.NAME,             SideJobPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(CaseBoardPoller.NAME,           CaseBoardPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(NpcDamagePoller.NAME,           NpcDamagePoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(MurderDiscoveryPoller.NAME,     MurderDiscoveryPoller.ProbeBody);
        PollerHealthCheck.RegisterProbe(HeldItemPoller.NAME,            HeldItemPoller.ProbeBody);

        // Pollers that only ever diff against a first-sight baseline, and must
        // not sit out the 30 s post-load grace: the player's own position,
        // citizen positions (host) and the client's interest report, and the
        // client's world edits / hits.
        ZdoPollerHost.ExemptFromInitGrace(LocalPlayerPoller.NAME);
        ZdoPollerHost.ExemptFromInitGrace(SoDCoop.Sync.CitizenPositionSync.POLLER_NAME);
        ZdoPollerHost.ExemptFromInitGrace(SoDCoop.Sync.CitizenPositionSync.INTEREST_POLLER_NAME);
        ZdoPollerHost.ExemptFromInitGrace(SoDCoop.Sync.WorldEditSync.POLLER_NAME);
        ZdoPollerHost.ExemptFromInitGrace(SoDCoop.Sync.NpcHitSync.POLLER_NAME);

        Plugin.Log.LogInfo("[ZdoBootstrap] resolvers + pollers + events registered.");
    }
}
