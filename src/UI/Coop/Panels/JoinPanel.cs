using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Network.Steam;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Join setup. There is no manual IP/port or join code under Steam — the
/// way you join a session is by accepting a Steam invite or clicking
/// "Join Game" on a friend's profile in the Steam overlay. The panel
/// surfaces a single "Open Steam Friends" button as a shortcut and
/// otherwise just explains the flow.
/// </summary>
public class JoinPanel : CoopPanelBase
{
    protected override string Title => L.Get("join.title");

    // Tagline + state label + instructions + friends button + direct IP
    // section (label + 2 inputs + button) + status + back. Scrollable so
    // the direct-IP inputs don't push Back off-screen.
    protected override float PanelHeight => 660f;
    protected override bool  ScrollableBody => true;

    private Text       _statusLabel;
    private Text       _gameStateLabel;
    private Button     _openFriendsBtn;
    private InputField _ipField;
    private InputField _portField;
    private Button     _connectIpBtn;

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("join.tagline"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        _gameStateLabel = WrappedBodyLabel("",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        WrappedBodyLabel(L.Get("join.instructions"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader);

        Spacer(12f);

        _openFriendsBtn = CoopMenuFactory.MenuButton("Friends", Body, L.Get("join.btn.openFriends"), OnOpenFriendsClick);

        Spacer(12f);

        // ── Direct IP fallback ──────────────────────────────────────────
        BodyLabel("Direct IP (alt.)", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _ipField   = CoopMenuFactory.TextInput("Ip",   Body, "",     "Host IP",   320f);
        _portField = CoopMenuFactory.TextInput("Port", Body, "7777", "Port",      320f);
        _connectIpBtn = CoopMenuFactory.MenuButton("ConnectIP", Body, "Connect to IP", OnConnectIpClick);

        _statusLabel = WrappedBodyLabel("",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, L.Get("join.btn.back"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
    }

    private void OnConnectIpClick()
    {
        try
        {
            // Joining from inside a game is allowed: the host's world is
            // loaded over it (the same in-game load a live re-sync does).
            string ip = _ipField?.text?.Trim() ?? "";
            int port = 7777;
            if (_portField != null && !string.IsNullOrEmpty(_portField.text))
            {
                if (!int.TryParse(_portField.text.Trim(), out port) || port <= 0 || port > 65535) port = 7777;
            }
            if (string.IsNullOrEmpty(ip))
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = "Enter the host's IP address.";
                    _statusLabel.color = CoopMenuTheme.LabelWarn;
                }
                return;
            }
            if (NetworkManager.ConnectIP(ip, port))
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = $"Dialing {ip}:{port}..." +
                        (WorldReadyGate.IsWorldReady ? "\n" + L.Get("join.warn.haveSave") : "");
                    _statusLabel.color = WorldReadyGate.IsWorldReady ? CoopMenuTheme.LabelWarn : CoopMenuTheme.LabelOk;
                }
            }
            else if (_statusLabel != null)
            {
                _statusLabel.text = $"Failed to dial {ip}:{port}.";
                _statusLabel.color = CoopMenuTheme.LabelError;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"JoinPanel.OnConnectIpClick: {ex}");
        }
    }

    private void OnOpenFriendsClick()
    {
        try
        {
            if (SteamLobby.OpenFriendsOverlay() && _statusLabel != null)
            {
                bool inGame = WorldReadyGate.IsWorldReady;
                _statusLabel.text = L.Get("join.status.overlayOpened") + (inGame ? "\n" + L.Get("join.warn.haveSave") : "");
                _statusLabel.color = inGame ? CoopMenuTheme.LabelWarn : CoopMenuTheme.LabelOk;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"JoinPanel.OnOpenFriendsClick: {ex}");
            if (_statusLabel != null)
            {
                _statusLabel.text = $"Error: {ex.Message}";
                _statusLabel.color = CoopMenuTheme.LabelError;
            }
        }
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
        bool inGame = WorldReadyGate.IsWorldReady;

        if (_gameStateLabel != null)
        {
            if (inGame)
            {
                _gameStateLabel.text = L.Get("join.state.haveSave");
                _gameStateLabel.color = CoopMenuTheme.LabelWarn;
            }
            else
            {
                _gameStateLabel.text = L.Get("join.state.menuOk");
                _gameStateLabel.color = CoopMenuTheme.LabelOk;
            }
        }

        if (_openFriendsBtn != null)
            _openFriendsBtn.interactable = true;
    }
}
