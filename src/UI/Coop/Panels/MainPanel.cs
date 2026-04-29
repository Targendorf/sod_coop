using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Player;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Root menu — entry point with Host / Join / Show My IP / Reset identity.
/// Hidden when offline; replaced by lobby flow once connected.
/// </summary>
public class MainPanel : CoopPanelBase
{
    // Demo wiring of the localization facade. All visible strings come
    // from L.Get(key); see SoDCoop.Localization.Translations for the
    // canonical key list (En dict). Other panels are still on hard-coded
    // English — they'll migrate incrementally as new keys land.
    protected override string Title => L.Get("main.title");

    /// <summary>Two-step confirmation state for the Reset button.</summary>
    private bool   _resetArmed;
    private Button _resetBtn;
    private Text   _resetStatus;

    private const string RESET_LABEL_NORMAL = "🗑  Reset my coop identity";
    private const string RESET_LABEL_ARMED  = "⚠  Click again to confirm";

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("main.tagline"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(20f);

        CoopMenuFactory.MenuButton("Host",   Body,
            L.Get("main.btn.host"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Host));

        CoopMenuFactory.MenuButton("Join",   Body,
            L.Get("main.btn.join"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Join));

        CoopMenuFactory.MenuButton("ShowIp", Body,
            L.Get("main.btn.showIp"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.IpInfo));

        CoopMenuFactory.MenuButton("Settings", Body,
            L.Get("main.btn.settings"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Settings));

        Spacer(20f);

        // Reset identity. Wipes our local stable clientGuid so on the next
        // join we look like a brand-new player to every host (they'll prompt
        // for a fresh character name and pick a fresh twin). Two-step confirm
        // because it's not undoable.
        _resetBtn    = CoopMenuFactory.MenuButton("Reset", Body,
            RESET_LABEL_NORMAL, OnResetClick);
        _resetStatus = WrappedBodyLabel(
            "Use this to start over with a different name on every world. " +
            "Your existing characters on hosts you've already visited stay " +
            "with their names.",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Close",  Body,
            L.Get("main.btn.close"),
            () => CoopMenuController.Hide());
    }

    private void OnResetClick()
    {
        if (!_resetArmed)
        {
            _resetArmed = true;
            UpdateResetButtonLabel();
            if (_resetStatus != null)
            {
                _resetStatus.text  = "Sure? This wipes your local coop identity. Click the button again to confirm.";
                _resetStatus.color = CoopMenuTheme.LabelWarn;
            }
            return;
        }

        try
        {
            CharacterIdentity.Reset();
            if (_resetStatus != null)
            {
                _resetStatus.text  = "Identity wiped. You'll be prompted for a name on your next join.";
                _resetStatus.color = CoopMenuTheme.LabelOk;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"MainPanel.OnResetClick: {ex}");
            if (_resetStatus != null)
            {
                _resetStatus.text  = $"Error: {ex.Message}";
                _resetStatus.color = CoopMenuTheme.LabelError;
            }
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

    public override void Show()
    {
        // If we're already connected, jump straight to the lobby.
        if (NetworkManager.IsConnected)
        {
            CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Lobby);
            return;
        }
        base.Show();
    }
}
