using System;
using SoDCoop.Localization;
using SoDCoop.Player;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Edits a single saved <see cref="ProfileStore.Profile"/>: display name +
/// in-world first/surname, and a button to open
/// <see cref="AppearancePanel"/> in <c>ProfileEdit</c> mode for the
/// appearance.
///
/// <para>Save validates names via <see cref="CharacterStore.ValidateName"/>
/// and writes back to the store. Cancel reverts (the in-flight profile
/// reference is mutated only on Save).</para>
/// </summary>
public class EditProfilePanel : CoopPanelBase
{
    protected override string Title => L.Get("editprofile.title");

    protected override float PanelHeight   => 700f;
    protected override bool  ScrollableBody => true;

    private ProfileStore.Profile _editing;

    private InputField _displayInput;
    private InputField _firstInput;
    private InputField _surInput;
    private Text       _statusLabel;
    private Text       _appearanceSummary;

    private string _scratchDisplay;
    private string _scratchFirst;
    private string _scratchSur;
    private AppearanceConfig _scratchAppearance;

    public void Configure(ProfileStore.Profile profile)
    {
        _editing = profile;
        _scratchDisplay = profile?.DisplayName ?? "";
        _scratchFirst   = profile?.FirstName   ?? "";
        _scratchSur     = profile?.Surname     ?? "";
        _scratchAppearance = profile?.Appearance ?? AppearanceConfig.Default;

        if (_displayInput != null) _displayInput.text = _scratchDisplay;
        if (_firstInput   != null) _firstInput  .text = _scratchFirst;
        if (_surInput     != null) _surInput    .text = _scratchSur;
        RefreshAppearanceSummary();
        ClearStatus();
    }

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("editprofile.subtitle"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted, TextAnchor.MiddleCenter, FontStyle.Italic);
        Spacer(8f);

