using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace FlyingWormConsole3;

public class ConsoleProRemoteServer : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_useNATPunch;

	private static readonly IntPtr NativeFieldInfoPtr_port;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool useNATPunch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNATPunch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useNATPunch)) = flag;
		}
	}

	public unsafe int port
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_port);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_port)) = num;
		}
	}

	static ConsoleProRemoteServer()
	{
		Il2CppClassPointerStore<ConsoleProRemoteServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FlyingWormConsole3", "ConsoleProRemoteServer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleProRemoteServer>.NativeClassPtr);
		NativeFieldInfoPtr_useNATPunch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleProRemoteServer>.NativeClassPtr, "useNATPunch");
		NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleProRemoteServer>.NativeClassPtr, "port");
		NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleProRemoteServer>.NativeClassPtr, 100677466);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleProRemoteServer>.NativeClassPtr, 100677467);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380846, XrefRangeEnd = 380852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380852, XrefRangeEnd = 380855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConsoleProRemoteServer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleProRemoteServer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ConsoleProRemoteServer(IntPtr pointer)
		: base(pointer)
	{
	}
}
