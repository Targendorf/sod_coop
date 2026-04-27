using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class TwitchAuthLandingPages : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SuccessLandingPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_RejectedLandingPage;

	public unsafe static string SuccessLandingPage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SuccessLandingPage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SuccessLandingPage, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RejectedLandingPage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RejectedLandingPage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RejectedLandingPage, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static TwitchAuthLandingPages()
	{
		Il2CppClassPointerStore<TwitchAuthLandingPages>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TwitchAuthLandingPages");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitchAuthLandingPages>.NativeClassPtr);
		NativeFieldInfoPtr_SuccessLandingPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAuthLandingPages>.NativeClassPtr, "SuccessLandingPage");
		NativeFieldInfoPtr_RejectedLandingPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchAuthLandingPages>.NativeClassPtr, "RejectedLandingPage");
	}

	public TwitchAuthLandingPages(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
