namespace SoDCoop.Network;

/// <summary>
/// Defines all packet types used for network communication.
/// </summary>
public enum PacketType : byte
{
    #region Connection Packets (0-9)
    
    /// <summary>
    /// Initial handshake packet. Contains player ID assignment and player list.
    /// </summary>
    Handshake = 0,
    
    /// <summary>
    /// World seed synchronization. Sent by host before game starts.
    /// </summary>
    WorldSeed = 1,
    
    /// <summary>
    /// Notification that a new player has joined.
    /// </summary>
    PlayerJoined = 2,
    
    /// <summary>
    /// Notification that a player has left.
    /// </summary>
    PlayerLeft = 3,
    
    /// <summary>
    /// Ping/pong for latency measurement.
    /// </summary>
    Ping = 4,
    
    /// <summary>
    /// Ready state toggle. Indicates player is ready to start.
    /// </summary>
    ReadyState = 5,
    
    /// <summary>
    /// Game start signal from host.
    /// </summary>
    GameStart = 6,

    /// <summary>
    /// Host → single client. Sent during connection handshake when the host
    /// has no stored character record for (worldSeed, clientGuid). Tells the
    /// client to open the Create Character panel and reply with
    /// <see cref="CharacterSubmit"/>. Carries the host's own character name
    /// + city name for context ("You're joining John Smith in New Babylon").
    /// </summary>
    CharacterCreationRequired = 7,

    /// <summary>
    /// Client → host. Reply to <see cref="CharacterCreationRequired"/> with
    /// the player-typed first name + surname. Host validates, persists to its
    /// per-seed character store, then proceeds with the normal handshake flow.
    /// </summary>
    CharacterSubmit = 8,

    /// <summary>
    /// Client → host. "Forget my character record on this world." Host removes
    /// the (clientGuid → record) entry from its per-seed store, re-enables the
    /// twin citizen's AI (so they rejoin city simulation), and disconnects the
    /// peer. Client then wipes its local clientGuid so the next connection
    /// behaves as a brand-new joiner.
    /// </summary>
    CharacterReset = 9,

    /// <summary>
    /// Host → client. Reply to <see cref="CharacterSubmit"/> when the
    /// player-typed name fails server-side validation (empty, forbidden
    /// chars, too long, name collision, etc.). Carries a single human-
    /// readable reason string the client surfaces in the creation panel.
    /// The panel stays open so the user can correct and re-submit.
    /// </summary>
    CharacterRejected = 10,

    #endregion
    
    #region Player Sync Packets (10-29)
    
    /// <summary>
    /// Player position, rotation, and velocity.
    /// Sent frequently (20 Hz).
    /// </summary>
    PlayerPosition = 10,
    
    /// <summary>
    /// Player animation state change.
    /// </summary>
    PlayerAnimation = 11,
    
    /// <summary>
    /// Full inventory sync.
    /// </summary>
    PlayerInventory = 12,
    
    /// <summary>
    /// Player interaction with object/NPC.
    /// </summary>
    PlayerInteraction = 13,
    
    /// <summary>
    /// Player picked up an item.
    /// </summary>
    PlayerPickup = 14,
    
    /// <summary>
    /// Player dropped an item.
    /// </summary>
    PlayerDrop = 15,
    
    /// <summary>
    /// Player equipped/changed weapon or tool.
    /// </summary>
    PlayerEquip = 16,
    
    /// <summary>
    /// Player used an item (e.g., consumed food).
    /// </summary>
    PlayerUseItem = 17,
    
    /// <summary>
    /// Player health/status change.
    /// </summary>
    PlayerStatus = 18,

    /// <summary>
    /// Player vitals (nourishment, hydration, energy, isDead). Sent at low rate
    /// from each client; rendered as bars in the UI HUD.
    /// </summary>
    PlayerVitals = 19,

    /// <summary>
    /// Currently held / equipped item changed. Carries Interactable.id of the
    /// held item, or -1 for empty hands. Each player polls its own
    /// FirstPersonItemController and broadcasts on change.
    /// </summary>
    ItemHeld = 20,

    /// <summary>
    /// Player's held item is raised (combat-ready) vs holstered/idle.
    /// Mirrors FirstPersonItemController.SetRaised(bool).
    /// </summary>
    ItemRaised = 21,

    /// <summary>
    /// Player toggled the flashlight on / off.
    /// Mirrors FirstPersonItemController.SetFlashlight(bool).
    /// </summary>
    ItemFlashlight = 22,

    /// <summary>
    /// One-shot combat / interaction action: MeleeAttack, Block, CounterAttack.
    /// Cosmetic broadcast — actual NPC state changes (damage, death) flow
    /// through the existing CitizenDeathSync / RecieveDamage paths.
    /// </summary>
    ItemAction = 23,

