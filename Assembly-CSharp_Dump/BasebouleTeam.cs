using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class BasebouleTeam : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_teamName;

	private static readonly IntPtr NativeFieldInfoPtr_teamIntroductionWhenFirstInLineUp;

	private static readonly IntPtr NativeFieldInfoPtr_teamIntroductionWhenSecondInLineUp;

	private static readonly IntPtr NativeFieldInfoPtr_roster;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string teamName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string teamIntroductionWhenFirstInLineUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamIntroductionWhenFirstInLineUp);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamIntroductionWhenFirstInLineUp)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string teamIntroductionWhenSecondInLineUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamIntroductionWhenSecondInLineUp);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamIntroductionWhenSecondInLineUp)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<BaseboulePlayer> roster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roster);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<BaseboulePlayer>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roster)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static BasebouleTeam()
	{
		Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasebouleTeam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr);
		NativeFieldInfoPtr_teamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr, "teamName");
		NativeFieldInfoPtr_teamIntroductionWhenFirstInLineUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr, "teamIntroductionWhenFirstInLineUp");
		NativeFieldInfoPtr_teamIntroductionWhenSecondInLineUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr, "teamIntroductionWhenSecondInLineUp");
		NativeFieldInfoPtr_roster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr, "roster");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr, 100673807);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BasebouleTeam()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasebouleTeam>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BasebouleTeam(IntPtr pointer)
		: base(pointer)
	{
	}
}
