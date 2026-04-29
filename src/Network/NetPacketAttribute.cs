namespace SoDCoop.Network;

/// <summary>
/// Marks a partial struct as a network packet. The <c>SoDCoop.Generators</c>
/// source generator emits matching <c>Serialize(NetDataWriter)</c> and
/// <c>Deserialize(NetDataReader)</c> methods derived from the struct's
/// public instance fields (in declaration order).
///
/// <para>Use:</para>
/// <code>
/// [NetPacket]
/// public partial struct ExamplePacket : INetPacket
/// {
///     public PacketType Type =&gt; PacketType.Example;
///     public int   PlayerId;
///     public byte  Foo;
///     public string Note;
///     // No hand-written Serialize / Deserialize — generator emits them.
/// }
/// </code>
///
/// <para>Supported field types: integral primitives + float/double/bool,
/// string (null-coalesced to ""), byte[] (length-prefixed), Vector3,
/// Vector3Int, Quaternion. Any other type emits a NETPKT001 diagnostic
/// at build time and is skipped in the generated body — extend
/// <c>NetPacketGenerator</c> to support more.</para>
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
public sealed class NetPacketAttribute : System.Attribute { }
