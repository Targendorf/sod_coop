using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class MeshPoolingController : MonoBehaviour
{
	[System.Serializable]
	public class RoomMeshCache : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_floorMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_wallMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalWallMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastAccessed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Mesh floorMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe Mesh wallMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe Dictionary<NewBuilding, Mesh> additionalWallMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalWallMesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewBuilding, Mesh>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalWallMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Mesh ceilingMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe float lastAccessed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastAccessed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastAccessed)) = num;
			}
		}

		static RoomMeshCache()
		{
			Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "RoomMeshCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr);
			NativeFieldInfoPtr_floorMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr, "floorMesh");
			NativeFieldInfoPtr_wallMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr, "wallMesh");
			NativeFieldInfoPtr_additionalWallMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr, "additionalWallMesh");
			NativeFieldInfoPtr_ceilingMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr, "ceilingMesh");
			NativeFieldInfoPtr_lastAccessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr, "lastAccessed");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr, 100670017);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoomMeshCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomMeshCache>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public RoomMeshCache(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class LoaderThread : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_thread;

		private static readonly System.IntPtr NativeFieldInfoPtr_location;

		private static readonly System.IntPtr NativeFieldInfoPtr_isDone;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Coroutine thread
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Coroutine>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)coroutine));
			}
		}

		public unsafe NewRoom location
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
			}
		}

		public unsafe bool isDone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDone);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDone)) = flag;
			}
		}

		static LoaderThread()
		{
			Il2CppClassPointerStore<LoaderThread>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "LoaderThread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoaderThread>.NativeClassPtr);
			NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoaderThread>.NativeClassPtr, "thread");
			NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoaderThread>.NativeClassPtr, "location");
			NativeFieldInfoPtr_isDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoaderThread>.NativeClassPtr, "isDone");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoaderThread>.NativeClassPtr, 100670018);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoaderThread()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoaderThread>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LoaderThread(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class ProcessMeshDataJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_meshData;

		private static readonly System.IntPtr NativeFieldInfoPtr_outputMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_vertexStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_indexStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_xform;

		private static readonly System.IntPtr NativeFieldInfoPtr_bounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempVertices;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempNormals;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempTangents;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempUVs;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputArrays_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe Mesh.MeshDataArray meshData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshData);
				return *(Mesh.MeshDataArray*)num;
			}
			set
			{
				*(Mesh.MeshDataArray*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshData)) = meshDataArray;
			}
		}

		public unsafe Mesh.MeshData outputMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMesh);
				return *(Mesh.MeshData*)num;
			}
			set
			{
				*(Mesh.MeshData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMesh)) = meshData;
			}
		}

		public unsafe NativeArray<int> vertexStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexStart);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> indexStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexStart);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float4x4> xform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xform);
				return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xform), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float3x2> bounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds);
				return new NativeArray<float3x2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3x2>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3x2>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float3> tempVertices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempVertices);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempVertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float3> tempNormals
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempNormals);
				return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempNormals), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float4> tempTangents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempTangents);
				return new NativeArray<float4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempTangents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float2> tempUVs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempUVs);
				return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempUVs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ProcessMeshDataJob()
		{
			Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "ProcessMeshDataJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr);
			NativeFieldInfoPtr_meshData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "meshData");
			NativeFieldInfoPtr_outputMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "outputMesh");
			NativeFieldInfoPtr_vertexStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "vertexStart");
			NativeFieldInfoPtr_indexStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "indexStart");
			NativeFieldInfoPtr_xform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "xform");
			NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "bounds");
			NativeFieldInfoPtr_tempVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "tempVertices");
			NativeFieldInfoPtr_tempNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "tempNormals");
			NativeFieldInfoPtr_tempTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "tempTangents");
			NativeFieldInfoPtr_tempUVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, "tempUVs");
			NativeMethodInfoPtr_CreateInputArrays_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, 100670019);
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr, 100670020);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231075, RefRangeEnd = 231076, XrefRangeStart = 231064, XrefRangeEnd = 231075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateInputArrays(int meshCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&meshCount);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputArrays_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231076, XrefRangeEnd = 231143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ProcessMeshDataJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ProcessMeshDataJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessMeshDataJob>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct BakeJob
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_meshId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		[FieldOffset(0)]
		public int meshId;

		static BakeJob()
		{
			Il2CppClassPointerStore<BakeJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "BakeJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakeJob>.NativeClassPtr);
			NativeFieldInfoPtr_meshId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakeJob>.NativeClassPtr, "meshId");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeJob>.NativeClassPtr, 100670021);
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakeJob>.NativeClassPtr, 100670022);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231143, RefRangeEnd = 231146, XrefRangeStart = 231143, XrefRangeEnd = 231143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BakeJob(int mId)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231146, XrefRangeEnd = 231155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BakeJob>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("MeshPoolingController+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__29_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__36_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ProcessWall_b__29_0_Internal_Boolean_NewNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__StartCachingProcess_b__36_0_Internal_Int32_NewRoom_NewRoom_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Func<NewNode, bool> __9__29_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewNode, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__29_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Comparison<NewRoom> __9__36_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<NewRoom>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__36_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__29_0");
			NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__36_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670024);
			NativeMethodInfoPtr__ProcessWall_b__29_0_Internal_Boolean_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670025);
			NativeMethodInfoPtr__StartCachingProcess_b__36_0_Internal_Int32_NewRoom_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670026);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ProcessWall_b__29_0(NewNode item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProcessWall_b__29_0_Internal_Boolean_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231155, XrefRangeEnd = 231157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _StartCachingProcess_b__36_0(NewRoom p2, NewRoom p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartCachingProcess_b__36_0_Internal_Int32_NewRoom_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("MeshPoolingController+<>c__DisplayClass34_0")]
	public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_loaderReference;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ThreadedMeshGeneration_b__0_Internal_Void_0;

		public unsafe MeshPoolingController __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshPoolingController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshPoolingController));
			}
		}

		public unsafe LoaderThread loaderReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loaderReference);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoaderThread>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loaderReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loaderThread));
			}
		}

		static __c__DisplayClass34_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "<>c__DisplayClass34_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_loaderReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, "loaderReference");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, 100670027);
			NativeMethodInfoPtr__ThreadedMeshGeneration_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, 100670028);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass34_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231157, XrefRangeEnd = 231158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ThreadedMeshGeneration_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ThreadedMeshGeneration_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass34_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("MeshPoolingController+<ThreadedMeshGeneration>d__34")]
	public sealed class _ThreadedMeshGeneration_d__34 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_loaderReference;

		private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__thread_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe MeshPoolingController __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshPoolingController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshPoolingController));
			}
		}

		public unsafe LoaderThread loaderReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loaderReference);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoaderThread>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loaderReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loaderThread));
			}
		}

		public unsafe __c__DisplayClass34_0 __8__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass34_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass34_));
			}
		}

		public unsafe Thread _thread_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__thread_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _ThreadedMeshGeneration_d__34()
		{
			Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "<ThreadedMeshGeneration>d__34");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_loaderReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, "loaderReference");
			NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, "<>8__1");
			NativeFieldInfoPtr__thread_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, "<thread>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, 100670029);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, 100670030);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, 100670031);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, 100670032);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, 100670033);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr, 100670034);
		}

		[CallerCount(0)]
		public unsafe _ThreadedMeshGeneration_d__34(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ThreadedMeshGeneration_d__34>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231158, XrefRangeEnd = 231195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231195, XrefRangeEnd = 231201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _ThreadedMeshGeneration_d__34(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_generatedRoomMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_colliderCookingOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_bakeMeshesWithJobSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_backgroundCachingEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheRoomPerXFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_uncachedRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_toCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_threads;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MeshPoolingController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnMeshesForRoom_Public_Void_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnModularRoomElements_Public_Void_NewRoom_Boolean_byref_List_1_MeshFilter_byref_Dictionary_2_NewBuilding_List_1_MeshFilter_byref_List_1_MeshFilter_byref_List_1_MeshFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnExtraRoomElements_Public_Void_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedRoomMeshes_Public_Void_NewRoom_byref_GameObject_byref_GameObject_byref_Dictionary_2_NewBuilding_GameObject_byref_GameObject_byref_MeshRenderer_byref_MeshRenderer_byref_MeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildCombinedMeshesForRoom_Public_Void_NewRoom_byref_Mesh_byref_Mesh_byref_Dictionary_2_NewBuilding_Mesh_byref_Mesh_Boolean_byref_GameObject_byref_GameObject_byref_Dictionary_2_NewBuilding_GameObject_byref_GameObject_byref_MeshRenderer_byref_MeshRenderer_byref_MeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Mesh_byref_List_1_MeshFilter_Boolean_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshesWithMeshAPI_Public_Mesh_byref_List_1_MeshFilter_Boolean_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WeldVertices_Public_Static_Mesh_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGameObjectFromMesh_Public_GameObject_Mesh_NewRoom_String_ShadowCastingMode_byref_MeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessWall_Public_Void_GameObject_NewRoom_NewBuilding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFloor_Public_Void_GameObject_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCeiling_Public_Void_GameObject_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBackgroundCachingAllowed_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThreadedMeshGeneration_Private_IEnumerator_LoaderThread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAtLoadTime_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartCachingProcess_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int generatedRoomMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedRoomMeshes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedRoomMeshes)) = num;
		}
	}

	public unsafe MeshColliderCookingOptions colliderCookingOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderCookingOptions);
			return *(MeshColliderCookingOptions*)num;
		}
		set
		{
			*(MeshColliderCookingOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colliderCookingOptions)) = meshColliderCookingOptions;
		}
	}

	public unsafe bool bakeMeshesWithJobSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakeMeshesWithJobSystem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bakeMeshesWithJobSystem)) = flag;
		}
	}

	public unsafe bool backgroundCachingEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundCachingEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backgroundCachingEnabled)) = flag;
		}
	}

	public unsafe int cacheRoomPerXFrames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheRoomPerXFrames);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheRoomPerXFrames)) = num;
		}
	}

	public unsafe int frameCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameCounter)) = num;
		}
	}

	public unsafe int maxCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCache);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCache)) = num;
		}
	}

	public unsafe int uncachedRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uncachedRooms);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uncachedRooms)) = num;
		}
	}

	public unsafe List<NewRoom> toCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LoaderThread> threads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoaderThread>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<NewRoom, RoomMeshCache> roomMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewRoom, RoomMeshCache>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomMeshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static MeshPoolingController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshPoolingController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshPoolingController));
		}
	}

	public unsafe static MeshPoolingController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231201, XrefRangeEnd = 231203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_MeshPoolingController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshPoolingController>(intPtr) : null;
		}
	}

	static MeshPoolingController()
	{
		Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeshPoolingController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr);
		NativeFieldInfoPtr_generatedRoomMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "generatedRoomMeshes");
		NativeFieldInfoPtr_colliderCookingOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "colliderCookingOptions");
		NativeFieldInfoPtr_bakeMeshesWithJobSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "bakeMeshesWithJobSystem");
		NativeFieldInfoPtr_backgroundCachingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "backgroundCachingEnabled");
		NativeFieldInfoPtr_cacheRoomPerXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "cacheRoomPerXFrames");
		NativeFieldInfoPtr_frameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "frameCounter");
		NativeFieldInfoPtr_maxCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "maxCache");
		NativeFieldInfoPtr_uncachedRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "uncachedRooms");
		NativeFieldInfoPtr_toCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "toCache");
		NativeFieldInfoPtr_threads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "threads");
		NativeFieldInfoPtr_roomMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "roomMeshes");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_MeshPoolingController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100669996);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100669997);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100669998);
		NativeMethodInfoPtr_SpawnMeshesForRoom_Public_Void_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100669999);
		NativeMethodInfoPtr_SpawnModularRoomElements_Public_Void_NewRoom_Boolean_byref_List_1_MeshFilter_byref_Dictionary_2_NewBuilding_List_1_MeshFilter_byref_List_1_MeshFilter_byref_List_1_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670000);
		NativeMethodInfoPtr_SpawnExtraRoomElements_Public_Void_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670001);
		NativeMethodInfoPtr_GetCombinedRoomMeshes_Public_Void_NewRoom_byref_GameObject_byref_GameObject_byref_Dictionary_2_NewBuilding_GameObject_byref_GameObject_byref_MeshRenderer_byref_MeshRenderer_byref_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670002);
		NativeMethodInfoPtr_BuildCombinedMeshesForRoom_Public_Void_NewRoom_byref_Mesh_byref_Mesh_byref_Dictionary_2_NewBuilding_Mesh_byref_Mesh_Boolean_byref_GameObject_byref_GameObject_byref_Dictionary_2_NewBuilding_GameObject_byref_GameObject_byref_MeshRenderer_byref_MeshRenderer_byref_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670003);
		NativeMethodInfoPtr_CombineMeshes_Public_Mesh_byref_List_1_MeshFilter_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670004);
		NativeMethodInfoPtr_CombineMeshesWithMeshAPI_Public_Mesh_byref_List_1_MeshFilter_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670005);
		NativeMethodInfoPtr_WeldVertices_Public_Static_Mesh_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670006);
		NativeMethodInfoPtr_CreateGameObjectFromMesh_Public_GameObject_Mesh_NewRoom_String_ShadowCastingMode_byref_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670007);
		NativeMethodInfoPtr_ProcessWall_Public_Void_GameObject_NewRoom_NewBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670008);
		NativeMethodInfoPtr_ProcessFloor_Public_Void_GameObject_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670009);
		NativeMethodInfoPtr_ProcessCeiling_Public_Void_GameObject_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670010);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670011);
		NativeMethodInfoPtr_IsBackgroundCachingAllowed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670012);
		NativeMethodInfoPtr_ThreadedMeshGeneration_Private_IEnumerator_LoaderThread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670013);
		NativeMethodInfoPtr_IsAtLoadTime_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670014);
		NativeMethodInfoPtr_StartCachingProcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670015);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr, 100670016);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231203, XrefRangeEnd = 231240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231240, XrefRangeEnd = 231264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231264, XrefRangeEnd = 231277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnMeshesForRoom(NewRoom room)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnMeshesForRoom_Public_Void_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231421, RefRangeEnd = 231424, XrefRangeStart = 231277, XrefRangeEnd = 231421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnModularRoomElements(NewRoom room, bool prepForCombineMeshes, out List<MeshFilter> wallChildMeshes, out Dictionary<NewBuilding, List<MeshFilter>> separateWallChildMeshes, out List<MeshFilter> floorChildMeshes, out List<MeshFilter> ceilingChildMeshes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prepForCombineMeshes;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		byte* num7 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num8 = 0;
		*(nint**)num7 = &num8;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnModularRoomElements_Public_Void_NewRoom_Boolean_byref_List_1_MeshFilter_byref_Dictionary_2_NewBuilding_List_1_MeshFilter_byref_List_1_MeshFilter_byref_List_1_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num9 = num2;
		wallChildMeshes = ((num9 == 0) ? null : new List<MeshFilter>(num9));
		nint num10 = num4;
		separateWallChildMeshes = ((num10 == 0) ? null : new Dictionary<NewBuilding, List<MeshFilter>>(num10));
		nint num11 = num6;
		floorChildMeshes = ((num11 == 0) ? null : new List<MeshFilter>(num11));
		nint num12 = num8;
		ceilingChildMeshes = ((num12 == 0) ? null : new List<MeshFilter>(num12));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 231464, RefRangeEnd = 231466, XrefRangeStart = 231424, XrefRangeEnd = 231464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnExtraRoomElements(NewRoom room)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnExtraRoomElements_Public_Void_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231541, RefRangeEnd = 231542, XrefRangeStart = 231466, XrefRangeEnd = 231541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCombinedRoomMeshes(NewRoom room, out GameObject floor, out GameObject walls, out Dictionary<NewBuilding, GameObject> additionalWalls, out GameObject ceiling, out MeshRenderer floorRend, out MeshRenderer wallsRend, out MeshRenderer ceilingRend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		byte* num7 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num8 = 0;
		*(nint**)num7 = &num8;
		byte* num9 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num10 = 0;
		*(nint**)num9 = &num10;
		byte* num11 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num12 = 0;
		*(nint**)num11 = &num12;
		byte* num13 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num14 = 0;
		*(nint**)num13 = &num14;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCombinedRoomMeshes_Public_Void_NewRoom_byref_GameObject_byref_GameObject_byref_Dictionary_2_NewBuilding_GameObject_byref_GameObject_byref_MeshRenderer_byref_MeshRenderer_byref_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num15 = num2;
		floor = ((num15 == 0) ? null : new GameObject(num15));
		nint num16 = num4;
		walls = ((num16 == 0) ? null : new GameObject(num16));
		nint num17 = num6;
		additionalWalls = ((num17 == 0) ? null : new Dictionary<NewBuilding, GameObject>(num17));
		nint num18 = num8;
		ceiling = ((num18 == 0) ? null : new GameObject(num18));
		nint num19 = num10;
		floorRend = ((num19 == 0) ? null : new MeshRenderer(num19));
		nint num20 = num12;
		wallsRend = ((num20 == 0) ? null : new MeshRenderer(num20));
		nint num21 = num14;
		ceilingRend = ((num21 == 0) ? null : new MeshRenderer(num21));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 231894, RefRangeEnd = 231898, XrefRangeStart = 231542, XrefRangeEnd = 231894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildCombinedMeshesForRoom(NewRoom room, out Mesh floorMesh, out Mesh wallMesh, out Dictionary<NewBuilding, Mesh> additionalWallMeshes, out Mesh ceilingMesh, bool returnGameObjects, out GameObject floor, out GameObject walls, out Dictionary<NewBuilding, GameObject> additionalWalls, out GameObject ceiling, out MeshRenderer floorRend, out MeshRenderer wallsRend, out MeshRenderer ceilingRend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		byte* num7 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num8 = 0;
		*(nint**)num7 = &num8;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnGameObjects;
		byte* num9 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num10 = 0;
		*(nint**)num9 = &num10;
		byte* num11 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num12 = 0;
		*(nint**)num11 = &num12;
		byte* num13 = (byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num14 = 0;
		*(nint**)num13 = &num14;
		byte* num15 = (byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num16 = 0;
		*(nint**)num15 = &num16;
		byte* num17 = (byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num18 = 0;
		*(nint**)num17 = &num18;
		byte* num19 = (byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num20 = 0;
		*(nint**)num19 = &num20;
		byte* num21 = (byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num22 = 0;
		*(nint**)num21 = &num22;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildCombinedMeshesForRoom_Public_Void_NewRoom_byref_Mesh_byref_Mesh_byref_Dictionary_2_NewBuilding_Mesh_byref_Mesh_Boolean_byref_GameObject_byref_GameObject_byref_Dictionary_2_NewBuilding_GameObject_byref_GameObject_byref_MeshRenderer_byref_MeshRenderer_byref_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num23 = num2;
		floorMesh = ((num23 == 0) ? null : new Mesh(num23));
		nint num24 = num4;
		wallMesh = ((num24 == 0) ? null : new Mesh(num24));
		nint num25 = num6;
		additionalWallMeshes = ((num25 == 0) ? null : new Dictionary<NewBuilding, Mesh>(num25));
		nint num26 = num8;
		ceilingMesh = ((num26 == 0) ? null : new Mesh(num26));
		nint num27 = num10;
		floor = ((num27 == 0) ? null : new GameObject(num27));
		nint num28 = num12;
		walls = ((num28 == 0) ? null : new GameObject(num28));
		nint num29 = num14;
		additionalWalls = ((num29 == 0) ? null : new Dictionary<NewBuilding, GameObject>(num29));
		nint num30 = num16;
		ceiling = ((num30 == 0) ? null : new GameObject(num30));
		nint num31 = num18;
		floorRend = ((num31 == 0) ? null : new MeshRenderer(num31));
		nint num32 = num20;
		wallsRend = ((num32 == 0) ? null : new MeshRenderer(num32));
		nint num33 = num22;
		ceilingRend = ((num33 == 0) ? null : new MeshRenderer(num33));
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 231949, RefRangeEnd = 231955, XrefRangeStart = 231898, XrefRangeEnd = 231949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mesh CombineMeshes(ref List<MeshFilter> childMeshes, bool markNoLongerReadable = true, bool bakePhysics = true, string meshName = "CombinedMesh")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)childMeshes);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &markNoLongerReadable;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bakePhysics;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(meshName);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Mesh_byref_List_1_MeshFilter_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		childMeshes = ((intPtr4 == (System.IntPtr)0) ? null : new List<MeshFilter>(intPtr4));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 232055, RefRangeEnd = 232062, XrefRangeStart = 231955, XrefRangeEnd = 232055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mesh CombineMeshesWithMeshAPI(ref List<MeshFilter> meshFilters, bool markNoLongerReadable = true, bool bakePhysics = true, string meshName = "CombinedMesh")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshFilters);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &markNoLongerReadable;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bakePhysics;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(meshName);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshesWithMeshAPI_Public_Mesh_byref_List_1_MeshFilter_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		meshFilters = ((intPtr4 == (System.IntPtr)0) ? null : new List<MeshFilter>(intPtr4));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
	}

	[CallerCount(155)]
	[CachedScanResults(RefRangeStart = 232062, RefRangeEnd = 232217, XrefRangeStart = 232062, XrefRangeEnd = 232062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh WeldVertices(Mesh aMesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aMesh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WeldVertices_Public_Static_Mesh_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 232273, RefRangeEnd = 232281, XrefRangeStart = 232217, XrefRangeEnd = 232273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateGameObjectFromMesh(Mesh mesh, NewRoom room, string newName, ShadowCastingMode shadowMode, out MeshRenderer meshRenderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newName);
		*(ShadowCastingMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowMode;
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGameObjectFromMesh_Public_GameObject_Mesh_NewRoom_String_ShadowCastingMode_byref_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		meshRenderer = ((num3 == 0) ? null : new MeshRenderer(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 232412, RefRangeEnd = 232416, XrefRangeStart = 232281, XrefRangeEnd = 232412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessWall(GameObject wallObject, NewRoom room, NewBuilding building = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)wallObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)building);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessWall_Public_Void_GameObject_NewRoom_NewBuilding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232444, RefRangeEnd = 232445, XrefRangeStart = 232416, XrefRangeEnd = 232444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessFloor(GameObject floorObject, NewRoom room)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)floorObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessFloor_Public_Void_GameObject_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232504, RefRangeEnd = 232506, XrefRangeStart = 232445, XrefRangeEnd = 232504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessCeiling(GameObject ceilingObject, NewRoom room)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ceilingObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCeiling_Public_Void_GameObject_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232506, XrefRangeEnd = 232549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232549, XrefRangeEnd = 232558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBackgroundCachingAllowed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBackgroundCachingAllowed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232558, XrefRangeEnd = 232561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ThreadedMeshGeneration(LoaderThread loaderReference)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loaderReference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThreadedMeshGeneration_Private_IEnumerator_LoaderThread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 232580, RefRangeEnd = 232583, XrefRangeStart = 232561, XrefRangeEnd = 232580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAtLoadTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAtLoadTime_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232629, RefRangeEnd = 232631, XrefRangeStart = 232583, XrefRangeEnd = 232629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartCachingProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartCachingProcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232631, XrefRangeEnd = 232651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeshPoolingController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshPoolingController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MeshPoolingController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
