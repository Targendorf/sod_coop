using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class ReflectionProbeController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_probe;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ReflectionProbe probe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probe);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflectionProbe));
		}
	}

	static ReflectionProbeController()
	{
		Il2CppClassPointerStore<ReflectionProbeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ReflectionProbeController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeController>.NativeClassPtr);
		NativeFieldInfoPtr_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeController>.NativeClassPtr, "probe");
		NativeMethodInfoPtr_Setup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeController>.NativeClassPtr, 100666175);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeController>.NativeClassPtr, 100666176);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102185, XrefRangeEnd = 102189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReflectionProbeController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ReflectionProbeController(IntPtr pointer)
		: base(pointer)
	{
	}
}
