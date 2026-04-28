using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace BrainFailProductions.PolyFew;

[Serializable]
public class ToleranceSphere : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

	private static readonly IntPtr NativeFieldInfoPtr_diameter;

	private static readonly IntPtr NativeFieldInfoPtr_color;

	private static readonly IntPtr NativeFieldInfoPtr_preservationStrength;

	private static readonly IntPtr NativeFieldInfoPtr_isHidden;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Color_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_ToleranceSphereJson_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Vector3_Single_Color_Single_Boolean_0;

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

	static ToleranceSphere()
	{
		Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew", "ToleranceSphere");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr);
		NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, "worldPosition");
		NativeFieldInfoPtr_diameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, "diameter");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, "color");
		NativeFieldInfoPtr_preservationStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, "preservationStrength");
		NativeFieldInfoPtr_isHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, "isHidden");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, 100676905);
		NativeMethodInfoPtr_SetProperties_Public_Void_ToleranceSphereJson_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, 100676906);
		NativeMethodInfoPtr_SetProperties_Public_Void_Vector3_Single_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr, 100676907);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369512, XrefRangeEnd = 369513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToleranceSphere(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToleranceSphere>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&worldPosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &diameter;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &preservationStrength;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &isHidden;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetProperties(ToleranceSphereJson tSphereJson)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tSphereJson);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_ToleranceSphereJson_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&worldPosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &diameter;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &preservationStrength;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &isHidden;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Vector3_Single_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ToleranceSphere(IntPtr pointer)
		: base(pointer)
	{
	}
}
