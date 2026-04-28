using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

public static class UISelectionUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_reusableAllSelectables;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0;

	public unsafe static Il2CppReferenceArray<Selectable> s_reusableAllSelectables
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_reusableAllSelectables, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_reusableAllSelectables, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static UISelectionUtility()
	{
		Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "UISelectionUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr);
		NativeFieldInfoPtr_s_reusableAllSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr, "s_reusableAllSelectables");
		NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionUtility>.NativeClassPtr, 100676348);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 361006, RefRangeEnd = 361014, XrefRangeStart = 360873, XrefRangeEnd = 361006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable FindNextSelectable(Selectable selectable, Transform transform, Vector3 direction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNextSelectable_Public_Static_Selectable_Selectable_Transform_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	public UISelectionUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
