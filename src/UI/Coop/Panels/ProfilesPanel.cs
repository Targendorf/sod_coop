using System;
using SoDCoop.Localization;
using SoDCoop.Player;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Lists every saved co-op profile and lets the user pick which one to
/// connect with, plus Create / Edit / Delete. Each row shows the profile's
/// display name + in-world name, with a star next to the active one.
///
/// <para><b>UX:</b> selecting a profile sets it active and pops back to
/// the main panel — the user then clicks Host / Join with that identity
/// pre-loaded. Editing opens <see cref="EditProfilePanel"/>; deleting is
/// two-step armed (because dropping a profile orphans its host-side
/// records on every server it ever visited).</para>
/// </summary>
public class ProfilesPanel : CoopPanelBase
{
    protected override string Title => L.Get("profiles.title");

    protected override float PanelHeight   => 640f;
    protected override bool  ScrollableBody => true;

    private GameObject _listContainer;
    private Text       _statusLabel;
    private int        _armedDeleteId = -1;

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("profiles.subtitle"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted, TextAnchor.MiddleCenter, FontStyle.Italic);
        Spacer(8f);

        _listContainer = CoopMenuFactory.Group("ProfileList", Body);
        var listRt = _listContainer.GetComponent<RectTransform>();
        listRt.sizeDelta = new(0, 280f);
        var listLe = _listContainer.AddComponent<LayoutElement>();
        listLe.preferredHeight = 280f;
        listLe.flexibleWidth = 1f;
        var listVl = _listContainer.AddComponent<VerticalLayoutGroup>();
        listVl.childAlignment = TextAnchor.UpperCenter;
        listVl.childControlHeight = false;
        listVl.childControlWidth = true;
        listVl.childForceExpandHeight = false;
        listVl.childForceExpandWidth = true;
        listVl.spacing = 4f;
        _listContainer.AddComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        Spacer(8f);

        CoopMenuFactory.MenuButton("CreateNew", Body,
            L.Get("profiles.btn.create"),
            OnCreateNew);

