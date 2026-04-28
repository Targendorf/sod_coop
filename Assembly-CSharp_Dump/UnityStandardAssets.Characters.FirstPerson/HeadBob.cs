using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson;

public class HeadBob : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_Camera;

	private static readonly IntPtr NativeFieldInfoPtr_motionBob;

	private static readonly IntPtr NativeFieldInfoPtr_jumpAndLandingBob;

	private static readonly IntPtr NativeFieldInfoPtr_rigidbodyFirstPersonController;

	private static readonly IntPtr NativeFieldInfoPtr_StrideInterval;

	private static readonly IntPtr NativeFieldInfoPtr_RunningStrideLengthen;

	private static readonly IntPtr NativeFieldInfoPtr_m_PreviouslyGrounded;

	private static readonly IntPtr NativeFieldInfoPtr_m_OriginalCameraPosition;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Camera Camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Camera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera));
		}
	}

	public unsafe CurveControlledBob motionBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBob);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CurveControlledBob>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curveControlledBob));
		}
	}

	public unsafe LerpControlledBob jumpAndLandingBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpAndLandingBob);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LerpControlledBob>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jumpAndLandingBob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lerpControlledBob));
		}
	}

	public unsafe RigidbodyFirstPersonController rigidbodyFirstPersonController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidbodyFirstPersonController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RigidbodyFirstPersonController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidbodyFirstPersonController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbodyFirstPersonController));
		}
	}

	public unsafe float StrideInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrideInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrideInterval)) = num;
		}
	}

	public unsafe float RunningStrideLengthen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunningStrideLengthen);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RunningStrideLengthen)) = num;
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

	static HeadBob()
	{
		Il2CppClassPointerStore<HeadBob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityStandardAssets.Characters.FirstPerson", "HeadBob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadBob>.NativeClassPtr);
		NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "Camera");
		NativeFieldInfoPtr_motionBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "motionBob");
		NativeFieldInfoPtr_jumpAndLandingBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "jumpAndLandingBob");
		NativeFieldInfoPtr_rigidbodyFirstPersonController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "rigidbodyFirstPersonController");
		NativeFieldInfoPtr_StrideInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "StrideInterval");
		NativeFieldInfoPtr_RunningStrideLengthen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "RunningStrideLengthen");
		NativeFieldInfoPtr_m_PreviouslyGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "m_PreviouslyGrounded");
		NativeFieldInfoPtr_m_OriginalCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, "m_OriginalCameraPosition");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, 100674316);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, 100674317);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadBob>.NativeClassPtr, 100674318);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346777, XrefRangeEnd = 346786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346786, XrefRangeEnd = 346821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346821, XrefRangeEnd = 346831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeadBob()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeadBob>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HeadBob(IntPtr pointer)
		: base(pointer)
	{
	}
}
