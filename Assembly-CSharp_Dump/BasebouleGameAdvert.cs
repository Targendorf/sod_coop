using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class BasebouleGameAdvert : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_adText;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string adText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adText);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static BasebouleGameAdvert()
	{
		Il2CppClassPointerStore<BasebouleGameAdvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasebouleGameAdvert");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasebouleGameAdvert>.NativeClassPtr);
		NativeFieldInfoPtr_adText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleGameAdvert>.NativeClassPtr, "adText");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleGameAdvert>.NativeClassPtr, 100673791);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BasebouleGameAdvert()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasebouleGameAdvert>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BasebouleGameAdvert(IntPtr pointer)
		: base(pointer)
	{
	}
}
