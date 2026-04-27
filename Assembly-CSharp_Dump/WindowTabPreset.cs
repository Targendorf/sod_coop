using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class WindowTabPreset : SoCustomComparison
{
	public enum TabContentType
	{
		generated,
		message,
		facts,
		history,
		help,
		photoSelect,
		shop,
		objectives,
		callLogsIncoming,
		callLogsOutgoing,
		passcodes,
		phoneNumbers,
		resolve,
		results,
		decor,
		furnishings,
		colourPicker,
		floors,
		ceiling,
		materialKey,
		caseOptions,
		items,
		itemSelect
	}

	private static readonly IntPtr NativeFieldInfoPtr_tabName;

	private static readonly IntPtr NativeFieldInfoPtr_colour;

	private static readonly IntPtr NativeFieldInfoPtr_contentPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_contentType;

	private static readonly IntPtr NativeFieldInfoPtr_scalableContent;

	private static readonly IntPtr NativeFieldInfoPtr_fitToScaleX;

	private static readonly IntPtr NativeFieldInfoPtr_fitToScaleY;

	private static readonly IntPtr NativeFieldInfoPtr_zoomWithMouseWheel;

	private static readonly IntPtr NativeFieldInfoPtr_scrollBars;

	private static readonly IntPtr NativeFieldInfoPtr_scrollRestrcition;

	private static readonly IntPtr NativeFieldInfoPtr_displayContentWithTag;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string tabName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Color colour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)) = color;
		}
	}

	public unsafe GameObject contentPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe TabContentType contentType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentType);
			return *(TabContentType*)num;
		}
		set
		{
			*(TabContentType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentType)) = tabContentType;
		}
	}

	public unsafe bool scalableContent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scalableContent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scalableContent)) = flag;
		}
	}

	public unsafe bool fitToScaleX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitToScaleX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitToScaleX)) = flag;
		}
	}

	public unsafe bool fitToScaleY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitToScaleY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fitToScaleY)) = flag;
		}
	}

	public unsafe bool zoomWithMouseWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomWithMouseWheel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoomWithMouseWheel)) = flag;
		}
	}

	public unsafe bool scrollBars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollBars);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollBars)) = flag;
		}
	}

	public unsafe ScrollRect.MovementType scrollRestrcition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollRestrcition);
			return *(ScrollRect.MovementType*)num;
		}
		set
		{
			*(ScrollRect.MovementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollRestrcition)) = movementType;
		}
	}

	public unsafe string displayContentWithTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayContentWithTag);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayContentWithTag)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static WindowTabPreset()
	{
		Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WindowTabPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr);
		NativeFieldInfoPtr_tabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "tabName");
		NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "colour");
		NativeFieldInfoPtr_contentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "contentPrefab");
		NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "contentType");
		NativeFieldInfoPtr_scalableContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "scalableContent");
		NativeFieldInfoPtr_fitToScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "fitToScaleX");
		NativeFieldInfoPtr_fitToScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "fitToScaleY");
		NativeFieldInfoPtr_zoomWithMouseWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "zoomWithMouseWheel");
		NativeFieldInfoPtr_scrollBars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "scrollBars");
		NativeFieldInfoPtr_scrollRestrcition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "scrollRestrcition");
		NativeFieldInfoPtr_displayContentWithTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, "displayContentWithTag");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr, 100674060);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330510, XrefRangeEnd = 330515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WindowTabPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowTabPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WindowTabPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
