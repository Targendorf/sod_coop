using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SyncDiskPreset : SoCustomComparison
{
	public enum Rarity
	{
		common,
		medium,
		rare,
		veryRare
	}

	public enum Manufacturer
	{
		ElGen,
		Kaizen,
		KensingtonIndigo,
		StarchKola,
		CandorNews,
		BlackMarket
	}

	public enum Effect
	{
		none,
		streetCleaningMoney,
		readingMoney,
		readingSeriesBonus,
		starchLoan,
		starchAddiction,
		reduceMedicalCosts,
		legalInsurance,
		accidentCover,
		awakenAtHome,
		increaseHealth,
		increaseInventory,
		increaseRegeneration,
		priceModifier,
		dialogChanceModifier,
		doorBargeModifier,
		fallDamageModifier,
		sideJobPayModifier,
		punchPowerModifier,
		throwPowerModifier,
		blockIncoming,
		focusFromDamage,
		noBrokenBones,
		reachModifier,
		holdingBlocksBullets,
		fistsThreatModifier,
		noBleeding,
		incomingDamageModifier,
		passiveIncome,
		installMalware,
		malwareOwnerBonus,
		footSizePerception,
		heightPerception,
		wealthPerception,
		salaryPerception,
		singlePerception,
		agePerception,
		starchAmbassador,
		starchGive,
		lockpickingSpeedModifier,
		lockpickingEfficiencyModifier,
		triggerIllegalOnPick,
		KOTimeModifier,
		securityBreakerModifier,
		securityGraceTimeModifier,
		noSmelly,
		noCold,
		noTired,
		kitchenPhotos,
		bathroomPhotos,
		illegalOpsPhotos,
		playerHeightModifier,
		removeSideEffect,
		moneyForLocations,
		moneyForDucts,
		moneyForAddresses,
		moneyForPasscodes,
		maxSpeedModifier,
		payPhoneCostModifier,
		allowApartmentPurchases,
		apartmentStatusReset,
		allowedAtCrimeScenes,
		spookedMultiplier,
		trespassGraceModifier,
		guestPassIssueModifier,
		fastTravelToApartment,
		fastTravelFromApartment,
		fastTravelUsingSignage,
		allowedInEchelons,
		disableLoitering
	}

	public enum UpgradeEffect
	{
		none,
		modifyEffect,
		bothConfigurations,
		readingSeriesBonus,
		reduceUninstallCost,
		reduceMedicalCosts,
		accidentCover,
		legalInsurance,
		awakenAtHome,
		increaseHealth,
		increaseInventory,
		increaseRegeneration,
		priceModifier,
		dialogChanceModifier,
		doorBargeModifier,
		fallDamageModifier,
		sideJobPayModifier,
		punchPowerModifier,
		throwPowerModifier,
		blockIncoming,
		focusFromDamage,
		noBrokenBones,
		reachModifier,
		holdingBlocksBullets,
		fistsThreatModifier,
		noBleeding,
		incomingDamageModifier,
		passiveIncome,
		installMalware,
		malwareOwnerBonus,
		footSizePerception,
		heightPerception,
		wealthPerception,
		removeSideEffect,
		salaryPerception,
		singlePerception,
		agePerception,
		starchAmbassador,
		starchGive,
		lockpickingSpeedModifier,
		lockpickingEfficiencyModifier,
		triggerIllegalOnPick,
		KOTimeModifier,
		securityBreakerModifier,
		securityGraceTimeModifier,
		noSmelly,
		noCold,
		noTired,
		kitchenPhotos,
		bathroomPhotos,
		illegalOpsPhotos,
		playerHeightModifier,
		moneyForLocations,
		moneyForDucts,
		moneyForAddresses,
		moneyForPasscodes,
		maxSpeedModifier
	}

	public enum SpecialCase
	{
		none,
		cancelSideEffect
	}

	[System.Serializable]
	public class TraitPick : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_appliedFrequency;

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

		public unsafe int appliedFrequency
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedFrequency);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedFrequency)) = num;
			}
		}

		static TraitPick()
		{
			Il2CppClassPointerStore<TraitPick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "TraitPick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraitPick>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_appliedFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "appliedFrequency");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, 100674056);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330409, XrefRangeEnd = 330415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraitPick()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraitPick>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TraitPick(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncDiskNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

	private static readonly System.IntPtr NativeFieldInfoPtr_rarity;

	private static readonly System.IntPtr NativeFieldInfoPtr_manufacturer;

	private static readonly System.IntPtr NativeFieldInfoPtr_canBeSideJobReward;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect1Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect1Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect1;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect1Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect1Icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect2Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect2Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect2;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect2Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect2Icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect3Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect3Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect3;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect3Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainEffect3Icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_option1UpgradeNameReferences;

	private static readonly System.IntPtr NativeFieldInfoPtr_option1UpgradeEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_option1UpgradeValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_option2UpgradeNameReferences;

	private static readonly System.IntPtr NativeFieldInfoPtr_option2UpgradeEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_option2UpgradeValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_option3UpgradeNameReferences;

	private static readonly System.IntPtr NativeFieldInfoPtr_option3UpgradeEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_option3UpgradeValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideEffectDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideEffectValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_uninstallCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumWealthLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_traitWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_traits;

	private static readonly System.IntPtr NativeFieldInfoPtr_occupationWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_occupation;

	private static readonly System.IntPtr NativeFieldInfoPtr_copyFrom;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyOwnershipStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe int syncDiskNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskNumber)) = num;
		}
	}

	public unsafe InteractablePreset interactable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe Rarity rarity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rarity);
			return *(Rarity*)num;
		}
		set
		{
			*(Rarity*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rarity)) = rarity;
		}
	}

	public unsafe Manufacturer manufacturer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manufacturer);
			return *(Manufacturer*)num;
		}
		set
		{
			*(Manufacturer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manufacturer)) = manufacturer;
		}
	}

	public unsafe bool canBeSideJobReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeSideJobReward);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeSideJobReward)) = flag;
		}
	}

	public unsafe string mainEffect1Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string mainEffect1Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Description);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Description)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Effect mainEffect1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1);
			return *(Effect*)num;
		}
		set
		{
			*(Effect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1)) = effect;
		}
	}

	public unsafe float mainEffect1Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Value);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Value)) = num;
		}
	}

	public unsafe Sprite mainEffect1Icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect1Icon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe string mainEffect2Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string mainEffect2Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Description);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Description)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Effect mainEffect2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2);
			return *(Effect*)num;
		}
		set
		{
			*(Effect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2)) = effect;
		}
	}

	public unsafe float mainEffect2Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Value);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Value)) = num;
		}
	}

	public unsafe Sprite mainEffect2Icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect2Icon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe string mainEffect3Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string mainEffect3Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Description);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Description)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Effect mainEffect3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3);
			return *(Effect*)num;
		}
		set
		{
			*(Effect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3)) = effect;
		}
	}

	public unsafe float mainEffect3Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Value);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Value)) = num;
		}
	}

	public unsafe Sprite mainEffect3Icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEffect3Icon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe List<string> option1UpgradeNameReferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option1UpgradeNameReferences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option1UpgradeNameReferences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<UpgradeEffect> option1UpgradeEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option1UpgradeEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UpgradeEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option1UpgradeEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> option1UpgradeValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option1UpgradeValues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option1UpgradeValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> option2UpgradeNameReferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option2UpgradeNameReferences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option2UpgradeNameReferences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<UpgradeEffect> option2UpgradeEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option2UpgradeEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UpgradeEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option2UpgradeEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> option2UpgradeValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option2UpgradeValues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option2UpgradeValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> option3UpgradeNameReferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option3UpgradeNameReferences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option3UpgradeNameReferences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<UpgradeEffect> option3UpgradeEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option3UpgradeEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UpgradeEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option3UpgradeEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<float> option3UpgradeValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option3UpgradeValues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option3UpgradeValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string sideEffectDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideEffectDescription);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideEffectDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Effect sideEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideEffect);
			return *(Effect*)num;
		}
		set
		{
			*(Effect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideEffect)) = effect;
		}
	}

	public unsafe float sideEffectValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideEffectValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideEffectValue)) = num;
		}
	}

	public unsafe int price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
		}
	}

	public unsafe int uninstallCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uninstallCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uninstallCost)) = num;
		}
	}

	public unsafe float minimumWealthLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealthLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealthLevel)) = num;
		}
	}

	public unsafe int traitWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitWeight)) = num;
		}
	}

	public unsafe List<TraitPick> traits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TraitPick>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int occupationWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupationWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupationWeight)) = num;
		}
	}

	public unsafe List<OccupationPreset> occupation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SyncDiskPreset copyFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SyncDiskPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syncDiskPreset));
		}
	}

	static SyncDiskPreset()
	{
		Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SyncDiskPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr);
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_syncDiskNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "syncDiskNumber");
		NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "interactable");
		NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "rarity");
		NativeFieldInfoPtr_manufacturer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "manufacturer");
		NativeFieldInfoPtr_canBeSideJobReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "canBeSideJobReward");
		NativeFieldInfoPtr_mainEffect1Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect1Name");
		NativeFieldInfoPtr_mainEffect1Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect1Description");
		NativeFieldInfoPtr_mainEffect1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect1");
		NativeFieldInfoPtr_mainEffect1Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect1Value");
		NativeFieldInfoPtr_mainEffect1Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect1Icon");
		NativeFieldInfoPtr_mainEffect2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect2Name");
		NativeFieldInfoPtr_mainEffect2Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect2Description");
		NativeFieldInfoPtr_mainEffect2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect2");
		NativeFieldInfoPtr_mainEffect2Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect2Value");
		NativeFieldInfoPtr_mainEffect2Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect2Icon");
		NativeFieldInfoPtr_mainEffect3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect3Name");
		NativeFieldInfoPtr_mainEffect3Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect3Description");
		NativeFieldInfoPtr_mainEffect3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect3");
		NativeFieldInfoPtr_mainEffect3Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect3Value");
		NativeFieldInfoPtr_mainEffect3Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "mainEffect3Icon");
		NativeFieldInfoPtr_option1UpgradeNameReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option1UpgradeNameReferences");
		NativeFieldInfoPtr_option1UpgradeEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option1UpgradeEffects");
		NativeFieldInfoPtr_option1UpgradeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option1UpgradeValues");
		NativeFieldInfoPtr_option2UpgradeNameReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option2UpgradeNameReferences");
		NativeFieldInfoPtr_option2UpgradeEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option2UpgradeEffects");
		NativeFieldInfoPtr_option2UpgradeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option2UpgradeValues");
		NativeFieldInfoPtr_option3UpgradeNameReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option3UpgradeNameReferences");
		NativeFieldInfoPtr_option3UpgradeEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option3UpgradeEffects");
		NativeFieldInfoPtr_option3UpgradeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "option3UpgradeValues");
		NativeFieldInfoPtr_sideEffectDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "sideEffectDescription");
		NativeFieldInfoPtr_sideEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "sideEffect");
		NativeFieldInfoPtr_sideEffectValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "sideEffectValue");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "price");
		NativeFieldInfoPtr_uninstallCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "uninstallCost");
		NativeFieldInfoPtr_minimumWealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "minimumWealthLevel");
		NativeFieldInfoPtr_traitWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "traitWeight");
		NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "traits");
		NativeFieldInfoPtr_occupationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "occupationWeight");
		NativeFieldInfoPtr_occupation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "occupation");
		NativeFieldInfoPtr_copyFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, "copyFrom");
		NativeMethodInfoPtr_CopyOwnershipStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, 100674054);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr, 100674055);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330415, XrefRangeEnd = 330423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyOwnershipStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyOwnershipStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330423, XrefRangeEnd = 330476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SyncDiskPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncDiskPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SyncDiskPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
