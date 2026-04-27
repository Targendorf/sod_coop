using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class LightCullingController : MonoBehaviour
{
	public sealed class LightRaycastData : Il2CppSystem.ValueType
	{
		public enum RayType
		{
			lightToCam,
			lightToFeet,
			lightToRadiusPoint,
			radiusPointToCam
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_rayType;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightRef;

		private static readonly System.IntPtr NativeFieldInfoPtr_originPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_direction;

		private static readonly System.IntPtr NativeFieldInfoPtr_range;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LightController_RayType_Vector3_Vector3_Single_0;

		public unsafe RayType rayType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayType);
				return *(RayType*)num;
			}
			set
			{
				*(RayType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayType)) = rayType;
			}
		}

		public unsafe LightController lightRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRef);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightController));
			}
		}

		public unsafe Vector3 originPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originPoint);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originPoint)) = vector;
			}
		}

		public unsafe Vector3 direction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = vector;
			}
		}

		public unsafe float range
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range)) = num;
			}
		}

		static LightRaycastData()
		{
			Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "LightRaycastData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr);
			NativeFieldInfoPtr_rayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr, "rayType");
			NativeFieldInfoPtr_lightRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr, "lightRef");
			NativeFieldInfoPtr_originPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr, "originPoint");
			NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr, "direction");
			NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr, "range");
			NativeMethodInfoPtr__ctor_Public_Void_LightController_RayType_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr, 100668410);
		}

		[CallerCount(0)]
		public unsafe LightRaycastData(LightController newLightRef, RayType newRayType, Vector3 newOriginPoint, Vector3 newDir, float newRange)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLightRef);
			*(RayType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newRayType;
			*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newOriginPoint;
			*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newDir;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LightController_RayType_Vector3_Vector3_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LightRaycastData(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public LightRaycastData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightRaycastData>.NativeClassPtr))
		{
		}
	}

	public sealed class SetupCommandJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_commands;

		private static readonly System.IntPtr NativeFieldInfoPtr_directions;

		private static readonly System.IntPtr NativeFieldInfoPtr_origins;

		private static readonly System.IntPtr NativeFieldInfoPtr_ranges;

		private static readonly System.IntPtr NativeFieldInfoPtr_mask;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe NativeArray<RaycastCommand> commands
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commands);
				return new NativeArray<RaycastCommand>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Vector3> directions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directions);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Vector3> origins
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origins);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origins), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float> ranges
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranges);
				return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int mask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask)) = num;
			}
		}

		static SetupCommandJob()
		{
			Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "SetupCommandJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr);
			NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr, "commands");
			NativeFieldInfoPtr_directions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr, "directions");
			NativeFieldInfoPtr_origins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr, "origins");
			NativeFieldInfoPtr_ranges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr, "ranges");
			NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr, "mask");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr, 100668411);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171885, XrefRangeEnd = 171887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SetupCommandJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SetupCommandJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupCommandJob>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_lightsToCheckPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_radiusChecksPerLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumLightUnculledTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightsToCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkingCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightsCheckedThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_culledLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_handlePrimary;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultsPrimary;

	private static readonly System.IntPtr NativeFieldInfoPtr_commandsPrimary;

	private static readonly System.IntPtr NativeFieldInfoPtr_originsPrimary;

	private static readonly System.IntPtr NativeFieldInfoPtr_directionsPrimary;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangePrimary;

	private static readonly System.IntPtr NativeFieldInfoPtr_primaryJobsActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_primaryJobsCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_handleSecondary;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultsSecondary;

	private static readonly System.IntPtr NativeFieldInfoPtr_commandsSecondary;

	private static readonly System.IntPtr NativeFieldInfoPtr_originsSecondary;

	private static readonly System.IntPtr NativeFieldInfoPtr_directionsSecondary;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangeSecondary;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondaryJobsActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondaryJobsCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_notCulled;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightRaycastDataCollectionFromRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightRaycastDataCollection;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_LightCullingController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int lightsToCheckPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsToCheckPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsToCheckPerFrame)) = num;
		}
	}

	public unsafe Vector2 radiusChecksPerLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radiusChecksPerLight);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radiusChecksPerLight)) = vector;
		}
	}

	public unsafe float minimumLightUnculledTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLightUnculledTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLightUnculledTime)) = num;
		}
	}

	public unsafe List<LightController> lightsToCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsToCheck);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsToCheck)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int checkingCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkingCursor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkingCursor)) = num;
		}
	}

	public unsafe List<LightController> lightsCheckedThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsCheckedThisFrame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsCheckedThisFrame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LightController> culledLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culledLights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culledLights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe JobHandle handlePrimary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handlePrimary);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handlePrimary)) = jobHandle;
		}
	}

	public unsafe NativeArray<RaycastHit> resultsPrimary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultsPrimary);
			return new NativeArray<RaycastHit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultsPrimary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<RaycastCommand> commandsPrimary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandsPrimary);
			return new NativeArray<RaycastCommand>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandsPrimary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> originsPrimary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originsPrimary);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originsPrimary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> directionsPrimary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionsPrimary);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionsPrimary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> rangePrimary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangePrimary);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangePrimary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool primaryJobsActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryJobsActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryJobsActive)) = flag;
		}
	}

	public unsafe bool primaryJobsCompleted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryJobsCompleted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primaryJobsCompleted)) = flag;
		}
	}

	public unsafe JobHandle handleSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handleSecondary);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handleSecondary)) = jobHandle;
		}
	}

	public unsafe NativeArray<RaycastHit> resultsSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultsSecondary);
			return new NativeArray<RaycastHit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultsSecondary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<RaycastCommand> commandsSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandsSecondary);
			return new NativeArray<RaycastCommand>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandsSecondary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> originsSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originsSecondary);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originsSecondary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> directionsSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionsSecondary);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionsSecondary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> rangeSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeSecondary);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeSecondary), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool secondaryJobsActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryJobsActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryJobsActive)) = flag;
		}
	}

	public unsafe bool secondaryJobsCompleted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryJobsCompleted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryJobsCompleted)) = flag;
		}
	}

	public unsafe List<LightController> notCulled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notCulled);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notCulled)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LightRaycastData> lightRaycastDataCollectionFromRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRaycastDataCollectionFromRadius);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightRaycastData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRaycastDataCollectionFromRadius)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LightRaycastData> lightRaycastDataCollection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRaycastDataCollection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightRaycastData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightRaycastDataCollection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static LightCullingController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightCullingController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightCullingController));
		}
	}

	public unsafe static LightCullingController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171887, XrefRangeEnd = 171889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_LightCullingController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightCullingController>(intPtr) : null;
		}
	}

	static LightCullingController()
	{
		Il2CppClassPointerStore<LightCullingController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LightCullingController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr);
		NativeFieldInfoPtr_lightsToCheckPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "lightsToCheckPerFrame");
		NativeFieldInfoPtr_radiusChecksPerLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "radiusChecksPerLight");
		NativeFieldInfoPtr_minimumLightUnculledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "minimumLightUnculledTime");
		NativeFieldInfoPtr_lightsToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "lightsToCheck");
		NativeFieldInfoPtr_checkingCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "checkingCursor");
		NativeFieldInfoPtr_lightsCheckedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "lightsCheckedThisFrame");
		NativeFieldInfoPtr_culledLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "culledLights");
		NativeFieldInfoPtr_handlePrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "handlePrimary");
		NativeFieldInfoPtr_resultsPrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "resultsPrimary");
		NativeFieldInfoPtr_commandsPrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "commandsPrimary");
		NativeFieldInfoPtr_originsPrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "originsPrimary");
		NativeFieldInfoPtr_directionsPrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "directionsPrimary");
		NativeFieldInfoPtr_rangePrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "rangePrimary");
		NativeFieldInfoPtr_primaryJobsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "primaryJobsActive");
		NativeFieldInfoPtr_primaryJobsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "primaryJobsCompleted");
		NativeFieldInfoPtr_handleSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "handleSecondary");
		NativeFieldInfoPtr_resultsSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "resultsSecondary");
		NativeFieldInfoPtr_commandsSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "commandsSecondary");
		NativeFieldInfoPtr_originsSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "originsSecondary");
		NativeFieldInfoPtr_directionsSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "directionsSecondary");
		NativeFieldInfoPtr_rangeSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "rangeSecondary");
		NativeFieldInfoPtr_secondaryJobsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "secondaryJobsActive");
		NativeFieldInfoPtr_secondaryJobsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "secondaryJobsCompleted");
		NativeFieldInfoPtr_notCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "notCulled");
		NativeFieldInfoPtr_lightRaycastDataCollectionFromRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "lightRaycastDataCollectionFromRadius");
		NativeFieldInfoPtr_lightRaycastDataCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "lightRaycastDataCollection");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_LightCullingController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, 100668405);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, 100668406);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, 100668407);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, 100668408);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr, 100668409);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171889, XrefRangeEnd = 171926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171926, XrefRangeEnd = 171947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171947, XrefRangeEnd = 172059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172059, XrefRangeEnd = 172088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LightCullingController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCullingController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LightCullingController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
