using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class RoomTypeFilter : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_roomClasses;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<RoomClassPreset> roomClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomClasses);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RoomClassPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static RoomTypeFilter()
	{
		Il2CppClassPointerStore<RoomTypeFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoomTypeFilter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomTypeFilter>.NativeClassPtr);
		NativeFieldInfoPtr_roomClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTypeFilter>.NativeClassPtr, "roomClasses");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomTypeFilter>.NativeClassPtr, 100674029);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330151, XrefRangeEnd = 330159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoomTypeFilter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomTypeFilter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoomTypeFilter(IntPtr pointer)
		: base(pointer)
	{
	}
}
