using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

public static class Triangulator : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Triangulate_Public_Static_Void_DataSet_Il2CppStructArray_1_FaceIndices_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPlaneNormal_Public_Static_Vector3_DataSet_Il2CppStructArray_1_FaceIndices_0;

	static Triangulator()
	{
		Il2CppClassPointerStore<Triangulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "Triangulator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Triangulator>.NativeClassPtr);
		NativeMethodInfoPtr_Triangulate_Public_Static_Void_DataSet_Il2CppStructArray_1_FaceIndices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100677009);
		NativeMethodInfoPtr_FindPlaneNormal_Public_Static_Vector3_DataSet_Il2CppStructArray_1_FaceIndices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulator>.NativeClassPtr, 100677010);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371812, RefRangeEnd = 371813, XrefRangeStart = 371787, XrefRangeEnd = 371812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Triangulate(DataSet dataSet, Il2CppStructArray<DataSet.FaceIndices> face)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataSet);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)face);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Triangulate_Public_Static_Void_DataSet_Il2CppStructArray_1_FaceIndices_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371823, RefRangeEnd = 371824, XrefRangeStart = 371813, XrefRangeEnd = 371823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 FindPlaneNormal(DataSet dataSet, Il2CppStructArray<DataSet.FaceIndices> face)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataSet);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)face);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPlaneNormal_Public_Static_Vector3_DataSet_Il2CppStructArray_1_FaceIndices_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Triangulator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
