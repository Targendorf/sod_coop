using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MenuNavigationOrderConfig : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_contentParentHierarchy;

	private static readonly IntPtr NativeFieldInfoPtr_leftMovesUpHierarchy;

	private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<Transform> contentParentHierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentParentHierarchy);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentParentHierarchy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool leftMovesUpHierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftMovesUpHierarchy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftMovesUpHierarchy)) = flag;
		}
	}

	static MenuNavigationOrderConfig()
	{
		Il2CppClassPointerStore<MenuNavigationOrderConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MenuNavigationOrderConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuNavigationOrderConfig>.NativeClassPtr);
		NativeFieldInfoPtr_contentParentHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuNavigationOrderConfig>.NativeClassPtr, "contentParentHierarchy");
		NativeFieldInfoPtr_leftMovesUpHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuNavigationOrderConfig>.NativeClassPtr, "leftMovesUpHierarchy");
		NativeMethodInfoPtr_Configure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuNavigationOrderConfig>.NativeClassPtr, 100671567);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuNavigationOrderConfig>.NativeClassPtr, 100671568);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274372, XrefRangeEnd = 274525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Configure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Configure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274525, XrefRangeEnd = 274534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MenuNavigationOrderConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuNavigationOrderConfig>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MenuNavigationOrderConfig(IntPtr pointer)
		: base(pointer)
	{
	}
}
