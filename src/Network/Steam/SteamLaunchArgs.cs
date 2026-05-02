using System;
using Steamworks;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Handles the <c>+connect_lobby &lt;lobbyId&gt;</c> command-line argument
/// that Steam appends when a friend clicks "Join Game" on the host's profile
/// while the joiner's copy of SoD is <b>not yet running</b>. Steam launches
/// the game with this arg; vanilla SoD ignores it (the base game has no
/// multiplayer), so we parse it ourselves and queue an auto-join.
///
/// <para>Lifecycle:
///   <list type="bullet">
///     <item><see cref="Parse"/> at plugin load — pulls the lobby ID out of
///           <see cref="Environment.GetCommandLineArgs"/>.</item>
///     <item><see cref="TryDrain"/> per frame from
///           <see cref="SoDCoop.CoopUpdateRunner.Update"/> — once Steam
///           callbacks are live and we're not already mid-session, fires
///           a one-shot <see cref="NetworkManager.Connect(CSteamID)"/>.</item>
///   </list>
/// </para>
///
/// <para>If a friend invites you while the game is already running, this
/// path is bypassed entirely — the <see cref="GameLobbyJoinRequested_t"/>
/// callback fires inside the running process and <see cref="SteamLobby"/>
/// auto-joins.</para>
/// </summary>
public static class SteamLaunchArgs
{
    private const string CONNECT_LOBBY_ARG = "+connect_lobby";

    /// <summary>Pending lobby ID to join, or 0 once consumed / never set.</summary>
    private static ulong _pendingLobbyId;

    /// <summary>True once we've handed the pending ID off to NetworkManager.
    /// Prevents a second auto-join attempt if the user disconnects and the
    /// game keeps running with the same args still in memory.</summary>
    private static bool _consumed;

    public static ulong PendingLobbyId => _pendingLobbyId;
    public static bool  HasPending     => _pendingLobbyId != 0 && !_consumed;

    /// <summary>Read the launch args once at plugin load. No-op if no
    /// <c>+connect_lobby</c> token is present.</summary>
    public static void Parse()
    {
        try
        {
            var args = Environment.GetCommandLineArgs();
            if (args == null || args.Length == 0) return;

            for (int i = 0; i < args.Length - 1; i++)
            {
                if (string.Equals(args[i], CONNECT_LOBBY_ARG, StringComparison.OrdinalIgnoreCase))
                {
                    if (ulong.TryParse(args[i + 1], out var lobbyId) && lobbyId != 0)
                    {
                        _pendingLobbyId = lobbyId;
                        Plugin.Log.LogInfo($"[SteamLaunchArgs] detected +connect_lobby {lobbyId} — will auto-join once Steam is ready.");
                    }
                    else
                    {
                        Plugin.Log.LogWarning($"[SteamLaunchArgs] +connect_lobby followed by unparseable value '{args[i + 1]}'.");
                    }
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SteamLaunchArgs] Parse: {ex.Message}");
        }
    }

    /// <summary>Per-frame attempt to fire the auto-join. Bails until Steam
    /// callbacks are initialized; only ever fires once. Safe to call every
    /// frame — does nothing on the steady-state path.</summary>
    public static void TryDrain()
    {
        if (_consumed || _pendingLobbyId == 0) return;
        if (!SteamCallbacks.IsInitialized) return;

        // Don't auto-join if the user already initiated something else
        // (e.g. clicked Host or manually navigated to Join). The Connecting
        // state is set by both StartHost and Connect; Hosting/Connected are
        // post-handshake.
        var st = NetworkManager.State;
        if (st != ConnectionState.Disconnected) { _consumed = true; return; }

        Plugin.Log.LogInfo($"[SteamLaunchArgs] auto-joining lobby {_pendingLobbyId} from Steam launch arg.");
        _consumed = true;
        try { NetworkManager.Connect(new CSteamID(_pendingLobbyId)); }
        catch (Exception ex) { Plugin.Log.LogError($"[SteamLaunchArgs] auto-join failed: {ex}"); }
    }
}
