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

public class MaterialsController : MonoBehaviour
{
	[System.Serializable]
	public class MaterialDebug : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeFieldInfoPtr_mat;

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

		public unsafe Toolbox.MaterialKey key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe Material mat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		static MaterialDebug()
		{
			Il2CppClassPointerStore<MaterialDebug>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MaterialDebug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialDebug>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialDebug>.NativeClassPtr, "name");
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialDebug>.NativeClassPtr, "key");
			NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialDebug>.NativeClassPtr, "mat");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialDebug>.NativeClassPtr, 100668432);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialDebug()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialDebug>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaterialDebug(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct FootprintMaterialKey
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_strength;

		private static readonly System.IntPtr NativeFieldInfoPtr_blood;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_FootprintMaterialKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FootprintMaterialKey_FootprintMaterialKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FootprintMaterialKey_FootprintMaterialKey_0;

		[FieldOffset(0)]
		public int type;

		[FieldOffset(4)]
		public float strength;

		[FieldOffset(8)]
		public float blood;

		static FootprintMaterialKey()
		{
			Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "FootprintMaterialKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, "type");
			NativeFieldInfoPtr_strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, "strength");
			NativeFieldInfoPtr_blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, "blood");
			NativeMethodInfoPtr_Equals_Public_Boolean_FootprintMaterialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, 100668433);
			NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, 100668434);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, 100668435);
			NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FootprintMaterialKey_FootprintMaterialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, 100668436);
			NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FootprintMaterialKey_FootprintMaterialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, 100668437);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172132, RefRangeEnd = 172134, XrefRangeStart = 172127, XrefRangeEnd = 172132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FootprintMaterialKey other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&other);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_FootprintMaterialKey_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172134, XrefRangeEnd = 172145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Il2CppSystem.Object obj)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172145, XrefRangeEnd = 172157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172157, XrefRangeEnd = 172158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FootprintMaterialKey c1, FootprintMaterialKey c2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&c1);
			*(FootprintMaterialKey**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FootprintMaterialKey_FootprintMaterialKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172158, XrefRangeEnd = 172159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(FootprintMaterialKey c1, FootprintMaterialKey c2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&c1);
			*(FootprintMaterialKey**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FootprintMaterialKey_FootprintMaterialKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FootprintMaterialKey>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("MaterialsController+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__39_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__39_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PopulateDebugData_b__39_0_Internal_Int32_MaterialDebug_MaterialDebug_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PopulateDebugData_b__39_1_Internal_Int32_MaterialDebug_MaterialDebug_0;

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

		public unsafe static Il2CppSystem.Comparison<MaterialDebug> __9__39_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<MaterialDebug>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__39_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<MaterialDebug> __9__39_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<MaterialDebug>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__39_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__39_0");
			NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__39_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668439);
			NativeMethodInfoPtr__PopulateDebugData_b__39_0_Internal_Int32_MaterialDebug_MaterialDebug_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668440);
			NativeMethodInfoPtr__PopulateDebugData_b__39_1_Internal_Int32_MaterialDebug_MaterialDebug_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668441);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172159, XrefRangeEnd = 172161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _PopulateDebugData_b__39_0(MaterialDebug p1, MaterialDebug p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PopulateDebugData_b__39_0_Internal_Int32_MaterialDebug_MaterialDebug_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _PopulateDebugData_b__39_1(MaterialDebug p1, MaterialDebug p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PopulateDebugData_b__39_1_Internal_Int32_MaterialDebug_MaterialDebug_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_commonMaterialsLibrary;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueMaterialsLibrary;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintMaterialLibrary;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialInstancesAvertedByCommonDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOfBaseMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightMaterialInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintInstancesAvertedByDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintMaterialShoe;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintMaterialBoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintMaterialHeel;

	private static readonly System.IntPtr NativeFieldInfoPtr_dirtColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_commonMaterialsDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueMaterialsDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_NO_MAT_COLOUR_KEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_RAIN_WINDOW_GLASS_KEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_BASE_COLOR_KEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_COLOR1_KEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_COLOR2_KEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_COLOR3_KEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATERIAL_GRUB_AMOUNT_KEY;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MaterialsController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterialGroup_Public_Material_GameObject_MaterialGroupPreset_MaterialKey_Boolean_MeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMaterialKey_Public_Material_GameObject_MaterialKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMaterialKey_Public_Material_MeshRenderer_MaterialKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialFromKey_Public_Material_MaterialKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMaterialKey_Public_MaterialKey_MaterialVariation_ColourSchemePreset_NewRoom_Boolean_NewBuilding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMaterial_Public_Void_MeshRenderer_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColourFromScheme_Public_Color_ColourSchemePreset_MaterialColour_NewRoom_NewBuilding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFootprintMaterial_Public_Material_FootprintController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateDebugData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<Toolbox.MaterialKey, Material> commonMaterialsLibrary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonMaterialsLibrary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Toolbox.MaterialKey, Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonMaterialsLibrary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Toolbox.MaterialKey, List<Material>> uniqueMaterialsLibrary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueMaterialsLibrary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Toolbox.MaterialKey, List<Material>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueMaterialsLibrary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<FootprintMaterialKey, Material> footprintMaterialLibrary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialLibrary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<FootprintMaterialKey, Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialLibrary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int materialCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialCount)) = num;
		}
	}

	public unsafe int materialInstancesAvertedByCommonDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialInstancesAvertedByCommonDictionary);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialInstancesAvertedByCommonDictionary)) = num;
		}
	}

	public unsafe int useOfBaseMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOfBaseMaterials);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOfBaseMaterials)) = num;
		}
	}

	public unsafe int lightMaterialInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightMaterialInstances);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightMaterialInstances)) = num;
		}
	}

	public unsafe int footprintMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterials);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterials)) = num;
		}
	}

	public unsafe int footprintInstancesAvertedByDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintInstancesAvertedByDictionary);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintInstancesAvertedByDictionary)) = num;
		}
	}

	public unsafe Material footprintMaterialShoe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialShoe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialShoe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material footprintMaterialBoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialBoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialBoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material footprintMaterialHeel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialHeel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintMaterialHeel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Color dirtColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtColour)) = color;
		}
	}

	public unsafe Color bloodColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodColour)) = color;
		}
	}

	public unsafe List<MaterialDebug> commonMaterialsDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonMaterialsDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialDebug>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonMaterialsDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MaterialDebug> uniqueMaterialsDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueMaterialsDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialDebug>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueMaterialsDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static MaterialsController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialsController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialsController));
		}
	}

	public unsafe static string MATERIAL_NO_MAT_COLOUR_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_NO_MAT_COLOUR_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_NO_MAT_COLOUR_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MATERIAL_RAIN_WINDOW_GLASS_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_RAIN_WINDOW_GLASS_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_RAIN_WINDOW_GLASS_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MATERIAL_BASE_COLOR_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_BASE_COLOR_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_BASE_COLOR_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MATERIAL_COLOR1_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_COLOR1_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_COLOR1_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MATERIAL_COLOR2_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_COLOR2_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_COLOR2_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MATERIAL_COLOR3_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_COLOR3_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_COLOR3_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MATERIAL_GRUB_AMOUNT_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATERIAL_GRUB_AMOUNT_KEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATERIAL_GRUB_AMOUNT_KEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static MaterialsController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172161, XrefRangeEnd = 172165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_MaterialsController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialsController>(intPtr) : null;
		}
	}

	static MaterialsController()
	{
		Il2CppClassPointerStore<MaterialsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MaterialsController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr);
		NativeFieldInfoPtr_commonMaterialsLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "commonMaterialsLibrary");
		NativeFieldInfoPtr_uniqueMaterialsLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "uniqueMaterialsLibrary");
		NativeFieldInfoPtr_footprintMaterialLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "footprintMaterialLibrary");
		NativeFieldInfoPtr_materialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "materialCount");
		NativeFieldInfoPtr_materialInstancesAvertedByCommonDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "materialInstancesAvertedByCommonDictionary");
		NativeFieldInfoPtr_useOfBaseMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "useOfBaseMaterials");
		NativeFieldInfoPtr_lightMaterialInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "lightMaterialInstances");
		NativeFieldInfoPtr_footprintMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "footprintMaterials");
		NativeFieldInfoPtr_footprintInstancesAvertedByDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "footprintInstancesAvertedByDictionary");
		NativeFieldInfoPtr_footprintMaterialShoe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "footprintMaterialShoe");
		NativeFieldInfoPtr_footprintMaterialBoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "footprintMaterialBoot");
		NativeFieldInfoPtr_footprintMaterialHeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "footprintMaterialHeel");
		NativeFieldInfoPtr_dirtColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "dirtColour");
		NativeFieldInfoPtr_bloodColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "bloodColour");
		NativeFieldInfoPtr_commonMaterialsDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "commonMaterialsDebug");
		NativeFieldInfoPtr_uniqueMaterialsDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "uniqueMaterialsDebug");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_MATERIAL_NO_MAT_COLOUR_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MATERIAL_NO_MAT_COLOUR_KEY");
		NativeFieldInfoPtr_MATERIAL_RAIN_WINDOW_GLASS_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MATERIAL_RAIN_WINDOW_GLASS_KEY");
		NativeFieldInfoPtr_MATERIAL_BASE_COLOR_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MATERIAL_BASE_COLOR_KEY");
		NativeFieldInfoPtr_MATERIAL_COLOR1_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MATERIAL_COLOR1_KEY");
		NativeFieldInfoPtr_MATERIAL_COLOR2_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MATERIAL_COLOR2_KEY");
		NativeFieldInfoPtr_MATERIAL_COLOR3_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MATERIAL_COLOR3_KEY");
		NativeFieldInfoPtr_MATERIAL_GRUB_AMOUNT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, "MATERIAL_GRUB_AMOUNT_KEY");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_MaterialsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668417);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668418);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668419);
		NativeMethodInfoPtr_SetMaterialGroup_Public_Material_GameObject_MaterialGroupPreset_MaterialKey_Boolean_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668420);
		NativeMethodInfoPtr_ApplyMaterialKey_Public_Material_GameObject_MaterialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668421);
		NativeMethodInfoPtr_ApplyMaterialKey_Public_Material_MeshRenderer_MaterialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668422);
		NativeMethodInfoPtr_GetMaterialFromKey_Public_Material_MaterialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668423);
		NativeMethodInfoPtr_GenerateMaterialKey_Public_MaterialKey_MaterialVariation_ColourSchemePreset_NewRoom_Boolean_NewBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668424);
		NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668425);
		NativeMethodInfoPtr_ApplyMaterial_Public_Void_MeshRenderer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668426);
		NativeMethodInfoPtr_GetColourFromScheme_Public_Color_ColourSchemePreset_MaterialColour_NewRoom_NewBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668427);
		NativeMethodInfoPtr_GetFootprintMaterial_Public_Material_FootprintController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668428);
		NativeMethodInfoPtr_PopulateDebugData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668429);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr, 100668430);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172165, XrefRangeEnd = 172208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172208, XrefRangeEnd = 172321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 172462, RefRangeEnd = 172489, XrefRangeStart = 172321, XrefRangeEnd = 172462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material SetMaterialGroup(GameObject model, MaterialGroupPreset preset, Toolbox.MaterialKey key, bool forceUniqueInstance = false, MeshRenderer renderer = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUniqueInstance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterialGroup_Public_Material_GameObject_MaterialGroupPreset_MaterialKey_Boolean_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 172511, RefRangeEnd = 172516, XrefRangeStart = 172489, XrefRangeEnd = 172511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material ApplyMaterialKey(GameObject model, Toolbox.MaterialKey key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyMaterialKey_Public_Material_GameObject_MaterialKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 172624, RefRangeEnd = 172632, XrefRangeStart = 172516, XrefRangeEnd = 172624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material ApplyMaterialKey(MeshRenderer renderer, Toolbox.MaterialKey key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyMaterialKey_Public_Material_MeshRenderer_MaterialKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172676, RefRangeEnd = 172677, XrefRangeStart = 172632, XrefRangeEnd = 172676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material GetMaterialFromKey(Toolbox.MaterialKey key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialFromKey_Public_Material_MaterialKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 172758, RefRangeEnd = 172770, XrefRangeStart = 172677, XrefRangeEnd = 172758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Toolbox.MaterialKey GenerateMaterialKey(MaterialGroupPreset.MaterialVariation variation, ColourSchemePreset scheme, NewRoom room, bool useGrubiness, NewBuilding building = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)variation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheme);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useGrubiness;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)building);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateMaterialKey_Public_MaterialKey_MaterialVariation_ColourSchemePreset_NewRoom_Boolean_NewBuilding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172797, RefRangeEnd = 172798, XrefRangeStart = 172770, XrefRangeEnd = 172797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyMaterial(GameObject model, Material mat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172798, XrefRangeEnd = 172811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyMaterial(MeshRenderer renderer, Material mat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyMaterial_Public_Void_MeshRenderer_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 172850, RefRangeEnd = 172858, XrefRangeStart = 172811, XrefRangeEnd = 172850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColourFromScheme(ColourSchemePreset scheme, MaterialGroupPreset.MaterialColour colourType, NewRoom room, NewBuilding building = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scheme);
		*(MaterialGroupPreset.MaterialColour**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colourType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)building);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColourFromScheme_Public_Color_ColourSchemePreset_MaterialColour_NewRoom_NewBuilding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172918, RefRangeEnd = 172919, XrefRangeStart = 172858, XrefRangeEnd = 172918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material GetFootprintMaterial(FootprintController fc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFootprintMaterial_Public_Material_FootprintController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172919, XrefRangeEnd = 173007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateDebugData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateDebugData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173007, XrefRangeEnd = 173035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialsController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialsController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MaterialsController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
