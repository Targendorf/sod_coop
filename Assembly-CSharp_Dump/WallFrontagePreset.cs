using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class WallFrontagePreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_gameObject;

	private static readonly IntPtr NativeFieldInfoPtr_allowStaticBatching;

	private static readonly IntPtr NativeFieldInfoPtr_isRainyWindow;

	private static readonly IntPtr NativeFieldInfoPtr_regularGlass;

	private static readonly IntPtr NativeFieldInfoPtr_rainyGlass;

	private static readonly IntPtr NativeFieldInfoPtr_universalDesignStyle;

	private static readonly IntPtr NativeFieldInfoPtr_designStyles;

	private static readonly IntPtr NativeFieldInfoPtr_inheritColouringFromDecor;

	private static readonly IntPtr NativeFieldInfoPtr_shareColours;

	private static readonly IntPtr NativeFieldInfoPtr_variations;

	private static readonly IntPtr NativeFieldInfoPtr_integratedInteractables;

	private static readonly IntPtr NativeFieldInfoPtr_classes;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject gameObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool allowStaticBatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStaticBatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStaticBatching)) = flag;
		}
	}

	public unsafe bool isRainyWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRainyWindow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRainyWindow)) = flag;
		}
	}

	public unsafe Material regularGlass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularGlass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularGlass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material rainyGlass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainyGlass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainyGlass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe bool universalDesignStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_universalDesignStyle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_universalDesignStyle)) = flag;
		}
	}

	public unsafe List<DesignStylePreset> designStyles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyles);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DesignStylePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool inheritColouringFromDecor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor)) = flag;
		}
	}

	public unsafe FurniturePreset.ShareColours shareColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColours);
			return *(FurniturePreset.ShareColours*)num;
		}
		set
		{
			*(FurniturePreset.ShareColours*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColours)) = shareColours;
		}
	}

	public unsafe List<MaterialGroupPreset.MaterialVariation> variations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variations);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialGroupPreset.MaterialVariation>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FurniturePreset.IntegratedInteractable> integratedInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integratedInteractables);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<FurniturePreset.IntegratedInteractable>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integratedInteractables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WallFrontageClass> classes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<WallFrontageClass>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static WallFrontagePreset()
	{
		Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WallFrontagePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr);
		NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "gameObject");
		NativeFieldInfoPtr_allowStaticBatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "allowStaticBatching");
		NativeFieldInfoPtr_isRainyWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "isRainyWindow");
		NativeFieldInfoPtr_regularGlass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "regularGlass");
		NativeFieldInfoPtr_rainyGlass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "rainyGlass");
		NativeFieldInfoPtr_universalDesignStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "universalDesignStyle");
		NativeFieldInfoPtr_designStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "designStyles");
		NativeFieldInfoPtr_inheritColouringFromDecor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "inheritColouringFromDecor");
		NativeFieldInfoPtr_shareColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "shareColours");
		NativeFieldInfoPtr_variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "variations");
		NativeFieldInfoPtr_integratedInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "integratedInteractables");
		NativeFieldInfoPtr_classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, "classes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr, 100674058);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330476, XrefRangeEnd = 330502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WallFrontagePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallFrontagePreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WallFrontagePreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
