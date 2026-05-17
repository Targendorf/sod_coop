using System;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Network.Steam;

namespace SoDCoop.Zdo;

/// <summary>
/// Pure stateless utility for wrapping/unwrapping the ZDO packet header
/// (flags + uncompressed length + payload-length + payload, with optional
/// zstd compression above <see cref="ZdoMan.DEFAULT_COMPRESSION_THRESHOLD"/>).
///
/// <para>Extracted from ZdoMan as part of the SRP-driven split: framing
/// has nothing to do with the registry, dirty-tracking, sector-cull,
/// or persistence concerns it used to live next to. This class owns
/// no state — the caller passes in the scratch <see cref="NetDataWriter"/>
/// (so ZdoMan keeps reusing its single shared <c>_wrapScratch</c> buffer
/// without us re-implementing pooling) and updates its own byte-count
/// stats from our return value.</para>
///
/// <para>Wire format (unchanged from the in-line ZdoMan version — this
/// is a code-move, not a wire-protocol change):
/// <list type="bullet">
///   <item><c>byte flags</c> — bit0=compressed, bit1=batched (informational).</item>
///   <item><c>int uncompressedLen</c> — Phase G.5 widened from ushort so
///   snapshots / large delta batches >64 KB don't truncate.</item>
///   <item><c>int payloadLen</c> — length of the bytes that follow.</item>
///   <item><c>byte[payloadLen]</c> — compressed-or-raw payload.</item>
/// </list></para>
/// </summary>
public static class ZdoWireFrame
{
    /// <summary>Wrap a payload and broadcast it to every connected peer.
    /// Used by the joiner-side broadcast path and host's all-peers send
    /// (e.g. ownership transfer). No-op when no peers are connected.</summary>
    /// <returns>Number of bytes the framed packet occupies on the wire,
    /// or 0 if nothing was sent (no peers). Caller uses this to update
    /// per-channel byte counters without us having to know about stats.</returns>
    public static int WrapAndSend(
        PacketType pt,
        NetDataWriter payload,
        DeliveryMethod delivery,
        NetDataWriter scratch)
    {
        if (!NetworkManager.HasPeers) return 0;
        WriteFrame(pt, payload, scratch);
        // SendToAll already prefixes the PacketType byte.
        NetworkManager.SendToAll(pt, scratch, delivery);
        return scratch.Length;
    }

    /// <summary>Per-peer counterpart to <see cref="WrapAndSend"/>: builds the
    /// same wrapper but emits via <see cref="NetworkManager.SendTo"/> to a
    /// single peer instead of broadcasting. Used by the per-peer-culled
    /// flush path.</summary>
    /// <returns>Number of bytes the framed packet occupies on the wire,
    /// or 0 if peer was null.</returns>
    public static int WrapAndSendTo(
        SteamPeer peer,
        PacketType pt,
        NetDataWriter payload,
        DeliveryMethod delivery,
        NetDataWriter scratch)
    {
        if (peer == null) return 0;
        WriteFrame(pt, payload, scratch);
        NetworkManager.SendTo(peer, pt, scratch, delivery);
        return scratch.Length;
    }

    /// <summary>Strip the (flags, uncompressedLen, payloadLen, payload)
    /// wrapper. Returns a reader positioned at the start of the inner
    /// payload, decompressed if needed.</summary>
    public static NetDataReader UnwrapHeader(NetDataReader r)
    {
        byte flags = r.GetByte();
        int uncompressedLen = r.GetInt();
        int compressedLen = r.GetInt();

        // Bug #4: bulk copy via BlockCopy instead of byte-by-byte GetByte loop.
        // Profiled hot path on ~100KB compressed snapshots — saves ~95% of
        // the loop overhead (single memcpy vs 100k method dispatches).
        byte[] body = new byte[compressedLen];
        Buffer.BlockCopy(r.RawData, r.Position, body, 0, compressedLen);
        r.SkipBytes(compressedLen);

        if ((flags & 0x01) != 0)
        {
            byte[] decompressed = ZdoCompression.Decompress(body, uncompressedLen);
            return new NetDataReader(decompressed);
        }
        return new NetDataReader(body);
    }

    /// <summary>Shared body of <see cref="WrapAndSend"/> and
    /// <see cref="WrapAndSendTo"/>: resets <paramref name="scratch"/> and
    /// writes the frame header + payload into it. Caller is responsible
    /// for the actual send + stats update.</summary>
    private static void WriteFrame(PacketType pt, NetDataWriter payload, NetDataWriter scratch)
    {
        scratch.Reset();

        byte[] data = payload.Data;
        int len = payload.Length;

        bool compress = len >= ZdoMan.DEFAULT_COMPRESSION_THRESHOLD;
        byte flags = 0;
        if (compress) flags |= 0x01;
        // bit 1 = batched (always 1 for ZdoDeltaBatch by definition; informational).
        if (pt == PacketType.ZdoDeltaBatch) flags |= 0x02;

        scratch.Put(flags);
        // Phase G.5 wire-tuning: uncompressed length is `int` (was `ushort`)
        // so snapshots / large delta batches > 64 KB don't truncate. Header
        // grows by 2 bytes (negligible vs the payload). Reader matches via
        // a feature-flag bit if we need to keep wire-compat with old peers
        // — currently no old peers exist on the wire, so straight upgrade.
        scratch.Put(len);

        if (compress)
        {
            byte[] compressed = ZdoCompression.Compress(data, len);
            scratch.Put(compressed.Length);
            scratch.Put(compressed, 0, compressed.Length);
        }
        else
        {
            scratch.Put(len);
            scratch.Put(data, 0, len);
        }
    }
}
