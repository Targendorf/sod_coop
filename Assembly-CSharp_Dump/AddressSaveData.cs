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
public class AddressSaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_p_n;

	private static readonly System.IntPtr NativeFieldInfoPtr_e_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_vs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string p_n
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_n);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_n)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Color e_c
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_e_c);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_e_c)) = color;
		}
	}

	public unsafe List<AddressLayoutVariation> vs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressLayoutVariation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AddressSaveData()
	{
		Il2CppClassPointerStore<AddressSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AddressSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_p_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressSaveData>.NativeClassPtr, "p_n");
		NativeFieldInfoPtr_e_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressSaveData>.NativeClassPtr, "e_c");
		NativeFieldInfoPtr_vs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressSaveData>.NativeClassPtr, "vs");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressSaveData>.NativeClassPtr, 100666696);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114319, XrefRangeEnd = 114325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddressSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddressSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
