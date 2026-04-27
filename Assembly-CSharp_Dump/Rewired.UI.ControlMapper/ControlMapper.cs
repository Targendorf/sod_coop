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
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

public class ControlMapper : MonoBehaviour
{
	public class GUIElement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_gameObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		private static readonly System.IntPtr NativeFieldInfoPtr_selectable;

		private static readonly System.IntPtr NativeFieldInfoPtr_uiElementInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_permanentStateSet;

		private static readonly System.IntPtr NativeFieldInfoPtr_children;

		private static readonly System.IntPtr NativeFieldInfoPtr__rectTransform_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_rectTransform_Private_set_Void_RectTransform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Selectable_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractible_Public_Virtual_New_Void_Boolean_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractible_Public_Virtual_New_Void_Boolean_Boolean_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetTextWidth_Public_Virtual_New_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFirstChildObjectWidth_Public_Virtual_New_Void_LayoutElementSizeType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetLabel_Public_Virtual_New_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLabel_Public_Virtual_New_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Virtual_New_Void_GUIElement_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetElementInfoData_Public_Void_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Virtual_New_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_New_Boolean_0;

		public unsafe GameObject gameObject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObject);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe TMP_Text text
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_Text));
			}
		}

		public unsafe Selectable selectable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectable));
			}
		}

		public unsafe UIElementInfo uiElementInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiElementInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIElementInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiElementInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIElementInfo));
			}
		}

		public unsafe bool permanentStateSet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_permanentStateSet);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_permanentStateSet)) = flag;
			}
		}

		public unsafe List<GUIElement> children
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_children);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GUIElement>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_children)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe RectTransform _rectTransform_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rectTransform_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rectTransform_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
			}
		}

		public unsafe RectTransform rectTransform
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 315010, RefRangeEnd = 315014, XrefRangeStart = 315010, XrefRangeEnd = 315014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 352130, RefRangeEnd = 352165, XrefRangeStart = 352130, XrefRangeEnd = 352130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rectTransform_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static GUIElement()
		{
			Il2CppClassPointerStore<GUIElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "GUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIElement>.NativeClassPtr);
			NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, "gameObject");
			NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, "text");
			NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, "selectable");
			NativeFieldInfoPtr_uiElementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, "uiElementInfo");
			NativeFieldInfoPtr_permanentStateSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, "permanentStateSet");
			NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, "children");
			NativeFieldInfoPtr__rectTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, "<rectTransform>k__BackingField");
			NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675570);
			NativeMethodInfoPtr_set_rectTransform_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675571);
			NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675572);
			NativeMethodInfoPtr__ctor_Public_Void_Selectable_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675573);
			NativeMethodInfoPtr_SetInteractible_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675574);
			NativeMethodInfoPtr_SetInteractible_Public_Virtual_New_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675575);
			NativeMethodInfoPtr_SetTextWidth_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675576);
			NativeMethodInfoPtr_SetFirstChildObjectWidth_Public_Virtual_New_Void_LayoutElementSizeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675577);
			NativeMethodInfoPtr_SetLabel_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675578);
			NativeMethodInfoPtr_GetLabel_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675579);
			NativeMethodInfoPtr_AddChild_Public_Virtual_New_Void_GUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675580);
			NativeMethodInfoPtr_SetElementInfoData_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675581);
			NativeMethodInfoPtr_SetActive_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675582);
			NativeMethodInfoPtr_Init_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIElement>.NativeClassPtr, 100675583);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 352211, RefRangeEnd = 352222, XrefRangeStart = 352165, XrefRangeEnd = 352211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIElement(GameObject gameObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIElement>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 352249, RefRangeEnd = 352252, XrefRangeStart = 352222, XrefRangeEnd = 352249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIElement(Selectable selectable, TMP_Text label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIElement>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectable);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Selectable_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual void SetInteractible(bool state, bool playTransition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&state);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playTransition;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInteractible_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352269, RefRangeEnd = 352270, XrefRangeStart = 352252, XrefRangeEnd = 352269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInteractible(bool state, bool playTransition, bool permanent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&state);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playTransition;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &permanent;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInteractible_Public_Virtual_New_Void_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352270, XrefRangeEnd = 352299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTextWidth(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetTextWidth_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352299, XrefRangeEnd = 352322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFirstChildObjectWidth(LayoutElementSizeType type, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&type);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetFirstChildObjectWidth_Public_Virtual_New_Void_LayoutElementSizeType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352322, XrefRangeEnd = 352333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLabel(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLabel_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352333, XrefRangeEnd = 352346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLabel_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352346, XrefRangeEnd = 352350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddChild(GUIElement child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddChild_Public_Virtual_New_Void_GUIElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 352361, RefRangeEnd = 352370, XrefRangeStart = 352350, XrefRangeEnd = 352361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementInfoData(string identifier, int intData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &intData;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetElementInfoData_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352370, XrefRangeEnd = 352383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetActive(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetActive_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352383, XrefRangeEnd = 352434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public GUIElement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class GUIButton : GUIElement
	{
		[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+GUIButton+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__SetOnClickCallback_b__0_Internal_Void_0;

			public unsafe Il2CppSystem.Action<ButtonInfo> callback
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ButtonInfo>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe GUIButton __4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIButton>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIButton));
				}
			}

			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUIButton>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr);
				NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "callback");
				NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100675590);
				NativeMethodInfoPtr__SetOnClickCallback_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100675591);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352434, XrefRangeEnd = 352436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetOnClickCallback_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetOnClickCallback_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public __c__DisplayClass7_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_get_button_Protected_get_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_buttonInfo_Public_get_ButtonInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Button_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetButtonInfoData_Public_Void_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetOnClickCallback_Public_Void_Action_1_ButtonInfo_0;

		public unsafe Button button
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352438, RefRangeEnd = 352440, XrefRangeStart = 352436, XrefRangeEnd = 352438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_button_Protected_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
		}

		public unsafe ButtonInfo buttonInfo
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 352442, RefRangeEnd = 352448, XrefRangeStart = 352440, XrefRangeEnd = 352442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_buttonInfo_Public_get_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonInfo>(intPtr) : null;
			}
		}

		static GUIButton()
		{
			Il2CppClassPointerStore<GUIButton>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "GUIButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIButton>.NativeClassPtr);
			NativeMethodInfoPtr_get_button_Protected_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIButton>.NativeClassPtr, 100675584);
			NativeMethodInfoPtr_get_buttonInfo_Public_get_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIButton>.NativeClassPtr, 100675585);
			NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIButton>.NativeClassPtr, 100675586);
			NativeMethodInfoPtr__ctor_Public_Void_Button_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIButton>.NativeClassPtr, 100675587);
			NativeMethodInfoPtr_SetButtonInfoData_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIButton>.NativeClassPtr, 100675588);
			NativeMethodInfoPtr_SetOnClickCallback_Public_Void_Action_1_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIButton>.NativeClassPtr, 100675589);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352448, XrefRangeEnd = 352449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIButton(GameObject gameObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIButton>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352449, XrefRangeEnd = 352450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIButton(Button button, TMP_Text label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIButton>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Button_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352450, XrefRangeEnd = 352451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonInfoData(string identifier, int intData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &intData;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetButtonInfoData_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 352474, RefRangeEnd = 352478, XrefRangeStart = 352451, XrefRangeEnd = 352474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOnClickCallback(Il2CppSystem.Action<ButtonInfo> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOnClickCallback_Public_Void_Action_1_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GUIButton(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class GUIInputField : GUIElement
	{
		[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+GUIInputField+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__SetOnClickCallback_b__0_Internal_Void_0;

			public unsafe Il2CppSystem.Action<InputFieldInfo> callback
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputFieldInfo>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe GUIInputField __4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIInputField>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIInputField));
				}
			}

			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr);
				NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "callback");
				NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, 100675607);
				NativeMethodInfoPtr__SetOnClickCallback_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr, 100675608);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass19_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352478, XrefRangeEnd = 352480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetOnClickCallback_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetOnClickCallback_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public __c__DisplayClass19_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__toggle_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_button_Protected_get_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fieldInfo_Public_get_InputFieldInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasToggle_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_toggle_Public_get_GUIToggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_toggle_Private_set_Void_GUIToggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Button_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFieldInfoData_Public_Void_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetOnClickCallback_Public_Void_Action_1_InputFieldInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractable_Public_Virtual_New_Void_Boolean_Boolean_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddToggle_Public_Void_GUIToggle_0;

		public unsafe GUIToggle _toggle_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__toggle_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIToggle>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__toggle_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIToggle));
			}
		}

		public unsafe Button button
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352482, RefRangeEnd = 352484, XrefRangeStart = 352480, XrefRangeEnd = 352482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_button_Protected_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
		}

		public unsafe InputFieldInfo fieldInfo
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 352486, RefRangeEnd = 352504, XrefRangeStart = 352484, XrefRangeEnd = 352486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fieldInfo_Public_get_InputFieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputFieldInfo>(intPtr) : null;
			}
		}

		public unsafe bool hasToggle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasToggle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe GUIToggle toggle
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 352504, RefRangeEnd = 352568, XrefRangeStart = 352504, XrefRangeEnd = 352504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_toggle_Public_get_GUIToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIToggle>(intPtr) : null;
			}
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 352568, RefRangeEnd = 352598, XrefRangeStart = 352568, XrefRangeEnd = 352568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_toggle_Private_set_Void_GUIToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe int actionElementMapId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352598, XrefRangeEnd = 352611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352624, RefRangeEnd = 352626, XrefRangeStart = 352611, XrefRangeEnd = 352624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe int controllerId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352626, XrefRangeEnd = 352639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 352652, RefRangeEnd = 352655, XrefRangeStart = 352639, XrefRangeEnd = 352652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static GUIInputField()
		{
			Il2CppClassPointerStore<GUIInputField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "GUIInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr);
			NativeFieldInfoPtr__toggle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, "<toggle>k__BackingField");
			NativeMethodInfoPtr_get_button_Protected_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675592);
			NativeMethodInfoPtr_get_fieldInfo_Public_get_InputFieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675593);
			NativeMethodInfoPtr_get_hasToggle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675594);
			NativeMethodInfoPtr_get_toggle_Public_get_GUIToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675595);
			NativeMethodInfoPtr_set_toggle_Private_set_Void_GUIToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675596);
			NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675597);
			NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675598);
			NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675599);
			NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675600);
			NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675601);
			NativeMethodInfoPtr__ctor_Public_Void_Button_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675602);
			NativeMethodInfoPtr_SetFieldInfoData_Public_Void_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675603);
			NativeMethodInfoPtr_SetOnClickCallback_Public_Void_Action_1_InputFieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675604);
			NativeMethodInfoPtr_SetInteractable_Public_Virtual_New_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675605);
			NativeMethodInfoPtr_AddToggle_Public_Void_GUIToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr, 100675606);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIInputField(GameObject gameObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIInputField(Button button, TMP_Text label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIInputField>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Button_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352655, XrefRangeEnd = 352673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&actionId);
			*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &intData;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFieldInfoData_Public_Void_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352696, RefRangeEnd = 352697, XrefRangeStart = 352673, XrefRangeEnd = 352696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOnClickCallback(Il2CppSystem.Action<InputFieldInfo> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOnClickCallback_Public_Void_Action_1_InputFieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352697, XrefRangeEnd = 352698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInteractable(bool state, bool playTransition, bool permanent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&state);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playTransition;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &permanent;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInteractable_Public_Virtual_New_Void_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void AddToggle(GUIToggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toggle);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToggle_Public_Void_GUIToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GUIInputField(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class GUIToggle : GUIElement
	{
		[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+GUIToggle+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__SetOnSubmitCallback_b__0_Internal_Void_BaseEventData_0;

			public unsafe Il2CppSystem.Action<ToggleInfo, bool> callback
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ToggleInfo, bool>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
				}
			}

			public unsafe GUIToggle __4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIToggle>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIToggle));
				}
			}

			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr);
				NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "callback");
				NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100675618);
				NativeMethodInfoPtr__SetOnSubmitCallback_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100675619);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352698, XrefRangeEnd = 352702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetOnSubmitCallback_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetOnSubmitCallback_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public __c__DisplayClass10_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_get_toggle_Protected_get_Toggle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_toggleInfo_Public_get_ToggleInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Toggle_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetToggleInfoData_Public_Void_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetOnSubmitCallback_Public_Void_Action_2_ToggleInfo_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetToggleState_Public_Void_Boolean_0;

		public unsafe Toggle toggle
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 352704, RefRangeEnd = 352710, XrefRangeStart = 352702, XrefRangeEnd = 352704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_toggle_Protected_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toggle>(intPtr) : null;
			}
		}

		public unsafe ToggleInfo toggleInfo
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 352712, RefRangeEnd = 352726, XrefRangeStart = 352710, XrefRangeEnd = 352712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_toggleInfo_Public_get_ToggleInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ToggleInfo>(intPtr) : null;
			}
		}

		public unsafe int actionElementMapId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 352739, RefRangeEnd = 352740, XrefRangeStart = 352726, XrefRangeEnd = 352739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 352753, RefRangeEnd = 352755, XrefRangeStart = 352740, XrefRangeEnd = 352753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static GUIToggle()
		{
			Il2CppClassPointerStore<GUIToggle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "GUIToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr);
			NativeMethodInfoPtr_get_toggle_Protected_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675609);
			NativeMethodInfoPtr_get_toggleInfo_Public_get_ToggleInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675610);
			NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675611);
			NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675612);
			NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675613);
			NativeMethodInfoPtr__ctor_Public_Void_Toggle_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675614);
			NativeMethodInfoPtr_SetToggleInfoData_Public_Void_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675615);
			NativeMethodInfoPtr_SetOnSubmitCallback_Public_Void_Action_2_ToggleInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675616);
			NativeMethodInfoPtr_SetToggleState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr, 100675617);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIToggle(GameObject gameObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIToggle(Toggle toggle, TMP_Text label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIToggle>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toggle);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Toggle_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352755, XrefRangeEnd = 352773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&actionId);
			*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &intData;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetToggleInfoData_Public_Void_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352846, RefRangeEnd = 352847, XrefRangeStart = 352773, XrefRangeEnd = 352846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOnSubmitCallback(Il2CppSystem.Action<ToggleInfo, bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOnSubmitCallback_Public_Void_Action_2_ToggleInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352861, RefRangeEnd = 352863, XrefRangeStart = 352847, XrefRangeEnd = 352861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleState(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetToggleState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GUIToggle(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class GUILabel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__gameObject_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__text_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__rectTransform_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_gameObject_Private_set_Void_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Private_get_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_text_Private_set_Void_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_rectTransform_Private_set_Void_RectTransform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetWidth_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetHeight_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFontStyle_Public_Void_FontStyles_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetTextAlignment_Public_Void_TextAlignmentOptions_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Check_Private_Boolean_0;

		public unsafe GameObject _gameObject_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameObject_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameObject_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe TMP_Text _text_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__text_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__text_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_Text));
			}
		}

		public unsafe RectTransform _rectTransform_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rectTransform_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rectTransform_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
			}
		}

		public unsafe GameObject gameObject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 191619, RefRangeEnd = 191718, XrefRangeStart = 191619, XrefRangeEnd = 191718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gameObject_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe TMP_Text text
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_text_Private_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
			}
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_text_Private_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe RectTransform rectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59183, XrefRangeStart = 59139, XrefRangeEnd = 59183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rectTransform_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static GUILabel()
		{
			Il2CppClassPointerStore<GUILabel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "GUILabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILabel>.NativeClassPtr);
			NativeFieldInfoPtr__gameObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, "<gameObject>k__BackingField");
			NativeFieldInfoPtr__text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, "<text>k__BackingField");
			NativeFieldInfoPtr__rectTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, "<rectTransform>k__BackingField");
			NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675620);
			NativeMethodInfoPtr_set_gameObject_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675621);
			NativeMethodInfoPtr_get_text_Private_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675622);
			NativeMethodInfoPtr_set_text_Private_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675623);
			NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675624);
			NativeMethodInfoPtr_set_rectTransform_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675625);
			NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675626);
			NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675627);
			NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675628);
			NativeMethodInfoPtr_SetWidth_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675629);
			NativeMethodInfoPtr_SetHeight_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675630);
			NativeMethodInfoPtr_SetLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675631);
			NativeMethodInfoPtr_SetFontStyle_Public_Void_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675632);
			NativeMethodInfoPtr_SetTextAlignment_Public_Void_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675633);
			NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675634);
			NativeMethodInfoPtr_Check_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILabel>.NativeClassPtr, 100675635);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352887, RefRangeEnd = 352888, XrefRangeStart = 352863, XrefRangeEnd = 352887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILabel(GameObject gameObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILabel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352888, XrefRangeEnd = 352889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILabel(TMP_Text label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILabel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352889, XrefRangeEnd = 352902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&width);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352902, XrefRangeEnd = 352914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWidth(int width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&width);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWidth_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352914, XrefRangeEnd = 352926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeight(int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&height);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeight_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352926, XrefRangeEnd = 352937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352948, RefRangeEnd = 352949, XrefRangeStart = 352937, XrefRangeEnd = 352948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFontStyle(FontStyles style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&style);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFontStyle_Public_Void_FontStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 352960, RefRangeEnd = 352963, XrefRangeStart = 352949, XrefRangeEnd = 352960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextAlignment(TextAlignmentOptions alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&alignment);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextAlignment_Public_Void_TextAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 352976, RefRangeEnd = 352980, XrefRangeStart = 352963, XrefRangeEnd = 352976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353002, RefRangeEnd = 353004, XrefRangeStart = 352980, XrefRangeEnd = 353002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public GUILabel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class MappingSet : Il2CppSystem.Object
	{
		public enum ActionListMode
		{
			ActionCategory,
			Action
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__mapCategoryId;

		private static readonly System.IntPtr NativeFieldInfoPtr__actionListMode;

		private static readonly System.IntPtr NativeFieldInfoPtr__actionCategoryIds;

		private static readonly System.IntPtr NativeFieldInfoPtr__actionIds;

		private static readonly System.IntPtr NativeFieldInfoPtr__actionCategoryIdsReadOnly;

		private static readonly System.IntPtr NativeFieldInfoPtr__actionIdsReadOnly;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mapCategoryId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionListMode_Public_get_ActionListMode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionCategoryIds_Public_get_IList_1_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionIds_Public_get_IList_1_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_ActionListMode_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_MappingSet_0;

		public unsafe int _mapCategoryId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mapCategoryId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mapCategoryId)) = num;
			}
		}

		public unsafe ActionListMode _actionListMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionListMode);
				return *(ActionListMode*)num;
			}
			set
			{
				*(ActionListMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionListMode)) = actionListMode;
			}
		}

		public unsafe Il2CppStructArray<int> _actionCategoryIds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionCategoryIds);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionCategoryIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<int> _actionIds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionIds);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe IList<int> _actionCategoryIdsReadOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionCategoryIdsReadOnly);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionCategoryIdsReadOnly)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe IList<int> _actionIdsReadOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionIdsReadOnly);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionIdsReadOnly)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int mapCategoryId
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 349722, RefRangeEnd = 349786, XrefRangeStart = 349722, XrefRangeEnd = 349786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mapCategoryId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe ActionListMode actionListMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionListMode_Public_get_ActionListMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ActionListMode*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe IList<int> actionCategoryIds
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353008, RefRangeEnd = 353011, XrefRangeStart = 353004, XrefRangeEnd = 353008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionCategoryIds_Public_get_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<int>>(intPtr) : null;
			}
		}

		public unsafe IList<int> actionIds
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353015, RefRangeEnd = 353018, XrefRangeStart = 353011, XrefRangeEnd = 353015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionIds_Public_get_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<int>>(intPtr) : null;
			}
		}

		public unsafe bool isValid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353023, RefRangeEnd = 353026, XrefRangeStart = 353018, XrefRangeEnd = 353023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe static MappingSet Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353032, XrefRangeEnd = 353040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_MappingSet_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MappingSet>(intPtr) : null;
			}
		}

		static MappingSet()
		{
			Il2CppClassPointerStore<MappingSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "MappingSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MappingSet>.NativeClassPtr);
			NativeFieldInfoPtr__mapCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, "_mapCategoryId");
			NativeFieldInfoPtr__actionListMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, "_actionListMode");
			NativeFieldInfoPtr__actionCategoryIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, "_actionCategoryIds");
			NativeFieldInfoPtr__actionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, "_actionIds");
			NativeFieldInfoPtr__actionCategoryIdsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, "_actionCategoryIdsReadOnly");
			NativeFieldInfoPtr__actionIdsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, "_actionIdsReadOnly");
			NativeMethodInfoPtr_get_mapCategoryId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675636);
			NativeMethodInfoPtr_get_actionListMode_Public_get_ActionListMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675637);
			NativeMethodInfoPtr_get_actionCategoryIds_Public_get_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675638);
			NativeMethodInfoPtr_get_actionIds_Public_get_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675639);
			NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675640);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675641);
			NativeMethodInfoPtr__ctor_Private_Void_Int32_ActionListMode_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675642);
			NativeMethodInfoPtr_get_Default_Public_Static_get_MappingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MappingSet>.NativeClassPtr, 100675643);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353026, XrefRangeEnd = 353031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MappingSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MappingSet>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353031, RefRangeEnd = 353032, XrefRangeStart = 353031, XrefRangeEnd = 353031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MappingSet(int mapCategoryId, ActionListMode actionListMode, Il2CppStructArray<int> actionCategoryIds, Il2CppStructArray<int> actionIds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MappingSet>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&mapCategoryId);
			*(ActionListMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionListMode;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionCategoryIds);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionIds);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_ActionListMode_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MappingSet(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class InputBehaviorSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__inputBehaviorId;

		private static readonly System.IntPtr NativeFieldInfoPtr__showJoystickAxisSensitivity;

		private static readonly System.IntPtr NativeFieldInfoPtr__showMouseXYAxisSensitivity;

		private static readonly System.IntPtr NativeFieldInfoPtr__labelLanguageKey;

		private static readonly System.IntPtr NativeFieldInfoPtr__joystickAxisSensitivityLabelLanguageKey;

		private static readonly System.IntPtr NativeFieldInfoPtr__mouseXYAxisSensitivityLabelLanguageKey;

		private static readonly System.IntPtr NativeFieldInfoPtr__joystickAxisSensitivityIcon;

		private static readonly System.IntPtr NativeFieldInfoPtr__mouseXYAxisSensitivityIcon;

		private static readonly System.IntPtr NativeFieldInfoPtr__joystickAxisSensitivityMin;

		private static readonly System.IntPtr NativeFieldInfoPtr__joystickAxisSensitivityMax;

		private static readonly System.IntPtr NativeFieldInfoPtr__mouseXYAxisSensitivityMin;

		private static readonly System.IntPtr NativeFieldInfoPtr__mouseXYAxisSensitivityMax;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehaviorId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_showJoystickAxisSensitivity_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_showMouseXYAxisSensitivity_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_labelLanguageKey_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickAxisSensitivityLabelLanguageKey_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseXYAxisSensitivityLabelLanguageKey_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickAxisSensitivityIcon_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseXYAxisSensitivityIcon_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickAxisSensitivityMin_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickAxisSensitivityMax_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseXYAxisSensitivityMin_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseXYAxisSensitivityMax_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int _inputBehaviorId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorId)) = num;
			}
		}

		public unsafe bool _showJoystickAxisSensitivity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showJoystickAxisSensitivity);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showJoystickAxisSensitivity)) = flag;
			}
		}

		public unsafe bool _showMouseXYAxisSensitivity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMouseXYAxisSensitivity);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMouseXYAxisSensitivity)) = flag;
			}
		}

		public unsafe string _labelLanguageKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__labelLanguageKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__labelLanguageKey)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string _joystickAxisSensitivityLabelLanguageKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityLabelLanguageKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityLabelLanguageKey)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string _mouseXYAxisSensitivityLabelLanguageKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityLabelLanguageKey);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityLabelLanguageKey)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Sprite _joystickAxisSensitivityIcon
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityIcon);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Sprite _mouseXYAxisSensitivityIcon
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityIcon);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe float _joystickAxisSensitivityMin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityMin);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityMin)) = num;
			}
		}

		public unsafe float _joystickAxisSensitivityMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityMax);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickAxisSensitivityMax)) = num;
			}
		}

		public unsafe float _mouseXYAxisSensitivityMin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityMin);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityMin)) = num;
			}
		}

		public unsafe float _mouseXYAxisSensitivityMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityMax);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseXYAxisSensitivityMax)) = num;
			}
		}

		public unsafe int inputBehaviorId
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 349722, RefRangeEnd = 349786, XrefRangeStart = 349722, XrefRangeEnd = 349786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputBehaviorId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool showJoystickAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showJoystickAxisSensitivity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool showMouseXYAxisSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showMouseXYAxisSensitivity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe string labelLanguageKey
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_labelLanguageKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		public unsafe string joystickAxisSensitivityLabelLanguageKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickAxisSensitivityLabelLanguageKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		public unsafe string mouseXYAxisSensitivityLabelLanguageKey
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseXYAxisSensitivityLabelLanguageKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		public unsafe Sprite joystickAxisSensitivityIcon
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 353048, RefRangeEnd = 353057, XrefRangeStart = 353048, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickAxisSensitivityIcon_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
		}

		public unsafe Sprite mouseXYAxisSensitivityIcon
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 353057, RefRangeEnd = 353062, XrefRangeStart = 353057, XrefRangeEnd = 353057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseXYAxisSensitivityIcon_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
		}

		public unsafe float joystickAxisSensitivityMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickAxisSensitivityMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float joystickAxisSensitivityMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickAxisSensitivityMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float mouseXYAxisSensitivityMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseXYAxisSensitivityMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float mouseXYAxisSensitivityMax
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 353062, RefRangeEnd = 353063, XrefRangeStart = 353062, XrefRangeEnd = 353062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseXYAxisSensitivityMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool isValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static InputBehaviorSettings()
		{
			Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "InputBehaviorSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr);
			NativeFieldInfoPtr__inputBehaviorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_inputBehaviorId");
			NativeFieldInfoPtr__showJoystickAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_showJoystickAxisSensitivity");
			NativeFieldInfoPtr__showMouseXYAxisSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_showMouseXYAxisSensitivity");
			NativeFieldInfoPtr__labelLanguageKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_labelLanguageKey");
			NativeFieldInfoPtr__joystickAxisSensitivityLabelLanguageKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_joystickAxisSensitivityLabelLanguageKey");
			NativeFieldInfoPtr__mouseXYAxisSensitivityLabelLanguageKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_mouseXYAxisSensitivityLabelLanguageKey");
			NativeFieldInfoPtr__joystickAxisSensitivityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_joystickAxisSensitivityIcon");
			NativeFieldInfoPtr__mouseXYAxisSensitivityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_mouseXYAxisSensitivityIcon");
			NativeFieldInfoPtr__joystickAxisSensitivityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_joystickAxisSensitivityMin");
			NativeFieldInfoPtr__joystickAxisSensitivityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_joystickAxisSensitivityMax");
			NativeFieldInfoPtr__mouseXYAxisSensitivityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_mouseXYAxisSensitivityMin");
			NativeFieldInfoPtr__mouseXYAxisSensitivityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, "_mouseXYAxisSensitivityMax");
			NativeMethodInfoPtr_get_inputBehaviorId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675644);
			NativeMethodInfoPtr_get_showJoystickAxisSensitivity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675645);
			NativeMethodInfoPtr_get_showMouseXYAxisSensitivity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675646);
			NativeMethodInfoPtr_get_labelLanguageKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675647);
			NativeMethodInfoPtr_get_joystickAxisSensitivityLabelLanguageKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675648);
			NativeMethodInfoPtr_get_mouseXYAxisSensitivityLabelLanguageKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675649);
			NativeMethodInfoPtr_get_joystickAxisSensitivityIcon_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675650);
			NativeMethodInfoPtr_get_mouseXYAxisSensitivityIcon_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675651);
			NativeMethodInfoPtr_get_joystickAxisSensitivityMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675652);
			NativeMethodInfoPtr_get_joystickAxisSensitivityMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675653);
			NativeMethodInfoPtr_get_mouseXYAxisSensitivityMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675654);
			NativeMethodInfoPtr_get_mouseXYAxisSensitivityMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675655);
			NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675656);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr, 100675657);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353063, XrefRangeEnd = 353067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputBehaviorSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputBehaviorSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InputBehaviorSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Prefabs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__button;

		private static readonly System.IntPtr NativeFieldInfoPtr__fitButton;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridLabel;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridHeaderLabel;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridFieldButton;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridFieldInvertToggle;

		private static readonly System.IntPtr NativeFieldInfoPtr__window;

		private static readonly System.IntPtr NativeFieldInfoPtr__windowTitleText;

		private static readonly System.IntPtr NativeFieldInfoPtr__windowContentText;

		private static readonly System.IntPtr NativeFieldInfoPtr__fader;

		private static readonly System.IntPtr NativeFieldInfoPtr__calibrationWindow;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputBehaviorsWindow;

		private static readonly System.IntPtr NativeFieldInfoPtr__centerStickGraphic;

		private static readonly System.IntPtr NativeFieldInfoPtr__moveStickGraphic;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_button_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fitButton_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridLabel_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridHeaderLabel_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridFieldButton_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridFieldInvertToggle_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_window_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_windowTitleText_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_windowContentText_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fader_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrationWindow_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputBehaviorsWindow_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_centerStickGraphic_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_moveStickGraphic_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe GameObject _button
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__button);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__button)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _fitButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fitButton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fitButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _inputGridLabel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridLabel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _inputGridHeaderLabel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeaderLabel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeaderLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _inputGridFieldButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldButton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _inputGridFieldInvertToggle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldInvertToggle);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldInvertToggle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _window
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__window);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__window)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _windowTitleText
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__windowTitleText);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__windowTitleText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _windowContentText
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__windowContentText);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__windowContentText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _fader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fader);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _calibrationWindow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationWindow);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationWindow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _inputBehaviorsWindow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorsWindow);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorsWindow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _centerStickGraphic
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerStickGraphic);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__centerStickGraphic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject _moveStickGraphic
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveStickGraphic);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__moveStickGraphic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject button
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_button_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject fitButton
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fitButton_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject inputGridLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridLabel_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject inputGridHeaderLabel
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridHeaderLabel_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject inputGridFieldButton
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 353048, RefRangeEnd = 353057, XrefRangeStart = 353048, XrefRangeEnd = 353057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridFieldButton_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject inputGridFieldInvertToggle
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 353057, RefRangeEnd = 353062, XrefRangeStart = 353057, XrefRangeEnd = 353062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridFieldInvertToggle_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject window
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 315010, RefRangeEnd = 315014, XrefRangeStart = 315010, XrefRangeEnd = 315014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_window_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject windowTitleText
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 352504, RefRangeEnd = 352568, XrefRangeStart = 352504, XrefRangeEnd = 352568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_windowTitleText_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject windowContentText
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 353067, RefRangeEnd = 353069, XrefRangeStart = 353067, XrefRangeEnd = 353067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_windowContentText_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject fader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fader_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject calibrationWindow
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 353069, RefRangeEnd = 353070, XrefRangeStart = 353069, XrefRangeEnd = 353069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_calibrationWindow_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject inputBehaviorsWindow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputBehaviorsWindow_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject centerStickGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_centerStickGraphic_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		public unsafe GameObject moveStickGraphic
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 350350, RefRangeEnd = 350378, XrefRangeStart = 350350, XrefRangeEnd = 350378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_moveStickGraphic_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
		}

		static Prefabs()
		{
			Il2CppClassPointerStore<Prefabs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "Prefabs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Prefabs>.NativeClassPtr);
			NativeFieldInfoPtr__button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_button");
			NativeFieldInfoPtr__fitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_fitButton");
			NativeFieldInfoPtr__inputGridLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_inputGridLabel");
			NativeFieldInfoPtr__inputGridHeaderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_inputGridHeaderLabel");
			NativeFieldInfoPtr__inputGridFieldButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_inputGridFieldButton");
			NativeFieldInfoPtr__inputGridFieldInvertToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_inputGridFieldInvertToggle");
			NativeFieldInfoPtr__window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_window");
			NativeFieldInfoPtr__windowTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_windowTitleText");
			NativeFieldInfoPtr__windowContentText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_windowContentText");
			NativeFieldInfoPtr__fader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_fader");
			NativeFieldInfoPtr__calibrationWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_calibrationWindow");
			NativeFieldInfoPtr__inputBehaviorsWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_inputBehaviorsWindow");
			NativeFieldInfoPtr__centerStickGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_centerStickGraphic");
			NativeFieldInfoPtr__moveStickGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, "_moveStickGraphic");
			NativeMethodInfoPtr_get_button_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675658);
			NativeMethodInfoPtr_get_fitButton_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675659);
			NativeMethodInfoPtr_get_inputGridLabel_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675660);
			NativeMethodInfoPtr_get_inputGridHeaderLabel_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675661);
			NativeMethodInfoPtr_get_inputGridFieldButton_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675662);
			NativeMethodInfoPtr_get_inputGridFieldInvertToggle_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675663);
			NativeMethodInfoPtr_get_window_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675664);
			NativeMethodInfoPtr_get_windowTitleText_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675665);
			NativeMethodInfoPtr_get_windowContentText_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675666);
			NativeMethodInfoPtr_get_fader_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675667);
			NativeMethodInfoPtr_get_calibrationWindow_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675668);
			NativeMethodInfoPtr_get_inputBehaviorsWindow_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675669);
			NativeMethodInfoPtr_get_centerStickGraphic_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675670);
			NativeMethodInfoPtr_get_moveStickGraphic_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675671);
			NativeMethodInfoPtr_Check_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675672);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefabs>.NativeClassPtr, 100675673);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353184, RefRangeEnd = 353185, XrefRangeStart = 353070, XrefRangeEnd = 353184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Prefabs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Prefabs>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Prefabs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class References : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__canvas;

		private static readonly System.IntPtr NativeFieldInfoPtr__mainCanvasGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__mainContent;

		private static readonly System.IntPtr NativeFieldInfoPtr__mainContentInner;

		private static readonly System.IntPtr NativeFieldInfoPtr__playersGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__controllerGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__controllerGroupLabelGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__controllerSettingsGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__assignedControllersGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__settingsAndMapCategoriesGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__settingsGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__mapCategoriesGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridContainer;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridHeadersGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridVScrollbar;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridScrollRect;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridInnerGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr__controllerNameLabel;

		private static readonly System.IntPtr NativeFieldInfoPtr__removeControllerButton;

		private static readonly System.IntPtr NativeFieldInfoPtr__assignControllerButton;

		private static readonly System.IntPtr NativeFieldInfoPtr__calibrateControllerButton;

		private static readonly System.IntPtr NativeFieldInfoPtr__doneButton;

		private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsButton;

		private static readonly System.IntPtr NativeFieldInfoPtr__defaultSelection;

		private static readonly System.IntPtr NativeFieldInfoPtr__fixedSelectableUIElements;

		private static readonly System.IntPtr NativeFieldInfoPtr__mainBackgroundImage;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridLayoutElement_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridActionColumn_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridKeyboardColumn_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridMouseColumn_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridControllerColumn_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridHeader1_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridHeader2_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridHeader3_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__inputGridHeader4_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mainCanvasGroup_Public_get_CanvasGroup_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mainContent_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mainContentInner_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_playersGroup_Public_get_UIGroup_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerGroup_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerGroupLabelGroup_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerSettingsGroup_Public_get_UIGroup_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_assignedControllersGroup_Public_get_UIGroup_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsAndMapCategoriesGroup_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsGroup_Public_get_UIGroup_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mapCategoriesGroup_Public_get_UIGroup_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridGroup_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridContainer_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridHeadersGroup_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridVScrollbar_Public_get_Scrollbar_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridScrollRect_Public_get_ScrollRect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridInnerGroup_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerNameLabel_Public_get_TMP_Text_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_removeControllerButton_Public_get_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_assignControllerButton_Public_get_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_calibrateControllerButton_Public_get_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_doneButton_Public_get_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsButton_Public_get_Button_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSelection_Public_get_Selectable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedSelectableUIElements_Public_get_Il2CppReferenceArray_1_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mainBackgroundImage_Public_get_Image_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridLayoutElement_Public_get_LayoutElement_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridLayoutElement_Public_set_Void_LayoutElement_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridActionColumn_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridActionColumn_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridKeyboardColumn_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridKeyboardColumn_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridMouseColumn_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridMouseColumn_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridControllerColumn_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridControllerColumn_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridHeader1_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridHeader1_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridHeader2_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridHeader2_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridHeader3_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridHeader3_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridHeader4_Public_get_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_inputGridHeader4_Public_set_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Canvas _canvas
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canvas);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Canvas>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canvas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas));
			}
		}

		public unsafe CanvasGroup _mainCanvasGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainCanvasGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainCanvasGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasGroup));
			}
		}

		public unsafe Transform _mainContent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainContent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainContent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _mainContentInner
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainContentInner);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainContentInner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe UIGroup _playersGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playersGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playersGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIGroup));
			}
		}

		public unsafe Transform _controllerGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _controllerGroupLabelGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerGroupLabelGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerGroupLabelGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe UIGroup _controllerSettingsGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerSettingsGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerSettingsGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIGroup));
			}
		}

		public unsafe UIGroup _assignedControllersGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignedControllersGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignedControllersGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIGroup));
			}
		}

		public unsafe Transform _settingsAndMapCategoriesGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsAndMapCategoriesGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsAndMapCategoriesGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe UIGroup _settingsGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIGroup));
			}
		}

		public unsafe UIGroup _mapCategoriesGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mapCategoriesGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mapCategoriesGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uIGroup));
			}
		}

		public unsafe Transform _inputGridGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridContainer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridContainer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridHeadersGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeadersGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeadersGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Scrollbar _inputGridVScrollbar
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridVScrollbar);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridVScrollbar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scrollbar));
			}
		}

		public unsafe ScrollRect _inputGridScrollRect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridScrollRect);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridScrollRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scrollRect));
			}
		}

		public unsafe Transform _inputGridInnerGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridInnerGroup);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridInnerGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe TMP_Text _controllerNameLabel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerNameLabel);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerNameLabel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_Text));
			}
		}

		public unsafe Button _removeControllerButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__removeControllerButton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__removeControllerButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
			}
		}

		public unsafe Button _assignControllerButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerButton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assignControllerButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
			}
		}

		public unsafe Button _calibrateControllerButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateControllerButton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrateControllerButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
			}
		}

		public unsafe Button _doneButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__doneButton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__doneButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
			}
		}

		public unsafe Button _restoreDefaultsButton
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsButton);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)button));
			}
		}

		public unsafe Selectable _defaultSelection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultSelection);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultSelection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectable));
			}
		}

		public unsafe Il2CppReferenceArray<GameObject> _fixedSelectableUIElements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fixedSelectableUIElements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fixedSelectableUIElements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Image _mainBackgroundImage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainBackgroundImage);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainBackgroundImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
			}
		}

		public unsafe LayoutElement _inputGridLayoutElement_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridLayoutElement_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridLayoutElement_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutElement));
			}
		}

		public unsafe Transform _inputGridActionColumn_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridActionColumn_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridActionColumn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridKeyboardColumn_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridKeyboardColumn_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridKeyboardColumn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridMouseColumn_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridMouseColumn_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridMouseColumn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridControllerColumn_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridControllerColumn_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridControllerColumn_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridHeader1_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader1_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader1_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridHeader2_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader2_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader2_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridHeader3_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader3_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader3_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Transform _inputGridHeader4_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader4_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridHeader4_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Canvas canvas
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Canvas>(intPtr) : null;
			}
		}

		public unsafe CanvasGroup mainCanvasGroup
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainCanvasGroup_Public_get_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr) : null;
			}
		}

		public unsafe Transform mainContent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainContent_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe Transform mainContentInner
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainContentInner_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe UIGroup playersGroup
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 353048, RefRangeEnd = 353057, XrefRangeStart = 353048, XrefRangeEnd = 353057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playersGroup_Public_get_UIGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
		}

		public unsafe Transform controllerGroup
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 353057, RefRangeEnd = 353062, XrefRangeStart = 353057, XrefRangeEnd = 353062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerGroup_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe Transform controllerGroupLabelGroup
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 315010, RefRangeEnd = 315014, XrefRangeStart = 315010, XrefRangeEnd = 315014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerGroupLabelGroup_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe UIGroup controllerSettingsGroup
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 352504, RefRangeEnd = 352568, XrefRangeStart = 352504, XrefRangeEnd = 352568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerSettingsGroup_Public_get_UIGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
		}

		public unsafe UIGroup assignedControllersGroup
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 353067, RefRangeEnd = 353069, XrefRangeStart = 353067, XrefRangeEnd = 353069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_assignedControllersGroup_Public_get_UIGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
		}

		public unsafe Transform settingsAndMapCategoriesGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settingsAndMapCategoriesGroup_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe UIGroup settingsGroup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 353069, RefRangeEnd = 353070, XrefRangeStart = 353069, XrefRangeEnd = 353070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settingsGroup_Public_get_UIGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
		}

		public unsafe UIGroup mapCategoriesGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mapCategoriesGroup_Public_get_UIGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIGroup>(intPtr) : null;
			}
		}

		public unsafe Transform inputGridGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridGroup_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe Transform inputGridContainer
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 350350, RefRangeEnd = 350378, XrefRangeStart = 350350, XrefRangeEnd = 350378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridContainer_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe Transform inputGridHeadersGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridHeadersGroup_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe Scrollbar inputGridVScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridVScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr) : null;
			}
		}

		public unsafe ScrollRect inputGridScrollRect
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 353185, RefRangeEnd = 353191, XrefRangeStart = 353185, XrefRangeEnd = 353185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridScrollRect_Public_get_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr) : null;
			}
		}

		public unsafe Transform inputGridInnerGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridInnerGroup_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
		}

		public unsafe TMP_Text controllerNameLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerNameLabel_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr) : null;
			}
		}

		public unsafe Button removeControllerButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_removeControllerButton_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
		}

		public unsafe Button assignControllerButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_assignControllerButton_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
		}

		public unsafe Button calibrateControllerButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_calibrateControllerButton_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
		}

		public unsafe Button doneButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_doneButton_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
		}

		public unsafe Button restoreDefaultsButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_restoreDefaultsButton_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Button>(intPtr) : null;
			}
		}

		public unsafe Selectable defaultSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultSelection_Public_get_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
			}
		}

		public unsafe Il2CppReferenceArray<GameObject> fixedSelectableUIElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedSelectableUIElements_Public_get_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
			}
		}

		public unsafe Image mainBackgroundImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainBackgroundImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
			}
		}

		public unsafe LayoutElement inputGridLayoutElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridLayoutElement_Public_get_LayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 353191, RefRangeEnd = 353196, XrefRangeStart = 353191, XrefRangeEnd = 353191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridLayoutElement_Public_set_Void_LayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridActionColumn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridActionColumn_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridActionColumn_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridKeyboardColumn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridKeyboardColumn_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridKeyboardColumn_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridMouseColumn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridMouseColumn_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 353196, RefRangeEnd = 353197, XrefRangeStart = 353196, XrefRangeEnd = 353196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridMouseColumn_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridControllerColumn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridControllerColumn_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 353197, RefRangeEnd = 353199, XrefRangeStart = 353197, XrefRangeEnd = 353197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridControllerColumn_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridHeader1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridHeader1_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridHeader1_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridHeader2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridHeader2_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 353199, RefRangeEnd = 353200, XrefRangeStart = 353199, XrefRangeEnd = 353199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridHeader2_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridHeader3
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridHeader3_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridHeader3_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Transform inputGridHeader4
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridHeader4_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputGridHeader4_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static References()
		{
			Il2CppClassPointerStore<References>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "References");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<References>.NativeClassPtr);
			NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_canvas");
			NativeFieldInfoPtr__mainCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_mainCanvasGroup");
			NativeFieldInfoPtr__mainContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_mainContent");
			NativeFieldInfoPtr__mainContentInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_mainContentInner");
			NativeFieldInfoPtr__playersGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_playersGroup");
			NativeFieldInfoPtr__controllerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_controllerGroup");
			NativeFieldInfoPtr__controllerGroupLabelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_controllerGroupLabelGroup");
			NativeFieldInfoPtr__controllerSettingsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_controllerSettingsGroup");
			NativeFieldInfoPtr__assignedControllersGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_assignedControllersGroup");
			NativeFieldInfoPtr__settingsAndMapCategoriesGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_settingsAndMapCategoriesGroup");
			NativeFieldInfoPtr__settingsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_settingsGroup");
			NativeFieldInfoPtr__mapCategoriesGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_mapCategoriesGroup");
			NativeFieldInfoPtr__inputGridGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_inputGridGroup");
			NativeFieldInfoPtr__inputGridContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_inputGridContainer");
			NativeFieldInfoPtr__inputGridHeadersGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_inputGridHeadersGroup");
			NativeFieldInfoPtr__inputGridVScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_inputGridVScrollbar");
			NativeFieldInfoPtr__inputGridScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_inputGridScrollRect");
			NativeFieldInfoPtr__inputGridInnerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_inputGridInnerGroup");
			NativeFieldInfoPtr__controllerNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_controllerNameLabel");
			NativeFieldInfoPtr__removeControllerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_removeControllerButton");
			NativeFieldInfoPtr__assignControllerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_assignControllerButton");
			NativeFieldInfoPtr__calibrateControllerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_calibrateControllerButton");
			NativeFieldInfoPtr__doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_doneButton");
			NativeFieldInfoPtr__restoreDefaultsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_restoreDefaultsButton");
			NativeFieldInfoPtr__defaultSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_defaultSelection");
			NativeFieldInfoPtr__fixedSelectableUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_fixedSelectableUIElements");
			NativeFieldInfoPtr__mainBackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_mainBackgroundImage");
			NativeFieldInfoPtr__inputGridLayoutElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridLayoutElement>k__BackingField");
			NativeFieldInfoPtr__inputGridActionColumn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridActionColumn>k__BackingField");
			NativeFieldInfoPtr__inputGridKeyboardColumn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridKeyboardColumn>k__BackingField");
			NativeFieldInfoPtr__inputGridMouseColumn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridMouseColumn>k__BackingField");
			NativeFieldInfoPtr__inputGridControllerColumn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridControllerColumn>k__BackingField");
			NativeFieldInfoPtr__inputGridHeader1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridHeader1>k__BackingField");
			NativeFieldInfoPtr__inputGridHeader2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridHeader2>k__BackingField");
			NativeFieldInfoPtr__inputGridHeader3_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridHeader3>k__BackingField");
			NativeFieldInfoPtr__inputGridHeader4_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "<inputGridHeader4>k__BackingField");
			NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675674);
			NativeMethodInfoPtr_get_mainCanvasGroup_Public_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675675);
			NativeMethodInfoPtr_get_mainContent_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675676);
			NativeMethodInfoPtr_get_mainContentInner_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675677);
			NativeMethodInfoPtr_get_playersGroup_Public_get_UIGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675678);
			NativeMethodInfoPtr_get_controllerGroup_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675679);
			NativeMethodInfoPtr_get_controllerGroupLabelGroup_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675680);
			NativeMethodInfoPtr_get_controllerSettingsGroup_Public_get_UIGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675681);
			NativeMethodInfoPtr_get_assignedControllersGroup_Public_get_UIGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675682);
			NativeMethodInfoPtr_get_settingsAndMapCategoriesGroup_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675683);
			NativeMethodInfoPtr_get_settingsGroup_Public_get_UIGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675684);
			NativeMethodInfoPtr_get_mapCategoriesGroup_Public_get_UIGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675685);
			NativeMethodInfoPtr_get_inputGridGroup_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675686);
			NativeMethodInfoPtr_get_inputGridContainer_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675687);
			NativeMethodInfoPtr_get_inputGridHeadersGroup_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675688);
			NativeMethodInfoPtr_get_inputGridVScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675689);
			NativeMethodInfoPtr_get_inputGridScrollRect_Public_get_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675690);
			NativeMethodInfoPtr_get_inputGridInnerGroup_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675691);
			NativeMethodInfoPtr_get_controllerNameLabel_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675692);
			NativeMethodInfoPtr_get_removeControllerButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675693);
			NativeMethodInfoPtr_get_assignControllerButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675694);
			NativeMethodInfoPtr_get_calibrateControllerButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675695);
			NativeMethodInfoPtr_get_doneButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675696);
			NativeMethodInfoPtr_get_restoreDefaultsButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675697);
			NativeMethodInfoPtr_get_defaultSelection_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675698);
			NativeMethodInfoPtr_get_fixedSelectableUIElements_Public_get_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675699);
			NativeMethodInfoPtr_get_mainBackgroundImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675700);
			NativeMethodInfoPtr_get_inputGridLayoutElement_Public_get_LayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675701);
			NativeMethodInfoPtr_set_inputGridLayoutElement_Public_set_Void_LayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675702);
			NativeMethodInfoPtr_get_inputGridActionColumn_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675703);
			NativeMethodInfoPtr_set_inputGridActionColumn_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675704);
			NativeMethodInfoPtr_get_inputGridKeyboardColumn_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675705);
			NativeMethodInfoPtr_set_inputGridKeyboardColumn_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675706);
			NativeMethodInfoPtr_get_inputGridMouseColumn_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675707);
			NativeMethodInfoPtr_set_inputGridMouseColumn_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675708);
			NativeMethodInfoPtr_get_inputGridControllerColumn_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675709);
			NativeMethodInfoPtr_set_inputGridControllerColumn_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675710);
			NativeMethodInfoPtr_get_inputGridHeader1_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675711);
			NativeMethodInfoPtr_set_inputGridHeader1_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675712);
			NativeMethodInfoPtr_get_inputGridHeader2_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675713);
			NativeMethodInfoPtr_set_inputGridHeader2_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675714);
			NativeMethodInfoPtr_get_inputGridHeader3_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675715);
			NativeMethodInfoPtr_set_inputGridHeader3_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675716);
			NativeMethodInfoPtr_get_inputGridHeader4_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675717);
			NativeMethodInfoPtr_set_inputGridHeader4_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675718);
			NativeMethodInfoPtr_Check_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675719);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100675720);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353353, RefRangeEnd = 353354, XrefRangeStart = 353200, XrefRangeEnd = 353353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Check_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe References()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<References>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public References(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class InputActionSet : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__actionId;

		private static readonly System.IntPtr NativeFieldInfoPtr__axisRange;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_AxisRange_0;

		public unsafe int _actionId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionId)) = num;
			}
		}

		public unsafe AxisRange _axisRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisRange);
				return *(AxisRange*)num;
			}
			set
			{
				*(AxisRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisRange)) = axisRange;
			}
		}

		public unsafe int actionId
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 349722, RefRangeEnd = 349786, XrefRangeStart = 349722, XrefRangeEnd = 349786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(AxisRange*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static InputActionSet()
		{
			Il2CppClassPointerStore<InputActionSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "InputActionSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActionSet>.NativeClassPtr);
			NativeFieldInfoPtr__actionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionSet>.NativeClassPtr, "_actionId");
			NativeFieldInfoPtr__axisRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionSet>.NativeClassPtr, "_axisRange");
			NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSet>.NativeClassPtr, 100675721);
			NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSet>.NativeClassPtr, 100675722);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSet>.NativeClassPtr, 100675723);
		}

		[CallerCount(0)]
		public unsafe InputActionSet(int actionId, AxisRange axisRange)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputActionSet>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&actionId);
			*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InputActionSet(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class InputMapping : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__actionName_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__fieldInfo_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__map_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__aem_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__controllerType_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__controllerId_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__pollingInfo_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__modifierKeyFlags_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_actionName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_actionName_Private_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fieldInfo_Public_get_InputFieldInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_fieldInfo_Private_set_Void_InputFieldInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_map_Public_get_ControllerMap_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_map_Private_set_Void_ControllerMap_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_aem_Public_get_ActionElementMap_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_aem_Private_set_Void_ActionElementMap_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerId_Private_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_pollingInfo_Public_get_ControllerPollingInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_pollingInfo_Public_set_Void_ControllerPollingInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_modifierKeyFlags_Public_set_Void_ModifierKeyFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_elementName_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputFieldInfo_ControllerMap_ActionElementMap_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_ControllerPollingInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_ControllerPollingInfo_ModifierKeyFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_0;

		public unsafe string _actionName_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe InputFieldInfo _fieldInfo_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fieldInfo_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputFieldInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fieldInfo_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputFieldInfo));
			}
		}

		public unsafe ControllerMap _map_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__map_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__map_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap));
			}
		}

		public unsafe ActionElementMap _aem_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aem_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aem_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionElementMap));
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

		public unsafe int _controllerId_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerId_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerId_k__BackingField)) = num;
			}
		}

		public unsafe ControllerPollingInfo _pollingInfo_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pollingInfo_k__BackingField);
				return new ControllerPollingInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pollingInfo_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerPollingInfo)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControllerPollingInfo>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ModifierKeyFlags _modifierKeyFlags_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modifierKeyFlags_k__BackingField);
				return *(ModifierKeyFlags*)num;
			}
			set
			{
				*(ModifierKeyFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modifierKeyFlags_k__BackingField)) = modifierKeyFlags;
			}
		}

		public unsafe string actionName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 191619, RefRangeEnd = 191718, XrefRangeStart = 191619, XrefRangeEnd = 191718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe InputFieldInfo fieldInfo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fieldInfo_Public_get_InputFieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputFieldInfo>(intPtr) : null;
			}
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fieldInfo_Private_set_Void_InputFieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe ControllerMap map
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_map_Public_get_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59183, XrefRangeStart = 59139, XrefRangeEnd = 59183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_map_Private_set_Void_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe ActionElementMap aem
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aem_Public_get_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr) : null;
			}
			[CallerCount(60)]
			[CachedScanResults(RefRangeStart = 71605, RefRangeEnd = 71665, XrefRangeStart = 71605, XrefRangeEnd = 71665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aem_Private_set_Void_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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

		public unsafe int controllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe ControllerPollingInfo pollingInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pollingInfo_Public_get_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ControllerPollingInfo(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pollingInfo_Public_set_Void_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe ModifierKeyFlags modifierKeyFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ModifierKeyFlags*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_modifierKeyFlags_Public_set_Void_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe AxisRange axisRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(AxisRange*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe string elementName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 353356, RefRangeEnd = 353358, XrefRangeStart = 353354, XrefRangeEnd = 353356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_elementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		static InputMapping()
		{
			Il2CppClassPointerStore<InputMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "InputMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMapping>.NativeClassPtr);
			NativeFieldInfoPtr__actionName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<actionName>k__BackingField");
			NativeFieldInfoPtr__fieldInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<fieldInfo>k__BackingField");
			NativeFieldInfoPtr__map_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<map>k__BackingField");
			NativeFieldInfoPtr__aem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<aem>k__BackingField");
			NativeFieldInfoPtr__controllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<controllerType>k__BackingField");
			NativeFieldInfoPtr__controllerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<controllerId>k__BackingField");
			NativeFieldInfoPtr__pollingInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<pollingInfo>k__BackingField");
			NativeFieldInfoPtr__modifierKeyFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, "<modifierKeyFlags>k__BackingField");
			NativeMethodInfoPtr_get_actionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675724);
			NativeMethodInfoPtr_set_actionName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675725);
			NativeMethodInfoPtr_get_fieldInfo_Public_get_InputFieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675726);
			NativeMethodInfoPtr_set_fieldInfo_Private_set_Void_InputFieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675727);
			NativeMethodInfoPtr_get_map_Public_get_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675728);
			NativeMethodInfoPtr_set_map_Private_set_Void_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675729);
			NativeMethodInfoPtr_get_aem_Public_get_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675730);
			NativeMethodInfoPtr_set_aem_Private_set_Void_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675731);
			NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675732);
			NativeMethodInfoPtr_set_controllerType_Private_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675733);
			NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675734);
			NativeMethodInfoPtr_set_controllerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675735);
			NativeMethodInfoPtr_get_pollingInfo_Public_get_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675736);
			NativeMethodInfoPtr_set_pollingInfo_Public_set_Void_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675737);
			NativeMethodInfoPtr_get_modifierKeyFlags_Public_get_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675738);
			NativeMethodInfoPtr_set_modifierKeyFlags_Public_set_Void_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675739);
			NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675740);
			NativeMethodInfoPtr_get_elementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675741);
			NativeMethodInfoPtr__ctor_Public_Void_String_InputFieldInfo_ControllerMap_ActionElementMap_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675742);
			NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675743);
			NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_ControllerPollingInfo_ModifierKeyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675744);
			NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputMapping>.NativeClassPtr, 100675745);
		}

		[CallerCount(0)]
		public unsafe InputMapping(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputMapping>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldInfo);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aem);
			*(ControllerType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_InputFieldInfo_ControllerMap_ActionElementMap_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353358, XrefRangeEnd = 353359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pollingInfo));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ElementAssignment*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353359, XrefRangeEnd = 353360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pollingInfo));
			*(ModifierKeyFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &modifierKeyFlags;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_ControllerPollingInfo_ModifierKeyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ElementAssignment*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 353362, RefRangeEnd = 353367, XrefRangeStart = 353360, XrefRangeEnd = 353362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementAssignment ToElementAssignment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToElementAssignment_Public_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ElementAssignment*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public InputMapping(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AxisCalibrator : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeFieldInfoPtr_joystick;

		private static readonly System.IntPtr NativeFieldInfoPtr_axisIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_axis;

		private static readonly System.IntPtr NativeFieldInfoPtr_firstRun;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RecordMinMax_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RecordZero_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Commit_Public_Void_0;

		public unsafe AxisCalibrationData data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				return new AxisCalibrationData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axisCalibrationData)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AxisCalibrationData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Joystick joystick
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystick);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystick)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick));
			}
		}

		public unsafe int axisIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisIndex)) = num;
			}
		}

		public unsafe Controller.Axis axis
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axis);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controller.Axis>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axis)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axis));
			}
		}

		public unsafe bool firstRun
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstRun);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstRun)) = flag;
			}
		}

		public unsafe bool isValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static AxisCalibrator()
		{
			Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "AxisCalibrator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, "data");
			NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, "joystick");
			NativeFieldInfoPtr_axisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, "axisIndex");
			NativeFieldInfoPtr_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, "axis");
			NativeFieldInfoPtr_firstRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, "firstRun");
			NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, 100675746);
			NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, 100675747);
			NativeMethodInfoPtr_RecordMinMax_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, 100675748);
			NativeMethodInfoPtr_RecordZero_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, 100675749);
			NativeMethodInfoPtr_Commit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr, 100675750);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353367, XrefRangeEnd = 353376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxisCalibrator(Joystick joystick, int axisIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisCalibrator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353376, XrefRangeEnd = 353377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordMinMax()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordMinMax_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353377, XrefRangeEnd = 353378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordZero()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordZero_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353378, XrefRangeEnd = 353381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Commit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AxisCalibrator(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class IndexedDictionary<TKey, TValue> : Il2CppSystem.Object
	{
		public class Entry : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_key;

			private static readonly System.IntPtr NativeFieldInfoPtr_value;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0;

			public unsafe TKey key
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
					return IL2CPP.PointerToValueGeneric<TKey>((System.IntPtr)num, true, false);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
					System.Type typeFromHandle = typeof(TKey);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((((object)val) is Il2CppObjectBase) ? ((object)val) : null));
							if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
							{
								System.IntPtr intPtr2 = intPtr;
								// IL cpblk instruction
								Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, intPtr);
							}
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, IL2CPP.ManagedStringToIl2Cpp(val as string));
						}
					}
					else
					{
						Unsafe.Write((void*)num2, val);
					}
				}
			}

			public unsafe TValue value
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num, true, false);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
					System.Type typeFromHandle = typeof(TValue);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((((object)val) is Il2CppObjectBase) ? ((object)val) : null));
							if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
							{
								System.IntPtr intPtr2 = intPtr;
								// IL cpblk instruction
								Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, intPtr);
							}
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, IL2CPP.ManagedStringToIl2Cpp(val as string));
						}
					}
					else
					{
						Unsafe.Write((void*)num2, val);
					}
				}
			}

			static Entry()
			{
				Il2CppClassPointerStore<Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
				{
					Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entry>.NativeClassPtr);
				NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "key");
				NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "value");
				NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100675760);
			}

			[CallerCount(0)]
			public unsafe Entry(TKey key, TValue value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entry>.NativeClassPtr))
			{
				//IL_0055->IL0058: Incompatible stack types: I vs Ref
				//IL_0048->IL0058: Incompatible stack types: I vs Ref
				//IL_009d->IL00a0: Incompatible stack types: I vs Ref
				//IL_0090->IL00a0: Incompatible stack types: I vs Ref
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				ref TKey reference;
				if (!typeof(TKey).IsValueType)
				{
					object obj = key;
					reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
				}
				else
				{
					reference = ref key;
				}
				*ptr = (nint)Unsafe.AsPointer(ref reference);
				byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
				ref TValue reference2;
				if (!typeof(TValue).IsValueType)
				{
					object obj2 = value;
					reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
				}
				else
				{
					reference2 = ref value;
				}
				*(void**)num = Unsafe.AsPointer(ref reference2);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public Entry(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_list;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_TValue_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_TValue_TKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_TKey_byref_TValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		public unsafe List<Entry> list
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353381, XrefRangeEnd = 353382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe TValue this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&index);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
		}

		static IndexedDictionary()
		{
			Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "IndexedDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr);
			NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, "list");
			NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675751);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675752);
			NativeMethodInfoPtr_get_Item_Public_get_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675753);
			NativeMethodInfoPtr_Get_Public_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675754);
			NativeMethodInfoPtr_TryGet_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675755);
			NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675756);
			NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675757);
			NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675758);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr, 100675759);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 353384, RefRangeEnd = 353392, XrefRangeStart = 353382, XrefRangeEnd = 353384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 353392, RefRangeEnd = 353427, XrefRangeStart = 353392, XrefRangeEnd = 353392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue Get(TKey key)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TKey reference;
			if (!typeof(TKey).IsValueType)
			{
				object obj = key;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref key;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
		}

		[CallerCount(0)]
		public unsafe bool TryGet(TKey key, out TValue value)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			//IL_0075->IL0077: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			ref TKey reference;
			if (!typeof(TKey).IsValueType)
			{
				object obj = key;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref key;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			Unsafe.SkipInit(out nint num2);
			ref TValue reference2;
			if (!typeof(TValue).IsValueType)
			{
				num2 = 0;
				reference2 = ref *(_003F*)(&num2);
			}
			else
			{
				reference2 = ref value;
			}
			*(void**)num = Unsafe.AsPointer(ref reference2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGet_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			if (!typeof(TValue).IsValueType)
			{
				nint num3 = num2;
				Unsafe.As<TValue, object>(ref value) = ((num3 == 0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num3, false, false));
			}
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 353441, RefRangeEnd = 353450, XrefRangeStart = 353427, XrefRangeEnd = 353441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(TKey key, TValue value)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			//IL_0094->IL0097: Incompatible stack types: I vs Ref
			//IL_0087->IL0097: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			ref TKey reference;
			if (!typeof(TKey).IsValueType)
			{
				object obj = key;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref key;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			ref TValue reference2;
			if (!typeof(TValue).IsValueType)
			{
				object obj2 = value;
				reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
			}
			else
			{
				reference2 = ref value;
			}
			*(void**)num = Unsafe.AsPointer(ref reference2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe int IndexOfKey(TKey key)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TKey reference;
			if (!typeof(TKey).IsValueType)
			{
				object obj = key;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref key;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfKey_Public_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 353450, RefRangeEnd = 353486, XrefRangeStart = 353450, XrefRangeEnd = 353450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsKey(TKey key)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TKey reference;
			if (!typeof(TKey).IsValueType)
			{
				object obj = key;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref key;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsKey_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353486, XrefRangeEnd = 353487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IndexedDictionary(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum LayoutElementSizeType
	{
		MinSize,
		PreferredSize
	}

	public enum WindowType
	{
		None,
		ChooseJoystick,
		JoystickAssignmentConflict,
		ElementAssignment,
		ElementAssignmentPrePolling,
		ElementAssignmentPolling,
		ElementAssignmentResult,
		ElementAssignmentConflict,
		Calibration,
		CalibrateStep1,
		CalibrateStep2
	}

	public class InputGrid : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_list;

		private static readonly System.IntPtr NativeFieldInfoPtr_groups;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddMapCategory_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddAction_Public_Void_Int32_InputAction_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionCategory_Public_Void_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddInputFieldSet_Public_Void_Int32_InputAction_AxisRange_ControllerType_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddInputField_Public_Void_Int32_InputAction_AxisRange_ControllerType_Int32_GUIInputField_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddGroup_Public_Void_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionLabel_Public_Void_Int32_Int32_AxisRange_GUILabel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionCategoryLabel_Public_Void_Int32_Int32_GUILabel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_Int32_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionSets_Public_IEnumerable_1_InputActionSet_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetColumnHeight_Public_Void_Int32_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetColumnHeight_Public_Single_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFieldsActive_Public_Void_Int32_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFieldLabel_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PopulateField_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_Int32_Int32_String_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFixedFieldData_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeFields_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HideAll_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClearLabels_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClearGroups_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClearAll_Public_Void_0;

		public unsafe InputGridEntryList list
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputGridEntryList>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_list)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputGridEntryList));
			}
		}

		public unsafe List<GameObject> groups
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static InputGrid()
		{
			Il2CppClassPointerStore<InputGrid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "InputGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputGrid>.NativeClassPtr);
			NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, "list");
			NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, "groups");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675761);
			NativeMethodInfoPtr_AddMapCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675762);
			NativeMethodInfoPtr_AddAction_Public_Void_Int32_InputAction_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675763);
			NativeMethodInfoPtr_AddActionCategory_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675764);
			NativeMethodInfoPtr_AddInputFieldSet_Public_Void_Int32_InputAction_AxisRange_ControllerType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675765);
			NativeMethodInfoPtr_AddInputField_Public_Void_Int32_InputAction_AxisRange_ControllerType_Int32_GUIInputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675766);
			NativeMethodInfoPtr_AddGroup_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675767);
			NativeMethodInfoPtr_AddActionLabel_Public_Void_Int32_Int32_AxisRange_GUILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675768);
			NativeMethodInfoPtr_AddActionCategoryLabel_Public_Void_Int32_Int32_GUILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675769);
			NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675770);
			NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_Int32_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675771);
			NativeMethodInfoPtr_GetActionSets_Public_IEnumerable_1_InputActionSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675772);
			NativeMethodInfoPtr_SetColumnHeight_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675773);
			NativeMethodInfoPtr_GetColumnHeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675774);
			NativeMethodInfoPtr_SetFieldsActive_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675775);
			NativeMethodInfoPtr_SetFieldLabel_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675776);
			NativeMethodInfoPtr_PopulateField_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675777);
			NativeMethodInfoPtr_SetFixedFieldData_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675778);
			NativeMethodInfoPtr_InitializeFields_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675779);
			NativeMethodInfoPtr_Show_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675780);
			NativeMethodInfoPtr_HideAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675781);
			NativeMethodInfoPtr_ClearLabels_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675782);
			NativeMethodInfoPtr_ClearGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675783);
			NativeMethodInfoPtr_ClearAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGrid>.NativeClassPtr, 100675784);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353502, RefRangeEnd = 353503, XrefRangeStart = 353487, XrefRangeEnd = 353502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputGrid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputGrid>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353503, XrefRangeEnd = 353505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMapCategory(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMapCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 353508, RefRangeEnd = 353515, XrefRangeStart = 353505, XrefRangeEnd = 353508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAction_Public_Void_Int32_InputAction_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353529, RefRangeEnd = 353530, XrefRangeStart = 353515, XrefRangeEnd = 353529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionCategory(int mapCategoryId, int actionCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionCategoryId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionCategory_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353530, XrefRangeEnd = 353532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldSetContainer);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInputFieldSet_Public_Void_Int32_InputAction_AxisRange_ControllerType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353545, RefRangeEnd = 353546, XrefRangeStart = 353532, XrefRangeEnd = 353545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, GUIInputField inputField)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputField);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInputField_Public_Void_Int32_InputAction_AxisRange_ControllerType_Int32_GUIInputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353546, XrefRangeEnd = 353550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGroup(GameObject group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGroup_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 353553, RefRangeEnd = 353560, XrefRangeStart = 353550, XrefRangeEnd = 353553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, GUILabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionLabel_Public_Void_Int32_Int32_AxisRange_GUILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353568, RefRangeEnd = 353569, XrefRangeStart = 353560, XrefRangeEnd = 353568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, GUILabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionCategoryId;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionCategoryLabel_Public_Void_Int32_Int32_GUILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353569, XrefRangeEnd = 353579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 353594, RefRangeEnd = 353597, XrefRangeStart = 353579, XrefRangeEnd = 353594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_Int32_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIInputField>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353597, XrefRangeEnd = 353601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<InputActionSet> GetActionSets(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionSets_Public_IEnumerable_1_InputActionSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InputActionSet>>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353603, RefRangeEnd = 353604, XrefRangeStart = 353601, XrefRangeEnd = 353603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumnHeight(int mapCategoryId, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&mapCategoryId);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColumnHeight_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353604, XrefRangeEnd = 353606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetColumnHeight(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColumnHeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353606, XrefRangeEnd = 353611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFieldsActive(int mapCategoryId, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&mapCategoryId);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFieldsActive_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353611, XrefRangeEnd = 353626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFieldLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFieldLabel_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353628, RefRangeEnd = 353629, XrefRangeStart = 353626, XrefRangeEnd = 353628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionElementMapId;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
			*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &invert;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateField_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_Int32_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353629, XrefRangeEnd = 353631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFixedFieldData_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353631, XrefRangeEnd = 353636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeFields(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeFields_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353636, XrefRangeEnd = 353639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353645, RefRangeEnd = 353647, XrefRangeStart = 353639, XrefRangeEnd = 353645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353647, XrefRangeEnd = 353652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLabels(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearLabels_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353670, RefRangeEnd = 353671, XrefRangeStart = 353652, XrefRangeEnd = 353670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353675, RefRangeEnd = 353677, XrefRangeStart = 353671, XrefRangeEnd = 353675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InputGrid(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class InputGridEntryList : Il2CppSystem.Object
	{
		public class MapCategoryEntry : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr__actionList;

			private static readonly System.IntPtr NativeFieldInfoPtr__actionCategoryList;

			private static readonly System.IntPtr NativeFieldInfoPtr__columnHeight;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_actionList_Public_get_List_1_ActionEntry_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_actionCategoryList_Public_get_IndexedDictionary_2_Int32_ActionCategoryEntry_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_columnHeight_Public_get_Single_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_set_columnHeight_Public_set_Void_Single_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetActionEntry_Public_ActionEntry_Int32_AxisRange_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfActionEntry_Public_Int32_Int32_AxisRange_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_ContainsActionEntry_Public_Boolean_Int32_AxisRange_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_AddAction_Public_ActionEntry_InputAction_AxisRange_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetActionCategoryEntry_Public_ActionCategoryEntry_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_AddActionCategory_Public_ActionCategoryEntry_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetAllActive_Public_Void_Boolean_0;

			public unsafe List<ActionEntry> _actionList
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionList);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ActionEntry>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
				}
			}

			public unsafe IndexedDictionary<int, ActionCategoryEntry> _actionCategoryList
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionCategoryList);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedDictionary<int, ActionCategoryEntry>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionCategoryList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indexedDictionary));
				}
			}

			public unsafe float _columnHeight
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__columnHeight);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__columnHeight)) = num;
				}
			}

			public unsafe List<ActionEntry> actionList
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionList_Public_get_List_1_ActionEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ActionEntry>>(intPtr) : null;
				}
			}

			public unsafe IndexedDictionary<int, ActionCategoryEntry> actionCategoryList
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionCategoryList_Public_get_IndexedDictionary_2_Int32_ActionCategoryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedDictionary<int, ActionCategoryEntry>>(intPtr) : null;
				}
			}

			public unsafe float columnHeight
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_columnHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = (nint)(&value);
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_columnHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			static MapCategoryEntry()
			{
				Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, "MapCategoryEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr);
				NativeFieldInfoPtr__actionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, "_actionList");
				NativeFieldInfoPtr__actionCategoryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, "_actionCategoryList");
				NativeFieldInfoPtr__columnHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, "_columnHeight");
				NativeMethodInfoPtr_get_actionList_Public_get_List_1_ActionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675812);
				NativeMethodInfoPtr_get_actionCategoryList_Public_get_IndexedDictionary_2_Int32_ActionCategoryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675813);
				NativeMethodInfoPtr_get_columnHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675814);
				NativeMethodInfoPtr_set_columnHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675815);
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675816);
				NativeMethodInfoPtr_GetActionEntry_Public_ActionEntry_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675817);
				NativeMethodInfoPtr_IndexOfActionEntry_Public_Int32_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675818);
				NativeMethodInfoPtr_ContainsActionEntry_Public_Boolean_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675819);
				NativeMethodInfoPtr_AddAction_Public_ActionEntry_InputAction_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675820);
				NativeMethodInfoPtr_GetActionCategoryEntry_Public_ActionCategoryEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675821);
				NativeMethodInfoPtr_AddActionCategory_Public_ActionCategoryEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675822);
				NativeMethodInfoPtr_SetAllActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr, 100675823);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353677, XrefRangeEnd = 353689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MapCategoryEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapCategoryEntry>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353691, RefRangeEnd = 353694, XrefRangeStart = 353689, XrefRangeEnd = 353691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionEntry GetActionEntry(int actionId, AxisRange axisRange)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&actionId);
				*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionEntry_Public_ActionEntry_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionEntry>(intPtr) : null;
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353696, RefRangeEnd = 353699, XrefRangeStart = 353694, XrefRangeEnd = 353696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int IndexOfActionEntry(int actionId, AxisRange axisRange)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&actionId);
				*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfActionEntry_Public_Int32_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353699, XrefRangeEnd = 353700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ContainsActionEntry(int actionId, AxisRange axisRange)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&actionId);
				*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsActionEntry_Public_Boolean_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353718, RefRangeEnd = 353721, XrefRangeStart = 353700, XrefRangeEnd = 353718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionEntry AddAction(InputAction action, AxisRange axisRange)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
				*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAction_Public_ActionEntry_InputAction_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionEntry>(intPtr) : null;
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353721, XrefRangeEnd = 353727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&actionCategoryId);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionCategoryEntry_Public_ActionCategoryEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionCategoryEntry>(intPtr) : null;
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353727, XrefRangeEnd = 353739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionCategoryEntry AddActionCategory(int actionCategoryId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&actionCategoryId);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionCategory_Public_ActionCategoryEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionCategoryEntry>(intPtr) : null;
			}

			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 353755, RefRangeEnd = 353760, XrefRangeStart = 353739, XrefRangeEnd = 353755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetAllActive(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&state);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAllActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public MapCategoryEntry(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class ActionEntry : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_fieldSets;

			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			private static readonly System.IntPtr NativeFieldInfoPtr_action;

			private static readonly System.IntPtr NativeFieldInfoPtr_axisRange;

			private static readonly System.IntPtr NativeFieldInfoPtr_actionSet;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputAction_AxisRange_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_GUILabel_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_Int32_AxisRange_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_AddInputFieldSet_Public_Void_ControllerType_GameObject_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_AddInputField_Public_Void_ControllerType_Int32_GUIInputField_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_ControllerType_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_ControllerType_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetFieldLabel_Public_Void_ControllerType_Int32_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_PopulateField_Public_Void_ControllerType_Int32_Int32_Int32_String_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetFixedFieldData_Public_Void_ControllerType_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_ClearLabels_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetFieldsActive_Public_Void_Boolean_0;

			public unsafe IndexedDictionary<int, FieldSet> fieldSets
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldSets);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedDictionary<int, FieldSet>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldSets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indexedDictionary));
				}
			}

			public unsafe GUILabel label
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILabel>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUILabel));
				}
			}

			public unsafe InputAction action
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAction>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputAction));
				}
			}

			public unsafe AxisRange axisRange
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisRange);
					return *(AxisRange*)num;
				}
				set
				{
					*(AxisRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axisRange)) = axisRange;
				}
			}

			public unsafe InputActionSet actionSet
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSet);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionSet>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputActionSet));
				}
			}

			static ActionEntry()
			{
				Il2CppClassPointerStore<ActionEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, "ActionEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr);
				NativeFieldInfoPtr_fieldSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, "fieldSets");
				NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, "label");
				NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, "action");
				NativeFieldInfoPtr_axisRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, "axisRange");
				NativeFieldInfoPtr_actionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, "actionSet");
				NativeMethodInfoPtr__ctor_Public_Void_InputAction_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675824);
				NativeMethodInfoPtr_SetLabel_Public_Void_GUILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675825);
				NativeMethodInfoPtr_Matches_Public_Boolean_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675826);
				NativeMethodInfoPtr_AddInputFieldSet_Public_Void_ControllerType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675827);
				NativeMethodInfoPtr_AddInputField_Public_Void_ControllerType_Int32_GUIInputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675828);
				NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675829);
				NativeMethodInfoPtr_Contains_Public_Boolean_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675830);
				NativeMethodInfoPtr_SetFieldLabel_Public_Void_ControllerType_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675831);
				NativeMethodInfoPtr_PopulateField_Public_Void_ControllerType_Int32_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675832);
				NativeMethodInfoPtr_SetFixedFieldData_Public_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675833);
				NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675834);
				NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675835);
				NativeMethodInfoPtr_ClearLabels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675836);
				NativeMethodInfoPtr_SetFieldsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr, 100675837);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353760, XrefRangeEnd = 353769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionEntry(InputAction action, AxisRange axisRange)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionEntry>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
				*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputAction_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLabel(GUILabel label)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLabel_Public_Void_GUILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool Matches(int actionId, AxisRange axisRange)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&actionId);
				*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Boolean_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353784, RefRangeEnd = 353787, XrefRangeStart = 353769, XrefRangeEnd = 353784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&controllerType);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldSetContainer);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInputFieldSet_Public_Void_ControllerType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353787, XrefRangeEnd = 353799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddInputField(ControllerType controllerType, int fieldIndex, GUIInputField inputField)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)(&controllerType);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputField);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInputField_Public_Void_ControllerType_Int32_GUIInputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353799, XrefRangeEnd = 353813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&controllerType);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIInputField>(intPtr) : null;
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353813, XrefRangeEnd = 353822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Contains(ControllerType controllerType, int fieldId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&controllerType);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldId;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353822, XrefRangeEnd = 353836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFieldLabel(ControllerType controllerType, int index, string label)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)(&controllerType);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFieldLabel_Public_Void_ControllerType_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 353854, RefRangeEnd = 353858, XrefRangeStart = 353836, XrefRangeEnd = 353854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[6];
				*ptr = (nint)(&controllerType);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
				*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
				*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionElementMapId;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
				*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &invert;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateField_Public_Void_ControllerType_Int32_Int32_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353869, RefRangeEnd = 353872, XrefRangeStart = 353858, XrefRangeEnd = 353869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFixedFieldData(ControllerType controllerType, int controllerId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&controllerType);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFixedFieldData_Public_Void_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353887, RefRangeEnd = 353890, XrefRangeStart = 353872, XrefRangeEnd = 353887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Initialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353890, XrefRangeEnd = 353897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetActive(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&state);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 353908, RefRangeEnd = 353910, XrefRangeStart = 353897, XrefRangeEnd = 353908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearLabels()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearLabels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 353920, RefRangeEnd = 353923, XrefRangeStart = 353910, XrefRangeEnd = 353920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFieldsActive(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&state);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFieldsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public ActionEntry(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class FieldSet : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_groupContainer;

			private static readonly System.IntPtr NativeFieldInfoPtr_fields;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_0;

			public unsafe GameObject groupContainer
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupContainer);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
				}
			}

			public unsafe IndexedDictionary<int, GUIInputField> fields
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fields);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedDictionary<int, GUIInputField>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fields)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indexedDictionary));
				}
			}

			static FieldSet()
			{
				Il2CppClassPointerStore<FieldSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, "FieldSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldSet>.NativeClassPtr);
				NativeFieldInfoPtr_groupContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldSet>.NativeClassPtr, "groupContainer");
				NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldSet>.NativeClassPtr, "fields");
				NativeMethodInfoPtr__ctor_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldSet>.NativeClassPtr, 100675838);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353923, XrefRangeEnd = 353929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FieldSet(GameObject groupContainer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldSet>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)groupContainer);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public FieldSet(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class ActionCategoryEntry : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_actionCategoryId;

			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_GUILabel_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

			public unsafe int actionCategoryId
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionCategoryId);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionCategoryId)) = num;
				}
			}

			public unsafe GUILabel label
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILabel>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_label)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUILabel));
				}
			}

			static ActionCategoryEntry()
			{
				Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, "ActionCategoryEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr);
				NativeFieldInfoPtr_actionCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr, "actionCategoryId");
				NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr, "label");
				NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr, 100675839);
				NativeMethodInfoPtr_SetLabel_Public_Void_GUILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr, 100675840);
				NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr, 100675841);
			}

			[CallerCount(0)]
			public unsafe ActionCategoryEntry(int actionCategoryId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionCategoryEntry>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&actionCategoryId);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLabel(GUILabel label)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLabel_Public_Void_GUILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353929, XrefRangeEnd = 353930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetActive(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&state);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public ActionCategoryEntry(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+InputGridEntryList+<GetActionSets>d__18")]
		public sealed class _GetActionSets_d__18 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;

			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			private static readonly System.IntPtr NativeFieldInfoPtr_mapCategoryId;

			private static readonly System.IntPtr NativeFieldInfoPtr___3__mapCategoryId;

			private static readonly System.IntPtr NativeFieldInfoPtr__list_5__2;

			private static readonly System.IntPtr NativeFieldInfoPtr__count_5__3;

			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_UI_ControlMapper_ControlMapper_InputActionSet__get_Current_Private_Virtual_Final_New_get_InputActionSet_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_UI_ControlMapper_ControlMapper_InputActionSet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputActionSet_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

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

			public unsafe InputActionSet __2__current
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionSet>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputActionSet));
				}
			}

			public unsafe int __l__initialThreadId
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId)) = num;
				}
			}

			public unsafe InputGridEntryList __4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputGridEntryList>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputGridEntryList));
				}
			}

			public unsafe int mapCategoryId
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapCategoryId);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapCategoryId)) = num;
				}
			}

			public unsafe int __3__mapCategoryId
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__mapCategoryId);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__mapCategoryId)) = num;
				}
			}

			public unsafe List<ActionEntry> _list_5__2
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__list_5__2);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ActionEntry>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__list_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
				}
			}

			public unsafe int _count_5__3
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count_5__3);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count_5__3)) = num;
				}
			}

			public unsafe int _i_5__4
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__4);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__4)) = num;
				}
			}

			public unsafe virtual InputActionSet System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EUI_002EControlMapper_002EControlMapper_002EInputActionSet_003E_002ECurrent
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_UI_ControlMapper_ControlMapper_InputActionSet__get_Current_Private_Virtual_Final_New_get_InputActionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputActionSet>(intPtr) : null;
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

			static _GetActionSets_d__18()
			{
				Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, "<GetActionSets>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr);
				NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<>1__state");
				NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<>2__current");
				NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<>l__initialThreadId");
				NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<>4__this");
				NativeFieldInfoPtr_mapCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "mapCategoryId");
				NativeFieldInfoPtr___3__mapCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<>3__mapCategoryId");
				NativeFieldInfoPtr__list_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<list>5__2");
				NativeFieldInfoPtr__count_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<count>5__3");
				NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, "<i>5__4");
				NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675842);
				NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675843);
				NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675844);
				NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_UI_ControlMapper_ControlMapper_InputActionSet__get_Current_Private_Virtual_Final_New_get_InputActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675845);
				NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675846);
				NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675847);
				NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_UI_ControlMapper_ControlMapper_InputActionSet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675848);
				NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr, 100675849);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetActionSets_d__18(int _003C_003E1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GetActionSets_d__18>.NativeClassPtr))
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353930, XrefRangeEnd = 353936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353936, XrefRangeEnd = 353942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353942, XrefRangeEnd = 353948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<InputActionSet> System_Collections_Generic_IEnumerable_Rewired_UI_ControlMapper_ControlMapper_InputActionSet__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_UI_ControlMapper_ControlMapper_InputActionSet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InputActionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<InputActionSet>>(intPtr) : null;
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
			}

			public _GetActionSets_d__18(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_entries;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddMapCategory_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddAction_Public_Void_Int32_InputAction_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionEntry_Private_ActionEntry_Int32_InputAction_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionLabel_Public_Void_Int32_Int32_AxisRange_GUILabel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionCategory_Public_Void_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionCategoryEntry_Private_ActionCategoryEntry_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddActionCategoryLabel_Public_Void_Int32_Int32_GUILabel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddInputFieldSet_Public_Void_Int32_InputAction_AxisRange_ControllerType_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddInputField_Public_Void_Int32_InputAction_AxisRange_ControllerType_Int32_GUIInputField_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetColumnHeight_Public_Void_Int32_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetColumnHeight_Public_Single_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_Int32_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionEntry_Private_ActionEntry_Int32_Int32_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionEntry_Private_ActionEntry_Int32_InputAction_AxisRange_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionSets_Public_IEnumerable_1_InputActionSet_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFieldsActive_Public_Void_Int32_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PopulateField_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_Int32_Int32_String_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFixedFieldData_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeFields_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HideAll_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClearLabels_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		public unsafe IndexedDictionary<int, MapCategoryEntry> entries
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entries);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedDictionary<int, MapCategoryEntry>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entries)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indexedDictionary));
			}
		}

		static InputGridEntryList()
		{
			Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "InputGridEntryList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr);
			NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, "entries");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675785);
			NativeMethodInfoPtr_AddMapCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675786);
			NativeMethodInfoPtr_AddAction_Public_Void_Int32_InputAction_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675787);
			NativeMethodInfoPtr_AddActionEntry_Private_ActionEntry_Int32_InputAction_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675788);
			NativeMethodInfoPtr_AddActionLabel_Public_Void_Int32_Int32_AxisRange_GUILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675789);
			NativeMethodInfoPtr_AddActionCategory_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675790);
			NativeMethodInfoPtr_AddActionCategoryEntry_Private_ActionCategoryEntry_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675791);
			NativeMethodInfoPtr_AddActionCategoryLabel_Public_Void_Int32_Int32_GUILabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675792);
			NativeMethodInfoPtr_AddInputFieldSet_Public_Void_Int32_InputAction_AxisRange_ControllerType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675793);
			NativeMethodInfoPtr_AddInputField_Public_Void_Int32_InputAction_AxisRange_ControllerType_Int32_GUIInputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675794);
			NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675795);
			NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675796);
			NativeMethodInfoPtr_SetColumnHeight_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675797);
			NativeMethodInfoPtr_GetColumnHeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675798);
			NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_Int32_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675799);
			NativeMethodInfoPtr_GetActionEntry_Private_ActionEntry_Int32_Int32_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675800);
			NativeMethodInfoPtr_GetActionEntry_Private_ActionEntry_Int32_InputAction_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675801);
			NativeMethodInfoPtr_GetActionSets_Public_IEnumerable_1_InputActionSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675802);
			NativeMethodInfoPtr_SetFieldsActive_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675803);
			NativeMethodInfoPtr_SetLabel_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675804);
			NativeMethodInfoPtr_PopulateField_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675805);
			NativeMethodInfoPtr_SetFixedFieldData_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675806);
			NativeMethodInfoPtr_InitializeFields_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675807);
			NativeMethodInfoPtr_Show_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675808);
			NativeMethodInfoPtr_HideAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675809);
			NativeMethodInfoPtr_ClearLabels_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675810);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr, 100675811);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353948, XrefRangeEnd = 353954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputGridEntryList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputGridEntryList>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353975, RefRangeEnd = 353977, XrefRangeStart = 353954, XrefRangeEnd = 353975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMapCategory(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMapCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353977, XrefRangeEnd = 353980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAction_Public_Void_Int32_InputAction_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353980, XrefRangeEnd = 353984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionEntry_Private_ActionEntry_Int32_InputAction_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionEntry>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353984, XrefRangeEnd = 353987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, GUILabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionLabel_Public_Void_Int32_Int32_AxisRange_GUILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353987, XrefRangeEnd = 354001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionCategory(int mapCategoryId, int actionCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionCategoryId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionCategory_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354001, XrefRangeEnd = 354015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionCategoryId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionCategoryEntry_Private_ActionCategoryEntry_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionCategoryEntry>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354015, XrefRangeEnd = 354023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, GUILabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionCategoryId;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionCategoryLabel_Public_Void_Int32_Int32_GUILabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354023, XrefRangeEnd = 354025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldSetContainer);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInputFieldSet_Public_Void_Int32_InputAction_AxisRange_ControllerType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354025, XrefRangeEnd = 354038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, GUIInputField inputField)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputField);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInputField_Public_Void_Int32_InputAction_AxisRange_ControllerType_Int32_GUIInputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354038, XrefRangeEnd = 354039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int mapCategoryId, int actionId, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354039, XrefRangeEnd = 354049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Boolean_Int32_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354049, XrefRangeEnd = 354051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumnHeight(int mapCategoryId, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&mapCategoryId);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColumnHeight_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354051, XrefRangeEnd = 354053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetColumnHeight(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColumnHeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354053, XrefRangeEnd = 354068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGUIInputField_Public_GUIInputField_Int32_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIInputField>(intPtr) : null;
		}

		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 354072, RefRangeEnd = 354092, XrefRangeStart = 354068, XrefRangeEnd = 354072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionEntry_Private_ActionEntry_Int32_Int32_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionEntry>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354092, XrefRangeEnd = 354093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&mapCategoryId);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionEntry_Private_ActionEntry_Int32_InputAction_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionEntry>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354093, XrefRangeEnd = 354097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<InputActionSet> GetActionSets(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionSets_Public_IEnumerable_1_InputActionSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InputActionSet>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354097, XrefRangeEnd = 354102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFieldsActive(int mapCategoryId, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&mapCategoryId);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFieldsActive_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354102, XrefRangeEnd = 354117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLabel_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354117, XrefRangeEnd = 354119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionElementMapId;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
			*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &invert;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateField_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_Int32_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354119, XrefRangeEnd = 354121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&mapCategoryId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
			*(AxisRange**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
			*(ControllerType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFixedFieldData_Public_Void_Int32_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354121, XrefRangeEnd = 354126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeFields(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeFields_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354126, XrefRangeEnd = 354129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354129, XrefRangeEnd = 354135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354135, XrefRangeEnd = 354140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLabels(int mapCategoryId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapCategoryId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearLabels_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354140, XrefRangeEnd = 354143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InputGridEntryList(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class WindowManager : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_windows;

		private static readonly System.IntPtr NativeFieldInfoPtr_windowPrefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_parent;

		private static readonly System.IntPtr NativeFieldInfoPtr_fader;

		private static readonly System.IntPtr NativeFieldInfoPtr_idCounter;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isWindowOpen_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_topWindow_Public_get_Window_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_GameObject_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OpenWindow_Public_Window_String_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OpenWindow_Public_Window_GameObject_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CloseTop_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CloseWindow_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CloseWindow_Public_Void_Window_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CloseAll_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CancelAll_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetWindow_Public_Window_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsFocused_Public_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Focus_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Focus_Public_Void_Window_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DefocusOtherWindows_Private_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFader_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FocusTopWindow_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFaderActive_Private_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateWindow_Private_Window_String_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateWindow_Private_Window_String_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWindow_Private_Void_Window_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetNewId_Private_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ClearCompletely_Public_Void_0;

		public unsafe List<Window> windows
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windows);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Window>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe GameObject windowPrefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowPrefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe Transform parent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe GameObject fader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fader);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe int idCounter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idCounter);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idCounter)) = num;
			}
		}

		public unsafe bool isWindowOpen
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 354156, RefRangeEnd = 354175, XrefRangeStart = 354143, XrefRangeEnd = 354156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isWindowOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe Window topWindow
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 354188, RefRangeEnd = 354196, XrefRangeStart = 354175, XrefRangeEnd = 354188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_topWindow_Public_get_Window_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
			}
		}

		static WindowManager()
		{
			Il2CppClassPointerStore<WindowManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "WindowManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowManager>.NativeClassPtr);
			NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, "windows");
			NativeFieldInfoPtr_windowPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, "windowPrefab");
			NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, "parent");
			NativeFieldInfoPtr_fader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, "fader");
			NativeFieldInfoPtr_idCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, "idCounter");
			NativeMethodInfoPtr_get_isWindowOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675850);
			NativeMethodInfoPtr_get_topWindow_Public_get_Window_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675851);
			NativeMethodInfoPtr__ctor_Public_Void_GameObject_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675852);
			NativeMethodInfoPtr_OpenWindow_Public_Window_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675853);
			NativeMethodInfoPtr_OpenWindow_Public_Window_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675854);
			NativeMethodInfoPtr_CloseTop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675855);
			NativeMethodInfoPtr_CloseWindow_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675856);
			NativeMethodInfoPtr_CloseWindow_Public_Void_Window_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675857);
			NativeMethodInfoPtr_CloseAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675858);
			NativeMethodInfoPtr_CancelAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675859);
			NativeMethodInfoPtr_GetWindow_Public_Window_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675860);
			NativeMethodInfoPtr_IsFocused_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675861);
			NativeMethodInfoPtr_Focus_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675862);
			NativeMethodInfoPtr_Focus_Public_Void_Window_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675863);
			NativeMethodInfoPtr_DefocusOtherWindows_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675864);
			NativeMethodInfoPtr_UpdateFader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675865);
			NativeMethodInfoPtr_FocusTopWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675866);
			NativeMethodInfoPtr_SetFaderActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675867);
			NativeMethodInfoPtr_InstantiateWindow_Private_Window_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675868);
			NativeMethodInfoPtr_InstantiateWindow_Private_Window_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675869);
			NativeMethodInfoPtr_DestroyWindow_Private_Void_Window_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675870);
			NativeMethodInfoPtr_GetNewId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675871);
			NativeMethodInfoPtr_ClearCompletely_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowManager>.NativeClassPtr, 100675872);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354221, RefRangeEnd = 354222, XrefRangeStart = 354196, XrefRangeEnd = 354221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowManager(GameObject windowPrefab, GameObject faderPrefab, Transform parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowManager>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowPrefab);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)faderPrefab);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_GameObject_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354222, XrefRangeEnd = 354224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Window OpenWindow(string name, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenWindow_Public_Window_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354224, XrefRangeEnd = 354239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Window OpenWindow(GameObject windowPrefab, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowPrefab);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenWindow_Public_Window_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354264, RefRangeEnd = 354265, XrefRangeStart = 354239, XrefRangeEnd = 354264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseTop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354265, XrefRangeEnd = 354267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseWindow(int windowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&windowId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseWindow_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 354321, RefRangeEnd = 354326, XrefRangeStart = 354267, XrefRangeEnd = 354321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseWindow(Window window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseWindow_Public_Void_Window_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354352, RefRangeEnd = 354355, XrefRangeStart = 354326, XrefRangeEnd = 354352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 354371, RefRangeEnd = 354376, XrefRangeStart = 354355, XrefRangeEnd = 354371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 354390, RefRangeEnd = 354403, XrefRangeStart = 354376, XrefRangeEnd = 354390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Window GetWindow(int windowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&windowId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWindow_Public_Window_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354403, XrefRangeEnd = 354416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFocused(int windowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&windowId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFocused_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354416, XrefRangeEnd = 354418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus(int windowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&windowId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Focus_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 354430, RefRangeEnd = 354445, XrefRangeStart = 354418, XrefRangeEnd = 354430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus(Window window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Focus_Public_Void_Window_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354460, RefRangeEnd = 354461, XrefRangeStart = 354445, XrefRangeEnd = 354460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefocusOtherWindows(int focusedWindowId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&focusedWindowId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefocusOtherWindows_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 354492, RefRangeEnd = 354500, XrefRangeStart = 354461, XrefRangeEnd = 354492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354500, XrefRangeEnd = 354513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusTopWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FocusTopWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354518, RefRangeEnd = 354519, XrefRangeStart = 354513, XrefRangeEnd = 354518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaderActive(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFaderActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354560, RefRangeEnd = 354563, XrefRangeStart = 354519, XrefRangeEnd = 354560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Window InstantiateWindow(string name, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantiateWindow_Private_Window_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354611, RefRangeEnd = 354613, XrefRangeStart = 354563, XrefRangeEnd = 354611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Window InstantiateWindow(string name, GameObject windowPrefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowPrefab);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantiateWindow_Private_Window_String_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354629, RefRangeEnd = 354632, XrefRangeStart = 354613, XrefRangeEnd = 354629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyWindow(Window window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyWindow_Private_Void_Window_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe int GetNewId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354632, XrefRangeEnd = 354647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCompletely()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCompletely_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WindowManager(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+<>c__DisplayClass341_0")]
	public sealed class __c__DisplayClass341_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_window;

		private static readonly System.IntPtr NativeFieldInfoPtr_controllerId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowControllerAssignmentConflictWindow_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowControllerAssignmentConflictWindow_b__1_Internal_Void_0;

		public unsafe ControlMapper __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlMapper));
			}
		}

		public unsafe Window window
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window));
			}
		}

		public unsafe int controllerId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controllerId)) = num;
			}
		}

		static __c__DisplayClass341_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "<>c__DisplayClass341_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr, "window");
			NativeFieldInfoPtr_controllerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr, "controllerId");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr, 100675873);
			NativeMethodInfoPtr__ShowControllerAssignmentConflictWindow_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr, 100675874);
			NativeMethodInfoPtr__ShowControllerAssignmentConflictWindow_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr, 100675875);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass341_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass341_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354647, XrefRangeEnd = 354648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowControllerAssignmentConflictWindow_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowControllerAssignmentConflictWindow_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354648, XrefRangeEnd = 354651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowControllerAssignmentConflictWindow_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowControllerAssignmentConflictWindow_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass341_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+<>c__DisplayClass342_0")]
	public sealed class __c__DisplayClass342_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_window;

		private static readonly System.IntPtr NativeFieldInfoPtr_fieldInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_map;

		private static readonly System.IntPtr NativeFieldInfoPtr_aem;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__1_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__2_Internal_Void_0;

		public unsafe ControlMapper __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlMapper));
			}
		}

		public unsafe Window window
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window));
			}
		}

		public unsafe InputFieldInfo fieldInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputFieldInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputFieldInfo));
			}
		}

		public unsafe ControllerMap map
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_map);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_map)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap));
			}
		}

		public unsafe ActionElementMap aem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionElementMap));
			}
		}

		public unsafe string actionName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass342_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "<>c__DisplayClass342_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, "window");
			NativeFieldInfoPtr_fieldInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, "fieldInfo");
			NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, "map");
			NativeFieldInfoPtr_aem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, "aem");
			NativeFieldInfoPtr_actionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, "actionName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, 100675876);
			NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, 100675877);
			NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, 100675878);
			NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr, 100675879);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass342_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass342_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowBeginElementAssignmentReplacementWindow_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354651, XrefRangeEnd = 354652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowBeginElementAssignmentReplacementWindow_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354652, XrefRangeEnd = 354653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowBeginElementAssignmentReplacementWindow_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowBeginElementAssignmentReplacementWindow_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass342_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+<>c__DisplayClass349_0")]
	public sealed class __c__DisplayClass349_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_window;

		private static readonly System.IntPtr NativeFieldInfoPtr_assignment;

		private static readonly System.IntPtr NativeFieldInfoPtr_skipOtherPlayers;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__1_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__2_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__3_Internal_Void_0;

		public unsafe ControlMapper __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlMapper));
			}
		}

		public unsafe Window window
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window));
			}
		}

		public unsafe ElementAssignment assignment
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignment);
				return *(ElementAssignment*)num;
			}
			set
			{
				*(ElementAssignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignment)) = elementAssignment;
			}
		}

		public unsafe bool skipOtherPlayers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipOtherPlayers);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipOtherPlayers)) = flag;
			}
		}

		static __c__DisplayClass349_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "<>c__DisplayClass349_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, "window");
			NativeFieldInfoPtr_assignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, "assignment");
			NativeFieldInfoPtr_skipOtherPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, "skipOtherPlayers");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, 100675880);
			NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, 100675881);
			NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, 100675882);
			NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, 100675883);
			NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr, 100675884);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass349_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass349_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowElementAssignmentConflictWindow_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354653, XrefRangeEnd = 354654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowElementAssignmentConflictWindow_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354654, XrefRangeEnd = 354657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowElementAssignmentConflictWindow_b__2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354657, XrefRangeEnd = 354658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowElementAssignmentConflictWindow_b__3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowElementAssignmentConflictWindow_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass349_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+<>c__DisplayClass350_0")]
	public sealed class __c__DisplayClass350_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_window;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowMouseAssignmentConflictWindow_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowMouseAssignmentConflictWindow_b__1_Internal_Void_0;

		public unsafe ControlMapper __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlMapper));
			}
		}

		public unsafe Window window
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window));
			}
		}

		static __c__DisplayClass350_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "<>c__DisplayClass350_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr, "window");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr, 100675885);
			NativeMethodInfoPtr__ShowMouseAssignmentConflictWindow_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr, 100675886);
			NativeMethodInfoPtr__ShowMouseAssignmentConflictWindow_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr, 100675887);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass350_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass350_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowMouseAssignmentConflictWindow_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowMouseAssignmentConflictWindow_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354658, XrefRangeEnd = 354661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowMouseAssignmentConflictWindow_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowMouseAssignmentConflictWindow_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass350_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+<>c__DisplayClass403_0")]
	public sealed class __c__DisplayClass403_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_window;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OpenModal_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OpenModal_b__1_Internal_Void_0;

		public unsafe ControlMapper __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlMapper));
			}
		}

		public unsafe Window window
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_window)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)window));
			}
		}

		static __c__DisplayClass403_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "<>c__DisplayClass403_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_window = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr, "window");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr, 100675888);
			NativeMethodInfoPtr__OpenModal_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr, 100675889);
			NativeMethodInfoPtr__OpenModal_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr, 100675890);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass403_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass403_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenModal_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OpenModal_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354661, XrefRangeEnd = 354663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenModal_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OpenModal_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass403_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+<ElementAssignmentConflicts>d__411")]
	public sealed class _ElementAssignmentConflicts_d__411 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;

		private static readonly System.IntPtr NativeFieldInfoPtr_player;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__player;

		private static readonly System.IntPtr NativeFieldInfoPtr_mapping;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__mapping;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_assignment;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__assignment;

		private static readonly System.IntPtr NativeFieldInfoPtr_skipOtherPlayers;

		private static readonly System.IntPtr NativeFieldInfoPtr___3__skipOtherPlayers;

		private static readonly System.IntPtr NativeFieldInfoPtr__conflictCheck_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

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

		public unsafe ElementAssignmentConflictInfo __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				return *(ElementAssignmentConflictInfo*)num;
			}
			set
			{
				*(ElementAssignmentConflictInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)) = elementAssignmentConflictInfo;
			}
		}

		public unsafe int __l__initialThreadId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___l__initialThreadId)) = num;
			}
		}

		public unsafe Player player
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player));
			}
		}

		public unsafe Player __3__player
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__player);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__player)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player));
			}
		}

		public unsafe InputMapping mapping
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapping);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputMapping>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapping)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputMapping));
			}
		}

		public unsafe InputMapping __3__mapping
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__mapping);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputMapping>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__mapping)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputMapping));
			}
		}

		public unsafe ControlMapper __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlMapper));
			}
		}

		public unsafe ElementAssignment assignment
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignment);
				return *(ElementAssignment*)num;
			}
			set
			{
				*(ElementAssignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignment)) = elementAssignment;
			}
		}

		public unsafe ElementAssignment __3__assignment
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__assignment);
				return *(ElementAssignment*)num;
			}
			set
			{
				*(ElementAssignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__assignment)) = elementAssignment;
			}
		}

		public unsafe bool skipOtherPlayers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipOtherPlayers);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipOtherPlayers)) = flag;
			}
		}

		public unsafe bool __3__skipOtherPlayers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__skipOtherPlayers);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___3__skipOtherPlayers)) = flag;
			}
		}

		public unsafe ElementAssignmentConflictCheck _conflictCheck_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__conflictCheck_5__2);
				return *(ElementAssignmentConflictCheck*)num;
			}
			set
			{
				*(ElementAssignmentConflictCheck*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__conflictCheck_5__2)) = elementAssignmentConflictCheck;
			}
		}

		public unsafe IEnumerator<ElementAssignmentConflictInfo> __7__wrap2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumerator));
			}
		}

		public unsafe virtual ElementAssignmentConflictInfo System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EElementAssignmentConflictInfo_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(ElementAssignmentConflictInfo*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354745, XrefRangeEnd = 354748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		static _ElementAssignmentConflicts_d__411()
		{
			Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "<ElementAssignmentConflicts>d__411");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>l__initialThreadId");
			NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "player");
			NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>3__player");
			NativeFieldInfoPtr_mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "mapping");
			NativeFieldInfoPtr___3__mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>3__mapping");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_assignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "assignment");
			NativeFieldInfoPtr___3__assignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>3__assignment");
			NativeFieldInfoPtr_skipOtherPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "skipOtherPlayers");
			NativeFieldInfoPtr___3__skipOtherPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>3__skipOtherPlayers");
			NativeFieldInfoPtr__conflictCheck_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<conflictCheck>5__2");
			NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, "<>7__wrap2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675891);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675892);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675893);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675894);
			NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675895);
			NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675896);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_ElementAssignmentConflictInfo__get_Current_Private_Virtual_Final_New_get_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675897);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675898);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675899);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675900);
			NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr, 100675901);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354663, XrefRangeEnd = 354664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ElementAssignmentConflicts_d__411(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ElementAssignmentConflicts_d__411>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354664, XrefRangeEnd = 354673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354673, XrefRangeEnd = 354730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354730, XrefRangeEnd = 354733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354733, XrefRangeEnd = 354736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354736, XrefRangeEnd = 354739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354739, XrefRangeEnd = 354745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354748, XrefRangeEnd = 354754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<ElementAssignmentConflictInfo> System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_ElementAssignmentConflictInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<ElementAssignmentConflictInfo>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
		}

		public _ElementAssignmentConflicts_d__411(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.UI.ControlMapper.ControlMapper+<>c__DisplayClass456_0")]
	public sealed class __c__DisplayClass456_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_aem;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ShowSwapButton_b__0_Internal_Boolean_ElementAssignmentConflictInfo_0;

		public unsafe ActionElementMap aem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionElementMap>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionElementMap));
			}
		}

		static __c__DisplayClass456_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass456_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "<>c__DisplayClass456_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass456_0>.NativeClassPtr);
			NativeFieldInfoPtr_aem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass456_0>.NativeClassPtr, "aem");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass456_0>.NativeClassPtr, 100675902);
			NativeMethodInfoPtr__ShowSwapButton_b__0_Internal_Boolean_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass456_0>.NativeClassPtr, 100675903);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass456_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass456_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ShowSwapButton_b__0(ElementAssignmentConflictInfo x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ShowSwapButton_b__0_Internal_Boolean_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass456_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CountIEnumerable_Private_Int32_IEnumerable_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CountIEnumerable_Private_Int32_IEnumerable_1_T_0, Il2CppClassPointerStore<ControlMapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_versionMajor;

	private static readonly System.IntPtr NativeFieldInfoPtr_versionMinor;

	private static readonly System.IntPtr NativeFieldInfoPtr_usesTMPro;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockInputOnFocusTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_playerSelection;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_removeController;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_assignController;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_calibrateController;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_editInputBehaviors;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_mapCategorySelection;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_assignedControllerSelection;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_done;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonIdentifier_restoreDefaults;

	private static readonly System.IntPtr NativeFieldInfoPtr__rewiredInputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__dontDestroyOnLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr__openOnStart;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboardMapDefaultLayout;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseMapDefaultLayout;

	private static readonly System.IntPtr NativeFieldInfoPtr__joystickMapDefaultLayout;

	private static readonly System.IntPtr NativeFieldInfoPtr__mappingSets;

	private static readonly System.IntPtr NativeFieldInfoPtr__showPlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr__showControllers;

	private static readonly System.IntPtr NativeFieldInfoPtr__showKeyboard;

	private static readonly System.IntPtr NativeFieldInfoPtr__showMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxControllersPerPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr__showActionCategoryLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboardInputFieldCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseInputFieldCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerInputFieldCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__showFullAxisInputFields;

	private static readonly System.IntPtr NativeFieldInfoPtr__showSplitAxisInputFields;

	private static readonly System.IntPtr NativeFieldInfoPtr__allowElementAssignmentConflicts;

	private static readonly System.IntPtr NativeFieldInfoPtr__allowElementAssignmentSwap;

	private static readonly System.IntPtr NativeFieldInfoPtr__actionLabelWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboardColMaxWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr__mouseColMaxWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerColMaxWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputRowHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputRowPadding;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputRowFieldSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputColumnSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputRowCategorySpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr__invertToggleWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultWindowWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultWindowHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr__controllerAssignmentTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr__preInputAssignmentTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputAssignmentTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr__axisCalibrationTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr__ignoreMouseXAxisAssignment;

	private static readonly System.IntPtr NativeFieldInfoPtr__ignoreMouseYAxisAssignment;

	private static readonly System.IntPtr NativeFieldInfoPtr__screenToggleAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__screenOpenAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__screenCloseAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__universalCancelAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__universalCancelClosesScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr__showInputBehaviorSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputBehaviorSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__useThemeSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__themeSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__language;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefabs;

	private static readonly System.IntPtr NativeFieldInfoPtr_references;

	private static readonly System.IntPtr NativeFieldInfoPtr__showPlayersGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__showControllerGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__showAssignedControllersGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__showSettingsGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__showMapCategoriesGroupLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__showControllerNameLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr__showAssignedControllers;

	private static readonly System.IntPtr NativeFieldInfoPtr__ScreenClosedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__ScreenOpenedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__PopupWindowOpenedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__PopupWindowClosedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__InputPollingStartedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__InputPollingEndedEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__onScreenClosed;

	private static readonly System.IntPtr NativeFieldInfoPtr__onScreenOpened;

	private static readonly System.IntPtr NativeFieldInfoPtr__onPopupWindowClosed;

	private static readonly System.IntPtr NativeFieldInfoPtr__onPopupWindowOpened;

	private static readonly System.IntPtr NativeFieldInfoPtr__onInputPollingStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr__onInputPollingEnded;

	private static readonly System.IntPtr NativeFieldInfoPtr_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputGrid;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPlayerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMapCategoryId;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapCategoryButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignedControllerButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignedControllerButtonsPlaceholder;

	private static readonly System.IntPtr NativeFieldInfoPtr_miscInstantiatedObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUISelection;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentJoystickId;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockInputOnFocusEndTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPollingForInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_pendingInputMapping;

	private static readonly System.IntPtr NativeFieldInfoPtr_pendingAxisCalibration;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFieldActivatedDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFieldInvertToggleStateChangedDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr__restoreDefaultsDelegate;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_ScreenClosedEvent_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_ScreenClosedEvent_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_ScreenOpenedEvent_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_ScreenOpenedEvent_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_PopupWindowClosedEvent_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_PopupWindowClosedEvent_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_PopupWindowOpenedEvent_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_PopupWindowOpenedEvent_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_InputPollingStartedEvent_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_InputPollingStartedEvent_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_InputPollingEndedEvent_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_InputPollingEndedEvent_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onScreenClosed_Public_add_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onScreenClosed_Public_rem_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onScreenOpened_Public_add_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onScreenOpened_Public_rem_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onPopupWindowClosed_Public_add_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onPopupWindowClosed_Public_rem_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onPopupWindowOpened_Public_add_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onPopupWindowOpened_Public_rem_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onInputPollingStarted_Public_add_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onInputPollingStarted_Public_rem_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onInputPollingEnded_Public_add_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onInputPollingEnded_Public_rem_Void_UnityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rewiredInputManager_Public_get_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rewiredInputManager_Public_set_Void_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dontDestroyOnLoad_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dontDestroyOnLoad_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardMapDefaultLayout_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_keyboardMapDefaultLayout_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseMapDefaultLayout_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mouseMapDefaultLayout_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickMapDefaultLayout_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_joystickMapDefaultLayout_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showPlayers_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showPlayers_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showControllers_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showControllers_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showKeyboard_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showKeyboard_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showMouse_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showMouse_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxControllersPerPlayer_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxControllersPerPlayer_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showActionCategoryLabels_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showActionCategoryLabels_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardInputFieldCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_keyboardInputFieldCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseInputFieldCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mouseInputFieldCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerInputFieldCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerInputFieldCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showFullAxisInputFields_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showFullAxisInputFields_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showSplitAxisInputFields_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showSplitAxisInputFields_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowElementAssignmentConflicts_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowElementAssignmentConflicts_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowElementAssignmentSwap_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowElementAssignmentSwap_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_actionLabelWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_actionLabelWidth_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardColMaxWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_keyboardColMaxWidth_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mouseColMaxWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mouseColMaxWidth_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerColMaxWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerColMaxWidth_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputRowHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inputRowHeight_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputColumnSpacing_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inputColumnSpacing_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputRowCategorySpacing_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inputRowCategorySpacing_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_invertToggleWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_invertToggleWidth_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultWindowWidth_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultWindowWidth_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultWindowHeight_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultWindowHeight_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerAssignmentTimeout_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerAssignmentTimeout_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_preInputAssignmentTimeout_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_preInputAssignmentTimeout_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputAssignmentTimeout_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inputAssignmentTimeout_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_axisCalibrationTimeout_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_axisCalibrationTimeout_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ignoreMouseXAxisAssignment_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ignoreMouseXAxisAssignment_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ignoreMouseYAxisAssignment_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ignoreMouseYAxisAssignment_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_universalCancelClosesScreen_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_universalCancelClosesScreen_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showInputBehaviorSettings_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showInputBehaviorSettings_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useThemeSettings_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useThemeSettings_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_language_Public_get_LanguageDataBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_language_Public_set_Void_LanguageDataBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showPlayersGroupLabel_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showPlayersGroupLabel_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showControllerGroupLabel_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showControllerGroupLabel_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showAssignedControllersGroupLabel_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showAssignedControllersGroupLabel_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showSettingsGroupLabel_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showSettingsGroupLabel_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showMapCategoriesGroupLabel_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showMapCategoriesGroupLabel_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showControllerNameLabel_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showControllerNameLabel_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showAssignedControllers_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showAssignedControllers_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_restoreDefaultsDelegate_Public_get_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_restoreDefaultsDelegate_Public_set_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isFocused_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputAllowed_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridColumnCount_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inputGridWidth_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentPlayer_Private_get_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentMapCategory_Private_get_InputCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentMappingSet_Private_get_MappingSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentJoystick_Private_get_Joystick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isJoystickSelected_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentUISelection_Private_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showSettings_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showMapCategories_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreInitialize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnJoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnJoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnJoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInputFieldActivated_Public_Void_InputFieldInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInputFieldInvertToggleStateChanged_Public_Void_ToggleInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayerSelected_Private_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerSelected_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoveCurrentController_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMapCategorySelected_Private_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRestoreDefaults_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnScreenToggleActionPressed_Private_Void_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnScreenOpenActionPressed_Private_Void_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnScreenCloseActionPressed_Private_Void_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUniversalCancelActionPressed_Private_Void_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWindowCancel_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoveElementAssignment_Private_Void_Int32_ControllerMap_ActionElementMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginElementAssignment_Private_Void_InputFieldInfo_ControllerMap_ActionElementMap_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerAssignmentConfirmed_Private_Void_Int32_Player_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMouseAssignmentConfirmed_Private_Void_Int32_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnElementAssignmentConflictReplaceConfirmed_Private_Void_Int32_InputMapping_ElementAssignment_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnElementAssignmentAddConfirmed_Private_Void_Int32_InputMapping_ElementAssignment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRestoreDefaultsConfirmed_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAssignControllerWindowUpdate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnElementAssignmentPrePollingWindowUpdate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnJoystickElementAssignmentPollingWindowUpdate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnKeyboardElementAssignmentPollingWindowUpdate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMouseElementAssignmentPollingWindowUpdate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCalibrateAxisStep1WindowUpdate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCalibrateAxisStep2WindowUpdate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowAssignControllerWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowControllerAssignmentConflictWindow_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowBeginElementAssignmentReplacementWindow_Private_Void_InputFieldInfo_InputAction_ControllerMap_ActionElementMap_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowCreateNewElementAssignmentWindow_Private_Void_InputFieldInfo_InputAction_ControllerMap_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowElementAssignmentPrePollingWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowElementAssignmentPollingWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowJoystickElementAssignmentPollingWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowKeyboardElementAssignmentPollingWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMouseElementAssignmentPollingWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowElementAssignmentConflictWindow_Private_Void_ElementAssignment_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMouseAssignmentConflictWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowCalibrateControllerWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowCalibrateAxisStep1Window_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowCalibrateAxisStep2Window_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowEditInputBehaviorsWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowRestoreDefaultsWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputGrid_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInputGrid_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshInputGridStructure_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHeaderLabels_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateActionLabelColumn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateKeyboardInputFieldColumn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMouseInputFieldColumn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateControllerInputFieldColumn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputFieldColumn_Private_Void_String_ControllerType_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputActionLabels_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputFields_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputFields_Private_Void_Transform_ControllerType_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputFieldSet_Private_Void_Transform_Int32_InputAction_AxisRange_ControllerType_Int32_Int32_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateInputFields_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateInputFieldGroup_Private_Void_InputActionSet_ControllerMap_ControllerType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableInputFieldGroup_Private_Void_InputActionSet_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetInputGridScrollBar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLayout_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPlayersGroup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawControllersGroup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawSettingsGroup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawMapCategoriesGroup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWindowButtonsGroup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Redraw_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RedrawPlayerGroup_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RedrawControllerGroup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RedrawMapCategoriesGroup_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RedrawInputGrid_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceRefresh_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputCategoryRow_Private_Void_byref_Int32_InputCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLabel_Private_GUILabel_String_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLabel_Private_GUILabel_GameObject_String_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateButton_Private_GUIButton_String_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFitButton_Private_GUIButton_String_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputField_Private_GUIInputField_Transform_Vector2_String_Int32_AxisRange_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputField_Private_GUIInputField_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateToggle_Private_GUIToggle_GameObject_Transform_Vector2_String_Int32_AxisRange_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateToggle_Private_GUIToggle_GameObject_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Private_GameObject_GameObject_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewGUIObject_Private_GameObject_String_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeNewGUIGameObject_Private_GameObject_GameObject_Transform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewColumnGroup_Private_GameObject_String_Transform_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenWindow_Private_Window_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenWindow_Private_Window_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenWindow_Private_Window_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenWindow_Private_Window_GameObject_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenModal_Private_Void_String_String_String_Action_1_Int32_String_Action_1_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseWindow_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseTopWindow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseAllWindows_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChildWindowOpened_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChildWindowClosed_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasElementAssignmentConflicts_Private_Boolean_Player_InputMapping_ElementAssignment_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBlockingAssignmentConflict_Private_Boolean_InputMapping_ElementAssignment_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ElementAssignmentConflicts_Private_IEnumerable_1_ElementAssignmentConflictInfo_Player_InputMapping_ElementAssignment_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateConflictCheck_Private_Boolean_InputMapping_ElementAssignment_byref_ElementAssignmentConflictCheck_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PollKeyboardForAssignment_Private_Void_byref_ControllerPollingInfo_byref_Boolean_byref_ModifierKeyFlags_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstElementAssignmentConflict_Private_Boolean_ElementAssignmentConflictCheck_byref_ElementAssignmentConflictInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstElementAssignmentConflict_Private_Boolean_Player_ElementAssignmentConflictCheck_byref_ElementAssignmentConflictInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartAxisCalibration_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndAxisCalibration_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreLastUISelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultUISelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectDefaultMapCategory_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckUISelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUIElementSelected_Private_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIsFocused_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCompletely_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSpawnedObjects_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearVarsOnPlayerChange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearVarsOnJoystickChange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllVars_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActionAxisInverted_Private_Void_Boolean_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMap_Private_ControllerMap_ControllerType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapOrCreateNew_Private_ControllerMap_ControllerType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountIEnumerable_Private_Int32_IEnumerable_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultMapCategoryId_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubscribeFixedUISelectionEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubscribeMenuControlInputEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsubscribeMenuControlInputEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubscribeRewiredInputEventAllPlayers_Private_Void_Int32_Action_1_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsubscribeRewiredInputEventAllPlayers_Private_Void_Int32_Action_1_InputActionEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxControllersPerPlayer_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowAssignedControllers_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InspectorPropertyChanged_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignController_Private_Void_Player_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllControllers_Private_Void_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveController_Private_Void_Player_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAllowedAssignment_Private_Boolean_InputMapping_ControllerPollingInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InputPollingStarted_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InputPollingStopped_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerInputFieldCount_Private_Int32_ControllerType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowSwapButton_Private_Boolean_Int32_InputMapping_ElementAssignment_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapIsSameInputRange_Private_Boolean_ControllerElementType_AxisRange_Pole_ControllerElementType_AxisRange_Pole_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTheme_Public_Static_Void_Il2CppReferenceArray_1_ElementInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLanguage_Public_Static_LanguageDataBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int versionMajor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_versionMajor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_versionMajor, (void*)(&num));
		}
	}

	public unsafe static int versionMinor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_versionMinor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_versionMinor, (void*)(&num));
		}
	}

	public unsafe static bool usesTMPro
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_usesTMPro, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_usesTMPro, (void*)(&flag));
		}
	}

	public unsafe static float blockInputOnFocusTimeout
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blockInputOnFocusTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blockInputOnFocusTimeout, (void*)(&num));
		}
	}

	public unsafe static string buttonIdentifier_playerSelection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_playerSelection, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_playerSelection, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_removeController
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_removeController, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_removeController, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_assignController
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_assignController, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_assignController, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_calibrateController
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_calibrateController, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_calibrateController, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_editInputBehaviors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_editInputBehaviors, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_editInputBehaviors, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_mapCategorySelection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_mapCategorySelection, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_mapCategorySelection, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_assignedControllerSelection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_assignedControllerSelection, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_assignedControllerSelection, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_done
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_done, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_done, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buttonIdentifier_restoreDefaults
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buttonIdentifier_restoreDefaults, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buttonIdentifier_restoreDefaults, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe InputManager _rewiredInputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rewiredInputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rewiredInputManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputManager));
		}
	}

	public unsafe bool _dontDestroyOnLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dontDestroyOnLoad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__dontDestroyOnLoad)) = flag;
		}
	}

	public unsafe bool _openOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__openOnStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__openOnStart)) = flag;
		}
	}

	public unsafe int _keyboardMapDefaultLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardMapDefaultLayout);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardMapDefaultLayout)) = num;
		}
	}

	public unsafe int _mouseMapDefaultLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseMapDefaultLayout);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseMapDefaultLayout)) = num;
		}
	}

	public unsafe int _joystickMapDefaultLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickMapDefaultLayout);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__joystickMapDefaultLayout)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<MappingSet> _mappingSets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mappingSets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MappingSet>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mappingSets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool _showPlayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showPlayers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showPlayers)) = flag;
		}
	}

	public unsafe bool _showControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showControllers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showControllers)) = flag;
		}
	}

	public unsafe bool _showKeyboard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showKeyboard);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showKeyboard)) = flag;
		}
	}

	public unsafe bool _showMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMouse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMouse)) = flag;
		}
	}

	public unsafe int _maxControllersPerPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxControllersPerPlayer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxControllersPerPlayer)) = num;
		}
	}

	public unsafe bool _showActionCategoryLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showActionCategoryLabels);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showActionCategoryLabels)) = flag;
		}
	}

	public unsafe int _keyboardInputFieldCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardInputFieldCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardInputFieldCount)) = num;
		}
	}

	public unsafe int _mouseInputFieldCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseInputFieldCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseInputFieldCount)) = num;
		}
	}

	public unsafe int _controllerInputFieldCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerInputFieldCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerInputFieldCount)) = num;
		}
	}

	public unsafe bool _showFullAxisInputFields
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showFullAxisInputFields);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showFullAxisInputFields)) = flag;
		}
	}

	public unsafe bool _showSplitAxisInputFields
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSplitAxisInputFields);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSplitAxisInputFields)) = flag;
		}
	}

	public unsafe bool _allowElementAssignmentConflicts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowElementAssignmentConflicts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowElementAssignmentConflicts)) = flag;
		}
	}

	public unsafe bool _allowElementAssignmentSwap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowElementAssignmentSwap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowElementAssignmentSwap)) = flag;
		}
	}

	public unsafe int _actionLabelWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionLabelWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionLabelWidth)) = num;
		}
	}

	public unsafe int _keyboardColMaxWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardColMaxWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardColMaxWidth)) = num;
		}
	}

	public unsafe int _mouseColMaxWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseColMaxWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseColMaxWidth)) = num;
		}
	}

	public unsafe int _controllerColMaxWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerColMaxWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerColMaxWidth)) = num;
		}
	}

	public unsafe int _inputRowHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowHeight)) = num;
		}
	}

	public unsafe RectOffset _inputRowPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowPadding);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowPadding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectOffset));
		}
	}

	public unsafe int _inputRowFieldSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowFieldSpacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowFieldSpacing)) = num;
		}
	}

	public unsafe int _inputColumnSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputColumnSpacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputColumnSpacing)) = num;
		}
	}

	public unsafe int _inputRowCategorySpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowCategorySpacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputRowCategorySpacing)) = num;
		}
	}

	public unsafe int _invertToggleWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertToggleWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertToggleWidth)) = num;
		}
	}

	public unsafe int _defaultWindowWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultWindowWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultWindowWidth)) = num;
		}
	}

	public unsafe int _defaultWindowHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultWindowHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__defaultWindowHeight)) = num;
		}
	}

	public unsafe float _controllerAssignmentTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerAssignmentTimeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerAssignmentTimeout)) = num;
		}
	}

	public unsafe float _preInputAssignmentTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preInputAssignmentTimeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preInputAssignmentTimeout)) = num;
		}
	}

	public unsafe float _inputAssignmentTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputAssignmentTimeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputAssignmentTimeout)) = num;
		}
	}

	public unsafe float _axisCalibrationTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisCalibrationTimeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisCalibrationTimeout)) = num;
		}
	}

	public unsafe bool _ignoreMouseXAxisAssignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignoreMouseXAxisAssignment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignoreMouseXAxisAssignment)) = flag;
		}
	}

	public unsafe bool _ignoreMouseYAxisAssignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignoreMouseYAxisAssignment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignoreMouseYAxisAssignment)) = flag;
		}
	}

	public unsafe int _screenToggleAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenToggleAction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenToggleAction)) = num;
		}
	}

	public unsafe int _screenOpenAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenOpenAction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenOpenAction)) = num;
		}
	}

	public unsafe int _screenCloseAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenCloseAction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenCloseAction)) = num;
		}
	}

	public unsafe int _universalCancelAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__universalCancelAction);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__universalCancelAction)) = num;
		}
	}

	public unsafe bool _universalCancelClosesScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__universalCancelClosesScreen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__universalCancelClosesScreen)) = flag;
		}
	}

	public unsafe bool _showInputBehaviorSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showInputBehaviorSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showInputBehaviorSettings)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<InputBehaviorSettings> _inputBehaviorSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InputBehaviorSettings>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputBehaviorSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool _useThemeSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useThemeSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useThemeSettings)) = flag;
		}
	}

	public unsafe ThemeSettings _themeSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__themeSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ThemeSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__themeSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)themeSettings));
		}
	}

	public unsafe LanguageDataBase _language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__language);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LanguageDataBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__language)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)languageDataBase));
		}
	}

	public unsafe Prefabs prefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Prefabs>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefabs));
		}
	}

	public unsafe References references
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_references);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<References>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_references)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)references));
		}
	}

	public unsafe bool _showPlayersGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showPlayersGroupLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showPlayersGroupLabel)) = flag;
		}
	}

	public unsafe bool _showControllerGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showControllerGroupLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showControllerGroupLabel)) = flag;
		}
	}

	public unsafe bool _showAssignedControllersGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showAssignedControllersGroupLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showAssignedControllersGroupLabel)) = flag;
		}
	}

	public unsafe bool _showSettingsGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSettingsGroupLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSettingsGroupLabel)) = flag;
		}
	}

	public unsafe bool _showMapCategoriesGroupLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMapCategoriesGroupLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMapCategoriesGroupLabel)) = flag;
		}
	}

	public unsafe bool _showControllerNameLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showControllerNameLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showControllerNameLabel)) = flag;
		}
	}

	public unsafe bool _showAssignedControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showAssignedControllers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showAssignedControllers)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action _ScreenClosedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScreenClosedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScreenClosedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action _ScreenOpenedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScreenOpenedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScreenOpenedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action _PopupWindowOpenedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PopupWindowOpenedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PopupWindowOpenedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action _PopupWindowClosedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PopupWindowClosedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PopupWindowClosedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action _InputPollingStartedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InputPollingStartedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InputPollingStartedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action _InputPollingEndedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InputPollingEndedEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InputPollingEndedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe UnityEvent _onScreenClosed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onScreenClosed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onScreenClosed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent _onScreenOpened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onScreenOpened);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onScreenOpened)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent _onPopupWindowClosed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onPopupWindowClosed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onPopupWindowClosed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent _onPopupWindowOpened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onPopupWindowOpened);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onPopupWindowOpened)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent _onInputPollingStarted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onInputPollingStarted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onInputPollingStarted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent _onInputPollingEnded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onInputPollingEnded);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__onInputPollingEnded)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe static ControlMapper Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlMapper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlMapper));
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

	public unsafe int playerCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCount)) = num;
		}
	}

	public unsafe InputGrid inputGrid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputGrid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputGrid>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputGrid)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputGrid));
		}
	}

	public unsafe WindowManager windowManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WindowManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowManager));
		}
	}

	public unsafe int currentPlayerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlayerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlayerId)) = num;
		}
	}

	public unsafe int currentMapCategoryId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMapCategoryId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMapCategoryId)) = num;
		}
	}

	public unsafe List<GUIButton> playerButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GUIButton>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerButtons)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GUIButton> mapCategoryButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapCategoryButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GUIButton>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapCategoryButtons)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GUIButton> assignedControllerButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignedControllerButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GUIButton>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignedControllerButtons)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GUIButton assignedControllerButtonsPlaceholder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignedControllerButtonsPlaceholder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIButton>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignedControllerButtonsPlaceholder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIButton));
		}
	}

	public unsafe List<GameObject> miscInstantiatedObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscInstantiatedObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscInstantiatedObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject canvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject lastUISelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUISelection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUISelection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe int currentJoystickId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentJoystickId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentJoystickId)) = num;
		}
	}

	public unsafe float blockInputOnFocusEndTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockInputOnFocusEndTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockInputOnFocusEndTime)) = num;
		}
	}

	public unsafe bool isPollingForInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPollingForInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPollingForInput)) = flag;
		}
	}

	public unsafe InputMapping pendingInputMapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingInputMapping);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputMapping>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingInputMapping)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputMapping));
		}
	}

	public unsafe AxisCalibrator pendingAxisCalibration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingAxisCalibration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AxisCalibrator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingAxisCalibration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axisCalibrator));
		}
	}

	public unsafe Il2CppSystem.Action<InputFieldInfo> inputFieldActivatedDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldActivatedDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputFieldInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldActivatedDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<ToggleInfo, bool> inputFieldInvertToggleStateChangedDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldInvertToggleStateChangedDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ToggleInfo, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldInvertToggleStateChangedDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action _restoreDefaultsDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__restoreDefaultsDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe InputManager rewiredInputManager
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rewiredInputManager_Public_get_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354838, XrefRangeEnd = 354844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rewiredInputManager_Public_set_Void_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool dontDestroyOnLoad
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dontDestroyOnLoad_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354844, XrefRangeEnd = 354853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dontDestroyOnLoad_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int keyboardMapDefaultLayout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyboardMapDefaultLayout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354853, XrefRangeEnd = 354859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keyboardMapDefaultLayout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int mouseMapDefaultLayout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseMapDefaultLayout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354859, XrefRangeEnd = 354865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mouseMapDefaultLayout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int joystickMapDefaultLayout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickMapDefaultLayout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354865, XrefRangeEnd = 354871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_joystickMapDefaultLayout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showPlayers
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354872, RefRangeEnd = 354875, XrefRangeStart = 354871, XrefRangeEnd = 354872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showPlayers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354875, XrefRangeEnd = 354881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showPlayers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showControllers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showControllers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354881, XrefRangeEnd = 354887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showControllers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showKeyboard
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showKeyboard_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354887, XrefRangeEnd = 354893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showKeyboard_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showMouse
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showMouse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354893, XrefRangeEnd = 354899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showMouse_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int maxControllersPerPlayer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxControllersPerPlayer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354899, XrefRangeEnd = 354905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxControllersPerPlayer_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showActionCategoryLabels
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showActionCategoryLabels_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354905, XrefRangeEnd = 354911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showActionCategoryLabels_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int keyboardInputFieldCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyboardInputFieldCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354911, XrefRangeEnd = 354917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keyboardInputFieldCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int mouseInputFieldCount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354917, RefRangeEnd = 354920, XrefRangeStart = 354917, XrefRangeEnd = 354917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseInputFieldCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354920, XrefRangeEnd = 354926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mouseInputFieldCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int controllerInputFieldCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerInputFieldCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354926, XrefRangeEnd = 354932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerInputFieldCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showFullAxisInputFields
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showFullAxisInputFields_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354932, XrefRangeEnd = 354938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showFullAxisInputFields_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showSplitAxisInputFields
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showSplitAxisInputFields_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354938, XrefRangeEnd = 354944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showSplitAxisInputFields_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool allowElementAssignmentConflicts
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowElementAssignmentConflicts_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowElementAssignmentConflicts_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool allowElementAssignmentSwap
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowElementAssignmentSwap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowElementAssignmentSwap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int actionLabelWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionLabelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354944, XrefRangeEnd = 354950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionLabelWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int keyboardColMaxWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyboardColMaxWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354950, XrefRangeEnd = 354956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keyboardColMaxWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int mouseColMaxWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseColMaxWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354956, XrefRangeEnd = 354962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mouseColMaxWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int controllerColMaxWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerColMaxWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354962, XrefRangeEnd = 354968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerColMaxWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int inputRowHeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputRowHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354968, XrefRangeEnd = 354974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputRowHeight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int inputColumnSpacing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputColumnSpacing_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354974, XrefRangeEnd = 354980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputColumnSpacing_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int inputRowCategorySpacing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputRowCategorySpacing_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354980, XrefRangeEnd = 354986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputRowCategorySpacing_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int invertToggleWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_invertToggleWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354986, XrefRangeEnd = 354992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_invertToggleWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int defaultWindowWidth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultWindowWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354992, XrefRangeEnd = 354998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultWindowWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int defaultWindowHeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultWindowHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354998, XrefRangeEnd = 355004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_defaultWindowHeight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float controllerAssignmentTimeout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerAssignmentTimeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerAssignmentTimeout_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float preInputAssignmentTimeout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_preInputAssignmentTimeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_preInputAssignmentTimeout_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float inputAssignmentTimeout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputAssignmentTimeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputAssignmentTimeout_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float axisCalibrationTimeout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_axisCalibrationTimeout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_axisCalibrationTimeout_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool ignoreMouseXAxisAssignment
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ignoreMouseXAxisAssignment_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ignoreMouseXAxisAssignment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool ignoreMouseYAxisAssignment
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ignoreMouseYAxisAssignment_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ignoreMouseYAxisAssignment_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool universalCancelClosesScreen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_universalCancelClosesScreen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_universalCancelClosesScreen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showInputBehaviorSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showInputBehaviorSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355004, XrefRangeEnd = 355010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showInputBehaviorSettings_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool useThemeSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useThemeSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355010, XrefRangeEnd = 355016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useThemeSettings_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe LanguageDataBase language
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_language_Public_get_LanguageDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LanguageDataBase>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355016, XrefRangeEnd = 355033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_language_Public_set_Void_LanguageDataBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showPlayersGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showPlayersGroupLabel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355033, XrefRangeEnd = 355039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showPlayersGroupLabel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showControllerGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showControllerGroupLabel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355039, XrefRangeEnd = 355045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showControllerGroupLabel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showAssignedControllersGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showAssignedControllersGroupLabel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355045, XrefRangeEnd = 355051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showAssignedControllersGroupLabel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showSettingsGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showSettingsGroupLabel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355051, XrefRangeEnd = 355057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showSettingsGroupLabel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showMapCategoriesGroupLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showMapCategoriesGroupLabel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355057, XrefRangeEnd = 355063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showMapCategoriesGroupLabel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showControllerNameLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showControllerNameLabel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355063, XrefRangeEnd = 355069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showControllerNameLabel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool showAssignedControllers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showAssignedControllers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355069, XrefRangeEnd = 355075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showAssignedControllers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Action restoreDefaultsDelegate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_restoreDefaultsDelegate_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_restoreDefaultsDelegate_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool isOpen
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 355093, RefRangeEnd = 355139, XrefRangeStart = 355075, XrefRangeEnd = 355093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool isFocused
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355139, XrefRangeEnd = 355140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isFocused_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool inputAllowed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355140, XrefRangeEnd = 355142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputAllowed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int inputGridColumnCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridColumnCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int inputGridWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355142, XrefRangeEnd = 355145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputGridWidth_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Player currentPlayer
	{
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 355151, RefRangeEnd = 355211, XrefRangeStart = 355145, XrefRangeEnd = 355151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentPlayer_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
		}
	}

	public unsafe InputCategory currentMapCategory
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355211, XrefRangeEnd = 355217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentMapCategory_Private_get_InputCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputCategory>(intPtr) : null;
		}
	}

	public unsafe MappingSet currentMappingSet
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 355218, RefRangeEnd = 355221, XrefRangeStart = 355217, XrefRangeEnd = 355218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentMappingSet_Private_get_MappingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MappingSet>(intPtr) : null;
		}
	}

	public unsafe Joystick currentJoystick
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 355227, RefRangeEnd = 355234, XrefRangeStart = 355221, XrefRangeEnd = 355227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentJoystick_Private_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
		}
	}

	public unsafe bool isJoystickSelected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isJoystickSelected_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe GameObject currentUISelection
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 355252, RefRangeEnd = 355257, XrefRangeStart = 355234, XrefRangeEnd = 355252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentUISelection_Private_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
	}

	public unsafe bool showSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showSettings_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool showMapCategories
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showMapCategories_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ControlMapper()
	{
		Il2CppClassPointerStore<ControlMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ControlMapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr);
		NativeFieldInfoPtr_versionMajor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "versionMajor");
		NativeFieldInfoPtr_versionMinor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "versionMinor");
		NativeFieldInfoPtr_usesTMPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "usesTMPro");
		NativeFieldInfoPtr_blockInputOnFocusTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "blockInputOnFocusTimeout");
		NativeFieldInfoPtr_buttonIdentifier_playerSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_playerSelection");
		NativeFieldInfoPtr_buttonIdentifier_removeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_removeController");
		NativeFieldInfoPtr_buttonIdentifier_assignController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_assignController");
		NativeFieldInfoPtr_buttonIdentifier_calibrateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_calibrateController");
		NativeFieldInfoPtr_buttonIdentifier_editInputBehaviors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_editInputBehaviors");
		NativeFieldInfoPtr_buttonIdentifier_mapCategorySelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_mapCategorySelection");
		NativeFieldInfoPtr_buttonIdentifier_assignedControllerSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_assignedControllerSelection");
		NativeFieldInfoPtr_buttonIdentifier_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_done");
		NativeFieldInfoPtr_buttonIdentifier_restoreDefaults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "buttonIdentifier_restoreDefaults");
		NativeFieldInfoPtr__rewiredInputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_rewiredInputManager");
		NativeFieldInfoPtr__dontDestroyOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_dontDestroyOnLoad");
		NativeFieldInfoPtr__openOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_openOnStart");
		NativeFieldInfoPtr__keyboardMapDefaultLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_keyboardMapDefaultLayout");
		NativeFieldInfoPtr__mouseMapDefaultLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_mouseMapDefaultLayout");
		NativeFieldInfoPtr__joystickMapDefaultLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_joystickMapDefaultLayout");
		NativeFieldInfoPtr__mappingSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_mappingSets");
		NativeFieldInfoPtr__showPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showPlayers");
		NativeFieldInfoPtr__showControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showControllers");
		NativeFieldInfoPtr__showKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showKeyboard");
		NativeFieldInfoPtr__showMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showMouse");
		NativeFieldInfoPtr__maxControllersPerPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_maxControllersPerPlayer");
		NativeFieldInfoPtr__showActionCategoryLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showActionCategoryLabels");
		NativeFieldInfoPtr__keyboardInputFieldCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_keyboardInputFieldCount");
		NativeFieldInfoPtr__mouseInputFieldCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_mouseInputFieldCount");
		NativeFieldInfoPtr__controllerInputFieldCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_controllerInputFieldCount");
		NativeFieldInfoPtr__showFullAxisInputFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showFullAxisInputFields");
		NativeFieldInfoPtr__showSplitAxisInputFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showSplitAxisInputFields");
		NativeFieldInfoPtr__allowElementAssignmentConflicts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_allowElementAssignmentConflicts");
		NativeFieldInfoPtr__allowElementAssignmentSwap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_allowElementAssignmentSwap");
		NativeFieldInfoPtr__actionLabelWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_actionLabelWidth");
		NativeFieldInfoPtr__keyboardColMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_keyboardColMaxWidth");
		NativeFieldInfoPtr__mouseColMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_mouseColMaxWidth");
		NativeFieldInfoPtr__controllerColMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_controllerColMaxWidth");
		NativeFieldInfoPtr__inputRowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_inputRowHeight");
		NativeFieldInfoPtr__inputRowPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_inputRowPadding");
		NativeFieldInfoPtr__inputRowFieldSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_inputRowFieldSpacing");
		NativeFieldInfoPtr__inputColumnSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_inputColumnSpacing");
		NativeFieldInfoPtr__inputRowCategorySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_inputRowCategorySpacing");
		NativeFieldInfoPtr__invertToggleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_invertToggleWidth");
		NativeFieldInfoPtr__defaultWindowWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_defaultWindowWidth");
		NativeFieldInfoPtr__defaultWindowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_defaultWindowHeight");
		NativeFieldInfoPtr__controllerAssignmentTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_controllerAssignmentTimeout");
		NativeFieldInfoPtr__preInputAssignmentTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_preInputAssignmentTimeout");
		NativeFieldInfoPtr__inputAssignmentTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_inputAssignmentTimeout");
		NativeFieldInfoPtr__axisCalibrationTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_axisCalibrationTimeout");
		NativeFieldInfoPtr__ignoreMouseXAxisAssignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_ignoreMouseXAxisAssignment");
		NativeFieldInfoPtr__ignoreMouseYAxisAssignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_ignoreMouseYAxisAssignment");
		NativeFieldInfoPtr__screenToggleAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_screenToggleAction");
		NativeFieldInfoPtr__screenOpenAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_screenOpenAction");
		NativeFieldInfoPtr__screenCloseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_screenCloseAction");
		NativeFieldInfoPtr__universalCancelAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_universalCancelAction");
		NativeFieldInfoPtr__universalCancelClosesScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_universalCancelClosesScreen");
		NativeFieldInfoPtr__showInputBehaviorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showInputBehaviorSettings");
		NativeFieldInfoPtr__inputBehaviorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_inputBehaviorSettings");
		NativeFieldInfoPtr__useThemeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_useThemeSettings");
		NativeFieldInfoPtr__themeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_themeSettings");
		NativeFieldInfoPtr__language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_language");
		NativeFieldInfoPtr_prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "prefabs");
		NativeFieldInfoPtr_references = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "references");
		NativeFieldInfoPtr__showPlayersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showPlayersGroupLabel");
		NativeFieldInfoPtr__showControllerGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showControllerGroupLabel");
		NativeFieldInfoPtr__showAssignedControllersGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showAssignedControllersGroupLabel");
		NativeFieldInfoPtr__showSettingsGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showSettingsGroupLabel");
		NativeFieldInfoPtr__showMapCategoriesGroupLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showMapCategoriesGroupLabel");
		NativeFieldInfoPtr__showControllerNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showControllerNameLabel");
		NativeFieldInfoPtr__showAssignedControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_showAssignedControllers");
		NativeFieldInfoPtr__ScreenClosedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_ScreenClosedEvent");
		NativeFieldInfoPtr__ScreenOpenedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_ScreenOpenedEvent");
		NativeFieldInfoPtr__PopupWindowOpenedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_PopupWindowOpenedEvent");
		NativeFieldInfoPtr__PopupWindowClosedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_PopupWindowClosedEvent");
		NativeFieldInfoPtr__InputPollingStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_InputPollingStartedEvent");
		NativeFieldInfoPtr__InputPollingEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_InputPollingEndedEvent");
		NativeFieldInfoPtr__onScreenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_onScreenClosed");
		NativeFieldInfoPtr__onScreenOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_onScreenOpened");
		NativeFieldInfoPtr__onPopupWindowClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_onPopupWindowClosed");
		NativeFieldInfoPtr__onPopupWindowOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_onPopupWindowOpened");
		NativeFieldInfoPtr__onInputPollingStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_onInputPollingStarted");
		NativeFieldInfoPtr__onInputPollingEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_onInputPollingEnded");
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_playerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "playerCount");
		NativeFieldInfoPtr_inputGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "inputGrid");
		NativeFieldInfoPtr_windowManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "windowManager");
		NativeFieldInfoPtr_currentPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "currentPlayerId");
		NativeFieldInfoPtr_currentMapCategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "currentMapCategoryId");
		NativeFieldInfoPtr_playerButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "playerButtons");
		NativeFieldInfoPtr_mapCategoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "mapCategoryButtons");
		NativeFieldInfoPtr_assignedControllerButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "assignedControllerButtons");
		NativeFieldInfoPtr_assignedControllerButtonsPlaceholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "assignedControllerButtonsPlaceholder");
		NativeFieldInfoPtr_miscInstantiatedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "miscInstantiatedObjects");
		NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "canvas");
		NativeFieldInfoPtr_lastUISelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "lastUISelection");
		NativeFieldInfoPtr_currentJoystickId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "currentJoystickId");
		NativeFieldInfoPtr_blockInputOnFocusEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "blockInputOnFocusEndTime");
		NativeFieldInfoPtr_isPollingForInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "isPollingForInput");
		NativeFieldInfoPtr_pendingInputMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "pendingInputMapping");
		NativeFieldInfoPtr_pendingAxisCalibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "pendingAxisCalibration");
		NativeFieldInfoPtr_inputFieldActivatedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "inputFieldActivatedDelegate");
		NativeFieldInfoPtr_inputFieldInvertToggleStateChangedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "inputFieldInvertToggleStateChangedDelegate");
		NativeFieldInfoPtr__restoreDefaultsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, "_restoreDefaultsDelegate");
		NativeMethodInfoPtr_add_ScreenClosedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675284);
		NativeMethodInfoPtr_remove_ScreenClosedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675285);
		NativeMethodInfoPtr_add_ScreenOpenedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675286);
		NativeMethodInfoPtr_remove_ScreenOpenedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675287);
		NativeMethodInfoPtr_add_PopupWindowClosedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675288);
		NativeMethodInfoPtr_remove_PopupWindowClosedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675289);
		NativeMethodInfoPtr_add_PopupWindowOpenedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675290);
		NativeMethodInfoPtr_remove_PopupWindowOpenedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675291);
		NativeMethodInfoPtr_add_InputPollingStartedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675292);
		NativeMethodInfoPtr_remove_InputPollingStartedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675293);
		NativeMethodInfoPtr_add_InputPollingEndedEvent_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675294);
		NativeMethodInfoPtr_remove_InputPollingEndedEvent_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675295);
		NativeMethodInfoPtr_add_onScreenClosed_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675296);
		NativeMethodInfoPtr_remove_onScreenClosed_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675297);
		NativeMethodInfoPtr_add_onScreenOpened_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675298);
		NativeMethodInfoPtr_remove_onScreenOpened_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675299);
		NativeMethodInfoPtr_add_onPopupWindowClosed_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675300);
		NativeMethodInfoPtr_remove_onPopupWindowClosed_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675301);
		NativeMethodInfoPtr_add_onPopupWindowOpened_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675302);
		NativeMethodInfoPtr_remove_onPopupWindowOpened_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675303);
		NativeMethodInfoPtr_add_onInputPollingStarted_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675304);
		NativeMethodInfoPtr_remove_onInputPollingStarted_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675305);
		NativeMethodInfoPtr_add_onInputPollingEnded_Public_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675306);
		NativeMethodInfoPtr_remove_onInputPollingEnded_Public_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675307);
		NativeMethodInfoPtr_get_rewiredInputManager_Public_get_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675308);
		NativeMethodInfoPtr_set_rewiredInputManager_Public_set_Void_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675309);
		NativeMethodInfoPtr_get_dontDestroyOnLoad_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675310);
		NativeMethodInfoPtr_set_dontDestroyOnLoad_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675311);
		NativeMethodInfoPtr_get_keyboardMapDefaultLayout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675312);
		NativeMethodInfoPtr_set_keyboardMapDefaultLayout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675313);
		NativeMethodInfoPtr_get_mouseMapDefaultLayout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675314);
		NativeMethodInfoPtr_set_mouseMapDefaultLayout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675315);
		NativeMethodInfoPtr_get_joystickMapDefaultLayout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675316);
		NativeMethodInfoPtr_set_joystickMapDefaultLayout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675317);
		NativeMethodInfoPtr_get_showPlayers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675318);
		NativeMethodInfoPtr_set_showPlayers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675319);
		NativeMethodInfoPtr_get_showControllers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675320);
		NativeMethodInfoPtr_set_showControllers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675321);
		NativeMethodInfoPtr_get_showKeyboard_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675322);
		NativeMethodInfoPtr_set_showKeyboard_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675323);
		NativeMethodInfoPtr_get_showMouse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675324);
		NativeMethodInfoPtr_set_showMouse_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675325);
		NativeMethodInfoPtr_get_maxControllersPerPlayer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675326);
		NativeMethodInfoPtr_set_maxControllersPerPlayer_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675327);
		NativeMethodInfoPtr_get_showActionCategoryLabels_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675328);
		NativeMethodInfoPtr_set_showActionCategoryLabels_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675329);
		NativeMethodInfoPtr_get_keyboardInputFieldCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675330);
		NativeMethodInfoPtr_set_keyboardInputFieldCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675331);
		NativeMethodInfoPtr_get_mouseInputFieldCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675332);
		NativeMethodInfoPtr_set_mouseInputFieldCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675333);
		NativeMethodInfoPtr_get_controllerInputFieldCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675334);
		NativeMethodInfoPtr_set_controllerInputFieldCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675335);
		NativeMethodInfoPtr_get_showFullAxisInputFields_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675336);
		NativeMethodInfoPtr_set_showFullAxisInputFields_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675337);
		NativeMethodInfoPtr_get_showSplitAxisInputFields_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675338);
		NativeMethodInfoPtr_set_showSplitAxisInputFields_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675339);
		NativeMethodInfoPtr_get_allowElementAssignmentConflicts_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675340);
		NativeMethodInfoPtr_set_allowElementAssignmentConflicts_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675341);
		NativeMethodInfoPtr_get_allowElementAssignmentSwap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675342);
		NativeMethodInfoPtr_set_allowElementAssignmentSwap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675343);
		NativeMethodInfoPtr_get_actionLabelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675344);
		NativeMethodInfoPtr_set_actionLabelWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675345);
		NativeMethodInfoPtr_get_keyboardColMaxWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675346);
		NativeMethodInfoPtr_set_keyboardColMaxWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675347);
		NativeMethodInfoPtr_get_mouseColMaxWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675348);
		NativeMethodInfoPtr_set_mouseColMaxWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675349);
		NativeMethodInfoPtr_get_controllerColMaxWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675350);
		NativeMethodInfoPtr_set_controllerColMaxWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675351);
		NativeMethodInfoPtr_get_inputRowHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675352);
		NativeMethodInfoPtr_set_inputRowHeight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675353);
		NativeMethodInfoPtr_get_inputColumnSpacing_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675354);
		NativeMethodInfoPtr_set_inputColumnSpacing_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675355);
		NativeMethodInfoPtr_get_inputRowCategorySpacing_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675356);
		NativeMethodInfoPtr_set_inputRowCategorySpacing_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675357);
		NativeMethodInfoPtr_get_invertToggleWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675358);
		NativeMethodInfoPtr_set_invertToggleWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675359);
		NativeMethodInfoPtr_get_defaultWindowWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675360);
		NativeMethodInfoPtr_set_defaultWindowWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675361);
		NativeMethodInfoPtr_get_defaultWindowHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675362);
		NativeMethodInfoPtr_set_defaultWindowHeight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675363);
		NativeMethodInfoPtr_get_controllerAssignmentTimeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675364);
		NativeMethodInfoPtr_set_controllerAssignmentTimeout_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675365);
		NativeMethodInfoPtr_get_preInputAssignmentTimeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675366);
		NativeMethodInfoPtr_set_preInputAssignmentTimeout_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675367);
		NativeMethodInfoPtr_get_inputAssignmentTimeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675368);
		NativeMethodInfoPtr_set_inputAssignmentTimeout_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675369);
		NativeMethodInfoPtr_get_axisCalibrationTimeout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675370);
		NativeMethodInfoPtr_set_axisCalibrationTimeout_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675371);
		NativeMethodInfoPtr_get_ignoreMouseXAxisAssignment_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675372);
		NativeMethodInfoPtr_set_ignoreMouseXAxisAssignment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675373);
		NativeMethodInfoPtr_get_ignoreMouseYAxisAssignment_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675374);
		NativeMethodInfoPtr_set_ignoreMouseYAxisAssignment_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675375);
		NativeMethodInfoPtr_get_universalCancelClosesScreen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675376);
		NativeMethodInfoPtr_set_universalCancelClosesScreen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675377);
		NativeMethodInfoPtr_get_showInputBehaviorSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675378);
		NativeMethodInfoPtr_set_showInputBehaviorSettings_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675379);
		NativeMethodInfoPtr_get_useThemeSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675380);
		NativeMethodInfoPtr_set_useThemeSettings_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675381);
		NativeMethodInfoPtr_get_language_Public_get_LanguageDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675382);
		NativeMethodInfoPtr_set_language_Public_set_Void_LanguageDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675383);
		NativeMethodInfoPtr_get_showPlayersGroupLabel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675384);
		NativeMethodInfoPtr_set_showPlayersGroupLabel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675385);
		NativeMethodInfoPtr_get_showControllerGroupLabel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675386);
		NativeMethodInfoPtr_set_showControllerGroupLabel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675387);
		NativeMethodInfoPtr_get_showAssignedControllersGroupLabel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675388);
		NativeMethodInfoPtr_set_showAssignedControllersGroupLabel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675389);
		NativeMethodInfoPtr_get_showSettingsGroupLabel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675390);
		NativeMethodInfoPtr_set_showSettingsGroupLabel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675391);
		NativeMethodInfoPtr_get_showMapCategoriesGroupLabel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675392);
		NativeMethodInfoPtr_set_showMapCategoriesGroupLabel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675393);
		NativeMethodInfoPtr_get_showControllerNameLabel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675394);
		NativeMethodInfoPtr_set_showControllerNameLabel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675395);
		NativeMethodInfoPtr_get_showAssignedControllers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675396);
		NativeMethodInfoPtr_set_showAssignedControllers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675397);
		NativeMethodInfoPtr_get_restoreDefaultsDelegate_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675398);
		NativeMethodInfoPtr_set_restoreDefaultsDelegate_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675399);
		NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675400);
		NativeMethodInfoPtr_get_isFocused_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675401);
		NativeMethodInfoPtr_get_inputAllowed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675402);
		NativeMethodInfoPtr_get_inputGridColumnCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675403);
		NativeMethodInfoPtr_get_inputGridWidth_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675404);
		NativeMethodInfoPtr_get_currentPlayer_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675405);
		NativeMethodInfoPtr_get_currentMapCategory_Private_get_InputCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675406);
		NativeMethodInfoPtr_get_currentMappingSet_Private_get_MappingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675407);
		NativeMethodInfoPtr_get_currentJoystick_Private_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675408);
		NativeMethodInfoPtr_get_isJoystickSelected_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675409);
		NativeMethodInfoPtr_get_currentUISelection_Private_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675410);
		NativeMethodInfoPtr_get_showSettings_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675411);
		NativeMethodInfoPtr_get_showMapCategories_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675412);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675413);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675414);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675415);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675416);
		NativeMethodInfoPtr_PreInitialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675417);
		NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675418);
		NativeMethodInfoPtr_OnJoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675419);
		NativeMethodInfoPtr_OnJoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675420);
		NativeMethodInfoPtr_OnJoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675421);
		NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675422);
		NativeMethodInfoPtr_OnInputFieldActivated_Public_Void_InputFieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675423);
		NativeMethodInfoPtr_OnInputFieldInvertToggleStateChanged_Public_Void_ToggleInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675424);
		NativeMethodInfoPtr_OnPlayerSelected_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675425);
		NativeMethodInfoPtr_OnControllerSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675426);
		NativeMethodInfoPtr_OnRemoveCurrentController_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675427);
		NativeMethodInfoPtr_OnMapCategorySelected_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675428);
		NativeMethodInfoPtr_OnRestoreDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675429);
		NativeMethodInfoPtr_OnScreenToggleActionPressed_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675430);
		NativeMethodInfoPtr_OnScreenOpenActionPressed_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675431);
		NativeMethodInfoPtr_OnScreenCloseActionPressed_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675432);
		NativeMethodInfoPtr_OnUniversalCancelActionPressed_Private_Void_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675433);
		NativeMethodInfoPtr_OnWindowCancel_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675434);
		NativeMethodInfoPtr_OnRemoveElementAssignment_Private_Void_Int32_ControllerMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675435);
		NativeMethodInfoPtr_OnBeginElementAssignment_Private_Void_InputFieldInfo_ControllerMap_ActionElementMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675436);
		NativeMethodInfoPtr_OnControllerAssignmentConfirmed_Private_Void_Int32_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675437);
		NativeMethodInfoPtr_OnMouseAssignmentConfirmed_Private_Void_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675438);
		NativeMethodInfoPtr_OnElementAssignmentConflictReplaceConfirmed_Private_Void_Int32_InputMapping_ElementAssignment_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675439);
		NativeMethodInfoPtr_OnElementAssignmentAddConfirmed_Private_Void_Int32_InputMapping_ElementAssignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675440);
		NativeMethodInfoPtr_OnRestoreDefaultsConfirmed_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675441);
		NativeMethodInfoPtr_OnAssignControllerWindowUpdate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675442);
		NativeMethodInfoPtr_OnElementAssignmentPrePollingWindowUpdate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675443);
		NativeMethodInfoPtr_OnJoystickElementAssignmentPollingWindowUpdate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675444);
		NativeMethodInfoPtr_OnKeyboardElementAssignmentPollingWindowUpdate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675445);
		NativeMethodInfoPtr_OnMouseElementAssignmentPollingWindowUpdate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675446);
		NativeMethodInfoPtr_OnCalibrateAxisStep1WindowUpdate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675447);
		NativeMethodInfoPtr_OnCalibrateAxisStep2WindowUpdate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675448);
		NativeMethodInfoPtr_ShowAssignControllerWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675449);
		NativeMethodInfoPtr_ShowControllerAssignmentConflictWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675450);
		NativeMethodInfoPtr_ShowBeginElementAssignmentReplacementWindow_Private_Void_InputFieldInfo_InputAction_ControllerMap_ActionElementMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675451);
		NativeMethodInfoPtr_ShowCreateNewElementAssignmentWindow_Private_Void_InputFieldInfo_InputAction_ControllerMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675452);
		NativeMethodInfoPtr_ShowElementAssignmentPrePollingWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675453);
		NativeMethodInfoPtr_ShowElementAssignmentPollingWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675454);
		NativeMethodInfoPtr_ShowJoystickElementAssignmentPollingWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675455);
		NativeMethodInfoPtr_ShowKeyboardElementAssignmentPollingWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675456);
		NativeMethodInfoPtr_ShowMouseElementAssignmentPollingWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675457);
		NativeMethodInfoPtr_ShowElementAssignmentConflictWindow_Private_Void_ElementAssignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675458);
		NativeMethodInfoPtr_ShowMouseAssignmentConflictWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675459);
		NativeMethodInfoPtr_ShowCalibrateControllerWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675460);
		NativeMethodInfoPtr_ShowCalibrateAxisStep1Window_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675461);
		NativeMethodInfoPtr_ShowCalibrateAxisStep2Window_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675462);
		NativeMethodInfoPtr_ShowEditInputBehaviorsWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675463);
		NativeMethodInfoPtr_ShowRestoreDefaultsWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675464);
		NativeMethodInfoPtr_CreateInputGrid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675465);
		NativeMethodInfoPtr_InitializeInputGrid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675466);
		NativeMethodInfoPtr_RefreshInputGridStructure_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675467);
		NativeMethodInfoPtr_CreateHeaderLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675468);
		NativeMethodInfoPtr_CreateActionLabelColumn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675469);
		NativeMethodInfoPtr_CreateKeyboardInputFieldColumn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675470);
		NativeMethodInfoPtr_CreateMouseInputFieldColumn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675471);
		NativeMethodInfoPtr_CreateControllerInputFieldColumn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675472);
		NativeMethodInfoPtr_CreateInputFieldColumn_Private_Void_String_ControllerType_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675473);
		NativeMethodInfoPtr_CreateInputActionLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675474);
		NativeMethodInfoPtr_CreateInputFields_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675475);
		NativeMethodInfoPtr_CreateInputFields_Private_Void_Transform_ControllerType_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675476);
		NativeMethodInfoPtr_CreateInputFieldSet_Private_Void_Transform_Int32_InputAction_AxisRange_ControllerType_Int32_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675477);
		NativeMethodInfoPtr_PopulateInputFields_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675478);
		NativeMethodInfoPtr_PopulateInputFieldGroup_Private_Void_InputActionSet_ControllerMap_ControllerType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675479);
		NativeMethodInfoPtr_DisableInputFieldGroup_Private_Void_InputActionSet_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675480);
		NativeMethodInfoPtr_ResetInputGridScrollBar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675481);
		NativeMethodInfoPtr_CreateLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675482);
		NativeMethodInfoPtr_Draw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675483);
		NativeMethodInfoPtr_DrawPlayersGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675484);
		NativeMethodInfoPtr_DrawControllersGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675485);
		NativeMethodInfoPtr_DrawSettingsGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675486);
		NativeMethodInfoPtr_DrawMapCategoriesGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675487);
		NativeMethodInfoPtr_DrawWindowButtonsGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675488);
		NativeMethodInfoPtr_Redraw_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675489);
		NativeMethodInfoPtr_RedrawPlayerGroup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675490);
		NativeMethodInfoPtr_RedrawControllerGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675491);
		NativeMethodInfoPtr_RedrawMapCategoriesGroup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675492);
		NativeMethodInfoPtr_RedrawInputGrid_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675493);
		NativeMethodInfoPtr_ForceRefresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675494);
		NativeMethodInfoPtr_CreateInputCategoryRow_Private_Void_byref_Int32_InputCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675495);
		NativeMethodInfoPtr_CreateLabel_Private_GUILabel_String_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675496);
		NativeMethodInfoPtr_CreateLabel_Private_GUILabel_GameObject_String_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675497);
		NativeMethodInfoPtr_CreateButton_Private_GUIButton_String_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675498);
		NativeMethodInfoPtr_CreateFitButton_Private_GUIButton_String_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675499);
		NativeMethodInfoPtr_CreateInputField_Private_GUIInputField_Transform_Vector2_String_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675500);
		NativeMethodInfoPtr_CreateInputField_Private_GUIInputField_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675501);
		NativeMethodInfoPtr_CreateToggle_Private_GUIToggle_GameObject_Transform_Vector2_String_Int32_AxisRange_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675502);
		NativeMethodInfoPtr_CreateToggle_Private_GUIToggle_GameObject_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675503);
		NativeMethodInfoPtr_InstantiateGUIObject_Private_GameObject_GameObject_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675504);
		NativeMethodInfoPtr_CreateNewGUIObject_Private_GameObject_String_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675505);
		NativeMethodInfoPtr_InitializeNewGUIGameObject_Private_GameObject_GameObject_Transform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675506);
		NativeMethodInfoPtr_CreateNewColumnGroup_Private_GameObject_String_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675507);
		NativeMethodInfoPtr_OpenWindow_Private_Window_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675508);
		NativeMethodInfoPtr_OpenWindow_Private_Window_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675509);
		NativeMethodInfoPtr_OpenWindow_Private_Window_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675510);
		NativeMethodInfoPtr_OpenWindow_Private_Window_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675511);
		NativeMethodInfoPtr_OpenModal_Private_Void_String_String_String_Action_1_Int32_String_Action_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675512);
		NativeMethodInfoPtr_CloseWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675513);
		NativeMethodInfoPtr_CloseTopWindow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675514);
		NativeMethodInfoPtr_CloseAllWindows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675515);
		NativeMethodInfoPtr_ChildWindowOpened_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675516);
		NativeMethodInfoPtr_ChildWindowClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675517);
		NativeMethodInfoPtr_HasElementAssignmentConflicts_Private_Boolean_Player_InputMapping_ElementAssignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675518);
		NativeMethodInfoPtr_IsBlockingAssignmentConflict_Private_Boolean_InputMapping_ElementAssignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675519);
		NativeMethodInfoPtr_ElementAssignmentConflicts_Private_IEnumerable_1_ElementAssignmentConflictInfo_Player_InputMapping_ElementAssignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675520);
		NativeMethodInfoPtr_CreateConflictCheck_Private_Boolean_InputMapping_ElementAssignment_byref_ElementAssignmentConflictCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675521);
		NativeMethodInfoPtr_PollKeyboardForAssignment_Private_Void_byref_ControllerPollingInfo_byref_Boolean_byref_ModifierKeyFlags_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675522);
		NativeMethodInfoPtr_GetFirstElementAssignmentConflict_Private_Boolean_ElementAssignmentConflictCheck_byref_ElementAssignmentConflictInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675523);
		NativeMethodInfoPtr_GetFirstElementAssignmentConflict_Private_Boolean_Player_ElementAssignmentConflictCheck_byref_ElementAssignmentConflictInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675524);
		NativeMethodInfoPtr_StartAxisCalibration_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675525);
		NativeMethodInfoPtr_EndAxisCalibration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675526);
		NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675527);
		NativeMethodInfoPtr_RestoreLastUISelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675528);
		NativeMethodInfoPtr_SetDefaultUISelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675529);
		NativeMethodInfoPtr_SelectDefaultMapCategory_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675530);
		NativeMethodInfoPtr_CheckUISelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675531);
		NativeMethodInfoPtr_OnUIElementSelected_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675532);
		NativeMethodInfoPtr_SetIsFocused_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675533);
		NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675534);
		NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675535);
		NativeMethodInfoPtr_Open_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675536);
		NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675537);
		NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675538);
		NativeMethodInfoPtr_ClearCompletely_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675539);
		NativeMethodInfoPtr_ClearSpawnedObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675540);
		NativeMethodInfoPtr_ClearVarsOnPlayerChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675541);
		NativeMethodInfoPtr_ClearVarsOnJoystickChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675542);
		NativeMethodInfoPtr_ClearAllVars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675543);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675544);
		NativeMethodInfoPtr_SetActionAxisInverted_Private_Void_Boolean_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675545);
		NativeMethodInfoPtr_GetControllerMap_Private_ControllerMap_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675546);
		NativeMethodInfoPtr_GetControllerMapOrCreateNew_Private_ControllerMap_ControllerType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675547);
		NativeMethodInfoPtr_CountIEnumerable_Private_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675548);
		NativeMethodInfoPtr_GetDefaultMapCategoryId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675549);
		NativeMethodInfoPtr_SubscribeFixedUISelectionEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675550);
		NativeMethodInfoPtr_SubscribeMenuControlInputEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675551);
		NativeMethodInfoPtr_UnsubscribeMenuControlInputEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675552);
		NativeMethodInfoPtr_SubscribeRewiredInputEventAllPlayers_Private_Void_Int32_Action_1_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675553);
		NativeMethodInfoPtr_UnsubscribeRewiredInputEventAllPlayers_Private_Void_Int32_Action_1_InputActionEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675554);
		NativeMethodInfoPtr_GetMaxControllersPerPlayer_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675555);
		NativeMethodInfoPtr_ShowAssignedControllers_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675556);
		NativeMethodInfoPtr_InspectorPropertyChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675557);
		NativeMethodInfoPtr_AssignController_Private_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675558);
		NativeMethodInfoPtr_RemoveAllControllers_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675559);
		NativeMethodInfoPtr_RemoveController_Private_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675560);
		NativeMethodInfoPtr_IsAllowedAssignment_Private_Boolean_InputMapping_ControllerPollingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675561);
		NativeMethodInfoPtr_InputPollingStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675562);
		NativeMethodInfoPtr_InputPollingStopped_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675563);
		NativeMethodInfoPtr_GetControllerInputFieldCount_Private_Int32_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675564);
		NativeMethodInfoPtr_ShowSwapButton_Private_Boolean_Int32_InputMapping_ElementAssignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675565);
		NativeMethodInfoPtr_SwapIsSameInputRange_Private_Boolean_ControllerElementType_AxisRange_Pole_ControllerElementType_AxisRange_Pole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675566);
		NativeMethodInfoPtr_ApplyTheme_Public_Static_Void_Il2CppReferenceArray_1_ElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675567);
		NativeMethodInfoPtr_GetLanguage_Public_Static_LanguageDataBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675568);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr, 100675569);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354754, XrefRangeEnd = 354759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ScreenClosedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_ScreenClosedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354759, XrefRangeEnd = 354764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ScreenClosedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_ScreenClosedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354764, XrefRangeEnd = 354769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ScreenOpenedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_ScreenOpenedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354769, XrefRangeEnd = 354774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ScreenOpenedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_ScreenOpenedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354774, XrefRangeEnd = 354779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_PopupWindowClosedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_PopupWindowClosedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354779, XrefRangeEnd = 354784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_PopupWindowClosedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_PopupWindowClosedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354784, XrefRangeEnd = 354789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_PopupWindowOpenedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_PopupWindowOpenedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354789, XrefRangeEnd = 354794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_PopupWindowOpenedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_PopupWindowOpenedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354794, XrefRangeEnd = 354799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_InputPollingStartedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_InputPollingStartedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354799, XrefRangeEnd = 354804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_InputPollingStartedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_InputPollingStartedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354804, XrefRangeEnd = 354809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_InputPollingEndedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_InputPollingEndedEvent_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354809, XrefRangeEnd = 354814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_InputPollingEndedEvent(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_InputPollingEndedEvent_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354814, XrefRangeEnd = 354816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onScreenClosed(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onScreenClosed_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354816, XrefRangeEnd = 354818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onScreenClosed(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onScreenClosed_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354818, XrefRangeEnd = 354820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onScreenOpened(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onScreenOpened_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354820, XrefRangeEnd = 354822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onScreenOpened(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onScreenOpened_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354822, XrefRangeEnd = 354824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onPopupWindowClosed(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onPopupWindowClosed_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354824, XrefRangeEnd = 354826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onPopupWindowClosed(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onPopupWindowClosed_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354826, XrefRangeEnd = 354828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onPopupWindowOpened(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onPopupWindowOpened_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354828, XrefRangeEnd = 354830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onPopupWindowOpened(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onPopupWindowOpened_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354830, XrefRangeEnd = 354832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onInputPollingStarted(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onInputPollingStarted_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354832, XrefRangeEnd = 354834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onInputPollingStarted(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onInputPollingStarted_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354834, XrefRangeEnd = 354836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onInputPollingEnded(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onInputPollingEnded_Public_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354836, XrefRangeEnd = 354838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onInputPollingEnded(UnityAction value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onInputPollingEnded_Public_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355257, XrefRangeEnd = 355270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355270, XrefRangeEnd = 355271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355271, XrefRangeEnd = 355286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355286, XrefRangeEnd = 355334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 355373, RefRangeEnd = 355374, XrefRangeStart = 355334, XrefRangeEnd = 355373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreInitialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 355575, RefRangeEnd = 355614, XrefRangeStart = 355374, XrefRangeEnd = 355575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355614, XrefRangeEnd = 355616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnJoystickConnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnJoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnJoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnJoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnJoystickPreDisconnect_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355616, XrefRangeEnd = 355631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonActivated(ButtonInfo buttonInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buttonInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355631, XrefRangeEnd = 355642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInputFieldActivated(InputFieldInfo fieldInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInputFieldActivated_Public_Void_InputFieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355642, XrefRangeEnd = 355648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toggleInfo);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newState;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInputFieldInvertToggleStateChanged_Public_Void_ToggleInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355648, XrefRangeEnd = 355649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerSelected(int playerId, bool redraw)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &redraw;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPlayerSelected_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355649, XrefRangeEnd = 355650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnControllerSelected(int joystickId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&joystickId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnControllerSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355650, XrefRangeEnd = 355654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRemoveCurrentController()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRemoveCurrentController_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355654, XrefRangeEnd = 355655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMapCategorySelected(int id, bool redraw)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &redraw;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMapCategorySelected_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 355668, RefRangeEnd = 355669, XrefRangeStart = 355655, XrefRangeEnd = 355668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRestoreDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRestoreDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355669, XrefRangeEnd = 355673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScreenToggleActionPressed(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScreenToggleActionPressed_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355673, XrefRangeEnd = 355674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScreenOpenActionPressed(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScreenOpenActionPressed_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355674, XrefRangeEnd = 355677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScreenCloseActionPressed(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnScreenCloseActionPressed_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355677, XrefRangeEnd = 355680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUniversalCancelActionPressed(InputActionEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUniversalCancelActionPressed_Private_Void_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355680, XrefRangeEnd = 355681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWindowCancel(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWindowCancel_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355681, XrefRangeEnd = 355682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&windowId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aem);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRemoveElementAssignment_Private_Void_Int32_ControllerMap_ActionElementMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 355697, RefRangeEnd = 355699, XrefRangeStart = 355682, XrefRangeEnd = 355697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginElementAssignment_Private_Void_InputFieldInfo_ControllerMap_ActionElementMap_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355699, XrefRangeEnd = 355701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&windowId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnControllerAssignmentConfirmed_Private_Void_Int32_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 355722, RefRangeEnd = 355723, XrefRangeStart = 355701, XrefRangeEnd = 355722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMouseAssignmentConfirmed(int windowId, Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&windowId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMouseAssignmentConfirmed_Private_Void_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 355796, RefRangeEnd = 355798, XrefRangeStart = 355723, XrefRangeEnd = 355796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnElementAssignmentConflictReplaceConfirmed(int windowId, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&windowId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapping);
		*(ElementAssignment**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assignment;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipOtherPlayers;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowSwap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnElementAssignmentConflictReplaceConfirmed_Private_Void_Int32_InputMapping_ElementAssignment_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355798, XrefRangeEnd = 355801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnElementAssignmentAddConfirmed(int windowId, InputMapping mapping, ElementAssignment assignment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&windowId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapping);
		*(ElementAssignment**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assignment;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnElementAssignmentAddConfirmed_Private_Void_Int32_InputMapping_ElementAssignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 355829, RefRangeEnd = 355830, XrefRangeStart = 355801, XrefRangeEnd = 355829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRestoreDefaultsConfirmed(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRestoreDefaultsConfirmed_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355830, XrefRangeEnd = 355862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAssignControllerWindowUpdate(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAssignControllerWindowUpdate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355862, XrefRangeEnd = 355883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnElementAssignmentPrePollingWindowUpdate(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnElementAssignmentPrePollingWindowUpdate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355883, XrefRangeEnd = 355918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnJoystickElementAssignmentPollingWindowUpdate(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnJoystickElementAssignmentPollingWindowUpdate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355918, XrefRangeEnd = 355942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnKeyboardElementAssignmentPollingWindowUpdate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355942, XrefRangeEnd = 355990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMouseElementAssignmentPollingWindowUpdate(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMouseElementAssignmentPollingWindowUpdate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355990, XrefRangeEnd = 356003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCalibrateAxisStep1WindowUpdate(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCalibrateAxisStep1WindowUpdate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356003, XrefRangeEnd = 356018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCalibrateAxisStep2WindowUpdate(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCalibrateAxisStep2WindowUpdate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356018, XrefRangeEnd = 356052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAssignControllerWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowAssignControllerWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356117, RefRangeEnd = 356118, XrefRangeStart = 356052, XrefRangeEnd = 356117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowControllerAssignmentConflictWindow(int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controllerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowControllerAssignmentConflictWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356160, RefRangeEnd = 356161, XrefRangeStart = 356118, XrefRangeEnd = 356160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowBeginElementAssignmentReplacementWindow_Private_Void_InputFieldInfo_InputAction_ControllerMap_ActionElementMap_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356161, XrefRangeEnd = 356163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowCreateNewElementAssignmentWindow_Private_Void_InputFieldInfo_InputAction_ControllerMap_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356202, RefRangeEnd = 356203, XrefRangeStart = 356163, XrefRangeEnd = 356202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowElementAssignmentPrePollingWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowElementAssignmentPrePollingWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356209, RefRangeEnd = 356210, XrefRangeStart = 356203, XrefRangeEnd = 356209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowElementAssignmentPollingWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowElementAssignmentPollingWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356239, RefRangeEnd = 356240, XrefRangeStart = 356210, XrefRangeEnd = 356239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowJoystickElementAssignmentPollingWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowJoystickElementAssignmentPollingWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356271, RefRangeEnd = 356272, XrefRangeStart = 356240, XrefRangeEnd = 356271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowKeyboardElementAssignmentPollingWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowKeyboardElementAssignmentPollingWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356301, RefRangeEnd = 356302, XrefRangeStart = 356272, XrefRangeEnd = 356301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowMouseElementAssignmentPollingWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMouseElementAssignmentPollingWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 356357, RefRangeEnd = 356360, XrefRangeStart = 356302, XrefRangeEnd = 356357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&assignment);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipOtherPlayers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowElementAssignmentConflictWindow_Private_Void_ElementAssignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356416, RefRangeEnd = 356417, XrefRangeStart = 356360, XrefRangeEnd = 356416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowMouseAssignmentConflictWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMouseAssignmentConflictWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356417, XrefRangeEnd = 356463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowCalibrateControllerWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowCalibrateControllerWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356508, RefRangeEnd = 356509, XrefRangeStart = 356463, XrefRangeEnd = 356508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowCalibrateAxisStep1Window()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowCalibrateAxisStep1Window_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356554, RefRangeEnd = 356555, XrefRangeStart = 356509, XrefRangeEnd = 356554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowCalibrateAxisStep2Window()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowCalibrateAxisStep2Window_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356555, XrefRangeEnd = 356592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowEditInputBehaviorsWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowEditInputBehaviorsWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356592, XrefRangeEnd = 356605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowRestoreDefaultsWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowRestoreDefaultsWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356630, RefRangeEnd = 356631, XrefRangeStart = 356605, XrefRangeEnd = 356630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInputGrid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputGrid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356703, RefRangeEnd = 356704, XrefRangeStart = 356631, XrefRangeEnd = 356703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeInputGrid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInputGrid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 356718, RefRangeEnd = 356720, XrefRangeStart = 356704, XrefRangeEnd = 356718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshInputGridStructure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshInputGridStructure_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356758, RefRangeEnd = 356759, XrefRangeStart = 356720, XrefRangeEnd = 356758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateHeaderLabels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHeaderLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356759, XrefRangeEnd = 356764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateActionLabelColumn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateActionLabelColumn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356764, XrefRangeEnd = 356767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateKeyboardInputFieldColumn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateKeyboardInputFieldColumn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356767, XrefRangeEnd = 356770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMouseInputFieldColumn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMouseInputFieldColumn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356770, XrefRangeEnd = 356773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateControllerInputFieldColumn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateControllerInputFieldColumn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 356776, RefRangeEnd = 356782, XrefRangeStart = 356773, XrefRangeEnd = 356776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cols;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableFullAxis;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputFieldColumn_Private_Void_String_ControllerType_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 356867, RefRangeEnd = 356868, XrefRangeStart = 356782, XrefRangeEnd = 356867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInputActionLabels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputActionLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356868, XrefRangeEnd = 356871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInputFields()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputFields_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 356934, RefRangeEnd = 356940, XrefRangeStart = 356871, XrefRangeEnd = 356934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)columnXform);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cols;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableFullAxis;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputFields_Private_Void_Transform_ControllerType_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 356980, RefRangeEnd = 356987, XrefRangeStart = 356940, XrefRangeEnd = 356980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapCategoryId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(AxisRange**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
		*(ControllerType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cols;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldWidth;
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yPos);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableFullAxis;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputFieldSet_Private_Void_Transform_Int32_InputAction_AxisRange_ControllerType_Int32_Int32_byref_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 357033, RefRangeEnd = 357037, XrefRangeStart = 356987, XrefRangeEnd = 357033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateInputFields()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateInputFields_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 357071, RefRangeEnd = 357074, XrefRangeStart = 357037, XrefRangeEnd = 357071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateInputFieldGroup(InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionSet);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap);
		*(ControllerType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxFields;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateInputFieldGroup_Private_Void_InputActionSet_ControllerMap_ControllerType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357075, RefRangeEnd = 357076, XrefRangeStart = 357074, XrefRangeEnd = 357075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableInputFieldGroup(InputActionSet actionSet, ControllerType controllerType, int fieldCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionSet);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableInputFieldGroup_Private_Void_InputActionSet_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 357088, RefRangeEnd = 357091, XrefRangeStart = 357076, XrefRangeEnd = 357088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetInputGridScrollBar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetInputGridScrollBar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357147, RefRangeEnd = 357148, XrefRangeStart = 357091, XrefRangeEnd = 357147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateLayout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357148, XrefRangeEnd = 357158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Draw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357202, RefRangeEnd = 357204, XrefRangeStart = 357158, XrefRangeEnd = 357202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawPlayersGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPlayersGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357227, RefRangeEnd = 357229, XrefRangeStart = 357204, XrefRangeEnd = 357227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawControllersGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawControllersGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357255, RefRangeEnd = 357257, XrefRangeStart = 357229, XrefRangeEnd = 357255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawSettingsGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawSettingsGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357296, RefRangeEnd = 357298, XrefRangeStart = 357257, XrefRangeEnd = 357296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawMapCategoriesGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawMapCategoriesGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357298, XrefRangeEnd = 357304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWindowButtonsGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWindowButtonsGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 357328, RefRangeEnd = 357338, XrefRangeStart = 357304, XrefRangeEnd = 357328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Redraw(bool listsChanged, bool playTransitions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&listsChanged);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playTransitions;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Redraw_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357344, RefRangeEnd = 357345, XrefRangeStart = 357338, XrefRangeEnd = 357344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RedrawPlayerGroup(bool playTransitions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playTransitions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RedrawPlayerGroup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357469, RefRangeEnd = 357470, XrefRangeStart = 357345, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RedrawControllerGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RedrawControllerGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357475, RefRangeEnd = 357476, XrefRangeStart = 357470, XrefRangeEnd = 357475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RedrawMapCategoriesGroup(bool playTransitions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playTransitions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RedrawMapCategoriesGroup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357476, XrefRangeEnd = 357480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RedrawInputGrid(bool listsChanged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&listsChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RedrawInputGrid_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357480, XrefRangeEnd = 357484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceRefresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceRefresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357484, XrefRangeEnd = 357485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInputCategoryRow(ref int rowCount, InputCategory category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref rowCount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)category);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputCategoryRow_Private_Void_byref_Int32_InputCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357485, XrefRangeEnd = 357486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(labelText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLabel_Private_GUILabel_String_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILabel>(intPtr) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 357515, RefRangeEnd = 357530, XrefRangeStart = 357486, XrefRangeEnd = 357515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(labelText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLabel_Private_GUILabel_GameObject_String_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILabel>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 357535, RefRangeEnd = 357538, XrefRangeStart = 357530, XrefRangeEnd = 357535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIButton CreateButton(string labelText, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(labelText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateButton_Private_GUIButton_String_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIButton>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357538, XrefRangeEnd = 357543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(labelText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFitButton_Private_GUIButton_String_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIButton>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357577, RefRangeEnd = 357578, XrefRangeStart = 357543, XrefRangeEnd = 357577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
		*(AxisRange**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
		*(ControllerType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputField_Private_GUIInputField_Transform_Vector2_String_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIInputField>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357578, XrefRangeEnd = 357583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIInputField CreateInputField(Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputField_Private_GUIInputField_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIInputField>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357615, RefRangeEnd = 357616, XrefRangeStart = 357583, XrefRangeEnd = 357615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionId;
		*(AxisRange**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisRange;
		*(ControllerType**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateToggle_Private_GUIToggle_GameObject_Transform_Vector2_String_Int32_AxisRange_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIToggle>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357616, XrefRangeEnd = 357621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateToggle_Private_GUIToggle_GameObject_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIToggle>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 357645, RefRangeEnd = 357652, XrefRangeStart = 357621, XrefRangeEnd = 357645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantiateGUIObject_Private_GameObject_GameObject_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357662, RefRangeEnd = 357664, XrefRangeStart = 357652, XrefRangeEnd = 357662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewGUIObject_Private_GameObject_String_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357703, RefRangeEnd = 357705, XrefRangeStart = 357664, XrefRangeEnd = 357703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeNewGUIGameObject_Private_GameObject_GameObject_Transform_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 357721, RefRangeEnd = 357728, XrefRangeStart = 357705, XrefRangeEnd = 357721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewColumnGroup_Private_GameObject_String_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 357746, RefRangeEnd = 357758, XrefRangeStart = 357728, XrefRangeEnd = 357746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Window OpenWindow(bool closeOthers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&closeOthers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenWindow_Private_Window_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357758, XrefRangeEnd = 357773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Window OpenWindow(string name, bool closeOthers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &closeOthers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenWindow_Private_Window_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357773, XrefRangeEnd = 357776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Window OpenWindow(GameObject windowPrefab, bool closeOthers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowPrefab);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &closeOthers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenWindow_Private_Window_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 357809, RefRangeEnd = 357812, XrefRangeStart = 357776, XrefRangeEnd = 357809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowPrefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &closeOthers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenWindow_Private_Window_GameObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Window>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357849, RefRangeEnd = 357851, XrefRangeStart = 357812, XrefRangeEnd = 357849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenModal(string title, string message, string confirmText, Il2CppSystem.Action<int> confirmAction, string cancelText, Il2CppSystem.Action<int> cancelAction, bool closeOthers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(confirmText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)confirmAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cancelText);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cancelAction);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &closeOthers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenModal_Private_Void_String_String_String_Action_1_Int32_String_Action_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 357855, RefRangeEnd = 357871, XrefRangeStart = 357851, XrefRangeEnd = 357855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseWindow(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357871, XrefRangeEnd = 357874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseTopWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseTopWindow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 357878, RefRangeEnd = 357880, XrefRangeStart = 357874, XrefRangeEnd = 357878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseAllWindows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseAllWindows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 357884, RefRangeEnd = 357887, XrefRangeStart = 357880, XrefRangeEnd = 357884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChildWindowOpened()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChildWindowOpened_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 357890, RefRangeEnd = 357896, XrefRangeStart = 357887, XrefRangeEnd = 357890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChildWindowClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChildWindowClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357909, RefRangeEnd = 357910, XrefRangeStart = 357896, XrefRangeEnd = 357909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasElementAssignmentConflicts(Player player, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapping);
		*(ElementAssignment**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assignment;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipOtherPlayers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasElementAssignmentConflicts_Private_Boolean_Player_InputMapping_ElementAssignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 357969, RefRangeEnd = 357970, XrefRangeStart = 357910, XrefRangeEnd = 357969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBlockingAssignmentConflict(InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapping);
		*(ElementAssignment**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &assignment;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipOtherPlayers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBlockingAssignmentConflict_Private_Boolean_InputMapping_ElementAssignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357970, XrefRangeEnd = 357974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapping);
		*(ElementAssignment**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assignment;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipOtherPlayers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ElementAssignmentConflicts_Private_IEnumerable_1_ElementAssignmentConflictInfo_Player_InputMapping_ElementAssignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<ElementAssignmentConflictInfo>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 357980, RefRangeEnd = 357987, XrefRangeStart = 357974, XrefRangeEnd = 357980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CreateConflictCheck(InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapping);
		*(ElementAssignment**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &assignment;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref conflictCheck);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateConflictCheck_Private_Boolean_InputMapping_ElementAssignment_byref_ElementAssignmentConflictCheck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 358022, RefRangeEnd = 358023, XrefRangeStart = 357987, XrefRangeEnd = 358022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		nint num = 0;
		*ptr = (nint)(&num);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref modifierKeyPressed);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref modifierFlags);
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PollKeyboardForAssignment_Private_Void_byref_ControllerPollingInfo_byref_Boolean_byref_ModifierKeyFlags_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num4 = num;
		pollingInfo = ((num4 == 0) ? null : new ControllerPollingInfo(num4));
		label = IL2CPP.Il2CppStringToManaged((System.IntPtr)num3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 358044, RefRangeEnd = 358045, XrefRangeStart = 358023, XrefRangeEnd = 358044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&conflictCheck);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref conflict);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipOtherPlayers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstElementAssignmentConflict_Private_Boolean_ElementAssignmentConflictCheck_byref_ElementAssignmentConflictInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 358058, RefRangeEnd = 358061, XrefRangeStart = 358045, XrefRangeEnd = 358058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(ElementAssignmentConflictCheck**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &conflictCheck;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref conflict);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstElementAssignmentConflict_Private_Boolean_Player_ElementAssignmentConflictCheck_byref_ElementAssignmentConflictInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358061, XrefRangeEnd = 358080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAxisCalibration(int axisIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&axisIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartAxisCalibration_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358080, XrefRangeEnd = 358083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndAxisCalibration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndAxisCalibration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 358102, RefRangeEnd = 358106, XrefRangeStart = 358083, XrefRangeEnd = 358102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUISelection(GameObject selection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUISelection_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 358124, RefRangeEnd = 358128, XrefRangeStart = 358106, XrefRangeEnd = 358124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreLastUISelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreLastUISelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 358143, RefRangeEnd = 358145, XrefRangeStart = 358128, XrefRangeEnd = 358143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultUISelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultUISelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 358162, RefRangeEnd = 358163, XrefRangeStart = 358145, XrefRangeEnd = 358162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectDefaultMapCategory(bool redraw)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&redraw);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectDefaultMapCategory_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358163, XrefRangeEnd = 358177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckUISelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckUISelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void OnUIElementSelected(GameObject selectedObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectedObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUIElementSelected_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 358183, RefRangeEnd = 358184, XrefRangeStart = 358177, XrefRangeEnd = 358183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsFocused(bool state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIsFocused_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358184, XrefRangeEnd = 358187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Toggle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Open()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 358196, RefRangeEnd = 358239, XrefRangeStart = 358187, XrefRangeEnd = 358196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Open(bool force)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 358254, RefRangeEnd = 358257, XrefRangeStart = 358239, XrefRangeEnd = 358254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close(bool save)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&save);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 358259, RefRangeEnd = 358299, XrefRangeStart = 358257, XrefRangeEnd = 358259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358299, XrefRangeEnd = 358302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCompletely()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCompletely_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 358381, RefRangeEnd = 358419, XrefRangeStart = 358302, XrefRangeEnd = 358381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSpawnedObjects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSpawnedObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ClearVarsOnPlayerChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearVarsOnPlayerChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ClearVarsOnJoystickChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearVarsOnJoystickChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 358422, RefRangeEnd = 358460, XrefRangeStart = 358419, XrefRangeEnd = 358422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearAllVars()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAllVars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358460, XrefRangeEnd = 358466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358466, XrefRangeEnd = 358470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&state);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionElementMapId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActionAxisInverted_Private_Void_Boolean_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 358473, RefRangeEnd = 358477, XrefRangeStart = 358470, XrefRangeEnd = 358473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControllerMap GetControllerMap(ControllerType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMap_Private_ControllerMap_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 358482, RefRangeEnd = 358485, XrefRangeStart = 358477, XrefRangeEnd = 358482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&controllerType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMapOrCreateNew_Private_ControllerMap_ControllerType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358485, XrefRangeEnd = 358492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CountIEnumerable<T>(IEnumerable<T> enumerable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumerable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CountIEnumerable_Private_Int32_IEnumerable_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358492, XrefRangeEnd = 358498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDefaultMapCategoryId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultMapCategoryId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 358523, RefRangeEnd = 358524, XrefRangeStart = 358498, XrefRangeEnd = 358523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubscribeFixedUISelectionEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubscribeFixedUISelectionEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358524, XrefRangeEnd = 358550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubscribeMenuControlInputEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubscribeMenuControlInputEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358550, XrefRangeEnd = 358576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnsubscribeMenuControlInputEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsubscribeMenuControlInputEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 358612, RefRangeEnd = 358620, XrefRangeStart = 358576, XrefRangeEnd = 358612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubscribeRewiredInputEventAllPlayers(int actionId, Il2CppSystem.Action<InputActionEventData> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&actionId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubscribeRewiredInputEventAllPlayers_Private_Void_Int32_Action_1_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 358659, RefRangeEnd = 358667, XrefRangeStart = 358620, XrefRangeEnd = 358659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnsubscribeRewiredInputEventAllPlayers(int actionId, Il2CppSystem.Action<InputActionEventData> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&actionId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsubscribeRewiredInputEventAllPlayers_Private_Void_Int32_Action_1_InputActionEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetMaxControllersPerPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxControllersPerPlayer_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 358668, RefRangeEnd = 358671, XrefRangeStart = 358667, XrefRangeEnd = 358668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShowAssignedControllers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowAssignedControllers_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358671, XrefRangeEnd = 358677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InspectorPropertyChanged(bool reset = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&reset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InspectorPropertyChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 358722, RefRangeEnd = 358725, XrefRangeStart = 358677, XrefRangeEnd = 358722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignController(Player player, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignController_Private_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358725, XrefRangeEnd = 358733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllControllers(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllControllers_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 358750, RefRangeEnd = 358754, XrefRangeStart = 358733, XrefRangeEnd = 358750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveController(Player player, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveController_Private_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsAllowedAssignment(InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pendingInputMapping);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pollingInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllowedAssignment_Private_Boolean_InputMapping_ControllerPollingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 358755, RefRangeEnd = 358761, XrefRangeStart = 358754, XrefRangeEnd = 358755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InputPollingStarted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InputPollingStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 358762, RefRangeEnd = 358767, XrefRangeStart = 358761, XrefRangeEnd = 358762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InputPollingStopped()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InputPollingStopped_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 358767, RefRangeEnd = 358769, XrefRangeStart = 358767, XrefRangeEnd = 358767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetControllerInputFieldCount(ControllerType controllerType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controllerType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerInputFieldCount_Private_Int32_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 358846, RefRangeEnd = 358847, XrefRangeStart = 358769, XrefRangeEnd = 358846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShowSwapButton(int windowId, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&windowId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapping);
		*(ElementAssignment**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &assignment;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipOtherPlayers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowSwapButton_Private_Boolean_Int32_InputMapping_ElementAssignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&origElementType);
		*(AxisRange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origAxisRange;
		*(Pole**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &origAxisContribution;
		*(ControllerElementType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &conflictElementType;
		*(AxisRange**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &conflictAxisRange;
		*(Pole**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &conflictAxisContribution;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwapIsSameInputRange_Private_Boolean_ControllerElementType_AxisRange_Pole_ControllerElementType_AxisRange_Pole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 358874, RefRangeEnd = 358875, XrefRangeStart = 358847, XrefRangeEnd = 358874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyTheme(Il2CppReferenceArray<ThemedElement.ElementInfo> elementInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elementInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTheme_Public_Static_Void_Il2CppReferenceArray_1_ElementInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 358889, RefRangeEnd = 358905, XrefRangeStart = 358875, XrefRangeEnd = 358889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LanguageDataBase GetLanguage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLanguage_Public_Static_LanguageDataBase_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LanguageDataBase>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358905, XrefRangeEnd = 358925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlMapper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlMapper>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ControlMapper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
