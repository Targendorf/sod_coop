using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

public class CanvasScalerExt : CanvasScaler
{
	private static readonly IntPtr NativeMethodInfoPtr_ForceRefresh_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CanvasScalerExt()
	{
		Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "CanvasScalerExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr);
		NativeMethodInfoPtr_ForceRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr, 100675277);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr, 100675278);
	}

	[CallerCount(0)]
	public unsafe void ForceRefresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352088, XrefRangeEnd = 352091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanvasScalerExt()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CanvasScalerExt(IntPtr pointer)
		: base(pointer)
	{
	}
}
