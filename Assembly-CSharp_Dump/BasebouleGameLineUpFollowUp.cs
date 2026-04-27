using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class BasebouleGameLineUpFollowUp : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_followUpText;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string followUpText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followUpText);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followUpText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static BasebouleGameLineUpFollowUp()
	{
		Il2CppClassPointerStore<BasebouleGameLineUpFollowUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasebouleGameLineUpFollowUp");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasebouleGameLineUpFollowUp>.NativeClassPtr);
		NativeFieldInfoPtr_followUpText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleGameLineUpFollowUp>.NativeClassPtr, "followUpText");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleGameLineUpFollowUp>.NativeClassPtr, 100673795);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BasebouleGameLineUpFollowUp()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasebouleGameLineUpFollowUp>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BasebouleGameLineUpFollowUp(IntPtr pointer)
		: base(pointer)
	{
	}
}
