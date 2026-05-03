using System;
using System.Collections.Generic;
using SoDCoop.Localization;
using SoDCoop.Network;
using SoDCoop.Player;
using SoDCoop.Sync;
using UnityEngine;
using UnityEngine.UI;

namespace SoDCoop.UI.Coop.Panels;

/// <summary>
/// Wider, denser counterpart to <see cref="AppearancePanel"/>. Inherits the
/// full row layout from the base panel and tacks on every additional knob
/// SoD's <c>CitizenOutfitController.debugOverride*</c> surface exposes:
/// shoe type, grime level, plus a long scrollable wardrobe browser so the
/// player can pick the source citizen by name instead of cycling through
/// hundreds of entries one-at-a-time with the basic panel's arrows.
///
/// <para>Wire-format-compatible with the basic panel — the extra fields
/// land in <see cref="AppearanceConfig.ShoeType"/> and
/// <see cref="AppearanceConfig.Grub"/>, both backwards-compatibly read /
/// written so a host running the deep panel can still talk to a client
/// that only knows the basic format.</para>
/// </summary>
public class DeepAppearancePanel : AppearancePanel
{
    protected override string Title => L.Get("appearanceDeep.title");

    // Wider + taller so the wardrobe browser has room to breathe.
    protected override float PanelWidth  => 760f;
    protected override float PanelHeight => 1040f;

    /// <summary>The deep panel IS the deep panel — no point linking to itself.</summary>
    protected override bool ShowDeepCustomizationButton => false;

    private Text _shoeTypeValue;
    private Text _grubValue;

    // Per-slot wardrobe cycle rows (one Text per slot for the value label).
    private Text _slotHatValue;
    private Text _slotTopValue;
    private Text _slotBottomValue;
    private Text _slotShoesValue;
    private Text _slotGlassesValue;
    private Text _slotHandsValue;

    // Wardrobe browser state.
    private GameObject _wardrobeListGo;
    private readonly List<(int humanId, Text label, Image marker)> _wardrobeRows = new();
    private const int WARDROBE_ROW_HEIGHT = 28;
    private const int WARDROBE_VISIBLE_HEIGHT = 220;

