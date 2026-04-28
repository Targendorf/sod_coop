using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil;

public class Triangle : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_v1;

	private static readonly System.IntPtr NativeFieldInfoPtr_v2;

	private static readonly System.IntPtr NativeFieldInfoPtr_v3;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vertex_Vertex_Vertex_0;

	public unsafe Vertex v1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Vertex>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertex));
		}
	}

	public unsafe Vertex v2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Vertex>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertex));
		}
	}

	public unsafe Vertex v3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Vertex>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertex));
		}
	}

	static Triangle()
	{
		Il2CppClassPointerStore<Triangle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL.MathUtil", "Triangle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Triangle>.NativeClassPtr);
		NativeFieldInfoPtr_v1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Triangle>.NativeClassPtr, "v1");
		NativeFieldInfoPtr_v2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Triangle>.NativeClassPtr, "v2");
		NativeFieldInfoPtr_v3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Triangle>.NativeClassPtr, "v3");
		NativeMethodInfoPtr__ctor_Public_Void_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangle>.NativeClassPtr, 100677223);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 375208, RefRangeEnd = 375222, XrefRangeStart = 375208, XrefRangeEnd = 375208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Triangle(Vertex v1, Vertex v2, Vertex v3)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Triangle>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v3);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vertex_Vertex_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Triangle(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
