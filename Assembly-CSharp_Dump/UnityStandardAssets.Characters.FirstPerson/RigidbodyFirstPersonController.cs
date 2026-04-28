using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson;

public class RigidbodyFirstPersonController : MonoBehaviour
{
	[System.Serializable]
	public class MovementSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ForwardSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_BackwardSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_StrafeSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_RunMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_RunKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_JumpForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_SlopeCurveModifier;

		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTargetSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Running;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDesiredTargetSpeed_Public_Void_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Running_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float ForwardSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForwardSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForwardSpeed)) = num;
			}
		}

		public unsafe float BackwardSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackwardSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackwardSpeed)) = num;
			}
		}

		public unsafe float StrafeSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrafeSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrafeSpeed)) = num;
			}
		}

		public unsafe float RunMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunMultiplier)) = num;
			}
		}

		public unsafe KeyCode RunKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunKey);
				return *(KeyCode*)num;
			}
			set
			{
				*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunKey)) = keyCode;
			}
		}

		public unsafe float JumpForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForce);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JumpForce)) = num;
			}
		}

		public unsafe AnimationCurve SlopeCurveModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlopeCurveModifier);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlopeCurveModifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
			}
		}

		public unsafe float CurrentTargetSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentTargetSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentTargetSpeed)) = num;
			}
		}

		public unsafe bool m_Running
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Running);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Running)) = flag;
			}
		}

		public unsafe bool Running
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Running_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static MovementSettings()
		{
			Il2CppClassPointerStore<MovementSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "MovementSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr);
			NativeFieldInfoPtr_ForwardSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "ForwardSpeed");
			NativeFieldInfoPtr_BackwardSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "BackwardSpeed");
			NativeFieldInfoPtr_StrafeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "StrafeSpeed");
			NativeFieldInfoPtr_RunMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "RunMultiplier");
			NativeFieldInfoPtr_RunKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "RunKey");
			NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "JumpForce");
			NativeFieldInfoPtr_SlopeCurveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "SlopeCurveModifier");
			NativeFieldInfoPtr_CurrentTargetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "CurrentTargetSpeed");
			NativeFieldInfoPtr_m_Running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, "m_Running");
			NativeMethodInfoPtr_UpdateDesiredTargetSpeed_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, 100674338);
			NativeMethodInfoPtr_get_Running_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, 100674339);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr, 100674340);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346995, XrefRangeEnd = 346999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDesiredTargetSpeed(Vector2 input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&input);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDesiredTargetSpeed_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347007, RefRangeEnd = 347008, XrefRangeStart = 346999, XrefRangeEnd = 347007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MovementSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovementSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MovementSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AdvancedSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_groundCheckDistance;

		private static readonly System.IntPtr NativeFieldInfoPtr_stickToGroundHelperDistance;

		private static readonly System.IntPtr NativeFieldInfoPtr_slowDownRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_airControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_shellOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float groundCheckDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundCheckDistance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundCheckDistance)) = num;
			}
		}

		public unsafe float stickToGroundHelperDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickToGroundHelperDistance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickToGroundHelperDistance)) = num;
			}
		}

		public unsafe float slowDownRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowDownRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowDownRate)) = num;
			}
		}

		public unsafe bool airControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airControl);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airControl)) = flag;
			}
		}

		public unsafe float shellOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shellOffset);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shellOffset)) = num;
			}
		}

		static AdvancedSettings()
		{
			Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "AdvancedSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr);
			NativeFieldInfoPtr_groundCheckDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr, "groundCheckDistance");
			NativeFieldInfoPtr_stickToGroundHelperDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr, "stickToGroundHelperDistance");
			NativeFieldInfoPtr_slowDownRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr, "slowDownRate");
			NativeFieldInfoPtr_airControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr, "airControl");
			NativeFieldInfoPtr_shellOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr, "shellOffset");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr, 100674341);
		}

		[CallerCount(0)]
		public unsafe AdvancedSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AdvancedSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_cam;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLook;

	private static readonly System.IntPtr NativeFieldInfoPtr_advancedSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RigidBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Capsule;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_YRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GroundContactNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Jump;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviouslyGrounded;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Jumping;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsGrounded;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Jumping_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Running_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlopeMultiplier_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StickToGroundHelper_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Private_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateView_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GroundCheck_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Camera cam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cam)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe MovementSettings movementSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MovementSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)movementSettings));
		}
	}

	public unsafe MouseLook mouseLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MouseLook>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouseLook));
		}
	}

	public unsafe AdvancedSettings advancedSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdvancedSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advancedSettings));
		}
	}

	public unsafe Rigidbody m_RigidBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RigidBody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RigidBody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
		}
	}

	public unsafe CapsuleCollider m_Capsule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Capsule);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Capsule)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capsuleCollider));
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

	public unsafe Vector3 m_GroundContactNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GroundContactNormal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GroundContactNormal)) = vector;
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

	public unsafe bool m_IsGrounded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsGrounded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsGrounded)) = flag;
		}
	}

	public unsafe Vector3 Velocity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347008, XrefRangeEnd = 347010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool Grounded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool Jumping
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Jumping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool Running
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Running_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static RigidbodyFirstPersonController()
	{
		Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityStandardAssets.Characters.FirstPerson", "RigidbodyFirstPersonController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr);
		NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "cam");
		NativeFieldInfoPtr_movementSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "movementSettings");
		NativeFieldInfoPtr_mouseLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "mouseLook");
		NativeFieldInfoPtr_advancedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "advancedSettings");
		NativeFieldInfoPtr_m_RigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_RigidBody");
		NativeFieldInfoPtr_m_Capsule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_Capsule");
		NativeFieldInfoPtr_m_YRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_YRotation");
		NativeFieldInfoPtr_m_GroundContactNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_GroundContactNormal");
		NativeFieldInfoPtr_m_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_Jump");
		NativeFieldInfoPtr_m_PreviouslyGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_PreviouslyGrounded");
		NativeFieldInfoPtr_m_Jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_Jumping");
		NativeFieldInfoPtr_m_IsGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, "m_IsGrounded");
		NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674325);
		NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674326);
		NativeMethodInfoPtr_get_Jumping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674327);
		NativeMethodInfoPtr_get_Running_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674328);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674329);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674330);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674331);
		NativeMethodInfoPtr_SlopeMultiplier_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674332);
		NativeMethodInfoPtr_StickToGroundHelper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674333);
		NativeMethodInfoPtr_GetInput_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674334);
		NativeMethodInfoPtr_RotateView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674335);
		NativeMethodInfoPtr_GroundCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674336);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr, 100674337);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347010, XrefRangeEnd = 347026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347026, XrefRangeEnd = 347033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347033, XrefRangeEnd = 347075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347075, XrefRangeEnd = 347083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float SlopeMultiplier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlopeMultiplier_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 347106, RefRangeEnd = 347107, XrefRangeStart = 347083, XrefRangeEnd = 347106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StickToGroundHelper()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StickToGroundHelper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 347127, RefRangeEnd = 347128, XrefRangeStart = 347107, XrefRangeEnd = 347127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInput_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 347152, RefRangeEnd = 347153, XrefRangeStart = 347128, XrefRangeEnd = 347152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RotateView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 347171, RefRangeEnd = 347172, XrefRangeStart = 347153, XrefRangeEnd = 347171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GroundCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GroundCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347172, XrefRangeEnd = 347185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RigidbodyFirstPersonController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RigidbodyFirstPersonController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RigidbodyFirstPersonController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
