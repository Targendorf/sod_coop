using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

[Serializable]
public class SideJobAffair : SideJob
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JobPreset_JobPickData_Boolean_0;

	static SideJobAffair()
	{
		Il2CppClassPointerStore<SideJobAffair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SideJobAffair");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SideJobAffair>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_JobPreset_JobPickData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideJobAffair>.NativeClassPtr, 100668309);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169555, XrefRangeEnd = 169559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SideJobAffair(JobPreset newPreset, SideJobController.JobPickData newData, bool immediatePost)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideJobAffair>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &immediatePost;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_JobPreset_JobPickData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SideJobAffair(IntPtr pointer)
		: base(pointer)
	{
	}
}
