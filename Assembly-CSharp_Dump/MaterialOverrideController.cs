using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class MaterialOverrideController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_concrete;

	private static readonly IntPtr NativeFieldInfoPtr_plaster;

	private static readonly IntPtr NativeFieldInfoPtr_wood;

	private static readonly IntPtr NativeFieldInfoPtr_carpet;

	private static readonly IntPtr NativeFieldInfoPtr_tile;

	private static readonly IntPtr NativeFieldInfoPtr_metal;

	private static readonly IntPtr NativeFieldInfoPtr_glass;

	private static readonly IntPtr NativeFieldInfoPtr_fabric;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float concrete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concrete);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concrete)) = num;
		}
	}

	public unsafe float plaster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plaster);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plaster)) = num;
		}
	}

	public unsafe float wood
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood)) = num;
		}
	}

	public unsafe float carpet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carpet);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carpet)) = num;
		}
	}

	public unsafe float tile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tile);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tile)) = num;
		}
	}

	public unsafe float metal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metal)) = num;
		}
	}

	public unsafe float glass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glass)) = num;
		}
	}

	public unsafe float fabric
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fabric);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fabric)) = num;
		}
	}

	static MaterialOverrideController()
	{
		Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MaterialOverrideController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr);
		NativeFieldInfoPtr_concrete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "concrete");
		NativeFieldInfoPtr_plaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "plaster");
		NativeFieldInfoPtr_wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "wood");
		NativeFieldInfoPtr_carpet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "carpet");
		NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "tile");
		NativeFieldInfoPtr_metal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "metal");
		NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "glass");
		NativeFieldInfoPtr_fabric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, "fabric");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr, 100669995);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231061, XrefRangeEnd = 231064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialOverrideController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrideController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MaterialOverrideController(IntPtr pointer)
		: base(pointer)
	{
	}
}