    protected override void AppendExtraRows()
    {
        Spacer(8f);
        BodyLabel(L.Get("appearanceDeep.section.body"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelTitle, TextAnchor.MiddleLeft, FontStyle.Bold);

        _shoeTypeValue = AddCycleRow(L.Get("appearanceDeep.row.shoeType"), OnShoeTypeDec, OnShoeTypeInc);
        _grubValue     = AddCycleRow(L.Get("appearanceDeep.row.grub"),     OnGrubDec,     OnGrubInc);

        Spacer(8f);
        BodyLabel(L.Get("appearanceDeep.section.slots"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelTitle, TextAnchor.MiddleLeft, FontStyle.Bold);
        BodyLabel(L.Get("appearanceDeep.slots.hint"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted, TextAnchor.MiddleLeft, FontStyle.Italic);

        // Per-slot wardrobe cycle rows: each picks a different source citizen
        // for one anchor group. Click arrows to cycle through "(use own)" +
        // every loaded citizen. Apply / preview happens immediately via
        // Mutate → PushPreview path inherited from the base panel.
        _slotHatValue     = AddCycleRow(L.Get("appearanceDeep.slot.hat"),     () => StepSlot(WardrobeSlot.Hat,     -1), () => StepSlot(WardrobeSlot.Hat,     +1));
        _slotTopValue     = AddCycleRow(L.Get("appearanceDeep.slot.top"),     () => StepSlot(WardrobeSlot.Top,     -1), () => StepSlot(WardrobeSlot.Top,     +1));
        _slotBottomValue  = AddCycleRow(L.Get("appearanceDeep.slot.bottom"),  () => StepSlot(WardrobeSlot.Bottom,  -1), () => StepSlot(WardrobeSlot.Bottom,  +1));
        _slotShoesValue   = AddCycleRow(L.Get("appearanceDeep.slot.shoes"),   () => StepSlot(WardrobeSlot.Shoes,   -1), () => StepSlot(WardrobeSlot.Shoes,   +1));
        _slotGlassesValue = AddCycleRow(L.Get("appearanceDeep.slot.glasses"), () => StepSlot(WardrobeSlot.Glasses, -1), () => StepSlot(WardrobeSlot.Glasses, +1));
        _slotHandsValue   = AddCycleRow(L.Get("appearanceDeep.slot.hands"),   () => StepSlot(WardrobeSlot.Hands,   -1), () => StepSlot(WardrobeSlot.Hands,   +1));

        Spacer(8f);
        BodyLabel(L.Get("appearanceDeep.section.wardrobe"),
            CoopMenuTheme.FontSizeBody, CoopMenuTheme.LabelTitle, TextAnchor.MiddleLeft, FontStyle.Bold);
        BodyLabel(L.Get("appearanceDeep.wardrobe.hint"),
            CoopMenuTheme.FontSizeSmall, CoopMenuTheme.LabelMuted, TextAnchor.MiddleLeft, FontStyle.Italic);

        BuildWardrobeBrowser();

        // Refresh extra-row labels with the initial config.
        RefreshExtraValues();
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Per-slot cycle
    // ─────────────────────────────────────────────────────────────────────

    private void StepSlot(WardrobeSlot slot, int delta)
    {
        Mutate(() =>
        {
            int total = CitizenWardrobeBrowser.Count;
            int current = GetSlotSource(slot);
            int currentVirtual = current == 0
                ? 0
                : 1 + System.Math.Max(0, CitizenWardrobeBrowser.IndexOfHumanId(current));

            int next = Wrap(currentVirtual + delta, total + 1);
            int newId = next == 0 ? 0 : (CitizenWardrobeBrowser.GetByIndex(next - 1)?.HumanID ?? 0);
            SetSlotSource(slot, newId);
        });
    }

    private int GetSlotSource(WardrobeSlot slot) => slot switch
    {
        WardrobeSlot.Hat     => _cfg.HatSourceHumanId,
        WardrobeSlot.Top     => _cfg.TopSourceHumanId,
        WardrobeSlot.Bottom  => _cfg.BottomSourceHumanId,
        WardrobeSlot.Shoes   => _cfg.ShoesSourceHumanId,
        WardrobeSlot.Glasses => _cfg.GlassesSourceHumanId,
        WardrobeSlot.Hands   => _cfg.HandsSourceHumanId,
        _ => 0,
    };

    private void SetSlotSource(WardrobeSlot slot, int humanId)
    {
        switch (slot)
        {
            case WardrobeSlot.Hat:     _cfg.HatSourceHumanId     = humanId; break;
            case WardrobeSlot.Top:     _cfg.TopSourceHumanId     = humanId; break;
            case WardrobeSlot.Bottom:  _cfg.BottomSourceHumanId  = humanId; break;
            case WardrobeSlot.Shoes:   _cfg.ShoesSourceHumanId   = humanId; break;
            case WardrobeSlot.Glasses: _cfg.GlassesSourceHumanId = humanId; break;
            case WardrobeSlot.Hands:   _cfg.HandsSourceHumanId   = humanId; break;
        }
    }

    private string DescribeSlotSource(int humanId)
    {
        if (humanId == 0) return L.Get("appearance.wardrobe.own");
        var entry = CitizenWardrobeBrowser.GetByHumanId(humanId);
        if (entry == null) return L.Get("appearance.wardrobe.unknown", humanId);
        return string.IsNullOrEmpty(entry.Subtitle)
            ? entry.DisplayName
            : $"{entry.DisplayName}  <i>({entry.Subtitle})</i>";
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Shoe type
    // ─────────────────────────────────────────────────────────────────────

    private const int SHOE_COUNT = 4; // normal/boots/heel/barefoot
    private void OnShoeTypeDec() => Mutate(() => _cfg.ShoeType = StepShoe(_cfg.ShoeType, -1));
    private void OnShoeTypeInc() => Mutate(() => _cfg.ShoeType = StepShoe(_cfg.ShoeType, +1));

    /// <summary>
    /// Cycles through 5 states: NoOverride → 0 (normal) → 1 (boots) →
    /// 2 (heel) → 3 (barefoot) → NoOverride. The sentinel is the leftmost
    /// position so users can always opt out of the override entirely.
    /// </summary>
    private static byte StepShoe(byte current, int delta)
    {
        // Map: 0..3 = real values; SHOE_COUNT (=4) virtual slot = "no override".
        int virt = current == AppearanceConfig.ShoeType_NoOverride ? SHOE_COUNT : current;
        int next = Wrap(virt + delta, SHOE_COUNT + 1);
        return next == SHOE_COUNT ? AppearanceConfig.ShoeType_NoOverride : (byte)next;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Grub
    // ─────────────────────────────────────────────────────────────────────

    private const int GRUB_STOPS = 9;
    private void OnGrubDec()
    {
        int step = _cfg.Grub * (GRUB_STOPS - 1) / 255;
        step = Wrap(step - 1, GRUB_STOPS);
        Mutate(() => _cfg.Grub = (byte)Mathf.RoundToInt(step * 255f / (GRUB_STOPS - 1)));
    }
    private void OnGrubInc()
    {
        int step = _cfg.Grub * (GRUB_STOPS - 1) / 255;
        step = Wrap(step + 1, GRUB_STOPS);
        Mutate(() => _cfg.Grub = (byte)Mathf.RoundToInt(step * 255f / (GRUB_STOPS - 1)));
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Wardrobe browser (scrollable list)
    // ─────────────────────────────────────────────────────────────────────

    private void BuildWardrobeBrowser()
    {
        // Outer container — fills row width with a fixed pixel height. The
        // ScrollRect inside clips and scrolls a long content list.
        var outer = CoopMenuFactory.Group("WardrobeList", Body);
        var oRt = outer.GetComponent<RectTransform>();
        oRt.sizeDelta = new(0, WARDROBE_VISIBLE_HEIGHT);
        var oLe = outer.AddComponent<LayoutElement>();
        oLe.preferredHeight = WARDROBE_VISIBLE_HEIGHT;
        oLe.flexibleWidth = 1f;

        var bg = outer.AddComponent<Image>();
        bg.color = new Color(0f, 0f, 0f, 0.18f);
        bg.raycastTarget = true;

        var scroll = outer.AddComponent<ScrollRect>();
        scroll.horizontal = false;
        scroll.vertical = true;
        scroll.movementType = ScrollRect.MovementType.Clamped;
        scroll.scrollSensitivity = 24f;

        var viewport = new GameObject("Viewport");
        viewport.transform.SetParent(outer.transform, false);
        var vRt = viewport.AddComponent<RectTransform>();
        vRt.anchorMin = Vector2.zero; vRt.anchorMax = Vector2.one;
        vRt.offsetMin = vRt.offsetMax = Vector2.zero;
        viewport.AddComponent<RectMask2D>();
        scroll.viewport = vRt;

        var content = new GameObject("Content");
        content.transform.SetParent(viewport.transform, false);
        var cRt = content.AddComponent<RectTransform>();
        cRt.anchorMin = new(0f, 1f);
        cRt.anchorMax = new(1f, 1f);
        cRt.pivot     = new(0.5f, 1f);
        cRt.anchoredPosition = Vector2.zero;
        cRt.sizeDelta = new(0, 0);

        var fitter = content.AddComponent<ContentSizeFitter>();
        fitter.verticalFit   = ContentSizeFitter.FitMode.PreferredSize;
        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;

        var stack = content.AddComponent<VerticalLayoutGroup>();
        stack.childAlignment = TextAnchor.UpperLeft;
        stack.childControlHeight = false;
        stack.childControlWidth = true;
        stack.childForceExpandHeight = false;
        stack.childForceExpandWidth = true;
        stack.spacing = 2f;
        stack.padding = new RectOffset(4, 4, 4, 4);

        scroll.content = cRt;
        _wardrobeListGo = content;

        PopulateWardrobe();
    }

    private void PopulateWardrobe()
    {
        if (_wardrobeListGo == null) return;
        // Wipe old rows.
        for (int i = _wardrobeListGo.transform.childCount - 1; i >= 0; i--)
            UnityEngine.Object.Destroy(_wardrobeListGo.transform.GetChild(i).gameObject);
        _wardrobeRows.Clear();

        // Row 0 — "use own outfit" sentinel.
        AddWardrobeRow(0, L.Get("appearance.wardrobe.own"), null);

        var all = CitizenWardrobeBrowser.All;
        for (int i = 0; i < all.Count; i++)
        {
            var entry = all[i];
            string text = string.IsNullOrEmpty(entry.Subtitle)
                ? entry.DisplayName
                : $"{entry.DisplayName}  <color=#888><size=11>{entry.Subtitle}</size></color>";
            AddWardrobeRow(entry.HumanID, text, entry);
        }

        RefreshWardrobeMarkers();
    }

    private void AddWardrobeRow(int humanId, string label, CitizenWardrobeBrowser.Entry entry)
    {
        var row = CoopMenuFactory.Group($"WRow_{humanId}", _wardrobeListGo.transform);
        var rt = row.GetComponent<RectTransform>();
        rt.sizeDelta = new(0, WARDROBE_ROW_HEIGHT);
        var le = row.AddComponent<LayoutElement>();
        le.preferredHeight = WARDROBE_ROW_HEIGHT;
        le.flexibleWidth = 1f;

        var rowBg = row.AddComponent<Image>();
        rowBg.color = new Color(0.10f, 0.12f, 0.16f, 0.0f); // marker for selected row
        rowBg.raycastTarget = true;

        var btn = row.AddComponent<Button>();
        var colors = btn.colors;
        colors.normalColor      = new Color(1f, 1f, 1f, 1f);
        colors.highlightedColor = new Color(1f, 1f, 1f, 0.6f);
        colors.pressedColor     = new Color(1f, 1f, 1f, 0.45f);
        btn.colors = colors;
        btn.targetGraphic = rowBg;
        btn.onClick.AddListener((UnityEngine.Events.UnityAction)(() => OnPickWardrobe(humanId)));

        var hl = row.AddComponent<HorizontalLayoutGroup>();
        hl.childAlignment = TextAnchor.MiddleLeft;
        hl.childControlHeight = true;
        hl.childControlWidth = true;
        hl.childForceExpandHeight = true;
        hl.childForceExpandWidth = true;
        hl.spacing = 6f;
        hl.padding = new RectOffset(8, 8, 0, 0);

        var labelGo = new GameObject("Label");
        labelGo.transform.SetParent(row.transform, false);
        var lRt = labelGo.AddComponent<RectTransform>();
        var lblText = labelGo.AddComponent<Text>();
        lblText.font = CoopMenuTheme.GetFont();
        lblText.fontSize = CoopMenuTheme.FontSizeSmall;
        lblText.color = CoopMenuTheme.LabelBody;
        lblText.alignment = TextAnchor.MiddleLeft;
        lblText.text = label;
        lblText.supportRichText = true;
        lblText.raycastTarget = false;

        _wardrobeRows.Add((humanId, lblText, rowBg));
    }

    private void OnPickWardrobe(int humanId)
    {
        Mutate(() => _cfg.WardrobeSourceHumanId = humanId);
        RefreshWardrobeMarkers();
    }

    private void RefreshWardrobeMarkers()
    {
        for (int i = 0; i < _wardrobeRows.Count; i++)
        {
            var (id, _, marker) = _wardrobeRows[i];
            bool selected = id == _cfg.WardrobeSourceHumanId;
            if (marker != null)
                marker.color = selected ? new Color(0.20f, 0.60f, 0.95f, 0.55f) : new Color(0.10f, 0.12f, 0.16f, 0.0f);
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Refresh
    // ─────────────────────────────────────────────────────────────────────

    protected override void RefreshAllValues()
    {
        base.RefreshAllValues();
        RefreshExtraValues();
    }

    private void RefreshExtraValues()
    {
        if (_shoeTypeValue != null)
        {
            if (_cfg.ShoeType == AppearanceConfig.ShoeType_NoOverride)
                _shoeTypeValue.text = L.Get("appearanceDeep.shoeType.default");
            else
                _shoeTypeValue.text = L.Get($"appearanceDeep.shoeType.{((global::Human.ShoeType)_cfg.ShoeType).ToString().ToLowerInvariant()}");
        }
        if (_grubValue != null)
        {
            int step = _cfg.Grub * (GRUB_STOPS - 1) / 255;
            _grubValue.text = L.Get("appearanceDeep.grub.value", step, GRUB_STOPS - 1);
        }
        if (_slotHatValue     != null) _slotHatValue    .text = DescribeSlotSource(_cfg.HatSourceHumanId);
        if (_slotTopValue     != null) _slotTopValue    .text = DescribeSlotSource(_cfg.TopSourceHumanId);
        if (_slotBottomValue  != null) _slotBottomValue .text = DescribeSlotSource(_cfg.BottomSourceHumanId);
        if (_slotShoesValue   != null) _slotShoesValue  .text = DescribeSlotSource(_cfg.ShoesSourceHumanId);
        if (_slotGlassesValue != null) _slotGlassesValue.text = DescribeSlotSource(_cfg.GlassesSourceHumanId);
        if (_slotHandsValue   != null) _slotHandsValue  .text = DescribeSlotSource(_cfg.HandsSourceHumanId);
        RefreshWardrobeMarkers();
    }

    public override void Show()
    {
        base.Show();
        // Wardrobe list is rebuilt on every Show so it picks up city changes
        // (citizens spawning / despawning between sessions).
        if (_wardrobeListGo != null) PopulateWardrobe();
    }
}
