using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Phone call active state surfaces as a chat banner via legacy
/// <c>PhoneSync</c>. The resolver only emits the banner once per
/// active state change; persistent state lives in the ZDO's
/// <c>callActive</c> key.
/// </summary>
public sealed class PhoneCallResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.PhoneCall;

    public void Apply(Zdo z)
    {
        // Display-only banner; PhoneSync owns the OnGUI rendering.
        // No-op apply — the data is read directly off the ZDO by callers.
        _ = z;
        try { } catch (Exception ex) { Plugin.Log.LogWarning($"[PhoneCallResolver] {ex.Message}"); }
    }
}
