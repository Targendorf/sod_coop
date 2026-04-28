using System.Collections.Generic;
using SoDCoop.UI.Coop.Panels;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop;

/// <summary>
/// Master controller for the new Canvas-based co-op menu.
///
/// Lifecycle:
///   • <see cref="Initialize"/> is called once at plugin load — builds the
///     Canvas hierarchy lazily.
///   • <see cref="Toggle"/> shows / hides the menu (bound to F9).
///   • Panels live as siblings under the root <see cref="_panelContainer"/>;
///     only one is active at a time, switched via <see cref="ShowPanel"/>.
///
/// All UI is procedural via <see cref="CoopMenuFactory"/>. We use Unity
/// legacy uGUI (<c>Image / Button / Text / InputField</c>) for IL2CPP
/// reliability — TextMeshPro types occasionally trip on injection.
/// </summary>
public static class CoopMenuController
{
    private static GameObject _root;
    private static Canvas     _canvas;
    private static GameObject _dimmer;       // semi-opaque background
    private static GameObject _panelContainer;
    private static EventSystem _ownEventSystem;

    private static MainPanel    _mainPanel;
    private static HostPanel    _hostPanel;
    private static JoinPanel    _joinPanel;
    private static LobbyPanel   _lobbyPanel;
    private static IpInfoPanel  _ipPanel;

    /// <summary>Current visible panel, or null when menu is hidden.</summary>
    public enum PanelKind { None, Main, Host, Join, Lobby, IpInfo }
    private static PanelKind _current = PanelKind.None;

    public static bool IsVisible { get; private set; }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lifecycle
    // ─────────────────────────────────────────────────────────────────────────

    public static void Initialize()
    {
        // Defer canvas build until first Toggle — avoids Awake / Start order
        // conflicts in IL2CPP (some required components may not be ready yet).
    }

    public static void Toggle()
    {
        if (_root == null) BuildCanvas();
        SetVisible(!IsVisible);
    }

    public static void Show(PanelKind kind = PanelKind.Main)
    {
        if (_root == null) BuildCanvas();
        SetVisible(true);
        ShowPanel(kind);
    }

    public static void Hide() => SetVisible(false);

    private static void SetVisible(bool show)
    {
        if (_root == null) return;
        IsVisible = show;
        _root.SetActive(show);
        if (show && _current == PanelKind.None) ShowPanel(PanelKind.Main);
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Per-frame tick (panels poll for live data)
    // ─────────────────────────────────────────────────────────────────────────

    public static void Update()
    {
        if (!IsVisible) return;
        try
        {
            _lobbyPanel?.Tick();
            _hostPanel?.Tick();
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"CoopMenuController.Update: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Canvas construction
    // ─────────────────────────────────────────────────────────────────────────

    private static void BuildCanvas()
    {
        try
        {
            _root = new GameObject("SoDCoop_Menu");
            Object.DontDestroyOnLoad(_root);
            _root.SetActive(false);

            // Canvas — overlay, high sort order so we sit above everything.
            _canvas = _root.AddComponent<Canvas>();
            _canvas.renderMode  = RenderMode.ScreenSpaceOverlay;
            _canvas.sortingOrder = 5000;

            var scaler = _root.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
            scaler.matchWidthOrHeight = 0.5f;

            _root.AddComponent<GraphicRaycaster>();

            // Ensure an EventSystem exists so buttons / inputs work.
            if (EventSystem.current == null)
            {
                _ownEventSystem = new GameObject("SoDCoop_EventSystem").AddComponent<EventSystem>();
                _ownEventSystem.gameObject.AddComponent<StandaloneInputModule>();
                Object.DontDestroyOnLoad(_ownEventSystem.gameObject);
            }

            // Page dimmer.
            _dimmer = new GameObject("Dimmer");
            _dimmer.transform.SetParent(_root.transform, false);
            var dRt = _dimmer.AddComponent<RectTransform>();
            dRt.anchorMin = Vector2.zero; dRt.anchorMax = Vector2.one;
            dRt.offsetMin = dRt.offsetMax = Vector2.zero;
            var dimImg = _dimmer.AddComponent<Image>();
            dimImg.color = CoopMenuTheme.RootDim;
            dimImg.raycastTarget = true;   // catches stray clicks

            // Panel container — centred on screen.
            _panelContainer = CoopMenuFactory.Group("PanelContainer", _root.transform);
            var pcRt = _panelContainer.GetComponent<RectTransform>();
            pcRt.anchorMin = pcRt.anchorMax = new Vector2(0.5f, 0.5f);
            pcRt.pivot = new Vector2(0.5f, 0.5f);
            pcRt.anchoredPosition = Vector2.zero;
            pcRt.sizeDelta = new Vector2(CoopMenuTheme.PanelWidth, CoopMenuTheme.PanelHeightMain);

            // Panels — built once, hidden until requested.
            _mainPanel  = new MainPanel();   _mainPanel.Build(_panelContainer.transform);
            _hostPanel  = new HostPanel();   _hostPanel.Build(_panelContainer.transform);
            _joinPanel  = new JoinPanel();   _joinPanel.Build(_panelContainer.transform);
            _lobbyPanel = new LobbyPanel();  _lobbyPanel.Build(_panelContainer.transform);
            _ipPanel    = new IpInfoPanel(); _ipPanel.Build(_panelContainer.transform);

            HideAllPanels();
            Plugin.Log.LogInfo("[CoopMenu] canvas built");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"CoopMenuController.BuildCanvas failed: {ex}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Panel switching
    // ─────────────────────────────────────────────────────────────────────────

    public static void ShowPanel(PanelKind kind)
    {
        HideAllPanels();
        _current = kind;
        switch (kind)
        {
            case PanelKind.Main:   _mainPanel?.Show();  break;
            case PanelKind.Host:   _hostPanel?.Show();  break;
            case PanelKind.Join:   _joinPanel?.Show();  break;
            case PanelKind.Lobby:  _lobbyPanel?.Show(); break;
            case PanelKind.IpInfo: _ipPanel?.Show();    break;
        }
    }

    private static void HideAllPanels()
    {
        _mainPanel?.Hide();
        _hostPanel?.Hide();
        _joinPanel?.Hide();
        _lobbyPanel?.Hide();
        _ipPanel?.Hide();
    }
}
