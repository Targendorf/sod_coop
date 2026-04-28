using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop;

/// <summary>
/// Helpers for procedurally building the co-op menu UI. Each method creates
/// a styled <c>GameObject</c> with the right uGUI component stack and
/// returns it (or its main interactive component). All children parent into
/// <paramref name="parent"/>'s RectTransform.
///
/// Built on Unity's legacy uGUI (<c>Image</c>, <c>Button</c>, <c>Text</c>,
/// <c>InputField</c>) for IL2CPP reliability — TMP types occasionally trip
/// on injection, and the legacy stack covers everything we need.
/// </summary>
public static class CoopMenuFactory
{
    // ─────────────────────────────────────────────────────────────────────────
    //  Container helpers
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>Empty <c>GameObject</c> with a <c>RectTransform</c> child.</summary>
    public static GameObject Group(string name, Transform parent)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var rt = go.AddComponent<RectTransform>();
        rt.anchorMin = rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        return go;
    }

    public static GameObject Panel(string name, Transform parent, float width, float height, Color bg)
    {
        var go = Group(name, parent);
        var rt = go.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(width, height);
        var img = go.AddComponent<Image>();
        img.color = bg;
        return go;
    }

    /// <summary>Single thin border rectangle for the four-edge outline trick.</summary>
    private static void BorderEdge(Transform parent, Vector2 anchorMin, Vector2 anchorMax,
                                   Vector2 sizeDelta, Color color)
    {
        var go = new GameObject("Edge");
        go.transform.SetParent(parent, false);
        var rt = go.AddComponent<RectTransform>();
        rt.anchorMin = anchorMin;
        rt.anchorMax = anchorMax;
        rt.sizeDelta = sizeDelta;
        rt.anchoredPosition = Vector2.zero;
        var img = go.AddComponent<Image>();
        img.color = color;
        img.raycastTarget = false;
    }

    /// <summary>Adds a 4-edge outline to a rect-transform-y panel.</summary>
    public static void AddBorder(GameObject panel, Color color, float thickness = 2f)
    {
        var t = panel.transform;
        BorderEdge(t, new(0, 1), new(1, 1), new(0, thickness), color); // top
        BorderEdge(t, new(0, 0), new(1, 0), new(0, thickness), color); // bottom
        BorderEdge(t, new(0, 0), new(0, 1), new(thickness, 0), color); // left
        BorderEdge(t, new(1, 0), new(1, 1), new(thickness, 0), color); // right
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Text
    // ─────────────────────────────────────────────────────────────────────────

    public static Text Label(string name, Transform parent, string text, int fontSize, Color color,
                             TextAnchor anchor = TextAnchor.MiddleCenter, FontStyle style = FontStyle.Normal)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var rt = go.AddComponent<RectTransform>();
        rt.anchorMin = new(0f, 0f);
        rt.anchorMax = new(1f, 1f);
        rt.offsetMin = rt.offsetMax = Vector2.zero;
        var t = go.AddComponent<Text>();
        t.text = text;
        t.font = CoopMenuTheme.GetFont();
        t.fontSize = fontSize;
        t.color = color;
        t.alignment = anchor;
        t.fontStyle = style;
        t.horizontalOverflow = HorizontalWrapMode.Overflow;
        t.verticalOverflow = VerticalWrapMode.Overflow;
        t.raycastTarget = false;
        return t;
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Buttons
    // ─────────────────────────────────────────────────────────────────────────

    public static Button MenuButton(string name, Transform parent, string label,
                                    System.Action onClick, float? widthOverride = null)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var rt = go.AddComponent<RectTransform>();
        rt.sizeDelta = new(widthOverride ?? (CoopMenuTheme.PanelWidth - CoopMenuTheme.Padding * 2),
                           CoopMenuTheme.ButtonHeight);

        var img = go.AddComponent<Image>();
        img.color = CoopMenuTheme.ButtonBg;

        var btn = go.AddComponent<Button>();
        var colors = btn.colors;
        colors.normalColor      = CoopMenuTheme.ButtonBg;
        colors.highlightedColor = CoopMenuTheme.ButtonBgHover;
        colors.pressedColor     = CoopMenuTheme.ButtonBgActive;
        colors.selectedColor    = CoopMenuTheme.ButtonBgHover;
        colors.disabledColor    = new Color(CoopMenuTheme.ButtonBg.r, CoopMenuTheme.ButtonBg.g,
                                            CoopMenuTheme.ButtonBg.b, 0.4f);
        btn.colors = colors;
        btn.targetGraphic = img;

        // Text label as child.
        Label("Text", go.transform, label, CoopMenuTheme.FontSizeButton,
              CoopMenuTheme.ButtonText, TextAnchor.MiddleCenter, FontStyle.Bold);

        if (onClick != null)
        {
            try
            {
                btn.onClick.AddListener((UnityAction)(() =>
                {
                    try { onClick(); }
                    catch (System.Exception ex) { Plugin.Log.LogError($"Coop button \"{label}\": {ex}"); }
                }));
            }
            catch (System.Exception ex)
            {
                Plugin.Log.LogWarning($"CoopMenuFactory.MenuButton listener wire-up: {ex.Message}");
            }
        }

        return btn;
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inputs
    // ─────────────────────────────────────────────────────────────────────────

    public static InputField TextInput(string name, Transform parent, string initial,
                                       string placeholder, float width, float height = 36f)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var rt = go.AddComponent<RectTransform>();
        rt.sizeDelta = new(width, height);

        var bg = go.AddComponent<Image>();
        bg.color = CoopMenuTheme.InputBg;

        var input = go.AddComponent<InputField>();
        input.targetGraphic = bg;

        // Text component for the entered text.
        var textGo = new GameObject("Text");
        textGo.transform.SetParent(go.transform, false);
        var textRt = textGo.AddComponent<RectTransform>();
        textRt.anchorMin = new(0, 0); textRt.anchorMax = new(1, 1);
        textRt.offsetMin = new(8, 4); textRt.offsetMax = new(-8, -4);
        var text = textGo.AddComponent<Text>();
        text.font = CoopMenuTheme.GetFont();
        text.fontSize = CoopMenuTheme.FontSizeBody;
        text.color = CoopMenuTheme.InputText;
        text.alignment = TextAnchor.MiddleLeft;
        text.supportRichText = false;
        text.horizontalOverflow = HorizontalWrapMode.Wrap;
        input.textComponent = text;

        // Placeholder.
        var placeholderGo = new GameObject("Placeholder");
        placeholderGo.transform.SetParent(go.transform, false);
        var phRt = placeholderGo.AddComponent<RectTransform>();
        phRt.anchorMin = new(0, 0); phRt.anchorMax = new(1, 1);
        phRt.offsetMin = new(8, 4); phRt.offsetMax = new(-8, -4);
        var ph = placeholderGo.AddComponent<Text>();
        ph.font = CoopMenuTheme.GetFont();
        ph.fontSize = CoopMenuTheme.FontSizeBody;
        ph.color = CoopMenuTheme.InputPlaceholder;
        ph.alignment = TextAnchor.MiddleLeft;
        ph.text = placeholder ?? "";
        ph.fontStyle = FontStyle.Italic;
        input.placeholder = ph;

        input.text = initial ?? "";

        return input;
    }
}
