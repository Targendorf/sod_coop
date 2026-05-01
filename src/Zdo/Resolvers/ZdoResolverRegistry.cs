using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Static lookup of registered resolvers. <see cref="ZdoMan"/> calls
/// <see cref="Apply"/> after every applied delta and after snapshot restore
/// so the live SoD world stays in sync with the ZDO registry on every peer.
/// </summary>
public static class ZdoResolverRegistry
{
    private static readonly Dictionary<ZdoTypeTag, IZdoResolver> _byTag = new();

    public static void Register(IZdoResolver resolver)
    {
        if (resolver == null) return;
        _byTag[resolver.Tag] = resolver;
    }

    public static void Apply(Zdo z)
    {
        if (z == null) return;
        if (_byTag.TryGetValue(z.ZdoTypeTag, out var r))
        {
            try { r.Apply(z); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[ZdoResolver] {z.ZdoTypeTag} apply: {ex.Message}"); }
        }
    }

    public static IZdoResolver Lookup(ZdoTypeTag tag)
        => _byTag.TryGetValue(tag, out var r) ? r : null;

    public static void Clear() => _byTag.Clear();
}
