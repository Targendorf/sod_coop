using SoDCoop.Network;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Join setup. Two ways to fill the connection fields:
///   • Paste a join code → fields auto-fill from the embedded host info.
///   • Manual: type IP + port directly.
/// </summary>
public class JoinPanel : CoopPanelBase
{
    protected override string Title => "Join a session";

    private InputField _codeInput;
    private InputField _ipInput;
    private InputField _portInput;
    private Text       _statusLabel;
    private Text       _gameStateLabel;
    private Button     _connectBtn;

    protected override void BuildBody()
    {
        WrappedBodyLabel("Paste a join code, or enter the host's IP and port manually. " +
                         "If this is your first time on the host's world, you'll be asked to create your character after connecting.",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        _gameStateLabel = WrappedBodyLabel("",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);
        Spacer(4f);

        BodyLabel("Join code (recommended)", CoopMenuTheme.FontSizeSmall,
            CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _codeInput = CoopMenuFactory.TextInput("Code", Body, "",
            "Paste join code here", CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2, 38f);
        AddLayoutHeight(_codeInput.gameObject, 38f);

        // Auto-fill on text change.
        try
        {
            _codeInput.onValueChanged.AddListener((UnityEngine.Events.UnityAction<string>)OnCodeChanged);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"JoinPanel listener wire-up: {ex.Message}");
        }

        Spacer(6f);

        BodyLabel("Or enter manually", CoopMenuTheme.FontSizeSmall,
            CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);

        _ipInput = CoopMenuFactory.TextInput("IP", Body,
            "127.0.0.1", "Host IP", CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        AddLayoutHeight(_ipInput.gameObject, 36f);

        _portInput = CoopMenuFactory.TextInput("Port", Body,
            "9050", "9050", CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        _portInput.contentType = InputField.ContentType.IntegerNumber;
        AddLayoutHeight(_portInput.gameObject, 36f);

        Spacer(8f);

        _connectBtn = CoopMenuFactory.MenuButton("Connect", Body, "🔌  Connect", OnConnectClick);

        _statusLabel = WrappedBodyLabel("",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, "←  Back",
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
    }

    private void OnCodeChanged(string code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            if (_statusLabel != null) _statusLabel.text = "";
            return;
        }
        if (JoinCode.TryDecode(code, out var cityName, out var seed,
                               out var version, out var ip, out var port))
        {
            if (_ipInput != null)   _ipInput.text   = ip;
            if (_portInput != null) _portInput.text = port.ToString();
            if (_statusLabel != null)
            {
                _statusLabel.text = string.IsNullOrEmpty(cityName)
                    ? $"Code OK — {ip}:{port}"
                    : $"Code OK — {ip}:{port} (city: {cityName})";
                _statusLabel.color = CoopMenuTheme.LabelOk;
            }
        }
        else
        {
            if (_statusLabel != null)
            {
                _statusLabel.text = "Code unrecognised — paste manually if needed.";
                _statusLabel.color = CoopMenuTheme.LabelWarn;
            }
        }
    }

    private void OnConnectClick()
    {
        try
        {
            // Hard guard: don't let the user join while their own save is loaded.
            // The client plays AS one of the host's citizens (twin) in the host's
            // world; their local save is irrelevant and a loaded local world
            // would just keep ticking in the background (NPCs walking around,
            // time passing, sound playing) while the lobby waits — confusing
            // state at best, broken sync at worst.
            if (WorldReadyGate.IsWorldReady)
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = "⚠ Return to the main menu first — you can't join while your own save is loaded.";
                    _statusLabel.color = CoopMenuTheme.LabelWarn;
                }
                Plugin.Log.LogWarning("[JoinPanel] Connect rejected: client has a save loaded; must be on main menu.");
                return;
            }

            string ip = _ipInput?.text ?? "127.0.0.1";
            int port = int.TryParse(_portInput?.text ?? "9050", out var p) ? p : 9050;

            if (_statusLabel != null)
            {
                _statusLabel.text = $"Connecting to {ip}:{port}…";
                _statusLabel.color = CoopMenuTheme.LabelWarn;
            }

            // Note: we deliberately do NOT switch to the Lobby panel here.
            // The host may need us to create a character first; the menu
            // controller subscribes to OnCharacterCreationRequired and OnConnected
            // and routes us to the right panel when the host responds.
            if (!NetworkManager.Connect(ip, port) && _statusLabel != null)
            {
                _statusLabel.text = "Connect failed — check IP / port.";
                _statusLabel.color = CoopMenuTheme.LabelError;
            }
            else
            {
                Plugin.Log.LogInfo($"[CoopMenu] connect-attempt to {ip}:{port}");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"JoinPanel.OnConnectClick: {ex}");
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
                _gameStateLabel.text = "⚠ A save is currently loaded. Return to the main menu before joining.";
                _gameStateLabel.color = CoopMenuTheme.LabelWarn;
            }
            else
            {
                _gameStateLabel.text = "✔ On main menu — ready to join.";
                _gameStateLabel.color = CoopMenuTheme.LabelOk;
            }
        }

        if (_connectBtn != null)
            _connectBtn.interactable = !inGame;
    }

    private static void AddLayoutHeight(GameObject go, float height)
    {
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = height;
        le.flexibleWidth = 1f;
    }
}
