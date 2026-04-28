using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class CompanyStructurePreset : SoCustomComparison
{
	[System.Serializable]
	public class OccupationSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_occupation;

		private static readonly System.IntPtr NativeFieldInfoPtr_positionsMinimum;

		private static readonly System.IntPtr NativeFieldInfoPtr_positionsMaximum;

		private static readonly System.IntPtr NativeFieldInfoPtr_payGrade;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe OccupationPreset occupation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupation);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OccupationPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occupationPreset));
			}
		}

		public unsafe int positionsMinimum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMinimum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMinimum)) = num;
			}
		}

		public unsafe int positionsMaximum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMaximum);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMaximum)) = num;
			}
		}

		public unsafe float payGrade
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_payGrade);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_payGrade)) = num;
			}
		}

		static OccupationSettings()
		{
			Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, "OccupationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr);
			NativeFieldInfoPtr_occupation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr, "occupation");
			NativeFieldInfoPtr_positionsMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr, "positionsMinimum");
			NativeFieldInfoPtr_positionsMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr, "positionsMaximum");
			NativeFieldInfoPtr_payGrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr, "payGrade");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr, 100673859);
		}

		[CallerCount(0)]
		public unsafe OccupationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OccupationSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OccupationSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class BossConfig : OccupationSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_subordinates;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<Hierarchy1Config> subordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Hierarchy1Config>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static BossConfig()
		{
			Il2CppClassPointerStore<BossConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, "BossConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossConfig>.NativeClassPtr);
			NativeFieldInfoPtr_subordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossConfig>.NativeClassPtr, "subordinates");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossConfig>.NativeClassPtr, 100673860);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328018, XrefRangeEnd = 328024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BossConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BossConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Hierarchy1Config : OccupationSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_subordinates;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<Hierarchy2Config> subordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Hierarchy2Config>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static Hierarchy1Config()
		{
			Il2CppClassPointerStore<Hierarchy1Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, "Hierarchy1Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hierarchy1Config>.NativeClassPtr);
			NativeFieldInfoPtr_subordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy1Config>.NativeClassPtr, "subordinates");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy1Config>.NativeClassPtr, 100673861);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328024, XrefRangeEnd = 328030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hierarchy1Config()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy1Config>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Hierarchy1Config(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Hierarchy2Config : OccupationSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_subordinates;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<Hierarchy3Config> subordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Hierarchy3Config>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static Hierarchy2Config()
		{
			Il2CppClassPointerStore<Hierarchy2Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, "Hierarchy2Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hierarchy2Config>.NativeClassPtr);
			NativeFieldInfoPtr_subordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy2Config>.NativeClassPtr, "subordinates");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy2Config>.NativeClassPtr, 100673862);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328030, XrefRangeEnd = 328036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hierarchy2Config()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy2Config>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Hierarchy2Config(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Hierarchy3Config : OccupationSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_subordinates;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<OccupationSettings> subordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationSettings>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static Hierarchy3Config()
		{
			Il2CppClassPointerStore<Hierarchy3Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, "Hierarchy3Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hierarchy3Config>.NativeClassPtr);
			NativeFieldInfoPtr_subordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy3Config>.NativeClassPtr, "subordinates");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy3Config>.NativeClassPtr, 100673863);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328036, XrefRangeEnd = 328042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hierarchy3Config()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy3Config>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Hierarchy3Config(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Hierarchy4Config : OccupationSettings
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static Hierarchy4Config()
		{
			Il2CppClassPointerStore<Hierarchy4Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, "Hierarchy4Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hierarchy4Config>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy4Config>.NativeClassPtr, 100673864);
		}

		[CallerCount(0)]
		public unsafe Hierarchy4Config()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy4Config>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Hierarchy4Config(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_companyStructure;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe BossConfig companyStructure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyStructure);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BossConfig>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyStructure)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bossConfig));
		}
	}

	static CompanyStructurePreset()
	{
		Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CompanyStructurePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr);
		NativeFieldInfoPtr_companyStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, "companyStructure");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr, 100673858);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompanyStructurePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompanyStructurePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CompanyStructurePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
