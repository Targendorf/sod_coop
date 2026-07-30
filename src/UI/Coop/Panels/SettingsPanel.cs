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

    // Settings now has: 4 overlay toggles + language block + networking
    // section (2 toggles + note) + back. That's ~14 rows — doesn't fit
    // comfortably in the default 520px panel height. Scrollable + a bit
    // taller keeps everything reachable without truncation.
    protected override float PanelHeight => 620f;
    protected override bool  ScrollableBody => true;

    private Button _statusBtn;
    private Button _chatBtn;
    private Button _nameTagsBtn;
    private Button _bannersBtn;
    private Button _worldBootstrapBtn;
    private Button _saveTransferAutoBtn;
    private Button _citizenAnimBtn;

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("settings.tagline"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(12f);

        // ── Overlays section ────────────────────────────────────────────
        SectionHeader("Overlays");

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

        Spacer(14f);

        // ── Language section ────────────────────────────────────────────
        SectionHeader(L.Get("settings.label.language"));
        WrappedBodyLabel(L.Get("settings.lang.note"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(14f);

        // ── Networking section ──────────────────────────────────────────
        // World bootstrap mode + save-transfer auto-accept. Host-side
        // settings; affect how a joining client acquires the host's world.
        SectionHeader(L.Get("settings.section.networking"));

        _worldBootstrapBtn = CoopMenuFactory.MenuButton("ToggleWorldBootstrap", Body,
            BuildWorldBootstrapLabel(),
            () => CycleWorldBootstrap());

        _saveTransferAutoBtn = CoopMenuFactory.MenuButton("ToggleSaveTransferAuto", Body,
            BuildLabel(L.Get("settings.toggle.saveTransferAuto"), CoopSettings.SaveTransferAutoAccept),
            () => Toggle(CoopSettings.SaveTransferAutoAccept, _saveTransferAutoBtn, L.Get("settings.toggle.saveTransferAuto")));

        WrappedBodyLabel(L.Get("settings.note.worldBootstrap"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(14f);

        // ── Performance section ─────────────────────────────────────────
        SectionHeader("Performance");

        _citizenAnimBtn = CoopMenuFactory.MenuButton("ToggleCitizenAnim", Body,
            BuildCitizenAnimLabel(),
            () => CycleCitizenAnim());

        WrappedBodyLabel("NPC animation sync: Disabled = best perf (minor visual lag near NPCs). " +
            "Auto = scan only nearby NPCs (recommended). Fixed Hz = scan all NPCs (smoothest, heaviest).",
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);

        Spacer(20f);

        CoopMenuFactory.MenuButton("Back", Body, L.Get("settings.btn.back"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Main));
    }

    /// <summary>A small amber-tinted section divider with a label. Gives
    /// visual grouping between Overlays / Language / Networking so the
    /// settings panel reads as structured rather than a flat button list.
    /// Replaces the bare <c>BodyLabel</c> section headers that blended into
    /// the surrounding content.</summary>
    private void SectionHeader(string text)
    {
        var go = CoopMenuFactory.Group("Section", Body);
        var rt = go.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, 28f);
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = 28f;
        le.flexibleWidth = 1f;

        // Thin amber underline (top of section).
        var lineGo = new GameObject("Underline");
        lineGo.transform.SetParent(go.transform, false);
        var lineRt = lineGo.AddComponent<RectTransform>();
        lineRt.anchorMin = new(0f, 0f); lineRt.anchorMax = new(1f, 0f);
        lineRt.offsetMin = new(0f, 0f); lineRt.offsetMax = new(0f, 1f);
        var lineImg = lineGo.AddComponent<Image>();
        lineImg.color = new Color(CoopMenuTheme.PanelBorder.r, CoopMenuTheme.PanelBorder.g,
                                  CoopMenuTheme.PanelBorder.b, 0.5f);
        lineImg.raycastTarget = false;

        var t = CoopMenuFactory.Label("Text", go.transform, text,
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelTitle,
            TextAnchor.LowerLeft, FontStyle.Bold);
        var tRt = t.GetComponent<RectTransform>();
        tRt.offsetMin = new(2f, 4f);
        tRt.offsetMax = new(-2f, -2f);
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
        SetButtonLabel(_worldBootstrapBtn,    BuildWorldBootstrapLabel());
        SetButtonLabel(_saveTransferAutoBtn,  BuildLabel(L.Get("settings.toggle.saveTransferAuto"), CoopSettings.SaveTransferAutoAccept));
        SetButtonLabel(_citizenAnimBtn,       BuildCitizenAnimLabel());
    }

    /// <summary>Build the WorldBootstrap button label from the current enum
    /// value. SaveTransfer → "World bootstrap: Save Transfer"; ShareCode →
    /// "World bootstrap: Share Code". The label doubles as the visible
    /// state — no separate checkbox because this is a 2-way enum, not a
    /// bool.</summary>
    private static string BuildWorldBootstrapLabel()
    {
        var mode = CoopSettings.WorldBootstrap?.Value ?? WorldBootstrapMode.SaveTransfer;
        // Reuse the two distinct translation keys so each mode's label is
        // localisable independently.
        return mode == WorldBootstrapMode.ShareCode
            ? "[●]  " + L.Get("settings.toggle.worldBootstrap.sharecode")
            : "[●]  " + L.Get("settings.toggle.worldBootstrap");
    }

    /// <summary>Cycle WorldBootstrap between SaveTransfer and ShareCode.
    /// Two-state cycle (not a true cycle for a 2-value enum, but named
    /// Cycle for symmetry with future expansion if a third mode is added).
    /// Logs the flip for debugging.</summary>
    private void CycleWorldBootstrap()
    {
        if (CoopSettings.WorldBootstrap == null) return;
        var current = CoopSettings.WorldBootstrap.Value;
        var next = current == WorldBootstrapMode.SaveTransfer
            ? WorldBootstrapMode.ShareCode
            : WorldBootstrapMode.SaveTransfer;
        CoopSettings.WorldBootstrap.Value = next;
        Plugin.Log.LogInfo($"[Settings] WorldBootstrap = {next} (was {current})");
        SetButtonLabel(_worldBootstrapBtn, BuildWorldBootstrapLabel());
    }

    /// <summary>Label for the NPC animation sync mode button.</summary>
    private static string BuildCitizenAnimLabel()
    {
        var m = CoopSettings.CitizenAnimSync?.Value ?? CitizenAnimSyncMode.Auto;
        string label = m switch
        {
            CitizenAnimSyncMode.Disabled => "NPC Anim Sync: Off",
            CitizenAnimSyncMode.Auto     => "NPC Anim Sync: Auto (nearby)",
            _                            => $"NPC Anim Sync: {CoopSettings.CitizenAnimSyncHz?.Value ?? 2} Hz (all)",
        };
        return "[●]  " + label;
    }

    /// <summary>Cycle: Off → Auto → 1Hz → 2Hz → 3Hz → 5Hz → Off.</summary>
    private void CycleCitizenAnim()
    {
        if (CoopSettings.CitizenAnimSync == null) return;
        var m = CoopSettings.CitizenAnimSync.Value;
        if (m == CitizenAnimSyncMode.Disabled) { CoopSettings.CitizenAnimSync.Value = CitizenAnimSyncMode.Auto; }
        else if (m == CitizenAnimSyncMode.Auto) { CoopSettings.CitizenAnimSync.Value = CitizenAnimSyncMode.FixedHz; if (CoopSettings.CitizenAnimSyncHz != null) CoopSettings.CitizenAnimSyncHz.Value = 1; }
        else
        {
            int hz = CoopSettings.CitizenAnimSyncHz?.Value ?? 2;
            if (hz < 5) { if (CoopSettings.CitizenAnimSyncHz != null) CoopSettings.CitizenAnimSyncHz.Value = hz + 1; }
            else { CoopSettings.CitizenAnimSync.Value = CitizenAnimSyncMode.Disabled; }
        }
        Plugin.Log.LogInfo($"[Settings] CitizenAnimSync = {CoopSettings.CitizenAnimSync.Value}" + (CoopSettings.CitizenAnimSync.Value == CitizenAnimSyncMode.FixedHz ? $" @ {CoopSettings.CitizenAnimSyncHz?.Value}Hz" : ""));
        SetButtonLabel(_citizenAnimBtn, BuildCitizenAnimLabel());
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
