using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Player;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Root menu — entry point with active profile selector + Host / Join /
/// Show My IP / Settings.
///
/// <para>The active-profile chip lives at the top: it shows whoever was
/// last picked in the <see cref="ProfilesPanel"/>, and clicking
/// <c>Manage profiles</c> opens that panel. The Host / Join buttons use
/// the active profile's <c>ClientGuid</c> + name + appearance for the
/// connection — so switching profiles is the way to "play as someone
/// else" with a separate twin / case-board on the same server.</para>
/// </summary>
public class MainPanel : CoopPanelBase
{
    protected override string Title => L.Get("main.title");

    private Text _activeProfileLabel;

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("main.tagline"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(12f);

        // Active profile chip.
        _activeProfileLabel = WrappedBodyLabel("", CoopMenuTheme.FontSizeBody,
            CoopMenuTheme.LabelHeader, TextAnchor.MiddleCenter, FontStyle.Bold);
        CoopMenuFactory.MenuButton("Profiles", Body,
            L.Get("main.btn.profiles"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Profiles));

        Spacer(16f);

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

        CoopMenuFactory.MenuButton("Close",  Body,
            L.Get("main.btn.close"),
            () => CoopMenuController.Hide());
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
        RefreshActiveProfile();
    }

    private void RefreshActiveProfile()
    {
        if (_activeProfileLabel == null) return;
        try
        {
            var p = ProfileStore.Active;
            if (p == null)
            {
                _activeProfileLabel.text  = L.Get("main.profile.none");
                _activeProfileLabel.color = CoopMenuTheme.LabelWarn;
                return;
            }

            string display = string.IsNullOrEmpty(p.DisplayName) ? L.Get("profiles.unnamed") : p.DisplayName;
            string subtitle = p.HasName ? p.FullName : L.Get("profiles.noNameYet");
            _activeProfileLabel.text  = L.Get("main.profile.active", display, subtitle);
            _activeProfileLabel.color = CoopMenuTheme.LabelTitle;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"MainPanel.RefreshActiveProfile: {ex.Message}");
        }
    }
}
