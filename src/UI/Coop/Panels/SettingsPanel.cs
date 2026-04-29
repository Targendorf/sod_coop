using BepInEx.Configuration;
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
    protected override string Title => "Settings";

    private Button _statusBtn;
    private Button _chatBtn;
    private Button _nameTagsBtn;
    private Button _bannersBtn;

    protected override void BuildBody()
    {
        WrappedBodyLabel("Show or hide each in-world overlay. Settings persist across game restarts.",
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(12f);

        _statusBtn = CoopMenuFactory.MenuButton("ToggleStatus", Body,
            BuildLabel("Top-right player list (vitals)", CoopSettings.ShowStatusHUD),
            () => Toggle(CoopSettings.ShowStatusHUD, _statusBtn, "Top-right player list (vitals)"));

        _chatBtn = CoopMenuFactory.MenuButton("ToggleChat", Body,
            BuildLabel("Chat window (bottom-left)", CoopSettings.ShowChatWindow),
            () => Toggle(CoopSettings.ShowChatWindow, _chatBtn, "Chat window (bottom-left)"));

        _nameTagsBtn = CoopMenuFactory.MenuButton("ToggleNameTags", Body,
            BuildLabel("Nametags above other players", CoopSettings.ShowNameTags),
            () => Toggle(CoopSettings.ShowNameTags, _nameTagsBtn, "Nametags above other players"));

        _bannersBtn = CoopMenuFactory.MenuButton("ToggleBanners", Body,
            BuildLabel("Sleep / phone / status banners", CoopSettings.ShowOverlayBanners),
            () => Toggle(CoopSettings.ShowOverlayBanners, _bannersBtn, "Sleep / phone / status banners"));

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, "←  Back",
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
        SetButtonLabel(_statusBtn,   BuildLabel("Top-right player list (vitals)",  CoopSettings.ShowStatusHUD));
        SetButtonLabel(_chatBtn,     BuildLabel("Chat window (bottom-left)",       CoopSettings.ShowChatWindow));
        SetButtonLabel(_nameTagsBtn, BuildLabel("Nametags above other players",    CoopSettings.ShowNameTags));
        SetButtonLabel(_bannersBtn,  BuildLabel("Sleep / phone / status banners", CoopSettings.ShowOverlayBanners));
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
