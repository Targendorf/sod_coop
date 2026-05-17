using System;
using System.Runtime.InteropServices;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Direct flat-C P/Invoke wrappers for <c>ISteamNetworkingSockets</c>.
/// Bypasses Steamworks.NET's managed <c>SteamNetworkingSockets</c> static
/// class — under IL2CPP that wrapper silently returns fake handles for
/// methods like <c>CreateListenSocketP2P</c>: we get a non-Invalid value
/// back, but no actual listen socket is registered with the Steam runtime,
/// so inbound P2P connections never reach our connection-status callback.
///
/// <para>Resolves the interface pointer once via the v012 accessor, falls
/// back to v011/v009 for older SDKs.</para>
/// </summary>
internal static class SteamSocketsNative
{
    private const string LIB = "steam_api64";

    // ── ISteamNetworkingSockets accessor (returns interface pointer) ──────
    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingSockets_SteamAPI_v012")]
    private static extern IntPtr SteamAPI_SteamNetworkingSockets_v012();
    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingSockets_SteamAPI_v011")]
    private static extern IntPtr SteamAPI_SteamNetworkingSockets_v011();
    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamAPI_SteamNetworkingSockets_SteamAPI_v009")]
    private static extern IntPtr SteamAPI_SteamNetworkingSockets_v009();

