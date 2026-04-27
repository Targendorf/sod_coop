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
    
    #endregion
}
