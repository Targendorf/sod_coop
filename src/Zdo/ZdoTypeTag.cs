namespace SoDCoop.Zdo;

/// <summary>
/// Discriminator for ZDO categories. Each tag has a corresponding
/// <see cref="Resolvers.IZdoResolver"/> that knows how to find the
/// live SoD object and apply property-bag state to it.
///
/// <para>Byte width is intentional — 256 tags is plenty. Tags are
/// additive only; never repurpose an existing value.</para>
/// </summary>
public enum ZdoTypeTag : byte
{
    None              = 0,

    // World physical state
    Door              = 1,
    Light             = 2,
    Switch            = 3,
    Elevator          = 4,

    // Citizens
    Citizen           = 10,
    PlayerTwin        = 11,
    LocalPlayer       = 12,

    // Forensics
    Fingerprint       = 20,
    Footprint         = 21,
    Spatter           = 22,
    EvidenceObject    = 23,

    // Investigation
    CaseBoardCard     = 30,
    CaseBoardString   = 31,
    Case              = 32,

    // Mid-session world
    VmailThread       = 40,
    PhoneCall         = 41,
    Weather           = 42,
    Time              = 43,
    SideJob           = 44,
    Money             = 45,

    // Items
    PlacedItem        = 50,
    ThrownItem        = 51,
    HeldItem          = 52,
    InventoryAction   = 53,

    // Computers
    Computer          = 60,

    // Surveillance
    SurveillanceTape  = 70,

    // Misc / events
    PauseState        = 80,
    Chat              = 81,
    MapPing           = 82,
}
