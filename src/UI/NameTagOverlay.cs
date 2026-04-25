using SoDCoop.Player;
using UnityEngine;

namespace SoDCoop.UI;

/// <summary>
/// Screen-space overlay that draws every remote player's nickname above their head.
/// Works at any distance and through walls — uses World→Screen projection in OnGUI,
/// so render distance / occlusion / shader pipeline don't matter.
/// </summary>
public static class NameTagOverlay
{
    /// <summary>
    /// Vertical world offset above player root for the label anchor.
    /// </summary>
    private const float HEAD_OFFSET_Y = 2.1f;

    /// <summary>
    /// Base font size when player is right next to camera. Scales down with distance
    /// but is clamped so far-away players are still readable across the city.
    /// </summary>
    private const int FONT_SIZE_NEAR = 22;
    private const int FONT_SIZE_FAR  = 12;

    /// <summary>
    /// Distance (m) at which font reaches FONT_SIZE_FAR. Beyond this stays at FAR size.
    /// </summary>
    private const float SCALE_FAR_DISTANCE = 80f;

    private static GUIStyle _style;
    private static GUIStyle _shadowStyle;
    private static Texture2D _bgTex;

    public static void Draw()
    {
        var cam = Camera.main;
        if (cam == null) return;

        EnsureStyles();

        foreach (var rp in RemotePlayerManager.GetAllPlayers())
        {
            if (rp == null || rp.gameObject == null || !rp.gameObject.activeInHierarchy) continue;

            var worldPos = rp.transform.position + new Vector3(0f, HEAD_OFFSET_Y, 0f);
            var screen = cam.WorldToScreenPoint(worldPos);

            // Behind camera — skip (z<0). We could draw an edge arrow here later.
            if (screen.z <= 0f) continue;

            float distance = screen.z;
            int fontSize = ComputeFontSize(distance);
            _style.fontSize = fontSize;
            _shadowStyle.fontSize = fontSize;

            string label = string.IsNullOrEmpty(rp.PlayerName) ? $"Player {rp.PlayerId}" : rp.PlayerName;
            // Optional: append distance for debug visibility — easy to confirm we see each other.
            string display = $"{label}  ·  {Mathf.RoundToInt(distance)}m";

            // OnGUI Y is inverted vs screen Y.
            float gx = screen.x;
            float gy = Screen.height - screen.y;

            var size = _style.CalcSize(new GUIContent(display));
            var rect = new Rect(gx - size.x * 0.5f, gy - size.y, size.x, size.y);

            // Semi-transparent backdrop for readability over bright scenes.
            GUI.DrawTexture(new Rect(rect.x - 4, rect.y - 2, rect.width + 8, rect.height + 4), _bgTex);

            // Drop shadow + main text.
            GUI.Label(new Rect(rect.x + 1, rect.y + 1, rect.width, rect.height), display, _shadowStyle);
            GUI.Label(rect, display, _style);
        }
    }

    private static int ComputeFontSize(float distance)
    {
        float t = Mathf.Clamp01(distance / SCALE_FAR_DISTANCE);
        return Mathf.RoundToInt(Mathf.Lerp(FONT_SIZE_NEAR, FONT_SIZE_FAR, t));
    }

    private static void EnsureStyles()
    {
        if (_style != null && _bgTex != null) return;

        _style = new GUIStyle(GUI.skin.label)
        {
            alignment = TextAnchor.MiddleCenter,
            fontStyle = FontStyle.Bold,
            richText  = false,
        };
        _style.normal.textColor = new Color(1f, 1f, 0.9f, 1f);

        _shadowStyle = new GUIStyle(_style);
        _shadowStyle.normal.textColor = new Color(0f, 0f, 0f, 0.85f);

        _bgTex = new Texture2D(1, 1);
        _bgTex.SetPixel(0, 0, new Color(0f, 0f, 0f, 0.45f));
        _bgTex.Apply();
        _bgTex.hideFlags = HideFlags.HideAndDontSave;
    }
}
