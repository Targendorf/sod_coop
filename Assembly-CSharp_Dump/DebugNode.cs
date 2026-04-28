using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class DebugNode : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_node;

	private static readonly IntPtr NativeFieldInfoPtr_coordinate;

	private static readonly IntPtr NativeFieldInfoPtr_tileCoordinate;

	private static readonly IntPtr NativeFieldInfoPtr_localTileCoordinate;

	private static readonly IntPtr NativeFieldInfoPtr_isConnected;

	private static readonly IntPtr NativeFieldInfoPtr_accessToOtherNodes;

	private static readonly IntPtr NativeFieldInfoPtr_upperStairwellLink;

	private static readonly IntPtr NativeFieldInfoPtr_lowerStairwellLink;

	private static readonly IntPtr NativeFieldInfoPtr_isTileStairwell;

	private static readonly IntPtr NativeFieldInfoPtr_isTileInvertedStairwell;

	private static readonly IntPtr NativeFieldInfoPtr_floorType;

	private static readonly IntPtr NativeFieldInfoPtr_displaySpawnedConnections;

	private static readonly IntPtr NativeFieldInfoPtr_spawnedConnections;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_NewNode_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToggleDisplayConnections_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NewNode node
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe Vector3 coordinate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinate);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinate)) = vector;
		}
	}

	public unsafe Vector3 tileCoordinate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileCoordinate);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileCoordinate)) = vector;
		}
	}

	public unsafe Vector2Int localTileCoordinate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localTileCoordinate);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localTileCoordinate)) = vector2Int;
		}
	}

	public unsafe bool isConnected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConnected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConnected)) = flag;
		}
	}

	public unsafe List<NewNode.NodeAccess> accessToOtherNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accessToOtherNodes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<NewNode.NodeAccess>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accessToOtherNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool upperStairwellLink
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperStairwellLink);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upperStairwellLink)) = flag;
		}
	}

	public unsafe bool lowerStairwellLink
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerStairwellLink);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerStairwellLink)) = flag;
		}
	}

	public unsafe bool isTileStairwell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTileStairwell);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTileStairwell)) = flag;
		}
	}

	public unsafe bool isTileInvertedStairwell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTileInvertedStairwell);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTileInvertedStairwell)) = flag;
		}
	}

	public unsafe NewNode.FloorTileType floorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorType);
			return *(NewNode.FloorTileType*)num;
		}
		set
		{
			*(NewNode.FloorTileType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorType)) = floorTileType;
		}
	}

	public unsafe bool displaySpawnedConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displaySpawnedConnections);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displaySpawnedConnections)) = flag;
		}
	}

	public unsafe List<GameObject> spawnedConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedConnections);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedConnections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static DebugNode()
	{
		Il2CppClassPointerStore<DebugNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DebugNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugNode>.NativeClassPtr);
		NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "node");
		NativeFieldInfoPtr_coordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "coordinate");
		NativeFieldInfoPtr_tileCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "tileCoordinate");
		NativeFieldInfoPtr_localTileCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "localTileCoordinate");
		NativeFieldInfoPtr_isConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "isConnected");
		NativeFieldInfoPtr_accessToOtherNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "accessToOtherNodes");
		NativeFieldInfoPtr_upperStairwellLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "upperStairwellLink");
		NativeFieldInfoPtr_lowerStairwellLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "lowerStairwellLink");
		NativeFieldInfoPtr_isTileStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "isTileStairwell");
		NativeFieldInfoPtr_isTileInvertedStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "isTileInvertedStairwell");
		NativeFieldInfoPtr_floorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "floorType");
		NativeFieldInfoPtr_displaySpawnedConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "displaySpawnedConnections");
		NativeFieldInfoPtr_spawnedConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, "spawnedConnections");
		NativeMethodInfoPtr_Setup_Public_Void_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, 100666512);
		NativeMethodInfoPtr_RefreshData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, 100666513);
		NativeMethodInfoPtr_ToggleDisplayConnections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, 100666514);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugNode>.NativeClassPtr, 100666515);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109884, XrefRangeEnd = 109885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(NewNode newNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109894, RefRangeEnd = 109896, XrefRangeStart = 109885, XrefRangeEnd = 109894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109896, XrefRangeEnd = 109911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleDisplayConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleDisplayConnections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109911, XrefRangeEnd = 109926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugNode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DebugNode(IntPtr pointer)
		: base(pointer)
	{
	}
}
