using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class PlayerTransitionPreset : SoCustomComparison
{
	public enum TransitionPosition
	{
		relativeToInteractable,
		relativeToPlayer
	}

	[System.Serializable]
	public class SFXSetting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_soundEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_atProgress;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

		public unsafe float atProgress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atProgress);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atProgress)) = num;
			}
		}

		static SFXSetting()
		{
			Il2CppClassPointerStore<SFXSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "SFXSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXSetting>.NativeClassPtr);
			NativeFieldInfoPtr_soundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXSetting>.NativeClassPtr, "soundEvent");
			NativeFieldInfoPtr_atProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXSetting>.NativeClassPtr, "atProgress");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXSetting>.NativeClassPtr, 100674008);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SFXSetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXSetting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SFXSetting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_retainMovementControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLookControlCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerHeightMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_CamHeightMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_factorInCrouching;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_camHeightCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useXMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerXCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useYMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerYCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useZMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerZCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_fixYMovementForRatController;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerYCurveIfRat;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionRelativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableWriteReturnPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionToSavedReturnPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionFromExistingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionTransitionCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_invertXPositionBasedOnRelativePlayerX;

	private static readonly System.IntPtr NativeFieldInfoPtr_invertYPositionBasedOnRelativePlayerY;

	private static readonly System.IntPtr NativeFieldInfoPtr_invertZPositionBasedOnRelativePlayerZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_raycastCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_onFailUse;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowMovementOnEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_restoreNormalMovementSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_customMovementSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableGravity;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableHeadBob;

	private static readonly System.IntPtr NativeFieldInfoPtr_useXLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerXLookCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useYLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerYLookCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useZLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerZLookCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookRelativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_forwardPositionModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookMovementMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_applyCameraRoll;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraRoll;

	private static readonly System.IntPtr NativeFieldInfoPtr_rollMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetCameraRoll;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionFromExistingMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseTransitionCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useChromaticAberration;

	private static readonly System.IntPtr NativeFieldInfoPtr_chromaticAberrationCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useGain;

	private static readonly System.IntPtr NativeFieldInfoPtr_gainCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_sfx;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceHolsterOnTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_restoreHolsterOnTransitionEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowWeaponSwitchingAfterTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerXRecoilLookCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerYRecoilLookCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerZRecoilLookCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCustomReturnPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_returnPostion;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float transitionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionTime)) = num;
		}
	}

	public unsafe bool retainMovementControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retainMovementControl);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retainMovementControl)) = flag;
		}
	}

	public unsafe AnimationCurve controlCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve mouseLookControlCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookControlCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLookControlCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float playerHeightMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeightMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeightMP)) = num;
		}
	}

	public unsafe float CamHeightMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CamHeightMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CamHeightMP)) = num;
		}
	}

	public unsafe bool factorInCrouching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factorInCrouching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factorInCrouching)) = flag;
		}
	}

	public unsafe AnimationCurve heightCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve camHeightCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camHeightCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camHeightCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useXMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useXMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useXMovement)) = flag;
		}
	}

	public unsafe AnimationCurve playerXCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useYMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useYMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useYMovement)) = flag;
		}
	}

	public unsafe AnimationCurve playerYCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useZMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useZMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useZMovement)) = flag;
		}
	}

	public unsafe AnimationCurve playerZCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerZCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerZCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool fixYMovementForRatController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fixYMovementForRatController);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fixYMovementForRatController)) = flag;
		}
	}

	public unsafe AnimationCurve playerYCurveIfRat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYCurveIfRat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYCurveIfRat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe TransitionPosition transitionRelativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionRelativity);
			return *(TransitionPosition*)num;
		}
		set
		{
			*(TransitionPosition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionRelativity)) = transitionPosition;
		}
	}

	public unsafe bool disableWriteReturnPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableWriteReturnPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableWriteReturnPosition)) = flag;
		}
	}

	public unsafe bool transitionToSavedReturnPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionToSavedReturnPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionToSavedReturnPosition)) = flag;
		}
	}

	public unsafe bool transitionFromExistingPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionFromExistingPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionFromExistingPosition)) = flag;
		}
	}

	public unsafe AnimationCurve positionTransitionCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionTransitionCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionTransitionCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool invertXPositionBasedOnRelativePlayerX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertXPositionBasedOnRelativePlayerX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertXPositionBasedOnRelativePlayerX)) = flag;
		}
	}

	public unsafe bool invertYPositionBasedOnRelativePlayerY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertYPositionBasedOnRelativePlayerY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertYPositionBasedOnRelativePlayerY)) = flag;
		}
	}

	public unsafe bool invertZPositionBasedOnRelativePlayerZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertZPositionBasedOnRelativePlayerZ);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertZPositionBasedOnRelativePlayerZ)) = flag;
		}
	}

	public unsafe bool raycastCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raycastCheck)) = flag;
		}
	}

	public unsafe PlayerTransitionPreset onFailUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFailUse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFailUse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe bool allowMovementOnEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMovementOnEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMovementOnEnd)) = flag;
		}
	}

	public unsafe bool restoreNormalMovementSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restoreNormalMovementSpeed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restoreNormalMovementSpeed)) = flag;
		}
	}

	public unsafe float customMovementSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customMovementSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customMovementSpeed)) = num;
		}
	}

	public unsafe bool disableGravity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableGravity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableGravity)) = flag;
		}
	}

	public unsafe bool disableHeadBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableHeadBob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableHeadBob)) = flag;
		}
	}

	public unsafe bool useXLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useXLook);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useXLook)) = flag;
		}
	}

	public unsafe AnimationCurve playerXLookCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXLookCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXLookCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useYLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useYLook);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useYLook)) = flag;
		}
	}

	public unsafe AnimationCurve playerYLookCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYLookCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYLookCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useZLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useZLook);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useZLook)) = flag;
		}
	}

	public unsafe AnimationCurve playerZLookCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerZLookCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerZLookCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe TransitionPosition lookRelativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookRelativity);
			return *(TransitionPosition*)num;
		}
		set
		{
			*(TransitionPosition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookRelativity)) = transitionPosition;
		}
	}

	public unsafe float forwardPositionModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardPositionModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardPositionModifier)) = num;
		}
	}

	public unsafe float lookMovementMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookMovementMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookMovementMultiplier)) = num;
		}
	}

	public unsafe bool applyCameraRoll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyCameraRoll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyCameraRoll)) = flag;
		}
	}

	public unsafe AnimationCurve cameraRoll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraRoll);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraRoll)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float rollMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rollMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rollMultiplier)) = num;
		}
	}

	public unsafe bool resetCameraRoll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetCameraRoll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetCameraRoll)) = flag;
		}
	}

	public unsafe bool transitionFromExistingMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionFromExistingMouse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionFromExistingMouse)) = flag;
		}
	}

	public unsafe AnimationCurve mouseTransitionCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseTransitionCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseTransitionCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useChromaticAberration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useChromaticAberration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useChromaticAberration)) = flag;
		}
	}

	public unsafe AnimationCurve chromaticAberrationCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAberrationCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAberrationCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useGain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGain);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGain)) = flag;
		}
	}

	public unsafe AnimationCurve gainCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gainCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gainCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe List<SFXSetting> sfx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sfx);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SFXSetting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sfx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool forceHolsterOnTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHolsterOnTransition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHolsterOnTransition)) = flag;
		}
	}

	public unsafe bool restoreHolsterOnTransitionEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restoreHolsterOnTransitionEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restoreHolsterOnTransitionEnd)) = flag;
		}
	}

	public unsafe bool allowWeaponSwitchingAfterTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWeaponSwitchingAfterTransition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWeaponSwitchingAfterTransition)) = flag;
		}
	}

	public unsafe AnimationCurve playerXRecoilLookCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXRecoilLookCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerXRecoilLookCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve playerYRecoilLookCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYRecoilLookCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerYRecoilLookCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve playerZRecoilLookCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerZRecoilLookCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerZRecoilLookCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool useCustomReturnPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomReturnPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCustomReturnPosition)) = flag;
		}
	}

	public unsafe Vector3 returnPostion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_returnPostion);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_returnPostion)) = vector;
		}
	}

	static PlayerTransitionPreset()
	{
		Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerTransitionPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr);
		NativeFieldInfoPtr_transitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "transitionTime");
		NativeFieldInfoPtr_retainMovementControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "retainMovementControl");
		NativeFieldInfoPtr_controlCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "controlCurve");
		NativeFieldInfoPtr_mouseLookControlCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "mouseLookControlCurve");
		NativeFieldInfoPtr_playerHeightMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerHeightMP");
		NativeFieldInfoPtr_CamHeightMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "CamHeightMP");
		NativeFieldInfoPtr_factorInCrouching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "factorInCrouching");
		NativeFieldInfoPtr_heightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "heightCurve");
		NativeFieldInfoPtr_camHeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "camHeightCurve");
		NativeFieldInfoPtr_useXMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useXMovement");
		NativeFieldInfoPtr_playerXCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerXCurve");
		NativeFieldInfoPtr_useYMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useYMovement");
		NativeFieldInfoPtr_playerYCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerYCurve");
		NativeFieldInfoPtr_useZMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useZMovement");
		NativeFieldInfoPtr_playerZCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerZCurve");
		NativeFieldInfoPtr_fixYMovementForRatController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "fixYMovementForRatController");
		NativeFieldInfoPtr_playerYCurveIfRat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerYCurveIfRat");
		NativeFieldInfoPtr_transitionRelativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "transitionRelativity");
		NativeFieldInfoPtr_disableWriteReturnPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "disableWriteReturnPosition");
		NativeFieldInfoPtr_transitionToSavedReturnPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "transitionToSavedReturnPosition");
		NativeFieldInfoPtr_transitionFromExistingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "transitionFromExistingPosition");
		NativeFieldInfoPtr_positionTransitionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "positionTransitionCurve");
		NativeFieldInfoPtr_invertXPositionBasedOnRelativePlayerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "invertXPositionBasedOnRelativePlayerX");
		NativeFieldInfoPtr_invertYPositionBasedOnRelativePlayerY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "invertYPositionBasedOnRelativePlayerY");
		NativeFieldInfoPtr_invertZPositionBasedOnRelativePlayerZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "invertZPositionBasedOnRelativePlayerZ");
		NativeFieldInfoPtr_raycastCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "raycastCheck");
		NativeFieldInfoPtr_onFailUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "onFailUse");
		NativeFieldInfoPtr_allowMovementOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "allowMovementOnEnd");
		NativeFieldInfoPtr_restoreNormalMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "restoreNormalMovementSpeed");
		NativeFieldInfoPtr_customMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "customMovementSpeed");
		NativeFieldInfoPtr_disableGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "disableGravity");
		NativeFieldInfoPtr_disableHeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "disableHeadBob");
		NativeFieldInfoPtr_useXLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useXLook");
		NativeFieldInfoPtr_playerXLookCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerXLookCurve");
		NativeFieldInfoPtr_useYLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useYLook");
		NativeFieldInfoPtr_playerYLookCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerYLookCurve");
		NativeFieldInfoPtr_useZLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useZLook");
		NativeFieldInfoPtr_playerZLookCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerZLookCurve");
		NativeFieldInfoPtr_lookRelativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "lookRelativity");
		NativeFieldInfoPtr_forwardPositionModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "forwardPositionModifier");
		NativeFieldInfoPtr_lookMovementMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "lookMovementMultiplier");
		NativeFieldInfoPtr_applyCameraRoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "applyCameraRoll");
		NativeFieldInfoPtr_cameraRoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "cameraRoll");
		NativeFieldInfoPtr_rollMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "rollMultiplier");
		NativeFieldInfoPtr_resetCameraRoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "resetCameraRoll");
		NativeFieldInfoPtr_transitionFromExistingMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "transitionFromExistingMouse");
		NativeFieldInfoPtr_mouseTransitionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "mouseTransitionCurve");
		NativeFieldInfoPtr_useChromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useChromaticAberration");
		NativeFieldInfoPtr_chromaticAberrationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "chromaticAberrationCurve");
		NativeFieldInfoPtr_useGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useGain");
		NativeFieldInfoPtr_gainCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "gainCurve");
		NativeFieldInfoPtr_sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "sfx");
		NativeFieldInfoPtr_forceHolsterOnTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "forceHolsterOnTransition");
		NativeFieldInfoPtr_restoreHolsterOnTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "restoreHolsterOnTransitionEnd");
		NativeFieldInfoPtr_allowWeaponSwitchingAfterTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "allowWeaponSwitchingAfterTransition");
		NativeFieldInfoPtr_playerXRecoilLookCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerXRecoilLookCurve");
		NativeFieldInfoPtr_playerYRecoilLookCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerYRecoilLookCurve");
		NativeFieldInfoPtr_playerZRecoilLookCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "playerZRecoilLookCurve");
		NativeFieldInfoPtr_useCustomReturnPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "useCustomReturnPosition");
		NativeFieldInfoPtr_returnPostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, "returnPostion");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr, 100674007);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329863, XrefRangeEnd = 329871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerTransitionPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTransitionPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlayerTransitionPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
