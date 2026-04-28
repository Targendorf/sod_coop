using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class BaseboulePlayer : ScriptableObject
{
	public enum Experience
	{
		Rookie,
		Experienced,
		Veteran,
		AllStar
	}

	public enum Position
	{
		Rouleur,
		Fielder,
		Tireur
	}

	private static readonly IntPtr NativeFieldInfoPtr_firstName;

	private static readonly IntPtr NativeFieldInfoPtr_surName;

	private static readonly IntPtr NativeFieldInfoPtr_playerSkill;

	private static readonly IntPtr NativeFieldInfoPtr_funFact;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string firstName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string surName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int playerSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSkill)) = num;
		}
	}

	public unsafe string funFact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_funFact);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_funFact)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static BaseboulePlayer()
	{
		Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BaseboulePlayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr);
		NativeFieldInfoPtr_firstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr, "firstName");
		NativeFieldInfoPtr_surName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr, "surName");
		NativeFieldInfoPtr_playerSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr, "playerSkill");
		NativeFieldInfoPtr_funFact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr, "funFact");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr, 100673797);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseboulePlayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseboulePlayer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BaseboulePlayer(IntPtr pointer)
		: base(pointer)
	{
	}
}
