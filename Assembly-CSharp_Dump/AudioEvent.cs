using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class AudioEvent : SoCustomComparison
{
	public enum MemoryTag
	{
		none,
		gunshot,
		scream
	}

	private static readonly IntPtr NativeFieldInfoPtr_guid;

	private static readonly IntPtr NativeFieldInfoPtr_disableOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_debug;

	private static readonly IntPtr NativeFieldInfoPtr_isDummyEvent;

	private static readonly IntPtr NativeFieldInfoPtr_isLicensed;

	private static readonly IntPtr NativeFieldInfoPtr_pauseWhenGameIsPaused;

	private static readonly IntPtr NativeFieldInfoPtr_disabled;

	private static readonly IntPtr NativeFieldInfoPtr_canPenetrateWalls;

	private static readonly IntPtr NativeFieldInfoPtr_canPenetrateFloors;

	private static readonly IntPtr NativeFieldInfoPtr_canPenetrateCeilings;

	private static readonly IntPtr NativeFieldInfoPtr_overrideMaximumLoops;

	private static readonly IntPtr NativeFieldInfoPtr_overriddenMaxLoops;

	private static readonly IntPtr NativeFieldInfoPtr_overrideOcclusionModifier;

	private static readonly IntPtr NativeFieldInfoPtr_occlusionUnitVolumeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_overrideOpenDoorOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_openDoorOcclusionUnits;

	private static readonly IntPtr NativeFieldInfoPtr_overrideClosedDoorOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_closedDoorOcclusionUnits;

	private static readonly IntPtr NativeFieldInfoPtr_overrideWindowOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_windowOcclusionUnits;

	private static readonly IntPtr NativeFieldInfoPtr_overrideWallOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_wallOcclusionUnits;

	private static readonly IntPtr NativeFieldInfoPtr_overrideCeilingOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_ceilingOcclusionUnits;

	private static readonly IntPtr NativeFieldInfoPtr_overrideFloorOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_floorOcclusionUnits;

	private static readonly IntPtr NativeFieldInfoPtr_forceVolumeLevelFadeTime;

	private static readonly IntPtr NativeFieldInfoPtr_volumeLevelFadeTime;

	private static readonly IntPtr NativeFieldInfoPtr_canBeSuspicious;

	private static readonly IntPtr NativeFieldInfoPtr_alwaysSuspicious;

	private static readonly IntPtr NativeFieldInfoPtr_suspiciousIfTresspassing;

	private static readonly IntPtr NativeFieldInfoPtr_suspiciousIfCantSeeSoundMaker;

	private static readonly IntPtr NativeFieldInfoPtr_onlySuspiciousIfEmptyAddress;

	private static readonly IntPtr NativeFieldInfoPtr_onlySuspiciousIfNotEnforcer;

	private static readonly IntPtr NativeFieldInfoPtr_suspiciousIfCitizenCount;

	private static readonly IntPtr NativeFieldInfoPtr_urgentResponse;

	private static readonly IntPtr NativeFieldInfoPtr_audioFocus;

	private static readonly IntPtr NativeFieldInfoPtr_forceOutlineForLoopIfPlayerTrespassing;

	private static readonly IntPtr NativeFieldInfoPtr_citizenMemoryTag;

	private static readonly IntPtr NativeFieldInfoPtr_spookValue;

	private static readonly IntPtr NativeFieldInfoPtr_noSpookIfEnforcer;

	private static readonly IntPtr NativeFieldInfoPtr_awakenChance;

	private static readonly IntPtr NativeFieldInfoPtr_actualSoundRange;

	private static readonly IntPtr NativeFieldInfoPtr_hearingRange;

	private static readonly IntPtr NativeFieldInfoPtr_stealthModeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_runModifier;

	private static readonly IntPtr NativeFieldInfoPtr_canDanceTo;

	private static readonly IntPtr NativeFieldInfoPtr_masterVolumeScale;

	private static readonly IntPtr NativeFieldInfoPtr_modifyBasedOnSurface;

	private static readonly IntPtr NativeFieldInfoPtr_concreteHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_woodHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_carpetHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_tileHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_plasterHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_fabricHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_metalHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_glassHearingRangeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_enableVibrationOnPlay;

	private static readonly IntPtr NativeFieldInfoPtr_disableForPS5;

	private static readonly IntPtr NativeFieldInfoPtr_vibrationSetup;

	private static readonly IntPtr NativeMethodInfoPtr_OnGUIDValueChangedCallback_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string guid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guid);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guid)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool disableOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableOcclusion)) = flag;
		}
	}

	public unsafe bool debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)) = flag;
		}
	}

	public unsafe bool isDummyEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDummyEvent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDummyEvent)) = flag;
		}
	}

	public unsafe bool isLicensed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLicensed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLicensed)) = flag;
		}
	}

	public unsafe bool pauseWhenGameIsPaused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseWhenGameIsPaused);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseWhenGameIsPaused)) = flag;
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

	public unsafe bool canPenetrateWalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateWalls);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateWalls)) = flag;
		}
	}

	public unsafe bool canPenetrateFloors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateFloors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateFloors)) = flag;
		}
	}

	public unsafe bool canPenetrateCeilings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateCeilings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateCeilings)) = flag;
		}
	}

	public unsafe bool overrideMaximumLoops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaximumLoops);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaximumLoops)) = flag;
		}
	}

	public unsafe int overriddenMaxLoops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overriddenMaxLoops);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overriddenMaxLoops)) = num;
		}
	}

	public unsafe bool overrideOcclusionModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOcclusionModifier);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOcclusionModifier)) = flag;
		}
	}

	public unsafe float occlusionUnitVolumeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionUnitVolumeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionUnitVolumeModifier)) = num;
		}
	}

	public unsafe bool overrideOpenDoorOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOpenDoorOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOpenDoorOcclusion)) = flag;
		}
	}

	public unsafe int openDoorOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoorOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoorOcclusionUnits)) = num;
		}
	}

	public unsafe bool overrideClosedDoorOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideClosedDoorOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideClosedDoorOcclusion)) = flag;
		}
	}

	public unsafe int closedDoorOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedDoorOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedDoorOcclusionUnits)) = num;
		}
	}

	public unsafe bool overrideWindowOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWindowOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWindowOcclusion)) = flag;
		}
	}

	public unsafe int windowOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowOcclusionUnits)) = num;
		}
	}

	public unsafe bool overrideWallOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWallOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWallOcclusion)) = flag;
		}
	}

	public unsafe int wallOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallOcclusionUnits)) = num;
		}
	}

	public unsafe bool overrideCeilingOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCeilingOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCeilingOcclusion)) = flag;
		}
	}

	public unsafe int ceilingOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingOcclusionUnits)) = num;
		}
	}

	public unsafe bool overrideFloorOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFloorOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFloorOcclusion)) = flag;
		}
	}

	public unsafe int floorOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOcclusionUnits)) = num;
		}
	}

	public unsafe bool forceVolumeLevelFadeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceVolumeLevelFadeTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceVolumeLevelFadeTime)) = flag;
		}
	}

	public unsafe float volumeLevelFadeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeLevelFadeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeLevelFadeTime)) = num;
		}
	}

	public unsafe bool canBeSuspicious
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeSuspicious);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeSuspicious)) = flag;
		}
	}

	public unsafe bool alwaysSuspicious
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysSuspicious);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysSuspicious)) = flag;
		}
	}

	public unsafe bool suspiciousIfTresspassing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspiciousIfTresspassing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspiciousIfTresspassing)) = flag;
		}
	}

	public unsafe bool suspiciousIfCantSeeSoundMaker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspiciousIfCantSeeSoundMaker);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspiciousIfCantSeeSoundMaker)) = flag;
		}
	}

	public unsafe bool onlySuspiciousIfEmptyAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySuspiciousIfEmptyAddress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySuspiciousIfEmptyAddress)) = flag;
		}
	}

	public unsafe bool onlySuspiciousIfNotEnforcer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySuspiciousIfNotEnforcer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySuspiciousIfNotEnforcer)) = flag;
		}
	}

	public unsafe int suspiciousIfCitizenCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspiciousIfCitizenCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspiciousIfCitizenCount)) = num;
		}
	}

	public unsafe bool urgentResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_urgentResponse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_urgentResponse)) = flag;
		}
	}

	public unsafe float audioFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioFocus);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioFocus)) = num;
		}
	}

	public unsafe bool forceOutlineForLoopIfPlayerTrespassing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceOutlineForLoopIfPlayerTrespassing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceOutlineForLoopIfPlayerTrespassing)) = flag;
		}
	}

	public unsafe MemoryTag citizenMemoryTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenMemoryTag);
			return *(MemoryTag*)num;
		}
		set
		{
			*(MemoryTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenMemoryTag)) = memoryTag;
		}
	}

	public unsafe float spookValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookValue)) = num;
		}
	}

	public unsafe bool noSpookIfEnforcer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noSpookIfEnforcer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noSpookIfEnforcer)) = flag;
		}
	}

	public unsafe float awakenChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awakenChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awakenChance)) = num;
		}
	}

	public unsafe float actualSoundRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualSoundRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualSoundRange)) = num;
		}
	}

	public unsafe float hearingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearingRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearingRange)) = num;
		}
	}

	public unsafe float stealthModeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeModifier)) = num;
		}
	}

	public unsafe float runModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runModifier)) = num;
		}
	}

	public unsafe bool canDanceTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canDanceTo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canDanceTo)) = flag;
		}
	}

	public unsafe float masterVolumeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterVolumeScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_masterVolumeScale)) = num;
		}
	}

	public unsafe bool modifyBasedOnSurface
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyBasedOnSurface);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifyBasedOnSurface)) = flag;
		}
	}

	public unsafe float concreteHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concreteHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concreteHearingRangeModifier)) = num;
		}
	}

	public unsafe float woodHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_woodHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_woodHearingRangeModifier)) = num;
		}
	}

	public unsafe float carpetHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carpetHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carpetHearingRangeModifier)) = num;
		}
	}

	public unsafe float tileHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileHearingRangeModifier)) = num;
		}
	}

	public unsafe float plasterHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plasterHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plasterHearingRangeModifier)) = num;
		}
	}

	public unsafe float fabricHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fabricHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fabricHearingRangeModifier)) = num;
		}
	}

	public unsafe float metalHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metalHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metalHearingRangeModifier)) = num;
		}
	}

	public unsafe float glassHearingRangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassHearingRangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassHearingRangeModifier)) = num;
		}
	}

	public unsafe bool enableVibrationOnPlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableVibrationOnPlay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableVibrationOnPlay)) = flag;
		}
	}

	public unsafe bool disableForPS5
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableForPS5);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableForPS5)) = flag;
		}
	}

	public unsafe List<InputController.ControllerVibration> vibrationSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vibrationSetup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InputController.ControllerVibration>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vibrationSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AudioEvent()
	{
		Il2CppClassPointerStore<AudioEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr);
		NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "guid");
		NativeFieldInfoPtr_disableOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "disableOcclusion");
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "debug");
		NativeFieldInfoPtr_isDummyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "isDummyEvent");
		NativeFieldInfoPtr_isLicensed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "isLicensed");
		NativeFieldInfoPtr_pauseWhenGameIsPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "pauseWhenGameIsPaused");
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_canPenetrateWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "canPenetrateWalls");
		NativeFieldInfoPtr_canPenetrateFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "canPenetrateFloors");
		NativeFieldInfoPtr_canPenetrateCeilings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "canPenetrateCeilings");
		NativeFieldInfoPtr_overrideMaximumLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideMaximumLoops");
		NativeFieldInfoPtr_overriddenMaxLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overriddenMaxLoops");
		NativeFieldInfoPtr_overrideOcclusionModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideOcclusionModifier");
		NativeFieldInfoPtr_occlusionUnitVolumeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "occlusionUnitVolumeModifier");
		NativeFieldInfoPtr_overrideOpenDoorOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideOpenDoorOcclusion");
		NativeFieldInfoPtr_openDoorOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "openDoorOcclusionUnits");
		NativeFieldInfoPtr_overrideClosedDoorOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideClosedDoorOcclusion");
		NativeFieldInfoPtr_closedDoorOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "closedDoorOcclusionUnits");
		NativeFieldInfoPtr_overrideWindowOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideWindowOcclusion");
		NativeFieldInfoPtr_windowOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "windowOcclusionUnits");
		NativeFieldInfoPtr_overrideWallOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideWallOcclusion");
		NativeFieldInfoPtr_wallOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "wallOcclusionUnits");
		NativeFieldInfoPtr_overrideCeilingOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideCeilingOcclusion");
		NativeFieldInfoPtr_ceilingOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "ceilingOcclusionUnits");
		NativeFieldInfoPtr_overrideFloorOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "overrideFloorOcclusion");
		NativeFieldInfoPtr_floorOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "floorOcclusionUnits");
		NativeFieldInfoPtr_forceVolumeLevelFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "forceVolumeLevelFadeTime");
		NativeFieldInfoPtr_volumeLevelFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "volumeLevelFadeTime");
		NativeFieldInfoPtr_canBeSuspicious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "canBeSuspicious");
		NativeFieldInfoPtr_alwaysSuspicious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "alwaysSuspicious");
		NativeFieldInfoPtr_suspiciousIfTresspassing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "suspiciousIfTresspassing");
		NativeFieldInfoPtr_suspiciousIfCantSeeSoundMaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "suspiciousIfCantSeeSoundMaker");
		NativeFieldInfoPtr_onlySuspiciousIfEmptyAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "onlySuspiciousIfEmptyAddress");
		NativeFieldInfoPtr_onlySuspiciousIfNotEnforcer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "onlySuspiciousIfNotEnforcer");
		NativeFieldInfoPtr_suspiciousIfCitizenCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "suspiciousIfCitizenCount");
		NativeFieldInfoPtr_urgentResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "urgentResponse");
		NativeFieldInfoPtr_audioFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "audioFocus");
		NativeFieldInfoPtr_forceOutlineForLoopIfPlayerTrespassing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "forceOutlineForLoopIfPlayerTrespassing");
		NativeFieldInfoPtr_citizenMemoryTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "citizenMemoryTag");
		NativeFieldInfoPtr_spookValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "spookValue");
		NativeFieldInfoPtr_noSpookIfEnforcer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "noSpookIfEnforcer");
		NativeFieldInfoPtr_awakenChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "awakenChance");
		NativeFieldInfoPtr_actualSoundRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "actualSoundRange");
		NativeFieldInfoPtr_hearingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "hearingRange");
		NativeFieldInfoPtr_stealthModeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "stealthModeModifier");
		NativeFieldInfoPtr_runModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "runModifier");
		NativeFieldInfoPtr_canDanceTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "canDanceTo");
		NativeFieldInfoPtr_masterVolumeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "masterVolumeScale");
		NativeFieldInfoPtr_modifyBasedOnSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "modifyBasedOnSurface");
		NativeFieldInfoPtr_concreteHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "concreteHearingRangeModifier");
		NativeFieldInfoPtr_woodHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "woodHearingRangeModifier");
		NativeFieldInfoPtr_carpetHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "carpetHearingRangeModifier");
		NativeFieldInfoPtr_tileHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "tileHearingRangeModifier");
		NativeFieldInfoPtr_plasterHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "plasterHearingRangeModifier");
		NativeFieldInfoPtr_fabricHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "fabricHearingRangeModifier");
		NativeFieldInfoPtr_metalHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "metalHearingRangeModifier");
		NativeFieldInfoPtr_glassHearingRangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "glassHearingRangeModifier");
		NativeFieldInfoPtr_enableVibrationOnPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "enableVibrationOnPlay");
		NativeFieldInfoPtr_disableForPS5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "disableForPS5");
		NativeFieldInfoPtr_vibrationSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, "vibrationSetup");
		NativeMethodInfoPtr_OnGUIDValueChangedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, 100673789);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr, 100673790);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326707, XrefRangeEnd = 326723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUIDValueChangedCallback()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUIDValueChangedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326723, XrefRangeEnd = 326731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AudioEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
