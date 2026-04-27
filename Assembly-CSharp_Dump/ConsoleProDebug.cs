using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class ConsoleProDebug : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogToFilter_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Watch_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Search_Public_Static_Void_String_0;

	static ConsoleProDebug()
	{
		Il2CppClassPointerStore<ConsoleProDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ConsoleProDebug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleProDebug>.NativeClassPtr);
		NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleProDebug>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_LogToFilter_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleProDebug>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_Watch_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleProDebug>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_Search_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleProDebug>.NativeClassPtr, 100663745);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9447, XrefRangeEnd = 9456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogToFilter(string inLog, string inFilterName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inLog);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFilterName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogToFilter_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9456, XrefRangeEnd = 9498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Watch(string inName, string inValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inValue);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Watch_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9498, XrefRangeEnd = 9507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Search(string inText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inText);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Search_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ConsoleProDebug(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
