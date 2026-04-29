using BepInEx.Configuration;
using SoDCoop.Localization;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Persistent overlay-visibility toggles (top-right HUD, chat, nametags,
/// banners). All values live in <see cref="CoopSettings"/> which is backed
/// by BepInEx's <see cref="ConfigFile"/> — flips made here survive game
/// restarts.
///
/// UI is intentionally minimal: one row per toggle, the row's button-label
/// flips between [✓] and [ ] on click. Avoids Unity's <c>Toggle</c>
/// component (slightly fiddly to style consistently across IL2CPP) by
/// reusing the same <c>MenuButton</c> visuals as the rest of the menu.
/// </summary>
public class SettingsPanel : CoopPanelBase
{
    protected override string Title => L.Get("settings.title");

    private Button _statusBtn;
    private Button _chatBtn;
    private Button _nameTagsBtn;
    private Button _bannersBtn;

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("settings.tagline"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(12f);

        string lblStatus  = L.Get("settings.toggle.statusHud");
        string lblChat    = L.Get("settings.toggle.chat");
        string lblNames   = L.Get("settings.toggle.nameTags");
        string lblBanners = L.Get("settings.toggle.banners");

        _statusBtn = CoopMenuFactory.MenuButton("ToggleStatus", Body,
            BuildLabel(lblStatus, CoopSettings.ShowStatusHUD),
            () => Toggle(CoopSettings.ShowStatusHUD, _statusBtn, lblStatus));

        _chatBtn = CoopMenuFactory.MenuButton("ToggleChat", Body,
            BuildLabel(lblChat, CoopSettings.ShowChatWindow),
            () => Toggle(CoopSettings.ShowChatWindow, _chatBtn, lblChat));

        _nameTagsBtn = CoopMenuFactory.MenuButton("ToggleNameTags", Body,
            BuildLabel(lblNames, CoopSettings.ShowNameTags),
            () => Toggle(CoopSettings.ShowNameTags, _nameTagsBtn, lblNames));

        _bannersBtn = CoopMenuFactory.MenuButton("ToggleBanners", Body,
            BuildLabel(lblBanners, CoopSettings.ShowOverlayBanners),
            () => Toggle(CoopSettings.ShowOverlayBanners, _bannersBtn, lblBanners));

        Spacer(8f);

        BodyLabel(L.Get("settings.label.language"), CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelHeader, TextAnchor.MiddleLeft);
        WrappedBodyLabel(L.Get("settings.lang.note"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, L.Get("settings.btn.back"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
    }

    public override void Show()
    {
        base.Show();
        // Re-read in case file was edited externally (or first-run defaults applied
        // after another panel was shown first).
        RefreshAll();
    }

    private void RefreshAll()
    {
        SetButtonLabel(_statusBtn,   BuildLabel(L.Get("settings.toggle.statusHud"), CoopSettings.ShowStatusHUD));
        SetButtonLabel(_chatBtn,     BuildLabel(L.Get("settings.toggle.chat"),      CoopSettings.ShowChatWindow));
        SetButtonLabel(_nameTagsBtn, BuildLabel(L.Get("settings.toggle.nameTags"),  CoopSettings.ShowNameTags));
        SetButtonLabel(_bannersBtn,  BuildLabel(L.Get("settings.toggle.banners"),   CoopSettings.ShowOverlayBanners));
    }

    private static void Toggle(ConfigEntry<bool> entry, Button btn, string baseLabel)
    {
        if (entry == null) return;
        entry.Value = !entry.Value;
        // BepInEx writes back to disk on shutdown; force-flush isn't necessary
        // for persistence but useful to log the new state for debugging.
        Plugin.Log.LogInfo($"[Settings] {entry.Definition.Key} = {entry.Value}");
        SetButtonLabel(btn, BuildLabel(baseLabel, entry));
    }

    private static string BuildLabel(string text, ConfigEntry<bool> entry)
    {
        bool on = entry?.Value ?? true;
        return (on ? "[✓]  " : "[ ]  ") + text;
    }

    private static void SetButtonLabel(Button btn, string text)
    {
        if (btn == null) return;
        var lbl = btn.GetComponentInChildren<Text>();
        if (lbl != null) lbl.text = text;
    }
}
