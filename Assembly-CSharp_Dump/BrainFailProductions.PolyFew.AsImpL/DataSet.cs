using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL;

public class DataSet : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct FaceIndices
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_vertIdx;

		private static readonly System.IntPtr NativeFieldInfoPtr_uvIdx;

		private static readonly System.IntPtr NativeFieldInfoPtr_normIdx;

		[FieldOffset(0)]
		public int vertIdx;

		[FieldOffset(4)]
		public int uvIdx;

		[FieldOffset(8)]
		public int normIdx;

		static FaceIndices()
		{
			Il2CppClassPointerStore<FaceIndices>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "FaceIndices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceIndices>.NativeClassPtr);
			NativeFieldInfoPtr_vertIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceIndices>.NativeClassPtr, "vertIdx");
			NativeFieldInfoPtr_uvIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceIndices>.NativeClassPtr, "uvIdx");
			NativeFieldInfoPtr_normIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceIndices>.NativeClassPtr, "normIdx");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceIndices>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class ObjectData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_faceGroups;

		private static readonly System.IntPtr NativeFieldInfoPtr_allFaces;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasNormals;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasColors;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

		public unsafe List<FaceGroupData> faceGroups
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceGroups);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FaceGroupData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceGroups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<FaceIndices> allFaces
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allFaces);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FaceIndices>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allFaces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool hasNormals
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasNormals);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasNormals)) = flag;
			}
		}

		public unsafe bool hasColors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasColors);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasColors)) = flag;
			}
		}

		static ObjectData()
		{
			Il2CppClassPointerStore<ObjectData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "ObjectData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectData>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectData>.NativeClassPtr, "name");
			NativeFieldInfoPtr_faceGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectData>.NativeClassPtr, "faceGroups");
			NativeFieldInfoPtr_allFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectData>.NativeClassPtr, "allFaces");
			NativeFieldInfoPtr_hasNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectData>.NativeClassPtr, "hasNormals");
			NativeFieldInfoPtr_hasColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectData>.NativeClassPtr, "hasColors");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectData>.NativeClassPtr, 100676983);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 370692, RefRangeEnd = 370695, XrefRangeStart = 370681, XrefRangeEnd = 370692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ObjectData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class FaceGroupData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialName;

		private static readonly System.IntPtr NativeFieldInfoPtr_faces;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

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

		public unsafe List<FaceIndices> faces
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faces);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FaceIndices>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370704, XrefRangeEnd = 370705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static FaceGroupData()
		{
			Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "FaceGroupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr, "name");
			NativeFieldInfoPtr_materialName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr, "materialName");
			NativeFieldInfoPtr_faces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr, "faces");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr, 100676984);
			NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr, 100676985);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 370700, RefRangeEnd = 370704, XrefRangeStart = 370695, XrefRangeEnd = 370700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceGroupData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceGroupData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FaceGroupData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_objectList;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertList;

	private static readonly System.IntPtr NativeFieldInfoPtr_uvList;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalList;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorList;

	private static readonly System.IntPtr NativeFieldInfoPtr_unnamedGroupIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_currObjData;

	private static readonly System.IntPtr NativeFieldInfoPtr_currGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_noFaceDefined;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrGroupName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFaceIndicesKey_Public_Static_String_FaceIndices_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixMaterialName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObject_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGroup_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMaterialName_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddVertex_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUV_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNormal_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFaceIndices_Public_Void_FaceIndices_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintSummary_Public_Void_0;

	public unsafe List<ObjectData> objectList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObjectData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3> vertList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector2> uvList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uvList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3> normalList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Color> colorList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int unnamedGroupIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unnamedGroupIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unnamedGroupIndex)) = num;
		}
	}

	public unsafe ObjectData currObjData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currObjData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currObjData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectData));
		}
	}

	public unsafe FaceGroupData currGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FaceGroupData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)faceGroupData));
		}
	}

	public unsafe bool noFaceDefined
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noFaceDefined);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noFaceDefined)) = flag;
		}
	}

	public unsafe string CurrGroupName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370705, XrefRangeEnd = 370706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrGroupName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe bool IsEmpty
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370706, XrefRangeEnd = 370707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static DataSet()
	{
		Il2CppClassPointerStore<DataSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BrainFailProductions.PolyFew.AsImpL", "DataSet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataSet>.NativeClassPtr);
		NativeFieldInfoPtr_objectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "objectList");
		NativeFieldInfoPtr_vertList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "vertList");
		NativeFieldInfoPtr_uvList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "uvList");
		NativeFieldInfoPtr_normalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "normalList");
		NativeFieldInfoPtr_colorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "colorList");
		NativeFieldInfoPtr_unnamedGroupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "unnamedGroupIndex");
		NativeFieldInfoPtr_currObjData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "currObjData");
		NativeFieldInfoPtr_currGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "currGroup");
		NativeFieldInfoPtr_noFaceDefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataSet>.NativeClassPtr, "noFaceDefined");
		NativeMethodInfoPtr_get_CurrGroupName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676969);
		NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676970);
		NativeMethodInfoPtr_GetFaceIndicesKey_Public_Static_String_FaceIndices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676971);
		NativeMethodInfoPtr_FixMaterialName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676972);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676973);
		NativeMethodInfoPtr_AddObject_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676974);
		NativeMethodInfoPtr_AddGroup_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676975);
		NativeMethodInfoPtr_AddMaterialName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676976);
		NativeMethodInfoPtr_AddVertex_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676977);
		NativeMethodInfoPtr_AddUV_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676978);
		NativeMethodInfoPtr_AddNormal_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676979);
		NativeMethodInfoPtr_AddColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676980);
		NativeMethodInfoPtr_AddFaceIndices_Public_Void_FaceIndices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676981);
		NativeMethodInfoPtr_PrintSummary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataSet>.NativeClassPtr, 100676982);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 370740, RefRangeEnd = 370743, XrefRangeStart = 370707, XrefRangeEnd = 370740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFaceIndicesKey(FaceIndices fi)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fi);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFaceIndicesKey_Public_Static_String_FaceIndices_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 370752, RefRangeEnd = 370754, XrefRangeStart = 370743, XrefRangeEnd = 370752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FixMaterialName(string mtlName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(mtlName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixMaterialName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 370795, RefRangeEnd = 370796, XrefRangeStart = 370754, XrefRangeEnd = 370795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataSet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataSet>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 370817, RefRangeEnd = 370818, XrefRangeStart = 370796, XrefRangeEnd = 370817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddObject(string objectName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObject_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 370835, RefRangeEnd = 370837, XrefRangeStart = 370818, XrefRangeEnd = 370835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddGroup(string groupName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(groupName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGroup_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 370842, RefRangeEnd = 370843, XrefRangeStart = 370837, XrefRangeEnd = 370842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMaterialName(string matName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(matName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMaterialName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 370845, RefRangeEnd = 370846, XrefRangeStart = 370843, XrefRangeEnd = 370845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddVertex(Vector3 vertex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vertex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVertex_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 370849, RefRangeEnd = 370850, XrefRangeStart = 370846, XrefRangeEnd = 370849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUV(Vector2 uv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUV_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 370852, RefRangeEnd = 370853, XrefRangeStart = 370850, XrefRangeEnd = 370852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNormal(Vector3 normal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&normal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNormal_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 370856, RefRangeEnd = 370857, XrefRangeStart = 370853, XrefRangeEnd = 370856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddColor(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 370862, RefRangeEnd = 370868, XrefRangeStart = 370857, XrefRangeEnd = 370862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFaceIndices(FaceIndices faceIdx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&faceIdx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFaceIndices_Public_Void_FaceIndices_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370868, XrefRangeEnd = 371013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintSummary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintSummary_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DataSet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
