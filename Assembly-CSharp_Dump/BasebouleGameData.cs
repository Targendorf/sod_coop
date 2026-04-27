using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class BasebouleGameData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_homeTeamScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_awayTeamSore;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int homeTeamScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeTeamScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeTeamScore)) = num;
		}
	}

	public unsafe int awayTeamSore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awayTeamSore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awayTeamSore)) = num;
		}
	}

	static BasebouleGameData()
	{
		Il2CppClassPointerStore<BasebouleGameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasebouleGameData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasebouleGameData>.NativeClassPtr);
		NativeFieldInfoPtr_homeTeamScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleGameData>.NativeClassPtr, "homeTeamScore");
		NativeFieldInfoPtr_awayTeamSore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleGameData>.NativeClassPtr, "awayTeamSore");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleGameData>.NativeClassPtr, 100673792);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BasebouleGameData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasebouleGameData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BasebouleGameData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
