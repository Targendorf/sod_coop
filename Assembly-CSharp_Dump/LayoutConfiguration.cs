using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class LayoutConfiguration : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_assignPurpose;

	private static readonly IntPtr NativeFieldInfoPtr_addressPreset;

	private static readonly IntPtr NativeFieldInfoPtr_publicFacing;

	private static readonly IntPtr NativeFieldInfoPtr_isOutside;

	private static readonly IntPtr NativeFieldInfoPtr_isLobby;

	private static readonly IntPtr NativeFieldInfoPtr_roomLayout;

	private static readonly IntPtr NativeFieldInfoPtr_requiresHallway;

	private static readonly IntPtr NativeFieldInfoPtr_hallway;

	private static readonly IntPtr NativeFieldInfoPtr_hallwayDistanceThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_useBuildingDesignStyle;

	private static readonly IntPtr NativeFieldInfoPtr_overrideEvidencePhotoSettings;

	private static readonly IntPtr NativeFieldInfoPtr_relativeCamPhotoPos;

	private static readonly IntPtr NativeFieldInfoPtr_relativeCamPhotoEuler;

	private static readonly IntPtr NativeFieldInfoPtr_doorwaysNormal;

	private static readonly IntPtr NativeFieldInfoPtr_doorwaysFlat;

	private static readonly IntPtr NativeFieldInfoPtr_roomDividersLeft;

	private static readonly IntPtr NativeFieldInfoPtr_roomDividersCentre;

	private static readonly IntPtr NativeFieldInfoPtr_roomDividersRight;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool assignPurpose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignPurpose);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignPurpose)) = flag;
		}
	}

	public unsafe AddressPreset addressPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressPreset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AddressPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addressPreset));
		}
	}

	public unsafe bool publicFacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicFacing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicFacing)) = flag;
		}
	}

	public unsafe bool isOutside
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutside);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutside)) = flag;
		}
	}

	public unsafe bool isLobby
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLobby);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLobby)) = flag;
		}
	}

	public unsafe List<RoomTypePreset> roomLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomLayout);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomLayout)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool requiresHallway
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresHallway);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresHallway)) = flag;
		}
	}

	public unsafe RoomConfiguration hallway
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hallway);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hallway)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	public unsafe int hallwayDistanceThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hallwayDistanceThreshold);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hallwayDistanceThreshold)) = num;
		}
	}

	public unsafe bool useBuildingDesignStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingDesignStyle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingDesignStyle)) = flag;
		}
	}

	public unsafe bool overrideEvidencePhotoSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEvidencePhotoSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEvidencePhotoSettings)) = flag;
		}
	}

	public unsafe Vector3 relativeCamPhotoPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos)) = vector;
		}
	}

	public unsafe Vector3 relativeCamPhotoEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler)) = vector;
		}
	}

	public unsafe List<DoorPairPreset> doorwaysNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorwaysNormal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DoorPairPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorwaysNormal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DoorPairPreset> doorwaysFlat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorwaysFlat);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DoorPairPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorwaysFlat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DoorPairPreset> roomDividersLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividersLeft);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DoorPairPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividersLeft)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DoorPairPreset> roomDividersCentre
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividersCentre);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DoorPairPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividersCentre)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DoorPairPreset> roomDividersRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividersRight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DoorPairPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividersRight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static LayoutConfiguration()
	{
		Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LayoutConfiguration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr);
		NativeFieldInfoPtr_assignPurpose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "assignPurpose");
		NativeFieldInfoPtr_addressPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "addressPreset");
		NativeFieldInfoPtr_publicFacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "publicFacing");
		NativeFieldInfoPtr_isOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "isOutside");
		NativeFieldInfoPtr_isLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "isLobby");
		NativeFieldInfoPtr_roomLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "roomLayout");
		NativeFieldInfoPtr_requiresHallway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "requiresHallway");
		NativeFieldInfoPtr_hallway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "hallway");
		NativeFieldInfoPtr_hallwayDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "hallwayDistanceThreshold");
		NativeFieldInfoPtr_useBuildingDesignStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "useBuildingDesignStyle");
		NativeFieldInfoPtr_overrideEvidencePhotoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "overrideEvidencePhotoSettings");
		NativeFieldInfoPtr_relativeCamPhotoPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "relativeCamPhotoPos");
		NativeFieldInfoPtr_relativeCamPhotoEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "relativeCamPhotoEuler");
		NativeFieldInfoPtr_doorwaysNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "doorwaysNormal");
		NativeFieldInfoPtr_doorwaysFlat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "doorwaysFlat");
		NativeFieldInfoPtr_roomDividersLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "roomDividersLeft");
		NativeFieldInfoPtr_roomDividersCentre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "roomDividersCentre");
		NativeFieldInfoPtr_roomDividersRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, "roomDividersRight");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr, 100673974);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329301, XrefRangeEnd = 329331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LayoutConfiguration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutConfiguration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LayoutConfiguration(IntPtr pointer)
		: base(pointer)
	{
	}
}
