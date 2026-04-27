using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class InteractablePreset : SoCustomComparison
{
	[System.Serializable]
	public class AIUseSetting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_usageOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_facingOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_useNodeFloorPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_useDoorBehaviour;

		private static readonly System.IntPtr NativeFieldInfoPtr_useSittingOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_useArmsStandingOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 usageOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageOffset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageOffset)) = vector;
			}
		}

		public unsafe Vector3 facingOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingOffset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingOffset)) = vector;
			}
		}

		public unsafe bool useNodeFloorPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNodeFloorPosition);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNodeFloorPosition)) = flag;
			}
		}

		public unsafe bool useDoorBehaviour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDoorBehaviour);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDoorBehaviour)) = flag;
			}
		}

		public unsafe bool useSittingOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSittingOffset);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSittingOffset)) = flag;
			}
		}

		public unsafe bool useArmsStandingOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useArmsStandingOffset);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useArmsStandingOffset)) = flag;
			}
		}

		static AIUseSetting()
		{
			Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "AIUseSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr);
			NativeFieldInfoPtr_usageOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr, "usageOffset");
			NativeFieldInfoPtr_facingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr, "facingOffset");
			NativeFieldInfoPtr_useNodeFloorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr, "useNodeFloorPosition");
			NativeFieldInfoPtr_useDoorBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr, "useDoorBehaviour");
			NativeFieldInfoPtr_useSittingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr, "useSittingOffset");
			NativeFieldInfoPtr_useArmsStandingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr, "useArmsStandingOffset");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr, 100673943);
		}

		[CallerCount(0)]
		public unsafe AIUseSetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIUseSetting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AIUseSetting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum InteractionKey
	{
		none,
		primary,
		secondary,
		alternative,
		scrollAxisUp,
		scrollAxisDown,
		jump,
		crouch,
		sprint,
		flashlight,
		caseBoard,
		map,
		notebook,
		moveHorizontal,
		moveVertical,
		lookHorizontal,
		lookVertical,
		WeaponSelect,
		nearestInteractable,
		CaseBoardZoomAxis,
		MoveEvidenceAxisX,
		MoveEvidenceAxisY,
		ContentMoveAxisX,
		ContentMoveAxisY,
		SelectLeft,
		SelectRight,
		SelectUp,
		SelectDown,
		CreateString,
		LeanLeft,
		LeanRight,
		Back,
		Select,
		Menu,
		MoveEvidence
	}

	public enum Switch
	{
		switchState,
		custom1,
		custom2,
		custom3,
		lockState,
		lockedIn,
		sprinting,
		enforcersInside,
		ko,
		securityGrid,
		carryPhysicsObject
	}

	[System.Serializable]
	public class SwitchState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_switchState;

		private static readonly System.IntPtr NativeFieldInfoPtr_boolIs;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Switch switchState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState);
				return *(Switch*)num;
			}
			set
			{
				*(Switch*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState)) = obj;
			}
		}

		public unsafe bool boolIs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolIs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolIs)) = flag;
			}
		}

		static SwitchState()
		{
			Il2CppClassPointerStore<SwitchState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "SwitchState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchState>.NativeClassPtr);
			NativeFieldInfoPtr_switchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchState>.NativeClassPtr, "switchState");
			NativeFieldInfoPtr_boolIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchState>.NativeClassPtr, "boolIs");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchState>.NativeClassPtr, 100673944);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchState>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SwitchState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class IfSwitchState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_switchState;

		private static readonly System.IntPtr NativeFieldInfoPtr_boolIs;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Switch switchState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState);
				return *(Switch*)num;
			}
			set
			{
				*(Switch*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState)) = obj;
			}
		}

		public unsafe bool boolIs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolIs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolIs)) = flag;
			}
		}

		static IfSwitchState()
		{
			Il2CppClassPointerStore<IfSwitchState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "IfSwitchState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IfSwitchState>.NativeClassPtr);
			NativeFieldInfoPtr_switchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchState>.NativeClassPtr, "switchState");
			NativeFieldInfoPtr_boolIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchState>.NativeClassPtr, "boolIs");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IfSwitchState>.NativeClassPtr, 100673945);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IfSwitchState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IfSwitchState>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IfSwitchState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class IfSwitchStateSFX : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_switchState;

		private static readonly System.IntPtr NativeFieldInfoPtr_boolIs;

		private static readonly System.IntPtr NativeFieldInfoPtr_triggerAudio;

		private static readonly System.IntPtr NativeFieldInfoPtr_isLoop;

		private static readonly System.IntPtr NativeFieldInfoPtr_isBroadcast;

		private static readonly System.IntPtr NativeFieldInfoPtr_isMusicPlayer;

		private static readonly System.IntPtr NativeFieldInfoPtr_stop;

		private static readonly System.IntPtr NativeFieldInfoPtr_passOpenParam;

		private static readonly System.IntPtr NativeFieldInfoPtr_passCSParam;

		private static readonly System.IntPtr NativeFieldInfoPtr_passDoorDirParam;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfInSyncBed;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfNotInSyncBed;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfNeonSign;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Switch switchState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState);
				return *(Switch*)num;
			}
			set
			{
				*(Switch*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState)) = obj;
			}
		}

		public unsafe bool boolIs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolIs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolIs)) = flag;
			}
		}

		public unsafe AudioEvent triggerAudio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerAudio);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerAudio)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe bool isLoop
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop)) = flag;
			}
		}

		public unsafe bool isBroadcast
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBroadcast);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBroadcast)) = flag;
			}
		}

		public unsafe bool isMusicPlayer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMusicPlayer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMusicPlayer)) = flag;
			}
		}

		public unsafe AudioController.StopType stop
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stop);
				return *(AudioController.StopType*)num;
			}
			set
			{
				*(AudioController.StopType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stop)) = stopType;
			}
		}

		public unsafe bool passOpenParam
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passOpenParam);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passOpenParam)) = flag;
			}
		}

		public unsafe bool passCSParam
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passCSParam);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passCSParam)) = flag;
			}
		}

		public unsafe bool passDoorDirParam
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passDoorDirParam);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passDoorDirParam)) = flag;
			}
		}

		public unsafe bool onlyIfInSyncBed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfInSyncBed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfInSyncBed)) = flag;
			}
		}

		public unsafe bool onlyIfNotInSyncBed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfNotInSyncBed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfNotInSyncBed)) = flag;
			}
		}

		public unsafe bool onlyIfNeonSign
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfNeonSign);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfNeonSign)) = flag;
			}
		}

		static IfSwitchStateSFX()
		{
			Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "IfSwitchStateSFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr);
			NativeFieldInfoPtr_switchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "switchState");
			NativeFieldInfoPtr_boolIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "boolIs");
			NativeFieldInfoPtr_triggerAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "triggerAudio");
			NativeFieldInfoPtr_isLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "isLoop");
			NativeFieldInfoPtr_isBroadcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "isBroadcast");
			NativeFieldInfoPtr_isMusicPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "isMusicPlayer");
			NativeFieldInfoPtr_stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "stop");
			NativeFieldInfoPtr_passOpenParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "passOpenParam");
			NativeFieldInfoPtr_passCSParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "passCSParam");
			NativeFieldInfoPtr_passDoorDirParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "passDoorDirParam");
			NativeFieldInfoPtr_onlyIfInSyncBed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "onlyIfInSyncBed");
			NativeFieldInfoPtr_onlyIfNotInSyncBed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "onlyIfNotInSyncBed");
			NativeFieldInfoPtr_onlyIfNeonSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, "onlyIfNeonSign");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr, 100673946);
		}

		[CallerCount(0)]
		public unsafe IfSwitchStateSFX()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IfSwitchStateSFX>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IfSwitchStateSFX(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class InteractionAction : Il2CppSystem.Object
	{
		public enum SpecialCase
		{
			none,
			takeSwap,
			onlyIfDeadAsleepOrUncon,
			availableInFastForward,
			onlyAvailableInFastForward,
			caseFormsNeeded,
			activeCaseHandInReady,
			search,
			knockOnDoor,
			putBack,
			originalPlace,
			onlyIfRestrained,
			onlyIfNotRestrained,
			ifInventoryItemDrawn,
			onlyIfSick,
			nonCombat,
			onlyIfMultiPageHasPages,
			onlyInNormalTimeAndAwakeNonDialog,
			nonDialog,
			decorPlacementPurchase,
			furniturePlacement,
			decorItemPlacement,
			citizenReturn,
			nonCombatOrRestrained,
			validTransitionZone,
			onlyIfRegularRotation,
			takePrintsFromBody
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionName;

		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr_useDefaultKeySetting;

		private static readonly System.IntPtr NativeFieldInfoPtr_keyOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_specialCase;

		private static readonly System.IntPtr NativeFieldInfoPtr_usableByAI;

		private static readonly System.IntPtr NativeFieldInfoPtr_aiUsageDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr_effectSwitchStates;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyActiveIf;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionIsIllegal;

		private static readonly System.IntPtr NativeFieldInfoPtr_availableWhileIllegal;

		private static readonly System.IntPtr NativeFieldInfoPtr_availableWhileWitnessesToIllegal;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyAvailableToRestrainedWhileIllegal;

		private static readonly System.IntPtr NativeFieldInfoPtr_availableWhileLockedIn;

		private static readonly System.IntPtr NativeFieldInfoPtr_availableWhileJumping;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionCost;

		private static readonly System.IntPtr NativeFieldInfoPtr_useStrikethrough;

		private static readonly System.IntPtr NativeFieldInfoPtr_isHidingPlace;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyHidingPlaceIfPublic;

		private static readonly System.IntPtr NativeFieldInfoPtr_soundEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_playOnTrigger;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionKey_Public_InteractionKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string interactionName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe AIActionPreset action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
			}
		}

		public unsafe bool useDefaultKeySetting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDefaultKeySetting);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDefaultKeySetting)) = flag;
			}
		}

		public unsafe InteractionKey keyOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyOverride);
				return *(InteractionKey*)num;
			}
			set
			{
				*(InteractionKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyOverride)) = interactionKey;
			}
		}

		public unsafe SpecialCase specialCase
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCase);
				return *(SpecialCase*)num;
			}
			set
			{
				*(SpecialCase*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCase)) = specialCase;
			}
		}

		public unsafe bool usableByAI
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usableByAI);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usableByAI)) = flag;
			}
		}

		public unsafe float aiUsageDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiUsageDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiUsageDelay)) = num;
			}
		}

		public unsafe List<SwitchState> effectSwitchStates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectSwitchStates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SwitchState>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectSwitchStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<IfSwitchState> onlyActiveIf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyActiveIf);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IfSwitchState>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyActiveIf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool actionIsIllegal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionIsIllegal);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionIsIllegal)) = flag;
			}
		}

		public unsafe bool availableWhileIllegal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileIllegal);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileIllegal)) = flag;
			}
		}

		public unsafe bool availableWhileWitnessesToIllegal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileWitnessesToIllegal);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileWitnessesToIllegal)) = flag;
			}
		}

		public unsafe bool onlyAvailableToRestrainedWhileIllegal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAvailableToRestrainedWhileIllegal);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAvailableToRestrainedWhileIllegal)) = flag;
			}
		}

		public unsafe bool availableWhileLockedIn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileLockedIn);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileLockedIn)) = flag;
			}
		}

		public unsafe bool availableWhileJumping
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileJumping);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhileJumping)) = flag;
			}
		}

		public unsafe int actionCost
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionCost);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionCost)) = num;
			}
		}

		public unsafe bool useStrikethrough
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStrikethrough);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStrikethrough)) = flag;
			}
		}

		public unsafe bool isHidingPlace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHidingPlace);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHidingPlace)) = flag;
			}
		}

		public unsafe bool onlyHidingPlaceIfPublic
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyHidingPlaceIfPublic);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyHidingPlaceIfPublic)) = flag;
			}
		}

		public unsafe AudioEvent soundEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEvent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe bool playOnTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playOnTrigger);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playOnTrigger)) = flag;
			}
		}

		static InteractionAction()
		{
			Il2CppClassPointerStore<InteractionAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "InteractionAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr);
			NativeFieldInfoPtr_interactionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "interactionName");
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "action");
			NativeFieldInfoPtr_useDefaultKeySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "useDefaultKeySetting");
			NativeFieldInfoPtr_keyOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "keyOverride");
			NativeFieldInfoPtr_specialCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "specialCase");
			NativeFieldInfoPtr_usableByAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "usableByAI");
			NativeFieldInfoPtr_aiUsageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "aiUsageDelay");
			NativeFieldInfoPtr_effectSwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "effectSwitchStates");
			NativeFieldInfoPtr_onlyActiveIf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "onlyActiveIf");
			NativeFieldInfoPtr_actionIsIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "actionIsIllegal");
			NativeFieldInfoPtr_availableWhileIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "availableWhileIllegal");
			NativeFieldInfoPtr_availableWhileWitnessesToIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "availableWhileWitnessesToIllegal");
			NativeFieldInfoPtr_onlyAvailableToRestrainedWhileIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "onlyAvailableToRestrainedWhileIllegal");
			NativeFieldInfoPtr_availableWhileLockedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "availableWhileLockedIn");
			NativeFieldInfoPtr_availableWhileJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "availableWhileJumping");
			NativeFieldInfoPtr_actionCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "actionCost");
			NativeFieldInfoPtr_useStrikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "useStrikethrough");
			NativeFieldInfoPtr_isHidingPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "isHidingPlace");
			NativeFieldInfoPtr_onlyHidingPlaceIfPublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "onlyHidingPlaceIfPublic");
			NativeFieldInfoPtr_soundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "soundEvent");
			NativeFieldInfoPtr_playOnTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, "playOnTrigger");
			NativeMethodInfoPtr_GetInteractionKey_Public_InteractionKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, 100673947);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr, 100673948);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 328945, RefRangeEnd = 328949, XrefRangeStart = 328945, XrefRangeEnd = 328945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionKey GetInteractionKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractionKey_Public_InteractionKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(InteractionKey*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328949, XrefRangeEnd = 328961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionAction>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InteractionAction(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum InteractableColourSetting
	{
		none,
		ownersFavColour,
		randomColour,
		randomDecorColour,
		syncDisk
	}

	public enum ItemClass
	{
		consumable,
		medical,
		equipment,
		document,
		misc,
		electronics
	}

	public enum ApartmentPlacementMode
	{
		physics,
		vertical,
		ceiling
	}

	[System.Serializable]
	public class AIUsePriority : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actions;

		private static readonly System.IntPtr NativeFieldInfoPtr_AIPriority;

		private static readonly System.IntPtr NativeFieldInfoPtr_pickDistanceMultiplier;

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

		public unsafe float AIPriority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPriority);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPriority)) = num;
			}
		}

		public unsafe float pickDistanceMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickDistanceMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickDistanceMultiplier)) = num;
			}
		}

		static AIUsePriority()
		{
			Il2CppClassPointerStore<AIUsePriority>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "AIUsePriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIUsePriority>.NativeClassPtr);
			NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUsePriority>.NativeClassPtr, "actions");
			NativeFieldInfoPtr_AIPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUsePriority>.NativeClassPtr, "AIPriority");
			NativeFieldInfoPtr_pickDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIUsePriority>.NativeClassPtr, "pickDistanceMultiplier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIUsePriority>.NativeClassPtr, 100673949);
		}

		[CallerCount(0)]
		public unsafe AIUsePriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIUsePriority>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AIUsePriority(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ObjectResetBehaviour : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ifSwitchState;

		private static readonly System.IntPtr NativeFieldInfoPtr_ifSwitchBool;

		private static readonly System.IntPtr NativeFieldInfoPtr_ifCondition;

		private static readonly System.IntPtr NativeFieldInfoPtr_ifGoal;

		private static readonly System.IntPtr NativeFieldInfoPtr_scope;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfObjectBelongsTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfAuthority;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfLastOccupant;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfHome;

		private static readonly System.IntPtr NativeFieldInfoPtr_insertActions;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Switch ifSwitchState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifSwitchState);
				return *(Switch*)num;
			}
			set
			{
				*(Switch*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifSwitchState)) = obj;
			}
		}

		public unsafe bool ifSwitchBool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifSwitchBool);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifSwitchBool)) = flag;
			}
		}

		public unsafe ObjectResetCondition ifCondition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifCondition);
				return *(ObjectResetCondition*)num;
			}
			set
			{
				*(ObjectResetCondition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifCondition)) = objectResetCondition;
			}
		}

		public unsafe AIGoalPreset ifGoal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifGoal);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
			}
		}

		public unsafe ObjectResetScope scope
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scope);
				return *(ObjectResetScope*)num;
			}
			set
			{
				*(ObjectResetScope*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scope)) = objectResetScope;
			}
		}

		public unsafe bool onlyIfObjectBelongsTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfObjectBelongsTo);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfObjectBelongsTo)) = flag;
			}
		}

		public unsafe bool onlyIfAuthority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfAuthority);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfAuthority)) = flag;
			}
		}

		public unsafe bool onlyIfLastOccupant
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfLastOccupant);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfLastOccupant)) = flag;
			}
		}

		public unsafe bool onlyIfHome
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfHome);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfHome)) = flag;
			}
		}

		public unsafe List<AIActionPreset> insertActions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insertActions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insertActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static ObjectResetBehaviour()
		{
			Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "ObjectResetBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr);
			NativeFieldInfoPtr_ifSwitchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "ifSwitchState");
			NativeFieldInfoPtr_ifSwitchBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "ifSwitchBool");
			NativeFieldInfoPtr_ifCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "ifCondition");
			NativeFieldInfoPtr_ifGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "ifGoal");
			NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "scope");
			NativeFieldInfoPtr_onlyIfObjectBelongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "onlyIfObjectBelongsTo");
			NativeFieldInfoPtr_onlyIfAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "onlyIfAuthority");
			NativeFieldInfoPtr_onlyIfLastOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "onlyIfLastOccupant");
			NativeFieldInfoPtr_onlyIfHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "onlyIfHome");
			NativeFieldInfoPtr_insertActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, "insertActions");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr, 100673950);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328961, XrefRangeEnd = 328967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectResetBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectResetBehaviour>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ObjectResetBehaviour(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ObjectResetCondition
	{
		leavingLocation,
		goalActive,
		goalActivated,
		goalDeactivated
	}

	public enum ObjectResetScope
	{
		ifInSameRoom,
		ifInSameLocation
	}

	public enum ReadingModeSource
	{
		evidenceNote,
		multipageEvidence,
		time,
		bookPreset,
		recordPreset,
		syncDiskPreset,
		mainEvidenceText,
		kaizenSkillDisplay
	}

	public enum AutoPlacement
	{
		always,
		onlyInCompany,
		onlyInHomes,
		onlyOnStreet,
		never
	}

	[System.Serializable]
	public class TraitPick : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_appliedFrequencyMin;

		private static readonly System.IntPtr NativeFieldInfoPtr_appliedFrequencyMax;

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

		public unsafe int appliedFrequencyMin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedFrequencyMin);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedFrequencyMin)) = num;
			}
		}

		public unsafe int appliedFrequencyMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedFrequencyMax);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedFrequencyMax)) = num;
			}
		}

		static TraitPick()
		{
			Il2CppClassPointerStore<TraitPick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "TraitPick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraitPick>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_appliedFrequencyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "appliedFrequencyMin");
			NativeFieldInfoPtr_appliedFrequencyMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, "appliedFrequencyMax");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraitPick>.NativeClassPtr, 100673951);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328967, XrefRangeEnd = 328973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public enum OwnedPlacementRule
	{
		nonOwnedOnly,
		ownedOnly,
		prioritiseNonOwned,
		prioritiseOwned,
		both
	}

	public enum RelocationAuthority
	{
		AIAndOwnersCanRelocate,
		ownerCanRelocate,
		anyoneCanRelocate,
		nooneCanRelocate
	}

	public enum FindEvidence
	{
		none,
		residentsContract,
		sideJob,
		companyRoster,
		addressKey,
		businessCard,
		namePlacard,
		photo,
		calendar,
		retailItem,
		workID,
		salesRecords,
		diary,
		menu,
		homeFile,
		birthCertificate,
		bankStatement,
		medicalDetails,
		IDCard,
		addressBook,
		residentRoster,
		telephone,
		callLogs,
		hospitalBed
	}

	public enum SpecialCase
	{
		none,
		sleepPosition,
		workDesk,
		workCounter,
		workKitchen,
		securityDoor,
		alarmSystem,
		sentryGun,
		securityCamera,
		interestBook,
		bookStack,
		thrownItem,
		fingerprint,
		shower,
		syncDisk,
		unused1,
		unused2,
		codebreaker,
		doorWedge,
		telephone,
		hospitalBed,
		syncBed,
		padlock,
		salesLedger,
		caseTray,
		footprint,
		breakerSecurity,
		breakerLights,
		breakerDoors,
		fridge,
		stovetopKettle,
		syncDiskUpgrade,
		otherSecuritySystem,
		gasReleaseSystem,
		tracker,
		grenade,
		ballisticArmour,
		forceStanding,
		lightswitch,
		airVent,
		burningBarrel,
		addressBook,
		garbageDisposal,
		glassBulletHole,
		bloodPool,
		briefcase,
		umbrella,
		basBouleCardCommon,
		basBouleCardRare,
		basBouleCardVeryRare,
		cigarettes,
		cigars
	}

	[System.Serializable]
	public class SubSpawnSlot : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_localPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_localEuler;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 localPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPos)) = vector;
			}
		}

		public unsafe Vector3 localEuler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localEuler);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localEuler)) = vector;
			}
		}

		static SubSpawnSlot()
		{
			Il2CppClassPointerStore<SubSpawnSlot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "SubSpawnSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSpawnSlot>.NativeClassPtr);
			NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSpawnSlot>.NativeClassPtr, "localPos");
			NativeFieldInfoPtr_localEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSpawnSlot>.NativeClassPtr, "localEuler");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubSpawnSlot>.NativeClassPtr, 100673952);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubSpawnSlot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubSpawnSlot>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SubSpawnSlot(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnable;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabLocalEuler;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabLocalScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontSaveWithSaveGames;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlySaveWithSaveGamesIfWorldObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeFromObjectPooling;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeFromVisibilityRangeChecks;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_showWorldObjectInSceneCapture;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureStateInSceneCapture;

	private static readonly System.IntPtr NativeFieldInfoPtr_createProxy;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyCreateProxyInDetailedCapture;

	private static readonly System.IntPtr NativeFieldInfoPtr_createProxyAtRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritColouringFromDecor;

	private static readonly System.IntPtr NativeFieldInfoPtr_shareColoursWithFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOwnColourSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_customColour1;

	private static readonly System.IntPtr NativeFieldInfoPtr_customColour2;

	private static readonly System.IntPtr NativeFieldInfoPtr_customColour3;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritGrubValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoName;

	private static readonly System.IntPtr NativeFieldInfoPtr_includeBelongsTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_useNameShorthand;

	private static readonly System.IntPtr NativeFieldInfoPtr_useApartmentName;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowUnscrewed;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMainLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceIncludeOnStreetLightLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_imagePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_imagePrefabOverride;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideFurnitureSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_enterTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_exitTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_enterTransition2;

	private static readonly System.IntPtr NativeFieldInfoPtr_exitTransition2;

	private static readonly System.IntPtr NativeFieldInfoPtr_switchSFX;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingSwitchState;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCustomState1;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCustomState2;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCustomState3;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingLockState;

	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeFieldInfoPtr_AIPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableForSocialGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickDistanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_perActionPrioritySettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_tamperEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_readyingEnabledOnlyWithSwitchIsTue;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_traitModifiers;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_subSpawnClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_subSpawnPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_relocationAuthority;

	private static readonly System.IntPtr NativeFieldInfoPtr_relocateIfPlacedInPlayersHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_AIWillCorrectPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_useEvidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSingleton;

	private static readonly System.IntPtr NativeFieldInfoPtr_findEvidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnEvidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationIsParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_summaryMessageSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideEvidencePhotoSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeCamPhotoPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeCamPhotoEuler;

	private static readonly System.IntPtr NativeFieldInfoPtr_includeLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_passwordSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_attemptedOpenSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_armLockOnClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSelfLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_useMaterialChanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockOffMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockOnMaterial;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsItemScaleModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_consumableAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyWhenAllConsumed;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSameModelAsTrash;

	private static readonly System.IntPtr NativeFieldInfoPtr_trashItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerConsumeLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_takeOneEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_disposal;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfDroppedAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_droppedAngleHeightBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_weapon;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryCarryItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHeldObjectRotation;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_musicTracks;

	private static readonly System.IntPtr NativeFieldInfoPtr_retailItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_hourlyChime;

	private static readonly System.IntPtr NativeFieldInfoPtr_chimeEqualToHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_chimeDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchLoop;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActions_Public_List_1_InteractionAction_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPhysicsProfile_Public_PhysicsProfile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFPSHeldPostionFromTransform_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDroppedAngleHeightBoost_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnIntoInventory_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetToZeroValue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateOwnEvidence_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool spawnable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnable)) = flag;
		}
	}

	public unsafe GameObject prefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 prefabLocalEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabLocalEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabLocalEuler)) = vector;
		}
	}

	public unsafe Vector3 prefabLocalScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabLocalScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabLocalScale)) = vector;
		}
	}

	public unsafe bool dontSaveWithSaveGames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSaveWithSaveGames);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSaveWithSaveGames)) = flag;
		}
	}

	public unsafe bool onlySaveWithSaveGamesIfWorldObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySaveWithSaveGamesIfWorldObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySaveWithSaveGamesIfWorldObject)) = flag;
		}
	}

	public unsafe bool excludeFromObjectPooling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromObjectPooling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromObjectPooling)) = flag;
		}
	}

	public unsafe bool excludeFromVisibilityRangeChecks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromVisibilityRangeChecks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeFromVisibilityRangeChecks)) = flag;
		}
	}

	public unsafe ObjectPoolingController.ObjectLoadRange spawnRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRange);
			return *(ObjectPoolingController.ObjectLoadRange*)num;
		}
		set
		{
			*(ObjectPoolingController.ObjectLoadRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRange)) = objectLoadRange;
		}
	}

	public unsafe bool showWorldObjectInSceneCapture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showWorldObjectInSceneCapture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showWorldObjectInSceneCapture)) = flag;
		}
	}

	public unsafe bool captureStateInSceneCapture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureStateInSceneCapture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureStateInSceneCapture)) = flag;
		}
	}

	public unsafe bool createProxy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createProxy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createProxy)) = flag;
		}
	}

	public unsafe bool onlyCreateProxyInDetailedCapture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyCreateProxyInDetailedCapture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyCreateProxyInDetailedCapture)) = flag;
		}
	}

	public unsafe ObjectPoolingController.ObjectLoadRange createProxyAtRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createProxyAtRange);
			return *(ObjectPoolingController.ObjectLoadRange*)num;
		}
		set
		{
			*(ObjectPoolingController.ObjectLoadRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createProxyAtRange)) = objectLoadRange;
		}
	}

	public unsafe bool inheritColouringFromDecor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor)) = flag;
		}
	}

	public unsafe FurniturePreset.ShareColours shareColoursWithFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColoursWithFurniture);
			return *(FurniturePreset.ShareColours*)num;
		}
		set
		{
			*(FurniturePreset.ShareColours*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColoursWithFurniture)) = shareColours;
		}
	}

	public unsafe bool useOwnColourSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnColourSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnColourSettings)) = flag;
		}
	}

	public unsafe InteractableColourSetting mainColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainColour);
			return *(InteractableColourSetting*)num;
		}
		set
		{
			*(InteractableColourSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainColour)) = interactableColourSetting;
		}
	}

	public unsafe InteractableColourSetting customColour1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour1);
			return *(InteractableColourSetting*)num;
		}
		set
		{
			*(InteractableColourSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour1)) = interactableColourSetting;
		}
	}

	public unsafe InteractableColourSetting customColour2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour2);
			return *(InteractableColourSetting*)num;
		}
		set
		{
			*(InteractableColourSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour2)) = interactableColourSetting;
		}
	}

	public unsafe InteractableColourSetting customColour3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour3);
			return *(InteractableColourSetting*)num;
		}
		set
		{
			*(InteractableColourSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customColour3)) = interactableColourSetting;
		}
	}

	public unsafe bool inheritGrubValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritGrubValue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritGrubValue)) = flag;
		}
	}

	public unsafe bool autoName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoName)) = flag;
		}
	}

	public unsafe bool includeBelongsTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeBelongsTo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeBelongsTo)) = flag;
		}
	}

	public unsafe bool useNameShorthand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNameShorthand);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNameShorthand)) = flag;
		}
	}

	public unsafe bool useApartmentName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useApartmentName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useApartmentName)) = flag;
		}
	}

	public unsafe LightingPreset isLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightingPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightingPreset));
		}
	}

	public unsafe Switch lightswitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitch);
			return *(Switch*)num;
		}
		set
		{
			*(Switch*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitch)) = obj;
		}
	}

	public unsafe bool allowUnscrewed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowUnscrewed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowUnscrewed)) = flag;
		}
	}

	public unsafe bool isMainLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMainLight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMainLight)) = flag;
		}
	}

	public unsafe bool forceIncludeOnStreetLightLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIncludeOnStreetLightLayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIncludeOnStreetLightLayer)) = flag;
		}
	}

	public unsafe Sprite staticImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Vector3 imagePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePos)) = vector;
		}
	}

	public unsafe Vector3 imageRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageRot)) = vector;
		}
	}

	public unsafe float imageScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageScale)) = num;
		}
	}

	public unsafe GameObject imagePrefabOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePrefabOverride);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePrefabOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Sprite iconOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconOverride);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe ItemClass itemClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemClass);
			return *(ItemClass*)num;
		}
		set
		{
			*(ItemClass*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemClass)) = itemClass;
		}
	}

	public unsafe bool allowInApartmentStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentStorage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentStorage)) = flag;
		}
	}

	public unsafe bool allowInApartmentShop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentShop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInApartmentShop)) = flag;
		}
	}

	public unsafe bool disableMoveToStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMoveToStorage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableMoveToStorage)) = flag;
		}
	}

	public unsafe ApartmentPlacementMode apartmentPlacementMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartmentPlacementMode);
			return *(ApartmentPlacementMode*)num;
		}
		set
		{
			*(ApartmentPlacementMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartmentPlacementMode)) = apartmentPlacementMode;
		}
	}

	public unsafe List<FurniturePreset> mustTouchFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustTouchFurniture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurniturePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustTouchFurniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useMaterialOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaterialOverride);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaterialOverride)) = flag;
		}
	}

	public unsafe AudioController.SoundMaterialOverride materialOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOverride);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController.SoundMaterialOverride>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundMaterialOverride));
		}
	}

	public unsafe List<InteractableActionsPreset> actionsPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionsPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractableActionsPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionsPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool onlyIllegalIfInNonPublic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIllegalIfInNonPublic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIllegalIfInNonPublic)) = flag;
		}
	}

	public unsafe float rangeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeModifier)) = num;
		}
	}

	public unsafe PhysicsProfile physicsProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsProfile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicsProfile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)physicsProfile));
		}
	}

	public unsafe bool overrideMass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMass)) = flag;
		}
	}

	public unsafe bool forcePhysicsAlwaysOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePhysicsAlwaysOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePhysicsAlwaysOn)) = flag;
		}
	}

	public unsafe bool reactWithExternalStimuli
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactWithExternalStimuli);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactWithExternalStimuli)) = flag;
		}
	}

	public unsafe float mass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass)) = num;
		}
	}

	public unsafe bool breakable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakable)) = flag;
		}
	}

	public unsafe ParticleEffect particleProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleProfile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParticleEffect>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particleEffect));
		}
	}

	public unsafe bool overrideShatterSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShatterSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShatterSettings)) = flag;
		}
	}

	public unsafe Vector3 shardSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardSize)) = vector;
		}
	}

	public unsafe int shardEveryXPixels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardEveryXPixels);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardEveryXPixels)) = num;
		}
	}

	public unsafe bool overrideSpatterSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSpatterSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSpatterSettings)) = flag;
		}
	}

	public unsafe SpatterPatternPreset spatterSimulation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterSimulation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpatterPatternPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterSimulation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterPatternPreset));
		}
	}

	public unsafe float spatterCountMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCountMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCountMultiplier)) = num;
		}
	}

	public unsafe bool overrideFurnitureSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFurnitureSetting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFurnitureSetting)) = flag;
		}
	}

	public unsafe PlayerTransitionPreset enterTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset exitTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset enterTransition2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterTransition2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enterTransition2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset exitTransition2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitTransition2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitTransition2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe List<IfSwitchStateSFX> switchSFX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchSFX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IfSwitchStateSFX>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchSFX)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool startingSwitchState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingSwitchState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingSwitchState)) = flag;
		}
	}

	public unsafe bool startingCustomState1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState1);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState1)) = flag;
		}
	}

	public unsafe bool startingCustomState2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState2);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState2)) = flag;
		}
	}

	public unsafe bool startingCustomState3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState3);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCustomState3)) = flag;
		}
	}

	public unsafe bool startingLockState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingLockState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingLockState)) = flag;
		}
	}

	public unsafe Vector2 value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = vector;
		}
	}

	public unsafe int AIPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIPriority)) = num;
		}
	}

	public unsafe bool disableForSocialGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableForSocialGroups);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableForSocialGroups)) = flag;
		}
	}

	public unsafe float pickDistanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickDistanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickDistanceMultiplier)) = num;
		}
	}

	public unsafe List<AIUsePriority> perActionPrioritySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perActionPrioritySettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIUsePriority>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perActionPrioritySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool tamperEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperEnabled)) = flag;
		}
	}

	public unsafe List<ObjectResetBehaviour> resetBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetBehaviour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObjectResetBehaviour>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetBehaviour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AIUseSetting useSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSetting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIUseSetting>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSetting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIUseSetting));
		}
	}

	public unsafe bool readingEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabled)) = flag;
		}
	}

	public unsafe bool readyingEnabledOnlyWithSwitchIsTue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readyingEnabledOnlyWithSwitchIsTue);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readyingEnabledOnlyWithSwitchIsTue)) = flag;
		}
	}

	public unsafe bool readingEnabledOnlyWithKaizenSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabledOnlyWithKaizenSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingEnabledOnlyWithKaizenSkill)) = flag;
		}
	}

	public unsafe ReadingModeSource readingSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingSource);
			return *(ReadingModeSource*)num;
		}
		set
		{
			*(ReadingModeSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingSource)) = readingModeSource;
		}
	}

	public unsafe bool discoverOnRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnRead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnRead)) = flag;
		}
	}

	public unsafe float pageTurnReadingDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageTurnReadingDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageTurnReadingDelay)) = num;
		}
	}

	public unsafe bool distanceRecognitionEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionEnabled)) = flag;
		}
	}

	public unsafe bool distanceRecognitionOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRecognitionOnly)) = flag;
		}
	}

	public unsafe float recognitionRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recognitionRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recognitionRange)) = num;
		}
	}

	public unsafe List<SubObjectClassPreset> subObjectClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjectClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubObjectClassPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjectClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SubObjectClassPreset> backupClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubObjectClassPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AutoPlacement autoPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPlacement);
			return *(AutoPlacement*)num;
		}
		set
		{
			*(AutoPlacement*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPlacement)) = autoPlacement;
		}
	}

	public unsafe bool alwaysPlaceAtGameLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysPlaceAtGameLocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysPlaceAtGameLocation)) = flag;
		}
	}

	public unsafe int frequencyPerGamelocationMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGamelocationMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGamelocationMin)) = num;
		}
	}

	public unsafe int frequencyPerGameLocationMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGameLocationMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerGameLocationMax)) = num;
		}
	}

	public unsafe int perGameLocationObjectPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perGameLocationObjectPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perGameLocationObjectPriority)) = num;
		}
	}

	public unsafe bool placeIfFiltersPresentInOwner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFiltersPresentInOwner);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFiltersPresentInOwner)) = flag;
		}
	}

	public unsafe bool placeAtHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtHome)) = flag;
		}
	}

	public unsafe bool placeAtWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtWork);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeAtWork)) = flag;
		}
	}

	public unsafe List<TraitPick> traitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TraitPick>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int frequencyPerOwnerMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMin)) = num;
		}
	}

	public unsafe int frequencyPerOwnerMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyPerOwnerMax)) = num;
		}
	}

	public unsafe bool multiplyByMessiness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplyByMessiness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplyByMessiness)) = flag;
		}
	}

	public unsafe int perOwnerObjectPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perOwnerObjectPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perOwnerObjectPriority)) = num;
		}
	}

	public unsafe EvidencePreset.BelongsToSetting writerIs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writerIs);
			return *(EvidencePreset.BelongsToSetting*)num;
		}
		set
		{
			*(EvidencePreset.BelongsToSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writerIs)) = belongsToSetting;
		}
	}

	public unsafe EvidencePreset.BelongsToSetting receiverIs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverIs);
			return *(EvidencePreset.BelongsToSetting*)num;
		}
		set
		{
			*(EvidencePreset.BelongsToSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverIs)) = belongsToSetting;
		}
	}

	public unsafe bool canBeFromSelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFromSelf);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFromSelf)) = flag;
		}
	}

	public unsafe bool limitPerObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerObject)) = flag;
		}
	}

	public unsafe int perObjectLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perObjectLimit)) = num;
		}
	}

	public unsafe bool limitPerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom)) = flag;
		}
	}

	public unsafe int perRoomLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perRoomLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perRoomLimit)) = num;
		}
	}

	public unsafe bool limitPerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress)) = flag;
		}
	}

	public unsafe int perAddressLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perAddressLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perAddressLimit)) = num;
		}
	}

	public unsafe bool limitInResidential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInResidential);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInResidential)) = flag;
		}
	}

	public unsafe int perResidentialLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perResidentialLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perResidentialLimit)) = num;
		}
	}

	public unsafe bool limitInCommercial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInCommercial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitInCommercial)) = flag;
		}
	}

	public unsafe int perCommercialLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perCommercialLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perCommercialLimit)) = num;
		}
	}

	public unsafe List<RoomConfiguration> banFromRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool limitToCertainRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainRooms);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainRooms)) = flag;
		}
	}

	public unsafe List<RoomConfiguration> onlyInRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool limitToCertainBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainBuildings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToCertainBuildings)) = flag;
		}
	}

	public unsafe List<BuildingPreset> onlyInBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInBuildings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe EvidencePreset attemptToStoreInFolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attemptToStoreInFolder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidencePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attemptToStoreInFolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidencePreset));
		}
	}

	public unsafe float folderPlacementChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderPlacementChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderPlacementChance)) = num;
		}
	}

	public unsafe bool dontPlaceIfNoFolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPlaceIfNoFolder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPlaceIfNoFolder)) = flag;
		}
	}

	public unsafe bool folderOwnershipMustMatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderOwnershipMustMatch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_folderOwnershipMustMatch)) = flag;
		}
	}

	public unsafe bool useSubSpawning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSubSpawning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSubSpawning)) = flag;
		}
	}

	public unsafe int securityLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityLevel)) = num;
		}
	}

	public unsafe OwnedPlacementRule ownedRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownedRule);
			return *(OwnedPlacementRule*)num;
		}
		set
		{
			*(OwnedPlacementRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownedRule)) = ownedPlacementRule;
		}
	}

	public unsafe bool overrideWithOnlyOwnedSpawnAtWork
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWithOnlyOwnedSpawnAtWork);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWithOnlyOwnedSpawnAtWork)) = flag;
		}
	}

	public unsafe SubObjectClassPreset subSpawnClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawnClass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawnClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
		}
	}

	public unsafe List<SubSpawnSlot> subSpawnPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawnPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubSpawnSlot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawnPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe RelocationAuthority relocationAuthority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocationAuthority);
			return *(RelocationAuthority*)num;
		}
		set
		{
			*(RelocationAuthority*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocationAuthority)) = relocationAuthority;
		}
	}

	public unsafe bool relocateIfPlacedInPlayersHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocateIfPlacedInPlayersHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relocateIfPlacedInPlayersHome)) = flag;
		}
	}

	public unsafe bool AIWillCorrectPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIWillCorrectPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AIWillCorrectPosition)) = flag;
		}
	}

	public unsafe bool useEvidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useEvidence);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useEvidence)) = flag;
		}
	}

	public unsafe EvidencePreset useSingleton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSingleton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidencePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSingleton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidencePreset));
		}
	}

	public unsafe FindEvidence findEvidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findEvidence);
			return *(FindEvidence*)num;
		}
		set
		{
			*(FindEvidence*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findEvidence)) = findEvidence;
		}
	}

	public unsafe EvidencePreset spawnEvidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnEvidence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidencePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnEvidence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidencePreset));
		}
	}

	public unsafe bool locationIsParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationIsParent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationIsParent)) = flag;
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

	public unsafe bool overrideEvidencePhotoSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEvidencePhotoSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEvidencePhotoSettings)) = flag;
		}
	}

	public unsafe Vector3 relativeCamPhotoPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos)) = vector;
		}
	}

	public unsafe Vector3 relativeCamPhotoEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler)) = vector;
		}
	}

	public unsafe InteractablePreset includeLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeLock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeLock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe Vector3 lockOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffset)) = vector;
		}
	}

	public unsafe RoomConfiguration.RoomPasswordPreference passwordSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordSource);
			return *(RoomConfiguration.RoomPasswordPreference*)num;
		}
		set
		{
			*(RoomConfiguration.RoomPasswordPreference*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordSource)) = roomPasswordPreference;
		}
	}

	public unsafe AudioEvent attemptedOpenSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attemptedOpenSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attemptedOpenSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe bool armLockOnClose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armLockOnClose);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armLockOnClose)) = flag;
		}
	}

	public unsafe Vector2 lockStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockStrength);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockStrength)) = vector;
		}
	}

	public unsafe bool isSelfLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelfLock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelfLock)) = flag;
		}
	}

	public unsafe bool useMaterialChanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaterialChanges);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMaterialChanges)) = flag;
		}
	}

	public unsafe Material lockOffMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material lockOnMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOnMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOnMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe bool isComputer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isComputer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isComputer)) = flag;
		}
	}

	public unsafe CruncherAppPreset bootApp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bootApp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CruncherAppPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bootApp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cruncherAppPreset));
		}
	}

	public unsafe CruncherAppPreset logInApp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logInApp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CruncherAppPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logInApp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cruncherAppPreset));
		}
	}

	public unsafe CruncherAppPreset desktopApp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desktopApp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CruncherAppPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desktopApp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cruncherAppPreset));
		}
	}

	public unsafe List<CruncherAppPreset> additionalApps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalApps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CruncherAppPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalApps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool fingerprintsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled)) = flag;
		}
	}

	public unsafe RoomConfiguration.PrintsSource printsSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource);
			return *(RoomConfiguration.PrintsSource*)num;
		}
		set
		{
			*(RoomConfiguration.PrintsSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource)) = printsSource;
		}
	}

	public unsafe float fingerprintDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintDensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintDensity)) = num;
		}
	}

	public unsafe bool enableDynamicFingerprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDynamicFingerprints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDynamicFingerprints)) = flag;
		}
	}

	public unsafe bool disableDynamicFingerprintsFromStaticPrintsSources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableDynamicFingerprintsFromStaticPrintsSources);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableDynamicFingerprintsFromStaticPrintsSources)) = flag;
		}
	}

	public unsafe bool overrideMaxDynamicFingerprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaxDynamicFingerprints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaxDynamicFingerprints)) = flag;
		}
	}

	public unsafe int maxDynamicFingerprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDynamicFingerprints);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDynamicFingerprints)) = num;
		}
	}

	public unsafe FirstPersonItem fpsItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonItem));
		}
	}

	public unsafe bool isInventoryItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInventoryItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInventoryItem)) = flag;
		}
	}

	public unsafe Vector3 fpsItemOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemOffset)) = vector;
		}
	}

	public unsafe Vector3 fpsItemRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemRotation)) = vector;
		}
	}

	public unsafe Vector3 fpsItemScaleModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemScaleModifier);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsItemScaleModifier)) = vector;
		}
	}

	public unsafe float consumableAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumableAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumableAmount)) = num;
		}
	}

	public unsafe bool destroyWhenAllConsumed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyWhenAllConsumed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyWhenAllConsumed)) = flag;
		}
	}

	public unsafe bool useSameModelAsTrash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSameModelAsTrash);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSameModelAsTrash)) = flag;
		}
	}

	public unsafe InteractablePreset trashItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trashItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trashItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe AudioEvent playerConsumeLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerConsumeLoop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerConsumeLoop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent takeOneEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeOneEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeOneEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe Human.DisposalType disposal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposal);
			return *(Human.DisposalType*)num;
		}
		set
		{
			*(Human.DisposalType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposal)) = disposalType;
		}
	}

	public unsafe float chanceOfDroppedAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfDroppedAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfDroppedAngle)) = num;
		}
	}

	public unsafe float droppedAngleHeightBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droppedAngleHeightBoost);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droppedAngleHeightBoost)) = num;
		}
	}

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

	public unsafe bool inventoryCarryItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryCarryItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryCarryItem)) = flag;
		}
	}

	public unsafe bool requiredCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredCarryAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredCarryAnimation)) = flag;
		}
	}

	public unsafe int aiCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiCarryAnimation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiCarryAnimation)) = num;
		}
	}

	public unsafe Vector3 aiHeldObjectPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectPosition)) = vector;
		}
	}

	public unsafe Vector3 aiHeldObjectRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHeldObjectRotation)) = vector;
		}
	}

	public unsafe bool putDownAtHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownAtHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownAtHome)) = flag;
		}
	}

	public unsafe bool takeWith
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeWith);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_takeWith)) = flag;
		}
	}

	public unsafe List<SubObjectClassPreset> putDownPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubObjectClassPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SubObjectClassPreset> backupPutDownPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupPutDownPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubObjectClassPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupPutDownPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SpecialCase specialCaseFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCaseFlag);
			return *(SpecialCase*)num;
		}
		set
		{
			*(SpecialCase*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCaseFlag)) = specialCase;
		}
	}

	public unsafe bool affectRoomSteamLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectRoomSteamLevel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectRoomSteamLevel)) = flag;
		}
	}

	public unsafe bool isPayphone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPayphone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPayphone)) = flag;
		}
	}

	public unsafe bool isClock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClock)) = flag;
		}
	}

	public unsafe bool isMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMoney);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMoney)) = flag;
		}
	}

	public unsafe bool entertainmentSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entertainmentSource);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entertainmentSource)) = flag;
		}
	}

	public unsafe bool isHeatSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHeatSource);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHeatSource)) = flag;
		}
	}

	public unsafe bool markAsTrashOnCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markAsTrashOnCreate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markAsTrashOnCreate)) = flag;
		}
	}

	public unsafe bool isLitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLitter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLitter)) = flag;
		}
	}

	public unsafe bool isDecal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecal)) = flag;
		}
	}

	public unsafe bool isMovableChair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMovableChair);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMovableChair)) = flag;
		}
	}

	public unsafe bool bedRightSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bedRightSide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bedRightSide)) = flag;
		}
	}

	public unsafe bool resetSwitchStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSwitchStates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetSwitchStates)) = flag;
		}
	}

	public unsafe float resetTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetTimer)) = num;
		}
	}

	public unsafe bool dontSaveSwitchStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSaveSwitchStates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontSaveSwitchStates)) = flag;
		}
	}

	public unsafe bool dontLoadSwitchStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontLoadSwitchStates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontLoadSwitchStates)) = flag;
		}
	}

	public unsafe bool recordCreationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordCreationTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordCreationTime)) = flag;
		}
	}

	public unsafe List<AudioEvent> musicTracks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicTracks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AudioEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicTracks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe RetailItemPreset retailItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RetailItemPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)retailItemPreset));
		}
	}

	public unsafe MenuPreset menuOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuOverride);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MenuPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)menuPreset));
		}
	}

	public unsafe AudioEvent hourlyChime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hourlyChime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hourlyChime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe bool chimeEqualToHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeEqualToHour);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeEqualToHour)) = flag;
		}
	}

	public unsafe float chimeDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chimeDelay)) = num;
		}
	}

	public unsafe AudioEvent searchLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchLoop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchLoop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	static InteractablePreset()
	{
		Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InteractablePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr);
		NativeFieldInfoPtr_spawnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "spawnable");
		NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "prefab");
		NativeFieldInfoPtr_prefabLocalEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "prefabLocalEuler");
		NativeFieldInfoPtr_prefabLocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "prefabLocalScale");
		NativeFieldInfoPtr_dontSaveWithSaveGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "dontSaveWithSaveGames");
		NativeFieldInfoPtr_onlySaveWithSaveGamesIfWorldObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "onlySaveWithSaveGamesIfWorldObject");
		NativeFieldInfoPtr_excludeFromObjectPooling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "excludeFromObjectPooling");
		NativeFieldInfoPtr_excludeFromVisibilityRangeChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "excludeFromVisibilityRangeChecks");
		NativeFieldInfoPtr_spawnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "spawnRange");
		NativeFieldInfoPtr_showWorldObjectInSceneCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "showWorldObjectInSceneCapture");
		NativeFieldInfoPtr_captureStateInSceneCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "captureStateInSceneCapture");
		NativeFieldInfoPtr_createProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "createProxy");
		NativeFieldInfoPtr_onlyCreateProxyInDetailedCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "onlyCreateProxyInDetailedCapture");
		NativeFieldInfoPtr_createProxyAtRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "createProxyAtRange");
		NativeFieldInfoPtr_inheritColouringFromDecor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "inheritColouringFromDecor");
		NativeFieldInfoPtr_shareColoursWithFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "shareColoursWithFurniture");
		NativeFieldInfoPtr_useOwnColourSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useOwnColourSettings");
		NativeFieldInfoPtr_mainColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "mainColour");
		NativeFieldInfoPtr_customColour1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "customColour1");
		NativeFieldInfoPtr_customColour2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "customColour2");
		NativeFieldInfoPtr_customColour3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "customColour3");
		NativeFieldInfoPtr_inheritGrubValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "inheritGrubValue");
		NativeFieldInfoPtr_autoName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "autoName");
		NativeFieldInfoPtr_includeBelongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "includeBelongsTo");
		NativeFieldInfoPtr_useNameShorthand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useNameShorthand");
		NativeFieldInfoPtr_useApartmentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useApartmentName");
		NativeFieldInfoPtr_isLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isLight");
		NativeFieldInfoPtr_lightswitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "lightswitch");
		NativeFieldInfoPtr_allowUnscrewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "allowUnscrewed");
		NativeFieldInfoPtr_isMainLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isMainLight");
		NativeFieldInfoPtr_forceIncludeOnStreetLightLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "forceIncludeOnStreetLightLayer");
		NativeFieldInfoPtr_staticImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "staticImage");
		NativeFieldInfoPtr_imagePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "imagePos");
		NativeFieldInfoPtr_imageRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "imageRot");
		NativeFieldInfoPtr_imageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "imageScale");
		NativeFieldInfoPtr_imagePrefabOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "imagePrefabOverride");
		NativeFieldInfoPtr_iconOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "iconOverride");
		NativeFieldInfoPtr_itemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "itemClass");
		NativeFieldInfoPtr_allowInApartmentStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "allowInApartmentStorage");
		NativeFieldInfoPtr_allowInApartmentShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "allowInApartmentShop");
		NativeFieldInfoPtr_disableMoveToStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "disableMoveToStorage");
		NativeFieldInfoPtr_apartmentPlacementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "apartmentPlacementMode");
		NativeFieldInfoPtr_mustTouchFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "mustTouchFurniture");
		NativeFieldInfoPtr_useMaterialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useMaterialOverride");
		NativeFieldInfoPtr_materialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "materialOverride");
		NativeFieldInfoPtr_actionsPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "actionsPreset");
		NativeFieldInfoPtr_onlyIllegalIfInNonPublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "onlyIllegalIfInNonPublic");
		NativeFieldInfoPtr_rangeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "rangeModifier");
		NativeFieldInfoPtr_physicsProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "physicsProfile");
		NativeFieldInfoPtr_overrideMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "overrideMass");
		NativeFieldInfoPtr_forcePhysicsAlwaysOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "forcePhysicsAlwaysOn");
		NativeFieldInfoPtr_reactWithExternalStimuli = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "reactWithExternalStimuli");
		NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "mass");
		NativeFieldInfoPtr_breakable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "breakable");
		NativeFieldInfoPtr_particleProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "particleProfile");
		NativeFieldInfoPtr_overrideShatterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "overrideShatterSettings");
		NativeFieldInfoPtr_shardSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "shardSize");
		NativeFieldInfoPtr_shardEveryXPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "shardEveryXPixels");
		NativeFieldInfoPtr_overrideSpatterSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "overrideSpatterSettings");
		NativeFieldInfoPtr_spatterSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "spatterSimulation");
		NativeFieldInfoPtr_spatterCountMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "spatterCountMultiplier");
		NativeFieldInfoPtr_overrideFurnitureSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "overrideFurnitureSetting");
		NativeFieldInfoPtr_enterTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "enterTransition");
		NativeFieldInfoPtr_exitTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "exitTransition");
		NativeFieldInfoPtr_enterTransition2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "enterTransition2");
		NativeFieldInfoPtr_exitTransition2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "exitTransition2");
		NativeFieldInfoPtr_switchSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "switchSFX");
		NativeFieldInfoPtr_startingSwitchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "startingSwitchState");
		NativeFieldInfoPtr_startingCustomState1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "startingCustomState1");
		NativeFieldInfoPtr_startingCustomState2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "startingCustomState2");
		NativeFieldInfoPtr_startingCustomState3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "startingCustomState3");
		NativeFieldInfoPtr_startingLockState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "startingLockState");
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "value");
		NativeFieldInfoPtr_AIPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "AIPriority");
		NativeFieldInfoPtr_disableForSocialGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "disableForSocialGroups");
		NativeFieldInfoPtr_pickDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "pickDistanceMultiplier");
		NativeFieldInfoPtr_perActionPrioritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perActionPrioritySettings");
		NativeFieldInfoPtr_tamperEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "tamperEnabled");
		NativeFieldInfoPtr_resetBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "resetBehaviour");
		NativeFieldInfoPtr_useSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useSetting");
		NativeFieldInfoPtr_readingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "readingEnabled");
		NativeFieldInfoPtr_readyingEnabledOnlyWithSwitchIsTue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "readyingEnabledOnlyWithSwitchIsTue");
		NativeFieldInfoPtr_readingEnabledOnlyWithKaizenSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "readingEnabledOnlyWithKaizenSkill");
		NativeFieldInfoPtr_readingSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "readingSource");
		NativeFieldInfoPtr_discoverOnRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "discoverOnRead");
		NativeFieldInfoPtr_pageTurnReadingDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "pageTurnReadingDelay");
		NativeFieldInfoPtr_distanceRecognitionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "distanceRecognitionEnabled");
		NativeFieldInfoPtr_distanceRecognitionOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "distanceRecognitionOnly");
		NativeFieldInfoPtr_recognitionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "recognitionRange");
		NativeFieldInfoPtr_subObjectClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "subObjectClasses");
		NativeFieldInfoPtr_backupClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "backupClasses");
		NativeFieldInfoPtr_autoPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "autoPlacement");
		NativeFieldInfoPtr_alwaysPlaceAtGameLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "alwaysPlaceAtGameLocation");
		NativeFieldInfoPtr_frequencyPerGamelocationMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "frequencyPerGamelocationMin");
		NativeFieldInfoPtr_frequencyPerGameLocationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "frequencyPerGameLocationMax");
		NativeFieldInfoPtr_perGameLocationObjectPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perGameLocationObjectPriority");
		NativeFieldInfoPtr_placeIfFiltersPresentInOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "placeIfFiltersPresentInOwner");
		NativeFieldInfoPtr_placeAtHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "placeAtHome");
		NativeFieldInfoPtr_placeAtWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "placeAtWork");
		NativeFieldInfoPtr_traitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "traitModifiers");
		NativeFieldInfoPtr_frequencyPerOwnerMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "frequencyPerOwnerMin");
		NativeFieldInfoPtr_frequencyPerOwnerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "frequencyPerOwnerMax");
		NativeFieldInfoPtr_multiplyByMessiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "multiplyByMessiness");
		NativeFieldInfoPtr_perOwnerObjectPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perOwnerObjectPriority");
		NativeFieldInfoPtr_writerIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "writerIs");
		NativeFieldInfoPtr_receiverIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "receiverIs");
		NativeFieldInfoPtr_canBeFromSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "canBeFromSelf");
		NativeFieldInfoPtr_limitPerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "limitPerObject");
		NativeFieldInfoPtr_perObjectLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perObjectLimit");
		NativeFieldInfoPtr_limitPerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "limitPerRoom");
		NativeFieldInfoPtr_perRoomLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perRoomLimit");
		NativeFieldInfoPtr_limitPerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "limitPerAddress");
		NativeFieldInfoPtr_perAddressLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perAddressLimit");
		NativeFieldInfoPtr_limitInResidential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "limitInResidential");
		NativeFieldInfoPtr_perResidentialLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perResidentialLimit");
		NativeFieldInfoPtr_limitInCommercial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "limitInCommercial");
		NativeFieldInfoPtr_perCommercialLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "perCommercialLimit");
		NativeFieldInfoPtr_banFromRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "banFromRooms");
		NativeFieldInfoPtr_limitToCertainRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "limitToCertainRooms");
		NativeFieldInfoPtr_onlyInRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "onlyInRooms");
		NativeFieldInfoPtr_limitToCertainBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "limitToCertainBuildings");
		NativeFieldInfoPtr_onlyInBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "onlyInBuildings");
		NativeFieldInfoPtr_attemptToStoreInFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "attemptToStoreInFolder");
		NativeFieldInfoPtr_folderPlacementChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "folderPlacementChance");
		NativeFieldInfoPtr_dontPlaceIfNoFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "dontPlaceIfNoFolder");
		NativeFieldInfoPtr_folderOwnershipMustMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "folderOwnershipMustMatch");
		NativeFieldInfoPtr_useSubSpawning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useSubSpawning");
		NativeFieldInfoPtr_securityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "securityLevel");
		NativeFieldInfoPtr_ownedRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "ownedRule");
		NativeFieldInfoPtr_overrideWithOnlyOwnedSpawnAtWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "overrideWithOnlyOwnedSpawnAtWork");
		NativeFieldInfoPtr_subSpawnClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "subSpawnClass");
		NativeFieldInfoPtr_subSpawnPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "subSpawnPositions");
		NativeFieldInfoPtr_relocationAuthority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "relocationAuthority");
		NativeFieldInfoPtr_relocateIfPlacedInPlayersHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "relocateIfPlacedInPlayersHome");
		NativeFieldInfoPtr_AIWillCorrectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "AIWillCorrectPosition");
		NativeFieldInfoPtr_useEvidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useEvidence");
		NativeFieldInfoPtr_useSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useSingleton");
		NativeFieldInfoPtr_findEvidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "findEvidence");
		NativeFieldInfoPtr_spawnEvidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "spawnEvidence");
		NativeFieldInfoPtr_locationIsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "locationIsParent");
		NativeFieldInfoPtr_summaryMessageSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "summaryMessageSource");
		NativeFieldInfoPtr_overrideEvidencePhotoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "overrideEvidencePhotoSettings");
		NativeFieldInfoPtr_relativeCamPhotoPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "relativeCamPhotoPos");
		NativeFieldInfoPtr_relativeCamPhotoEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "relativeCamPhotoEuler");
		NativeFieldInfoPtr_includeLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "includeLock");
		NativeFieldInfoPtr_lockOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "lockOffset");
		NativeFieldInfoPtr_passwordSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "passwordSource");
		NativeFieldInfoPtr_attemptedOpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "attemptedOpenSound");
		NativeFieldInfoPtr_armLockOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "armLockOnClose");
		NativeFieldInfoPtr_lockStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "lockStrength");
		NativeFieldInfoPtr_isSelfLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isSelfLock");
		NativeFieldInfoPtr_useMaterialChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useMaterialChanges");
		NativeFieldInfoPtr_lockOffMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "lockOffMaterial");
		NativeFieldInfoPtr_lockOnMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "lockOnMaterial");
		NativeFieldInfoPtr_isComputer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isComputer");
		NativeFieldInfoPtr_bootApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "bootApp");
		NativeFieldInfoPtr_logInApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "logInApp");
		NativeFieldInfoPtr_desktopApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "desktopApp");
		NativeFieldInfoPtr_additionalApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "additionalApps");
		NativeFieldInfoPtr_fingerprintsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "fingerprintsEnabled");
		NativeFieldInfoPtr_printsSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "printsSource");
		NativeFieldInfoPtr_fingerprintDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "fingerprintDensity");
		NativeFieldInfoPtr_enableDynamicFingerprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "enableDynamicFingerprints");
		NativeFieldInfoPtr_disableDynamicFingerprintsFromStaticPrintsSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "disableDynamicFingerprintsFromStaticPrintsSources");
		NativeFieldInfoPtr_overrideMaxDynamicFingerprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "overrideMaxDynamicFingerprints");
		NativeFieldInfoPtr_maxDynamicFingerprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "maxDynamicFingerprints");
		NativeFieldInfoPtr_fpsItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "fpsItem");
		NativeFieldInfoPtr_isInventoryItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isInventoryItem");
		NativeFieldInfoPtr_fpsItemOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "fpsItemOffset");
		NativeFieldInfoPtr_fpsItemRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "fpsItemRotation");
		NativeFieldInfoPtr_fpsItemScaleModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "fpsItemScaleModifier");
		NativeFieldInfoPtr_consumableAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "consumableAmount");
		NativeFieldInfoPtr_destroyWhenAllConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "destroyWhenAllConsumed");
		NativeFieldInfoPtr_useSameModelAsTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "useSameModelAsTrash");
		NativeFieldInfoPtr_trashItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "trashItem");
		NativeFieldInfoPtr_playerConsumeLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "playerConsumeLoop");
		NativeFieldInfoPtr_takeOneEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "takeOneEvent");
		NativeFieldInfoPtr_disposal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "disposal");
		NativeFieldInfoPtr_chanceOfDroppedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "chanceOfDroppedAngle");
		NativeFieldInfoPtr_droppedAngleHeightBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "droppedAngleHeightBoost");
		NativeFieldInfoPtr_weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "weapon");
		NativeFieldInfoPtr_inventoryCarryItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "inventoryCarryItem");
		NativeFieldInfoPtr_requiredCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "requiredCarryAnimation");
		NativeFieldInfoPtr_aiCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "aiCarryAnimation");
		NativeFieldInfoPtr_aiHeldObjectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "aiHeldObjectPosition");
		NativeFieldInfoPtr_aiHeldObjectRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "aiHeldObjectRotation");
		NativeFieldInfoPtr_putDownAtHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "putDownAtHome");
		NativeFieldInfoPtr_takeWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "takeWith");
		NativeFieldInfoPtr_putDownPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "putDownPositions");
		NativeFieldInfoPtr_backupPutDownPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "backupPutDownPositions");
		NativeFieldInfoPtr_specialCaseFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "specialCaseFlag");
		NativeFieldInfoPtr_affectRoomSteamLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "affectRoomSteamLevel");
		NativeFieldInfoPtr_isPayphone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isPayphone");
		NativeFieldInfoPtr_isClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isClock");
		NativeFieldInfoPtr_isMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isMoney");
		NativeFieldInfoPtr_entertainmentSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "entertainmentSource");
		NativeFieldInfoPtr_isHeatSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isHeatSource");
		NativeFieldInfoPtr_markAsTrashOnCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "markAsTrashOnCreate");
		NativeFieldInfoPtr_isLitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isLitter");
		NativeFieldInfoPtr_isDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isDecal");
		NativeFieldInfoPtr_isMovableChair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "isMovableChair");
		NativeFieldInfoPtr_bedRightSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "bedRightSide");
		NativeFieldInfoPtr_resetSwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "resetSwitchStates");
		NativeFieldInfoPtr_resetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "resetTimer");
		NativeFieldInfoPtr_dontSaveSwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "dontSaveSwitchStates");
		NativeFieldInfoPtr_dontLoadSwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "dontLoadSwitchStates");
		NativeFieldInfoPtr_recordCreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "recordCreationTime");
		NativeFieldInfoPtr_musicTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "musicTracks");
		NativeFieldInfoPtr_retailItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "retailItem");
		NativeFieldInfoPtr_menuOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "menuOverride");
		NativeFieldInfoPtr_hourlyChime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "hourlyChime");
		NativeFieldInfoPtr_chimeEqualToHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "chimeEqualToHour");
		NativeFieldInfoPtr_chimeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "chimeDelay");
		NativeFieldInfoPtr_searchLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, "searchLoop");
		NativeMethodInfoPtr_GetActions_Public_List_1_InteractionAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673935);
		NativeMethodInfoPtr_GetPhysicsProfile_Public_PhysicsProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673936);
		NativeMethodInfoPtr_CopyFPSHeldPostionFromTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673937);
		NativeMethodInfoPtr_CalculateDroppedAngleHeightBoost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673938);
		NativeMethodInfoPtr_SpawnIntoInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673939);
		NativeMethodInfoPtr_SetToZeroValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673940);
		NativeMethodInfoPtr_CreateOwnEvidence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673941);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr, 100673942);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 328997, RefRangeEnd = 329023, XrefRangeStart = 328973, XrefRangeEnd = 328997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<InteractionAction> GetActions(int lockedInPhase = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lockedInPhase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActions_Public_List_1_InteractionAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractionAction>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 329025, RefRangeEnd = 329027, XrefRangeStart = 329023, XrefRangeEnd = 329025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhysicsProfile GetPhysicsProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPhysicsProfile_Public_PhysicsProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicsProfile>(intPtr) : null;
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyFPSHeldPostionFromTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFPSHeldPostionFromTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateDroppedAngleHeightBoost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDroppedAngleHeightBoost_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329027, XrefRangeEnd = 329056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnIntoInventory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnIntoInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetToZeroValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetToZeroValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateOwnEvidence()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateOwnEvidence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329056, XrefRangeEnd = 329152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractablePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractablePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InteractablePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
