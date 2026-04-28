using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Rewired.UI.ControlMapper;

public class ToggleInfo : InputFieldInfo
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ToggleInfo()
	{
		Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ToggleInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr, 100676316);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToggleInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ToggleInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
