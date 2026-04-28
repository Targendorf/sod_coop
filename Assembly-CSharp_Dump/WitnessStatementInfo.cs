using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class WitnessStatementInfo : Il2CppSystem.Object
{
	public enum StatementType
	{
		Alibi,
		knowVictim
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_citizen;

	private static readonly System.IntPtr NativeFieldInfoPtr_statementType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Citizen_StatementType_0;

	public unsafe Citizen citizen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizen);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Citizen>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizen));
		}
	}

	public unsafe StatementType statementType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statementType);
			return *(StatementType*)num;
		}
		set
		{
			*(StatementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statementType)) = statementType;
		}
	}

	static WitnessStatementInfo()
	{
		Il2CppClassPointerStore<WitnessStatementInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WitnessStatementInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WitnessStatementInfo>.NativeClassPtr);
		NativeFieldInfoPtr_citizen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WitnessStatementInfo>.NativeClassPtr, "citizen");
		NativeFieldInfoPtr_statementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WitnessStatementInfo>.NativeClassPtr, "statementType");
		NativeMethodInfoPtr__ctor_Public_Void_Citizen_StatementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WitnessStatementInfo>.NativeClassPtr, 100673199);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 314007, RefRangeEnd = 314016, XrefRangeStart = 314007, XrefRangeEnd = 314007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WitnessStatementInfo(Citizen newCit, StatementType newStatementType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WitnessStatementInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCit);
		*(StatementType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newStatementType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Citizen_StatementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WitnessStatementInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
