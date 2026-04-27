using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ColourPalettePreset : SoCustomComparison
{
	[System.Serializable]
	public class MaterialSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_colour;

		private static readonly System.IntPtr NativeFieldInfoPtr_weighting;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Color colour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)) = color;
			}
		}

		public unsafe int weighting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weighting);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weighting)) = num;
			}
		}

		static MaterialSettings()
		{
			Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColourPalettePreset>.NativeClassPtr, "MaterialSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr);
			NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, "colour");
			NativeFieldInfoPtr_weighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, "weighting");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, 100673852);
		}

		[CallerCount(0)]
		public unsafe MaterialSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaterialSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_colours;

	private static readonly System.IntPtr NativeFieldInfoPtr_hexaco;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<MaterialSettings> colours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialSettings>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HEXACO hexaco
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hexaco);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HEXACO>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hexaco)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hEXACO));
		}
	}

	static ColourPalettePreset()
	{
		Il2CppClassPointerStore<ColourPalettePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ColourPalettePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColourPalettePreset>.NativeClassPtr);
		NativeFieldInfoPtr_colours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourPalettePreset>.NativeClassPtr, "colours");
		NativeFieldInfoPtr_hexaco = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourPalettePreset>.NativeClassPtr, "hexaco");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColourPalettePreset>.NativeClassPtr, 100673851);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327947, XrefRangeEnd = 327955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColourPalettePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColourPalettePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ColourPalettePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
