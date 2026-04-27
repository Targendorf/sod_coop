using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class GameplayControls : MonoBehaviour
{
	[System.Serializable]
	public class SyncDiskColour : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_category;

		private static readonly System.IntPtr NativeFieldInfoPtr_mainColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour1;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour2;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SyncDiskPreset.Manufacturer category
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
				return *(SyncDiskPreset.Manufacturer*)num;
			}
			set
			{
				*(SyncDiskPreset.Manufacturer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)) = manufacturer;
			}
		}

		public unsafe Color mainColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainColour)) = color;
			}
		}

		public unsafe Color colour1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1)) = color;
			}
		}

		public unsafe Color colour2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2)) = color;
			}
		}

		public unsafe Color colour3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3)) = color;
			}
		}

		static SyncDiskColour()
		{
			Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "SyncDiskColour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr);
			NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr, "category");
			NativeFieldInfoPtr_mainColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr, "mainColour");
			NativeFieldInfoPtr_colour1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr, "colour1");
			NativeFieldInfoPtr_colour2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr, "colour2");
			NativeFieldInfoPtr_colour3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr, "colour3");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr, 100674108);
		}

		[CallerCount(0)]
		public unsafe SyncDiskColour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncDiskColour>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SyncDiskColour(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_intro;

	private static readonly System.IntPtr NativeFieldInfoPtr_outro;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingTimeSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeMultipliers;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingDate;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingMonth;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearZeroLeapYearCycle;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayZero;

	private static readonly System.IntPtr NativeFieldInfoPtr_publicYearZero;

	private static readonly System.IntPtr NativeFieldInfoPtr_routineUpdateFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameWorldUpdateFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorSequenceUpdateFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealthModeLoopUpdateFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerHeightNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerHeightCrouched;

	private static readonly System.IntPtr NativeFieldInfoPtr_crouchHeightCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_leanCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_joltCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraHeightNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraHeightCrouched;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_carryDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_throwForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_fovInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsModelLag;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerWalkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerRunSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_jumpHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerStealthWalkMuliplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerStealthRunMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_headBobMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_ductPlayerHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ductCamHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ductPlayerPosY;

	private static readonly System.IntPtr NativeFieldInfoPtr_airDuctEntry;

	private static readonly System.IntPtr NativeFieldInfoPtr_airDuctExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalSkinWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_carryingSkinWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_ductSkinWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultReturnTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_enterVentTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_exitVentTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizensArrestTranstion;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenTalkToTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorPeekEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorPeekExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockpickEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockpickExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_sabotageEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_sabotageExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_bargeDoorEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_bargeDoorFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_bargeDoorSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_punchedReaction;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerKO;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerUseComputer;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerComputerExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerTakePrint;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerTakePrintExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSearchExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_focusOnInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterCoolerEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragForceAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxAngleMovementWhenDragging;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollCarryMaxDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollJointPreprocessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollJointCollision;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollJointProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollJointContactDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollRigidbodyCollision;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollJointBounce;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollJointDampen;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollJointSpring;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofNormalNearStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofNormalNearEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofNormalFarStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofNormalFarEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofTalkingNearStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofTalkingNearEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofTalkingFarStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofTalkingFarEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofPausedNearStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofPausedNearEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofPausedFarStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofPausedFarEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofCityEditNearStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofCityEditNearEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofCityEditFarStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofCityEditFarEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_dofChangeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_nothingItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_watchItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_fistsItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_coinItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_printReader;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemSwitchCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealthAmbientLightLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_interiorAmbientLightMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorLightMeasure;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealthSunLightLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingAlarmTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityTrackSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenFOV;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityFOV;

	private static readonly System.IntPtr NativeFieldInfoPtr_sabotageLandValueMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenSightRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_securitySightRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumStealthDetectionRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_sentryGunWeapon;

	private static readonly System.IntPtr NativeFieldInfoPtr_sentryGunROF;

	private static readonly System.IntPtr NativeFieldInfoPtr_sentryGunDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_sentryGunAccuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerMaxSpotDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSpotUpdateEveryXFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_spottedGraceTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_spottedFadeSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioOnlySpotGraceTimeMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerImageCaptureMaxRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingWantedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_breakerResetTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityResetTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasFillTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasEmptyTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_additionalEscalationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingLockpicks;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockpickEffectivenessRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockpickSpeedRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_bargeDamageRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseMaxPlayerHealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerRecoveryRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerCombatSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerCombatHeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultInventorySlots;

	private static readonly System.IntPtr NativeFieldInfoPtr_incomingPlayerPhysicsDamageMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_commonSyncDisksPer200Citizens;

	private static readonly System.IntPtr NativeFieldInfoPtr_mediumSyncDisksPer200Citizens;

	private static readonly System.IntPtr NativeFieldInfoPtr_rareSyncDisksPer200Citizens;

	private static readonly System.IntPtr NativeFieldInfoPtr_veryRareSyncDisksPer200Citizens;

	private static readonly System.IntPtr NativeFieldInfoPtr_corpSabotageMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_corpSabotageManagementBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyForAddresses;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyForNewLocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyForAirDucts;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyForPasscodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyForReading;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyForStreetCleaning;

	private static readonly System.IntPtr NativeFieldInfoPtr_passiveIncome;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeHeightModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeRunSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeReach;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeHealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgradeRegen;

	private static readonly System.IntPtr NativeFieldInfoPtr_legalInsuranceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialCreditForLostAndFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialCreditForSideJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialCreditForMurders;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialCreditLevelCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_foodHotTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeOfDeathAccuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_retailItemSoldDiscovery;

	private static readonly System.IntPtr NativeFieldInfoPtr_retailItemNoSoldDiscovery;

	private static readonly System.IntPtr NativeFieldInfoPtr_fistMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerUpperMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerLowerMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerTipMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_thumbJointMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_interpolation;

	private static readonly System.IntPtr NativeFieldInfoPtr_physicsOffTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultObjectPhysicsProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_binTrashLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingCallLogMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_preSimSpeedMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_walletCashAmountBasedOnWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_creditCardTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_donorCardTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_successfulBlockThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_perfectBlockThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseAttackDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockedAttackDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_perfectBlockAttackDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_koTimeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerKOPunchForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_koTimePass;

	private static readonly System.IntPtr NativeFieldInfoPtr_restrainedTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_takedownTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_thrownGrenadeFuse;

	private static readonly System.IntPtr NativeFieldInfoPtr_proxyGrenadeFuse;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodAmountMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_successfulBlockTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_unsuccessfulBlockTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_counterTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayerLookAtTailingDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerLookAtSpookRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_loseSpookedRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenCentreSpookCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_muggingChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatterRemovalTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectPositionResetTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_brokenWindowBoardTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_brokenWindowResetTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_breakingWindowsFine;

	private static readonly System.IntPtr NativeFieldInfoPtr_vandalismFineMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_vandalismTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_illegalActionMinimumTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_tamperGrace;

	private static readonly System.IntPtr NativeFieldInfoPtr_physicsTamperDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_fignerprintPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_detainDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseResultProcessTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_bestCaseVictimCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_worstCaseVictimCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideJobDifficultyRewardMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_secretLocationFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealTriggerChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCases;

	private static readonly System.IntPtr NativeFieldInfoPtr_crimeSceneCleanupDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionPhotoMinMaxDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_missionPhotoDistanceScoreCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCoverUps;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpAvailableDuringCase;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpReward;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpDelayTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumFootprintsPerRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintScaleRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_stepDirtRemoval;

	private static readonly System.IntPtr NativeFieldInfoPtr_stepBloodRemoval;

	private static readonly System.IntPtr NativeFieldInfoPtr_outdoorStepDirtAccumulation;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_crimeSceneSearchLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_crimeSceneLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_smellTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_murderResolveQuestions;

	private static readonly System.IntPtr NativeFieldInfoPtr_retirementResolveQuestions;

	private static readonly System.IntPtr NativeFieldInfoPtr_kidnapperCallTriggerDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_OScursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureFoV;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_humanCaptureRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraCaptureMemory;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraCaptureMaxTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCapturesPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncDiskColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultDiskSlots;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseWheelEvidenceScrollSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_indoorTemperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_airDuctTemperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_heatSourceTemperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_oscillatorX;

	private static readonly System.IntPtr NativeFieldInfoPtr_oscillatorY;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkOscillationSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverFluctuation;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverOscillationSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkLensDistortOscillator;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkLensDistortSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_tripTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_headacheFluctuation;

	private static readonly System.IntPtr NativeFieldInfoPtr_bleedingSpatter;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallDamageMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_detainedStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_wantedInBuildingStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerHungerRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerThirstRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerTirednessRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerEnergyRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_combatHitChanceOfBruised;

	private static readonly System.IntPtr NativeFieldInfoPtr_combatHitChanceOfBlackEye;

	private static readonly System.IntPtr NativeFieldInfoPtr_combatHitChanceOfBrokenLeg;

	private static readonly System.IntPtr NativeFieldInfoPtr_combatHitChanceOfBleeding;

	private static readonly System.IntPtr NativeFieldInfoPtr_propertyValueRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_propertyValueCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultLoanAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultLoanExtra;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultLoanRepayment;

	private static readonly System.IntPtr NativeFieldInfoPtr_loiteringCommentThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_loiteringConfrontThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_loiteringTrespassThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_loiteringPurchaseResetValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_humanScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_murderScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_evidenceScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideJobScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncDiskScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_groupScope;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_GameplayControls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CutScenePreset intro
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intro);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CutScenePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intro)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cutScenePreset));
		}
	}

	public unsafe CutScenePreset outro
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outro);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CutScenePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outro)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cutScenePreset));
		}
	}

	public unsafe SessionData.TimeSpeed startingTimeSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingTimeSpeed);
			return *(SessionData.TimeSpeed*)num;
		}
		set
		{
			*(SessionData.TimeSpeed*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingTimeSpeed)) = timeSpeed;
		}
	}

	public unsafe List<float> timeMultipliers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeMultipliers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeMultipliers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int startingDate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDate);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDate)) = num;
		}
	}

	public unsafe int startingMonth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMonth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMonth)) = num;
		}
	}

	public unsafe int startingYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingYear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingYear)) = num;
		}
	}

	public unsafe int yearZeroLeapYearCycle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearZeroLeapYearCycle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearZeroLeapYearCycle)) = num;
		}
	}

	public unsafe int dayZero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayZero);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayZero)) = num;
		}
	}

	public unsafe int publicYearZero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicYearZero);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicYearZero)) = num;
		}
	}

	public unsafe float routineUpdateFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_routineUpdateFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_routineUpdateFrequency)) = num;
		}
	}

	public unsafe float gameWorldUpdateFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameWorldUpdateFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameWorldUpdateFrequency)) = num;
		}
	}

	public unsafe float doorSequenceUpdateFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSequenceUpdateFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSequenceUpdateFrequency)) = num;
		}
	}

	public unsafe float stealthModeLoopUpdateFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeLoopUpdateFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeLoopUpdateFrequency)) = num;
		}
	}

	public unsafe float playerHeightNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeightNormal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeightNormal)) = num;
		}
	}

	public unsafe float playerHeightCrouched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeightCrouched);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeightCrouched)) = num;
		}
	}

	public unsafe AnimationCurve crouchHeightCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouchHeightCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouchHeightCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve leanCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve joltCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float cameraHeightNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraHeightNormal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraHeightNormal)) = num;
		}
	}

	public unsafe float cameraHeightCrouched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraHeightCrouched);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraHeightCrouched)) = num;
		}
	}

	public unsafe float interactionRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionRange)) = num;
		}
	}

	public unsafe float readingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingRange)) = num;
		}
	}

	public unsafe float carryDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carryDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carryDistance)) = num;
		}
	}

	public unsafe float throwForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwForce)) = num;
		}
	}

	public unsafe float fovNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovNormal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovNormal)) = num;
		}
	}

	public unsafe float fovInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovInteraction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovInteraction)) = num;
		}
	}

	public unsafe float fpsModelLag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsModelLag);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsModelLag)) = num;
		}
	}

	public unsafe float playerWalkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerWalkSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerWalkSpeed)) = num;
		}
	}

	public unsafe float playerRunSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRunSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRunSpeed)) = num;
		}
	}

	public unsafe float jumpHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpHeight)) = num;
		}
	}

	public unsafe float playerStealthWalkMuliplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStealthWalkMuliplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStealthWalkMuliplier)) = num;
		}
	}

	public unsafe float playerStealthRunMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStealthRunMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStealthRunMultiplier)) = num;
		}
	}

	public unsafe float headBobMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headBobMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headBobMultiplier)) = num;
		}
	}

	public unsafe float ductPlayerHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductPlayerHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductPlayerHeight)) = num;
		}
	}

	public unsafe float ductCamHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductCamHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductCamHeight)) = num;
		}
	}

	public unsafe float ductPlayerPosY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductPlayerPosY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductPlayerPosY)) = num;
		}
	}

	public unsafe Vector3 airDuctEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctEntry);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctEntry)) = vector;
		}
	}

	public unsafe Vector3 airDuctExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctExit);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctExit)) = vector;
		}
	}

	public unsafe float normalSkinWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalSkinWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalSkinWidth)) = num;
		}
	}

	public unsafe float carryingSkinWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carryingSkinWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carryingSkinWidth)) = num;
		}
	}

	public unsafe float ductSkinWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductSkinWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductSkinWidth)) = num;
		}
	}

	public unsafe PlayerTransitionPreset defaultReturnTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultReturnTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultReturnTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset enterVentTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterVentTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterVentTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset exitVentTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitVentTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitVentTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset citizensArrestTranstion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizensArrestTranstion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizensArrestTranstion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset citizenTalkToTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenTalkToTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenTalkToTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset doorPeekEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPeekEnter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPeekEnter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset doorPeekExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPeekExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPeekExit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset lockpickEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickEnter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickEnter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset lockpickExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickExit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset sabotageEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageEnter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageEnter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset sabotageExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageExit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset bargeDoorEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoorEnter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoorEnter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset bargeDoorFail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoorFail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoorFail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset bargeDoorSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoorSuccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDoorSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset punchedReaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_punchedReaction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_punchedReaction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset playerKO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerKO);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerKO)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset playerUseComputer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerUseComputer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerUseComputer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset playerComputerExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerComputerExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerComputerExit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset playerTakePrint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTakePrint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTakePrint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset playerTakePrintExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTakePrintExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTakePrintExit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset playerSearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSearch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSearch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset playerSearchExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSearchExit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSearchExit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset focusOnInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusOnInteractable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusOnInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset waterCoolerEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterCoolerEnter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterCoolerEnter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe float dragForceAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragForceAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragForceAmount)) = num;
		}
	}

	public unsafe float maxAngleMovementWhenDragging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngleMovementWhenDragging);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngleMovementWhenDragging)) = num;
		}
	}

	public unsafe float ragdollCarryMaxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollCarryMaxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollCarryMaxDistance)) = num;
		}
	}

	public unsafe bool ragdollJointPreprocessing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointPreprocessing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointPreprocessing)) = flag;
		}
	}

	public unsafe bool ragdollJointCollision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointCollision);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointCollision)) = flag;
		}
	}

	public unsafe bool ragdollJointProjection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointProjection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointProjection)) = flag;
		}
	}

	public unsafe float ragdollJointContactDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointContactDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointContactDistance)) = num;
		}
	}

	public unsafe bool ragdollRigidbodyCollision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollRigidbodyCollision);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollRigidbodyCollision)) = flag;
		}
	}

	public unsafe float ragdollJointBounce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointBounce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointBounce)) = num;
		}
	}

	public unsafe float ragdollJointDampen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointDampen);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointDampen)) = num;
		}
	}

	public unsafe float ragdollJointSpring
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointSpring);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollJointSpring)) = num;
		}
	}

	public unsafe float dofNormalNearStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalNearStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalNearStart)) = num;
		}
	}

	public unsafe float dofNormalNearEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalNearEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalNearEnd)) = num;
		}
	}

	public unsafe float dofNormalFarStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalFarStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalFarStart)) = num;
		}
	}

	public unsafe float dofNormalFarEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalFarEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofNormalFarEnd)) = num;
		}
	}

	public unsafe float dofTalkingNearStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingNearStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingNearStart)) = num;
		}
	}

	public unsafe float dofTalkingNearEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingNearEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingNearEnd)) = num;
		}
	}

	public unsafe float dofTalkingFarStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingFarStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingFarStart)) = num;
		}
	}

	public unsafe float dofTalkingFarEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingFarEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofTalkingFarEnd)) = num;
		}
	}

	public unsafe float dofPausedNearStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedNearStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedNearStart)) = num;
		}
	}

	public unsafe float dofPausedNearEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedNearEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedNearEnd)) = num;
		}
	}

	public unsafe float dofPausedFarStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedFarStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedFarStart)) = num;
		}
	}

	public unsafe float dofPausedFarEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedFarEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofPausedFarEnd)) = num;
		}
	}

	public unsafe float dofCityEditNearStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditNearStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditNearStart)) = num;
		}
	}

	public unsafe float dofCityEditNearEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditNearEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditNearEnd)) = num;
		}
	}

	public unsafe float dofCityEditFarStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditFarStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditFarStart)) = num;
		}
	}

	public unsafe float dofCityEditFarEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditFarEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofCityEditFarEnd)) = num;
		}
	}

	public unsafe float dofChangeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofChangeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dofChangeTime)) = num;
		}
	}

	public unsafe List<FirstPersonItem> startingItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FirstPersonItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe FirstPersonItem nothingItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nothingItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nothingItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonItem));
		}
	}

	public unsafe FirstPersonItem watchItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_watchItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_watchItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonItem));
		}
	}

	public unsafe FirstPersonItem fistsItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fistsItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fistsItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonItem));
		}
	}

	public unsafe FirstPersonItem coinItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coinItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coinItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonItem));
		}
	}

	public unsafe FirstPersonItem printReader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printReader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printReader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonItem));
		}
	}

	public unsafe float itemSwitchCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSwitchCounter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSwitchCounter)) = num;
		}
	}

	public unsafe AnimationCurve stealthAmbientLightLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthAmbientLightLevel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthAmbientLightLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float interiorAmbientLightMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientLightMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientLightMultiplier)) = num;
		}
	}

	public unsafe Transform floorLightMeasure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorLightMeasure);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorLightMeasure)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe AnimationCurve stealthSunLightLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthSunLightLevel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthSunLightLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Vector2 buildingAlarmTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingAlarmTime);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingAlarmTime)) = vector;
		}
	}

	public unsafe float securityTrackSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityTrackSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityTrackSpeed)) = num;
		}
	}

	public unsafe float citizenFOV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenFOV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenFOV)) = num;
		}
	}

	public unsafe float securityFOV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityFOV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityFOV)) = num;
		}
	}

	public unsafe float sabotageLandValueMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageLandValueMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageLandValueMP)) = num;
		}
	}

	public unsafe float citizenSightRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenSightRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenSightRange)) = num;
		}
	}

	public unsafe float securitySightRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securitySightRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securitySightRange)) = num;
		}
	}

	public unsafe float minimumStealthDetectionRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumStealthDetectionRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumStealthDetectionRange)) = num;
		}
	}

	public unsafe MurderWeaponPreset sentryGunWeapon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunWeapon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MurderWeaponPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunWeapon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)murderWeaponPreset));
		}
	}

	public unsafe float sentryGunROF
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunROF);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunROF)) = num;
		}
	}

	public unsafe float sentryGunDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunDamage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunDamage)) = num;
		}
	}

	public unsafe float sentryGunAccuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunAccuracy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sentryGunAccuracy)) = num;
		}
	}

	public unsafe float playerMaxSpotDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMaxSpotDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMaxSpotDistance)) = num;
		}
	}

	public unsafe int playerSpotUpdateEveryXFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSpotUpdateEveryXFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSpotUpdateEveryXFrame)) = num;
		}
	}

	public unsafe float spottedGraceTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spottedGraceTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spottedGraceTime)) = num;
		}
	}

	public unsafe float spottedFadeSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spottedFadeSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spottedFadeSpeed)) = num;
		}
	}

	public unsafe float audioOnlySpotGraceTimeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioOnlySpotGraceTimeMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioOnlySpotGraceTimeMultiplier)) = num;
		}
	}

	public unsafe float playerImageCaptureMaxRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerImageCaptureMaxRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerImageCaptureMaxRange)) = num;
		}
	}

	public unsafe float buildingWantedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingWantedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingWantedTime)) = num;
		}
	}

	public unsafe float breakerResetTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerResetTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerResetTime)) = num;
		}
	}

	public unsafe float securityResetTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityResetTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityResetTime)) = num;
		}
	}

	public unsafe float gasFillTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasFillTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasFillTime)) = num;
		}
	}

	public unsafe float gasEmptyTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasEmptyTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasEmptyTime)) = num;
		}
	}

	public unsafe float additionalEscalationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalEscalationTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalEscalationTime)) = num;
		}
	}

	public unsafe int startingMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMoney);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMoney)) = num;
		}
	}

	public unsafe int startingLockpicks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingLockpicks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingLockpicks)) = num;
		}
	}

	public unsafe Vector2 lockpickEffectivenessRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickEffectivenessRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickEffectivenessRange)) = vector;
		}
	}

	public unsafe Vector2 lockpickSpeedRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickSpeedRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpickSpeedRange)) = vector;
		}
	}

	public unsafe Vector2 bargeDamageRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDamageRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeDamageRange)) = vector;
		}
	}

	public unsafe float baseMaxPlayerHealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMaxPlayerHealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMaxPlayerHealth)) = num;
		}
	}

	public unsafe float playerRecoveryRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRecoveryRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRecoveryRate)) = num;
		}
	}

	public unsafe float playerCombatSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCombatSkill);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCombatSkill)) = num;
		}
	}

	public unsafe float playerCombatHeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCombatHeft);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCombatHeft)) = num;
		}
	}

	public unsafe int defaultInventorySlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultInventorySlots);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultInventorySlots)) = num;
		}
	}

	public unsafe float incomingPlayerPhysicsDamageMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomingPlayerPhysicsDamageMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomingPlayerPhysicsDamageMultiplier)) = num;
		}
	}

	public unsafe float commonSyncDisksPer200Citizens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonSyncDisksPer200Citizens);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonSyncDisksPer200Citizens)) = num;
		}
	}

	public unsafe float mediumSyncDisksPer200Citizens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumSyncDisksPer200Citizens);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumSyncDisksPer200Citizens)) = num;
		}
	}

	public unsafe float rareSyncDisksPer200Citizens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareSyncDisksPer200Citizens);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rareSyncDisksPer200Citizens)) = num;
		}
	}

	public unsafe float veryRareSyncDisksPer200Citizens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_veryRareSyncDisksPer200Citizens);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_veryRareSyncDisksPer200Citizens)) = num;
		}
	}

	public unsafe int corpSabotageMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_corpSabotageMoney);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_corpSabotageMoney)) = num;
		}
	}

	public unsafe int corpSabotageManagementBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_corpSabotageManagementBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_corpSabotageManagementBonus)) = num;
		}
	}

	public unsafe int moneyForAddresses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForAddresses);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForAddresses)) = num;
		}
	}

	public unsafe int moneyForNewLocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForNewLocations);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForNewLocations)) = num;
		}
	}

	public unsafe int moneyForAirDucts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForAirDucts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForAirDucts)) = num;
		}
	}

	public unsafe int moneyForPasscodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForPasscodes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForPasscodes)) = num;
		}
	}

	public unsafe int moneyForReading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForReading);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForReading)) = num;
		}
	}

	public unsafe int moneyForStreetCleaning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForStreetCleaning);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyForStreetCleaning)) = num;
		}
	}

	public unsafe int passiveIncome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passiveIncome);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passiveIncome)) = num;
		}
	}

	public unsafe float upgradeHeightModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeHeightModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeHeightModifier)) = num;
		}
	}

	public unsafe float upgradeRunSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeRunSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeRunSpeed)) = num;
		}
	}

	public unsafe float upgradeReach
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeReach);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeReach)) = num;
		}
	}

	public unsafe float upgradeHealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeHealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeHealth)) = num;
		}
	}

	public unsafe float upgradeRegen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeRegen);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradeRegen)) = num;
		}
	}

	public unsafe Vector2 legalInsuranceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legalInsuranceMultiplier);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legalInsuranceMultiplier)) = vector;
		}
	}

	public unsafe int socialCreditForLostAndFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditForLostAndFound);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditForLostAndFound)) = num;
		}
	}

	public unsafe int socialCreditForSideJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditForSideJobs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditForSideJobs)) = num;
		}
	}

	public unsafe int socialCreditForMurders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditForMurders);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditForMurders)) = num;
		}
	}

	public unsafe AnimationCurve socialCreditLevelCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditLevelCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditLevelCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float foodHotTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodHotTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodHotTime)) = num;
		}
	}

	public unsafe float timeOfDeathAccuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOfDeathAccuracy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOfDeathAccuracy)) = num;
		}
	}

	public unsafe EvidencePreset retailItemSoldDiscovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItemSoldDiscovery);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidencePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItemSoldDiscovery)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidencePreset));
		}
	}

	public unsafe EvidencePreset retailItemNoSoldDiscovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItemNoSoldDiscovery);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidencePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItemNoSoldDiscovery)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidencePreset));
		}
	}

	public unsafe Material fistMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fistMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fistMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material fingerUpperMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerUpperMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerUpperMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material fingerLowerMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerLowerMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerLowerMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material fingerTipMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerTipMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerTipMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material thumbJointMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbJointMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbJointMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe RigidbodyInterpolation interpolation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interpolation);
			return *(RigidbodyInterpolation*)num;
		}
		set
		{
			*(RigidbodyInterpolation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interpolation)) = rigidbodyInterpolation;
		}
	}

	public unsafe float physicsOffTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsOffTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsOffTime)) = num;
		}
	}

	public unsafe PhysicsProfile defaultObjectPhysicsProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultObjectPhysicsProfile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicsProfile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultObjectPhysicsProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)physicsProfile));
		}
	}

	public unsafe int binTrashLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binTrashLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binTrashLimit)) = num;
		}
	}

	public unsafe int buildingCallLogMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingCallLogMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingCallLogMax)) = num;
		}
	}

	public unsafe float preSimSpeedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preSimSpeedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preSimSpeedMultiplier)) = num;
		}
	}

	public unsafe AnimationCurve walletCashAmountBasedOnWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walletCashAmountBasedOnWealth);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walletCashAmountBasedOnWealth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe CharacterTrait creditCardTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creditCardTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creditCardTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait donorCardTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_donorCardTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_donorCardTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe float successfulBlockThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_successfulBlockThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_successfulBlockThreshold)) = num;
		}
	}

	public unsafe float perfectBlockThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perfectBlockThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perfectBlockThreshold)) = num;
		}
	}

	public unsafe Vector2 baseAttackDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAttackDelay);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseAttackDelay)) = vector;
		}
	}

	public unsafe Vector2 blockedAttackDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAttackDelay);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAttackDelay)) = vector;
		}
	}

	public unsafe Vector2 perfectBlockAttackDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perfectBlockAttackDelay);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perfectBlockAttackDelay)) = vector;
		}
	}

	public unsafe Vector2 koTimeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTimeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTimeRange)) = vector;
		}
	}

	public unsafe float playerKOPunchForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerKOPunchForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerKOPunchForce)) = num;
		}
	}

	public unsafe float koTimePass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTimePass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTimePass)) = num;
		}
	}

	public unsafe float restrainedTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrainedTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrainedTimer)) = num;
		}
	}

	public unsafe float takedownTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takedownTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takedownTimer)) = num;
		}
	}

	public unsafe float thrownGrenadeFuse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thrownGrenadeFuse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thrownGrenadeFuse)) = num;
		}
	}

	public unsafe float proxyGrenadeFuse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_proxyGrenadeFuse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_proxyGrenadeFuse)) = num;
		}
	}

	public unsafe float bloodAmountMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodAmountMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodAmountMultiplier)) = num;
		}
	}

	public unsafe PlayerTransitionPreset successfulBlockTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_successfulBlockTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_successfulBlockTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset unsuccessfulBlockTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unsuccessfulBlockTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unsuccessfulBlockTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset counterTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counterTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe float maxPlayerLookAtTailingDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayerLookAtTailingDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayerLookAtTailingDistance)) = num;
		}
	}

	public unsafe float playerLookAtSpookRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerLookAtSpookRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerLookAtSpookRate)) = num;
		}
	}

	public unsafe float loseSpookedRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseSpookedRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseSpookedRate)) = num;
		}
	}

	public unsafe AnimationCurve screenCentreSpookCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenCentreSpookCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenCentreSpookCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float muggingChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muggingChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muggingChance)) = num;
		}
	}

	public unsafe float spatterRemovalTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterRemovalTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterRemovalTime)) = num;
		}
	}

	public unsafe float objectPositionResetTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPositionResetTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPositionResetTime)) = num;
		}
	}

	public unsafe float brokenWindowBoardTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenWindowBoardTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenWindowBoardTime)) = num;
		}
	}

	public unsafe float brokenWindowResetTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenWindowResetTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenWindowResetTime)) = num;
		}
	}

	public unsafe int breakingWindowsFine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakingWindowsFine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakingWindowsFine)) = num;
		}
	}

	public unsafe int vandalismFineMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalismFineMultiplier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalismFineMultiplier)) = num;
		}
	}

	public unsafe float vandalismTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalismTimeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalismTimeout)) = num;
		}
	}

	public unsafe float illegalActionMinimumTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_illegalActionMinimumTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_illegalActionMinimumTime)) = num;
		}
	}

	public unsafe int tamperGrace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperGrace);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperGrace)) = num;
		}
	}

	public unsafe float physicsTamperDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsTamperDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsTamperDistance)) = num;
		}
	}

	public unsafe InteractablePreset fignerprintPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fignerprintPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fignerprintPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe float detainDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detainDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detainDelay)) = num;
		}
	}

	public unsafe float caseResultProcessTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseResultProcessTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseResultProcessTime)) = num;
		}
	}

	public unsafe int bestCaseVictimCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestCaseVictimCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestCaseVictimCount)) = num;
		}
	}

	public unsafe int worstCaseVictimCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worstCaseVictimCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worstCaseVictimCount)) = num;
		}
	}

	public unsafe AnimationCurve sideJobDifficultyRewardMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideJobDifficultyRewardMultiplier);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideJobDifficultyRewardMultiplier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe List<FurniturePreset> secretLocationFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secretLocationFurniture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurniturePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secretLocationFurniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float stealTriggerChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealTriggerChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealTriggerChance)) = num;
		}
	}

	public unsafe int maxCases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCases);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCases)) = num;
		}
	}

	public unsafe float crimeSceneCleanupDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneCleanupDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneCleanupDelay)) = num;
		}
	}

	public unsafe Vector2 missionPhotoMinMaxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionPhotoMinMaxDistance);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionPhotoMinMaxDistance)) = vector;
		}
	}

	public unsafe AnimationCurve missionPhotoDistanceScoreCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionPhotoDistanceScoreCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionPhotoDistanceScoreCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool enableCoverUps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCoverUps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCoverUps)) = flag;
		}
	}

	public unsafe int coverUpAvailableDuringCase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpAvailableDuringCase);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpAvailableDuringCase)) = num;
		}
	}

	public unsafe float coverUpChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpChance)) = num;
		}
	}

	public unsafe int coverUpReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpReward);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpReward)) = num;
		}
	}

	public unsafe float coverUpDelayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpDelayTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpDelayTime)) = num;
		}
	}

	public unsafe int maximumFootprintsPerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumFootprintsPerRoom);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumFootprintsPerRoom)) = num;
		}
	}

	public unsafe Vector2 footprintScaleRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintScaleRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintScaleRange)) = vector;
		}
	}

	public unsafe float stepDirtRemoval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stepDirtRemoval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stepDirtRemoval)) = num;
		}
	}

	public unsafe float stepBloodRemoval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stepBloodRemoval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stepBloodRemoval)) = num;
		}
	}

	public unsafe float outdoorStepDirtAccumulation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outdoorStepDirtAccumulation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outdoorStepDirtAccumulation)) = num;
		}
	}

	public unsafe InteractablePreset footprintPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe float crimeSceneSearchLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneSearchLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneSearchLength)) = num;
		}
	}

	public unsafe float crimeSceneLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneLength)) = num;
		}
	}

	public unsafe float smellTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smellTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smellTime)) = num;
		}
	}

	public unsafe List<Case.ResolveQuestion> murderResolveQuestions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderResolveQuestions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Case.ResolveQuestion>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderResolveQuestions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Case.ResolveQuestion> retirementResolveQuestions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retirementResolveQuestions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Case.ResolveQuestion>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retirementResolveQuestions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe DialogPreset kidnapperCallTriggerDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperCallTriggerDialog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapperCallTriggerDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe GameObject OScursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OScursor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OScursor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Sprite loadCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCursor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCursor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe float captureFoV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureFoV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureFoV)) = num;
		}
	}

	public unsafe float captureRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureRange)) = num;
		}
	}

	public unsafe float humanCaptureRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanCaptureRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanCaptureRange)) = num;
		}
	}

	public unsafe float captureInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureInterval)) = num;
		}
	}

	public unsafe int cameraCaptureMemory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCaptureMemory);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCaptureMemory)) = num;
		}
	}

	public unsafe float cameraCaptureMaxTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCaptureMaxTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCaptureMaxTime)) = num;
		}
	}

	public unsafe int maxCapturesPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCapturesPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCapturesPerFrame)) = num;
		}
	}

	public unsafe List<SyncDiskColour> syncDiskColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SyncDiskColour>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int defaultDiskSlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultDiskSlots);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultDiskSlots)) = num;
		}
	}

	public unsafe int mouseWheelEvidenceScrollSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseWheelEvidenceScrollSensitivity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseWheelEvidenceScrollSensitivity)) = num;
		}
	}

	public unsafe float indoorTemperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indoorTemperature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indoorTemperature)) = num;
		}
	}

	public unsafe float airDuctTemperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctTemperature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctTemperature)) = num;
		}
	}

	public unsafe float heatSourceTemperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heatSourceTemperature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heatSourceTemperature)) = num;
		}
	}

	public unsafe AnimationCurve oscillatorX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oscillatorX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oscillatorX)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve oscillatorY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oscillatorY);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oscillatorY)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Vector2 drunkOscillationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillationSpeed);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillationSpeed)) = vector;
		}
	}

	public unsafe AnimationCurve shiverFluctuation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverFluctuation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverFluctuation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Vector2 shiverOscillationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillationSpeed);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillationSpeed)) = vector;
		}
	}

	public unsafe AnimationCurve drunkLensDistortOscillator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistortOscillator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistortOscillator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Vector2 drunkLensDistortSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistortSpeed);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistortSpeed)) = vector;
		}
	}

	public unsafe PlayerTransitionPreset tripTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe AnimationCurve headacheFluctuation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheFluctuation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheFluctuation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe SpatterPatternPreset bleedingSpatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedingSpatter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpatterPatternPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedingSpatter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterPatternPreset));
		}
	}

	public unsafe float fallDamageMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallDamageMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallDamageMultiplier)) = num;
		}
	}

	public unsafe StatusPreset detainedStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detainedStatus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detainedStatus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusPreset));
		}
	}

	public unsafe StatusPreset wantedInBuildingStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wantedInBuildingStatus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wantedInBuildingStatus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusPreset));
		}
	}

	public unsafe float playerHungerRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHungerRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHungerRate)) = num;
		}
	}

	public unsafe float playerThirstRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerThirstRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerThirstRate)) = num;
		}
	}

	public unsafe float playerTirednessRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTirednessRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerTirednessRate)) = num;
		}
	}

	public unsafe float playerEnergyRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerEnergyRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerEnergyRate)) = num;
		}
	}

	public unsafe float combatHitChanceOfBruised
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBruised);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBruised)) = num;
		}
	}

	public unsafe float combatHitChanceOfBlackEye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBlackEye);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBlackEye)) = num;
		}
	}

	public unsafe float combatHitChanceOfBrokenLeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBrokenLeg);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBrokenLeg)) = num;
		}
	}

	public unsafe float combatHitChanceOfBleeding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBleeding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHitChanceOfBleeding)) = num;
		}
	}

	public unsafe Vector2 propertyValueRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyValueRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyValueRange)) = vector;
		}
	}

	public unsafe AnimationCurve propertyValueCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyValueCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyValueCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe int defaultLoanAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultLoanAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultLoanAmount)) = num;
		}
	}

	public unsafe int defaultLoanExtra
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultLoanExtra);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultLoanExtra)) = num;
		}
	}

	public unsafe int defaultLoanRepayment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultLoanRepayment);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultLoanRepayment)) = num;
		}
	}

	public unsafe float loiteringCommentThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringCommentThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringCommentThreshold)) = num;
		}
	}

	public unsafe float loiteringConfrontThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringConfrontThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringConfrontThreshold)) = num;
		}
	}

	public unsafe float loiteringTrespassThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringTrespassThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringTrespassThreshold)) = num;
		}
	}

	public unsafe float loiteringPurchaseResetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringPurchaseResetValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiteringPurchaseResetValue)) = num;
		}
	}

	public unsafe DDSScope humanScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe DDSScope itemScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe DDSScope murderScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe DDSScope locationScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe DDSScope evidenceScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe DDSScope sideJobScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideJobScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideJobScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe DDSScope syncDiskScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe DDSScope groupScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupScope);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSScope>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupScope)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSScope));
		}
	}

	public unsafe static GameplayControls _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameplayControls>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameplayControls));
		}
	}

	public unsafe static GameplayControls Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331418, XrefRangeEnd = 331420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_GameplayControls_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameplayControls>(intPtr) : null;
		}
	}

	static GameplayControls()
	{
		Il2CppClassPointerStore<GameplayControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameplayControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr);
		NativeFieldInfoPtr_intro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "intro");
		NativeFieldInfoPtr_outro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "outro");
		NativeFieldInfoPtr_startingTimeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "startingTimeSpeed");
		NativeFieldInfoPtr_timeMultipliers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "timeMultipliers");
		NativeFieldInfoPtr_startingDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "startingDate");
		NativeFieldInfoPtr_startingMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "startingMonth");
		NativeFieldInfoPtr_startingYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "startingYear");
		NativeFieldInfoPtr_yearZeroLeapYearCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "yearZeroLeapYearCycle");
		NativeFieldInfoPtr_dayZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dayZero");
		NativeFieldInfoPtr_publicYearZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "publicYearZero");
		NativeFieldInfoPtr_routineUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "routineUpdateFrequency");
		NativeFieldInfoPtr_gameWorldUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "gameWorldUpdateFrequency");
		NativeFieldInfoPtr_doorSequenceUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "doorSequenceUpdateFrequency");
		NativeFieldInfoPtr_stealthModeLoopUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "stealthModeLoopUpdateFrequency");
		NativeFieldInfoPtr_playerHeightNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerHeightNormal");
		NativeFieldInfoPtr_playerHeightCrouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerHeightCrouched");
		NativeFieldInfoPtr_crouchHeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "crouchHeightCurve");
		NativeFieldInfoPtr_leanCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "leanCurve");
		NativeFieldInfoPtr_joltCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "joltCurve");
		NativeFieldInfoPtr_cameraHeightNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "cameraHeightNormal");
		NativeFieldInfoPtr_cameraHeightCrouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "cameraHeightCrouched");
		NativeFieldInfoPtr_interactionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "interactionRange");
		NativeFieldInfoPtr_readingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "readingRange");
		NativeFieldInfoPtr_carryDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "carryDistance");
		NativeFieldInfoPtr_throwForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "throwForce");
		NativeFieldInfoPtr_fovNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fovNormal");
		NativeFieldInfoPtr_fovInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fovInteraction");
		NativeFieldInfoPtr_fpsModelLag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fpsModelLag");
		NativeFieldInfoPtr_playerWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerWalkSpeed");
		NativeFieldInfoPtr_playerRunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerRunSpeed");
		NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "jumpHeight");
		NativeFieldInfoPtr_playerStealthWalkMuliplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerStealthWalkMuliplier");
		NativeFieldInfoPtr_playerStealthRunMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerStealthRunMultiplier");
		NativeFieldInfoPtr_headBobMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "headBobMultiplier");
		NativeFieldInfoPtr_ductPlayerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ductPlayerHeight");
		NativeFieldInfoPtr_ductCamHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ductCamHeight");
		NativeFieldInfoPtr_ductPlayerPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ductPlayerPosY");
		NativeFieldInfoPtr_airDuctEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "airDuctEntry");
		NativeFieldInfoPtr_airDuctExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "airDuctExit");
		NativeFieldInfoPtr_normalSkinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "normalSkinWidth");
		NativeFieldInfoPtr_carryingSkinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "carryingSkinWidth");
		NativeFieldInfoPtr_ductSkinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ductSkinWidth");
		NativeFieldInfoPtr_defaultReturnTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "defaultReturnTransition");
		NativeFieldInfoPtr_enterVentTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "enterVentTransition");
		NativeFieldInfoPtr_exitVentTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "exitVentTransition");
		NativeFieldInfoPtr_citizensArrestTranstion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "citizensArrestTranstion");
		NativeFieldInfoPtr_citizenTalkToTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "citizenTalkToTransition");
		NativeFieldInfoPtr_doorPeekEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "doorPeekEnter");
		NativeFieldInfoPtr_doorPeekExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "doorPeekExit");
		NativeFieldInfoPtr_lockpickEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "lockpickEnter");
		NativeFieldInfoPtr_lockpickExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "lockpickExit");
		NativeFieldInfoPtr_sabotageEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sabotageEnter");
		NativeFieldInfoPtr_sabotageExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sabotageExit");
		NativeFieldInfoPtr_bargeDoorEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "bargeDoorEnter");
		NativeFieldInfoPtr_bargeDoorFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "bargeDoorFail");
		NativeFieldInfoPtr_bargeDoorSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "bargeDoorSuccess");
		NativeFieldInfoPtr_punchedReaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "punchedReaction");
		NativeFieldInfoPtr_playerKO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerKO");
		NativeFieldInfoPtr_playerUseComputer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerUseComputer");
		NativeFieldInfoPtr_playerComputerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerComputerExit");
		NativeFieldInfoPtr_playerTakePrint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerTakePrint");
		NativeFieldInfoPtr_playerTakePrintExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerTakePrintExit");
		NativeFieldInfoPtr_playerSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerSearch");
		NativeFieldInfoPtr_playerSearchExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerSearchExit");
		NativeFieldInfoPtr_focusOnInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "focusOnInteractable");
		NativeFieldInfoPtr_waterCoolerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "waterCoolerEnter");
		NativeFieldInfoPtr_dragForceAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dragForceAmount");
		NativeFieldInfoPtr_maxAngleMovementWhenDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "maxAngleMovementWhenDragging");
		NativeFieldInfoPtr_ragdollCarryMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollCarryMaxDistance");
		NativeFieldInfoPtr_ragdollJointPreprocessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollJointPreprocessing");
		NativeFieldInfoPtr_ragdollJointCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollJointCollision");
		NativeFieldInfoPtr_ragdollJointProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollJointProjection");
		NativeFieldInfoPtr_ragdollJointContactDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollJointContactDistance");
		NativeFieldInfoPtr_ragdollRigidbodyCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollRigidbodyCollision");
		NativeFieldInfoPtr_ragdollJointBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollJointBounce");
		NativeFieldInfoPtr_ragdollJointDampen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollJointDampen");
		NativeFieldInfoPtr_ragdollJointSpring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "ragdollJointSpring");
		NativeFieldInfoPtr_dofNormalNearStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofNormalNearStart");
		NativeFieldInfoPtr_dofNormalNearEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofNormalNearEnd");
		NativeFieldInfoPtr_dofNormalFarStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofNormalFarStart");
		NativeFieldInfoPtr_dofNormalFarEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofNormalFarEnd");
		NativeFieldInfoPtr_dofTalkingNearStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofTalkingNearStart");
		NativeFieldInfoPtr_dofTalkingNearEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofTalkingNearEnd");
		NativeFieldInfoPtr_dofTalkingFarStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofTalkingFarStart");
		NativeFieldInfoPtr_dofTalkingFarEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofTalkingFarEnd");
		NativeFieldInfoPtr_dofPausedNearStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofPausedNearStart");
		NativeFieldInfoPtr_dofPausedNearEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofPausedNearEnd");
		NativeFieldInfoPtr_dofPausedFarStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofPausedFarStart");
		NativeFieldInfoPtr_dofPausedFarEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofPausedFarEnd");
		NativeFieldInfoPtr_dofCityEditNearStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofCityEditNearStart");
		NativeFieldInfoPtr_dofCityEditNearEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofCityEditNearEnd");
		NativeFieldInfoPtr_dofCityEditFarStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofCityEditFarStart");
		NativeFieldInfoPtr_dofCityEditFarEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofCityEditFarEnd");
		NativeFieldInfoPtr_dofChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "dofChangeTime");
		NativeFieldInfoPtr_startingItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "startingItems");
		NativeFieldInfoPtr_nothingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "nothingItem");
		NativeFieldInfoPtr_watchItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "watchItem");
		NativeFieldInfoPtr_fistsItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fistsItem");
		NativeFieldInfoPtr_coinItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "coinItem");
		NativeFieldInfoPtr_printReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "printReader");
		NativeFieldInfoPtr_itemSwitchCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "itemSwitchCounter");
		NativeFieldInfoPtr_stealthAmbientLightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "stealthAmbientLightLevel");
		NativeFieldInfoPtr_interiorAmbientLightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "interiorAmbientLightMultiplier");
		NativeFieldInfoPtr_floorLightMeasure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "floorLightMeasure");
		NativeFieldInfoPtr_stealthSunLightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "stealthSunLightLevel");
		NativeFieldInfoPtr_buildingAlarmTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "buildingAlarmTime");
		NativeFieldInfoPtr_securityTrackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "securityTrackSpeed");
		NativeFieldInfoPtr_citizenFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "citizenFOV");
		NativeFieldInfoPtr_securityFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "securityFOV");
		NativeFieldInfoPtr_sabotageLandValueMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sabotageLandValueMP");
		NativeFieldInfoPtr_citizenSightRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "citizenSightRange");
		NativeFieldInfoPtr_securitySightRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "securitySightRange");
		NativeFieldInfoPtr_minimumStealthDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "minimumStealthDetectionRange");
		NativeFieldInfoPtr_sentryGunWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sentryGunWeapon");
		NativeFieldInfoPtr_sentryGunROF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sentryGunROF");
		NativeFieldInfoPtr_sentryGunDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sentryGunDamage");
		NativeFieldInfoPtr_sentryGunAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sentryGunAccuracy");
		NativeFieldInfoPtr_playerMaxSpotDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerMaxSpotDistance");
		NativeFieldInfoPtr_playerSpotUpdateEveryXFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerSpotUpdateEveryXFrame");
		NativeFieldInfoPtr_spottedGraceTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "spottedGraceTime");
		NativeFieldInfoPtr_spottedFadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "spottedFadeSpeed");
		NativeFieldInfoPtr_audioOnlySpotGraceTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "audioOnlySpotGraceTimeMultiplier");
		NativeFieldInfoPtr_playerImageCaptureMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerImageCaptureMaxRange");
		NativeFieldInfoPtr_buildingWantedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "buildingWantedTime");
		NativeFieldInfoPtr_breakerResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "breakerResetTime");
		NativeFieldInfoPtr_securityResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "securityResetTime");
		NativeFieldInfoPtr_gasFillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "gasFillTime");
		NativeFieldInfoPtr_gasEmptyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "gasEmptyTime");
		NativeFieldInfoPtr_additionalEscalationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "additionalEscalationTime");
		NativeFieldInfoPtr_startingMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "startingMoney");
		NativeFieldInfoPtr_startingLockpicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "startingLockpicks");
		NativeFieldInfoPtr_lockpickEffectivenessRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "lockpickEffectivenessRange");
		NativeFieldInfoPtr_lockpickSpeedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "lockpickSpeedRange");
		NativeFieldInfoPtr_bargeDamageRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "bargeDamageRange");
		NativeFieldInfoPtr_baseMaxPlayerHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "baseMaxPlayerHealth");
		NativeFieldInfoPtr_playerRecoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerRecoveryRate");
		NativeFieldInfoPtr_playerCombatSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerCombatSkill");
		NativeFieldInfoPtr_playerCombatHeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerCombatHeft");
		NativeFieldInfoPtr_defaultInventorySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "defaultInventorySlots");
		NativeFieldInfoPtr_incomingPlayerPhysicsDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "incomingPlayerPhysicsDamageMultiplier");
		NativeFieldInfoPtr_commonSyncDisksPer200Citizens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "commonSyncDisksPer200Citizens");
		NativeFieldInfoPtr_mediumSyncDisksPer200Citizens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "mediumSyncDisksPer200Citizens");
		NativeFieldInfoPtr_rareSyncDisksPer200Citizens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "rareSyncDisksPer200Citizens");
		NativeFieldInfoPtr_veryRareSyncDisksPer200Citizens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "veryRareSyncDisksPer200Citizens");
		NativeFieldInfoPtr_corpSabotageMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "corpSabotageMoney");
		NativeFieldInfoPtr_corpSabotageManagementBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "corpSabotageManagementBonus");
		NativeFieldInfoPtr_moneyForAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "moneyForAddresses");
		NativeFieldInfoPtr_moneyForNewLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "moneyForNewLocations");
		NativeFieldInfoPtr_moneyForAirDucts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "moneyForAirDucts");
		NativeFieldInfoPtr_moneyForPasscodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "moneyForPasscodes");
		NativeFieldInfoPtr_moneyForReading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "moneyForReading");
		NativeFieldInfoPtr_moneyForStreetCleaning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "moneyForStreetCleaning");
		NativeFieldInfoPtr_passiveIncome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "passiveIncome");
		NativeFieldInfoPtr_upgradeHeightModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "upgradeHeightModifier");
		NativeFieldInfoPtr_upgradeRunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "upgradeRunSpeed");
		NativeFieldInfoPtr_upgradeReach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "upgradeReach");
		NativeFieldInfoPtr_upgradeHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "upgradeHealth");
		NativeFieldInfoPtr_upgradeRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "upgradeRegen");
		NativeFieldInfoPtr_legalInsuranceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "legalInsuranceMultiplier");
		NativeFieldInfoPtr_socialCreditForLostAndFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "socialCreditForLostAndFound");
		NativeFieldInfoPtr_socialCreditForSideJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "socialCreditForSideJobs");
		NativeFieldInfoPtr_socialCreditForMurders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "socialCreditForMurders");
		NativeFieldInfoPtr_socialCreditLevelCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "socialCreditLevelCurve");
		NativeFieldInfoPtr_foodHotTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "foodHotTime");
		NativeFieldInfoPtr_timeOfDeathAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "timeOfDeathAccuracy");
		NativeFieldInfoPtr_retailItemSoldDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "retailItemSoldDiscovery");
		NativeFieldInfoPtr_retailItemNoSoldDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "retailItemNoSoldDiscovery");
		NativeFieldInfoPtr_fistMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fistMaterial");
		NativeFieldInfoPtr_fingerUpperMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fingerUpperMaterial");
		NativeFieldInfoPtr_fingerLowerMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fingerLowerMaterial");
		NativeFieldInfoPtr_fingerTipMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fingerTipMaterial");
		NativeFieldInfoPtr_thumbJointMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "thumbJointMaterial");
		NativeFieldInfoPtr_interpolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "interpolation");
		NativeFieldInfoPtr_physicsOffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "physicsOffTime");
		NativeFieldInfoPtr_defaultObjectPhysicsProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "defaultObjectPhysicsProfile");
		NativeFieldInfoPtr_binTrashLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "binTrashLimit");
		NativeFieldInfoPtr_buildingCallLogMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "buildingCallLogMax");
		NativeFieldInfoPtr_preSimSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "preSimSpeedMultiplier");
		NativeFieldInfoPtr_walletCashAmountBasedOnWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "walletCashAmountBasedOnWealth");
		NativeFieldInfoPtr_creditCardTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "creditCardTrait");
		NativeFieldInfoPtr_donorCardTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "donorCardTrait");
		NativeFieldInfoPtr_successfulBlockThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "successfulBlockThreshold");
		NativeFieldInfoPtr_perfectBlockThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "perfectBlockThreshold");
		NativeFieldInfoPtr_baseAttackDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "baseAttackDelay");
		NativeFieldInfoPtr_blockedAttackDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "blockedAttackDelay");
		NativeFieldInfoPtr_perfectBlockAttackDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "perfectBlockAttackDelay");
		NativeFieldInfoPtr_koTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "koTimeRange");
		NativeFieldInfoPtr_playerKOPunchForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerKOPunchForce");
		NativeFieldInfoPtr_koTimePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "koTimePass");
		NativeFieldInfoPtr_restrainedTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "restrainedTimer");
		NativeFieldInfoPtr_takedownTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "takedownTimer");
		NativeFieldInfoPtr_thrownGrenadeFuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "thrownGrenadeFuse");
		NativeFieldInfoPtr_proxyGrenadeFuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "proxyGrenadeFuse");
		NativeFieldInfoPtr_bloodAmountMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "bloodAmountMultiplier");
		NativeFieldInfoPtr_successfulBlockTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "successfulBlockTransition");
		NativeFieldInfoPtr_unsuccessfulBlockTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "unsuccessfulBlockTransition");
		NativeFieldInfoPtr_counterTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "counterTransition");
		NativeFieldInfoPtr_maxPlayerLookAtTailingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "maxPlayerLookAtTailingDistance");
		NativeFieldInfoPtr_playerLookAtSpookRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerLookAtSpookRate");
		NativeFieldInfoPtr_loseSpookedRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "loseSpookedRate");
		NativeFieldInfoPtr_screenCentreSpookCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "screenCentreSpookCurve");
		NativeFieldInfoPtr_muggingChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "muggingChance");
		NativeFieldInfoPtr_spatterRemovalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "spatterRemovalTime");
		NativeFieldInfoPtr_objectPositionResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "objectPositionResetTime");
		NativeFieldInfoPtr_brokenWindowBoardTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "brokenWindowBoardTime");
		NativeFieldInfoPtr_brokenWindowResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "brokenWindowResetTime");
		NativeFieldInfoPtr_breakingWindowsFine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "breakingWindowsFine");
		NativeFieldInfoPtr_vandalismFineMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "vandalismFineMultiplier");
		NativeFieldInfoPtr_vandalismTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "vandalismTimeout");
		NativeFieldInfoPtr_illegalActionMinimumTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "illegalActionMinimumTime");
		NativeFieldInfoPtr_tamperGrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "tamperGrace");
		NativeFieldInfoPtr_physicsTamperDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "physicsTamperDistance");
		NativeFieldInfoPtr_fignerprintPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fignerprintPreset");
		NativeFieldInfoPtr_detainDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "detainDelay");
		NativeFieldInfoPtr_caseResultProcessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "caseResultProcessTime");
		NativeFieldInfoPtr_bestCaseVictimCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "bestCaseVictimCount");
		NativeFieldInfoPtr_worstCaseVictimCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "worstCaseVictimCount");
		NativeFieldInfoPtr_sideJobDifficultyRewardMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sideJobDifficultyRewardMultiplier");
		NativeFieldInfoPtr_secretLocationFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "secretLocationFurniture");
		NativeFieldInfoPtr_stealTriggerChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "stealTriggerChance");
		NativeFieldInfoPtr_maxCases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "maxCases");
		NativeFieldInfoPtr_crimeSceneCleanupDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "crimeSceneCleanupDelay");
		NativeFieldInfoPtr_missionPhotoMinMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "missionPhotoMinMaxDistance");
		NativeFieldInfoPtr_missionPhotoDistanceScoreCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "missionPhotoDistanceScoreCurve");
		NativeFieldInfoPtr_enableCoverUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "enableCoverUps");
		NativeFieldInfoPtr_coverUpAvailableDuringCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "coverUpAvailableDuringCase");
		NativeFieldInfoPtr_coverUpChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "coverUpChance");
		NativeFieldInfoPtr_coverUpReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "coverUpReward");
		NativeFieldInfoPtr_coverUpDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "coverUpDelayTime");
		NativeFieldInfoPtr_maximumFootprintsPerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "maximumFootprintsPerRoom");
		NativeFieldInfoPtr_footprintScaleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "footprintScaleRange");
		NativeFieldInfoPtr_stepDirtRemoval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "stepDirtRemoval");
		NativeFieldInfoPtr_stepBloodRemoval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "stepBloodRemoval");
		NativeFieldInfoPtr_outdoorStepDirtAccumulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "outdoorStepDirtAccumulation");
		NativeFieldInfoPtr_footprintPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "footprintPreset");
		NativeFieldInfoPtr_crimeSceneSearchLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "crimeSceneSearchLength");
		NativeFieldInfoPtr_crimeSceneLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "crimeSceneLength");
		NativeFieldInfoPtr_smellTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "smellTime");
		NativeFieldInfoPtr_murderResolveQuestions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "murderResolveQuestions");
		NativeFieldInfoPtr_retirementResolveQuestions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "retirementResolveQuestions");
		NativeFieldInfoPtr_kidnapperCallTriggerDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "kidnapperCallTriggerDialog");
		NativeFieldInfoPtr_OScursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "OScursor");
		NativeFieldInfoPtr_loadCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "loadCursor");
		NativeFieldInfoPtr_captureFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "captureFoV");
		NativeFieldInfoPtr_captureRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "captureRange");
		NativeFieldInfoPtr_humanCaptureRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "humanCaptureRange");
		NativeFieldInfoPtr_captureInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "captureInterval");
		NativeFieldInfoPtr_cameraCaptureMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "cameraCaptureMemory");
		NativeFieldInfoPtr_cameraCaptureMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "cameraCaptureMaxTime");
		NativeFieldInfoPtr_maxCapturesPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "maxCapturesPerFrame");
		NativeFieldInfoPtr_syncDiskColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "syncDiskColours");
		NativeFieldInfoPtr_defaultDiskSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "defaultDiskSlots");
		NativeFieldInfoPtr_mouseWheelEvidenceScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "mouseWheelEvidenceScrollSensitivity");
		NativeFieldInfoPtr_indoorTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "indoorTemperature");
		NativeFieldInfoPtr_airDuctTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "airDuctTemperature");
		NativeFieldInfoPtr_heatSourceTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "heatSourceTemperature");
		NativeFieldInfoPtr_oscillatorX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "oscillatorX");
		NativeFieldInfoPtr_oscillatorY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "oscillatorY");
		NativeFieldInfoPtr_drunkOscillationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "drunkOscillationSpeed");
		NativeFieldInfoPtr_shiverFluctuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "shiverFluctuation");
		NativeFieldInfoPtr_shiverOscillationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "shiverOscillationSpeed");
		NativeFieldInfoPtr_drunkLensDistortOscillator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "drunkLensDistortOscillator");
		NativeFieldInfoPtr_drunkLensDistortSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "drunkLensDistortSpeed");
		NativeFieldInfoPtr_tripTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "tripTransition");
		NativeFieldInfoPtr_headacheFluctuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "headacheFluctuation");
		NativeFieldInfoPtr_bleedingSpatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "bleedingSpatter");
		NativeFieldInfoPtr_fallDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "fallDamageMultiplier");
		NativeFieldInfoPtr_detainedStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "detainedStatus");
		NativeFieldInfoPtr_wantedInBuildingStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "wantedInBuildingStatus");
		NativeFieldInfoPtr_playerHungerRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerHungerRate");
		NativeFieldInfoPtr_playerThirstRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerThirstRate");
		NativeFieldInfoPtr_playerTirednessRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerTirednessRate");
		NativeFieldInfoPtr_playerEnergyRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "playerEnergyRate");
		NativeFieldInfoPtr_combatHitChanceOfBruised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "combatHitChanceOfBruised");
		NativeFieldInfoPtr_combatHitChanceOfBlackEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "combatHitChanceOfBlackEye");
		NativeFieldInfoPtr_combatHitChanceOfBrokenLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "combatHitChanceOfBrokenLeg");
		NativeFieldInfoPtr_combatHitChanceOfBleeding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "combatHitChanceOfBleeding");
		NativeFieldInfoPtr_propertyValueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "propertyValueRange");
		NativeFieldInfoPtr_propertyValueCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "propertyValueCurve");
		NativeFieldInfoPtr_defaultLoanAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "defaultLoanAmount");
		NativeFieldInfoPtr_defaultLoanExtra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "defaultLoanExtra");
		NativeFieldInfoPtr_defaultLoanRepayment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "defaultLoanRepayment");
		NativeFieldInfoPtr_loiteringCommentThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "loiteringCommentThreshold");
		NativeFieldInfoPtr_loiteringConfrontThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "loiteringConfrontThreshold");
		NativeFieldInfoPtr_loiteringTrespassThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "loiteringTrespassThreshold");
		NativeFieldInfoPtr_loiteringPurchaseResetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "loiteringPurchaseResetValue");
		NativeFieldInfoPtr_humanScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "humanScope");
		NativeFieldInfoPtr_itemScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "itemScope");
		NativeFieldInfoPtr_murderScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "murderScope");
		NativeFieldInfoPtr_locationScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "locationScope");
		NativeFieldInfoPtr_evidenceScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "evidenceScope");
		NativeFieldInfoPtr_sideJobScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "sideJobScope");
		NativeFieldInfoPtr_syncDiskScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "syncDiskScope");
		NativeFieldInfoPtr_groupScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "groupScope");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_GameplayControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, 100674104);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, 100674105);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, 100674106);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr, 100674107);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331420, XrefRangeEnd = 331458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331458, XrefRangeEnd = 331479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331479, XrefRangeEnd = 331517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameplayControls()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayControls>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameplayControls(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
