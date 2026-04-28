using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

public class PathSettings : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_defaultRootPath;

	private static readonly IntPtr NativeFieldInfoPtr_mobileRootPath;

	private static readonly IntPtr NativeMethodInfoPtr_get_RootPath_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindPathComponent_Public_Static_PathSettings_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_FullPath_Public_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RootPathEnum defaultRootPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultRootPath);
			return *(RootPathEnum*)num;
		}
		set
		{
			*(RootPathEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultRootPath)) = rootPathEnum;
		}
	}

	public unsafe RootPathEnum mobileRootPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobileRootPath);
			return *(RootPathEnum*)num;
		}
		set
		{
			*(RootPathEnum*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobileRootPath)) = rootPathEnum;
		}
	}

	public unsafe string RootPath
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375168, RefRangeEnd = 375170, XrefRangeStart = 375164, XrefRangeEnd = 375168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RootPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static PathSettings()
	{
		Il2CppClassPointerStore<PathSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "PathSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSettings>.NativeClassPtr);
		NativeFieldInfoPtr_defaultRootPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, "defaultRootPath");
		NativeFieldInfoPtr_mobileRootPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, "mobileRootPath");
		NativeMethodInfoPtr_get_RootPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, 100677219);
		NativeMethodInfoPtr_FindPathComponent_Public_Static_PathSettings_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, 100677220);
		NativeMethodInfoPtr_FullPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, 100677221);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, 100677222);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375170, XrefRangeEnd = 375202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PathSettings FindPathComponent(GameObject obj)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPathComponent_Public_Static_PathSettings_GameObject_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PathSettings>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375202, XrefRangeEnd = 375208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FullPath(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FullPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PathSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PathSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
