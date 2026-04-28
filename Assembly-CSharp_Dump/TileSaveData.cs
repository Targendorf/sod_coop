using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
public class TileSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_f_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_i_e;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_e;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_t;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_e_l;

	private static readonly System.IntPtr NativeFieldInfoPtr_e_r;

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

	public unsafe bool i_e
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i_e);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i_e)) = flag;
		}
	}

	public unsafe bool m_e
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_e);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_e)) = flag;
		}
	}

	public unsafe bool s_t
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_t);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_t)) = flag;
		}
	}

	public unsafe int s_r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_r);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_r)) = num;
		}
	}

	public unsafe bool e_l
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_e_l);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_e_l)) = flag;
		}
	}

	public unsafe int e_r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_e_r);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_e_r)) = num;
		}
	}

	static TileSaveData()
	{
		Il2CppClassPointerStore<TileSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TileSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_f_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, "f_c");
		NativeFieldInfoPtr_i_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, "i_e");
		NativeFieldInfoPtr_m_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, "m_e");
		NativeFieldInfoPtr_s_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, "s_t");
		NativeFieldInfoPtr_s_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, "s_r");
		NativeFieldInfoPtr_e_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, "e_l");
		NativeFieldInfoPtr_e_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, "e_r");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr, 100666699);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TileSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TileSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
