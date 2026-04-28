using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class TwitchUserData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_user_name;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string user_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_user_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_user_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static TwitchUserData()
	{
		Il2CppClassPointerStore<TwitchUserData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TwitchUserData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitchUserData>.NativeClassPtr);
		NativeFieldInfoPtr_user_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchUserData>.NativeClassPtr, "user_name");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchUserData>.NativeClassPtr, 100670486);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitchUserData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitchUserData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TwitchUserData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
