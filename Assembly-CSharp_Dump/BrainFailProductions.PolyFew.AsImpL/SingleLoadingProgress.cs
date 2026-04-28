using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace BrainFailProductions.PolyFew.AsImpL;

public class SingleLoadingProgress : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_message;

	private static readonly System.IntPtr NativeFieldInfoPtr_percentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_numObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_numSubObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_error;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string fileName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float percentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_percentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_percentage)) = num;
		}
	}

	public unsafe int numObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numObjects);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numObjects)) = num;
		}
	}

	public unsafe int numSubObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSubObjects);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSubObjects)) = num;
		}
	}

	public unsafe bool error
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error)) = flag;
		}
	}

	static SingleLoadingProgress()
	{
		Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "SingleLoadingProgress");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr);
		NativeFieldInfoPtr_fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr, "fileName");
		NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr, "message");
		NativeFieldInfoPtr_percentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr, "percentage");
		NativeFieldInfoPtr_numObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr, "numObjects");
		NativeFieldInfoPtr_numSubObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr, "numSubObjects");
		NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr, "error");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr, 100677179);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SingleLoadingProgress()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleLoadingProgress>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SingleLoadingProgress(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
