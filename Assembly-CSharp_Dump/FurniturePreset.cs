using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class FurniturePreset : SoCustomComparison
{
	public enum SubObjectOwnership
	{
		nobody,
		everybody,
		person0,
		person1,
		person2,
		person3,
		person4,
		person5,
		person6,
		person7,
		person8,
		person9,
		person10,
		person11,
		person12,
		person13,
		person14,
		person15,
		person16,
		person17,
		person18,
		person19,
		person20,
		person21,
		person22,
		person23,
		person24,
		person25,
		person26,
		person27,
		person28,
		person29
	}

	[System.Serializable]
	public class SubObject : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_parent;

		private static readonly System.IntPtr NativeFieldInfoPtr_localPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_localRot;

		private static readonly System.IntPtr NativeFieldInfoPtr_belongsTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_security;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SubObjectClassPreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
			}
		}

		public unsafe string parent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parent)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Vector3 localPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPos)) = vector;
			}
		}

		public unsafe Vector3 localRot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRot);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRot)) = vector;
			}
		}

		public unsafe SubObjectOwnership belongsTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo);
				return *(SubObjectOwnership*)num;
			}
			set
			{
				*(SubObjectOwnership*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo)) = subObjectOwnership;
			}
		}

		public unsafe int security
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security)) = num;
			}
		}

		static SubObject()
		{
			Il2CppClassPointerStore<SubObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "SubObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubObject>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "parent");
			NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "localPos");
			NativeFieldInfoPtr_localRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "localRot");
			NativeFieldInfoPtr_belongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "belongsTo");
			NativeFieldInfoPtr_security = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "security");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubObject>.NativeClassPtr, 100673926);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubObject>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SubObject(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class IntegratedInteractable : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_pairToController;

		private static readonly System.IntPtr NativeFieldInfoPtr_belongsTo;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractablePreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe InteractableController.InteractableID pairToController
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairToController);
				return *(InteractableController.InteractableID*)num;
			}
			set
			{
				*(InteractableController.InteractableID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairToController)) = interactableID;
			}
		}

		public unsafe SubObjectOwnership belongsTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo);
				return *(SubObjectOwnership*)num;
			}
			set
			{
				*(SubObjectOwnership*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo)) = subObjectOwnership;
			}
		}

		static IntegratedInteractable()
		{
			Il2CppClassPointerStore<IntegratedInteractable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "IntegratedInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedInteractable>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedInteractable>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_pairToController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedInteractable>.NativeClassPtr, "pairToController");
			NativeFieldInfoPtr_belongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedInteractable>.NativeClassPtr, "belongsTo");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedInteractable>.NativeClassPtr, 100673927);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegratedInteractable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedInteractable>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IntegratedInteractable(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ShareColours
	{
		none,
		seating,
		wallFrontage,
		cabinets,
		cubicles,
		curtains,
		telephone,
		wood,
		doors,
		shelving,
		bins,
		blinds
	}

	public enum FurnitureGroup
	{
		none,
		seating,
		windowDecor
	}

	public enum ModifierTest
	{
		none,
		testOwner,
		testInhbitants
	}

	public enum DecorClass
	{
		chairs,
		tables,
		units,
		electronics,
		structural,
		decoration,
		misc
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_classes;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowStaticBatching;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowWeatherAffectedMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_integratedInteractables;

	private static readonly System.IntPtr NativeFieldInfoPtr_universalDesignStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_designStyles;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritColouringFromDecor;

	private static readonly System.IntPtr NativeFieldInfoPtr_shareColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritGrubFromDecor;

	private static readonly System.IntPtr NativeFieldInfoPtr_variations;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_groupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_concrete;

	private static readonly System.IntPtr NativeFieldInfoPtr_plaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_wood;

	private static readonly System.IntPtr NativeFieldInfoPtr_carpet;

	private static readonly System.IntPtr NativeFieldInfoPtr_tile;

	private static readonly System.IntPtr NativeFieldInfoPtr_metal;

	private static readonly System.IntPtr NativeFieldInfoPtr_glass;

	private static readonly System.IntPtr NativeFieldInfoPtr_fabric;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumRoomSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInOpenPlan;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyAllowInFollowing;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInAddressesOfType;

	private static readonly System.IntPtr NativeFieldInfoPtr_banInFollowing;

	private static readonly System.IntPtr NativeFieldInfoPtr_bannedInAddressesOfType;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnlyAllowInBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_banFromBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_notAllowedInBuildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnlyAllowInDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_banFromDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_notAllowedInDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresGenderedInhabitants;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableIfGenderPresent;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedRoomFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_subObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_testForModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcePublicIllegal;

	private static readonly System.IntPtr NativeFieldInfoPtr_hidingEnterTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_hidingExitTransition;

	private static readonly System.IntPtr NativeFieldInfoPtr_hidingEnterTransition2;

	private static readonly System.IntPtr NativeFieldInfoPtr_hidingExitTransition2;

	private static readonly System.IntPtr NativeFieldInfoPtr_map;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawUnderWalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoreDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_printsSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_alterAreaLighting;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightOperation;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_brightnessModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_purchasable;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableFromDecorMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_cost;

	private static readonly System.IntPtr NativeFieldInfoPtr_decorClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_imagePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_imagePrefabOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_isJobBoard;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWorkPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPlant;

	private static readonly System.IntPtr NativeFieldInfoPtr_isArt;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSecurityCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_onLoadAdjacentPlayerTeleport;

	private static readonly System.IntPtr NativeFieldInfoPtr_artOrientation;

	private static readonly System.IntPtr NativeFieldInfoPtr_createSelfEmployed;

	private static readonly System.IntPtr NativeFieldInfoPtr_workPositionID;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnObjectOnChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnObjectsOnPlacement;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<FurnitureClass> classes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClass>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_classes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject prefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool allowStaticBatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStaticBatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowStaticBatching)) = flag;
		}
	}

	public unsafe ObjectPoolingController.ObjectLoadRange spawnRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRange);
			return *(ObjectPoolingController.ObjectLoadRange*)num;
		}
		set
		{
			*(ObjectPoolingController.ObjectLoadRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnRange)) = objectLoadRange;
		}
	}

	public unsafe bool allowWeatherAffectedMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWeatherAffectedMaterials);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowWeatherAffectedMaterials)) = flag;
		}
	}

	public unsafe List<IntegratedInteractable> integratedInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integratedInteractables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntegratedInteractable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integratedInteractables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool universalDesignStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_universalDesignStyle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_universalDesignStyle)) = flag;
		}
	}

	public unsafe List<DesignStylePreset> designStyles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DesignStylePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool inheritColouringFromDecor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritColouringFromDecor)) = flag;
		}
	}

	public unsafe ShareColours shareColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColours);
			return *(ShareColours*)num;
		}
		set
		{
			*(ShareColours*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColours)) = shareColours;
		}
	}

	public unsafe bool inheritGrubFromDecor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritGrubFromDecor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inheritGrubFromDecor)) = flag;
		}
	}

	public unsafe List<MaterialGroupPreset.MaterialVariation> variations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialGroupPreset.MaterialVariation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe FurnitureGroup furnitureGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureGroup);
			return *(FurnitureGroup*)num;
		}
		set
		{
			*(FurnitureGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureGroup)) = furnitureGroup;
		}
	}

	public unsafe int groupID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupID)) = num;
		}
	}

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

	public unsafe int minimumRoomSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRoomSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRoomSize)) = num;
		}
	}

	public unsafe FurnitureCluster.AllowedOpenPlan allowedInOpenPlan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInOpenPlan);
			return *(FurnitureCluster.AllowedOpenPlan*)num;
		}
		set
		{
			*(FurnitureCluster.AllowedOpenPlan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInOpenPlan)) = allowedOpenPlan;
		}
	}

	public unsafe bool onlyAllowInFollowing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowInFollowing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAllowInFollowing)) = flag;
		}
	}

	public unsafe List<AddressPreset> allowedInAddressesOfType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInAddressesOfType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInAddressesOfType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool banInFollowing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banInFollowing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banInFollowing)) = flag;
		}
	}

	public unsafe List<AddressPreset> bannedInAddressesOfType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedInAddressesOfType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedInAddressesOfType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool OnlyAllowInBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnlyAllowInBuildings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnlyAllowInBuildings)) = flag;
		}
	}

	public unsafe List<BuildingPreset> allowedInBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInBuildings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool banFromBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromBuildings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromBuildings)) = flag;
		}
	}

	public unsafe List<BuildingPreset> notAllowedInBuildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAllowedInBuildings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAllowedInBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool OnlyAllowInDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnlyAllowInDistricts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnlyAllowInDistricts)) = flag;
		}
	}

	public unsafe List<DistrictPreset> allowedInDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInDistricts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInDistricts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool banFromDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromDistricts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_banFromDistricts)) = flag;
		}
	}

	public unsafe List<DistrictPreset> notAllowedInDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAllowedInDistricts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAllowedInDistricts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool requiresGenderedInhabitants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresGenderedInhabitants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresGenderedInhabitants)) = flag;
		}
	}

	public unsafe List<Human.Gender> enableIfGenderPresent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableIfGenderPresent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.Gender>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableIfGenderPresent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RoomTypeFilter> allowedRoomFilters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedRoomFilters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypeFilter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedRoomFilters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float minimumWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth)) = num;
		}
	}

	public unsafe List<SubObject> subObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ModifierTest testForModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testForModifiers);
			return *(ModifierTest*)num;
		}
		set
		{
			*(ModifierTest*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testForModifiers)) = modifierTest;
		}
	}

	public unsafe bool forcePublicIllegal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePublicIllegal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcePublicIllegal)) = flag;
		}
	}

	public unsafe PlayerTransitionPreset hidingEnterTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingEnterTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingEnterTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset hidingExitTransition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingExitTransition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingExitTransition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset hidingEnterTransition2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingEnterTransition2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingEnterTransition2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe PlayerTransitionPreset hidingExitTransition2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingExitTransition2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTransitionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hidingExitTransition2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerTransitionPreset));
		}
	}

	public unsafe Texture2D map
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_map);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_map)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe bool drawUnderWalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawUnderWalls);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawUnderWalls)) = flag;
		}
	}

	public unsafe bool ignoreDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreDirection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreDirection)) = flag;
		}
	}

	public unsafe bool fingerprintsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintsEnabled)) = flag;
		}
	}

	public unsafe RoomConfiguration.PrintsSource printsSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource);
			return *(RoomConfiguration.PrintsSource*)num;
		}
		set
		{
			*(RoomConfiguration.PrintsSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printsSource)) = printsSource;
		}
	}

	public unsafe float fingerprintDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintDensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintDensity)) = num;
		}
	}

	public unsafe bool alterAreaLighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alterAreaLighting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alterAreaLighting)) = flag;
		}
	}

	public unsafe List<Color> possibleColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe DistrictPreset.AffectStreetAreaLights lightOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOperation);
			return *(DistrictPreset.AffectStreetAreaLights*)num;
		}
		set
		{
			*(DistrictPreset.AffectStreetAreaLights*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOperation)) = affectStreetAreaLights;
		}
	}

	public unsafe float lightAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightAmount)) = num;
		}
	}

	public unsafe float brightnessModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightnessModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightnessModifier)) = num;
		}
	}

	public unsafe bool purchasable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchasable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purchasable)) = flag;
		}
	}

	public unsafe bool disableFromDecorMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableFromDecorMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableFromDecorMenu)) = flag;
		}
	}

	public unsafe int cost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cost)) = num;
		}
	}

	public unsafe DecorClass decorClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorClass);
			return *(DecorClass*)num;
		}
		set
		{
			*(DecorClass*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorClass)) = decorClass;
		}
	}

	public unsafe Sprite staticImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Vector3 imagePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePos)) = vector;
		}
	}

	public unsafe Vector3 imageRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageRot)) = vector;
		}
	}

	public unsafe float imageScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageScale)) = num;
		}
	}

	public unsafe GameObject imagePrefabOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePrefabOverride);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imagePrefabOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool isJobBoard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJobBoard);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJobBoard)) = flag;
		}
	}

	public unsafe bool isWorkPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWorkPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWorkPosition)) = flag;
		}
	}

	public unsafe bool isPlant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlant)) = flag;
		}
	}

	public unsafe bool isArt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isArt);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isArt)) = flag;
		}
	}

	public unsafe bool isSecurityCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSecurityCamera);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSecurityCamera)) = flag;
		}
	}

	public unsafe bool onLoadAdjacentPlayerTeleport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onLoadAdjacentPlayerTeleport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onLoadAdjacentPlayerTeleport)) = flag;
		}
	}

	public unsafe ArtPreset.ArtOrientation artOrientation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artOrientation);
			return *(ArtPreset.ArtOrientation*)num;
		}
		set
		{
			*(ArtPreset.ArtOrientation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artOrientation)) = artOrientation;
		}
	}

	public unsafe CompanyPreset createSelfEmployed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createSelfEmployed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompanyPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createSelfEmployed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)companyPreset));
		}
	}

	public unsafe InteractableController.InteractableID workPositionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workPositionID);
			return *(InteractableController.InteractableID*)num;
		}
		set
		{
			*(InteractableController.InteractableID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workPositionID)) = interactableID;
		}
	}

	public unsafe float spawnObjectOnChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnObjectOnChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnObjectOnChance)) = num;
		}
	}

	public unsafe List<InteractablePreset> spawnObjectsOnPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnObjectsOnPlacement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnObjectsOnPlacement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static FurniturePreset()
	{
		Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FurniturePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr);
		NativeFieldInfoPtr_classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "classes");
		NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "prefab");
		NativeFieldInfoPtr_allowStaticBatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "allowStaticBatching");
		NativeFieldInfoPtr_spawnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "spawnRange");
		NativeFieldInfoPtr_allowWeatherAffectedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "allowWeatherAffectedMaterials");
		NativeFieldInfoPtr_integratedInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "integratedInteractables");
		NativeFieldInfoPtr_universalDesignStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "universalDesignStyle");
		NativeFieldInfoPtr_designStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "designStyles");
		NativeFieldInfoPtr_inheritColouringFromDecor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "inheritColouringFromDecor");
		NativeFieldInfoPtr_shareColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "shareColours");
		NativeFieldInfoPtr_inheritGrubFromDecor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "inheritGrubFromDecor");
		NativeFieldInfoPtr_variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "variations");
		NativeFieldInfoPtr_furnitureGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "furnitureGroup");
		NativeFieldInfoPtr_groupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "groupID");
		NativeFieldInfoPtr_concrete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "concrete");
		NativeFieldInfoPtr_plaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "plaster");
		NativeFieldInfoPtr_wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "wood");
		NativeFieldInfoPtr_carpet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "carpet");
		NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "tile");
		NativeFieldInfoPtr_metal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "metal");
		NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "glass");
		NativeFieldInfoPtr_fabric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "fabric");
		NativeFieldInfoPtr_minimumRoomSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "minimumRoomSize");
		NativeFieldInfoPtr_allowedInOpenPlan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "allowedInOpenPlan");
		NativeFieldInfoPtr_onlyAllowInFollowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "onlyAllowInFollowing");
		NativeFieldInfoPtr_allowedInAddressesOfType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "allowedInAddressesOfType");
		NativeFieldInfoPtr_banInFollowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "banInFollowing");
		NativeFieldInfoPtr_bannedInAddressesOfType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "bannedInAddressesOfType");
		NativeFieldInfoPtr_OnlyAllowInBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "OnlyAllowInBuildings");
		NativeFieldInfoPtr_allowedInBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "allowedInBuildings");
		NativeFieldInfoPtr_banFromBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "banFromBuildings");
		NativeFieldInfoPtr_notAllowedInBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "notAllowedInBuildings");
		NativeFieldInfoPtr_OnlyAllowInDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "OnlyAllowInDistricts");
		NativeFieldInfoPtr_allowedInDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "allowedInDistricts");
		NativeFieldInfoPtr_banFromDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "banFromDistricts");
		NativeFieldInfoPtr_notAllowedInDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "notAllowedInDistricts");
		NativeFieldInfoPtr_requiresGenderedInhabitants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "requiresGenderedInhabitants");
		NativeFieldInfoPtr_enableIfGenderPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "enableIfGenderPresent");
		NativeFieldInfoPtr_allowedRoomFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "allowedRoomFilters");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_subObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "subObjects");
		NativeFieldInfoPtr_testForModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "testForModifiers");
		NativeFieldInfoPtr_forcePublicIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "forcePublicIllegal");
		NativeFieldInfoPtr_hidingEnterTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "hidingEnterTransition");
		NativeFieldInfoPtr_hidingExitTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "hidingExitTransition");
		NativeFieldInfoPtr_hidingEnterTransition2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "hidingEnterTransition2");
		NativeFieldInfoPtr_hidingExitTransition2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "hidingExitTransition2");
		NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "map");
		NativeFieldInfoPtr_drawUnderWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "drawUnderWalls");
		NativeFieldInfoPtr_ignoreDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "ignoreDirection");
		NativeFieldInfoPtr_fingerprintsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "fingerprintsEnabled");
		NativeFieldInfoPtr_printsSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "printsSource");
		NativeFieldInfoPtr_fingerprintDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "fingerprintDensity");
		NativeFieldInfoPtr_alterAreaLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "alterAreaLighting");
		NativeFieldInfoPtr_possibleColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "possibleColours");
		NativeFieldInfoPtr_lightOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "lightOperation");
		NativeFieldInfoPtr_lightAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "lightAmount");
		NativeFieldInfoPtr_brightnessModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "brightnessModifier");
		NativeFieldInfoPtr_purchasable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "purchasable");
		NativeFieldInfoPtr_disableFromDecorMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "disableFromDecorMenu");
		NativeFieldInfoPtr_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "cost");
		NativeFieldInfoPtr_decorClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "decorClass");
		NativeFieldInfoPtr_staticImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "staticImage");
		NativeFieldInfoPtr_imagePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "imagePos");
		NativeFieldInfoPtr_imageRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "imageRot");
		NativeFieldInfoPtr_imageScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "imageScale");
		NativeFieldInfoPtr_imagePrefabOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "imagePrefabOverride");
		NativeFieldInfoPtr_isJobBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "isJobBoard");
		NativeFieldInfoPtr_isWorkPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "isWorkPosition");
		NativeFieldInfoPtr_isPlant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "isPlant");
		NativeFieldInfoPtr_isArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "isArt");
		NativeFieldInfoPtr_isSecurityCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "isSecurityCamera");
		NativeFieldInfoPtr_onLoadAdjacentPlayerTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "onLoadAdjacentPlayerTeleport");
		NativeFieldInfoPtr_artOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "artOrientation");
		NativeFieldInfoPtr_createSelfEmployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "createSelfEmployed");
		NativeFieldInfoPtr_workPositionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "workPositionID");
		NativeFieldInfoPtr_spawnObjectOnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "spawnObjectOnChance");
		NativeFieldInfoPtr_spawnObjectsOnPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, "spawnObjectsOnPlacement");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr, 100673925);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328798, XrefRangeEnd = 328883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FurniturePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurniturePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FurniturePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
