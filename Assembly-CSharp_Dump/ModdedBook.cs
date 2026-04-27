using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class ModdedBook : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_copyDataFrom;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookName;

	private static readonly System.IntPtr NativeFieldInfoPtr_author;

	private static readonly System.IntPtr NativeFieldInfoPtr_genre;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSeries;

	private static readonly System.IntPtr NativeFieldInfoPtr_seriesTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_seriesNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_common;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickRules1;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickRules2;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickRules3;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_bookMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_ddsMessage;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string copyDataFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDataFrom);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDataFrom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bookName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string author
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> genre
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genre);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genre)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string isSeries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSeries);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSeries)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string seriesTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesTag);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesTag)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string seriesNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesNumber);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesNumber)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string common
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_common);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_common)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string baseChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> pickRules1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> pickRules2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> pickRules3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string spawnRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRule);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRule)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bookMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMesh);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMesh)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bookMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMaterial);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ddsMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ModdedBook()
	{
		Il2CppClassPointerStore<ModdedBook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ModdedBook");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr);
		NativeFieldInfoPtr_copyDataFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "copyDataFrom");
		NativeFieldInfoPtr_bookName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "bookName");
		NativeFieldInfoPtr_author = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "author");
		NativeFieldInfoPtr_genre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "genre");
		NativeFieldInfoPtr_isSeries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "isSeries");
		NativeFieldInfoPtr_seriesTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "seriesTag");
		NativeFieldInfoPtr_seriesNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "seriesNumber");
		NativeFieldInfoPtr_common = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "common");
		NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "baseChance");
		NativeFieldInfoPtr_pickRules1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "pickRules1");
		NativeFieldInfoPtr_pickRules2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "pickRules2");
		NativeFieldInfoPtr_pickRules3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "pickRules3");
		NativeFieldInfoPtr_spawnRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "spawnRule");
		NativeFieldInfoPtr_bookMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "bookMesh");
		NativeFieldInfoPtr_bookMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "bookMaterial");
		NativeFieldInfoPtr_ddsMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, "ddsMessage");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr, 100673192);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313983, XrefRangeEnd = 313997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModdedBook()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModdedBook>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModdedBook(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
