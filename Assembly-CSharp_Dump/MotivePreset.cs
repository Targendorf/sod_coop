using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class MotivePreset : SoCustomComparison
{
	[System.Serializable]
	public class ModifierRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_score;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CharacterTrait.RuleType rule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule);
				return *(CharacterTrait.RuleType*)num;
			}
			set
			{
				*(CharacterTrait.RuleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule)) = ruleType;
			}
		}

		public unsafe List<CharacterTrait> traitList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool mustPassForApplication
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustPassForApplication);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustPassForApplication)) = flag;
			}
		}

		public unsafe int score
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_score)) = num;
			}
		}

		static ModifierRule()
		{
			Il2CppClassPointerStore<ModifierRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "ModifierRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierRule>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierRule>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierRule>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierRule>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierRule>.NativeClassPtr, "score");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierRule>.NativeClassPtr, 100673982);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329399, XrefRangeEnd = 329405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModifierRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ModifierRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_allowHomelessPurps;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowJoblessPurps;

	private static readonly System.IntPtr NativeFieldInfoPtr_purpMustLiveAtDifferentAddressToPoster;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowEnforcers;

	private static readonly System.IntPtr NativeFieldInfoPtr_disallowEchelonHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_purpTraitModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePurpJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_purpJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowHomelessPosters;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowJoblessPosters;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePosterConnections;

	private static readonly System.IntPtr NativeFieldInfoPtr_acceptableConnections;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePosterTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_posterTraitModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_purpIsExemptFromPostingOtherJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_purpIsExemptFromPurpingOtherJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_posterIsExemptFromPostingOtherJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_posterIsExemptFromPurpingOtherJobs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool allowHomelessPurps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHomelessPurps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHomelessPurps)) = flag;
		}
	}

	public unsafe bool allowJoblessPurps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowJoblessPurps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowJoblessPurps)) = flag;
		}
	}

	public unsafe bool purpMustLiveAtDifferentAddressToPoster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpMustLiveAtDifferentAddressToPoster);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpMustLiveAtDifferentAddressToPoster)) = flag;
		}
	}

	public unsafe bool allowEnforcers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowEnforcers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowEnforcers)) = flag;
		}
	}

	public unsafe bool disallowEchelonHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallowEchelonHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallowEchelonHome)) = flag;
		}
	}

	public unsafe List<ModifierRule> purpTraitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpTraitModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ModifierRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpTraitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool usePurpJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePurpJobs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePurpJobs)) = flag;
		}
	}

	public unsafe List<OccupationPreset> purpJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool allowHomelessPosters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHomelessPosters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHomelessPosters)) = flag;
		}
	}

	public unsafe bool allowJoblessPosters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowJoblessPosters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowJoblessPosters)) = flag;
		}
	}

	public unsafe bool usePosterConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePosterConnections);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePosterConnections)) = flag;
		}
	}

	public unsafe List<Acquaintance.ConnectionType> acceptableConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceptableConnections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Acquaintance.ConnectionType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceptableConnections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool usePosterTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePosterTraits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePosterTraits)) = flag;
		}
	}

	public unsafe List<ModifierRule> posterTraitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posterTraitModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ModifierRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posterTraitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool purpIsExemptFromPostingOtherJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpIsExemptFromPostingOtherJobs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpIsExemptFromPostingOtherJobs)) = flag;
		}
	}

	public unsafe bool purpIsExemptFromPurpingOtherJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpIsExemptFromPurpingOtherJobs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpIsExemptFromPurpingOtherJobs)) = flag;
		}
	}

	public unsafe bool posterIsExemptFromPostingOtherJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posterIsExemptFromPostingOtherJobs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posterIsExemptFromPostingOtherJobs)) = flag;
		}
	}

	public unsafe bool posterIsExemptFromPurpingOtherJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posterIsExemptFromPurpingOtherJobs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posterIsExemptFromPurpingOtherJobs)) = flag;
		}
	}

	static MotivePreset()
	{
		Il2CppClassPointerStore<MotivePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MotivePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr);
		NativeFieldInfoPtr_allowHomelessPurps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "allowHomelessPurps");
		NativeFieldInfoPtr_allowJoblessPurps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "allowJoblessPurps");
		NativeFieldInfoPtr_purpMustLiveAtDifferentAddressToPoster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "purpMustLiveAtDifferentAddressToPoster");
		NativeFieldInfoPtr_allowEnforcers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "allowEnforcers");
		NativeFieldInfoPtr_disallowEchelonHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "disallowEchelonHome");
		NativeFieldInfoPtr_purpTraitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "purpTraitModifiers");
		NativeFieldInfoPtr_usePurpJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "usePurpJobs");
		NativeFieldInfoPtr_purpJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "purpJobs");
		NativeFieldInfoPtr_allowHomelessPosters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "allowHomelessPosters");
		NativeFieldInfoPtr_allowJoblessPosters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "allowJoblessPosters");
		NativeFieldInfoPtr_usePosterConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "usePosterConnections");
		NativeFieldInfoPtr_acceptableConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "acceptableConnections");
		NativeFieldInfoPtr_usePosterTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "usePosterTraits");
		NativeFieldInfoPtr_posterTraitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "posterTraitModifiers");
		NativeFieldInfoPtr_purpIsExemptFromPostingOtherJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "purpIsExemptFromPostingOtherJobs");
		NativeFieldInfoPtr_purpIsExemptFromPurpingOtherJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "purpIsExemptFromPurpingOtherJobs");
		NativeFieldInfoPtr_posterIsExemptFromPostingOtherJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "posterIsExemptFromPostingOtherJobs");
		NativeFieldInfoPtr_posterIsExemptFromPurpingOtherJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, "posterIsExemptFromPurpingOtherJobs");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr, 100673981);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329405, XrefRangeEnd = 329429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MotivePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotivePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MotivePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
