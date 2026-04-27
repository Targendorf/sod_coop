using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class AddressPreset : SoCustomComparison
{
	[System.Serializable]
	public class AddressRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_districtPreset;

		private static readonly System.IntPtr NativeFieldInfoPtr_scoreModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe DistrictPreset districtPreset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtPreset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DistrictPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)districtPreset));
			}
		}

		public unsafe int scoreModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreModifier);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreModifier)) = num;
			}
		}

		static AddressRule()
		{
			Il2CppClassPointerStore<AddressRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "AddressRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressRule>.NativeClassPtr);
			NativeFieldInfoPtr_districtPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressRule>.NativeClassPtr, "districtPreset");
			NativeFieldInfoPtr_scoreModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressRule>.NativeClassPtr, "scoreModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressRule>.NativeClassPtr, 100673776);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddressRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AddressRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum AccessType
	{
		allPublic,
		residents,
		buildingInhabitants,
		employees,
		none
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_debug;

	private static readonly System.IntPtr NativeFieldInfoPtr_fitsUnitSizeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_fitsUnitSizeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_hardSizeLimits;

	private static readonly System.IntPtr NativeFieldInfoPtr_minMaxFloors;

	private static readonly System.IntPtr NativeFieldInfoPtr_important;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseScoreFrequencyPenalty;

	private static readonly System.IntPtr NativeFieldInfoPtr_idealFootfall;

	private static readonly System.IntPtr NativeFieldInfoPtr_footfallMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_addressRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcePick;

	private static readonly System.IntPtr NativeFieldInfoPtr_ethnicityMatters;

	private static readonly System.IntPtr NativeFieldInfoPtr_ethnicity;

	private static readonly System.IntPtr NativeFieldInfoPtr_compatible;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_access;

	private static readonly System.IntPtr NativeFieldInfoPtr_canPassThrough;

	private static readonly System.IntPtr NativeFieldInfoPtr_openHoursDicatedByAdjoiningCompany;

	private static readonly System.IntPtr NativeFieldInfoPtr_needsPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_dictionaryPasswordSources;

	private static readonly System.IntPtr NativeFieldInfoPtr_company;

	private static readonly System.IntPtr NativeFieldInfoPtr_residence;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerKnowsPurpose;

	private static readonly System.IntPtr NativeFieldInfoPtr_evidenceIconLarge;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfNameSignHorizontal;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalSignOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_signCharacterSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfNameSignVertical;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleSigns;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfExternalSpareKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_airVentRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOwnSecuritySystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOwnBreakerBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_alarmLocksDownFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideBuildingEnvironment;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_entrancesLockedByDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaveLightsOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableLockingUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableLocationInformationDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceCityDirectoryInclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameFeaturesBuildingReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameFeaturesTypeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideBuildingName;

	private static readonly System.IntPtr NativeFieldInfoPtr_sameBuildingEmployeesAuthority;

	private static readonly System.IntPtr NativeFieldInfoPtr_sameBuildingResidentsAuthority;

	private static readonly System.IntPtr NativeFieldInfoPtr_canFeatureLostAndFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumLandValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumLandValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowSniperVantagePoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_vantagePointBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSniperTargetSite;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowPublicToiletUse;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableThis;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)) = flag;
		}
	}

	public unsafe int fitsUnitSizeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitsUnitSizeMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitsUnitSizeMin)) = num;
		}
	}

	public unsafe int fitsUnitSizeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitsUnitSizeMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitsUnitSizeMax)) = num;
		}
	}

	public unsafe bool hardSizeLimits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardSizeLimits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardSizeLimits)) = flag;
		}
	}

	public unsafe Vector2 minMaxFloors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxFloors);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxFloors)) = vector;
		}
	}

	public unsafe bool important
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_important);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_important)) = flag;
		}
	}

	public unsafe int maxInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxInstances);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxInstances)) = num;
		}
	}

	public unsafe int baseScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScore)) = num;
		}
	}

	public unsafe int baseScoreFrequencyPenalty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScoreFrequencyPenalty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScoreFrequencyPenalty)) = num;
		}
	}

	public unsafe float idealFootfall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idealFootfall);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idealFootfall)) = num;
		}
	}

	public unsafe float footfallMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footfallMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footfallMultiplier)) = num;
		}
	}

	public unsafe List<AddressRule> addressRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BuildingPreset> limitToBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToBuildings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool forcePick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePick)) = flag;
		}
	}

	public unsafe bool ethnicityMatters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityMatters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityMatters)) = flag;
		}
	}

	public unsafe Descriptors.EthnicGroup ethnicity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicity);
			return *(Descriptors.EthnicGroup*)num;
		}
		set
		{
			*(Descriptors.EthnicGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicity)) = ethnicGroup;
		}
	}

	public unsafe List<LayoutConfiguration> compatible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatible);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LayoutConfiguration>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatible)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RoomConfiguration> roomConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AccessType access
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access);
			return *(AccessType*)num;
		}
		set
		{
			*(AccessType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access)) = accessType;
		}
	}

	public unsafe bool canPassThrough
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPassThrough);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPassThrough)) = flag;
		}
	}

	public unsafe bool openHoursDicatedByAdjoiningCompany
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openHoursDicatedByAdjoiningCompany);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openHoursDicatedByAdjoiningCompany)) = flag;
		}
	}

	public unsafe bool needsPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsPassword);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsPassword)) = flag;
		}
	}

	public unsafe List<string> dictionaryPasswordSources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dictionaryPasswordSources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dictionaryPasswordSources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe CompanyPreset company
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_company);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompanyPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_company)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)companyPreset));
		}
	}

	public unsafe ResidencePreset residence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResidencePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)residencePreset));
		}
	}

	public unsafe bool playerKnowsPurpose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerKnowsPurpose);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerKnowsPurpose)) = flag;
		}
	}

	public unsafe Sprite evidenceIconLarge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceIconLarge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceIconLarge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe float chanceOfNameSignHorizontal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfNameSignHorizontal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfNameSignHorizontal)) = num;
		}
	}

	public unsafe Vector3 horizontalSignOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSignOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSignOffset)) = vector;
		}
	}

	public unsafe List<NeonSignCharacters> signCharacterSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signCharacterSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NeonSignCharacters>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signCharacterSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float chanceOfNameSignVertical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfNameSignVertical);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfNameSignVertical)) = num;
		}
	}

	public unsafe List<GameObject> possibleSigns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleSigns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleSigns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> specialItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float chanceOfExternalSpareKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfExternalSpareKey);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfExternalSpareKey)) = num;
		}
	}

	public unsafe Vector2 airVentRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVentRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVentRange)) = vector;
		}
	}

	public unsafe bool useOwnSecuritySystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnSecuritySystem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnSecuritySystem)) = flag;
		}
	}

	public unsafe bool useOwnBreakerBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnBreakerBox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnBreakerBox)) = flag;
		}
	}

	public unsafe bool alarmLocksDownFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmLocksDownFloor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmLocksDownFloor)) = flag;
		}
	}

	public unsafe bool overrideBuildingEnvironment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBuildingEnvironment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBuildingEnvironment)) = flag;
		}
	}

	public unsafe SessionData.SceneProfile sceneProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfile);
			return *(SessionData.SceneProfile*)num;
		}
		set
		{
			*(SessionData.SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfile)) = sceneProfile;
		}
	}

	public unsafe bool entrancesLockedByDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entrancesLockedByDefault);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entrancesLockedByDefault)) = flag;
		}
	}

	public unsafe bool leaveLightsOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveLightsOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leaveLightsOn)) = flag;
		}
	}

	public unsafe bool disableLockingUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableLockingUp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableLockingUp)) = flag;
		}
	}

	public unsafe bool disableLocationInformationDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableLocationInformationDisplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableLocationInformationDisplay)) = flag;
		}
	}

	public unsafe bool forceCityDirectoryInclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCityDirectoryInclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCityDirectoryInclusion)) = flag;
		}
	}

	public unsafe bool nameFeaturesBuildingReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameFeaturesBuildingReference);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameFeaturesBuildingReference)) = flag;
		}
	}

	public unsafe bool nameFeaturesTypeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameFeaturesTypeCount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameFeaturesTypeCount)) = flag;
		}
	}

	public unsafe bool overrideBuildingName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBuildingName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideBuildingName)) = flag;
		}
	}

	public unsafe bool sameBuildingEmployeesAuthority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sameBuildingEmployeesAuthority);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sameBuildingEmployeesAuthority)) = flag;
		}
	}

	public unsafe bool sameBuildingResidentsAuthority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sameBuildingResidentsAuthority);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sameBuildingResidentsAuthority)) = flag;
		}
	}

	public unsafe bool canFeatureLostAndFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFeatureLostAndFound);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFeatureLostAndFound)) = flag;
		}
	}

	public unsafe float minimumLandValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLandValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLandValue)) = num;
		}
	}

	public unsafe float maximumLandValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumLandValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumLandValue)) = num;
		}
	}

	public unsafe bool allowSniperVantagePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSniperVantagePoint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSniperVantagePoint)) = flag;
		}
	}

	public unsafe float vantagePointBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vantagePointBoost);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vantagePointBoost)) = num;
		}
	}

	public unsafe bool disableSniperTargetSite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSniperTargetSite);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSniperTargetSite)) = flag;
		}
	}

	public unsafe bool allowPublicToiletUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPublicToiletUse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPublicToiletUse)) = flag;
		}
	}

	public unsafe bool disableThis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableThis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableThis)) = flag;
		}
	}

	static AddressPreset()
	{
		Il2CppClassPointerStore<AddressPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AddressPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr);
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "debug");
		NativeFieldInfoPtr_fitsUnitSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "fitsUnitSizeMin");
		NativeFieldInfoPtr_fitsUnitSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "fitsUnitSizeMax");
		NativeFieldInfoPtr_hardSizeLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "hardSizeLimits");
		NativeFieldInfoPtr_minMaxFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "minMaxFloors");
		NativeFieldInfoPtr_important = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "important");
		NativeFieldInfoPtr_maxInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "maxInstances");
		NativeFieldInfoPtr_baseScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "baseScore");
		NativeFieldInfoPtr_baseScoreFrequencyPenalty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "baseScoreFrequencyPenalty");
		NativeFieldInfoPtr_idealFootfall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "idealFootfall");
		NativeFieldInfoPtr_footfallMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "footfallMultiplier");
		NativeFieldInfoPtr_addressRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "addressRules");
		NativeFieldInfoPtr_limitToBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "limitToBuildings");
		NativeFieldInfoPtr_forcePick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "forcePick");
		NativeFieldInfoPtr_ethnicityMatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "ethnicityMatters");
		NativeFieldInfoPtr_ethnicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "ethnicity");
		NativeFieldInfoPtr_compatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "compatible");
		NativeFieldInfoPtr_roomConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "roomConfig");
		NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "access");
		NativeFieldInfoPtr_canPassThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "canPassThrough");
		NativeFieldInfoPtr_openHoursDicatedByAdjoiningCompany = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "openHoursDicatedByAdjoiningCompany");
		NativeFieldInfoPtr_needsPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "needsPassword");
		NativeFieldInfoPtr_dictionaryPasswordSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "dictionaryPasswordSources");
		NativeFieldInfoPtr_company = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "company");
		NativeFieldInfoPtr_residence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "residence");
		NativeFieldInfoPtr_playerKnowsPurpose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "playerKnowsPurpose");
		NativeFieldInfoPtr_evidenceIconLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "evidenceIconLarge");
		NativeFieldInfoPtr_chanceOfNameSignHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "chanceOfNameSignHorizontal");
		NativeFieldInfoPtr_horizontalSignOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "horizontalSignOffset");
		NativeFieldInfoPtr_signCharacterSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "signCharacterSet");
		NativeFieldInfoPtr_chanceOfNameSignVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "chanceOfNameSignVertical");
		NativeFieldInfoPtr_possibleSigns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "possibleSigns");
		NativeFieldInfoPtr_specialItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "specialItems");
		NativeFieldInfoPtr_chanceOfExternalSpareKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "chanceOfExternalSpareKey");
		NativeFieldInfoPtr_airVentRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "airVentRange");
		NativeFieldInfoPtr_useOwnSecuritySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "useOwnSecuritySystem");
		NativeFieldInfoPtr_useOwnBreakerBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "useOwnBreakerBox");
		NativeFieldInfoPtr_alarmLocksDownFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "alarmLocksDownFloor");
		NativeFieldInfoPtr_overrideBuildingEnvironment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "overrideBuildingEnvironment");
		NativeFieldInfoPtr_sceneProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "sceneProfile");
		NativeFieldInfoPtr_entrancesLockedByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "entrancesLockedByDefault");
		NativeFieldInfoPtr_leaveLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "leaveLightsOn");
		NativeFieldInfoPtr_disableLockingUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "disableLockingUp");
		NativeFieldInfoPtr_disableLocationInformationDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "disableLocationInformationDisplay");
		NativeFieldInfoPtr_forceCityDirectoryInclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "forceCityDirectoryInclusion");
		NativeFieldInfoPtr_nameFeaturesBuildingReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "nameFeaturesBuildingReference");
		NativeFieldInfoPtr_nameFeaturesTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "nameFeaturesTypeCount");
		NativeFieldInfoPtr_overrideBuildingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "overrideBuildingName");
		NativeFieldInfoPtr_sameBuildingEmployeesAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "sameBuildingEmployeesAuthority");
		NativeFieldInfoPtr_sameBuildingResidentsAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "sameBuildingResidentsAuthority");
		NativeFieldInfoPtr_canFeatureLostAndFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "canFeatureLostAndFound");
		NativeFieldInfoPtr_minimumLandValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "minimumLandValue");
		NativeFieldInfoPtr_maximumLandValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "maximumLandValue");
		NativeFieldInfoPtr_allowSniperVantagePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "allowSniperVantagePoint");
		NativeFieldInfoPtr_vantagePointBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "vantagePointBoost");
		NativeFieldInfoPtr_disableSniperTargetSite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "disableSniperTargetSite");
		NativeFieldInfoPtr_allowPublicToiletUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "allowPublicToiletUse");
		NativeFieldInfoPtr_disableThis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, "disableThis");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr, 100673775);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326456, XrefRangeEnd = 326510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddressPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddressPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
