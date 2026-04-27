using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class Unemployed : Il2CppSystem.Object
{
	public enum UnemployedType
	{
		Student,
		Retired,
		Unemployed,
		Prison
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateSalary;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe UnemployedType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(UnemployedType*)num;
		}
		set
		{
			*(UnemployedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = unemployedType;
		}
	}

	public unsafe float stateSalary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateSalary);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateSalary)) = num;
		}
	}

	static Unemployed()
	{
		Il2CppClassPointerStore<Unemployed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Unemployed");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unemployed>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unemployed>.NativeClassPtr, "type");
		NativeFieldInfoPtr_stateSalary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unemployed>.NativeClassPtr, "stateSalary");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unemployed>.NativeClassPtr, 100664968);
	}

	[CallerCount(0)]
	public unsafe Unemployed()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unemployed>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Unemployed(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
