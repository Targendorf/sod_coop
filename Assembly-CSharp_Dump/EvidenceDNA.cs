using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class EvidenceDNA : Evidence
{
	private static readonly System.IntPtr NativeFieldInfoPtr_citizenController;

	private static readonly System.IntPtr NativeFieldInfoPtr_DNAAssign;

	private static readonly System.IntPtr NativeFieldInfoPtr_DNAAssignLoop;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EvidencePreset_String_Controller_List_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDiscovery_Public_Virtual_Void_0;

	public unsafe Citizen citizenController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Citizen>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizen));
		}
	}

	public unsafe static int DNAAssign
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DNAAssign, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DNAAssign, (void*)(&num));
		}
	}

	public unsafe static int DNAAssignLoop
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DNAAssignLoop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DNAAssignLoop, (void*)(&num));
		}
	}

	static EvidenceDNA()
	{
		Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EvidenceDNA");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr);
		NativeFieldInfoPtr_citizenController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr, "citizenController");
		NativeFieldInfoPtr_DNAAssign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr, "DNAAssign");
		NativeFieldInfoPtr_DNAAssignLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr, "DNAAssignLoop");
		NativeMethodInfoPtr__ctor_Public_Void_EvidencePreset_String_Controller_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr, 100673416);
		NativeMethodInfoPtr_OnDiscovery_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr, 100673417);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318219, XrefRangeEnd = 318222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EvidenceDNA(EvidencePreset newPreset, string evID, Controller newController, List<Il2CppSystem.Object> newPassedObjects)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvidenceDNA>.NativeClassPtr))
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318222, XrefRangeEnd = 318232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDiscovery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDiscovery_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EvidenceDNA(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
