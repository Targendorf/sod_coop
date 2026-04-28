using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace BrainFailProductions.PolyFew.AsImpL;

public class LoadingProgress : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_singleProgress;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<SingleLoadingProgress> singleProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleProgress);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SingleLoadingProgress>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleProgress)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static LoadingProgress()
	{
		Il2CppClassPointerStore<LoadingProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "LoadingProgress");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingProgress>.NativeClassPtr);
		NativeFieldInfoPtr_singleProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingProgress>.NativeClassPtr, "singleProgress");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingProgress>.NativeClassPtr, 100677180);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374537, XrefRangeEnd = 374543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadingProgress()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingProgress>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LoadingProgress(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
