using System;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Player-chosen appearance customization for the twin citizen. Wire-format
/// is 7 bytes (6 enum bytes + 1 lipstick byte 0..255). We don't ship raw
/// <c>Color</c> values — instead we transmit indices into ScriptableObject
/// palettes that <c>SocialStatistics.Instance</c> exposes (HairSetting per
/// HairColour enum, EthnicityStats per EthnicGroup), and resolve the actual
/// RGB on the receiver. The palette ScriptableObjects are baked into the
/// game build, so every peer resolves the same Color from the same byte.
///
/// <para>Applied via <see cref="ApplyTo"/> to a <c>CitizenOutfitController</c>
/// — sets the 9 <c>debugOverride*</c> fields plus the master switch and
/// calls <c>LoadCurrentOutfit(forceLoad: true)</c> to rebuild the visual.</para>
/// </summary>
public struct AppearanceConfig
{
    public byte Gender;       // global::Human.Gender
    public byte Build;        // Descriptors.BuildType
    public byte HairStyle;    // Descriptors.HairStyle
    public byte HairColour;   // Descriptors.HairColour (also: palette index for hairColourSettings)
    public byte EyeColour;    // Descriptors.EyeColour
    public byte SkinIndex;    // index into SocialStatistics.ethnicityStats (skin tone proxy)
    public byte Expression;   // CitizenOutfitController.Expression
    public byte Lipstick;     // 0..255 → 0..1f
    public byte Outfit;       // ClothesPreset.OutfitCategory — picks from citizen's pre-generated wardrobe
    /// <summary>Shoe variant pinned via CitizenOutfitController.debugOverrideShoeType.
    /// 0=normal, 1=boots, 2=heel, 3=barefoot. Sentinel 0xFF = "leave default"
    /// so the basic AppearancePanel doesn't override what the user only
    /// touched in the deep panel.</summary>
    public byte ShoeType;
    /// <summary>Grime / dirt level forwarded to debugOverrideGrub (0..1f).
    /// Stored as 0..255 on the wire to match Lipstick's encoding.</summary>
    public byte Grub;

    /// <summary>HumanID of a citizen whose wardrobe to borrow for the
    /// current <see cref="Outfit"/> category. 0 = use the twin's own
    /// procedural wardrobe (vanilla behaviour).
    ///
    /// <para>SoD has ~300 citizens × 9 outfit categories worth of
    /// wardrobe combinations baked at city-gen time. By pointing here at
    /// any citizen by humanID, the twin renders that citizen's clothes
    /// list for the chosen category — which gives massive visual variety
    /// without requiring a per-mesh editor.</para>
    ///
    /// <para>Applied as the FIRST step in <see cref="ApplyTo"/>; the per-slot
    /// source fields below then surgically override individual anchor groups
    /// on top of that base. Both can be used together: legacy field picks
    /// the broad outfit, per-slot fields swap out specific items.</para></summary>
    public int WardrobeSourceHumanId;

    /// <summary>Per-slot wardrobe sources — each picks a citizen whose
    /// clothing item(s) covering that slot's <see cref="WardrobeSlot"/>
    /// anchor group are spliced into the twin's outfit on top of the
    /// legacy whole-outfit borrow. Zero = no override for this slot
    /// (whatever is already there from the twin's own outfit / legacy
    /// borrow stays). Resolved by <see cref="ApplyTo"/> via the global
    /// <c>Toolbox.Instance.clothesDictionary</c>.</summary>
    public int HatSourceHumanId;
    public int TopSourceHumanId;
    public int BottomSourceHumanId;
    public int ShoesSourceHumanId;
    public int GlassesSourceHumanId;
    public int HandsSourceHumanId;

    public bool IsCustomized;

    /// <summary>Bytes written by <see cref="Write"/>. Receivers tolerate
    /// shorter payloads (legacy records) by defaulting trailing fields.</summary>
    public const int WireSize = 1 /*flag*/ + 9 + 4 /*WardrobeSourceHumanId*/ + 2 /*ShoeType+Grub*/ + 24 /*6 per-slot ints*/;
    public const int LegacyMinWireSize = 1 /*flag*/ + 8;

    /// <summary>Sentinel for <see cref="ShoeType"/> meaning "do not override
    /// — let the citizen's procedural shoe pick stand". 0xFF picked so the
    /// real shoe enum (0..3) never collides.</summary>
    public const byte ShoeType_NoOverride = 0xFF;

