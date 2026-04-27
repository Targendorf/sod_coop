using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class BreakerController : DoorMovementController
{
	private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Single_Actor_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BreakerController()
	{
		Il2CppClassPointerStore<BreakerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BreakerController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BreakerController>.NativeClassPtr);
		NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Single_Actor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreakerController>.NativeClassPtr, 100666861);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreakerController>.NativeClassPtr, 100666862);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119393, XrefRangeEnd = 119397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetOpen(float newAjar, Actor interactor, bool skipAnimation = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&newAjar);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactor);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &skipAnimation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Single_Actor_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119397, XrefRangeEnd = 119398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BreakerController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BreakerController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BreakerController(IntPtr pointer)
		: base(pointer)
	{
	}
}
