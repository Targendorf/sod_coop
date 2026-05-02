namespace SoDCoop.Zdo;

/// <summary>
/// Pre-computed FNV-1a-32 hashes of every ZDO property-key string. Computed
/// once at static type init so the hot path never re-hashes.
///
/// <para>Reserved keys are namespaced with a leading double underscore so
/// they don't collide with feature-specific keys.</para>
/// </summary>
public static class ZdoKeys
{
    // ── Reserved ──
    public static readonly int Type      = Hash32.Of("__type");
    public static readonly int Version   = Hash32.Of("__version");
    public static readonly int Owner     = Hash32.Of("__owner");
    public static readonly int Pos       = Hash32.Of("__pos");
    public static readonly int Rot       = Hash32.Of("__rot");
    public static readonly int SodId     = Hash32.Of("__sodId");
    public static readonly int SodIdStr  = Hash32.Of("__sodIdStr");

    // ── Doors / lights / switches ──
    public static readonly int Closed     = Hash32.Of("closed");
    public static readonly int Locked     = Hash32.Of("locked");
    public static readonly int PlaySound  = Hash32.Of("playSound");
    public static readonly int On         = Hash32.Of("on");

    // ── Citizens / player ──
    public static readonly int OutfitCategory     = Hash32.Of("outfitCategory");
    public static readonly int InBed              = Hash32.Of("inBed");
    public static readonly int LowBed             = Hash32.Of("lowBed");
    public static readonly int Asleep             = Hash32.Of("asleep");
    public static readonly int Restrained         = Hash32.Of("restrained");
    public static readonly int RestrainedDuration = Hash32.Of("restrainedDuration");
    public static readonly int Stunned            = Hash32.Of("stunned");
    public static readonly int Trespassing        = Hash32.Of("trespassing");
    public static readonly int IllegalActionActive = Hash32.Of("illegalActionActive");
    public static readonly int IllegalAreaActive  = Hash32.Of("illegalAreaActive");
    public static readonly int IllegalStatus      = Hash32.Of("illegalStatus");
    public static readonly int Escalation         = Hash32.Of("escalation");
    public static readonly int Velocity           = Hash32.Of("velocity");
    public static readonly int Nourishment        = Hash32.Of("nourishment");
    public static readonly int Hydration          = Hash32.Of("hydration");
    public static readonly int Energy             = Hash32.Of("energy");
    public static readonly int Dead               = Hash32.Of("dead");
    public static readonly int Downed             = Hash32.Of("downed");
    public static readonly int KillerHumanId      = Hash32.Of("killerHumanId");
    public static readonly int WeaponInteractableId = Hash32.Of("weaponInteractableId");
    public static readonly int DeathPos           = Hash32.Of("deathPos");
    public static readonly int ClaimedHumanId     = Hash32.Of("claimedHumanId");
    public static readonly int AiFrozen           = Hash32.Of("aiFrozen");
    public static readonly int Appearance         = Hash32.Of("appearance");
    public static readonly int Drunk              = Hash32.Of("drunk");
    public static readonly int Bleeding           = Hash32.Of("bleeding");

    // ── Forensics ──
    public static readonly int InteractableId     = Hash32.Of("interactableId");
    public static readonly int HumanId            = Hash32.Of("humanId");
    public static readonly int Life               = Hash32.Of("life");
    public static readonly int Dirt               = Hash32.Of("dirt");
    public static readonly int Blood              = Hash32.Of("blood");
    public static readonly int RoomId             = Hash32.Of("roomId");
    public static readonly int SpatterPreset      = Hash32.Of("spatterPreset");
    public static readonly int SpatterErase       = Hash32.Of("spatterErase");
    public static readonly int SpatterForceType   = Hash32.Of("spatterForceType");
    public static readonly int SpatterCount       = Hash32.Of("spatterCount");
    public static readonly int SpatterStickActors = Hash32.Of("spatterStickActors");
    public static readonly int SpatterOrigin      = Hash32.Of("spatterOrigin");
    public static readonly int SpatterTarget      = Hash32.Of("spatterTarget");
    public static readonly int SpatterCountMul    = Hash32.Of("spatterCountMul");
    public static readonly int FootprintTimestamp = Hash32.Of("footprintTimestamp");
    public static readonly int FootprintEuler     = Hash32.Of("footprintEuler");
    public static readonly int DirtFloat          = Hash32.Of("dirtFloat");
    public static readonly int BloodFloat         = Hash32.Of("bloodFloat");

