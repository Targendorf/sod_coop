using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class FirstPersonItem : SoCustomComparison
{
	public enum SpecialAction
	{
		none,
		block,
		handcuff,
		takedown,
		punch,
		consumeTrue,
		consumeFalse,
		putDown,
		attack,
		raiseTrue,
		raiseFalse,
		takePicture,
		placeCodebreaker,
		placeDoorWedge,
		takeOne,
		placeFurniture,
		cancelFurniture,
		give,
		placeTracker,
		placeFlashbomb,
		placeIncapacitator,
		takeBriefcaseCash,
		openBriefcaseBomb,
		rotateFurnLeft,
		rotateFurnRight,
		putBriefcaseCash,
		camFlashOn,
		camFlashOff,
		smoke
	}

	[Serializable]
	public class FPSInteractionAction : InteractablePreset.InteractionAction
	{
		private static readonly IntPtr NativeFieldInfoPtr_availability;

		private static readonly IntPtr NativeFieldInfoPtr_steamVersionOnly;

		private static readonly IntPtr NativeFieldInfoPtr_attackMainSpeed;

		private static readonly IntPtr NativeFieldInfoPtr_attackTrasition;

		private static readonly IntPtr NativeFieldInfoPtr_attackDelay;

		private static readonly IntPtr NativeFieldInfoPtr_mainSpecialAction;

		private static readonly IntPtr NativeFieldInfoPtr_mainUseSpecialColour;

		private static readonly IntPtr NativeFieldInfoPtr_mainSpecialColour;

		private static readonly IntPtr NativeFieldInfoPtr_attackEvent;

		private static readonly IntPtr NativeFieldInfoPtr_useCameraJolt;

		private static readonly IntPtr NativeFieldInfoPtr_joltXRange;

		private static readonly IntPtr NativeFieldInfoPtr_joltYRange;

		private static readonly IntPtr NativeFieldInfoPtr_joltZRange;

		private static readonly IntPtr NativeFieldInfoPtr_joltAmplitude;

		private static readonly IntPtr NativeFieldInfoPtr_joltSpeed;

		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe AttackAvailability availability
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availability);
				return *(AttackAvailability*)num;
			}
			set
			{
				*(AttackAvailability*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availability)) = attackAvailability;
			}
		}

		public unsafe bool steamVersionOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamVersionOnly);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamVersionOnly)) = flag;
			}
		}

		public unsafe float attackMainSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackMainSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackMainSpeed)) = num;
			}
		}

		public unsafe PlayerTransitionPreset attackTrasition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTrasition);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTrasition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
			}
		}

		public unsafe float attackDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDelay)) = num;
			}
		}

		public unsafe SpecialAction mainSpecialAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainSpecialAction);
				return *(SpecialAction*)num;
			}
			set
			{
				*(SpecialAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainSpecialAction)) = specialAction;
			}
		}

		public unsafe bool mainUseSpecialColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainUseSpecialColour);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainUseSpecialColour)) = flag;
			}
		}

		public unsafe Color mainSpecialColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainSpecialColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainSpecialColour)) = color;
			}
		}

		public unsafe AudioEvent attackEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackEvent);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe bool useCameraJolt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCameraJolt);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCameraJolt)) = flag;
			}
		}

		public unsafe Vector2 joltXRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltXRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltXRange)) = vector;
			}
		}

		public unsafe Vector2 joltYRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltYRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltYRange)) = vector;
			}
		}

		public unsafe Vector2 joltZRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltZRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltZRange)) = vector;
			}
		}

		public unsafe float joltAmplitude
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltAmplitude);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltAmplitude)) = num;
			}
		}

		public unsafe float joltSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joltSpeed)) = num;
			}
		}

		static FPSInteractionAction()
		{
			Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "FPSInteractionAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr);
			NativeFieldInfoPtr_availability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "availability");
			NativeFieldInfoPtr_steamVersionOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "steamVersionOnly");
			NativeFieldInfoPtr_attackMainSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "attackMainSpeed");
			NativeFieldInfoPtr_attackTrasition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "attackTrasition");
			NativeFieldInfoPtr_attackDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "attackDelay");
			NativeFieldInfoPtr_mainSpecialAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "mainSpecialAction");
			NativeFieldInfoPtr_mainUseSpecialColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "mainUseSpecialColour");
			NativeFieldInfoPtr_mainSpecialColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "mainSpecialColour");
			NativeFieldInfoPtr_attackEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "attackEvent");
			NativeFieldInfoPtr_useCameraJolt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "useCameraJolt");
			NativeFieldInfoPtr_joltXRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "joltXRange");
			NativeFieldInfoPtr_joltYRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "joltYRange");
			NativeFieldInfoPtr_joltZRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "joltZRange");
			NativeFieldInfoPtr_joltAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "joltAmplitude");
			NativeFieldInfoPtr_joltSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, "joltSpeed");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr, 100673905);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328485, XrefRangeEnd = 328497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FPSInteractionAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPSInteractionAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FPSInteractionAction(IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum AttackAvailability
	{
		never,
		always,
		handcuffs,
		behindCitizen,
		onConsuming,
		onNotConsuming,
		onNotConsumingButLeftovers,
		nearPutDown,
		onRaised,
		onNotRaised,
		codebreaker,
		doorWedge,
		giveItem,
		tracker,
		onRaisedButLeftovers,
		onRaisedNotFull,
		whenCamFlashOn,
		whenCamFlashOff
	}

	private static readonly IntPtr NativeFieldInfoPtr_slotPriority;

	private static readonly IntPtr NativeFieldInfoPtr_modelActive;

	private static readonly IntPtr NativeFieldInfoPtr_idleClip;

	private static readonly IntPtr NativeFieldInfoPtr_selectionIcon;

	private static readonly IntPtr NativeFieldInfoPtr_summaryMsgID;

	private static readonly IntPtr NativeFieldInfoPtr_triggerTutorial;

	private static readonly IntPtr NativeFieldInfoPtr_disableBracketDisplayName;

	private static readonly IntPtr NativeFieldInfoPtr_drawSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_holsterSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_leftHandObject;

	private static readonly IntPtr NativeFieldInfoPtr_rightHandObject;

	private static readonly IntPtr NativeFieldInfoPtr_spawnScale;

	private static readonly IntPtr NativeFieldInfoPtr_useFoodSlotItem;

	private static readonly IntPtr NativeFieldInfoPtr_useAlternateTrashObjects;

	private static readonly IntPtr NativeFieldInfoPtr_leftHandObjectTrash;

	private static readonly IntPtr NativeFieldInfoPtr_rightHandObjectTrash;

	private static readonly IntPtr NativeFieldInfoPtr_actions;

	private static readonly IntPtr NativeFieldInfoPtr_drawnNerveModifier;

	private static readonly IntPtr NativeFieldInfoPtr_barkTriggerChance;

	private static readonly IntPtr NativeFieldInfoPtr_bark;

	private static readonly IntPtr NativeFieldInfoPtr_compatibleWithLockedIn;

	private static readonly IntPtr NativeFieldInfoPtr_compatibleWithHidden;

	private static readonly IntPtr NativeFieldInfoPtr_equipSoundDelay;

	private static readonly IntPtr NativeFieldInfoPtr_equipEvent;

	private static readonly IntPtr NativeFieldInfoPtr_holsterSoundDelay;

	private static readonly IntPtr NativeFieldInfoPtr_holsterEvent;

	private static readonly IntPtr NativeFieldInfoPtr_activeLoop;

	private static readonly IntPtr NativeFieldInfoPtr_passRainParamsToActiveLoop;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int slotPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotPriority)) = num;
		}
	}

	public unsafe bool modelActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelActive)) = flag;
		}
	}

	public unsafe AnimationClip idleClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleClip);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleClip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationClip));
		}
	}

	public unsafe Sprite selectionIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe string summaryMsgID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summaryMsgID);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_summaryMsgID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string triggerTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerTutorial);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerTutorial)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool disableBracketDisplayName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableBracketDisplayName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableBracketDisplayName)) = flag;
		}
	}

	public unsafe float drawSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawSpeed)) = num;
		}
	}

	public unsafe float holsterSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterSpeed)) = num;
		}
	}

	public unsafe GameObject leftHandObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftHandObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftHandObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject rightHandObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightHandObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightHandObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 spawnScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnScale)) = vector;
		}
	}

	public unsafe bool useFoodSlotItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFoodSlotItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFoodSlotItem)) = flag;
		}
	}

	public unsafe bool useAlternateTrashObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAlternateTrashObjects);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAlternateTrashObjects)) = flag;
		}
	}

	public unsafe GameObject leftHandObjectTrash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftHandObjectTrash);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftHandObjectTrash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject rightHandObjectTrash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightHandObjectTrash);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightHandObjectTrash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<FPSInteractionAction> actions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<FPSInteractionAction>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float drawnNerveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawnNerveModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawnNerveModifier)) = num;
		}
	}

	public unsafe float barkTriggerChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barkTriggerChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barkTriggerChance)) = num;
		}
	}

	public unsafe SpeechController.Bark bark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bark);
			return *(SpeechController.Bark*)num;
		}
		set
		{
			*(SpeechController.Bark*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bark)) = bark;
		}
	}

	public unsafe bool compatibleWithLockedIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithLockedIn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithLockedIn)) = flag;
		}
	}

	public unsafe bool compatibleWithHidden
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithHidden);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithHidden)) = flag;
		}
	}

	public unsafe float equipSoundDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipSoundDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipSoundDelay)) = num;
		}
	}

	public unsafe AudioEvent equipEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe float holsterSoundDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterSoundDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterSoundDelay)) = num;
		}
	}

	public unsafe AudioEvent holsterEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent activeLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeLoop);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeLoop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe bool passRainParamsToActiveLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passRainParamsToActiveLoop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passRainParamsToActiveLoop)) = flag;
		}
	}

	static FirstPersonItem()
	{
		Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FirstPersonItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr);
		NativeFieldInfoPtr_slotPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "slotPriority");
		NativeFieldInfoPtr_modelActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "modelActive");
		NativeFieldInfoPtr_idleClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "idleClip");
		NativeFieldInfoPtr_selectionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "selectionIcon");
		NativeFieldInfoPtr_summaryMsgID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "summaryMsgID");
		NativeFieldInfoPtr_triggerTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "triggerTutorial");
		NativeFieldInfoPtr_disableBracketDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "disableBracketDisplayName");
		NativeFieldInfoPtr_drawSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "drawSpeed");
		NativeFieldInfoPtr_holsterSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "holsterSpeed");
		NativeFieldInfoPtr_leftHandObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "leftHandObject");
		NativeFieldInfoPtr_rightHandObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "rightHandObject");
		NativeFieldInfoPtr_spawnScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "spawnScale");
		NativeFieldInfoPtr_useFoodSlotItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "useFoodSlotItem");
		NativeFieldInfoPtr_useAlternateTrashObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "useAlternateTrashObjects");
		NativeFieldInfoPtr_leftHandObjectTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "leftHandObjectTrash");
		NativeFieldInfoPtr_rightHandObjectTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "rightHandObjectTrash");
		NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "actions");
		NativeFieldInfoPtr_drawnNerveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "drawnNerveModifier");
		NativeFieldInfoPtr_barkTriggerChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "barkTriggerChance");
		NativeFieldInfoPtr_bark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "bark");
		NativeFieldInfoPtr_compatibleWithLockedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "compatibleWithLockedIn");
		NativeFieldInfoPtr_compatibleWithHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "compatibleWithHidden");
		NativeFieldInfoPtr_equipSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "equipSoundDelay");
		NativeFieldInfoPtr_equipEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "equipEvent");
		NativeFieldInfoPtr_holsterSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "holsterSoundDelay");
		NativeFieldInfoPtr_holsterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "holsterEvent");
		NativeFieldInfoPtr_activeLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "activeLoop");
		NativeFieldInfoPtr_passRainParamsToActiveLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, "passRainParamsToActiveLoop");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr, 100673904);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328497, XrefRangeEnd = 328507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FirstPersonItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPersonItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FirstPersonItem(IntPtr pointer)
		: base(pointer)
	{
	}
}
