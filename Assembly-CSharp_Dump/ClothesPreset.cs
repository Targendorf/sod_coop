using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ClothesPreset : SoCustomComparison
{
	[System.Serializable]
	public class MaterialSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_colour;

		private static readonly System.IntPtr NativeFieldInfoPtr_weighting;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Color colour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)) = color;
			}
		}

		public unsafe int weighting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weighting);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weighting)) = num;
			}
		}

		static MaterialSettings()
		{
			Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "MaterialSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr);
			NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, "colour");
			NativeFieldInfoPtr_weighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, "weighting");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, 100673846);
		}

		[CallerCount(0)]
		public unsafe MaterialSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaterialSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ModelSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_anchor;

		private static readonly System.IntPtr NativeFieldInfoPtr_offsetPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_offsetEuler;

		private static readonly System.IntPtr NativeFieldInfoPtr_exclusiveAnchorModel;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe GameObject prefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe CitizenOutfitController.CharacterAnchor anchor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor);
				return *(CitizenOutfitController.CharacterAnchor*)num;
			}
			set
			{
				*(CitizenOutfitController.CharacterAnchor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor)) = characterAnchor;
			}
		}

		public unsafe Vector3 offsetPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetPosition)) = vector;
			}
		}

		public unsafe Vector3 offsetEuler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetEuler);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetEuler)) = vector;
			}
		}

		public unsafe bool exclusiveAnchorModel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exclusiveAnchorModel);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exclusiveAnchorModel)) = flag;
			}
		}

		static ModelSettings()
		{
			Il2CppClassPointerStore<ModelSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "ModelSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr);
			NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr, "prefab");
			NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr, "anchor");
			NativeFieldInfoPtr_offsetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr, "offsetPosition");
			NativeFieldInfoPtr_offsetEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr, "offsetEuler");
			NativeFieldInfoPtr_exclusiveAnchorModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr, "exclusiveAnchorModel");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr, 100673847);
		}

		[CallerCount(0)]
		public unsafe ModelSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ModelSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum OutfitCategory
	{
		casual,
		work,
		smart,
		outdoorsCasual,
		outdoorsWork,
		outdoorsSmart,
		undressed,
		bed,
		underwear
	}

	public enum ClothingColourSource
	{
		none,
		garment,
		skin,
		white,
		hair,
		underneathColour1,
		underneathColour2,
		underneathColour3,
		workUniformColour
	}

	public enum ClothesTags
	{
		longGarment,
		noLongGarments
	}

	public enum HairRenderSetting
	{
		renderHatCompatibleHair,
		renderAllHair,
		dontRenderAnyHair
	}

	public enum Incompatibility
	{
		inAnyCategory,
		inThisCategory
	}

	[System.Serializable]
	public class IncompatibilitySetting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_incompatibleIf;

		private static readonly System.IntPtr NativeFieldInfoPtr_tags;

		private static readonly System.IntPtr NativeFieldInfoPtr_featured;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Incompatibility incompatibleIf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incompatibleIf);
				return *(Incompatibility*)num;
			}
			set
			{
				*(Incompatibility*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incompatibleIf)) = incompatibility;
			}
		}

		public unsafe List<ClothesTags> tags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesTags>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe ClothesPreset featured
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featured);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClothesPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featured)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clothesPreset));
			}
		}

		static IncompatibilitySetting()
		{
			Il2CppClassPointerStore<IncompatibilitySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "IncompatibilitySetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncompatibilitySetting>.NativeClassPtr);
			NativeFieldInfoPtr_incompatibleIf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncompatibilitySetting>.NativeClassPtr, "incompatibleIf");
			NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncompatibilitySetting>.NativeClassPtr, "tags");
			NativeFieldInfoPtr_featured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncompatibilitySetting>.NativeClassPtr, "featured");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncompatibilitySetting>.NativeClassPtr, 100673848);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncompatibilitySetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncompatibilitySetting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IncompatibilitySetting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class TraitPickRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_addChance;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CharacterTrait.RuleType rule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule);
				return *(CharacterTrait.RuleType*)num;
			}
			set
			{
				*(CharacterTrait.RuleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule)) = ruleType;
			}
		}

		public unsafe List<CharacterTrait> traitList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool mustPassForApplication
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustPassForApplication);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustPassForApplication)) = flag;
			}
		}

		public unsafe int addChance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addChance);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addChance)) = num;
			}
		}

		static TraitPickRule()
		{
			Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "TraitPickRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_addChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "addChance");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, 100673849);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327861, XrefRangeEnd = 327867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraitPickRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TraitPickRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_covers;

	private static readonly System.IntPtr NativeFieldInfoPtr_outfitCategories;

	private static readonly System.IntPtr NativeFieldInfoPtr_suitableForGenders;

	private static readonly System.IntPtr NativeFieldInfoPtr_suitableForBuilds;

	private static readonly System.IntPtr NativeFieldInfoPtr_tags;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFacialFeatureSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_suitableForHairstyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_pupilsOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowsOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouthOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_hatRenderCompatible;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeHats;

	private static readonly System.IntPtr NativeFieldInfoPtr_hairRenderMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_setFootwear;

	private static readonly System.IntPtr NativeFieldInfoPtr_footwear;

	private static readonly System.IntPtr NativeFieldInfoPtr_priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyChooseIfAllModelPartsAreAvailable;

	private static readonly System.IntPtr NativeFieldInfoPtr_incompatibility;

	private static readonly System.IntPtr NativeFieldInfoPtr_useWealthValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseColourSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_colourBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_colour1Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_colour1;

	private static readonly System.IntPtr NativeFieldInfoPtr_colour2Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_colour2;

	private static readonly System.IntPtr NativeFieldInfoPtr_colour3Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_colour3;

	private static readonly System.IntPtr NativeFieldInfoPtr_includeInPersonalityMatching;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_useHEXACO;

	private static readonly System.IntPtr NativeFieldInfoPtr_hexaco;

	private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_models;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<CitizenOutfitController.CharacterAnchor> covers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_covers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitizenOutfitController.CharacterAnchor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_covers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<OutfitCategory> outfitCategories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitCategories);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OutfitCategory>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitCategories)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Human.Gender> suitableForGenders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suitableForGenders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.Gender>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suitableForGenders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Descriptors.BuildType> suitableForBuilds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suitableForBuilds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Descriptors.BuildType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suitableForBuilds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ClothesTags> tags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesTags>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool enableFacialFeatureSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFacialFeatureSetup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFacialFeatureSetup)) = flag;
		}
	}

	public unsafe List<Descriptors.HairStyle> suitableForHairstyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suitableForHairstyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Descriptors.HairStyle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suitableForHairstyle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool isHead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHead)) = flag;
		}
	}

	public unsafe Vector3 pupilsOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pupilsOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pupilsOffset)) = vector;
		}
	}

	public unsafe Vector3 eyebrowsOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowsOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowsOffset)) = vector;
		}
	}

	public unsafe Vector3 mouthOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouthOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouthOffset)) = vector;
		}
	}

	public unsafe bool hatRenderCompatible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hatRenderCompatible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hatRenderCompatible)) = flag;
		}
	}

	public unsafe List<ClothesPreset> excludeHats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeHats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeHats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HairRenderSetting hairRenderMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairRenderMode);
			return *(HairRenderSetting*)num;
		}
		set
		{
			*(HairRenderSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairRenderMode)) = hairRenderSetting;
		}
	}

	public unsafe bool setFootwear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setFootwear);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setFootwear)) = flag;
		}
	}

	public unsafe Human.ShoeType footwear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footwear);
			return *(Human.ShoeType*)num;
		}
		set
		{
			*(Human.ShoeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footwear)) = shoeType;
		}
	}

	public unsafe int priority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
		}
	}

	public unsafe bool onlyChooseIfAllModelPartsAreAvailable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyChooseIfAllModelPartsAreAvailable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyChooseIfAllModelPartsAreAvailable)) = flag;
		}
	}

	public unsafe List<IncompatibilitySetting> incompatibility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incompatibility);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IncompatibilitySetting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incompatibility)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useWealthValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWealthValues);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWealthValues)) = flag;
		}
	}

	public unsafe float minimumWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth)) = num;
		}
	}

	public unsafe float maximumWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumWealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumWealth)) = num;
		}
	}

	public unsafe ClothingColourSource baseColourSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseColourSource);
			return *(ClothingColourSource*)num;
		}
		set
		{
			*(ClothingColourSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseColourSource)) = clothingColourSource;
		}
	}

	public unsafe List<ColourPalettePreset> colourBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourBase);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ColourPalettePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourBase)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ClothingColourSource colour1Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1Source);
			return *(ClothingColourSource*)num;
		}
		set
		{
			*(ClothingColourSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1Source)) = clothingColourSource;
		}
	}

	public unsafe List<ColourPalettePreset> colour1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ColourPalettePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ClothingColourSource colour2Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2Source);
			return *(ClothingColourSource*)num;
		}
		set
		{
			*(ClothingColourSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2Source)) = clothingColourSource;
		}
	}

	public unsafe List<ColourPalettePreset> colour2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ColourPalettePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ClothingColourSource colour3Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3Source);
			return *(ClothingColourSource*)num;
		}
		set
		{
			*(ClothingColourSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3Source)) = clothingColourSource;
		}
	}

	public unsafe List<ColourPalettePreset> colour3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ColourPalettePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool includeInPersonalityMatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeInPersonalityMatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeInPersonalityMatching)) = flag;
		}
	}

	public unsafe int baseChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance)) = num;
		}
	}

	public unsafe bool useHEXACO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHEXACO);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHEXACO)) = flag;
		}
	}

	public unsafe HEXACO hexaco
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hexaco);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HEXACO>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hexaco)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hEXACO));
		}
	}

	public unsafe bool useTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTraits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTraits)) = flag;
		}
	}

	public unsafe List<TraitPickRule> characterTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TraitPickRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ModelSettings> models
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_models);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ModelSettings>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_models)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ClothesPreset()
	{
		Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ClothesPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr);
		NativeFieldInfoPtr_covers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "covers");
		NativeFieldInfoPtr_outfitCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "outfitCategories");
		NativeFieldInfoPtr_suitableForGenders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "suitableForGenders");
		NativeFieldInfoPtr_suitableForBuilds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "suitableForBuilds");
		NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "tags");
		NativeFieldInfoPtr_enableFacialFeatureSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "enableFacialFeatureSetup");
		NativeFieldInfoPtr_suitableForHairstyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "suitableForHairstyle");
		NativeFieldInfoPtr_isHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "isHead");
		NativeFieldInfoPtr_pupilsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "pupilsOffset");
		NativeFieldInfoPtr_eyebrowsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "eyebrowsOffset");
		NativeFieldInfoPtr_mouthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "mouthOffset");
		NativeFieldInfoPtr_hatRenderCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "hatRenderCompatible");
		NativeFieldInfoPtr_excludeHats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "excludeHats");
		NativeFieldInfoPtr_hairRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "hairRenderMode");
		NativeFieldInfoPtr_setFootwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "setFootwear");
		NativeFieldInfoPtr_footwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "footwear");
		NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "priority");
		NativeFieldInfoPtr_onlyChooseIfAllModelPartsAreAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "onlyChooseIfAllModelPartsAreAvailable");
		NativeFieldInfoPtr_incompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "incompatibility");
		NativeFieldInfoPtr_useWealthValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "useWealthValues");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_maximumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "maximumWealth");
		NativeFieldInfoPtr_baseColourSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "baseColourSource");
		NativeFieldInfoPtr_colourBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "colourBase");
		NativeFieldInfoPtr_colour1Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "colour1Source");
		NativeFieldInfoPtr_colour1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "colour1");
		NativeFieldInfoPtr_colour2Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "colour2Source");
		NativeFieldInfoPtr_colour2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "colour2");
		NativeFieldInfoPtr_colour3Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "colour3Source");
		NativeFieldInfoPtr_colour3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "colour3");
		NativeFieldInfoPtr_includeInPersonalityMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "includeInPersonalityMatching");
		NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "baseChance");
		NativeFieldInfoPtr_useHEXACO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "useHEXACO");
		NativeFieldInfoPtr_hexaco = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "hexaco");
		NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "useTraits");
		NativeFieldInfoPtr_characterTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "characterTraits");
		NativeFieldInfoPtr_models = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, "models");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr, 100673845);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327867, XrefRangeEnd = 327947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClothesPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothesPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ClothesPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
