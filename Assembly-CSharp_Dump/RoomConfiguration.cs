using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class RoomConfiguration : SoCustomComparison
{
	public enum DecorSetting
	{
		ownStyle,
		borrowFromAdjoining,
		borrowFromBuilding
	}

	public enum RoomZoning
	{
		lobby,
		residential,
		commerical,
		industrial,
		municpial,
		park
	}

	public enum Forbidden
	{
		alwaysAllowed,
		alwaysForbidden,
		allowedDuringOpenHours
	}

	public enum SecurityDoorRule
	{
		never,
		allAdjoining,
		onlyToOtherAddress,
		onlyToStairwell
	}

	[System.Serializable]
	public class AILightingBehaviour : Il2CppSystem.Object
	{
		public enum TimeOfDay
		{
			always,
			daytime,
			evening
		}

		public enum LightingPreference
		{
			mainOn,
			secondaryOn,
			eitherPriorityMain,
			eitherPrioritySecondary,
			allOff,
			mainOff,
			secondaryOff,
			none,
			mainOnSecondaryAny
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_dayRule;

		private static readonly System.IntPtr NativeFieldInfoPtr_passthroughBehaviour;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationBehaviour;

		private static readonly System.IntPtr NativeFieldInfoPtr_exitRoomBehaviour;

		private static readonly System.IntPtr NativeFieldInfoPtr_exitGameLocationBehaviour;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TimeOfDay dayRule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayRule);
				return *(TimeOfDay*)num;
			}
			set
			{
				*(TimeOfDay*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayRule)) = timeOfDay;
			}
		}

		public unsafe LightingPreference passthroughBehaviour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passthroughBehaviour);
				return *(LightingPreference*)num;
			}
			set
			{
				*(LightingPreference*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passthroughBehaviour)) = lightingPreference;
			}
		}

		public unsafe LightingPreference destinationBehaviour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationBehaviour);
				return *(LightingPreference*)num;
			}
			set
			{
				*(LightingPreference*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationBehaviour)) = lightingPreference;
			}
		}

		public unsafe LightingPreference exitRoomBehaviour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitRoomBehaviour);
				return *(LightingPreference*)num;
			}
			set
			{
				*(LightingPreference*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitRoomBehaviour)) = lightingPreference;
			}
		}

		public unsafe LightingPreference exitGameLocationBehaviour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitGameLocationBehaviour);
				return *(LightingPreference*)num;
			}
			set
			{
				*(LightingPreference*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitGameLocationBehaviour)) = lightingPreference;
			}
		}

		static AILightingBehaviour()
		{
			Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "AILightingBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr);
			NativeFieldInfoPtr_dayRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr, "dayRule");
			NativeFieldInfoPtr_passthroughBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr, "passthroughBehaviour");
			NativeFieldInfoPtr_destinationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr, "destinationBehaviour");
			NativeFieldInfoPtr_exitRoomBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr, "exitRoomBehaviour");
			NativeFieldInfoPtr_exitGameLocationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr, "exitGameLocationBehaviour");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr, 100674026);
		}

		[CallerCount(0)]
		public unsafe AILightingBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AILightingBehaviour>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AILightingBehaviour(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum RoomPasswordPreference
	{
		interactableBelongsTo,
		thisRoom,
		thisAddress
	}

	public enum KeyPlacement
	{
		thisAddress,
		belongsToHome,
		belongsToWork
	}

	[System.Serializable]
	public class WallFrontage : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_wallPreset;

		private static readonly System.IntPtr NativeFieldInfoPtr_insideFrontage;

		private static readonly System.IntPtr NativeFieldInfoPtr_outsideFrontage;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfBorderingOutside;

		private static readonly System.IntPtr NativeFieldInfoPtr_localOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_limitToBuildingTypes;

		private static readonly System.IntPtr NativeFieldInfoPtr_limitedToBuildings;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe DoorPairPreset wallPreset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallPreset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
			}
		}

		public unsafe List<WallFrontageClass> insideFrontage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insideFrontage);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WallFrontageClass>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insideFrontage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<WallFrontageClass> outsideFrontage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideFrontage);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WallFrontageClass>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideFrontage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool onlyIfBorderingOutside
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfBorderingOutside);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfBorderingOutside)) = flag;
			}
		}

		public unsafe Vector3 localOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localOffset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localOffset)) = vector;
			}
		}

		public unsafe bool limitToBuildingTypes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToBuildingTypes);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToBuildingTypes)) = flag;
			}
		}

		public unsafe List<BuildingPreset> limitedToBuildings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitedToBuildings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitedToBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static WallFrontage()
		{
			Il2CppClassPointerStore<WallFrontage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "WallFrontage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "name");
			NativeFieldInfoPtr_wallPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "wallPreset");
			NativeFieldInfoPtr_insideFrontage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "insideFrontage");
			NativeFieldInfoPtr_outsideFrontage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "outsideFrontage");
			NativeFieldInfoPtr_onlyIfBorderingOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "onlyIfBorderingOutside");
			NativeFieldInfoPtr_localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "localOffset");
			NativeFieldInfoPtr_limitToBuildingTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "limitToBuildingTypes");
			NativeFieldInfoPtr_limitedToBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, "limitedToBuildings");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr, 100674027);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330059, XrefRangeEnd = 330061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WallFrontage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallFrontage>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WallFrontage(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum OutsideSetting
	{
		dontChange,
		forceOutside,
		forceInside
	}

	public enum PrintsSource
	{
		owners,
		inhabitants,
		buildingResidents,
		customersAll,
		customersMale,
		customersFemale,
		publicAll,
		inhabitantsAndCustomers,
		writers,
		receivers,
		ownersAndWriters,
		ownersWritersReceivers,
		killer
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_roomType;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_canBeOpenPlan;

	private static readonly System.IntPtr NativeFieldInfoPtr_openPlanRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitSecurityCameras;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityCameraLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMainLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_useLightSwitches;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightsOnAtStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_wellLit;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoDisableLightsOutOfVicinity;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyAutoDisableInNonStairwell;

	private static readonly System.IntPtr NativeFieldInfoPtr_useAdditionalAreaLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDistrictSettingsAsBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumLightZoneSizeForAreaLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightBrightness;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightCoverageMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_boostCeilingEmission;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingEmissionBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfCeilingFans;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseLightingShadowTint;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseLightingShadowTintIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightingShadowTint;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightingShadowTintIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideAreaLightShadowTint;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightShadowTintOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_areaLightShadowDimmer;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightingBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_cleanness;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceColourSchemes;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumGrubiness;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumGrubiness;

	private static readonly System.IntPtr NativeFieldInfoPtr_decorSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeFromOthersCopyingDecorStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfOverrideMatIfGroundFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfOverrideMatIfBasement;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfOverrideMatIfStairwell;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_decorationPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOwnership;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignBelongsToOwners;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferCouples;

	private static readonly System.IntPtr NativeFieldInfoPtr_belongsToJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_exteriorDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_addressDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_passwordPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferredPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_placeKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyOwnershipPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_steps;

	private static readonly System.IntPtr NativeFieldInfoPtr_replaceWindows;

	private static readonly System.IntPtr NativeFieldInfoPtr_replaceWalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_replaceEntrance;

	private static readonly System.IntPtr NativeFieldInfoPtr_replaceInsideAlso;

	private static readonly System.IntPtr NativeFieldInfoPtr_replaceOnlyIfOtherIs;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyReplaceIf;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStreetLightLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBuildingModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallFrontage;

	private static readonly System.IntPtr NativeFieldInfoPtr_oneFrontagePerNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumVents;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfRoofVent;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfWallVentUpper;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfWallVentLower;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowUpperWallLevelDucts;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyAllowUpperIfFloorLevelIsZero;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitUpperLevelDucts;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowLowerWallLevelDucts;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideAddressEnvironment;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneClean;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneDirty;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseRoomAtmosphere;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceOutside;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_printsSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintWallDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowCoving;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowBugs;

	private static readonly System.IntPtr NativeFieldInfoPtr_bugAmountMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_forbidden;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedIfGivenCorrectPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_AIknowPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_escalationLevelNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_escalationLevelAfterHours;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowPersonalAffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideMaxFurnitureClusters;

	private static readonly System.IntPtr NativeFieldInfoPtr_overridenMaxFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideAttemptsPerNodeMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_overridenAttemptsPerNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadinessValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowMuggings;

	private static readonly System.IntPtr NativeFieldInfoPtr_muggingAwakenRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugRoom;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyWallFrontage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWallFrontage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RoomTypePreset roomType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomTypePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomTypePreset));
		}
	}

	public unsafe RoomClassPreset roomClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomClass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomClassPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomClassPreset));
		}
	}

	public unsafe bool canBeOpenPlan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeOpenPlan);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeOpenPlan)) = flag;
		}
	}

	public unsafe RoomTypePreset openPlanRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openPlanRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomTypePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openPlanRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomTypePreset));
		}
	}

	public unsafe SecurityDoorRule securityDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityDoors);
			return *(SecurityDoorRule*)num;
		}
		set
		{
			*(SecurityDoorRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityDoors)) = securityDoorRule;
		}
	}

	public unsafe bool limitSecurityCameras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitSecurityCameras);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitSecurityCameras)) = flag;
		}
	}

	public unsafe int securityCameraLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityCameraLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityCameraLimit)) = num;
		}
	}

	public unsafe bool useMainLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMainLights);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMainLights)) = flag;
		}
	}

	public unsafe bool useLightSwitches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLightSwitches);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLightSwitches)) = flag;
		}
	}

	public unsafe bool lightsOnAtStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsOnAtStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsOnAtStart)) = flag;
		}
	}

	public unsafe bool wellLit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellLit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellLit)) = flag;
		}
	}

	public unsafe bool autoDisableLightsOutOfVicinity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoDisableLightsOutOfVicinity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoDisableLightsOutOfVicinity)) = flag;
		}
	}

	public unsafe bool onlyAutoDisableInNonStairwell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAutoDisableInNonStairwell);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAutoDisableInNonStairwell)) = flag;
		}
	}

	public unsafe bool useAdditionalAreaLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAdditionalAreaLights);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAdditionalAreaLights)) = flag;
		}
	}

	public unsafe bool useDistrictSettingsAsBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDistrictSettingsAsBase);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDistrictSettingsAsBase)) = flag;
		}
	}

	public unsafe int minimumLightZoneSizeForAreaLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLightZoneSizeForAreaLights);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLightZoneSizeForAreaLights)) = num;
		}
	}

	public unsafe Vector3 areaLightOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightOffset)) = vector;
		}
	}

	public unsafe float areaLightBrightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightBrightness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightBrightness)) = num;
		}
	}

	public unsafe Color areaLightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightColor)) = color;
		}
	}

	public unsafe float areaLightRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightRange)) = num;
		}
	}

	public unsafe float areaLightCoverageMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightCoverageMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightCoverageMultiplier)) = num;
		}
	}

	public unsafe bool boostCeilingEmission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boostCeilingEmission);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boostCeilingEmission)) = flag;
		}
	}

	public unsafe Color ceilingEmissionBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingEmissionBoost);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingEmissionBoost)) = color;
		}
	}

	public unsafe float chanceOfCeilingFans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfCeilingFans);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfCeilingFans)) = num;
		}
	}

	public unsafe bool baseLightingShadowTint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLightingShadowTint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLightingShadowTint)) = flag;
		}
	}

	public unsafe float baseLightingShadowTintIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLightingShadowTintIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseLightingShadowTintIntensity)) = num;
		}
	}

	public unsafe bool areaLightingShadowTint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightingShadowTint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightingShadowTint)) = flag;
		}
	}

	public unsafe float areaLightingShadowTintIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightingShadowTintIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightingShadowTintIntensity)) = num;
		}
	}

	public unsafe bool overrideAreaLightShadowTint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAreaLightShadowTint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAreaLightShadowTint)) = flag;
		}
	}

	public unsafe Color areaLightShadowTintOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightShadowTintOverride);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightShadowTintOverride)) = color;
		}
	}

	public unsafe float areaLightShadowDimmer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightShadowDimmer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightShadowDimmer)) = num;
		}
	}

	public unsafe List<AILightingBehaviour> lightingBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingBehaviour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AILightingBehaviour>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingBehaviour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int cleanness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanness)) = num;
		}
	}

	public unsafe List<ColourSchemePreset> forceColourSchemes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceColourSchemes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ColourSchemePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceColourSchemes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float minimumGrubiness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumGrubiness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumGrubiness)) = num;
		}
	}

	public unsafe float maximumGrubiness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumGrubiness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumGrubiness)) = num;
		}
	}

	public unsafe DecorSetting decorSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorSetting);
			return *(DecorSetting*)num;
		}
		set
		{
			*(DecorSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorSetting)) = decorSetting;
		}
	}

	public unsafe bool excludeFromOthersCopyingDecorStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromOthersCopyingDecorStyle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromOthersCopyingDecorStyle)) = flag;
		}
	}

	public unsafe float chanceOfOverrideMatIfGroundFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOverrideMatIfGroundFloor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOverrideMatIfGroundFloor)) = num;
		}
	}

	public unsafe float chanceOfOverrideMatIfBasement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOverrideMatIfBasement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOverrideMatIfBasement)) = num;
		}
	}

	public unsafe float chanceOfOverrideMatIfStairwell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOverrideMatIfStairwell);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOverrideMatIfStairwell)) = num;
		}
	}

	public unsafe List<MaterialGroupPreset> floorOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOverrides);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialGroupPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOverrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MaterialGroupPreset> wallOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallOverrides);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialGroupPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallOverrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MaterialGroupPreset> ceilingOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingOverrides);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialGroupPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingOverrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int decorationPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorationPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorationPriority)) = num;
		}
	}

	public unsafe bool useOwnership
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnership);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnership)) = flag;
		}
	}

	public unsafe int assignBelongsToOwners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignBelongsToOwners);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignBelongsToOwners)) = num;
		}
	}

	public unsafe bool preferCouples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferCouples);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferCouples)) = flag;
		}
	}

	public unsafe List<OccupationPreset> belongsToJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsToJob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsToJob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe DoorPreset exteriorDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorDoor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPreset));
		}
	}

	public unsafe DoorPreset addressDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressDoor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPreset));
		}
	}

	public unsafe DoorPreset internalDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalDoor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPreset));
		}
	}

	public unsafe int passwordPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordPriority)) = num;
		}
	}

	public unsafe RoomPasswordPreference preferredPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredPassword);
			return *(RoomPasswordPreference*)num;
		}
		set
		{
			*(RoomPasswordPreference*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredPassword)) = roomPasswordPreference;
		}
	}

	public unsafe List<KeyPlacement> placeKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeKey);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyPlacement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe InteractablePreset.OwnedPlacementRule keyOwnershipPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyOwnershipPlacement);
			return *(InteractablePreset.OwnedPlacementRule*)num;
		}
		set
		{
			*(InteractablePreset.OwnedPlacementRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyOwnershipPlacement)) = ownedPlacementRule;
		}
	}

	public unsafe GameObject steps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe DoorPairPreset replaceWindows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceWindows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceWindows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe DoorPairPreset replaceWalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceWalls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceWalls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe DoorPairPreset replaceEntrance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceEntrance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceEntrance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe bool replaceInsideAlso
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceInsideAlso);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceInsideAlso)) = flag;
		}
	}

	public unsafe bool replaceOnlyIfOtherIs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceOnlyIfOtherIs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceOnlyIfOtherIs)) = flag;
		}
	}

	public unsafe List<RoomTypePreset> onlyReplaceIf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyReplaceIf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyReplaceIf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool forceStreetLightLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStreetLightLayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStreetLightLayer)) = flag;
		}
	}

	public unsafe bool drawBuildingModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBuildingModel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBuildingModel)) = flag;
		}
	}

	public unsafe List<WallFrontage> wallFrontage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallFrontage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WallFrontage>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallFrontage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool oneFrontagePerNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneFrontagePerNode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneFrontagePerNode)) = flag;
		}
	}

	public unsafe int maximumVents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumVents);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumVents)) = num;
		}
	}

	public unsafe int chanceOfRoofVent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfRoofVent);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfRoofVent)) = num;
		}
	}

	public unsafe int chanceOfWallVentUpper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWallVentUpper);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWallVentUpper)) = num;
		}
	}

	public unsafe int chanceOfWallVentLower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWallVentLower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWallVentLower)) = num;
		}
	}

	public unsafe bool allowUpperWallLevelDucts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowUpperWallLevelDucts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowUpperWallLevelDucts)) = flag;
		}
	}

	public unsafe bool onlyAllowUpperIfFloorLevelIsZero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowUpperIfFloorLevelIsZero);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowUpperIfFloorLevelIsZero)) = flag;
		}
	}

	public unsafe int limitUpperLevelDucts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitUpperLevelDucts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitUpperLevelDucts)) = num;
		}
	}

	public unsafe bool allowLowerWallLevelDucts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLowerWallLevelDucts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLowerWallLevelDucts)) = flag;
		}
	}

	public unsafe bool overrideAddressEnvironment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAddressEnvironment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAddressEnvironment)) = flag;
		}
	}

	public unsafe SessionData.SceneProfile sceneClean
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneClean);
			return *(SessionData.SceneProfile*)num;
		}
		set
		{
			*(SessionData.SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneClean)) = sceneProfile;
		}
	}

	public unsafe SessionData.SceneProfile sceneDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneDirty);
			return *(SessionData.SceneProfile*)num;
		}
		set
		{
			*(SessionData.SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneDirty)) = sceneProfile;
		}
	}

	public unsafe float baseRoomAtmosphere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseRoomAtmosphere);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseRoomAtmosphere)) = num;
		}
	}

	public unsafe OutsideSetting forceOutside
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceOutside);
			return *(OutsideSetting*)num;
		}
		set
		{
			*(OutsideSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceOutside)) = outsideSetting;
		}
	}

	public unsafe AmbientZone ambientZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientZone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AmbientZone>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientZone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ambientZone));
		}
	}

	public unsafe bool fingerprintsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled)) = flag;
		}
	}

	public unsafe bool footprintsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintsEnabled)) = flag;
		}
	}

	public unsafe PrintsSource printsSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource);
			return *(PrintsSource*)num;
		}
		set
		{
			*(PrintsSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource)) = printsSource;
		}
	}

	public unsafe float fingerprintWallDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintWallDensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintWallDensity)) = num;
		}
	}

	public unsafe bool allowCoving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCoving);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCoving)) = flag;
		}
	}

	public unsafe bool allowBugs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowBugs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowBugs)) = flag;
		}
	}

	public unsafe float bugAmountMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bugAmountMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bugAmountMultiplier)) = num;
		}
	}

	public unsafe Forbidden forbidden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbidden);
			return *(Forbidden*)num;
		}
		set
		{
			*(Forbidden*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbidden)) = forbidden;
		}
	}

	public unsafe bool allowedIfGivenCorrectPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedIfGivenCorrectPassword);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedIfGivenCorrectPassword)) = flag;
		}
	}

	public unsafe bool AIknowPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIknowPassword);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIknowPassword)) = flag;
		}
	}

	public unsafe int escalationLevelNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevelNormal);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevelNormal)) = num;
		}
	}

	public unsafe int escalationLevelAfterHours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevelAfterHours);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevelAfterHours)) = num;
		}
	}

	public unsafe int securityLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityLevel)) = num;
		}
	}

	public unsafe bool allowPersonalAffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPersonalAffects);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPersonalAffects)) = flag;
		}
	}

	public unsafe bool overrideMaxFurnitureClusters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaxFurnitureClusters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaxFurnitureClusters)) = flag;
		}
	}

	public unsafe int overridenMaxFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridenMaxFurniture);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridenMaxFurniture)) = num;
		}
	}

	public unsafe bool overrideAttemptsPerNodeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAttemptsPerNodeMultiplier);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideAttemptsPerNodeMultiplier)) = flag;
		}
	}

	public unsafe float overridenAttemptsPerNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridenAttemptsPerNode);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridenAttemptsPerNode)) = num;
		}
	}

	public unsafe int shadinessValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadinessValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadinessValue)) = num;
		}
	}

	public unsafe bool allowMuggings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMuggings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMuggings)) = flag;
		}
	}

	public unsafe bool muggingAwakenRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muggingAwakenRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muggingAwakenRoom)) = flag;
		}
	}

	public unsafe RoomConfiguration debugRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	static RoomConfiguration()
	{
		Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoomConfiguration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr);
		NativeFieldInfoPtr_roomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "roomType");
		NativeFieldInfoPtr_roomClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "roomClass");
		NativeFieldInfoPtr_canBeOpenPlan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "canBeOpenPlan");
		NativeFieldInfoPtr_openPlanRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "openPlanRoom");
		NativeFieldInfoPtr_securityDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "securityDoors");
		NativeFieldInfoPtr_limitSecurityCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "limitSecurityCameras");
		NativeFieldInfoPtr_securityCameraLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "securityCameraLimit");
		NativeFieldInfoPtr_useMainLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "useMainLights");
		NativeFieldInfoPtr_useLightSwitches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "useLightSwitches");
		NativeFieldInfoPtr_lightsOnAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "lightsOnAtStart");
		NativeFieldInfoPtr_wellLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "wellLit");
		NativeFieldInfoPtr_autoDisableLightsOutOfVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "autoDisableLightsOutOfVicinity");
		NativeFieldInfoPtr_onlyAutoDisableInNonStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "onlyAutoDisableInNonStairwell");
		NativeFieldInfoPtr_useAdditionalAreaLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "useAdditionalAreaLights");
		NativeFieldInfoPtr_useDistrictSettingsAsBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "useDistrictSettingsAsBase");
		NativeFieldInfoPtr_minimumLightZoneSizeForAreaLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "minimumLightZoneSizeForAreaLights");
		NativeFieldInfoPtr_areaLightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightOffset");
		NativeFieldInfoPtr_areaLightBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightBrightness");
		NativeFieldInfoPtr_areaLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightColor");
		NativeFieldInfoPtr_areaLightRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightRange");
		NativeFieldInfoPtr_areaLightCoverageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightCoverageMultiplier");
		NativeFieldInfoPtr_boostCeilingEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "boostCeilingEmission");
		NativeFieldInfoPtr_ceilingEmissionBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "ceilingEmissionBoost");
		NativeFieldInfoPtr_chanceOfCeilingFans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "chanceOfCeilingFans");
		NativeFieldInfoPtr_baseLightingShadowTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "baseLightingShadowTint");
		NativeFieldInfoPtr_baseLightingShadowTintIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "baseLightingShadowTintIntensity");
		NativeFieldInfoPtr_areaLightingShadowTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightingShadowTint");
		NativeFieldInfoPtr_areaLightingShadowTintIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightingShadowTintIntensity");
		NativeFieldInfoPtr_overrideAreaLightShadowTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "overrideAreaLightShadowTint");
		NativeFieldInfoPtr_areaLightShadowTintOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightShadowTintOverride");
		NativeFieldInfoPtr_areaLightShadowDimmer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "areaLightShadowDimmer");
		NativeFieldInfoPtr_lightingBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "lightingBehaviour");
		NativeFieldInfoPtr_cleanness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "cleanness");
		NativeFieldInfoPtr_forceColourSchemes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "forceColourSchemes");
		NativeFieldInfoPtr_minimumGrubiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "minimumGrubiness");
		NativeFieldInfoPtr_maximumGrubiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "maximumGrubiness");
		NativeFieldInfoPtr_decorSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "decorSetting");
		NativeFieldInfoPtr_excludeFromOthersCopyingDecorStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "excludeFromOthersCopyingDecorStyle");
		NativeFieldInfoPtr_chanceOfOverrideMatIfGroundFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "chanceOfOverrideMatIfGroundFloor");
		NativeFieldInfoPtr_chanceOfOverrideMatIfBasement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "chanceOfOverrideMatIfBasement");
		NativeFieldInfoPtr_chanceOfOverrideMatIfStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "chanceOfOverrideMatIfStairwell");
		NativeFieldInfoPtr_floorOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "floorOverrides");
		NativeFieldInfoPtr_wallOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "wallOverrides");
		NativeFieldInfoPtr_ceilingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "ceilingOverrides");
		NativeFieldInfoPtr_decorationPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "decorationPriority");
		NativeFieldInfoPtr_useOwnership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "useOwnership");
		NativeFieldInfoPtr_assignBelongsToOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "assignBelongsToOwners");
		NativeFieldInfoPtr_preferCouples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "preferCouples");
		NativeFieldInfoPtr_belongsToJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "belongsToJob");
		NativeFieldInfoPtr_exteriorDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "exteriorDoor");
		NativeFieldInfoPtr_addressDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "addressDoor");
		NativeFieldInfoPtr_internalDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "internalDoor");
		NativeFieldInfoPtr_passwordPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "passwordPriority");
		NativeFieldInfoPtr_preferredPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "preferredPassword");
		NativeFieldInfoPtr_placeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "placeKey");
		NativeFieldInfoPtr_keyOwnershipPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "keyOwnershipPlacement");
		NativeFieldInfoPtr_steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "steps");
		NativeFieldInfoPtr_replaceWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "replaceWindows");
		NativeFieldInfoPtr_replaceWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "replaceWalls");
		NativeFieldInfoPtr_replaceEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "replaceEntrance");
		NativeFieldInfoPtr_replaceInsideAlso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "replaceInsideAlso");
		NativeFieldInfoPtr_replaceOnlyIfOtherIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "replaceOnlyIfOtherIs");
		NativeFieldInfoPtr_onlyReplaceIf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "onlyReplaceIf");
		NativeFieldInfoPtr_forceStreetLightLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "forceStreetLightLayer");
		NativeFieldInfoPtr_drawBuildingModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "drawBuildingModel");
		NativeFieldInfoPtr_wallFrontage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "wallFrontage");
		NativeFieldInfoPtr_oneFrontagePerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "oneFrontagePerNode");
		NativeFieldInfoPtr_maximumVents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "maximumVents");
		NativeFieldInfoPtr_chanceOfRoofVent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "chanceOfRoofVent");
		NativeFieldInfoPtr_chanceOfWallVentUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "chanceOfWallVentUpper");
		NativeFieldInfoPtr_chanceOfWallVentLower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "chanceOfWallVentLower");
		NativeFieldInfoPtr_allowUpperWallLevelDucts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "allowUpperWallLevelDucts");
		NativeFieldInfoPtr_onlyAllowUpperIfFloorLevelIsZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "onlyAllowUpperIfFloorLevelIsZero");
		NativeFieldInfoPtr_limitUpperLevelDucts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "limitUpperLevelDucts");
		NativeFieldInfoPtr_allowLowerWallLevelDucts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "allowLowerWallLevelDucts");
		NativeFieldInfoPtr_overrideAddressEnvironment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "overrideAddressEnvironment");
		NativeFieldInfoPtr_sceneClean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "sceneClean");
		NativeFieldInfoPtr_sceneDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "sceneDirty");
		NativeFieldInfoPtr_baseRoomAtmosphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "baseRoomAtmosphere");
		NativeFieldInfoPtr_forceOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "forceOutside");
		NativeFieldInfoPtr_ambientZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "ambientZone");
		NativeFieldInfoPtr_fingerprintsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "fingerprintsEnabled");
		NativeFieldInfoPtr_footprintsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "footprintsEnabled");
		NativeFieldInfoPtr_printsSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "printsSource");
		NativeFieldInfoPtr_fingerprintWallDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "fingerprintWallDensity");
		NativeFieldInfoPtr_allowCoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "allowCoving");
		NativeFieldInfoPtr_allowBugs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "allowBugs");
		NativeFieldInfoPtr_bugAmountMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "bugAmountMultiplier");
		NativeFieldInfoPtr_forbidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "forbidden");
		NativeFieldInfoPtr_allowedIfGivenCorrectPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "allowedIfGivenCorrectPassword");
		NativeFieldInfoPtr_AIknowPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "AIknowPassword");
		NativeFieldInfoPtr_escalationLevelNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "escalationLevelNormal");
		NativeFieldInfoPtr_escalationLevelAfterHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "escalationLevelAfterHours");
		NativeFieldInfoPtr_securityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "securityLevel");
		NativeFieldInfoPtr_allowPersonalAffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "allowPersonalAffects");
		NativeFieldInfoPtr_overrideMaxFurnitureClusters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "overrideMaxFurnitureClusters");
		NativeFieldInfoPtr_overridenMaxFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "overridenMaxFurniture");
		NativeFieldInfoPtr_overrideAttemptsPerNodeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "overrideAttemptsPerNodeMultiplier");
		NativeFieldInfoPtr_overridenAttemptsPerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "overridenAttemptsPerNode");
		NativeFieldInfoPtr_shadinessValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "shadinessValue");
		NativeFieldInfoPtr_allowMuggings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "allowMuggings");
		NativeFieldInfoPtr_muggingAwakenRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "muggingAwakenRoom");
		NativeFieldInfoPtr_debugRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, "debugRoom");
		NativeMethodInfoPtr_CopyWallFrontage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, 100674023);
		NativeMethodInfoPtr_AddWallFrontage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, 100674024);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr, 100674025);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330061, XrefRangeEnd = 330067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyWallFrontage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyWallFrontage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330067, XrefRangeEnd = 330069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWallFrontage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWallFrontage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330069, XrefRangeEnd = 330115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoomConfiguration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomConfiguration>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoomConfiguration(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
