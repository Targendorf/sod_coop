using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Rewired.Demos;

public class ControlRemappingDemo1 : MonoBehaviour
{
	public class ControllerSelection : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__id;

		private static readonly System.IntPtr NativeFieldInfoPtr__idPrev;

		private static readonly System.IntPtr NativeFieldInfoPtr__type;

		private static readonly System.IntPtr NativeFieldInfoPtr__typePrev;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		public unsafe int _id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id)) = num;
			}
		}

		public unsafe int _idPrev
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__idPrev);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__idPrev)) = num;
			}
		}

		public unsafe ControllerType _type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type);
				return *(ControllerType*)num;
			}
			set
			{
				*(ControllerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type)) = controllerType;
			}
		}

		public unsafe ControllerType _typePrev
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__typePrev);
				return *(ControllerType*)num;
			}
			set
			{
				*(ControllerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__typePrev)) = controllerType;
			}
		}

		public unsafe int id
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 349722, RefRangeEnd = 349786, XrefRangeStart = 349722, XrefRangeEnd = 349786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe ControllerType type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ControllerType*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe int idPrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe ControllerType typePrev
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ControllerType*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool hasSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static ControllerSelection()
		{
			Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "ControllerSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr);
			NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, "_id");
			NativeFieldInfoPtr__idPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, "_idPrev");
			NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, "_type");
			NativeFieldInfoPtr__typePrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, "_typePrev");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676484);
			NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676485);
			NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676486);
			NativeMethodInfoPtr_get_type_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676487);
			NativeMethodInfoPtr_set_type_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676488);
			NativeMethodInfoPtr_get_idPrev_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676489);
			NativeMethodInfoPtr_get_typePrev_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676490);
			NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676491);
			NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676492);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr, 100676493);
		}

		[CallerCount(0)]
		public unsafe ControllerSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerSelection>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void Set(int id, ControllerType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&id);
			*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Int32_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ControllerSelection(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DialogHelper : Il2CppSystem.Object
	{
		public enum DialogType
		{
			None = 0,
			JoystickConflict = 1,
			ElementConflict = 2,
			KeyConflict = 3,
			DeleteAssignmentConfirmation = 10,
			AssignElement = 11
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_openBusyDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr_closeBusyDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr__type;

		private static readonly System.IntPtr NativeFieldInfoPtr__enabled;

		private static readonly System.IntPtr NativeFieldInfoPtr__busyTime;

		private static readonly System.IntPtr NativeFieldInfoPtr__busyTimerRunning;

		private static readonly System.IntPtr NativeFieldInfoPtr_drawWindowDelegate;

		private static readonly System.IntPtr NativeFieldInfoPtr_drawWindowFunction;

		private static readonly System.IntPtr NativeFieldInfoPtr_windowProperties;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentActionId;

		private static readonly System.IntPtr NativeFieldInfoPtr_resultCallback;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_DialogType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_busy_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawCancelButton_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimers_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_StateChanged_Private_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ResetTimers_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FullReset_Public_Void_0;

		public unsafe static float openBusyDelay
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_openBusyDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_openBusyDelay, (void*)(&num));
			}
		}

		public unsafe static float closeBusyDelay
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_closeBusyDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_closeBusyDelay, (void*)(&num));
			}
		}

		public unsafe DialogType _type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type);
				return *(DialogType*)num;
			}
			set
			{
				*(DialogType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type)) = dialogType;
			}
		}

		public unsafe bool _enabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enabled)) = flag;
			}
		}

		public unsafe float _busyTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__busyTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__busyTime)) = num;
			}
		}

		public unsafe bool _busyTimerRunning
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__busyTimerRunning);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__busyTimerRunning)) = flag;
			}
		}

		public unsafe Il2CppSystem.Action<int> drawWindowDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawWindowDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawWindowDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe GUI.WindowFunction drawWindowFunction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawWindowFunction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUI.WindowFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawWindowFunction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowFunction));
			}
		}

		public unsafe WindowProperties windowProperties
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowProperties);
				return new WindowProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowProperties), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowProperties)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int currentActionId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentActionId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentActionId)) = num;
			}
		}

		public unsafe Il2CppSystem.Action<int, UserResponse> resultCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, UserResponse>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe float busyTimer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361945, XrefRangeEnd = 361947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361947, XrefRangeEnd = 361949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe DialogType type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_DialogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(DialogType*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361949, XrefRangeEnd = 361953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe bool busy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_busy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static DialogHelper()
		{
			Il2CppClassPointerStore<DialogHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "DialogHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr);
			NativeFieldInfoPtr_openBusyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "openBusyDelay");
			NativeFieldInfoPtr_closeBusyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "closeBusyDelay");
			NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "_type");
			NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "_enabled");
			NativeFieldInfoPtr__busyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "_busyTime");
			NativeFieldInfoPtr__busyTimerRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "_busyTimerRunning");
			NativeFieldInfoPtr_drawWindowDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "drawWindowDelegate");
			NativeFieldInfoPtr_drawWindowFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "drawWindowFunction");
			NativeFieldInfoPtr_windowProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "windowProperties");
			NativeFieldInfoPtr_currentActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "currentActionId");
			NativeFieldInfoPtr_resultCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, "resultCallback");
			NativeMethodInfoPtr_get_busyTimer_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676494);
			NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676495);
			NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676496);
			NativeMethodInfoPtr_get_type_Public_get_DialogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676497);
			NativeMethodInfoPtr_set_type_Public_set_Void_DialogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676498);
			NativeMethodInfoPtr_get_busy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676499);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676500);
			NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676501);
			NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676502);
			NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676503);
			NativeMethodInfoPtr_Draw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676504);
			NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676505);
			NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676506);
			NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676507);
			NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676508);
			NativeMethodInfoPtr_DrawCancelButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676509);
			NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676510);
			NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676511);
			NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676512);
			NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676513);
			NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676514);
			NativeMethodInfoPtr_UpdateTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676515);
			NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676516);
			NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676517);
			NativeMethodInfoPtr_StateChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676518);
			NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676519);
			NativeMethodInfoPtr_ResetTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676520);
			NativeMethodInfoPtr_FullReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr, 100676521);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361953, XrefRangeEnd = 361965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogHelper>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361965, XrefRangeEnd = 361966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Il2CppSystem.Action<int, UserResponse> resultCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&queueActionId);
			*(DialogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)windowProperties));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultCallback);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 361971, RefRangeEnd = 361979, XrefRangeStart = 361966, XrefRangeEnd = 361971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Il2CppSystem.Action<int, UserResponse> resultCallback, float openBusyDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&queueActionId);
			*(DialogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)windowProperties));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultCallback);
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &openBusyDelay;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartModal_Public_Void_Int32_DialogType_WindowProperties_Action_2_Int32_UserResponse_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361979, XrefRangeEnd = 361982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 362001, RefRangeEnd = 362004, XrefRangeStart = 361982, XrefRangeEnd = 362001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362004, XrefRangeEnd = 362007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawConfirmButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawConfirmButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 362029, RefRangeEnd = 362033, XrefRangeStart = 362007, XrefRangeEnd = 362029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawConfirmButton(string title)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawConfirmButton_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362033, XrefRangeEnd = 362036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawConfirmButton(UserResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&response);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 362058, RefRangeEnd = 362062, XrefRangeStart = 362036, XrefRangeEnd = 362058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawConfirmButton(UserResponse response, string title)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&response);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawConfirmButton_Public_Void_UserResponse_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362062, XrefRangeEnd = 362065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCancelButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCancelButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 362087, RefRangeEnd = 362092, XrefRangeStart = 362065, XrefRangeEnd = 362087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCancelButton(string title)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCancelButton_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362094, RefRangeEnd = 362095, XrefRangeStart = 362092, XrefRangeEnd = 362094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362095, XrefRangeEnd = 362097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm(UserResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&response);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362097, XrefRangeEnd = 362099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362099, XrefRangeEnd = 362100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWindow(int windowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&windowId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362100, XrefRangeEnd = 362102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362104, RefRangeEnd = 362105, XrefRangeStart = 362102, XrefRangeEnd = 362104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBusyTimer(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&time);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartBusyTimer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 362107, RefRangeEnd = 362115, XrefRangeStart = 362105, XrefRangeEnd = 362107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362104, RefRangeEnd = 362105, XrefRangeStart = 362104, XrefRangeEnd = 362105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StateChanged(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&delay);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StateChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void ResetTimers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void FullReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DialogHelper(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class QueueEntry : Il2CppSystem.Object
	{
		public enum State
		{
			Waiting,
			Confirmed,
			Canceled
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__queueActionType_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__state_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__response_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_uidCounter;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_State_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Protected_set_Void_State_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_response_Public_get_UserResponse_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		public unsafe int _id_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField)) = num;
			}
		}

		public unsafe QueueActionType _queueActionType_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queueActionType_k__BackingField);
				return *(QueueActionType*)num;
			}
			set
			{
				*(QueueActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__queueActionType_k__BackingField)) = queueActionType;
			}
		}

		public unsafe State _state_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField);
				return *(State*)num;
			}
			set
			{
				*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField)) = state;
			}
		}

		public unsafe UserResponse _response_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__response_k__BackingField);
				return *(UserResponse*)num;
			}
			set
			{
				*(UserResponse*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__response_k__BackingField)) = userResponse;
			}
		}

		public unsafe static int uidCounter
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uidCounter, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uidCounter, (void*)(&num));
			}
		}

		public unsafe int id
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 349722, RefRangeEnd = 349786, XrefRangeStart = 349722, XrefRangeEnd = 349786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe QueueActionType queueActionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(QueueActionType*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe State state
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(State*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_state_Protected_set_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe UserResponse response
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_response_Public_get_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(UserResponse*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe static int nextId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362115, XrefRangeEnd = 362117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static QueueEntry()
		{
			Il2CppClassPointerStore<QueueEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "QueueEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr);
			NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, "<id>k__BackingField");
			NativeFieldInfoPtr__queueActionType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, "<queueActionType>k__BackingField");
			NativeFieldInfoPtr__state_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, "<state>k__BackingField");
			NativeFieldInfoPtr__response_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, "<response>k__BackingField");
			NativeFieldInfoPtr_uidCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, "uidCounter");
			NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676522);
			NativeMethodInfoPtr_set_id_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676523);
			NativeMethodInfoPtr_get_queueActionType_Public_get_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676524);
			NativeMethodInfoPtr_set_queueActionType_Protected_set_Void_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676525);
			NativeMethodInfoPtr_get_state_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676526);
			NativeMethodInfoPtr_set_state_Protected_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676527);
			NativeMethodInfoPtr_get_response_Public_get_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676528);
			NativeMethodInfoPtr_set_response_Protected_set_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676529);
			NativeMethodInfoPtr_get_nextId_Protected_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676530);
			NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676531);
			NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676532);
			NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr, 100676533);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362117, XrefRangeEnd = 362119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueEntry(QueueActionType queueActionType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&queueActionType);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_QueueActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void Confirm(UserResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&response);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Confirm_Public_Void_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public QueueEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class JoystickAssignmentChange : QueueEntry
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__playerId_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__joystickId_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__assign_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_assign_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;

		public unsafe int _playerId_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId_k__BackingField)) = num;
			}
		}

		public unsafe int _joystickId_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickId_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickId_k__BackingField)) = num;
			}
		}

		public unsafe bool _assign_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assign_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assign_k__BackingField)) = flag;
			}
		}

		public unsafe int playerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe int joystickId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe bool assign
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_assign_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static JoystickAssignmentChange()
		{
			Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "JoystickAssignmentChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr);
			NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, "<playerId>k__BackingField");
			NativeFieldInfoPtr__joystickId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, "<joystickId>k__BackingField");
			NativeFieldInfoPtr__assign_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, "<assign>k__BackingField");
			NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, 100676534);
			NativeMethodInfoPtr_set_playerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, 100676535);
			NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, 100676536);
			NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, 100676537);
			NativeMethodInfoPtr_get_assign_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, 100676538);
			NativeMethodInfoPtr_set_assign_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, 100676539);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr, 100676540);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362121, RefRangeEnd = 362122, XrefRangeStart = 362119, XrefRangeEnd = 362121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickAssignmentChange>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&newPlayerId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &joystickId;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assign;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public JoystickAssignmentChange(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ElementAssignmentChange : QueueEntry
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__changeType_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__context_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_context_Public_get_Context_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_context_Private_set_Void_Context_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0;

		public unsafe ElementAssignmentChangeType _changeType_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__changeType_k__BackingField);
				return *(ElementAssignmentChangeType*)num;
			}
			set
			{
				*(ElementAssignmentChangeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__changeType_k__BackingField)) = elementAssignmentChangeType;
			}
		}

		public unsafe InputMapper.Context _context_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__context_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__context_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context));
			}
		}

		public unsafe ElementAssignmentChangeType changeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ElementAssignmentChangeType*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe InputMapper.Context context
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputMapper.Context>(intPtr) : null;
			}
			[CallerCount(60)]
			[CachedScanResults(RefRangeStart = 71605, RefRangeEnd = 71665, XrefRangeStart = 71605, XrefRangeEnd = 71665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_context_Private_set_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static ElementAssignmentChange()
		{
			Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "ElementAssignmentChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr);
			NativeFieldInfoPtr__changeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, "<changeType>k__BackingField");
			NativeFieldInfoPtr__context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, "<context>k__BackingField");
			NativeMethodInfoPtr_get_changeType_Public_get_ElementAssignmentChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, 100676541);
			NativeMethodInfoPtr_set_changeType_Public_set_Void_ElementAssignmentChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, 100676542);
			NativeMethodInfoPtr_get_context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, 100676543);
			NativeMethodInfoPtr_set_context_Private_set_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, 100676544);
			NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, 100676545);
			NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr, 100676546);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 362124, RefRangeEnd = 362128, XrefRangeStart = 362122, XrefRangeEnd = 362124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&changeType);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChangeType_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362128, XrefRangeEnd = 362131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementAssignmentChange(ElementAssignmentChange other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementAssignmentChange>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ElementAssignmentChange(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class FallbackJoystickIdentification : QueueEntry
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__joystickId_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__joystickName_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		public unsafe int _joystickId_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickId_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickId_k__BackingField)) = num;
			}
		}

		public unsafe string _joystickName_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int joystickId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe string joystickName
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(60)]
			[CachedScanResults(RefRangeStart = 71605, RefRangeEnd = 71665, XrefRangeStart = 71605, XrefRangeEnd = 71665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static FallbackJoystickIdentification()
		{
			Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "FallbackJoystickIdentification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr);
			NativeFieldInfoPtr__joystickId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr, "<joystickId>k__BackingField");
			NativeFieldInfoPtr__joystickName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr, "<joystickName>k__BackingField");
			NativeMethodInfoPtr_get_joystickId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr, 100676547);
			NativeMethodInfoPtr_set_joystickId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr, 100676548);
			NativeMethodInfoPtr_get_joystickName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr, 100676549);
			NativeMethodInfoPtr_set_joystickName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr, 100676550);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr, 100676551);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362131, XrefRangeEnd = 362133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallbackJoystickIdentification(int joystickId, string joystickName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackJoystickIdentification>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&joystickId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(joystickName);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FallbackJoystickIdentification(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Calibration : QueueEntry
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__player_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__controllerType_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__joystick_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__calibrationMap_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr_selectedElementIdentifierId;

		private static readonly System.IntPtr NativeFieldInfoPtr_recording;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Public_get_Player_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_player_Private_set_Void_Player_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0;

		public unsafe Player _player_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__player_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__player_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player));
			}
		}

		public unsafe ControllerType _controllerType_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerType_k__BackingField);
				return *(ControllerType*)num;
			}
			set
			{
				*(ControllerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerType_k__BackingField)) = controllerType;
			}
		}

		public unsafe Joystick _joystick_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystick_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystick_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick));
			}
		}

		public unsafe CalibrationMap _calibrationMap_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationMap_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationMap_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)calibrationMap));
			}
		}

		public unsafe int selectedElementIdentifierId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedElementIdentifierId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedElementIdentifierId)) = num;
			}
		}

		public unsafe bool recording
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recording);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recording)) = flag;
			}
		}

		public unsafe Player player
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59183, XrefRangeStart = 59139, XrefRangeEnd = 59183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ControllerType*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Joystick joystick
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 353048, RefRangeEnd = 353057, XrefRangeStart = 353048, XrefRangeEnd = 353057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 360364, RefRangeEnd = 360388, XrefRangeStart = 360364, XrefRangeEnd = 360388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe CalibrationMap calibrationMap
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 353057, RefRangeEnd = 353062, XrefRangeStart = 353057, XrefRangeEnd = 353062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CalibrationMap>(intPtr) : null;
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 360388, RefRangeEnd = 360410, XrefRangeStart = 360388, XrefRangeEnd = 360410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static Calibration()
		{
			Il2CppClassPointerStore<Calibration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "Calibration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Calibration>.NativeClassPtr);
			NativeFieldInfoPtr__player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calibration>.NativeClassPtr, "<player>k__BackingField");
			NativeFieldInfoPtr__controllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calibration>.NativeClassPtr, "<controllerType>k__BackingField");
			NativeFieldInfoPtr__joystick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calibration>.NativeClassPtr, "<joystick>k__BackingField");
			NativeFieldInfoPtr__calibrationMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calibration>.NativeClassPtr, "<calibrationMap>k__BackingField");
			NativeFieldInfoPtr_selectedElementIdentifierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calibration>.NativeClassPtr, "selectedElementIdentifierId");
			NativeFieldInfoPtr_recording = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Calibration>.NativeClassPtr, "recording");
			NativeMethodInfoPtr_get_player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676552);
			NativeMethodInfoPtr_set_player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676553);
			NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676554);
			NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676555);
			NativeMethodInfoPtr_get_joystick_Public_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676556);
			NativeMethodInfoPtr_set_joystick_Private_set_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676557);
			NativeMethodInfoPtr_get_calibrationMap_Public_get_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676558);
			NativeMethodInfoPtr_set_calibrationMap_Private_set_Void_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676559);
			NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Calibration>.NativeClassPtr, 100676560);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362133, XrefRangeEnd = 362135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Calibration>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)calibrationMap);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Player_Joystick_CalibrationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Calibration(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class WindowProperties : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_windowId;

		private static readonly System.IntPtr NativeFieldInfoPtr_rect;

		private static readonly System.IntPtr NativeFieldInfoPtr_windowDrawDelegate;

		private static readonly System.IntPtr NativeFieldInfoPtr_title;

		private static readonly System.IntPtr NativeFieldInfoPtr_message;

		public unsafe int windowId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowId)) = num;
			}
		}

		public unsafe Rect rect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rect);
				return *(Rect*)num;
			}
			set
			{
				*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rect)) = rect;
			}
		}

		public unsafe Il2CppSystem.Action<string, string> windowDrawDelegate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowDrawDelegate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string, string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowDrawDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe string title
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string message
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static WindowProperties()
		{
			Il2CppClassPointerStore<WindowProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "WindowProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr);
			NativeFieldInfoPtr_windowId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr, "windowId");
			NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr, "rect");
			NativeFieldInfoPtr_windowDrawDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr, "windowDrawDelegate");
			NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr, "title");
			NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr, "message");
		}

		public WindowProperties(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public WindowProperties()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowProperties>.NativeClassPtr))
		{
		}
	}

	public enum QueueActionType
	{
		None,
		JoystickAssignment,
		ElementAssignment,
		FallbackJoystickIdentification,
		Calibrate
	}

	public enum ElementAssignmentChangeType
	{
		Add,
		Replace,
		Remove,
		ReassignOrRemove,
		ConflictCheck
	}

	public enum UserResponse
	{
		Confirm,
		Cancel,
		Custom1,
		Custom2
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultModalWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultModalHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignmentTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMapper;

	private static readonly System.IntPtr NativeFieldInfoPtr_conflictFoundEventData;

	private static readonly System.IntPtr NativeFieldInfoPtr_guiState;

	private static readonly System.IntPtr NativeFieldInfoPtr_busy;

	private static readonly System.IntPtr NativeFieldInfoPtr_pageGUIState;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedMapCategoryId;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedController;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_showMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_startListening;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionScrollPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_calibrateScrollPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_setupFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCompiling;

	private static readonly System.IntPtr NativeFieldInfoPtr_style_wordWrap;

	private static readonly System.IntPtr NativeFieldInfoPtr_style_centeredBox;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleMenuControl_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPage_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMapCategories_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowDialog_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessQueue_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearMapSelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAll_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckRecompile_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float defaultModalWidth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultModalWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultModalWidth, (void*)(&num));
		}
	}

	public unsafe static float defaultModalHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultModalHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultModalHeight, (void*)(&num));
		}
	}

	public unsafe static float assignmentTimeout
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assignmentTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assignmentTimeout, (void*)(&num));
		}
	}

	public unsafe DialogHelper dialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogHelper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogHelper));
		}
	}

	public unsafe InputMapper inputMapper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMapper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputMapper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMapper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputMapper));
		}
	}

	public unsafe InputMapper.ConflictFoundEventData conflictFoundEventData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conflictFoundEventData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputMapper.ConflictFoundEventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conflictFoundEventData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conflictFoundEventData));
		}
	}

	public unsafe bool guiState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guiState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guiState)) = flag;
		}
	}

	public unsafe bool busy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_busy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_busy)) = flag;
		}
	}

	public unsafe bool pageGUIState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageGUIState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageGUIState)) = flag;
		}
	}

	public unsafe Player selectedPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedPlayer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedPlayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player));
		}
	}

	public unsafe int selectedMapCategoryId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedMapCategoryId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedMapCategoryId)) = num;
		}
	}

	public unsafe ControllerSelection selectedController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerSelection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerSelection));
		}
	}

	public unsafe ControllerMap selectedMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap));
		}
	}

	public unsafe bool showMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMenu)) = flag;
		}
	}

	public unsafe bool startListening
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startListening);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startListening)) = flag;
		}
	}

	public unsafe Vector2 actionScrollPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionScrollPos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionScrollPos)) = vector;
		}
	}

	public unsafe Vector2 calibrateScrollPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calibrateScrollPos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calibrateScrollPos)) = vector;
		}
	}

	public unsafe Queue<QueueEntry> actionQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<QueueEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe bool setupFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setupFinished);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setupFinished)) = flag;
		}
	}

	public unsafe bool initialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialized)) = flag;
		}
	}

	public unsafe bool isCompiling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompiling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompiling)) = flag;
		}
	}

	public unsafe GUIStyle style_wordWrap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style_wordWrap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style_wordWrap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIStyle));
		}
	}

	public unsafe GUIStyle style_centeredBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style_centeredBox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style_centeredBox)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIStyle));
		}
	}

	static ControlRemappingDemo1()
	{
		Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "ControlRemappingDemo1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr);
		NativeFieldInfoPtr_defaultModalWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "defaultModalWidth");
		NativeFieldInfoPtr_defaultModalHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "defaultModalHeight");
		NativeFieldInfoPtr_assignmentTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "assignmentTimeout");
		NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "dialog");
		NativeFieldInfoPtr_inputMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "inputMapper");
		NativeFieldInfoPtr_conflictFoundEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "conflictFoundEventData");
		NativeFieldInfoPtr_guiState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "guiState");
		NativeFieldInfoPtr_busy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "busy");
		NativeFieldInfoPtr_pageGUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "pageGUIState");
		NativeFieldInfoPtr_selectedPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedPlayer");
		NativeFieldInfoPtr_selectedMapCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedMapCategoryId");
		NativeFieldInfoPtr_selectedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedController");
		NativeFieldInfoPtr_selectedMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "selectedMap");
		NativeFieldInfoPtr_showMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "showMenu");
		NativeFieldInfoPtr_startListening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "startListening");
		NativeFieldInfoPtr_actionScrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "actionScrollPos");
		NativeFieldInfoPtr_calibrateScrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "calibrateScrollPos");
		NativeFieldInfoPtr_actionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "actionQueue");
		NativeFieldInfoPtr_setupFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "setupFinished");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_isCompiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "isCompiling");
		NativeFieldInfoPtr_style_wordWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "style_wordWrap");
		NativeFieldInfoPtr_style_centeredBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, "style_centeredBox");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676423);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676424);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676425);
		NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676426);
		NativeMethodInfoPtr_Setup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676427);
		NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676428);
		NativeMethodInfoPtr_Unsubscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676429);
		NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676430);
		NativeMethodInfoPtr_HandleMenuControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676431);
		NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676432);
		NativeMethodInfoPtr_Open_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676433);
		NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676434);
		NativeMethodInfoPtr_DrawPage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676435);
		NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676436);
		NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676437);
		NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676438);
		NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676439);
		NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676440);
		NativeMethodInfoPtr_DrawMapCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676441);
		NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676442);
		NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676443);
		NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676444);
		NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676445);
		NativeMethodInfoPtr_ShowDialog_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676446);
		NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676447);
		NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676448);
		NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676449);
		NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676450);
		NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676451);
		NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676452);
		NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676453);
		NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676454);
		NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676455);
		NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676456);
		NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676457);
		NativeMethodInfoPtr_ProcessQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676458);
		NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676459);
		NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676460);
		NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676461);
		NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676462);
		NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676463);
		NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676464);
		NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676465);
		NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676466);
		NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676467);
		NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676468);
		NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676469);
		NativeMethodInfoPtr_ClearMapSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676470);
		NativeMethodInfoPtr_ResetAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676471);
		NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676472);
		NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676473);
		NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676474);
		NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676475);
		NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676476);
		NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676477);
		NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676478);
		NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676479);
		NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676480);
		NativeMethodInfoPtr_CheckRecompile_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676481);
		NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676482);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr, 100676483);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362135, XrefRangeEnd = 362140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362140, XrefRangeEnd = 362156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362156, XrefRangeEnd = 362158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362211, RefRangeEnd = 362212, XrefRangeStart = 362158, XrefRangeEnd = 362211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362228, RefRangeEnd = 362229, XrefRangeStart = 362212, XrefRangeEnd = 362228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Subscribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unsubscribe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unsubscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362229, XrefRangeEnd = 362274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362274, XrefRangeEnd = 362287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleMenuControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleMenuControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362287, XrefRangeEnd = 362288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Open()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362288, XrefRangeEnd = 362341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawInitialScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawInitialScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362392, RefRangeEnd = 362393, XrefRangeStart = 362341, XrefRangeEnd = 362392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362466, RefRangeEnd = 362467, XrefRangeStart = 362393, XrefRangeEnd = 362466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawPlayerSelector()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPlayerSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362540, RefRangeEnd = 362541, XrefRangeStart = 362467, XrefRangeEnd = 362540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawMouseAssignment()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMouseAssignment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362639, RefRangeEnd = 362640, XrefRangeStart = 362541, XrefRangeEnd = 362639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawJoystickSelector()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawJoystickSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362741, RefRangeEnd = 362742, XrefRangeStart = 362640, XrefRangeEnd = 362741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawControllerSelector()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawControllerSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362795, RefRangeEnd = 362796, XrefRangeStart = 362742, XrefRangeEnd = 362795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawCalibrateButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCalibrateButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 362910, RefRangeEnd = 362911, XrefRangeStart = 362796, XrefRangeEnd = 362910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawMapCategories()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMapCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363104, RefRangeEnd = 363105, XrefRangeStart = 362911, XrefRangeEnd = 363104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawCategoryActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCategoryActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 363141, RefRangeEnd = 363145, XrefRangeStart = 363105, XrefRangeEnd = 363141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elementMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawActionAssignmentButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363170, RefRangeEnd = 363171, XrefRangeStart = 363145, XrefRangeEnd = 363170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(Pole**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionAxisContribution;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elementMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawInvertButton_Private_Void_Int32_InputAction_Pole_ControllerSelection_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 363195, RefRangeEnd = 363199, XrefRangeStart = 363171, XrefRangeEnd = 363195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawAddActionMapButton_Private_Void_Int32_InputAction_AxisRange_ControllerSelection_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363199, XrefRangeEnd = 363202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowDialog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowDialog_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363202, XrefRangeEnd = 363222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawModalWindow(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawModalWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363222, XrefRangeEnd = 363238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawModalWindow_OkayOnly(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawModalWindow_OkayOnly_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363238, XrefRangeEnd = 363250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawElementAssignmentWindow(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawElementAssignmentWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363250, XrefRangeEnd = 363274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawElementAssignmentProtectedConflictWindow(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawElementAssignmentProtectedConflictWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363274, XrefRangeEnd = 363302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawElementAssignmentNormalConflictWindow(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawElementAssignmentNormalConflictWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363302, XrefRangeEnd = 363322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawReassignOrRemoveElementAssignmentWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363322, XrefRangeEnd = 363351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawFallbackJoystickIdentificationWindow(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawFallbackJoystickIdentificationWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363351, XrefRangeEnd = 363653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawCalibrationWindow(string title, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCalibrationWindow_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363653, XrefRangeEnd = 363663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DialogResultCallback(int queueActionId, UserResponse response)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&queueActionId);
		*(UserResponse**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &response;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DialogResultCallback_Private_Void_Int32_UserResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 363667, RefRangeEnd = 363676, XrefRangeStart = 363663, XrefRangeEnd = 363667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rect GetScreenCenteredRect(float width, float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&width);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScreenCenteredRect_Private_Rect_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 363684, RefRangeEnd = 363688, XrefRangeStart = 363676, XrefRangeEnd = 363684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnqueueAction(QueueEntry entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnqueueAction_Private_Void_QueueEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363710, RefRangeEnd = 363711, XrefRangeStart = 363688, XrefRangeEnd = 363710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessQueue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363745, RefRangeEnd = 363746, XrefRangeStart = 363711, XrefRangeEnd = 363745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessJoystickAssignmentChange_Private_Boolean_JoystickAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363757, RefRangeEnd = 363758, XrefRangeStart = 363746, XrefRangeEnd = 363757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessElementAssignmentChange_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363784, RefRangeEnd = 363785, XrefRangeStart = 363758, XrefRangeEnd = 363784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRemoveOrReassignElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363802, RefRangeEnd = 363803, XrefRangeStart = 363785, XrefRangeEnd = 363802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRemoveElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363834, RefRangeEnd = 363835, XrefRangeStart = 363803, XrefRangeEnd = 363834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessAddOrReplaceElementAssignment_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363867, RefRangeEnd = 363868, XrefRangeStart = 363835, XrefRangeEnd = 363867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessElementAssignmentConflictCheck_Private_Boolean_ElementAssignmentChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363885, RefRangeEnd = 363886, XrefRangeStart = 363868, XrefRangeEnd = 363885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessFallbackJoystickIdentification_Private_Boolean_FallbackJoystickIdentification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 363907, RefRangeEnd = 363908, XrefRangeStart = 363886, XrefRangeEnd = 363907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProcessCalibration(Calibration entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCalibration_Private_Boolean_Calibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363908, XrefRangeEnd = 363909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayerSelectionChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerSelectionChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 363909, RefRangeEnd = 363914, XrefRangeStart = 363909, XrefRangeEnd = 363909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ControllerSelectionChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ControllerSelectionChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 363914, RefRangeEnd = 363916, XrefRangeStart = 363914, XrefRangeEnd = 363914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearControllerSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearControllerSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 363909, RefRangeEnd = 363914, XrefRangeStart = 363909, XrefRangeEnd = 363914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearMapSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearMapSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363916, XrefRangeEnd = 363917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 363923, RefRangeEnd = 363929, XrefRangeStart = 363917, XrefRangeEnd = 363923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearWorkingVars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearWorkingVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363929, XrefRangeEnd = 363939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGUIStateStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGUIStateStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363939, XrefRangeEnd = 363948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGUIStateEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGUIStateEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363948, XrefRangeEnd = 363991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363991, XrefRangeEnd = 364031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364031, XrefRangeEnd = 364037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(60)]
	[CachedScanResults(RefRangeStart = 71605, RefRangeEnd = 71665, XrefRangeStart = 71605, XrefRangeEnd = 71665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConflictFound(InputMapper.ConflictFoundEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnConflictFound_Private_Void_ConflictFoundEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnStopped(InputMapper.StoppedEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStopped_Private_Void_StoppedEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 364073, RefRangeEnd = 364076, XrefRangeStart = 364037, XrefRangeEnd = 364073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IdentifyAllJoysticks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckRecompile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckRecompile_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecompileWindow(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecompileWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364076, XrefRangeEnd = 364083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlRemappingDemo1()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlRemappingDemo1>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ControlRemappingDemo1(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