    // ── Evidence ──
    public static readonly int EvId             = Hash32.Of("evId");
    public static readonly int EvPreset         = Hash32.Of("evPreset");
    public static readonly int EvCreator        = Hash32.Of("evCreator");
    public static readonly int EvDiscovery      = Hash32.Of("evDiscovery");
    public static readonly int EvNoteKeys       = Hash32.Of("evNoteKeys");
    public static readonly int EvNoteText       = Hash32.Of("evNoteText");
    public static readonly int EvCustomNameKey  = Hash32.Of("evCustomNameKey");
    public static readonly int EvCustomName     = Hash32.Of("evCustomName");

    // ── Case board ──
    public static readonly int CaseId         = Hash32.Of("caseId");
    public static readonly int CaseStatus     = Hash32.Of("caseStatus");
    public static readonly int CaseResolved   = Hash32.Of("caseResolved");
    public static readonly int CaseHidden     = Hash32.Of("caseHiddenFacts");
    public static readonly int CardKeys       = Hash32.Of("cardKeys");
    public static readonly int CardForceAuto  = Hash32.Of("cardForceAutoPin");
    public static readonly int StringFromEvId = Hash32.Of("stringFromEvId");
    public static readonly int StringFromKeys = Hash32.Of("stringFromKeys");
    public static readonly int StringToEvId   = Hash32.Of("stringToEvId");
    public static readonly int StringToKeys   = Hash32.Of("stringToKeys");
    public static readonly int StringColourId = Hash32.Of("stringColourId");
    public static readonly int FactCustomName = Hash32.Of("factCustomName");

    // ── Mid-session world ──
    public static readonly int ThreadId        = Hash32.Of("threadId");
    public static readonly int Participants    = Hash32.Of("participants");
    public static readonly int Subject         = Hash32.Of("subject");
    public static readonly int CallerId        = Hash32.Of("callerId");
    public static readonly int CalleeId        = Hash32.Of("calleeId");
    public static readonly int CallActive      = Hash32.Of("callActive");
    public static readonly int WeatherPreset   = Hash32.Of("weatherPreset");
    public static readonly int WeatherTransitionTime = Hash32.Of("weatherTransitionTime");
    public static readonly int WeatherInstant  = Hash32.Of("weatherInstant");
    public static readonly int WeatherRain     = Hash32.Of("weatherRain");
    public static readonly int WeatherWind     = Hash32.Of("weatherWind");
    public static readonly int WeatherSnow     = Hash32.Of("weatherSnow");
    public static readonly int WeatherLightning = Hash32.Of("weatherLightning");
    public static readonly int WeatherFog      = Hash32.Of("weatherFog");
    public static readonly int GameTime        = Hash32.Of("gameTime");
    public static readonly int DayIndex        = Hash32.Of("dayIndex");
    public static readonly int TimePaused      = Hash32.Of("timePaused");
    public static readonly int JobId           = Hash32.Of("jobId");
    public static readonly int JobPreset       = Hash32.Of("jobPreset");
    public static readonly int JobPoster       = Hash32.Of("jobPoster");
    public static readonly int JobReward       = Hash32.Of("jobReward");
    public static readonly int JobPhase        = Hash32.Of("jobPhase");
    public static readonly int JobAccepted     = Hash32.Of("jobAccepted");
    public static readonly int JobState        = Hash32.Of("jobState");

    // ── Money / wallet ──
    public static readonly int Amount          = Hash32.Of("amount");
    public static readonly int DisplayMessage  = Hash32.Of("displayMessage");
    public static readonly int Reason          = Hash32.Of("reason");
    public static readonly int PlayerPeer      = Hash32.Of("playerPeer");

    // ── Items ──
    public static readonly int Held            = Hash32.Of("held");
    public static readonly int Raised          = Hash32.Of("raised");
    public static readonly int Flashlight      = Hash32.Of("flashlight");
    public static readonly int PresetName      = Hash32.Of("presetName");

    // ── Computers ──
    public static readonly int LoggedInHumanId = Hash32.Of("loggedInHumanId");
    public static readonly int AppPreset       = Hash32.Of("appPreset");
    public static readonly int ForceUpdate     = Hash32.Of("forceUpdate");

    // ── Surveillance ──
    public static readonly int CameraId        = Hash32.Of("cameraId");
    public static readonly int TapeIndex       = Hash32.Of("tapeIndex");
    public static readonly int AcquiredName    = Hash32.Of("acquiredName");
    public static readonly int AcquiredHumanId = Hash32.Of("acquiredHumanId");

    // ── Misc ──
    public static readonly int Paused          = Hash32.Of("paused");
}
