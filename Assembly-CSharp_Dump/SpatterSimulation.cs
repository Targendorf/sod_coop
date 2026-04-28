using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

[System.Serializable]
public class SpatterSimulation : Il2CppSystem.Object
{
	public enum EraseMode
	{
		neverOrManual,
		onceExecutedAndOutOfBuildingPlusDespawnTime,
		onceExecutedAndOutOfAddressPlusDespawnTime,
		useDespawnTime,
		useDespawnTimeOnceExecuted,
		quickDespawn
	}

	public enum ForceType
	{
		bulletForward,
		bulletBack,
		punch
	}

	[System.Serializable]
	public class DecalSpawnData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_parentID;

		private static readonly System.IntPtr NativeFieldInfoPtr_transformParentID;

		private static readonly System.IntPtr NativeFieldInfoPtr_subObjectName;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldEuler;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialType;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawnedProjector;

		private static readonly System.IntPtr NativeFieldInfoPtr_i;

		private static readonly System.IntPtr NativeFieldInfoPtr_sim;

		private static readonly System.IntPtr NativeFieldInfoPtr_INITIAL_POOL_SIZE;

		private static readonly System.IntPtr NativeFieldInfoPtr_RECYCLED_Y_POSITION;

		private static readonly System.IntPtr NativeFieldInfoPtr_decalPool;

