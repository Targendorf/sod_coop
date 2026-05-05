using System;
using Steamworks;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Holds every <see cref="Callback{T}"/> instance the mod registers with
/// Steamworks.NET. They MUST be kept alive in static fields — the
/// underlying Steamworks.NET <c>Callback&lt;T&gt;</c> wrapper deregisters
/// itself on finalisation, so a local-scope variable would silently stop
/// firing the moment GC ran.
///
/// <para>SoD's own <c>SteamAPIController</c> already calls
/// <c>SteamAPI.Init()</c> at game launch — we never call it again. We only
/// hook callbacks and call <see cref="SteamAPI.RunCallbacks"/> from the
/// mod's per-frame tick.</para>
/// </summary>
public static class SteamCallbacks
{
    private static bool _initialized;

    // Kept alive in static fields so Steamworks.NET's Callback finaliser
    // doesn't deregister us mid-session.
    private static Callback<LobbyCreated_t>                              _cbLobbyCreated;
    private static Callback<LobbyEnter_t>                                _cbLobbyEnter;
    private static Callback<LobbyChatUpdate_t>                           _cbLobbyChatUpdate;
    private static Callback<GameLobbyJoinRequested_t>                    _cbGameLobbyJoinRequested;
    private static Callback<SteamNetConnectionStatusChangedCallback_t>   _cbConnStatusChanged;
    private static Callback<LobbyDataUpdate_t>                           _cbLobbyDataUpdate;

    public static void Initialize()
    {
        if (_initialized) return;

        try
        {
            if (!SteamAPI.IsSteamRunning())
            {
                Plugin.Log.LogError("[SteamCallbacks] SteamAPI is not running — Steam P2P unavailable. Did the game launch outside Steam?");
                return;
            }

            // Il2CppInterop on this Steamworks.NET wrapper exposes
            // Callback<T>.DispatchDelegate as a generated class rather than a
            // C# delegate type, so neither method-group nor lambda conversion
            // compiles. Stubbed for now — Steam P2P transport callbacks not
            // wired. Single-player + manual peer connection paths still work.
            // TODO: revive via DelegateSupport.ConvertDelegate or reflection.
            _ = _cbLobbyCreated; _ = _cbLobbyEnter; _ = _cbLobbyChatUpdate;
            _ = _cbGameLobbyJoinRequested; _ = _cbLobbyDataUpdate; _ = _cbConnStatusChanged;
            Plugin.Log.LogWarning("[SteamCallbacks] Callback<T>.Create stubbed — IL2CPP interop incompatibility. Steam P2P inactive.");

            _initialized = true;
            Plugin.Log.LogInfo($"[SteamCallbacks] init complete (stubbed). SteamID={SteamUser.GetSteamID().m_SteamID} appID={SteamUtils.GetAppID().m_AppId}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamCallbacks] init failed: {ex}");
        }
    }

    /// <summary>Pump per frame from <c>NetworkManager.Update()</c>. Drives the
    /// Steam callback queue so all the static handlers above actually fire.</summary>
    public static void RunCallbacks()
    {
        if (!_initialized) return;
        try { SteamAPI.RunCallbacks(); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[SteamCallbacks] RunCallbacks: {ex.Message}"); }
    }

    public static bool IsInitialized => _initialized;
}
