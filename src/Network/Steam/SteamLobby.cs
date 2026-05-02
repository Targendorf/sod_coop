using System;
using Steamworks;

namespace SoDCoop.Network.Steam;

/// <summary>
/// Friends-only Steam lobby that gates connections to the host. Replaces
/// the previous IP/port/join-code matchmaking surface entirely.
///
/// <para>Flow:
///   <list type="number">
///     <item>Host clicks "Host" → <see cref="CreateLobbyAsync"/> →
///           <see cref="OnLobbyCreated"/> sets metadata + starts the
///           SteamNetworkingSockets listen socket.</item>
///     <item>Host clicks "Invite Friends" → Steam overlay opens; friend
///           clicks the invite or "Join Game" on host's profile.</item>
///     <item>Friend's game receives <see cref="GameLobbyJoinRequested_t"/>
///           → <see cref="JoinLobby"/> → <see cref="OnLobbyEnter"/> reads
///           host's SteamID from lobby data and dials via
///           <see cref="SteamTransport.ConnectTo"/>.</item>
///   </list>
/// </para>
/// </summary>
public static class SteamLobby
{
    public const string LobbyKey_HostId  = "host_steamid";
    public const string LobbyKey_Version = "version";
    public const string LobbyKey_City    = "city";
    public const string LobbyKey_Game    = "game_id";
    /// <summary>Identifies this mod's lobbies vs other Steam lobbies for
    /// the same AppID (anti-collision when a player runs several mods).</summary>
    public const string LobbyGameTag = "SoDCoop_v1";

    /// <summary>Current lobby ID. <see cref="CSteamID.IsValid"/> is false when
    /// no lobby is active. Host owns it after CreateLobby; clients hold a
    /// reference after JoinLobby.</summary>
    public static CSteamID CurrentLobby { get; private set; }

    /// <summary>Lobby owner's Steam ID. Equals the local SteamID when hosting;
    /// the host's SteamID when client. Invalid when not in a lobby.</summary>
    public static CSteamID HostSteamId { get; private set; }

    public static bool InLobby => CurrentLobby.IsValid();

    /// <summary>Raised after the local user has fully entered a lobby (host
    /// or client side). Carries the lobby ID. Hooked by NetworkManager to
    /// kick off the actual SteamNetworkingSockets connection on the client.</summary>
    public static event Action<CSteamID> OnEnteredLobby;

    /// <summary>Raised when the local user leaves / fails to enter a lobby
    /// (lobby destroyed, kicked, network error, refused). UI consumers
    /// route back to the main panel.</summary>
    public static event Action<string> OnLeftLobby;

    /// <summary>Raised on the host when a peer's lobby membership changes
    /// (joined / left / disconnected). Lets the host log who's
    /// transitioning through the lobby UI before the SteamNetworkingSockets
    /// connection is dialed.</summary>
    public static event Action<CSteamID, EChatMemberStateChange> OnMemberStateChanged;

    private const int MAX_LOBBY_MEMBERS = 4;

    // ─── Host: create a lobby ─────────────────────────────────────────────

