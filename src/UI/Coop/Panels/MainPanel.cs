using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Root menu — entry point with Host / Join / Show My IP / Back.
/// Hidden when offline; replaced by lobby flow once connected.
/// </summary>
public class MainPanel : CoopPanelBase
{
    protected override string Title => "Co-op Multiplayer";

    protected override void BuildBody()
    {
        BodyLabel("Connect with a teammate to investigate together.",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(20f);

        CoopMenuFactory.MenuButton("Host",   Body,
            "🛜  Host a session",
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Host));

        CoopMenuFactory.MenuButton("Join",   Body,
            "🔌  Join a session",
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Join));

        CoopMenuFactory.MenuButton("ShowIp", Body,
            "📡  Show my IP",
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.IpInfo));

        Spacer(40f);

        CoopMenuFactory.MenuButton("Close",  Body,
            "✕  Close menu",
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
    }
}
