using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class NewspaperArticle : SoCustomComparison
{
	public enum Category
	{
		general,
		murder,
		ad,
		foreignAffairs,
		murderSecond
	}

	public enum ContextSource
	{
		nothing,
		lastMurder,
		player,
		randomCitizen,
		randomCriminal,
		randomGroup
	}

	private static readonly IntPtr NativeFieldInfoPtr_disabled;

	private static readonly IntPtr NativeFieldInfoPtr_ddsReference;

	private static readonly IntPtr NativeFieldInfoPtr_category;

	private static readonly IntPtr NativeFieldInfoPtr_followupStories;

	private static readonly IntPtr NativeFieldInfoPtr_context;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool disabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)) = flag;
		}
	}

	public unsafe string ddsReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsReference);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsReference)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Category category
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
			return *(Category*)num;
		}
		set
		{
			*(Category*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)) = category;
		}
	}

	public unsafe List<NewspaperArticle> followupStories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followupStories);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<NewspaperArticle>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followupStories)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ContextSource context
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context);
			return *(ContextSource*)num;
		}
		set
		{
			*(ContextSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_context)) = contextSource;
		}
	}

	static NewspaperArticle()
	{
		Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NewspaperArticle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr);
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_ddsReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr, "ddsReference");
		NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr, "category");
		NativeFieldInfoPtr_followupStories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr, "followupStories");
		NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr, "context");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr, 100674002);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329778, XrefRangeEnd = 329786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewspaperArticle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewspaperArticle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NewspaperArticle(IntPtr pointer)
		: base(pointer)
	{
	}
}
