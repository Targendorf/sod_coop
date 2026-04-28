using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CharacterTrait : SoCustomComparison
{
	public enum PosNeg
	{
		postive,
		neutral,
		negative
	}

	public enum RuleType
	{
		ifAnyOfThese,
		ifAllOfThese,
		ifNoneOfThese,
		ifPartnerAnyOfThese
	}

	[System.Serializable]
	public class TraitPickRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseChance;

		private static readonly System.IntPtr NativeFieldInfoPtr_reasonChance;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe RuleType rule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule);
				return *(RuleType*)num;
			}
			set
			{
				*(RuleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule)) = ruleType;
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

		public unsafe int reasonChance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reasonChance);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reasonChance)) = num;
			}
		}

		static TraitPickRule()
		{
			Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "TraitPickRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "baseChance");
			NativeFieldInfoPtr_reasonChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, "reasonChance");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr, 100673843);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327851, RefRangeEnd = 327853, XrefRangeStart = 327845, XrefRangeEnd = 327851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraitPickRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraitPickRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TraitPickRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class SpecialItemPlacementRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_chance;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractablePreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
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

		static SpecialItemPlacementRule()
		{
			Il2CppClassPointerStore<SpecialItemPlacementRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "SpecialItemPlacementRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialItemPlacementRule>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialItemPlacementRule>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialItemPlacementRule>.NativeClassPtr, "chance");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialItemPlacementRule>.NativeClassPtr, 100673844);
		}

		[CallerCount(0)]
		public unsafe SpecialItemPlacementRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialItemPlacementRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SpecialItemPlacementRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_isTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_needsReson;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresPartner;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresSingle;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresEmployment;

	private static readonly System.IntPtr NativeFieldInfoPtr_needsDate;

	private static readonly System.IntPtr NativeFieldInfoPtr_featureInInterestPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_featureInAfflictionPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_ageDateRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCouplesAnniversary;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_postiveNegative;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickStage;

	private static readonly System.IntPtr NativeFieldInfoPtr_primeBaseChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_useHumilityMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchHumility;

	private static readonly System.IntPtr NativeFieldInfoPtr_useEmotionalityMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchEmotionality;

	private static readonly System.IntPtr NativeFieldInfoPtr_useExtraversionMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchExtraversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_useAgreeablenessMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchAgreeableness;

	private static readonly System.IntPtr NativeFieldInfoPtr_useConscientiousnessMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchConscientiousness;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCreativityMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchCreativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSocietalClassMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchSocietalClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectHumility;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectEmotionality;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectExtraversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectAgreeableness;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectConscientiousness;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectCreativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHealthModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_recoveryRateModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_combatSkillModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_combatHeftModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxNerveModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_breathRecoveryModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitHumility;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitEmotionality;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitExtraversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitAgreeableness;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitConscientiousness;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitCreativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangUsageModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingMale;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingFemale;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingLover;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangCurse;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangCurseNoun;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangPraiseNoun;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferredBookCountModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_sightingLimitMemoryModifier;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTrait);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTrait)) = flag;
		}
	}

	public unsafe bool needsReson
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsReson);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsReson)) = flag;
		}
	}

	public unsafe bool requiresPartner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresPartner);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresPartner)) = flag;
		}
	}

	public unsafe bool requiresSingle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresSingle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresSingle)) = flag;
		}
	}

	public unsafe bool requiresHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresHome)) = flag;
		}
	}

	public unsafe bool requiresEmployment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresEmployment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresEmployment)) = flag;
		}
	}

	public unsafe bool needsDate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsDate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsDate)) = flag;
		}
	}

	public unsafe bool featureInInterestPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureInInterestPool);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureInInterestPool)) = flag;
		}
	}

	public unsafe bool featureInAfflictionPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureInAfflictionPool);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureInAfflictionPool)) = flag;
		}
	}

	public unsafe Vector2 ageDateRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ageDateRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ageDateRange)) = vector;
		}
	}

	public unsafe bool useCouplesAnniversary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCouplesAnniversary);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCouplesAnniversary)) = flag;
		}
	}

	public unsafe bool isPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPassword);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPassword)) = flag;
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

	public unsafe PosNeg postiveNegative
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postiveNegative);
			return *(PosNeg*)num;
		}
		set
		{
			*(PosNeg*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postiveNegative)) = posNeg;
		}
	}

	public unsafe int pickStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickStage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickStage)) = num;
		}
	}

	public unsafe float primeBaseChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primeBaseChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_primeBaseChance)) = num;
		}
	}

	public unsafe List<TraitPickRule> pickRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TraitPickRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float matchChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchChance)) = num;
		}
	}

	public unsafe bool useHumilityMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHumilityMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHumilityMatch)) = flag;
		}
	}

	public unsafe float matchHumility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchHumility);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchHumility)) = num;
		}
	}

	public unsafe bool useEmotionalityMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useEmotionalityMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useEmotionalityMatch)) = flag;
		}
	}

	public unsafe float matchEmotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchEmotionality);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchEmotionality)) = num;
		}
	}

	public unsafe bool useExtraversionMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useExtraversionMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useExtraversionMatch)) = flag;
		}
	}

	public unsafe float matchExtraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchExtraversion);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchExtraversion)) = num;
		}
	}

	public unsafe bool useAgreeablenessMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAgreeablenessMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAgreeablenessMatch)) = flag;
		}
	}

	public unsafe float matchAgreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchAgreeableness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchAgreeableness)) = num;
		}
	}

	public unsafe bool useConscientiousnessMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useConscientiousnessMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useConscientiousnessMatch)) = flag;
		}
	}

	public unsafe float matchConscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchConscientiousness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchConscientiousness)) = num;
		}
	}

	public unsafe bool useCreativityMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCreativityMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCreativityMatch)) = flag;
		}
	}

	public unsafe float matchCreativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchCreativity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchCreativity)) = num;
		}
	}

	public unsafe bool useSocietalClassMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSocietalClassMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSocietalClassMatch)) = flag;
		}
	}

	public unsafe float matchSocietalClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchSocietalClass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchSocietalClass)) = num;
		}
	}

	public unsafe float effectHumility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectHumility);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectHumility)) = num;
		}
	}

	public unsafe float effectEmotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectEmotionality);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectEmotionality)) = num;
		}
	}

	public unsafe float effectExtraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectExtraversion);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectExtraversion)) = num;
		}
	}

	public unsafe float effectAgreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectAgreeableness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectAgreeableness)) = num;
		}
	}

	public unsafe float effectConscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectConscientiousness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectConscientiousness)) = num;
		}
	}

	public unsafe float effectCreativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectCreativity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectCreativity)) = num;
		}
	}

	public unsafe float maxHealthModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealthModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealthModifier)) = num;
		}
	}

	public unsafe float recoveryRateModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRateModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRateModifier)) = num;
		}
	}

	public unsafe float combatSkillModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatSkillModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatSkillModifier)) = num;
		}
	}

	public unsafe float combatHeftModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHeftModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHeftModifier)) = num;
		}
	}

	public unsafe float maxNerveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNerveModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNerveModifier)) = num;
		}
	}

	public unsafe float breathRecoveryModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRecoveryModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRecoveryModifier)) = num;
		}
	}

	public unsafe Vector2 limitHumility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitHumility);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitHumility)) = vector;
		}
	}

	public unsafe Vector2 limitEmotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitEmotionality);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitEmotionality)) = vector;
		}
	}

	public unsafe Vector2 limitExtraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitExtraversion);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitExtraversion)) = vector;
		}
	}

	public unsafe Vector2 limitAgreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitAgreeableness);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitAgreeableness)) = vector;
		}
	}

	public unsafe Vector2 limitConscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitConscientiousness);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitConscientiousness)) = vector;
		}
	}

	public unsafe Vector2 limitCreativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCreativity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCreativity)) = vector;
		}
	}

	public unsafe float slangUsageModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangUsageModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangUsageModifier)) = num;
		}
	}

	public unsafe List<string> slangGreetingDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingDefault);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingDefault)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangGreetingMale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingMale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingMale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangGreetingFemale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingFemale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingFemale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangGreetingLover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingLover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingLover)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangCurse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangCurseNoun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurseNoun);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurseNoun)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangPraiseNoun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangPraiseNoun);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangPraiseNoun)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int preferredBookCountModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredBookCountModifier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredBookCountModifier)) = num;
		}
	}

	public unsafe int sightingLimitMemoryModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingLimitMemoryModifier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingLimitMemoryModifier)) = num;
		}
	}

	static CharacterTrait()
	{
		Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CharacterTrait");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr);
		NativeFieldInfoPtr_isTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "isTrait");
		NativeFieldInfoPtr_needsReson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "needsReson");
		NativeFieldInfoPtr_requiresPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "requiresPartner");
		NativeFieldInfoPtr_requiresSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "requiresSingle");
		NativeFieldInfoPtr_requiresHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "requiresHome");
		NativeFieldInfoPtr_requiresEmployment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "requiresEmployment");
		NativeFieldInfoPtr_needsDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "needsDate");
		NativeFieldInfoPtr_featureInInterestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "featureInInterestPool");
		NativeFieldInfoPtr_featureInAfflictionPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "featureInAfflictionPool");
		NativeFieldInfoPtr_ageDateRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "ageDateRange");
		NativeFieldInfoPtr_useCouplesAnniversary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useCouplesAnniversary");
		NativeFieldInfoPtr_isPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "isPassword");
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_postiveNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "postiveNegative");
		NativeFieldInfoPtr_pickStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "pickStage");
		NativeFieldInfoPtr_primeBaseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "primeBaseChance");
		NativeFieldInfoPtr_pickRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "pickRules");
		NativeFieldInfoPtr_matchChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchChance");
		NativeFieldInfoPtr_useHumilityMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useHumilityMatch");
		NativeFieldInfoPtr_matchHumility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchHumility");
		NativeFieldInfoPtr_useEmotionalityMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useEmotionalityMatch");
		NativeFieldInfoPtr_matchEmotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchEmotionality");
		NativeFieldInfoPtr_useExtraversionMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useExtraversionMatch");
		NativeFieldInfoPtr_matchExtraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchExtraversion");
		NativeFieldInfoPtr_useAgreeablenessMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useAgreeablenessMatch");
		NativeFieldInfoPtr_matchAgreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchAgreeableness");
		NativeFieldInfoPtr_useConscientiousnessMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useConscientiousnessMatch");
		NativeFieldInfoPtr_matchConscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchConscientiousness");
		NativeFieldInfoPtr_useCreativityMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useCreativityMatch");
		NativeFieldInfoPtr_matchCreativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchCreativity");
		NativeFieldInfoPtr_useSocietalClassMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "useSocietalClassMatch");
		NativeFieldInfoPtr_matchSocietalClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "matchSocietalClass");
		NativeFieldInfoPtr_effectHumility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "effectHumility");
		NativeFieldInfoPtr_effectEmotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "effectEmotionality");
		NativeFieldInfoPtr_effectExtraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "effectExtraversion");
		NativeFieldInfoPtr_effectAgreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "effectAgreeableness");
		NativeFieldInfoPtr_effectConscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "effectConscientiousness");
		NativeFieldInfoPtr_effectCreativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "effectCreativity");
		NativeFieldInfoPtr_maxHealthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "maxHealthModifier");
		NativeFieldInfoPtr_recoveryRateModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "recoveryRateModifier");
		NativeFieldInfoPtr_combatSkillModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "combatSkillModifier");
		NativeFieldInfoPtr_combatHeftModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "combatHeftModifier");
		NativeFieldInfoPtr_maxNerveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "maxNerveModifier");
		NativeFieldInfoPtr_breathRecoveryModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "breathRecoveryModifier");
		NativeFieldInfoPtr_limitHumility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "limitHumility");
		NativeFieldInfoPtr_limitEmotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "limitEmotionality");
		NativeFieldInfoPtr_limitExtraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "limitExtraversion");
		NativeFieldInfoPtr_limitAgreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "limitAgreeableness");
		NativeFieldInfoPtr_limitConscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "limitConscientiousness");
		NativeFieldInfoPtr_limitCreativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "limitCreativity");
		NativeFieldInfoPtr_slangUsageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangUsageModifier");
		NativeFieldInfoPtr_slangGreetingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangGreetingDefault");
		NativeFieldInfoPtr_slangGreetingMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangGreetingMale");
		NativeFieldInfoPtr_slangGreetingFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangGreetingFemale");
		NativeFieldInfoPtr_slangGreetingLover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangGreetingLover");
		NativeFieldInfoPtr_slangCurse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangCurse");
		NativeFieldInfoPtr_slangCurseNoun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangCurseNoun");
		NativeFieldInfoPtr_slangPraiseNoun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "slangPraiseNoun");
		NativeFieldInfoPtr_preferredBookCountModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "preferredBookCountModifier");
		NativeFieldInfoPtr_sightingLimitMemoryModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, "sightingLimitMemoryModifier");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr, 100673842);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327853, XrefRangeEnd = 327861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterTrait()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterTrait>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CharacterTrait(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
