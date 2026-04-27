using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class ModdedInteractable : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_copyDataFrom;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnable;

	private static readonly System.IntPtr NativeFieldInfoPtr_presetName;

	private static readonly System.IntPtr NativeFieldInfoPtr_model;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeFromObjectPooling;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeFromVisibilityRangeChecks;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritColouringFromDecor;

	private static readonly System.IntPtr NativeFieldInfoPtr_shareColoursWithFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOwnColourSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_customColour1;

	private static readonly System.IntPtr NativeFieldInfoPtr_customColour2;

	private static readonly System.IntPtr NativeFieldInfoPtr_customColour3;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritGrubValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_includeBelongsTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_useNameShorthand;

	private static readonly System.IntPtr NativeFieldInfoPtr_useApartmentName;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_iconOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInApartmentStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInApartmentShop;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableMoveToStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_apartmentPlacementMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_mustTouchFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMaterialOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionsPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyIllegalIfInNonPublic;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangeModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_physicsProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideMass;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcePhysicsAlwaysOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactWithExternalStimuli;

	private static readonly System.IntPtr NativeFieldInfoPtr_mass;

	private static readonly System.IntPtr NativeFieldInfoPtr_breakable;

	private static readonly System.IntPtr NativeFieldInfoPtr_particleProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideShatterSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_shardSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_shardEveryXPixels;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideSpatterSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatterSimulation;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatterCountMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_switchSFX1;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingSwitchState;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCustomState1;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCustomState2;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCustomState3;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingLockState;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_tamperEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingEnabledOnlyWithSwitchIsTue;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingEnabledOnlyWithKaizenSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_discoverOnRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_pageTurnReadingDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceRecognitionEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceRecognitionOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_recognitionRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_subObjectClasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_backupClasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysPlaceAtGameLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequencyPerGamelocationMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequencyPerGameLocationMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_perGameLocationObjectPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_placeIfFiltersPresentInOwner;

	private static readonly System.IntPtr NativeFieldInfoPtr_placeAtHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_placeAtWork;

	private static readonly System.IntPtr NativeFieldInfoPtr_traitModifier1;

	private static readonly System.IntPtr NativeFieldInfoPtr_traitModifier2;

	private static readonly System.IntPtr NativeFieldInfoPtr_traitModifier3;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequencyPerOwnerMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequencyPerOwnerMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplyByMessiness;

	private static readonly System.IntPtr NativeFieldInfoPtr_perOwnerObjectPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_writerIs;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiverIs;

	private static readonly System.IntPtr NativeFieldInfoPtr_canBeFromSelf;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_perObjectLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_perRoomLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_perAddressLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitInResidential;

	private static readonly System.IntPtr NativeFieldInfoPtr_perResidentialLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitInCommercial;

	private static readonly System.IntPtr NativeFieldInfoPtr_perCommercialLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_banFromRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToCertainRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyInRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToCertainBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyInBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_attemptToStoreInFolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_folderPlacementChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontPlaceIfNoFolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_folderOwnershipMustMatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSubSpawning;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownedRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideWithOnlyOwnedSpawnAtWork;

	private static readonly System.IntPtr NativeFieldInfoPtr_relocationAuthority;

	private static readonly System.IntPtr NativeFieldInfoPtr_relocateIfPlacedInPlayersHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_AIWillCorrectPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationIsParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_summaryMessageSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_isComputer;

	private static readonly System.IntPtr NativeFieldInfoPtr_bootApp;

	private static readonly System.IntPtr NativeFieldInfoPtr_logInApp;

	private static readonly System.IntPtr NativeFieldInfoPtr_desktopApp;

	private static readonly System.IntPtr NativeFieldInfoPtr_additionalApps;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_printsSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDynamicFingerprints;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableDynamicFingerprintsFromStaticPrintsSources;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideMaxDynamicFingerprints;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDynamicFingerprints;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInventoryItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemOffsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemOffsetZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemRotationX;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemRotationY;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemRotationZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemScaleModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_consumableAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyWhenAllConsumed;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSameModelAsTrash;

	private static readonly System.IntPtr NativeFieldInfoPtr_trashItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_disposal;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfDroppedAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_droppedAngleHeightBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_weapon;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryCarryItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectPositionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectPositionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectPositionZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectRotationX;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectRotationY;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectRotationZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_putDownAtHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_takeWith;

	private static readonly System.IntPtr NativeFieldInfoPtr_putDownPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_backupPutDownPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialCaseFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_affectRoomSteamLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPayphone;

	private static readonly System.IntPtr NativeFieldInfoPtr_isClock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_entertainmentSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHeatSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_markAsTrashOnCreate;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDecal;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMovableChair;

	private static readonly System.IntPtr NativeFieldInfoPtr_bedRightSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetSwitchStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontSaveSwitchStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontLoadSwitchStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_recordCreationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_retailItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_chimeEqualToHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_chimeDelay;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string copyDataFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDataFrom);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDataFrom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string spawnable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnable);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string presetName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string model
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string excludeFromObjectPooling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromObjectPooling);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromObjectPooling)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string excludeFromVisibilityRangeChecks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromVisibilityRangeChecks);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromVisibilityRangeChecks)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string spawnRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRange);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRange)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string inheritColouringFromDecor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shareColoursWithFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColoursWithFurniture);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColoursWithFurniture)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string useOwnColourSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnColourSettings);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnColourSettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string mainColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainColour);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainColour)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string customColour1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string customColour2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string customColour3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour3);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour3)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string inheritGrubValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritGrubValue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritGrubValue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string includeBelongsTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeBelongsTo);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeBelongsTo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string useNameShorthand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNameShorthand);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNameShorthand)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string useApartmentName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useApartmentName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useApartmentName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLight);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLight)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string lightswitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitch);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitch)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string iconOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconOverride);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemClass);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemClass)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string allowInApartmentStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentStorage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentStorage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string allowInApartmentShop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentShop);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentShop)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string disableMoveToStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMoveToStorage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMoveToStorage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string apartmentPlacementMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartmentPlacementMode);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartmentPlacementMode)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> mustTouchFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustTouchFurniture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustTouchFurniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string useMaterialOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaterialOverride);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaterialOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<float> materialOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOverride);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> actionsPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionsPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionsPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string onlyIllegalIfInNonPublic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIllegalIfInNonPublic);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIllegalIfInNonPublic)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string rangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeModifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeModifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string physicsProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsProfile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsProfile)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string overrideMass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMass);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMass)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string forcePhysicsAlwaysOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePhysicsAlwaysOn);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePhysicsAlwaysOn)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string reactWithExternalStimuli
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactWithExternalStimuli);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactWithExternalStimuli)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string mass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string breakable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakable);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string particleProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleProfile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleProfile)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string overrideShatterSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShatterSettings);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShatterSettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shardSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardSize);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardSize)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shardEveryXPixels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardEveryXPixels);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardEveryXPixels)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string overrideSpatterSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSpatterSettings);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSpatterSettings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string spatterSimulation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterSimulation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterSimulation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string spatterCountMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCountMultiplier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCountMultiplier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> switchSFX1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchSFX1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchSFX1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string startingSwitchState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingSwitchState);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingSwitchState)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string startingCustomState1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string startingCustomState2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string startingCustomState3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState3);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState3)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string startingLockState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingLockState);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingLockState)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string valueMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string valueMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string tamperEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperEnabled);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string readingEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabled);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string readingEnabledOnlyWithSwitchIsTue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabledOnlyWithSwitchIsTue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabledOnlyWithSwitchIsTue)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string readingEnabledOnlyWithKaizenSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabledOnlyWithKaizenSkill);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabledOnlyWithKaizenSkill)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string readingSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string discoverOnRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnRead);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnRead)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string pageTurnReadingDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageTurnReadingDelay);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageTurnReadingDelay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string distanceRecognitionEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionEnabled);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string distanceRecognitionOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionOnly);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionOnly)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string recognitionRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recognitionRange);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recognitionRange)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> subObjectClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjectClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjectClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> backupClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string autoPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPlacement);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPlacement)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string alwaysPlaceAtGameLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysPlaceAtGameLocation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysPlaceAtGameLocation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string frequencyPerGamelocationMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGamelocationMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGamelocationMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string frequencyPerGameLocationMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGameLocationMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGameLocationMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string perGameLocationObjectPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perGameLocationObjectPriority);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perGameLocationObjectPriority)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string placeIfFiltersPresentInOwner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFiltersPresentInOwner);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFiltersPresentInOwner)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string placeAtHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtHome);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtHome)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string placeAtWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtWork);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtWork)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> traitModifier1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifier1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifier1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> traitModifier2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifier2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifier2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> traitModifier3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifier3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifier3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string frequencyPerOwnerMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string frequencyPerOwnerMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string multiplyByMessiness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplyByMessiness);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplyByMessiness)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string perOwnerObjectPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perOwnerObjectPriority);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perOwnerObjectPriority)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string writerIs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writerIs);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writerIs)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string receiverIs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverIs);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverIs)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string canBeFromSelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFromSelf);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFromSelf)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string limitPerObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerObject);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerObject)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string perObjectLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectLimit);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectLimit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string limitPerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string perRoomLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perRoomLimit);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perRoomLimit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string limitPerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string perAddressLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perAddressLimit);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perAddressLimit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string limitInResidential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInResidential);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInResidential)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string perResidentialLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perResidentialLimit);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perResidentialLimit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string limitInCommercial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInCommercial);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInCommercial)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string perCommercialLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perCommercialLimit);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perCommercialLimit)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> banFromRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string limitToCertainRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainRooms);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainRooms)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> onlyInRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string limitToCertainBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainBuildings);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainBuildings)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> onlyInBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInBuildings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string attemptToStoreInFolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attemptToStoreInFolder);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attemptToStoreInFolder)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string folderPlacementChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderPlacementChance);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderPlacementChance)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string dontPlaceIfNoFolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPlaceIfNoFolder);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPlaceIfNoFolder)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string folderOwnershipMustMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderOwnershipMustMatch);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderOwnershipMustMatch)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string useSubSpawning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSubSpawning);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSubSpawning)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string securityLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityLevel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityLevel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ownedRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownedRule);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownedRule)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string overrideWithOnlyOwnedSpawnAtWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWithOnlyOwnedSpawnAtWork);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWithOnlyOwnedSpawnAtWork)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string relocationAuthority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocationAuthority);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocationAuthority)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string relocateIfPlacedInPlayersHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocateIfPlacedInPlayersHome);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocateIfPlacedInPlayersHome)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string AIWillCorrectPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIWillCorrectPosition);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIWillCorrectPosition)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string locationIsParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationIsParent);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationIsParent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string summaryMessageSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summaryMessageSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summaryMessageSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isComputer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isComputer);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isComputer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bootApp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bootApp);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bootApp)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string logInApp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logInApp);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logInApp)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string desktopApp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desktopApp);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desktopApp)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> additionalApps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalApps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalApps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string fingerprintsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string printsSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fingerprintDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintDensity);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintDensity)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string enableDynamicFingerprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDynamicFingerprints);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDynamicFingerprints)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string disableDynamicFingerprintsFromStaticPrintsSources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableDynamicFingerprintsFromStaticPrintsSources);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableDynamicFingerprintsFromStaticPrintsSources)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string overrideMaxDynamicFingerprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaxDynamicFingerprints);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaxDynamicFingerprints)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string maxDynamicFingerprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDynamicFingerprints);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDynamicFingerprints)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isInventoryItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInventoryItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInventoryItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItemOffsetX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffsetX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffsetX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItemOffsetY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffsetY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffsetY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItemOffsetZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffsetZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffsetZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItemRotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotationX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotationX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItemRotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotationY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotationY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItemRotationZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotationZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotationZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fpsItemScaleModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemScaleModifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemScaleModifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string consumableAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumableAmount);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumableAmount)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string destroyWhenAllConsumed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyWhenAllConsumed);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyWhenAllConsumed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string useSameModelAsTrash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSameModelAsTrash);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSameModelAsTrash)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string trashItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trashItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trashItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string disposal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposal);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposal)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string chanceOfDroppedAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfDroppedAngle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfDroppedAngle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string droppedAngleHeightBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droppedAngleHeightBoost);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droppedAngleHeightBoost)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string weapon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string inventoryCarryItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryCarryItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryCarryItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string requiredCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredCarryAnimation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredCarryAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string aiCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiCarryAnimation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiCarryAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string aiHeldObjectPositionX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPositionX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPositionX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string aiHeldObjectPositionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPositionY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPositionY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string aiHeldObjectPositionZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPositionZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPositionZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string aiHeldObjectRotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotationX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotationX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string aiHeldObjectRotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotationY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotationY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string aiHeldObjectRotationZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotationZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotationZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string putDownAtHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownAtHome);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownAtHome)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string takeWith
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeWith);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeWith)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> putDownPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> backupPutDownPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupPutDownPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupPutDownPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string specialCaseFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCaseFlag);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCaseFlag)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string affectRoomSteamLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectRoomSteamLevel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectRoomSteamLevel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isPayphone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPayphone);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPayphone)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isClock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClock);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClock)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMoney);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMoney)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string entertainmentSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entertainmentSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entertainmentSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isHeatSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHeatSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHeatSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string markAsTrashOnCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markAsTrashOnCreate);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markAsTrashOnCreate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isLitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLitter);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLitter)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isDecal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecal);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecal)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isMovableChair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMovableChair);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMovableChair)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bedRightSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bedRightSide);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bedRightSide)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string resetSwitchStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSwitchStates);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSwitchStates)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string resetTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetTimer);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetTimer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string dontSaveSwitchStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSaveSwitchStates);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSaveSwitchStates)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string dontLoadSwitchStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontLoadSwitchStates);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontLoadSwitchStates)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string recordCreationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordCreationTime);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordCreationTime)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string retailItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItem);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItem)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string menuOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuOverride);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string chimeEqualToHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeEqualToHour);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeEqualToHour)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string chimeDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeDelay);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeDelay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ModdedInteractable()
	{
		Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ModdedInteractable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr);
		NativeFieldInfoPtr_copyDataFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "copyDataFrom");
		NativeFieldInfoPtr_spawnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "spawnable");
		NativeFieldInfoPtr_presetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "presetName");
		NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "model");
		NativeFieldInfoPtr_excludeFromObjectPooling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "excludeFromObjectPooling");
		NativeFieldInfoPtr_excludeFromVisibilityRangeChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "excludeFromVisibilityRangeChecks");
		NativeFieldInfoPtr_spawnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "spawnRange");
		NativeFieldInfoPtr_inheritColouringFromDecor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "inheritColouringFromDecor");
		NativeFieldInfoPtr_shareColoursWithFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "shareColoursWithFurniture");
		NativeFieldInfoPtr_useOwnColourSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "useOwnColourSettings");
		NativeFieldInfoPtr_mainColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "mainColour");
		NativeFieldInfoPtr_customColour1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "customColour1");
		NativeFieldInfoPtr_customColour2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "customColour2");
		NativeFieldInfoPtr_customColour3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "customColour3");
		NativeFieldInfoPtr_inheritGrubValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "inheritGrubValue");
		NativeFieldInfoPtr_includeBelongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "includeBelongsTo");
		NativeFieldInfoPtr_useNameShorthand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "useNameShorthand");
		NativeFieldInfoPtr_useApartmentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "useApartmentName");
		NativeFieldInfoPtr_isLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isLight");
		NativeFieldInfoPtr_lightswitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "lightswitch");
		NativeFieldInfoPtr_iconOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "iconOverride");
		NativeFieldInfoPtr_itemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "itemClass");
		NativeFieldInfoPtr_allowInApartmentStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "allowInApartmentStorage");
		NativeFieldInfoPtr_allowInApartmentShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "allowInApartmentShop");
		NativeFieldInfoPtr_disableMoveToStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "disableMoveToStorage");
		NativeFieldInfoPtr_apartmentPlacementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "apartmentPlacementMode");
		NativeFieldInfoPtr_mustTouchFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "mustTouchFurniture");
		NativeFieldInfoPtr_useMaterialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "useMaterialOverride");
		NativeFieldInfoPtr_materialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "materialOverride");
		NativeFieldInfoPtr_actionsPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "actionsPreset");
		NativeFieldInfoPtr_onlyIllegalIfInNonPublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "onlyIllegalIfInNonPublic");
		NativeFieldInfoPtr_rangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "rangeModifier");
		NativeFieldInfoPtr_physicsProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "physicsProfile");
		NativeFieldInfoPtr_overrideMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "overrideMass");
		NativeFieldInfoPtr_forcePhysicsAlwaysOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "forcePhysicsAlwaysOn");
		NativeFieldInfoPtr_reactWithExternalStimuli = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "reactWithExternalStimuli");
		NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "mass");
		NativeFieldInfoPtr_breakable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "breakable");
		NativeFieldInfoPtr_particleProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "particleProfile");
		NativeFieldInfoPtr_overrideShatterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "overrideShatterSettings");
		NativeFieldInfoPtr_shardSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "shardSize");
		NativeFieldInfoPtr_shardEveryXPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "shardEveryXPixels");
		NativeFieldInfoPtr_overrideSpatterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "overrideSpatterSettings");
		NativeFieldInfoPtr_spatterSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "spatterSimulation");
		NativeFieldInfoPtr_spatterCountMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "spatterCountMultiplier");
		NativeFieldInfoPtr_switchSFX1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "switchSFX1");
		NativeFieldInfoPtr_startingSwitchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "startingSwitchState");
		NativeFieldInfoPtr_startingCustomState1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "startingCustomState1");
		NativeFieldInfoPtr_startingCustomState2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "startingCustomState2");
		NativeFieldInfoPtr_startingCustomState3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "startingCustomState3");
		NativeFieldInfoPtr_startingLockState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "startingLockState");
		NativeFieldInfoPtr_valueMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "valueMin");
		NativeFieldInfoPtr_valueMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "valueMax");
		NativeFieldInfoPtr_tamperEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "tamperEnabled");
		NativeFieldInfoPtr_readingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "readingEnabled");
		NativeFieldInfoPtr_readingEnabledOnlyWithSwitchIsTue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "readingEnabledOnlyWithSwitchIsTue");
		NativeFieldInfoPtr_readingEnabledOnlyWithKaizenSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "readingEnabledOnlyWithKaizenSkill");
		NativeFieldInfoPtr_readingSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "readingSource");
		NativeFieldInfoPtr_discoverOnRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "discoverOnRead");
		NativeFieldInfoPtr_pageTurnReadingDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "pageTurnReadingDelay");
		NativeFieldInfoPtr_distanceRecognitionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "distanceRecognitionEnabled");
		NativeFieldInfoPtr_distanceRecognitionOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "distanceRecognitionOnly");
		NativeFieldInfoPtr_recognitionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "recognitionRange");
		NativeFieldInfoPtr_subObjectClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "subObjectClasses");
		NativeFieldInfoPtr_backupClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "backupClasses");
		NativeFieldInfoPtr_autoPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "autoPlacement");
		NativeFieldInfoPtr_alwaysPlaceAtGameLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "alwaysPlaceAtGameLocation");
		NativeFieldInfoPtr_frequencyPerGamelocationMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "frequencyPerGamelocationMin");
		NativeFieldInfoPtr_frequencyPerGameLocationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "frequencyPerGameLocationMax");
		NativeFieldInfoPtr_perGameLocationObjectPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "perGameLocationObjectPriority");
		NativeFieldInfoPtr_placeIfFiltersPresentInOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "placeIfFiltersPresentInOwner");
		NativeFieldInfoPtr_placeAtHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "placeAtHome");
		NativeFieldInfoPtr_placeAtWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "placeAtWork");
		NativeFieldInfoPtr_traitModifier1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "traitModifier1");
		NativeFieldInfoPtr_traitModifier2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "traitModifier2");
		NativeFieldInfoPtr_traitModifier3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "traitModifier3");
		NativeFieldInfoPtr_frequencyPerOwnerMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "frequencyPerOwnerMin");
		NativeFieldInfoPtr_frequencyPerOwnerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "frequencyPerOwnerMax");
		NativeFieldInfoPtr_multiplyByMessiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "multiplyByMessiness");
		NativeFieldInfoPtr_perOwnerObjectPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "perOwnerObjectPriority");
		NativeFieldInfoPtr_writerIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "writerIs");
		NativeFieldInfoPtr_receiverIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "receiverIs");
		NativeFieldInfoPtr_canBeFromSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "canBeFromSelf");
		NativeFieldInfoPtr_limitPerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "limitPerObject");
		NativeFieldInfoPtr_perObjectLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "perObjectLimit");
		NativeFieldInfoPtr_limitPerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "limitPerRoom");
		NativeFieldInfoPtr_perRoomLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "perRoomLimit");
		NativeFieldInfoPtr_limitPerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "limitPerAddress");
		NativeFieldInfoPtr_perAddressLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "perAddressLimit");
		NativeFieldInfoPtr_limitInResidential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "limitInResidential");
		NativeFieldInfoPtr_perResidentialLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "perResidentialLimit");
		NativeFieldInfoPtr_limitInCommercial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "limitInCommercial");
		NativeFieldInfoPtr_perCommercialLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "perCommercialLimit");
		NativeFieldInfoPtr_banFromRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "banFromRooms");
		NativeFieldInfoPtr_limitToCertainRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "limitToCertainRooms");
		NativeFieldInfoPtr_onlyInRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "onlyInRooms");
		NativeFieldInfoPtr_limitToCertainBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "limitToCertainBuildings");
		NativeFieldInfoPtr_onlyInBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "onlyInBuildings");
		NativeFieldInfoPtr_attemptToStoreInFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "attemptToStoreInFolder");
		NativeFieldInfoPtr_folderPlacementChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "folderPlacementChance");
		NativeFieldInfoPtr_dontPlaceIfNoFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "dontPlaceIfNoFolder");
		NativeFieldInfoPtr_folderOwnershipMustMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "folderOwnershipMustMatch");
		NativeFieldInfoPtr_useSubSpawning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "useSubSpawning");
		NativeFieldInfoPtr_securityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "securityLevel");
		NativeFieldInfoPtr_ownedRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "ownedRule");
		NativeFieldInfoPtr_overrideWithOnlyOwnedSpawnAtWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "overrideWithOnlyOwnedSpawnAtWork");
		NativeFieldInfoPtr_relocationAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "relocationAuthority");
		NativeFieldInfoPtr_relocateIfPlacedInPlayersHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "relocateIfPlacedInPlayersHome");
		NativeFieldInfoPtr_AIWillCorrectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "AIWillCorrectPosition");
		NativeFieldInfoPtr_locationIsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "locationIsParent");
		NativeFieldInfoPtr_summaryMessageSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "summaryMessageSource");
		NativeFieldInfoPtr_isComputer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isComputer");
		NativeFieldInfoPtr_bootApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "bootApp");
		NativeFieldInfoPtr_logInApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "logInApp");
		NativeFieldInfoPtr_desktopApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "desktopApp");
		NativeFieldInfoPtr_additionalApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "additionalApps");
		NativeFieldInfoPtr_fingerprintsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fingerprintsEnabled");
		NativeFieldInfoPtr_printsSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "printsSource");
		NativeFieldInfoPtr_fingerprintDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fingerprintDensity");
		NativeFieldInfoPtr_enableDynamicFingerprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "enableDynamicFingerprints");
		NativeFieldInfoPtr_disableDynamicFingerprintsFromStaticPrintsSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "disableDynamicFingerprintsFromStaticPrintsSources");
		NativeFieldInfoPtr_overrideMaxDynamicFingerprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "overrideMaxDynamicFingerprints");
		NativeFieldInfoPtr_maxDynamicFingerprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "maxDynamicFingerprints");
		NativeFieldInfoPtr_fpsItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItem");
		NativeFieldInfoPtr_isInventoryItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isInventoryItem");
		NativeFieldInfoPtr_fpsItemOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItemOffsetX");
		NativeFieldInfoPtr_fpsItemOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItemOffsetY");
		NativeFieldInfoPtr_fpsItemOffsetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItemOffsetZ");
		NativeFieldInfoPtr_fpsItemRotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItemRotationX");
		NativeFieldInfoPtr_fpsItemRotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItemRotationY");
		NativeFieldInfoPtr_fpsItemRotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItemRotationZ");
		NativeFieldInfoPtr_fpsItemScaleModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "fpsItemScaleModifier");
		NativeFieldInfoPtr_consumableAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "consumableAmount");
		NativeFieldInfoPtr_destroyWhenAllConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "destroyWhenAllConsumed");
		NativeFieldInfoPtr_useSameModelAsTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "useSameModelAsTrash");
		NativeFieldInfoPtr_trashItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "trashItem");
		NativeFieldInfoPtr_disposal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "disposal");
		NativeFieldInfoPtr_chanceOfDroppedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "chanceOfDroppedAngle");
		NativeFieldInfoPtr_droppedAngleHeightBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "droppedAngleHeightBoost");
		NativeFieldInfoPtr_weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "weapon");
		NativeFieldInfoPtr_inventoryCarryItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "inventoryCarryItem");
		NativeFieldInfoPtr_requiredCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "requiredCarryAnimation");
		NativeFieldInfoPtr_aiCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "aiCarryAnimation");
		NativeFieldInfoPtr_aiHeldObjectPositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "aiHeldObjectPositionX");
		NativeFieldInfoPtr_aiHeldObjectPositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "aiHeldObjectPositionY");
		NativeFieldInfoPtr_aiHeldObjectPositionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "aiHeldObjectPositionZ");
		NativeFieldInfoPtr_aiHeldObjectRotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "aiHeldObjectRotationX");
		NativeFieldInfoPtr_aiHeldObjectRotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "aiHeldObjectRotationY");
		NativeFieldInfoPtr_aiHeldObjectRotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "aiHeldObjectRotationZ");
		NativeFieldInfoPtr_putDownAtHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "putDownAtHome");
		NativeFieldInfoPtr_takeWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "takeWith");
		NativeFieldInfoPtr_putDownPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "putDownPositions");
		NativeFieldInfoPtr_backupPutDownPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "backupPutDownPositions");
		NativeFieldInfoPtr_specialCaseFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "specialCaseFlag");
		NativeFieldInfoPtr_affectRoomSteamLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "affectRoomSteamLevel");
		NativeFieldInfoPtr_isPayphone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isPayphone");
		NativeFieldInfoPtr_isClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isClock");
		NativeFieldInfoPtr_isMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isMoney");
		NativeFieldInfoPtr_entertainmentSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "entertainmentSource");
		NativeFieldInfoPtr_isHeatSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isHeatSource");
		NativeFieldInfoPtr_markAsTrashOnCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "markAsTrashOnCreate");
		NativeFieldInfoPtr_isLitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isLitter");
		NativeFieldInfoPtr_isDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isDecal");
		NativeFieldInfoPtr_isMovableChair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "isMovableChair");
		NativeFieldInfoPtr_bedRightSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "bedRightSide");
		NativeFieldInfoPtr_resetSwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "resetSwitchStates");
		NativeFieldInfoPtr_resetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "resetTimer");
		NativeFieldInfoPtr_dontSaveSwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "dontSaveSwitchStates");
		NativeFieldInfoPtr_dontLoadSwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "dontLoadSwitchStates");
		NativeFieldInfoPtr_recordCreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "recordCreationTime");
		NativeFieldInfoPtr_retailItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "retailItem");
		NativeFieldInfoPtr_menuOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "menuOverride");
		NativeFieldInfoPtr_chimeEqualToHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "chimeEqualToHour");
		NativeFieldInfoPtr_chimeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, "chimeDelay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr, 100673194);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModdedInteractable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModdedInteractable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModdedInteractable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
