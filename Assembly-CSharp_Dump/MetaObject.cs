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
public class MetaObject : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_preset;

	private static readonly System.IntPtr NativeFieldInfoPtr_owner;

	private static readonly System.IntPtr NativeFieldInfoPtr_writer;

	private static readonly System.IntPtr NativeFieldInfoPtr_reciever;

	private static readonly System.IntPtr NativeFieldInfoPtr_dds;

	private static readonly System.IntPtr NativeFieldInfoPtr_passed;

	private static readonly System.IntPtr NativeFieldInfoPtr_n;

	private static readonly System.IntPtr NativeFieldInfoPtr_cd;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InteractablePreset_Human_Human_Human_List_1_Passed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEvidence_Public_Evidence_Boolean_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreset_Public_InteractablePreset_0;

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe string preset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int owner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner)) = num;
		}
	}

	public unsafe int writer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)) = num;
		}
	}

	public unsafe int reciever
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reciever);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reciever)) = num;
		}
	}

	public unsafe string dds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dds);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dds)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<Interactable.Passed> passed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable.Passed>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector3Int n
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n)) = vector3Int;
		}
	}

	public unsafe bool cd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cd)) = flag;
		}
	}

	static MetaObject()
	{
		Il2CppClassPointerStore<MetaObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MetaObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaObject>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "id");
		NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "preset");
		NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "owner");
		NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "writer");
		NativeFieldInfoPtr_reciever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "reciever");
		NativeFieldInfoPtr_dds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "dds");
		NativeFieldInfoPtr_passed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "passed");
		NativeFieldInfoPtr_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "n");
		NativeFieldInfoPtr_cd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, "cd");
		NativeMethodInfoPtr__ctor_Public_Void_InteractablePreset_Human_Human_Human_List_1_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, 100670037);
		NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, 100670038);
		NativeMethodInfoPtr_GetEvidence_Public_Evidence_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, 100670039);
		NativeMethodInfoPtr_GetPreset_Public_InteractablePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaObject>.NativeClassPtr, 100670040);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 232747, RefRangeEnd = 232751, XrefRangeStart = 232676, XrefRangeEnd = 232747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MetaObject(InteractablePreset newPreset, Human newOwner, Human newWriter, Human newReciever, List<Interactable.Passed> newPassed)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newOwner);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newReciever);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InteractablePreset_Human_Human_Human_List_1_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232760, RefRangeEnd = 232762, XrefRangeStart = 232751, XrefRangeEnd = 232760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 232782, RefRangeEnd = 232789, XrefRangeStart = 232762, XrefRangeEnd = 232782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Evidence GetEvidence(bool setPosition = false, Vector3Int nodeCoord = default(Vector3Int))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&setPosition);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodeCoord;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEvidence_Public_Evidence_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Evidence>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 232794, RefRangeEnd = 232797, XrefRangeStart = 232789, XrefRangeEnd = 232794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractablePreset GetPreset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreset_Public_InteractablePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
	}

	public MetaObject(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
