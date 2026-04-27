using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

public class TouchJoystickExample : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_allowMouseControl;

	private static readonly IntPtr NativeFieldInfoPtr_radius;

	private static readonly IntPtr NativeFieldInfoPtr_origAnchoredPosition;

	private static readonly IntPtr NativeFieldInfoPtr_origWorldPosition;

	private static readonly IntPtr NativeFieldInfoPtr_origScreenResolution;

	private static readonly IntPtr NativeFieldInfoPtr_origScreenOrientation;

	private static readonly IntPtr NativeFieldInfoPtr_hasFinger;

	private static readonly IntPtr NativeFieldInfoPtr_lastFingerId;

	private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Restart_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StoreOrigValues_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool allowMouseControl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMouseControl);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowMouseControl)) = flag;
		}
	}

	public unsafe int radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = num;
		}
	}

	public unsafe Vector2 origAnchoredPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origAnchoredPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origAnchoredPosition)) = vector;
		}
	}

	public unsafe Vector3 origWorldPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origWorldPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origWorldPosition)) = vector;
		}
	}

	public unsafe Vector2 origScreenResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origScreenResolution);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origScreenResolution)) = vector;
		}
	}

	public unsafe ScreenOrientation origScreenOrientation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origScreenOrientation);
			return *(ScreenOrientation*)num;
		}
		set
		{
			*(ScreenOrientation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origScreenOrientation)) = screenOrientation;
		}
	}

	public unsafe bool hasFinger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasFinger);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasFinger)) = flag;
		}
	}

	public unsafe int lastFingerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFingerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFingerId)) = num;
		}
	}

	public unsafe Vector2 _position_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__position_k__BackingField);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__position_k__BackingField)) = vector;
		}
	}

	public unsafe Vector2 position
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static TouchJoystickExample()
	{
		Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "TouchJoystickExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr);
		NativeFieldInfoPtr_allowMouseControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "allowMouseControl");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_origAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origAnchoredPosition");
		NativeFieldInfoPtr_origWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origWorldPosition");
		NativeFieldInfoPtr_origScreenResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origScreenResolution");
		NativeFieldInfoPtr_origScreenOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "origScreenOrientation");
		NativeFieldInfoPtr_hasFinger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "hasFinger");
		NativeFieldInfoPtr_lastFingerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "lastFingerId");
		NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, "<position>k__BackingField");
		NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676588);
		NativeMethodInfoPtr_set_position_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676589);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676590);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676591);
		NativeMethodInfoPtr_Restart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676592);
		NativeMethodInfoPtr_StoreOrigValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676593);
		NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676594);
		NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676595);
		NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676596);
		NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676597);
		NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676598);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr, 100676599);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364381, XrefRangeEnd = 364386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364386, XrefRangeEnd = 364394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 364402, RefRangeEnd = 364404, XrefRangeStart = 364394, XrefRangeEnd = 364402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Restart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Restart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 364420, RefRangeEnd = 364422, XrefRangeStart = 364404, XrefRangeEnd = 364420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreOrigValues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreOrigValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void UpdateValue(Vector3 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateValue_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364422, XrefRangeEnd = 364423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364423, XrefRangeEnd = 364428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UnityEngine_EventSystems_IDragHandler_OnDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsMousePointerId(int id)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMousePointerId_Private_Static_Boolean_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364428, XrefRangeEnd = 364431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TouchJoystickExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchJoystickExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TouchJoystickExample(IntPtr pointer)
		: base(pointer)
	{
	}
}
