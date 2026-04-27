using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

public static class UITools : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0;

	static UITools()
	{
		Il2CppClassPointerStore<UITools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UITools");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITools>.NativeClassPtr);
		NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676359);
		NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676360);
		NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676361);
		NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676362);
		NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676363);
		NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676364);
		NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676365);
		NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100676366);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 361147, RefRangeEnd = 361152, XrefRangeStart = 361110, XrefRangeEnd = 361147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 361193, RefRangeEnd = 361195, XrefRangeStart = 361152, XrefRangeEnd = 361193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(Vector2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchorMin;
		*(Vector2**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchorMax;
		*(Vector2**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchoredPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361195, XrefRangeEnd = 361250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject InstantiateGUIObject_Pre<T>(GameObject prefab, Transform parent, string name) where T : Component
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 361265, RefRangeEnd = 361266, XrefRangeStart = 361250, XrefRangeEnd = 361265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361266, XrefRangeEnd = 361285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetWorldSpaceRect(RectTransform rt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 361319, RefRangeEnd = 361320, XrefRangeStart = 361285, XrefRangeEnd = 361319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect TransformRectTo(Transform from, Transform to, Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Rect InvertY(Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 361339, RefRangeEnd = 361344, XrefRangeStart = 361320, XrefRangeEnd = 361339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetInteractable(Selectable selectable, bool state, bool playTransition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &playTransition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UITools(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
