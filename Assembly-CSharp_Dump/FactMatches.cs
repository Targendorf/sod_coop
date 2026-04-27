using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class FactMatches : Fact
{
	private static readonly System.IntPtr NativeFieldInfoPtr_matchPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeRangeDifference;

	private static readonly System.IntPtr NativeFieldInfoPtr_travelTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_closest1;

	private static readonly System.IntPtr NativeFieldInfoPtr_closest2;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FactPreset_List_1_Evidence_List_1_Evidence_List_1_Object_List_1_DataKey_List_1_DataKey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchCheck_Public_Static_Boolean_MatchPreset_Evidence_Evidence_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNameSuffix_Public_Virtual_String_0;

	public unsafe MatchPreset matchPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchPreset));
		}
	}

	public unsafe float timeRangeDifference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRangeDifference);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRangeDifference)) = num;
		}
	}

	public unsafe float travelTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelTime)) = num;
		}
	}

	public unsafe NewNode closest1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closest1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closest1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe NewNode closest2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closest2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closest2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	static FactMatches()
	{
		Il2CppClassPointerStore<FactMatches>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FactMatches");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactMatches>.NativeClassPtr);
		NativeFieldInfoPtr_matchPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, "matchPreset");
		NativeFieldInfoPtr_timeRangeDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, "timeRangeDifference");
		NativeFieldInfoPtr_travelTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, "travelTime");
		NativeFieldInfoPtr_closest1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, "closest1");
		NativeFieldInfoPtr_closest2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, "closest2");
		NativeMethodInfoPtr__ctor_Public_Void_FactPreset_List_1_Evidence_List_1_Evidence_List_1_Object_List_1_DataKey_List_1_DataKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, 100673578);
		NativeMethodInfoPtr_MatchCheck_Public_Static_Boolean_MatchPreset_Evidence_Evidence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, 100673579);
		NativeMethodInfoPtr_GenerateNameSuffix_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactMatches>.NativeClassPtr, 100673580);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320771, XrefRangeEnd = 320775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FactMatches(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<Il2CppSystem.Object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactMatches>.NativeClassPtr))
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 320857, RefRangeEnd = 320858, XrefRangeStart = 320775, XrefRangeEnd = 320857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchCheck(MatchPreset match, Evidence matchFrom, Evidence matchTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchFrom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchTo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchCheck_Public_Static_Boolean_MatchPreset_Evidence_Evidence_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320858, XrefRangeEnd = 320860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GenerateNameSuffix()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateNameSuffix_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public FactMatches(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
