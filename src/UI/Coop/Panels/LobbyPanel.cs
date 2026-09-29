using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Player;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Post-connection lobby. Shown after the client successfully connects to a
/// host but before they're in a synced game world.
///
/// Live status block: reads <see cref="HostStatusSync.LastFromHost"/> and
/// renders one of:
///   • "Host on main menu — waiting…"
///   • "Host loading world…"
///   • "Host in game: New Babylon, Day 3 14:32"
///
/// Note: dynamic phase / status strings (loading / in-game / day+time) stay
/// in English right now — they're displayed briefly and would balloon the
/// translation set. Localised buttons + main labels handle the bulk of
/// what the user sees.
/// </summary>
public class LobbyPanel : CoopPanelBase
{
    protected override string Title => L.Get("lobby.title");

    // Lobby has many rows (host status block + 4 action buttons + reset
    // explanation paragraph) that don't fit in the default 520px panel.
    // Scrollable + taller so Customize / Settings / Hide stay reachable.
    protected override float PanelHeight   => 700f;
    protected override bool  ScrollableBody => true;

    private Text _hostHeader;
    private Text _hostPhase;
    private Text _hostCity;
    private Text _hostTime;
    private Text _hostPlayers;
    private Text _joinProgress;
    private Button _disconnectBtn;
    private Button _resetBtn;
    private Text   _resetStatus;
    private bool   _resetArmed;

    private const string RESET_LABEL_NORMAL = "🗑  Reset character & disconnect";
    private const string RESET_LABEL_ARMED  = "⚠  Click again to confirm";

    protected override void BuildBody()
    {
        WrappedBodyLabel("Connected to host. Waiting for world…",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        _hostHeader  = BodyLabel("Host: —",   CoopMenuTheme.FontSizeHeader, CoopMenuTheme.LabelTitle, TextAnchor.MiddleCenter, FontStyle.Bold);
        _hostPhase   = BodyLabel("Status: —", CoopMenuTheme.FontSizeBody,   CoopMenuTheme.LabelBody);
        _hostCity    = BodyLabel("",          CoopMenuTheme.FontSizeBody,   CoopMenuTheme.LabelMuted);
        _hostTime    = BodyLabel("",          CoopMenuTheme.FontSizeSmall,  CoopMenuTheme.LabelMuted);
        _hostPlayers = BodyLabel("",          CoopMenuTheme.FontSizeSmall,  CoopMenuTheme.LabelMuted);
        Spacer(6f);
        _joinProgress = WrappedBodyLabel("", CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelOk);

        Spacer(40f);

        _disconnectBtn = CoopMenuFactory.MenuButton("Disconnect", Body,
            "🚪  " + L.Get("lobby.btn.disconnect"), OnDisconnectClick);

        Spacer(6f);

        // Reset character on this host. Clients only — for host themselves
        // it'd just orphan their own twin (host's identity comes from
        // Game.Instance, not from CharacterStore).
        _resetBtn = CoopMenuFactory.MenuButton("ResetChar", Body,
            RESET_LABEL_NORMAL, OnResetClick);
        _resetStatus = WrappedBodyLabel(
            "Forgets your name on this host's world and disconnects. " +
            "Your old in-game identity (citizen) keeps the name but rejoins normal NPC life.",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(6f);

        CoopMenuFactory.MenuButton("Customize", Body, L.Get("lobby.btn.appearance"),
            () => CoopMenuController.OpenAppearance(firstTimeFlow: false));

        Spacer(4f);

        CoopMenuFactory.MenuButton("Settings", Body, L.Get("lobby.btn.settings"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Settings));

        Spacer(4f);

        CoopMenuFactory.MenuButton("Hide", Body, "✕  Hide menu",
            () => CoopMenuController.Hide());
    }

    public override void Show()
    {
        base.Show();
        Refresh();
    }

    public void Tick()
    {
        if (Root == null || !Root.activeSelf) return;
        Refresh();
    }

    private void Refresh()
    {
        // Disconnected — bounce back to main panel.
        if (!NetworkManager.IsConnected)
        {
            CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main);
            return;
        }

        // If we're the host ourselves, show our own state with a different framing.
        if (NetworkManager.IsHost)
        {
            _hostHeader.text  = $"Hosting as {NetworkManager.LocalPlayerName ?? "Host"}";
            _hostPhase.text   = "Status: " + DescribeLocalPhase();
            _hostPhase.color  = CoopMenuTheme.LabelOk;
            _hostCity.text    = TryCityName();
            _hostTime.text    = "";
            _hostPlayers.text = $"Connected peers: {NetworkManager.Players?.Count ?? 0}";
            if (_joinProgress != null) _joinProgress.text = "";
            return;
        }

        // Client view — where we are in getting into the host's world.
        if (_joinProgress != null)
        {
            var (text, done) = DescribeJoinProgress();
            _joinProgress.text  = text;
            _joinProgress.color = done ? CoopMenuTheme.LabelOk : CoopMenuTheme.LabelWarn;
        }

        // Client view — show host's broadcasted status.
        if (HostStatusSync.HasHostStatus)
        {
            var s = HostStatusSync.LastFromHost;
            _hostHeader.text = $"Host: {(string.IsNullOrEmpty(s.HostNickname) ? "—" : s.HostNickname)}";
            switch ((HostPhase)s.Phase)
            {
                case HostPhase.InMainMenu:
                    _hostPhase.text  = "⏸  Host is in main menu";
                    _hostPhase.color = CoopMenuTheme.LabelWarn;
                    _hostCity.text   = "Waiting for them to start a session…";
                    _hostTime.text   = "";
                    break;
                case HostPhase.LoadingWorld:
                    _hostPhase.text  = "⏳  Host is loading the world…";
                    _hostPhase.color = CoopMenuTheme.LabelWarn;
                    _hostCity.text   = "You'll join automatically once it's ready.";
                    _hostTime.text   = "";
                    break;
                case HostPhase.InGame:
                    _hostPhase.text  = "🎮  Host is in game";
                    _hostPhase.color = CoopMenuTheme.LabelOk;
                    _hostCity.text   = string.IsNullOrEmpty(s.CityName)
                        ? "(unknown city)" : $"City: {s.CityName}";
                    _hostTime.text   = $"Game time: {FormatGameTime(s.GameTime)}";
                    break;
            }
            _hostPlayers.text = $"Players: {s.PlayerCount}";
        }
        else
        {
            _hostHeader.text = "Host: connecting…";
            _hostPhase.text  = "Awaiting first status…";
            _hostPhase.color = CoopMenuTheme.LabelMuted;
            _hostCity.text   = "";
            _hostTime.text   = "";
            _hostPlayers.text = "";
        }
    }

    /// <summary>The join pipeline as the client sees it: the host capturing,
    /// the city file and save arriving, SoD loading, the live state arriving.</summary>
    private static (string text, bool done) DescribeJoinProgress()
    {
        switch (SaveTransfer.Stage)
        {
            case SaveTransfer.ClientStage.ReceivingCity:
                return (L.Get("lobby.join.city", Mathf.RoundToInt(SaveTransfer.StageProgress * 100f),
                              (SaveTransfer.StageBytes / 1048576f).ToString("F1")), false);
            case SaveTransfer.ClientStage.ReceivingSave:
                return (L.Get("lobby.join.save", Mathf.RoundToInt(SaveTransfer.StageProgress * 100f),
                              (SaveTransfer.StageBytes / 1048576f).ToString("F1")), false);
            case SaveTransfer.ClientStage.Loading:
                return (L.Get("lobby.join.loading"), false);
        }
        if (WorldAutoLoad.IsBootstrappingWorld) return (L.Get("lobby.join.generating"), false);
        if (SoDCoop.Zdo.ZdoMan.ClientSynced)   return (L.Get("lobby.join.done"), true);
        if (WorldReadyGate.IsWorldReady && WorldAutoLoad.JoinedSessionActive)
            return (L.Get("lobby.join.syncing"), false);
        return (L.Get("lobby.join.waitingHost"), false);
    }

    private string DescribeLocalPhase()
    {
        switch (HostStatusSync.ComputeLocalPhase())
        {
            case HostPhase.LoadingWorld: return "loading world…";
            case HostPhase.InGame:       return "in game";
            default:                     return "main menu";
        }
    }

    private static string TryCityName()
    {
        try { return string.IsNullOrEmpty(CityData.Instance?.cityName) ? "" : $"City: {CityData.Instance.cityName}"; }
        catch { return ""; }
    }

    private static string FormatGameTime(float t)
    {
        // SoD's gameTime is in hours since start; convert to days + HH:MM.
        if (t <= 0) return "—";
        int dayIdx = Mathf.FloorToInt(t / 24f) + 1;
        float hourPart = t - Mathf.Floor(t / 24f) * 24f;
        int hh = Mathf.FloorToInt(hourPart);
        int mm = Mathf.FloorToInt((hourPart - hh) * 60f);
        return $"Day {dayIdx} — {hh:D2}:{mm:D2}";
    }

    private void OnDisconnectClick()
    {
        try { NetworkManager.Shutdown(); } catch { }
        CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main);
    }

