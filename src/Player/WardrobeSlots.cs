using System;
using System.Collections.Generic;

namespace SoDCoop.Player;

/// <summary>
/// Coarse-grained wardrobe slot — a logical group of
/// <see cref="global::CitizenOutfitController.CharacterAnchor"/> positions
/// the player can swap as a unit. SoD's outfit system stores clothing as
/// per-anchor mesh attachments; we group those into 6 conceptual slots so
/// the deep customization UI doesn't have to expose the full 21-anchor
/// matrix.
///
/// <para>The deep panel renders one cycle row per slot and stores the
/// chosen source citizen's humanID in the matching
/// <c>AppearanceConfig.&lt;Slot&gt;SourceHumanId</c> field.</para>
/// </summary>
public enum WardrobeSlot
{
    Hat,
    Top,
    Bottom,
    Shoes,
    Glasses,
    Hands,
    Hair,
}

/// <summary>
/// Static helpers for resolving <see cref="WardrobeSlot"/> → covered
/// anchors and for splicing one citizen's per-slot clothing onto another
/// citizen's outfit. Used by <see cref="AppearanceConfig.ApplyTo"/> and
/// the deep customization panel.
/// </summary>
public static class WardrobeSlots
{
    public static readonly WardrobeSlot[] All =
    {
        WardrobeSlot.Hat,
        WardrobeSlot.Top,
        WardrobeSlot.Bottom,
        WardrobeSlot.Shoes,
        WardrobeSlot.Glasses,
        WardrobeSlot.Hands,
        WardrobeSlot.Hair,
    };

    /// <summary>Anchor positions a slot is responsible for. Multi-anchor
    /// slots like Top cover the whole upper body (torso + arms) so a
    /// borrowed shirt doesn't leave a sleeveless mismatch with the
    /// citizen's own arms.</summary>
    public static IReadOnlyList<global::CitizenOutfitController.CharacterAnchor> AnchorsFor(WardrobeSlot slot)
        => slot switch
        {
            WardrobeSlot.Hat     => _hat,
            WardrobeSlot.Top     => _top,
            WardrobeSlot.Bottom  => _bottom,
            WardrobeSlot.Shoes   => _shoes,
            WardrobeSlot.Glasses => _glasses,
            WardrobeSlot.Hands   => _hands,
            WardrobeSlot.Hair    => _hair,
            _                    => System.Array.Empty<global::CitizenOutfitController.CharacterAnchor>(),
        };

    private static readonly global::CitizenOutfitController.CharacterAnchor[] _hat =
    {
        global::CitizenOutfitController.CharacterAnchor.Hat,
    };

    private static readonly global::CitizenOutfitController.CharacterAnchor[] _top =
    {
        global::CitizenOutfitController.CharacterAnchor.upperTorso,
        global::CitizenOutfitController.CharacterAnchor.UpperArmRight,
        global::CitizenOutfitController.CharacterAnchor.UpperArmLeft,
        global::CitizenOutfitController.CharacterAnchor.LowerArmRight,
        global::CitizenOutfitController.CharacterAnchor.LowerArmLeft,
        global::CitizenOutfitController.CharacterAnchor.Midriff,
    };

    private static readonly global::CitizenOutfitController.CharacterAnchor[] _bottom =
    {
        global::CitizenOutfitController.CharacterAnchor.lowerTorso,
        global::CitizenOutfitController.CharacterAnchor.UpperLegRight,
        global::CitizenOutfitController.CharacterAnchor.UpperLegLeft,
        global::CitizenOutfitController.CharacterAnchor.LowerLegRight,
        global::CitizenOutfitController.CharacterAnchor.LowerLegLeft,
    };

    private static readonly global::CitizenOutfitController.CharacterAnchor[] _shoes =
    {
        global::CitizenOutfitController.CharacterAnchor.RightFoot,
        global::CitizenOutfitController.CharacterAnchor.LeftFoot,
    };

    private static readonly global::CitizenOutfitController.CharacterAnchor[] _glasses =
    {
        global::CitizenOutfitController.CharacterAnchor.Glasses,
    };

    private static readonly global::CitizenOutfitController.CharacterAnchor[] _hands =
    {
        global::CitizenOutfitController.CharacterAnchor.HandRight,
        global::CitizenOutfitController.CharacterAnchor.HandLeft,
    };

    private static readonly global::CitizenOutfitController.CharacterAnchor[] _hair =
    {
        global::CitizenOutfitController.CharacterAnchor.Hair,
    };

