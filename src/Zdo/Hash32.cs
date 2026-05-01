using System;

namespace SoDCoop.Zdo;

/// <summary>
/// Fowler–Noll–Vo 1a hash. Used as the deterministic, cross-runtime stable
/// hash for ZDO key strings and peer-uid derivation. Replaces .NET 6's
/// randomised <c>string.GetHashCode</c> which gives different values on
/// different peers.
///
/// <para>32-bit variant for ZDO property keys (small key set, collisions
/// improbable but resolved at the dictionary lookup level). 64-bit variant
/// for <c>ZDOID.PeerUid</c> derivation from the per-profile clientGuid.</para>
/// </summary>
public static class Hash32
{
    public const uint OFFSET32 = 2166136261u;
    public const uint PRIME32  = 16777619u;

    public const ulong OFFSET64 = 14695981039346656037ul;
    public const ulong PRIME64  = 1099511628211ul;

    /// <summary>FNV-1a 32-bit over UTF-16 char bytes.</summary>
    public static int Of(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        uint h = OFFSET32;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            h = (h ^ (byte)(c & 0xff)) * PRIME32;
            h = (h ^ (byte)((c >> 8) & 0xff)) * PRIME32;
        }
        return unchecked((int)h);
    }

    /// <summary>FNV-1a 32-bit over a byte buffer.</summary>
    public static int Of(ReadOnlySpan<byte> bytes)
    {
        uint h = OFFSET32;
        for (int i = 0; i < bytes.Length; i++)
            h = (h ^ bytes[i]) * PRIME32;
        return unchecked((int)h);
    }

    /// <summary>FNV-1a 64-bit over UTF-16 char bytes.</summary>
    public static ulong Of64(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0ul;
        ulong h = OFFSET64;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            h = (h ^ (byte)(c & 0xff)) * PRIME64;
            h = (h ^ (byte)((c >> 8) & 0xff)) * PRIME64;
        }
        return h;
    }
}
