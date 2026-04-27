using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityEditorStreetEdit : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_streetListElementPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_streetSelectionDisplayPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_streetMouseOverDisplayPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_streetListContentRect;

	private static readonly IntPtr NativeFieldInfoPtr_listLayout;

	private static readonly IntPtr NativeFieldInfoPtr_currentlySelectedStreet;

	private static readonly IntPtr NativeFieldInfoPtr_currentlyMousedOverStreet;

	private static readonly IntPtr NativeFieldInfoPtr_previouslyMousedOverStreet;

	private static readonly IntPtr NativeFieldInfoPtr_spawnedStreetListElements;

	private static readonly IntPtr NativeFieldInfoPtr_spawnedStreetSelectionObjects;

	private static readonly IntPtr NativeFieldInfoPtr_spawnedStreetMouseOverObjects;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetStreets_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TryGetStreet_Private_StreetController_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSelectedStreet_Public_Void_StreetController_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawStreetSelection_Private_Void_StreetController_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveStreetSelection_Private_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RenameSelectedStreet_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetSelection_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnGenerateNewCityMap_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RepopulateStreetList_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject streetListElementPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetListElementPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetListElementPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject streetSelectionDisplayPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetSelectionDisplayPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetSelectionDisplayPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject streetMouseOverDisplayPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetMouseOverDisplayPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetMouseOverDisplayPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe RectTransform streetListContentRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetListContentRect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetListContentRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe VerticalLayoutGroup listLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listLayout);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listLayout)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verticalLayoutGroup));
		}
	}

	public unsafe StreetController currentlySelectedStreet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlySelectedStreet);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StreetController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlySelectedStreet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streetController));
		}
	}

	public unsafe StreetController currentlyMousedOverStreet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyMousedOverStreet);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StreetController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyMousedOverStreet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streetController));
		}
	}

	public unsafe StreetController previouslyMousedOverStreet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previouslyMousedOverStreet);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StreetController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previouslyMousedOverStreet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streetController));
		}
	}

	public unsafe List<CityEditorStreetsEditListElement> spawnedStreetListElements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedStreetListElements);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CityEditorStreetsEditListElement>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedStreetListElements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> spawnedStreetSelectionObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedStreetSelectionObjects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedStreetSelectionObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> spawnedStreetMouseOverObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedStreetMouseOverObjects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedStreetMouseOverObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static CityEditorStreetEdit()
	{
		Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CityEditorStreetEdit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr);
		NativeFieldInfoPtr_streetListElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "streetListElementPrefab");
		NativeFieldInfoPtr_streetSelectionDisplayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "streetSelectionDisplayPrefab");
		NativeFieldInfoPtr_streetMouseOverDisplayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "streetMouseOverDisplayPrefab");
		NativeFieldInfoPtr_streetListContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "streetListContentRect");
		NativeFieldInfoPtr_listLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "listLayout");
		NativeFieldInfoPtr_currentlySelectedStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "currentlySelectedStreet");
		NativeFieldInfoPtr_currentlyMousedOverStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "currentlyMousedOverStreet");
		NativeFieldInfoPtr_previouslyMousedOverStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "previouslyMousedOverStreet");
		NativeFieldInfoPtr_spawnedStreetListElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "spawnedStreetListElements");
		NativeFieldInfoPtr_spawnedStreetSelectionObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "spawnedStreetSelectionObjects");
		NativeFieldInfoPtr_spawnedStreetMouseOverObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, "spawnedStreetMouseOverObjects");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666437);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666438);
		NativeMethodInfoPtr_ResetStreets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666439);
		NativeMethodInfoPtr_TryGetStreet_Private_StreetController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666440);
		NativeMethodInfoPtr_SetSelectedStreet_Public_Void_StreetController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666441);
		NativeMethodInfoPtr_DrawStreetSelection_Private_Void_StreetController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666442);
		NativeMethodInfoPtr_RemoveStreetSelection_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666443);
		NativeMethodInfoPtr_RenameSelectedStreet_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666444);
		NativeMethodInfoPtr_ResetSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666445);
		NativeMethodInfoPtr_OnGenerateNewCityMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666446);
		NativeMethodInfoPtr_RepopulateStreetList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666447);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666448);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr, 100666449);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108800, XrefRangeEnd = 108829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108829, XrefRangeEnd = 108887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108902, RefRangeEnd = 108903, XrefRangeStart = 108887, XrefRangeEnd = 108902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetStreets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetStreets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108926, RefRangeEnd = 108927, XrefRangeStart = 108903, XrefRangeEnd = 108926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StreetController TryGetStreet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetStreet_Private_StreetController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StreetController>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 108937, RefRangeEnd = 108941, XrefRangeStart = 108927, XrefRangeEnd = 108937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectedStreet(StreetController newSt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSt);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedStreet_Public_Void_StreetController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 108980, RefRangeEnd = 108982, XrefRangeStart = 108941, XrefRangeEnd = 108980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawStreetSelection(StreetController street, bool isMouseOver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)street);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isMouseOver;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawStreetSelection_Private_Void_StreetController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 109020, RefRangeEnd = 109025, XrefRangeStart = 108982, XrefRangeEnd = 109020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveStreetSelection(bool isMouseOver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isMouseOver);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveStreetSelection_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109025, XrefRangeEnd = 109044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenameSelectedStreet(string newStreetName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newStreetName);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenameSelectedStreet_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109044, XrefRangeEnd = 109045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109045, XrefRangeEnd = 109052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGenerateNewCityMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGenerateNewCityMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109092, XrefRangeStart = 109052, XrefRangeEnd = 109090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RepopulateStreetList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RepopulateStreetList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109092, XrefRangeEnd = 109121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109121, XrefRangeEnd = 109140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CityEditorStreetEdit()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CityEditorStreetEdit>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CityEditorStreetEdit(IntPtr pointer)
		: base(pointer)
	{
	}
}
