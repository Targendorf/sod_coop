using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class RoomLightingPreset : SoCustomComparison
{
	public enum StairwellLightRule
	{
		noStairwells,
		onlyStairwells,
		either
	}

	private static readonly IntPtr NativeFieldInfoPtr_disable;

	private static readonly IntPtr NativeFieldInfoPtr_lightObjects;

	private static readonly IntPtr NativeFieldInfoPtr_lightingPreset;

	private static readonly IntPtr NativeFieldInfoPtr_roomCompatibility;

	private static readonly IntPtr NativeFieldInfoPtr_minimumRoomSize;

	private static readonly IntPtr NativeFieldInfoPtr_maximumRoomSize;

	private static readonly IntPtr NativeFieldInfoPtr_onlyAllowInBuildings;

	private static readonly IntPtr NativeFieldInfoPtr_banFromBuildings;

	private static readonly IntPtr NativeFieldInfoPtr_stairwellRule;

	private static readonly IntPtr NativeFieldInfoPtr_designStyleCompatibility;

	private static readonly IntPtr NativeFieldInfoPtr_ceilingFans;

	private static readonly IntPtr NativeFieldInfoPtr_frequency;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe List<InteractablePreset> lightObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightObjects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe LightingPreset lightingPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingPreset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LightingPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightingPreset));
		}
	}

	public unsafe List<RoomConfiguration> roomCompatibility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomCompatibility);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomCompatibility)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe List<BuildingPreset> onlyAllowInBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowInBuildings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowInBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BuildingPreset> banFromBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromBuildings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe StairwellLightRule stairwellRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellRule);
			return *(StairwellLightRule*)num;
		}
		set
		{
			*(StairwellLightRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellRule)) = stairwellLightRule;
		}
	}

	public unsafe List<DesignStylePreset> designStyleCompatibility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyleCompatibility);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DesignStylePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyleCompatibility)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> ceilingFans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingFans);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingFans)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int frequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency)) = num;
		}
	}

	static RoomLightingPreset()
	{
		Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoomLightingPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr);
		NativeFieldInfoPtr_disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "disable");
		NativeFieldInfoPtr_lightObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "lightObjects");
		NativeFieldInfoPtr_lightingPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "lightingPreset");
		NativeFieldInfoPtr_roomCompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "roomCompatibility");
		NativeFieldInfoPtr_minimumRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "minimumRoomSize");
		NativeFieldInfoPtr_maximumRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "maximumRoomSize");
		NativeFieldInfoPtr_onlyAllowInBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "onlyAllowInBuildings");
		NativeFieldInfoPtr_banFromBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "banFromBuildings");
		NativeFieldInfoPtr_stairwellRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "stairwellRule");
		NativeFieldInfoPtr_designStyleCompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "designStyleCompatibility");
		NativeFieldInfoPtr_ceilingFans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "ceilingFans");
		NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, "frequency");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr, 100674028);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330115, XrefRangeEnd = 330151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoomLightingPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomLightingPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoomLightingPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
