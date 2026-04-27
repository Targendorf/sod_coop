using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class TwitchAudienceData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_user_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_login;

	private static readonly System.IntPtr NativeFieldInfoPtr__links;

	private static readonly System.IntPtr NativeFieldInfoPtr_chatter_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_chatters;

	private static readonly System.IntPtr NativeFieldInfoPtr_followers;

	private static readonly System.IntPtr NativeFieldInfoPtr_chattersNew;

	private static readonly System.IntPtr NativeFieldInfoPtr_vipsNew;

	private static readonly System.IntPtr NativeFieldInfoPtr_moderatorsNew;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string user_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_user_id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_user_id)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string login
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_login);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_login)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _links
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__links);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__links)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int chatter_count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chatter_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chatter_count)) = num;
		}
	}

	public unsafe Chatters chatters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chatters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Chatters>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chatters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatters));
		}
	}

	public unsafe TwitchRootObject followers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TwitchRootObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)twitchRootObject));
		}
	}

	public unsafe TwitchRootObject chattersNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chattersNew);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TwitchRootObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chattersNew)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)twitchRootObject));
		}
	}

	public unsafe TwitchRootObject vipsNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vipsNew);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TwitchRootObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vipsNew)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)twitchRootObject));
		}
	}

	public unsafe TwitchRootObject moderatorsNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moderatorsNew);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TwitchRootObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moderatorsNew)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)twitchRootObject));
		}
	}

	static TwitchAudienceData()
	{
		Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TwitchAudienceData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr);
		NativeFieldInfoPtr_user_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "user_id");
		NativeFieldInfoPtr_login = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "login");
		NativeFieldInfoPtr__links = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "_links");
		NativeFieldInfoPtr_chatter_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "chatter_count");
		NativeFieldInfoPtr_chatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "chatters");
		NativeFieldInfoPtr_followers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "followers");
		NativeFieldInfoPtr_chattersNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "chattersNew");
		NativeFieldInfoPtr_vipsNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "vipsNew");
		NativeFieldInfoPtr_moderatorsNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, "moderatorsNew");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr, 100670487);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitchAudienceData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitchAudienceData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TwitchAudienceData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