    public static AppearanceConfig Default => new()
    {
        Gender       = (byte)global::Human.Gender.male,
        Build        = (byte)global::Descriptors.BuildType.average,
        HairStyle    = (byte)global::Descriptors.HairStyle.shortHair,
        HairColour   = (byte)global::Descriptors.HairColour.brown,
        EyeColour    = (byte)global::Descriptors.EyeColour.brownEyes,
        SkinIndex    = 0,
        Expression   = (byte)global::CitizenOutfitController.Expression.neutral,
        Lipstick     = 0,
        Outfit       = (byte)global::ClothesPreset.OutfitCategory.casual,
        ShoeType     = ShoeType_NoOverride,
        Grub         = 0,
        IsCustomized = false,
    };

    // ─────────────────────────────────────────────────────────────────────
    //  Wire serialization (hand-written — used in CharacterStore base64 too)
    // ─────────────────────────────────────────────────────────────────────

    public void Write(NetDataWriter w)
    {
        w.Put(IsCustomized);
        w.Put(Gender);
        w.Put(Build);
        w.Put(HairStyle);
        w.Put(HairColour);
        w.Put(EyeColour);
        w.Put(SkinIndex);
        w.Put(Expression);
        w.Put(Lipstick);
        w.Put(Outfit);
        w.Put(WardrobeSourceHumanId);
        w.Put(ShoeType);
        w.Put(Grub);
        w.Put(HatSourceHumanId);
        w.Put(TopSourceHumanId);
        w.Put(BottomSourceHumanId);
        w.Put(ShoesSourceHumanId);
        w.Put(GlassesSourceHumanId);
        w.Put(HandsSourceHumanId);
    }

    public void Read(NetDataReader r)
    {
        IsCustomized = r.GetBool();
        Gender       = r.GetByte();
        Build        = r.GetByte();
        HairStyle    = r.GetByte();
        HairColour   = r.GetByte();
        EyeColour    = r.GetByte();
        SkinIndex    = r.GetByte();
        Expression   = r.GetByte();
        Lipstick     = r.GetByte();
        // Optional trailing fields — legacy payloads default these.
        Outfit                 = r.AvailableBytes > 0 ? r.GetByte() : (byte)global::ClothesPreset.OutfitCategory.casual;
        WardrobeSourceHumanId  = r.AvailableBytes >= 4 ? r.GetInt()  : 0;
        ShoeType               = r.AvailableBytes > 0 ? r.GetByte() : ShoeType_NoOverride;
        Grub                   = r.AvailableBytes > 0 ? r.GetByte() : (byte)0;
        // Per-slot source citizens (6 × int, all default 0).
        HatSourceHumanId       = r.AvailableBytes >= 4 ? r.GetInt() : 0;
        TopSourceHumanId       = r.AvailableBytes >= 4 ? r.GetInt() : 0;
        BottomSourceHumanId    = r.AvailableBytes >= 4 ? r.GetInt() : 0;
        ShoesSourceHumanId     = r.AvailableBytes >= 4 ? r.GetInt() : 0;
        GlassesSourceHumanId   = r.AvailableBytes >= 4 ? r.GetInt() : 0;
        HandsSourceHumanId     = r.AvailableBytes >= 4 ? r.GetInt() : 0;
    }

    public byte[] ToBytes()
    {
        var w = new NetDataWriter(true, WireSize);
        Write(w);
        var data = new byte[w.Length];
        Buffer.BlockCopy(w.Data, 0, data, 0, w.Length);
        return data;
    }

