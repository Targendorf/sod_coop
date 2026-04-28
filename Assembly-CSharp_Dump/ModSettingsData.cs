using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ModIO;

[System.Serializable]
public class ModSettingsData : Il2CppSystem.Object
{
	public enum ModSource
	{
		local,
		modIO,
		steamWorkshop
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadOrderValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_creator;

	private static readonly System.IntPtr NativeFieldInfoPtr_summary;

	private static readonly System.IntPtr NativeFieldInfoPtr_enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_modSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_workshopPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_workshopID;

	private static readonly System.IntPtr NativeFieldInfoPtr_workshopTags;

	private static readonly System.IntPtr NativeFieldInfoPtr_modData;

	private static readonly System.IntPtr NativeFieldInfoPtr_directory;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContentDirectory_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSettings_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int loadOrderValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadOrderValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadOrderValue)) = num;
		}
	}

	public unsafe string creator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creator)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string summary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summary);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summary)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabled)) = flag;
		}
	}

	public unsafe ModSource modSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modSource);
			return *(ModSource*)num;
		}
		set
		{
			*(ModSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modSource)) = modSource;
		}
	}

	public unsafe string workshopPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workshopPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workshopPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string workshopID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workshopID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workshopID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> workshopTags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workshopTags);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workshopTags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe UserInstalledMod modData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modData);
			return new UserInstalledMod(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserInstalledMod>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userInstalledMod)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UserInstalledMod>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string directory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directory);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ModSettingsData()
	{
		Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ModSettingsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "name");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "version");
		NativeFieldInfoPtr_loadOrderValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "loadOrderValue");
		NativeFieldInfoPtr_creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "creator");
		NativeFieldInfoPtr_summary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "summary");
		NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "enabled");
		NativeFieldInfoPtr_modSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "modSource");
		NativeFieldInfoPtr_workshopPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "workshopPath");
		NativeFieldInfoPtr_workshopID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "workshopID");
		NativeFieldInfoPtr_workshopTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "workshopTags");
		NativeFieldInfoPtr_modData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "modData");
		NativeFieldInfoPtr_directory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, "directory");
		NativeMethodInfoPtr_GetContentDirectory_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, 100668618);
		NativeMethodInfoPtr_SaveSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, 100668619);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr, 100668620);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 177990, RefRangeEnd = 177994, XrefRangeStart = 177989, XrefRangeEnd = 177990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetContentDirectory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContentDirectory_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 178014, RefRangeEnd = 178021, XrefRangeStart = 177994, XrefRangeEnd = 178014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178021, XrefRangeEnd = 178027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModSettingsData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModSettingsData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModSettingsData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
