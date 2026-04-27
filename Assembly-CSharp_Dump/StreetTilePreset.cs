using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class StreetTilePreset : SoCustomComparison
{
	[System.Serializable]
	public class StreetSectionModel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_normalMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_rainMaterial;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe GameObject prefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe Material normalMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe Material rainMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		static StreetSectionModel()
		{
			Il2CppClassPointerStore<StreetSectionModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreetTilePreset>.NativeClassPtr, "StreetSectionModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetSectionModel>.NativeClassPtr);
			NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetSectionModel>.NativeClassPtr, "prefab");
			NativeFieldInfoPtr_normalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetSectionModel>.NativeClassPtr, "normalMaterial");
			NativeFieldInfoPtr_rainMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetSectionModel>.NativeClassPtr, "rainMaterial");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetSectionModel>.NativeClassPtr, 100674052);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetSectionModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetSectionModel>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StreetSectionModel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum StreetSection
	{
		streetLong,
		streetShort,
		streetInsideCorner,
		streetJunctionCorner,
		streetOutsideCorner,
		joinerLong,
		joinerShort
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_sectionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StreetSection sectionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sectionType);
			return *(StreetSection*)num;
		}
		set
		{
			*(StreetSection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sectionType)) = streetSection;
		}
	}

	public unsafe List<StreetSectionModel> prefabList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StreetSectionModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static StreetTilePreset()
	{
		Il2CppClassPointerStore<StreetTilePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StreetTilePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetTilePreset>.NativeClassPtr);
		NativeFieldInfoPtr_sectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetTilePreset>.NativeClassPtr, "sectionType");
		NativeFieldInfoPtr_prefabList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetTilePreset>.NativeClassPtr, "prefabList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetTilePreset>.NativeClassPtr, 100674051);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330393, XrefRangeEnd = 330401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StreetTilePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetTilePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StreetTilePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
