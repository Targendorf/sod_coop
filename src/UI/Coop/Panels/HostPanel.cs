using SoDCoop.Network;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Host setup: nickname + port, Start Hosting, then displays the join code
/// for friends to paste. Polls connection status while live so users see
/// "Hosting on port X — share this code".
/// </summary>
public class HostPanel : CoopPanelBase
{
    protected override string Title => "Host a session";

    private InputField _portInput;
    private Text       _identityLabel;
    private Text       _statusLabel;
    private Text       _joinCodeLabel;
    private Button     _startBtn;
    private Button     _stopBtn;
    private Button     _copyBtn;

    protected override void BuildBody()
    {
        BodyLabel("You'll host as your existing in-game character. Your name is read from the loaded save — make sure you're in-game before starting.",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        BodyLabel("Playing as", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _identityLabel = BodyLabel("(reading from game…)",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelOk, TextAnchor.MiddleLeft, FontStyle.Bold);

        Spacer(6f);

        BodyLabel("Port", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _portInput = CoopMenuFactory.TextInput("PortInput", Body, "9050", "9050",
            CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        _portInput.contentType = InputField.ContentType.IntegerNumber;
        AddLayoutHeight(_portInput.gameObject, 36f);

        Spacer(8f);

        _startBtn = CoopMenuFactory.MenuButton("Start", Body, "▶  Start Hosting", OnStartClick);
        _stopBtn  = CoopMenuFactory.MenuButton("Stop",  Body, "■  Stop Hosting",  OnStopClick);
        _stopBtn.gameObject.SetActive(false);

        Spacer(8f);

        _statusLabel = BodyLabel("Status: not hosting",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        BodyLabel("Join Code (paste this to your friend)",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader);

        _joinCodeLabel = BodyLabel("(start hosting to generate)",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelOk);
        _joinCodeLabel.fontStyle = FontStyle.Italic;

        _copyBtn = CoopMenuFactory.MenuButton("Copy", Body, "📋  Copy code to clipboard", OnCopyClick);
        _copyBtn.gameObject.SetActive(false);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, "←  Back",
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

        if (_startBtn != null) _startBtn.gameObject.SetActive(!hosting);
        if (_stopBtn  != null) _stopBtn .gameObject.SetActive(hosting);
        if (_copyBtn  != null) _copyBtn .gameObject.SetActive(hosting);

        // Identity preview: read live from Game.Instance pre-host (so user sees
        // the name they'll be hosting as), then mirror what's in NetworkManager
        // once hosting is live (in case it differed for any reason).
        if (_identityLabel != null)
        {
            string display;
            if (hosting)
            {
                display = string.IsNullOrEmpty(NetworkManager.LocalPlayerName) ? "Host" : NetworkManager.LocalPlayerName;
                _identityLabel.color = CoopMenuTheme.LabelOk;
            }
            else
            {
                var (fn, sn) = SoDCoop.Sync.CharacterStore.ReadHostCharacter();
                if (string.IsNullOrEmpty(fn) && string.IsNullOrEmpty(sn))
                {
                    display = "(no save loaded — will host as 'Host')";
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
                _statusLabel.text = $"Status: hosting — {conns} peer(s) connected";
                _statusLabel.color = CoopMenuTheme.LabelOk;
            }
            else
            {
                _statusLabel.text = "Status: not hosting";
                _statusLabel.color = CoopMenuTheme.LabelMuted;
            }
        }

        if (_joinCodeLabel != null)
        {
            if (hosting)
            {
                _joinCodeLabel.text = BuildJoinCode();
                _joinCodeLabel.color = CoopMenuTheme.LabelOk;
                _joinCodeLabel.fontStyle = FontStyle.Bold;
            }
            else
            {
                _joinCodeLabel.text = "(start hosting to generate)";
                _joinCodeLabel.color = CoopMenuTheme.LabelMuted;
                _joinCodeLabel.fontStyle = FontStyle.Italic;
            }
        }
    }

    private string BuildJoinCode()
    {
        try
        {
            var ip   = IpDiscovery.GetLocalIp();
            var port = int.TryParse(_portInput?.text ?? "9050", out var p) ? p : 9050;
            string cityName = "";
            try { cityName = CityData.Instance?.cityName ?? ""; } catch { }
            return JoinCode.Encode(cityName, "", "0.1", ip, port);
        }
        catch { return ""; }
    }

    private void OnStartClick()
    {
        try
        {
            int port = int.TryParse(_portInput?.text ?? "9050", out var p) ? p : 9050;
            if (NetworkManager.StartHost(port))
            {
                Plugin.Log.LogInfo($"[CoopMenu] hosting on port {port} as \"{NetworkManager.LocalPlayerName}\"");
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
        try { NetworkManager.Shutdown(); } catch { }
        Refresh();
    }

    private void OnCopyClick()
    {
        try
        {
            var code = _joinCodeLabel?.text ?? "";
            if (!string.IsNullOrEmpty(code)) GUIUtility.systemCopyBuffer = code;
            if (_statusLabel != null)
            {
                _statusLabel.text = "Status: code copied!";
                _statusLabel.color = CoopMenuTheme.LabelOk;
            }
        }
        catch { }
    }

    private static void AddLayoutHeight(GameObject go, float height)
    {
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = height;
        le.flexibleWidth = 1f;
    }
}
