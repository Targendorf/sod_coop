using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class ColourSchemePreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_primary1;

	private static readonly IntPtr NativeFieldInfoPtr_secondary1;

	private static readonly IntPtr NativeFieldInfoPtr_neutral;

	private static readonly IntPtr NativeFieldInfoPtr_secondary2;

	private static readonly IntPtr NativeFieldInfoPtr_primary2;

	private static readonly IntPtr NativeFieldInfoPtr_modernity;

	private static readonly IntPtr NativeFieldInfoPtr_cleanness;

	private static readonly IntPtr NativeFieldInfoPtr_loudness;

	private static readonly IntPtr NativeFieldInfoPtr_emotive;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Color primary1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primary1);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primary1)) = color;
		}
	}

	public unsafe Color secondary1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondary1);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondary1)) = color;
		}
	}

	public unsafe Color neutral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neutral);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neutral)) = color;
		}
	}

	public unsafe Color secondary2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondary2);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondary2)) = color;
		}
	}

	public unsafe Color primary2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primary2);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primary2)) = color;
		}
	}

	public unsafe int modernity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modernity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modernity)) = num;
		}
	}

	public unsafe int cleanness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanness)) = num;
		}
	}

	public unsafe int loudness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loudness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loudness)) = num;
		}
	}

	public unsafe int emotive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotive)) = num;
		}
	}

	static ColourSchemePreset()
	{
		Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ColourSchemePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr);
		NativeFieldInfoPtr_primary1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "primary1");
		NativeFieldInfoPtr_secondary1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "secondary1");
		NativeFieldInfoPtr_neutral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "neutral");
		NativeFieldInfoPtr_secondary2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "secondary2");
		NativeFieldInfoPtr_primary2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "primary2");
		NativeFieldInfoPtr_modernity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "modernity");
		NativeFieldInfoPtr_cleanness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "cleanness");
		NativeFieldInfoPtr_loudness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "loudness");
		NativeFieldInfoPtr_emotive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, "emotive");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr, 100673853);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327955, XrefRangeEnd = 327956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColourSchemePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColourSchemePreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ColourSchemePreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
