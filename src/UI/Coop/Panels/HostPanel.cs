using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Network.Steam;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Host setup. Creates a friends-only Steam lobby and exposes a Steam
/// overlay invite button so friends can join. There are no IPs, ports, or
/// join-codes any more — Steam SDR handles transport, lobby visibility is
/// gated to friends, and the overlay's "Join Game" affordance brings them
/// in.
/// </summary>
public class HostPanel : CoopPanelBase
{
    protected override string Title => L.Get("host.title");

    // Identity label + Start/Stop/Invite + direct-IP section (label +
    // port + button) + status + back = ~10 rows. Scrollable keeps the
    // direct-IP section reachable on smaller panels / larger fonts.
    protected override float PanelHeight => 620f;
    protected override bool  ScrollableBody => true;

    private Text       _identityLabel;
    private Text       _statusLabel;
    private Button     _startBtn;
    private Button     _stopBtn;
    private Button     _inviteBtn;
    private InputField _portField;
    private Button     _startIPBtn;

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("host.tagline"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        BodyLabel(L.Get("host.label.playingAs"), CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _identityLabel = WrappedBodyLabel(L.Get("host.identity.reading"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelOk, TextAnchor.MiddleLeft, FontStyle.Bold);

        Spacer(12f);

        _startBtn  = CoopMenuFactory.MenuButton("Start", Body, L.Get("host.btn.start"), OnStartClick);
        _stopBtn   = CoopMenuFactory.MenuButton("Stop",  Body, L.Get("host.btn.stop"),  OnStopClick);
        _stopBtn.gameObject.SetActive(false);

        _inviteBtn = CoopMenuFactory.MenuButton("Invite", Body, L.Get("host.btn.invite"), OnInviteClick);
        _inviteBtn.gameObject.SetActive(false);

        Spacer(12f);

        // ── Direct IP fallback ──────────────────────────────────────────
        // Steam's SDR routing fails for some peer combinations (FindingRoute
        // → ClosedByPeer timeout). Direct UDP via LiteNetLib is the
        // alternative — host opens a port, friend types in IP:port.
        BodyLabel("Direct IP (alt.)", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _portField = CoopMenuFactory.TextInput("Port", Body, "7777", "Port", 320f);
        _startIPBtn = CoopMenuFactory.MenuButton("StartIP", Body, "Host on port", OnStartIPClick);

        Spacer(8f);

        _statusLabel = WrappedBodyLabel(L.Get("host.status.notHosting"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, L.Get("host.btn.back"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
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
        bool hosting = NetworkManager.IsConnected && NetworkManager.IsHost;
        bool inGame  = WorldReadyGate.IsWorldReady;
        bool canHost = !hosting && inGame;

        if (_startBtn  != null) { _startBtn .gameObject.SetActive(!hosting); _startBtn.interactable = canHost; }
        if (_stopBtn   != null)   _stopBtn  .gameObject.SetActive(hosting);
        if (_inviteBtn != null)   _inviteBtn.gameObject.SetActive(hosting);

        if (_identityLabel != null)
        {
            string display;
            if (hosting)
            {
                display = string.IsNullOrEmpty(NetworkManager.LocalPlayerName) ? "Host" : NetworkManager.LocalPlayerName;
                _identityLabel.color = CoopMenuTheme.LabelOk;
            }
            else if (!inGame)
            {
                display = L.Get("host.identity.noSave");
                _identityLabel.color = CoopMenuTheme.LabelWarn;
            }
            else
            {
                var (fn, sn) = CharacterStore.ReadHostCharacter();
                if (string.IsNullOrEmpty(fn) && string.IsNullOrEmpty(sn))
                {
                    display = L.Get("host.identity.fallback");
                    _identityLabel.color = CoopMenuTheme.LabelWarn;
                }
                else
                {
                    display = string.IsNullOrEmpty(sn) ? fn : $"{fn} {sn}";
                    _identityLabel.color = CoopMenuTheme.LabelOk;
                }
            }
            _identityLabel.text = display;
        }

        if (_statusLabel != null)
        {
            if (hosting)
            {
                int conns = NetworkManager.Players?.Count ?? 0;
                _statusLabel.text = L.Get("host.status.hosting", conns);
                _statusLabel.color = CoopMenuTheme.LabelOk;
            }
            else if (!inGame)
            {
                _statusLabel.text = L.Get("host.status.mainMenu");
                _statusLabel.color = CoopMenuTheme.LabelWarn;
            }
            else
            {
                _statusLabel.text = L.Get("host.status.notHosting");
                _statusLabel.color = CoopMenuTheme.LabelMuted;
            }
        }
    }

    private void OnStartClick()
    {
        try
        {
            if (!WorldReadyGate.IsWorldReady)
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = L.Get("host.warn.noSave");
                    _statusLabel.color = CoopMenuTheme.LabelWarn;
                }
                Plugin.Log.LogWarning("[HostPanel] Start Hosting rejected: load or generate a city first, THEN click Host.");
                return;
            }

            if (NetworkManager.StartHost())
            {
                Plugin.Log.LogInfo($"[CoopMenu] hosting via Steam as \"{NetworkManager.LocalPlayerName}\"");
            }
            else
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = "Failed to start hosting. Check the log.";
                    _statusLabel.color = CoopMenuTheme.LabelError;
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"HostPanel.OnStartClick: {ex}");
        }
        Refresh();
    }

    private void OnStopClick()
    {
        try { NetworkManager.Disconnect(); } catch { }
        Refresh();
    }

    private void OnStartIPClick()
    {
        try
        {
            if (!WorldReadyGate.IsWorldReady)
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = L.Get("host.warn.noSave");
                    _statusLabel.color = CoopMenuTheme.LabelWarn;
                }
                return;
            }
            int port = 7777;
            if (_portField != null && !string.IsNullOrEmpty(_portField.text))
            {
                if (!int.TryParse(_portField.text.Trim(), out port) || port <= 0 || port > 65535) port = 7777;
            }
            if (NetworkManager.StartHostIP(port))
            {
                Plugin.Log.LogInfo($"[CoopMenu] hosting via direct IP on port {port}");
                if (_statusLabel != null)
                {
                    _statusLabel.text = $"Hosting on UDP {port}. Friends connect to your-ip:{port}.";
                    _statusLabel.color = CoopMenuTheme.LabelOk;
                }
            }
            else if (_statusLabel != null)
            {
                _statusLabel.text = $"Failed to bind UDP port {port} (in use?).";
                _statusLabel.color = CoopMenuTheme.LabelError;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"HostPanel.OnStartIPClick: {ex}");
        }
        Refresh();
    }

    private void OnInviteClick()
    {
        try
        {
            if (SteamLobby.OpenInviteDialog())
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = L.Get("host.status.invitedOverlay");
                    _statusLabel.color = CoopMenuTheme.LabelOk;
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"HostPanel.OnInviteClick: {ex.Message}");
        }
    }
}
