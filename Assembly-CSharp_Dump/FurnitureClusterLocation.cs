using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class FurnitureClusterLocation : Il2CppSystem.Object
{
	public enum RemoveInteractablesOption
	{
		keep,
		remove,
		moveToStorage
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_clusterObjectMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_clusterList;

	private static readonly System.IntPtr NativeFieldInfoPtr_cluster;

	private static readonly System.IntPtr NativeFieldInfoPtr_anchorNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_ranking;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadedGeometry;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NewNode_FurnitureCluster_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFurnitureToWorld_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadFurniture_Public_Void_Boolean_RemoveInteractablesOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCluster_Public_Void_Boolean_RemoveInteractablesOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFurniture_Public_Void_Int32_Boolean_RemoveInteractablesOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FurnitureClusterLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSaveData_Public_FurnitureClusterCitySave_0;

	public unsafe Dictionary<NewNode, List<FurnitureLocation>> clusterObjectMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clusterObjectMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewNode, List<FurnitureLocation>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clusterObjectMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<FurnitureLocation> clusterList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clusterList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clusterList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

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

	public unsafe NewNode anchorNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe int angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
		}
	}

	public unsafe float ranking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranking);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranking)) = num;
		}
	}

	public unsafe bool loadedGeometry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedGeometry);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedGeometry)) = flag;
		}
	}

	static FurnitureClusterLocation()
	{
		Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FurnitureClusterLocation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr);
		NativeFieldInfoPtr_clusterObjectMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, "clusterObjectMap");
		NativeFieldInfoPtr_clusterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, "clusterList");
		NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, "cluster");
		NativeFieldInfoPtr_anchorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, "anchorNode");
		NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, "angle");
		NativeFieldInfoPtr_ranking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, "ranking");
		NativeFieldInfoPtr_loadedGeometry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, "loadedGeometry");
		NativeMethodInfoPtr__ctor_Public_Void_NewNode_FurnitureCluster_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, 100669433);
		NativeMethodInfoPtr_LoadFurnitureToWorld_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, 100669434);
		NativeMethodInfoPtr_UnloadFurniture_Public_Void_Boolean_RemoveInteractablesOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, 100669435);
		NativeMethodInfoPtr_DeleteCluster_Public_Void_Boolean_RemoveInteractablesOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, 100669436);
		NativeMethodInfoPtr_DeleteFurniture_Public_Void_Int32_Boolean_RemoveInteractablesOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, 100669437);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FurnitureClusterLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, 100669438);
		NativeMethodInfoPtr_GenerateSaveData_Public_FurnitureClusterCitySave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr, 100669439);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 206779, RefRangeEnd = 206782, XrefRangeStart = 206768, XrefRangeEnd = 206779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FurnitureClusterLocation(NewNode newAnchor, FurnitureCluster newPreset, int newAngle, float newRank)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureClusterLocation>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAnchor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newAngle;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newRank;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NewNode_FurnitureCluster_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206820, RefRangeEnd = 206821, XrefRangeStart = 206782, XrefRangeEnd = 206820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFurnitureToWorld(bool forceSpawnImmediate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceSpawnImmediate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFurnitureToWorld_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 206849, RefRangeEnd = 206852, XrefRangeStart = 206821, XrefRangeEnd = 206849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadFurniture(bool removeIntegratedInteractables, RemoveInteractablesOption removeSpawnedInteractables)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&removeIntegratedInteractables);
		*(RemoveInteractablesOption**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSpawnedInteractables;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadFurniture_Public_Void_Boolean_RemoveInteractablesOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206884, RefRangeEnd = 206885, XrefRangeStart = 206852, XrefRangeEnd = 206884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteCluster(bool removeIntegratedInteractables, RemoveInteractablesOption removeSpawnedInteractables)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&removeIntegratedInteractables);
		*(RemoveInteractablesOption**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSpawnedInteractables;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteCluster_Public_Void_Boolean_RemoveInteractablesOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 206934, RefRangeEnd = 206936, XrefRangeStart = 206885, XrefRangeEnd = 206934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteFurniture(int deleteID, bool removeIntegratedInteractables, RemoveInteractablesOption removeSpawnedInteractables)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&deleteID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeIntegratedInteractables;
		*(RemoveInteractablesOption**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeSpawnedInteractables;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFurniture_Public_Void_Int32_Boolean_RemoveInteractablesOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int CompareTo(FurnitureClusterLocation otherObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FurnitureClusterLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 207043, RefRangeEnd = 207044, XrefRangeStart = 206936, XrefRangeEnd = 207043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CitySaveData.FurnitureClusterCitySave GenerateSaveData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSaveData_Public_FurnitureClusterCitySave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData.FurnitureClusterCitySave>(intPtr) : null;
	}

	public FurnitureClusterLocation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
