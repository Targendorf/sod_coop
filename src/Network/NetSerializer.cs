using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Network;

/// <summary>
/// Extension methods for serializing Unity types with LiteNetLib.
/// </summary>
public static class NetSerializerExtensions
{
    #region Vector3
    
    public static void Put(this NetDataWriter writer, Vector3 vector)
    {
        writer.Put(vector.x);
        writer.Put(vector.y);
        writer.Put(vector.z);
    }
    
    public static Vector3 GetVector3(this NetDataReader reader)
    {
        return new Vector3(
            reader.GetFloat(),
            reader.GetFloat(),
            reader.GetFloat()
        );
    }
    
    #endregion
    
    #region Quaternion
    
    public static void Put(this NetDataWriter writer, Quaternion quaternion)
    {
        writer.Put(quaternion.x);
        writer.Put(quaternion.y);
        writer.Put(quaternion.z);
        writer.Put(quaternion.w);
    }
    
    public static Quaternion GetQuaternion(this NetDataReader reader)
    {
        return new Quaternion(
            reader.GetFloat(),
            reader.GetFloat(),
            reader.GetFloat(),
            reader.GetFloat()
        );
    }
    
    #endregion
    
    #region Compressed Quaternion (3 floats + sign)
    
    /// <summary>
    /// Writes a quaternion using smallest-three compression (saves 25% bandwidth).
    /// </summary>
    public static void PutCompressed(this NetDataWriter writer, Quaternion quaternion)
    {
        // Find largest component
        float absX = Mathf.Abs(quaternion.x);
        float absY = Mathf.Abs(quaternion.y);
        float absZ = Mathf.Abs(quaternion.z);
        float absW = Mathf.Abs(quaternion.w);
        
        int largestIndex = 0;
        float largestValue = absX;
        
        if (absY > largestValue) { largestIndex = 1; largestValue = absY; }
        if (absZ > largestValue) { largestIndex = 2; largestValue = absZ; }
        if (absW > largestValue) { largestIndex = 3; }
        
        // Write index and sign
        float sign = quaternion[largestIndex] >= 0 ? 1f : -1f;
        writer.Put((byte)(largestIndex | (sign < 0 ? 0x04 : 0)));
        
        // Write the other 3 components
        for (int i = 0; i < 4; i++)
        {
            if (i != largestIndex)
            {
                writer.Put((short)(quaternion[i] * sign * 32767f));
            }
        }
    }
    
    public static Quaternion GetCompressedQuaternion(this NetDataReader reader)
    {
        byte header = reader.GetByte();
        int largestIndex = header & 0x03;
        float sign = (header & 0x04) != 0 ? -1f : 1f;

        // Allocation-free: read into stack locals, not a heap float[]. At 20Hz
        // × N players this saves visible GC pressure on the receiver hot path.
        float c0 = 0f, c1 = 0f, c2 = 0f, c3 = 0f;
        float sumSquares = 0f;
        for (int i = 0; i < 4; i++)
        {
            if (i == largestIndex) continue;
            float v = reader.GetShort() / 32767f;
            sumSquares += v * v;
            switch (i) { case 0: c0 = v; break; case 1: c1 = v; break; case 2: c2 = v; break; case 3: c3 = v; break; }
        }
        float reconstructed = Mathf.Sqrt(Mathf.Max(0f, 1f - sumSquares)) * sign;
        switch (largestIndex) { case 0: c0 = reconstructed; break; case 1: c1 = reconstructed; break; case 2: c2 = reconstructed; break; case 3: c3 = reconstructed; break; }

        return new Quaternion(c0, c1, c2, c3);
    }

    /// <summary>
    /// Pack a velocity / small-magnitude vector as 3× int16 with 0.01 m
    /// scale: range ±327.67 m/s, precision 1 cm/s. Plenty for player /
    /// citizen movement (max walking ~6 m/s, running ~10 m/s in SoD).
    /// 6 bytes vs the 12 of an uncompressed Vector3 — half the wire cost
    /// per high-rate position packet.
    /// </summary>
    public static void PutCompressed(this NetDataWriter writer, Vector3 v)
    {
        writer.Put((short)Mathf.Clamp(Mathf.RoundToInt(v.x * 100f), short.MinValue, short.MaxValue));
        writer.Put((short)Mathf.Clamp(Mathf.RoundToInt(v.y * 100f), short.MinValue, short.MaxValue));
        writer.Put((short)Mathf.Clamp(Mathf.RoundToInt(v.z * 100f), short.MinValue, short.MaxValue));
    }

    public static Vector3 GetCompressedVector3(this NetDataReader reader)
    {
        short x = reader.GetShort(), y = reader.GetShort(), z = reader.GetShort();
        return new Vector3(x * 0.01f, y * 0.01f, z * 0.01f);
    }

    #endregion

    #region Color
    
    public static void Put(this NetDataWriter writer, Color color)
    {
        writer.Put((byte)(color.r * 255));
        writer.Put((byte)(color.g * 255));
        writer.Put((byte)(color.b * 255));
        writer.Put((byte)(color.a * 255));
    }
    
    public static Color GetColor(this NetDataReader reader)
    {
        return new Color(
            reader.GetByte() / 255f,
            reader.GetByte() / 255f,
            reader.GetByte() / 255f,
            reader.GetByte() / 255f
        );
    }
    
    #endregion
    
    #region Vector2
    
    public static void Put(this NetDataWriter writer, Vector2 vector)
    {
        writer.Put(vector.x);
        writer.Put(vector.y);
    }
    
    public static Vector2 GetVector2(this NetDataReader reader)
    {
        return new Vector2(
            reader.GetFloat(),
            reader.GetFloat()
        );
    }
    
    #endregion
}

/// <summary>
/// Interface for serializable network packets.
/// </summary>
public interface INetPacket : INetSerializable
{
    PacketType Type { get; }
}

/// <summary>
/// Player position sync packet. Sent at adaptive rate (4–30 Hz).
/// Sequence is monotonic per-sender, used to drop out-of-order packets.
/// Flags pack movement modifiers — see MovementFlags enum.
/// </summary>
public struct PlayerPositionPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerPosition;

    public int PlayerId;
    public ushort Sequence;
    public byte Flags;
    public Vector3 Position;
    public Quaternion Rotation;
    public Vector3 Velocity;
    public float Timestamp;

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(PlayerId);
        writer.Put(Sequence);
        writer.Put(Flags);
        writer.Put(Position);
        writer.PutCompressed(Rotation);   // 7 bytes (smallest-three)
        writer.PutCompressed(Velocity);   // 6 bytes (int16 × 0.01 m scale)
        writer.Put(Timestamp);
    }

    public void Deserialize(NetDataReader reader)
    {
        PlayerId  = reader.GetInt();
        Sequence  = reader.GetUShort();
        Flags     = reader.GetByte();
        Position  = reader.GetVector3();
        Rotation  = reader.GetCompressedQuaternion();
        Velocity  = reader.GetCompressedVector3();
        Timestamp = reader.GetFloat();
    }

    public bool IsCrouching => (Flags & (byte)MovementFlags.Crouching) != 0;
    public bool IsRunning   => (Flags & (byte)MovementFlags.Running)   != 0;
    public bool IsGrounded  => (Flags & (byte)MovementFlags.Grounded)  != 0;
}

[System.Flags]
public enum MovementFlags : byte
{
    None      = 0,
    Crouching = 1 << 0,
    Running   = 1 << 1,
    Grounded  = 1 << 2,
}

/// <summary>
/// Player animation state packet.
/// </summary>
public struct PlayerAnimationPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerAnimation;
    
    public int PlayerId;
    public int AnimationHash;
    public float NormalizedTime;
    public bool IsCrouching;
    public bool IsRunning;
    
    public void Serialize(NetDataWriter writer)
    {
        writer.Put(PlayerId);
        writer.Put(AnimationHash);
        writer.Put(NormalizedTime);
        writer.Put(IsCrouching);
        writer.Put(IsRunning);
    }
    
    public void Deserialize(NetDataReader reader)
    {
        PlayerId = reader.GetInt();
        AnimationHash = reader.GetInt();
        NormalizedTime = reader.GetFloat();
        IsCrouching = reader.GetBool();
        IsRunning = reader.GetBool();
    }
}

/// <summary>
/// Player interaction packet.
/// </summary>
public struct PlayerInteractionPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerInteraction;
    
    public int PlayerId;
    public InteractionType InteractionType;
    public int TargetId;
    public Vector3 TargetPosition;
    
    public void Serialize(NetDataWriter writer)
    {
        writer.Put(PlayerId);
        writer.Put((byte)InteractionType);
        writer.Put(TargetId);
        writer.Put(TargetPosition);
    }
    
    public void Deserialize(NetDataReader reader)
    {
        PlayerId = reader.GetInt();
        InteractionType = (InteractionType)reader.GetByte();
        TargetId = reader.GetInt();
        TargetPosition = reader.GetVector3();
    }
}

