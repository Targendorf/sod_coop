using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class EvidenceSalesNote : Evidence
{
	private static readonly System.IntPtr NativeFieldInfoPtr_forSale;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EvidencePreset_String_Controller_List_1_Object_0;

	public unsafe NewAddress forSale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forSale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forSale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
		}
	}

	static EvidenceSalesNote()
	{
		Il2CppClassPointerStore<EvidenceSalesNote>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EvidenceSalesNote");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvidenceSalesNote>.NativeClassPtr);
		NativeFieldInfoPtr_forSale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceSalesNote>.NativeClassPtr, "forSale");
		NativeMethodInfoPtr__ctor_Public_Void_EvidencePreset_String_Controller_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidenceSalesNote>.NativeClassPtr, 100673512);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319529, XrefRangeEnd = 319559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EvidenceSalesNote(EvidencePreset newPreset, string evID, Controller newController, List<Il2CppSystem.Object> newPassedObjects)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvidenceSalesNote>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(evID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newController);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedObjects);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EvidencePreset_String_Controller_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EvidenceSalesNote(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
