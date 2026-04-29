using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// First-time-on-this-world character creation. Shown when the host has no
/// stored record for our (worldSeed, clientGuid) pair — the host sends
/// <see cref="PacketType.CharacterCreationRequired"/> with its own name and
/// city name, we display "Welcome to &lt;city&gt;! You're joining
/// &lt;hostName&gt;. Pick your character name." and on submit we send back
/// <see cref="PacketType.CharacterSubmit"/> with first / surname.
///
/// Validation is local (non-empty, no forbidden chars) plus server-side in
/// <see cref="CharacterStore.ValidateName"/>; if the host rejects, it
/// re-emits CharacterCreationRequired and we get re-shown.
/// </summary>
public class CreateCharacterPanel : CoopPanelBase
{
    protected override string Title => L.Get("create.title");

    private Text       _contextLabel;
    private InputField _firstInput;
    private InputField _surInput;
    private Text       _statusLabel;
    private Button     _submitBtn;

    private string _hostFirst = "";
    private string _hostSur   = "";
    private string _cityName  = "";

    /// <summary>Called by CoopMenuController when the host requests creation.</summary>
    public void Configure(string hostFirstName, string hostSurname, string cityName)
    {
        _hostFirst = hostFirstName ?? "";
        _hostSur   = hostSurname ?? "";
        _cityName  = cityName ?? "";
        RefreshContext();
        ClearStatus();
    }

    /// <summary>
    /// Called by <see cref="CoopMenuController"/> when the host sends back a
    /// CharacterRejected packet. Surfaces the reason in red and re-arms the
    /// Submit button (panel stays open).
    /// </summary>
    public void ShowRejection(string reason)
    {
        if (_statusLabel == null) return;
        _statusLabel.text  = string.IsNullOrEmpty(reason)
            ? L.Get("create.reject.generic")
            : L.Get("create.reject.with", reason);
        _statusLabel.color = CoopMenuTheme.LabelError;
    }

    protected override void BuildBody()
    {
        _contextLabel = WrappedBodyLabel("…", CoopMenuTheme.FontSizeBody,
            CoopMenuTheme.LabelMuted, TextAnchor.MiddleCenter, FontStyle.Italic);
        Spacer(10f);

        BodyLabel(L.Get("create.label.first"), CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _firstInput = CoopMenuFactory.TextInput("FirstNameInput", Body,
            "", L.Get("create.placeholder.first"), CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        AddLayoutHeight(_firstInput.gameObject, 36f);

        BodyLabel(L.Get("create.label.surname"), CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _surInput = CoopMenuFactory.TextInput("SurnameInput", Body,
            "", L.Get("create.placeholder.sur"), CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        AddLayoutHeight(_surInput.gameObject, 36f);

        Spacer(8f);

        _submitBtn = CoopMenuFactory.MenuButton("Submit", Body,
            L.Get("create.btn.submit"), OnSubmitClick);

        _statusLabel = WrappedBodyLabel("", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Cancel", Body, L.Get("create.btn.cancel"), OnCancelClick);
    }

    private void RefreshContext()
    {
        if (_contextLabel == null) return;
        string host = string.IsNullOrEmpty(_hostSur) ? _hostFirst : $"{_hostFirst} {_hostSur}";
        if (string.IsNullOrEmpty(host)) host = "—";
        string city = string.IsNullOrEmpty(_cityName) ? "—" : _cityName;

        _contextLabel.text = L.Get("create.context", city, host);
        _contextLabel.color = CoopMenuTheme.LabelMuted;
    }

    private void ClearStatus()
    {
        if (_statusLabel == null) return;
        _statusLabel.text = "";
    }

    private void OnSubmitClick()
    {
        try
        {
            string first = (_firstInput?.text ?? "").Trim();
            string sur   = (_surInput?.text ?? "").Trim();

            string err = CharacterStore.ValidateName(first) ?? CharacterStore.ValidateName(sur);
            if (err != null)
            {
                if (_statusLabel != null)
                {
                    _statusLabel.text = err;
                    _statusLabel.color = CoopMenuTheme.LabelError;
                }
                return;
            }

            if (_statusLabel != null)
            {
                _statusLabel.text = L.Get("create.status.submitting", first, sur);
                _statusLabel.color = CoopMenuTheme.LabelWarn;
            }

            NetworkManager.SubmitCharacter(first, sur);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"CreateCharacterPanel.OnSubmitClick: {ex}");
            if (_statusLabel != null)
            {
                _statusLabel.text = $"Error: {ex.Message}";
                _statusLabel.color = CoopMenuTheme.LabelError;
            }
        }
    }

    private void OnCancelClick()
    {
        try { NetworkManager.Disconnect(); } catch { }
        CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main);
    }

    private static void AddLayoutHeight(GameObject go, float height)
    {
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = height;
        le.flexibleWidth = 1f;
    }
}
