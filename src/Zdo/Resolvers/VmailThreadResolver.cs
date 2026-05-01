using System;

namespace SoDCoop.Zdo.Resolvers;

public sealed class VmailThreadResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.VmailThread;

    public void Apply(Zdo z)
    {
        // Vmail threads are pulled from the live SoD object via legacy
        // VmailSync apply path. The ZDO acts as a presence marker so the
        // VmailThreadPoller (host) and the listener know which threads
        // are observed.
        _ = z;
        try { } catch (Exception ex) { Plugin.Log.LogWarning($"[VmailThreadResolver] {ex.Message}"); }
    }
}
