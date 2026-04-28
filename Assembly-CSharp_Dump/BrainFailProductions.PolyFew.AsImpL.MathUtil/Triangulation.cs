using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil;

public static class Triangulation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_TriangulateConvexPolygon_Public_Static_List_1_Triangle_List_1_Vertex_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TriangulateByEarClipping_Public_Static_List_1_Triangle_List_1_Vertex_Vector3_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClipTriangle_Public_Static_Triangle_Vertex_List_1_Vertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClipEar_Private_Static_Triangle_Vertex_List_1_Vertex_List_1_Vertex_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindMaxAreaEarVertex_Private_Static_Vertex_List_1_Vertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindEarVertices_Private_Static_List_1_Vertex_List_1_Vertex_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVertexReflex_Private_Static_Boolean_Vertex_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVertexEar_Private_Static_Boolean_Vertex_List_1_Vertex_Vector3_0;

	static Triangulation()
	{
		Il2CppClassPointerStore<Triangulation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL.MathUtil", "Triangulation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Triangulation>.NativeClassPtr);
		NativeMethodInfoPtr_TriangulateConvexPolygon_Public_Static_List_1_Triangle_List_1_Vertex_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677240);
		NativeMethodInfoPtr_TriangulateByEarClipping_Public_Static_List_1_Triangle_List_1_Vertex_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677241);
		NativeMethodInfoPtr_ClipTriangle_Public_Static_Triangle_Vertex_List_1_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677242);
		NativeMethodInfoPtr_ClipEar_Private_Static_Triangle_Vertex_List_1_Vertex_List_1_Vertex_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677243);
		NativeMethodInfoPtr_FindMaxAreaEarVertex_Private_Static_Vertex_List_1_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677244);
		NativeMethodInfoPtr_FindEarVertices_Private_Static_List_1_Vertex_List_1_Vertex_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677245);
		NativeMethodInfoPtr_IsVertexReflex_Private_Static_Boolean_Vertex_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677246);
		NativeMethodInfoPtr_IsVertexEar_Private_Static_Boolean_Vertex_List_1_Vertex_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Triangulation>.NativeClassPtr, 100677247);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375239, XrefRangeEnd = 375266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Triangle> TriangulateConvexPolygon(List<Vertex> vertices, bool preserveOriginalVertices = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &preserveOriginalVertices;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriangulateConvexPolygon_Public_Static_List_1_Triangle_List_1_Vertex_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Triangle>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 375326, RefRangeEnd = 375327, XrefRangeStart = 375266, XrefRangeEnd = 375326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Triangle> TriangulateByEarClipping(List<Vertex> origVertices, Vector3 planeNormal, string meshName, bool preserveOriginalVertices = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origVertices);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &planeNormal;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(meshName);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &preserveOriginalVertices;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriangulateByEarClipping_Public_Static_List_1_Triangle_List_1_Vertex_Vector3_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Triangle>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 375334, RefRangeEnd = 375338, XrefRangeStart = 375327, XrefRangeEnd = 375334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Triangle ClipTriangle(Vertex vertex, List<Vertex> vertices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClipTriangle_Public_Static_Triangle_Vertex_List_1_Vertex_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Triangle>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375338, XrefRangeEnd = 375352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Triangle ClipEar(Vertex earVertex, List<Vertex> earVertices, List<Vertex> vertices, Vector3 planeNormal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)earVertex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)earVertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &planeNormal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClipEar_Private_Static_Triangle_Vertex_List_1_Vertex_List_1_Vertex_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Triangle>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 375363, RefRangeEnd = 375365, XrefRangeStart = 375352, XrefRangeEnd = 375363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vertex FindMaxAreaEarVertex(List<Vertex> earVertices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)earVertices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindMaxAreaEarVertex_Private_Static_Vertex_List_1_Vertex_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Vertex>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 375379, RefRangeEnd = 375381, XrefRangeStart = 375365, XrefRangeEnd = 375379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vertex> FindEarVertices(List<Vertex> vertices, Vector3 planeNormal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &planeNormal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindEarVertices_Private_Static_List_1_Vertex_List_1_Vertex_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vertex>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 375384, RefRangeEnd = 375386, XrefRangeStart = 375381, XrefRangeEnd = 375384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVertexReflex(Vertex v, Vector3 vNormal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vNormal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVertexReflex_Private_Static_Boolean_Vertex_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 375400, RefRangeEnd = 375405, XrefRangeStart = 375386, XrefRangeEnd = 375400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVertexEar(Vertex v, List<Vertex> vertices, Vector3 planeNormal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &planeNormal;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVertexEar_Private_Static_Boolean_Vertex_List_1_Vertex_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Triangulation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
