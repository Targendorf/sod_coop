namespace SoDCoop.Sync;

/// <summary>
/// Master enable/disable flag every Harmony patch consults as its first
/// instruction. Closed at plugin load and during SoD's heavy save-load
/// init burst; opened once the world has finished loading and the
/// post-ready grace window has elapsed.
///
/// <para><b>Why:</b> in IL2CPP-Interop every Harmony postfix invocation
/// has fixed wrapper overhead (10–50µs per call, mostly native↔managed
/// transitions and arg marshalling). When SoD's save-load pipeline
/// fires patched methods tens of thousands of times — restoring every
/// light / door / switch / citizen outfit state — that overhead alone
/// adds minutes to the load. We can't make the wrapper cheaper, but
/// we can make the body do nothing except a single static bool check.
/// Combined with the gate being closed during the load burst, every
/// patch becomes a near-noop on the load hot-path.</para>
///
/// <para>Use: <c>if (!SyncGate.IsOpen) return;</c> as the FIRST line of
/// every Postfix. Place it before any IL2CPP property access on
/// <c>__instance</c> — even <c>__instance.interactable</c> on a
/// LightController is an il2cpp_field_get_offset call that costs more
/// than a managed-side static bool check.</para>
/// </summary>
public static class SyncGate
{
    /// <summary>True while patches are allowed to run their broadcast logic.
    /// Default false. Flipped via <see cref="Open"/> / <see cref="Close"/>.</summary>
    public static bool IsOpen { get; private set; }

    /// <summary>Opens the gate. Idempotent.</summary>
    public static void Open()
    {
        if (IsOpen) return;
        IsOpen = true;
        Plugin.Log.LogInfo("[SyncGate] OPEN — patch broadcast bodies are now active.");
    }

    /// <summary>Closes the gate. Idempotent.</summary>
    public static void Close()
    {
        if (!IsOpen) return;
        IsOpen = false;
        Plugin.Log.LogInfo("[SyncGate] CLOSED — patch bodies will fast-bail.");
    }
}
