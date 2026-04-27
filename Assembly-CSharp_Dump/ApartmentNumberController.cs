using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ApartmentNumberController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_numberPrefabs;

	private static readonly IntPtr NativeFieldInfoPtr_spawned;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_NewNode_NewDoor_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<GameObject> numberPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberPrefabs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberPrefabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Transform> spawned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawned);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawned)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ApartmentNumberController()
	{
		Il2CppClassPointerStore<ApartmentNumberController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ApartmentNumberController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApartmentNumberController>.NativeClassPtr);
		NativeFieldInfoPtr_numberPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApartmentNumberController>.NativeClassPtr, "numberPrefabs");
		NativeFieldInfoPtr_spawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApartmentNumberController>.NativeClassPtr, "spawned");
		NativeMethodInfoPtr_Setup_Public_Void_NewNode_NewDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApartmentNumberController>.NativeClassPtr, 100669325);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApartmentNumberController>.NativeClassPtr, 100669326);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 203597, RefRangeEnd = 203599, XrefRangeStart = 203527, XrefRangeEnd = 203597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(NewNode behindNode, NewDoor door)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)behindNode);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)door);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_NewNode_NewDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203599, XrefRangeEnd = 203614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ApartmentNumberController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApartmentNumberController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ApartmentNumberController(IntPtr pointer)
		: base(pointer)
	{
	}
}