    // ── Listen / connect / poll group ─────────────────────────────────────
    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern uint SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2P(
        IntPtr self, int nLocalVirtualPort, int nOptions, IntPtr pOptions);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern uint SteamAPI_ISteamNetworkingSockets_CreatePollGroup(IntPtr self);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern uint SteamAPI_ISteamNetworkingSockets_ConnectP2P(
        IntPtr self, IntPtr pIdentityRemote, int nRemoteVirtualPort, int nOptions, IntPtr pOptions);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern int SteamAPI_ISteamNetworkingSockets_AcceptConnection(IntPtr self, uint hConn);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool SteamAPI_ISteamNetworkingSockets_SetConnectionPollGroup(
        IntPtr self, uint hConn, uint hPollGroup);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool SteamAPI_ISteamNetworkingSockets_CloseConnection(
        IntPtr self, uint hConn, int nReason, [MarshalAs(UnmanagedType.LPStr)] string pszDebug, [MarshalAs(UnmanagedType.U1)] bool bEnableLinger);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool SteamAPI_ISteamNetworkingSockets_CloseListenSocket(IntPtr self, uint hSocket);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.U1)]
    private static extern bool SteamAPI_ISteamNetworkingSockets_DestroyPollGroup(IntPtr self, uint hPollGroup);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern int SteamAPI_ISteamNetworkingSockets_SendMessageToConnection(
        IntPtr self, uint hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern int SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(
        IntPtr self, uint hPollGroup, IntPtr ppOutMessages, int nMaxMessages);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr msgPtr);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern void SteamAPI_ISteamNetworkingSockets_RunCallbacks(IntPtr self);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern int SteamAPI_ISteamNetworkingSockets_InitAuthentication(IntPtr self);

    [DllImport(LIB, CallingConvention = CallingConvention.Cdecl)]
    private static extern int SteamAPI_ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr self, IntPtr pStatus);

    // ── Resolved interface pointer ────────────────────────────────────────
    private static IntPtr _sockets = IntPtr.Zero;
    private static int    _resolvedVersion = 0;
    /// <summary>If true, we've already logged a "couldn't resolve" warning.
    /// Stops per-frame log flooding when called from RunInterfaceCallbacks
    /// before Steam has fully come up.</summary>
    private static bool   _loggedFailure;

    public static IntPtr Get()
    {
        if (_sockets != IntPtr.Zero) return _sockets;

        try { _sockets = SteamAPI_SteamNetworkingSockets_v012(); _resolvedVersion = 12; }
        catch (EntryPointNotFoundException) { _sockets = IntPtr.Zero; }
        if (_sockets == IntPtr.Zero)
        {
            try { _sockets = SteamAPI_SteamNetworkingSockets_v011(); _resolvedVersion = 11; }
            catch (EntryPointNotFoundException) { _sockets = IntPtr.Zero; }
        }
        if (_sockets == IntPtr.Zero)
        {
            try { _sockets = SteamAPI_SteamNetworkingSockets_v009(); _resolvedVersion = 9; }
            catch (EntryPointNotFoundException) { _sockets = IntPtr.Zero; }
        }

        if (_sockets != IntPtr.Zero)
        {
            Plugin.Log.LogInfo($"[SteamSocketsNative] resolved ISteamNetworkingSockets v{_resolvedVersion} @ 0x{_sockets.ToInt64():X}");
            _loggedFailure = false; // reset for any future re-probe after disconnect
        }
        else if (!_loggedFailure)
        {
            // Log ONCE per session. Subsequent calls just return Zero
            // silently — caller (RunInterfaceCallbacks etc.) handles that
            // by no-op'ing. Per-frame logs would spam the log file and tank
            // performance under Unity's logger.
            _loggedFailure = true;
            Plugin.Log.LogWarning("[SteamSocketsNative] ISteamNetworkingSockets accessor not yet available (Steam may still be starting up). Will retry silently.");
        }

        return _sockets;
    }

    // ── High-level helpers ────────────────────────────────────────────────

    /// <returns>Listen-socket handle or 0 (Invalid) on failure.</returns>
    public static uint CreateListenSocketP2P(int virtualPort)
    {
        var s = Get();
        if (s == IntPtr.Zero) return 0;
        // Build per-listen-socket config options. Each entry is 16 bytes
        // (Pack=8): int eValue + int eDataType + 8-byte union value.
        // We push:
        //   • TimeoutInitial    = 30000 ms — give SDR rendezvous up to 30 s
        //                        instead of the 10 s default. The host log
        //                        showed FindingRoute → ClosedByPeer at exactly
        //                        ~10 s after AcceptConnection, matching this
        //                        default. LAN peers in particular need the
        //                        extra slack while Steam tries direct + relay
        //                        paths in parallel.
        //   • TimeoutConnected  = 30000 ms — same slack for steady-state.
        //   • SendBufferSize    = 2 MB    — bump from default 512 KB so heavy
        //                        ZDO snapshot bursts don't get back-pressured
        //                        and silently drop. Same value Valheim uses.
        IntPtr opts = AllocConfigOptions(out int nOpts);
        try
        {
            return SteamAPI_ISteamNetworkingSockets_CreateListenSocketP2P(s, virtualPort, nOpts, opts);
        }
        finally { if (opts != IntPtr.Zero) Marshal.FreeHGlobal(opts); }
    }

    /// <returns>Poll-group handle or 0 (Invalid) on failure.</returns>
    public static uint CreatePollGroup()
    {
        var s = Get();
        if (s == IntPtr.Zero) return 0;
        return SteamAPI_ISteamNetworkingSockets_CreatePollGroup(s);
    }

    /// <summary>
    /// Initiates an outgoing P2P connection. Builds the
    /// <c>SteamNetworkingIdentity</c> as a 136-byte buffer in unmanaged
    /// memory so we don't go through any IL2Cpp-converted struct shim
    /// (which loses layout under interop).
    /// </summary>
    /// <returns>Connection handle or 0 (Invalid) on failure.</returns>
    public static uint ConnectP2P(ulong remoteSteamId64, int virtualPort)
    {
        var s = Get();
        if (s == IntPtr.Zero) return 0;

        // Identity layout (Pack=1, total 136 bytes):
        //   offset 0  : ESteamNetworkingIdentityType m_eType   (int) = 16 (SteamID)
        //   offset 4  : int m_cbSize                                 = 8  (sizeof(uint64))
        //   offset 8  : uint64 m_steamID64                            = remoteSteamId64
        //   offset 16+: zero-padded (union is 128 bytes max; SteamID uses 8)
        // BUG fix: m_cbSize was previously 16 — that's the size of two pointers,
        // not of the SteamID payload. Steamworks.NET's SetSteamID() sets it to
        // 8 (sizeof uint64) and that's what Steam validates against internally.
        // The wrong value didn't reject the connect, but caused the SDR
        // rendezvous to fail validation downstream → "FindingRoute" timeout.
        IntPtr ident = Marshal.AllocHGlobal(136);
        IntPtr opts  = AllocConfigOptions(out int nOpts);
        try
        {
            unsafe
            {
                byte* p = (byte*)ident;
                for (int i = 0; i < 136; i++) *(p + i) = 0;
                *(int*)  (p + 0) = 16;            // k_ESteamNetworkingIdentityType_SteamID
                *(int*)  (p + 4) = 8;             // m_cbSize = sizeof(uint64) for SteamID payload
                *(ulong*)(p + 8) = remoteSteamId64;
            }
            return SteamAPI_ISteamNetworkingSockets_ConnectP2P(s, ident, virtualPort, nOpts, opts);
        }
        finally
        {
            Marshal.FreeHGlobal(ident);
            if (opts != IntPtr.Zero) Marshal.FreeHGlobal(opts);
        }
    }

    // ── Config option packer ─────────────────────────────────────────────
    // Steam's SteamNetworkingConfigValue_t struct (Pack=8, 16 bytes):
    //   offset 0  : ESteamNetworkingConfigValue    m_eValue     (int32)
    //   offset 4  : ESteamNetworkingConfigDataType m_eDataType  (int32)
    //   offset 8  : union { int32, int64, float, ptr } m_val   (8 bytes)
    // We push 3 entries: TimeoutInitial=30s, TimeoutConnected=30s, SendBufferSize=2MB.
    // Layout values from steamnetworkingtypes.h (SDK 1.5x):
    //   k_ESteamNetworkingConfig_Int32              = 1
    //   k_ESteamNetworkingConfig_SendBufferSize     = 9
    //   k_ESteamNetworkingConfig_TimeoutInitial     = 24
    //   k_ESteamNetworkingConfig_TimeoutConnected   = 25
    private const int ENTRY_SIZE = 16;
    private const int CFG_INT32              = 1;
    private const int CFG_SendBufferSize     = 9;
    private const int CFG_TimeoutInitial     = 24;
    private const int CFG_TimeoutConnected   = 25;

    private static IntPtr AllocConfigOptions(out int nOpts)
    {
        nOpts = 3;
        IntPtr buf = Marshal.AllocHGlobal(ENTRY_SIZE * nOpts);
        unsafe
        {
            byte* p = (byte*)buf;
            for (int i = 0; i < ENTRY_SIZE * nOpts; i++) *(p + i) = 0;

            // Entry 0: TimeoutInitial = 30000 ms
            *(int*)(p +  0) = CFG_TimeoutInitial;
            *(int*)(p +  4) = CFG_INT32;
            *(int*)(p +  8) = 30000;

            // Entry 1: TimeoutConnected = 30000 ms
            *(int*)(p + 16) = CFG_TimeoutConnected;
            *(int*)(p + 20) = CFG_INT32;
            *(int*)(p + 24) = 30000;

            // Entry 2: SendBufferSize = 2 MB (default is 512 KB)
            *(int*)(p + 32) = CFG_SendBufferSize;
            *(int*)(p + 36) = CFG_INT32;
            *(int*)(p + 40) = 2 * 1024 * 1024;
        }
        return buf;
    }

    public static int AcceptConnection(uint hConn)
    {
        var s = Get();
        if (s == IntPtr.Zero) return -1;
        return SteamAPI_ISteamNetworkingSockets_AcceptConnection(s, hConn);
    }

    public static bool SetConnectionPollGroup(uint hConn, uint hPollGroup)
    {
        var s = Get();
        if (s == IntPtr.Zero) return false;
        return SteamAPI_ISteamNetworkingSockets_SetConnectionPollGroup(s, hConn, hPollGroup);
    }

    public static bool CloseConnection(uint hConn, int reason, string debug, bool linger)
    {
        var s = Get();
        if (s == IntPtr.Zero) return false;
        return SteamAPI_ISteamNetworkingSockets_CloseConnection(s, hConn, reason, debug ?? "", linger);
    }

    public static bool CloseListenSocket(uint hSocket)
    {
        var s = Get();
        if (s == IntPtr.Zero) return false;
        return SteamAPI_ISteamNetworkingSockets_CloseListenSocket(s, hSocket);
    }

    public static bool DestroyPollGroup(uint hPollGroup)
    {
        var s = Get();
        if (s == IntPtr.Zero) return false;
        return SteamAPI_ISteamNetworkingSockets_DestroyPollGroup(s, hPollGroup);
    }

    /// <summary>
    /// Native send. Returns Steam <c>EResult</c> code; 1 = OK.
    /// </summary>
    public static int SendMessageToConnection(uint hConn, IntPtr data, uint length, int sendFlags, out long outMsgNumber)
    {
        outMsgNumber = 0;
        var s = Get();
        if (s == IntPtr.Zero) return -1;
        return SteamAPI_ISteamNetworkingSockets_SendMessageToConnection(s, hConn, data, length, sendFlags, out outMsgNumber);
    }

    /// <summary>
    /// Native receive. <paramref name="msgPtrs"/> is a pinned IntPtr[] of
    /// at least <paramref name="maxMessages"/> capacity; on return, the
    /// first N entries (where N = return value) point to
    /// SteamNetworkingMessage_t structs the caller must copy from and then
    /// release via <see cref="ReleaseMessage"/>.
    /// </summary>
    public static int ReceiveMessagesOnPollGroup(uint hPollGroup, IntPtr msgPtrs, int maxMessages)
    {
        var s = Get();
        if (s == IntPtr.Zero) return 0;
        return SteamAPI_ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(s, hPollGroup, msgPtrs, maxMessages);
    }

    public static void ReleaseMessage(IntPtr msgPtr)
    {
        if (msgPtr == IntPtr.Zero) return;
        try { SteamAPI_SteamNetworkingMessage_t_Release(msgPtr); } catch { }
    }

    /// <summary>
    /// Pump the interface-level callback queue. This is SEPARATE from the
    /// global <c>SteamAPI_RunCallbacks</c> — that one fires our registered
    /// CCallbackBase for status changes, but the SDR P2P rendezvous worker
    /// needs the interface's own pump to actually service incoming
    /// rendezvous packets. Without this, AcceptConnection succeeds, the
    /// connection enters FindingRoute, and then times out because the SDR
    /// handshake never gets serviced.
    /// </summary>
    public static void RunInterfaceCallbacks()
    {
        var s = Get();
        if (s == IntPtr.Zero) return;
        try { SteamAPI_ISteamNetworkingSockets_RunCallbacks(s); } catch { }
    }

    /// <summary>
    /// Kicks off the authentication-cert request asynchronously. Required
    /// for SDR routing — without an issued cert, route-finding eventually
    /// times out. Returns the current availability code (0..100).
    /// </summary>
    public static int InitAuthentication()
    {
        var s = Get();
        if (s == IntPtr.Zero) return -1;
        try { return SteamAPI_ISteamNetworkingSockets_InitAuthentication(s); }
        catch { return -1; }
    }

    /// <summary>
    /// Reads <c>SteamNetAuthenticationStatus_t</c>:
    /// <c>m_eAvail</c> (int32, offset 0) + <c>char m_debugMsg[256]</c> (offset 4).
    /// Total 260 bytes; we allocate 272 for safety. Returns the auth-availability
    /// state. NOTE: This is a different layout from
    /// <c>SteamRelayNetworkStatus_t</c> (which has padding + 3 extra avail
    /// fields between eAvail and debugMsg) — earlier code mistakenly used
    /// the relay-status offsets here, producing truncated 'ert' strings
    /// instead of the full 'cert is valid for ...' debug message.
    /// </summary>
    public static int GetAuthenticationStatus(out string debugMsg)
    {
        debugMsg = "";
        var s = Get();
        if (s == IntPtr.Zero) return -1;

        IntPtr buf = Marshal.AllocHGlobal(272);
        try
        {
            unsafe
            {
                byte* p = (byte*)buf;
                for (int i = 0; i < 272; i++) *(p + i) = 0;
                int rc = SteamAPI_ISteamNetworkingSockets_GetAuthenticationStatus(s, buf);
                int eAvail = *(int*)(p + 0);
                int len = 0;
                while (len < 256 && *(p + 4 + len) != 0) len++;
                debugMsg = len == 0 ? "" : System.Text.Encoding.ASCII.GetString(p + 4, len);
                return eAvail;
            }
        }
        catch { return -1; }
        finally { Marshal.FreeHGlobal(buf); }
    }
}
