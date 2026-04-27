using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

public class CityConstructor : MonoBehaviour
{
	public enum LoadState
	{
		parsingFile,
		setupCityBoundary,
		generateDistricts,
		generateBlocks,
		generateDensity,
		generateBuildings,
		generatePathfinding,
		generateBlueprints,
		generateCompanies,
		connectRooms,
		generateCitizens,
		generateRelationships,
		gatherData,
		generateAirDucts,
		generateEvidence,
		generateInteriors,
		prepareCitizens,
		loadObjects,
		finalizing,
		savingData,
		loadState,
		preSim,
		loadComplete
	}

	[System.Serializable]
	public class CollectedLoadTimeInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_build;

		private static readonly System.IntPtr NativeFieldInfoPtr_citySize;

		private static readonly System.IntPtr NativeFieldInfoPtr_generateNew;

		private static readonly System.IntPtr NativeFieldInfoPtr_loadTimes;

		private static readonly System.IntPtr NativeFieldInfoPtr_decorTimes;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string build
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string citySize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySize);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySize)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool generateNew
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateNew);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateNew)) = flag;
			}
		}

		public unsafe Dictionary<LoadState, int> loadTimes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadTimes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<LoadState, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadTimes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Dictionary<NewRoom, List<DecorClusterGenerationTimeInfo>> decorTimes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorTimes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewRoom, List<DecorClusterGenerationTimeInfo>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorTimes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		static CollectedLoadTimeInfo()
		{
			Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "CollectedLoadTimeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr);
			NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr, "build");
			NativeFieldInfoPtr_citySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr, "citySize");
			NativeFieldInfoPtr_generateNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr, "generateNew");
			NativeFieldInfoPtr_loadTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr, "loadTimes");
			NativeFieldInfoPtr_decorTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr, "decorTimes");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr, 100664833);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55427, XrefRangeEnd = 55437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectedLoadTimeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectedLoadTimeInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CollectedLoadTimeInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DecorClusterGenerationTimeInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cluster;

		private static readonly System.IntPtr NativeFieldInfoPtr_found;

		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe FurnitureCluster cluster
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cluster);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureCluster>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cluster)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureCluster));
			}
		}

		public unsafe bool found
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_found);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_found)) = flag;
			}
		}

		public unsafe float time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = num;
			}
		}

		static DecorClusterGenerationTimeInfo()
		{
			Il2CppClassPointerStore<DecorClusterGenerationTimeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "DecorClusterGenerationTimeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorClusterGenerationTimeInfo>.NativeClassPtr);
			NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorClusterGenerationTimeInfo>.NativeClassPtr, "cluster");
			NativeFieldInfoPtr_found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorClusterGenerationTimeInfo>.NativeClassPtr, "found");
			NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorClusterGenerationTimeInfo>.NativeClassPtr, "time");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorClusterGenerationTimeInfo>.NativeClassPtr, 100664834);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorClusterGenerationTimeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorClusterGenerationTimeInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DecorClusterGenerationTimeInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DecorTotalTime : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_room;

		private static readonly System.IntPtr NativeFieldInfoPtr_totalTime;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe NewRoom room
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
			}
		}

		public unsafe float totalTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalTime)) = num;
			}
		}

		static DecorTotalTime()
		{
			Il2CppClassPointerStore<DecorTotalTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "DecorTotalTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorTotalTime>.NativeClassPtr);
			NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorTotalTime>.NativeClassPtr, "room");
			NativeFieldInfoPtr_totalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorTotalTime>.NativeClassPtr, "totalTime");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorTotalTime>.NativeClassPtr, 100664835);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorTotalTime()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorTotalTime>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DecorTotalTime(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class OnStartGame : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnStartGame()
		{
			Il2CppClassPointerStore<OnStartGame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "OnStartGame");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStartGame>.NativeClassPtr, 100664836);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStartGame>.NativeClassPtr, 100664837);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStartGame>.NativeClassPtr, 100664838);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnStartGame>.NativeClassPtr, 100664839);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnStartGame(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnStartGame>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11711, RefRangeEnd = 11712, XrefRangeStart = 11711, XrefRangeEnd = 11712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OnStartGame(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnStartGame(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnStartGame>((System.Delegate)P_0);
		}

		public static OnStartGame operator +(OnStartGame P_0, OnStartGame P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnStartGame>();
		}

		public static OnStartGame operator -(OnStartGame P_0, OnStartGame P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnStartGame>();
			}
			return (OnStartGame)obj;
		}
	}

	public sealed class LoadFinalize : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static LoadFinalize()
		{
			Il2CppClassPointerStore<LoadFinalize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "LoadFinalize");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFinalize>.NativeClassPtr, 100664840);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFinalize>.NativeClassPtr, 100664841);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFinalize>.NativeClassPtr, 100664842);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadFinalize>.NativeClassPtr, 100664843);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadFinalize(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadFinalize>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11711, RefRangeEnd = 11712, XrefRangeStart = 11711, XrefRangeEnd = 11712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LoadFinalize(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator LoadFinalize(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<LoadFinalize>((System.Delegate)P_0);
		}

		public static LoadFinalize operator +(LoadFinalize P_0, LoadFinalize P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<LoadFinalize>();
		}

		public static LoadFinalize operator -(LoadFinalize P_0, LoadFinalize P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<LoadFinalize>();
			}
			return (LoadFinalize)obj;
		}
	}

	[ObfuscatedName("CityConstructor+<LoadSaveGame>d__40")]
	public sealed class _LoadSaveGame_d__40 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncVoidMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncVoidMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CityConstructor __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityConstructor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cityConstructor));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _LoadSaveGame_d__40()
		{
			Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<LoadSaveGame>d__40");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr, "<>u__1");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr, 100664844);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr, 100664845);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55437, XrefRangeEnd = 55653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55653, XrefRangeEnd = 55654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _LoadSaveGame_d__40(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _LoadSaveGame_d__40()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_LoadSaveGame_d__40>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("CityConstructor+<>c__DisplayClass47_0")]
	public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_acc;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__0_Internal_Boolean_NodeAccess_0;

		public unsafe NewNode.NodeAccess acc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode.NodeAccess>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeAccess));
			}
		}

		static __c__DisplayClass47_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c__DisplayClass47_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass47_0>.NativeClassPtr);
			NativeFieldInfoPtr_acc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass47_0>.NativeClassPtr, "acc");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass47_0>.NativeClassPtr, 100664846);
			NativeMethodInfoPtr__Update_b__0_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass47_0>.NativeClassPtr, 100664847);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass47_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass47_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _Update_b__0(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__0_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass47_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<>c__DisplayClass50_0")]
	public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_loadState;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WriteSavingTimings_b__0_Internal_Boolean_LoadState_0;

		public unsafe string loadState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadState);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadState)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass50_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c__DisplayClass50_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr);
			NativeFieldInfoPtr_loadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, "loadState");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, 100664848);
			NativeMethodInfoPtr__WriteSavingTimings_b__0_Internal_Boolean_LoadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr, 100664849);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass50_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass50_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55654, XrefRangeEnd = 55658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WriteSavingTimings_b__0(LoadState item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WriteSavingTimings_b__0_Internal_Boolean_LoadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass50_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("CityConstructor+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__51_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__51_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__52_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__54_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__56_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__58_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__58_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__58_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__58_3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WriteRoomDecorTimings_b__51_1_Internal_Int32_DecorClusterGenerationTimeInfo_DecorClusterGenerationTimeInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WriteRoomDecorTimings_b__51_0_Internal_Int32_DecorTotalTime_DecorTotalTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WriteGeneratedObjectDetails_b__52_0_Internal_Int32_Interactable_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GatherData_b__54_0_Internal_Boolean_NewAddress_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FinalizePostSave_b__56_0_Internal_Boolean_StreetController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__58_1_Internal_Boolean_NodeAccess_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__58_2_Internal_Boolean_NewAddress_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__58_0_Internal_Boolean_FurnitureLocation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__58_3_Internal_Boolean_FurnitureLocation_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<DecorClusterGenerationTimeInfo> __9__51_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__51_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<DecorClusterGenerationTimeInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__51_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<DecorTotalTime> __9__51_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<DecorTotalTime>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__51_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<Interactable> __9__52_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Interactable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__52_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAddress> __9__54_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__54_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAddress>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__54_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<StreetController> __9__56_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<StreetController>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__56_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewNode.NodeAccess> __9__58_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__58_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewNode.NodeAccess>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__58_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAddress> __9__58_2
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__58_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAddress>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__58_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FurnitureLocation> __9__58_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FurnitureLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__58_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FurnitureLocation> __9__58_3
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__58_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FurnitureLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__58_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__51_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__51_1");
			NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__51_0");
			NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__52_0");
			NativeFieldInfoPtr___9__54_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__54_0");
			NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__56_0");
			NativeFieldInfoPtr___9__58_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__58_1");
			NativeFieldInfoPtr___9__58_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__58_2");
			NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__58_0");
			NativeFieldInfoPtr___9__58_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__58_3");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664851);
			NativeMethodInfoPtr__WriteRoomDecorTimings_b__51_1_Internal_Int32_DecorClusterGenerationTimeInfo_DecorClusterGenerationTimeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664852);
			NativeMethodInfoPtr__WriteRoomDecorTimings_b__51_0_Internal_Int32_DecorTotalTime_DecorTotalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664853);
			NativeMethodInfoPtr__WriteGeneratedObjectDetails_b__52_0_Internal_Int32_Interactable_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664854);
			NativeMethodInfoPtr__GatherData_b__54_0_Internal_Boolean_NewAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664855);
			NativeMethodInfoPtr__FinalizePostSave_b__56_0_Internal_Boolean_StreetController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664856);
			NativeMethodInfoPtr__StartGame_b__58_1_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664857);
			NativeMethodInfoPtr__StartGame_b__58_2_Internal_Boolean_NewAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664858);
			NativeMethodInfoPtr__StartGame_b__58_0_Internal_Boolean_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664859);
			NativeMethodInfoPtr__StartGame_b__58_3_Internal_Boolean_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664860);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe int _WriteRoomDecorTimings_b__51_1(DecorClusterGenerationTimeInfo p2, DecorClusterGenerationTimeInfo p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WriteRoomDecorTimings_b__51_1_Internal_Int32_DecorClusterGenerationTimeInfo_DecorClusterGenerationTimeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _WriteRoomDecorTimings_b__51_0(DecorTotalTime p2, DecorTotalTime p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WriteRoomDecorTimings_b__51_0_Internal_Int32_DecorTotalTime_DecorTotalTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55658, XrefRangeEnd = 55660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _WriteGeneratedObjectDetails_b__52_0(Interactable p2, Interactable p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WriteGeneratedObjectDetails_b__52_0_Internal_Int32_Interactable_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55660, XrefRangeEnd = 55662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GatherData_b__54_0(NewAddress item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GatherData_b__54_0_Internal_Boolean_NewAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55662, XrefRangeEnd = 55665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _FinalizePostSave_b__56_0(StreetController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FinalizePostSave_b__56_0_Internal_Boolean_StreetController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _StartGame_b__58_1(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartGame_b__58_1_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55665, XrefRangeEnd = 55669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartGame_b__58_2(NewAddress item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartGame_b__58_2_Internal_Boolean_NewAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _StartGame_b__58_0(FurnitureLocation item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartGame_b__58_0_Internal_Boolean_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55669, XrefRangeEnd = 55671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartGame_b__58_3(FurnitureLocation item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartGame_b__58_3_Internal_Boolean_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<>c__DisplayClass62_0")]
	public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cityInfoPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_writeString;

		private static readonly System.IntPtr NativeFieldInfoPtr_cityDataPath;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SaveCityData_b__0_Internal_Void_0;

		public unsafe string cityInfoPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityInfoPath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityInfoPath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string writeString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeString)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string cityDataPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityDataPath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityDataPath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass62_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c__DisplayClass62_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr);
			NativeFieldInfoPtr_cityInfoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, "cityInfoPath");
			NativeFieldInfoPtr_writeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, "writeString");
			NativeFieldInfoPtr_cityDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, "cityDataPath");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, 100664861);
			NativeMethodInfoPtr__SaveCityData_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr, 100664862);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass62_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass62_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55671, XrefRangeEnd = 55681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SaveCityData_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SaveCityData_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass62_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<>c__DisplayClass62_1")]
	public sealed class __c__DisplayClass62_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_jsonString;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SaveCityData_b__1_Internal_Void_0;

		public unsafe string jsonString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe __c__DisplayClass62_0 field_Public___c__DisplayClass62_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass62_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass62_));
			}
		}

		static __c__DisplayClass62_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass62_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c__DisplayClass62_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass62_1>.NativeClassPtr);
			NativeFieldInfoPtr_jsonString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_1>.NativeClassPtr, "jsonString");
			NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_1>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_1>.NativeClassPtr, 100664863);
			NativeMethodInfoPtr__SaveCityData_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_1>.NativeClassPtr, 100664864);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass62_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass62_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55681, XrefRangeEnd = 55691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SaveCityData_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SaveCityData_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass62_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<>c__DisplayClass62_2")]
	public sealed class __c__DisplayClass62_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_jsonString;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SaveCityData_b__2_Internal_Void_0;

		public unsafe string jsonString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe __c__DisplayClass62_0 field_Public___c__DisplayClass62_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass62_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass62_));
			}
		}

		static __c__DisplayClass62_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass62_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c__DisplayClass62_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass62_2>.NativeClassPtr);
			NativeFieldInfoPtr_jsonString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_2>.NativeClassPtr, "jsonString");
			NativeFieldInfoPtr_field_Public___c__DisplayClass62_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass62_2>.NativeClassPtr, "CS$<>8__locals2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_2>.NativeClassPtr, 100664865);
			NativeMethodInfoPtr__SaveCityData_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass62_2>.NativeClassPtr, 100664866);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass62_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass62_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55691, XrefRangeEnd = 55701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SaveCityData_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SaveCityData_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass62_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<SaveCityData>d__62")]
	public sealed class _SaveCityData_d__62 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__cursor_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__cityTiles_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr__stopWatch_5__4;

		private static readonly System.IntPtr NativeFieldInfoPtr__writeCityInfoTask_5__5;

		private static readonly System.IntPtr NativeFieldInfoPtr__compressedCityPath_5__6;

		private static readonly System.IntPtr NativeFieldInfoPtr__tempCompressionTask_5__7;

		private static readonly System.IntPtr NativeFieldInfoPtr__tempTask_5__8;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe CityConstructor __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityConstructor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cityConstructor));
			}
		}

		public unsafe __c__DisplayClass62_0 __8__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass62_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass62_));
			}
		}

		public unsafe int _cursor_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cursor_5__2);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cursor_5__2)) = num;
			}
		}

		public unsafe List<CityTile> _cityTiles_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cityTiles_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CityTile>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cityTiles_5__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Stopwatch _stopWatch_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__4);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__4)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stopwatch));
			}
		}

		public unsafe Task _writeCityInfoTask_5__5
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__writeCityInfoTask_5__5);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__writeCityInfoTask_5__5)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task));
			}
		}

		public unsafe string _compressedCityPath_5__6
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compressedCityPath_5__6);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compressedCityPath_5__6)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Task<bool> _tempCompressionTask_5__7
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tempCompressionTask_5__7);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tempCompressionTask_5__7)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task));
			}
		}

		public unsafe Task _tempTask_5__8
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tempTask_5__8);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tempTask_5__8)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _SaveCityData_d__62()
		{
			Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<SaveCityData>d__62");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<>8__1");
			NativeFieldInfoPtr__cursor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<cursor>5__2");
			NativeFieldInfoPtr__cityTiles_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<cityTiles>5__3");
			NativeFieldInfoPtr__stopWatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<stopWatch>5__4");
			NativeFieldInfoPtr__writeCityInfoTask_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<writeCityInfoTask>5__5");
			NativeFieldInfoPtr__compressedCityPath_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<compressedCityPath>5__6");
			NativeFieldInfoPtr__tempCompressionTask_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<tempCompressionTask>5__7");
			NativeFieldInfoPtr__tempTask_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, "<tempTask>5__8");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, 100664867);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, 100664868);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, 100664869);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, 100664870);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, 100664871);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr, 100664872);
		}

		[CallerCount(0)]
		public unsafe _SaveCityData_d__62(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_SaveCityData_d__62>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55701, XrefRangeEnd = 56053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56053, XrefRangeEnd = 56059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _SaveCityData_d__62(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<>c__DisplayClass66_0")]
	public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_jsonString;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadFullCityDataAsync_b__1_Internal_Void_0;

		public unsafe string jsonString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass66_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c__DisplayClass66_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr);
			NativeFieldInfoPtr_jsonString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, "jsonString");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, 100664873);
			NativeMethodInfoPtr__LoadFullCityDataAsync_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, 100664874);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass66_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56059, XrefRangeEnd = 56072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LoadFullCityDataAsync_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadFullCityDataAsync_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass66_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<LoadFullCityDataAsync>d__66")]
	public sealed class _LoadFullCityDataAsync_d__66 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__stopWatch_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__2;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CityConstructor __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityConstructor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cityConstructor));
			}
		}

		public unsafe __c__DisplayClass66_0 __8__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass66_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass66_));
			}
		}

		public unsafe Stopwatch _stopWatch_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stopwatch));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool> __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _LoadFullCityDataAsync_d__66()
		{
			Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<LoadFullCityDataAsync>d__66");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, "<>8__1");
			NativeFieldInfoPtr__stopWatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, "<stopWatch>5__2");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, "<>u__1");
			NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, "<>u__2");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, 100664875);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr, 100664876);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56072, XrefRangeEnd = 56183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56183, XrefRangeEnd = 56187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _LoadFullCityDataAsync_d__66(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _LoadFullCityDataAsync_d__66()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_LoadFullCityDataAsync_d__66>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("CityConstructor+<>c__DisplayClass67_0")]
	public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_jsonString;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadSaveStateFile_b__1_Internal_Void_0;

		public unsafe string jsonString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jsonString)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass67_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<>c__DisplayClass67_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr);
			NativeFieldInfoPtr_jsonString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "jsonString");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100664877);
			NativeMethodInfoPtr__LoadSaveStateFile_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100664878);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass67_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56187, XrefRangeEnd = 56200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LoadSaveStateFile_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadSaveStateFile_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass67_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CityConstructor+<LoadSaveStateFile>d__67")]
	public sealed class _LoadSaveStateFile_d__67 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__stopWatch_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__2;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CityConstructor __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityConstructor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cityConstructor));
			}
		}

		public unsafe __c__DisplayClass67_0 __8__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass67_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass67_));
			}
		}

		public unsafe Stopwatch _stopWatch_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopWatch_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stopwatch));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool> __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<bool>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _LoadSaveStateFile_d__67()
		{
			Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "<LoadSaveStateFile>d__67");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, "<>8__1");
			NativeFieldInfoPtr__stopWatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, "<stopWatch>5__2");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, "<>u__1");
			NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, "<>u__2");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, 100664879);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr, 100664880);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56200, XrefRangeEnd = 56314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56314, XrefRangeEnd = 56318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _LoadSaveStateFile_d__67(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _LoadSaveStateFile_d__67()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_LoadSaveStateFile_d__67>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_currentData;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveState;

	private static readonly System.IntPtr NativeFieldInfoPtr_generateNew;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCityConstructionHold;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveChunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_evidenceToCompile;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadState;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityConstructorHoldState;

	private static readonly System.IntPtr NativeFieldInfoPtr_allLoadStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadingProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadingOperationActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_preSimActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_preSimOccured;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadingWallsReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadingFurnitureReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateSwitchState;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeStamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLoadTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnGameStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnLoadFinalize;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadFullCityDataTask;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnGameStarted_Public_add_Void_OnStartGame_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnGameStarted_Public_rem_Void_OnStartGame_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnLoadFinalize_Public_add_Void_LoadFinalize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnLoadFinalize_Public_rem_Void_LoadFinalize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CityConstructor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroySelf_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNewCity_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSaveGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncompatibleVersionConfirm_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncompatibleVersionCancel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCityFromShareCode_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCityStartNewGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartLoading_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopCityConstructionAtEndOfLoadState_Public_Void_LoadState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCityConstructionHoldStatus_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteSavingTimings_Private_Void_byref_CollectedLoadTimeInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteRoomDecorTimings_Private_Void_byref_CollectedLoadTimeInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteGeneratedObjectDetails_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLoadingText_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GatherData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalized_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizePostSave_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPreSim_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TriggerStartEvent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTutorial_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableTutorial_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveCityData_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingCityEditor_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSelfEmployed_Public_Void_CompanyPreset_Human_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFullCityDataAsync_Public_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSaveStateFile_Public_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__LoadFullCityDataAsync_b__66_0_Private_Void_CitySaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__LoadSaveStateFile_b__67_0_Private_Void_StateSaveData_0;

	public unsafe CitySaveData currentData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citySaveData));
		}
	}

	public unsafe StateSaveData saveState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateSaveData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateSaveData));
		}
	}

	public unsafe bool generateNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateNew);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateNew)) = flag;
		}
	}

	public unsafe bool isLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoaded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoaded)) = flag;
		}
	}

	public unsafe bool useCityConstructionHold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCityConstructionHold);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCityConstructionHold)) = flag;
		}
	}

	public unsafe int saveChunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveChunk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveChunk)) = num;
		}
	}

	public unsafe List<Evidence> evidenceToCompile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceToCompile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceToCompile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe LoadState loadState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadState);
			return *(LoadState*)num;
		}
		set
		{
			*(LoadState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadState)) = loadState;
		}
	}

	public unsafe LoadState cityConstructorHoldState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityConstructorHoldState);
			return *(LoadState*)num;
		}
		set
		{
			*(LoadState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityConstructorHoldState)) = loadState;
		}
	}

	public unsafe List<LoadState> allLoadStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLoadStates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoadState>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLoadStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int loadCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCursor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCursor)) = num;
		}
	}

	public unsafe float loadingProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingProgress)) = num;
		}
	}

	public unsafe bool stateComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateComplete)) = flag;
		}
	}

	public unsafe bool loadingOperationActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingOperationActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingOperationActive)) = flag;
		}
	}

	public unsafe bool preSimActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preSimActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preSimActive)) = flag;
		}
	}

	public unsafe bool preSimOccured
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preSimOccured);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preSimOccured)) = flag;
		}
	}

	public unsafe Dictionary<int, NewWall> loadingWallsReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingWallsReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, NewWall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingWallsReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, FurnitureLocation> loadingFurnitureReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingFurnitureReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, FurnitureLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingFurnitureReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Interactable> updateSwitchState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateSwitchState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateSwitchState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float timeStamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStamp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStamp)) = num;
		}
	}

	public unsafe CollectedLoadTimeInfo debugLoadTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLoadTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CollectedLoadTimeInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLoadTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collectedLoadTimeInfo));
		}
	}

	public unsafe OnStartGame OnGameStarted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGameStarted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnStartGame>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGameStarted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onStartGame));
		}
	}

	public unsafe LoadFinalize OnLoadFinalize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLoadFinalize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoadFinalize>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLoadFinalize)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loadFinalize));
		}
	}

	public unsafe static CityConstructor _instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityConstructor>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cityConstructor));
		}
	}

	public unsafe Task loadFullCityDataTask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFullCityDataTask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFullCityDataTask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task));
		}
	}

	public unsafe static CityConstructor Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56334, XrefRangeEnd = 56336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_CityConstructor_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityConstructor>(intPtr) : null;
		}
	}

	static CityConstructor()
	{
		Il2CppClassPointerStore<CityConstructor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CityConstructor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr);
		NativeFieldInfoPtr_currentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "currentData");
		NativeFieldInfoPtr_saveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "saveState");
		NativeFieldInfoPtr_generateNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "generateNew");
		NativeFieldInfoPtr_isLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "isLoaded");
		NativeFieldInfoPtr_useCityConstructionHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "useCityConstructionHold");
		NativeFieldInfoPtr_saveChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "saveChunk");
		NativeFieldInfoPtr_evidenceToCompile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "evidenceToCompile");
		NativeFieldInfoPtr_loadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "loadState");
		NativeFieldInfoPtr_cityConstructorHoldState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "cityConstructorHoldState");
		NativeFieldInfoPtr_allLoadStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "allLoadStates");
		NativeFieldInfoPtr_loadCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "loadCursor");
		NativeFieldInfoPtr_loadingProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "loadingProgress");
		NativeFieldInfoPtr_stateComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "stateComplete");
		NativeFieldInfoPtr_loadingOperationActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "loadingOperationActive");
		NativeFieldInfoPtr_preSimActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "preSimActive");
		NativeFieldInfoPtr_preSimOccured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "preSimOccured");
		NativeFieldInfoPtr_loadingWallsReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "loadingWallsReference");
		NativeFieldInfoPtr_loadingFurnitureReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "loadingFurnitureReference");
		NativeFieldInfoPtr_updateSwitchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "updateSwitchState");
		NativeFieldInfoPtr_timeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "timeStamp");
		NativeFieldInfoPtr_debugLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "debugLoadTime");
		NativeFieldInfoPtr_OnGameStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "OnGameStarted");
		NativeFieldInfoPtr_OnLoadFinalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "OnLoadFinalize");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_loadFullCityDataTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, "loadFullCityDataTask");
		NativeMethodInfoPtr_add_OnGameStarted_Public_add_Void_OnStartGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664794);
		NativeMethodInfoPtr_remove_OnGameStarted_Public_rem_Void_OnStartGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664795);
		NativeMethodInfoPtr_add_OnLoadFinalize_Public_add_Void_LoadFinalize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664796);
		NativeMethodInfoPtr_remove_OnLoadFinalize_Public_rem_Void_LoadFinalize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664797);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_CityConstructor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664798);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664799);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664800);
		NativeMethodInfoPtr_DestroySelf_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664801);
		NativeMethodInfoPtr_GenerateNewCity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664802);
		NativeMethodInfoPtr_LoadSaveGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664803);
		NativeMethodInfoPtr_IncompatibleVersionConfirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664804);
		NativeMethodInfoPtr_IncompatibleVersionCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664805);
		NativeMethodInfoPtr_GenerateCityFromShareCode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664806);
		NativeMethodInfoPtr_LoadCityStartNewGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664807);
		NativeMethodInfoPtr_StartLoading_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664808);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664809);
		NativeMethodInfoPtr_StopCityConstructionAtEndOfLoadState_Public_Void_LoadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664810);
		NativeMethodInfoPtr_ClearCityConstructionHoldStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664811);
		NativeMethodInfoPtr_WriteSavingTimings_Private_Void_byref_CollectedLoadTimeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664812);
		NativeMethodInfoPtr_WriteRoomDecorTimings_Private_Void_byref_CollectedLoadTimeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664813);
		NativeMethodInfoPtr_WriteGeneratedObjectDetails_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664814);
		NativeMethodInfoPtr_SetLoadingText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664815);
		NativeMethodInfoPtr_GatherData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664816);
		NativeMethodInfoPtr_Finalized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664817);
		NativeMethodInfoPtr_FinalizePostSave_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664818);
		NativeMethodInfoPtr_SetPreSim_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664819);
		NativeMethodInfoPtr_StartGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664820);
		NativeMethodInfoPtr_TriggerStartEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664821);
		NativeMethodInfoPtr_EnableTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664822);
		NativeMethodInfoPtr_DisableTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664823);
		NativeMethodInfoPtr_SaveCityData_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664824);
		NativeMethodInfoPtr_IsUsingCityEditor_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664825);
		NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664826);
		NativeMethodInfoPtr_CreateSelfEmployed_Public_Void_CompanyPreset_Human_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664827);
		NativeMethodInfoPtr_LoadFullCityDataAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664828);
		NativeMethodInfoPtr_LoadSaveStateFile_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664829);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664830);
		NativeMethodInfoPtr__LoadFullCityDataAsync_b__66_0_Private_Void_CitySaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664831);
		NativeMethodInfoPtr__LoadSaveStateFile_b__67_0_Private_Void_StateSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr, 100664832);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56321, RefRangeEnd = 56322, XrefRangeStart = 56318, XrefRangeEnd = 56321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnGameStarted(OnStartGame value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnGameStarted_Public_add_Void_OnStartGame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56325, RefRangeEnd = 56328, XrefRangeStart = 56322, XrefRangeEnd = 56325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnGameStarted(OnStartGame value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnGameStarted_Public_rem_Void_OnStartGame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56328, XrefRangeEnd = 56331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnLoadFinalize(LoadFinalize value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnLoadFinalize_Public_add_Void_LoadFinalize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56331, XrefRangeEnd = 56334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnLoadFinalize(LoadFinalize value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnLoadFinalize_Public_rem_Void_LoadFinalize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56336, XrefRangeEnd = 56381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56381, XrefRangeEnd = 56402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56402, XrefRangeEnd = 56411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroySelf()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroySelf_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56432, RefRangeEnd = 56433, XrefRangeStart = 56411, XrefRangeEnd = 56432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateNewCity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateNewCity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56433, XrefRangeEnd = 56437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadSaveGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSaveGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56437, XrefRangeEnd = 56457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncompatibleVersionConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncompatibleVersionConfirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56457, XrefRangeEnd = 56490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncompatibleVersionCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncompatibleVersionCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56509, RefRangeEnd = 56511, XrefRangeStart = 56490, XrefRangeEnd = 56509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateCityFromShareCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCityFromShareCode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56511, XrefRangeEnd = 56512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadCityStartNewGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCityStartNewGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 56749, RefRangeEnd = 56754, XrefRangeStart = 56512, XrefRangeEnd = 56749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartLoading()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartLoading_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56754, XrefRangeEnd = 56958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void StopCityConstructionAtEndOfLoadState(LoadState stopHereState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stopHereState);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopCityConstructionAtEndOfLoadState_Public_Void_LoadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56958, XrefRangeEnd = 56962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCityConstructionHoldStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCityConstructionHoldStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57235, RefRangeEnd = 57236, XrefRangeStart = 56962, XrefRangeEnd = 57235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteSavingTimings(ref CollectedLoadTimeInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteSavingTimings_Private_Void_byref_CollectedLoadTimeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		info = ((intPtr4 == (System.IntPtr)0) ? null : new CollectedLoadTimeInfo(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57438, RefRangeEnd = 57439, XrefRangeStart = 57236, XrefRangeEnd = 57438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteRoomDecorTimings(ref CollectedLoadTimeInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteRoomDecorTimings_Private_Void_byref_CollectedLoadTimeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		info = ((intPtr4 == (System.IntPtr)0) ? null : new CollectedLoadTimeInfo(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57837, RefRangeEnd = 57838, XrefRangeStart = 57439, XrefRangeEnd = 57837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteGeneratedObjectDetails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteGeneratedObjectDetails_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57838, XrefRangeEnd = 57850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLoadingText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLoadingText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57850, XrefRangeEnd = 58035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GatherData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GatherData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58035, XrefRangeEnd = 58441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Finalized()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58441, XrefRangeEnd = 58590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinalizePostSave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizePostSave_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58624, RefRangeEnd = 58625, XrefRangeStart = 58590, XrefRangeEnd = 58624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPreSim(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPreSim_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58967, RefRangeEnd = 58968, XrefRangeStart = 58625, XrefRangeEnd = 58967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58992, RefRangeEnd = 58993, XrefRangeStart = 58968, XrefRangeEnd = 58992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TriggerStartEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriggerStartEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58993, XrefRangeEnd = 59014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59014, XrefRangeEnd = 59035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59035, XrefRangeEnd = 59038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator SaveCityData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveCityData_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59057, RefRangeEnd = 59059, XrefRangeStart = 59038, XrefRangeEnd = 59057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUsingCityEditor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsingCityEditor_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59059, XrefRangeEnd = 59061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59083, RefRangeEnd = 59084, XrefRangeStart = 59061, XrefRangeEnd = 59083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateSelfEmployed(CompanyPreset company, Human employee, Interactable workLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)company);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)employee);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)workLocation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSelfEmployed_Public_Void_CompanyPreset_Human_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59084, XrefRangeEnd = 59096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task LoadFullCityDataAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFullCityDataAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59096, XrefRangeEnd = 59108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task LoadSaveStateFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSaveStateFile_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59108, XrefRangeEnd = 59139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CityConstructor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CityConstructor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(73)]
	[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _LoadFullCityDataAsync_b__66_0(CitySaveData output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadFullCityDataAsync_b__66_0_Private_Void_CitySaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(44)]
	[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59183, XrefRangeStart = 59139, XrefRangeEnd = 59139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _LoadSaveStateFile_b__67_0(StateSaveData output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadSaveStateFile_b__67_0_Private_Void_StateSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CityConstructor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
