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
