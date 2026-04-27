using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class RoomClassPreset : SoCustomComparison
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RoomClassPreset()
	{
		Il2CppClassPointerStore<RoomClassPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoomClassPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomClassPreset>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomClassPreset>.NativeClassPtr, 100674022);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoomClassPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomClassPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoomClassPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
