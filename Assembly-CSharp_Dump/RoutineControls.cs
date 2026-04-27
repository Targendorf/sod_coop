using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class RoutineControls : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeFieldInfoPtr_hungerRate;

	private static readonly IntPtr NativeFieldInfoPtr_thirstRate;

	private static readonly IntPtr NativeFieldInfoPtr_tirednessRate;

	private static readonly IntPtr NativeFieldInfoPtr_energyRate;

	private static readonly IntPtr NativeFieldInfoPtr_boredemRate;

	private static readonly IntPtr NativeFieldInfoPtr_choresRate;

	private static readonly IntPtr NativeFieldInfoPtr_hygeieneRate;

	private static readonly IntPtr NativeFieldInfoPtr_bladderRate;

	private static readonly IntPtr NativeFieldInfoPtr_drunkRate;

	private static readonly IntPtr NativeFieldInfoPtr_breathRate;

	private static readonly IntPtr NativeFieldInfoPtr_idleSoundRate;

	private static readonly IntPtr NativeFieldInfoPtr_poisonRate;

	private static readonly IntPtr NativeFieldInfoPtr_blindedRate;

	private static readonly IntPtr NativeFieldInfoPtr_commericalDecisionMPTimeSpent;

	private static readonly IntPtr NativeFieldInfoPtr_commericalDecisionMPlayerSameBuilding;

	private static readonly IntPtr NativeFieldInfoPtr_commericalDecisionMPlayerSameLocation;

	private static readonly IntPtr NativeFieldInfoPtr_commericalDecisionMPlayerElsewhere;

	private static readonly IntPtr NativeFieldInfoPtr_workGoal;

	private static readonly IntPtr NativeFieldInfoPtr_answerDoorGoal;

	private static readonly IntPtr NativeFieldInfoPtr_awakenGoal;

	private static readonly IntPtr NativeFieldInfoPtr_sleepGoal;

	private static readonly IntPtr NativeFieldInfoPtr_patrolGoal;

	private static readonly IntPtr NativeFieldInfoPtr_fleeGoal;

	private static readonly IntPtr NativeFieldInfoPtr_investigateGoal;

	private static readonly IntPtr NativeFieldInfoPtr_postJob;

	private static readonly IntPtr NativeFieldInfoPtr_enforcerResponse;

	private static readonly IntPtr NativeFieldInfoPtr_enforcerGuardDuty;

	private static readonly IntPtr NativeFieldInfoPtr_makeSpecificCall;

	private static readonly IntPtr NativeFieldInfoPtr_layLow;

	private static readonly IntPtr NativeFieldInfoPtr_kidnapperCollectRansom;

	private static readonly IntPtr NativeFieldInfoPtr_kidnapperFreeVictim;

	private static readonly IntPtr NativeFieldInfoPtr_searchArea;

	private static readonly IntPtr NativeFieldInfoPtr_searchAreaEnforcer;

	private static readonly IntPtr NativeFieldInfoPtr_hangUp;

	private static readonly IntPtr NativeFieldInfoPtr_raiseAlarm;

	private static readonly IntPtr NativeFieldInfoPtr_sleep;

	private static readonly IntPtr NativeFieldInfoPtr_audioFocus;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightOn;

	private static readonly IntPtr NativeFieldInfoPtr_mainLightOff;

	private static readonly IntPtr NativeFieldInfoPtr_secondaryLightOn;

	private static readonly IntPtr NativeFieldInfoPtr_secondaryLightOff;

	private static readonly IntPtr NativeFieldInfoPtr_lockDoor;

	private static readonly IntPtr NativeFieldInfoPtr_unlockDoor;

	private static readonly IntPtr NativeFieldInfoPtr_openDoor;

	private static readonly IntPtr NativeFieldInfoPtr_closeDoor;

	private static readonly IntPtr NativeFieldInfoPtr_knockOnDoor;

	private static readonly IntPtr NativeFieldInfoPtr_openLocker;

	private static readonly IntPtr NativeFieldInfoPtr_closeLocker;

	private static readonly IntPtr NativeFieldInfoPtr_hide;

	private static readonly IntPtr NativeFieldInfoPtr_pullPlayerFromHiding;

	private static readonly IntPtr NativeFieldInfoPtr_answerTelephone;

	private static readonly IntPtr NativeFieldInfoPtr_makeCall;

	private static readonly IntPtr NativeFieldInfoPtr_takeMoney;

	private static readonly IntPtr NativeFieldInfoPtr_pickupFromFloor;

	private static readonly IntPtr NativeFieldInfoPtr_putBack;

	private static readonly IntPtr NativeFieldInfoPtr_turnOnMusic;

	private static readonly IntPtr NativeFieldInfoPtr_disposal;

	private static readonly IntPtr NativeFieldInfoPtr_bargeDoor;

	private static readonly IntPtr NativeFieldInfoPtr_standAgainstWall;

	private static readonly IntPtr NativeFieldInfoPtr_standGuard;

	private static readonly IntPtr NativeFieldInfoPtr_putUpPoliceTape;

	private static readonly IntPtr NativeFieldInfoPtr_putUpStreetCrimeScene;

	private static readonly IntPtr NativeFieldInfoPtr_getHandIn;

	private static readonly IntPtr NativeFieldInfoPtr_AIPutDownItem;

	private static readonly IntPtr NativeFieldInfoPtr_AIPickUpItem;

	private static readonly IntPtr NativeFieldInfoPtr_purchaseItem;

	private static readonly IntPtr NativeFieldInfoPtr_takeConsumable;

	private static readonly IntPtr NativeFieldInfoPtr_sit;

	private static readonly IntPtr NativeFieldInfoPtr_lookBehindSpooked;

	private static readonly IntPtr NativeFieldInfoPtr_mugging;

	private static readonly IntPtr NativeFieldInfoPtr_fameAndFortune;

	private static readonly IntPtr NativeFieldInfoPtr_loiterConfront;

	private static readonly IntPtr NativeFieldInfoPtr_takeFirstPersonItem;

	private static readonly IntPtr NativeFieldInfoPtr_cleanUp;

	private static readonly IntPtr NativeFieldInfoPtr_findDeadBody;

	private static readonly IntPtr NativeFieldInfoPtr_smellDeadBody;

	private static readonly IntPtr NativeFieldInfoPtr_mourn;

	private static readonly IntPtr NativeFieldInfoPtr_stealItem;

	private static readonly IntPtr NativeFieldInfoPtr_exitBuilding;

	private static readonly IntPtr NativeFieldInfoPtr_missionMeetUpSpecific;

	private static readonly IntPtr NativeFieldInfoPtr_giveSelfUp;

	private static readonly IntPtr NativeFieldInfoPtr_meetFood;

	private static readonly IntPtr NativeFieldInfoPtr_meetUpFoodMission;

	private static readonly IntPtr NativeFieldInfoPtr_toGoGoal;

	private static readonly IntPtr NativeFieldInfoPtr_toGoWalkGoal;

	private static readonly IntPtr NativeFieldInfoPtr_cityHall;

	private static readonly IntPtr NativeFieldInfoPtr_salesRecordsThreshold;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_RoutineControls_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static RoutineControls _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RoutineControls>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)routineControls));
		}
	}

	public unsafe float hungerRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerRate)) = num;
		}
	}

	public unsafe float thirstRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstRate)) = num;
		}
	}

	public unsafe float tirednessRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tirednessRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tirednessRate)) = num;
		}
	}

	public unsafe float energyRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyRate)) = num;
		}
	}

	public unsafe float boredemRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boredemRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boredemRate)) = num;
		}
	}

	public unsafe float choresRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choresRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choresRate)) = num;
		}
	}

	public unsafe float hygeieneRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygeieneRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygeieneRate)) = num;
		}
	}

	public unsafe float bladderRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladderRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladderRate)) = num;
		}
	}

	public unsafe float drunkRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkRate)) = num;
		}
	}

	public unsafe float breathRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRate)) = num;
		}
	}

	public unsafe float idleSoundRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleSoundRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleSoundRate)) = num;
		}
	}

	public unsafe float poisonRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonRate)) = num;
		}
	}

	public unsafe float blindedRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindedRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindedRate)) = num;
		}
	}

	public unsafe float commericalDecisionMPTimeSpent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPTimeSpent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPTimeSpent)) = num;
		}
	}

	public unsafe float commericalDecisionMPlayerSameBuilding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPlayerSameBuilding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPlayerSameBuilding)) = num;
		}
	}

	public unsafe float commericalDecisionMPlayerSameLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPlayerSameLocation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPlayerSameLocation)) = num;
		}
	}

	public unsafe float commericalDecisionMPlayerElsewhere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPlayerElsewhere);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commericalDecisionMPlayerElsewhere)) = num;
		}
	}

	public unsafe AIGoalPreset workGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset answerDoorGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_answerDoorGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_answerDoorGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset awakenGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awakenGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awakenGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset sleepGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset patrolGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_patrolGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_patrolGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset fleeGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fleeGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fleeGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset investigateGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset postJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postJob);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postJob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset enforcerResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enforcerResponse);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enforcerResponse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset enforcerGuardDuty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enforcerGuardDuty);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enforcerGuardDuty)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset makeSpecificCall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeSpecificCall);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeSpecificCall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset layLow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layLow);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layLow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset kidnapperCollectRansom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperCollectRansom);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperCollectRansom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset kidnapperFreeVictim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperFreeVictim);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperFreeVictim)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIActionPreset searchArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchArea);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset searchAreaEnforcer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchAreaEnforcer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchAreaEnforcer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset hangUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hangUp);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hangUp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset raiseAlarm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raiseAlarm);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raiseAlarm)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset sleep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleep);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleep)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset audioFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioFocus);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset mainLightOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightOn);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightOn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset mainLightOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightOff);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightOff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset secondaryLightOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryLightOn);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryLightOn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset secondaryLightOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryLightOff);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryLightOff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset lockDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockDoor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset unlockDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockDoor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset openDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset closeDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeDoor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset knockOnDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knockOnDoor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knockOnDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset openLocker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openLocker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openLocker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset closeLocker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeLocker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeLocker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset hide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hide);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hide)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset pullPlayerFromHiding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pullPlayerFromHiding);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pullPlayerFromHiding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset answerTelephone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_answerTelephone);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_answerTelephone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset makeCall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeCall);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeCall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset takeMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeMoney);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeMoney)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset pickupFromFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickupFromFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickupFromFloor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset putBack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putBack);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putBack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset turnOnMusic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnOnMusic);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnOnMusic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset disposal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset bargeDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset standAgainstWall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standAgainstWall);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standAgainstWall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset standGuard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standGuard);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standGuard)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset putUpPoliceTape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putUpPoliceTape);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putUpPoliceTape)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset putUpStreetCrimeScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putUpStreetCrimeScene);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putUpStreetCrimeScene)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset getHandIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getHandIn);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getHandIn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset AIPutDownItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPutDownItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPutDownItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset AIPickUpItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPickUpItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPickUpItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset purchaseItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchaseItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchaseItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset takeConsumable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeConsumable);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeConsumable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset sit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sit);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset lookBehindSpooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookBehindSpooked);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookBehindSpooked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset mugging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mugging);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mugging)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset fameAndFortune
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fameAndFortune);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fameAndFortune)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset loiterConfront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiterConfront);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiterConfront)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset takeFirstPersonItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeFirstPersonItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeFirstPersonItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIActionPreset cleanUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanUp);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanUp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe AIGoalPreset findDeadBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findDeadBody);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findDeadBody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset smellDeadBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smellDeadBody);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smellDeadBody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset mourn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mourn);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mourn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset stealItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset exitBuilding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitBuilding);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitBuilding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset missionMeetUpSpecific
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionMeetUpSpecific);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionMeetUpSpecific)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset giveSelfUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveSelfUp);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveSelfUp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset meetFood
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetFood);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetFood)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe GroupPreset meetUpFoodMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpFoodMission);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GroupPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpFoodMission)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)groupPreset));
		}
	}

	public unsafe AIGoalPreset toGoGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toGoGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toGoGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe AIGoalPreset toGoWalkGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toGoWalkGoal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toGoWalkGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe BuildingPreset cityHall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityHall);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BuildingPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityHall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildingPreset));
		}
	}

	public unsafe int salesRecordsThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salesRecordsThreshold);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salesRecordsThreshold)) = num;
		}
	}

	public unsafe static RoutineControls Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331816, XrefRangeEnd = 331818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_RoutineControls_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutineControls>(intPtr) : null;
		}
	}

	static RoutineControls()
	{
		Il2CppClassPointerStore<RoutineControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoutineControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr);
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_hungerRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "hungerRate");
		NativeFieldInfoPtr_thirstRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "thirstRate");
		NativeFieldInfoPtr_tirednessRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "tirednessRate");
		NativeFieldInfoPtr_energyRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "energyRate");
		NativeFieldInfoPtr_boredemRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "boredemRate");
		NativeFieldInfoPtr_choresRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "choresRate");
		NativeFieldInfoPtr_hygeieneRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "hygeieneRate");
		NativeFieldInfoPtr_bladderRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "bladderRate");
		NativeFieldInfoPtr_drunkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "drunkRate");
		NativeFieldInfoPtr_breathRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "breathRate");
		NativeFieldInfoPtr_idleSoundRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "idleSoundRate");
		NativeFieldInfoPtr_poisonRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "poisonRate");
		NativeFieldInfoPtr_blindedRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "blindedRate");
		NativeFieldInfoPtr_commericalDecisionMPTimeSpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "commericalDecisionMPTimeSpent");
		NativeFieldInfoPtr_commericalDecisionMPlayerSameBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "commericalDecisionMPlayerSameBuilding");
		NativeFieldInfoPtr_commericalDecisionMPlayerSameLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "commericalDecisionMPlayerSameLocation");
		NativeFieldInfoPtr_commericalDecisionMPlayerElsewhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "commericalDecisionMPlayerElsewhere");
		NativeFieldInfoPtr_workGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "workGoal");
		NativeFieldInfoPtr_answerDoorGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "answerDoorGoal");
		NativeFieldInfoPtr_awakenGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "awakenGoal");
		NativeFieldInfoPtr_sleepGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "sleepGoal");
		NativeFieldInfoPtr_patrolGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "patrolGoal");
		NativeFieldInfoPtr_fleeGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "fleeGoal");
		NativeFieldInfoPtr_investigateGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "investigateGoal");
		NativeFieldInfoPtr_postJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "postJob");
		NativeFieldInfoPtr_enforcerResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "enforcerResponse");
		NativeFieldInfoPtr_enforcerGuardDuty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "enforcerGuardDuty");
		NativeFieldInfoPtr_makeSpecificCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "makeSpecificCall");
		NativeFieldInfoPtr_layLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "layLow");
		NativeFieldInfoPtr_kidnapperCollectRansom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "kidnapperCollectRansom");
		NativeFieldInfoPtr_kidnapperFreeVictim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "kidnapperFreeVictim");
		NativeFieldInfoPtr_searchArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "searchArea");
		NativeFieldInfoPtr_searchAreaEnforcer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "searchAreaEnforcer");
		NativeFieldInfoPtr_hangUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "hangUp");
		NativeFieldInfoPtr_raiseAlarm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "raiseAlarm");
		NativeFieldInfoPtr_sleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "sleep");
		NativeFieldInfoPtr_audioFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "audioFocus");
		NativeFieldInfoPtr_mainLightOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "mainLightOn");
		NativeFieldInfoPtr_mainLightOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "mainLightOff");
		NativeFieldInfoPtr_secondaryLightOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "secondaryLightOn");
		NativeFieldInfoPtr_secondaryLightOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "secondaryLightOff");
		NativeFieldInfoPtr_lockDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "lockDoor");
		NativeFieldInfoPtr_unlockDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "unlockDoor");
		NativeFieldInfoPtr_openDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "openDoor");
		NativeFieldInfoPtr_closeDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "closeDoor");
		NativeFieldInfoPtr_knockOnDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "knockOnDoor");
		NativeFieldInfoPtr_openLocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "openLocker");
		NativeFieldInfoPtr_closeLocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "closeLocker");
		NativeFieldInfoPtr_hide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "hide");
		NativeFieldInfoPtr_pullPlayerFromHiding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "pullPlayerFromHiding");
		NativeFieldInfoPtr_answerTelephone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "answerTelephone");
		NativeFieldInfoPtr_makeCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "makeCall");
		NativeFieldInfoPtr_takeMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "takeMoney");
		NativeFieldInfoPtr_pickupFromFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "pickupFromFloor");
		NativeFieldInfoPtr_putBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "putBack");
		NativeFieldInfoPtr_turnOnMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "turnOnMusic");
		NativeFieldInfoPtr_disposal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "disposal");
		NativeFieldInfoPtr_bargeDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "bargeDoor");
		NativeFieldInfoPtr_standAgainstWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "standAgainstWall");
		NativeFieldInfoPtr_standGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "standGuard");
		NativeFieldInfoPtr_putUpPoliceTape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "putUpPoliceTape");
		NativeFieldInfoPtr_putUpStreetCrimeScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "putUpStreetCrimeScene");
		NativeFieldInfoPtr_getHandIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "getHandIn");
		NativeFieldInfoPtr_AIPutDownItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "AIPutDownItem");
		NativeFieldInfoPtr_AIPickUpItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "AIPickUpItem");
		NativeFieldInfoPtr_purchaseItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "purchaseItem");
		NativeFieldInfoPtr_takeConsumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "takeConsumable");
		NativeFieldInfoPtr_sit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "sit");
		NativeFieldInfoPtr_lookBehindSpooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "lookBehindSpooked");
		NativeFieldInfoPtr_mugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "mugging");
		NativeFieldInfoPtr_fameAndFortune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "fameAndFortune");
		NativeFieldInfoPtr_loiterConfront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "loiterConfront");
		NativeFieldInfoPtr_takeFirstPersonItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "takeFirstPersonItem");
		NativeFieldInfoPtr_cleanUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "cleanUp");
		NativeFieldInfoPtr_findDeadBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "findDeadBody");
		NativeFieldInfoPtr_smellDeadBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "smellDeadBody");
		NativeFieldInfoPtr_mourn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "mourn");
		NativeFieldInfoPtr_stealItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "stealItem");
		NativeFieldInfoPtr_exitBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "exitBuilding");
		NativeFieldInfoPtr_missionMeetUpSpecific = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "missionMeetUpSpecific");
		NativeFieldInfoPtr_giveSelfUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "giveSelfUp");
		NativeFieldInfoPtr_meetFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "meetFood");
		NativeFieldInfoPtr_meetUpFoodMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "meetUpFoodMission");
		NativeFieldInfoPtr_toGoGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "toGoGoal");
		NativeFieldInfoPtr_toGoWalkGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "toGoWalkGoal");
		NativeFieldInfoPtr_cityHall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "cityHall");
		NativeFieldInfoPtr_salesRecordsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, "salesRecordsThreshold");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_RoutineControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, 100674124);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, 100674125);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, 100674126);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr, 100674127);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331818, XrefRangeEnd = 331855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331855, XrefRangeEnd = 331876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331876, XrefRangeEnd = 331879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoutineControls()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoutineControls>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoutineControls(IntPtr pointer)
		: base(pointer)
	{
	}
}
