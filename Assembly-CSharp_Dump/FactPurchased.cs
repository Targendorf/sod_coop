using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class FactPurchased : Fact
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sale;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FactPreset_List_1_Evidence_List_1_Evidence_List_1_Object_List_1_DataKey_List_1_DataKey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNameSuffix_Public_Virtual_String_0;

	public unsafe Company.SalesRecord sale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Company.SalesRecord>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)salesRecord));
		}
	}

	static FactPurchased()
	{
		Il2CppClassPointerStore<FactPurchased>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FactPurchased");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactPurchased>.NativeClassPtr);
		NativeFieldInfoPtr_sale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactPurchased>.NativeClassPtr, "sale");
		NativeMethodInfoPtr__ctor_Public_Void_FactPreset_List_1_Evidence_List_1_Evidence_List_1_Object_List_1_DataKey_List_1_DataKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactPurchased>.NativeClassPtr, 100673581);
		NativeMethodInfoPtr_GenerateNameSuffix_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactPurchased>.NativeClassPtr, 100673582);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320860, XrefRangeEnd = 320864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactPurchased(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<Il2CppSystem.Object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactPurchased>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFromEvidence);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newToEvidence);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedObjects);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideFromKeys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideToKeys);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCustomFact;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FactPreset_List_1_Evidence_List_1_Evidence_List_1_Object_List_1_DataKey_List_1_DataKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320864, XrefRangeEnd = 320903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GenerateNameSuffix()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateNameSuffix_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public FactPurchased(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
