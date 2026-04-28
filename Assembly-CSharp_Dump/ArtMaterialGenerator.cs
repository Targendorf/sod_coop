using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class ArtMaterialGenerator : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_textureSourceDirectory;

	private static readonly IntPtr NativeFieldInfoPtr_materialOutputDirectory;

	private static readonly IntPtr NativeFieldInfoPtr_presetOutputDirectory;

	private static readonly IntPtr NativeFieldInfoPtr_presetTemplate;

	private static readonly IntPtr NativeFieldInfoPtr_materialTemplate;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateMaterialsAndPresets_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTextureImporterFormat_Public_Static_Void_Texture2D_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string textureSourceDirectory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureSourceDirectory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureSourceDirectory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string materialOutputDirectory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOutputDirectory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOutputDirectory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string presetOutputDirectory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetOutputDirectory);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetOutputDirectory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ArtPreset presetTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetTemplate);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ArtPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetTemplate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)artPreset));
		}
	}

	public unsafe Material materialTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialTemplate);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialTemplate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	static ArtMaterialGenerator()
	{
		Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ArtMaterialGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_textureSourceDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, "textureSourceDirectory");
		NativeFieldInfoPtr_materialOutputDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, "materialOutputDirectory");
		NativeFieldInfoPtr_presetOutputDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, "presetOutputDirectory");
		NativeFieldInfoPtr_presetTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, "presetTemplate");
		NativeFieldInfoPtr_materialTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, "materialTemplate");
		NativeMethodInfoPtr_GenerateMaterialsAndPresets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, 100666482);
		NativeMethodInfoPtr_SetTextureImporterFormat_Public_Static_Void_Texture2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, 100666483);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr, 100666484);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateMaterialsAndPresets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateMaterialsAndPresets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTextureImporterFormat(Texture2D texture, bool isReadable)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isReadable;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureImporterFormat_Public_Static_Void_Texture2D_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArtMaterialGenerator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArtMaterialGenerator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ArtMaterialGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}
