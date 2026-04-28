using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class OccupationPreset : SoCustomComparison
{
	public enum workType
	{
		Office,
		Management,
		Labourer,
		Janitorial,
		Retail,
		Service,
		Driver,
		PublicSector,
		Enforcer,
		Criminal,
		Creative,
		Other,
		Student,
		Unemployed,
		Retired,
		Illegal
	}

	public enum ShiftType
	{
		morningShift,
		dayShift,
		eveningShift,
		nightShift
	}

	public enum JobAI
	{
		workPosition,
		random,
		randomBuilding,
		passedCompanyPosition
	}

	public enum workTags
	{
		none,
		dull,
		exciting,
		dangerous,
		menial,
		intern,
		stressful,
		cushy,
		technical,
		ceo,
		social,
		isolated,
		professional
	}

	public enum Overtime
	{
		none,
		low,
		medium,
		high,
		veryHigh
	}

	private static readonly IntPtr NativeFieldInfoPtr_work;

	private static readonly IntPtr NativeFieldInfoPtr_tags;

	private static readonly IntPtr NativeFieldInfoPtr_jobFillPriority;

	private static readonly IntPtr NativeFieldInfoPtr_workOutfit;

	private static readonly IntPtr NativeFieldInfoPtr_selfEmployed;

	private static readonly IntPtr NativeFieldInfoPtr_receptionist;

	private static readonly IntPtr NativeFieldInfoPtr_canAskAboutJob;

	private static readonly IntPtr NativeFieldInfoPtr_janitor;

	private static readonly IntPtr NativeFieldInfoPtr_security;

	private static readonly IntPtr NativeFieldInfoPtr_isCriminal;

	private static readonly IntPtr NativeFieldInfoPtr_isPublicFacing;

	private static readonly IntPtr NativeFieldInfoPtr_minimumPerCity;

	private static readonly IntPtr NativeFieldInfoPtr_societalClass;

	private static readonly IntPtr NativeFieldInfoPtr_skewPersonalityTowardsJobFit;

	private static readonly IntPtr NativeFieldInfoPtr_skewHumility;

	private static readonly IntPtr NativeFieldInfoPtr_humility;

	private static readonly IntPtr NativeFieldInfoPtr_skewEmotionality;

	private static readonly IntPtr NativeFieldInfoPtr_emotionality;

	private static readonly IntPtr NativeFieldInfoPtr_skewExtraversion;

	private static readonly IntPtr NativeFieldInfoPtr_extraversion;

	private static readonly IntPtr NativeFieldInfoPtr_skewAgreeableness;

	private static readonly IntPtr NativeFieldInfoPtr_agreeableness;

	private static readonly IntPtr NativeFieldInfoPtr_skewConscientiousness;

	private static readonly IntPtr NativeFieldInfoPtr_conscientiousness;

	private static readonly IntPtr NativeFieldInfoPtr_skewCreativity;

	private static readonly IntPtr NativeFieldInfoPtr_creativity;

	private static readonly IntPtr NativeFieldInfoPtr_shiftTimeIsImportant;

	private static readonly IntPtr NativeFieldInfoPtr_shiftType;

	private static readonly IntPtr NativeFieldInfoPtr_countsTowardsOpenHoursCoverage;

	private static readonly IntPtr NativeFieldInfoPtr_lunchBreakAllowed;

	private static readonly IntPtr NativeFieldInfoPtr_jobAIPosition;

	private static readonly IntPtr NativeFieldInfoPtr_bannedRooms;

	private static readonly IntPtr NativeFieldInfoPtr_actionSetup;

	private static readonly IntPtr NativeFieldInfoPtr_jobPostion;

	private static readonly IntPtr NativeFieldInfoPtr_ownsWorkPosition;

	private static readonly IntPtr NativeFieldInfoPtr_preferredRooms;

	private static readonly IntPtr NativeFieldInfoPtr_potterFrequency;

	private static readonly IntPtr NativeFieldInfoPtr_onlyPotterIfSomebodyElseWorking;

	private static readonly IntPtr NativeFieldInfoPtr_potterActions;

	private static readonly IntPtr NativeFieldInfoPtr_canPickUpLitter;

	private static readonly IntPtr NativeFieldInfoPtr_namePlacard;

	private static readonly IntPtr NativeFieldInfoPtr_employeePhoto;

	private static readonly IntPtr NativeFieldInfoPtr_businessCards;

	private static readonly IntPtr NativeFieldInfoPtr_workRota;

	private static readonly IntPtr NativeFieldInfoPtr_employmentContract;

	private static readonly IntPtr NativeFieldInfoPtr_jobItems;

	private static readonly IntPtr NativeFieldInfoPtr_inventoryItems;

	private static readonly IntPtr NativeFieldInfoPtr_joinGroups;

	private static readonly IntPtr NativeFieldInfoPtr_addDialog;

	private static readonly IntPtr NativeFieldInfoPtr_selectedPreset;

	private static readonly IntPtr NativeMethodInfoPtr_CopyOutfitFromSelectedPreset_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe workType work
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_work);
			return *(workType*)num;
		}
		set
		{
			*(workType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_work)) = workType2;
		}
	}

	public unsafe List<workTags> tags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<workTags>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int jobFillPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobFillPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobFillPriority)) = num;
		}
	}

	public unsafe List<ClothesPreset> workOutfit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workOutfit);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workOutfit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool selfEmployed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfEmployed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selfEmployed)) = flag;
		}
	}

	public unsafe bool receptionist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receptionist);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receptionist)) = flag;
		}
	}

	public unsafe bool canAskAboutJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canAskAboutJob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canAskAboutJob)) = flag;
		}
	}

	public unsafe bool janitor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_janitor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_janitor)) = flag;
		}
	}

	public unsafe bool security
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security)) = flag;
		}
	}

	public unsafe bool isCriminal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCriminal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCriminal)) = flag;
		}
	}

	public unsafe bool isPublicFacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPublicFacing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPublicFacing)) = flag;
		}
	}

	public unsafe int minimumPerCity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumPerCity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumPerCity)) = num;
		}
	}

	public unsafe float societalClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClass)) = num;
		}
	}

	public unsafe float skewPersonalityTowardsJobFit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewPersonalityTowardsJobFit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewPersonalityTowardsJobFit)) = num;
		}
	}

	public unsafe bool skewHumility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewHumility);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewHumility)) = flag;
		}
	}

	public unsafe float humility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility)) = num;
		}
	}

	public unsafe bool skewEmotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewEmotionality);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewEmotionality)) = flag;
		}
	}

	public unsafe float emotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality)) = num;
		}
	}

	public unsafe bool skewExtraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewExtraversion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewExtraversion)) = flag;
		}
	}

	public unsafe float extraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion)) = num;
		}
	}

	public unsafe bool skewAgreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewAgreeableness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewAgreeableness)) = flag;
		}
	}

	public unsafe float agreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness)) = num;
		}
	}

	public unsafe bool skewConscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewConscientiousness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewConscientiousness)) = flag;
		}
	}

	public unsafe float conscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness)) = num;
		}
	}

	public unsafe bool skewCreativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewCreativity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skewCreativity)) = flag;
		}
	}

	public unsafe float creativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity)) = num;
		}
	}

	public unsafe bool shiftTimeIsImportant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTimeIsImportant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftTimeIsImportant)) = flag;
		}
	}

	public unsafe ShiftType shiftType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftType);
			return *(ShiftType*)num;
		}
		set
		{
			*(ShiftType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftType)) = shiftType;
		}
	}

	public unsafe bool countsTowardsOpenHoursCoverage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countsTowardsOpenHoursCoverage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countsTowardsOpenHoursCoverage)) = flag;
		}
	}

	public unsafe bool lunchBreakAllowed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lunchBreakAllowed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lunchBreakAllowed)) = flag;
		}
	}

	public unsafe JobAI jobAIPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobAIPosition);
			return *(JobAI*)num;
		}
		set
		{
			*(JobAI*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobAIPosition)) = jobAI;
		}
	}

	public unsafe List<RoomConfiguration> bannedRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedRooms);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AIGoalPreset.GoalActionSetup> actionSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSetup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AIGoalPreset.GoalActionSetup>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe InteractablePreset.SpecialCase jobPostion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPostion);
			return *(InteractablePreset.SpecialCase*)num;
		}
		set
		{
			*(InteractablePreset.SpecialCase*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPostion)) = specialCase;
		}
	}

	public unsafe bool ownsWorkPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownsWorkPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownsWorkPosition)) = flag;
		}
	}

	public unsafe List<RoomConfiguration> preferredRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredRooms);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe bool onlyPotterIfSomebodyElseWorking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyPotterIfSomebodyElseWorking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyPotterIfSomebodyElseWorking)) = flag;
		}
	}

	public unsafe List<AIActionPreset> potterActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterActions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potterActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool canPickUpLitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPickUpLitter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPickUpLitter)) = flag;
		}
	}

	public unsafe bool namePlacard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namePlacard);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namePlacard)) = flag;
		}
	}

	public unsafe bool employeePhoto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_employeePhoto);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_employeePhoto)) = flag;
		}
	}

	public unsafe bool businessCards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_businessCards);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_businessCards)) = flag;
		}
	}

	public unsafe bool workRota
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workRota);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workRota)) = flag;
		}
	}

	public unsafe bool employmentContract
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_employmentContract);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_employmentContract)) = flag;
		}
	}

	public unsafe List<InteractablePreset> jobItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobItems);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> inventoryItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItems);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GroupPreset> joinGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joinGroups);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GroupPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joinGroups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogPreset> addDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addDialog);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe OccupationPreset selectedPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedPreset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OccupationPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occupationPreset));
		}
	}

	static OccupationPreset()
	{
		Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OccupationPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr);
		NativeFieldInfoPtr_work = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "work");
		NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "tags");
		NativeFieldInfoPtr_jobFillPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "jobFillPriority");
		NativeFieldInfoPtr_workOutfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "workOutfit");
		NativeFieldInfoPtr_selfEmployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "selfEmployed");
		NativeFieldInfoPtr_receptionist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "receptionist");
		NativeFieldInfoPtr_canAskAboutJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "canAskAboutJob");
		NativeFieldInfoPtr_janitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "janitor");
		NativeFieldInfoPtr_security = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "security");
		NativeFieldInfoPtr_isCriminal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "isCriminal");
		NativeFieldInfoPtr_isPublicFacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "isPublicFacing");
		NativeFieldInfoPtr_minimumPerCity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "minimumPerCity");
		NativeFieldInfoPtr_societalClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "societalClass");
		NativeFieldInfoPtr_skewPersonalityTowardsJobFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "skewPersonalityTowardsJobFit");
		NativeFieldInfoPtr_skewHumility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "skewHumility");
		NativeFieldInfoPtr_humility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "humility");
		NativeFieldInfoPtr_skewEmotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "skewEmotionality");
		NativeFieldInfoPtr_emotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "emotionality");
		NativeFieldInfoPtr_skewExtraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "skewExtraversion");
		NativeFieldInfoPtr_extraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "extraversion");
		NativeFieldInfoPtr_skewAgreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "skewAgreeableness");
		NativeFieldInfoPtr_agreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "agreeableness");
		NativeFieldInfoPtr_skewConscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "skewConscientiousness");
		NativeFieldInfoPtr_conscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "conscientiousness");
		NativeFieldInfoPtr_skewCreativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "skewCreativity");
		NativeFieldInfoPtr_creativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "creativity");
		NativeFieldInfoPtr_shiftTimeIsImportant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "shiftTimeIsImportant");
		NativeFieldInfoPtr_shiftType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "shiftType");
		NativeFieldInfoPtr_countsTowardsOpenHoursCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "countsTowardsOpenHoursCoverage");
		NativeFieldInfoPtr_lunchBreakAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "lunchBreakAllowed");
		NativeFieldInfoPtr_jobAIPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "jobAIPosition");
		NativeFieldInfoPtr_bannedRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "bannedRooms");
		NativeFieldInfoPtr_actionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "actionSetup");
		NativeFieldInfoPtr_jobPostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "jobPostion");
		NativeFieldInfoPtr_ownsWorkPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "ownsWorkPosition");
		NativeFieldInfoPtr_preferredRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "preferredRooms");
		NativeFieldInfoPtr_potterFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "potterFrequency");
		NativeFieldInfoPtr_onlyPotterIfSomebodyElseWorking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "onlyPotterIfSomebodyElseWorking");
		NativeFieldInfoPtr_potterActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "potterActions");
		NativeFieldInfoPtr_canPickUpLitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "canPickUpLitter");
		NativeFieldInfoPtr_namePlacard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "namePlacard");
		NativeFieldInfoPtr_employeePhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "employeePhoto");
		NativeFieldInfoPtr_businessCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "businessCards");
		NativeFieldInfoPtr_workRota = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "workRota");
		NativeFieldInfoPtr_employmentContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "employmentContract");
		NativeFieldInfoPtr_jobItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "jobItems");
		NativeFieldInfoPtr_inventoryItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "inventoryItems");
		NativeFieldInfoPtr_joinGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "joinGroups");
		NativeFieldInfoPtr_addDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "addDialog");
		NativeFieldInfoPtr_selectedPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, "selectedPreset");
		NativeMethodInfoPtr_CopyOutfitFromSelectedPreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, 100674003);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr, 100674004);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329786, XrefRangeEnd = 329790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyOutfitFromSelectedPreset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyOutfitFromSelectedPreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329790, XrefRangeEnd = 329842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OccupationPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OccupationPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OccupationPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
