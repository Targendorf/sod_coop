using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

public class MaterialData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_materialName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffuseColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_specularColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_emissiveColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_shininess;

	private static readonly System.IntPtr NativeFieldInfoPtr_overallAlpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_illumType;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasReflectionTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffuseTexPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffuseTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_bumpTexPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_bumpTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_specularTexPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_specularTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_opacityTexPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_opacityTex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe Color ambientColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientColor)) = color;
		}
	}

	public unsafe Color diffuseColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseColor)) = color;
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

	public unsafe Color emissiveColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissiveColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissiveColor)) = color;
		}
	}

	public unsafe float shininess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shininess);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shininess)) = num;
		}
	}

	public unsafe float overallAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overallAlpha);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overallAlpha)) = num;
		}
	}

	public unsafe int illumType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_illumType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_illumType)) = num;
		}
	}

	public unsafe bool hasReflectionTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasReflectionTex);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasReflectionTex)) = flag;
		}
	}

	public unsafe string diffuseTexPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Texture2D diffuseTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe string bumpTexPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTexPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTexPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Texture2D bumpTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bumpTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe string specularTexPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTexPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTexPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Texture2D specularTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specularTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe string opacityTexPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTexPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTexPath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Texture2D opacityTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opacityTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	static MaterialData()
	{
		Il2CppClassPointerStore<MaterialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "MaterialData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialData>.NativeClassPtr);
		NativeFieldInfoPtr_materialName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "materialName");
		NativeFieldInfoPtr_ambientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "ambientColor");
		NativeFieldInfoPtr_diffuseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "diffuseColor");
		NativeFieldInfoPtr_specularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "specularColor");
		NativeFieldInfoPtr_emissiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "emissiveColor");
		NativeFieldInfoPtr_shininess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "shininess");
		NativeFieldInfoPtr_overallAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "overallAlpha");
		NativeFieldInfoPtr_illumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "illumType");
		NativeFieldInfoPtr_hasReflectionTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "hasReflectionTex");
		NativeFieldInfoPtr_diffuseTexPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "diffuseTexPath");
		NativeFieldInfoPtr_diffuseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "diffuseTex");
		NativeFieldInfoPtr_bumpTexPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "bumpTexPath");
		NativeFieldInfoPtr_bumpTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "bumpTex");
		NativeFieldInfoPtr_specularTexPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "specularTexPath");
		NativeFieldInfoPtr_specularTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "specularTex");
		NativeFieldInfoPtr_opacityTexPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "opacityTexPath");
		NativeFieldInfoPtr_opacityTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, "opacityTex");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialData>.NativeClassPtr, 100676986);
	}

	[CallerCount(0)]
	public unsafe MaterialData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MaterialData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
