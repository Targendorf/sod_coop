using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson;

public class FirstPersonController : MonoBehaviour
{
	public class CameraJolt : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_direction;

		private static readonly System.IntPtr NativeFieldInfoPtr_progress;

		private static readonly System.IntPtr NativeFieldInfoPtr_speed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0;

		public unsafe Vector3 direction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = vector;
			}
		}

		public unsafe float progress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progress);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progress)) = num;
			}
		}

		public unsafe float speed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed)) = num;
			}
		}

		static CameraJolt()
		{
			Il2CppClassPointerStore<CameraJolt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "CameraJolt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraJolt>.NativeClassPtr);
			NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraJolt>.NativeClassPtr, "direction");
			NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraJolt>.NativeClassPtr, "progress");
			NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraJolt>.NativeClassPtr, "speed");
			NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraJolt>.NativeClassPtr, 100674309);
		}

		[CallerCount(0)]
		public unsafe CameraJolt(Vector3 newDirection, float newSpeed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraJolt>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&newDirection);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSpeed;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CameraJolt(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityStandardAssets.Characters.FirstPerson.FirstPersonController+<RatJumpCooldown>d__105")]
	public sealed class _RatJumpCooldown_d__105 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_delay;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe FirstPersonController __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonController));
			}
		}

		public unsafe float delay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay)) = num;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _RatJumpCooldown_d__105()
		{
			Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "<RatJumpCooldown>d__105");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, "delay");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, 100674310);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, 100674311);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, 100674312);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, 100674313);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, 100674314);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr, 100674315);
		}

		[CallerCount(0)]
		public unsafe _RatJumpCooldown_d__105(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_RatJumpCooldown_d__105>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345786, XrefRangeEnd = 345789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345789, XrefRangeEnd = 345795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _RatJumpCooldown_d__105(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_enableMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMoving;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableHeadBob;

	private static readonly System.IntPtr NativeFieldInfoPtr_ghostMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_clipping;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncTransforms;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerScript;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsWalking;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RunToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WalkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RunSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RunstepLenghten;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StickToGroundForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GravityMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseFovKick;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FovKick;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HeadBob;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseJumpBob;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_JumpBob;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StepInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightFootNext;

	private static readonly System.IntPtr NativeFieldInfoPtr_leanPivot;

	private static readonly System.IntPtr NativeFieldInfoPtr_leanSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLeanAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLeanMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Camera;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Jump;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_YRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Input;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MoveDir;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterController;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CollisionFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviouslyGrounded;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalCameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StepCycle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NextStep;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Jumping;

	private static readonly System.IntPtr NativeFieldInfoPtr_leanState;

	private static readonly System.IntPtr NativeFieldInfoPtr_leanProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentLeanAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentLeanMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeJolts;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastY;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementThisUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitInfoArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_slopeLimitForAddedJumpCooldown;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxGroundedDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxWallRunDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr__ratJumpHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ratMoveSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_addedSprintValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallJumpDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_slopeGroundJumpDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_groundJumpDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_minCamAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCamAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr__ratGroundMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr__ratMoveDir;

	private static readonly System.IntPtr NativeFieldInfoPtr__groundHitInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr__wallHitInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr__isRatGrounded;

	private static readonly System.IntPtr NativeFieldInfoPtr__ratGroundedPossible;

	private static readonly System.IntPtr NativeFieldInfoPtr__isWallRunning;

	private static readonly System.IntPtr NativeFieldInfoPtr__ratJumpCooldownActive;

	private static readonly System.IntPtr NativeFieldInfoPtr__ratVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr__groundHitPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr__groundHitNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr__groundForwardVector;

	private static readonly System.IntPtr NativeFieldInfoPtr__moveVector;

	private static readonly System.IntPtr NativeFieldInfoPtr__wallRunHitPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr__wallRunHitNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr__wallRunHitForwardVector;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputVector;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseInput;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentSlopeAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr__camRotX;

	private static readonly System.IntPtr NativeFieldInfoPtr__camRotY;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitialiseController_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayLandingSound_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerOutOfWorldCheck_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMovement_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoltCamera_Public_Void_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProgressStepCycle_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraPosition_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraPositionRatController_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateView_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoHeadBob_Public_Vector3_CurveControlledBob_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateGroundAsRat_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateRatMouseMovement_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRatMovement_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleRatJumping_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RatJumpCooldown_Private_IEnumerator_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreWeClimbingABuilding_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckWallCeilingCollision_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool enableMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMovement)) = flag;
		}
	}

	public unsafe bool enableLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableLook);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableLook)) = flag;
		}
	}

	public unsafe bool isMoving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMoving);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMoving)) = flag;
		}
	}

	public unsafe bool movementChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementChange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementChange)) = flag;
		}
	}

	public unsafe bool enableHeadBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHeadBob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHeadBob)) = flag;
		}
	}

	public unsafe bool ghostMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ghostMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ghostMovement)) = flag;
		}
	}

	public unsafe bool clipping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipping)) = flag;
		}
	}

	public unsafe bool syncTransforms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncTransforms);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncTransforms)) = flag;
		}
	}

	public unsafe Player playerScript
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerScript);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerScript)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player));
		}
	}

	public unsafe bool m_IsWalking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsWalking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsWalking)) = flag;
		}
	}

	public unsafe bool m_RunToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunToggle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunToggle)) = flag;
		}
	}

	public unsafe float m_WalkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WalkSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WalkSpeed)) = num;
		}
	}

	public unsafe float m_RunSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunSpeed)) = num;
		}
	}

	public unsafe float speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed)) = num;
		}
	}

	public unsafe float m_RunstepLenghten
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunstepLenghten);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunstepLenghten)) = num;
		}
	}

	public unsafe float m_StickToGroundForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StickToGroundForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StickToGroundForce)) = num;
		}
	}

	public unsafe float m_GravityMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GravityMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GravityMultiplier)) = num;
		}
	}

	public unsafe MouseLook m_MouseLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MouseLook>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouseLook));
		}
	}

	public unsafe bool m_UseFovKick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFovKick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFovKick)) = flag;
		}
	}

	public unsafe FOVKick m_FovKick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FovKick);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FOVKick>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FovKick)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fOVKick));
		}
	}

	public unsafe CurveControlledBob m_HeadBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HeadBob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CurveControlledBob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HeadBob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curveControlledBob));
		}
	}

	public unsafe bool m_UseJumpBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseJumpBob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseJumpBob)) = flag;
		}
	}

	public unsafe LerpControlledBob m_JumpBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JumpBob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LerpControlledBob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JumpBob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lerpControlledBob));
		}
	}

	public unsafe float m_StepInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepInterval)) = num;
		}
	}

	public unsafe bool rightFootNext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightFootNext);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightFootNext)) = flag;
		}
	}

	public unsafe Transform leanPivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanPivot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanPivot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe float leanSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanSpeed)) = num;
		}
	}

	public unsafe float maxLeanAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLeanAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLeanAngle)) = num;
		}
	}

	public unsafe float maxLeanMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLeanMovement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLeanMovement)) = num;
		}
	}

	public unsafe Camera m_Camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe bool m_Jump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jump)) = flag;
		}
	}

	public unsafe float m_YRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_YRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_YRotation)) = num;
		}
	}

	public unsafe Vector2 m_Input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Input);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Input)) = vector;
		}
	}

	public unsafe Vector3 m_MoveDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveDir);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveDir)) = vector;
		}
	}

	public unsafe CharacterController m_CharacterController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterController));
		}
	}

	public unsafe CollisionFlags m_CollisionFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CollisionFlags);
			return *(CollisionFlags*)num;
		}
		set
		{
			*(CollisionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CollisionFlags)) = collisionFlags;
		}
	}

	public unsafe bool m_PreviouslyGrounded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviouslyGrounded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviouslyGrounded)) = flag;
		}
	}

	public unsafe Vector3 m_OriginalCameraPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OriginalCameraPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OriginalCameraPosition)) = vector;
		}
	}

	public unsafe float m_StepCycle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepCycle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepCycle)) = num;
		}
	}

	public unsafe float m_NextStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextStep);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextStep)) = num;
		}
	}

	public unsafe bool m_Jumping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jumping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jumping)) = flag;
		}
	}

	public unsafe int leanState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanState)) = num;
		}
	}

	public unsafe float leanProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leanProgress)) = num;
		}
	}

	public unsafe float currentLeanAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLeanAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLeanAngle)) = num;
		}
	}

	public unsafe float currentLeanMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLeanMovement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLeanMovement)) = num;
		}
	}

	public unsafe List<CameraJolt> activeJolts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeJolts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CameraJolt>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeJolts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float lastY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastY)) = num;
		}
	}

	public unsafe float fallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallCount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallCount)) = num;
		}
	}

	public unsafe Vector3 previousMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMovement);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMovement)) = vector;
		}
	}

	public unsafe Vector3 movementThisUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementThisUpdate);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementThisUpdate)) = vector;
		}
	}

	public unsafe Il2CppStructArray<RaycastHit> hitInfoArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitInfoArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitInfoArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe float slopeLimitForAddedJumpCooldown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeLimitForAddedJumpCooldown);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeLimitForAddedJumpCooldown)) = num;
		}
	}

	public unsafe float maxGroundedDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxGroundedDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxGroundedDistance)) = num;
		}
	}

	public unsafe float maxWallRunDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWallRunDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWallRunDistance)) = num;
		}
	}

	public unsafe float _ratJumpHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratJumpHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratJumpHeight)) = num;
		}
	}

	public unsafe float ratMoveSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratMoveSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratMoveSpeed)) = num;
		}
	}

	public unsafe float addedSprintValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addedSprintValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addedSprintValue)) = num;
		}
	}

	public unsafe float mouseSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivity)) = num;
		}
	}

	public unsafe float wallJumpDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallJumpDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallJumpDelay)) = num;
		}
	}

	public unsafe float slopeGroundJumpDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeGroundJumpDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeGroundJumpDelay)) = num;
		}
	}

	public unsafe float groundJumpDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundJumpDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundJumpDelay)) = num;
		}
	}

	public unsafe float minCamAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minCamAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minCamAngle)) = num;
		}
	}

	public unsafe float maxCamAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCamAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCamAngle)) = num;
		}
	}

	public unsafe LayerMask _ratGroundMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratGroundMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratGroundMask)) = layerMask;
		}
	}

	public unsafe LayerMask buildingMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingMask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingMask)) = layerMask;
		}
	}

	public unsafe Vector2 _ratMoveDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratMoveDir);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratMoveDir)) = vector;
		}
	}

	public unsafe RaycastHit _groundHitInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundHitInfo);
			return *(RaycastHit*)num;
		}
		set
		{
			*(RaycastHit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundHitInfo)) = raycastHit;
		}
	}

	public unsafe RaycastHit _wallHitInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallHitInfo);
			return *(RaycastHit*)num;
		}
		set
		{
			*(RaycastHit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallHitInfo)) = raycastHit;
		}
	}

	public unsafe bool _isRatGrounded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isRatGrounded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isRatGrounded)) = flag;
		}
	}

	public unsafe bool _ratGroundedPossible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratGroundedPossible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratGroundedPossible)) = flag;
		}
	}

	public unsafe bool _isWallRunning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isWallRunning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isWallRunning)) = flag;
		}
	}

	public unsafe bool _ratJumpCooldownActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratJumpCooldownActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratJumpCooldownActive)) = flag;
		}
	}

	public unsafe Vector3 _ratVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ratVelocity)) = vector;
		}
	}

	public unsafe Vector3 _groundHitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundHitPoint);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundHitPoint)) = vector;
		}
	}

	public unsafe Vector3 _groundHitNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundHitNormal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundHitNormal)) = vector;
		}
	}

	public unsafe Vector3 _groundForwardVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundForwardVector);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundForwardVector)) = vector;
		}
	}

	public unsafe Vector3 _moveVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveVector);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveVector)) = vector;
		}
	}

	public unsafe Vector3 _wallRunHitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallRunHitPoint);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallRunHitPoint)) = vector;
		}
	}

	public unsafe Vector3 _wallRunHitNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallRunHitNormal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallRunHitNormal)) = vector;
		}
	}

	public unsafe Vector3 _wallRunHitForwardVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallRunHitForwardVector);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wallRunHitForwardVector)) = vector;
		}
	}

	public unsafe Vector3 _inputVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputVector);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputVector)) = vector;
		}
	}

	public unsafe Vector2 _mouseInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseInput);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseInput)) = vector;
		}
	}

	public unsafe float _currentSlopeAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentSlopeAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentSlopeAngle)) = num;
		}
	}

	public unsafe float _camRotX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camRotX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camRotX)) = num;
		}
	}

	public unsafe float _camRotY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camRotY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camRotY)) = num;
		}
	}

	static FirstPersonController()
	{
		Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityStandardAssets.Characters.FirstPerson", "FirstPersonController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr);
		NativeFieldInfoPtr_enableMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "enableMovement");
		NativeFieldInfoPtr_enableLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "enableLook");
		NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "isMoving");
		NativeFieldInfoPtr_movementChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "movementChange");
		NativeFieldInfoPtr_enableHeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "enableHeadBob");
		NativeFieldInfoPtr_ghostMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "ghostMovement");
		NativeFieldInfoPtr_clipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "clipping");
		NativeFieldInfoPtr_syncTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "syncTransforms");
		NativeFieldInfoPtr_playerScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "playerScript");
		NativeFieldInfoPtr_m_IsWalking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_IsWalking");
		NativeFieldInfoPtr_m_RunToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_RunToggle");
		NativeFieldInfoPtr_m_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_WalkSpeed");
		NativeFieldInfoPtr_m_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_RunSpeed");
		NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "speed");
		NativeFieldInfoPtr_m_RunstepLenghten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_RunstepLenghten");
		NativeFieldInfoPtr_m_StickToGroundForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_StickToGroundForce");
		NativeFieldInfoPtr_m_GravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_GravityMultiplier");
		NativeFieldInfoPtr_m_MouseLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_MouseLook");
		NativeFieldInfoPtr_m_UseFovKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_UseFovKick");
		NativeFieldInfoPtr_m_FovKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_FovKick");
		NativeFieldInfoPtr_m_HeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_HeadBob");
		NativeFieldInfoPtr_m_UseJumpBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_UseJumpBob");
		NativeFieldInfoPtr_m_JumpBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_JumpBob");
		NativeFieldInfoPtr_m_StepInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_StepInterval");
		NativeFieldInfoPtr_rightFootNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "rightFootNext");
		NativeFieldInfoPtr_leanPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "leanPivot");
		NativeFieldInfoPtr_leanSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "leanSpeed");
		NativeFieldInfoPtr_maxLeanAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "maxLeanAngle");
		NativeFieldInfoPtr_maxLeanMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "maxLeanMovement");
		NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_Camera");
		NativeFieldInfoPtr_m_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_Jump");
		NativeFieldInfoPtr_m_YRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_YRotation");
		NativeFieldInfoPtr_m_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_Input");
		NativeFieldInfoPtr_m_MoveDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_MoveDir");
		NativeFieldInfoPtr_m_CharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_CharacterController");
		NativeFieldInfoPtr_m_CollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_CollisionFlags");
		NativeFieldInfoPtr_m_PreviouslyGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_PreviouslyGrounded");
		NativeFieldInfoPtr_m_OriginalCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_OriginalCameraPosition");
		NativeFieldInfoPtr_m_StepCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_StepCycle");
		NativeFieldInfoPtr_m_NextStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_NextStep");
		NativeFieldInfoPtr_m_Jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "m_Jumping");
		NativeFieldInfoPtr_leanState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "leanState");
		NativeFieldInfoPtr_leanProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "leanProgress");
		NativeFieldInfoPtr_currentLeanAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "currentLeanAngle");
		NativeFieldInfoPtr_currentLeanMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "currentLeanMovement");
		NativeFieldInfoPtr_activeJolts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "activeJolts");
		NativeFieldInfoPtr_lastY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "lastY");
		NativeFieldInfoPtr_fallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "fallCount");
		NativeFieldInfoPtr_previousMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "previousMovement");
		NativeFieldInfoPtr_movementThisUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "movementThisUpdate");
		NativeFieldInfoPtr_hitInfoArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "hitInfoArray");
		NativeFieldInfoPtr_slopeLimitForAddedJumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "slopeLimitForAddedJumpCooldown");
		NativeFieldInfoPtr_maxGroundedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "maxGroundedDistance");
		NativeFieldInfoPtr_maxWallRunDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "maxWallRunDistance");
		NativeFieldInfoPtr__ratJumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_ratJumpHeight");
		NativeFieldInfoPtr_ratMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "ratMoveSpeed");
		NativeFieldInfoPtr_addedSprintValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "addedSprintValue");
		NativeFieldInfoPtr_mouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "mouseSensitivity");
		NativeFieldInfoPtr_wallJumpDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "wallJumpDelay");
		NativeFieldInfoPtr_slopeGroundJumpDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "slopeGroundJumpDelay");
		NativeFieldInfoPtr_groundJumpDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "groundJumpDelay");
		NativeFieldInfoPtr_minCamAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "minCamAngle");
		NativeFieldInfoPtr_maxCamAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "maxCamAngle");
		NativeFieldInfoPtr__ratGroundMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_ratGroundMask");
		NativeFieldInfoPtr_buildingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "buildingMask");
		NativeFieldInfoPtr__ratMoveDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_ratMoveDir");
		NativeFieldInfoPtr__groundHitInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_groundHitInfo");
		NativeFieldInfoPtr__wallHitInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_wallHitInfo");
		NativeFieldInfoPtr__isRatGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_isRatGrounded");
		NativeFieldInfoPtr__ratGroundedPossible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_ratGroundedPossible");
		NativeFieldInfoPtr__isWallRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_isWallRunning");
		NativeFieldInfoPtr__ratJumpCooldownActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_ratJumpCooldownActive");
		NativeFieldInfoPtr__ratVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_ratVelocity");
		NativeFieldInfoPtr__groundHitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_groundHitPoint");
		NativeFieldInfoPtr__groundHitNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_groundHitNormal");
		NativeFieldInfoPtr__groundForwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_groundForwardVector");
		NativeFieldInfoPtr__moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_moveVector");
		NativeFieldInfoPtr__wallRunHitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_wallRunHitPoint");
		NativeFieldInfoPtr__wallRunHitNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_wallRunHitNormal");
		NativeFieldInfoPtr__wallRunHitForwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_wallRunHitForwardVector");
		NativeFieldInfoPtr__inputVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_inputVector");
		NativeFieldInfoPtr__mouseInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_mouseInput");
		NativeFieldInfoPtr__currentSlopeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_currentSlopeAngle");
		NativeFieldInfoPtr__camRotX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_camRotX");
		NativeFieldInfoPtr__camRotY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, "_camRotY");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674286);
		NativeMethodInfoPtr_InitialiseController_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674287);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674288);
		NativeMethodInfoPtr_PlayLandingSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674289);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674290);
		NativeMethodInfoPtr_PlayerOutOfWorldCheck_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674291);
		NativeMethodInfoPtr_UpdateMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674292);
		NativeMethodInfoPtr_JoltCamera_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674293);
		NativeMethodInfoPtr_ProgressStepCycle_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674294);
		NativeMethodInfoPtr_UpdateCameraPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674295);
		NativeMethodInfoPtr_UpdateCameraPositionRatController_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674296);
		NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674297);
		NativeMethodInfoPtr_RotateView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674298);
		NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674299);
		NativeMethodInfoPtr_DoHeadBob_Public_Vector3_CurveControlledBob_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674300);
		NativeMethodInfoPtr_EvaluateGroundAsRat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674301);
		NativeMethodInfoPtr_EvaluateRatMouseMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674302);
		NativeMethodInfoPtr_ApplyRatMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674303);
		NativeMethodInfoPtr_HandleRatJumping_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674304);
		NativeMethodInfoPtr_RatJumpCooldown_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674305);
		NativeMethodInfoPtr_AreWeClimbingABuilding_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674306);
		NativeMethodInfoPtr_CheckWallCeilingCollision_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674307);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr, 100674308);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 345845, RefRangeEnd = 345853, XrefRangeStart = 345795, XrefRangeEnd = 345845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitialiseController(bool setOriginalCamPosition, bool initMouslook = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&setOriginalCamPosition);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &initMouslook;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitialiseController_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345853, XrefRangeEnd = 345940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 345943, RefRangeEnd = 345944, XrefRangeStart = 345940, XrefRangeEnd = 345943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayLandingSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayLandingSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345944, XrefRangeEnd = 345947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 345972, RefRangeEnd = 345975, XrefRangeStart = 345947, XrefRangeEnd = 345972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PlayerOutOfWorldCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerOutOfWorldCheck_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 346171, RefRangeEnd = 346173, XrefRangeStart = 345975, XrefRangeEnd = 346171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 346181, RefRangeEnd = 346187, XrefRangeStart = 346173, XrefRangeEnd = 346181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoltCamera(Vector3 direction, float amplitude, float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&direction);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amplitude;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoltCamera_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346265, RefRangeEnd = 346266, XrefRangeStart = 346187, XrefRangeEnd = 346265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProgressStepCycle(float speed, float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&speed);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProgressStepCycle_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346297, RefRangeEnd = 346298, XrefRangeStart = 346266, XrefRangeEnd = 346297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameraPosition(float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346321, RefRangeEnd = 346322, XrefRangeStart = 346298, XrefRangeEnd = 346321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameraPositionRatController(float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraPositionRatController_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346492, RefRangeEnd = 346493, XrefRangeStart = 346322, XrefRangeEnd = 346492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInput(out float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref speed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346504, RefRangeEnd = 346505, XrefRangeStart = 346493, XrefRangeEnd = 346504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RotateView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346505, XrefRangeEnd = 346524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnControllerColliderHit(ControllerColliderHit hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 346554, RefRangeEnd = 346557, XrefRangeStart = 346524, XrefRangeEnd = 346554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 DoHeadBob(CurveControlledBob bob, float speed, float multiplier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bob);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &multiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoHeadBob_Public_Vector3_CurveControlledBob_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346567, RefRangeEnd = 346568, XrefRangeStart = 346557, XrefRangeEnd = 346567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EvaluateGroundAsRat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateGroundAsRat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346568, XrefRangeEnd = 346589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EvaluateRatMouseMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateRatMouseMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346665, RefRangeEnd = 346666, XrefRangeStart = 346589, XrefRangeEnd = 346665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyRatMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyRatMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346685, RefRangeEnd = 346686, XrefRangeStart = 346666, XrefRangeEnd = 346685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleRatJumping()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleRatJumping_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 346689, RefRangeEnd = 346691, XrefRangeStart = 346686, XrefRangeEnd = 346689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RatJumpCooldown(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delay);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RatJumpCooldown_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346719, RefRangeEnd = 346720, XrefRangeStart = 346691, XrefRangeEnd = 346719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AreWeClimbingABuilding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreWeClimbingABuilding_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 346752, RefRangeEnd = 346753, XrefRangeStart = 346720, XrefRangeEnd = 346752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckWallCeilingCollision()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckWallCeilingCollision_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346753, XrefRangeEnd = 346777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FirstPersonController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirstPersonController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FirstPersonController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