/// <summary>
/// Types of player interactions.
/// </summary>
public enum InteractionType : byte
{
    None = 0,
    PickUp = 1,
    Drop = 2,
    Use = 3,
    OpenDoor = 4,
    CloseDoor = 5,
    OpenContainer = 6,
    CloseContainer = 7,
    TalkToNPC = 8,
    PunchNPC = 9,
    Sit = 10,
    StandUp = 11
}

/// <summary>
/// Time sync packet.
/// </summary>
public struct TimeSyncPacket : INetPacket
{
    public PacketType Type => PacketType.TimeSync;
    
    /// <summary><c>SessionData.gameTime</c> — minutes since midnight.</summary>
    public float GameTime;
    /// <summary><c>SessionData.day</c> — the WeekDay ENUM (Mon..Sun), not a
    /// counter. Display/diagnostics plus the weekday NPC schedules key off.</summary>
    public int Day;
    public int Hour;
    public int Minute;
    public bool IsPaused;
    /// <summary><c>SessionData.dayInt</c> — the absolute day counter. This is
    /// the authoritative date field; <see cref="Day"/> and <see cref="Month"/>
    /// are the calendar presentation of it.
    ///
    /// <para>Added because the clock sync only ever wrote
    /// <c>gameTime</c> (minutes since midnight) and left the DATE alone. A
    /// client whose clock gets snapped across midnight does not run SoD's own
    /// rollover, so its day silently fails to advance and the two machines end
    /// up on different weekdays — where SoD's citizens follow entirely
    /// different schedules. That desynchronises where every NPC in the city is,
    /// permanently and invisibly.</para></summary>
    public int DayInt;
    /// <summary><c>SessionData.month</c> enum.</summary>
    public int Month;
    /// <summary><c>SessionData.gameTimeDouble</c> — the game's real time master
    /// (a cumulative count of game hours in double precision). The float
    /// <see cref="GameTime"/> is only its per-frame mirror; see TimeSync.
    /// NaN when the sender predates this field.</summary>
    public double GameTimeDouble;
    /// <summary><c>SessionData.leapYearCycle</c>, the second argument of
    /// <c>SetGameTime</c>. -1 when unknown.</summary>
    public int LeapYearCycle;
    /// <summary><c>SessionData.currentTimeSpeed</c> as int. -1 when unknown.</summary>
    public int TimeSpeed;

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(GameTime);
        writer.Put(Day);
        writer.Put(Hour);
        writer.Put(Minute);
        writer.Put(IsPaused);
        writer.Put(DayInt);
        writer.Put(Month);
        writer.Put(GameTimeDouble);
        writer.Put(LeapYearCycle);
        writer.Put(TimeSpeed);
    }

    public void Deserialize(NetDataReader reader)
    {
        GameTime = reader.GetFloat();
        Day = reader.GetInt();
        Hour = reader.GetInt();
        Minute = reader.GetInt();
        IsPaused = reader.GetBool();
        // Trailing fields — a peer on an older build doesn't write them.
        // Leave them at -1 ("unknown") so the apply side skips the date
        // correction rather than stamping a bogus day 0 / January.
        DayInt = reader.AvailableBytes >= 4 ? reader.GetInt() : -1;
        Month  = reader.AvailableBytes >= 4 ? reader.GetInt() : -1;
        GameTimeDouble = reader.AvailableBytes >= 8 ? reader.GetDouble() : double.NaN;
        LeapYearCycle  = reader.AvailableBytes >= 4 ? reader.GetInt() : -1;
        TimeSpeed      = reader.AvailableBytes >= 4 ? reader.GetInt() : -1;
    }
}

/// <summary>
/// Chat message packet.
/// </summary>
public struct ChatMessagePacket : INetPacket
{
    public PacketType Type => PacketType.ChatMessage;
    
    public int PlayerId;
    public string PlayerName;
    public string Message;
    public float Timestamp;
    
    public void Serialize(NetDataWriter writer)
    {
        writer.Put(PlayerId);
        writer.Put(PlayerName);
        writer.Put(Message);
        writer.Put(Timestamp);
    }
    
    public void Deserialize(NetDataReader reader)
    {
        PlayerId = reader.GetInt();
        PlayerName = reader.GetString();
        Message = reader.GetString();
        Timestamp = reader.GetFloat();
    }
}

/// <summary>
/// World seed packet for synchronizing world generation.
/// </summary>
public struct WorldSeedPacket : INetPacket
{
    public PacketType Type => PacketType.WorldSeed;
    
    public int Seed;
    public string CityName;
    public int CitySize;
    
    public void Serialize(NetDataWriter writer)
    {
        writer.Put(Seed);
        writer.Put(CityName);
        writer.Put(CitySize);
    }
    
    public void Deserialize(NetDataReader reader)
    {
        Seed = reader.GetInt();
        CityName = reader.GetString();
        CitySize = reader.GetInt();
    }
}

/// <summary>
/// Citizen/NPC state packet.
/// </summary>
public struct CitizenStatePacket : INetPacket
{
    public PacketType Type => PacketType.CitizenState;
    
    public int CitizenId;
    public Vector3 Position;
    public Quaternion Rotation;
    public int CurrentAction;
    public int CurrentLocationId;
    public bool IsDead;
    public bool IsUnconscious;
    
    public void Serialize(NetDataWriter writer)
    {
        writer.Put(CitizenId);
        writer.Put(Position);
        writer.PutCompressed(Rotation);
        writer.Put(CurrentAction);
        writer.Put(CurrentLocationId);
        writer.Put(IsDead);
        writer.Put(IsUnconscious);
    }
    
    public void Deserialize(NetDataReader reader)
    {
        CitizenId = reader.GetInt();
        Position = reader.GetVector3();
        Rotation = reader.GetCompressedQuaternion();
        CurrentAction = reader.GetInt();
        CurrentLocationId = reader.GetInt();
        IsDead = reader.GetBool();
        IsUnconscious = reader.GetBool();
    }
}

/// <summary>
/// Known citizen behaviour states mirroring SoD's CitizenAnimationController states.
/// Kept as byte to save bandwidth. Unknown/future states map to Idle.
/// </summary>
public enum CitizenBehaviourState : byte
{
    Idle      = 0,   // standing still, looking around
    Walking   = 1,   // NavMeshAgent moving at normal speed
    Running   = 2,   // NavMeshAgent moving at run speed (fleeing/chasing)
    Sitting   = 3,   // seated — no position interpolation needed on client
    Talking   = 4,   // in dialogue — stationary
    Sleeping  = 5,   // lying down
    Fleeing   = 6,   // panicking, running away from crime
    Dead      = 7,   // corpse — never move
}

/// <summary>
/// AI command packet — one entry serialised inside a CitizenCommandBatch.
///
/// Host sends this whenever a citizen's NavMeshAgent destination or behaviour state
/// changes. Client re-runs the same NavMeshAgent command locally — because both
/// machines share the same world seed the NavMesh topology is identical, so the
/// resulting paths will match without streaming per-frame positions.
///
/// Size: 4 + 12 + 4 + 1 + 1 = 22 bytes per citizen.
/// </summary>
public struct CitizenCommandPacket : INetPacket
{
    public PacketType Type => PacketType.CitizenCommandBatch;

    public int                   CitizenId;
    public Vector3               Destination;     // NavMeshAgent.destination on host
    public float                 Speed;           // NavMeshAgent.speed on host
    public CitizenBehaviourState BehaviourState;  // current high-level state
    public bool                  IsDead;          // dead → client stops all movement

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(CitizenId);
        writer.Put(Destination);
        writer.Put(Speed);
        writer.Put((byte)BehaviourState);
        writer.Put(IsDead);
    }

    public void Deserialize(NetDataReader reader)
    {
        CitizenId      = reader.GetInt();
        Destination    = reader.GetVector3();
        Speed          = reader.GetFloat();
        BehaviourState = (CitizenBehaviourState)reader.GetByte();
        IsDead         = reader.GetBool();
    }
}

/// <summary>
/// Authoritative position correction — one entry in a CitizenCorrectionBatch.
///
/// Sent every CORRECTION_INTERVAL seconds for moving citizens.
/// Corrects floating-point drift that accumulates when two NavMesh simulations
/// run independently. Client snaps or lerps toward the host's position
/// if delta exceeds CORRECTION_SNAP_DIST.
///
/// Size: 4 + 12 + 1 = 17 bytes per citizen.
/// </summary>
public struct CitizenCorrectionPacket : INetPacket
{
    public PacketType Type => PacketType.CitizenCorrectionBatch;

    public int     CitizenId;
    public Vector3 Position;    // authoritative world-space position from host
    public byte    YawByte;     // yaw compressed to 0-255; saves 3 floats vs full Quaternion

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(CitizenId);
        writer.Put(Position);
        writer.Put(YawByte);
    }

    public void Deserialize(NetDataReader reader)
    {
        CitizenId = reader.GetInt();
        Position  = reader.GetVector3();
        YawByte   = reader.GetByte();
    }

    /// <summary>Decompress yaw byte back to a Y-axis world rotation.</summary>
    public Quaternion GetRotation() =>
        Quaternion.Euler(0f, YawByte / 255f * 360f, 0f);

    /// <summary>Compress a world-space rotation to a single yaw byte.</summary>
    public static byte CompressYaw(Quaternion rot) =>
        (byte)(((rot.eulerAngles.y % 360f + 360f) % 360f) / 360f * 255f);
}

