using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

[System.Serializable]
public class ImportOptions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_zUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_litDiffuse;

	private static readonly System.IntPtr NativeFieldInfoPtr_convertToDoubleSided;

	private static readonly System.IntPtr NativeFieldInfoPtr_modelScaling;

	private static readonly System.IntPtr NativeFieldInfoPtr_reuseLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildColliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_colliderConvex;

	private static readonly System.IntPtr NativeFieldInfoPtr_colliderTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_use32bitIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_hideWhileLoading;

	private static readonly System.IntPtr NativeFieldInfoPtr_localPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_localEulerAngles;

	private static readonly System.IntPtr NativeFieldInfoPtr_localScale;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool zUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zUp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zUp)) = flag;
		}
	}

	public unsafe bool litDiffuse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_litDiffuse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_litDiffuse)) = flag;
		}
	}

	public unsafe bool convertToDoubleSided
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convertToDoubleSided);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convertToDoubleSided)) = flag;
		}
	}

	public unsafe float modelScaling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelScaling);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelScaling)) = num;
		}
	}

	public unsafe bool reuseLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reuseLoaded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reuseLoaded)) = flag;
		}
	}

	public unsafe bool inheritLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritLayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritLayer)) = flag;
		}
	}

	public unsafe bool buildColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildColliders);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildColliders)) = flag;
		}
	}

	public unsafe bool colliderConvex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderConvex);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderConvex)) = flag;
		}
	}

	public unsafe bool colliderTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderTrigger);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderTrigger)) = flag;
		}
	}

	public unsafe bool use32bitIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use32bitIndices);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use32bitIndices)) = flag;
		}
	}

	public unsafe bool hideWhileLoading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideWhileLoading);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideWhileLoading)) = flag;
		}
	}

	public unsafe Vector3 localPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosition)) = vector;
		}
	}

	public unsafe Vector3 localEulerAngles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localEulerAngles);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localEulerAngles)) = vector;
		}
	}

	public unsafe Vector3 localScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localScale)) = vector;
		}
	}

	static ImportOptions()
	{
		Il2CppClassPointerStore<ImportOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "ImportOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr);
		NativeFieldInfoPtr_zUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "zUp");
		NativeFieldInfoPtr_litDiffuse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "litDiffuse");
		NativeFieldInfoPtr_convertToDoubleSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "convertToDoubleSided");
		NativeFieldInfoPtr_modelScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "modelScaling");
		NativeFieldInfoPtr_reuseLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "reuseLoaded");
		NativeFieldInfoPtr_inheritLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "inheritLayer");
		NativeFieldInfoPtr_buildColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "buildColliders");
		NativeFieldInfoPtr_colliderConvex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "colliderConvex");
		NativeFieldInfoPtr_colliderTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "colliderTrigger");
		NativeFieldInfoPtr_use32bitIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "use32bitIndices");
		NativeFieldInfoPtr_hideWhileLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "hideWhileLoading");
		NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "localPosition");
		NativeFieldInfoPtr_localEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "localEulerAngles");
		NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, "localScale");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr, 100677011);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 371830, RefRangeEnd = 371839, XrefRangeStart = 371824, XrefRangeEnd = 371830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImportOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImportOptions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ImportOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
