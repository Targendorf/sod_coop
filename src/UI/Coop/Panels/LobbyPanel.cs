using SoDCoop.Network;
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
/// </summary>
public class LobbyPanel : CoopPanelBase
{
    protected override string Title => "Lobby";

    private Text _hostHeader;
    private Text _hostPhase;
    private Text _hostCity;
    private Text _hostTime;
    private Text _hostPlayers;
    private Button _disconnectBtn;

    protected override void BuildBody()
    {
        BodyLabel("Connected to host. Waiting for world…",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        _hostHeader  = BodyLabel("Host: —",   CoopMenuTheme.FontSizeHeader, CoopMenuTheme.LabelTitle, TextAnchor.MiddleCenter, FontStyle.Bold);
        _hostPhase   = BodyLabel("Status: —", CoopMenuTheme.FontSizeBody,   CoopMenuTheme.LabelBody);
        _hostCity    = BodyLabel("",          CoopMenuTheme.FontSizeBody,   CoopMenuTheme.LabelMuted);
        _hostTime    = BodyLabel("",          CoopMenuTheme.FontSizeSmall,  CoopMenuTheme.LabelMuted);
        _hostPlayers = BodyLabel("",          CoopMenuTheme.FontSizeSmall,  CoopMenuTheme.LabelMuted);

        Spacer(40f);

        _disconnectBtn = CoopMenuFactory.MenuButton("Disconnect", Body,
            "🚪  Disconnect", OnDisconnectClick);

        Spacer(6f);

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
            return;
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
}
