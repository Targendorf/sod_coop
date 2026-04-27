using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CruncherSurveillanceActorEntry : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_rect;

	private static readonly IntPtr NativeFieldInfoPtr_headshotImg;

	private static readonly IntPtr NativeFieldInfoPtr_loadedHeadshot;

	private static readonly IntPtr NativeFieldInfoPtr_component;

	private static readonly IntPtr NativeFieldInfoPtr_namePopup;

	private static readonly IntPtr NativeFieldInfoPtr_popupText;

	private static readonly IntPtr NativeFieldInfoPtr_appParent;

	private static readonly IntPtr NativeFieldInfoPtr_human;

	private static readonly IntPtr NativeFieldInfoPtr_isOver;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_SurveillanceApp_Human_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadHeadshot_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetOnOver_Public_Void_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Press_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__SetOnOver_b__11_0_Private_Boolean_ActorCapture_0;

	public unsafe RectTransform rect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RawImage headshotImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headshotImg);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RawImage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headshotImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawImage));
		}
	}

	public unsafe bool loadedHeadshot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedHeadshot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedHeadshot)) = flag;
		}
	}

	public unsafe ComputerOSUIComponent component
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_component);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ComputerOSUIComponent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_component)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computerOSUIComponent));
		}
	}

	public unsafe RectTransform namePopup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namePopup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namePopup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe TextMeshProUGUI popupText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_popupText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_popupText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe SurveillanceApp appParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SurveillanceApp>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)surveillanceApp));
		}
	}

	public unsafe Human human
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe bool isOver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOver);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOver)) = flag;
		}
	}

	static CruncherSurveillanceActorEntry()
	{
		Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CruncherSurveillanceActorEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr);
		NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "rect");
		NativeFieldInfoPtr_headshotImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "headshotImg");
		NativeFieldInfoPtr_loadedHeadshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "loadedHeadshot");
		NativeFieldInfoPtr_component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "component");
		NativeFieldInfoPtr_namePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "namePopup");
		NativeFieldInfoPtr_popupText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "popupText");
		NativeFieldInfoPtr_appParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "appParent");
		NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "human");
		NativeFieldInfoPtr_isOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, "isOver");
		NativeMethodInfoPtr_Setup_Public_Void_SurveillanceApp_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, 100667377);
		NativeMethodInfoPtr_LoadHeadshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, 100667378);
		NativeMethodInfoPtr_SetOnOver_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, 100667379);
		NativeMethodInfoPtr_UpdateText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, 100667380);
		NativeMethodInfoPtr_Press_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, 100667381);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, 100667382);
		NativeMethodInfoPtr__SetOnOver_b__11_0_Private_Boolean_ActorCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr, 100667383);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 139445, RefRangeEnd = 139446, XrefRangeStart = 139433, XrefRangeEnd = 139445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(SurveillanceApp newParent, Human newHuman)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newParent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHuman);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_SurveillanceApp_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139446, XrefRangeEnd = 139457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadHeadshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadHeadshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 139486, RefRangeEnd = 139489, XrefRangeStart = 139457, XrefRangeEnd = 139486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOnOver(bool val, bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&val);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &forceUpdate;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOnOver_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 139533, RefRangeEnd = 139535, XrefRangeStart = 139489, XrefRangeEnd = 139533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139535, XrefRangeEnd = 139537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Press()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Press_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CruncherSurveillanceActorEntry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CruncherSurveillanceActorEntry>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _SetOnOver_b__11_0(SceneRecorder.ActorCapture item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetOnOver_b__11_0_Private_Boolean_ActorCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CruncherSurveillanceActorEntry(IntPtr pointer)
		: base(pointer)
	{
	}
}