/// <summary>
/// World-space ping marker dropped by a player ("look here!").
/// Auto-expires on the receiving side after MapPing.LIFETIME seconds.
/// </summary>
public struct MapPingPacket : INetPacket
{
    public PacketType Type => PacketType.MapPing;

    public int     PlayerId;
    public string  PlayerName;
    public Vector3 Position;

    public void Serialize(NetDataWriter w)
    {
        w.Put(PlayerId);
        w.Put(PlayerName ?? "");
        w.Put(Position);
    }

    public void Deserialize(NetDataReader r)
    {
        PlayerId   = r.GetInt();
        PlayerName = r.GetString();
        Position   = r.GetVector3();
    }
}

/// <summary>Local pause state — broadcast when a player opens/closes a menu.</summary>
public struct PauseStatePacket : INetPacket
{
    public PacketType Type => PacketType.PauseState;

    public int  PlayerId;
    public bool IsPaused;

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(IsPaused); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); IsPaused = r.GetBool(); }
}

/// <summary>Door open/close — keyed by Interactable.id.</summary>
public struct DoorStatePacket : INetPacket
{
    public PacketType Type => PacketType.DoorState;

    public int  InteractableId;
    public bool IsClosed;       // true = closed; false = open

    public void Serialize(NetDataWriter w)   { w.Put(InteractableId); w.Put(IsClosed); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); IsClosed = r.GetBool(); }
}

/// <summary>
/// Door locked / unlocked. Same id model as DoorStatePacket (open/close).
/// Mirrors NewDoor.SetLocked on the receiver. Actor reference is passed as
/// null because we don't carry attribution across the wire.
/// </summary>
public struct DoorLockStatePacket : INetPacket
{
    public PacketType Type => PacketType.DoorLockState;

    public int  InteractableId;
    public bool IsLocked;
    public bool PlaySound;

    public void Serialize(NetDataWriter w)   { w.Put(InteractableId); w.Put(IsLocked); w.Put(PlaySound); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); IsLocked = r.GetBool(); PlaySound = r.GetBool(); }
}

/// <summary>Computer login / logout — Mirrors ComputerController.SetLoggedIn.</summary>
public struct ComputerLoginPacket : INetPacket
{
    public PacketType Type => PacketType.ComputerLogin;

    public int InteractableId;     // computer's interactable.id
    public int HumanId;            // -1 = logged out

    public void Serialize(NetDataWriter w)   { w.Put(InteractableId); w.Put(HumanId); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); HumanId = r.GetInt(); }
}

/// <summary>Computer foreground app — Mirrors ComputerController.SetComputerApp.</summary>
public struct ComputerAppPacket : INetPacket
{
    public PacketType Type => PacketType.ComputerApp;

    public int    InteractableId;
    public string PresetName;      // CruncherAppPreset.name (empty = null app, returns to OS)
    public bool   ForceUpdate;

    public void Serialize(NetDataWriter w)
    {
        w.Put(InteractableId);
        w.Put(PresetName ?? "");
        w.Put(ForceUpdate);
    }

    public void Deserialize(NetDataReader r)
    {
        InteractableId = r.GetInt();
        PresetName     = r.GetString();
        ForceUpdate    = r.GetBool();
    }
}

/// <summary>Light on/off — keyed by Interactable.id of the light's controller.</summary>
public struct LightStatePacket : INetPacket
{
    public PacketType Type => PacketType.LightState;

    public int  InteractableId;
    public bool IsOn;

    public void Serialize(NetDataWriter w)   { w.Put(InteractableId); w.Put(IsOn); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); IsOn = r.GetBool(); }
}

/// <summary>
/// Pin a card onto the shared case board. Identified cross-machine by
/// (CaseId, EvId, DataKeys) — all three are deterministic from the world seed.
/// Position is the local panel coordinate where the card should land. If the
/// receiver was issued a remote pin while ForceAutoPin=true the layout step is
/// allowed to override the position (keeps SoD's auto-arrange working when
/// the original sender used auto-pin).
/// </summary>
public struct CaseBoardPinPacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardPin;

    public int     CaseId;
    public string  EvId;
    public byte[]  DataKeys;
    public Vector2 Position;
    public bool    ForceAutoPin;

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(EvId ?? "");
        w.Put((byte)(DataKeys?.Length ?? 0));
        if (DataKeys != null) for (int i = 0; i < DataKeys.Length; i++) w.Put(DataKeys[i]);
        w.Put(Position);
        w.Put(ForceAutoPin);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId   = r.GetInt();
        EvId     = r.GetString();
        int n    = r.GetByte();
        DataKeys = new byte[n];
        for (int i = 0; i < n; i++) DataKeys[i] = r.GetByte();
        Position     = r.GetVector2();
        ForceAutoPin = r.GetBool();
    }
}

/// <summary>Unpin a card from the shared case board.</summary>
public struct CaseBoardUnpinPacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardUnpin;

    public int     CaseId;
    public string  EvId;
    public byte[]  DataKeys;

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(EvId ?? "");
        w.Put((byte)(DataKeys?.Length ?? 0));
        if (DataKeys != null) for (int i = 0; i < DataKeys.Length; i++) w.Put(DataKeys[i]);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId   = r.GetInt();
        EvId     = r.GetString();
        int n    = r.GetByte();
        DataKeys = new byte[n];
        for (int i = 0; i < n; i++) DataKeys[i] = r.GetByte();
    }
}

/// <summary>
/// Live drag of a pinned card. Streamed at ~20 Hz while the user is dragging
/// so the other player sees the motion in real-time. Sent over Sequenced
/// (not ReliableOrdered) — it's OK to drop intermediate frames.
/// </summary>
public struct CaseBoardMovePacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardMove;

    public int     CaseId;
    public string  EvId;
    public byte[]  DataKeys;
    public Vector2 Position;
    public int     SenderId;     // for "host wins" tie-break

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(EvId ?? "");
        w.Put((byte)(DataKeys?.Length ?? 0));
        if (DataKeys != null) for (int i = 0; i < DataKeys.Length; i++) w.Put(DataKeys[i]);
        w.Put(Position);
        w.Put(SenderId);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId   = r.GetInt();
        EvId     = r.GetString();
        int n    = r.GetByte();
        DataKeys = new byte[n];
        for (int i = 0; i < n; i++) DataKeys[i] = r.GetByte();
        Position = r.GetVector2();
        SenderId = r.GetInt();
    }
}

/// <summary>
/// Connect a coloured string between two pinned facts on the case board.
/// A fact is uniquely identified across machines by a directed evidence-key
/// pair: (fromEvId, fromDataKeys) → (toEvId, toDataKeys). Colour is
/// InterfaceControls.EvidenceColours packed as a byte.
/// Replays Case.AddNewStringColour on the receiver.
/// </summary>
public struct CaseBoardStringPacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardString;

    public int     CaseId;
    public string  FromEvId;
    public byte[]  FromKeys;
    public string  ToEvId;
    public byte[]  ToKeys;
    public byte    Colour;

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(FromEvId ?? "");
        w.Put((byte)(FromKeys?.Length ?? 0));
        if (FromKeys != null) for (int i = 0; i < FromKeys.Length; i++) w.Put(FromKeys[i]);
        w.Put(ToEvId ?? "");
        w.Put((byte)(ToKeys?.Length ?? 0));
        if (ToKeys != null) for (int i = 0; i < ToKeys.Length; i++) w.Put(ToKeys[i]);
        w.Put(Colour);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId   = r.GetInt();
        FromEvId = r.GetString();
        int n    = r.GetByte();
        FromKeys = new byte[n];
        for (int i = 0; i < n; i++) FromKeys[i] = r.GetByte();
        ToEvId   = r.GetString();
        int m    = r.GetByte();
        ToKeys   = new byte[m];
        for (int i = 0; i < m; i++) ToKeys[i] = r.GetByte();
        Colour   = r.GetByte();
    }
}

/// <summary>
/// Hide / show a fact card on the case board. Same fact identifier as the
/// string packet (4-tuple). Replays Case.SetHidden(fact, IsHidden).
/// </summary>
public struct CaseBoardHidePacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardHide;

    public int     CaseId;
    public string  FromEvId;
    public byte[]  FromKeys;
    public string  ToEvId;
    public byte[]  ToKeys;
    public bool    IsHidden;

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(FromEvId ?? "");
        w.Put((byte)(FromKeys?.Length ?? 0));
        if (FromKeys != null) for (int i = 0; i < FromKeys.Length; i++) w.Put(FromKeys[i]);
        w.Put(ToEvId ?? "");
        w.Put((byte)(ToKeys?.Length ?? 0));
        if (ToKeys != null) for (int i = 0; i < ToKeys.Length; i++) w.Put(ToKeys[i]);
        w.Put(IsHidden);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId   = r.GetInt();
        FromEvId = r.GetString();
        int n    = r.GetByte();
        FromKeys = new byte[n];
        for (int i = 0; i < n; i++) FromKeys[i] = r.GetByte();
        ToEvId   = r.GetString();
        int m    = r.GetByte();
        ToKeys   = new byte[m];
        for (int i = 0; i < m; i++) ToKeys[i] = r.GetByte();
        IsHidden = r.GetBool();
    }
}

