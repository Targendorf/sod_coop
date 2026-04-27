using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Steamworks;

[System.Serializable]
public class SteamMod : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_installPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_PublishedFileIdT;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderToLoad;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_PublishedFileId_t_0;

	public unsafe string installPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe PublishedFileId_t PublishedFileIdT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PublishedFileIdT);
			return *(PublishedFileId_t*)num;
		}
		set
		{
			*(PublishedFileId_t*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PublishedFileIdT)) = publishedFileId_t;
		}
	}

	public unsafe bool isEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled)) = flag;
		}
	}

	public unsafe int orderToLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderToLoad);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderToLoad)) = num;
		}
	}

	static SteamMod()
	{
		Il2CppClassPointerStore<SteamMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SteamMod");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMod>.NativeClassPtr);
		NativeFieldInfoPtr_installPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMod>.NativeClassPtr, "installPath");
		NativeFieldInfoPtr_PublishedFileIdT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMod>.NativeClassPtr, "PublishedFileIdT");
		NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMod>.NativeClassPtr, "isEnabled");
		NativeFieldInfoPtr_orderToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMod>.NativeClassPtr, "orderToLoad");
		NativeMethodInfoPtr__ctor_Public_Void_String_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMod>.NativeClassPtr, 100670406);
	}

	[CallerCount(0)]
	public unsafe SteamMod(string path, PublishedFileId_t fileId)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMod>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(PublishedFileId_t**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_PublishedFileId_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SteamMod(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
