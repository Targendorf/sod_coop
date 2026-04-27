using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

public class ModelUtil : Il2CppSystem.Object
{
	public enum MtlBlendMode
	{
		OPAQUE,
		CUTOUT,
		FADE,
		TRANSPARENT
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupMaterialWithBlendMode_Public_Static_Void_Material_MtlBlendMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanTransparentPixels_Public_Static_Boolean_Texture2D_byref_MtlBlendMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetectMtlBlendFadeOrCutout_Public_Static_Void_Single_byref_MtlBlendMode_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HeightToNormalMap_Public_Static_Texture2D_Texture2D_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WrapInt_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ModelUtil()
	{
		Il2CppClassPointerStore<ModelUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "ModelUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr);
		NativeMethodInfoPtr_SetupMaterialWithBlendMode_Public_Static_Void_Material_MtlBlendMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr, 100676987);
		NativeMethodInfoPtr_ScanTransparentPixels_Public_Static_Boolean_Texture2D_byref_MtlBlendMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr, 100676988);
		NativeMethodInfoPtr_DetectMtlBlendFadeOrCutout_Public_Static_Void_Single_byref_MtlBlendMode_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr, 100676989);
		NativeMethodInfoPtr_HeightToNormalMap_Public_Static_Texture2D_Texture2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr, 100676990);
		NativeMethodInfoPtr_WrapInt_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr, 100676991);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr, 100676992);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371060, RefRangeEnd = 371061, XrefRangeStart = 371013, XrefRangeEnd = 371060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupMaterialWithBlendMode(Material mtl, MtlBlendMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mtl);
		*(MtlBlendMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupMaterialWithBlendMode_Public_Static_Void_Material_MtlBlendMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 371085, RefRangeEnd = 371087, XrefRangeStart = 371061, XrefRangeEnd = 371085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ScanTransparentPixels(Texture2D texture, ref MtlBlendMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanTransparentPixels_Public_Static_Boolean_Texture2D_byref_MtlBlendMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void DetectMtlBlendFadeOrCutout(float alpha, ref MtlBlendMode mode, ref bool noDoubt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&alpha);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mode);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref noDoubt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetectMtlBlendFadeOrCutout_Public_Static_Void_Single_byref_MtlBlendMode_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371111, RefRangeEnd = 371112, XrefRangeStart = 371087, XrefRangeEnd = 371111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D HeightToNormalMap(Texture2D bumpMap, float amount = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bumpMap);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HeightToNormalMap_Public_Static_Texture2D_Texture2D_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static int WrapInt(int pos, int boundary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundary;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WrapInt_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelUtil>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModelUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