/// <summary>
/// Case status (active / solved / failed). Replays Case.SetStatus.
/// </summary>
public struct CaseBoardStatusPacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardStatus;

    public int  CaseId;
    public byte Status;             // CaseStatus enum
    public bool CancelObjectives;

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(Status);
        w.Put(CancelObjectives);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId           = r.GetInt();
        Status           = r.GetByte();
        CancelObjectives = r.GetBool();
    }
}

/// <summary>
/// Player removed a thread between two pinned cards. Identified by the same
/// (caseID, fromEvID, fromKeys, toEvID, toKeys) tuple used by AddNewStringColour.
/// Receiver finds the matching <c>StringController</c> in
/// <c>CasePanelController.spawnedStrings</c> and calls
/// <c>RemoveCustomLink</c> on it locally.
/// </summary>
public struct CaseBoardStringRemovePacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardStringRemove;

    public int     CaseId;
    public string  FromEvId;
    public byte[]  FromKeys;
    public string  ToEvId;
    public byte[]  ToKeys;

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(FromEvId ?? "");
        w.Put((byte)(FromKeys?.Length ?? 0));
        if (FromKeys != null) for (int i = 0; i < FromKeys.Length; i++) w.Put(FromKeys[i]);
        w.Put(ToEvId ?? "");
        w.Put((byte)(ToKeys?.Length ?? 0));
        if (ToKeys != null) for (int i = 0; i < ToKeys.Length; i++) w.Put(ToKeys[i]);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId   = r.GetInt();
        FromEvId = r.GetString();
        int n    = r.GetByte();
        FromKeys = new byte[n];
        for (int i = 0; i < n; i++) FromKeys[i] = r.GetByte();
        ToEvId   = r.GetString();
        int m    = r.GetByte();
        ToKeys   = new byte[m];
        for (int i = 0; i < m; i++) ToKeys[i] = r.GetByte();
    }
}

/// <summary>
/// Resolve-question answer progress. Identified by parent caseID + the
/// question's index in <c>Case.resolveQuestions</c>. Both clients run the
/// same case schema so the index is stable cross-machine.
/// </summary>
public struct CaseBoardResolveAnswerPacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardResolveAnswer;

    public int   CaseId;
    public int   QuestionIndex;
    public float Progress;
    public bool  ForceTrigger;

    public void Serialize(NetDataWriter w)
    {
        w.Put(CaseId);
        w.Put(QuestionIndex);
        w.Put(Progress);
        w.Put(ForceTrigger);
    }

    public void Deserialize(NetDataReader r)
    {
        CaseId        = r.GetInt();
        QuestionIndex = r.GetInt();
        Progress      = r.GetFloat();
        ForceTrigger  = r.GetBool();
    }
}

/// <summary>Final case hand-in / resolve. Replays Case.Resolve().</summary>
public struct CaseBoardResolvePacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardResolve;

    public int CaseId;

    public void Serialize(NetDataWriter w)   { w.Put(CaseId); }
    public void Deserialize(NetDataReader r) { CaseId = r.GetInt(); }
}

/// <summary>
/// Custom name typed onto a fact card. Same fact 4-tuple identifier as the
/// string / hide packets, plus the new name string. Replays Fact.SetCustomName.
/// </summary>
public struct CaseBoardFactNamePacket : INetPacket
{
    public PacketType Type => PacketType.CaseBoardFactName;

    public string  FromEvId;
    public byte[]  FromKeys;
    public string  ToEvId;
    public byte[]  ToKeys;
    public string  CustomName;

    public void Serialize(NetDataWriter w)
    {
        w.Put(FromEvId ?? "");
        w.Put((byte)(FromKeys?.Length ?? 0));
        if (FromKeys != null) for (int i = 0; i < FromKeys.Length; i++) w.Put(FromKeys[i]);
        w.Put(ToEvId ?? "");
        w.Put((byte)(ToKeys?.Length ?? 0));
        if (ToKeys != null) for (int i = 0; i < ToKeys.Length; i++) w.Put(ToKeys[i]);
        w.Put(CustomName ?? "");
    }

    public void Deserialize(NetDataReader r)
    {
        FromEvId   = r.GetString();
        int n      = r.GetByte();
        FromKeys   = new byte[n];
        for (int i = 0; i < n; i++) FromKeys[i] = r.GetByte();
        ToEvId     = r.GetString();
        int m      = r.GetByte();
        ToKeys     = new byte[m];
        for (int i = 0; i < m; i++) ToKeys[i] = r.GetByte();
        CustomName = r.GetString();
    }
}

/// <summary>
/// A new <c>Evidence</c> was created on the originator's machine. Sent so
/// receivers can call <c>EvidenceCreator.CreateEvidence</c> with the same
/// <c>evID</c>, keeping cross-machine references aligned (case-board pin
/// targets, FactLink resolution, etc). Texture / photo content is NOT in
/// this packet — receivers regenerate visuals locally as needed.
/// </summary>
public struct EvidenceCreatePacket : INetPacket
{
    public PacketType Type => PacketType.EvidenceCreate;

    public string EvId;             // evID — also stable across machines
    public string PresetName;       // EvidencePreset.name
    public string ParentEvId;       // empty if no parent evidence
    public int    OwnerHumanId;     // -1 if none
    public int    WriterHumanId;    // -1 if none
    public int    ReceiverHumanId;  // -1 if none
    public bool   ForceDiscovery;
    public int    SenderId;

    public void Serialize(NetDataWriter w)
    {
        w.Put(EvId ?? "");
        w.Put(PresetName ?? "");
        w.Put(ParentEvId ?? "");
        w.Put(OwnerHumanId);
        w.Put(WriterHumanId);
        w.Put(ReceiverHumanId);
        w.Put(ForceDiscovery);
        w.Put(SenderId);
    }

    public void Deserialize(NetDataReader r)
    {
        EvId            = r.GetString();
        PresetName      = r.GetString();
        ParentEvId      = r.GetString();
        OwnerHumanId    = r.GetInt();
        WriterHumanId   = r.GetInt();
        ReceiverHumanId = r.GetInt();
        ForceDiscovery  = r.GetBool();
        SenderId        = r.GetInt();
    }
}

/// <summary>
/// Non-lethal NPC damage. Mirrors every meaningful parameter of
/// <c>Actor.RecieveDamage</c> so receivers replay the same hit. Spatter
/// preset references travel as Unity asset names (resolved via the
/// SpatterSync preset registry on receivers).
/// </summary>
public struct NpcDamagePacket : INetPacket
{
    public PacketType Type => PacketType.NpcDamage;

    public int     SenderId;
    public int     VictimHumanId;
    public int     AttackerHumanId;          // -1 if attacker unknown / null
    public float   Amount;
    public Vector3 HitPosition;
    public Vector3 HitDirection;
    public string  ForwardSpatterPreset;     // empty = null
    public string  BackSpatterPreset;        // empty = null
    public byte    EraseMode;
    public bool    ForceRagdoll;
    public float   RagdollDuration;
    public float   ShockMP;
    public bool    EnableKill;
    public bool    AllowRecoil;
    public float   RagdollForceMP;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(VictimHumanId);
        w.Put(AttackerHumanId);
        w.Put(Amount);
        w.Put(HitPosition);
        w.Put(HitDirection);
        w.Put(ForwardSpatterPreset ?? "");
        w.Put(BackSpatterPreset ?? "");
        w.Put(EraseMode);
        w.Put(ForceRagdoll);
        w.Put(RagdollDuration);
        w.Put(ShockMP);
        w.Put(EnableKill);
        w.Put(AllowRecoil);
        w.Put(RagdollForceMP);
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId             = r.GetInt();
        VictimHumanId        = r.GetInt();
        AttackerHumanId      = r.GetInt();
        Amount               = r.GetFloat();
        HitPosition          = r.GetVector3();
        HitDirection         = r.GetVector3();
        ForwardSpatterPreset = r.GetString();
        BackSpatterPreset    = r.GetString();
        EraseMode            = r.GetByte();
        ForceRagdoll         = r.GetBool();
        RagdollDuration      = r.GetFloat();
        ShockMP              = r.GetFloat();
        EnableKill           = r.GetBool();
        AllowRecoil          = r.GetBool();
        RagdollForceMP       = r.GetFloat();
    }
}

/// <summary>
/// Player-written note on an Evidence. Carries evID + a packed list of
/// DataKey bytes + the note text. Receiver replays Evidence.SetNote with
/// a freshly-built Il2Cpp DataKey list.
/// </summary>
public struct EvidenceSetNotePacket : INetPacket
{
    public PacketType Type => PacketType.EvidenceSetNote;

