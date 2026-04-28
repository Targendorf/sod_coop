using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class StringTooltipController : TooltipController
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static StringTooltipController()
	{
		Il2CppClassPointerStore<StringTooltipController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StringTooltipController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringTooltipController>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringTooltipController>.NativeClassPtr, 100672620);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300598, XrefRangeEnd = 300599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StringTooltipController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringTooltipController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StringTooltipController(IntPtr pointer)
		: base(pointer)
	{
	}
}
