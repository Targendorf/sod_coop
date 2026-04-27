using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class DBWitnessStatement : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DBWitnessStatement()
	{
		Il2CppClassPointerStore<DBWitnessStatement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DBWitnessStatement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBWitnessStatement>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBWitnessStatement>.NativeClassPtr, 100673198);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DBWitnessStatement()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBWitnessStatement>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DBWitnessStatement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
