using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class SubObjectClassPreset : SoCustomComparison
{
	public enum PlacementTypeLimit
	{
		all,
		companyOnly,
		homeOnly,
		indoorsOnly,
		outdoorsOnly
	}

	private static readonly IntPtr NativeFieldInfoPtr_limitCountPerObject;

	private static readonly IntPtr NativeFieldInfoPtr_maxPerObject;

	private static readonly IntPtr NativeFieldInfoPtr_perObjectSpawnChance;

	private static readonly IntPtr NativeFieldInfoPtr_perInstanceSpawnChance;

	private static readonly IntPtr NativeFieldInfoPtr_perInstanceModifiers;

	private static readonly IntPtr NativeFieldInfoPtr_typeLimit;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool limitCountPerObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCountPerObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCountPerObject)) = flag;
		}
	}

	public unsafe int maxPerObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPerObject);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPerObject)) = num;
		}
	}

	public unsafe float perObjectSpawnChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectSpawnChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectSpawnChance)) = num;
		}
	}

	public unsafe float perInstanceSpawnChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perInstanceSpawnChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perInstanceSpawnChance)) = num;
		}
	}

	public unsafe List<CharacterTrait.TraitPickRule> perInstanceModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perInstanceModifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perInstanceModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe PlacementTypeLimit typeLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeLimit);
			return *(PlacementTypeLimit*)num;
		}
		set
		{
			*(PlacementTypeLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeLimit)) = placementTypeLimit;
		}
	}

	static SubObjectClassPreset()
	{
		Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SubObjectClassPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr);
		NativeFieldInfoPtr_limitCountPerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr, "limitCountPerObject");
		NativeFieldInfoPtr_maxPerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr, "maxPerObject");
		NativeFieldInfoPtr_perObjectSpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr, "perObjectSpawnChance");
		NativeFieldInfoPtr_perInstanceSpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr, "perInstanceSpawnChance");
		NativeFieldInfoPtr_perInstanceModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr, "perInstanceModifiers");
		NativeFieldInfoPtr_typeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr, "typeLimit");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr, 100674053);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330401, XrefRangeEnd = 330409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubObjectClassPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubObjectClassPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SubObjectClassPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