    /// <summary>
    /// Player placed a tactical item (codebreaker, doorwedge, tracker, grenade
    /// mine). Carries the preset name + position + rotation so the other peers
    /// can spawn a stripped visual mock at the same spot. Functional gameplay
    /// (e.g. codebreaker scanning) only runs on the placer's machine.
    /// </summary>
    ItemPlaceVisual = 24,

    /// <summary>
    /// Player gave an item to a Human (NPC takes it into their possession).
    /// Replays Human.TryGiveItem on the receiver.
    /// </summary>
    ItemGive = 25,

    /// <summary>
    /// NPC handcuff state changed (NewAIController.SetRestrained).
    /// </summary>
    NpcRestrained = 26,

    /// <summary>
    /// NPC stun state changed (NewAIController.SetStunned).
    /// </summary>
    NpcStunned = 27,

    /// <summary>
    /// Placer picked up / removed a previously-placed item. Receivers destroy
    /// the mirrored local Interactable so the visual goes away.
    /// </summary>
    ItemPlaceRemove = 28,

    /// <summary>
    /// Player threw a coin / food / grenade / mug. Carries the same diff-style
    /// payload as placements: the spawned projectile Interactable's preset +
    /// world transform, so receivers can spawn an identical physics object.
    /// </summary>
    ItemThrow = 29,

    /// <summary>
    /// A new Evidence object was created on the originator's machine
    /// (typically by a player action like TakePicture). Carries enough info
    /// for the receiver to call EvidenceCreator.CreateEvidence with the same
    /// evID so cross-machine references match (case-board pinning, etc).
    /// </summary>
    EvidenceCreate = 30,

    /// <summary>
    /// Non-lethal damage applied to an NPC. Mirrors Actor.RecieveDamage on
    /// the receiver so the citizen ragdolls / bleeds / takes the same hit
    /// state on every machine. Player victims are NOT synced — health is
    /// per-machine local state.
    /// </summary>
    NpcDamage = 31,

    /// <summary>
    /// Player pressed an elevator floor button. Receiver looks up the
    /// matching <c>Elevator</c> by (buildingID, bottomTile.globalTileCoord)
    /// and replays <c>CallElevator(newFloor, upButton)</c> so the lift moves
    /// in lockstep on every machine.
    /// </summary>
    ElevatorCall = 32,

    /// <summary>
    /// Door locked / unlocked state changed. Mirrors NewDoor.SetLocked.
    /// Covers lockpicking completion, key use, scripted unlock.
    /// </summary>
    DoorLockState = 33,

    /// <summary>
    /// A Human logged in / out of a computer. Mirrors
    /// ComputerController.SetLoggedIn(Human).
    /// </summary>
    ComputerLogin = 34,

    /// <summary>
    /// Computer's foreground app changed. Mirrors
    /// ComputerController.SetComputerApp(CruncherAppPreset, forceUpdate).
    /// </summary>
    ComputerApp = 35,

    /// <summary>
    /// New voicemail thread created. Mirrors Toolbox.NewVmailThread so a
    /// player-driven trigger that creates a vmail propagates. Idempotent on
    /// receive: skipped if threadID already exists in messageThreads dict.
    /// </summary>
    VmailCreated = 36,

    /// <summary>
    /// Player-to-player item handoff. Sender's machine empties the slot
    /// silently and emits this packet; the recipient's machine drops the
    /// item directly into their first available slot via PickUpItem.
    /// </summary>
    PlayerHandoff = 37,

    /// <summary>
    /// Player got into / out of a bed. Mirrors Actor.SetInBed for the local
    /// player so peers' RemotePlayer avatar lies down / stands up.
    /// </summary>
    PlayerInBed = 38,

    /// <summary>
    /// Player fell asleep / woke up. Mirrors Actor.GoToSleep / WakeUp.
    /// Drives a HUD banner on peers ("X is asleep") so they know not to
    /// wait — and animator transitions on the remote avatar.
    /// </summary>
    PlayerAsleep = 39,

    /// <summary>
    /// Money was added to (or removed from) the player's wallet via
    /// <c>GameplayController.AddMoney</c>. Quest rewards, evidence sales,
    /// found cash. Both players receive the same amount independently —
    /// the receiver replays AddMoney locally with identical args.
    /// </summary>
    MoneyAdded = 40,

    /// <summary>
    /// Host's lifecycle status (in-menu, loading world, in game) plus
    /// city name + game time, broadcast every couple of seconds so the
    /// client lobby UI can show "Host is loading…" or "Host in game:
    /// New Babylon, Day 3 14:32".
    /// </summary>
    HostStatus = 41,

    #endregion
    