    /// <summary>
    /// Apply per-slot wardrobe override: copy the source citizen's clothing
    /// items that cover any anchor in <paramref name="slot"/> onto
    /// <paramref name="targetCtrl"/>'s outfit for the same category,
    /// removing target items currently occupying those anchors first.
    ///
    /// <para>No-op on any resolution failure (missing citizen, missing
    /// outfit, missing ClothesPreset). The OutfitClothes objects are
    /// shared by reference rather than deep-cloned — this matches vanilla
    /// SoD's <c>SetCurrentOutfit</c> semantics, where the loader treats
    /// the list as immutable data; SoD never mutates an OutfitClothes'
    /// fields, only reads them to spawn meshes.</para>
    /// </summary>
    public static void ApplySlotBorrow(global::CitizenOutfitController targetCtrl,
                                       global::ClothesPreset.OutfitCategory category,
                                       WardrobeSlot slot,
                                       int sourceHumanId)
    {
        if (sourceHumanId == 0) return;
        if (targetCtrl == null) return;

        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(sourceHumanId, out var src) || src == null) return;
            var srcCtrl = src.outfitController;
            if (srcCtrl == null || srcCtrl.outfits == null) return;

            var anchors = AnchorsFor(slot);
            if (anchors == null || anchors.Count == 0) return;

            // Find source + target outfit slots for the requested category.
            var srcOutfit = FindOutfit(srcCtrl, category);
            var tgtOutfit = FindOutfit(targetCtrl, category);
            if (srcOutfit == null || srcOutfit.clothes == null) return;
            if (tgtOutfit == null || tgtOutfit.clothes == null) return;

            // Make sure tgtOutfit.clothes is a list we own — if it's still
            // pointing at another citizen's list (legacy whole-outfit
            // borrow), clone it so per-slot mutations don't bleed onto the
            // donor citizen's wardrobe.
            tgtOutfit.clothes = CloneClothesList(tgtOutfit.clothes);

            // Remove target items whose preset covers any of our slot anchors.
            for (int i = tgtOutfit.clothes.Count - 1; i >= 0; i--)
            {
                var oc = tgtOutfit.clothes[i];
                if (oc == null) continue;
                if (CoversAny(oc, anchors))
                {
                    tgtOutfit.clothes.RemoveAt(i);
                }
            }

            // Add matching source items (shared by reference; SoD's loader
            // treats OutfitClothes as immutable data).
            for (int i = 0; i < srcOutfit.clothes.Count; i++)
            {
                var oc = srcOutfit.clothes[i];
                if (oc == null) continue;
                if (CoversAny(oc, anchors))
                {
                    tgtOutfit.clothes.Add(oc);
                }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"WardrobeSlots.ApplySlotBorrow(slot={slot}, src={sourceHumanId}, cat={category}): {ex.Message}");
        }
    }

    /// <summary>True iff the OutfitClothes' resolved ClothesPreset covers
    /// any anchor in the slot. Toolbox.Instance.clothesDictionary is the
    /// global string→preset registry; it's populated by SoD before any
    /// citizen exists, so a Toolbox-null lookup means the game hasn't
    /// finished bootstrapping.</summary>
    private static bool CoversAny(global::CitizenOutfitController.OutfitClothes oc,
                                  IReadOnlyList<global::CitizenOutfitController.CharacterAnchor> anchors)
    {
        try
        {
            string name = oc.clothes;
            if (string.IsNullOrEmpty(name)) return false;

            var dict = global::Toolbox.Instance?.clothesDictionary;
            if (dict == null) return false;

            global::ClothesPreset preset = null;
            try { dict.TryGetValue(name, out preset); } catch { }
            if (preset == null) return false;

            var covers = preset.covers;
            if (covers == null || covers.Count == 0) return false;
            for (int i = 0; i < covers.Count; i++)
            {
                var c = covers[i];
                for (int j = 0; j < anchors.Count; j++)
                {
                    if (anchors[j] == c) return true;
                }
            }
        }
        catch { }
        return false;
    }

    private static global::CitizenOutfitController.Outfit FindOutfit(global::CitizenOutfitController ctrl,
                                                                     global::ClothesPreset.OutfitCategory category)
    {
        if (ctrl?.outfits == null) return null;
        for (int i = 0; i < ctrl.outfits.Count; i++)
        {
            var o = ctrl.outfits[i];
            if (o != null && o.category == category) return o;
        }
        return null;
    }

    /// <summary>Shallow-clone the IL2CPP list so mutations stay scoped to
    /// the target outfit. We can't blindly use <c>System.Collections.Generic.List</c>
    /// because the source field is an IL2CPP <c>List&lt;OutfitClothes&gt;</c>;
    /// rebuilding via the same generic preserves the underlying type.</summary>
    private static Il2CppSystem.Collections.Generic.List<global::CitizenOutfitController.OutfitClothes>
        CloneClothesList(Il2CppSystem.Collections.Generic.List<global::CitizenOutfitController.OutfitClothes> src)
    {
        var copy = new Il2CppSystem.Collections.Generic.List<global::CitizenOutfitController.OutfitClothes>();
        if (src == null) return copy;
        for (int i = 0; i < src.Count; i++) copy.Add(src[i]);
        return copy;
    }
}
