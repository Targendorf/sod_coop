using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Rewired.UI.ControlMapper;

[System.Serializable]
public class LanguageData : LanguageDataBase
{
	[System.Serializable]
	public class CustomEntry : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0;

		public unsafe string key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static CustomEntry()
		{
			Il2CppClassPointerStore<CustomEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "CustomEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr);
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr, "key");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr, "value");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr, 100676141);
			NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr, 100676142);
			NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr, 100676143);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(121)]
		[CachedScanResults(RefRangeStart = 138970, RefRangeEnd = 139091, XrefRangeStart = 138970, XrefRangeEnd = 139091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomEntry(string key, string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359813, RefRangeEnd = 359814, XrefRangeStart = 359793, XrefRangeEnd = 359813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, string> ToDictionary(Il2CppReferenceArray<CustomEntry> array)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_String_String_Il2CppReferenceArray_1_CustomEntry_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
		}

		public CustomEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ModifierKeys : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_control;

		private static readonly System.IntPtr NativeFieldInfoPtr_alt;

		private static readonly System.IntPtr NativeFieldInfoPtr_shift;

		private static readonly System.IntPtr NativeFieldInfoPtr_command;

		private static readonly System.IntPtr NativeFieldInfoPtr_separator;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string control
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_control);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_control)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string alt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alt);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alt)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string shift
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shift);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shift)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string command
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_command);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_command)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string separator
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_separator);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_separator)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static ModifierKeys()
		{
			Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "ModifierKeys");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr);
			NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr, "control");
			NativeFieldInfoPtr_alt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr, "alt");
			NativeFieldInfoPtr_shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr, "shift");
			NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr, "command");
			NativeFieldInfoPtr_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr, "separator");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr, 100676144);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359814, XrefRangeEnd = 359824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModifierKeys()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierKeys>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ModifierKeys(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__yes;

	private static readonly System.IntPtr NativeFieldInfoPtr__no;

	private static readonly System.IntPtr NativeFieldInfoPtr__add;

	private static readonly System.IntPtr NativeFieldInfoPtr__replace;

	private static readonly System.IntPtr NativeFieldInfoPtr__remove;

	private static readonly System.IntPtr NativeFieldInfoPtr__swap;

	private static readonly System.IntPtr NativeFieldInfoPtr__cancel;

	private static readonly System.IntPtr NativeFieldInfoPtr__none;

	private static readonly System.IntPtr NativeFieldInfoPtr__okay;

	private static readonly System.IntPtr NativeFieldInfoPtr__done;

	private static readonly System.IntPtr NativeFieldInfoPtr__default;

	private static readonly System.IntPtr NativeFieldInfoPtr__assignControllerWindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__assignControllerWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr__elementAssignmentConflictWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__elementAlreadyInUseBlocked;

	private static readonly System.IntPtr NativeFieldInfoPtr__elementAlreadyInUseCanReplace;

	private static readonly System.IntPtr NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateControllerWindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep1WindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep1WindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep2WindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateAxisStep2WindowMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsWindowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr__actionColumnLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboardColumnLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseColumnLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerColumnLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__removeControllerButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateControllerButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__assignControllerButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__doneButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__playersGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerSettingsGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__assignedControllersGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__settingsGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__mapCategoriesGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_invertToggleLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__modifierKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr__customEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr__initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_customDict;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string _yes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__yes);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__yes)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _no
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__no);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__no)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _add
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__add);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__add)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _replace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__replace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__replace)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _remove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__remove);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__remove)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _swap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__swap);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__swap)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _cancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cancel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cancel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _none
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__none);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__none)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _okay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__okay);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__okay)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _done
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__done);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__done)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _default
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__default);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__default)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _assignControllerWindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerWindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerWindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _assignControllerWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _controllerAssignmentConflictWindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _controllerAssignmentConflictWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _elementAssignmentPrePollingWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _joystickElementAssignmentPollingWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _keyboardElementAssignmentPollingWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _mouseElementAssignmentPollingWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _elementAssignmentConflictWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAssignmentConflictWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAssignmentConflictWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _elementAlreadyInUseBlocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAlreadyInUseBlocked);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAlreadyInUseBlocked)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _elementAlreadyInUseCanReplace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAlreadyInUseCanReplace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAlreadyInUseCanReplace)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _elementAlreadyInUseCanReplace_conflictAllowed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _mouseAssignmentConflictWindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _mouseAssignmentConflictWindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateControllerWindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateControllerWindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateControllerWindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateAxisStep1WindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep1WindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep1WindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateAxisStep1WindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep1WindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep1WindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateAxisStep2WindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep2WindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep2WindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateAxisStep2WindowMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep2WindowMessage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateAxisStep2WindowMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _inputBehaviorSettingsWindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _restoreDefaultsWindowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsWindowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsWindowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _restoreDefaultsWindowMessage_onePlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _restoreDefaultsWindowMessage_multiPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _actionColumnLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionColumnLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionColumnLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _keyboardColumnLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardColumnLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardColumnLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _mouseColumnLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseColumnLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseColumnLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _controllerColumnLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerColumnLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerColumnLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _removeControllerButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__removeControllerButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__removeControllerButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateControllerButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateControllerButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateControllerButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _assignControllerButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _inputBehaviorSettingsButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _doneButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__doneButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__doneButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _restoreDefaultsButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _playersGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playersGroupLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playersGroupLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _controllerSettingsGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerSettingsGroupLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerSettingsGroupLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _assignedControllersGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignedControllersGroupLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignedControllersGroupLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _settingsGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsGroupLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsGroupLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _mapCategoriesGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mapCategoriesGroupLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mapCategoriesGroupLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateWindow_deadZoneSliderLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateWindow_zeroSliderLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateWindow_sensitivitySliderLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateWindow_invertToggleLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_invertToggleLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_invertToggleLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _calibrateWindow_calibrateButtonLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ModifierKeys _modifierKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modifierKeys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModifierKeys>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modifierKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modifierKeys));
		}
	}

	public unsafe Il2CppReferenceArray<CustomEntry> _customEntries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customEntries);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomEntry>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customEntries)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool _initialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialized)) = flag;
		}
	}

	public unsafe Dictionary<string, string> customDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDict)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe override string yes
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string no
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string add
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string replace
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 353048, RefRangeEnd = 353057, XrefRangeStart = 353048, XrefRangeEnd = 353057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string remove
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 353057, RefRangeEnd = 353062, XrefRangeStart = 353057, XrefRangeEnd = 353062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string swap
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315010, RefRangeEnd = 315014, XrefRangeStart = 315010, XrefRangeEnd = 315014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string cancel
	{
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 352504, RefRangeEnd = 352568, XrefRangeStart = 352504, XrefRangeEnd = 352568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string none
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353067, RefRangeEnd = 353069, XrefRangeStart = 353067, XrefRangeEnd = 353069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string okay
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string done
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353069, RefRangeEnd = 353070, XrefRangeStart = 353069, XrefRangeEnd = 353070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string default_
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string assignControllerWindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string assignControllerWindowMessage
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 350350, RefRangeEnd = 350378, XrefRangeStart = 350350, XrefRangeEnd = 350378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string controllerAssignmentConflictWindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string elementAssignmentPrePollingWindowMessage
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 353185, RefRangeEnd = 353191, XrefRangeStart = 353185, XrefRangeEnd = 353191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string elementAssignmentConflictWindowMessage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string mouseAssignmentConflictWindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateControllerWindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateAxisStep1WindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateAxisStep2WindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string inputBehaviorSettingsWindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string restoreDefaultsWindowTitle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string actionColumnLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string keyboardColumnLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string mouseColumnLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string controllerColumnLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string removeControllerButtonLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateControllerButtonLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string assignControllerButtonLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string inputBehaviorSettingsButtonLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string doneButtonLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string restoreDefaultsButtonLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string controllerSettingsGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string playersGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string assignedControllersGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string settingsGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string mapCategoriesGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string restoreDefaultsWindowMessage
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359831, XrefRangeEnd = 359836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateWindow_deadZoneSliderLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateWindow_zeroSliderLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateWindow_sensitivitySliderLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateWindow_invertToggleLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string calibrateWindow_calibrateButtonLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static LanguageData()
	{
		Il2CppClassPointerStore<LanguageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "LanguageData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageData>.NativeClassPtr);
		NativeFieldInfoPtr__yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_yes");
		NativeFieldInfoPtr__no = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_no");
		NativeFieldInfoPtr__add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_add");
		NativeFieldInfoPtr__replace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_replace");
		NativeFieldInfoPtr__remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_remove");
		NativeFieldInfoPtr__swap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_swap");
		NativeFieldInfoPtr__cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_cancel");
		NativeFieldInfoPtr__none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_none");
		NativeFieldInfoPtr__okay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_okay");
		NativeFieldInfoPtr__done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_done");
		NativeFieldInfoPtr__default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_default");
		NativeFieldInfoPtr__assignControllerWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignControllerWindowTitle");
		NativeFieldInfoPtr__assignControllerWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignControllerWindowMessage");
		NativeFieldInfoPtr__controllerAssignmentConflictWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerAssignmentConflictWindowTitle");
		NativeFieldInfoPtr__controllerAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerAssignmentConflictWindowMessage");
		NativeFieldInfoPtr__elementAssignmentPrePollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAssignmentPrePollingWindowMessage");
		NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_joystickElementAssignmentPollingWindowMessage");
		NativeFieldInfoPtr__joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_joystickElementAssignmentPollingWindowMessage_fullAxisFieldOnly");
		NativeFieldInfoPtr__keyboardElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_keyboardElementAssignmentPollingWindowMessage");
		NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseElementAssignmentPollingWindowMessage");
		NativeFieldInfoPtr__mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseElementAssignmentPollingWindowMessage_fullAxisFieldOnly");
		NativeFieldInfoPtr__elementAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAssignmentConflictWindowMessage");
		NativeFieldInfoPtr__elementAlreadyInUseBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAlreadyInUseBlocked");
		NativeFieldInfoPtr__elementAlreadyInUseCanReplace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAlreadyInUseCanReplace");
		NativeFieldInfoPtr__elementAlreadyInUseCanReplace_conflictAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_elementAlreadyInUseCanReplace_conflictAllowed");
		NativeFieldInfoPtr__mouseAssignmentConflictWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseAssignmentConflictWindowTitle");
		NativeFieldInfoPtr__mouseAssignmentConflictWindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseAssignmentConflictWindowMessage");
		NativeFieldInfoPtr__calibrateControllerWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateControllerWindowTitle");
		NativeFieldInfoPtr__calibrateAxisStep1WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep1WindowTitle");
		NativeFieldInfoPtr__calibrateAxisStep1WindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep1WindowMessage");
		NativeFieldInfoPtr__calibrateAxisStep2WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep2WindowTitle");
		NativeFieldInfoPtr__calibrateAxisStep2WindowMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateAxisStep2WindowMessage");
		NativeFieldInfoPtr__inputBehaviorSettingsWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_inputBehaviorSettingsWindowTitle");
		NativeFieldInfoPtr__restoreDefaultsWindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsWindowTitle");
		NativeFieldInfoPtr__restoreDefaultsWindowMessage_onePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsWindowMessage_onePlayer");
		NativeFieldInfoPtr__restoreDefaultsWindowMessage_multiPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsWindowMessage_multiPlayer");
		NativeFieldInfoPtr__actionColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_actionColumnLabel");
		NativeFieldInfoPtr__keyboardColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_keyboardColumnLabel");
		NativeFieldInfoPtr__mouseColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mouseColumnLabel");
		NativeFieldInfoPtr__controllerColumnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerColumnLabel");
		NativeFieldInfoPtr__removeControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_removeControllerButtonLabel");
		NativeFieldInfoPtr__calibrateControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateControllerButtonLabel");
		NativeFieldInfoPtr__assignControllerButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignControllerButtonLabel");
		NativeFieldInfoPtr__inputBehaviorSettingsButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_inputBehaviorSettingsButtonLabel");
		NativeFieldInfoPtr__doneButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_doneButtonLabel");
		NativeFieldInfoPtr__restoreDefaultsButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_restoreDefaultsButtonLabel");
		NativeFieldInfoPtr__playersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_playersGroupLabel");
		NativeFieldInfoPtr__controllerSettingsGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_controllerSettingsGroupLabel");
		NativeFieldInfoPtr__assignedControllersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_assignedControllersGroupLabel");
		NativeFieldInfoPtr__settingsGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_settingsGroupLabel");
		NativeFieldInfoPtr__mapCategoriesGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_mapCategoriesGroupLabel");
		NativeFieldInfoPtr__calibrateWindow_deadZoneSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_deadZoneSliderLabel");
		NativeFieldInfoPtr__calibrateWindow_zeroSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_zeroSliderLabel");
		NativeFieldInfoPtr__calibrateWindow_sensitivitySliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_sensitivitySliderLabel");
		NativeFieldInfoPtr__calibrateWindow_invertToggleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_invertToggleLabel");
		NativeFieldInfoPtr__calibrateWindow_calibrateButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_calibrateWindow_calibrateButtonLabel");
		NativeFieldInfoPtr__modifierKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_modifierKeys");
		NativeFieldInfoPtr__customEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_customEntries");
		NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "_initialized");
		NativeFieldInfoPtr_customDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, "customDict");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676072);
		NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676073);
		NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676074);
		NativeMethodInfoPtr_get_yes_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676075);
		NativeMethodInfoPtr_get_no_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676076);
		NativeMethodInfoPtr_get_add_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676077);
		NativeMethodInfoPtr_get_replace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676078);
		NativeMethodInfoPtr_get_remove_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676079);
		NativeMethodInfoPtr_get_swap_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676080);
		NativeMethodInfoPtr_get_cancel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676081);
		NativeMethodInfoPtr_get_none_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676082);
		NativeMethodInfoPtr_get_okay_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676083);
		NativeMethodInfoPtr_get_done_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676084);
		NativeMethodInfoPtr_get_default__Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676085);
		NativeMethodInfoPtr_get_assignControllerWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676086);
		NativeMethodInfoPtr_get_assignControllerWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676087);
		NativeMethodInfoPtr_get_controllerAssignmentConflictWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676088);
		NativeMethodInfoPtr_get_elementAssignmentPrePollingWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676089);
		NativeMethodInfoPtr_get_elementAssignmentConflictWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676090);
		NativeMethodInfoPtr_get_mouseAssignmentConflictWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676091);
		NativeMethodInfoPtr_get_calibrateControllerWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676092);
		NativeMethodInfoPtr_get_calibrateAxisStep1WindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676093);
		NativeMethodInfoPtr_get_calibrateAxisStep2WindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676094);
		NativeMethodInfoPtr_get_inputBehaviorSettingsWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676095);
		NativeMethodInfoPtr_get_restoreDefaultsWindowTitle_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676096);
		NativeMethodInfoPtr_get_actionColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676097);
		NativeMethodInfoPtr_get_keyboardColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676098);
		NativeMethodInfoPtr_get_mouseColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676099);
		NativeMethodInfoPtr_get_controllerColumnLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676100);
		NativeMethodInfoPtr_get_removeControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676101);
		NativeMethodInfoPtr_get_calibrateControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676102);
		NativeMethodInfoPtr_get_assignControllerButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676103);
		NativeMethodInfoPtr_get_inputBehaviorSettingsButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676104);
		NativeMethodInfoPtr_get_doneButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676105);
		NativeMethodInfoPtr_get_restoreDefaultsButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676106);
		NativeMethodInfoPtr_get_controllerSettingsGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676107);
		NativeMethodInfoPtr_get_playersGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676108);
		NativeMethodInfoPtr_get_assignedControllersGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676109);
		NativeMethodInfoPtr_get_settingsGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676110);
		NativeMethodInfoPtr_get_mapCategoriesGroupLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676111);
		NativeMethodInfoPtr_get_restoreDefaultsWindowMessage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676112);
		NativeMethodInfoPtr_get_calibrateWindow_deadZoneSliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676113);
		NativeMethodInfoPtr_get_calibrateWindow_zeroSliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676114);
		NativeMethodInfoPtr_get_calibrateWindow_sensitivitySliderLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676115);
		NativeMethodInfoPtr_get_calibrateWindow_invertToggleLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676116);
		NativeMethodInfoPtr_get_calibrateWindow_calibrateButtonLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676117);
		NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676118);
		NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676119);
		NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676120);
		NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676121);
		NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676122);
		NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676123);
		NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676124);
		NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676125);
		NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676126);
		NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676127);
		NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676128);
		NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676129);
		NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676130);
		NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676131);
		NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676132);
		NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676133);
		NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676134);
		NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676135);
		NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676136);
		NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676137);
		NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676138);
		NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676139);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageData>.NativeClassPtr, 100676140);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359824, XrefRangeEnd = 359825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359825, XrefRangeEnd = 359829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetCustomEntry(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCustomEntry_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359829, XrefRangeEnd = 359831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ContainsCustomEntryKey(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ContainsCustomEntryKey_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359836, XrefRangeEnd = 359838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(joystickName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(currentPlayerName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetControllerAssignmentConflictWindowMessage_Public_Virtual_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359838, XrefRangeEnd = 359840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetJoystickElementAssignmentPollingWindowMessage(string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359840, XrefRangeEnd = 359842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359842, XrefRangeEnd = 359844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetKeyboardElementAssignmentPollingWindowMessage(string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetKeyboardElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359844, XrefRangeEnd = 359846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetMouseElementAssignmentPollingWindowMessage(string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359846, XrefRangeEnd = 359848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359848, XrefRangeEnd = 359850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetElementAlreadyInUseBlocked(string elementName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetElementAlreadyInUseBlocked_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359850, XrefRangeEnd = 359853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowConflicts;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetElementAlreadyInUseCanReplace_Public_Virtual_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359853, XrefRangeEnd = 359855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(otherPlayerName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(thisPlayerName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMouseAssignmentConflictWindowMessage_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359855, XrefRangeEnd = 359857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetCalibrateAxisStep1WindowMessage(string axisName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCalibrateAxisStep1WindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359857, XrefRangeEnd = 359859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetCalibrateAxisStep2WindowMessage(string axisName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCalibrateAxisStep2WindowMessage_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359859, XrefRangeEnd = 359875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetPlayerName(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPlayerName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359875, XrefRangeEnd = 359883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetControllerName(Controller controller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetControllerName_Public_Virtual_String_Controller_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359883, XrefRangeEnd = 359885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetElementIdentifierName(ActionElementMap actionElementMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionElementMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359885, XrefRangeEnd = 359888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &elementIdentifierId;
		*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_Controller_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359888, XrefRangeEnd = 359894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&keyCode);
		*(ModifierKeyFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &modifierKeyFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetElementIdentifierName_Public_Virtual_String_KeyCode_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359894, XrefRangeEnd = 359899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetActionName(int actionId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&actionId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359899, XrefRangeEnd = 359914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetActionName(int actionId, AxisRange axisRange)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&actionId);
		*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActionName_Public_Virtual_String_Int32_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359914, XrefRangeEnd = 359919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetMapCategoryName(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMapCategoryName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359919, XrefRangeEnd = 359924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetActionCategoryName(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActionCategoryName_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359924, XrefRangeEnd = 359929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetLayoutName(ControllerType controllerType, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controllerType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLayoutName_Public_Virtual_String_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359929, XrefRangeEnd = 359938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ModifierKeyFlagsToString(ModifierKeyFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ModifierKeyFlagsToString_Public_Virtual_String_ModifierKeyFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359938, XrefRangeEnd = 360047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LanguageData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LanguageData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
