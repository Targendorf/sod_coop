using UnityEngine;

namespace SoDCoop.UI.Coop;

/// <summary>
/// Shared colors / sizing constants for the new Canvas-based co-op menu.
/// Tuned to lean towards Shadows of Doubt's noir / pixelated UI palette
/// without trying to be a 1:1 clone (we're an overlay, not a vanilla theme).
/// </summary>
public static class CoopMenuTheme
{
    // Backgrounds
    public static readonly Color RootDim         = new(0f, 0f, 0f, 0.55f);    // page-fading underlay
    public static readonly Color PanelBg         = new(0.08f, 0.10f, 0.13f, 0.96f);
    public static readonly Color PanelBorder     = new(0.95f, 0.62f, 0.20f, 1f);  // amber line
    public static readonly Color SectionBg       = new(0.12f, 0.15f, 0.19f, 0.92f);

    // Buttons
    public static readonly Color ButtonBg        = new(0.16f, 0.20f, 0.26f, 1f);
    public static readonly Color ButtonBgHover   = new(0.95f, 0.62f, 0.20f, 1f);  // amber on hover
    public static readonly Color ButtonBgActive  = new(0.78f, 0.50f, 0.16f, 1f);
    public static readonly Color ButtonText      = new(0.96f, 0.94f, 0.86f, 1f);  // off-white
    public static readonly Color ButtonTextHover = new(0.06f, 0.06f, 0.06f, 1f);  // black on amber

    // Inputs
    public static readonly Color InputBg         = new(0.05f, 0.07f, 0.10f, 1f);
    public static readonly Color InputText       = new(0.96f, 0.94f, 0.86f, 1f);
    public static readonly Color InputPlaceholder= new(0.55f, 0.55f, 0.55f, 1f);

    // Labels
    public static readonly Color LabelTitle      = new(0.95f, 0.62f, 0.20f, 1f);  // amber
    public static readonly Color LabelHeader     = new(0.85f, 0.85f, 0.78f, 1f);
    public static readonly Color LabelBody       = new(0.75f, 0.75f, 0.70f, 1f);
    public static readonly Color LabelMuted      = new(0.50f, 0.50f, 0.48f, 1f);
    public static readonly Color LabelOk         = new(0.55f, 0.85f, 0.45f, 1f);
    public static readonly Color LabelWarn       = new(0.95f, 0.75f, 0.30f, 1f);
    public static readonly Color LabelError      = new(0.92f, 0.42f, 0.40f, 1f);

    // Sizes
    public const float PanelWidth      = 560f;
    public const float PanelHeightMain = 520f;
    public const float ButtonHeight    = 44f;
    public const float ButtonGap       = 8f;
    public const float Padding         = 24f;
    public const float SectionPadding  = 14f;

    // Typography
    public const int FontSizeTitle     = 28;
    public const int FontSizeHeader    = 18;
    public const int FontSizeBody      = 15;
    public const int FontSizeButton    = 16;
    public const int FontSizeSmall     = 12;

    /// <summary>Thin border render — 4 outline rects around a panel.</summary>
    public const float BorderThickness = 2f;

    /// <summary>Cached default Unity font ("Arial" via Resources lookup).</summary>
    private static Font _font;
    public static Font GetFont()
    {
        if (_font != null) return _font;
        try { _font = Resources.GetBuiltinResource<Font>("Arial.ttf"); } catch { }
        if (_font == null)
        {
            try { _font = Font.CreateDynamicFontFromOSFont("Arial", 16); } catch { }
        }
        return _font;
    }
}