        BodyLabel(L.Get("editprofile.label.display"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _displayInput = CoopMenuFactory.TextInput("DisplayInput", Body,
            "", L.Get("editprofile.placeholder.display"),
            CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        AddLayoutHeight(_displayInput.gameObject, 32f);

        BodyLabel(L.Get("editprofile.label.first"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _firstInput = CoopMenuFactory.TextInput("FirstInput", Body,
            "", L.Get("editprofile.placeholder.first"),
            CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        AddLayoutHeight(_firstInput.gameObject, 32f);

        BodyLabel(L.Get("editprofile.label.sur"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        _surInput = CoopMenuFactory.TextInput("SurInput", Body,
            "", L.Get("editprofile.placeholder.sur"),
            CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2);
        AddLayoutHeight(_surInput.gameObject, 32f);

        Spacer(10f);

        _appearanceSummary = WrappedBodyLabel(
            L.Get("editprofile.appearance.default"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        CoopMenuFactory.MenuButton("EditAppearance", Body,
            L.Get("editprofile.btn.appearance"),
            OnEditAppearance);

        Spacer(10f);

        var row = MakeRow();
        AddRowButton(row, L.Get("editprofile.btn.cancel"), OnCancel);
        AddRowButton(row, L.Get("editprofile.btn.save"),   OnSave);

        _statusLabel = WrappedBodyLabel("", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);
    }

    public override void Show()
    {
        base.Show();
        if (_displayInput != null) _displayInput.text = _scratchDisplay ?? "";
        if (_firstInput   != null) _firstInput  .text = _scratchFirst   ?? "";
        if (_surInput     != null) _surInput    .text = _scratchSur     ?? "";
        RefreshAppearanceSummary();
    }

    private void RefreshAppearanceSummary()
    {
        if (_appearanceSummary == null) return;
        _appearanceSummary.text = _scratchAppearance.IsCustomized
            ? L.Get("editprofile.appearance.customized")
            : L.Get("editprofile.appearance.default");
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Actions
    // ─────────────────────────────────────────────────────────────────────

    private void OnEditAppearance()
    {
        // Snapshot current name fields into scratch before navigating away
        // so the user doesn't lose typing when they round-trip.
        SyncScratchFromInputs();

        CoopMenuController.OpenAppearanceForProfileEdit(_scratchAppearance,
            onConfirm: cfg =>
            {
                _scratchAppearance = cfg;
                CoopMenuController.ShowPanel(CoopMenuController.PanelKind.EditProfile);
            },
            onCancel: () =>
            {
                CoopMenuController.ShowPanel(CoopMenuController.PanelKind.EditProfile);
            });
    }

    private void OnSave()
    {
        try
        {
            SyncScratchFromInputs();

            string firstErr = string.IsNullOrWhiteSpace(_scratchFirst) ? null : CharacterStore.ValidateName(_scratchFirst);
            string surErr   = string.IsNullOrWhiteSpace(_scratchSur)   ? null : CharacterStore.ValidateName(_scratchSur);
            string err = firstErr ?? surErr;
            if (err != null)
            {
                SetStatus(err, CoopMenuTheme.LabelError);
                return;
            }

            if (_editing == null)
            {
                SetStatus("No profile loaded.", CoopMenuTheme.LabelError);
                return;
            }

            _editing.DisplayName = string.IsNullOrWhiteSpace(_scratchDisplay)
                ? (string.IsNullOrWhiteSpace(_scratchFirst) ? L.Get("profiles.unnamed") : _scratchFirst.Trim())
                : _scratchDisplay.Trim();
            _editing.FirstName  = (_scratchFirst ?? "").Trim();
            _editing.Surname    = (_scratchSur   ?? "").Trim();
            _editing.Appearance = _scratchAppearance;
            ProfileStore.Save(_editing);

            SetStatus(L.Get("editprofile.status.saved"), CoopMenuTheme.LabelOk);
            CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Profiles);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"EditProfilePanel.OnSave: {ex}");
            SetStatus($"Error: {ex.Message}", CoopMenuTheme.LabelError);
        }
    }

    private void OnCancel()
    {
        CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Profiles);
    }

    private void SyncScratchFromInputs()
    {
        if (_displayInput != null) _scratchDisplay = _displayInput.text;
        if (_firstInput   != null) _scratchFirst   = _firstInput  .text;
        if (_surInput     != null) _scratchSur     = _surInput    .text;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Helpers
    // ─────────────────────────────────────────────────────────────────────

    private GameObject MakeRow()
    {
        var row = CoopMenuFactory.Group("ButtonRow", Body);
        var rt = row.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, CoopMenuTheme.ButtonHeight);
        var le = row.AddComponent<LayoutElement>();
        le.preferredHeight = CoopMenuTheme.ButtonHeight;
        le.flexibleWidth = 1f;
        var hl = row.AddComponent<HorizontalLayoutGroup>();
        hl.childAlignment = TextAnchor.MiddleCenter;
        hl.childControlHeight = true;
        hl.childControlWidth = true;
        hl.childForceExpandHeight = true;
        hl.childForceExpandWidth = true;
        hl.spacing = 8f;
        return row;
    }

    private void AddRowButton(GameObject row, string label, Action onClick)
    {
        var btn = CoopMenuFactory.MenuButton(label, row.transform, label, onClick);
        var le = btn.gameObject.AddComponent<LayoutElement>();
        le.flexibleWidth = 1f;
        le.preferredHeight = CoopMenuTheme.ButtonHeight;
    }

    private static void AddLayoutHeight(GameObject go, float height)
    {
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = height;
        le.flexibleWidth = 1f;
    }

    private void SetStatus(string s, Color c)
    {
        if (_statusLabel == null) return;
        _statusLabel.text = s;
        _statusLabel.color = c;
    }

    private void ClearStatus()
    {
        if (_statusLabel == null) return;
        _statusLabel.text = "";
    }
}
