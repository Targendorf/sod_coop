using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class EffectPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_firstValueIsPercentageIncrease;

	private static readonly IntPtr NativeFieldInfoPtr_runActivationOnUpdate;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool firstValueIsPercentageIncrease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstValueIsPercentageIncrease);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstValueIsPercentageIncrease)) = flag;
		}
	}

	public unsafe bool runActivationOnUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runActivationOnUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runActivationOnUpdate)) = flag;
		}
	}

	static EffectPreset()
	{
		Il2CppClassPointerStore<EffectPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EffectPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPreset>.NativeClassPtr);
		NativeFieldInfoPtr_firstValueIsPercentageIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPreset>.NativeClassPtr, "firstValueIsPercentageIncrease");
		NativeFieldInfoPtr_runActivationOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPreset>.NativeClassPtr, "runActivationOnUpdate");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPreset>.NativeClassPtr, 100673886);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EffectPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EffectPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
