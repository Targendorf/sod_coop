using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

public class ObjectBuilder : Il2CppSystem.Object
{
	public class ProgressInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_materialsLoaded;

		private static readonly System.IntPtr NativeFieldInfoPtr_objectsLoaded;

		private static readonly System.IntPtr NativeFieldInfoPtr_groupsLoaded;

		private static readonly System.IntPtr NativeFieldInfoPtr_numGroups;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int materialsLoaded
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsLoaded);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsLoaded)) = num;
			}
		}

		public unsafe int objectsLoaded
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsLoaded);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsLoaded)) = num;
			}
		}

		public unsafe int groupsLoaded
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupsLoaded);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupsLoaded)) = num;
			}
		}

		public unsafe int numGroups
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGroups);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGroups)) = num;
			}
		}

		static ProgressInfo()
		{
			Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "ProgressInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr);
			NativeFieldInfoPtr_materialsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr, "materialsLoaded");
			NativeFieldInfoPtr_objectsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr, "objectsLoaded");
			NativeFieldInfoPtr_groupsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr, "groupsLoaded");
			NativeFieldInfoPtr_numGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr, "numGroups");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr, 100677007);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ProgressInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BuildStatus : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_objCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_subObjCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_idxCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_grpIdx;

		private static readonly System.IntPtr NativeFieldInfoPtr_numGroups;

		private static readonly System.IntPtr NativeFieldInfoPtr_grpFaceIdx;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshPartIdx;

		private static readonly System.IntPtr NativeFieldInfoPtr_totFaceIdxCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_currObjGameObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_subObjParent;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool newObject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newObject);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newObject)) = flag;
			}
		}

		public unsafe int objCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objCount)) = num;
			}
		}

		public unsafe int subObjCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjCount)) = num;
			}
		}

		public unsafe int idxCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idxCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idxCount)) = num;
			}
		}

		public unsafe int grpIdx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grpIdx);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grpIdx)) = num;
			}
		}

		public unsafe int numGroups
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGroups);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGroups)) = num;
			}
		}

		public unsafe int grpFaceIdx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grpFaceIdx);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grpFaceIdx)) = num;
			}
		}

		public unsafe int meshPartIdx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshPartIdx);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshPartIdx)) = num;
			}
		}

		public unsafe int totFaceIdxCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totFaceIdxCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totFaceIdxCount)) = num;
			}
		}

		public unsafe GameObject currObjGameObject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currObjGameObject);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currObjGameObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe GameObject subObjParent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjParent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		static BuildStatus()
		{
			Il2CppClassPointerStore<BuildStatus>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "BuildStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr);
			NativeFieldInfoPtr_newObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "newObject");
			NativeFieldInfoPtr_objCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "objCount");
			NativeFieldInfoPtr_subObjCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "subObjCount");
			NativeFieldInfoPtr_idxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "idxCount");
			NativeFieldInfoPtr_grpIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "grpIdx");
			NativeFieldInfoPtr_numGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "numGroups");
			NativeFieldInfoPtr_grpFaceIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "grpFaceIdx");
			NativeFieldInfoPtr_meshPartIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "meshPartIdx");
			NativeFieldInfoPtr_totFaceIdxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "totFaceIdxCount");
			NativeFieldInfoPtr_currObjGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "currObjGameObject");
			NativeFieldInfoPtr_subObjParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, "subObjParent");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr, 100677008);
		}

		[CallerCount(0)]
		public unsafe BuildStatus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStatus>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BuildStatus(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_buildOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_currDataSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_currParentObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_currMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialData;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_VERTICES_LIMIT_FOR_A_MESH;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_INDICES_LIMIT_FOR_A_MESH;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_VERT_COUNT;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ImportedMaterials_Public_get_Dictionary_2_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NumImportedMaterials_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitBuildMaterials_Public_Void_List_1_MaterialData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildMaterials_Public_Boolean_ProgressInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartBuildObjectAsync_Public_Void_DataSet_GameObject_Dictionary_2_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildObjectAsync_Public_Boolean_byref_ProgressInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Solve_Public_Static_Void_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildMeshCollider_Public_Static_Void_GameObject_Boolean_Boolean_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildNextObject_Protected_Boolean_GameObject_Dictionary_2_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportSubObject_Private_GameObject_GameObject_ObjectData_Dictionary_2_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildMaterial_Private_Material_MaterialData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Using32bitIndices_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ImportOptions buildOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImportOptions>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)importOptions));
		}
	}

	public unsafe BuildStatus buildStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildStatus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuildStatus>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildStatus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildStatus));
		}
	}

	public unsafe DataSet currDataSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currDataSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataSet>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currDataSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataSet));
		}
	}

	public unsafe GameObject currParentObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currParentObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currParentObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Dictionary<string, Material> currMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<MaterialData> materialData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int MAX_VERTICES_LIMIT_FOR_A_MESH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_VERTICES_LIMIT_FOR_A_MESH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_VERTICES_LIMIT_FOR_A_MESH, (void*)(&num));
		}
	}

	public unsafe static int MAX_INDICES_LIMIT_FOR_A_MESH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_INDICES_LIMIT_FOR_A_MESH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_INDICES_LIMIT_FOR_A_MESH, (void*)(&num));
		}
	}

	public unsafe static int MAX_VERT_COUNT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_VERT_COUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_VERT_COUNT, (void*)(&num));
		}
	}

	public unsafe Dictionary<string, Material> ImportedMaterials
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 353048, RefRangeEnd = 353057, XrefRangeStart = 353048, XrefRangeEnd = 353057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ImportedMaterials_Public_get_Dictionary_2_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Material>>(intPtr) : null;
		}
	}

	public unsafe int NumImportedMaterials
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371113, RefRangeEnd = 371114, XrefRangeStart = 371112, XrefRangeEnd = 371113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumImportedMaterials_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ObjectBuilder()
	{
		Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "ObjectBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_buildOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "buildOptions");
		NativeFieldInfoPtr_buildStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "buildStatus");
		NativeFieldInfoPtr_currDataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "currDataSet");
		NativeFieldInfoPtr_currParentObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "currParentObj");
		NativeFieldInfoPtr_currMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "currMaterials");
		NativeFieldInfoPtr_materialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "materialData");
		NativeFieldInfoPtr_MAX_VERTICES_LIMIT_FOR_A_MESH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "MAX_VERTICES_LIMIT_FOR_A_MESH");
		NativeFieldInfoPtr_MAX_INDICES_LIMIT_FOR_A_MESH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "MAX_INDICES_LIMIT_FOR_A_MESH");
		NativeFieldInfoPtr_MAX_VERT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, "MAX_VERT_COUNT");
		NativeMethodInfoPtr_get_ImportedMaterials_Public_get_Dictionary_2_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100676993);
		NativeMethodInfoPtr_get_NumImportedMaterials_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100676994);
		NativeMethodInfoPtr_InitBuildMaterials_Public_Void_List_1_MaterialData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100676995);
		NativeMethodInfoPtr_BuildMaterials_Public_Boolean_ProgressInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100676996);
		NativeMethodInfoPtr_StartBuildObjectAsync_Public_Void_DataSet_GameObject_Dictionary_2_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100676997);
		NativeMethodInfoPtr_BuildObjectAsync_Public_Boolean_byref_ProgressInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100676998);
		NativeMethodInfoPtr_Solve_Public_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100676999);
		NativeMethodInfoPtr_BuildMeshCollider_Public_Static_Void_GameObject_Boolean_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100677000);
		NativeMethodInfoPtr_BuildNextObject_Protected_Boolean_GameObject_Dictionary_2_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100677001);
		NativeMethodInfoPtr_ImportSubObject_Private_GameObject_GameObject_ObjectData_Dictionary_2_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100677002);
		NativeMethodInfoPtr_BuildMaterial_Private_Material_MaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100677003);
		NativeMethodInfoPtr_Using32bitIndices_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100677004);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr, 100677005);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 371159, RefRangeEnd = 371162, XrefRangeStart = 371114, XrefRangeEnd = 371159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitBuildMaterials(List<MaterialData> materialData, bool hasColors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasColors;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitBuildMaterials_Public_Void_List_1_MaterialData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 371180, RefRangeEnd = 371183, XrefRangeStart = 371162, XrefRangeEnd = 371180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BuildMaterials(ProgressInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildMaterials_Public_Boolean_ProgressInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 371183, RefRangeEnd = 371185, XrefRangeStart = 371183, XrefRangeEnd = 371183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartBuildObjectAsync(DataSet dataSet, GameObject parentObj, Dictionary<string, Material> materials = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataSet);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentObj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materials);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartBuildObjectAsync_Public_Void_DataSet_GameObject_Dictionary_2_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371186, RefRangeEnd = 371187, XrefRangeStart = 371185, XrefRangeEnd = 371186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BuildObjectAsync(ref ProgressInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildObjectAsync_Public_Boolean_byref_ProgressInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		info = ((intPtr4 == (System.IntPtr)0) ? null : new ProgressInfo(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371233, RefRangeEnd = 371234, XrefRangeStart = 371187, XrefRangeEnd = 371233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Solve(Mesh origMesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)origMesh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Solve_Public_Static_Void_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371268, RefRangeEnd = 371269, XrefRangeStart = 371234, XrefRangeEnd = 371268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildMeshCollider(GameObject targetObject, bool convex = false, bool isTrigger = false, bool inflateMesh = false, float skinWidth = 0.01f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &convex;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTrigger;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inflateMesh;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &skinWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildMeshCollider_Public_Static_Void_GameObject_Boolean_Boolean_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 371394, RefRangeEnd = 371397, XrefRangeStart = 371269, XrefRangeEnd = 371394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BuildNextObject(GameObject parentObj, Dictionary<string, Material> mats)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentObj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mats);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildNextObject_Protected_Boolean_GameObject_Dictionary_2_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371585, RefRangeEnd = 371586, XrefRangeStart = 371397, XrefRangeEnd = 371585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject ImportSubObject(GameObject parentObj, DataSet.ObjectData objData, Dictionary<string, Material> mats)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentObj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mats);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportSubObject_Private_GameObject_GameObject_ObjectData_Dictionary_2_String_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 371783, RefRangeEnd = 371784, XrefRangeStart = 371586, XrefRangeEnd = 371783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material BuildMaterial(MaterialData md)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)md);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildMaterial_Private_Material_MaterialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe bool Using32bitIndices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Using32bitIndices_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371784, XrefRangeEnd = 371787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectBuilder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectBuilder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObjectBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
