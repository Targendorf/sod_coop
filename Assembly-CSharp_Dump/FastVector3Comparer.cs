using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class FastVector3Comparer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sharedFastVector3Comparer;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__Equals_Private_Virtual_Final_New_Boolean_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__GetHashCode_Private_Virtual_Final_New_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SharedFastVector3Comparer_Public_Static_get_FastVector3Comparer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static FastVector3Comparer sharedFastVector3Comparer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sharedFastVector3Comparer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastVector3Comparer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sharedFastVector3Comparer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fastVector3Comparer));
		}
	}

	public unsafe static FastVector3Comparer SharedFastVector3Comparer
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99847, RefRangeEnd = 99849, XrefRangeStart = 99841, XrefRangeEnd = 99847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SharedFastVector3Comparer_Public_Static_get_FastVector3Comparer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastVector3Comparer>(intPtr) : null;
		}
	}

	static FastVector3Comparer()
	{
		Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FastVector3Comparer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr);
		NativeFieldInfoPtr_sharedFastVector3Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr, "sharedFastVector3Comparer");
		NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__Equals_Private_Virtual_Final_New_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr, 100666123);
		NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__GetHashCode_Private_Virtual_Final_New_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr, 100666124);
		NativeMethodInfoPtr_get_SharedFastVector3Comparer_Public_Static_get_FastVector3Comparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr, 100666125);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr, 100666126);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99827, XrefRangeEnd = 99833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__Equals(Vector3 x, Vector3 y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__Equals_Private_Virtual_Final_New_Boolean_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99833, XrefRangeEnd = 99841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__GetHashCode(Vector3 obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEqualityComparer_UnityEngine_Vector3__GetHashCode_Private_Virtual_Final_New_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FastVector3Comparer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastVector3Comparer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FastVector3Comparer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
