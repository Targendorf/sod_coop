using System;
using ZstdSharp;

namespace SoDCoop.Zdo;

/// <summary>
/// Thin facade over <c>ZstdSharp.Port</c>. Reuses a single
/// <see cref="Compressor"/> / <see cref="Decompressor"/> pair to amortise
/// allocation. Single-threaded; ZdoMan flush runs on the Unity main thread.
///
/// <para>Default level 3 matches BetterNetworking-Valheim's default. Below
/// the 100-byte threshold (enforced at the call site in <see cref="ZdoMan"/>)
/// payloads ship raw because zstd's frame overhead would inflate them.</para>
/// </summary>
public static class ZdoCompression
{
    public static int Level = 3;

    private static Compressor _compressor;
    private static Decompressor _decompressor;

    private static Compressor Compressor   => _compressor   ??= new Compressor(Level);
    private static Decompressor Decompressor => _decompressor ??= new Decompressor();

    public static byte[] Compress(byte[] data, int length)
    {
        if (data == null || length <= 0) return Array.Empty<byte>();
        try
        {
            // ZstdSharp.Compressor.Wrap takes ReadOnlySpan<byte>.
            return Compressor.Wrap(new ReadOnlySpan<byte>(data, 0, length)).ToArray();
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoCompression] compress failed: {ex.Message}");
            // Fall back to uncompressed copy so we don't lose data.
            byte[] copy = new byte[length];
            Buffer.BlockCopy(data, 0, copy, 0, length);
            return copy;
        }
    }

    /// <summary>Thread-safe Compress for use on a background thread.
    /// Allocates a private Compressor for the call so the shared one isn't
    /// touched from off-main. Used by the async snapshot send path
    /// (<see cref="ZdoMan.SendSnapshotTo"/>) which dispatches compression
    /// to <see cref="System.Threading.Tasks.Task.Run(System.Action)"/> so
    /// the Unity main thread is not blocked on zstd of a 1–2 MB snapshot.</summary>
    public static byte[] CompressOffThread(byte[] data, int length)
    {
        if (data == null || length <= 0) return Array.Empty<byte>();
        try
        {
            using var local = new Compressor(Level);
            return local.Wrap(new ReadOnlySpan<byte>(data, 0, length)).ToArray();
        }
        catch (Exception)
        {
            // No Plugin.Log here — logger may not be thread-safe.
            // Just fall back to uncompressed and let the receiver decode
            // (flags bit 0 == 0 path) without disruption.
            byte[] copy = new byte[length];
            Buffer.BlockCopy(data, 0, copy, 0, length);
            return copy;
        }
    }

    public static byte[] Decompress(byte[] data, int expectedLen)
        => Decompress(data, data?.Length ?? 0, expectedLen);

    /// <summary>Decompress exactly <paramref name="dataLen"/> bytes from the
    /// start of <paramref name="data"/>. Exists for callers handing in pooled
    /// (<see cref="System.Buffers.ArrayPool{T}"/>) buffers — those can be
    /// LARGER than the logical payload, so reading <c>data.Length</c> bytes
    /// (as the 2-arg overload does) would feed zstd trailing garbage past the
    /// real frame and corrupt or fail the decode. Used by
    /// <see cref="ZdoEventDispatcher.Dispatch"/>'s rented receive buffer.</summary>
    public static byte[] Decompress(byte[] data, int dataLen, int expectedLen)
    {
        if (data == null || dataLen <= 0) return Array.Empty<byte>();
        try
        {
            return Decompressor.Unwrap(new ReadOnlySpan<byte>(data, 0, dataLen)).ToArray();
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoCompression] decompress failed: {ex.Message}");
            return Array.Empty<byte>();
        }
    }

    public static void Reset()
    {
        try { _compressor?.Dispose(); } catch { }
        try { _decompressor?.Dispose(); } catch { }
        _compressor = null;
        _decompressor = null;
    }
}