    public int    SenderId;
    public string EvId;
    public byte[] DataKeys;
    public string Text;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(EvId ?? "");
        int n = DataKeys?.Length ?? 0;
        w.Put(n);
        for (int i = 0; i < n; i++) w.Put(DataKeys[i]);
        w.Put(Text ?? "");
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId = r.GetInt();
        EvId     = r.GetString();
        int n = r.GetInt();
        DataKeys = new byte[n];
        for (int i = 0; i < n; i++) DataKeys[i] = r.GetByte();
        Text = r.GetString();
    }
}

/// <summary>
/// Player-set custom name on a single Evidence DataKey. Receiver replays
/// Evidence.AddOrSetCustomName(DataKey, string).
/// </summary>
public struct EvidenceCustomNamePacket : INetPacket
{
    public PacketType Type => PacketType.EvidenceCustomName;

    public int    SenderId;
    public string EvId;
    public byte   DataKey;
    public string CustomName;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(EvId ?? "");
        w.Put(DataKey);
        w.Put(CustomName ?? "");
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId   = r.GetInt();
        EvId       = r.GetString();
        DataKey    = r.GetByte();
        CustomName = r.GetString();
    }
}

/// <summary>
/// Evidence.AddDiscovery event. Carries the evID + the Discovery enum
/// value as a byte. Receiver finds the evidence in the dictionary and
/// replays AddDiscovery so the discovered-fact graph converges.
/// </summary>
public struct EvidenceDiscoveryAddPacket : INetPacket
{
    public PacketType Type => PacketType.EvidenceDiscoveryAdd;

    public int    SenderId;
    public string EvId;
    public byte   Discovery;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(EvId ?? "");
        w.Put(Discovery);
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId  = r.GetInt();
        EvId      = r.GetString();
        Discovery = r.GetByte();
    }
}

/// <summary>
/// NPC outfit category change (host → all). Carries the citizen's
/// stable humanID + the new <c>ClothesPreset.OutfitCategory</c> as a
/// byte. Receiver looks the citizen up in city dictionary and replays
/// SetCurrentOutfit so the visual matches.
///
/// <para><b>Source-generated:</b> Serialize / Deserialize are emitted by
/// <c>SoDCoop.Generators.NetPacketGenerator</c> from the public field
/// declarations below. Adding a field automatically updates both
/// methods on next build — see <see cref="NetPacketAttribute"/>.</para>
/// </summary>
[NetPacket]
public partial struct NpcOutfitPacket : INetPacket
{
    public PacketType Type => PacketType.NpcOutfit;

    public int  SenderId;
    public int  HumanId;
    public byte Category;
}

/// <summary>
/// Player outfit category. Client-only outbound: when the local player's
/// <c>CitizenOutfitController.SetCurrentOutfit</c> is called, host applies
/// the same category to the sender's twin so guard / co-worker checks see
/// the disguise.
/// </summary>
public struct PlayerOutfitPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerOutfit;

    public int  PlayerId;
    public byte Category; // ClothesPreset.OutfitCategory enum

    public void Serialize(NetDataWriter w)
    {
        w.Put(PlayerId);
        w.Put(Category);
    }

    public void Deserialize(NetDataReader r)
    {
        PlayerId = r.GetInt();
        Category = r.GetByte();
    }
}

/// <summary>
/// Player suspicion / trespass flags. Client-only outbound: each client
/// polls its own <c>Player.Instance</c> Actor-level flags every tick, and
/// when any change broadcasts this packet. Host applies the flags to the
/// sender's twin <c>Human</c> so guard NPCs (which run on the host) react
/// correctly to the remote player's behaviour.
/// </summary>
public struct PlayerSuspicionPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerSuspicion;

    public int  PlayerId;
    public bool IsTrespassing;
    public bool IllegalActionActive;
    public bool IllegalAreaActive;
    public bool IllegalStatus;
    public int  TrespassingEscalation;

    public void Serialize(NetDataWriter w)
    {
        w.Put(PlayerId);
        w.Put(IsTrespassing);
        w.Put(IllegalActionActive);
        w.Put(IllegalAreaActive);
        w.Put(IllegalStatus);
        w.Put(TrespassingEscalation);
    }

    public void Deserialize(NetDataReader r)
    {
        PlayerId              = r.GetInt();
        IsTrespassing         = r.GetBool();
        IllegalActionActive   = r.GetBool();
        IllegalAreaActive     = r.GetBool();
        IllegalStatus         = r.GetBool();
        TrespassingEscalation = r.GetInt();
    }

    public bool SameAs(PlayerSuspicionPacket o)
        => IsTrespassing         == o.IsTrespassing
        && IllegalActionActive   == o.IllegalActionActive
        && IllegalAreaActive     == o.IllegalAreaActive
        && IllegalStatus         == o.IllegalStatus
        && TrespassingEscalation == o.TrespassingEscalation;
}

/// <summary>
/// Side-job upsert (host → all). Carries full scalar state of a SideJob so
/// the receiver can either (a) reconstruct a skeleton SideJob in its own
/// SideJobController.allJobsDictionary, or (b) at minimum surface a chat
/// banner about the lifecycle event. <see cref="Kind"/>:
///   0 = Created  (SideJob ctor finished — first generation)
///   1 = Posted   (SetJobState → posted — visible on poster's corkboard)
///   2 = Ended    (SetJobState → ended — completed / failed / expired)
///   3 = Snapshot (host pushes existing jobs to a freshly-joined client)
/// </summary>
public struct SideJobUpsertPacket : INetPacket
{
    public PacketType Type => PacketType.SideJobNotification;

    public byte   Kind;
    public int    JobId;
    public string PresetName;
    public string MotiveStr;
    public byte   State;             // SideJob.JobState: 0=generated 1=posted 2=ended
    public bool   Accepted;
    public int    CaseId;
    public int    Phase;
    public int    PostId;
    public int    PosterHumanId;
    public int    PurpHumanId;
    public int    Reward;
    public string RewardSyncDisk;
    public string JobInfoDialogMsg;
    public string PosterName;        // pre-resolved on host for the banner text
    public string Intro;
    public string HandIn;
    public bool   PostImmediately;
    public int    FakeNumber;
    public string FakeNumberStr;
    public int    GooseChasePhone;
    public int    GooseChaseFromPhone;
    public bool   TriggerHandIn;

    public void Serialize(NetDataWriter w)
    {
        w.Put(Kind);
        w.Put(JobId);
        w.Put(PresetName ?? "");
        w.Put(MotiveStr ?? "");
        w.Put(State);
        w.Put(Accepted);
        w.Put(CaseId);
        w.Put(Phase);
        w.Put(PostId);
        w.Put(PosterHumanId);
        w.Put(PurpHumanId);
        w.Put(Reward);
        w.Put(RewardSyncDisk ?? "");
        w.Put(JobInfoDialogMsg ?? "");
        w.Put(PosterName ?? "");
        w.Put(Intro ?? "");
        w.Put(HandIn ?? "");
        w.Put(PostImmediately);
        w.Put(FakeNumber);
        w.Put(FakeNumberStr ?? "");
        w.Put(GooseChasePhone);
        w.Put(GooseChaseFromPhone);
        w.Put(TriggerHandIn);
    }

    public void Deserialize(NetDataReader r)
    {
        Kind                = r.GetByte();
        JobId               = r.GetInt();
        PresetName          = r.GetString();
        MotiveStr           = r.GetString();
        State               = r.GetByte();
        Accepted            = r.GetBool();
        CaseId              = r.GetInt();
        Phase               = r.GetInt();
        PostId              = r.GetInt();
        PosterHumanId       = r.GetInt();
        PurpHumanId         = r.GetInt();
        Reward              = r.GetInt();
        RewardSyncDisk      = r.GetString();
        JobInfoDialogMsg    = r.GetString();
        PosterName          = r.GetString();
        Intro               = r.GetString();
        HandIn              = r.GetString();
        PostImmediately     = r.GetBool();
        FakeNumber          = r.GetInt();
        FakeNumberStr       = r.GetString();
        GooseChasePhone     = r.GetInt();
        GooseChaseFromPhone = r.GetInt();
        TriggerHandIn       = r.GetBool();
    }
}

/// <summary>
/// Local player took damage. Carries the event metadata (amount, attacker,
/// hit pos/dir, lethal flag) so receivers can show a chat banner and toggle
/// a "downed" visual on the corresponding RemotePlayer.
///
/// <para>HP / health value itself is NOT synced — each machine keeps its own
/// player-health state. Only the discrete damage events are mirrored, which
/// is enough for chat awareness + visible ragdoll on lethal hits.</para>
/// </summary>
public struct PlayerDamagePacket : INetPacket
{
    public PacketType Type => PacketType.PlayerDamage;

    public int     SenderId;
    public int     PlayerId;          // network player id of the victim
    public int     AttackerHumanId;   // -1 if unknown / environment
    public float   Amount;
    public Vector3 HitPosition;
    public Vector3 HitDirection;
    public bool    IsLethal;          // killing-blow flag — receiver shows "down" pose

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(PlayerId);
        w.Put(AttackerHumanId);
        w.Put(Amount);
        w.Put(HitPosition);
        w.Put(HitDirection);
        w.Put(IsLethal);
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId        = r.GetInt();
        PlayerId        = r.GetInt();
        AttackerHumanId = r.GetInt();
        Amount          = r.GetFloat();
        HitPosition     = r.GetVector3();
        HitDirection    = r.GetVector3();
        IsLethal        = r.GetBool();
    }
}

