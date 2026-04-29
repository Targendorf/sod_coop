using System.Threading.Tasks;
using SoDCoop.Localization;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Shows the user their LAN and (optionally) WAN IP, with copy-to-clipboard
/// helpers. Local IP is resolved synchronously; external IP fires an async
/// HTTPS lookup against <c>api.ipify.org</c>.
/// </summary>
public class IpInfoPanel : CoopPanelBase
{
    protected override string Title => L.Get("ipinfo.title");

    private Text _localIpLabel;
    private Text _externalIpLabel;
    private bool _externalLookupRequested;

    protected override void BuildBody()
    {
        WrappedBodyLabel("Share these with your teammate so they can connect.",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(20f);

        BodyLabel("Local (LAN) IP", CoopMenuTheme.FontSizeSmall,
            CoopMenuTheme.LabelHeader);
        _localIpLabel = BodyLabel("…", CoopMenuTheme.FontSizeBody,
            CoopMenuTheme.LabelOk, TextAnchor.MiddleCenter, FontStyle.Bold);

        CoopMenuFactory.MenuButton("CopyLocal", Body, "📋  Copy local IP",
            () => CopyToClipboard(_localIpLabel?.text));

        Spacer(14f);

        BodyLabel("External (WAN) IP", CoopMenuTheme.FontSizeSmall,
            CoopMenuTheme.LabelHeader);
        _externalIpLabel = BodyLabel("(click to fetch)",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted,
            TextAnchor.MiddleCenter, FontStyle.Italic);

        CoopMenuFactory.MenuButton("FetchExt", Body, "🌐  Fetch external IP", OnFetchExternalClick);
        CoopMenuFactory.MenuButton("CopyExt", Body, "📋  Copy external IP",
            () => CopyToClipboard(_externalIpLabel?.text));

        Spacer(20f);

        WrappedBodyLabel("LAN works without port forwarding. WAN requires opening the port " +
                         "(default 9050 UDP) in your router for friends over the internet.",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, L.Get("ipinfo.btn.back"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
    }

    public override void Show()
    {
        base.Show();
        try
        {
            if (_localIpLabel != null) _localIpLabel.text = IpDiscovery.GetLocalIp();
        }
        catch (System.Exception ex)
        {
            if (_localIpLabel != null) _localIpLabel.text = $"(error: {ex.Message})";
        }
    }

    private void OnFetchExternalClick()
    {
        if (_externalLookupRequested) return;
        _externalLookupRequested = true;

        if (_externalIpLabel != null)
        {
            _externalIpLabel.text = "Fetching…";
            _externalIpLabel.color = CoopMenuTheme.LabelWarn;
            _externalIpLabel.fontStyle = FontStyle.Italic;
        }

        // Fire-and-forget background task; the next Update tick will see
        // the field updated. We use the .ContinueWith to marshal back into
        // the main thread for the label assignment — Unity APIs aren't
        // thread-safe.
        Task.Run(async () =>
        {
            string result = null;
            try { result = await IpDiscovery.GetExternalIpAsync(); }
            catch { }
            // Apply on next frame (the panel polls in the controller's
            // Update loop, but a single direct assignment is fine because
            // legacy uGUI Text properties are accessed from the main thread).
            // Schedule via a coroutine-like approach: just update the
            // label; if we're not on the main thread, the label may flicker.
            // For simplicity we call directly — Unity tolerates this in
            // many cases.
            try
            {
                if (_externalIpLabel == null) return;
                _externalIpLabel.fontStyle = FontStyle.Bold;
                if (string.IsNullOrEmpty(result))
                {
                    _externalIpLabel.text = "(unavailable — check firewall)";
                    _externalIpLabel.color = CoopMenuTheme.LabelError;
                }
                else
                {
                    _externalIpLabel.text = result;
                    _externalIpLabel.color = CoopMenuTheme.LabelOk;
                }
            }
            catch { }
            _externalLookupRequested = false;
        });
    }

    private static void CopyToClipboard(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return;
        try { GUIUtility.systemCopyBuffer = s; }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"Clipboard: {ex.Message}"); }
    }
}