    private void OnResetClick()
    {
        // Hide the reset action when we're the host — it's nonsensical (host
        // identity comes from Game.Instance, not CharacterStore) and would
        // just orphan its own twin record on disk.
        if (NetworkManager.IsHost)
        {
            if (_resetStatus != null)
            {
                _resetStatus.text  = "Reset is for joining clients only — host identity comes from your loaded save.";
                _resetStatus.color = CoopMenuTheme.LabelWarn;
            }
            return;
        }

        if (!_resetArmed)
        {
            _resetArmed = true;
            UpdateResetButtonLabel();
            if (_resetStatus != null)
            {
                _resetStatus.text  = "Sure? You'll be disconnected and your name on this world cleared.";
                _resetStatus.color = CoopMenuTheme.LabelWarn;
            }
            return;
        }

        try
        {
            // Tell the host to drop our record + unfreeze our old twin.
            NetworkManager.RequestCharacterReset();

            // Wipe local stable identity so a reconnect is treated as new.
            CharacterIdentity.Reset();

            // Host will close the connection in response to CharacterReset;
            // but call Shutdown here too as a safety net so the UI cleans up
            // immediately without waiting for the disconnect round-trip.
            try { NetworkManager.Shutdown(); } catch { }

            CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"LobbyPanel.OnResetClick: {ex}");
        }
        finally
        {
            _resetArmed = false;
            UpdateResetButtonLabel();
        }
    }

    private void UpdateResetButtonLabel()
    {
        if (_resetBtn == null) return;
        var lbl = _resetBtn.GetComponentInChildren<Text>();
        if (lbl != null) lbl.text = _resetArmed ? RESET_LABEL_ARMED : RESET_LABEL_NORMAL;
    }
}
