using System;
using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Player;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Per-client appearance customization panel. Shown once after first-time
/// character creation, and any time the player picks "Customize appearance"
/// from the lobby.
///
/// <para>Each control is a row of <c>◀ value ▶</c> arrows with a label. Live
/// preview is "see yourself in the world": confirming the panel applies
/// the overrides to the player's twin citizen on every machine, so the
/// player can close the menu (F9), look in a mirror, and judge the
/// result. Phase 1 deliberately ships without a 3D in-UI preview to keep
/// scope manageable.</para>
/// </summary>
public class AppearancePanel : CoopPanelBase
{
    protected override string Title => L.Get("appearance.title");

    protected override float PanelHeight   => 880f;
    protected override bool  ScrollableBody => true;

    protected AppearanceConfig _cfg = AppearanceConfig.Default;

    // Cycle-row text components, refreshed on each Inc/Dec.
    private Text _genderValue;
    private Text _buildValue;
    private Text _hairStyleValue;
    private Text _hairColourValue;
    private Text _eyeColourValue;
    private Text _skinValue;
    private Text _lipstickValue;
    private Text _expressionValue;
    private Text _outfitValue;
    private Text _wardrobeValue;

    // Color swatches we update inline.
    private Image _hairSwatch;
    private Image _skinSwatch;

    // 3D preview.
    private RawImage _previewImage;
    private Text     _previewMissingLabel;

    private Text _statusLabel;

    public enum Mode
    {
        /// <summary>Live coop session — Confirm broadcasts to host and routes to Lobby.</summary>
        InSession,
        /// <summary>Editing a saved profile from main menu — Confirm hands the
        /// new config back via the supplied callback. No network traffic.</summary>
        ProfileEdit,
    }

    protected Mode _mode = Mode.InSession;
    protected Action<AppearanceConfig> _onProfileConfirm;
    protected Action _onProfileCancel;

    /// <summary>In-session entry point: confirm broadcasts and routes to Lobby.</summary>
    public void Configure(AppearanceConfig initial, bool firstTimeFlow)
    {
        _cfg = initial;
        _mode = Mode.InSession;
        _onProfileConfirm = null;
        _onProfileCancel = null;
        RefreshAllValues();
        ClearStatus();
        UpdateBackButtonLabel();
    }

    /// <summary>Profile-edit entry: callbacks decide what happens on Confirm /
    /// Back; no network traffic, just preview + return.</summary>
    public void ConfigureProfileEdit(AppearanceConfig initial, Action<AppearanceConfig> onConfirm, Action onCancel)
    {
        _cfg = initial;
        _mode = Mode.ProfileEdit;
        _onProfileConfirm = onConfirm;
        _onProfileCancel = onCancel;
        RefreshAllValues();
        ClearStatus();
        UpdateBackButtonLabel();
    }

    private Button _backBtn;
    private Text   _backLabel;

    protected override void BuildBody()
    {
        BodyLabel(L.Get("appearance.subtitle"), CoopMenuTheme.FontSizeSmall,
                  CoopMenuTheme.LabelMuted, TextAnchor.MiddleCenter, FontStyle.Italic);
        Spacer(6f);

        BuildPreviewBlock();
        Spacer(6f);

        _genderValue     = AddCycleRow(L.Get("appearance.row.gender"),     OnGenderDec,    OnGenderInc);
        _buildValue      = AddCycleRow(L.Get("appearance.row.build"),      OnBuildDec,     OnBuildInc);
        _hairStyleValue  = AddCycleRow(L.Get("appearance.row.hairStyle"), OnHairStyleDec, OnHairStyleInc);

        _hairColourValue = AddCycleRow(L.Get("appearance.row.hairColour"), OnHairColourDec, OnHairColourInc, out _hairSwatch);
        _eyeColourValue  = AddCycleRow(L.Get("appearance.row.eyeColour"),  OnEyeColourDec,  OnEyeColourInc);

        _skinValue       = AddCycleRow(L.Get("appearance.row.skin"),       OnSkinDec,       OnSkinInc, out _skinSwatch);
        _lipstickValue   = AddCycleRow(L.Get("appearance.row.lipstick"),   OnLipstickDec,   OnLipstickInc);
        _expressionValue = AddCycleRow(L.Get("appearance.row.expression"), OnExpressionDec, OnExpressionInc);
        _outfitValue     = AddCycleRow(L.Get("appearance.row.outfit"),     OnOutfitDec,     OnOutfitInc);
        _wardrobeValue   = AddCycleRow(L.Get("appearance.row.wardrobe"),   OnWardrobeDec,   OnWardrobeInc);

        // Subclass extension point — DeepAppearancePanel slots additional
        // rows (ShoeType, Grub, full wardrobe browser…) here, before the
        // action row. Default impl is a no-op.
        AppendExtraRows();

        Spacer(8f);

        // Action row: Randomize | Reset | Deep
        var actionsRow = MakeRow();
        AddRowButton(actionsRow, L.Get("appearance.btn.randomize"), OnRandomize);
        AddRowButton(actionsRow, L.Get("appearance.btn.reset"),     OnReset);
        if (ShowDeepCustomizationButton)
            AddRowButton(actionsRow, L.Get("appearance.btn.deep"),  OnOpenDeep);

        Spacer(6f);

        var confirmRow = MakeRow();
        _backBtn = AddRowButtonReturn(confirmRow, L.Get("appearance.btn.back"), OnBack);
        AddRowButton(confirmRow, L.Get("appearance.btn.confirm"), OnConfirm);
        _backLabel = _backBtn?.GetComponentInChildren<Text>();

        _statusLabel = WrappedBodyLabel("", CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted);
    }

