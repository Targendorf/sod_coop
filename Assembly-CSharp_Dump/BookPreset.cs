using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class BookPreset : SoCustomComparison
{
	public enum BookGenre
	{
		crime,
		history,
		esoteric,
		romance,
		medical,
		science,
		architecture,
		sciFi,
		memoir,
		propaganda,
		politics,
		beauty,
		food,
		nature,
		poetry
	}

	public enum BookSeries
	{
		none,
		detectiveGill,
		talesOfTheHeart,
		candorHistory,
		customSeries1,
		customSeries2,
		customSeries3,
		customSeries4,
		customSeries5,
		customSeries6,
		customSeries7,
		customSeries8,
		customSeries9,
		customSeries10
	}

	public enum SpawnRules
	{
		onlyAtHome,
		onlyAtWork,
		homeOrWork,
		secret
	}

	private static readonly IntPtr NativeFieldInfoPtr_bookName;

	private static readonly IntPtr NativeFieldInfoPtr_author;

	private static readonly IntPtr NativeFieldInfoPtr_genre;

	private static readonly IntPtr NativeFieldInfoPtr_isSeries;

	private static readonly IntPtr NativeFieldInfoPtr_seriesTag;

	private static readonly IntPtr NativeFieldInfoPtr_seriesNumber;

	private static readonly IntPtr NativeFieldInfoPtr_common;

	private static readonly IntPtr NativeFieldInfoPtr_baseChance;

	private static readonly IntPtr NativeFieldInfoPtr_pickRules;

	private static readonly IntPtr NativeFieldInfoPtr_spawnRule;

	private static readonly IntPtr NativeFieldInfoPtr_bookMesh;

	private static readonly IntPtr NativeFieldInfoPtr_bookMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_ddsMessage;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string bookName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string author
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_author)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<BookGenre> genre
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genre);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BookGenre>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genre)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool isSeries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSeries);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSeries)) = flag;
		}
	}

	public unsafe BookSeries seriesTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesTag);
			return *(BookSeries*)num;
		}
		set
		{
			*(BookSeries*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesTag)) = bookSeries;
		}
	}

	public unsafe int seriesNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesNumber)) = num;
		}
	}

	public unsafe float common
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_common);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_common)) = num;
		}
	}

	public unsafe float baseChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance)) = num;
		}
	}

	public unsafe List<CharacterTrait.TraitPickRule> pickRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SpawnRules spawnRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRule);
			return *(SpawnRules*)num;
		}
		set
		{
			*(SpawnRules*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRule)) = spawnRules;
		}
	}

	public unsafe Mesh bookMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMesh);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Material bookMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bookMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe string ddsMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessage);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static BookPreset()
	{
		Il2CppClassPointerStore<BookPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BookPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BookPreset>.NativeClassPtr);
		NativeFieldInfoPtr_bookName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "bookName");
		NativeFieldInfoPtr_author = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "author");
		NativeFieldInfoPtr_genre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "genre");
		NativeFieldInfoPtr_isSeries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "isSeries");
		NativeFieldInfoPtr_seriesTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "seriesTag");
		NativeFieldInfoPtr_seriesNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "seriesNumber");
		NativeFieldInfoPtr_common = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "common");
		NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "baseChance");
		NativeFieldInfoPtr_pickRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "pickRules");
		NativeFieldInfoPtr_spawnRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "spawnRule");
		NativeFieldInfoPtr_bookMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "bookMesh");
		NativeFieldInfoPtr_bookMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "bookMaterial");
		NativeFieldInfoPtr_ddsMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, "ddsMessage");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BookPreset>.NativeClassPtr, 100673808);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326876, XrefRangeEnd = 326884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BookPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BookPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BookPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