    #region World Sync Packets (30-59)
    
    /// <summary>
    /// Citizen/NPC state update.
    /// </summary>
    CitizenState = 30,
    
    /// <summary>
    /// Batch citizen state update (multiple NPCs).
    /// </summary>
    CitizenStateBatch = 31,
    
    /// <summary>
    /// Game time synchronization.
    /// </summary>
    TimeSync = 32,
    
    /// <summary>
    /// Interactable object state (doors, containers, etc.).
    /// </summary>
    ObjectState = 33,
    
    /// <summary>
    /// Weather state change.
    /// </summary>
    WeatherSync = 34,
    
    /// <summary>
    /// Request full world state snapshot.
    /// </summary>
    WorldSnapshotRequest = 35,
    
    /// <summary>
    /// Full world state snapshot response.
    /// </summary>
    WorldSnapshot = 36,
    
    /// <summary>
    /// Delta world state update.
    /// </summary>
    WorldDelta = 37,
    
    /// <summary>
    /// World state checksum for validation.
    /// </summary>
    WorldChecksum = 38,

    /// <summary>
    /// AI command batch: NavMeshAgent destination + behaviour state per citizen.
    /// Sent when a citizen's destination or behaviour changes.
    /// Client re-runs NavMeshAgent locally — no position lerp needed.
    /// </summary>
    CitizenCommandBatch = 39,

    /// <summary>
    /// Authoritative position correction batch.
    /// Sent every CORRECTION_INTERVAL seconds for moving citizens
    /// to fix floating-point drift accumulated from independent NavMesh runs.
    /// </summary>
    CitizenCorrectionBatch = 40,

    /// <summary>
    /// Client → Host: "I am taking ownership of citizen #N for local interaction
    /// (dialog, combat, etc.)". Host pauses its own AI for this citizen and stops
    /// sending sync commands for it. Other clients also stop receiving updates.
    /// </summary>
    CitizenOwnershipClaim = 41,

    /// <summary>
    /// Client → Host: "I'm done with citizen #N; resume normal sync."
    /// Host re-enables its NewAIController and resumes broadcasting.
    /// </summary>
    CitizenOwnershipRelease = 42,

    /// <summary>
    /// Door open/close state — uses Interactable.id as the network identifier.
    /// Broadcast by whoever changed it; receivers mirror via NewDoor.SetOpen.
    /// </summary>
    DoorState = 50,

    /// <summary>
    /// Light on/off state — uses LightController's owning Interactable.id.
    /// Broadcast on change; receivers call LightController.SetOn locally.
    /// </summary>
    LightState = 51,

    /// <summary>
    /// Generic Interactable.sw0 toggle — drawers, cabinets, fridges, safes, etc.
    /// Anything that calls Interactable.SetSwitchState. Lights are filtered out
    /// at the broadcast site because they go via LightState=51.
    /// </summary>
    SwitchState = 52,

    /// <summary>
    /// Add a dynamic fingerprint on an Interactable. Replays
    /// Interactable.AddNewDynamicFingerprint(human, life). Each side may
    /// generate its own internal print id/seed — gameplay queries prints by
    /// (interactable, human) pair, so identical id is not required.
    /// </summary>
    FingerprintAdd = 53,

    /// <summary>
    /// Clear all manually-removed fingerprints on an Interactable.
    /// Replays Interactable.RemoveManuallyCreatedFingerprints.
    /// </summary>
    FingerprintClearManual = 54,

    /// <summary>
    /// A bloody/dirty footprint decal was placed in the world. Carries the
    /// originating Human's id, the world position + euler rotation of the
    /// print, dirt and blood strengths, and a room id. Receiver reconstructs
    /// a <c>GameplayController.Footprint</c> and feeds it into a fresh
    /// <c>FootprintController</c> from the pool.
    /// </summary>
    FootprintAdd = 55,

    /// <summary>
    /// Blood / dirt spatter pattern execution. Carries the parameters of
    /// SpatterSimulation.Execute() — origin, target, preset name, erase
    /// mode, force type, count multiplier, and stickToActors flag. Receiver
    /// reconstructs a SpatterSimulation via the world-position constructor
    /// and lets it run normally.
    /// </summary>
    SpatterAdd = 56,

    #endregion
    
    #region Case/Investigation Sync Packets (60-79)
    
    /// <summary>
    /// Case progress update.
    /// </summary>
    CaseProgress = 60,
    
    /// <summary>
    /// Evidence discovered.
    /// </summary>
    EvidenceFound = 61,
    
    /// <summary>
    /// Citizen/suspect interrogated.
    /// </summary>
    Interrogation = 62,
    
    /// <summary>
    /// Case board update (pins, strings, photos).
    /// </summary>
    CaseBoard = 63,