    public static AppearanceConfig FromBytes(byte[] bytes)
    {
        if (bytes == null || bytes.Length < LegacyMinWireSize) return Default;
        var r = new NetDataReader(bytes);
        var c = new AppearanceConfig();
        c.Read(r);
        return c;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Apply
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Stamps the 9 debug-override fields onto a <c>CitizenOutfitController</c>
    /// and rebuilds the visual. No-op if <see cref="IsCustomized"/> is false
    /// (the controller falls back to vanilla seeded generation).
    /// </summary>
    public void ApplyTo(global::CitizenOutfitController ctrl)
    {
        if (ctrl == null) return;
        try
        {
            if (!IsCustomized)
            {
                ctrl.debugOverride = false;
                return;
            }

            ctrl.debugOverride         = true;
            ctrl.debugOverrideGender   = (global::Human.Gender)Gender;
            ctrl.debugOverrideBuild    = (global::Descriptors.BuildType)Build;
            ctrl.debugOverrideHair     = (global::Descriptors.HairStyle)HairStyle;
            ctrl.debugOverrideEyeColour = (global::Descriptors.EyeColour)EyeColour;
            ctrl.debugOverrideExpression = (global::CitizenOutfitController.Expression)Expression;
            ctrl.debugOverrideHairColour = AppearancePalette.HairColourFor((global::Descriptors.HairColour)HairColour);
            ctrl.debugOverrideSkinColour = AppearancePalette.SkinColourFor(SkinIndex);
            ctrl.debugOverrideLipstick  = Lipstick / 255f;
            ctrl.debugOverrideGrub      = Grub / 255f;
            // ShoeType: only override when the deep panel set a real value;
            // 0xFF leaves the citizen's procedural pick alone.
            if (ShoeType != ShoeType_NoOverride)
                ctrl.debugOverrideShoeType = (global::Human.ShoeType)ShoeType;

            // SetCurrentOutfit picks the citizen's pre-generated outfit for
            // the requested category and triggers LoadCurrentOutfit internally
            // — covers both clothing swap and rebuild of body / hair visuals
            // in one call. forceLoad=true ensures we rebuild even if the
            // category is already current.
            var category = (global::ClothesPreset.OutfitCategory)Outfit;

            // Wardrobe-source override: if the player picked a "borrow this
            // citizen's wardrobe" entry, splice that citizen's clothes list
            // for the target category onto our twin's outfit slot before the
            // SetCurrentOutfit reload. SoD's loader reads OutfitClothes by
            // value (preset name + colors) — sharing the list between
            // citizens is safe; visuals spawn on whoever calls LoadCurrentOutfit.
            if (WardrobeSourceHumanId > 0)
                TryBorrowWardrobe(ctrl, category, WardrobeSourceHumanId);

            // Per-slot wardrobe overrides — applied AFTER the legacy whole-
            // outfit borrow so the player can pick a base outfit and then
            // surgically swap individual items (e.g. "borrow Sarah's coat
            // but use John's hat"). Each slot resolves its source citizen's
            // clothing items covering that anchor group and splices them
            // onto the twin's outfit; details in WardrobeSlots.ApplySlotBorrow.
            WardrobeSlots.ApplySlotBorrow(ctrl, category, WardrobeSlot.Hat,     HatSourceHumanId);
            WardrobeSlots.ApplySlotBorrow(ctrl, category, WardrobeSlot.Top,     TopSourceHumanId);
            WardrobeSlots.ApplySlotBorrow(ctrl, category, WardrobeSlot.Bottom,  BottomSourceHumanId);
            WardrobeSlots.ApplySlotBorrow(ctrl, category, WardrobeSlot.Shoes,   ShoesSourceHumanId);
            WardrobeSlots.ApplySlotBorrow(ctrl, category, WardrobeSlot.Glasses, GlassesSourceHumanId);
            WardrobeSlots.ApplySlotBorrow(ctrl, category, WardrobeSlot.Hands,   HandsSourceHumanId);

            ctrl.SetCurrentOutfit(category, /*forceLoad:*/ true, /*forceReload:*/ true, /*ignoreIfDead:*/ true);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"AppearanceConfig.ApplyTo: {ex.GetType().Name}: {ex.Message}");
        }
    }

    /// <summary>
    /// Look up <paramref name="sourceHumanId"/> in the city, copy their
    /// <c>outfits[category].clothes</c> list onto <paramref name="targetCtrl"/>'s
    /// outfit slot for the same category. Idempotent / no-op on any
    /// resolution failure.
    /// </summary>
    private static void TryBorrowWardrobe(global::CitizenOutfitController targetCtrl,
                                           global::ClothesPreset.OutfitCategory category,
                                           int sourceHumanId)
    {
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(sourceHumanId, out var src) || src == null) return;
            var srcCtrl = src.outfitController;
            if (srcCtrl == null || srcCtrl.outfits == null) return;

            global::CitizenOutfitController.Outfit srcOutfit = null;
            for (int i = 0; i < srcCtrl.outfits.Count; i++)
            {
                var o = srcCtrl.outfits[i];
                if (o != null && o.category == category) { srcOutfit = o; break; }
            }
            if (srcOutfit == null || srcOutfit.clothes == null) return;