    /// <summary>Hook for subclasses to append additional cycle rows / blocks
    /// between the standard rows and the action row. Default = no-op.</summary>
    protected virtual void AppendExtraRows() { }

    /// <summary>Whether to render the "Deep customization →" button in the
    /// action row. The deep panel itself overrides this to false (no point
    /// jumping to itself).</summary>
    protected virtual bool ShowDeepCustomizationButton => true;

    private void OnOpenDeep()
    {
        try
        {
            // Persist the in-flight tweaks into the panel-controller's
            // shared state and switch panels. The deep panel re-reads the
            // active profile / record on Show.
            CoopMenuController.OpenAppearanceDeep(_cfg, _mode, _onProfileConfirm, _onProfileCancel);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"AppearancePanel.OnOpenDeep: {ex}");
        }
    }

    private Button AddRowButtonReturn(GameObject row, string label, Action onClick)
    {
        var btn = CoopMenuFactory.MenuButton(label, row.transform, label, onClick);
        var le = btn.gameObject.AddComponent<LayoutElement>();
        le.flexibleWidth = 1f;
        le.preferredHeight = CoopMenuTheme.ButtonHeight;
        return btn;
    }

    private void UpdateBackButtonLabel()
    {
        if (_backLabel == null) return;
        _backLabel.text = _mode == Mode.ProfileEdit
            ? L.Get("appearance.btn.back")
            : L.Get("appearance.btn.cancel");
    }

    private void OnBack()
    {
        try { AppearancePreviewStage.End(); } catch { }
        if (_mode == Mode.ProfileEdit)
        {
            _onProfileCancel?.Invoke();
        }
        else
        {
            // In-session: drop change, return to Lobby (or Main if disconnected).
            CoopMenuController.ShowPanel(NetworkManager.IsConnected
                ? CoopMenuController.PanelKind.Lobby
                : CoopMenuController.PanelKind.Main);
        }
    }

    public override void Show()
    {
        base.Show();
        RefreshAllValues();
        TryStartPreview();
    }

    public override void Hide()
    {
        try { AppearancePreviewStage.End(); } catch { }
        base.Hide();
    }

    private void TryStartPreview()
    {
        try
        {
            AppearancePreviewStage.Begin(_cfg);
            bool ok = AppearancePreviewStage.IsActive && AppearancePreviewStage.RenderTex != null;
            if (_previewImage != null)
            {
                _previewImage.gameObject.SetActive(ok);
                if (ok) _previewImage.texture = AppearancePreviewStage.RenderTex;
            }
            if (_previewMissingLabel != null)
                _previewMissingLabel.gameObject.SetActive(!ok);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"AppearancePanel.TryStartPreview: {ex.Message}");
        }
    }

    protected void PushPreview()
    {
        if (!AppearancePreviewStage.IsActive) return;
        try { AppearancePreviewStage.Update(_cfg); } catch { }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Preview block
    // ─────────────────────────────────────────────────────────────────────

    private void BuildPreviewBlock()
    {
        const float W = 200f;
        const float H = 260f;

        // Stage row: <  preview  >
        var row = CoopMenuFactory.Group("PreviewRow", Body);
        var rt = row.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, H);
        var le = row.AddComponent<LayoutElement>();
        le.preferredHeight = H;
        le.flexibleWidth = 1f;

        var hl = row.AddComponent<HorizontalLayoutGroup>();
        hl.childAlignment = TextAnchor.MiddleCenter;
        hl.childControlHeight = false;
        hl.childControlWidth = false;
        hl.childForceExpandHeight = false;
        hl.childForceExpandWidth = false;
        hl.spacing = 8f;

        AddArrowButton(row.transform, "<", () => RotatePreview(+25f));

        // Preview frame (RawImage on top of a dark background image).
        var frameGo = new GameObject("PreviewFrame");
        frameGo.transform.SetParent(row.transform, false);
        var frameRt = frameGo.AddComponent<RectTransform>();
        frameRt.sizeDelta = new(W, H);
        var frameLe = frameGo.AddComponent<LayoutElement>();
        frameLe.preferredWidth = W; frameLe.minWidth = W;
        frameLe.preferredHeight = H; frameLe.minHeight = H;
        var frameBg = frameGo.AddComponent<Image>();
        frameBg.color = new Color(0.04f, 0.05f, 0.07f, 1f);
        frameBg.raycastTarget = false;

        // RawImage that displays the RenderTexture.
        var imgGo = new GameObject("PreviewRawImage");
        imgGo.transform.SetParent(frameGo.transform, false);
        var imgRt = imgGo.AddComponent<RectTransform>();
        imgRt.anchorMin = Vector2.zero; imgRt.anchorMax = Vector2.one;
        imgRt.offsetMin = new Vector2(2, 2); imgRt.offsetMax = new Vector2(-2, -2);
        _previewImage = imgGo.AddComponent<RawImage>();
        _previewImage.color = Color.white;
        _previewImage.raycastTarget = false;
        _previewImage.texture = AppearancePreviewStage.RenderTex;
        _previewImage.gameObject.SetActive(false); // shown after Begin succeeds

        // "preview unavailable" overlay text (when no city loaded yet).
        var missGo = new GameObject("PreviewMissing");
        missGo.transform.SetParent(frameGo.transform, false);
        var missRt = missGo.AddComponent<RectTransform>();
        missRt.anchorMin = Vector2.zero; missRt.anchorMax = Vector2.one;
        missRt.offsetMin = missRt.offsetMax = Vector2.zero;
        _previewMissingLabel = missGo.AddComponent<Text>();
        _previewMissingLabel.font = CoopMenuTheme.GetFont();
        _previewMissingLabel.fontSize = CoopMenuTheme.FontSizeSmall;
        _previewMissingLabel.color = CoopMenuTheme.LabelMuted;
        _previewMissingLabel.alignment = TextAnchor.MiddleCenter;
        _previewMissingLabel.fontStyle = FontStyle.Italic;
        _previewMissingLabel.horizontalOverflow = HorizontalWrapMode.Wrap;
        _previewMissingLabel.verticalOverflow = VerticalWrapMode.Overflow;
        _previewMissingLabel.text = L.Get("appearance.preview.unavailable");
        _previewMissingLabel.raycastTarget = false;

        AddArrowButton(row.transform, ">", () => RotatePreview(-25f));
    }

    protected void RotatePreview(float deg)
    {
        try { AppearancePreviewStage.Rotate(deg); } catch { }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Row factories
    // ─────────────────────────────────────────────────────────────────────

    protected Text AddCycleRow(string label, Action onDec, Action onInc)
        => AddCycleRow(label, onDec, onInc, out _);

    protected Text AddCycleRow(string label, Action onDec, Action onInc, out Image swatch)
    {
        var row = CoopMenuFactory.Group("Row", Body);
        var rt = row.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, 32f);
        var le = row.AddComponent<LayoutElement>();
        le.preferredHeight = 32f;
        le.flexibleWidth = 1f;

        var hl = row.AddComponent<HorizontalLayoutGroup>();
        hl.childAlignment = TextAnchor.MiddleLeft;
        hl.childControlHeight = true;
        hl.childControlWidth = false;
        hl.childForceExpandHeight = true;
        hl.childForceExpandWidth = false;
        hl.spacing = 8f;
        hl.padding = new RectOffset(2, 2, 0, 0);

        // Label (fixed width)
        var labelGo = new GameObject("Label");
        labelGo.transform.SetParent(row.transform, false);
        var lblRt = labelGo.AddComponent<RectTransform>();
        lblRt.sizeDelta = new(150f, 28f);
        var lblText = labelGo.AddComponent<Text>();
        lblText.font = CoopMenuTheme.GetFont();
        lblText.fontSize = CoopMenuTheme.FontSizeBody;
        lblText.color = CoopMenuTheme.LabelHeader;
        lblText.alignment = TextAnchor.MiddleLeft;
        lblText.text = label;
        lblText.raycastTarget = false;
        var lblLe = labelGo.AddComponent<LayoutElement>();
        lblLe.preferredWidth = 150f;
        lblLe.minWidth = 150f;

        // ◀
        var dec = AddArrowButton(row.transform, "<", onDec);
        Unused(dec);

        // Optional color swatch
        swatch = null;
        var swatchGo = new GameObject("Swatch");
        swatchGo.transform.SetParent(row.transform, false);
        var swRt = swatchGo.AddComponent<RectTransform>();
        swRt.sizeDelta = new(20f, 20f);
        var swImg = swatchGo.AddComponent<Image>();
        swImg.color = new Color(0, 0, 0, 0); // hidden by default
        swImg.raycastTarget = false;
        var swLe = swatchGo.AddComponent<LayoutElement>();
        swLe.preferredWidth = 20f;
        swLe.minWidth = 20f;
        swatch = swImg;

        // Value label (flexible)
        var valGo = new GameObject("Value");
        valGo.transform.SetParent(row.transform, false);
        var valRt = valGo.AddComponent<RectTransform>();
        valRt.sizeDelta = new(180f, 28f);
        var valText = valGo.AddComponent<Text>();
        valText.font = CoopMenuTheme.GetFont();
        valText.fontSize = CoopMenuTheme.FontSizeBody;
        valText.color = CoopMenuTheme.LabelBody;
        valText.alignment = TextAnchor.MiddleCenter;
        valText.text = "—";
        valText.raycastTarget = false;
        var valLe = valGo.AddComponent<LayoutElement>();
        valLe.preferredWidth = 180f;
        valLe.minWidth = 120f;
        valLe.flexibleWidth = 1f;

        // ▶
        var inc = AddArrowButton(row.transform, ">", onInc);
        Unused(inc);

        return valText;
    }

    protected Button AddArrowButton(Transform parent, string glyph, Action onClick)
    {
        var go = new GameObject($"Arrow_{glyph}");
        go.transform.SetParent(parent, false);
        var rt = go.AddComponent<RectTransform>();
        rt.sizeDelta = new(30f, 28f);
        var le = go.AddComponent<LayoutElement>();
        le.preferredWidth = 30f;
        le.minWidth = 30f;

        var img = go.AddComponent<Image>();
        img.color = CoopMenuTheme.ButtonBg;

        var btn = go.AddComponent<Button>();
        var colors = btn.colors;
        colors.normalColor      = CoopMenuTheme.ButtonBg;
        colors.highlightedColor = CoopMenuTheme.ButtonBgHover;
        colors.pressedColor     = CoopMenuTheme.ButtonBgActive;
        btn.colors = colors;
        btn.targetGraphic = img;

        // Glyph
        var labelGo = new GameObject("Glyph");
        labelGo.transform.SetParent(go.transform, false);
        var lblRt = labelGo.AddComponent<RectTransform>();
        lblRt.anchorMin = Vector2.zero; lblRt.anchorMax = Vector2.one;
        lblRt.offsetMin = lblRt.offsetMax = Vector2.zero;
        var t = labelGo.AddComponent<Text>();
        t.font = CoopMenuTheme.GetFont();
        t.fontSize = CoopMenuTheme.FontSizeButton;
        t.color = CoopMenuTheme.ButtonText;
        t.alignment = TextAnchor.MiddleCenter;
        t.fontStyle = FontStyle.Bold;
        t.text = glyph;
        t.raycastTarget = false;

        if (onClick != null)
        {
            btn.onClick.AddListener((UnityEngine.Events.UnityAction)(() =>
            {
                try { onClick(); }
                catch (Exception ex) { Plugin.Log.LogError($"AppearancePanel arrow \"{glyph}\": {ex}"); }
            }));
        }
        return btn;
    }

    protected GameObject MakeRow()
    {
        var row = CoopMenuFactory.Group("ButtonRow", Body);
        var rt = row.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, CoopMenuTheme.ButtonHeight);
        var le = row.AddComponent<LayoutElement>();
        le.preferredHeight = CoopMenuTheme.ButtonHeight;
        le.flexibleWidth = 1f;
        var hl = row.AddComponent<HorizontalLayoutGroup>();
        hl.childAlignment = TextAnchor.MiddleCenter;
        hl.childControlHeight = true;
        hl.childControlWidth = true;
        hl.childForceExpandHeight = true;
        hl.childForceExpandWidth = true;
        hl.spacing = 8f;
        return row;
    }

    protected void AddRowButton(GameObject row, string label, Action onClick)
    {
        var btn = CoopMenuFactory.MenuButton(label, row.transform, label, onClick);
        var le = btn.gameObject.AddComponent<LayoutElement>();
        le.flexibleWidth = 1f;
        le.preferredHeight = CoopMenuTheme.ButtonHeight;
    }

    protected static void Unused(object _) { }

    // ─────────────────────────────────────────────────────────────────────
    //  Cycling
    // ─────────────────────────────────────────────────────────────────────

    protected static int Wrap(int value, int count)
    {
        if (count <= 0) return 0;
        int m = value % count;
        return m < 0 ? m + count : m;
    }

    protected void Mutate(Action change)
    {
        _cfg.IsCustomized = true;
        change();
        RefreshAllValues();
        PushPreview();
    }

    private void OnGenderDec()    => Mutate(() => _cfg.Gender = (byte)Wrap(_cfg.Gender - 1, 3));
    private void OnGenderInc()    => Mutate(() => _cfg.Gender = (byte)Wrap(_cfg.Gender + 1, 3));

    private void OnBuildDec()     => Mutate(() => _cfg.Build = (byte)Wrap(_cfg.Build - 1, 4));
    private void OnBuildInc()     => Mutate(() => _cfg.Build = (byte)Wrap(_cfg.Build + 1, 4));

    private void OnHairStyleDec() => Mutate(() => _cfg.HairStyle = (byte)Wrap(_cfg.HairStyle - 1, 3));
    private void OnHairStyleInc() => Mutate(() => _cfg.HairStyle = (byte)Wrap(_cfg.HairStyle + 1, 3));

    private void OnHairColourDec() => Mutate(() => _cfg.HairColour = (byte)Wrap(_cfg.HairColour - 1, AppearancePalette.HairPaletteSize));
    private void OnHairColourInc() => Mutate(() => _cfg.HairColour = (byte)Wrap(_cfg.HairColour + 1, AppearancePalette.HairPaletteSize));

    private void OnEyeColourDec()  => Mutate(() => _cfg.EyeColour = (byte)Wrap(_cfg.EyeColour - 1, 4));
    private void OnEyeColourInc()  => Mutate(() => _cfg.EyeColour = (byte)Wrap(_cfg.EyeColour + 1, 4));

    private void OnSkinDec() => Mutate(() => _cfg.SkinIndex = (byte)Wrap(_cfg.SkinIndex - 1, AppearancePalette.SkinPaletteSize));
    private void OnSkinInc() => Mutate(() => _cfg.SkinIndex = (byte)Wrap(_cfg.SkinIndex + 1, AppearancePalette.SkinPaletteSize));

    // Lipstick: 9 stops (0, 32, 64, ... 255).
    private const int LipstickStops = 9;
    private void OnLipstickDec()
    {
        int step = _cfg.Lipstick * (LipstickStops - 1) / 255;
        step = Wrap(step - 1, LipstickStops);
        Mutate(() => _cfg.Lipstick = (byte)Mathf.RoundToInt(step * 255f / (LipstickStops - 1)));
    }
    private void OnLipstickInc()
    {
        int step = _cfg.Lipstick * (LipstickStops - 1) / 255;
        step = Wrap(step + 1, LipstickStops);
        Mutate(() => _cfg.Lipstick = (byte)Mathf.RoundToInt(step * 255f / (LipstickStops - 1)));
    }

    private void OnExpressionDec() => Mutate(() => _cfg.Expression = (byte)Wrap(_cfg.Expression - 1, 6));
    private void OnExpressionInc() => Mutate(() => _cfg.Expression = (byte)Wrap(_cfg.Expression + 1, 6));

    private const int OutfitCount = 9; // ClothesPreset.OutfitCategory enum length
    private void OnOutfitDec() => Mutate(() => _cfg.Outfit = (byte)Wrap(_cfg.Outfit - 1, OutfitCount));
    private void OnOutfitInc() => Mutate(() => _cfg.Outfit = (byte)Wrap(_cfg.Outfit + 1, OutfitCount));

    // Wardrobe source: cycle index -1 = "(use own outfit)" sentinel,
    // 0..N-1 = entry into CitizenWardrobeBrowser. We map this to
    // _cfg.WardrobeSourceHumanId (0 = own).
    private void OnWardrobeDec() => Mutate(() => StepWardrobe(-1));
    private void OnWardrobeInc() => Mutate(() => StepWardrobe(+1));

    private void StepWardrobe(int delta)
    {
        int total = CitizenWardrobeBrowser.Count;
        if (total == 0) { _cfg.WardrobeSourceHumanId = 0; return; }

        // Build a virtual index: [own][entry0][entry1]...[entry N-1].
        int currentVirtual = _cfg.WardrobeSourceHumanId == 0
            ? 0
            : 1 + System.Math.Max(0, CitizenWardrobeBrowser.IndexOfHumanId(_cfg.WardrobeSourceHumanId));

        int next = Wrap(currentVirtual + delta, total + 1);
        if (next == 0) { _cfg.WardrobeSourceHumanId = 0; return; }

        var entry = CitizenWardrobeBrowser.GetByIndex(next - 1);
        _cfg.WardrobeSourceHumanId = entry?.HumanID ?? 0;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Buttons
    // ─────────────────────────────────────────────────────────────────────

    private void OnRandomize()
    {
        var rng = new System.Random();
        _cfg = new AppearanceConfig
        {
            Gender     = (byte)rng.Next(0, 3),
            Build      = (byte)rng.Next(0, 4),
            HairStyle  = (byte)rng.Next(0, 3),
            HairColour = (byte)rng.Next(0, AppearancePalette.HairPaletteSize),
            EyeColour  = (byte)rng.Next(0, 4),
            SkinIndex  = (byte)rng.Next(0, AppearancePalette.SkinPaletteSize),
            Expression = (byte)global::CitizenOutfitController.Expression.neutral,
            Lipstick   = (byte)rng.Next(0, 256),
            Outfit     = (byte)rng.Next(0, OutfitCount),
            WardrobeSourceHumanId = PickRandomWardrobeSource(rng),
            IsCustomized = true,
        };
        RefreshAllValues();
        PushPreview();
    }

    private void OnReset()
    {
        _cfg = AppearanceConfig.Default;   // IsCustomized=false → twin returns to vanilla
        RefreshAllValues();
        PushPreview();
    }

    private static int PickRandomWardrobeSource(System.Random rng)
    {
        // 30% chance: keep own outfit. 70%: pick a real citizen.
        if (rng.NextDouble() < 0.30) return 0;
        int total = CitizenWardrobeBrowser.Count;
        if (total == 0) return 0;
        var entry = CitizenWardrobeBrowser.GetByIndex(rng.Next(0, total));
        return entry?.HumanID ?? 0;
    }

    private void OnConfirm()
    {
        try
        {
            try { AppearancePreviewStage.End(); } catch { }

            if (_mode == Mode.ProfileEdit)
            {
                _onProfileConfirm?.Invoke(_cfg);
                return;
            }

            // ── In-session ──
            // 1. Apply locally to our Player.Instance.outfitController so
            //    mirrors / 3rd-person show the new look immediately.
            ApplyToLocalPlayer(_cfg);

            // 2. Broadcast to host (host applies on its twin and re-broadcasts).
            AppearanceSync.BroadcastLocal(_cfg);

            // 3. Persist into the active profile so it survives reconnects /
            //    next session.
            try
            {
                var prof = global::SoDCoop.Player.ProfileStore.Active;
                if (prof != null)
                {
                    prof.Appearance = _cfg;
                    global::SoDCoop.Player.ProfileStore.Save(prof);
                }
            }
            catch (Exception ex)
            {
                Plugin.Log.LogWarning($"AppearancePanel profile persist: {ex.Message}");
            }

            // 4. Host self-persist into CharacterStore (clients rely on host's
            //    OnPacketReceived path).
            if (NetworkManager.IsHost)
            {
                try
                {
                    string seed = CharacterStore.CurrentSeed();
                    string guid = global::SoDCoop.Player.CharacterIdentity.ClientGuid;
                    if (!string.IsNullOrEmpty(guid))
                        CharacterStore.SetAppearance(seed, guid, _cfg);
                }
                catch (Exception ex)
                {
                    Plugin.Log.LogWarning($"AppearancePanel host-self persist: {ex.Message}");
                }
            }

            CoopMenuController.ShowPanel(CoopMenuController.PanelKind.Lobby);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"AppearancePanel.OnConfirm: {ex}");
            if (_statusLabel != null)
            {
                _statusLabel.text = $"Error: {ex.Message}";
                _statusLabel.color = CoopMenuTheme.LabelError;
            }
        }
    }

    private static void ApplyToLocalPlayer(AppearanceConfig cfg)
    {
        try
        {
            var p = global::Player.Instance;
            if (p != null)
            {
                var ctrl = p.outfitController;
                if (ctrl != null) cfg.ApplyTo(ctrl);
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"AppearancePanel.ApplyToLocalPlayer: {ex.Message}");
        }
    }

    private void ClearStatus()
    {
        if (_statusLabel == null) return;
        _statusLabel.text = "";
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Refresh value labels & swatches
    // ─────────────────────────────────────────────────────────────────────

    protected virtual void RefreshAllValues()
    {
        if (_genderValue != null)
            _genderValue.text = L.Get($"appearance.gender.{((global::Human.Gender)_cfg.Gender).ToString().ToLowerInvariant()}");
        if (_buildValue != null)
            _buildValue.text = L.Get($"appearance.build.{((global::Descriptors.BuildType)_cfg.Build).ToString().ToLowerInvariant()}");
        if (_hairStyleValue != null)
            _hairStyleValue.text = L.Get($"appearance.hairStyle.{((global::Descriptors.HairStyle)_cfg.HairStyle).ToString().ToLowerInvariant()}");
        if (_hairColourValue != null)
            _hairColourValue.text = L.Get($"appearance.hairColour.{((global::Descriptors.HairColour)_cfg.HairColour).ToString().ToLowerInvariant()}");
        if (_eyeColourValue != null)
            _eyeColourValue.text = L.Get($"appearance.eyeColour.{((global::Descriptors.EyeColour)_cfg.EyeColour).ToString().ToLowerInvariant()}");
        if (_skinValue != null)
            _skinValue.text = L.Get("appearance.skin.value", _cfg.SkinIndex + 1, AppearancePalette.SkinPaletteSize);
        if (_lipstickValue != null)
        {
            int step = _cfg.Lipstick * (LipstickStops - 1) / 255;
            _lipstickValue.text = L.Get("appearance.lipstick.value", step, LipstickStops - 1);
        }
        if (_expressionValue != null)
            _expressionValue.text = L.Get($"appearance.expression.{((global::CitizenOutfitController.Expression)_cfg.Expression).ToString().ToLowerInvariant()}");
        if (_outfitValue != null)
            _outfitValue.text = L.Get($"appearance.outfit.{((global::ClothesPreset.OutfitCategory)_cfg.Outfit).ToString().ToLowerInvariant()}");
        if (_wardrobeValue != null)
        {
            if (_cfg.WardrobeSourceHumanId == 0)
            {
                _wardrobeValue.text = L.Get("appearance.wardrobe.own");
            }
            else
            {
                var entry = CitizenWardrobeBrowser.GetByHumanId(_cfg.WardrobeSourceHumanId);
                if (entry == null)
                {
                    _wardrobeValue.text = L.Get("appearance.wardrobe.unknown", _cfg.WardrobeSourceHumanId);
                }
                else
                {
                    _wardrobeValue.text = string.IsNullOrEmpty(entry.Subtitle)
                        ? entry.DisplayName
                        : $"{entry.DisplayName}\n  <i>{entry.Subtitle}</i>";
                }
            }
        }

        if (_hairSwatch != null)
        {
            var c = AppearancePalette.HairColourFor((global::Descriptors.HairColour)_cfg.HairColour);
            _hairSwatch.color = new Color(c.r, c.g, c.b, 1f);
        }
        if (_skinSwatch != null)
        {
            var c = AppearancePalette.SkinColourFor(_cfg.SkinIndex);
            _skinSwatch.color = new Color(c.r, c.g, c.b, 1f);
        }
    }
}
