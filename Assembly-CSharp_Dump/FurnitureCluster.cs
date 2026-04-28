using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class FurnitureCluster : SoCustomComparison
{
	public enum FurnitureRuleOption
	{
		mustFeature,
		cantFeature,
		canFeature
	}

	public enum WallRule
	{
		nothing,
		wallNoDoor,
		onlyWall,
		doorway,
		door,
		bannister,
		window
	}

	public enum FurnitureFacing
	{
		down,
		up,
		left,
		right
	}

	public enum AllowedOpenPlan
	{
		yes,
		no,
		openPlanOnly
	}

	[System.Serializable]
	public class FurnitureClusterRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_onlyValidIfPreviousObjectPlaced;

		private static readonly System.IntPtr NativeFieldInfoPtr_placements;

		private static readonly System.IntPtr NativeFieldInfoPtr_furnitureClass;

		private static readonly System.IntPtr NativeFieldInfoPtr_facing;

		private static readonly System.IntPtr NativeFieldInfoPtr_importantToCluster;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfPlacementAttempt;

		private static readonly System.IntPtr NativeFieldInfoPtr_placementScoreBoost;

		private static readonly System.IntPtr NativeFieldInfoPtr_useFovBlock;

		private static readonly System.IntPtr NativeFieldInfoPtr_blockDirection;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxFOVBlockDistance;

		private static readonly System.IntPtr NativeFieldInfoPtr_localScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_positionOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool onlyValidIfPreviousObjectPlaced
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyValidIfPreviousObjectPlaced);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyValidIfPreviousObjectPlaced)) = flag;
			}
		}

		public unsafe List<Vector2> placements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe FurnitureClass furnitureClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureClass>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureClass));
			}
		}

		public unsafe FurnitureFacing facing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facing);
				return *(FurnitureFacing*)num;
			}
			set
			{
				*(FurnitureFacing*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facing)) = furnitureFacing;
			}
		}

		public unsafe bool importantToCluster
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importantToCluster);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_importantToCluster)) = flag;
			}
		}

		public unsafe float chanceOfPlacementAttempt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfPlacementAttempt);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfPlacementAttempt)) = num;
			}
		}

		public unsafe int placementScoreBoost
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementScoreBoost);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementScoreBoost)) = num;
			}
		}

		public unsafe bool useFovBlock
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFovBlock);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFovBlock)) = flag;
			}
		}

		public unsafe Vector2 blockDirection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDirection);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDirection)) = vector;
			}
		}

		public unsafe int maxFOVBlockDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFOVBlockDistance);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFOVBlockDistance)) = num;
			}
		}

		public unsafe Vector3 localScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localScale);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localScale)) = vector;
			}
		}

		public unsafe Vector3 positionOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffset)) = vector;
			}
		}

		static FurnitureClusterRule()
		{
			Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "FurnitureClusterRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr);
			NativeFieldInfoPtr_onlyValidIfPreviousObjectPlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "onlyValidIfPreviousObjectPlaced");
			NativeFieldInfoPtr_placements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "placements");
			NativeFieldInfoPtr_furnitureClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "furnitureClass");
			NativeFieldInfoPtr_facing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "facing");
			NativeFieldInfoPtr_importantToCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "importantToCluster");
			NativeFieldInfoPtr_chanceOfPlacementAttempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "chanceOfPlacementAttempt");
			NativeFieldInfoPtr_placementScoreBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "placementScoreBoost");
			NativeFieldInfoPtr_useFovBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "useFovBlock");
			NativeFieldInfoPtr_blockDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "blockDirection");
			NativeFieldInfoPtr_maxFOVBlockDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "maxFOVBlockDistance");
			NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "localScale");
			NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, "positionOffset");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr, 100673921);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328683, RefRangeEnd = 328684, XrefRangeStart = 328674, XrefRangeEnd = 328683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurnitureClusterRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureClusterRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FurnitureClusterRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("FurnitureCluster+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__61_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdatePreCalculatedLimits_b__61_0_Internal_Boolean_Vector2_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Vector2> __9__61_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__61_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__61_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673923);
			NativeMethodInfoPtr__UpdatePreCalculatedLimits_b__61_0_Internal_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673924);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328684, XrefRangeEnd = 328685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdatePreCalculatedLimits_b__61_0(Vector2 item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdatePreCalculatedLimits_b__61_0_Internal_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_disable;

	private static readonly System.IntPtr NativeFieldInfoPtr_clusterElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifyPriorityTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifyPlacementChanceTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_essentialFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_updatePreCalculated;

	private static readonly System.IntPtr NativeFieldInfoPtr_calculatedMinRoomSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumZeroNodeWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumZeroNodeWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_zeroNodeClasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumRoomSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMaximumRoomSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumRoomSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCustomZeroNodeMinWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_customZeroNodeMinWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCustomZeroNodeMaxWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_customZeroNodeMaxWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_zeroNodeWallRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInOpenPlan;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInResidential;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInCompanies;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowOnStreets;

	private static readonly System.IntPtr NativeFieldInfoPtr_coastalOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_banFromDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_notAllowedInDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipIfNoAddressInhabitants;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlySkipNoInhabitantsIfResidenceOrCompany;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontSkipNoInhabitantsIfIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedRoomFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumPerRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumPerAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOnFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToFloorRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOnFloorRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_wealthLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRoomGrub;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumGrub;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumGrub;

	private static readonly System.IntPtr NativeFieldInfoPtr_useBuildingResidences;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumResidences;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumResidences;

	private static readonly System.IntPtr NativeFieldInfoPtr_addClustersOnSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeClustersOnSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeClustersOnFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBreakerBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDebug;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePreCalculatedLimits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool disable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable)) = flag;
		}
	}

	public unsafe List<FurnitureClusterRule> clusterElements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clusterElements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClusterRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clusterElements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float placementChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementChance)) = num;
		}
	}

	public unsafe float roomPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomPriority);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomPriority)) = num;
		}
	}

	public unsafe List<CharacterTrait.TraitPickRule> modifyPriorityTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyPriorityTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyPriorityTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CharacterTrait.TraitPickRule> modifyPlacementChanceTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyPlacementChanceTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyPlacementChanceTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool essentialFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_essentialFurniture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_essentialFurniture)) = flag;
		}
	}

	public unsafe bool updatePreCalculated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatePreCalculated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatePreCalculated)) = flag;
		}
	}

	public unsafe int calculatedMinRoomSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedMinRoomSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedMinRoomSize)) = num;
		}
	}

	public unsafe int minimumZeroNodeWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumZeroNodeWallCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumZeroNodeWallCount)) = num;
		}
	}

	public unsafe int maximumZeroNodeWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumZeroNodeWallCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumZeroNodeWallCount)) = num;
		}
	}

	public unsafe List<FurnitureClass> zeroNodeClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zeroNodeClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClass>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zeroNodeClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int minimumRoomSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRoomSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRoomSize)) = num;
		}
	}

	public unsafe bool useMaximumRoomSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaximumRoomSize);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaximumRoomSize)) = flag;
		}
	}

	public unsafe int maximumRoomSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRoomSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRoomSize)) = num;
		}
	}

	public unsafe bool useCustomZeroNodeMinWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomZeroNodeMinWallCount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomZeroNodeMinWallCount)) = flag;
		}
	}

	public unsafe int customZeroNodeMinWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customZeroNodeMinWallCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customZeroNodeMinWallCount)) = num;
		}
	}

	public unsafe bool useCustomZeroNodeMaxWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomZeroNodeMaxWallCount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomZeroNodeMaxWallCount)) = flag;
		}
	}

	public unsafe int customZeroNodeMaxWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customZeroNodeMaxWallCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customZeroNodeMaxWallCount)) = num;
		}
	}

	public unsafe List<FurnitureClass.FurnitureWallRule> zeroNodeWallRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zeroNodeWallRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClass.FurnitureWallRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zeroNodeWallRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AllowedOpenPlan allowedInOpenPlan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInOpenPlan);
			return *(AllowedOpenPlan*)num;
		}
		set
		{
			*(AllowedOpenPlan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInOpenPlan)) = allowedOpenPlan;
		}
	}

	public unsafe bool allowInResidential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInResidential);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInResidential)) = flag;
		}
	}

	public unsafe bool allowInCompanies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInCompanies);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInCompanies)) = flag;
		}
	}

	public unsafe bool allowOnStreets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowOnStreets);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowOnStreets)) = flag;
		}
	}

	public unsafe bool coastalOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastalOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastalOnly)) = flag;
		}
	}

	public unsafe bool limitToDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToDistricts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToDistricts)) = flag;
		}
	}

	public unsafe List<DistrictPreset> allowedInDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInDistricts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInDistricts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool banFromDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromDistricts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromDistricts)) = flag;
		}
	}

	public unsafe List<DistrictPreset> notAllowedInDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAllowedInDistricts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAllowedInDistricts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool skipIfNoAddressInhabitants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfNoAddressInhabitants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfNoAddressInhabitants)) = flag;
		}
	}

	public unsafe bool onlySkipNoInhabitantsIfResidenceOrCompany
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySkipNoInhabitantsIfResidenceOrCompany);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySkipNoInhabitantsIfResidenceOrCompany)) = flag;
		}
	}

	public unsafe List<RoomClassPreset> dontSkipNoInhabitantsIfIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSkipNoInhabitantsIfIn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomClassPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSkipNoInhabitantsIfIn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RoomTypeFilter> allowedRoomFilters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedRoomFilters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypeFilter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedRoomFilters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool limitPerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom)) = flag;
		}
	}

	public unsafe int maximumPerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumPerRoom);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumPerRoom)) = num;
		}
	}

	public unsafe bool limitPerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress)) = flag;
		}
	}

	public unsafe int maximumPerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumPerAddress);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumPerAddress)) = num;
		}
	}

	public unsafe bool limitToFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloor)) = flag;
		}
	}

	public unsafe int allowedOnFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloor)) = num;
		}
	}

	public unsafe bool limitToFloorRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloorRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloorRange)) = flag;
		}
	}

	public unsafe Vector2Int allowedOnFloorRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloorRange);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloorRange)) = vector2Int;
		}
	}

	public unsafe bool wealthLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wealthLimit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wealthLimit)) = flag;
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

	public unsafe bool useRoomGrub
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRoomGrub);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRoomGrub)) = flag;
		}
	}

	public unsafe float minimumGrub
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumGrub);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumGrub)) = num;
		}
	}

	public unsafe float maximumGrub
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumGrub);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumGrub)) = num;
		}
	}

	public unsafe bool useBuildingResidences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingResidences);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingResidences)) = flag;
		}
	}

	public unsafe int minimumResidences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumResidences);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumResidences)) = num;
		}
	}

	public unsafe int maximumResidences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumResidences);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumResidences)) = num;
		}
	}

	public unsafe List<FurnitureCluster> addClustersOnSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addClustersOnSuccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureCluster>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addClustersOnSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FurnitureCluster> removeClustersOnSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeClustersOnSuccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureCluster>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeClustersOnSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FurnitureCluster> removeClustersOnFail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeClustersOnFail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureCluster>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeClustersOnFail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool securityDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityDoor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityDoor)) = flag;
		}
	}

	public unsafe bool isBreakerBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBreakerBox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBreakerBox)) = flag;
		}
	}

	public unsafe bool enableDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDebug)) = flag;
		}
	}

	static FurnitureCluster()
	{
		Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FurnitureCluster");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr);
		NativeFieldInfoPtr_disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "disable");
		NativeFieldInfoPtr_clusterElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "clusterElements");
		NativeFieldInfoPtr_placementChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "placementChance");
		NativeFieldInfoPtr_roomPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "roomPriority");
		NativeFieldInfoPtr_modifyPriorityTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "modifyPriorityTraits");
		NativeFieldInfoPtr_modifyPlacementChanceTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "modifyPlacementChanceTraits");
		NativeFieldInfoPtr_essentialFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "essentialFurniture");
		NativeFieldInfoPtr_updatePreCalculated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "updatePreCalculated");
		NativeFieldInfoPtr_calculatedMinRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "calculatedMinRoomSize");
		NativeFieldInfoPtr_minimumZeroNodeWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "minimumZeroNodeWallCount");
		NativeFieldInfoPtr_maximumZeroNodeWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "maximumZeroNodeWallCount");
		NativeFieldInfoPtr_zeroNodeClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "zeroNodeClasses");
		NativeFieldInfoPtr_minimumRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "minimumRoomSize");
		NativeFieldInfoPtr_useMaximumRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "useMaximumRoomSize");
		NativeFieldInfoPtr_maximumRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "maximumRoomSize");
		NativeFieldInfoPtr_useCustomZeroNodeMinWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "useCustomZeroNodeMinWallCount");
		NativeFieldInfoPtr_customZeroNodeMinWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "customZeroNodeMinWallCount");
		NativeFieldInfoPtr_useCustomZeroNodeMaxWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "useCustomZeroNodeMaxWallCount");
		NativeFieldInfoPtr_customZeroNodeMaxWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "customZeroNodeMaxWallCount");
		NativeFieldInfoPtr_zeroNodeWallRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "zeroNodeWallRules");
		NativeFieldInfoPtr_allowedInOpenPlan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowedInOpenPlan");
		NativeFieldInfoPtr_allowInResidential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowInResidential");
		NativeFieldInfoPtr_allowInCompanies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowInCompanies");
		NativeFieldInfoPtr_allowOnStreets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowOnStreets");
		NativeFieldInfoPtr_coastalOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "coastalOnly");
		NativeFieldInfoPtr_limitToDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "limitToDistricts");
		NativeFieldInfoPtr_allowedInDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowedInDistricts");
		NativeFieldInfoPtr_banFromDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "banFromDistricts");
		NativeFieldInfoPtr_notAllowedInDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "notAllowedInDistricts");
		NativeFieldInfoPtr_skipIfNoAddressInhabitants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "skipIfNoAddressInhabitants");
		NativeFieldInfoPtr_onlySkipNoInhabitantsIfResidenceOrCompany = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "onlySkipNoInhabitantsIfResidenceOrCompany");
		NativeFieldInfoPtr_dontSkipNoInhabitantsIfIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "dontSkipNoInhabitantsIfIn");
		NativeFieldInfoPtr_allowedRoomFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowedRoomFilters");
		NativeFieldInfoPtr_limitPerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "limitPerRoom");
		NativeFieldInfoPtr_maximumPerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "maximumPerRoom");
		NativeFieldInfoPtr_limitPerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "limitPerAddress");
		NativeFieldInfoPtr_maximumPerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "maximumPerAddress");
		NativeFieldInfoPtr_limitToFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "limitToFloor");
		NativeFieldInfoPtr_allowedOnFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowedOnFloor");
		NativeFieldInfoPtr_limitToFloorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "limitToFloorRange");
		NativeFieldInfoPtr_allowedOnFloorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "allowedOnFloorRange");
		NativeFieldInfoPtr_wealthLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "wealthLimit");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_maximumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "maximumWealth");
		NativeFieldInfoPtr_useRoomGrub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "useRoomGrub");
		NativeFieldInfoPtr_minimumGrub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "minimumGrub");
		NativeFieldInfoPtr_maximumGrub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "maximumGrub");
		NativeFieldInfoPtr_useBuildingResidences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "useBuildingResidences");
		NativeFieldInfoPtr_minimumResidences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "minimumResidences");
		NativeFieldInfoPtr_maximumResidences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "maximumResidences");
		NativeFieldInfoPtr_addClustersOnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "addClustersOnSuccess");
		NativeFieldInfoPtr_removeClustersOnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "removeClustersOnSuccess");
		NativeFieldInfoPtr_removeClustersOnFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "removeClustersOnFail");
		NativeFieldInfoPtr_securityDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "securityDoor");
		NativeFieldInfoPtr_isBreakerBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "isBreakerBox");
		NativeFieldInfoPtr_enableDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, "enableDebug");
		NativeMethodInfoPtr_UpdatePreCalculatedLimits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, 100673919);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr, 100673920);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328685, XrefRangeEnd = 328732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePreCalculatedLimits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePreCalculatedLimits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328732, XrefRangeEnd = 328798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FurnitureCluster()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureCluster>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FurnitureCluster(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
