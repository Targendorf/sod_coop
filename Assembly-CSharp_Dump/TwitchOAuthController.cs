using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class TwitchOAuthController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_TwitchAuthUrl;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClientID;

	private static readonly System.IntPtr NativeFieldInfoPtr_TwitchRedirectURL;

	private static readonly System.IntPtr NativeFieldInfoPtr__twitchAuthStateVerify;

	private static readonly System.IntPtr NativeFieldInfoPtr__authToken;

	private static readonly System.IntPtr NativeFieldInfoPtr__tokenQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr__hasAuth;

	private static readonly System.IntPtr NativeFieldInfoPtr__tryingValidation;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TwitchOAuthController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueAuthorizationToken_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAuthToken_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClientID_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryTwitchAuthorization_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitiateTwitchAuth_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartLocalWebserver_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncomingHttpRequest_Private_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncomingAuth_Private_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static TwitchOAuthController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TwitchOAuthController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)twitchOAuthController));
		}
	}

	public unsafe static string TwitchAuthUrl
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TwitchAuthUrl, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TwitchAuthUrl, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ClientID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClientID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClientID, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TwitchRedirectURL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TwitchRedirectURL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TwitchRedirectURL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _twitchAuthStateVerify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__twitchAuthStateVerify);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__twitchAuthStateVerify)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _authToken
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__authToken);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__authToken)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Queue<string> _tokenQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tokenQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tokenQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe bool _hasAuth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasAuth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasAuth)) = flag;
		}
	}

	public unsafe bool _tryingValidation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tryingValidation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tryingValidation)) = flag;
		}
	}

	public unsafe static TwitchOAuthController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244297, XrefRangeEnd = 244299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_TwitchOAuthController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TwitchOAuthController>(intPtr) : null;
		}
	}

	static TwitchOAuthController()
	{
		Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TwitchOAuthController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr);
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_TwitchAuthUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "TwitchAuthUrl");
		NativeFieldInfoPtr_ClientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "ClientID");
		NativeFieldInfoPtr_TwitchRedirectURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "TwitchRedirectURL");
		NativeFieldInfoPtr__twitchAuthStateVerify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "_twitchAuthStateVerify");
		NativeFieldInfoPtr__authToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "_authToken");
		NativeFieldInfoPtr__tokenQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "_tokenQueue");
		NativeFieldInfoPtr__hasAuth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "_hasAuth");
		NativeFieldInfoPtr__tryingValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, "_tryingValidation");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_TwitchOAuthController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670490);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670491);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670492);
		NativeMethodInfoPtr_QueueAuthorizationToken_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670493);
		NativeMethodInfoPtr_GetAuthToken_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670494);
		NativeMethodInfoPtr_GetClientID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670495);
		NativeMethodInfoPtr_TryTwitchAuthorization_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670496);
		NativeMethodInfoPtr_InitiateTwitchAuth_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670497);
		NativeMethodInfoPtr_StartLocalWebserver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670498);
		NativeMethodInfoPtr_IncomingHttpRequest_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670499);
		NativeMethodInfoPtr_IncomingAuth_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670500);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr, 100670501);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244299, XrefRangeEnd = 244336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244336, XrefRangeEnd = 244357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244357, XrefRangeEnd = 244366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueAuthorizationToken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueAuthorizationToken_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 244372, RefRangeEnd = 244376, XrefRangeStart = 244366, XrefRangeEnd = 244372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAuthToken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAuthToken_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 244385, RefRangeEnd = 244389, XrefRangeStart = 244376, XrefRangeEnd = 244385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetClientID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClientID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244389, XrefRangeEnd = 244390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryTwitchAuthorization()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryTwitchAuthorization_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 244502, RefRangeEnd = 244504, XrefRangeStart = 244390, XrefRangeEnd = 244502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitiateTwitchAuth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitiateTwitchAuth_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 244535, RefRangeEnd = 244536, XrefRangeStart = 244504, XrefRangeEnd = 244535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartLocalWebserver()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartLocalWebserver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244536, XrefRangeEnd = 244626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncomingHttpRequest(Il2CppSystem.IAsyncResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncomingHttpRequest_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244626, XrefRangeEnd = 244678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncomingAuth(Il2CppSystem.IAsyncResult ar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ar);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncomingAuth_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244678, XrefRangeEnd = 244687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitchOAuthController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitchOAuthController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TwitchOAuthController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