/// <summary>
/// Player pressed an elevator floor button. Cross-machine elevator identity
/// is the pair (<c>building.buildingID</c>, <c>bottom.globalTileCoord</c>) —
/// both are deterministic from the world seed. Receiver iterates
/// <c>SessionData.Instance.activeElevators</c> and replays
/// <c>CallElevator(newFloor, upButton)</c> on the match.
/// </summary>
public struct ElevatorCallPacket : INetPacket
{
    public PacketType Type => PacketType.ElevatorCall;

    public int        SenderId;
    public int        BuildingId;
    public Vector3Int BottomTileCoord;
    public int        NewFloor;
    public bool       UpButton;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(BuildingId);
        w.Put(BottomTileCoord.x);
        w.Put(BottomTileCoord.y);
        w.Put(BottomTileCoord.z);
        w.Put(NewFloor);
        w.Put(UpButton);
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId        = r.GetInt();
        BuildingId      = r.GetInt();
        int x = r.GetInt(), y = r.GetInt(), z = r.GetInt();
        BottomTileCoord = new Vector3Int(x, y, z);
        NewFloor        = r.GetInt();
        UpButton        = r.GetBool();
    }
}

/// <summary>
/// New voicemail thread created. Mirrors the parameters of
/// <c>Toolbox.NewVmailThread</c>. Idempotent — receivers skip if
/// <c>messageThreads[ThreadId]</c> already exists.
/// </summary>
public struct VmailCreatedPacket : INetPacket
{
    public PacketType Type => PacketType.VmailCreated;

    public int    SenderId;
    public int    ThreadId;
    public string TreeId;
    public int    FromHumanId;       // -1 if anonymous
    public int    ToAHumanId;        // -1 if not present
    public int    ToBHumanId;
    public int    ToCHumanId;
    public float  TimeStamp;
    public int    Progress;
    public byte   DataSource;        // CustomDataSource enum
    public int    DataSourceId;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(ThreadId);
        w.Put(TreeId ?? "");
        w.Put(FromHumanId);
        w.Put(ToAHumanId);
        w.Put(ToBHumanId);
        w.Put(ToCHumanId);
        w.Put(TimeStamp);
        w.Put(Progress);
        w.Put(DataSource);
        w.Put(DataSourceId);
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId      = r.GetInt();
        ThreadId      = r.GetInt();
        TreeId        = r.GetString();
        FromHumanId   = r.GetInt();
        ToAHumanId    = r.GetInt();
        ToBHumanId    = r.GetInt();
        ToCHumanId    = r.GetInt();
        TimeStamp     = r.GetFloat();
        Progress      = r.GetInt();
        DataSource    = r.GetByte();
        DataSourceId  = r.GetInt();
    }
}

/// <summary>Local player got into / out of a bed.</summary>
public struct PlayerInBedPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerInBed;

    public int  PlayerId;
    public bool IsInBed;
    public bool IsLowBed;

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(IsInBed); w.Put(IsLowBed); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); IsInBed = r.GetBool(); IsLowBed = r.GetBool(); }
}

/// <summary>Local player fell asleep / woke up.</summary>
public struct PlayerAsleepPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerAsleep;

    public int  PlayerId;
    public bool IsAsleep;

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(IsAsleep); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); IsAsleep = r.GetBool(); }
}

/// <summary>
/// Host's connection-lobby status. Broadcast at low frequency (every 2s)
/// from the host so connected clients can render a live "Host is loading…"
/// / "Host in game: City, Day N HH:MM" lobby UI without the client
/// having to query.
/// </summary>
public enum HostPhase : byte
{
    InMainMenu   = 0,
    LoadingWorld = 1,
    InGame       = 2,
}

public struct HostStatusPacket : INetPacket
{
    public PacketType Type => PacketType.HostStatus;

    public byte    Phase;        // HostPhase
    public string  HostNickname;
    public string  CityName;     // empty unless InGame
    public string  ShareSeed;    // SoD city share-seed string when known
    public float   GameTime;     // current game time when InGame
    public int     PlayerCount;  // total connected players (including host)

    public void Serialize(NetDataWriter w)
    {
        w.Put(Phase);
        w.Put(HostNickname ?? "");
        w.Put(CityName ?? "");
        w.Put(ShareSeed ?? "");
        w.Put(GameTime);
        w.Put(PlayerCount);
    }

    public void Deserialize(NetDataReader r)
    {
        Phase        = r.GetByte();
        HostNickname = r.GetString();
        CityName     = r.GetString();
        ShareSeed    = r.GetString();
        GameTime     = r.GetFloat();
        PlayerCount  = r.GetInt();
    }
}

/// <summary>
/// Money credit / debit on the local player. Quest rewards, evidence sales,
/// found cash, fees. Receiver re-invokes
/// <c>GameplayController.AddMoney(amount, displayMessage, reason)</c> so
/// every player ends up with the same balance shift.
/// </summary>
public struct MoneyAddedPacket : INetPacket
{
    public PacketType Type => PacketType.MoneyAdded;

    public int    SenderId;
    public int    Amount;          // signed — positive credit, negative debit
    public bool   DisplayMessage;
    public string Reason;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(Amount);
        w.Put(DisplayMessage);
        w.Put(Reason ?? "");
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId       = r.GetInt();
        Amount         = r.GetInt();
        DisplayMessage = r.GetBool();
        Reason         = r.GetString();
    }
}

/// <summary>
/// Player-to-player item handoff. Sender empties their slot under suppression
/// (no ItemDrop packet flies); recipient calls PickUpItem on the same
/// Interactable.id and slots it into their first free spot.
/// </summary>
public struct PlayerHandoffPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerHandoff;

    public int SenderId;
    public int RecipientId;
    public int InteractableId;

    public void Serialize(NetDataWriter w)   { w.Put(SenderId); w.Put(RecipientId); w.Put(InteractableId); }
    public void Deserialize(NetDataReader r) { SenderId = r.GetInt(); RecipientId = r.GetInt(); InteractableId = r.GetInt(); }
}

/// <summary>
/// Citizen death — broadcast when <c>Human.Murder</c> fires on a non-player.
/// Receiver finds the victim via CityData.citizenDictionary[humanID] and mirrors
/// the dead state (isDead flag + CitizenAnimationController.SetDead(true) +
/// disable NewAIController). Host stays authoritative for the case logic;
/// clients only mirror the visible body.
/// </summary>
public struct CitizenDeathPacket : INetPacket
{
    public PacketType Type => PacketType.CitizenDeath;

    public int VictimHumanId;
    public int KillerHumanId;          // -1 if unknown
    public int WeaponInteractableId;   // -1 if no weapon
    public Vector3 DeathPosition;      // best-effort visual snap on receiver

    public void Serialize(NetDataWriter w)
    {
        w.Put(VictimHumanId);
        w.Put(KillerHumanId);
        w.Put(WeaponInteractableId);
        w.Put(DeathPosition);
    }

    public void Deserialize(NetDataReader r)
    {
        VictimHumanId         = r.GetInt();
        KillerHumanId         = r.GetInt();
        WeaponInteractableId  = r.GetInt();
        DeathPosition         = r.GetVector3();
    }
}

/// <summary>
/// Crime-scene discovery — broadcast when MurderController.OnVictimDiscovery
/// fires on either side. Receiver replays the call locally so the case is
/// flagged "discovered" on both machines without each player having to walk
/// past the body independently.
/// </summary>
public struct CrimeSceneDiscoveredPacket : INetPacket
{
    public PacketType Type => PacketType.CrimeSceneDiscovered;

    public int DiscovererPlayerId;   // who walked over the body (informational)

    public void Serialize(NetDataWriter w)   { w.Put(DiscovererPlayerId); }
    public void Deserialize(NetDataReader r) { DiscovererPlayerId = r.GetInt(); }
}

/// <summary>
/// Phone call notification — lightweight banner-only sync (PhoneCall objects
/// are too tangled with audio/dialog presets to safely replicate).
///
/// Two flavours encoded in the same packet:
///   • Incoming NPC → host call: <c>CallerName</c> filled, <c>CalleeName</c>
///     empty, banner reads "📞 Sarah is calling".
///   • Outgoing player → NPC call: BOTH names filled, banner reads
///     "📞 Player A is calling Sarah". Allows clients to see when their
///     teammate picks up a phone and dials someone.
/// </summary>
public struct PhoneCallNotifyPacket : INetPacket
{
    public PacketType Type => PacketType.PhoneCallNotify;

    public int    CallerHumanId;   // -1 if anonymous/system
    public string CallerName;      // resolved on the broadcasting side; empty if unknown
    public bool   IsStarting;      // true = call begun, false = call ended
    public string CalleeName;      // non-empty marks "outgoing player call"; banner reads "X is calling Y"

    public void Serialize(NetDataWriter w)
    {
        w.Put(CallerHumanId);
        w.Put(CallerName ?? "");
        w.Put(IsStarting);
        w.Put(CalleeName ?? "");
    }

