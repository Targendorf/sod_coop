using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class FactPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_iconSpriteLarge;

	private static readonly IntPtr NativeFieldInfoPtr_subClass;

	private static readonly IntPtr NativeFieldInfoPtr_allowDuplicates;

	private static readonly IntPtr NativeFieldInfoPtr_allowReverseDuplicates;

	private static readonly IntPtr NativeFieldInfoPtr_fromDataKeys;

	private static readonly IntPtr NativeFieldInfoPtr_toDataKeys;

	private static readonly IntPtr NativeFieldInfoPtr_discoverOnCreate;

	private static readonly IntPtr NativeFieldInfoPtr_countsAsNewInformationOnDiscovery;

	private static readonly IntPtr NativeFieldInfoPtr_applyFromKeysOnDiscovery;

	private static readonly IntPtr NativeFieldInfoPtr_applyToKeysOnDiscovery;

	private static readonly IntPtr NativeFieldInfoPtr_discoveryTriggers;

	private static readonly IntPtr NativeFieldInfoPtr_factRank;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Sprite iconSpriteLarge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSpriteLarge);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSpriteLarge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe string subClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subClass);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subClass)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool allowDuplicates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowDuplicates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowDuplicates)) = flag;
		}
	}

	public unsafe bool allowReverseDuplicates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowReverseDuplicates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowReverseDuplicates)) = flag;
		}
	}

	public unsafe List<Evidence.DataKey> fromDataKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromDataKeys);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromDataKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Evidence.DataKey> toDataKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toDataKeys);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toDataKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool discoverOnCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnCreate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnCreate)) = flag;
		}
	}

	public unsafe bool countsAsNewInformationOnDiscovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countsAsNewInformationOnDiscovery);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countsAsNewInformationOnDiscovery)) = flag;
		}
	}

	public unsafe List<Evidence.DataKey> applyFromKeysOnDiscovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyFromKeysOnDiscovery);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyFromKeysOnDiscovery)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Evidence.DataKey> applyToKeysOnDiscovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyToKeysOnDiscovery);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyToKeysOnDiscovery)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Evidence.Discovery> discoveryTriggers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryTriggers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.Discovery>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryTriggers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int factRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factRank)) = num;
		}
	}

	static FactPreset()
	{
		Il2CppClassPointerStore<FactPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FactPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactPreset>.NativeClassPtr);
		NativeFieldInfoPtr_iconSpriteLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "iconSpriteLarge");
		NativeFieldInfoPtr_subClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "subClass");
		NativeFieldInfoPtr_allowDuplicates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "allowDuplicates");
		NativeFieldInfoPtr_allowReverseDuplicates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "allowReverseDuplicates");
		NativeFieldInfoPtr_fromDataKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "fromDataKeys");
		NativeFieldInfoPtr_toDataKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "toDataKeys");
		NativeFieldInfoPtr_discoverOnCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "discoverOnCreate");
		NativeFieldInfoPtr_countsAsNewInformationOnDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "countsAsNewInformationOnDiscovery");
		NativeFieldInfoPtr_applyFromKeysOnDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "applyFromKeysOnDiscovery");
		NativeFieldInfoPtr_applyToKeysOnDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "applyToKeysOnDiscovery");
		NativeFieldInfoPtr_discoveryTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "discoveryTriggers");
		NativeFieldInfoPtr_factRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, "factRank");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactPreset>.NativeClassPtr, 100673903);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328457, XrefRangeEnd = 328485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FactPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
