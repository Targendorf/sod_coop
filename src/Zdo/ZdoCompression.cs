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

    public static byte[] Decompress(byte[] data, int expectedLen)
    {
        if (data == null || data.Length == 0) return Array.Empty<byte>();
        try
        {
            return Decompressor.Unwrap(new ReadOnlySpan<byte>(data, 0, data.Length)).ToArray();
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
