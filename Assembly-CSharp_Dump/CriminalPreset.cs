using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class CriminalPreset : SoCustomComparison
{
	public enum CriminalType
	{
		serialKiller
	}

	private static readonly IntPtr NativeFieldInfoPtr_type;

	private static readonly IntPtr NativeFieldInfoPtr_canBeAgent;

	private static readonly IntPtr NativeFieldInfoPtr_canHaveJob;

	private static readonly IntPtr NativeFieldInfoPtr_suggestedRank;

	private static readonly IntPtr NativeFieldInfoPtr_boss;

	private static readonly IntPtr NativeFieldInfoPtr_positionsMin;

	private static readonly IntPtr NativeFieldInfoPtr_positionsMax;

	private static readonly IntPtr NativeFieldInfoPtr_desiredCrimePerDay;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CriminalType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(CriminalType*)num;
		}
		set
		{
			*(CriminalType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = criminalType;
		}
	}

	public unsafe bool canBeAgent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeAgent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeAgent)) = flag;
		}
	}

	public unsafe bool canHaveJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canHaveJob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canHaveJob)) = flag;
		}
	}

	public unsafe int suggestedRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suggestedRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suggestedRank)) = num;
		}
	}

	public unsafe CriminalPreset boss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boss);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CriminalPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boss)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)criminalPreset));
		}
	}

	public unsafe int positionsMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMin)) = num;
		}
	}

	public unsafe int positionsMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionsMax)) = num;
		}
	}

	public unsafe float desiredCrimePerDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredCrimePerDay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredCrimePerDay)) = num;
		}
	}

	static CriminalPreset()
	{
		Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CriminalPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "type");
		NativeFieldInfoPtr_canBeAgent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "canBeAgent");
		NativeFieldInfoPtr_canHaveJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "canHaveJob");
		NativeFieldInfoPtr_suggestedRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "suggestedRank");
		NativeFieldInfoPtr_boss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "boss");
		NativeFieldInfoPtr_positionsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "positionsMin");
		NativeFieldInfoPtr_positionsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "positionsMax");
		NativeFieldInfoPtr_desiredCrimePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, "desiredCrimePerDay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr, 100673865);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328042, XrefRangeEnd = 328043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CriminalPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CriminalPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CriminalPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