        _statusLabel = WrappedBodyLabel("", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(6f);

        CoopMenuFactory.MenuButton("Back", Body,
            L.Get("profiles.btn.back"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
    }

    public override void Show()
    {
        base.Show();
        _armedDeleteId = -1;
        ClearStatus();
        Rebuild();
    }

    private void Rebuild()
    {
        if (_listContainer == null) return;

        // Wipe existing rows.
        for (int i = _listContainer.transform.childCount - 1; i >= 0; i--)
            UnityEngine.Object.Destroy(_listContainer.transform.GetChild(i).gameObject);

        var all = ProfileStore.All;
        var active = ProfileStore.Active;

        if (all.Count == 0)
        {
            var empty = CoopMenuFactory.Label("Empty", _listContainer.transform,
                L.Get("profiles.empty"),
                CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted,
                TextAnchor.MiddleCenter, FontStyle.Italic);
            var le = empty.gameObject.AddComponent<LayoutElement>();
            le.preferredHeight = 60f;
            return;
        }

        for (int i = 0; i < all.Count; i++)
        {
            var p = all[i];
            BuildRow(p, isActive: active != null && p.Id == active.Id);
        }
    }

    private void BuildRow(ProfileStore.Profile profile, bool isActive)
    {
        var row = CoopMenuFactory.Group($"Profile_{profile.Id}", _listContainer.transform);
        var rt = row.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, 44f);
        var le = row.AddComponent<LayoutElement>();
        le.preferredHeight = 44f;
        le.flexibleWidth = 1f;

        var bg = row.AddComponent<Image>();
        bg.color = isActive
            ? new Color(0.16f, 0.20f, 0.26f, 0.9f)
            : new Color(0.10f, 0.12f, 0.16f, 0.85f);
        bg.raycastTarget = false;

        var hl = row.AddComponent<HorizontalLayoutGroup>();
        hl.childAlignment = TextAnchor.MiddleLeft;
        hl.childControlHeight = true;
        hl.childControlWidth = false;
        hl.childForceExpandHeight = true;
        hl.childForceExpandWidth = false;
        hl.spacing = 6f;
        hl.padding = new RectOffset(10, 10, 4, 4);

        // Active indicator + name label
        string prefix = isActive ? "★ " : "    ";
        string display = string.IsNullOrEmpty(profile.DisplayName) ? L.Get("profiles.unnamed") : profile.DisplayName;
        string subtitle = profile.HasName ? profile.FullName : L.Get("profiles.noNameYet");

        var nameGo = new GameObject("Name");
        nameGo.transform.SetParent(row.transform, false);
        var nameRt = nameGo.AddComponent<RectTransform>();
        var nameLe = nameGo.AddComponent<LayoutElement>();
        nameLe.flexibleWidth = 1f;
        nameLe.minWidth = 200f;
        var nameText = nameGo.AddComponent<Text>();
        nameText.font = CoopMenuTheme.GetFont();
        nameText.fontSize = CoopMenuTheme.FontSizeBody;
        nameText.color = isActive ? CoopMenuTheme.LabelTitle : CoopMenuTheme.LabelHeader;
        nameText.alignment = TextAnchor.MiddleLeft;
        nameText.text = $"{prefix}{display}\n  <i>{subtitle}</i>";
        nameText.supportRichText = true;
        nameText.horizontalOverflow = HorizontalWrapMode.Overflow;
        nameText.verticalOverflow = VerticalWrapMode.Overflow;
        nameText.raycastTarget = false;

        // Action buttons
        AddMiniButton(row.transform, L.Get("profiles.btn.use"),    () => OnUse(profile.Id));
        AddMiniButton(row.transform, L.Get("profiles.btn.edit"),   () => OnEdit(profile.Id));
        bool armedNow = _armedDeleteId == profile.Id;
        AddMiniButton(row.transform,
            armedNow ? L.Get("profiles.btn.deleteArmed") : L.Get("profiles.btn.delete"),
            () => OnDelete(profile.Id),
            armedNow ? CoopMenuTheme.LabelError : (Color?)null);
    }

    private Button AddMiniButton(Transform parent, string label, Action onClick, Color? labelTint = null)
    {
        var btn = CoopMenuFactory.MenuButton(label, parent, label, onClick, widthOverride: 78f);
        var le = btn.gameObject.AddComponent<LayoutElement>();
        le.preferredWidth = 78f;
        le.minWidth = 78f;
        le.preferredHeight = 32f;
        le.minHeight = 32f;
        var rt = btn.GetComponent<RectTransform>();
        rt.sizeDelta = new(78f, 32f);
        if (labelTint.HasValue)
        {
            var t = btn.GetComponentInChildren<Text>();
            if (t != null) t.color = labelTint.Value;
        }
        return btn;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Actions
    // ─────────────────────────────────────────────────────────────────────

    private void OnUse(int profileId)
    {
        try
        {
            ProfileStore.SetActive(profileId);
            SetStatus(L.Get("profiles.status.activated"), CoopMenuTheme.LabelOk);
            Rebuild();
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"ProfilesPanel.OnUse: {ex}");
            SetStatus($"Error: {ex.Message}", CoopMenuTheme.LabelError);
        }
    }

    private void OnEdit(int profileId)
    {
        var p = ProfileStore.GetById(profileId);
        if (p == null) return;
        CoopMenuController.OpenProfileEdit(p);
    }

    private void OnCreateNew()
    {
        var fresh = ProfileStore.Create("", "", "", AppearanceConfig.Default);
        CoopMenuController.OpenProfileEdit(fresh);
    }

    private void OnDelete(int profileId)
    {
        if (_armedDeleteId != profileId)
        {
            _armedDeleteId = profileId;
            SetStatus(L.Get("profiles.status.deleteConfirm"), CoopMenuTheme.LabelWarn);
            Rebuild();
            return;
        }
        _armedDeleteId = -1;
        ProfileStore.Delete(profileId);
        SetStatus(L.Get("profiles.status.deleted"), CoopMenuTheme.LabelMuted);
        Rebuild();
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
