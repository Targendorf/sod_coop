using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MurderPreset : SoCustomComparison
{
	public enum CaseType
	{
		murder,
		sniper,
		kidnap
	}

	[System.Serializable]
	public class MurdererModifierRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_scoreModifier;

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

		public unsafe float scoreModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scoreModifier)) = num;
			}
		}

		static MurdererModifierRule()
		{
			Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "MurdererModifierRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_scoreModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr, "scoreModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr, 100673991);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329565, XrefRangeEnd = 329571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MurdererModifierRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurdererModifierRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MurdererModifierRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum SuccessfulTravelTrigger
	{
		whenMurdererIsAtTheSameLocation,
		whenMurdererIsAtVantagePoint
	}

	public enum LeadCitizen
	{
		nobody,
		victim,
		killer,
		victimsClosest,
		killersClosest,
		victimsDoctor,
		killersDoctor,
		ransom,
		victimsLandlord,
		KillersLandlord
	}

	public enum LeadSpawnWhere
	{
		victimHome,
		victimWork,
		killerHome,
		killerWork,
		ransom,
		killerDen
	}

	[System.Serializable]
	public class MurderModifierRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_who;

		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe LeadCitizen who
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who)) = leadCitizen;
			}
		}

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

		public unsafe float chanceModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceModifier)) = num;
			}
		}

		static MurderModifierRule()
		{
			Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "MurderModifierRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr);
			NativeFieldInfoPtr_who = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr, "who");
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_chanceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr, "chanceModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr, 100673992);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329571, XrefRangeEnd = 329577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MurderModifierRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurderModifierRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MurderModifierRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class MurderLeadItem : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleWithAllMotives;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleWithMotives;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawnOnPhase;

		private static readonly System.IntPtr NativeFieldInfoPtr_tryToSpawnWithEachNewMurder;

		private static readonly System.IntPtr NativeFieldInfoPtr_belongsTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_chance;

		private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitModifiers;

		private static readonly System.IntPtr NativeFieldInfoPtr_useIf;

		private static readonly System.IntPtr NativeFieldInfoPtr_ifTag;

		private static readonly System.IntPtr NativeFieldInfoPtr_useOrGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_orGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemTag;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawnItem;

		private static readonly System.IntPtr NativeFieldInfoPtr_vmailThread;

		private static readonly System.IntPtr NativeFieldInfoPtr_vmailProgressThreshold;

		private static readonly System.IntPtr NativeFieldInfoPtr_writer;

		private static readonly System.IntPtr NativeFieldInfoPtr_receiver;

		private static readonly System.IntPtr NativeFieldInfoPtr_vmailOtherParticipants;

		private static readonly System.IntPtr NativeFieldInfoPtr_where;

		private static readonly System.IntPtr NativeFieldInfoPtr_security;

		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		private static readonly System.IntPtr NativeFieldInfoPtr_ownershipRule;

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

		public unsafe bool compatibleWithAllMotives
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithAllMotives);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithAllMotives)) = flag;
			}
		}

		public unsafe List<MurderMO> compatibleWithMotives
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithMotives);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderMO>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithMotives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe MurderController.MurderState spawnOnPhase
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnOnPhase);
				return *(MurderController.MurderState*)num;
			}
			set
			{
				*(MurderController.MurderState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnOnPhase)) = murderState;
			}
		}

		public unsafe bool tryToSpawnWithEachNewMurder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tryToSpawnWithEachNewMurder);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tryToSpawnWithEachNewMurder)) = flag;
			}
		}

		public unsafe LeadCitizen belongsTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo)) = leadCitizen;
			}
		}

		public unsafe float chance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance)) = num;
			}
		}

		public unsafe bool useTraits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTraits);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTraits)) = flag;
			}
		}

		public unsafe List<MurderModifierRule> traitModifiers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderModifierRule>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool useIf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useIf);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useIf)) = flag;
			}
		}

		public unsafe JobPreset.JobTag ifTag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifTag);
				return *(JobPreset.JobTag*)num;
			}
			set
			{
				*(JobPreset.JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifTag)) = jobTag;
			}
		}

		public unsafe bool useOrGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOrGroup);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOrGroup)) = flag;
			}
		}

		public unsafe JobPreset.JobTag orGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orGroup);
				return *(JobPreset.JobTag*)num;
			}
			set
			{
				*(JobPreset.JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orGroup)) = jobTag;
			}
		}

		public unsafe int chanceRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceRatio)) = num;
			}
		}

		public unsafe JobPreset.JobTag itemTag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTag);
				return *(JobPreset.JobTag*)num;
			}
			set
			{
				*(JobPreset.JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTag)) = jobTag;
			}
		}

		public unsafe InteractablePreset spawnItem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe string vmailThread
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailThread);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailThread)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Vector2 vmailProgressThreshold
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailProgressThreshold);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailProgressThreshold)) = vector;
			}
		}

		public unsafe LeadCitizen writer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)) = leadCitizen;
			}
		}

		public unsafe LeadCitizen receiver
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver)) = leadCitizen;
			}
		}

		public unsafe List<LeadCitizen> vmailOtherParticipants
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailOtherParticipants);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LeadCitizen>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailOtherParticipants)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe LeadSpawnWhere where
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_where);
				return *(LeadSpawnWhere*)num;
			}
			set
			{
				*(LeadSpawnWhere*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_where)) = leadSpawnWhere;
			}
		}

		public unsafe int security
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security)) = num;
			}
		}

		public unsafe int priority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
			}
		}

		public unsafe InteractablePreset.OwnedPlacementRule ownershipRule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipRule);
				return *(InteractablePreset.OwnedPlacementRule*)num;
			}
			set
			{
				*(InteractablePreset.OwnedPlacementRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipRule)) = ownedPlacementRule;
			}
		}

		static MurderLeadItem()
		{
			Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "MurderLeadItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "name");
			NativeFieldInfoPtr_compatibleWithAllMotives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "compatibleWithAllMotives");
			NativeFieldInfoPtr_compatibleWithMotives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "compatibleWithMotives");
			NativeFieldInfoPtr_spawnOnPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "spawnOnPhase");
			NativeFieldInfoPtr_tryToSpawnWithEachNewMurder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "tryToSpawnWithEachNewMurder");
			NativeFieldInfoPtr_belongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "belongsTo");
			NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "chance");
			NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "useTraits");
			NativeFieldInfoPtr_traitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "traitModifiers");
			NativeFieldInfoPtr_useIf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "useIf");
			NativeFieldInfoPtr_ifTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "ifTag");
			NativeFieldInfoPtr_useOrGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "useOrGroup");
			NativeFieldInfoPtr_orGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "orGroup");
			NativeFieldInfoPtr_chanceRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "chanceRatio");
			NativeFieldInfoPtr_itemTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "itemTag");
			NativeFieldInfoPtr_spawnItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "spawnItem");
			NativeFieldInfoPtr_vmailThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "vmailThread");
			NativeFieldInfoPtr_vmailProgressThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "vmailProgressThreshold");
			NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "writer");
			NativeFieldInfoPtr_receiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "receiver");
			NativeFieldInfoPtr_vmailOtherParticipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "vmailOtherParticipants");
			NativeFieldInfoPtr_where = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "where");
			NativeFieldInfoPtr_security = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "security");
			NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "priority");
			NativeFieldInfoPtr_ownershipRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, "ownershipRule");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr, 100673993);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329577, XrefRangeEnd = 329595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MurderLeadItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurderLeadItem>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MurderLeadItem(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_caseType;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererRandomScoreRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_murdererTraitModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_useHexaco;

	private static readonly System.IntPtr NativeFieldInfoPtr_hexaco;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickDen;

	private static readonly System.IntPtr NativeFieldInfoPtr_kidnapperTimeUntilKill;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumTimeBetweenMurders;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonHomeMaximumOccupantsTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonHomeMaximumOccupantsCancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresAcquirePhase;

	private static readonly System.IntPtr NativeFieldInfoPtr_acquirePassInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_acquirePassRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_acquireActionSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresResearchPhase;

	private static readonly System.IntPtr NativeFieldInfoPtr_killerMeetsVicim;

	private static readonly System.IntPtr NativeFieldInfoPtr_researchPassInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_researchPassRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_researchActionSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockVictimFromLeavingLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_travelSuccessTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_travelPassInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_travelPassRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_travelActionSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_executePassInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_executePassRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_executionActionSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_postPassInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_postPassRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_postActionSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_escapePassInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_escapePassRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_escapeActionSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_leads;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCustomResolveQuestions;

	private static readonly System.IntPtr NativeFieldInfoPtr_customResolveQuestions;

	private static readonly System.IntPtr NativeFieldInfoPtr_copyFrom;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeads_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CaseType caseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseType);
			return *(CaseType*)num;
		}
		set
		{
			*(CaseType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseType)) = caseType;
		}
	}

	public unsafe bool disabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)) = flag;
		}
	}

	public unsafe int frequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency)) = num;
		}
	}

	public unsafe Vector2 murdererRandomScoreRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererRandomScoreRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererRandomScoreRange)) = vector;
		}
	}

	public unsafe List<MurdererModifierRule> murdererTraitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererTraitModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurdererModifierRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murdererTraitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useHexaco
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHexaco);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHexaco)) = flag;
		}
	}

	public unsafe HEXACO hexaco
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hexaco);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HEXACO>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hexaco)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hEXACO));
		}
	}

	public unsafe bool pickDen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickDen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickDen)) = flag;
		}
	}

	public unsafe float kidnapperTimeUntilKill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperTimeUntilKill);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperTimeUntilKill)) = num;
		}
	}

	public unsafe float minimumTimeBetweenMurders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumTimeBetweenMurders);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumTimeBetweenMurders)) = num;
		}
	}

	public unsafe int nonHomeMaximumOccupantsTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonHomeMaximumOccupantsTrigger);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonHomeMaximumOccupantsTrigger)) = num;
		}
	}

	public unsafe int nonHomeMaximumOccupantsCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonHomeMaximumOccupantsCancel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonHomeMaximumOccupantsCancel)) = num;
		}
	}

	public unsafe bool requiresAcquirePhase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresAcquirePhase);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresAcquirePhase)) = flag;
		}
	}

	public unsafe bool acquirePassInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquirePassInteractable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquirePassInteractable)) = flag;
		}
	}

	public unsafe bool acquirePassRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquirePassRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquirePassRoom)) = flag;
		}
	}

	public unsafe List<AIGoalPreset.GoalActionSetup> acquireActionSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquireActionSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset.GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquireActionSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool requiresResearchPhase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresResearchPhase);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresResearchPhase)) = flag;
		}
	}

	public unsafe bool killerMeetsVicim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killerMeetsVicim);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killerMeetsVicim)) = flag;
		}
	}

	public unsafe bool researchPassInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_researchPassInteractable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_researchPassInteractable)) = flag;
		}
	}

	public unsafe bool researchPassRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_researchPassRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_researchPassRoom)) = flag;
		}
	}

	public unsafe List<AIGoalPreset.GoalActionSetup> researchActionSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_researchActionSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset.GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_researchActionSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool blockVictimFromLeavingLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockVictimFromLeavingLocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockVictimFromLeavingLocation)) = flag;
		}
	}

	public unsafe SuccessfulTravelTrigger travelSuccessTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelSuccessTrigger);
			return *(SuccessfulTravelTrigger*)num;
		}
		set
		{
			*(SuccessfulTravelTrigger*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelSuccessTrigger)) = successfulTravelTrigger;
		}
	}

	public unsafe bool travelPassInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelPassInteractable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelPassInteractable)) = flag;
		}
	}

	public unsafe bool travelPassRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelPassRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelPassRoom)) = flag;
		}
	}

	public unsafe List<AIGoalPreset.GoalActionSetup> travelActionSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelActionSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset.GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelActionSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool executePassInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executePassInteractable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executePassInteractable)) = flag;
		}
	}

	public unsafe bool executePassRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executePassRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executePassRoom)) = flag;
		}
	}

	public unsafe List<AIGoalPreset.GoalActionSetup> executionActionSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executionActionSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset.GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executionActionSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool postPassInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postPassInteractable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postPassInteractable)) = flag;
		}
	}

	public unsafe bool postPassRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postPassRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postPassRoom)) = flag;
		}
	}

	public unsafe List<AIGoalPreset.GoalActionSetup> postActionSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postActionSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset.GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postActionSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool escapePassInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapePassInteractable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapePassInteractable)) = flag;
		}
	}

	public unsafe bool escapePassRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapePassRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapePassRoom)) = flag;
		}
	}

	public unsafe List<AIGoalPreset.GoalActionSetup> escapeActionSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapeActionSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset.GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapeActionSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MurderLeadItem> leads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderLeadItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useCustomResolveQuestions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomResolveQuestions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomResolveQuestions)) = flag;
		}
	}

	public unsafe List<Case.ResolveQuestion> customResolveQuestions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customResolveQuestions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Case.ResolveQuestion>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customResolveQuestions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe MurderPreset copyFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MurderPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)murderPreset));
		}
	}

	static MurderPreset()
	{
		Il2CppClassPointerStore<MurderPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MurderPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr);
		NativeFieldInfoPtr_caseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "caseType");
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "frequency");
		NativeFieldInfoPtr_murdererRandomScoreRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "murdererRandomScoreRange");
		NativeFieldInfoPtr_murdererTraitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "murdererTraitModifiers");
		NativeFieldInfoPtr_useHexaco = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "useHexaco");
		NativeFieldInfoPtr_hexaco = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "hexaco");
		NativeFieldInfoPtr_pickDen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "pickDen");
		NativeFieldInfoPtr_kidnapperTimeUntilKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "kidnapperTimeUntilKill");
		NativeFieldInfoPtr_minimumTimeBetweenMurders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "minimumTimeBetweenMurders");
		NativeFieldInfoPtr_nonHomeMaximumOccupantsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "nonHomeMaximumOccupantsTrigger");
		NativeFieldInfoPtr_nonHomeMaximumOccupantsCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "nonHomeMaximumOccupantsCancel");
		NativeFieldInfoPtr_requiresAcquirePhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "requiresAcquirePhase");
		NativeFieldInfoPtr_acquirePassInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "acquirePassInteractable");
		NativeFieldInfoPtr_acquirePassRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "acquirePassRoom");
		NativeFieldInfoPtr_acquireActionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "acquireActionSetup");
		NativeFieldInfoPtr_requiresResearchPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "requiresResearchPhase");
		NativeFieldInfoPtr_killerMeetsVicim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "killerMeetsVicim");
		NativeFieldInfoPtr_researchPassInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "researchPassInteractable");
		NativeFieldInfoPtr_researchPassRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "researchPassRoom");
		NativeFieldInfoPtr_researchActionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "researchActionSetup");
		NativeFieldInfoPtr_blockVictimFromLeavingLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "blockVictimFromLeavingLocation");
		NativeFieldInfoPtr_travelSuccessTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "travelSuccessTrigger");
		NativeFieldInfoPtr_travelPassInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "travelPassInteractable");
		NativeFieldInfoPtr_travelPassRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "travelPassRoom");
		NativeFieldInfoPtr_travelActionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "travelActionSetup");
		NativeFieldInfoPtr_executePassInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "executePassInteractable");
		NativeFieldInfoPtr_executePassRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "executePassRoom");
		NativeFieldInfoPtr_executionActionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "executionActionSetup");
		NativeFieldInfoPtr_postPassInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "postPassInteractable");
		NativeFieldInfoPtr_postPassRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "postPassRoom");
		NativeFieldInfoPtr_postActionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "postActionSetup");
		NativeFieldInfoPtr_escapePassInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "escapePassInteractable");
		NativeFieldInfoPtr_escapePassRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "escapePassRoom");
		NativeFieldInfoPtr_escapeActionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "escapeActionSetup");
		NativeFieldInfoPtr_leads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "leads");
		NativeFieldInfoPtr_useCustomResolveQuestions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "useCustomResolveQuestions");
		NativeFieldInfoPtr_customResolveQuestions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "customResolveQuestions");
		NativeFieldInfoPtr_copyFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, "copyFrom");
		NativeMethodInfoPtr_CopyLeads_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, 100673989);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr, 100673990);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329595, XrefRangeEnd = 329601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyLeads()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyLeads_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329601, XrefRangeEnd = 329647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MurderPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurderPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MurderPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
