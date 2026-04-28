using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public class RewiredPointerInputModule : BaseInputModule
{
	public class MouseState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_TrackedButtons;

		private static readonly System.IntPtr NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<ButtonState> m_TrackedButtons
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrackedButtons);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ButtonState>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TrackedButtons)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static MouseState()
		{
			Il2CppClassPointerStore<MouseState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "MouseState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseState>.NativeClassPtr);
			NativeFieldInfoPtr_m_TrackedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseState>.NativeClassPtr, "m_TrackedButtons");
			NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100675116);
			NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100675117);
			NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100675118);
			NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100675119);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100675120);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349684, XrefRangeEnd = 349687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyPressesThisFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349687, XrefRangeEnd = 349690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyReleasesThisFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 349703, RefRangeEnd = 349715, XrefRangeStart = 349690, XrefRangeEnd = 349703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonState GetButtonState(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonState>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349715, XrefRangeEnd = 349716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&button);
			*(PointerEventData.FramePressState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stateForMouseButton;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349716, XrefRangeEnd = 349722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseState>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MouseState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MouseButtonEventData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonState;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttonData;

		private static readonly System.IntPtr NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe PointerEventData.FramePressState buttonState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonState);
				return *(PointerEventData.FramePressState*)num;
			}
			set
			{
				*(PointerEventData.FramePressState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonState)) = framePressState;
			}
		}

		public unsafe PlayerPointerEventData buttonData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerPointerEventData));
			}
		}

		static MouseButtonEventData()
		{
			Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "MouseButtonEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr);
			NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr, "buttonState");
			NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr, "buttonData");
			NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr, 100675121);
			NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr, 100675122);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr, 100675123);
		}

		[CallerCount(0)]
		public unsafe bool PressedThisFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool ReleasedThisFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseButtonEventData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseButtonEventData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MouseButtonEventData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ButtonState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Button;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_EventData;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_button_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int m_Button
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Button);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Button)) = num;
			}
		}

		public unsafe MouseButtonEventData m_EventData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MouseButtonEventData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EventData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouseButtonEventData));
			}
		}

		public unsafe MouseButtonEventData eventData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MouseButtonEventData>(intPtr) : null;
			}
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe int button
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 349722, RefRangeEnd = 349786, XrefRangeStart = 349722, XrefRangeEnd = 349722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_button_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static ButtonState()
		{
			Il2CppClassPointerStore<ButtonState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "ButtonState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonState>.NativeClassPtr);
			NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonState>.NativeClassPtr, "m_Button");
			NativeFieldInfoPtr_m_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonState>.NativeClassPtr, "m_EventData");
			NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonState>.NativeClassPtr, 100675124);
			NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonState>.NativeClassPtr, 100675125);
			NativeMethodInfoPtr_get_button_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonState>.NativeClassPtr, 100675126);
			NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonState>.NativeClassPtr, 100675127);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonState>.NativeClassPtr, 100675128);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonState>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ButtonState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class UnityInputSource : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_MousePosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MousePositionPrev;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdatedFrame;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryUpdate_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2 m_MousePosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MousePosition);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MousePosition)) = vector;
			}
		}

		public unsafe Vector2 m_MousePositionPrev
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MousePositionPrev);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MousePositionPrev)) = vector;
			}
		}

		public unsafe int m_LastUpdatedFrame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastUpdatedFrame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastUpdatedFrame)) = num;
			}
		}

		public unsafe virtual int Rewired_002EUI_002EIMouseInputSource_002EplayerId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349786, XrefRangeEnd = 349787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual int Rewired_002EUI_002EITouchInputSource_002EplayerId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual bool Rewired_002EUI_002EIMouseInputSource_002Eenabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349787, XrefRangeEnd = 349788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual bool Rewired_002EUI_002EIMouseInputSource_002Elocked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349788, XrefRangeEnd = 349791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual int Rewired_002EUI_002EIMouseInputSource_002EbuttonCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349791, XrefRangeEnd = 349792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349807, XrefRangeEnd = 349810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349810, XrefRangeEnd = 349811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual Vector2 Rewired_002EUI_002EIMouseInputSource_002EwheelDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349811, XrefRangeEnd = 349814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual bool Rewired_002EUI_002EITouchInputSource_002EtouchSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349814, XrefRangeEnd = 349819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual int Rewired_002EUI_002EITouchInputSource_002EtouchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349819, XrefRangeEnd = 349824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static UnityInputSource()
		{
			Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "UnityInputSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr);
			NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, "m_MousePosition");
			NativeFieldInfoPtr_m_MousePositionPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, "m_MousePositionPrev");
			NativeFieldInfoPtr_m_LastUpdatedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, "m_LastUpdatedFrame");
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675129);
			NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675130);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675131);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675132);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675133);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675134);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675135);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675136);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675137);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675138);
			NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675139);
			NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675140);
			NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675141);
			NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675142);
			NativeMethodInfoPtr_TryUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675143);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr, 100675144);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349792, XrefRangeEnd = 349797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Rewired_UI_IMouseInputSource_GetButtonDown(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349797, XrefRangeEnd = 349802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Rewired_UI_IMouseInputSource_GetButtonUp(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349802, XrefRangeEnd = 349807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Rewired_UI_IMouseInputSource_GetButton(int button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&button);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349824, XrefRangeEnd = 349827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Touch Rewired_UI_ITouchInputSource_GetTouch(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Touch*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 349833, RefRangeEnd = 349847, XrefRangeStart = 349827, XrefRangeEnd = 349833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe UnityInputSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputSource>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public UnityInputSource(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kMouseLeftId;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMouseRightId;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMouseMiddleId;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFakeTouchesId;

	private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsStartingId;

	private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsMaxCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_customButtonsLastId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseInputSourcesList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerPointerData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UserDefaultTouchInputSource;

	private static readonly System.IntPtr NativeFieldInfoPtr___m_DefaultInputSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseState;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSelection_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe static int kMouseLeftId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMouseLeftId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMouseLeftId, (void*)(&num));
		}
	}

	public unsafe static int kMouseRightId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMouseRightId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMouseRightId, (void*)(&num));
		}
	}

	public unsafe static int kMouseMiddleId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMouseMiddleId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMouseMiddleId, (void*)(&num));
		}
	}

	public unsafe static int kFakeTouchesId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFakeTouchesId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFakeTouchesId, (void*)(&num));
		}
	}

	public unsafe static int customButtonsStartingId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_customButtonsStartingId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_customButtonsStartingId, (void*)(&num));
		}
	}

	public unsafe static int customButtonsMaxCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_customButtonsMaxCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_customButtonsMaxCount, (void*)(&num));
		}
	}

	public unsafe static int customButtonsLastId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_customButtonsLastId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_customButtonsLastId, (void*)(&num));
		}
	}

	public unsafe List<IMouseInputSource> m_MouseInputSourcesList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseInputSourcesList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IMouseInputSource>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseInputSourcesList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>> m_PlayerPointerData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerPointerData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlayerPointerData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe ITouchInputSource m_UserDefaultTouchInputSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserDefaultTouchInputSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UserDefaultTouchInputSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)touchInputSource));
		}
	}

	public unsafe UnityInputSource __m_DefaultInputSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___m_DefaultInputSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityInputSource>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___m_DefaultInputSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityInputSource));
		}
	}

	public unsafe MouseState m_MouseState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MouseState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouseState));
		}
	}

	public unsafe UnityInputSource defaultInputSource
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 349848, RefRangeEnd = 349862, XrefRangeStart = 349847, XrefRangeEnd = 349848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityInputSource>(intPtr) : null;
		}
	}

	public unsafe IMouseInputSource defaultMouseInputSource
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349862, XrefRangeEnd = 349863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr) : null;
		}
	}

	public unsafe ITouchInputSource defaultTouchInputSource
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr) : null;
		}
	}

	public unsafe virtual bool isMouseSupported
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349939, XrefRangeEnd = 349944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static RewiredPointerInputModule()
	{
		Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", "RewiredPointerInputModule");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr);
		NativeFieldInfoPtr_kMouseLeftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kMouseLeftId");
		NativeFieldInfoPtr_kMouseRightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kMouseRightId");
		NativeFieldInfoPtr_kMouseMiddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kMouseMiddleId");
		NativeFieldInfoPtr_kFakeTouchesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kFakeTouchesId");
		NativeFieldInfoPtr_customButtonsStartingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "customButtonsStartingId");
		NativeFieldInfoPtr_customButtonsMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "customButtonsMaxCount");
		NativeFieldInfoPtr_customButtonsLastId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "customButtonsLastId");
		NativeFieldInfoPtr_m_MouseInputSourcesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_MouseInputSourcesList");
		NativeFieldInfoPtr_m_PlayerPointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_PlayerPointerData");
		NativeFieldInfoPtr_m_UserDefaultTouchInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_UserDefaultTouchInputSource");
		NativeFieldInfoPtr___m_DefaultInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "__m_DefaultInputSource");
		NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_MouseState");
		NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675085);
		NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675086);
		NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675087);
		NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675088);
		NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675089);
		NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675090);
		NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675091);
		NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675092);
		NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675093);
		NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675094);
		NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675095);
		NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675096);
		NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675097);
		NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675098);
		NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675099);
		NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675100);
		NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675101);
		NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675102);
		NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675103);
		NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675104);
		NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675105);
		NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675106);
		NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675107);
		NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675108);
		NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675109);
		NativeMethodInfoPtr_ClearSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675110);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675111);
		NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675112);
		NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675113);
		NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675114);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100675115);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349863, XrefRangeEnd = 349864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDefaultMouse(IMouseInputSource mouse)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouse);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 349870, RefRangeEnd = 349881, XrefRangeStart = 349864, XrefRangeEnd = 349870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mouseIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349881, XrefRangeEnd = 349892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveMouseInputSource(IMouseInputSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 349909, RefRangeEnd = 349911, XrefRangeStart = 349892, XrefRangeEnd = 349909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMouseInputSource(IMouseInputSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 349916, RefRangeEnd = 349921, XrefRangeStart = 349911, XrefRangeEnd = 349916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMouseInputSourceCount(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 349928, RefRangeEnd = 349929, XrefRangeStart = 349921, XrefRangeEnd = 349928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void RemoveTouchInputSource(ITouchInputSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349929, XrefRangeEnd = 349935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTouchInputSource(ITouchInputSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetTouchInputSourceCount(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 349937, RefRangeEnd = 349939, XrefRangeStart = 349935, XrefRangeEnd = 349937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearMouseInputSources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsDefaultPlayer(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 349985, RefRangeEnd = 349992, XrefRangeStart = 349944, XrefRangeEnd = 349985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerTypeId;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &create;
		*(PointerEventType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerEventType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new PlayerPointerEventData(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349992, XrefRangeEnd = 350003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerTypeId;
		*(PointerEventType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerEventType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 350009, RefRangeEnd = 350010, XrefRangeStart = 350003, XrefRangeEnd = 350009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePointerData(PlayerPointerEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 350019, RefRangeEnd = 350020, XrefRangeStart = 350010, XrefRangeEnd = 350019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &touchDeviceIndex;
		*(Touch**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &input;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pressed);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref released);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350020, XrefRangeEnd = 350060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mouseIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MouseState>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350060, XrefRangeEnd = 350074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerTypeId;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignorePointerTypeId;
		*(PointerEventType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointerEventType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&pressPos);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentPos;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDragThreshold;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350074, XrefRangeEnd = 350090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ProcessMove(PlayerPointerEventData pointerEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointerEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350090, XrefRangeEnd = 350144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointerEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350144, XrefRangeEnd = 350166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsPointerOverGameObject(int pointerTypeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pointerTypeId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 350190, RefRangeEnd = 350191, XrefRangeStart = 350166, XrefRangeEnd = 350190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350191, XrefRangeEnd = 350254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 350278, RefRangeEnd = 350279, XrefRangeStart = 350254, XrefRangeEnd = 350278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentOverGo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointerEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 350288, RefRangeEnd = 350292, XrefRangeStart = 350279, XrefRangeEnd = 350288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mouseIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(PointerEventData.FramePressState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 350317, RefRangeEnd = 350318, XrefRangeStart = 350292, XrefRangeEnd = 350317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RewiredPointerInputModule()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RewiredPointerInputModule(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
