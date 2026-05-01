using SoDCoop.Network;

namespace SoDCoop.Zdo;

/// <summary>
/// Wire payload for <c>PacketType.ZdoVersionMismatch</c>. Sent host → client
/// when handshake reveals a protocol/wire version disagreement. Client
/// surfaces the message in the Co-op menu and disconnects cleanly.
/// </summary>
[NetPacket]
public partial struct ZdoVersionMismatchPacket
{
    public byte ServerWireVersion;
    public byte ClientWireVersion;
    public string Reason;
}
