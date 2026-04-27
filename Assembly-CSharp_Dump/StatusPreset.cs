using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class StatusPreset : SoCustomComparison
{
	public enum ProgressBarTrack
	{
		none,
		witnesses,
		wantedInBuilding,
		alarmTime,
		guestPassTime
	}

	public enum StatusCountType
	{
		none,
		crime
	}

	[System.Serializable]
	public class StatusCountConfig : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_icon;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour;

		private static readonly System.IntPtr NativeFieldInfoPtr_penaltyRule;

		private static readonly System.IntPtr NativeFieldInfoPtr_penalty;

		private static readonly System.IntPtr NativeFieldInfoPtr_onAcquire;

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

		public unsafe Sprite icon
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Color colour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)) = color;
			}
		}

		public unsafe PenaltyRule penaltyRule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penaltyRule);
				return *(PenaltyRule*)num;
			}
			set
			{
				*(PenaltyRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penaltyRule)) = penaltyRule;
			}
		}

		public unsafe float penalty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penalty);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penalty)) = num;
			}
		}

		public unsafe AudioEvent onAcquire
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onAcquire);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onAcquire)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		static StatusCountConfig()
		{
			Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "StatusCountConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr, "name");
			NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr, "icon");
			NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr, "colour");
			NativeFieldInfoPtr_penaltyRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr, "penaltyRule");
			NativeFieldInfoPtr_penalty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr, "penalty");
			NativeFieldInfoPtr_onAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr, "onAcquire");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr, 100674050);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusCountConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusCountConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StatusCountConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum PenaltyRule
	{
		fixedValue,
		percentageValue,
		objectValueMultiplied
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_alternateColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_alternateIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimizeToIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulseBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulseIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulseIconAdditiveColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_includeDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoNotificationMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeToWhite;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableProgressBar;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTracking;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCustomMethod;

	private static readonly System.IntPtr NativeFieldInfoPtr_onAcquire;

	private static readonly System.IntPtr NativeFieldInfoPtr_onRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_countType;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrrideColorWithCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayCountCountsInMainText;

	private static readonly System.IntPtr NativeFieldInfoPtr_replaceDescriptionBasedOnCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayAddressInDetailText;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayBuildingInDetailText;

	private static readonly System.IntPtr NativeFieldInfoPtr_listCountsInDetailText;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayFineTotalInMainText;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertWhenNewCountIsAdded;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayTotalFineWhenMinimized;

	private static readonly System.IntPtr NativeFieldInfoPtr_countConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopsRecovery;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopsSprint;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopsJump;

	private static readonly System.IntPtr NativeFieldInfoPtr_recoveryRatePlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHealthPlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeedPlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_temperatureGainPlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageIncomingPlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageOutgoingPlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkControls;

	private static readonly System.IntPtr NativeFieldInfoPtr_tripChanceWet;

	private static readonly System.IntPtr NativeFieldInfoPtr_tripChanceDrunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_affectHeadBob;

	private static readonly System.IntPtr NativeFieldInfoPtr_headBob;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkVision;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverVision;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkLensDistort;

	private static readonly System.IntPtr NativeFieldInfoPtr_headacheVision;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloomIntensityPlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionBlurPlusMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_chromaticAbberationAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_vignetteAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_expsosure;

	private static readonly System.IntPtr NativeFieldInfoPtr_useChannelMixer;

	private static readonly System.IntPtr NativeFieldInfoPtr_redR;

	private static readonly System.IntPtr NativeFieldInfoPtr_redG;

	private static readonly System.IntPtr NativeFieldInfoPtr_redB;

	private static readonly System.IntPtr NativeFieldInfoPtr_greenR;

	private static readonly System.IntPtr NativeFieldInfoPtr_greenG;

	private static readonly System.IntPtr NativeFieldInfoPtr_greenB;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueR;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueG;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueB;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Color color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
		}
	}

	public unsafe Color alternateColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alternateColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alternateColour)) = color;
		}
	}

	public unsafe Sprite icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite alternateIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alternateIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alternateIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe bool minimizeToIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeToIcon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeToIcon)) = flag;
		}
	}

	public unsafe bool pulseBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseBackground);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseBackground)) = flag;
		}
	}

	public unsafe bool pulseIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseIcon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseIcon)) = flag;
		}
	}

	public unsafe Color pulseIconAdditiveColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseIconAdditiveColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseIconAdditiveColour)) = color;
		}
	}

	public unsafe bool includeDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeDescription);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeDescription)) = flag;
		}
	}

	public unsafe bool autoNotificationMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoNotificationMessage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoNotificationMessage)) = flag;
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

	public unsafe bool fadeToWhite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeToWhite);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeToWhite)) = flag;
		}
	}

	public unsafe bool enableProgressBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableProgressBar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableProgressBar)) = flag;
		}
	}

	public unsafe ProgressBarTrack barTracking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barTracking);
			return *(ProgressBarTrack*)num;
		}
		set
		{
			*(ProgressBarTrack*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barTracking)) = progressBarTrack;
		}
	}

	public unsafe bool useCustomMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomMethod);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomMethod)) = flag;
		}
	}

	public unsafe AudioEvent onAcquire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onAcquire);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onAcquire)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent onRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRemove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRemove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe StatusCountType countType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countType);
			return *(StatusCountType*)num;
		}
		set
		{
			*(StatusCountType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countType)) = statusCountType;
		}
	}

	public unsafe bool overrrideColorWithCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrrideColorWithCount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrrideColorWithCount)) = flag;
		}
	}

	public unsafe bool displayCountCountsInMainText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayCountCountsInMainText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayCountCountsInMainText)) = flag;
		}
	}

	public unsafe bool replaceDescriptionBasedOnCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceDescriptionBasedOnCounts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceDescriptionBasedOnCounts)) = flag;
		}
	}

	public unsafe bool displayAddressInDetailText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayAddressInDetailText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayAddressInDetailText)) = flag;
		}
	}

	public unsafe bool displayBuildingInDetailText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayBuildingInDetailText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayBuildingInDetailText)) = flag;
		}
	}

	public unsafe bool listCountsInDetailText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listCountsInDetailText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listCountsInDetailText)) = flag;
		}
	}

	public unsafe bool displayFineTotalInMainText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayFineTotalInMainText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayFineTotalInMainText)) = flag;
		}
	}

	public unsafe bool alertWhenNewCountIsAdded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertWhenNewCountIsAdded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertWhenNewCountIsAdded)) = flag;
		}
	}

	public unsafe bool displayTotalFineWhenMinimized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayTotalFineWhenMinimized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayTotalFineWhenMinimized)) = flag;
		}
	}

	public unsafe List<StatusCountConfig> countConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StatusCountConfig>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool stopsRecovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopsRecovery);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopsRecovery)) = flag;
		}
	}

	public unsafe bool stopsSprint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopsSprint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopsSprint)) = flag;
		}
	}

	public unsafe bool stopsJump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopsJump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopsJump)) = flag;
		}
	}

	public unsafe float recoveryRatePlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRatePlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRatePlusMP)) = num;
		}
	}

	public unsafe float maxHealthPlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealthPlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealthPlusMP)) = num;
		}
	}

	public unsafe float movementSpeedPlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedPlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedPlusMP)) = num;
		}
	}

	public unsafe float temperatureGainPlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperatureGainPlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperatureGainPlusMP)) = num;
		}
	}

	public unsafe float damageIncomingPlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageIncomingPlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageIncomingPlusMP)) = num;
		}
	}

	public unsafe float damageOutgoingPlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageOutgoingPlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageOutgoingPlusMP)) = num;
		}
	}

	public unsafe float drunkControls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkControls);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkControls)) = num;
		}
	}

	public unsafe float tripChanceWet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceWet);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceWet)) = num;
		}
	}

	public unsafe float tripChanceDrunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceDrunk);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceDrunk)) = num;
		}
	}

	public unsafe float affectHeadBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectHeadBob);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectHeadBob)) = num;
		}
	}

	public unsafe AnimationCurve headBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headBob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headBob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float drunkVision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkVision);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkVision)) = num;
		}
	}

	public unsafe float shiverVision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverVision);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverVision)) = num;
		}
	}

	public unsafe float drunkLensDistort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistort);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistort)) = num;
		}
	}

	public unsafe float headacheVision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheVision);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheVision)) = num;
		}
	}

	public unsafe float bloomIntensityPlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensityPlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensityPlusMP)) = num;
		}
	}

	public unsafe float motionBlurPlusMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurPlusMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurPlusMP)) = num;
		}
	}

	public unsafe float chromaticAbberationAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAbberationAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAbberationAmount)) = num;
		}
	}

	public unsafe float vignetteAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignetteAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignetteAmount)) = num;
		}
	}

	public unsafe float expsosure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expsosure);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expsosure)) = num;
		}
	}

	public unsafe bool useChannelMixer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useChannelMixer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useChannelMixer)) = flag;
		}
	}

	public unsafe int redR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redR)) = num;
		}
	}

	public unsafe int redG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redG)) = num;
		}
	}

	public unsafe int redB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redB)) = num;
		}
	}

	public unsafe int greenR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenR)) = num;
		}
	}

	public unsafe int greenG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenG)) = num;
		}
	}

	public unsafe int greenB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenB)) = num;
		}
	}

	public unsafe int blueR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueR)) = num;
		}
	}

	public unsafe int blueG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueG)) = num;
		}
	}

	public unsafe int blueB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueB)) = num;
		}
	}

	static StatusPreset()
	{
		Il2CppClassPointerStore<StatusPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr);
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "color");
		NativeFieldInfoPtr_alternateColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "alternateColour");
		NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "icon");
		NativeFieldInfoPtr_alternateIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "alternateIcon");
		NativeFieldInfoPtr_minimizeToIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "minimizeToIcon");
		NativeFieldInfoPtr_pulseBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "pulseBackground");
		NativeFieldInfoPtr_pulseIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "pulseIcon");
		NativeFieldInfoPtr_pulseIconAdditiveColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "pulseIconAdditiveColour");
		NativeFieldInfoPtr_includeDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "includeDescription");
		NativeFieldInfoPtr_autoNotificationMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "autoNotificationMessage");
		NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "priority");
		NativeFieldInfoPtr_fadeToWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "fadeToWhite");
		NativeFieldInfoPtr_enableProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "enableProgressBar");
		NativeFieldInfoPtr_barTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "barTracking");
		NativeFieldInfoPtr_useCustomMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "useCustomMethod");
		NativeFieldInfoPtr_onAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "onAcquire");
		NativeFieldInfoPtr_onRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "onRemove");
		NativeFieldInfoPtr_countType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "countType");
		NativeFieldInfoPtr_overrrideColorWithCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "overrrideColorWithCount");
		NativeFieldInfoPtr_displayCountCountsInMainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "displayCountCountsInMainText");
		NativeFieldInfoPtr_replaceDescriptionBasedOnCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "replaceDescriptionBasedOnCounts");
		NativeFieldInfoPtr_displayAddressInDetailText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "displayAddressInDetailText");
		NativeFieldInfoPtr_displayBuildingInDetailText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "displayBuildingInDetailText");
		NativeFieldInfoPtr_listCountsInDetailText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "listCountsInDetailText");
		NativeFieldInfoPtr_displayFineTotalInMainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "displayFineTotalInMainText");
		NativeFieldInfoPtr_alertWhenNewCountIsAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "alertWhenNewCountIsAdded");
		NativeFieldInfoPtr_displayTotalFineWhenMinimized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "displayTotalFineWhenMinimized");
		NativeFieldInfoPtr_countConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "countConfig");
		NativeFieldInfoPtr_stopsRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "stopsRecovery");
		NativeFieldInfoPtr_stopsSprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "stopsSprint");
		NativeFieldInfoPtr_stopsJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "stopsJump");
		NativeFieldInfoPtr_recoveryRatePlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "recoveryRatePlusMP");
		NativeFieldInfoPtr_maxHealthPlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "maxHealthPlusMP");
		NativeFieldInfoPtr_movementSpeedPlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "movementSpeedPlusMP");
		NativeFieldInfoPtr_temperatureGainPlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "temperatureGainPlusMP");
		NativeFieldInfoPtr_damageIncomingPlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "damageIncomingPlusMP");
		NativeFieldInfoPtr_damageOutgoingPlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "damageOutgoingPlusMP");
		NativeFieldInfoPtr_drunkControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "drunkControls");
		NativeFieldInfoPtr_tripChanceWet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "tripChanceWet");
		NativeFieldInfoPtr_tripChanceDrunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "tripChanceDrunk");
		NativeFieldInfoPtr_affectHeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "affectHeadBob");
		NativeFieldInfoPtr_headBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "headBob");
		NativeFieldInfoPtr_drunkVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "drunkVision");
		NativeFieldInfoPtr_shiverVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "shiverVision");
		NativeFieldInfoPtr_drunkLensDistort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "drunkLensDistort");
		NativeFieldInfoPtr_headacheVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "headacheVision");
		NativeFieldInfoPtr_bloomIntensityPlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "bloomIntensityPlusMP");
		NativeFieldInfoPtr_motionBlurPlusMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "motionBlurPlusMP");
		NativeFieldInfoPtr_chromaticAbberationAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "chromaticAbberationAmount");
		NativeFieldInfoPtr_vignetteAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "vignetteAmount");
		NativeFieldInfoPtr_expsosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "expsosure");
		NativeFieldInfoPtr_useChannelMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "useChannelMixer");
		NativeFieldInfoPtr_redR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "redR");
		NativeFieldInfoPtr_redG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "redG");
		NativeFieldInfoPtr_redB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "redB");
		NativeFieldInfoPtr_greenR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "greenR");
		NativeFieldInfoPtr_greenG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "greenG");
		NativeFieldInfoPtr_greenB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "greenB");
		NativeFieldInfoPtr_blueR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "blueR");
		NativeFieldInfoPtr_blueG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "blueG");
		NativeFieldInfoPtr_blueB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, "blueB");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr, 100674049);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330385, XrefRangeEnd = 330393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StatusPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StatusPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
