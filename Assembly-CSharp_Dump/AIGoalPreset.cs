using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class AIGoalPreset : SoCustomComparison
{
	public enum GoalCategory
	{
		trivial,
		important,
		vital
	}

	public enum StartingGoal
	{
		all,
		nonHomelessOnly,
		homelessOnly
	}

	public enum RainFactor
	{
		none,
		onlyDoWhenRaining,
		dontDoWhenRaining
	}

	[System.Serializable]
	public class GoalModifierRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorityMultiplier;

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

		public unsafe float priorityMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorityMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorityMultiplier)) = num;
			}
		}

		static GoalModifierRule()
		{
			Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "GoalModifierRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_priorityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr, "priorityMultiplier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr, 100673782);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326613, XrefRangeEnd = 326619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoalModifierRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoalModifierRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GoalModifierRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum LocationOption
	{
		useCurrent,
		home,
		work,
		commercial,
		nearestAvailable,
		investigate,
		commercialDecision,
		patrolLocation,
		passedInteractable,
		passedGamelocation,
		murderLocation
	}

	public enum RoomOption
	{
		none,
		bedroom,
		job
	}

	public enum FurnitureOption
	{
		none,
		bed,
		job
	}

	[System.Serializable]
	public class GoalActionSetup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actions;

		private static readonly System.IntPtr NativeFieldInfoPtr_condition;

		private static readonly System.IntPtr NativeFieldInfoPtr_chance;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitModifiers;

		private static readonly System.IntPtr NativeFieldInfoPtr_statusModifiers;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<AIActionPreset> actions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe ActionCondition condition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
				return *(ActionCondition*)num;
			}
			set
			{
				*(ActionCondition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition)) = actionCondition;
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

		public unsafe List<GoalModifierRule> traitModifiers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GoalModifierRule>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<StatusModifierRule> statusModifiers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusModifiers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StatusModifierRule>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static GoalActionSetup()
		{
			Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "GoalActionSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr);
			NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr, "actions");
			NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr, "condition");
			NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr, "chance");
			NativeFieldInfoPtr_traitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr, "traitModifiers");
			NativeFieldInfoPtr_statusModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr, "statusModifiers");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr, 100673783);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326619, XrefRangeEnd = 326637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoalActionSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoalActionSetup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GoalActionSetup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class StatusModifierRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_status;

		private static readonly System.IntPtr NativeFieldInfoPtr_condition;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe StatusType status
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status);
				return *(StatusType*)num;
			}
			set
			{
				*(StatusType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status)) = statusType;
			}
		}

		public unsafe StatusCondition condition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
				return *(StatusCondition*)num;
			}
			set
			{
				*(StatusCondition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition)) = statusCondition;
			}
		}

		public unsafe float value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
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

		static StatusModifierRule()
		{
			Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "StatusModifierRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr);
			NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr, "status");
			NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr, "condition");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr, "value");
			NativeFieldInfoPtr_chanceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr, "chanceModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr, 100673784);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusModifierRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusModifierRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StatusModifierRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum StatusType
	{
		health,
		nerve,
		nourishment,
		hydration,
		alertness,
		energy,
		excitement,
		chores,
		hygeine,
		bladder,
		heat,
		breath,
		onDutyEnforcer
	}

	public enum StatusCondition
	{
		isEqualOrAbove,
		isEqualOrBelow,
		isTrue,
		isFalse
	}

	public enum ActionCondition
	{
		always,
		atHomeOnly,
		inPublicOnly,
		atWorkOnly,
		onlyIfEscalated,
		onlyIfDead,
		atHomeNoGuestPass,
		noGuestPass,
		kidnapOnly,
		nonKidnapOnly,
		killerTauntChance
	}

	public enum GoalActionSource
	{
		thisConfiguration,
		jobPreset,
		murderPreset
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_startingGoal;

	private static readonly System.IntPtr NativeFieldInfoPtr_appliesTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_appliedToTheseJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfFeaturesItemsAtHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_category;

	private static readonly System.IntPtr NativeFieldInfoPtr_basePriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomVariance;

	private static readonly System.IntPtr NativeFieldInfoPtr_minMaxPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplyUsingTrashCarried;

	private static readonly System.IntPtr NativeFieldInfoPtr_useLateDebtPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyImportantBetweenHours;

	private static readonly System.IntPtr NativeFieldInfoPtr_validBetweenHours;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcePriorityUpdateOnCreation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMusic;

	private static readonly System.IntPtr NativeFieldInfoPtr_useTrespassing;

	private static readonly System.IntPtr NativeFieldInfoPtr_affectPriorityOverTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplierModifierOverOneHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_sniperVictimBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_goalModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_ifGoalsPresent;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherGoalPriorityModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_useTiming;

	private static readonly System.IntPtr NativeFieldInfoPtr_timingImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_earlyTimingWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelIfLate;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelIfThisLate;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelAfterTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelAfter;

	private static readonly System.IntPtr NativeFieldInfoPtr_runIfLate;

	private static readonly System.IntPtr NativeFieldInfoPtr_nourishmentImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_hydrationImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertnessImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_energyImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_excitementImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_choresImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_hygieneImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_bladderImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_heatImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_breathImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisonImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_blindedImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_completable;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopingActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_interuptable;

	private static readonly System.IntPtr NativeFieldInfoPtr_unteruptableByFollowingCategories;

	private static readonly System.IntPtr NativeFieldInfoPtr_uninteruptableByCategories;

	private static readonly System.IntPtr NativeFieldInfoPtr_useInteruptionThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_interuptionThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDelayOnBusy;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDelayOnInterupt;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDelayOnFinishActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowEnforcersEverywhere;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_useToiletSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_desireCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionFoundRoomBecomesPassedRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_passedGamelocationIsImportant;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionsSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_raiseAlarm;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowTrespass;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableActionInsertions;

	private static readonly System.IntPtr NativeFieldInfoPtr_trashConsumablesOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableThrowing;

	private static readonly System.IntPtr NativeFieldInfoPtr_diabledMugging;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowPottering;

	private static readonly System.IntPtr NativeFieldInfoPtr_potterSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_potterFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_potterActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideLightingBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyOverrideIfAtGamelocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightingBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfOnTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_onTriggerBark;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool startingGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingGoal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingGoal)) = flag;
		}
	}

	public unsafe StartingGoal appliesTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliesTo);
			return *(StartingGoal*)num;
		}
		set
		{
			*(StartingGoal*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliesTo)) = startingGoal;
		}
	}

	public unsafe List<OccupationPreset> appliedToTheseJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedToTheseJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedToTheseJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> onlyIfFeaturesItemsAtHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfFeaturesItemsAtHome);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfFeaturesItemsAtHome)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool disableSave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSave);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSave)) = flag;
		}
	}

	public unsafe GoalCategory category
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
			return *(GoalCategory*)num;
		}
		set
		{
			*(GoalCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)) = goalCategory;
		}
	}

	public unsafe int basePriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority)) = num;
		}
	}

	public unsafe int randomVariance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomVariance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomVariance)) = num;
		}
	}

	public unsafe Vector2 minMaxPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxPriority);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxPriority)) = vector;
		}
	}

	public unsafe bool multiplyUsingTrashCarried
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplyUsingTrashCarried);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplyUsingTrashCarried)) = flag;
		}
	}

	public unsafe bool useLateDebtPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLateDebtPriority);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLateDebtPriority)) = flag;
		}
	}

	public unsafe bool onlyImportantBetweenHours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyImportantBetweenHours);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyImportantBetweenHours)) = flag;
		}
	}

	public unsafe Vector2 validBetweenHours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validBetweenHours);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validBetweenHours)) = vector;
		}
	}

	public unsafe bool dontUpdateGoalPriorityWhileActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive)) = flag;
		}
	}

	public unsafe bool forcePriorityUpdateOnCreation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePriorityUpdateOnCreation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePriorityUpdateOnCreation)) = flag;
		}
	}

	public unsafe RainFactor rainFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainFactor);
			return *(RainFactor*)num;
		}
		set
		{
			*(RainFactor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainFactor)) = rainFactor;
		}
	}

	public unsafe bool useMusic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMusic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMusic)) = flag;
		}
	}

	public unsafe bool useTrespassing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTrespassing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTrespassing)) = flag;
		}
	}

	public unsafe bool affectPriorityOverTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectPriorityOverTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectPriorityOverTime)) = flag;
		}
	}

	public unsafe float multiplierModifierOverOneHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplierModifierOverOneHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplierModifierOverOneHour)) = num;
		}
	}

	public unsafe bool sniperVictimBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sniperVictimBoost);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sniperVictimBoost)) = flag;
		}
	}

	public unsafe List<GoalModifierRule> goalModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goalModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GoalModifierRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goalModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AIGoalPreset> ifGoalsPresent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifGoalsPresent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifGoalsPresent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float otherGoalPriorityModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherGoalPriorityModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherGoalPriorityModifier)) = num;
		}
	}

	public unsafe bool useTiming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTiming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTiming)) = flag;
		}
	}

	public unsafe int timingImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timingImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timingImportance)) = num;
		}
	}

	public unsafe float earlyTimingWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_earlyTimingWindow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_earlyTimingWindow)) = num;
		}
	}

	public unsafe bool cancelIfLate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfLate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfLate)) = flag;
		}
	}

	public unsafe float cancelIfThisLate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfThisLate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfThisLate)) = num;
		}
	}

	public unsafe bool cancelAfterTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelAfterTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelAfterTime)) = flag;
		}
	}

	public unsafe float cancelAfter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelAfter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelAfter)) = num;
		}
	}

	public unsafe bool runIfLate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runIfLate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runIfLate)) = flag;
		}
	}

	public unsafe int nourishmentImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishmentImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishmentImportance)) = num;
		}
	}

	public unsafe int hydrationImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydrationImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydrationImportance)) = num;
		}
	}

	public unsafe int alertnessImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertnessImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertnessImportance)) = num;
		}
	}

	public unsafe int energyImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyImportance)) = num;
		}
	}

	public unsafe int excitementImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitementImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitementImportance)) = num;
		}
	}

	public unsafe int choresImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choresImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choresImportance)) = num;
		}
	}

	public unsafe int hygieneImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygieneImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygieneImportance)) = num;
		}
	}

	public unsafe int bladderImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladderImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladderImportance)) = num;
		}
	}

	public unsafe int heatImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heatImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heatImportance)) = num;
		}
	}

	public unsafe int drunkImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkImportance)) = num;
		}
	}

	public unsafe int breathImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathImportance)) = num;
		}
	}

	public unsafe int poisonImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonImportance)) = num;
		}
	}

	public unsafe int blindedImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindedImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindedImportance)) = num;
		}
	}

	public unsafe bool completable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completable)) = flag;
		}
	}

	public unsafe bool loopingActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingActions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingActions)) = flag;
		}
	}

	public unsafe bool interuptable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interuptable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interuptable)) = flag;
		}
	}

	public unsafe bool unteruptableByFollowingCategories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unteruptableByFollowingCategories);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unteruptableByFollowingCategories)) = flag;
		}
	}

	public unsafe List<GoalCategory> uninteruptableByCategories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uninteruptableByCategories);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GoalCategory>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uninteruptableByCategories)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useInteruptionThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInteruptionThreshold);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInteruptionThreshold)) = flag;
		}
	}

	public unsafe float interuptionThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interuptionThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interuptionThreshold)) = num;
		}
	}

	public unsafe float repeatDelayOnBusy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnBusy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnBusy)) = num;
		}
	}

	public unsafe float repeatDelayOnInterupt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnInterupt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnInterupt)) = num;
		}
	}

	public unsafe float repeatDelayOnFinishActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnFinishActions);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnFinishActions)) = num;
		}
	}

	public unsafe bool allowEnforcersEverywhere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowEnforcersEverywhere);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowEnforcersEverywhere)) = flag;
		}
	}

	public unsafe LocationOption locationOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationOption);
			return *(LocationOption*)num;
		}
		set
		{
			*(LocationOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationOption)) = locationOption;
		}
	}

	public unsafe bool useToiletSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useToiletSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useToiletSettings)) = flag;
		}
	}

	public unsafe CompanyPreset.CompanyCategory desireCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireCategory);
			return *(CompanyPreset.CompanyCategory*)num;
		}
		set
		{
			*(CompanyPreset.CompanyCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireCategory)) = companyCategory;
		}
	}

	public unsafe RoomOption roomOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomOption);
			return *(RoomOption*)num;
		}
		set
		{
			*(RoomOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomOption)) = roomOption;
		}
	}

	public unsafe FurnitureOption furnitureOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureOption);
			return *(FurnitureOption*)num;
		}
		set
		{
			*(FurnitureOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureOption)) = furnitureOption;
		}
	}

	public unsafe bool actionFoundRoomBecomesPassedRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionFoundRoomBecomesPassedRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionFoundRoomBecomesPassedRoom)) = flag;
		}
	}

	public unsafe bool passedGamelocationIsImportant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedGamelocationIsImportant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedGamelocationIsImportant)) = flag;
		}
	}

	public unsafe GoalActionSource actionSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSource);
			return *(GoalActionSource*)num;
		}
		set
		{
			*(GoalActionSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSource)) = goalActionSource;
		}
	}

	public unsafe List<GoalActionSetup> actionsSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionsSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionsSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool raiseAlarm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raiseAlarm);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raiseAlarm)) = flag;
		}
	}

	public unsafe bool allowTrespass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowTrespass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowTrespass)) = flag;
		}
	}

	public unsafe bool disableActionInsertions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableActionInsertions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableActionInsertions)) = flag;
		}
	}

	public unsafe bool trashConsumablesOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trashConsumablesOnActivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trashConsumablesOnActivate)) = flag;
		}
	}

	public unsafe bool disableThrowing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableThrowing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableThrowing)) = flag;
		}
	}

	public unsafe bool diabledMugging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diabledMugging);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diabledMugging)) = flag;
		}
	}

	public unsafe bool allowPottering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPottering);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPottering)) = flag;
		}
	}

	public unsafe GoalActionSource potterSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterSource);
			return *(GoalActionSource*)num;
		}
		set
		{
			*(GoalActionSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterSource)) = goalActionSource;
		}
	}

	public unsafe Vector2 potterFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterFrequency);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterFrequency)) = vector;
		}
	}

	public unsafe List<AIActionPreset> potterActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool overrideLightingBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideLightingBehaviour);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideLightingBehaviour)) = flag;
		}
	}

	public unsafe bool onlyOverrideIfAtGamelocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyOverrideIfAtGamelocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyOverrideIfAtGamelocation)) = flag;
		}
	}

	public unsafe List<RoomConfiguration.AILightingBehaviour> lightingBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingBehaviour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration.AILightingBehaviour>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingBehaviour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AIActionPreset.DoorRule doorRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorRule);
			return *(AIActionPreset.DoorRule*)num;
		}
		set
		{
			*(AIActionPreset.DoorRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorRule)) = doorRule;
		}
	}

	public unsafe float chanceOfOnTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnTrigger);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnTrigger)) = num;
		}
	}

	public unsafe List<SpeechController.Bark> onTriggerBark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTriggerBark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpeechController.Bark>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTriggerBark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AIGoalPreset()
	{
		Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AIGoalPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr);
		NativeFieldInfoPtr_startingGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "startingGoal");
		NativeFieldInfoPtr_appliesTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "appliesTo");
		NativeFieldInfoPtr_appliedToTheseJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "appliedToTheseJobs");
		NativeFieldInfoPtr_onlyIfFeaturesItemsAtHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "onlyIfFeaturesItemsAtHome");
		NativeFieldInfoPtr_disableSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "disableSave");
		NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "category");
		NativeFieldInfoPtr_basePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "basePriority");
		NativeFieldInfoPtr_randomVariance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "randomVariance");
		NativeFieldInfoPtr_minMaxPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "minMaxPriority");
		NativeFieldInfoPtr_multiplyUsingTrashCarried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "multiplyUsingTrashCarried");
		NativeFieldInfoPtr_useLateDebtPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "useLateDebtPriority");
		NativeFieldInfoPtr_onlyImportantBetweenHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "onlyImportantBetweenHours");
		NativeFieldInfoPtr_validBetweenHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "validBetweenHours");
		NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "dontUpdateGoalPriorityWhileActive");
		NativeFieldInfoPtr_forcePriorityUpdateOnCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "forcePriorityUpdateOnCreation");
		NativeFieldInfoPtr_rainFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "rainFactor");
		NativeFieldInfoPtr_useMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "useMusic");
		NativeFieldInfoPtr_useTrespassing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "useTrespassing");
		NativeFieldInfoPtr_affectPriorityOverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "affectPriorityOverTime");
		NativeFieldInfoPtr_multiplierModifierOverOneHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "multiplierModifierOverOneHour");
		NativeFieldInfoPtr_sniperVictimBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "sniperVictimBoost");
		NativeFieldInfoPtr_goalModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "goalModifiers");
		NativeFieldInfoPtr_ifGoalsPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "ifGoalsPresent");
		NativeFieldInfoPtr_otherGoalPriorityModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "otherGoalPriorityModifier");
		NativeFieldInfoPtr_useTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "useTiming");
		NativeFieldInfoPtr_timingImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "timingImportance");
		NativeFieldInfoPtr_earlyTimingWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "earlyTimingWindow");
		NativeFieldInfoPtr_cancelIfLate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "cancelIfLate");
		NativeFieldInfoPtr_cancelIfThisLate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "cancelIfThisLate");
		NativeFieldInfoPtr_cancelAfterTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "cancelAfterTime");
		NativeFieldInfoPtr_cancelAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "cancelAfter");
		NativeFieldInfoPtr_runIfLate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "runIfLate");
		NativeFieldInfoPtr_nourishmentImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "nourishmentImportance");
		NativeFieldInfoPtr_hydrationImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "hydrationImportance");
		NativeFieldInfoPtr_alertnessImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "alertnessImportance");
		NativeFieldInfoPtr_energyImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "energyImportance");
		NativeFieldInfoPtr_excitementImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "excitementImportance");
		NativeFieldInfoPtr_choresImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "choresImportance");
		NativeFieldInfoPtr_hygieneImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "hygieneImportance");
		NativeFieldInfoPtr_bladderImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "bladderImportance");
		NativeFieldInfoPtr_heatImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "heatImportance");
		NativeFieldInfoPtr_drunkImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "drunkImportance");
		NativeFieldInfoPtr_breathImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "breathImportance");
		NativeFieldInfoPtr_poisonImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "poisonImportance");
		NativeFieldInfoPtr_blindedImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "blindedImportance");
		NativeFieldInfoPtr_completable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "completable");
		NativeFieldInfoPtr_loopingActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "loopingActions");
		NativeFieldInfoPtr_interuptable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "interuptable");
		NativeFieldInfoPtr_unteruptableByFollowingCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "unteruptableByFollowingCategories");
		NativeFieldInfoPtr_uninteruptableByCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "uninteruptableByCategories");
		NativeFieldInfoPtr_useInteruptionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "useInteruptionThreshold");
		NativeFieldInfoPtr_interuptionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "interuptionThreshold");
		NativeFieldInfoPtr_repeatDelayOnBusy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "repeatDelayOnBusy");
		NativeFieldInfoPtr_repeatDelayOnInterupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "repeatDelayOnInterupt");
		NativeFieldInfoPtr_repeatDelayOnFinishActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "repeatDelayOnFinishActions");
		NativeFieldInfoPtr_allowEnforcersEverywhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "allowEnforcersEverywhere");
		NativeFieldInfoPtr_locationOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "locationOption");
		NativeFieldInfoPtr_useToiletSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "useToiletSettings");
		NativeFieldInfoPtr_desireCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "desireCategory");
		NativeFieldInfoPtr_roomOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "roomOption");
		NativeFieldInfoPtr_furnitureOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "furnitureOption");
		NativeFieldInfoPtr_actionFoundRoomBecomesPassedRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "actionFoundRoomBecomesPassedRoom");
		NativeFieldInfoPtr_passedGamelocationIsImportant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "passedGamelocationIsImportant");
		NativeFieldInfoPtr_actionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "actionSource");
		NativeFieldInfoPtr_actionsSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "actionsSetup");
		NativeFieldInfoPtr_raiseAlarm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "raiseAlarm");
		NativeFieldInfoPtr_allowTrespass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "allowTrespass");
		NativeFieldInfoPtr_disableActionInsertions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "disableActionInsertions");
		NativeFieldInfoPtr_trashConsumablesOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "trashConsumablesOnActivate");
		NativeFieldInfoPtr_disableThrowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "disableThrowing");
		NativeFieldInfoPtr_diabledMugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "diabledMugging");
		NativeFieldInfoPtr_allowPottering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "allowPottering");
		NativeFieldInfoPtr_potterSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "potterSource");
		NativeFieldInfoPtr_potterFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "potterFrequency");
		NativeFieldInfoPtr_potterActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "potterActions");
		NativeFieldInfoPtr_overrideLightingBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "overrideLightingBehaviour");
		NativeFieldInfoPtr_onlyOverrideIfAtGamelocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "onlyOverrideIfAtGamelocation");
		NativeFieldInfoPtr_lightingBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "lightingBehaviour");
		NativeFieldInfoPtr_doorRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "doorRule");
		NativeFieldInfoPtr_chanceOfOnTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "chanceOfOnTrigger");
		NativeFieldInfoPtr_onTriggerBark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, "onTriggerBark");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr, 100673781);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326637, XrefRangeEnd = 326687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIGoalPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIGoalPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AIGoalPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