    public void Deserialize(NetDataReader r)
    {
        CallerHumanId = r.GetInt();
        CallerName    = r.GetString();
        IsStarting    = r.GetBool();
        CalleeName    = r.GetString();
    }
}

/// <summary>
/// Host-authoritative weather snapshot. Mirrors the parameters of
/// <c>SessionData.SetWeather(rain, wind, snow, lightning, fog, transitionSpeed, instant)</c>.
/// Sent by the host whenever its own SetWeather fires (and once on player-join so
/// late-joiners catch up). Clients block their local weather scheduler and only
/// apply the values they receive over the wire.
/// </summary>
public struct WeatherStatePacket : INetPacket
{
    public PacketType Type => PacketType.WeatherSync;

    public float Rain;
    public float Wind;
    public float Snow;
    public float Lightning;
    public float Fog;
    public float TransitionSpeed;
    public bool  Instant;

    public void Serialize(NetDataWriter w)
    {
        w.Put(Rain); w.Put(Wind); w.Put(Snow); w.Put(Lightning); w.Put(Fog);
        w.Put(TransitionSpeed); w.Put(Instant);
    }

    public void Deserialize(NetDataReader r)
    {
        Rain      = r.GetFloat();
        Wind      = r.GetFloat();
        Snow      = r.GetFloat();
        Lightning = r.GetFloat();
        Fog       = r.GetFloat();
        TransitionSpeed = r.GetFloat();
        Instant   = r.GetBool();
    }
}

/// <summary>
/// Player or NPC left a dynamic fingerprint on an Interactable.
/// Replays <c>Interactable.AddNewDynamicFingerprint(human, life)</c> on the
/// receiver. SenderId is included for echo dedup (host reflects packets back
/// in star topology). The receiver's local print object will have a different
/// internal id/seed from ours — that's fine, gameplay matches prints by
/// (interactable, human) pair.
/// </summary>
public struct FingerprintAddPacket : INetPacket
{
    public PacketType Type => PacketType.FingerprintAdd;

    public int  InteractableId;
    public int  HumanId;
    public byte Life;       // Interactable.PrintLife enum value
    public int  SenderId;

    public void Serialize(NetDataWriter w)
    {
        w.Put(InteractableId);
        w.Put(HumanId);
        w.Put(Life);
        w.Put(SenderId);
    }

    public void Deserialize(NetDataReader r)
    {
        InteractableId = r.GetInt();
        HumanId        = r.GetInt();
        Life           = r.GetByte();
        SenderId       = r.GetInt();
    }
}

/// <summary>
/// A footprint decal was placed in the world (bloody / dirty footstep).
/// All seven fields of <c>GameplayController.Footprint</c> are sent so the
/// receiver can reconstruct an identical Footprint and pass it to a fresh
/// <c>FootprintController</c> from the pool. SenderId carries echo dedup.
/// </summary>
public struct FootprintAddPacket : INetPacket
{
    public PacketType Type => PacketType.FootprintAdd;

    public int     HumanId;     // Footprint.hID
    public int     RoomId;      // Footprint.rID
    public Vector3 Position;    // Footprint.wP
    public Vector3 EulerRot;    // Footprint.eU
    public float   Dirt;        // Footprint.str
    public float   Blood;       // Footprint.bl
    public float   Timestamp;   // Footprint.t (game-time)
    public int     SenderId;

    public void Serialize(NetDataWriter w)
    {
        w.Put(HumanId);
        w.Put(RoomId);
        w.Put(Position);
        w.Put(EulerRot);
        w.Put(Dirt);
        w.Put(Blood);
        w.Put(Timestamp);
        w.Put(SenderId);
    }

    public void Deserialize(NetDataReader r)
    {
        HumanId   = r.GetInt();
        RoomId    = r.GetInt();
        Position  = r.GetVector3();
        EulerRot  = r.GetVector3();
        Dirt      = r.GetFloat();
        Blood     = r.GetFloat();
        Timestamp = r.GetFloat();
        SenderId  = r.GetInt();
    }
}

/// <summary>
/// Blood / dirt spatter pattern. Receiver reconstructs a
/// <c>SpatterSimulation</c> via the world-position ctor and lets the game's
/// own pipeline spawn the decals. <c>PresetName</c> is the
/// <c>SpatterPatternPreset.name</c> (Unity ScriptableObject name) used for
/// cross-machine preset resolution.
/// </summary>
public struct SpatterAddPacket : INetPacket
{
    public PacketType Type => PacketType.SpatterAdd;

    public Vector3 WorldOrigin;
    public Vector3 WorldTarget;
    public string  PresetName;     // SpatterPatternPreset.name
    public byte    EraseMode;      // SpatterSimulation.EraseMode enum
    public byte    Force;          // SpatterSimulation.ForceType enum
    public float   CountMultiplier;
    public bool    StickToActors;
    public int     SenderId;

    public void Serialize(NetDataWriter w)
    {
        w.Put(WorldOrigin);
        w.Put(WorldTarget);
        w.Put(PresetName ?? "");
        w.Put(EraseMode);
        w.Put(Force);
        w.Put(CountMultiplier);
        w.Put(StickToActors);
        w.Put(SenderId);
    }

    public void Deserialize(NetDataReader r)
    {
        WorldOrigin     = r.GetVector3();
        WorldTarget     = r.GetVector3();
        PresetName      = r.GetString();
        EraseMode       = r.GetByte();
        Force           = r.GetByte();
        CountMultiplier = r.GetFloat();
        StickToActors   = r.GetBool();
        SenderId        = r.GetInt();
    }
}

/// <summary>
/// All manually-placed fingerprints on an Interactable were cleared.
/// Receiver re-invokes <c>RemoveManuallyCreatedFingerprints</c> locally.
/// </summary>
public struct FingerprintClearManualPacket : INetPacket
{
    public PacketType Type => PacketType.FingerprintClearManual;

    public int InteractableId;
    public int SenderId;

    public void Serialize(NetDataWriter w)   { w.Put(InteractableId); w.Put(SenderId); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); SenderId = r.GetInt(); }
}

/// <summary>
/// Generic switch toggle (drawer, cabinet, fridge door, safe, etc.) — keyed by
/// Interactable.id, mirrors the sw0 bool. Receivers call Interactable.SetSwitchState
/// locally with interactor=null so SoD treats it as an unattributed change.
/// Lights / doors use their own dedicated packets.
/// </summary>
public struct SwitchStatePacket : INetPacket
{
    public PacketType Type => PacketType.SwitchState;

    public int  InteractableId;
    public bool IsOn;          // true == sw0 on (drawer open, fridge open, …)

    public void Serialize(NetDataWriter w)   { w.Put(InteractableId); w.Put(IsOn); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); IsOn = r.GetBool(); }
}

/// <summary>Player vitals — small fixed-size HUD update at low rate.</summary>
public struct PlayerVitalsPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerVitals;

    public int  PlayerId;
    public byte Nourishment;   // 0-255 (raw float * 255)
    public byte Hydration;
    public byte Energy;
    public bool IsDead;

    public void Serialize(NetDataWriter w)
    {
        w.Put(PlayerId);
        w.Put(Nourishment); w.Put(Hydration); w.Put(Energy);
        w.Put(IsDead);
    }

    public void Deserialize(NetDataReader r)
    {
        PlayerId   = r.GetInt();
        Nourishment = r.GetByte();
        Hydration   = r.GetByte();
        Energy      = r.GetByte();
        IsDead      = r.GetBool();
    }

    public static byte Pack(float v01) => (byte)Mathf.Clamp(v01 * 255f, 0f, 255f);
    public static float Unpack(byte b) => b / 255f;
}

/// <summary>
/// Currently held item changed. Each side polls its local
/// <c>FirstPersonItemController.currentItem</c>, resolves the backing
/// <c>InventorySlot.interactableID</c>, and broadcasts on change. Receivers
/// spawn a copy of the Interactable's preset prefab on the remote player's
/// right-hand bone. <c>InteractableId == -1</c> means empty hands.
/// </summary>
public struct ItemHeldPacket : INetPacket
{
    public PacketType Type => PacketType.ItemHeld;

    public int PlayerId;
    public int InteractableId;     // -1 = empty hand

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(InteractableId); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); InteractableId = r.GetInt(); }
}

/// <summary>Player raised / lowered their held item (combat-ready stance).</summary>
public struct ItemRaisedPacket : INetPacket
{
    public PacketType Type => PacketType.ItemRaised;

    public int  PlayerId;
    public bool IsRaised;

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(IsRaised); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); IsRaised = r.GetBool(); }
}

/// <summary>Player toggled their flashlight on / off.</summary>
public struct ItemFlashlightPacket : INetPacket
{
    public PacketType Type => PacketType.ItemFlashlight;

    public int  PlayerId;
    public bool IsOn;

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(IsOn); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); IsOn = r.GetBool(); }
}

/// <summary>
/// One-shot combat action by a remote player. Cosmetic — actual NPC damage
/// flows via CitizenDeathSync. Receiver fires a best-effort animator trigger
/// matching the action kind.
/// </summary>
public enum ItemActionKind : byte
{
    MeleeAttack    = 0,
    Block          = 1,
    CounterAttack  = 2,
}

