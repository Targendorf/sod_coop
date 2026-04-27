using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MurderMO : SoCustomComparison
{
	[System.Serializable]
	public class CallingCardPick : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeFieldInfoPtr_origin;

		private static readonly System.IntPtr NativeFieldInfoPtr_randomScoreRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitModifiers;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractablePreset item
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe CallingCardOrigin origin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origin);
				return *(CallingCardOrigin*)num;
			}
			set
			{
				*(CallingCardOrigin*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origin)) = callingCardOrigin;
			}
		}

		public unsafe Vector2 randomScoreRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomScoreRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomScoreRange)) = vector;
			}
		}

		public unsafe List<MurderPreset.MurdererModifierRule> traitModifiers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset.MurdererModifierRule>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CallingCardPick()
		{
			Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "CallingCardPick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr);
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr, "item");
			NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr, "origin");
			NativeFieldInfoPtr_randomScoreRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr, "randomScoreRange");
			NativeFieldInfoPtr_traitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr, "traitModifiers");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr, 100673985);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329429, XrefRangeEnd = 329435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallingCardPick()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallingCardPick>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CallingCardPick(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum CallingCardOrigin
	{
		createAtScene,
		createOnGoToLocation
	}

	[System.Serializable]
	public class Graffiti : Il2CppSystem.Object
	{
		public enum GraffitiPosition
		{
			victim,
			nearbyWall
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_artImage;

		private static readonly System.IntPtr NativeFieldInfoPtr_ddsMessageTextList;

		private static readonly System.IntPtr NativeFieldInfoPtr_color;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractablePreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe GraffitiPosition pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(GraffitiPosition*)num;
			}
			set
			{
				*(GraffitiPosition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = graffitiPosition;
			}
		}

		public unsafe ArtPreset artImage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artImage);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArtPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)artPreset));
			}
		}

		public unsafe string ddsMessageTextList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessageTextList);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessageTextList)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Color color
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
			}
		}

		public unsafe float size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = num;
			}
		}

		static Graffiti()
		{
			Il2CppClassPointerStore<Graffiti>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "Graffiti");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graffiti>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graffiti>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graffiti>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_artImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graffiti>.NativeClassPtr, "artImage");
			NativeFieldInfoPtr_ddsMessageTextList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graffiti>.NativeClassPtr, "ddsMessageTextList");
			NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graffiti>.NativeClassPtr, "color");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graffiti>.NativeClassPtr, "size");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graffiti>.NativeClassPtr, 100673986);
		}

		[CallerCount(0)]
		public unsafe Graffiti()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Graffiti>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Graffiti(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class JobModifier : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_jobs;

		private static readonly System.IntPtr NativeFieldInfoPtr_jobBoost;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<OccupationPreset> jobs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int jobBoost
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobBoost);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobBoost)) = num;
			}
		}

		static JobModifier()
		{
			Il2CppClassPointerStore<JobModifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "JobModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobModifier>.NativeClassPtr);
			NativeFieldInfoPtr_jobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobModifier>.NativeClassPtr, "jobs");
			NativeFieldInfoPtr_jobBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobModifier>.NativeClassPtr, "jobBoost");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobModifier>.NativeClassPtr, 100673987);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329435, XrefRangeEnd = 329441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobModifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobModifier>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public JobModifier(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CompanyModifier : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_companies;

		private static readonly System.IntPtr NativeFieldInfoPtr_mininumEmployees;

		private static readonly System.IntPtr NativeFieldInfoPtr_companyBoost;

		private static readonly System.IntPtr NativeFieldInfoPtr_boostPerEmployeeOverMinimum;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<CompanyPreset> companies
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companies);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int mininumEmployees
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mininumEmployees);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mininumEmployees)) = num;
			}
		}

		public unsafe int companyBoost
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyBoost);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyBoost)) = num;
			}
		}

		public unsafe int boostPerEmployeeOverMinimum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boostPerEmployeeOverMinimum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boostPerEmployeeOverMinimum)) = num;
			}
		}

		static CompanyModifier()
		{
			Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "CompanyModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr);
			NativeFieldInfoPtr_companies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr, "companies");
			NativeFieldInfoPtr_mininumEmployees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr, "mininumEmployees");
			NativeFieldInfoPtr_companyBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr, "companyBoost");
			NativeFieldInfoPtr_boostPerEmployeeOverMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr, "boostPerEmployeeOverMinimum");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr, 100673988);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329441, XrefRangeEnd = 329447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompanyModifier()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompanyModifier>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CompanyModifier(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_notes;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_compatibleWith;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumPotentialScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateThis;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickRandomScoreRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererTraitModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererJobModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererCompanyModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMurdererSocialClassRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererClassRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererClassRangeBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_useHexaco;

	private static readonly System.IntPtr NativeFieldInfoPtr_hexaco;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresSniperVantageAtHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponsPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockDroppingWeapons;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowAnywhere;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowWork;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowPublic;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowStreets;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowDen;

	private static readonly System.IntPtr NativeFieldInfoPtr_denFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_denStyleOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_denItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_acquaintedSuitabilityBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_attractedToSuitabilityBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_likeSuitabilityBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_sameWorkplaceBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererIsTenantBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimRandomScoreRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimTraitModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimJobModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimCompanyModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_useVictimSocialClassRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimClassRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimClassRangeBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_monkierDDSMessageList;

	private static readonly System.IntPtr NativeFieldInfoPtr_confessionalDDSResponses;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOleads;

	private static readonly System.IntPtr NativeFieldInfoPtr_graffiti;

	private static readonly System.IntPtr NativeFieldInfoPtr_callingCardPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerTaunts;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUIDValueChangedCallback_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string notes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notes);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notes)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool disabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)) = flag;
		}
	}

	public unsafe List<MurderPreset> compatibleWith
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWith);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWith)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int baseDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseDifficulty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseDifficulty)) = num;
		}
	}

	public unsafe float maximumPotentialScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumPotentialScore);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumPotentialScore)) = num;
		}
	}

	public unsafe bool updateThis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateThis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateThis)) = flag;
		}
	}

	public unsafe Vector2 pickRandomScoreRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRandomScoreRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRandomScoreRange)) = vector;
		}
	}

	public unsafe List<MurderPreset.MurdererModifierRule> murdererTraitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererTraitModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset.MurdererModifierRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererTraitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<JobModifier> murdererJobModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererJobModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<JobModifier>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererJobModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CompanyModifier> murdererCompanyModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererCompanyModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyModifier>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererCompanyModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useMurdererSocialClassRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMurdererSocialClassRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMurdererSocialClassRange)) = flag;
		}
	}

	public unsafe Vector2 murdererClassRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererClassRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererClassRange)) = vector;
		}
	}

	public unsafe int murdererClassRangeBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererClassRangeBoost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererClassRangeBoost)) = num;
		}
	}

	public unsafe bool useHexaco
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHexaco);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHexaco)) = flag;
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

	public unsafe bool requiresSniperVantageAtHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresSniperVantageAtHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresSniperVantageAtHome)) = flag;
		}
	}

	public unsafe List<MurderWeaponsPool> weaponsPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponsPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderWeaponsPool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponsPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool blockDroppingWeapons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDroppingWeapons);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDroppingWeapons)) = flag;
		}
	}

	public unsafe bool allowAnywhere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowAnywhere);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowAnywhere)) = flag;
		}
	}

	public unsafe bool allowHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHome)) = flag;
		}
	}

	public unsafe bool allowWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWork);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWork)) = flag;
		}
	}

	public unsafe bool allowPublic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPublic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPublic)) = flag;
		}
	}

	public unsafe bool allowStreets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStreets);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStreets)) = flag;
		}
	}

	public unsafe bool allowDen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowDen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowDen)) = flag;
		}
	}

	public unsafe List<FurnitureCluster> denFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_denFurniture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureCluster>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_denFurniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DesignStylePreset> denStyleOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_denStyleOverride);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DesignStylePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_denStyleOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> denItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_denItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_denItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int acquaintedSuitabilityBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquaintedSuitabilityBoost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquaintedSuitabilityBoost)) = num;
		}
	}

	public unsafe int attractedToSuitabilityBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractedToSuitabilityBoost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractedToSuitabilityBoost)) = num;
		}
	}

	public unsafe int likeSuitabilityBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_likeSuitabilityBoost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_likeSuitabilityBoost)) = num;
		}
	}

	public unsafe int sameWorkplaceBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sameWorkplaceBoost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sameWorkplaceBoost)) = num;
		}
	}

	public unsafe int murdererIsTenantBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererIsTenantBoost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererIsTenantBoost)) = num;
		}
	}

	public unsafe Vector2 victimRandomScoreRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimRandomScoreRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimRandomScoreRange)) = vector;
		}
	}

	public unsafe List<MurderPreset.MurdererModifierRule> victimTraitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimTraitModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset.MurdererModifierRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimTraitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<JobModifier> victimJobModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimJobModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<JobModifier>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimJobModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CompanyModifier> victimCompanyModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimCompanyModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyModifier>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimCompanyModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useVictimSocialClassRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useVictimSocialClassRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useVictimSocialClassRange)) = flag;
		}
	}

	public unsafe Vector2 victimClassRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimClassRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimClassRange)) = vector;
		}
	}

	public unsafe int victimClassRangeBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimClassRangeBoost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimClassRangeBoost)) = num;
		}
	}

	public unsafe string monkierDDSMessageList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monkierDDSMessageList);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monkierDDSMessageList)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> confessionalDDSResponses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confessionalDDSResponses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confessionalDDSResponses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MurderPreset.MurderLeadItem> MOleads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MOleads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset.MurderLeadItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MOleads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Graffiti> graffiti
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graffiti);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Graffiti>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graffiti)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CallingCardPick> callingCardPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callingCardPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CallingCardPick>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callingCardPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> playerTaunts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTaunts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTaunts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static MurderMO()
	{
		Il2CppClassPointerStore<MurderMO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MurderMO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurderMO>.NativeClassPtr);
		NativeFieldInfoPtr_notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "notes");
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_compatibleWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "compatibleWith");
		NativeFieldInfoPtr_baseDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "baseDifficulty");
		NativeFieldInfoPtr_maximumPotentialScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "maximumPotentialScore");
		NativeFieldInfoPtr_updateThis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "updateThis");
		NativeFieldInfoPtr_pickRandomScoreRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "pickRandomScoreRange");
		NativeFieldInfoPtr_murdererTraitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "murdererTraitModifiers");
		NativeFieldInfoPtr_murdererJobModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "murdererJobModifiers");
		NativeFieldInfoPtr_murdererCompanyModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "murdererCompanyModifiers");
		NativeFieldInfoPtr_useMurdererSocialClassRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "useMurdererSocialClassRange");
		NativeFieldInfoPtr_murdererClassRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "murdererClassRange");
		NativeFieldInfoPtr_murdererClassRangeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "murdererClassRangeBoost");
		NativeFieldInfoPtr_useHexaco = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "useHexaco");
		NativeFieldInfoPtr_hexaco = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "hexaco");
		NativeFieldInfoPtr_requiresSniperVantageAtHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "requiresSniperVantageAtHome");
		NativeFieldInfoPtr_weaponsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "weaponsPool");
		NativeFieldInfoPtr_blockDroppingWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "blockDroppingWeapons");
		NativeFieldInfoPtr_allowAnywhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "allowAnywhere");
		NativeFieldInfoPtr_allowHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "allowHome");
		NativeFieldInfoPtr_allowWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "allowWork");
		NativeFieldInfoPtr_allowPublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "allowPublic");
		NativeFieldInfoPtr_allowStreets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "allowStreets");
		NativeFieldInfoPtr_allowDen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "allowDen");
		NativeFieldInfoPtr_denFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "denFurniture");
		NativeFieldInfoPtr_denStyleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "denStyleOverride");
		NativeFieldInfoPtr_denItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "denItems");
		NativeFieldInfoPtr_acquaintedSuitabilityBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "acquaintedSuitabilityBoost");
		NativeFieldInfoPtr_attractedToSuitabilityBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "attractedToSuitabilityBoost");
		NativeFieldInfoPtr_likeSuitabilityBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "likeSuitabilityBoost");
		NativeFieldInfoPtr_sameWorkplaceBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "sameWorkplaceBoost");
		NativeFieldInfoPtr_murdererIsTenantBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "murdererIsTenantBoost");
		NativeFieldInfoPtr_victimRandomScoreRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "victimRandomScoreRange");
		NativeFieldInfoPtr_victimTraitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "victimTraitModifiers");
		NativeFieldInfoPtr_victimJobModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "victimJobModifiers");
		NativeFieldInfoPtr_victimCompanyModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "victimCompanyModifiers");
		NativeFieldInfoPtr_useVictimSocialClassRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "useVictimSocialClassRange");
		NativeFieldInfoPtr_victimClassRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "victimClassRange");
		NativeFieldInfoPtr_victimClassRangeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "victimClassRangeBoost");
		NativeFieldInfoPtr_monkierDDSMessageList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "monkierDDSMessageList");
		NativeFieldInfoPtr_confessionalDDSResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "confessionalDDSResponses");
		NativeFieldInfoPtr_MOleads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "MOleads");
		NativeFieldInfoPtr_graffiti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "graffiti");
		NativeFieldInfoPtr_callingCardPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "callingCardPool");
		NativeFieldInfoPtr_playerTaunts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, "playerTaunts");
		NativeMethodInfoPtr_OnGUIDValueChangedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, 100673983);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderMO>.NativeClassPtr, 100673984);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329447, XrefRangeEnd = 329475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUIDValueChangedCallback()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUIDValueChangedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329475, XrefRangeEnd = 329565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MurderMO()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurderMO>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MurderMO(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
