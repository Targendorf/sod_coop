using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FloorSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_floorName;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultFloorHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCeilingHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_a_d;

	private static readonly System.IntPtr NativeFieldInfoPtr_t_d;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string floorName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Vector2 size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = vector;
		}
	}

	public unsafe int defaultFloorHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFloorHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFloorHeight)) = num;
		}
	}

	public unsafe int defaultCeilingHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCeilingHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCeilingHeight)) = num;
		}
	}

	public unsafe List<AddressSaveData> a_d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a_d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressSaveData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a_d)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<TileSaveData> t_d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t_d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TileSaveData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t_d)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static FloorSaveData()
	{
		Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FloorSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_floorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr, "floorName");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr, "size");
		NativeFieldInfoPtr_defaultFloorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr, "defaultFloorHeight");
		NativeFieldInfoPtr_defaultCeilingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr, "defaultCeilingHeight");
		NativeFieldInfoPtr_a_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr, "a_d");
		NativeFieldInfoPtr_t_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr, "t_d");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr, 100666695);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114318, RefRangeEnd = 114319, XrefRangeStart = 114304, XrefRangeEnd = 114318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FloorSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FloorSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
