using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace BrainFailProductions.PolyFewRuntime;

public static class MeshCombiner : Il2CppSystem.Object
{
	public sealed class StaticRenderer : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_isNewMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_transform;

		private static readonly System.IntPtr NativeFieldInfoPtr_mesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_materials;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool isNewMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNewMesh);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNewMesh)) = flag;
			}
		}

		public unsafe Transform transform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Mesh mesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe Il2CppReferenceArray<Material> materials
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static StaticRenderer()
		{
			Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "StaticRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr, "name");
			NativeFieldInfoPtr_isNewMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr, "isNewMesh");
			NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr, "transform");
			NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr, "mesh");
			NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr, "materials");
		}

		public StaticRenderer(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public StaticRenderer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticRenderer>.NativeClassPtr))
		{
		}
	}

	public sealed class SkinnedRenderer : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hasBlendShapes;

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_isNewMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_transform;

		private static readonly System.IntPtr NativeFieldInfoPtr_mesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_materials;

		private static readonly System.IntPtr NativeFieldInfoPtr_rootBone;

		private static readonly System.IntPtr NativeFieldInfoPtr_bones;

		public unsafe bool hasBlendShapes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBlendShapes);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBlendShapes)) = flag;
			}
		}

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool isNewMesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNewMesh);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNewMesh)) = flag;
			}
		}

		public unsafe Transform transform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Mesh mesh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
			}
		}

		public unsafe Il2CppReferenceArray<Material> materials
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Transform rootBone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootBone);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootBone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe Il2CppReferenceArray<Transform> bones
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bones);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static SkinnedRenderer()
		{
			Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "SkinnedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr);
			NativeFieldInfoPtr_hasBlendShapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "hasBlendShapes");
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "name");
			NativeFieldInfoPtr_isNewMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "isNewMesh");
			NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "transform");
			NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "mesh");
			NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "materials");
			NativeFieldInfoPtr_rootBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "rootBone");
			NativeFieldInfoPtr_bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr, "bones");
		}

		public SkinnedRenderer(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SkinnedRenderer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedRenderer>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public sealed class BlendShape : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ShapeName;

		private static readonly System.IntPtr NativeFieldInfoPtr_Frames;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_BlendShapeFrame_0;

		public unsafe string ShapeName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShapeName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShapeName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Il2CppReferenceArray<BlendShapeFrame> Frames
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Frames);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BlendShapeFrame>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Frames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static BlendShape()
		{
			Il2CppClassPointerStore<BlendShape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "BlendShape");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendShape>.NativeClassPtr);
			NativeFieldInfoPtr_ShapeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, "ShapeName");
			NativeFieldInfoPtr_Frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, "Frames");
			NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_BlendShapeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShape>.NativeClassPtr, 100677317);
		}

		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 369557, RefRangeEnd = 369628, XrefRangeStart = 369557, XrefRangeEnd = 369628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendShape(string shapeName, Il2CppReferenceArray<BlendShapeFrame> frames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendShape>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shapeName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frames);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_BlendShapeFrame_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BlendShape(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public BlendShape()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendShape>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public sealed class BlendShapeFrame : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_shapeName;

		private static readonly System.IntPtr NativeFieldInfoPtr_frameWeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_deltaVertices;

		private static readonly System.IntPtr NativeFieldInfoPtr_deltaNormals;

		private static readonly System.IntPtr NativeFieldInfoPtr_deltaTangents;

		private static readonly System.IntPtr NativeFieldInfoPtr_vertexOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Int32_0;

		public unsafe string shapeName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shapeName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float frameWeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameWeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameWeight)) = num;
			}
		}

		public unsafe Il2CppStructArray<Vector3> deltaVertices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaVertices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaVertices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Vector3> deltaNormals
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaNormals);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaNormals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Vector3> deltaTangents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTangents);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTangents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe int vertexOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexOffset);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexOffset)) = num;
			}
		}

		static BlendShapeFrame()
		{
			Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "BlendShapeFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr);
			NativeFieldInfoPtr_shapeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, "shapeName");
			NativeFieldInfoPtr_frameWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, "frameWeight");
			NativeFieldInfoPtr_deltaVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, "deltaVertices");
			NativeFieldInfoPtr_deltaNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, "deltaNormals");
			NativeFieldInfoPtr_deltaTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, "deltaTangents");
			NativeFieldInfoPtr_vertexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, "vertexOffset");
			NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, 100677318);
			NativeMethodInfoPtr__ctor_Public_Void_String_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr, 100677319);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 376039, RefRangeEnd = 376040, XrefRangeStart = 376037, XrefRangeEnd = 376039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendShapeFrame(float frameWeight, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&frameWeight);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deltaVertices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deltaNormals);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deltaTangents);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 376040, RefRangeEnd = 376042, XrefRangeStart = 376040, XrefRangeEnd = 376040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendShapeFrame(string shapeName, float frameWeight, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents, int vertexOffset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shapeName);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameWeight;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deltaVertices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deltaNormals);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)deltaTangents);
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &vertexOffset;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Single_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BlendShapeFrame(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public BlendShapeFrame()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendShapeFrame>.NativeClassPtr))
		{
		}
	}

	public static class MeshUtils : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_UVChannelCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector2_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector4_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector2_Il2CppReferenceArray_1_List_1_Vector3_Il2CppReferenceArray_1_List_1_Vector4_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshBlendShapes_Public_Static_Il2CppReferenceArray_1_BlendShape_Mesh_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMeshBlendShapes_Public_Static_Void_Mesh_Il2CppReferenceArray_1_BlendShape_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshUVs_Public_Static_Il2CppReferenceArray_1_List_1_Vector4_Mesh_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshUVs_Public_Static_List_1_Vector4_Mesh_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetUsedUVComponents_Public_Static_Int32_List_1_Vector4_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertUVsTo2D_Public_Static_Il2CppStructArray_1_Vector2_List_1_Vector4_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertUVsTo3D_Public_Static_Il2CppStructArray_1_Vector3_List_1_Vector4_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetSubMeshIndexMinMax_Public_Static_Il2CppStructArray_1_Vector2Int_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_byref_IndexFormat_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexMinMax_Private_Static_Void_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_0;

		public unsafe static int UVChannelCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UVChannelCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UVChannelCount, (void*)(&num));
			}
		}

		static MeshUtils()
		{
			Il2CppClassPointerStore<MeshUtils>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "MeshUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr);
			NativeFieldInfoPtr_UVChannelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, "UVChannelCount");
			NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector2_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677320);
			NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector4_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677321);
			NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector2_Il2CppReferenceArray_1_List_1_Vector3_Il2CppReferenceArray_1_List_1_Vector4_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677322);
			NativeMethodInfoPtr_GetMeshBlendShapes_Public_Static_Il2CppReferenceArray_1_BlendShape_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677323);
			NativeMethodInfoPtr_ApplyMeshBlendShapes_Public_Static_Void_Mesh_Il2CppReferenceArray_1_BlendShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677324);
			NativeMethodInfoPtr_GetMeshUVs_Public_Static_Il2CppReferenceArray_1_List_1_Vector4_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677325);
			NativeMethodInfoPtr_GetMeshUVs_Public_Static_List_1_Vector4_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677326);
			NativeMethodInfoPtr_GetUsedUVComponents_Public_Static_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677327);
			NativeMethodInfoPtr_ConvertUVsTo2D_Public_Static_Il2CppStructArray_1_Vector2_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677328);
			NativeMethodInfoPtr_ConvertUVsTo3D_Public_Static_Il2CppStructArray_1_Vector3_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677329);
			NativeMethodInfoPtr_GetSubMeshIndexMinMax_Public_Static_Il2CppStructArray_1_Vector2Int_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_byref_IndexFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677330);
			NativeMethodInfoPtr_GetIndexMinMax_Private_Static_Void_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100677331);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376042, XrefRangeEnd = 376043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateMesh(Il2CppStructArray<Vector3> vertices, Il2CppReferenceArray<Il2CppStructArray<int>> indices, Il2CppStructArray<Vector3> normals, Il2CppStructArray<Vector4> tangents, Il2CppStructArray<Color> colors, Il2CppStructArray<BoneWeight> boneWeights, Il2CppReferenceArray<List<Vector2>> uvs, Il2CppStructArray<Matrix4x4> bindposes, Il2CppReferenceArray<BlendShape> blendShapes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)normals);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tangents);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneWeights);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bindposes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendShapes);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector2_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376043, XrefRangeEnd = 376044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateMesh(Il2CppStructArray<Vector3> vertices, Il2CppReferenceArray<Il2CppStructArray<int>> indices, Il2CppStructArray<Vector3> normals, Il2CppStructArray<Vector4> tangents, Il2CppStructArray<Color> colors, Il2CppStructArray<BoneWeight> boneWeights, Il2CppReferenceArray<List<Vector4>> uvs, Il2CppStructArray<Matrix4x4> bindposes, Il2CppReferenceArray<BlendShape> blendShapes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)normals);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tangents);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneWeights);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bindposes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendShapes);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector4_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376089, RefRangeEnd = 376092, XrefRangeStart = 376044, XrefRangeEnd = 376089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh CreateMesh(Il2CppStructArray<Vector3> vertices, Il2CppReferenceArray<Il2CppStructArray<int>> indices, Il2CppStructArray<Vector3> normals, Il2CppStructArray<Vector4> tangents, Il2CppStructArray<Color> colors, Il2CppStructArray<BoneWeight> boneWeights, Il2CppReferenceArray<List<Vector2>> uvs2D, Il2CppReferenceArray<List<Vector3>> uvs3D, Il2CppReferenceArray<List<Vector4>> uvs4D, Il2CppStructArray<Matrix4x4> bindposes, Il2CppReferenceArray<BlendShape> blendShapes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[11];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)normals);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tangents);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneWeights);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs2D);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs3D);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs4D);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bindposes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendShapes);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMesh_Public_Static_Mesh_Il2CppStructArray_1_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector4_Il2CppStructArray_1_Color_Il2CppStructArray_1_BoneWeight_Il2CppReferenceArray_1_List_1_Vector2_Il2CppReferenceArray_1_List_1_Vector3_Il2CppReferenceArray_1_List_1_Vector4_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_BlendShape_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376092, XrefRangeEnd = 376130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<BlendShape> GetMeshBlendShapes(Mesh mesh)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshBlendShapes_Public_Static_Il2CppReferenceArray_1_BlendShape_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BlendShape>>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 376146, RefRangeEnd = 376147, XrefRangeStart = 376130, XrefRangeEnd = 376146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyMeshBlendShapes(Mesh mesh, Il2CppReferenceArray<BlendShape> blendShapes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendShapes);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyMeshBlendShapes_Public_Static_Void_Mesh_Il2CppReferenceArray_1_BlendShape_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 376165, RefRangeEnd = 376166, XrefRangeStart = 376147, XrefRangeEnd = 376165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<List<Vector4>> GetMeshUVs(Mesh mesh)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshUVs_Public_Static_Il2CppReferenceArray_1_List_1_Vector4_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<Vector4>>>(intPtr) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 376184, RefRangeEnd = 376186, XrefRangeStart = 376166, XrefRangeEnd = 376184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector4> GetMeshUVs(Mesh mesh, int channel)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshUVs_Public_Static_List_1_Vector4_Mesh_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376186, XrefRangeEnd = 376198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetUsedUVComponents(List<Vector4> uvs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsedUVComponents_Public_Static_Int32_List_1_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376198, XrefRangeEnd = 376204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector2> ConvertUVsTo2D(List<Vector4> uvs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertUVsTo2D_Public_Static_Il2CppStructArray_1_Vector2_List_1_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376204, XrefRangeEnd = 376210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> ConvertUVsTo3D(List<Vector4> uvs)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uvs);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertUVsTo3D_Public_Static_Il2CppStructArray_1_Vector3_List_1_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376210, XrefRangeEnd = 376215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector2Int> GetSubMeshIndexMinMax(Il2CppReferenceArray<Il2CppStructArray<int>> indices, out IndexFormat indexFormat)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref indexFormat);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubMeshIndexMinMax_Public_Static_Il2CppStructArray_1_Vector2Int_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_byref_IndexFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376215, XrefRangeEnd = 376216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetIndexMinMax(Il2CppStructArray<int> indices, out int minIndex, out int maxIndex)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref minIndex);
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxIndex);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndexMinMax_Private_Static_Void_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MeshUtils(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("BrainFailProductions.PolyFewRuntime.MeshCombiner+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__11_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__12_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CombineStaticMeshes_b__11_0_Internal_Boolean_MeshRenderer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CombineStaticMeshes_b__11_1_Internal_MeshFilter_MeshRenderer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CombineSkinnedMeshes_b__12_0_Internal_Boolean_SkinnedMeshRenderer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CombineSkinnedMeshes_b__12_1_Internal_Boolean_SkinnedMeshRenderer_0;

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

		public unsafe static Il2CppSystem.Func<MeshRenderer, bool> __9__11_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<MeshRenderer, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__11_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<MeshRenderer, MeshFilter> __9__11_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<MeshRenderer, MeshFilter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__11_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<SkinnedMeshRenderer, bool> __9__12_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<SkinnedMeshRenderer, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__12_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<SkinnedMeshRenderer, bool> __9__12_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<SkinnedMeshRenderer, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__12_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__11_0");
			NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__11_1");
			NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__12_0");
			NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__12_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677333);
			NativeMethodInfoPtr__CombineStaticMeshes_b__11_0_Internal_Boolean_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677334);
			NativeMethodInfoPtr__CombineStaticMeshes_b__11_1_Internal_MeshFilter_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677335);
			NativeMethodInfoPtr__CombineSkinnedMeshes_b__12_0_Internal_Boolean_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677336);
			NativeMethodInfoPtr__CombineSkinnedMeshes_b__12_1_Internal_Boolean_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100677337);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376216, XrefRangeEnd = 376244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CombineStaticMeshes_b__11_0(MeshRenderer renderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CombineStaticMeshes_b__11_0_Internal_Boolean_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376244, XrefRangeEnd = 376248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshFilter _CombineStaticMeshes_b__11_1(MeshRenderer renderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CombineStaticMeshes_b__11_1_Internal_MeshFilter_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376248, XrefRangeEnd = 376261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CombineSkinnedMeshes_b__12_0(SkinnedMeshRenderer renderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CombineSkinnedMeshes_b__12_0_Internal_Boolean_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376261, XrefRangeEnd = 376274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CombineSkinnedMeshes_b__12_1(SkinnedMeshRenderer renderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CombineSkinnedMeshes_b__12_1_Internal_Boolean_SkinnedMeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CopyVertexAttributes_Private_Static_Void_byref_List_1_T_IEnumerable_1_T_Int32_Int32_Int32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyVertexAttributes_Private_Static_Void_byref_List_1_T_IEnumerable_1_T_Int32_Int32_Int32_T_0, Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_MergeArrays_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MergeArrays_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_unityCombinedMeshRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_unityCombinedMeshesMats;

	private static readonly System.IntPtr NativeFieldInfoPtr_didUseUnityCombine;

	private static readonly System.IntPtr NativeFieldInfoPtr_generateUV2;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticRenderers_Public_Static_Il2CppReferenceArray_1_StaticRenderer_Il2CppReferenceArray_1_MeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkinnedRenderers_Public_Static_Il2CppReferenceArray_1_SkinnedRenderer_Il2CppReferenceArray_1_SkinnedMeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineStaticMeshes_Public_Static_Il2CppReferenceArray_1_StaticRenderer_Transform_Int32_Il2CppReferenceArray_1_MeshRenderer_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineSkinnedMeshes_Public_Static_Il2CppReferenceArray_1_SkinnedRenderer_Transform_Int32_Il2CppReferenceArray_1_SkinnedMeshRenderer_byref_Il2CppReferenceArray_1_SkinnedMeshRenderer_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Transform_Il2CppReferenceArray_1_MeshRenderer_byref_Il2CppReferenceArray_1_Material_Dictionary_2_Transform_Transform_Dictionary_2_String_BlendShapeFrame_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_byref_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Il2CppReferenceArray_1_Mesh_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_Tuple_2_Matrix4x4_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Material_Dictionary_2_String_BlendShapeFrame_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Il2CppReferenceArray_1_Mesh_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_Tuple_2_Matrix4x4_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Transform_byref_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Transform_Dictionary_2_String_BlendShapeFrame_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParentAndResetTransform_Private_Static_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParentAndOffsetTransform_Private_Static_Void_Transform_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindBestRootBone_Private_Static_Transform_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindBestRootBone_Private_Static_Transform_Dictionary_2_Transform_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTopLevelParent_Private_Static_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyVertexPositions_Private_Static_Void_List_1_Vector3_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyVertexAttributes_Private_Static_Void_byref_List_1_T_IEnumerable_1_T_Int32_Int32_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeArrays_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformVertices_Private_Static_Void_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformNormals_Private_Static_Void_Il2CppStructArray_1_Vector3_byref_Tuple_2_Matrix4x4_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformTangents_Private_Static_Void_Il2CppStructArray_1_Vector4_byref_Tuple_2_Matrix4x4_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemapBones_Private_Static_Void_Il2CppStructArray_1_BoneWeight_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScaleMatrix_Private_Static_Matrix4x4_byref_Matrix4x4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshesUnity_Private_Static_Void_Transform_Il2CppReferenceArray_1_MeshFilter_0;

	public unsafe static Il2CppReferenceArray<MeshRenderer> unityCombinedMeshRenderers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unityCombinedMeshRenderers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unityCombinedMeshRenderers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Material> unityCombinedMeshesMats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unityCombinedMeshesMats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unityCombinedMeshesMats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool didUseUnityCombine
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_didUseUnityCombine, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_didUseUnityCombine, (void*)(&flag));
		}
	}

	public unsafe static bool generateUV2
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_generateUV2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_generateUV2, (void*)(&flag));
		}
	}

	static MeshCombiner()
	{
		Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFewRuntime", "MeshCombiner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr);
		NativeFieldInfoPtr_unityCombinedMeshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "unityCombinedMeshRenderers");
		NativeFieldInfoPtr_unityCombinedMeshesMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "unityCombinedMeshesMats");
		NativeFieldInfoPtr_didUseUnityCombine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "didUseUnityCombine");
		NativeFieldInfoPtr_generateUV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, "generateUV2");
		NativeMethodInfoPtr_GetStaticRenderers_Public_Static_Il2CppReferenceArray_1_StaticRenderer_Il2CppReferenceArray_1_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677295);
		NativeMethodInfoPtr_GetSkinnedRenderers_Public_Static_Il2CppReferenceArray_1_SkinnedRenderer_Il2CppReferenceArray_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677296);
		NativeMethodInfoPtr_CombineStaticMeshes_Public_Static_Il2CppReferenceArray_1_StaticRenderer_Transform_Int32_Il2CppReferenceArray_1_MeshRenderer_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677297);
		NativeMethodInfoPtr_CombineSkinnedMeshes_Public_Static_Il2CppReferenceArray_1_SkinnedRenderer_Transform_Int32_Il2CppReferenceArray_1_SkinnedMeshRenderer_byref_Il2CppReferenceArray_1_SkinnedMeshRenderer_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677298);
		NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Transform_Il2CppReferenceArray_1_MeshRenderer_byref_Il2CppReferenceArray_1_Material_Dictionary_2_Transform_Transform_Dictionary_2_String_BlendShapeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677299);
		NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_byref_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677300);
		NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Il2CppReferenceArray_1_Mesh_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_Tuple_2_Matrix4x4_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Material_Dictionary_2_String_BlendShapeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677301);
		NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Il2CppReferenceArray_1_Mesh_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_Tuple_2_Matrix4x4_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Transform_byref_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Transform_Dictionary_2_String_BlendShapeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677302);
		NativeMethodInfoPtr_ParentAndResetTransform_Private_Static_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677303);
		NativeMethodInfoPtr_ParentAndOffsetTransform_Private_Static_Void_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677304);
		NativeMethodInfoPtr_FindBestRootBone_Private_Static_Transform_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677305);
		NativeMethodInfoPtr_FindBestRootBone_Private_Static_Transform_Dictionary_2_Transform_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677306);
		NativeMethodInfoPtr_GetTopLevelParent_Private_Static_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677307);
		NativeMethodInfoPtr_CopyVertexPositions_Private_Static_Void_List_1_Vector3_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677308);
		NativeMethodInfoPtr_CopyVertexAttributes_Private_Static_Void_byref_List_1_T_IEnumerable_1_T_Int32_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677309);
		NativeMethodInfoPtr_MergeArrays_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677310);
		NativeMethodInfoPtr_TransformVertices_Private_Static_Void_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677311);
		NativeMethodInfoPtr_TransformNormals_Private_Static_Void_Il2CppStructArray_1_Vector3_byref_Tuple_2_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677312);
		NativeMethodInfoPtr_TransformTangents_Private_Static_Void_Il2CppStructArray_1_Vector4_byref_Tuple_2_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677313);
		NativeMethodInfoPtr_RemapBones_Private_Static_Void_Il2CppStructArray_1_BoneWeight_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677314);
		NativeMethodInfoPtr_ScaleMatrix_Private_Static_Matrix4x4_byref_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677315);
		NativeMethodInfoPtr_CombineMeshesUnity_Private_Static_Void_Transform_Il2CppReferenceArray_1_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCombiner>.NativeClassPtr, 100677316);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 376324, RefRangeEnd = 376325, XrefRangeStart = 376274, XrefRangeEnd = 376324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<StaticRenderer> GetStaticRenderers(Il2CppReferenceArray<MeshRenderer> renderers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStaticRenderers_Public_Static_Il2CppReferenceArray_1_StaticRenderer_Il2CppReferenceArray_1_MeshRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StaticRenderer>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 376360, RefRangeEnd = 376361, XrefRangeStart = 376325, XrefRangeEnd = 376360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<SkinnedRenderer> GetSkinnedRenderers(Il2CppReferenceArray<SkinnedMeshRenderer> renderers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkinnedRenderers_Public_Static_Il2CppReferenceArray_1_SkinnedRenderer_Il2CppReferenceArray_1_SkinnedMeshRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedRenderer>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 376476, RefRangeEnd = 376478, XrefRangeStart = 376361, XrefRangeEnd = 376476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<StaticRenderer> CombineStaticMeshes(Transform transform, int levelIndex, Il2CppReferenceArray<MeshRenderer> renderers, bool autoName = true, string combinedBaseName = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoName;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(combinedBaseName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineStaticMeshes_Public_Static_Il2CppReferenceArray_1_StaticRenderer_Transform_Int32_Il2CppReferenceArray_1_MeshRenderer_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StaticRenderer>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 376563, RefRangeEnd = 376565, XrefRangeStart = 376478, XrefRangeEnd = 376563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<SkinnedRenderer> CombineSkinnedMeshes(Transform transform, int levelIndex, Il2CppReferenceArray<SkinnedMeshRenderer> renderers, ref Il2CppReferenceArray<SkinnedMeshRenderer> renderersActuallyCombined, bool autoName = true, string combinedBaseName = "")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderersActuallyCombined);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoName;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(combinedBaseName);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineSkinnedMeshes_Public_Static_Il2CppReferenceArray_1_SkinnedRenderer_Transform_Int32_Il2CppReferenceArray_1_SkinnedMeshRenderer_byref_Il2CppReferenceArray_1_SkinnedMeshRenderer_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		renderersActuallyCombined = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<SkinnedMeshRenderer>(intPtr4));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedRenderer>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 376672, RefRangeEnd = 376673, XrefRangeStart = 376565, XrefRangeEnd = 376672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh CombineMeshes(Transform rootTransform, Il2CppReferenceArray<MeshRenderer> renderers, out Il2CppReferenceArray<Material> resultMaterials, Dictionary<Transform, Transform> topLevelParents = null, Dictionary<string, BlendShapeFrame> blendShapes = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topLevelParents);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendShapes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Transform_Il2CppReferenceArray_1_MeshRenderer_byref_Il2CppReferenceArray_1_Material_Dictionary_2_Transform_Transform_Dictionary_2_String_BlendShapeFrame_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		resultMaterials = ((num3 == 0) ? null : new Il2CppReferenceArray<Material>((System.IntPtr)num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 376853, RefRangeEnd = 376854, XrefRangeStart = 376673, XrefRangeEnd = 376853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh CombineMeshes(Transform rootTransform, Il2CppReferenceArray<SkinnedMeshRenderer> renderers, out Il2CppReferenceArray<Material> resultMaterials, out Il2CppReferenceArray<Transform> resultBones)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_byref_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num5 = num2;
		resultMaterials = ((num5 == 0) ? null : new Il2CppReferenceArray<Material>((System.IntPtr)num5));
		nint num6 = num4;
		resultBones = ((num6 == 0) ? null : new Il2CppReferenceArray<Transform>((System.IntPtr)num6));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376854, XrefRangeEnd = 376855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh CombineMeshes(Il2CppReferenceArray<Mesh> meshes, Il2CppStructArray<Matrix4x4> transforms, Il2CppReferenceArray<Il2CppSystem.Tuple<Matrix4x4, bool>> normalsTransforms, Il2CppReferenceArray<Il2CppReferenceArray<Material>> materials, out Il2CppReferenceArray<Material> resultMaterials, Dictionary<string, BlendShapeFrame> blendShapes = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transforms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)normalsTransforms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendShapes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Il2CppReferenceArray_1_Mesh_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_Tuple_2_Matrix4x4_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Material_Dictionary_2_String_BlendShapeFrame_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		resultMaterials = ((num3 == 0) ? null : new Il2CppReferenceArray<Material>((System.IntPtr)num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 377071, RefRangeEnd = 377074, XrefRangeStart = 376855, XrefRangeEnd = 377071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh CombineMeshes(Il2CppReferenceArray<Mesh> meshes, Il2CppStructArray<Matrix4x4> transforms, Il2CppReferenceArray<Il2CppSystem.Tuple<Matrix4x4, bool>> normalsTransforms, Il2CppReferenceArray<Il2CppReferenceArray<Material>> materials, Il2CppReferenceArray<Il2CppReferenceArray<Transform>> bones, out Il2CppReferenceArray<Material> resultMaterials, out Il2CppReferenceArray<Transform> resultBones, Dictionary<string, BlendShapeFrame> blendShapes = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transforms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)normalsTransforms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bones);
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blendShapes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Static_Mesh_Il2CppReferenceArray_1_Mesh_Il2CppStructArray_1_Matrix4x4_Il2CppReferenceArray_1_Tuple_2_Matrix4x4_Boolean_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Transform_byref_Il2CppReferenceArray_1_Material_byref_Il2CppReferenceArray_1_Transform_Dictionary_2_String_BlendShapeFrame_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num5 = num2;
		resultMaterials = ((num5 == 0) ? null : new Il2CppReferenceArray<Material>((System.IntPtr)num5));
		nint num6 = num4;
		resultBones = ((num6 == 0) ? null : new Il2CppReferenceArray<Transform>((System.IntPtr)num6));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 377088, RefRangeEnd = 377094, XrefRangeStart = 377074, XrefRangeEnd = 377088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentAndResetTransform(Transform transform, Transform parentTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParentAndResetTransform_Private_Static_Void_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 377108, RefRangeEnd = 377112, XrefRangeStart = 377094, XrefRangeEnd = 377108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParentAndOffsetTransform_Private_Static_Void_Transform_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 377140, RefRangeEnd = 377141, XrefRangeStart = 377112, XrefRangeEnd = 377140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindBestRootBone(Transform transform, Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshRenderers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skinnedMeshRenderers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBestRootBone_Private_Static_Transform_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377141, XrefRangeEnd = 377173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindBestRootBone(Dictionary<Transform, Transform> topLevelParents, Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshRenderers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topLevelParents);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skinnedMeshRenderers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBestRootBone_Private_Static_Transform_Dictionary_2_Transform_Transform_Il2CppReferenceArray_1_SkinnedMeshRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377173, XrefRangeEnd = 377189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform GetTopLevelParent(Transform forObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTopLevelParent_Private_Static_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 377193, RefRangeEnd = 377194, XrefRangeStart = 377189, XrefRangeEnd = 377193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyVertexPositions(List<Vector3> list, Il2CppStructArray<Vector3> arr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyVertexPositions_Private_Static_Void_List_1_Vector3_Il2CppStructArray_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377194, XrefRangeEnd = 377197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue)
	{
		//IL_0099->IL009c: Incompatible stack types: I vs Ref
		//IL_008c->IL009c: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &previousVertexCount;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshVertexCount;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalVertexCount;
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = defaultValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref defaultValue;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyVertexAttributes_Private_Static_Void_byref_List_1_T_IEnumerable_1_T_Int32_Int32_Int32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dest = ((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377197, XrefRangeEnd = 377201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<T> MergeArrays<T>(Il2CppArrayBase<T> arr1, Il2CppArrayBase<T> arr2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MergeArrays_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 377202, RefRangeEnd = 377204, XrefRangeStart = 377201, XrefRangeEnd = 377202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TransformVertices(Il2CppStructArray<Vector3> vertices, ref Matrix4x4 transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformVertices_Private_Static_Void_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 377211, RefRangeEnd = 377212, XrefRangeStart = 377204, XrefRangeEnd = 377211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TransformNormals(Il2CppStructArray<Vector3> normals, ref Il2CppSystem.Tuple<Matrix4x4, bool> transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)normals);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformNormals_Private_Static_Void_Il2CppStructArray_1_Vector3_byref_Tuple_2_Matrix4x4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		transform = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppSystem.Tuple<Matrix4x4, bool>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 377214, RefRangeEnd = 377215, XrefRangeStart = 377212, XrefRangeEnd = 377214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TransformTangents(Il2CppStructArray<Vector4> tangents, ref Il2CppSystem.Tuple<Matrix4x4, bool> transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tangents);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformTangents_Private_Static_Void_Il2CppStructArray_1_Vector4_byref_Tuple_2_Matrix4x4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		transform = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppSystem.Tuple<Matrix4x4, bool>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377215, XrefRangeEnd = 377216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemapBones(Il2CppStructArray<BoneWeight> boneWeights, Il2CppStructArray<int> boneIndices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneWeights);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneIndices);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemapBones_Private_Static_Void_Il2CppStructArray_1_BoneWeight_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Matrix4x4 ScaleMatrix(ref Matrix4x4 matrix, float scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref matrix);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleMatrix_Private_Static_Matrix4x4_byref_Matrix4x4_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 377366, RefRangeEnd = 377367, XrefRangeStart = 377216, XrefRangeEnd = 377366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CombineMeshesUnity(Transform parentTransform, Il2CppReferenceArray<MeshFilter> meshFilters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshFilters);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshesUnity_Private_Static_Void_Transform_Il2CppReferenceArray_1_MeshFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MeshCombiner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
