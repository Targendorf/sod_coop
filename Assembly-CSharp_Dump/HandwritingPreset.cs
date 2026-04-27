using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;

public class HandwritingPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

	private static readonly IntPtr NativeFieldInfoPtr_baseChance;

	private static readonly IntPtr NativeFieldInfoPtr_characterTraits;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TMP_FontAsset fontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_FontAsset));
		}
	}

	public unsafe float baseChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance)) = num;
		}
	}

	public unsafe List<CharacterTrait.TraitPickRule> characterTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraits);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static HandwritingPreset()
	{
		Il2CppClassPointerStore<HandwritingPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HandwritingPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandwritingPreset>.NativeClassPtr);
		NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandwritingPreset>.NativeClassPtr, "fontAsset");
		NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandwritingPreset>.NativeClassPtr, "baseChance");
		NativeFieldInfoPtr_characterTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandwritingPreset>.NativeClassPtr, "characterTraits");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandwritingPreset>.NativeClassPtr, 100673931);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328909, XrefRangeEnd = 328917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HandwritingPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandwritingPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HandwritingPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