    /// <summary>
    /// Pin a card onto the case board. Keyed by (caseID, evID, DataKey set).
    /// Replays CasePanelController.PinToCasePanel on the receiver.
    /// </summary>
    CaseBoardPin = 66,

    /// <summary>
    /// Unpin a card. Keyed by (caseID, evID, DataKey set).
    /// Replays CasePanelController.UnPinFromCasePanel on the receiver.
    /// </summary>
    CaseBoardUnpin = 67,

    /// <summary>
    /// Move (live-drag) a pinned card. Streamed at ~20 Hz while dragging so
    /// peers see the motion in real-time, like in single-player.
    /// </summary>
    CaseBoardMove = 68,

    /// <summary>
    /// Connect a coloured string between two pinned facts.
    /// Replays Case.AddNewStringColour on the receiver.
    /// </summary>
    CaseBoardString = 69,

    /// <summary>
    /// Hide / show a fact card. Replays Case.SetHidden(fact, val) on the receiver.
    /// </summary>
    CaseBoardHide = 70,

    /// <summary>
    /// Case status change (active / solved / failed). Replays Case.SetStatus.
    /// </summary>
    CaseBoardStatus = 71,

    /// <summary>
    /// Answer progress for a resolve-question (suspect / location / time pick).
    /// Replays ResolveQuestion.SetProgress.
    /// </summary>
    CaseBoardResolveAnswer = 72,

    /// <summary>
    /// Final case resolution / hand-in. Replays Case.Resolve().
    /// </summary>
    CaseBoardResolve = 73,

    /// <summary>
    /// Player-typed custom name for a fact card. Replays Fact.SetCustomName.
    /// </summary>
    CaseBoardFactName = 74,

    /// <summary>
    /// Player removed a coloured thread between two pinned cards.
    /// Replays StringController.RemoveCustomLink on the matching local string.
    /// </summary>
    CaseBoardStringRemove = 75,
    
    /// <summary>
    /// Suspect identified/arrested.
    /// </summary>
    Arrest = 64,
    
    /// <summary>
    /// Case solved/failed.
    /// </summary>
    CaseResult = 65,
    
    #endregion
    
    #region UI/Chat Packets (80-99)
    
    /// <summary>
    /// Text chat message.
    /// </summary>
    ChatMessage = 80,
    
    /// <summary>
    /// Player marker/ping on map.
    /// </summary>
    MapPing = 81,

    /// <summary>
    /// Waypoint placed.
    /// </summary>
    Waypoint = 82,

    /// <summary>
    /// Local pause state — broadcast when a player opens/closes the in-game
    /// menu so others see a "Player X is paused" overlay.
    /// </summary>
    PauseState = 83,
    
    #endregion
    
    #region Critical Events (100+)
    
    /// <summary>
    /// Citizen died (murder, accident).
    /// </summary>
    CitizenDeath = 100,

    /// <summary>
    /// Crime committed.
    /// </summary>
    CrimeCommitted = 101,

    /// <summary>
    /// Player discovered crime scene.
    /// </summary>
    CrimeSceneDiscovered = 102,

    /// <summary>
    /// Phone call started/ended notification — host-authoritative.
    /// Lightweight banner: caller name and start/end flag, no full PhoneCall replay.
    /// </summary>
    PhoneCallNotify = 103,

    /// <summary>
    /// Local player took damage. Carries amount, attacker (if known), hit
    /// position / direction, and a lethal flag. Receivers replay it as a
    /// chat banner ("X is hurt" / "X is down") and toggle a visible "downed"
    /// pose on that player's RemotePlayer avatar. Player health itself is
    /// still per-machine state (we only sync the *event*, not HP value),
    /// matching the existing "asymmetric" pattern in PlayerVitals.
    /// </summary>
    PlayerDamage = 104,

    /// <summary>
    /// Side-job lifecycle notification (host → all). MVP "awareness" packet:
    /// chat-banner only — does not reconstruct a SideJob object on the
    /// client (host-authoritative gameplay loop is deferred to SJ.2/3).
    /// Carries a kind discriminator (created / posted / ended), the jobID,
    /// preset name, poster citizen name, and reward amount.
    /// </summary>
    SideJobNotification = 105,

    /// <summary>
    /// Player suspicion / trespass flags (client → host). Five Actor-level
    /// flags that drive guard / NPC reactions: isTrespassing,
    /// illegalActionActive, illegalAreaActive, illegalStatus, and
    /// trespassingEscalation (int). Without sync, a remote client entering
    /// a restricted area gets caught locally but their twin citizen on the
    /// host stays "innocent" — host's NPCs never react.
    /// </summary>
    PlayerSuspicion = 106,

    #endregion
}
