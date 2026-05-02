using System;
using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Player;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Root menu — entry point with active profile selector, recent-sessions
/// quick-rejoin via the Steam overlay, and Host / Join / Settings.
/// </summary>
public class MainPanel : CoopPanelBase
{
    protected override string Title => L.Get("main.title");

    // Bump height + scrollable body so the recent-sessions block + any
    // future affordances don't push lower buttons off-screen on small
    // viewports.
    protected override float PanelHeight   => 720f;
    protected override bool  ScrollableBody => true;

    private Text       _activeProfileLabel;
    private GameObject _sessionsContainer;
    private Text       _sessionsHeader;

    protected override void BuildBody()
    {
        WrappedBodyLabel(L.Get("main.tagline"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelMuted);
        Spacer(8f);

        // Active profile chip.
        _activeProfileLabel = WrappedBodyLabel("", CoopMenuTheme.FontSizeBody,
            CoopMenuTheme.LabelHeader, TextAnchor.MiddleCenter, FontStyle.Bold);
        CoopMenuFactory.MenuButton("Profiles", Body,
            L.Get("main.btn.profiles"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Profiles));

        Spacer(12f);

        // Recent sessions block — built once, repopulated on Show().
        _sessionsHeader = BodyLabel(L.Get("main.sessions.header"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted, TextAnchor.MiddleLeft, FontStyle.Italic);

        _sessionsContainer = CoopMenuFactory.Group("RecentSessions", Body);
        var sRt = _sessionsContainer.GetComponent<RectTransform>();
        sRt.sizeDelta = new(0, 0);
        var sLe = _sessionsContainer.AddComponent<LayoutElement>();
        sLe.preferredHeight = 0f;
        sLe.flexibleWidth = 1f;
        var sVl = _sessionsContainer.AddComponent<VerticalLayoutGroup>();
        sVl.childAlignment = TextAnchor.UpperCenter;
        sVl.childControlHeight = false;
        sVl.childControlWidth = true;
        sVl.childForceExpandHeight = false;
        sVl.childForceExpandWidth = true;
        sVl.spacing = 4f;
        _sessionsContainer.AddComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        Spacer(12f);

        CoopMenuFactory.MenuButton("Host",   Body,
            L.Get("main.btn.host"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Host));

        CoopMenuFactory.MenuButton("Join",   Body,
            L.Get("main.btn.join"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Join));

        CoopMenuFactory.MenuButton("Settings", Body,
            L.Get("main.btn.settings"),
            () => CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Settings));

        Spacer(16f);

        CoopMenuFactory.MenuButton("Close",  Body,
            L.Get("main.btn.close"),
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
        RefreshActiveProfile();
        RebuildSessionsList();
    }

    private void RefreshActiveProfile()
    {
        if (_activeProfileLabel == null) return;
        try
        {
            var p = ProfileStore.Active;
            if (p == null)
            {
                _activeProfileLabel.text  = L.Get("main.profile.none");
                _activeProfileLabel.color = CoopMenuTheme.LabelWarn;
                return;
            }

            string display = string.IsNullOrEmpty(p.DisplayName) ? L.Get("profiles.unnamed") : p.DisplayName;
            string subtitle = p.HasName ? p.FullName : L.Get("profiles.noNameYet");
            _activeProfileLabel.text  = L.Get("main.profile.active", display, subtitle);
            _activeProfileLabel.color = CoopMenuTheme.LabelTitle;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"MainPanel.RefreshActiveProfile: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Recent sessions
    // ─────────────────────────────────────────────────────────────────────

    private void RebuildSessionsList()
    {
        if (_sessionsContainer == null) return;
        try
        {
            // Wipe.
            for (int i = _sessionsContainer.transform.childCount - 1; i >= 0; i--)
                UnityEngine.Object.Destroy(_sessionsContainer.transform.GetChild(i).gameObject);

            var all = SessionStore.All;
            if (_sessionsHeader != null)
                _sessionsHeader.gameObject.SetActive(all.Count > 0);

            if (all.Count == 0) return;

            // Show up to 5 most recent.
            int show = Mathf.Min(5, all.Count);
            for (int i = 0; i < show; i++) BuildSessionRow(all[i]);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"MainPanel.RebuildSessionsList: {ex.Message}");
        }
    }

    private void BuildSessionRow(SessionStore.Entry e)
    {
        var row = CoopMenuFactory.Group($"Session_{e.Endpoint}", _sessionsContainer.transform);
        var rt = row.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, 40f);
        var le = row.AddComponent<LayoutElement>();
        le.preferredHeight = 40f;
        le.flexibleWidth = 1f;

        var bg = row.AddComponent<Image>();
        bg.color = new Color(0.10f, 0.12f, 0.16f, 0.85f);
        bg.raycastTarget = false;

        var hl = row.AddComponent<HorizontalLayoutGroup>();
        hl.childAlignment = TextAnchor.MiddleLeft;
        hl.childControlHeight = true;
        hl.childControlWidth = false;
        hl.childForceExpandHeight = true;
        hl.childForceExpandWidth = false;
        hl.spacing = 6f;
        hl.padding = new RectOffset(10, 6, 4, 4);

        // Endpoint + host name + ago — left side.
        string label = string.IsNullOrEmpty(e.HostName)
            ? $"{e.Endpoint}\n  <i>{SessionStore.FormatAgo(e)}</i>"
            : $"{e.HostName}  <color=#888><size=11>{e.Endpoint}</size></color>\n  <i>{SessionStore.FormatAgo(e)}</i>";

        var nameGo = new GameObject("Label");
        nameGo.transform.SetParent(row.transform, false);
        var nameRt = nameGo.AddComponent<RectTransform>();
        var nameLe = nameGo.AddComponent<LayoutElement>();
        nameLe.flexibleWidth = 1f;
        nameLe.minWidth = 200f;
        var nameText = nameGo.AddComponent<Text>();
        nameText.font = CoopMenuTheme.GetFont();
        nameText.fontSize = CoopMenuTheme.FontSizeSmall;
        nameText.color = CoopMenuTheme.LabelHeader;
        nameText.alignment = TextAnchor.MiddleLeft;
        nameText.text = label;
        nameText.supportRichText = true;
        nameText.raycastTarget = false;

        AddMiniButton(row.transform, L.Get("main.sessions.btn.connect"), () => OnQuickConnect(e), 90f, true);
        AddMiniButton(row.transform, "✕",                               () => OnForget(e),       30f, false);
    }

    private Button AddMiniButton(Transform parent, string label, Action onClick, float width, bool primary)
    {
        var btn = CoopMenuFactory.MenuButton(label, parent, label, onClick, widthOverride: width);
        var le = btn.gameObject.AddComponent<LayoutElement>();
        le.preferredWidth = width; le.minWidth = width;
        le.preferredHeight = 32f;  le.minHeight = 32f;
        var rt = btn.GetComponent<RectTransform>();
        rt.sizeDelta = new(width, 32f);
        if (!primary)
        {
            var t = btn.GetComponentInChildren<Text>();
            if (t != null) t.color = CoopMenuTheme.LabelMuted;
        }
        return btn;
    }

    private void OnQuickConnect(SessionStore.Entry e)
    {
        try
        {
            if (e == null || e.HostSteamId == 0) return;
            // Without a live lobby ID, the cleanest re-entry is via the
            // Steam overlay — open the friend's profile so the user can
            // click "Join Game" if the host is online.
            try { Steamworks.SteamFriends.ActivateGameOverlayToUser("steamid", new Steamworks.CSteamID(e.HostSteamId)); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[MainPanel] open friend overlay: {ex.Message}"); }
            Plugin.Log.LogInfo($"[MainPanel] opening Steam overlay for last host {e.HostName} ({e.HostSteamId})");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"MainPanel.OnQuickConnect: {ex}");
        }
    }

    private void OnForget(SessionStore.Entry e)
    {
        if (e == null) return;
        SessionStore.Forget(e.HostSteamId);
        RebuildSessionsList();
    }
}
