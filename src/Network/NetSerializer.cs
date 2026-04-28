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
        
        float[] components = new float[4];
        float sumSquares = 0f;
        
        for (int i = 0; i < 4; i++)
        {
            if (i != largestIndex)
            {
                components[i] = reader.GetShort() / 32767f;
                sumSquares += components[i] * components[i];
            }
        }
        
        components[largestIndex] = Mathf.Sqrt(1f - sumSquares) * sign;
        
        return new Quaternion(components[0], components[1], components[2], components[3]);
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
        writer.PutCompressed(Rotation);
        writer.Put(Velocity);
        writer.Put(Timestamp);
    }

    public void Deserialize(NetDataReader reader)
    {
        PlayerId  = reader.GetInt();
        Sequence  = reader.GetUShort();
        Flags     = reader.GetByte();
        Position  = reader.GetVector3();
        Rotation  = reader.GetCompressedQuaternion();
        Velocity  = reader.GetVector3();
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
    
    public float GameTime;
    public int Day;
    public int Hour;
    public int Minute;
    public bool IsPaused;
    
    public void Serialize(NetDataWriter writer)
    {
        writer.Put(GameTime);
        writer.Put(Day);
        writer.Put(Hour);
        writer.Put(Minute);
        writer.Put(IsPaused);
    }
    
    public void Deserialize(NetDataReader reader)
    {
        GameTime = reader.GetFloat();
        Day = reader.GetInt();
        Hour = reader.GetInt();
        Minute = reader.GetInt();
        IsPaused = reader.GetBool();
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
/// </summary>
public struct PhoneCallNotifyPacket : INetPacket
{
    public PacketType Type => PacketType.PhoneCallNotify;

    public int    CallerHumanId;   // -1 if anonymous/system
    public string CallerName;      // resolved on the broadcasting side; empty if unknown
    public bool   IsStarting;      // true = call begun, false = call ended

    public void Serialize(NetDataWriter w)
    {
        w.Put(CallerHumanId);
        w.Put(CallerName ?? "");
        w.Put(IsStarting);
    }

    public void Deserialize(NetDataReader r)
    {
        CallerHumanId = r.GetInt();
        CallerName    = r.GetString();
        IsStarting    = r.GetBool();
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
