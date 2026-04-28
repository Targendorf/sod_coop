using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace BrainFailProductions.PolyFew;

[System.Serializable]
public class ToleranceSphereJson : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_worldPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_diameter;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_preservationStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHidden;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Color_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ToleranceSphere_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Vector3_Single_Color_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DumpFromToleranceSphere_Public_Void_ToleranceSphere_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DumpToToleranceSphere_Public_Void_byref_ToleranceSphere_0;

	public unsafe Vector3 worldPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPosition)) = vector;
		}
	}

	public unsafe float diameter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diameter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diameter)) = num;
		}
	}

	public unsafe Color color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
		}
	}

	public unsafe float preservationStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preservationStrength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preservationStrength)) = num;
		}
	}

	public unsafe bool isHidden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHidden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHidden)) = flag;
		}
	}

	static ToleranceSphereJson()
	{
		Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew", "ToleranceSphereJson");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr);
		NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, "worldPosition");
		NativeFieldInfoPtr_diameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, "diameter");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, "color");
		NativeFieldInfoPtr_preservationStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, "preservationStrength");
		NativeFieldInfoPtr_isHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, "isHidden");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, 100676908);
		NativeMethodInfoPtr__ctor_Public_Void_ToleranceSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, 100676909);
		NativeMethodInfoPtr_SetProperties_Public_Void_Vector3_Single_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, 100676910);
		NativeMethodInfoPtr_DumpFromToleranceSphere_Public_Void_ToleranceSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, 100676911);
		NativeMethodInfoPtr_DumpToToleranceSphere_Public_Void_byref_ToleranceSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr, 100676912);
	}

	[CallerCount(0)]
	public unsafe ToleranceSphereJson(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&worldPosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &diameter;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &preservationStrength;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHidden;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369513, XrefRangeEnd = 369535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToleranceSphereJson(ToleranceSphere toleranceSphere)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToleranceSphereJson>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toleranceSphere);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ToleranceSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&worldPosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &diameter;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &preservationStrength;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHidden;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Vector3_Single_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369535, XrefRangeEnd = 369546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DumpFromToleranceSphere(ToleranceSphere toleranceSphere)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toleranceSphere);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DumpFromToleranceSphere_Public_Void_ToleranceSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369546, XrefRangeEnd = 369557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DumpToToleranceSphere(ref ToleranceSphere toleranceSphere)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toleranceSphere);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DumpToToleranceSphere_Public_Void_byref_ToleranceSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		toleranceSphere = ((intPtr4 == (System.IntPtr)0) ? null : new ToleranceSphere(intPtr4));
	}

	public ToleranceSphereJson(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
