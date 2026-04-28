using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class RoomTypePreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_forceConfiguration;

	private static readonly IntPtr NativeFieldInfoPtr_chance;

	private static readonly IntPtr NativeFieldInfoPtr_minimumAddressSize;

	private static readonly IntPtr NativeFieldInfoPtr_maximumRoomTypesPerAddress;

	private static readonly IntPtr NativeFieldInfoPtr_cyclePriority;

	private static readonly IntPtr NativeFieldInfoPtr_minimumRoomAreaShape;

	private static readonly IntPtr NativeFieldInfoPtr_maximumRoomAreaShape;

	private static readonly IntPtr NativeFieldInfoPtr_tesselationShape;

	private static readonly IntPtr NativeFieldInfoPtr_floorSpaceWeight;

	private static readonly IntPtr NativeFieldInfoPtr_exteriorWallWeight;

	private static readonly IntPtr NativeFieldInfoPtr_exteriorWindowWeight;

	private static readonly IntPtr NativeFieldInfoPtr_entranceWeight;

	private static readonly IntPtr NativeFieldInfoPtr_mustAdjoinRooms;

	private static readonly IntPtr NativeFieldInfoPtr_doorPriority;

	private static readonly IntPtr NativeFieldInfoPtr_chanceOfNoDoor;

	private static readonly IntPtr NativeFieldInfoPtr_maxDoors;

	private static readonly IntPtr NativeFieldInfoPtr_forceNoDoors;

	private static readonly IntPtr NativeFieldInfoPtr_doorSetting;

	private static readonly IntPtr NativeFieldInfoPtr_allowRoomDividers;

	private static readonly IntPtr NativeFieldInfoPtr_maxDividers;

	private static readonly IntPtr NativeFieldInfoPtr_onlyAllowDividersAdjoining;

	private static readonly IntPtr NativeFieldInfoPtr_allowMainAddressEntrance;

	private static readonly IntPtr NativeFieldInfoPtr_allowSecondaryAddressEntrance;

	private static readonly IntPtr NativeFieldInfoPtr_preferMainAddressEntrance;

	private static readonly IntPtr NativeFieldInfoPtr_mustConnectWithEntrance;

	private static readonly IntPtr NativeFieldInfoPtr_overridable;

	private static readonly IntPtr NativeFieldInfoPtr_overwriteWithPriorityUpTo;

	private static readonly IntPtr NativeFieldInfoPtr_blockOverridesFromType;

	private static readonly IntPtr NativeFieldInfoPtr_overwriteLimit;

	private static readonly IntPtr NativeFieldInfoPtr_expandIntoNull;

	private static readonly IntPtr NativeFieldInfoPtr_expandIntoNullAdjacencyMinimum;

	private static readonly IntPtr NativeFieldInfoPtr_shareFeaturesWithCommonAdjacent;

	private static readonly IntPtr NativeFieldInfoPtr_allowCorridorReplacement;

	private static readonly IntPtr NativeFieldInfoPtr_overrideFloorHeight;

	private static readonly IntPtr NativeFieldInfoPtr_floorHeight;

	private static readonly IntPtr NativeFieldInfoPtr_copyFrom;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RoomConfiguration forceConfiguration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceConfiguration);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceConfiguration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	public unsafe float chance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance)) = num;
		}
	}

	public unsafe int minimumAddressSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumAddressSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumAddressSize)) = num;
		}
	}

	public unsafe int maximumRoomTypesPerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRoomTypesPerAddress);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRoomTypesPerAddress)) = num;
		}
	}

	public unsafe int cyclePriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cyclePriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cyclePriority)) = num;
		}
	}

	public unsafe Vector2 minimumRoomAreaShape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRoomAreaShape);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRoomAreaShape)) = vector;
		}
	}

	public unsafe Vector2 maximumRoomAreaShape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRoomAreaShape);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumRoomAreaShape)) = vector;
		}
	}

	public unsafe Vector2 tesselationShape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tesselationShape);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tesselationShape)) = vector;
		}
	}

	public unsafe int floorSpaceWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorSpaceWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorSpaceWeight)) = num;
		}
	}

	public unsafe int exteriorWallWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorWallWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorWallWeight)) = num;
		}
	}

	public unsafe int exteriorWindowWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorWindowWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorWindowWeight)) = num;
		}
	}

	public unsafe int entranceWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entranceWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entranceWeight)) = num;
		}
	}

	public unsafe List<RoomTypePreset> mustAdjoinRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustAdjoinRooms);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustAdjoinRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int doorPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPriority)) = num;
		}
	}

	public unsafe float chanceOfNoDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfNoDoor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfNoDoor)) = num;
		}
	}

	public unsafe int maxDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDoors);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDoors)) = num;
		}
	}

	public unsafe bool forceNoDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceNoDoors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceNoDoors)) = flag;
		}
	}

	public unsafe NewDoor.DoorSetting doorSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSetting);
			return *(NewDoor.DoorSetting*)num;
		}
		set
		{
			*(NewDoor.DoorSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSetting)) = doorSetting;
		}
	}

	public unsafe bool allowRoomDividers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowRoomDividers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowRoomDividers)) = flag;
		}
	}

	public unsafe int maxDividers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDividers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDividers)) = num;
		}
	}

	public unsafe List<RoomTypePreset> onlyAllowDividersAdjoining
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowDividersAdjoining);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowDividersAdjoining)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool allowMainAddressEntrance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMainAddressEntrance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMainAddressEntrance)) = flag;
		}
	}

	public unsafe bool allowSecondaryAddressEntrance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSecondaryAddressEntrance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSecondaryAddressEntrance)) = flag;
		}
	}

	public unsafe bool preferMainAddressEntrance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferMainAddressEntrance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferMainAddressEntrance)) = flag;
		}
	}

	public unsafe bool mustConnectWithEntrance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustConnectWithEntrance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustConnectWithEntrance)) = flag;
		}
	}

	public unsafe bool overridable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridable)) = flag;
		}
	}

	public unsafe int overwriteWithPriorityUpTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overwriteWithPriorityUpTo);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overwriteWithPriorityUpTo)) = num;
		}
	}

	public unsafe List<RoomTypePreset> blockOverridesFromType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockOverridesFromType);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockOverridesFromType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int overwriteLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overwriteLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overwriteLimit)) = num;
		}
	}

	public unsafe bool expandIntoNull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expandIntoNull);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expandIntoNull)) = flag;
		}
	}

	public unsafe int expandIntoNullAdjacencyMinimum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expandIntoNullAdjacencyMinimum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expandIntoNullAdjacencyMinimum)) = num;
		}
	}

	public unsafe bool shareFeaturesWithCommonAdjacent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareFeaturesWithCommonAdjacent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareFeaturesWithCommonAdjacent)) = flag;
		}
	}

	public unsafe bool allowCorridorReplacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCorridorReplacement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCorridorReplacement)) = flag;
		}
	}

	public unsafe bool overrideFloorHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFloorHeight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFloorHeight)) = flag;
		}
	}

	public unsafe int floorHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorHeight)) = num;
		}
	}

	public unsafe RoomConfiguration copyFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	static RoomTypePreset()
	{
		Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoomTypePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr);
		NativeFieldInfoPtr_forceConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "forceConfiguration");
		NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "chance");
		NativeFieldInfoPtr_minimumAddressSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "minimumAddressSize");
		NativeFieldInfoPtr_maximumRoomTypesPerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "maximumRoomTypesPerAddress");
		NativeFieldInfoPtr_cyclePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "cyclePriority");
		NativeFieldInfoPtr_minimumRoomAreaShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "minimumRoomAreaShape");
		NativeFieldInfoPtr_maximumRoomAreaShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "maximumRoomAreaShape");
		NativeFieldInfoPtr_tesselationShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "tesselationShape");
		NativeFieldInfoPtr_floorSpaceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "floorSpaceWeight");
		NativeFieldInfoPtr_exteriorWallWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "exteriorWallWeight");
		NativeFieldInfoPtr_exteriorWindowWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "exteriorWindowWeight");
		NativeFieldInfoPtr_entranceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "entranceWeight");
		NativeFieldInfoPtr_mustAdjoinRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "mustAdjoinRooms");
		NativeFieldInfoPtr_doorPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "doorPriority");
		NativeFieldInfoPtr_chanceOfNoDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "chanceOfNoDoor");
		NativeFieldInfoPtr_maxDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "maxDoors");
		NativeFieldInfoPtr_forceNoDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "forceNoDoors");
		NativeFieldInfoPtr_doorSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "doorSetting");
		NativeFieldInfoPtr_allowRoomDividers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "allowRoomDividers");
		NativeFieldInfoPtr_maxDividers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "maxDividers");
		NativeFieldInfoPtr_onlyAllowDividersAdjoining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "onlyAllowDividersAdjoining");
		NativeFieldInfoPtr_allowMainAddressEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "allowMainAddressEntrance");
		NativeFieldInfoPtr_allowSecondaryAddressEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "allowSecondaryAddressEntrance");
		NativeFieldInfoPtr_preferMainAddressEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "preferMainAddressEntrance");
		NativeFieldInfoPtr_mustConnectWithEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "mustConnectWithEntrance");
		NativeFieldInfoPtr_overridable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "overridable");
		NativeFieldInfoPtr_overwriteWithPriorityUpTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "overwriteWithPriorityUpTo");
		NativeFieldInfoPtr_blockOverridesFromType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "blockOverridesFromType");
		NativeFieldInfoPtr_overwriteLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "overwriteLimit");
		NativeFieldInfoPtr_expandIntoNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "expandIntoNull");
		NativeFieldInfoPtr_expandIntoNullAdjacencyMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "expandIntoNullAdjacencyMinimum");
		NativeFieldInfoPtr_shareFeaturesWithCommonAdjacent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "shareFeaturesWithCommonAdjacent");
		NativeFieldInfoPtr_allowCorridorReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "allowCorridorReplacement");
		NativeFieldInfoPtr_overrideFloorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "overrideFloorHeight");
		NativeFieldInfoPtr_floorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "floorHeight");
		NativeFieldInfoPtr_copyFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, "copyFrom");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr, 100674030);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330159, XrefRangeEnd = 330175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoomTypePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomTypePreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoomTypePreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
