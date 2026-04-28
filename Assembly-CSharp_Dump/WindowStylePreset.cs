using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class WindowStylePreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_closable;

	private static readonly IntPtr NativeFieldInfoPtr_pinnable;

	private static readonly IntPtr NativeFieldInfoPtr_forceWorldInteraction;

	private static readonly IntPtr NativeFieldInfoPtr_useWindowFocusMode;

	private static readonly IntPtr NativeFieldInfoPtr_resizable;

	private static readonly IntPtr NativeFieldInfoPtr_defaultSize;

	private static readonly IntPtr NativeFieldInfoPtr_minSize;

	private static readonly IntPtr NativeFieldInfoPtr_maxSize;

	private static readonly IntPtr NativeFieldInfoPtr_DDSadditionalSize;

	private static readonly IntPtr NativeFieldInfoPtr_overrideIcon;

	private static readonly IntPtr NativeFieldInfoPtr_tabs;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool closable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closable)) = flag;
		}
	}

	public unsafe bool pinnable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnable)) = flag;
		}
	}

	public unsafe bool forceWorldInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceWorldInteraction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceWorldInteraction)) = flag;
		}
	}

	public unsafe bool useWindowFocusMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWindowFocusMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWindowFocusMode)) = flag;
		}
	}

	public unsafe bool resizable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resizable)) = flag;
		}
	}

	public unsafe Vector2 defaultSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultSize)) = vector;
		}
	}

	public unsafe Vector2 minSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSize)) = vector;
		}
	}

	public unsafe Vector2 maxSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSize)) = vector;
		}
	}

	public unsafe Vector2 DDSadditionalSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DDSadditionalSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DDSadditionalSize)) = vector;
		}
	}

	public unsafe Sprite overrideIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe List<WindowTabPreset> tabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<WindowTabPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static WindowStylePreset()
	{
		Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WindowStylePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr);
		NativeFieldInfoPtr_closable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "closable");
		NativeFieldInfoPtr_pinnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "pinnable");
		NativeFieldInfoPtr_forceWorldInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "forceWorldInteraction");
		NativeFieldInfoPtr_useWindowFocusMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "useWindowFocusMode");
		NativeFieldInfoPtr_resizable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "resizable");
		NativeFieldInfoPtr_defaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "defaultSize");
		NativeFieldInfoPtr_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "minSize");
		NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "maxSize");
		NativeFieldInfoPtr_DDSadditionalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "DDSadditionalSize");
		NativeFieldInfoPtr_overrideIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "overrideIcon");
		NativeFieldInfoPtr_tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, "tabs");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr, 100674059);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330502, XrefRangeEnd = 330510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WindowStylePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowStylePreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WindowStylePreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
