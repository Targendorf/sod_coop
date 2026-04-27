using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SnailController : MonoBehaviour
{
	[System.Serializable]
	public class SnailSaveData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_rot;

		private static readonly System.IntPtr NativeFieldInfoPtr_inAirVent;

		private static readonly System.IntPtr NativeFieldInfoPtr_duct;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		public unsafe Quaternion rot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot)) = quaternion;
			}
		}

		public unsafe bool inAirVent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inAirVent);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inAirVent)) = flag;
			}
		}

		public unsafe int duct
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct)) = num;
			}
		}

		static SnailSaveData()
		{
			Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "SnailSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr);
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr, "rot");
			NativeFieldInfoPtr_inAirVent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr, "inAirVent");
			NativeFieldInfoPtr_duct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr, "duct");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr, 100673768);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnailSaveData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnailSaveData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SnailSaveData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public sealed class SnailSearchVector : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_startPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_forwards;

		private static readonly System.IntPtr NativeFieldInfoPtr_up;

		private static readonly System.IntPtr NativeFieldInfoPtr_previousPoints;

		public unsafe Vector3 startPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPoint);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPoint)) = vector;
			}
		}

		public unsafe Vector3 forwards
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwards);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwards)) = vector;
			}
		}

		public unsafe Vector3 up
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up)) = vector;
			}
		}

		public unsafe List<Vector3> previousPoints
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousPoints);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousPoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static SnailSearchVector()
		{
			Il2CppClassPointerStore<SnailSearchVector>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "SnailSearchVector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnailSearchVector>.NativeClassPtr);
			NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSearchVector>.NativeClassPtr, "startPoint");
			NativeFieldInfoPtr_forwards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSearchVector>.NativeClassPtr, "forwards");
			NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSearchVector>.NativeClassPtr, "up");
			NativeFieldInfoPtr_previousPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailSearchVector>.NativeClassPtr, "previousPoints");
		}

		public SnailSearchVector(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SnailSearchVector()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnailSearchVector>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public sealed class SnailPath : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_vent;

		private static readonly System.IntPtr NativeFieldInfoPtr_duct;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_AirDuctSection_0;

		public unsafe Vector3 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		public unsafe bool vent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vent);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vent)) = flag;
			}
		}

		public unsafe AirDuctGroup.AirDuctSection duct
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AirDuctGroup.AirDuctSection>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)airDuctSection));
			}
		}

		static SnailPath()
		{
			Il2CppClassPointerStore<SnailPath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "SnailPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnailPath>.NativeClassPtr);
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailPath>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_vent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailPath>.NativeClassPtr, "vent");
			NativeFieldInfoPtr_duct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailPath>.NativeClassPtr, "duct");
			NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailPath>.NativeClassPtr, 100673769);
			NativeMethodInfoPtr__ctor_Public_Void_Vector3_AirDuctSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailPath>.NativeClassPtr, 100673770);
		}

		[CallerCount(0)]
		public unsafe SnailPath(Vector3 newPos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnailPath>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&newPos);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe SnailPath(Vector3 newPos, AirDuctGroup.AirDuctSection newDuct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnailPath>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&newPos);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newDuct);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_AirDuctSection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SnailPath(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SnailPath()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnailPath>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("SnailController+<>c__DisplayClass37_0")]
	public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_loadSnailPos;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetupNewSnail_b__0_Internal_Boolean_AirDuctGroup_0;

		public unsafe SnailSaveData loadSnailPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadSnailPos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SnailSaveData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadSnailPos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)snailSaveData));
			}
		}

		static __c__DisplayClass37_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "<>c__DisplayClass37_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr);
			NativeFieldInfoPtr_loadSnailPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr, "loadSnailPos");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr, 100673771);
			NativeMethodInfoPtr__SetupNewSnail_b__0_Internal_Boolean_AirDuctGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr, 100673772);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass37_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass37_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _SetupNewSnail_b__0(AirDuctGroup item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetupNewSnail_b__0_Internal_Boolean_AirDuctGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass37_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_inAirVent;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAirDuctGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAirDuctSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_snailLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointCloudLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_snailSlimePrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_slimeTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_pathCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRouteWhenPlayerWasAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_closePathUpdateTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_distancePathUpdateTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerXZDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_surfaceOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_surfaceNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceDirectionSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_psuedoGravity;

	private static readonly System.IntPtr NativeFieldInfoPtr_snailSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDestination;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_points;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointsGeneratedForRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPointCloudPathNodeReached;

	private static readonly System.IntPtr NativeFieldInfoPtr_closestPlayerCloudPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_sampleTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_samplePositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_snailUnstuckTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_upAlignSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_forwardTurnSpeed;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupNewSnail_Public_Void_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupNewSnail_Public_Void_SnailSaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartAudio_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_SnailSaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePath_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateStuckPath_Private_SnailPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveSnailMovement_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveSnail_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTraversalYConditions_Public_Vector3_Vector3_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PathAdvanceCheck_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSurface_Private_Boolean_byref_RaycastHit_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInRenderedRoom_Private_Boolean_byref_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SamplePositionTest_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdvancePath_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TouchPlayerCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SnailCustomPathfind_Public_List_1_SnailPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PathfindIncludingVentSystem_Public_List_1_SnailPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindClosestVentThatConnectsToPlayer_Private_AirVent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoesCurrentDuctConnectWithPlayer_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAirDuctPathfind_Public_Boolean_AirDuctSection_AirDuctSection_Boolean_byref_List_1_AirDuctSection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInAirDuct_Public_Void_Boolean_AirDuctSection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentNodePos_Public_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroundLevelPlayerPosition_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSameRoomPathingRoute_Public_List_1_SnailPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrimPath_Private_List_1_SnailPath_List_1_SnailPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SnailRaycast_Private_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCurrentRoomPointCloud_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerLocationPoints_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPlayerCloudPoint_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRouteFromPointCloud_Public_Boolean_byref_List_1_SnailPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCeilingHeight_Private_Single_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoundedVector3_Private_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool inAirVent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inAirVent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inAirVent)) = flag;
		}
	}

	public unsafe AirDuctGroup currentAirDuctGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAirDuctGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AirDuctGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAirDuctGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)airDuctGroup));
		}
	}

	public unsafe AirDuctGroup.AirDuctSection currentAirDuctSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAirDuctSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AirDuctGroup.AirDuctSection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAirDuctSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)airDuctSection));
		}
	}

	public unsafe int snailLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailLayerMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailLayerMask)) = num;
		}
	}

	public unsafe int pointCloudLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointCloudLayerMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointCloudLayerMask)) = num;
		}
	}

	public unsafe AudioController.LoopingSoundInfo audioLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioLoop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioLoop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe GameObject snailSlimePrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailSlimePrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailSlimePrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float slimeTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slimeTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slimeTimer)) = num;
		}
	}

	public unsafe List<SnailPath> currentPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPath);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SnailPath>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPath)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int pathCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathCursor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathCursor)) = num;
		}
	}

	public unsafe NewNode lastRouteWhenPlayerWasAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRouteWhenPlayerWasAt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRouteWhenPlayerWasAt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe float closePathUpdateTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closePathUpdateTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closePathUpdateTimer)) = num;
		}
	}

	public unsafe float distancePathUpdateTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distancePathUpdateTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distancePathUpdateTimer)) = num;
		}
	}

	public unsafe float playerXZDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXZDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXZDistance)) = num;
		}
	}

	public unsafe float movementAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementAmount)) = num;
		}
	}

	public unsafe float surfaceOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceOffset)) = num;
		}
	}

	public unsafe Vector3 surfaceNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceNormal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceNormal)) = vector;
		}
	}

	public unsafe float probeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeRange)) = num;
		}
	}

	public unsafe float faceDirectionSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceDirectionSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceDirectionSpeed)) = num;
		}
	}

	public unsafe float psuedoGravity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_psuedoGravity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_psuedoGravity)) = num;
		}
	}

	public unsafe float snailSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailSpeed)) = num;
		}
	}

	public unsafe Vector3 currentDestination
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDestination);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDestination)) = vector;
		}
	}

	public unsafe float stopDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopDistance)) = num;
		}
	}

	public unsafe Dictionary<Vector3, List<Vector3>> points
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_points);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3, List<Vector3>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_points)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe NewRoom pointsGeneratedForRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointsGeneratedForRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointsGeneratedForRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe Vector3 lastPointCloudPathNodeReached
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPointCloudPathNodeReached);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPointCloudPathNodeReached)) = vector;
		}
	}

	public unsafe Vector3 closestPlayerCloudPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestPlayerCloudPoint);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestPlayerCloudPoint)) = vector;
		}
	}

	public unsafe float sampleTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleTimer)) = num;
		}
	}

	public unsafe List<Vector3> samplePositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samplePositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samplePositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float snailUnstuckTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailUnstuckTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snailUnstuckTimer)) = num;
		}
	}

	public unsafe Vector3 currentNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentNormal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentNormal)) = vector;
		}
	}

	public unsafe float upAlignSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upAlignSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upAlignSpeed)) = num;
		}
	}

	public unsafe float forwardTurnSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardTurnSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardTurnSpeed)) = num;
		}
	}

	static SnailController()
	{
		Il2CppClassPointerStore<SnailController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SnailController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnailController>.NativeClassPtr);
		NativeFieldInfoPtr_inAirVent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "inAirVent");
		NativeFieldInfoPtr_currentAirDuctGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "currentAirDuctGroup");
		NativeFieldInfoPtr_currentAirDuctSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "currentAirDuctSection");
		NativeFieldInfoPtr_snailLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "snailLayerMask");
		NativeFieldInfoPtr_pointCloudLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "pointCloudLayerMask");
		NativeFieldInfoPtr_audioLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "audioLoop");
		NativeFieldInfoPtr_snailSlimePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "snailSlimePrefab");
		NativeFieldInfoPtr_slimeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "slimeTimer");
		NativeFieldInfoPtr_currentPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "currentPath");
		NativeFieldInfoPtr_pathCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "pathCursor");
		NativeFieldInfoPtr_lastRouteWhenPlayerWasAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "lastRouteWhenPlayerWasAt");
		NativeFieldInfoPtr_closePathUpdateTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "closePathUpdateTimer");
		NativeFieldInfoPtr_distancePathUpdateTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "distancePathUpdateTimer");
		NativeFieldInfoPtr_playerXZDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "playerXZDistance");
		NativeFieldInfoPtr_movementAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "movementAmount");
		NativeFieldInfoPtr_surfaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "surfaceOffset");
		NativeFieldInfoPtr_surfaceNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "surfaceNormal");
		NativeFieldInfoPtr_probeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "probeRange");
		NativeFieldInfoPtr_faceDirectionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "faceDirectionSpeed");
		NativeFieldInfoPtr_psuedoGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "psuedoGravity");
		NativeFieldInfoPtr_snailSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "snailSpeed");
		NativeFieldInfoPtr_currentDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "currentDestination");
		NativeFieldInfoPtr_stopDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "stopDistance");
		NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "points");
		NativeFieldInfoPtr_pointsGeneratedForRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "pointsGeneratedForRoom");
		NativeFieldInfoPtr_lastPointCloudPathNodeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "lastPointCloudPathNodeReached");
		NativeFieldInfoPtr_closestPlayerCloudPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "closestPlayerCloudPoint");
		NativeFieldInfoPtr_sampleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "sampleTimer");
		NativeFieldInfoPtr_samplePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "samplePositions");
		NativeFieldInfoPtr_snailUnstuckTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "snailUnstuckTimer");
		NativeFieldInfoPtr_currentNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "currentNormal");
		NativeFieldInfoPtr_upAlignSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "upAlignSpeed");
		NativeFieldInfoPtr_forwardTurnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnailController>.NativeClassPtr, "forwardTurnSpeed");
		NativeMethodInfoPtr_SetupNewSnail_Public_Void_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673733);
		NativeMethodInfoPtr_SetupNewSnail_Public_Void_SnailSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673734);
		NativeMethodInfoPtr_StartAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673735);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673736);
		NativeMethodInfoPtr_GetSaveData_Public_SnailSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673737);
		NativeMethodInfoPtr_UpdatePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673738);
		NativeMethodInfoPtr_GenerateStuckPath_Private_SnailPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673739);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673740);
		NativeMethodInfoPtr_ResolveSnailMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673741);
		NativeMethodInfoPtr_MoveSnail_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673742);
		NativeMethodInfoPtr_ApplyTraversalYConditions_Public_Vector3_Vector3_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673743);
		NativeMethodInfoPtr_PathAdvanceCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673744);
		NativeMethodInfoPtr_FindSurface_Private_Boolean_byref_RaycastHit_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673745);
		NativeMethodInfoPtr_IsInRenderedRoom_Private_Boolean_byref_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673746);
		NativeMethodInfoPtr_SamplePositionTest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673747);
		NativeMethodInfoPtr_AdvancePath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673748);
		NativeMethodInfoPtr_TouchPlayerCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673749);
		NativeMethodInfoPtr_SnailCustomPathfind_Public_List_1_SnailPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673750);
		NativeMethodInfoPtr_PathfindIncludingVentSystem_Public_List_1_SnailPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673751);
		NativeMethodInfoPtr_FindClosestVentThatConnectsToPlayer_Private_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673752);
		NativeMethodInfoPtr_DoesCurrentDuctConnectWithPlayer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673753);
		NativeMethodInfoPtr_TryAirDuctPathfind_Public_Boolean_AirDuctSection_AirDuctSection_Boolean_byref_List_1_AirDuctSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673754);
		NativeMethodInfoPtr_SetInAirDuct_Public_Void_Boolean_AirDuctSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673755);
		NativeMethodInfoPtr_GetCurrentNodePos_Public_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673756);
		NativeMethodInfoPtr_GetGroundLevelPlayerPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673757);
		NativeMethodInfoPtr_GetSameRoomPathingRoute_Public_List_1_SnailPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673758);
		NativeMethodInfoPtr_TrimPath_Private_List_1_SnailPath_List_1_SnailPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673759);
		NativeMethodInfoPtr_SnailRaycast_Private_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673760);
		NativeMethodInfoPtr_GenerateCurrentRoomPointCloud_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673761);
		NativeMethodInfoPtr_AddPlayerLocationPoints_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673762);
		NativeMethodInfoPtr_GetClosestPlayerCloudPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673763);
		NativeMethodInfoPtr_GetRouteFromPointCloud_Public_Boolean_byref_List_1_SnailPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673764);
		NativeMethodInfoPtr_GetCeilingHeight_Private_Single_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673765);
		NativeMethodInfoPtr_GetRoundedVector3_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673766);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnailController>.NativeClassPtr, 100673767);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 324492, RefRangeEnd = 324493, XrefRangeStart = 324469, XrefRangeEnd = 324492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupNewSnail(NewNode startingNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startingNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupNewSnail_Public_Void_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324493, XrefRangeEnd = 324561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupNewSnail(SnailSaveData loadSnailPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loadSnailPos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupNewSnail_Public_Void_SnailSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 324576, RefRangeEnd = 324578, XrefRangeStart = 324561, XrefRangeEnd = 324576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAudio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324578, XrefRangeEnd = 324594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 324616, RefRangeEnd = 324617, XrefRangeStart = 324594, XrefRangeEnd = 324616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SnailSaveData GetSaveData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSaveData_Public_SnailSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SnailSaveData>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 324699, RefRangeEnd = 324704, XrefRangeStart = 324617, XrefRangeEnd = 324699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 324766, RefRangeEnd = 324767, XrefRangeStart = 324704, XrefRangeEnd = 324766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SnailPath GenerateStuckPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateStuckPath_Private_SnailPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new SnailPath(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324767, XrefRangeEnd = 324833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324833, XrefRangeEnd = 324841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResolveSnailMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveSnailMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 325028, RefRangeEnd = 325030, XrefRangeStart = 324841, XrefRangeEnd = 325028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveSnail(float movementAmount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&movementAmount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveSnail_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325030, XrefRangeEnd = 325032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ApplyTraversalYConditions(Vector3 input, NewNode currentNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTraversalYConditions_Public_Vector3_Vector3_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325032, XrefRangeEnd = 325038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PathAdvanceCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PathAdvanceCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 325102, RefRangeEnd = 325103, XrefRangeStart = 325038, XrefRangeEnd = 325102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindSurface(out RaycastHit bestHit, out bool useGroundLevelTarget, bool includeBackwardsDiagonal = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref bestHit);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref useGroundLevelTarget);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeBackwardsDiagonal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSurface_Private_Boolean_byref_RaycastHit_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325103, XrefRangeEnd = 325132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInRenderedRoom(out NewNode currentNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInRenderedRoom_Private_Boolean_byref_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num2 = num;
		currentNode = ((num2 == 0) ? null : new NewNode(num2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325132, XrefRangeEnd = 325176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SamplePositionTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SamplePositionTest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 325179, RefRangeEnd = 325181, XrefRangeStart = 325176, XrefRangeEnd = 325179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdvancePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdvancePath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 325255, RefRangeEnd = 325256, XrefRangeStart = 325181, XrefRangeEnd = 325255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TouchPlayerCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TouchPlayerCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 325289, RefRangeEnd = 325290, XrefRangeStart = 325256, XrefRangeEnd = 325289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SnailPath> SnailCustomPathfind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnailCustomPathfind_Public_List_1_SnailPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SnailPath>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325290, XrefRangeEnd = 325548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SnailPath> PathfindIncludingVentSystem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PathfindIncludingVentSystem_Public_List_1_SnailPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SnailPath>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 325595, RefRangeEnd = 325596, XrefRangeStart = 325548, XrefRangeEnd = 325595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AirDuctGroup.AirVent FindClosestVentThatConnectsToPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindClosestVentThatConnectsToPlayer_Private_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AirDuctGroup.AirVent>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325596, XrefRangeEnd = 325599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DoesCurrentDuctConnectWithPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoesCurrentDuctConnectWithPlayer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 325661, RefRangeEnd = 325666, XrefRangeStart = 325599, XrefRangeEnd = 325661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAirDuctPathfind(AirDuctGroup.AirDuctSection origin, AirDuctGroup.AirDuctSection destination, bool findNearestExitInstead, out List<AirDuctGroup.AirDuctSection> ret)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &findNearestExitInstead;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAirDuctPathfind_Public_Boolean_AirDuctSection_AirDuctSection_Boolean_byref_List_1_AirDuctSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		ret = ((num3 == 0) ? null : new List<AirDuctGroup.AirDuctSection>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 325666, RefRangeEnd = 325668, XrefRangeStart = 325666, XrefRangeEnd = 325666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInAirDuct(bool isIn, AirDuctGroup.AirDuctSection setToSection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isIn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)setToSection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInAirDuct_Public_Void_Boolean_AirDuctSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 325709, RefRangeEnd = 325721, XrefRangeStart = 325668, XrefRangeEnd = 325709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode GetCurrentNodePos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentNodePos_Public_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 325731, RefRangeEnd = 325732, XrefRangeStart = 325721, XrefRangeEnd = 325731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetGroundLevelPlayerPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroundLevelPlayerPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 325813, RefRangeEnd = 325814, XrefRangeStart = 325732, XrefRangeEnd = 325813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SnailPath> GetSameRoomPathingRoute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSameRoomPathingRoute_Public_List_1_SnailPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SnailPath>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 325829, RefRangeEnd = 325830, XrefRangeStart = 325814, XrefRangeEnd = 325829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<SnailPath> TrimPath(List<SnailPath> input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrimPath_Private_List_1_SnailPath_List_1_SnailPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SnailPath>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 325938, RefRangeEnd = 325942, XrefRangeStart = 325830, XrefRangeEnd = 325938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SnailRaycast(Vector3 origin, Vector3 direction, out RaycastHit hit, float range, int layerMask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hit);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnailRaycast_Private_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 326142, RefRangeEnd = 326145, XrefRangeStart = 325942, XrefRangeEnd = 326142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateCurrentRoomPointCloud()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCurrentRoomPointCloud_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 326259, RefRangeEnd = 326262, XrefRangeStart = 326145, XrefRangeEnd = 326259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPlayerLocationPoints(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerLocationPoints_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 326285, RefRangeEnd = 326286, XrefRangeStart = 326262, XrefRangeEnd = 326285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetClosestPlayerCloudPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClosestPlayerCloudPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 326392, RefRangeEnd = 326393, XrefRangeStart = 326286, XrefRangeEnd = 326392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetRouteFromPointCloud(out List<SnailPath> ret)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRouteFromPointCloud_Public_Boolean_byref_List_1_SnailPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num2 = num;
		ret = ((num2 == 0) ? null : new List<SnailPath>(num2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 326404, RefRangeEnd = 326407, XrefRangeStart = 326393, XrefRangeEnd = 326404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetCeilingHeight(NewNode forNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCeilingHeight_Private_Single_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 326416, RefRangeEnd = 326424, XrefRangeStart = 326407, XrefRangeEnd = 326416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetRoundedVector3(Vector3 v3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v3);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoundedVector3_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326424, XrefRangeEnd = 326448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SnailController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnailController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SnailController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
