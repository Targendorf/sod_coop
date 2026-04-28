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
public class NodeSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_f_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_f_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_f_t;

	private static readonly System.IntPtr NativeFieldInfoPtr_f_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_w_d;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2Int f_c
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_c);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_c)) = vector2Int;
		}
	}

	public unsafe int f_h
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_h);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_h)) = num;
		}
	}

	public unsafe NewNode.FloorTileType f_t
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_t);
			return *(NewNode.FloorTileType*)num;
		}
		set
		{
			*(NewNode.FloorTileType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_t)) = floorTileType;
		}
	}

	public unsafe string f_r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_r);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f_r)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<WallSaveData> w_d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WallSaveData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_d)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static NodeSaveData()
	{
		Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NodeSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_f_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr, "f_c");
		NativeFieldInfoPtr_f_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr, "f_h");
		NativeFieldInfoPtr_f_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr, "f_t");
		NativeFieldInfoPtr_f_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr, "f_r");
		NativeFieldInfoPtr_w_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr, "w_d");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr, 100666700);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 114348, RefRangeEnd = 114351, XrefRangeStart = 114342, XrefRangeEnd = 114348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NodeSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NodeSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
