using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

public class InputBehaviorWindow : Window
{
	public class InputBehaviorInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__inputBehavior;

		private static readonly System.IntPtr NativeFieldInfoPtr__controlSet;

		private static readonly System.IntPtr NativeFieldInfoPtr_idToProperty;

		private static readonly System.IntPtr NativeFieldInfoPtr_copyOfOriginal;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RestorePreviousData_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshControls_Public_Void_0;

		public unsafe InputBehavior _inputBehavior
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehavior);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehavior)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputBehavior));
			}
		}

		public unsafe UIControlSet _controlSet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controlSet);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIControlSet>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controlSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIControlSet));
			}
		}

		public unsafe Dictionary<int, PropertyType> idToProperty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idToProperty);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, PropertyType>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idToProperty)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe InputBehavior copyOfOriginal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyOfOriginal);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyOfOriginal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputBehavior));
			}
		}

		public unsafe InputBehavior inputBehavior
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr) : null;
			}
		}

		public unsafe UIControlSet controlSet
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIControlSet>(intPtr) : null;
			}
		}

		static InputBehaviorInfo()
		{
			Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "InputBehaviorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr);
			NativeFieldInfoPtr__inputBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, "_inputBehavior");
			NativeFieldInfoPtr__controlSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, "_controlSet");
			NativeFieldInfoPtr_idToProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, "idToProperty");
			NativeFieldInfoPtr_copyOfOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, "copyOfOriginal");
			NativeMethodInfoPtr_get_inputBehavior_Public_get_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, 100676046);
			NativeMethodInfoPtr_get_controlSet_Public_get_UIControlSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, 100676047);
			NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, 100676048);
			NativeMethodInfoPtr_RestorePreviousData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, 100676049);
			NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, 100676050);
			NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, 100676051);
			NativeMethodInfoPtr_RefreshControls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr, 100676052);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359442, RefRangeEnd = 359443, XrefRangeStart = 359438, XrefRangeEnd = 359442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBehaviorInfo(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<int, PropertyType> idToProperty)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputBehavior);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlSet);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)idToProperty);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputBehavior_UIControlSet_Dictionary_2_Int32_PropertyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359443, XrefRangeEnd = 359444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestorePreviousData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestorePreviousData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359444, XrefRangeEnd = 359447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreDefaultData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreDefaultData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359462, RefRangeEnd = 359464, XrefRangeStart = 359447, XrefRangeEnd = 359462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreData(PropertyType propertyType, int controlId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&propertyType);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreData_Public_Void_PropertyType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 359499, RefRangeEnd = 359501, XrefRangeStart = 359464, XrefRangeEnd = 359499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshControls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InputBehaviorInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ButtonIdentifier
	{
		Done,
		Cancel,
		Default
	}

	public enum PropertyType
	{
		JoystickAxisSensitivity,
		MouseXYAxisSensitivity
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.InputBehaviorWindow+<>c__DisplayClass26_0")]
	public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_valueChangedCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputBehaviorId;

		private static readonly System.IntPtr NativeFieldInfoPtr_cancelCallback;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0;

		public unsafe Il2CppSystem.Action<int, int, float> valueChangedCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueChangedCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, int, float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueChangedCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe int inputBehaviorId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputBehaviorId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputBehaviorId)) = num;
			}
		}

		public unsafe Il2CppSystem.Action<int, int> cancelCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static __c__DisplayClass26_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "<>c__DisplayClass26_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr);
			NativeFieldInfoPtr_valueChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, "valueChangedCallback");
			NativeFieldInfoPtr_inputBehaviorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, "inputBehaviorId");
			NativeFieldInfoPtr_cancelCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, "cancelCallback");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100676053);
			NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100676054);
			NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100676055);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass26_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void _CreateSlider_b__0(int cId, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&cId);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateSlider_b__0_Internal_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359501, XrefRangeEnd = 359502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateSlider_b__1(int cId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&cId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateSlider_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass26_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_minSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_doneButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_doneButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiControlSetPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiSliderControlPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputBehaviorInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerId;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDone_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCancel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float minSensitivity
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minSensitivity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minSensitivity, (void*)(&num));
		}
	}

	public unsafe RectTransform spawnTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Button doneButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doneButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doneButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
		}
	}

	public unsafe Button cancelButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
		}
	}

	public unsafe Button defaultButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
		}
	}

	public unsafe TMP_Text doneButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doneButtonLabel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doneButtonLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_Text));
		}
	}

	public unsafe TMP_Text cancelButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelButtonLabel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelButtonLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_Text));
		}
	}

	public unsafe TMP_Text defaultButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultButtonLabel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultButtonLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_Text));
		}
	}

	public unsafe GameObject uiControlSetPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiControlSetPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiControlSetPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject uiSliderControlPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiSliderControlPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiSliderControlPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<InputBehaviorInfo> inputBehaviorInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputBehaviorInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputBehaviorInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputBehaviorInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, Il2CppSystem.Action<int>> buttonCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppSystem.Action<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int playerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId)) = num;
		}
	}

	static InputBehaviorWindow()
	{
		Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "InputBehaviorWindow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr);
		NativeFieldInfoPtr_minSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "minSensitivity");
		NativeFieldInfoPtr_spawnTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "spawnTransform");
		NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "doneButton");
		NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "cancelButton");
		NativeFieldInfoPtr_defaultButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "defaultButton");
		NativeFieldInfoPtr_doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "doneButtonLabel");
		NativeFieldInfoPtr_cancelButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "cancelButtonLabel");
		NativeFieldInfoPtr_defaultButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "defaultButtonLabel");
		NativeFieldInfoPtr_uiControlSetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "uiControlSetPrefab");
		NativeFieldInfoPtr_uiSliderControlPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "uiSliderControlPrefab");
		NativeFieldInfoPtr_inputBehaviorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "inputBehaviorInfo");
		NativeFieldInfoPtr_buttonCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "buttonCallbacks");
		NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, "playerId");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676029);
		NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676030);
		NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676031);
		NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676032);
		NativeMethodInfoPtr_OnDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676033);
		NativeMethodInfoPtr_OnCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676034);
		NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676035);
		NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676036);
		NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676037);
		NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676038);
		NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676039);
		NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676040);
		NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676041);
		NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676042);
		NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676043);
		NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676044);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr, 100676045);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359502, XrefRangeEnd = 359617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(int id, Il2CppSystem.Func<int, bool> isFocusedCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isFocusedCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Int32_Func_2_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 359666, RefRangeEnd = 359667, XrefRangeStart = 359617, XrefRangeEnd = 359666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(int playerId, Il2CppReferenceArray<ControlMapper.InputBehaviorSettings> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_Int32_Il2CppReferenceArray_1_InputBehaviorSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 359672, RefRangeEnd = 359674, XrefRangeStart = 359667, XrefRangeEnd = 359672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetButtonCallback(ButtonIdentifier buttonIdentifier, Il2CppSystem.Action<int> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buttonIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetButtonCallback_Public_Void_ButtonIdentifier_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359674, XrefRangeEnd = 359686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359686, XrefRangeEnd = 359689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359689, XrefRangeEnd = 359699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRestoreDefault()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRestoreDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359699, XrefRangeEnd = 359700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&inputBehaviorId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlId;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoystickAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359700, XrefRangeEnd = 359701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&inputBehaviorId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlId;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseXYAxisSensitivityValueChanged_Private_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359701, XrefRangeEnd = 359703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputBehaviorId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoystickAxisSensitivityCanceled_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359703, XrefRangeEnd = 359705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputBehaviorId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseXYAxisSensitivityCanceled_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359705, XrefRangeEnd = 359706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void TakeInputFocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TakeInputFocus_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 359724, RefRangeEnd = 359725, XrefRangeStart = 359706, XrefRangeEnd = 359724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIControlSet CreateControlSet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateControlSet_Private_UIControlSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIControlSet>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 359770, RefRangeEnd = 359772, XrefRangeStart = 359725, XrefRangeEnd = 359770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Il2CppSystem.Action<int, int, float> valueChangedCallback, Il2CppSystem.Action<int, int> cancelCallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)set);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputBehaviorId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultTitle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overrideTitle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)icon);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &minValue;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)valueChangedCallback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cancelCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSlider_Private_UISliderControl_UIControlSet_Int32_String_String_Sprite_Single_Single_Action_3_Int32_Int32_Single_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UISliderControl>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 359778, RefRangeEnd = 359781, XrefRangeStart = 359772, XrefRangeEnd = 359778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputBehavior GetInputBehavior(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputBehavior_Private_InputBehavior_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputBehavior>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 359783, RefRangeEnd = 359785, XrefRangeStart = 359781, XrefRangeEnd = 359783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputBehaviorId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputBehaviorInfo_Private_InputBehaviorInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputBehaviorInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359785, XrefRangeEnd = 359788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputBehaviorWindow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorWindow>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InputBehaviorWindow(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
