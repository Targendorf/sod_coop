using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Common scaffolding for each menu panel: framed background, title row,
/// vertical stack for content. Subclasses override <see cref="BuildBody"/>
/// to fill the content area.
/// </summary>
public abstract class CoopPanelBase
{
    protected GameObject Root;
    protected Transform  Body;            // the vertical-stacked content area
    protected Text       TitleText;

    /// <summary>Title shown at the top of the panel.</summary>
    protected abstract string Title { get; }

    /// <summary>Override to fill the body area (called once on Build).</summary>
    protected abstract void BuildBody();

    public void Build(Transform parent)
    {
        Root = CoopMenuFactory.Panel(GetType().Name, parent,
            CoopMenuTheme.PanelWidth, CoopMenuTheme.PanelHeightMain,
            CoopMenuTheme.PanelBg);
        var rt = Root.GetComponent<RectTransform>();
        rt.anchorMin = rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = Vector2.zero;

        CoopMenuFactory.AddBorder(Root, CoopMenuTheme.PanelBorder, CoopMenuTheme.BorderThickness);

        // Title row.
        var titleGo = CoopMenuFactory.Group("Title", Root.transform);
        var titleRt = titleGo.GetComponent<RectTransform>();
        titleRt.anchorMin = new(0f, 1f);
        titleRt.anchorMax = new(1f, 1f);
        titleRt.pivot     = new(0.5f, 1f);
        titleRt.sizeDelta = new(0, 60f);
        titleRt.anchoredPosition = new(0f, -10f);
        TitleText = CoopMenuFactory.Label("TitleText", titleGo.transform, Title,
            CoopMenuTheme.FontSizeTitle, CoopMenuTheme.LabelTitle,
            TextAnchor.MiddleCenter, FontStyle.Bold);

        // Body area — fills below title with padding.
        var bodyGo = CoopMenuFactory.Group("Body", Root.transform);
        var bodyRt = bodyGo.GetComponent<RectTransform>();
        bodyRt.anchorMin = new(0f, 0f);
        bodyRt.anchorMax = new(1f, 1f);
        bodyRt.offsetMin = new(CoopMenuTheme.Padding, CoopMenuTheme.Padding);
        bodyRt.offsetMax = new(-CoopMenuTheme.Padding, -80f);
        Body = bodyGo.transform;

        // Vertical stacker so children stack neatly.
        var stack = bodyGo.AddComponent<VerticalLayoutGroup>();
        stack.childAlignment = TextAnchor.UpperCenter;
        stack.childControlHeight = false;
        stack.childControlWidth  = true;
        stack.childForceExpandHeight = false;
        stack.childForceExpandWidth  = true;
        stack.spacing = CoopMenuTheme.ButtonGap;

        BuildBody();
        Hide();
    }

    public virtual void Show() => Root?.SetActive(true);
    public virtual void Hide() => Root?.SetActive(false);

    /// <summary>Convenience: a small spacer so groups visually breathe.</summary>
    protected void Spacer(float height = 12f)
    {
        var go = CoopMenuFactory.Group("Spacer", Body);
        var rt = go.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, height);
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = height;
        le.flexibleWidth = 1f;
    }

    /// <summary>Adds a centered information line.</summary>
    protected Text BodyLabel(string text, int fontSize, Color color,
                             TextAnchor anchor = TextAnchor.MiddleCenter,
                             FontStyle style = FontStyle.Normal)
    {
        var go = CoopMenuFactory.Group("Label", Body);
        var rt = go.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, fontSize + 8);
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = fontSize + 8;
        le.flexibleWidth = 1f;
        return CoopMenuFactory.Label("Text", go.transform, text, fontSize, color, anchor, style);
    }

    /// <summary>
    /// Multi-line label that wraps long text within the panel width. Approximates
    /// line count from text length × font size, then sizes the row tall enough.
    /// Cheap and font-agnostic; if the heuristic underestimates, the Text's
    /// vertical-overflow=Overflow lets it spill rather than clip.
    /// </summary>
    protected Text WrappedBodyLabel(string text, int fontSize, Color color,
                                    TextAnchor anchor = TextAnchor.MiddleCenter,
                                    FontStyle style = FontStyle.Normal)
    {
        // Average glyph width ≈ 0.5 × fontSize for the proportional default font;
        // 0.5 is intentionally conservative so we round up on line count.
        float availWidth   = CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2f - 16f;
        float charsPerLine = Mathf.Max(1f, availWidth / (fontSize * 0.5f));
        int approxLines    = Mathf.Max(1, Mathf.CeilToInt((text?.Length ?? 0) / charsPerLine));
        int height         = approxLines * (fontSize + 4) + 6;

        var go = CoopMenuFactory.Group("Label", Body);
        var rt = go.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, height);
        var le = go.AddComponent<LayoutElement>();
        le.preferredHeight = height;
        le.flexibleWidth = 1f;

        var t = CoopMenuFactory.Label("Text", go.transform, text, fontSize, color, anchor, style);
        t.horizontalOverflow = HorizontalWrapMode.Wrap;
        t.verticalOverflow   = VerticalWrapMode.Overflow;
        return t;
    }
}
