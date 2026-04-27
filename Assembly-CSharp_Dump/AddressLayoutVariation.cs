using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class AddressLayoutVariation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_r_d;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<RoomSaveData> r_d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r_d);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomSaveData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r_d)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AddressLayoutVariation()
	{
		Il2CppClassPointerStore<AddressLayoutVariation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AddressLayoutVariation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressLayoutVariation>.NativeClassPtr);
		NativeFieldInfoPtr_r_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressLayoutVariation>.NativeClassPtr, "r_d");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressLayoutVariation>.NativeClassPtr, 100666697);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 114331, RefRangeEnd = 114333, XrefRangeStart = 114325, XrefRangeEnd = 114331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddressLayoutVariation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressLayoutVariation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddressLayoutVariation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
