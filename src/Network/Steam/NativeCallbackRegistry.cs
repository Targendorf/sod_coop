using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Direct-to-native Steam callback registration. Bypasses Steamworks.NET's
/// managed <c>Callback&lt;T&gt;</c> wrapper because IL2CPP refuses to JIT
/// the generic <c>DispatchDelegate</c> constructor for any
/// <c>Callback&lt;T&gt;</c> instantiation that the game itself doesn't use
/// — the Unity build simply has no AOT code for those, and IL2CPP runtime
/// has no JIT.
///
/// <para>Implementation: build a CCallbackBase-compatible 16-byte struct
/// in unmanaged memory with a 24-byte vtable of three function pointers
/// matching the Steamworks SDK ABI, hand it to
/// <c>SteamAPI_RegisterCallback</c> via P/Invoke, and route the dispatch
/// stubs back to the managed handler keyed by the base-struct pointer.
/// Layout copied from upstream Steamworks.NET <c>NativeCallback.cs</c> so
/// it matches what the Steam runtime expects on Windows x64.</para>
///
/// <para>Limitations: callbacks (<c>SteamAPI_RegisterCallback</c>) only —
/// not CallResults. Steam delivers callbacks on whatever thread calls
/// <c>SteamAPI_RunCallbacks</c>; we pump from the Unity main thread, so
/// handlers run there.</para>
/// </summary>
internal static class NativeCallbackRegistry
{
    private const string LIB = "steam_api64";

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern void SteamAPI_RunCallbacks();

