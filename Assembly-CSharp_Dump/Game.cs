using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using UnityEngine;
using UnityEngine.Rendering;

public class Game : MonoBehaviour
{
	public enum BuildConfig
	{
		PCSteam,
		PCEpic,
		PCGog,
		PCMicrosoftStore,
		PCNoStorefrontFeatures,
		ConsolePlaystation5,
		ConsoleXboxSeriesS,
		ConsoleXboxSeriesX
	}

	[System.Serializable]
	public class DebugCitizenWeapons : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_weapon;

		private static readonly System.IntPtr NativeFieldInfoPtr_count;

		private static readonly System.IntPtr NativeFieldInfoPtr_percentage;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe MurderWeaponPreset weapon
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MurderWeaponPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)murderWeaponPreset));
			}
		}

		public unsafe int count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
			}
		}

		public unsafe float percentage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_percentage);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_percentage)) = num;
			}
		}

		static DebugCitizenWeapons()
		{
			Il2CppClassPointerStore<DebugCitizenWeapons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, "DebugCitizenWeapons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugCitizenWeapons>.NativeClassPtr);
			NativeFieldInfoPtr_weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCitizenWeapons>.NativeClassPtr, "weapon");
			NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCitizenWeapons>.NativeClassPtr, "count");
			NativeFieldInfoPtr_percentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCitizenWeapons>.NativeClassPtr, "percentage");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCitizenWeapons>.NativeClassPtr, 100667908);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugCitizenWeapons()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugCitizenWeapons>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DebugCitizenWeapons(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("Game+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__267_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__317_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__333_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__335_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetDepthBlur_b__267_0_Internal_Boolean_GameSetting_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Base26Test_b__317_0_Internal_Char_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__MissionPhotoTest_b__333_1_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TeleportPlayerStreetStart_b__335_0_Internal_Boolean_StreetController_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Predicate<PlayerPrefsController.GameSetting> __9__267_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__267_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<PlayerPrefsController.GameSetting>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__267_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Func<int, char> __9__317_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__317_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int, char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__317_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Interactable> __9__333_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__333_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__333_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<StreetController> __9__335_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__335_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<StreetController>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__335_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__267_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__267_0");
			NativeFieldInfoPtr___9__317_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__317_0");
			NativeFieldInfoPtr___9__333_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__333_1");
			NativeFieldInfoPtr___9__335_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__335_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667910);
			NativeMethodInfoPtr__SetDepthBlur_b__267_0_Internal_Boolean_GameSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667911);
			NativeMethodInfoPtr__Base26Test_b__317_0_Internal_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667912);
			NativeMethodInfoPtr__MissionPhotoTest_b__333_1_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667913);
			NativeMethodInfoPtr__TeleportPlayerStreetStart_b__335_0_Internal_Boolean_StreetController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667914);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151356, XrefRangeEnd = 151359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetDepthBlur_b__267_0(PlayerPrefsController.GameSetting item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetDepthBlur_b__267_0_Internal_Boolean_GameSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe char _Base26Test_b__317_0(int s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&s);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Base26Test_b__317_0_Internal_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151359, XrefRangeEnd = 151390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _MissionPhotoTest_b__333_1(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MissionPhotoTest_b__333_1_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151390, XrefRangeEnd = 151393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TeleportPlayerStreetStart_b__335_0(StreetController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TeleportPlayerStreetStart_b__335_0_Internal_Boolean_StreetController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_buildID;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_customTags;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamScriptPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateAbove;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCompatibleCities;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildConfiguration;

	private static readonly System.IntPtr NativeFieldInfoPtr_autodetectBuildConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceLowEndHardware;

	private static readonly System.IntPtr NativeFieldInfoPtr_devMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_printDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysPrintErrors;

	private static readonly System.IntPtr NativeFieldInfoPtr_collectDebugData;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugPrintLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableBugReporting;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceEnglish;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipIntro;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowMods;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceMediumCitiesOnConsole;

	private static readonly System.IntPtr NativeFieldInfoPtr_ensureItemNamesInDictionaries;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLowEndHardware;

	private static readonly System.IntPtr NativeFieldInfoPtr_boostMinimumFontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeOnConsoleVersions;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeLimited;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTimerAfterApartmentExit;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseTimerOnGamePause;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSaveLoadGames;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSandbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableCityGeneration;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallCitiesOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayBetaMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSaveGameCompression;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveGameCompressionQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCityDataCompression;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityDataCompressionQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxThreads;

	private static readonly System.IntPtr NativeFieldInfoPtr_writeUnfoundToTextFiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_sandboxMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadChapter;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateMovementEveryFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultSaturationAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayExtraControlHints;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectiveMarkers;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficultyIncomingDamageMultipliers;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameLengthMaxLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceSideJobDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedJobDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_resumeAfterPin;

	private static readonly System.IntPtr NativeFieldInfoPtr_closeInteractionsOnResume;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDirectionalArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_sandboxStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableMurdererInSandbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherChangeFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableTrespass;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugMurdererOnStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_demoChapterSkip;

	private static readonly System.IntPtr NativeFieldInfoPtr_demoMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_allHospitalAccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoPause;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoPauseSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_demoAutoReset;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetChapterPart;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetSaveGameName;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableCaseBoardClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowLicensedMusic;

	private static readonly System.IntPtr NativeFieldInfoPtr_overridePasscodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_overriddenPasscode;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDeltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_aaMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPasscode;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDiskSavedCaptures;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_coldStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_smellyStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_headacheStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_tiredStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_hungerStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_hydrationStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_numbStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_bleedingStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_wetStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_sickStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_starchAddictionEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisonStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_blindedStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_energizedStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_hydratedStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_focusedStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_wellRestedStatusEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_virtualCursorSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_axisMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlAutoSwitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseSmoothing;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerSmoothing;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFeedbackMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerFirstName;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSurname;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerGender;

	private static readonly System.IntPtr NativeFieldInfoPtr_partnerGender;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSkinColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBirthDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBirthMonth;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBirthYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_language;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordCountTotal;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayStreetChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayStreetAndJunctionChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayTrafficSimulationResults;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugtrafficSimMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayStreets;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugStreetMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_streetDebugColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugDisplayRoads;

	private static readonly System.IntPtr NativeFieldInfoPtr_keysToTheCity;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCullingDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCityEditor;

	private static readonly System.IntPtr NativeFieldInfoPtr_collectRoutineTimingInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_guessAverageOnTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_guessDataEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_guessEarlyPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_guessLatePercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_guessCumulativeOnTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_guessEarlyEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_guessLateEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_boundaries;

	private static readonly System.IntPtr NativeFieldInfoPtr_noReactOnAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugPathfinding;

	private static readonly System.IntPtr NativeFieldInfoPtr_useJobSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_useExternalRouteCaching;

	private static readonly System.IntPtr NativeFieldInfoPtr_useInternalRouteCaching;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceStreetPathsOnMainThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlimitedPathCaching;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxExternalCachedPaths;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxInternalCachedPaths;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxStreetCachedPaths;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicReRouting;

	private static readonly System.IntPtr NativeFieldInfoPtr_pathfinderDebugLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_discoverAllEvidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_discoverAllRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDrawnMapIcons;

	private static readonly System.IntPtr NativeFieldInfoPtr_everywhereIllegal;

	private static readonly System.IntPtr NativeFieldInfoPtr_invisiblePlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_inaudiblePlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_invinciblePlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_routeTeleport;

	private static readonly System.IntPtr NativeFieldInfoPtr_giveAllUpgrades;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableFallDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseAI;

	private static readonly System.IntPtr NativeFieldInfoPtr_freeCam;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastForward;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSurvivalStatusesInStory;

	private static readonly System.IntPtr NativeFieldInfoPtr_sandboxStartingApartment;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerFixedPasscode;

	private static readonly System.IntPtr NativeFieldInfoPtr_sandboxStartingMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_sandboxStartingLockpicks;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferredStartingBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_toggleRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_permaDeath;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoTravelPause;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowEchelons;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowLoitering;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowAutoTravel;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowSocialCreditPerks;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowDraggableRagdolls;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceCoverUpOffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableColesFallingThroughFloorCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcePlayerTaunts;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSimplifiedKillerMonikers;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnBasBouleCards;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobRewardMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobPenaltyMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_housePriceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_noShadowsWhenPlayerIsInDifferentGoundmapLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableRaindrops;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableRainyWindows;

	private static readonly System.IntPtr NativeFieldInfoPtr_fov;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthBlur;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionBlurIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionBlurGameSpeedModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloomIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowsOnCitizenLOD;

	private static readonly System.IntPtr NativeFieldInfoPtr_vsync;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFrameCap;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameCap;

	private static readonly System.IntPtr NativeFieldInfoPtr_flickeringLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableRuntimeStaticBatching;

	private static readonly System.IntPtr NativeFieldInfoPtr_useQuadsForFootprints;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCustomLightCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableNewRealtimeTimeCullingSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_generateCullingInGame;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenSpaceReflection;

	private static readonly System.IntPtr NativeFieldInfoPtr_hyperacusisFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_bassReduction;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightFadeDistanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowFadeDistanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunShadowUpdateFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastShadowsUpdatedCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideLightControllerShadowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowModeOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicShadowUpdateFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxUpdateDynamicShadowsPerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_combineAirDuctMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_combineRoomMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomWallShadowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomFloorShadowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomCeilingShadowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_airDuctShadowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_useJobSystemForMeshCombination;

	private static readonly System.IntPtr NativeFieldInfoPtr_optimizeCombinedMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoWeldVertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordByWordText;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectCitizenOnLookAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_base26Test;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenshotMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenshotModeAllowDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugHuman;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugHumanMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugHumanActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugHumanAttacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugHumanUpdates;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugHumanMisc;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugHumanSight;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugFindWall;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugAddressID;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugCitizenID;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugPhotoTestID;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugTestWeapon;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugWeaponsSurvey;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_WordCount_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScreenshotMode_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Game_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOnTimeEntry_Public_Void_Actor_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AIInAddressFullyRested_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AIInAddressNeedShower_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AIInAddressNeedFun_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugButton_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetRoutineCollectionData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRandomCitizenToAwareness_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceEnableMovement_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRaindrops_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRainWindows_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFOV_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetObjectiveMarkers_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDirectionalArrow_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAwarenessIndicator_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDepthBlur_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSandboxStartTime_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGameDifficulty_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGameLength_Public_Void_Int32_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableColdStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableSmellyStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableHeadacheStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableBleedingStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableInjuryStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableHungerStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableHydrationStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableWetStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableSickStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableNumbStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableTiredStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableDrunkStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableEnergizedStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableHydratedStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableFocusedStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableWellRestedStatus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSandboxStartingApartment_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFixedPasscode_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSandboxStartingMoney_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSandboxStartingLockpicks_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForceSideJobDifficulty_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForcedSideJobDifficulty_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPauseAI_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFreeCamMode_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFastForward_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDrawDistance_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLightDistance_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMurders_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUIScale_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAAMode_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAAQuality_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDithering_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVsync_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnableFrameCap_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFrameCap_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPasscodeOverrideToggle_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPasscodeOverride_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFlickingLights_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAllowLicensedMusic_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScreenSpaceReflection_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHyperacusisFilter_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBassReduction_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerPasscode_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerPasscodeDigits_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Base26Test_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Give1000Crows_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Give100Lockpicks_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetHealth_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KOPlayer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestCurrentDetainedStatus_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VictimsRankTest_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveAllUpgrades_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveSocialCredit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteSideJob_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayAnswersToCurrentSideJob_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBuildValueChanged_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugFindWall_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugAddressID_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugCitizenID_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShotgunTest_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MissionPhotoTest_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindProsthetics_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TeleportPlayerStreetStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleCitizenColliders_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveRandomJolt_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TripPlayer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestTimeRange_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeletePlayerPrefs_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeletePlayerPrefsConfirm_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeletePlayerPrefsCancel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForcePlayerDirtyDeath_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnOffAllDynamicOcclusion_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnOffAllLODS_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShootFromPlayer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListSelfEmployed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExportGameContentLists_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__DebugAddressID_b__330_0_Private_Boolean_NewAddress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__DebugCitizenID_b__331_0_Private_Boolean_Citizen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__MissionPhotoTest_b__333_0_Private_Boolean_Interactable_0;

	public unsafe string buildID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string buildDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildDescription);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string customTags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customTags);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customTags)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string steamScriptPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamScriptPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamScriptPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool updateAbove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAbove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAbove)) = flag;
		}
	}

	public unsafe string lastCompatibleCities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCompatibleCities);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCompatibleCities)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe BuildConfig buildConfiguration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildConfiguration);
			return *(BuildConfig*)num;
		}
		set
		{
			*(BuildConfig*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildConfiguration)) = buildConfig;
		}
	}

	public unsafe bool autodetectBuildConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autodetectBuildConfig);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autodetectBuildConfig)) = flag;
		}
	}

	public unsafe bool forceLowEndHardware
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLowEndHardware);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceLowEndHardware)) = flag;
		}
	}

	public unsafe bool devMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_devMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_devMode)) = flag;
		}
	}

	public unsafe bool printDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printDebug)) = flag;
		}
	}

	public unsafe bool alwaysPrintErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysPrintErrors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysPrintErrors)) = flag;
		}
	}

	public unsafe bool collectDebugData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectDebugData);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectDebugData)) = flag;
		}
	}

	public unsafe int debugPrintLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPrintLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPrintLevel)) = num;
		}
	}

	public unsafe bool enableBugReporting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableBugReporting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableBugReporting)) = flag;
		}
	}

	public unsafe bool forceEnglish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceEnglish);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceEnglish)) = flag;
		}
	}

	public unsafe bool skipIntro
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIntro);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIntro)) = flag;
		}
	}

	public unsafe bool allowMods
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMods);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMods)) = flag;
		}
	}

	public unsafe bool forceMediumCitiesOnConsole
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMediumCitiesOnConsole);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceMediumCitiesOnConsole)) = flag;
		}
	}

	public unsafe bool ensureItemNamesInDictionaries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ensureItemNamesInDictionaries);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ensureItemNamesInDictionaries)) = flag;
		}
	}

	public unsafe bool isLowEndHardware
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLowEndHardware);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLowEndHardware)) = flag;
		}
	}

	public unsafe bool boostMinimumFontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boostMinimumFontSize);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boostMinimumFontSize)) = flag;
		}
	}

	public unsafe List<GameObject> removeOnConsoleVersions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeOnConsoleVersions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeOnConsoleVersions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool timeLimited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimited)) = flag;
		}
	}

	public unsafe float timeLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimit)) = num;
		}
	}

	public unsafe bool startTimerAfterApartmentExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTimerAfterApartmentExit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTimerAfterApartmentExit)) = flag;
		}
	}

	public unsafe bool pauseTimerOnGamePause
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseTimerOnGamePause);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseTimerOnGamePause)) = flag;
		}
	}

	public unsafe bool disableSaveLoadGames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSaveLoadGames);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSaveLoadGames)) = flag;
		}
	}

	public unsafe bool disableSandbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSandbox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSandbox)) = flag;
		}
	}

	public unsafe bool disableCityGeneration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableCityGeneration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableCityGeneration)) = flag;
		}
	}

	public unsafe bool smallCitiesOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallCitiesOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallCitiesOnly)) = flag;
		}
	}

	public unsafe bool displayBetaMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayBetaMessage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayBetaMessage)) = flag;
		}
	}

	public unsafe bool useSaveGameCompression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSaveGameCompression);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSaveGameCompression)) = flag;
		}
	}

	public unsafe int saveGameCompressionQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveGameCompressionQuality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveGameCompressionQuality)) = num;
		}
	}

	public unsafe bool useCityDataCompression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCityDataCompression);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCityDataCompression)) = flag;
		}
	}

	public unsafe int cityDataCompressionQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityDataCompressionQuality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityDataCompressionQuality)) = num;
		}
	}

	public unsafe int maxThreads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxThreads);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxThreads)) = num;
		}
	}

	public unsafe bool writeUnfoundToTextFiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeUnfoundToTextFiles);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeUnfoundToTextFiles)) = flag;
		}
	}

	public unsafe bool sandboxMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxMode)) = flag;
		}
	}

	public unsafe int loadChapter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadChapter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadChapter)) = num;
		}
	}

	public unsafe bool updateMovementEveryFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMovementEveryFrame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMovementEveryFrame)) = flag;
		}
	}

	public unsafe float defaultSaturationAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSaturationAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSaturationAmount)) = num;
		}
	}

	public unsafe bool displayExtraControlHints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayExtraControlHints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayExtraControlHints)) = flag;
		}
	}

	public unsafe bool objectiveMarkers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveMarkers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveMarkers)) = flag;
		}
	}

	public unsafe int gameDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameDifficulty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameDifficulty)) = num;
		}
	}

	public unsafe List<float> difficultyIncomingDamageMultipliers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyIncomingDamageMultipliers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyIncomingDamageMultipliers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int gameLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLength)) = num;
		}
	}

	public unsafe List<int> gameLengthMaxLevels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLengthMaxLevels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLengthMaxLevels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool forceSideJobDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSideJobDifficulty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSideJobDifficulty)) = flag;
		}
	}

	public unsafe int forcedJobDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedJobDifficulty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedJobDifficulty)) = num;
		}
	}

	public unsafe bool resumeAfterPin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resumeAfterPin);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resumeAfterPin)) = flag;
		}
	}

	public unsafe bool closeInteractionsOnResume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeInteractionsOnResume);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeInteractionsOnResume)) = flag;
		}
	}

	public unsafe bool enableDirectionalArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDirectionalArrow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDirectionalArrow)) = flag;
		}
	}

	public unsafe float sandboxStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartTime)) = num;
		}
	}

	public unsafe bool enableMurdererInSandbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMurdererInSandbox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMurdererInSandbox)) = flag;
		}
	}

	public unsafe float weatherChangeFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherChangeFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherChangeFrequency)) = num;
		}
	}

	public unsafe bool disableSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSnow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSnow)) = flag;
		}
	}

	public unsafe bool disableTrespass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableTrespass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableTrespass)) = flag;
		}
	}

	public unsafe bool debugMurdererOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMurdererOnStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMurdererOnStart)) = flag;
		}
	}

	public unsafe bool demoChapterSkip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demoChapterSkip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demoChapterSkip)) = flag;
		}
	}

	public unsafe bool demoMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demoMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demoMode)) = flag;
		}
	}

	public unsafe bool allHospitalAccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allHospitalAccess);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allHospitalAccess)) = flag;
		}
	}

	public unsafe bool autoPause
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPause);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPause)) = flag;
		}
	}

	public unsafe int autoPauseSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPauseSeconds);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPauseSeconds)) = num;
		}
	}

	public unsafe bool demoAutoReset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demoAutoReset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demoAutoReset)) = flag;
		}
	}

	public unsafe int resetSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSeconds);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSeconds)) = num;
		}
	}

	public unsafe int resetChapterPart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetChapterPart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetChapterPart)) = num;
		}
	}

	public unsafe string resetSaveGameName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSaveGameName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSaveGameName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float textSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpeed)) = num;
		}
	}

	public unsafe bool disableCaseBoardClose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableCaseBoardClose);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableCaseBoardClose)) = flag;
		}
	}

	public unsafe bool allowLicensedMusic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLicensedMusic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLicensedMusic)) = flag;
		}
	}

	public unsafe bool overridePasscodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridePasscodes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridePasscodes)) = flag;
		}
	}

	public unsafe int overriddenPasscode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overriddenPasscode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overriddenPasscode)) = num;
		}
	}

	public unsafe float maxDeltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDeltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDeltaTime)) = num;
		}
	}

	public unsafe int aaMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aaMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aaMode)) = num;
		}
	}

	public unsafe int playerPasscode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPasscode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPasscode)) = num;
		}
	}

	public unsafe bool enableDiskSavedCaptures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDiskSavedCaptures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDiskSavedCaptures)) = flag;
		}
	}

	public unsafe Thread mainThread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainThread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainThread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe bool coldStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coldStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coldStatusEnabled)) = flag;
		}
	}

	public unsafe bool smellyStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smellyStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smellyStatusEnabled)) = flag;
		}
	}

	public unsafe bool headacheStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheStatusEnabled)) = flag;
		}
	}

	public unsafe bool injuryStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryStatusEnabled)) = flag;
		}
	}

	public unsafe bool tiredStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiredStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiredStatusEnabled)) = flag;
		}
	}

	public unsafe bool hungerStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerStatusEnabled)) = flag;
		}
	}

	public unsafe bool hydrationStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydrationStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydrationStatusEnabled)) = flag;
		}
	}

	public unsafe bool numbStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numbStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numbStatusEnabled)) = flag;
		}
	}

	public unsafe bool bleedingStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedingStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedingStatusEnabled)) = flag;
		}
	}

	public unsafe bool wetStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wetStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wetStatusEnabled)) = flag;
		}
	}

	public unsafe bool sickStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sickStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sickStatusEnabled)) = flag;
		}
	}

	public unsafe bool drunkStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkStatusEnabled)) = flag;
		}
	}

	public unsafe bool starchAddictionEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddictionEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddictionEnabled)) = flag;
		}
	}

	public unsafe bool poisonStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisonStatusEnabled)) = flag;
		}
	}

	public unsafe bool blindedStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindedStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindedStatusEnabled)) = flag;
		}
	}

	public unsafe bool energizedStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energizedStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energizedStatusEnabled)) = flag;
		}
	}

	public unsafe bool hydratedStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydratedStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydratedStatusEnabled)) = flag;
		}
	}

	public unsafe bool focusedStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusedStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusedStatusEnabled)) = flag;
		}
	}

	public unsafe bool wellRestedStatusEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRestedStatusEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRestedStatusEnabled)) = flag;
		}
	}

	public unsafe Vector2 mouseSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivity)) = vector;
		}
	}

	public unsafe Vector2 controllerSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerSensitivity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerSensitivity)) = vector;
		}
	}

	public unsafe float virtualCursorSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualCursorSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualCursorSensitivity)) = num;
		}
	}

	public unsafe Vector2 axisMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisMP);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisMP)) = vector;
		}
	}

	public unsafe bool controlAutoSwitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlAutoSwitch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlAutoSwitch)) = flag;
		}
	}

	public unsafe int mouseSmoothing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSmoothing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSmoothing)) = num;
		}
	}

	public unsafe int controllerSmoothing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerSmoothing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerSmoothing)) = num;
		}
	}

	public unsafe float movementSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeed)) = num;
		}
	}

	public unsafe int scrollSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollSensitivity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollSensitivity)) = num;
		}
	}

	public unsafe float forceFeedbackMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFeedbackMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFeedbackMultiplier)) = num;
		}
	}

	public unsafe string playerFirstName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFirstName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFirstName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string playerSurname
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSurname);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSurname)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Human.Gender playerGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGender);
			return *(Human.Gender*)num;
		}
		set
		{
			*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGender)) = gender;
		}
	}

	public unsafe Human.Gender partnerGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partnerGender);
			return *(Human.Gender*)num;
		}
		set
		{
			*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partnerGender)) = gender;
		}
	}

	public unsafe Color playerSkinColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSkinColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSkinColour)) = color;
		}
	}

	public unsafe int playerBirthDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthDay)) = num;
		}
	}

	public unsafe int playerBirthMonth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthMonth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthMonth)) = num;
		}
	}

	public unsafe int playerBirthYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthYear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthYear)) = num;
		}
	}

	public unsafe string language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_language);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_language)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int wordCountTotal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordCountTotal);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordCountTotal)) = num;
		}
	}

	public unsafe bool displayStreetChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayStreetChunks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayStreetChunks)) = flag;
		}
	}

	public unsafe bool displayStreetAndJunctionChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayStreetAndJunctionChunks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayStreetAndJunctionChunks)) = flag;
		}
	}

	public unsafe bool displayTrafficSimulationResults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayTrafficSimulationResults);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayTrafficSimulationResults)) = flag;
		}
	}

	public unsafe Material debugtrafficSimMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugtrafficSimMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugtrafficSimMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe bool displayStreets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayStreets);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayStreets)) = flag;
		}
	}

	public unsafe Material debugStreetMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugStreetMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugStreetMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe List<Color> streetDebugColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetDebugColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetDebugColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool debugDisplayRoads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDisplayRoads);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDisplayRoads)) = flag;
		}
	}

	public unsafe bool keysToTheCity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keysToTheCity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keysToTheCity)) = flag;
		}
	}

	public unsafe bool disableFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableFurniture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableFurniture)) = flag;
		}
	}

	public unsafe Transform debugContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe bool enableCullingDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCullingDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCullingDebug)) = flag;
		}
	}

	public unsafe bool enableCityEditor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCityEditor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCityEditor)) = flag;
		}
	}

	public unsafe bool collectRoutineTimingInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectRoutineTimingInfo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectRoutineTimingInfo)) = flag;
		}
	}

	public unsafe float guessAverageOnTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessAverageOnTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessAverageOnTime)) = num;
		}
	}

	public unsafe int guessDataEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessDataEntries);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessDataEntries)) = num;
		}
	}

	public unsafe float guessEarlyPercent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessEarlyPercent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessEarlyPercent)) = num;
		}
	}

	public unsafe float guessLatePercent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessLatePercent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessLatePercent)) = num;
		}
	}

	public unsafe float guessCumulativeOnTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessCumulativeOnTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessCumulativeOnTime)) = num;
		}
	}

	public unsafe int guessEarlyEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessEarlyEntries);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessEarlyEntries)) = num;
		}
	}

	public unsafe int guessLateEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessLateEntries);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guessLateEntries)) = num;
		}
	}

	public unsafe Vector2 boundaries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundaries);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundaries)) = vector;
		}
	}

	public unsafe bool noReactOnAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noReactOnAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noReactOnAttack)) = flag;
		}
	}

	public unsafe bool debugPathfinding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPathfinding);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPathfinding)) = flag;
		}
	}

	public unsafe bool useJobSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useJobSystem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useJobSystem)) = flag;
		}
	}

	public unsafe bool useExternalRouteCaching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useExternalRouteCaching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useExternalRouteCaching)) = flag;
		}
	}

	public unsafe bool useInternalRouteCaching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInternalRouteCaching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInternalRouteCaching)) = flag;
		}
	}

	public unsafe bool forceStreetPathsOnMainThread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStreetPathsOnMainThread);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceStreetPathsOnMainThread)) = flag;
		}
	}

	public unsafe bool unlimitedPathCaching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedPathCaching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlimitedPathCaching)) = flag;
		}
	}

	public unsafe int maxExternalCachedPaths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxExternalCachedPaths);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxExternalCachedPaths)) = num;
		}
	}

	public unsafe int maxInternalCachedPaths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxInternalCachedPaths);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxInternalCachedPaths)) = num;
		}
	}

	public unsafe int maxStreetCachedPaths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStreetCachedPaths);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStreetCachedPaths)) = num;
		}
	}

	public unsafe bool dynamicReRouting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicReRouting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicReRouting)) = flag;
		}
	}

	public unsafe List<string> pathfinderDebugLog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathfinderDebugLog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathfinderDebugLog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool discoverAllEvidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverAllEvidence);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverAllEvidence)) = flag;
		}
	}

	public unsafe bool discoverAllRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverAllRooms);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverAllRooms)) = flag;
		}
	}

	public unsafe int maxDrawnMapIcons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDrawnMapIcons);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDrawnMapIcons)) = num;
		}
	}

	public unsafe bool everywhereIllegal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_everywhereIllegal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_everywhereIllegal)) = flag;
		}
	}

	public unsafe bool invisiblePlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invisiblePlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invisiblePlayer)) = flag;
		}
	}

	public unsafe bool inaudiblePlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inaudiblePlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inaudiblePlayer)) = flag;
		}
	}

	public unsafe bool invinciblePlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invinciblePlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invinciblePlayer)) = flag;
		}
	}

	public unsafe bool routeTeleport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_routeTeleport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_routeTeleport)) = flag;
		}
	}

	public unsafe bool giveAllUpgrades
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveAllUpgrades);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveAllUpgrades)) = flag;
		}
	}

	public unsafe bool disableFallDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableFallDamage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableFallDamage)) = flag;
		}
	}

	public unsafe bool pauseAI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAI);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseAI)) = flag;
		}
	}

	public unsafe bool freeCam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeCam);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeCam)) = flag;
		}
	}

	public unsafe bool fastForward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForward);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForward)) = flag;
		}
	}

	public unsafe bool disableSurvivalStatusesInStory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSurvivalStatusesInStory);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSurvivalStatusesInStory)) = flag;
		}
	}

	public unsafe bool sandboxStartingApartment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartingApartment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartingApartment)) = flag;
		}
	}

	public unsafe int playerFixedPasscode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFixedPasscode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFixedPasscode)) = num;
		}
	}

	public unsafe int sandboxStartingMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartingMoney);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartingMoney)) = num;
		}
	}

	public unsafe int sandboxStartingLockpicks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartingLockpicks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandboxStartingLockpicks)) = num;
		}
	}

	public unsafe List<BuildingPreset> preferredStartingBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredStartingBuildings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredStartingBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool alwaysRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysRun)) = flag;
		}
	}

	public unsafe bool toggleRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggleRun)) = flag;
		}
	}

	public unsafe bool permaDeath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_permaDeath);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_permaDeath)) = flag;
		}
	}

	public unsafe bool autoTravelPause
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoTravelPause);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoTravelPause)) = flag;
		}
	}

	public unsafe bool allowEchelons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowEchelons);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowEchelons)) = flag;
		}
	}

	public unsafe bool allowLoitering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLoitering);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLoitering)) = flag;
		}
	}

	public unsafe bool allowAutoTravel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowAutoTravel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowAutoTravel)) = flag;
		}
	}

	public unsafe bool allowSocialCreditPerks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSocialCreditPerks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSocialCreditPerks)) = flag;
		}
	}

	public unsafe bool allowDraggableRagdolls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowDraggableRagdolls);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowDraggableRagdolls)) = flag;
		}
	}

	public unsafe bool forceCoverUpOffers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCoverUpOffers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCoverUpOffers)) = flag;
		}
	}

	public unsafe bool enableColesFallingThroughFloorCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableColesFallingThroughFloorCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableColesFallingThroughFloorCheck)) = flag;
		}
	}

	public unsafe bool forcePlayerTaunts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePlayerTaunts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePlayerTaunts)) = flag;
		}
	}

	public unsafe bool useSimplifiedKillerMonikers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSimplifiedKillerMonikers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSimplifiedKillerMonikers)) = flag;
		}
	}

	public unsafe bool spawnBasBouleCards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnBasBouleCards);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnBasBouleCards)) = flag;
		}
	}

	public unsafe float jobRewardMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobRewardMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobRewardMultiplier)) = num;
		}
	}

	public unsafe float jobPenaltyMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPenaltyMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPenaltyMultiplier)) = num;
		}
	}

	public unsafe float housePriceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_housePriceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_housePriceMultiplier)) = num;
		}
	}

	public unsafe bool noShadowsWhenPlayerIsInDifferentGoundmapLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noShadowsWhenPlayerIsInDifferentGoundmapLocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noShadowsWhenPlayerIsInDifferentGoundmapLocation)) = flag;
		}
	}

	public unsafe bool enableRaindrops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRaindrops);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRaindrops)) = flag;
		}
	}

	public unsafe bool enableRainyWindows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRainyWindows);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRainyWindows)) = flag;
		}
	}

	public unsafe int fov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fov);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fov)) = num;
		}
	}

	public unsafe bool depthBlur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthBlur);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthBlur)) = flag;
		}
	}

	public unsafe float motionBlurIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurIntensity)) = num;
		}
	}

	public unsafe float motionBlurGameSpeedModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurGameSpeedModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurGameSpeedModifier)) = num;
		}
	}

	public unsafe float bloomIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensity)) = num;
		}
	}

	public unsafe bool shadowsOnCitizenLOD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowsOnCitizenLOD);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowsOnCitizenLOD)) = flag;
		}
	}

	public unsafe bool vsync
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vsync);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vsync)) = flag;
		}
	}

	public unsafe bool enableFrameCap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFrameCap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFrameCap)) = flag;
		}
	}

	public unsafe int frameCap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameCap);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameCap)) = num;
		}
	}

	public unsafe bool flickeringLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickeringLights);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickeringLights)) = flag;
		}
	}

	public unsafe bool enableRuntimeStaticBatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRuntimeStaticBatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRuntimeStaticBatching)) = flag;
		}
	}

	public unsafe bool useQuadsForFootprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useQuadsForFootprints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useQuadsForFootprints)) = flag;
		}
	}

	public unsafe bool enableCustomLightCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCustomLightCulling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCustomLightCulling)) = flag;
		}
	}

	public unsafe bool enableNewRealtimeTimeCullingSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableNewRealtimeTimeCullingSystem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableNewRealtimeTimeCullingSystem)) = flag;
		}
	}

	public unsafe bool generateCullingInGame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateCullingInGame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateCullingInGame)) = flag;
		}
	}

	public unsafe bool screenSpaceReflection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSpaceReflection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSpaceReflection)) = flag;
		}
	}

	public unsafe int hyperacusisFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hyperacusisFilter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hyperacusisFilter)) = num;
		}
	}

	public unsafe int bassReduction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bassReduction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bassReduction)) = num;
		}
	}

	public unsafe float lightFadeDistanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightFadeDistanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightFadeDistanceMultiplier)) = num;
		}
	}

	public unsafe float shadowFadeDistanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowFadeDistanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowFadeDistanceMultiplier)) = num;
		}
	}

	public unsafe int sunShadowUpdateFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunShadowUpdateFrequency);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunShadowUpdateFrequency)) = num;
		}
	}

	public unsafe int lastShadowsUpdatedCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastShadowsUpdatedCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastShadowsUpdatedCount)) = num;
		}
	}

	public unsafe bool overrideLightControllerShadowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideLightControllerShadowMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideLightControllerShadowMode)) = flag;
		}
	}

	public unsafe LightingPreset.ShadowMode shadowModeOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowModeOverride);
			return *(LightingPreset.ShadowMode*)num;
		}
		set
		{
			*(LightingPreset.ShadowMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowModeOverride)) = shadowMode;
		}
	}

	public unsafe int dynamicShadowUpdateFrames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicShadowUpdateFrames);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicShadowUpdateFrames)) = num;
		}
	}

	public unsafe int maxUpdateDynamicShadowsPerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxUpdateDynamicShadowsPerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxUpdateDynamicShadowsPerFrame)) = num;
		}
	}

	public unsafe bool combineAirDuctMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combineAirDuctMeshes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combineAirDuctMeshes)) = flag;
		}
	}

	public unsafe bool combineRoomMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combineRoomMeshes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combineRoomMeshes)) = flag;
		}
	}

	public unsafe ShadowCastingMode roomWallShadowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomWallShadowMode);
			return *(ShadowCastingMode*)num;
		}
		set
		{
			*(ShadowCastingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomWallShadowMode)) = shadowCastingMode;
		}
	}

	public unsafe ShadowCastingMode roomFloorShadowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomFloorShadowMode);
			return *(ShadowCastingMode*)num;
		}
		set
		{
			*(ShadowCastingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomFloorShadowMode)) = shadowCastingMode;
		}
	}

	public unsafe ShadowCastingMode roomCeilingShadowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomCeilingShadowMode);
			return *(ShadowCastingMode*)num;
		}
		set
		{
			*(ShadowCastingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomCeilingShadowMode)) = shadowCastingMode;
		}
	}

	public unsafe ShadowCastingMode airDuctShadowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctShadowMode);
			return *(ShadowCastingMode*)num;
		}
		set
		{
			*(ShadowCastingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctShadowMode)) = shadowCastingMode;
		}
	}

	public unsafe bool useJobSystemForMeshCombination
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useJobSystemForMeshCombination);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useJobSystemForMeshCombination)) = flag;
		}
	}

	public unsafe bool optimizeCombinedMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optimizeCombinedMeshes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optimizeCombinedMeshes)) = flag;
		}
	}

	public unsafe bool autoWeldVertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoWeldVertices);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoWeldVertices)) = flag;
		}
	}

	public unsafe int uiScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiScale);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiScale)) = num;
		}
	}

	public unsafe bool wordByWordText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordByWordText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordByWordText)) = flag;
		}
	}

	public unsafe bool selectCitizenOnLookAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectCitizenOnLookAt);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectCitizenOnLookAt)) = flag;
		}
	}

	public unsafe int base26Test
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base26Test);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base26Test)) = num;
		}
	}

	public unsafe bool screenshotMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotMode)) = flag;
		}
	}

	public unsafe bool screenshotModeAllowDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotModeAllowDialog);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotModeAllowDialog)) = flag;
		}
	}

	public unsafe List<Actor> debugHuman
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHuman);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Actor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHuman)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool debugHumanMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanMovement)) = flag;
		}
	}

	public unsafe bool debugHumanActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanActions);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanActions)) = flag;
		}
	}

	public unsafe bool debugHumanAttacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanAttacks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanAttacks)) = flag;
		}
	}

	public unsafe bool debugHumanUpdates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanUpdates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanUpdates)) = flag;
		}
	}

	public unsafe bool debugHumanMisc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanMisc);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanMisc)) = flag;
		}
	}

	public unsafe bool debugHumanSight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanSight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugHumanSight)) = flag;
		}
	}

	public unsafe int debugFindWall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFindWall);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFindWall)) = num;
		}
	}

	public unsafe int debugAddressID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugAddressID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugAddressID)) = num;
		}
	}

	public unsafe int debugCitizenID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCitizenID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCitizenID)) = num;
		}
	}

	public unsafe int debugPhotoTestID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPhotoTestID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPhotoTestID)) = num;
		}
	}

	public unsafe MurderWeaponPreset debugTestWeapon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugTestWeapon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MurderWeaponPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugTestWeapon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)murderWeaponPreset));
		}
	}

	public unsafe List<DebugCitizenWeapons> debugWeaponsSurvey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugWeaponsSurvey);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DebugCitizenWeapons>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugWeaponsSurvey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Game _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Game>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)game));
		}
	}

	public unsafe static Game Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151454, XrefRangeEnd = 151456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_Game_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Game>(intPtr) : null;
		}
	}

	static Game()
	{
		Il2CppClassPointerStore<Game>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Game");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game>.NativeClassPtr);
		NativeFieldInfoPtr_buildID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "buildID");
		NativeFieldInfoPtr_buildDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "buildDescription");
		NativeFieldInfoPtr_customTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "customTags");
		NativeFieldInfoPtr_steamScriptPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "steamScriptPath");
		NativeFieldInfoPtr_updateAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "updateAbove");
		NativeFieldInfoPtr_lastCompatibleCities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "lastCompatibleCities");
		NativeFieldInfoPtr_buildConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "buildConfiguration");
		NativeFieldInfoPtr_autodetectBuildConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "autodetectBuildConfig");
		NativeFieldInfoPtr_forceLowEndHardware = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forceLowEndHardware");
		NativeFieldInfoPtr_devMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "devMode");
		NativeFieldInfoPtr_printDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "printDebug");
		NativeFieldInfoPtr_alwaysPrintErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "alwaysPrintErrors");
		NativeFieldInfoPtr_collectDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "collectDebugData");
		NativeFieldInfoPtr_debugPrintLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugPrintLevel");
		NativeFieldInfoPtr_enableBugReporting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableBugReporting");
		NativeFieldInfoPtr_forceEnglish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forceEnglish");
		NativeFieldInfoPtr_skipIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "skipIntro");
		NativeFieldInfoPtr_allowMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allowMods");
		NativeFieldInfoPtr_forceMediumCitiesOnConsole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forceMediumCitiesOnConsole");
		NativeFieldInfoPtr_ensureItemNamesInDictionaries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "ensureItemNamesInDictionaries");
		NativeFieldInfoPtr_isLowEndHardware = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "isLowEndHardware");
		NativeFieldInfoPtr_boostMinimumFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "boostMinimumFontSize");
		NativeFieldInfoPtr_removeOnConsoleVersions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "removeOnConsoleVersions");
		NativeFieldInfoPtr_timeLimited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "timeLimited");
		NativeFieldInfoPtr_timeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "timeLimit");
		NativeFieldInfoPtr_startTimerAfterApartmentExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "startTimerAfterApartmentExit");
		NativeFieldInfoPtr_pauseTimerOnGamePause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "pauseTimerOnGamePause");
		NativeFieldInfoPtr_disableSaveLoadGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableSaveLoadGames");
		NativeFieldInfoPtr_disableSandbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableSandbox");
		NativeFieldInfoPtr_disableCityGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableCityGeneration");
		NativeFieldInfoPtr_smallCitiesOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "smallCitiesOnly");
		NativeFieldInfoPtr_displayBetaMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "displayBetaMessage");
		NativeFieldInfoPtr_useSaveGameCompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useSaveGameCompression");
		NativeFieldInfoPtr_saveGameCompressionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "saveGameCompressionQuality");
		NativeFieldInfoPtr_useCityDataCompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useCityDataCompression");
		NativeFieldInfoPtr_cityDataCompressionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "cityDataCompressionQuality");
		NativeFieldInfoPtr_maxThreads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "maxThreads");
		NativeFieldInfoPtr_writeUnfoundToTextFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "writeUnfoundToTextFiles");
		NativeFieldInfoPtr_sandboxMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "sandboxMode");
		NativeFieldInfoPtr_loadChapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "loadChapter");
		NativeFieldInfoPtr_updateMovementEveryFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "updateMovementEveryFrame");
		NativeFieldInfoPtr_defaultSaturationAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "defaultSaturationAmount");
		NativeFieldInfoPtr_displayExtraControlHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "displayExtraControlHints");
		NativeFieldInfoPtr_objectiveMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "objectiveMarkers");
		NativeFieldInfoPtr_gameDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "gameDifficulty");
		NativeFieldInfoPtr_difficultyIncomingDamageMultipliers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "difficultyIncomingDamageMultipliers");
		NativeFieldInfoPtr_gameLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "gameLength");
		NativeFieldInfoPtr_gameLengthMaxLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "gameLengthMaxLevels");
		NativeFieldInfoPtr_forceSideJobDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forceSideJobDifficulty");
		NativeFieldInfoPtr_forcedJobDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forcedJobDifficulty");
		NativeFieldInfoPtr_resumeAfterPin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "resumeAfterPin");
		NativeFieldInfoPtr_closeInteractionsOnResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "closeInteractionsOnResume");
		NativeFieldInfoPtr_enableDirectionalArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableDirectionalArrow");
		NativeFieldInfoPtr_sandboxStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "sandboxStartTime");
		NativeFieldInfoPtr_enableMurdererInSandbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableMurdererInSandbox");
		NativeFieldInfoPtr_weatherChangeFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "weatherChangeFrequency");
		NativeFieldInfoPtr_disableSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableSnow");
		NativeFieldInfoPtr_disableTrespass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableTrespass");
		NativeFieldInfoPtr_debugMurdererOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugMurdererOnStart");
		NativeFieldInfoPtr_demoChapterSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "demoChapterSkip");
		NativeFieldInfoPtr_demoMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "demoMode");
		NativeFieldInfoPtr_allHospitalAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allHospitalAccess");
		NativeFieldInfoPtr_autoPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "autoPause");
		NativeFieldInfoPtr_autoPauseSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "autoPauseSeconds");
		NativeFieldInfoPtr_demoAutoReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "demoAutoReset");
		NativeFieldInfoPtr_resetSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "resetSeconds");
		NativeFieldInfoPtr_resetChapterPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "resetChapterPart");
		NativeFieldInfoPtr_resetSaveGameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "resetSaveGameName");
		NativeFieldInfoPtr_textSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "textSpeed");
		NativeFieldInfoPtr_disableCaseBoardClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableCaseBoardClose");
		NativeFieldInfoPtr_allowLicensedMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allowLicensedMusic");
		NativeFieldInfoPtr_overridePasscodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "overridePasscodes");
		NativeFieldInfoPtr_overriddenPasscode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "overriddenPasscode");
		NativeFieldInfoPtr_maxDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "maxDeltaTime");
		NativeFieldInfoPtr_aaMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "aaMode");
		NativeFieldInfoPtr_playerPasscode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerPasscode");
		NativeFieldInfoPtr_enableDiskSavedCaptures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableDiskSavedCaptures");
		NativeFieldInfoPtr_mainThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "mainThread");
		NativeFieldInfoPtr_coldStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "coldStatusEnabled");
		NativeFieldInfoPtr_smellyStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "smellyStatusEnabled");
		NativeFieldInfoPtr_headacheStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "headacheStatusEnabled");
		NativeFieldInfoPtr_injuryStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "injuryStatusEnabled");
		NativeFieldInfoPtr_tiredStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "tiredStatusEnabled");
		NativeFieldInfoPtr_hungerStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "hungerStatusEnabled");
		NativeFieldInfoPtr_hydrationStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "hydrationStatusEnabled");
		NativeFieldInfoPtr_numbStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "numbStatusEnabled");
		NativeFieldInfoPtr_bleedingStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "bleedingStatusEnabled");
		NativeFieldInfoPtr_wetStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "wetStatusEnabled");
		NativeFieldInfoPtr_sickStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "sickStatusEnabled");
		NativeFieldInfoPtr_drunkStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "drunkStatusEnabled");
		NativeFieldInfoPtr_starchAddictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "starchAddictionEnabled");
		NativeFieldInfoPtr_poisonStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "poisonStatusEnabled");
		NativeFieldInfoPtr_blindedStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "blindedStatusEnabled");
		NativeFieldInfoPtr_energizedStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "energizedStatusEnabled");
		NativeFieldInfoPtr_hydratedStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "hydratedStatusEnabled");
		NativeFieldInfoPtr_focusedStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "focusedStatusEnabled");
		NativeFieldInfoPtr_wellRestedStatusEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "wellRestedStatusEnabled");
		NativeFieldInfoPtr_mouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "mouseSensitivity");
		NativeFieldInfoPtr_controllerSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "controllerSensitivity");
		NativeFieldInfoPtr_virtualCursorSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "virtualCursorSensitivity");
		NativeFieldInfoPtr_axisMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "axisMP");
		NativeFieldInfoPtr_controlAutoSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "controlAutoSwitch");
		NativeFieldInfoPtr_mouseSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "mouseSmoothing");
		NativeFieldInfoPtr_controllerSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "controllerSmoothing");
		NativeFieldInfoPtr_movementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "movementSpeed");
		NativeFieldInfoPtr_scrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "scrollSensitivity");
		NativeFieldInfoPtr_forceFeedbackMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forceFeedbackMultiplier");
		NativeFieldInfoPtr_playerFirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerFirstName");
		NativeFieldInfoPtr_playerSurname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerSurname");
		NativeFieldInfoPtr_playerGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerGender");
		NativeFieldInfoPtr_partnerGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "partnerGender");
		NativeFieldInfoPtr_playerSkinColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerSkinColour");
		NativeFieldInfoPtr_playerBirthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerBirthDay");
		NativeFieldInfoPtr_playerBirthMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerBirthMonth");
		NativeFieldInfoPtr_playerBirthYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerBirthYear");
		NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "language");
		NativeFieldInfoPtr_wordCountTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "wordCountTotal");
		NativeFieldInfoPtr_displayStreetChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "displayStreetChunks");
		NativeFieldInfoPtr_displayStreetAndJunctionChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "displayStreetAndJunctionChunks");
		NativeFieldInfoPtr_displayTrafficSimulationResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "displayTrafficSimulationResults");
		NativeFieldInfoPtr_debugtrafficSimMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugtrafficSimMaterial");
		NativeFieldInfoPtr_displayStreets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "displayStreets");
		NativeFieldInfoPtr_debugStreetMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugStreetMaterial");
		NativeFieldInfoPtr_streetDebugColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "streetDebugColours");
		NativeFieldInfoPtr_debugDisplayRoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugDisplayRoads");
		NativeFieldInfoPtr_keysToTheCity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "keysToTheCity");
		NativeFieldInfoPtr_disableFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableFurniture");
		NativeFieldInfoPtr_debugContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugContainer");
		NativeFieldInfoPtr_enableCullingDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableCullingDebug");
		NativeFieldInfoPtr_enableCityEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableCityEditor");
		NativeFieldInfoPtr_collectRoutineTimingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "collectRoutineTimingInfo");
		NativeFieldInfoPtr_guessAverageOnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "guessAverageOnTime");
		NativeFieldInfoPtr_guessDataEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "guessDataEntries");
		NativeFieldInfoPtr_guessEarlyPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "guessEarlyPercent");
		NativeFieldInfoPtr_guessLatePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "guessLatePercent");
		NativeFieldInfoPtr_guessCumulativeOnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "guessCumulativeOnTime");
		NativeFieldInfoPtr_guessEarlyEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "guessEarlyEntries");
		NativeFieldInfoPtr_guessLateEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "guessLateEntries");
		NativeFieldInfoPtr_boundaries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "boundaries");
		NativeFieldInfoPtr_noReactOnAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "noReactOnAttack");
		NativeFieldInfoPtr_debugPathfinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugPathfinding");
		NativeFieldInfoPtr_useJobSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useJobSystem");
		NativeFieldInfoPtr_useExternalRouteCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useExternalRouteCaching");
		NativeFieldInfoPtr_useInternalRouteCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useInternalRouteCaching");
		NativeFieldInfoPtr_forceStreetPathsOnMainThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forceStreetPathsOnMainThread");
		NativeFieldInfoPtr_unlimitedPathCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "unlimitedPathCaching");
		NativeFieldInfoPtr_maxExternalCachedPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "maxExternalCachedPaths");
		NativeFieldInfoPtr_maxInternalCachedPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "maxInternalCachedPaths");
		NativeFieldInfoPtr_maxStreetCachedPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "maxStreetCachedPaths");
		NativeFieldInfoPtr_dynamicReRouting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "dynamicReRouting");
		NativeFieldInfoPtr_pathfinderDebugLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "pathfinderDebugLog");
		NativeFieldInfoPtr_discoverAllEvidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "discoverAllEvidence");
		NativeFieldInfoPtr_discoverAllRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "discoverAllRooms");
		NativeFieldInfoPtr_maxDrawnMapIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "maxDrawnMapIcons");
		NativeFieldInfoPtr_everywhereIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "everywhereIllegal");
		NativeFieldInfoPtr_invisiblePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "invisiblePlayer");
		NativeFieldInfoPtr_inaudiblePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "inaudiblePlayer");
		NativeFieldInfoPtr_invinciblePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "invinciblePlayer");
		NativeFieldInfoPtr_routeTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "routeTeleport");
		NativeFieldInfoPtr_giveAllUpgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "giveAllUpgrades");
		NativeFieldInfoPtr_disableFallDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableFallDamage");
		NativeFieldInfoPtr_pauseAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "pauseAI");
		NativeFieldInfoPtr_freeCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "freeCam");
		NativeFieldInfoPtr_fastForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "fastForward");
		NativeFieldInfoPtr_disableSurvivalStatusesInStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "disableSurvivalStatusesInStory");
		NativeFieldInfoPtr_sandboxStartingApartment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "sandboxStartingApartment");
		NativeFieldInfoPtr_playerFixedPasscode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playerFixedPasscode");
		NativeFieldInfoPtr_sandboxStartingMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "sandboxStartingMoney");
		NativeFieldInfoPtr_sandboxStartingLockpicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "sandboxStartingLockpicks");
		NativeFieldInfoPtr_preferredStartingBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "preferredStartingBuildings");
		NativeFieldInfoPtr_alwaysRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "alwaysRun");
		NativeFieldInfoPtr_toggleRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "toggleRun");
		NativeFieldInfoPtr_permaDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "permaDeath");
		NativeFieldInfoPtr_autoTravelPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "autoTravelPause");
		NativeFieldInfoPtr_allowEchelons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allowEchelons");
		NativeFieldInfoPtr_allowLoitering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allowLoitering");
		NativeFieldInfoPtr_allowAutoTravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allowAutoTravel");
		NativeFieldInfoPtr_allowSocialCreditPerks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allowSocialCreditPerks");
		NativeFieldInfoPtr_allowDraggableRagdolls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "allowDraggableRagdolls");
		NativeFieldInfoPtr_forceCoverUpOffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forceCoverUpOffers");
		NativeFieldInfoPtr_enableColesFallingThroughFloorCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableColesFallingThroughFloorCheck");
		NativeFieldInfoPtr_forcePlayerTaunts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "forcePlayerTaunts");
		NativeFieldInfoPtr_useSimplifiedKillerMonikers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useSimplifiedKillerMonikers");
		NativeFieldInfoPtr_spawnBasBouleCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "spawnBasBouleCards");
		NativeFieldInfoPtr_jobRewardMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "jobRewardMultiplier");
		NativeFieldInfoPtr_jobPenaltyMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "jobPenaltyMultiplier");
		NativeFieldInfoPtr_housePriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "housePriceMultiplier");
		NativeFieldInfoPtr_noShadowsWhenPlayerIsInDifferentGoundmapLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "noShadowsWhenPlayerIsInDifferentGoundmapLocation");
		NativeFieldInfoPtr_enableRaindrops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableRaindrops");
		NativeFieldInfoPtr_enableRainyWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableRainyWindows");
		NativeFieldInfoPtr_fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "fov");
		NativeFieldInfoPtr_depthBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "depthBlur");
		NativeFieldInfoPtr_motionBlurIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "motionBlurIntensity");
		NativeFieldInfoPtr_motionBlurGameSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "motionBlurGameSpeedModifier");
		NativeFieldInfoPtr_bloomIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "bloomIntensity");
		NativeFieldInfoPtr_shadowsOnCitizenLOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "shadowsOnCitizenLOD");
		NativeFieldInfoPtr_vsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "vsync");
		NativeFieldInfoPtr_enableFrameCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableFrameCap");
		NativeFieldInfoPtr_frameCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "frameCap");
		NativeFieldInfoPtr_flickeringLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "flickeringLights");
		NativeFieldInfoPtr_enableRuntimeStaticBatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableRuntimeStaticBatching");
		NativeFieldInfoPtr_useQuadsForFootprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useQuadsForFootprints");
		NativeFieldInfoPtr_enableCustomLightCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableCustomLightCulling");
		NativeFieldInfoPtr_enableNewRealtimeTimeCullingSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "enableNewRealtimeTimeCullingSystem");
		NativeFieldInfoPtr_generateCullingInGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "generateCullingInGame");
		NativeFieldInfoPtr_screenSpaceReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "screenSpaceReflection");
		NativeFieldInfoPtr_hyperacusisFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "hyperacusisFilter");
		NativeFieldInfoPtr_bassReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "bassReduction");
		NativeFieldInfoPtr_lightFadeDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "lightFadeDistanceMultiplier");
		NativeFieldInfoPtr_shadowFadeDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "shadowFadeDistanceMultiplier");
		NativeFieldInfoPtr_sunShadowUpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "sunShadowUpdateFrequency");
		NativeFieldInfoPtr_lastShadowsUpdatedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "lastShadowsUpdatedCount");
		NativeFieldInfoPtr_overrideLightControllerShadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "overrideLightControllerShadowMode");
		NativeFieldInfoPtr_shadowModeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "shadowModeOverride");
		NativeFieldInfoPtr_dynamicShadowUpdateFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "dynamicShadowUpdateFrames");
		NativeFieldInfoPtr_maxUpdateDynamicShadowsPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "maxUpdateDynamicShadowsPerFrame");
		NativeFieldInfoPtr_combineAirDuctMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "combineAirDuctMeshes");
		NativeFieldInfoPtr_combineRoomMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "combineRoomMeshes");
		NativeFieldInfoPtr_roomWallShadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "roomWallShadowMode");
		NativeFieldInfoPtr_roomFloorShadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "roomFloorShadowMode");
		NativeFieldInfoPtr_roomCeilingShadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "roomCeilingShadowMode");
		NativeFieldInfoPtr_airDuctShadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "airDuctShadowMode");
		NativeFieldInfoPtr_useJobSystemForMeshCombination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "useJobSystemForMeshCombination");
		NativeFieldInfoPtr_optimizeCombinedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "optimizeCombinedMeshes");
		NativeFieldInfoPtr_autoWeldVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "autoWeldVertices");
		NativeFieldInfoPtr_uiScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "uiScale");
		NativeFieldInfoPtr_wordByWordText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "wordByWordText");
		NativeFieldInfoPtr_selectCitizenOnLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "selectCitizenOnLookAt");
		NativeFieldInfoPtr_base26Test = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "base26Test");
		NativeFieldInfoPtr_screenshotMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "screenshotMode");
		NativeFieldInfoPtr_screenshotModeAllowDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "screenshotModeAllowDialog");
		NativeFieldInfoPtr_debugHuman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugHuman");
		NativeFieldInfoPtr_debugHumanMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugHumanMovement");
		NativeFieldInfoPtr_debugHumanActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugHumanActions");
		NativeFieldInfoPtr_debugHumanAttacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugHumanAttacks");
		NativeFieldInfoPtr_debugHumanUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugHumanUpdates");
		NativeFieldInfoPtr_debugHumanMisc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugHumanMisc");
		NativeFieldInfoPtr_debugHumanSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugHumanSight");
		NativeFieldInfoPtr_debugFindWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugFindWall");
		NativeFieldInfoPtr_debugAddressID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugAddressID");
		NativeFieldInfoPtr_debugCitizenID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugCitizenID");
		NativeFieldInfoPtr_debugPhotoTestID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugPhotoTestID");
		NativeFieldInfoPtr_debugTestWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugTestWeapon");
		NativeFieldInfoPtr_debugWeaponsSurvey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "debugWeaponsSurvey");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_WordCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667802);
		NativeMethodInfoPtr_SetScreenshotMode_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667803);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667804);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667805);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667806);
		NativeMethodInfoPtr_AddOnTimeEntry_Public_Void_Actor_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667807);
		NativeMethodInfoPtr_AIInAddressFullyRested_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667808);
		NativeMethodInfoPtr_AIInAddressNeedShower_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667809);
		NativeMethodInfoPtr_AIInAddressNeedFun_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667810);
		NativeMethodInfoPtr_DebugButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667811);
		NativeMethodInfoPtr_ResetRoutineCollectionData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667812);
		NativeMethodInfoPtr_AddRandomCitizenToAwareness_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667813);
		NativeMethodInfoPtr_ForceEnableMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667814);
		NativeMethodInfoPtr_SetRaindrops_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667815);
		NativeMethodInfoPtr_SetRainWindows_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667816);
		NativeMethodInfoPtr_SetFOV_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667817);
		NativeMethodInfoPtr_SetObjectiveMarkers_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667818);
		NativeMethodInfoPtr_SetDirectionalArrow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667819);
		NativeMethodInfoPtr_SetAwarenessIndicator_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667820);
		NativeMethodInfoPtr_SetDepthBlur_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667821);
		NativeMethodInfoPtr_SetSandboxStartTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667822);
		NativeMethodInfoPtr_SetGameDifficulty_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667823);
		NativeMethodInfoPtr_SetGameLength_Public_Void_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667824);
		NativeMethodInfoPtr_SetEnableColdStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667825);
		NativeMethodInfoPtr_SetEnableSmellyStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667826);
		NativeMethodInfoPtr_SetEnableHeadacheStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667827);
		NativeMethodInfoPtr_SetEnableBleedingStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667828);
		NativeMethodInfoPtr_SetEnableInjuryStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667829);
		NativeMethodInfoPtr_SetEnableHungerStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667830);
		NativeMethodInfoPtr_SetEnableHydrationStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667831);
		NativeMethodInfoPtr_SetEnableWetStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667832);
		NativeMethodInfoPtr_SetEnableSickStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667833);
		NativeMethodInfoPtr_SetEnableNumbStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667834);
		NativeMethodInfoPtr_SetEnableTiredStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667835);
		NativeMethodInfoPtr_SetEnableDrunkStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667836);
		NativeMethodInfoPtr_SetEnableEnergizedStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667837);
		NativeMethodInfoPtr_SetEnableHydratedStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667838);
		NativeMethodInfoPtr_SetEnableFocusedStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667839);
		NativeMethodInfoPtr_SetEnableWellRestedStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667840);
		NativeMethodInfoPtr_SetSandboxStartingApartment_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667841);
		NativeMethodInfoPtr_SetFixedPasscode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667842);
		NativeMethodInfoPtr_SetSandboxStartingMoney_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667843);
		NativeMethodInfoPtr_SetSandboxStartingLockpicks_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667844);
		NativeMethodInfoPtr_SetForceSideJobDifficulty_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667845);
		NativeMethodInfoPtr_SetForcedSideJobDifficulty_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667846);
		NativeMethodInfoPtr_SetPauseAI_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667847);
		NativeMethodInfoPtr_SetFreeCamMode_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667848);
		NativeMethodInfoPtr_SetFastForward_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667849);
		NativeMethodInfoPtr_SetDrawDistance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667850);
		NativeMethodInfoPtr_SetLightDistance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667851);
		NativeMethodInfoPtr_SetMurders_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667852);
		NativeMethodInfoPtr_SetUIScale_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667853);
		NativeMethodInfoPtr_SetAAMode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667854);
		NativeMethodInfoPtr_SetAAQuality_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667855);
		NativeMethodInfoPtr_SetDithering_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr_SetVsync_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667857);
		NativeMethodInfoPtr_SetEnableFrameCap_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667858);
		NativeMethodInfoPtr_SetFrameCap_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667859);
		NativeMethodInfoPtr_SetPasscodeOverrideToggle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667860);
		NativeMethodInfoPtr_SetPasscodeOverride_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667861);
		NativeMethodInfoPtr_SetFlickingLights_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667862);
		NativeMethodInfoPtr_Log_Public_Static_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667863);
		NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667864);
		NativeMethodInfoPtr_SetAllowLicensedMusic_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667865);
		NativeMethodInfoPtr_SetScreenSpaceReflection_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667866);
		NativeMethodInfoPtr_SetHyperacusisFilter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667867);
		NativeMethodInfoPtr_SetBassReduction_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667868);
		NativeMethodInfoPtr_SetPlayerPasscode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667869);
		NativeMethodInfoPtr_GetPlayerPasscodeDigits_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667870);
		NativeMethodInfoPtr_Base26Test_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667871);
		NativeMethodInfoPtr_Give1000Crows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667872);
		NativeMethodInfoPtr_Give100Lockpicks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667873);
		NativeMethodInfoPtr_ResetHealth_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667874);
		NativeMethodInfoPtr_KOPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667875);
		NativeMethodInfoPtr_TestCurrentDetainedStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667876);
		NativeMethodInfoPtr_VictimsRankTest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667877);
		NativeMethodInfoPtr_GiveAllUpgrades_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667878);
		NativeMethodInfoPtr_GiveSocialCredit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667879);
		NativeMethodInfoPtr_CompleteSideJob_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667880);
		NativeMethodInfoPtr_DisplayAnswersToCurrentSideJob_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667881);
		NativeMethodInfoPtr_OnBuildValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667882);
		NativeMethodInfoPtr_DebugFindWall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667883);
		NativeMethodInfoPtr_DebugAddressID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667884);
		NativeMethodInfoPtr_DebugCitizenID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667885);
		NativeMethodInfoPtr_ShotgunTest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667886);
		NativeMethodInfoPtr_MissionPhotoTest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667887);
		NativeMethodInfoPtr_FindProsthetics_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667888);
		NativeMethodInfoPtr_TeleportPlayerStreetStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667889);
		NativeMethodInfoPtr_ToggleCitizenColliders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667890);
		NativeMethodInfoPtr_GiveRandomJolt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667891);
		NativeMethodInfoPtr_TripPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667892);
		NativeMethodInfoPtr_TestTimeRange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667893);
		NativeMethodInfoPtr_DeletePlayerPrefs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667894);
		NativeMethodInfoPtr_DeletePlayerPrefsConfirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667895);
		NativeMethodInfoPtr_DeletePlayerPrefsCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667896);
		NativeMethodInfoPtr_ForcePlayerDirtyDeath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667897);
		NativeMethodInfoPtr_TurnOffAllDynamicOcclusion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667898);
		NativeMethodInfoPtr_TurnOffAllLODS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667899);
		NativeMethodInfoPtr_ShootFromPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667900);
		NativeMethodInfoPtr_UnloadUnusedAssets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667901);
		NativeMethodInfoPtr_ListSelfEmployed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667902);
		NativeMethodInfoPtr_ExportGameContentLists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667903);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667904);
		NativeMethodInfoPtr__DebugAddressID_b__330_0_Private_Boolean_NewAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667905);
		NativeMethodInfoPtr__DebugCitizenID_b__331_0_Private_Boolean_Citizen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667906);
		NativeMethodInfoPtr__MissionPhotoTest_b__333_0_Private_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100667907);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151393, XrefRangeEnd = 151419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WordCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WordCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 151452, RefRangeEnd = 151454, XrefRangeStart = 151419, XrefRangeEnd = 151452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetScreenshotMode(bool val, bool allowDialog = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowDialog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScreenshotMode_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151456, XrefRangeEnd = 151529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151529, XrefRangeEnd = 151550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151550, XrefRangeEnd = 151551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnTimeEntry(Actor cc, float newOnTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cc);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newOnTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOnTimeEntry_Public_Void_Actor_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151551, XrefRangeEnd = 151571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AIInAddressFullyRested()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AIInAddressFullyRested_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151571, XrefRangeEnd = 151591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AIInAddressNeedShower()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AIInAddressNeedShower_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151591, XrefRangeEnd = 151611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AIInAddressNeedFun()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AIInAddressNeedFun_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151611, XrefRangeEnd = 151648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151648, XrefRangeEnd = 151650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetRoutineCollectionData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetRoutineCollectionData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151650, XrefRangeEnd = 151685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRandomCitizenToAwareness()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRandomCitizenToAwareness_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151685, XrefRangeEnd = 151701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceEnableMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceEnableMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 151766, RefRangeEnd = 151768, XrefRangeStart = 151701, XrefRangeEnd = 151766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRaindrops(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRaindrops_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 151946, RefRangeEnd = 151948, XrefRangeStart = 151768, XrefRangeEnd = 151946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRainWindows(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRainWindows_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 151976, RefRangeEnd = 151977, XrefRangeStart = 151948, XrefRangeEnd = 151976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFOV(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFOV_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152005, RefRangeEnd = 152006, XrefRangeStart = 151977, XrefRangeEnd = 152005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetObjectiveMarkers(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetObjectiveMarkers_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152021, RefRangeEnd = 152022, XrefRangeStart = 152006, XrefRangeEnd = 152021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDirectionalArrow(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirectionalArrow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152038, RefRangeEnd = 152039, XrefRangeStart = 152022, XrefRangeEnd = 152038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAwarenessIndicator(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAwarenessIndicator_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152102, RefRangeEnd = 152103, XrefRangeStart = 152039, XrefRangeEnd = 152102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDepthBlur(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDepthBlur_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 152103, RefRangeEnd = 152107, XrefRangeStart = 152103, XrefRangeEnd = 152103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSandboxStartTime(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSandboxStartTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 152107, RefRangeEnd = 152111, XrefRangeStart = 152107, XrefRangeEnd = 152107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameDifficulty(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameDifficulty_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 152128, RefRangeEnd = 152135, XrefRangeStart = 152111, XrefRangeEnd = 152128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameLength(int val, bool updateSocialCredits, bool updateDropdown, bool updateSavedValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&val);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateSocialCredits;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateDropdown;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateSavedValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameLength_Public_Void_Int32_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152140, RefRangeEnd = 152141, XrefRangeStart = 152135, XrefRangeEnd = 152140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableColdStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableColdStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152146, RefRangeEnd = 152147, XrefRangeStart = 152141, XrefRangeEnd = 152146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableSmellyStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableSmellyStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152152, RefRangeEnd = 152153, XrefRangeStart = 152147, XrefRangeEnd = 152152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableHeadacheStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableHeadacheStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152158, RefRangeEnd = 152159, XrefRangeStart = 152153, XrefRangeEnd = 152158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableBleedingStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableBleedingStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152164, RefRangeEnd = 152165, XrefRangeStart = 152159, XrefRangeEnd = 152164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableInjuryStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableInjuryStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152170, RefRangeEnd = 152171, XrefRangeStart = 152165, XrefRangeEnd = 152170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableHungerStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableHungerStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152176, RefRangeEnd = 152177, XrefRangeStart = 152171, XrefRangeEnd = 152176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableHydrationStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableHydrationStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152182, RefRangeEnd = 152183, XrefRangeStart = 152177, XrefRangeEnd = 152182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableWetStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableWetStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152188, RefRangeEnd = 152189, XrefRangeStart = 152183, XrefRangeEnd = 152188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableSickStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableSickStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152194, RefRangeEnd = 152195, XrefRangeStart = 152189, XrefRangeEnd = 152194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableNumbStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableNumbStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152200, RefRangeEnd = 152201, XrefRangeStart = 152195, XrefRangeEnd = 152200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableTiredStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableTiredStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152206, RefRangeEnd = 152207, XrefRangeStart = 152201, XrefRangeEnd = 152206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableDrunkStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableDrunkStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152212, RefRangeEnd = 152213, XrefRangeStart = 152207, XrefRangeEnd = 152212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableEnergizedStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableEnergizedStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152218, RefRangeEnd = 152219, XrefRangeStart = 152213, XrefRangeEnd = 152218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableHydratedStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableHydratedStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152224, RefRangeEnd = 152225, XrefRangeStart = 152219, XrefRangeEnd = 152224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableFocusedStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableFocusedStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152230, RefRangeEnd = 152231, XrefRangeStart = 152225, XrefRangeEnd = 152230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableWellRestedStatus(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableWellRestedStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152231, RefRangeEnd = 152232, XrefRangeStart = 152231, XrefRangeEnd = 152231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSandboxStartingApartment(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSandboxStartingApartment_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetFixedPasscode(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFixedPasscode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152232, RefRangeEnd = 152233, XrefRangeStart = 152232, XrefRangeEnd = 152232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSandboxStartingMoney(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSandboxStartingMoney_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152233, RefRangeEnd = 152234, XrefRangeStart = 152233, XrefRangeEnd = 152233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSandboxStartingLockpicks(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSandboxStartingLockpicks_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152234, RefRangeEnd = 152235, XrefRangeStart = 152234, XrefRangeEnd = 152234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForceSideJobDifficulty(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForceSideJobDifficulty_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152235, RefRangeEnd = 152236, XrefRangeStart = 152235, XrefRangeEnd = 152235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForcedSideJobDifficulty(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForcedSideJobDifficulty_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152236, RefRangeEnd = 152237, XrefRangeStart = 152236, XrefRangeEnd = 152236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPauseAI(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPauseAI_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 152251, RefRangeEnd = 152253, XrefRangeStart = 152237, XrefRangeEnd = 152251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFreeCamMode(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFreeCamMode_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152260, RefRangeEnd = 152261, XrefRangeStart = 152253, XrefRangeEnd = 152260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFastForward(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFastForward_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDrawDistance(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDrawDistance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152272, RefRangeEnd = 152273, XrefRangeStart = 152261, XrefRangeEnd = 152272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLightDistance(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLightDistance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152273, RefRangeEnd = 152274, XrefRangeStart = 152273, XrefRangeEnd = 152273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMurders(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMurders_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUIScale(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUIScale_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 152305, RefRangeEnd = 152307, XrefRangeStart = 152274, XrefRangeEnd = 152305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAAMode(int newMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newMode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAAMode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152333, RefRangeEnd = 152334, XrefRangeStart = 152307, XrefRangeEnd = 152333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAAQuality(int newQuality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newQuality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAAQuality_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152364, RefRangeEnd = 152365, XrefRangeStart = 152334, XrefRangeEnd = 152364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDithering(bool newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDithering_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152372, RefRangeEnd = 152373, XrefRangeStart = 152365, XrefRangeEnd = 152372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVsync(bool newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVsync_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152374, RefRangeEnd = 152375, XrefRangeStart = 152373, XrefRangeEnd = 152374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnableFrameCap(bool newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnableFrameCap_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 152382, RefRangeEnd = 152384, XrefRangeStart = 152375, XrefRangeEnd = 152382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFrameCap(int newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrameCap_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152384, RefRangeEnd = 152385, XrefRangeStart = 152384, XrefRangeEnd = 152384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPasscodeOverrideToggle(bool newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPasscodeOverrideToggle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152385, RefRangeEnd = 152386, XrefRangeStart = 152385, XrefRangeEnd = 152385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPasscodeOverride(int newPasscode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newPasscode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPasscodeOverride_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 152386, RefRangeEnd = 152387, XrefRangeStart = 152386, XrefRangeEnd = 152386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFlickingLights(bool newVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFlickingLights_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2097)]
	[CachedScanResults(RefRangeStart = 152408, RefRangeEnd = 154505, XrefRangeStart = 152387, XrefRangeEnd = 152408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(Il2CppSystem.Object print, int level = 2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)print);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(349)]
	[CachedScanResults(RefRangeStart = 154532, RefRangeEnd = 154881, XrefRangeStart = 154505, XrefRangeEnd = 154532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogError(Il2CppSystem.Object print, int level = 2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)print);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 154907, RefRangeEnd = 154908, XrefRangeStart = 154881, XrefRangeEnd = 154907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAllowLicensedMusic(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAllowLicensedMusic_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 154937, RefRangeEnd = 154938, XrefRangeStart = 154908, XrefRangeEnd = 154937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetScreenSpaceReflection(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScreenSpaceReflection_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 154949, RefRangeEnd = 154950, XrefRangeStart = 154938, XrefRangeEnd = 154949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHyperacusisFilter(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHyperacusisFilter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 154961, RefRangeEnd = 154962, XrefRangeStart = 154950, XrefRangeEnd = 154961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBassReduction(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBassReduction_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 154962, RefRangeEnd = 154963, XrefRangeStart = 154962, XrefRangeEnd = 154962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerPasscode(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerPasscode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 154998, RefRangeEnd = 154999, XrefRangeStart = 154963, XrefRangeEnd = 154998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetPlayerPasscodeDigits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerPasscodeDigits_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154999, XrefRangeEnd = 155035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Base26Test()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Base26Test_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155035, XrefRangeEnd = 155040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Give1000Crows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Give1000Crows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155040, XrefRangeEnd = 155044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Give100Lockpicks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Give100Lockpicks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155044, XrefRangeEnd = 155047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetHealth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetHealth_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155047, XrefRangeEnd = 155049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void KOPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KOPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155049, XrefRangeEnd = 155053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestCurrentDetainedStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestCurrentDetainedStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155053, XrefRangeEnd = 155095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VictimsRankTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VictimsRankTest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155095, XrefRangeEnd = 155121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveAllUpgrades()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveAllUpgrades_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155121, XrefRangeEnd = 155128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveSocialCredit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveSocialCredit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155128, XrefRangeEnd = 155134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompleteSideJob()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompleteSideJob_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155134, XrefRangeEnd = 155140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayAnswersToCurrentSideJob()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayAnswersToCurrentSideJob_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155140, XrefRangeEnd = 155204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBuildValueChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBuildValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155204, XrefRangeEnd = 155277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugFindWall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugFindWall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155277, XrefRangeEnd = 155323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugAddressID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugAddressID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155323, XrefRangeEnd = 155347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugCitizenID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugCitizenID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155347, XrefRangeEnd = 155362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShotgunTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShotgunTest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155362, XrefRangeEnd = 155441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MissionPhotoTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MissionPhotoTest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155441, XrefRangeEnd = 155514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindProsthetics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindProsthetics_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155514, XrefRangeEnd = 155547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TeleportPlayerStreetStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TeleportPlayerStreetStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155547, XrefRangeEnd = 155582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleCitizenColliders()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleCitizenColliders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155582, XrefRangeEnd = 155594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveRandomJolt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveRandomJolt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155594, XrefRangeEnd = 155597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TripPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TripPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155597, XrefRangeEnd = 155659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestTimeRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestTimeRange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155659, XrefRangeEnd = 155689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeletePlayerPrefs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeletePlayerPrefs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155689, XrefRangeEnd = 155726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeletePlayerPrefsConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeletePlayerPrefsConfirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155726, XrefRangeEnd = 155745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeletePlayerPrefsCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeletePlayerPrefsCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155745, XrefRangeEnd = 155753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForcePlayerDirtyDeath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForcePlayerDirtyDeath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155753, XrefRangeEnd = 155762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TurnOffAllDynamicOcclusion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnOffAllDynamicOcclusion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155762, XrefRangeEnd = 155776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TurnOffAllLODS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnOffAllLODS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155776, XrefRangeEnd = 155803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShootFromPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShootFromPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155803, XrefRangeEnd = 155813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadUnusedAssets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadUnusedAssets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155813, XrefRangeEnd = 155861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ListSelfEmployed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListSelfEmployed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155861, XrefRangeEnd = 156172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExportGameContentLists()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExportGameContentLists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156172, XrefRangeEnd = 156235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Game()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Game>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _DebugAddressID_b__330_0(NewAddress item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DebugAddressID_b__330_0_Private_Boolean_NewAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _DebugCitizenID_b__331_0(Citizen item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DebugCitizenID_b__331_0_Private_Boolean_Citizen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _MissionPhotoTest_b__333_0(Interactable item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MissionPhotoTest_b__333_0_Private_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Game(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