            if (targetCtrl.outfits == null) return;
            global::CitizenOutfitController.Outfit tgtOutfit = null;
            for (int i = 0; i < targetCtrl.outfits.Count; i++)
            {
                var o = targetCtrl.outfits[i];
                if (o != null && o.category == category) { tgtOutfit = o; break; }
            }
            if (tgtOutfit == null) return;

            tgtOutfit.clothes = srcOutfit.clothes;   // share by reference; SoD treats it as data
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"TryBorrowWardrobe(src={sourceHumanId}, cat={category}): {ex.Message}");
        }
    }
}

/// <summary>
/// Resolves <see cref="AppearanceConfig"/> indices to actual <c>Color</c>
/// values via <c>SocialStatistics.Instance</c>. The underlying lists are
/// ScriptableObjects baked into the game, so every peer (host + clients)
/// resolves the same byte to the same RGB.
/// </summary>
public static class AppearancePalette
{
    /// <summary>
    /// Number of distinct skin tones the player can pick. Aligns with the
    /// number of <c>EthnicityStats</c> entries (17). Capped at 32 in case
    /// SoD adds more — we never want a byte overflow.
    /// </summary>
    public static int SkinPaletteSize
    {
        get
        {
            try
            {
                var ss = global::SocialStatistics.Instance;
                var list = ss?.ethnicityStats;
                if (list == null) return 17;
                return Mathf.Min(list.Count, 32);
            }
            catch { return 17; }
        }
    }

    /// <summary>How many <c>HairColour</c> swatches the UI should show.</summary>
    public const int HairPaletteSize = 11;

    /// <summary>Resolves the swatch shown in the UI for a hair colour byte.</summary>
    public static Color HairColourFor(global::Descriptors.HairColour hc)
    {
        try
        {
            var ss = global::SocialStatistics.Instance;
            var settings = ss?.hairColourSettings;
            if (settings != null)
            {
                for (int i = 0; i < settings.Count; i++)
                {
                    var s = settings[i];
                    if (s != null && s.colour == hc)
                        return s.hairColourRange1;
                }
            }
        }
        catch { }

        // Fallback table — used pre-Toolbox boot and on resolution failure.
        return hc switch
        {
            global::Descriptors.HairColour.black  => new Color(0.10f, 0.08f, 0.07f),
            global::Descriptors.HairColour.brown  => new Color(0.35f, 0.22f, 0.13f),
            global::Descriptors.HairColour.blonde => new Color(0.92f, 0.82f, 0.55f),
            global::Descriptors.HairColour.ginger => new Color(0.78f, 0.42f, 0.18f),
            global::Descriptors.HairColour.red    => new Color(0.66f, 0.18f, 0.14f),
            global::Descriptors.HairColour.blue   => new Color(0.28f, 0.42f, 0.78f),
            global::Descriptors.HairColour.green  => new Color(0.30f, 0.62f, 0.32f),
            global::Descriptors.HairColour.purple => new Color(0.55f, 0.30f, 0.65f),
            global::Descriptors.HairColour.pink   => new Color(0.92f, 0.55f, 0.72f),
            global::Descriptors.HairColour.grey   => new Color(0.60f, 0.60f, 0.60f),
            global::Descriptors.HairColour.white  => new Color(0.92f, 0.92f, 0.92f),
            _ => new Color(0.35f, 0.22f, 0.13f),
        };
    }

    /// <summary>Resolves the skin-tone swatch byte (index into ethnicityStats).</summary>
    public static Color SkinColourFor(byte idx)
    {
        try
        {
            var ss = global::SocialStatistics.Instance;
            var list = ss?.ethnicityStats;
            if (list != null && list.Count > 0)
            {
                int i = Mathf.Clamp(idx, 0, list.Count - 1);
                var stats = list[i];
                if (stats != null) return stats.skinColourRange1;
            }
        }
        catch { }

        // Fallback ladder of 8 plausible skin tones.
        var fallback = new[]
        {
            new Color(0.97f, 0.85f, 0.74f),
            new Color(0.94f, 0.79f, 0.65f),
            new Color(0.86f, 0.69f, 0.54f),
            new Color(0.78f, 0.59f, 0.43f),
            new Color(0.66f, 0.47f, 0.31f),
            new Color(0.52f, 0.35f, 0.22f),
            new Color(0.40f, 0.27f, 0.17f),
            new Color(0.28f, 0.18f, 0.12f),
        };
        return fallback[Mathf.Clamp(idx, 0, fallback.Length - 1)];
    }
}