public struct ItemActionPacket : INetPacket
{
    public PacketType Type => PacketType.ItemAction;

    public int  PlayerId;
    public byte Action;        // ItemActionKind

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(Action); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); Action = r.GetByte(); }
}

/// <summary>
/// Player gave an item to an NPC. Receiver re-invokes
/// <c>recipient.TryGiveItem(item, null, defaultSuccess, enableSpeech)</c> so
/// the NPC mirrors the take. <c>givenBy</c> is sent as null on the receiver
/// because each machine has its own local Player and humanIDs don't match
/// across machines for players.
/// </summary>
public struct ItemGivePacket : INetPacket
{
    public PacketType Type => PacketType.ItemGive;

    public int  GiverPlayerId;        // network player id of the giver, for echo dedup
    public int  RecipientHumanId;     // Human.humanID of the NPC receiving
    public int  ItemInteractableId;   // Interactable.id of the gifted item
    public bool DefaultSuccess;
    public bool EnableSpeech;

    public void Serialize(NetDataWriter w)
    {
        w.Put(GiverPlayerId);
        w.Put(RecipientHumanId);
        w.Put(ItemInteractableId);
        w.Put(DefaultSuccess);
        w.Put(EnableSpeech);
    }

    public void Deserialize(NetDataReader r)
    {
        GiverPlayerId      = r.GetInt();
        RecipientHumanId   = r.GetInt();
        ItemInteractableId = r.GetInt();
        DefaultSuccess     = r.GetBool();
        EnableSpeech       = r.GetBool();
    }
}

/// <summary>NPC restrained / unrestrained (NewAIController.SetRestrained).</summary>
public struct NpcRestrainedPacket : INetPacket
{
    public PacketType Type => PacketType.NpcRestrained;

    public int   SenderId;
    public int   NpcHumanId;
    public bool  IsRestrained;
    public float Duration;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(NpcHumanId);
        w.Put(IsRestrained);
        w.Put(Duration);
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId     = r.GetInt();
        NpcHumanId   = r.GetInt();
        IsRestrained = r.GetBool();
        Duration     = r.GetFloat();
    }
}

/// <summary>NPC stunned / unstunned (NewAIController.SetStunned).</summary>
public struct NpcStunnedPacket : INetPacket
{
    public PacketType Type => PacketType.NpcStunned;

    public int  SenderId;
    public int  NpcHumanId;
    public bool IsStunned;

    public void Serialize(NetDataWriter w)
    {
        w.Put(SenderId);
        w.Put(NpcHumanId);
        w.Put(IsStunned);
    }

    public void Deserialize(NetDataReader r)
    {
        SenderId   = r.GetInt();
        NpcHumanId = r.GetInt();
        IsStunned  = r.GetBool();
    }
}

/// <summary>
/// Placer removed (picked up / destroyed) a previously placed item.
/// Receiver looks up its mirrored local Interactable via
/// (PlayerId, PlacerSourceId) and destroys it.
/// </summary>
public struct ItemPlaceRemovePacket : INetPacket
{
    public PacketType Type => PacketType.ItemPlaceRemove;

    public int PlayerId;          // who placed it originally
    public int PlacerSourceId;    // the placement's id on placer's machine

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(PlacerSourceId); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); PlacerSourceId = r.GetInt(); }
}

/// <summary>
/// Player threw an item (coin, food, grenade, mug). Diff approach as
/// placements: prefix snapshots the directory count, postfix walks every
/// new Interactable and broadcasts a packet with preset name + world
/// transform + linear/angular velocity so receivers can spawn an identical
/// physics-driven projectile.
/// </summary>
public struct ItemThrowPacket : INetPacket
{
    public PacketType Type => PacketType.ItemThrow;

    public int     PlayerId;
    public int     PlacerSourceId;     // for cross-machine cleanup if needed
    public string  PresetName;
    public Vector3 Position;
    public Vector3 EulerRotation;
    public Vector3 LinearVelocity;
    public Vector3 AngularVelocity;

    public void Serialize(NetDataWriter w)
    {
        w.Put(PlayerId);
        w.Put(PlacerSourceId);
        w.Put(PresetName ?? "");
        w.Put(Position);
        w.Put(EulerRotation);
        w.Put(LinearVelocity);
        w.Put(AngularVelocity);
    }

    public void Deserialize(NetDataReader r)
    {
        PlayerId        = r.GetInt();
        PlacerSourceId  = r.GetInt();
        PresetName      = r.GetString();
        Position        = r.GetVector3();
        EulerRotation   = r.GetVector3();
        LinearVelocity  = r.GetVector3();
        AngularVelocity = r.GetVector3();
    }
}

/// <summary>
/// Visual mock of a tactical placement (codebreaker, doorwedge, tracker, mine).
/// The placer's machine has the real Interactable; receivers spawn a stripped
/// copy of the preset prefab as decoration. PlacerSourceId is the placer's
/// local Interactable.id, used to clean up the mock if the placer later
/// destroys/picks up the placement (future RemoveVisual packet).
/// </summary>
public struct ItemPlaceVisualPacket : INetPacket
{
    public PacketType Type => PacketType.ItemPlaceVisual;

    public int     PlayerId;          // who placed it
    public int     PlacerSourceId;    // Interactable.id on the placer's side (for future cleanup)
    public string  PresetName;        // InteractablePreset.name
    public Vector3 Position;
    public Vector3 EulerRotation;

    public void Serialize(NetDataWriter w)
    {
        w.Put(PlayerId);
        w.Put(PlacerSourceId);
        w.Put(PresetName ?? "");
        w.Put(Position);
        w.Put(EulerRotation);
    }

    public void Deserialize(NetDataReader r)
    {
        PlayerId       = r.GetInt();
        PlacerSourceId = r.GetInt();
        PresetName     = r.GetString();
        Position       = r.GetVector3();
        EulerRotation  = r.GetVector3();
    }
}

/// <summary>
/// Item pickup event — keyed by Interactable.id.
/// Sent after a successful FirstPersonItemController.PickUpItem so peers can
/// hide the in-world object (it's now in the picker's inventory).
/// </summary>
public struct ItemPickupPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerPickup;

    /// <summary>PlayerId of the player who picked the item up.</summary>
    public int PlayerId;
    /// <summary>Interactable.id of the item.</summary>
    public int InteractableId;

    public void Serialize(NetDataWriter w)   { w.Put(PlayerId); w.Put(InteractableId); }
    public void Deserialize(NetDataReader r) { PlayerId = r.GetInt(); InteractableId = r.GetInt(); }
}

/// <summary>
/// Item drop event — keyed by Interactable.id, includes world-space drop position.
/// Sent after FirstPersonItemController.EmptySlot (when the item is returned to the
/// world, not destroyed) so peers can teleport and show the in-world object.
/// </summary>
public struct ItemDropPacket : INetPacket
{
    public PacketType Type => PacketType.PlayerDrop;

    public int     InteractableId;
    /// <summary>World-space position where the item landed (from spawnedObject after drop).</summary>
    public Vector3 DropPosition;

    public void Serialize(NetDataWriter w)   { w.Put(InteractableId); w.Put(DropPosition); }
    public void Deserialize(NetDataReader r) { InteractableId = r.GetInt(); DropPosition = r.GetVector3(); }
}

/// <summary>
/// Client → Host transfer-of-ownership packet.
///
/// When the local player walks within range of a citizen we send a Claim;
/// the host then pauses that citizen's authoritative AI and stops broadcasting
/// commands for it. Other clients are notified and skip applying state for
/// citizens owned by another player. Released when the player walks away.
///
/// This is the "Skyrim Together LocalActor" pattern — exactly one machine drives
/// each NPC at any moment.
/// </summary>
public struct CitizenOwnershipPacket : INetPacket
{
    public PacketType Type { get; set; }   // Claim or Release

    public int CitizenId;
    public int OwnerId;   // playerId of the claiming/releasing client

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(CitizenId);
        writer.Put(OwnerId);
    }

    public void Deserialize(NetDataReader reader)
    {
        CitizenId = reader.GetInt();
        OwnerId   = reader.GetInt();
    }
}

/// <summary>
/// Player appearance customization. Wire = senderId + 9 bytes packed by
/// <see cref="SoDCoop.Player.AppearanceConfig.Write"/>. Host re-broadcasts
/// to other peers (with senderId preserved) so receivers can apply the
/// overrides to the corresponding twin citizen on their local machine.
/// </summary>
public struct PlayerAppearancePacket : INetPacket
{
    public PacketType Type => PacketType.PlayerAppearance;

    public int SenderId;
    public int TwinHumanId;   // 0 from client; host fills in via RemapForForward
    public SoDCoop.Player.AppearanceConfig Config;

    public void Serialize(NetDataWriter writer)
    {
        writer.Put(SenderId);
        writer.Put(TwinHumanId);
        Config.Write(writer);
    }

    public void Deserialize(NetDataReader reader)
    {
        SenderId    = reader.GetInt();
        TwinHumanId = reader.GetInt();
        Config.Read(reader);
    }
}
