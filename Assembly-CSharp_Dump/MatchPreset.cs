using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class MatchPreset : SoCustomComparison
{
	public enum MatchCondition
	{
		bloodGroup,
		fingerprint,
		time,
		visualDescriptors,
		retailPresetMatch,
		murderWeapon
	}

	private static readonly IntPtr NativeFieldInfoPtr_canOnlyBeMatchedWith;

	private static readonly IntPtr NativeFieldInfoPtr_matchConditions;

	private static readonly IntPtr NativeFieldInfoPtr_onlyMatchWithMatchParents;

	private static readonly IntPtr NativeFieldInfoPtr_canMatchWithItself;

	private static readonly IntPtr NativeFieldInfoPtr_onlyMatchWithThis;

	private static readonly IntPtr NativeFieldInfoPtr_linkFromKeys;

	private static readonly IntPtr NativeFieldInfoPtr_linkToKeys;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool canOnlyBeMatchedWith
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canOnlyBeMatchedWith);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canOnlyBeMatchedWith)) = flag;
		}
	}

	public unsafe List<MatchCondition> matchConditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchConditions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MatchCondition>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool onlyMatchWithMatchParents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyMatchWithMatchParents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyMatchWithMatchParents)) = flag;
		}
	}

	public unsafe bool canMatchWithItself
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canMatchWithItself);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canMatchWithItself)) = flag;
		}
	}

	public unsafe MatchPreset onlyMatchWithThis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyMatchWithThis);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MatchPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyMatchWithThis)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchPreset));
		}
	}

	public unsafe List<Evidence.DataKey> linkFromKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkFromKeys);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkFromKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Evidence.DataKey> linkToKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkToKeys);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkToKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static MatchPreset()
	{
		Il2CppClassPointerStore<MatchPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MatchPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr);
		NativeFieldInfoPtr_canOnlyBeMatchedWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, "canOnlyBeMatchedWith");
		NativeFieldInfoPtr_matchConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, "matchConditions");
		NativeFieldInfoPtr_onlyMatchWithMatchParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, "onlyMatchWithMatchParents");
		NativeFieldInfoPtr_canMatchWithItself = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, "canMatchWithItself");
		NativeFieldInfoPtr_onlyMatchWithThis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, "onlyMatchWithThis");
		NativeFieldInfoPtr_linkFromKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, "linkFromKeys");
		NativeFieldInfoPtr_linkToKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, "linkToKeys");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr, 100673976);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329341, XrefRangeEnd = 329359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MatchPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MatchPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
