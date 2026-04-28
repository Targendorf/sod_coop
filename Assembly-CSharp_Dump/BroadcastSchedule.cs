using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class BroadcastSchedule : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_broadcasts;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<BroadcastPreset> broadcasts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_broadcasts);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BroadcastPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_broadcasts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static BroadcastSchedule()
	{
		Il2CppClassPointerStore<BroadcastSchedule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BroadcastSchedule");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastSchedule>.NativeClassPtr);
		NativeFieldInfoPtr_broadcasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastSchedule>.NativeClassPtr, "broadcasts");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastSchedule>.NativeClassPtr, 100673814);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326922, XrefRangeEnd = 326930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BroadcastSchedule()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BroadcastSchedule>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BroadcastSchedule(IntPtr pointer)
		: base(pointer)
	{
	}
}
