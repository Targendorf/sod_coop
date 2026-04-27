using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

public class ShopSelectButtonController : ButtonController
{
	private static readonly IntPtr NativeFieldInfoPtr_preset;

	private static readonly IntPtr NativeFieldInfoPtr_sellInteractable;

	private static readonly IntPtr NativeFieldInfoPtr_syncDisk;

	private static readonly IntPtr NativeFieldInfoPtr_price;

	private static readonly IntPtr NativeFieldInfoPtr_priceText;

	private static readonly IntPtr NativeFieldInfoPtr_specialText;

	private static readonly IntPtr NativeFieldInfoPtr_thisWindow;

	private static readonly IntPtr NativeFieldInfoPtr_buyController;

	private static readonly IntPtr NativeFieldInfoPtr_mainImage;

	private static readonly IntPtr NativeFieldInfoPtr_todayOnly;

	private static readonly IntPtr NativeFieldInfoPtr_sellMode;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_InteractablePreset_Int32_BuyInterfaceController_InfoWindow_SyncDiskPreset_Boolean_Interactable_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonText_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateTooltip_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLeftClick_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PurchaseExecute_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SellExecute_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdatePurchaseAbility_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__UpdateButtonText_b__12_0_Private_Boolean_FineRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr__SellExecute_b__16_0_Private_Boolean_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr__UpdatePurchaseAbility_b__18_0_Private_Boolean_FineRecord_0;

	public unsafe InteractablePreset preset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe Interactable sellInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellInteractable);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe SyncDiskPreset syncDisk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDisk);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SyncDiskPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDisk)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syncDiskPreset));
		}
	}

	public unsafe int price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
		}
	}

	public unsafe TextMeshProUGUI priceText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priceText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priceText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI specialText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe InfoWindow thisWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisWindow);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InfoWindow>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisWindow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)infoWindow));
		}
	}

	public unsafe BuyInterfaceController buyController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BuyInterfaceController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buyInterfaceController));
		}
	}

	public unsafe Image mainImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe bool todayOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_todayOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_todayOnly)) = flag;
		}
	}

	public unsafe bool sellMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellMode)) = flag;
		}
	}

	static ShopSelectButtonController()
	{
		Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShopSelectButtonController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr);
		NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "preset");
		NativeFieldInfoPtr_sellInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "sellInteractable");
		NativeFieldInfoPtr_syncDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "syncDisk");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "price");
		NativeFieldInfoPtr_priceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "priceText");
		NativeFieldInfoPtr_specialText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "specialText");
		NativeFieldInfoPtr_thisWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "thisWindow");
		NativeFieldInfoPtr_buyController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "buyController");
		NativeFieldInfoPtr_mainImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "mainImage");
		NativeFieldInfoPtr_todayOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "todayOnly");
		NativeFieldInfoPtr_sellMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, "sellMode");
		NativeMethodInfoPtr_Setup_Public_Void_InteractablePreset_Int32_BuyInterfaceController_InfoWindow_SyncDiskPreset_Boolean_Interactable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672102);
		NativeMethodInfoPtr_UpdateButtonText_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672103);
		NativeMethodInfoPtr_UpdateTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672104);
		NativeMethodInfoPtr_OnLeftClick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672105);
		NativeMethodInfoPtr_PurchaseExecute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672106);
		NativeMethodInfoPtr_SellExecute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672107);
		NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672108);
		NativeMethodInfoPtr_UpdatePurchaseAbility_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672109);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672110);
		NativeMethodInfoPtr__UpdateButtonText_b__12_0_Private_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672111);
		NativeMethodInfoPtr__SellExecute_b__16_0_Private_Boolean_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672112);
		NativeMethodInfoPtr__UpdatePurchaseAbility_b__18_0_Private_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr, 100672113);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 286929, RefRangeEnd = 286933, XrefRangeStart = 286927, XrefRangeEnd = 286929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(InteractablePreset newPreset, int newPrice, BuyInterfaceController newBuyController, InfoWindow newThisWindow, SyncDiskPreset newSyncDisk = null, bool newTemp = false, Interactable newSellInteractable = null, bool newSellMode = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &newPrice;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newBuyController);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newThisWindow);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSyncDisk);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &newTemp;
		*(IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSellInteractable);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &newSellMode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_InteractablePreset_Int32_BuyInterfaceController_InfoWindow_SyncDiskPreset_Boolean_Interactable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286933, XrefRangeEnd = 286999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateButtonText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateButtonText_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 287080, RefRangeEnd = 287081, XrefRangeStart = 286999, XrefRangeEnd = 287080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTooltip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287081, XrefRangeEnd = 287148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnLeftClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnLeftClick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287148, XrefRangeEnd = 287185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PurchaseExecute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PurchaseExecute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287185, XrefRangeEnd = 287211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SellExecute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SellExecute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287211, XrefRangeEnd = 287238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 287271, RefRangeEnd = 287272, XrefRangeStart = 287238, XrefRangeEnd = 287271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePurchaseAbility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePurchaseAbility_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShopSelectButtonController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopSelectButtonController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _UpdateButtonText_b__12_0(StatusController.FineRecord item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateButtonText_b__12_0_Private_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _SellExecute_b__16_0(FirstPersonItemController.InventorySlot item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SellExecute_b__16_0_Private_Boolean_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _UpdatePurchaseAbility_b__18_0(StatusController.FineRecord item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdatePurchaseAbility_b__18_0_Private_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ShopSelectButtonController(IntPtr pointer)
		: base(pointer)
	{
	}
}
