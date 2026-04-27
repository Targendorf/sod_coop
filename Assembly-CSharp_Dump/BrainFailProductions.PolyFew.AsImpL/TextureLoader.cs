using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

public class TextureLoader : MonoBehaviour
{
	public class TgaHeader : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_identSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_colorMapType;

		private static readonly System.IntPtr NativeFieldInfoPtr_imageType;

		private static readonly System.IntPtr NativeFieldInfoPtr_colorMapStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_colorMapLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_colorMapBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_xStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_ySstart;

		private static readonly System.IntPtr NativeFieldInfoPtr_width;

		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		private static readonly System.IntPtr NativeFieldInfoPtr_bits;

		private static readonly System.IntPtr NativeFieldInfoPtr_descriptor;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe byte identSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identSize);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identSize)) = b;
			}
		}

		public unsafe byte colorMapType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapType);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapType)) = b;
			}
		}

		public unsafe byte imageType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageType);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageType)) = b;
			}
		}

		public unsafe ushort colorMapStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapStart);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapStart)) = num;
			}
		}

		public unsafe ushort colorMapLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapLength);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapLength)) = num;
			}
		}

		public unsafe byte colorMapBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapBits);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMapBits)) = b;
			}
		}

		public unsafe ushort xStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xStart);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xStart)) = num;
			}
		}

		public unsafe ushort ySstart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySstart);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySstart)) = num;
			}
		}

		public unsafe ushort width
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = num;
			}
		}

		public unsafe ushort height
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
				return *(ushort*)num;
			}
			set
			{
				*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = num;
			}
		}

		public unsafe byte bits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bits);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bits)) = b;
			}
		}

		public unsafe byte descriptor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptor);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptor)) = b;
			}
		}

		static TgaHeader()
		{
			Il2CppClassPointerStore<TgaHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, "TgaHeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr);
			NativeFieldInfoPtr_identSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "identSize");
			NativeFieldInfoPtr_colorMapType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "colorMapType");
			NativeFieldInfoPtr_imageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "imageType");
			NativeFieldInfoPtr_colorMapStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "colorMapStart");
			NativeFieldInfoPtr_colorMapLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "colorMapLength");
			NativeFieldInfoPtr_colorMapBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "colorMapBits");
			NativeFieldInfoPtr_xStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "xStart");
			NativeFieldInfoPtr_ySstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "ySstart");
			NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "width");
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "height");
			NativeFieldInfoPtr_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "bits");
			NativeFieldInfoPtr_descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, "descriptor");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr, 100677178);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TgaHeader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TgaHeader>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TgaHeader(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTextureFromUrl_Public_Static_Texture2D_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTexture_Public_Static_Texture2D_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTGA_Public_Static_Texture2D_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDDSManual_Public_Static_Texture2D_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTGA_Public_Static_Texture2D_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTgaHeader_Private_Static_TgaHeader_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static TextureLoader()
	{
		Il2CppClassPointerStore<TextureLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "TextureLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr);
		NativeMethodInfoPtr_LoadTextureFromUrl_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, 100677171);
		NativeMethodInfoPtr_LoadTexture_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, 100677172);
		NativeMethodInfoPtr_LoadTGA_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, 100677173);
		NativeMethodInfoPtr_LoadDDSManual_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, 100677174);
		NativeMethodInfoPtr_LoadTGA_Public_Static_Texture2D_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, 100677175);
		NativeMethodInfoPtr_LoadTgaHeader_Private_Static_TgaHeader_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, 100677176);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr, 100677177);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374386, XrefRangeEnd = 374401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadTextureFromUrl(string url)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTextureFromUrl_Public_Static_Texture2D_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 374426, RefRangeEnd = 374429, XrefRangeStart = 374401, XrefRangeEnd = 374426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadTexture(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTexture_Public_Static_Texture2D_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374429, XrefRangeEnd = 374437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadTGA(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTGA_Public_Static_Texture2D_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374437, XrefRangeEnd = 374473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadDDSManual(string ddsPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ddsPath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDDSManual_Public_Static_Texture2D_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 374502, RefRangeEnd = 374503, XrefRangeStart = 374473, XrefRangeEnd = 374502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadTGA(Stream TGAStream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)TGAStream);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTGA_Public_Static_Texture2D_Stream_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 374536, RefRangeEnd = 374537, XrefRangeStart = 374503, XrefRangeEnd = 374536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TgaHeader LoadTgaHeader(BinaryReader r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)r);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTgaHeader_Private_Static_TgaHeader_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TgaHeader>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureLoader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TextureLoader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
