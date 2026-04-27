using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew;

public class CombiningInformation : Il2CppSystem.Object
{
	public enum DiffuseColorSpace
	{
		NON_LINEAR,
		LINEAR
	}

	public enum CompressionType
	{
		UNCOMPRESSED,
		DXT1,
		ETC2_RGB,
		PVRTC_RGB4,
		ASTC_RGB
	}

	public enum CompressionQuality
	{
		LOW,
		MEDIUM,
		HIGH
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct Resolution
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_width;

		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		[FieldOffset(0)]
		public int width;

		[FieldOffset(4)]
		public int height;

		static Resolution()
		{
			Il2CppClassPointerStore<Resolution>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "Resolution");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resolution>.NativeClassPtr);
			NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "width");
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "height");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Resolution>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	public class TextureArrayUserSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_resolution;

		private static readonly System.IntPtr NativeFieldInfoPtr_filteringMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_compressionType;

		private static readonly System.IntPtr NativeFieldInfoPtr_compressionQuality;

		private static readonly System.IntPtr NativeFieldInfoPtr_anisotropicFilteringLevel;

		private static readonly System.IntPtr NativeFieldInfoPtr_choiceResolutionW;

		private static readonly System.IntPtr NativeFieldInfoPtr_choiceResolutionH;

		private static readonly System.IntPtr NativeFieldInfoPtr_choiceFilteringMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_choiceCompressionQuality;

		private static readonly System.IntPtr NativeFieldInfoPtr_choiceCompressionType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Resolution_FilterMode_CompressionType_CompressionQuality_Int32_0;

		public unsafe Resolution resolution
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution);
				return *(Resolution*)num;
			}
			set
			{
				*(Resolution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution)) = resolution;
			}
		}

		public unsafe FilterMode filteringMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filteringMode);
				return *(FilterMode*)num;
			}
			set
			{
				*(FilterMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filteringMode)) = filterMode;
			}
		}

		public unsafe CompressionType compressionType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionType);
				return *(CompressionType*)num;
			}
			set
			{
				*(CompressionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionType)) = compressionType;
			}
		}

		public unsafe CompressionQuality compressionQuality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionQuality);
				return *(CompressionQuality*)num;
			}
			set
			{
				*(CompressionQuality*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionQuality)) = compressionQuality;
			}
		}

		public unsafe int anisotropicFilteringLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anisotropicFilteringLevel);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anisotropicFilteringLevel)) = num;
			}
		}

		public unsafe int choiceResolutionW
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceResolutionW);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceResolutionW)) = num;
			}
		}

		public unsafe int choiceResolutionH
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceResolutionH);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceResolutionH)) = num;
			}
		}

		public unsafe int choiceFilteringMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceFilteringMode);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceFilteringMode)) = num;
			}
		}

		public unsafe int choiceCompressionQuality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceCompressionQuality);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceCompressionQuality)) = num;
			}
		}

		public unsafe int choiceCompressionType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceCompressionType);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceCompressionType)) = num;
			}
		}

		static TextureArrayUserSettings()
		{
			Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "TextureArrayUserSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr);
			NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "resolution");
			NativeFieldInfoPtr_filteringMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "filteringMode");
			NativeFieldInfoPtr_compressionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "compressionType");
			NativeFieldInfoPtr_compressionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "compressionQuality");
			NativeFieldInfoPtr_anisotropicFilteringLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "anisotropicFilteringLevel");
			NativeFieldInfoPtr_choiceResolutionW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "choiceResolutionW");
			NativeFieldInfoPtr_choiceResolutionH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "choiceResolutionH");
			NativeFieldInfoPtr_choiceFilteringMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "choiceFilteringMode");
			NativeFieldInfoPtr_choiceCompressionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "choiceCompressionQuality");
			NativeFieldInfoPtr_choiceCompressionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, "choiceCompressionType");
			NativeMethodInfoPtr__ctor_Public_Void_Resolution_FilterMode_CompressionType_CompressionQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr, 100676843);
		}

		[CallerCount(0)]
		public unsafe TextureArrayUserSettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureArrayUserSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&resolution);
			*(FilterMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filteringMode;
			*(CompressionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressionType;
			*(CompressionQuality**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressionQuality;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisotropicFilteringLevel;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Resolution_FilterMode_CompressionType_CompressionQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TextureArrayUserSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class TextureArrayGroup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_diffuseArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_metallicArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_specularArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_normalArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_heightArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_occlusionArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_emissiveArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailMaskArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailAlbedoArraySettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailNormalArraySettings;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDefaultArraySettings_Public_Void_Resolution_FilterMode_CompressionType_CompressionQuality_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureArrayUserSettings diffuseArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings metallicArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metallicArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metallicArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings specularArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings normalArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings heightArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings occlusionArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings emissiveArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissiveArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissiveArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings detailMaskArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailMaskArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailMaskArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings detailAlbedoArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailAlbedoArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailAlbedoArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		public unsafe TextureArrayUserSettings detailNormalArraySettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailNormalArraySettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayUserSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailNormalArraySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayUserSettings));
			}
		}

		static TextureArrayGroup()
		{
			Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "TextureArrayGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr);
			NativeFieldInfoPtr_diffuseArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "diffuseArraySettings");
			NativeFieldInfoPtr_metallicArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "metallicArraySettings");
			NativeFieldInfoPtr_specularArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "specularArraySettings");
			NativeFieldInfoPtr_normalArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "normalArraySettings");
			NativeFieldInfoPtr_heightArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "heightArraySettings");
			NativeFieldInfoPtr_occlusionArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "occlusionArraySettings");
			NativeFieldInfoPtr_emissiveArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "emissiveArraySettings");
			NativeFieldInfoPtr_detailMaskArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "detailMaskArraySettings");
			NativeFieldInfoPtr_detailAlbedoArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "detailAlbedoArraySettings");
			NativeFieldInfoPtr_detailNormalArraySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, "detailNormalArraySettings");
			NativeMethodInfoPtr_InitializeDefaultArraySettings_Public_Void_Resolution_FilterMode_CompressionType_CompressionQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, 100676844);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr, 100676845);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368858, XrefRangeEnd = 368879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDefaultArraySettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&resolution);
			*(FilterMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filteringMode;
			*(CompressionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressionType;
			*(CompressionQuality**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressionQuality;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anisotropicFilteringLevel;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDefaultArraySettings_Public_Void_Resolution_FilterMode_CompressionType_CompressionQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureArrayGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureArrayGroup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TextureArrayGroup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class MaterialProperties : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_foldOut;

		private static readonly System.IntPtr NativeFieldInfoPtr_texArrIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_matIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialName;

		private static readonly System.IntPtr NativeFieldInfoPtr_originalMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_albedoTint;

		private static readonly System.IntPtr NativeFieldInfoPtr_uvTileOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_normalIntensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_occlusionIntensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_smoothnessIntensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_glossMapScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_metalIntensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_emissionColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailUVTileOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_alphaCutoff;

		private static readonly System.IntPtr NativeFieldInfoPtr_specularColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailNormalScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_heightIntensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_uvSec;

		private static readonly System.IntPtr NativeFieldInfoPtr_alphaMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_specularWorkflow;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsSameAs_Public_Boolean_MaterialProperties_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NewTexture_Public_Static_Texture2D_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BurnAttrToImg_Public_Void_byref_Texture2D_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FillPropertiesFromMaterial_Public_Void_Material_CombiningInformation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool foldOut
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foldOut);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foldOut)) = flag;
			}
		}

		public unsafe int texArrIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texArrIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texArrIndex)) = num;
			}
		}

		public unsafe int matIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matIndex)) = num;
			}
		}

		public unsafe string materialName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Material originalMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe Color albedoTint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_albedoTint);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_albedoTint)) = color;
			}
		}

		public unsafe Vector4 uvTileOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvTileOffset);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvTileOffset)) = vector;
			}
		}

		public unsafe float normalIntensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalIntensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalIntensity)) = num;
			}
		}

		public unsafe float occlusionIntensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionIntensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionIntensity)) = num;
			}
		}

		public unsafe float smoothnessIntensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothnessIntensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothnessIntensity)) = num;
			}
		}

		public unsafe float glossMapScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glossMapScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glossMapScale)) = num;
			}
		}

		public unsafe float metalIntensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metalIntensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metalIntensity)) = num;
			}
		}

		public unsafe Color emissionColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionColor);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionColor)) = color;
			}
		}

		public unsafe Vector4 detailUVTileOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailUVTileOffset);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailUVTileOffset)) = vector;
			}
		}

		public unsafe float alphaCutoff
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaCutoff);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaCutoff)) = num;
			}
		}

		public unsafe Color specularColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularColor);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularColor)) = color;
			}
		}

		public unsafe float detailNormalScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailNormalScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailNormalScale)) = num;
			}
		}

		public unsafe float heightIntensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightIntensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightIntensity)) = num;
			}
		}

		public unsafe float uvSec
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvSec);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvSec)) = num;
			}
		}

		public unsafe int alphaMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaMode);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphaMode)) = num;
			}
		}

		public unsafe bool specularWorkflow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularWorkflow);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularWorkflow)) = flag;
			}
		}

		static MaterialProperties()
		{
			Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "MaterialProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr);
			NativeFieldInfoPtr_foldOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "foldOut");
			NativeFieldInfoPtr_texArrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "texArrIndex");
			NativeFieldInfoPtr_matIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "matIndex");
			NativeFieldInfoPtr_materialName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "materialName");
			NativeFieldInfoPtr_originalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "originalMaterial");
			NativeFieldInfoPtr_albedoTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "albedoTint");
			NativeFieldInfoPtr_uvTileOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "uvTileOffset");
			NativeFieldInfoPtr_normalIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "normalIntensity");
			NativeFieldInfoPtr_occlusionIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "occlusionIntensity");
			NativeFieldInfoPtr_smoothnessIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "smoothnessIntensity");
			NativeFieldInfoPtr_glossMapScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "glossMapScale");
			NativeFieldInfoPtr_metalIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "metalIntensity");
			NativeFieldInfoPtr_emissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "emissionColor");
			NativeFieldInfoPtr_detailUVTileOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "detailUVTileOffset");
			NativeFieldInfoPtr_alphaCutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "alphaCutoff");
			NativeFieldInfoPtr_specularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "specularColor");
			NativeFieldInfoPtr_detailNormalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "detailNormalScale");
			NativeFieldInfoPtr_heightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "heightIntensity");
			NativeFieldInfoPtr_uvSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "uvSec");
			NativeFieldInfoPtr_alphaMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "alphaMode");
			NativeFieldInfoPtr_specularWorkflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, "specularWorkflow");
			NativeMethodInfoPtr_IsSameAs_Public_Boolean_MaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, 100676846);
			NativeMethodInfoPtr_NewTexture_Public_Static_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, 100676847);
			NativeMethodInfoPtr_BurnAttrToImg_Public_Void_byref_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, 100676848);
			NativeMethodInfoPtr_FillPropertiesFromMaterial_Public_Void_Material_CombiningInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, 100676849);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr, 100676850);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368879, XrefRangeEnd = 368896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSameAs(MaterialProperties toCompare)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toCompare);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSameAs_Public_Boolean_MaterialProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368896, XrefRangeEnd = 368904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture2D NewTexture()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewTexture_Public_Static_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368904, XrefRangeEnd = 368925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)burnOn);
			*ptr = (nint)(&intPtr);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureArrayIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr3);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BurnAttrToImg_Public_Void_byref_Texture2D_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			System.IntPtr intPtr4 = intPtr;
			burnOn = ((intPtr4 == (System.IntPtr)0) ? null : new Texture2D(intPtr4));
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 368925, XrefRangeEnd = 369037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillPropertiesFromMaterial(Material material, CombiningInformation combineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)combineInfo);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillPropertiesFromMaterial_Public_Void_Material_CombiningInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe MaterialProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialProperties>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaterialProperties(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class MeshData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_meshFilters;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshRenderers;

		private static readonly System.IntPtr NativeFieldInfoPtr_skinnedMeshRenderers;

		private static readonly System.IntPtr NativeFieldInfoPtr_originalMaterials;

		private static readonly System.IntPtr NativeFieldInfoPtr_outputMeshes;

		private static readonly System.IntPtr NativeFieldInfoPtr_outputMatrices;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<MeshFilter> meshFilters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshFilter>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshFilters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<MeshRenderer> meshRenderers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<SkinnedMeshRenderer> skinnedMeshRenderers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinnedMeshRenderers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinnedMeshRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Il2CppReferenceArray<Material> originalMaterials
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalMaterials);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppReferenceArray<Mesh> outputMeshes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMeshes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMeshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Matrix4x4> outputMatrices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMatrices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMatrices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static MeshData()
		{
			Il2CppClassPointerStore<MeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "MeshData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshData>.NativeClassPtr);
			NativeFieldInfoPtr_meshFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshData>.NativeClassPtr, "meshFilters");
			NativeFieldInfoPtr_meshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshData>.NativeClassPtr, "meshRenderers");
			NativeFieldInfoPtr_skinnedMeshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshData>.NativeClassPtr, "skinnedMeshRenderers");
			NativeFieldInfoPtr_originalMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshData>.NativeClassPtr, "originalMaterials");
			NativeFieldInfoPtr_outputMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshData>.NativeClassPtr, "outputMeshes");
			NativeFieldInfoPtr_outputMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshData>.NativeClassPtr, "outputMatrices");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshData>.NativeClassPtr, 100676851);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MeshData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CombineMetaData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialProperties;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempMaterialProperties;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshesData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe MaterialProperties materialProperties
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialProperties);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialProperties>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialProperties)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialProperties));
			}
		}

		public unsafe MaterialProperties tempMaterialProperties
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempMaterialProperties);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialProperties>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempMaterialProperties)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialProperties));
			}
		}

		public unsafe List<MeshData> meshesData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshesData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshesData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CombineMetaData()
		{
			Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "CombineMetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr);
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_materialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr, "materialProperties");
			NativeFieldInfoPtr_tempMaterialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr, "tempMaterialProperties");
			NativeFieldInfoPtr_meshesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr, "meshesData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr, 100676852);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369037, XrefRangeEnd = 369043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombineMetaData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombineMetaData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CombineMetaData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class MaterialEntity : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_combinedMats;

		private static readonly System.IntPtr NativeFieldInfoPtr_textArrIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_diffuseMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_metallicMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_specularMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_normalMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_heightMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_occlusionMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_emissionMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailMaskMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailAlbedoMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_detailNormalMap;

		private static readonly System.IntPtr NativeMethodInfoPtr_HasAnyTextures_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<CombineMetaData> combinedMats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedMats);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CombineMetaData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedMats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int textArrIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textArrIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textArrIndex)) = num;
			}
		}

		public unsafe Texture2D diffuseMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D metallicMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metallicMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metallicMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D specularMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D normalMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D heightMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D occlusionMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D emissionMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D detailMaskMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailMaskMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailMaskMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D detailAlbedoMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailAlbedoMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailAlbedoMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe Texture2D detailNormalMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailNormalMap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailNormalMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		static MaterialEntity()
		{
			Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "MaterialEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr);
			NativeFieldInfoPtr_combinedMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "combinedMats");
			NativeFieldInfoPtr_textArrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "textArrIndex");
			NativeFieldInfoPtr_diffuseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "diffuseMap");
			NativeFieldInfoPtr_metallicMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "metallicMap");
			NativeFieldInfoPtr_specularMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "specularMap");
			NativeFieldInfoPtr_normalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "normalMap");
			NativeFieldInfoPtr_heightMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "heightMap");
			NativeFieldInfoPtr_occlusionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "occlusionMap");
			NativeFieldInfoPtr_emissionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "emissionMap");
			NativeFieldInfoPtr_detailMaskMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "detailMaskMap");
			NativeFieldInfoPtr_detailAlbedoMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "detailAlbedoMap");
			NativeFieldInfoPtr_detailNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, "detailNormalMap");
			NativeMethodInfoPtr_HasAnyTextures_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, 100676853);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr, 100676854);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369043, XrefRangeEnd = 369134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAnyTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasAnyTextures_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369134, XrefRangeEnd = 369140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialEntity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialEntity>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaterialEntity(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_materialEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureArraysSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffuseColorSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedMaterials;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateMetallicArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateSpecularArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateNormalArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateHeightArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateOcclusionArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateEmissionArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateDetailMaskArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateDetailAlbedoArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldGenerateDetailNormalArray_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<MaterialEntity> materialEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialEntity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TextureArrayGroup textureArraysSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureArraysSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureArrayGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureArraysSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureArrayGroup));
		}
	}

	public unsafe DiffuseColorSpace diffuseColorSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseColorSpace);
			return *(DiffuseColorSpace*)num;
		}
		set
		{
			*(DiffuseColorSpace*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseColorSpace)) = diffuseColorSpace;
		}
	}

	public unsafe Il2CppReferenceArray<Material> combinedMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static CombiningInformation()
	{
		Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew", "CombiningInformation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr);
		NativeFieldInfoPtr_materialEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "materialEntities");
		NativeFieldInfoPtr_textureArraysSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "textureArraysSettings");
		NativeFieldInfoPtr_diffuseColorSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "diffuseColorSpace");
		NativeFieldInfoPtr_combinedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, "combinedMaterials");
		NativeMethodInfoPtr_ShouldGenerateMetallicArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676833);
		NativeMethodInfoPtr_ShouldGenerateSpecularArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676834);
		NativeMethodInfoPtr_ShouldGenerateNormalArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676835);
		NativeMethodInfoPtr_ShouldGenerateHeightArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676836);
		NativeMethodInfoPtr_ShouldGenerateOcclusionArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676837);
		NativeMethodInfoPtr_ShouldGenerateEmissionArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676838);
		NativeMethodInfoPtr_ShouldGenerateDetailMaskArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676839);
		NativeMethodInfoPtr_ShouldGenerateDetailAlbedoArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676840);
		NativeMethodInfoPtr_ShouldGenerateDetailNormalArray_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676841);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr, 100676842);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369140, XrefRangeEnd = 369158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateMetallicArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateMetallicArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369158, XrefRangeEnd = 369176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateSpecularArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateSpecularArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369176, XrefRangeEnd = 369194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateNormalArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateNormalArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369194, XrefRangeEnd = 369212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateHeightArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateHeightArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369212, XrefRangeEnd = 369230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateOcclusionArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateOcclusionArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 369248, RefRangeEnd = 369249, XrefRangeStart = 369230, XrefRangeEnd = 369248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateEmissionArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateEmissionArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369249, XrefRangeEnd = 369267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateDetailMaskArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateDetailMaskArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369267, XrefRangeEnd = 369285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateDetailAlbedoArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateDetailAlbedoArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369285, XrefRangeEnd = 369303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldGenerateDetailNormalArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldGenerateDetailNormalArray_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369303, XrefRangeEnd = 369312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CombiningInformation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombiningInformation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CombiningInformation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
