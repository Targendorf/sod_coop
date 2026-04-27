using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
public class CityInfoData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cityName;

	private static readonly System.IntPtr NativeFieldInfoPtr_build;

	private static readonly System.IntPtr NativeFieldInfoPtr_shareCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_citySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_population;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string cityName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string build
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shareCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareCode);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareCode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Vector2 citySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySize)) = vector;
		}
	}

	public unsafe int population
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_population);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_population)) = num;
		}
	}

	static CityInfoData()
	{
		Il2CppClassPointerStore<CityInfoData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CityInfoData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr);
		NativeFieldInfoPtr_cityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr, "cityName");
		NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr, "build");
		NativeFieldInfoPtr_shareCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr, "shareCode");
		NativeFieldInfoPtr_citySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr, "citySize");
		NativeFieldInfoPtr_population = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr, "population");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr, 100670315);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 241150, RefRangeEnd = 241153, XrefRangeStart = 241146, XrefRangeEnd = 241150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CityInfoData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CityInfoData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CityInfoData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
