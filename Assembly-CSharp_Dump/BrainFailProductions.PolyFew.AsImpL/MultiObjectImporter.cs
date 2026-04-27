using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace BrainFailProductions.PolyFew.AsImpL;

public class MultiObjectImporter : ObjectImporter
{
	private static readonly IntPtr NativeFieldInfoPtr_autoLoadOnStart;

	private static readonly IntPtr NativeFieldInfoPtr_objectsList;

	private static readonly IntPtr NativeFieldInfoPtr_defaultImportOptions;

	private static readonly IntPtr NativeFieldInfoPtr_pathSettings;

	private static readonly IntPtr NativeMethodInfoPtr_get_RootPath_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ImportModelListAsync_Public_Void_Il2CppReferenceArray_1_ModelImportInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool autoLoadOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLoadOnStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLoadOnStart)) = flag;
		}
	}

	public unsafe List<ModelImportInfo> objectsList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ModelImportInfo>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ImportOptions defaultImportOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultImportOptions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ImportOptions>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultImportOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)importOptions));
		}
	}

	public unsafe PathSettings pathSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathSettings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PathSettings>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pathSettings));
		}
	}

	public unsafe string RootPath
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374557, RefRangeEnd = 374558, XrefRangeStart = 374543, XrefRangeEnd = 374557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static MultiObjectImporter()
	{
		Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "MultiObjectImporter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr);
		NativeFieldInfoPtr_autoLoadOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, "autoLoadOnStart");
		NativeFieldInfoPtr_objectsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, "objectsList");
		NativeFieldInfoPtr_defaultImportOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, "defaultImportOptions");
		NativeFieldInfoPtr_pathSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, "pathSettings");
		NativeMethodInfoPtr_get_RootPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, 100677182);
		NativeMethodInfoPtr_ImportModelListAsync_Public_Void_Il2CppReferenceArray_1_ModelImportInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, 100677183);
		NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, 100677184);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr, 100677185);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 374580, RefRangeEnd = 374581, XrefRangeStart = 374558, XrefRangeEnd = 374580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImportModelListAsync(Il2CppReferenceArray<ModelImportInfo> modelsInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modelsInfo);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportModelListAsync_Public_Void_Il2CppReferenceArray_1_ModelImportInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374581, XrefRangeEnd = 374585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374585, XrefRangeEnd = 374610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultiObjectImporter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiObjectImporter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MultiObjectImporter(IntPtr pointer)
		: base(pointer)
	{
	}
}