    // ── Steam Datagram Relay (SDR) bootstrap ─────────────────────────────
    // The managed wrappers `SteamNetworkingUtils.InitRelayNetworkAccess()`
    // and `GetRelayNetworkStatus(out ...)` throw "Steamworks is not
    // initialized" under IL2CPP because the C# CallbackDispatcher isn't
    // alive. We bypass through the same flat-C exports the wrappers use
    // internally, calling them directly.
    //
    // Interface version: ISteamNetworkingUtils v004 (current SDK 1.5x+).
    // If the game ships an older SDK and this entry point is missing, the
    // DllImport will throw EntryPointNotFoundException — we catch and fall
    // back to v003 below.
    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingUtils_SteamAPI_v004")]
    private static extern IntPtr SteamAPI_SteamNetworkingUtils_v004();

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingUtils_SteamAPI_v003")]
    private static extern IntPtr SteamAPI_SteamNetworkingUtils_v003();

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern void SteamAPI_ISteamNetworkingUtils_InitRelayNetworkAccess(IntPtr self);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern int SteamAPI_ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr self, IntPtr pStatus);

    private static IntPtr _sdrUtils = IntPtr.Zero;

    private static IntPtr GetSdrUtils()
    {
        if (_sdrUtils != IntPtr.Zero) return _sdrUtils;
        try { _sdrUtils = SteamAPI_SteamNetworkingUtils_v004(); }
        catch (EntryPointNotFoundException) { _sdrUtils = IntPtr.Zero; }
        if (_sdrUtils == IntPtr.Zero)
        {
            try { _sdrUtils = SteamAPI_SteamNetworkingUtils_v003(); }
            catch (EntryPointNotFoundException) { _sdrUtils = IntPtr.Zero; }
        }
        return _sdrUtils;
    }

    /// <summary>
    /// Kick off async fetch of Steam Datagram Relay tickets. Without this,
    /// SteamNetworkingSockets P2P listen sockets exist but never receive
    /// inbound connections from peers (they're invisible to SDR routing).
    /// </summary>
    public static bool InitRelayNetworkAccess()
    {
        var utils = GetSdrUtils();
        if (utils == IntPtr.Zero) return false;
        try { SteamAPI_ISteamNetworkingUtils_InitRelayNetworkAccess(utils); return true; }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[NativeCallback] InitRelayNetworkAccess: {ex.GetType().Name}: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Reads SDR availability into a managed mirror of
    /// <c>SteamRelayNetworkStatus_t</c> (272 bytes total). Returns the
    /// availability code; -1 on error.
    /// </summary>
    public static int GetRelayNetworkStatus(out int eAvail, out int eAvailNetworkConfig, out int eAvailAnyRelay, out string debugMsg)
    {
        eAvail = -1; eAvailNetworkConfig = -1; eAvailAnyRelay = -1; debugMsg = "";
        var utils = GetSdrUtils();
        if (utils == IntPtr.Zero) return -1;

        // SteamRelayNetworkStatus_t layout (Pack=8):
        //   0  : ESteamNetworkingAvailability m_eAvail              (int)
        //   4  : int                          m_bPingMeasurementInProgress
        //   8  : ESteamNetworkingAvailability m_eAvailNetworkConfig (int)
        //   12 : ESteamNetworkingAvailability m_eAvailAnyRelay      (int)
        //   16 : char                         m_debugMsg[256]
        //  total 272 bytes.
        IntPtr buf = Marshal.AllocHGlobal(272);
        try
        {
            unsafe
            {
                byte* p = (byte*)buf;
                for (int i = 0; i < 272; i++) *(p + i) = 0;
                int rc = SteamAPI_ISteamNetworkingUtils_GetRelayNetworkStatus(utils, buf);
                eAvail              = *(int*)(p + 0);
                eAvailNetworkConfig = *(int*)(p + 8);
                eAvailAnyRelay      = *(int*)(p + 12);
                int len = 0;
                while (len < 256 && *(p + 16 + len) != 0) len++;
                debugMsg = len == 0 ? "" : System.Text.Encoding.ASCII.GetString(p + 16, len);
                return rc;
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[NativeCallback] GetRelayNetworkStatus: {ex.GetType().Name}: {ex.Message}");
            return -1;
        }
        finally { Marshal.FreeHGlobal(buf); }
    }

    /// <summary>
    /// Direct native pump — drives the C++ callback queue and dispatches into
    /// our registered base structs. Bypasses Steamworks.NET's managed
    /// <c>SteamAPI.RunCallbacks</c> wrapper, which under IL2CPP throws
    /// <c>InvalidOperationException("Callback dispatcher is not initialized.")</c>
    /// from its managed <c>CallbackDispatcher.RunFrame</c> guard before ever
    /// reaching the native call. We don't use the managed dispatcher at all,
    /// so we go around it.
    /// </summary>
    public static void RunCallbacks()
    {
        try { SteamAPI_RunCallbacks(); }
        catch (Exception ex)
        {
            // Don't spam — log once per type then suppress.
            try { Plugin.Log.LogWarning($"[NativeCallback] RunCallbacks: {ex.GetType().Name}: {ex.Message}"); }
            catch { }
        }
    }

    /// <summary>
    /// Per-registration bookkeeping. <see cref="BasePtr"/> is the address we
    /// hand to Steam — it doubles as the dictionary key the dispatch stubs
    /// use to find the right handler.
    /// </summary>
    private sealed class Entry
    {
        public IntPtr BasePtr;            // CCallbackBase* (16 bytes)
        public IntPtr VTablePtr;          // 3 × IntPtr
        public Action<IntPtr> Dispatch;   // copies bytes → invokes managed handler
        public int    SizeBytes;          // sizeof(T) — Steam asks via vtable[2]
        public int    CallbackId;
        public string Label;
    }

    private static readonly Dictionary<IntPtr, Entry> _entries = new();

    /// <summary>
    /// Register a managed handler against the given Steam callback id.
    /// Returns an opaque handle (the underlying base-struct pointer) — pass
    /// it to <see cref="Unregister"/> later.
    /// </summary>
    // No struct constraint: under IL2Cpp interop some Steamworks types
    // (e.g. SteamNetConnectionStatusChangedCallback_t — it has a string
    // field) are exposed as classes, not value types. Marshal.SizeOf and
    // Marshal.PtrToStructure both accept either kind via [StructLayout]
    // attribute reflection.
    //
    // <param name="sizeOverride">If &gt; 0, used in lieu of Marshal.SizeOf&lt;T&gt;().
    // Required for non-blittable types (e.g. structs containing strings or
    // fixed buffers) where Marshal.SizeOf throws "no meaningful size".
    // Must be &gt;= the real C++ struct size — Steam's runtime memcpy's that
    // many bytes when delivering the callback, so undersizing crashes.</param>
    public static IntPtr Register<T>(int callbackId, Action<T> handler, string label, int sizeOverride = 0)
    {
        if (handler == null) throw new ArgumentNullException(nameof(handler));

        int size;
        if (sizeOverride > 0)
        {
            size = sizeOverride;
        }
        else
        {
            try { size = Marshal.SizeOf(typeof(T)); }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    $"Cannot compute size of {typeof(T).Name} via Marshal.SizeOf — pass sizeOverride explicitly, or use RegisterRaw. ({ex.GetType().Name}: {ex.Message})", ex);
            }
        }

        string finalLabel = label ?? typeof(T).Name;
        return RegisterCore(callbackId, size, finalLabel, (pvParam) =>
        {
            try
            {
                var data = Marshal.PtrToStructure<T>(pvParam);
                handler(data);
            }
            catch (Exception ex)
            {
                try { Plugin.Log.LogWarning($"[NativeCallback] {finalLabel} handler: {ex.GetType().Name}: {ex.Message}"); }
                catch { }
            }
        });
    }

    /// <summary>
    /// Variant for callbacks whose payload struct can't be marshaled via
    /// <see cref="Marshal.PtrToStructure"/> (non-blittable, missing layout
    /// metadata under IL2Cpp interop, etc.). Hands the raw native pointer
    /// to the caller along with the byte count Steam delivered; the caller
    /// is responsible for decoding fields manually.
    /// </summary>
    public static IntPtr RegisterRaw(int callbackId, int sizeBytes, Action<IntPtr> rawHandler, string label)
    {
        if (rawHandler == null) throw new ArgumentNullException(nameof(rawHandler));
        if (sizeBytes <= 0) throw new ArgumentOutOfRangeException(nameof(sizeBytes), "Must be a positive byte count >= the C++ struct size.");

        string finalLabel = label ?? "raw-callback";
        return RegisterCore(callbackId, sizeBytes, finalLabel, (pvParam) =>
        {
            try { rawHandler(pvParam); }
            catch (Exception ex)
            {
                try { Plugin.Log.LogWarning($"[NativeCallback] {finalLabel} raw handler: {ex.GetType().Name}: {ex.Message}"); }
                catch { }
            }
        });
    }

    /// <summary>
    /// Shared registration core: allocates the unmanaged base struct + vtable,
    /// stores the dispatch closure in <see cref="_entries"/>, calls
    /// <c>SteamAPI_RegisterCallback</c>. Both <see cref="Register{T}"/> and
    /// <see cref="RegisterRaw"/> funnel through here.
    /// </summary>
    private static IntPtr RegisterCore(int callbackId, int sizeBytes, string label, Action<IntPtr> dispatch)
    {
        // ── Build the 24-byte vtable ────────────────────────────────────
        // Slot order matches Steamworks.NET upstream NativeCallback.cs:
        //   [0] = Run( void*, bool, SteamAPICall_t )   — CallResult variant
        //   [1] = Run( void* )                          — Callback variant (this is the one that fires for us)
        //   [2] = GetCallbackSizeBytes()
        IntPtr vtable = Marshal.AllocHGlobal(IntPtr.Size * 3);
        unsafe
        {
            IntPtr* slots = (IntPtr*)vtable;
            slots[0] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, byte, ulong, void>)&RunCallResultStub;
            slots[1] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, void>)&RunCallbackStub;
            slots[2] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&GetCallbackSizeBytesStub;
        }

        // ── Build the 16-byte CCallbackBase ─────────────────────────────
        IntPtr basePtr = Marshal.AllocHGlobal(16);
        unsafe
        {
            byte* p = (byte*)basePtr;
            *(IntPtr*)(p + 0)  = vtable;
            *(byte*)  (p + 8)  = 0;
            *(byte*)  (p + 9)  = 0;
            *(byte*)  (p + 10) = 0;
            *(byte*)  (p + 11) = 0;
            *(int*)   (p + 12) = callbackId;
        }

        var entry = new Entry
        {
            BasePtr    = basePtr,
            VTablePtr  = vtable,
            CallbackId = callbackId,
            SizeBytes  = sizeBytes,
            Label      = label,
            Dispatch   = dispatch,
        };
        _entries[basePtr] = entry;

        try
        {
            SteamAPI_RegisterCallback(basePtr, callbackId);
        }
        catch
        {
            _entries.Remove(basePtr);
            try { Marshal.FreeHGlobal(basePtr);   } catch { }
            try { Marshal.FreeHGlobal(vtable);    } catch { }
            throw;
        }

        return basePtr;
    }

    /// <summary>Unregister + free the unmanaged buffers. Idempotent.</summary>
    public static void Unregister(IntPtr handle)
    {
        if (handle == IntPtr.Zero) return;
        if (!_entries.TryGetValue(handle, out var entry)) return;

        try { SteamAPI_UnregisterCallback(handle); } catch { }
        _entries.Remove(handle);
        try { Marshal.FreeHGlobal(entry.BasePtr);  } catch { }
        try { Marshal.FreeHGlobal(entry.VTablePtr); } catch { }
    }

    /// <summary>Drop every registered callback. Call from teardown.</summary>
    public static void UnregisterAll()
    {
        var keys = new List<IntPtr>(_entries.Keys);
        foreach (var k in keys) Unregister(k);
    }

    // ─── Native dispatch stubs ────────────────────────────────────────────
    // [UnmanagedCallersOnly] requires:
    //   • blittable parameter types (IntPtr, primitive ints, byte for C++ bool — OK)
    //   • no escaping managed exceptions (we wrap everything)
    //   • static method (no captured state — we look up by `self` in a static dict)
    //
    // Calling convention: Windows x64 has a single platform ABI (Microsoft x64).
    // C++ member function call uses the same ABI with `this` in RCX, which maps
    // 1:1 onto our (IntPtr self, ...) signature. No CallConvs attribute needed.

    [UnmanagedCallersOnly]
    private static void RunCallbackStub(IntPtr self, IntPtr pvParam)
    {
        DispatchCommon(self, pvParam);
    }

    [UnmanagedCallersOnly]
    private static void RunCallResultStub(IntPtr self, IntPtr pvParam, byte bIOFailure, ulong hSteamAPICall)
    {
        // Pure callbacks (vs CallResults) shouldn't reach this slot, but
        // route to the same path so a misbehaving Steam runtime doesn't
        // silently drop messages. (UnmanagedCallersOnly methods can't call
        // each other directly — share via DispatchCommon.)
        DispatchCommon(self, pvParam);
    }

    private static void DispatchCommon(IntPtr self, IntPtr pvParam)
    {
        try
        {
            if (_entries.TryGetValue(self, out var entry) && entry.Dispatch != null)
                entry.Dispatch(pvParam);
        }
        catch (Exception ex)
        {
            try { Plugin.Log.LogError($"[NativeCallback] DispatchCommon: {ex}"); } catch { }
        }
    }

    [UnmanagedCallersOnly]
    private static int GetCallbackSizeBytesStub(IntPtr self)
    {
        try
        {
            if (_entries.TryGetValue(self, out var entry)) return entry.SizeBytes;
        }
        catch { }
        return 0;
    }
}
