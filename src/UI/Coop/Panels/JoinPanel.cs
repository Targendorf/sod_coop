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

    private Text   _statusLabel;
    private Text   _gameStateLabel;
    private Button _openFriendsBtn;

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

        _statusLabel = WrappedBodyLabel("",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, L.Get("join.btn.back"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
    }

    private void OnOpenFriendsClick()
    {
        try
        {
            if (WorldReadyGate.IsWorldReady)
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = L.Get("join.warn.haveSave");
                    _statusLabel.color = CoopMenuTheme.LabelWarn;
                }
                Plugin.Log.LogWarning("[JoinPanel] Open Friends rejected: client has a save loaded; must be on main menu.");
                return;
            }

            if (SteamLobby.OpenFriendsOverlay() && _statusLabel != null)
            {
                _statusLabel.text = L.Get("join.status.overlayOpened");
                _statusLabel.color = CoopMenuTheme.LabelOk;
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
            _openFriendsBtn.interactable = !inGame;
    }
}