    /// <summary>Async: requests Steam to create a friends-only lobby.
    /// The result arrives via <see cref="OnLobbyCreated"/> — that handler
    /// will populate metadata and call back into NetworkManager to spin up
    /// the listen socket.</summary>
    public static void CreateLobbyAsync()
    {
        if (!SteamCallbacks.IsInitialized)
        {
            Plugin.Log.LogError("[SteamLobby] CreateLobbyAsync called before SteamCallbacks.Initialize.");
            NetworkManager.OnSteamLobbyCreateFailed("Steam not initialized");
            return;
        }
        if (InLobby)
        {
            Plugin.Log.LogWarning("[SteamLobby] CreateLobbyAsync: already in a lobby — leaving first.");
            LeaveLobby();
        }

        try
        {
            SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, MAX_LOBBY_MEMBERS);
            Plugin.Log.LogInfo("[SteamLobby] requested friends-only lobby (4 slots).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamLobby] CreateLobby threw: {ex}");
            NetworkManager.OnSteamLobbyCreateFailed(ex.Message);
        }
    }

    /// <summary>Steam callback. Fires on the host after CreateLobby resolves.</summary>
    public static void OnLobbyCreated(LobbyCreated_t cb)
    {
        if (cb.m_eResult != EResult.k_EResultOK)
        {
            Plugin.Log.LogError($"[SteamLobby] CreateLobby failed: {cb.m_eResult}");
            NetworkManager.OnSteamLobbyCreateFailed($"Steam: {cb.m_eResult}");
            return;
        }

        CurrentLobby = new CSteamID(cb.m_ulSteamIDLobby);
        HostSteamId  = SteamUser.GetSteamID();

        try
        {
            SteamMatchmaking.SetLobbyData(CurrentLobby, LobbyKey_Game,    LobbyGameTag);
            SteamMatchmaking.SetLobbyData(CurrentLobby, LobbyKey_HostId,  HostSteamId.m_SteamID.ToString());
            SteamMatchmaking.SetLobbyData(CurrentLobby, LobbyKey_Version, "0.1");

            string cityName = "";
            try { cityName = global::CityData.Instance?.cityName ?? ""; } catch { }
            SteamMatchmaking.SetLobbyData(CurrentLobby, LobbyKey_City, cityName);

            // Rich presence — lets friends see "Join Game" on our profile.
            SteamFriends.SetRichPresence("connect", $"+connect_lobby {CurrentLobby.m_SteamID}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[SteamLobby] post-create metadata: {ex.Message}");
        }

        Plugin.Log.LogInfo($"[SteamLobby] lobby created id={CurrentLobby.m_SteamID} (friends-only, 4 slots).");
        try { OnEnteredLobby?.Invoke(CurrentLobby); } catch (Exception ex) { Plugin.Log.LogWarning($"OnEnteredLobby (host): {ex.Message}"); }
        NetworkManager.OnSteamLobbyHostReady();
    }

    // ─── Client: join a lobby ─────────────────────────────────────────────

    /// <summary>Issue a JoinLobby request. The result arrives via
    /// <see cref="OnLobbyEnter"/>.</summary>
    public static void JoinLobby(CSteamID lobbyId)
    {
        if (!SteamCallbacks.IsInitialized)
        {
            Plugin.Log.LogError("[SteamLobby] JoinLobby called before SteamCallbacks.Initialize.");
            return;
        }
        if (InLobby && CurrentLobby == lobbyId)
        {
            Plugin.Log.LogInfo($"[SteamLobby] already in lobby {lobbyId.m_SteamID} — ignoring duplicate join.");
            return;
        }
        if (InLobby) LeaveLobby();

        try
        {
            SteamMatchmaking.JoinLobby(lobbyId);
            Plugin.Log.LogInfo($"[SteamLobby] joining lobby {lobbyId.m_SteamID}...");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamLobby] JoinLobby threw: {ex}");
        }
    }

    /// <summary>Steam callback. Fires on the joiner once the lobby is entered.
    /// At this point lobby metadata (host SteamID, city, version) is readable
    /// and we can dial the host via SteamNetworkingSockets.</summary>
    public static void OnLobbyEnter(LobbyEnter_t cb)
    {
        var lobby = new CSteamID(cb.m_ulSteamIDLobby);

        if (cb.m_EChatRoomEnterResponse != (uint)EChatRoomEnterResponse.k_EChatRoomEnterResponseSuccess)
        {
            string reason = ((EChatRoomEnterResponse)cb.m_EChatRoomEnterResponse).ToString();
            Plugin.Log.LogError($"[SteamLobby] LobbyEnter failed for {lobby.m_SteamID}: {reason}");
            try { OnLeftLobby?.Invoke($"Lobby join failed: {reason}"); } catch { }
            return;
        }

        CurrentLobby = lobby;

        // Pull host SteamID from the lobby metadata (set by the host in
        // OnLobbyCreated). On rare timing edge cases the data hasn't
        // propagated yet — we'll try GetLobbyOwner as a fallback.
        ulong hostId = 0;
        try
        {
            string raw = SteamMatchmaking.GetLobbyData(lobby, LobbyKey_HostId);
            ulong.TryParse(raw, out hostId);
        }
        catch { }
        if (hostId == 0)
        {
            try { hostId = SteamMatchmaking.GetLobbyOwner(lobby).m_SteamID; } catch { }
        }
        HostSteamId = new CSteamID(hostId);

        if (!HostSteamId.IsValid())
        {
            Plugin.Log.LogError($"[SteamLobby] entered lobby {lobby.m_SteamID} but host SteamID is invalid — leaving.");
            LeaveLobby();
            try { OnLeftLobby?.Invoke("Host SteamID unresolved"); } catch { }
            return;
        }

        // Cache friendly host name for SessionStore.
        string hostName = "";
        try { hostName = SteamFriends.GetFriendPersonaName(HostSteamId); } catch { }
        Plugin.Log.LogInfo($"[SteamLobby] entered lobby {lobby.m_SteamID} hosted by '{hostName}' ({HostSteamId.m_SteamID}).");

        try { OnEnteredLobby?.Invoke(lobby); } catch (Exception ex) { Plugin.Log.LogWarning($"OnEnteredLobby (client): {ex.Message}"); }

        // Hand off to the transport — connect to the host now that we know
        // their SteamID.
        NetworkManager.OnSteamLobbyJoined(lobby, HostSteamId, hostName);
    }

    /// <summary>Steam callback. Fires on every member transition — joins,
    /// leaves, disconnects. Host uses this to log lobby churn before the
    /// SteamNetworkingSockets connection is dialed.</summary>
    public static void OnLobbyChatUpdate(LobbyChatUpdate_t cb)
    {
        if (cb.m_ulSteamIDLobby != CurrentLobby.m_SteamID) return;

        var changed = new CSteamID(cb.m_ulSteamIDUserChanged);
        var change = (EChatMemberStateChange)cb.m_rgfChatMemberStateChange;

        try { OnMemberStateChanged?.Invoke(changed, change); }
        catch (Exception ex) { Plugin.Log.LogWarning($"OnMemberStateChanged: {ex.Message}"); }

        Plugin.Log.LogInfo($"[SteamLobby] member {changed.m_SteamID} → {change}");
    }

    /// <summary>Steam callback. Fires when lobby metadata changes — useful
    /// for clients picking up host's SteamID if the entry-time read raced.</summary>
    public static void OnLobbyDataUpdate(LobbyDataUpdate_t cb)
    {
        if (cb.m_ulSteamIDLobby != CurrentLobby.m_SteamID) return;
        // Currently a no-op: we read everything we need at LobbyEnter time.
        // Hooked so the callback isn't unprocessed in the queue.
    }

    /// <summary>Steam callback. Fires when a friend clicks "Join Game" on
    /// our profile, or accepts an invite from the chat overlay. Auto-joins.</summary>
    public static void OnGameLobbyJoinRequested(GameLobbyJoinRequested_t cb)
    {
        Plugin.Log.LogInfo($"[SteamLobby] GameLobbyJoinRequested → lobby {cb.m_steamIDLobby.m_SteamID}, friend={cb.m_steamIDFriend.m_SteamID}");
        JoinLobby(cb.m_steamIDLobby);
    }

    // ─── Leave ─────────────────────────────────────────────────────────────

    public static void LeaveLobby()
    {
        if (!CurrentLobby.IsValid()) return;
        try { SteamMatchmaking.LeaveLobby(CurrentLobby); } catch (Exception ex) { Plugin.Log.LogWarning($"[SteamLobby] LeaveLobby: {ex.Message}"); }
        try { SteamFriends.ClearRichPresence(); } catch { }
        Plugin.Log.LogInfo($"[SteamLobby] left lobby {CurrentLobby.m_SteamID}");
        CurrentLobby = CSteamID.Nil;
        HostSteamId = CSteamID.Nil;
        try { OnLeftLobby?.Invoke("user left lobby"); } catch { }
    }

    // ─── Invite UI ─────────────────────────────────────────────────────────

    /// <summary>Open the Steam overlay to send an invite to the current
    /// lobby. No-op if no lobby is active.</summary>
    public static bool OpenInviteDialog()
    {
        if (!InLobby)
        {
            Plugin.Log.LogWarning("[SteamLobby] OpenInviteDialog: no lobby — start hosting first.");
            return false;
        }
        try
        {
            SteamFriends.ActivateGameOverlayInviteDialog(CurrentLobby);
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamLobby] OpenInviteDialog: {ex}");
            return false;
        }
    }

    /// <summary>Open the Steam overlay to the friends list — clients use
    /// this when looking for a host to join.</summary>
    public static bool OpenFriendsOverlay()
    {
        try
        {
            SteamFriends.ActivateGameOverlay("Friends");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[SteamLobby] OpenFriendsOverlay: {ex}");
            return false;
        }
    }

    /// <summary>Member count of the current lobby (or 0 if not in one).</summary>
    public static int MemberCount
    {
        get
        {
            if (!InLobby) return 0;
            try { return SteamMatchmaking.GetNumLobbyMembers(CurrentLobby); }
            catch { return 0; }
        }
    }
}