		private static readonly System.IntPtr NativeMethodInfoPtr_SpawnOnTransform_Public_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitialisePool_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetNewDecalProjector_Public_Static_DecalProjector_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RecycleDecalProjector_Public_Static_Void_DecalProjector_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ParentID parentID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentID);
				return *(ParentID*)num;
			}
			set
			{
				*(ParentID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentID)) = parentID;
			}
		}

		public unsafe int transformParentID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformParentID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformParentID)) = num;
			}
		}

		public unsafe string subObjectName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjectName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjectName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Vector3 worldPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPos)) = vector;
			}
		}

		public unsafe Vector3 worldEuler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldEuler);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldEuler)) = vector;
			}
		}

		public unsafe Vector3 size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = vector;
			}
		}

		public unsafe DecalMaterialType materialType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialType);
				return *(DecalMaterialType*)num;
			}
			set
			{
				*(DecalMaterialType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialType)) = decalMaterialType;
			}
		}

		public unsafe DecalProjector spawnedProjector
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedProjector);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedProjector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalProjector));
			}
		}

		public unsafe Interactable i
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		public unsafe SpatterSimulation sim
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sim);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpatterSimulation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sim)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterSimulation));
			}
		}

		public unsafe static int INITIAL_POOL_SIZE
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INITIAL_POOL_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INITIAL_POOL_SIZE, (void*)(&num));
			}
		}

		public unsafe static float RECYCLED_Y_POSITION
		{
			get
			{
				Unsafe.SkipInit(out float result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RECYCLED_Y_POSITION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RECYCLED_Y_POSITION, (void*)(&num));
			}
		}

		public unsafe static Queue<DecalProjector> decalPool
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_decalPool, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<DecalProjector>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_decalPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
			}
		}

		static DecalSpawnData()
		{
			Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "DecalSpawnData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr);
			NativeFieldInfoPtr_parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "parentID");
			NativeFieldInfoPtr_transformParentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "transformParentID");
			NativeFieldInfoPtr_subObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "subObjectName");
			NativeFieldInfoPtr_worldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "worldPos");
			NativeFieldInfoPtr_worldEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "worldEuler");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "size");
			NativeFieldInfoPtr_materialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "materialType");
			NativeFieldInfoPtr_spawnedProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "spawnedProjector");
			NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "i");
			NativeFieldInfoPtr_sim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "sim");
			NativeFieldInfoPtr_INITIAL_POOL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "INITIAL_POOL_SIZE");
			NativeFieldInfoPtr_RECYCLED_Y_POSITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "RECYCLED_Y_POSITION");
			NativeFieldInfoPtr_decalPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, "decalPool");
			NativeMethodInfoPtr_SpawnOnTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, 100670389);
			NativeMethodInfoPtr_InitialisePool_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, 100670390);
			NativeMethodInfoPtr_GetNewDecalProjector_Public_Static_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, 100670391);
			NativeMethodInfoPtr_RecycleDecalProjector_Public_Static_Void_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, 100670392);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr, 100670393);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242250, RefRangeEnd = 242252, XrefRangeStart = 242204, XrefRangeEnd = 242250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnOnTransform(Transform spawnTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnTransform);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnOnTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242280, RefRangeEnd = 242281, XrefRangeStart = 242252, XrefRangeEnd = 242280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitialisePool()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitialisePool_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242290, RefRangeEnd = 242292, XrefRangeStart = 242281, XrefRangeEnd = 242290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DecalProjector GetNewDecalProjector()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewDecalProjector_Public_Static_DecalProjector_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242307, RefRangeEnd = 242310, XrefRangeStart = 242292, XrefRangeEnd = 242307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecycleDecalProjector(DecalProjector decalProjector)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalProjector);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecycleDecalProjector_Public_Static_Void_DecalProjector_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe DecalSpawnData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalSpawnData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DecalSpawnData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum DecalMaterialType
	{
		light,
		medium,
		heavy
	}

	public enum ParentID
	{
		room,
		human,
		interactable,
		door
	}

	[ObfuscatedName("SpatterSimulation+<>c__DisplayClass25_0")]
	public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ds;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Interactable_0;

		public unsafe DecalSpawnData ds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecalSpawnData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalSpawnData));
			}
		}

		static __c__DisplayClass25_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "<>c__DisplayClass25_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr);
			NativeFieldInfoPtr_ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, "ds");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, 100670395);
			NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr, 100670396);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass25_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass25_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _Remove_b__0(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass25_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("SpatterSimulation+<>c__DisplayClass27_0")]
	public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ds;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSpawning_b__0_Internal_Boolean_Interactable_0;

		public unsafe DecalSpawnData ds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecalSpawnData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalSpawnData));
			}
		}

		static __c__DisplayClass27_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "<>c__DisplayClass27_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr);
			NativeFieldInfoPtr_ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, "ds");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100670397);
			NativeMethodInfoPtr__UpdateSpawning_b__0_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100670398);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass27_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _UpdateSpawning_b__0(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateSpawning_b__0_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass27_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_worldOrigin;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeCoord;

	private static readonly System.IntPtr NativeFieldInfoPtr_presetStr;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomID;

	private static readonly System.IntPtr NativeFieldInfoPtr_eraseMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_force;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatterCountMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_createdAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_isExecuted;

	private static readonly System.IntPtr NativeFieldInfoPtr_executedAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_eraseModeTimeStamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_stickToActors;

	private static readonly System.IntPtr NativeFieldInfoPtr_decalsSpawned;

	private static readonly System.IntPtr NativeFieldInfoPtr_room;

	private static readonly System.IntPtr NativeFieldInfoPtr_preset;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedProjectorsCount;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Human_Vector3_Vector3_SpatterPatternPreset_EraseMode_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_SpatterPatternPreset_EraseMode_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromSerializedData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpawning_Public_Void_0;

	public unsafe Vector3 worldOrigin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldOrigin);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldOrigin)) = vector;
		}
	}

	public unsafe Vector3 worldTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTarget);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTarget)) = vector;
		}
	}

	public unsafe Vector3Int nodeCoord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeCoord);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeCoord)) = vector3Int;
		}
	}

	public unsafe string presetStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetStr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetStr)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int roomID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomID)) = num;
		}
	}

	public unsafe EraseMode eraseMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eraseMode);
			return *(EraseMode*)num;
		}
		set
		{
			*(EraseMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eraseMode)) = eraseMode;
		}
	}

	public unsafe ForceType force
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force);
			return *(ForceType*)num;
		}
		set
		{
			*(ForceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_force)) = forceType;
		}
	}

	public unsafe float spatterCountMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCountMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCountMultiplier)) = num;
		}
	}

	public unsafe float createdAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdAt)) = num;
		}
	}

	public unsafe bool isExecuted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isExecuted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isExecuted)) = flag;
		}
	}

	public unsafe float executedAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executedAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executedAt)) = num;
		}
	}

	public unsafe float eraseModeTimeStamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eraseModeTimeStamp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eraseModeTimeStamp)) = num;
		}
	}

	public unsafe bool stickToActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickToActors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickToActors)) = flag;
		}
	}

	public unsafe List<DecalSpawnData> decalsSpawned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalsSpawned);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DecalSpawnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalsSpawned)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe NewRoom room
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe SpatterPatternPreset preset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpatterPatternPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterPatternPreset));
		}
	}

	public unsafe static int spawnedProjectorsCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_spawnedProjectorsCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_spawnedProjectorsCount, (void*)(&num));
		}
	}

	static SpatterSimulation()
	{
		Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpatterSimulation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr);
		NativeFieldInfoPtr_worldOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "worldOrigin");
		NativeFieldInfoPtr_worldTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "worldTarget");
		NativeFieldInfoPtr_nodeCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "nodeCoord");
		NativeFieldInfoPtr_presetStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "presetStr");
		NativeFieldInfoPtr_roomID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "roomID");
		NativeFieldInfoPtr_eraseMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "eraseMode");
		NativeFieldInfoPtr_force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "force");
		NativeFieldInfoPtr_spatterCountMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "spatterCountMultiplier");
		NativeFieldInfoPtr_createdAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "createdAt");
		NativeFieldInfoPtr_isExecuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "isExecuted");
		NativeFieldInfoPtr_executedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "executedAt");
		NativeFieldInfoPtr_eraseModeTimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "eraseModeTimeStamp");
		NativeFieldInfoPtr_stickToActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "stickToActors");
		NativeFieldInfoPtr_decalsSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "decalsSpawned");
		NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "room");
		NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "preset");
		NativeFieldInfoPtr_spawnedProjectorsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, "spawnedProjectorsCount");
		NativeMethodInfoPtr__ctor_Public_Void_Human_Vector3_Vector3_SpatterPatternPreset_EraseMode_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, 100670383);
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_SpatterPatternPreset_EraseMode_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, 100670384);
		NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, 100670385);
		NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, 100670386);
		NativeMethodInfoPtr_LoadFromSerializedData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, 100670387);
		NativeMethodInfoPtr_UpdateSpawning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr, 100670388);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 242343, RefRangeEnd = 242348, XrefRangeStart = 242310, XrefRangeEnd = 242343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpatterSimulation(Human newHuman, Vector3 newLocalPosition, Vector3 newDirection, SpatterPatternPreset spatter, EraseMode newEraseMode, float newSpatterCountMultiplier = 1f, bool newStickToActors = true)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHuman);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLocalPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newDirection;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatter);
		*(EraseMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newEraseMode;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSpatterCountMultiplier;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &newStickToActors;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Human_Vector3_Vector3_SpatterPatternPreset_EraseMode_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242374, RefRangeEnd = 242375, XrefRangeStart = 242348, XrefRangeEnd = 242374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpatterSimulation(Vector3 newWorldPosition, Vector3 newWorldTarget, SpatterPatternPreset spatter, EraseMode newEraseMode, float newSpatterCountMultiplier = 1f, bool newStickToActors = true)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpatterSimulation>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&newWorldPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newWorldTarget;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatter);
		*(EraseMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newEraseMode;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSpatterCountMultiplier;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newStickToActors;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_SpatterPatternPreset_EraseMode_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 242565, RefRangeEnd = 242569, XrefRangeStart = 242375, XrefRangeEnd = 242565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242628, RefRangeEnd = 242629, XrefRangeStart = 242569, XrefRangeEnd = 242628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242641, RefRangeEnd = 242642, XrefRangeStart = 242629, XrefRangeEnd = 242641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFromSerializedData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromSerializedData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 242858, RefRangeEnd = 242861, XrefRangeStart = 242642, XrefRangeEnd = 242858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpawning()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpawning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SpatterSimulation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
