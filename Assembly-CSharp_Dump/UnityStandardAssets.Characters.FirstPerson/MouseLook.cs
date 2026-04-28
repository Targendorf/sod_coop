using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson;

[System.Serializable]
public class MouseLook : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_clampVerticalRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinimumX;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaximumX;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_charMovementThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_camMovementThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterTargetRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraTargetRot;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerInputX;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerInputY;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerXRot;

	private static readonly System.IntPtr NativeFieldInfoPtr__invertY;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampRotationAroundXAxis_Public_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampRotationAroundYAxis_Public_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool clampVerticalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampVerticalRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampVerticalRotation)) = flag;
		}
	}

	public unsafe float MinimumX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumX)) = num;
		}
	}

	public unsafe float MaximumX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaximumX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaximumX)) = num;
		}
	}

	public unsafe bool lockCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockCursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockCursor)) = flag;
		}
	}

	public unsafe Quaternion charMovementThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charMovementThisFrame);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charMovementThisFrame)) = quaternion;
		}
	}

	public unsafe Quaternion camMovementThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camMovementThisFrame);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camMovementThisFrame)) = quaternion;
		}
	}

	public unsafe Quaternion m_CharacterTargetRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTargetRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTargetRot)) = quaternion;
		}
	}

	public unsafe Quaternion m_CameraTargetRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTargetRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTargetRot)) = quaternion;
		}
	}

	public unsafe float _controllerInputX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerInputX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerInputX)) = num;
		}
	}

	public unsafe float _controllerInputY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerInputY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerInputY)) = num;
		}
	}

	public unsafe float _controllerXRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerXRot);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerXRot)) = num;
		}
	}

	public unsafe bool _invertY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertY)) = flag;
		}
	}

	static MouseLook()
	{
		Il2CppClassPointerStore<MouseLook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityStandardAssets.Characters.FirstPerson", "MouseLook");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseLook>.NativeClassPtr);
		NativeFieldInfoPtr_clampVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "clampVerticalRotation");
		NativeFieldInfoPtr_MinimumX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "MinimumX");
		NativeFieldInfoPtr_MaximumX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "MaximumX");
		NativeFieldInfoPtr_lockCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "lockCursor");
		NativeFieldInfoPtr_charMovementThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "charMovementThisFrame");
		NativeFieldInfoPtr_camMovementThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "camMovementThisFrame");
		NativeFieldInfoPtr_m_CharacterTargetRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "m_CharacterTargetRot");
		NativeFieldInfoPtr_m_CameraTargetRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "m_CameraTargetRot");
		NativeFieldInfoPtr__controllerInputX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "_controllerInputX");
		NativeFieldInfoPtr__controllerInputY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "_controllerInputY");
		NativeFieldInfoPtr__controllerXRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "_controllerXRot");
		NativeFieldInfoPtr__invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, "_invertY");
		NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, 100674319);
		NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, 100674320);
		NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, 100674321);
		NativeMethodInfoPtr_ClampRotationAroundXAxis_Public_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, 100674322);
		NativeMethodInfoPtr_ClampRotationAroundYAxis_Public_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, 100674323);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseLook>.NativeClassPtr, 100674324);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 346835, RefRangeEnd = 346839, XrefRangeStart = 346831, XrefRangeEnd = 346835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(Transform character, Transform camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 346985, RefRangeEnd = 346989, XrefRangeStart = 346839, XrefRangeEnd = 346985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LookRotation(Transform character, Transform camera, bool disableClamp = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)character);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableClamp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCursorLock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346989, XrefRangeEnd = 346992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampRotationAroundXAxis_Public_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346992, XrefRangeEnd = 346995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion ClampRotationAroundYAxis(Quaternion q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampRotationAroundYAxis_Public_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe MouseLook()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseLook>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MouseLook(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
