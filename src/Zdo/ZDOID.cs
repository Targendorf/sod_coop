using System;
using LiteNetLib.Utils;

namespace SoDCoop.Zdo;

/// <summary>
/// Composite identity for a ZDO. <c>(PeerUid, Sequence)</c> — minted by the
/// creator peer with no central allocator. PeerUid is the FNV-1a-64 of the
/// peer's stable profile clientGuid; Sequence is a per-peer monotonic counter.
/// Wire size: 12 bytes.
/// </summary>
public readonly struct ZDOID : IEquatable<ZDOID>
{
    public readonly ulong PeerUid;
    public readonly uint  Sequence;

    public ZDOID(ulong peerUid, uint sequence)
    {
        PeerUid = peerUid;
        Sequence = sequence;
    }

    public bool IsValid => PeerUid != 0ul || Sequence != 0u;

    public bool Equals(ZDOID other) => PeerUid == other.PeerUid && Sequence == other.Sequence;
    public override bool Equals(object obj) => obj is ZDOID o && Equals(o);
    public override int GetHashCode() => unchecked((int)(PeerUid ^ (PeerUid >> 32) ^ Sequence));
    public override string ToString() => $"{PeerUid:X16}:{Sequence:X8}";

    public static bool operator ==(ZDOID a, ZDOID b) => a.Equals(b);
    public static bool operator !=(ZDOID a, ZDOID b) => !a.Equals(b);

    public static readonly ZDOID Invalid = new(0ul, 0u);

    public void Write(NetDataWriter w)
    {
        w.Put(PeerUid);
        w.Put(Sequence);
    }

    public static ZDOID Read(NetDataReader r)
    {
        ulong p = r.GetULong();
        uint  s = r.GetUInt();
        return new ZDOID(p, s);
    }
}
