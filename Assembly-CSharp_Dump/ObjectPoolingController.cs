using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ObjectPoolingController : MonoBehaviour
{
	public enum ObjectLoadRange
	{
		veryClose,
		close,
		medium,
		far,
		veryFar,
		maximum
	}

	[System.Serializable]
	public class ObjectLoadRangeConfig : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_range;

		private static readonly System.IntPtr NativeFieldInfoPtr_loadDistance;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ObjectLoadRange range
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range);
				return *(ObjectLoadRange*)num;
			}
			set
			{
				*(ObjectLoadRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range)) = objectLoadRange;
			}
		}

		public unsafe float loadDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadDistance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadDistance)) = num;
			}
		}

		static ObjectLoadRangeConfig()
		{
			Il2CppClassPointerStore<ObjectLoadRangeConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "ObjectLoadRangeConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectLoadRangeConfig>.NativeClassPtr);
			NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLoadRangeConfig>.NativeClassPtr, "range");
			NativeFieldInfoPtr_loadDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLoadRangeConfig>.NativeClassPtr, "loadDistance");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectLoadRangeConfig>.NativeClassPtr, 100670065);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectLoadRangeConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectLoadRangeConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ObjectLoadRangeConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_useGradualSpawning;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadNewObjectPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadPooledObjectPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePooling;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumInteractablePoolCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadRangeConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumRangeCheckingPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomCacheLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRoomCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowGradualRoomLoading;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomsLoadedPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactablesLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactablesToLoadCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactablesRangeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateObjectRangesTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_furntiureCheckCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureToLoadCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureRangeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactablesCurrentlyPooled;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactableInstancesSaved;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactableFullPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomsLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomStuffToLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactableRangeToLoadList;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactableRangeToEnableDisableList;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactableLoadList;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureRangeToLoadList;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureRangeToEnableDisableList;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactablePool;

	private static readonly System.IntPtr NativeFieldInfoPtr_entirePoolReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureCheckingPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomStuffQueuedToLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpdateObjectRange;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ObjectPoolingController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteInteractableCheckingPool_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteFurnitureCheckingPool_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsToLoad_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsNotNeeded_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsToLoad_Public_Void_FurnitureLocation_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsNotNeeded_Public_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateObjectRanges_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteUpdateObjectRanges_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteUpdateObjectRanges_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnRangeCheck_Public_Boolean_Interactable_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnRangeCheck_Public_Boolean_FurnitureLocation_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractableObject_Public_GameObject_Interactable_byref_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromPool_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PoolInteractable_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkRoomStuffToLoad_Public_Void_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkRoomStuffNotNeeded_Public_Void_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteRoomStuffPool_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool useGradualSpawning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGradualSpawning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGradualSpawning)) = flag;
		}
	}

	public unsafe int loadNewObjectPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadNewObjectPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadNewObjectPerFrame)) = num;
		}
	}

	public unsafe int loadPooledObjectPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadPooledObjectPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadPooledObjectPerFrame)) = num;
		}
	}

	public unsafe bool usePooling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePooling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePooling)) = flag;
		}
	}

	public unsafe int maximumInteractablePoolCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumInteractablePoolCache);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumInteractablePoolCache)) = num;
		}
	}

	public unsafe bool useRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRange)) = flag;
		}
	}

	public unsafe List<ObjectLoadRangeConfig> loadRangeConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadRangeConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObjectLoadRangeConfig>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadRangeConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int maximumRangeCheckingPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRangeCheckingPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRangeCheckingPerFrame)) = num;
		}
	}

	public unsafe bool roomCacheLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomCacheLimit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomCacheLimit)) = flag;
		}
	}

	public unsafe int maxRoomCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRoomCache);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRoomCache)) = num;
		}
	}

	public unsafe bool allowGradualRoomLoading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowGradualRoomLoading);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowGradualRoomLoading)) = flag;
		}
	}

	public unsafe int roomsLoadedPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomsLoadedPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomsLoadedPerFrame)) = num;
		}
	}

	public unsafe int interactablesLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesLoaded);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesLoaded)) = num;
		}
	}

	public unsafe int interactablesToLoadCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesToLoadCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesToLoadCount)) = num;
		}
	}

	public unsafe int interactablesRangeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesRangeCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesRangeCount)) = num;
		}
	}

	public unsafe float updateObjectRangesTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateObjectRangesTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateObjectRangesTimer)) = num;
		}
	}

	public unsafe int furntiureCheckCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furntiureCheckCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furntiureCheckCount)) = num;
		}
	}

	public unsafe int furnitureToLoadCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureToLoadCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureToLoadCount)) = num;
		}
	}

	public unsafe int furnitureRangeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRangeCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRangeCount)) = num;
		}
	}

	public unsafe int interactablesCurrentlyPooled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesCurrentlyPooled);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablesCurrentlyPooled)) = num;
		}
	}

	public unsafe int interactableInstancesSaved
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableInstancesSaved);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableInstancesSaved)) = num;
		}
	}

	public unsafe float interactableFullPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableFullPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableFullPercentage)) = num;
		}
	}

	public unsafe int roomsLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomsLoaded);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomsLoaded)) = num;
		}
	}

	public unsafe int roomStuffToLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomStuffToLoad);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomStuffToLoad)) = num;
		}
	}

	public unsafe Dictionary<int, float> loadRanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadRanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadRanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Interactable> interactableRangeToLoadList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableRangeToLoadList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableRangeToLoadList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> interactableRangeToEnableDisableList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableRangeToEnableDisableList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableRangeToEnableDisableList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<Interactable> interactableLoadList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableLoadList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableLoadList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<FurnitureLocation> furnitureRangeToLoadList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRangeToLoadList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRangeToLoadList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<FurnitureLocation> furnitureRangeToEnableDisableList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRangeToEnableDisableList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<FurnitureLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRangeToEnableDisableList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<InteractablePreset, HashSet<Interactable>> interactablePool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablePool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InteractablePreset, HashSet<Interactable>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactablePool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<Interactable> entirePoolReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entirePoolReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entirePoolReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<FurnitureLocation> furnitureCheckingPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureCheckingPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<FurnitureLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureCheckingPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<NewRoom> roomStuffQueuedToLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomStuffQueuedToLoad);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomStuffQueuedToLoad)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Il2CppSystem.Action UpdateObjectRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateObjectRange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateObjectRange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static ObjectPoolingController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPoolingController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPoolingController));
		}
	}

	public unsafe static ObjectPoolingController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232801, XrefRangeEnd = 232803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_ObjectPoolingController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPoolingController>(intPtr) : null;
		}
	}

	static ObjectPoolingController()
	{
		Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ObjectPoolingController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr);
		NativeFieldInfoPtr_useGradualSpawning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "useGradualSpawning");
		NativeFieldInfoPtr_loadNewObjectPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "loadNewObjectPerFrame");
		NativeFieldInfoPtr_loadPooledObjectPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "loadPooledObjectPerFrame");
		NativeFieldInfoPtr_usePooling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "usePooling");
		NativeFieldInfoPtr_maximumInteractablePoolCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "maximumInteractablePoolCache");
		NativeFieldInfoPtr_useRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "useRange");
		NativeFieldInfoPtr_loadRangeConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "loadRangeConfig");
		NativeFieldInfoPtr_maximumRangeCheckingPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "maximumRangeCheckingPerFrame");
		NativeFieldInfoPtr_roomCacheLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "roomCacheLimit");
		NativeFieldInfoPtr_maxRoomCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "maxRoomCache");
		NativeFieldInfoPtr_allowGradualRoomLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "allowGradualRoomLoading");
		NativeFieldInfoPtr_roomsLoadedPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "roomsLoadedPerFrame");
		NativeFieldInfoPtr_interactablesLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactablesLoaded");
		NativeFieldInfoPtr_interactablesToLoadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactablesToLoadCount");
		NativeFieldInfoPtr_interactablesRangeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactablesRangeCount");
		NativeFieldInfoPtr_updateObjectRangesTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "updateObjectRangesTimer");
		NativeFieldInfoPtr_furntiureCheckCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "furntiureCheckCount");
		NativeFieldInfoPtr_furnitureToLoadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "furnitureToLoadCount");
		NativeFieldInfoPtr_furnitureRangeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "furnitureRangeCount");
		NativeFieldInfoPtr_interactablesCurrentlyPooled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactablesCurrentlyPooled");
		NativeFieldInfoPtr_interactableInstancesSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactableInstancesSaved");
		NativeFieldInfoPtr_interactableFullPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactableFullPercentage");
		NativeFieldInfoPtr_roomsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "roomsLoaded");
		NativeFieldInfoPtr_roomStuffToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "roomStuffToLoad");
		NativeFieldInfoPtr_loadRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "loadRanges");
		NativeFieldInfoPtr_interactableRangeToLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactableRangeToLoadList");
		NativeFieldInfoPtr_interactableRangeToEnableDisableList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactableRangeToEnableDisableList");
		NativeFieldInfoPtr_interactableLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactableLoadList");
		NativeFieldInfoPtr_furnitureRangeToLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "furnitureRangeToLoadList");
		NativeFieldInfoPtr_furnitureRangeToEnableDisableList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "furnitureRangeToEnableDisableList");
		NativeFieldInfoPtr_interactablePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "interactablePool");
		NativeFieldInfoPtr_entirePoolReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "entirePoolReference");
		NativeFieldInfoPtr_furnitureCheckingPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "furnitureCheckingPool");
		NativeFieldInfoPtr_roomStuffQueuedToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "roomStuffQueuedToLoad");
		NativeFieldInfoPtr_UpdateObjectRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "UpdateObjectRange");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_ObjectPoolingController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670043);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670044);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670045);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670046);
		NativeMethodInfoPtr_ExecuteInteractableCheckingPool_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670047);
		NativeMethodInfoPtr_ExecuteFurnitureCheckingPool_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670048);
		NativeMethodInfoPtr_MarkAsToLoad_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670049);
		NativeMethodInfoPtr_MarkAsNotNeeded_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670050);
		NativeMethodInfoPtr_MarkAsToLoad_Public_Void_FurnitureLocation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670051);
		NativeMethodInfoPtr_MarkAsNotNeeded_Public_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670052);
		NativeMethodInfoPtr_UpdateObjectRanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670053);
		NativeMethodInfoPtr_ExecuteUpdateObjectRanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670054);
		NativeMethodInfoPtr_ExecuteUpdateObjectRanges_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670055);
		NativeMethodInfoPtr_SpawnRangeCheck_Public_Boolean_Interactable_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670056);
		NativeMethodInfoPtr_SpawnRangeCheck_Public_Boolean_FurnitureLocation_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670057);
		NativeMethodInfoPtr_GetInteractableObject_Public_GameObject_Interactable_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670058);
		NativeMethodInfoPtr_RemoveFromPool_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670059);
		NativeMethodInfoPtr_PoolInteractable_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670060);
		NativeMethodInfoPtr_MarkRoomStuffToLoad_Public_Void_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670061);
		NativeMethodInfoPtr_MarkRoomStuffNotNeeded_Public_Void_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670062);
		NativeMethodInfoPtr_ExecuteRoomStuffPool_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670063);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr, 100670064);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232803, XrefRangeEnd = 232861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232861, XrefRangeEnd = 232882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232882, XrefRangeEnd = 232904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232913, RefRangeEnd = 232915, XrefRangeStart = 232904, XrefRangeEnd = 232913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteInteractableCheckingPool(int maxPooledLoops, int maxNewObjectLoops)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&maxPooledLoops);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxNewObjectLoops;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteInteractableCheckingPool_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232943, RefRangeEnd = 232945, XrefRangeStart = 232915, XrefRangeEnd = 232943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteFurnitureCheckingPool(int maxLoops)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxLoops);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteFurnitureCheckingPool_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232982, RefRangeEnd = 232983, XrefRangeStart = 232945, XrefRangeEnd = 232982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkAsToLoad(Interactable interactable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsToLoad_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233010, RefRangeEnd = 233013, XrefRangeStart = 232983, XrefRangeEnd = 233010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkAsNotNeeded(Interactable interactable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsNotNeeded_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233013, XrefRangeEnd = 233015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkAsToLoad(FurnitureLocation furniture, bool forceSpawnImmediate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSpawnImmediate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsToLoad_Public_Void_FurnitureLocation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233022, RefRangeEnd = 233025, XrefRangeStart = 233015, XrefRangeEnd = 233022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkAsNotNeeded(FurnitureLocation furniture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkAsNotNeeded_Public_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 233031, RefRangeEnd = 233036, XrefRangeStart = 233025, XrefRangeEnd = 233031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateObjectRanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateObjectRanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233036, XrefRangeEnd = 233037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteUpdateObjectRanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteUpdateObjectRanges_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233109, RefRangeEnd = 233111, XrefRangeStart = 233037, XrefRangeEnd = 233109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteUpdateObjectRanges(bool forceImmediateSpawning = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceImmediateSpawning);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteUpdateObjectRanges_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 233134, RefRangeEnd = 233138, XrefRangeStart = 233111, XrefRangeEnd = 233134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SpawnRangeCheck(Interactable interactable, out float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnRangeCheck_Public_Boolean_Interactable_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233163, RefRangeEnd = 233165, XrefRangeStart = 233138, XrefRangeEnd = 233163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SpawnRangeCheck(FurnitureLocation furniture, out float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnRangeCheck_Public_Boolean_FurnitureLocation_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233211, RefRangeEnd = 233212, XrefRangeStart = 233165, XrefRangeEnd = 233211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetInteractableObject(Interactable interactable, out bool wasPooled, out bool isSelf)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref wasPooled);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isSelf);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractableObject_Public_GameObject_Interactable_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233221, RefRangeEnd = 233224, XrefRangeStart = 233212, XrefRangeEnd = 233221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFromPool(Interactable interactable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromPool_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233245, RefRangeEnd = 233246, XrefRangeStart = 233224, XrefRangeEnd = 233245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PoolInteractable(Interactable interactable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PoolInteractable_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233246, XrefRangeEnd = 233254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkRoomStuffToLoad(NewRoom room)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkRoomStuffToLoad_Public_Void_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233254, XrefRangeEnd = 233258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkRoomStuffNotNeeded(NewRoom room)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkRoomStuffNotNeeded_Public_Void_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233258, XrefRangeEnd = 233274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteRoomStuffPool(int maxPerFrame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxPerFrame);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteRoomStuffPool_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233274, XrefRangeEnd = 233330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectPoolingController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPoolingController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObjectPoolingController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
