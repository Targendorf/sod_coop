using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MaterialGroupPreset : SoCustomComparison
{
	[System.Serializable]
	public class MaterialSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_designStyle;

		private static readonly System.IntPtr NativeFieldInfoPtr_weighting;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe DesignStylePreset designStyle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DesignStylePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)designStylePreset));
			}
		}

		public unsafe int weighting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weighting);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weighting)) = num;
			}
		}

		static MaterialSettings()
		{
			Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "MaterialSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr);
			NativeFieldInfoPtr_designStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, "designStyle");
			NativeFieldInfoPtr_weighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, "weighting");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr, 100673978);
		}

		[CallerCount(0)]
		public unsafe MaterialSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaterialSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum MaterialType
	{
		walls,
		floor,
		ceiling,
		other
	}

	public enum MaterialColour
	{
		anyPrimary,
		anySecondary,
		anyPrimaryOrNeutral,
		anySecondaryOrNeutral,
		any1,
		any2,
		any1OrNeutral,
		any2OrNeutral,
		any,
		primary1,
		primary2,
		secondary1,
		secondary2,
		neutral,
		wood,
		none,
		anyPrimaryOrSecondary
	}

	[System.Serializable]
	public class MaterialVariation : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_main;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour1;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour2;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour3;

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

		public unsafe MaterialColour main
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_main);
				return *(MaterialColour*)num;
			}
			set
			{
				*(MaterialColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_main)) = materialColour;
			}
		}

		public unsafe MaterialColour colour1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1);
				return *(MaterialColour*)num;
			}
			set
			{
				*(MaterialColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour1)) = materialColour;
			}
		}

		public unsafe MaterialColour colour2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2);
				return *(MaterialColour*)num;
			}
			set
			{
				*(MaterialColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour2)) = materialColour;
			}
		}

		public unsafe MaterialColour colour3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3);
				return *(MaterialColour*)num;
			}
			set
			{
				*(MaterialColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour3)) = materialColour;
			}
		}

		static MaterialVariation()
		{
			Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "MaterialVariation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr, "name");
			NativeFieldInfoPtr_main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr, "main");
			NativeFieldInfoPtr_colour1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr, "colour1");
			NativeFieldInfoPtr_colour2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr, "colour2");
			NativeFieldInfoPtr_colour3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr, "colour3");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr, 100673979);
		}

		[CallerCount(0)]
		public unsafe MaterialVariation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialVariation>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MaterialVariation(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_material;

	private static readonly System.IntPtr NativeFieldInfoPtr_variations;

	private static readonly System.IntPtr NativeFieldInfoPtr_concrete;

	private static readonly System.IntPtr NativeFieldInfoPtr_plaster;

	private static readonly System.IntPtr NativeFieldInfoPtr_wood;

	private static readonly System.IntPtr NativeFieldInfoPtr_carpet;

	private static readonly System.IntPtr NativeFieldInfoPtr_tile;

	private static readonly System.IntPtr NativeFieldInfoPtr_metal;

	private static readonly System.IntPtr NativeFieldInfoPtr_glass;

	private static readonly System.IntPtr NativeFieldInfoPtr_fabric;

	private static readonly System.IntPtr NativeFieldInfoPtr_noFloorReplacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowFootprints;

	private static readonly System.IntPtr NativeFieldInfoPtr_affectFootprintDirt;

	private static readonly System.IntPtr NativeFieldInfoPtr_grubFootprintDirtMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialType;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_designStyles;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedRoomFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_purchasable;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_decorSprite;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Material material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe List<MaterialVariation> variations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialVariation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe MaterialGroupPreset noFloorReplacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noFloorReplacement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noFloorReplacement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe bool allowFootprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowFootprints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowFootprints)) = flag;
		}
	}

	public unsafe float affectFootprintDirt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectFootprintDirt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectFootprintDirt)) = num;
		}
	}

	public unsafe float grubFootprintDirtMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grubFootprintDirtMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grubFootprintDirtMultiplier)) = num;
		}
	}

	public unsafe MaterialType materialType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialType);
			return *(MaterialType*)num;
		}
		set
		{
			*(MaterialType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialType)) = materialType;
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

	public unsafe List<MaterialSettings> designStyles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialSettings>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe int price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
		}
	}

	public unsafe Sprite decorSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	static MaterialGroupPreset()
	{
		Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MaterialGroupPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr);
		NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "material");
		NativeFieldInfoPtr_variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "variations");
		NativeFieldInfoPtr_concrete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "concrete");
		NativeFieldInfoPtr_plaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "plaster");
		NativeFieldInfoPtr_wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "wood");
		NativeFieldInfoPtr_carpet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "carpet");
		NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "tile");
		NativeFieldInfoPtr_metal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "metal");
		NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "glass");
		NativeFieldInfoPtr_fabric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "fabric");
		NativeFieldInfoPtr_noFloorReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "noFloorReplacement");
		NativeFieldInfoPtr_allowFootprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "allowFootprints");
		NativeFieldInfoPtr_affectFootprintDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "affectFootprintDirt");
		NativeFieldInfoPtr_grubFootprintDirtMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "grubFootprintDirtMultiplier");
		NativeFieldInfoPtr_materialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "materialType");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_designStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "designStyles");
		NativeFieldInfoPtr_allowedRoomFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "allowedRoomFilters");
		NativeFieldInfoPtr_purchasable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "purchasable");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "price");
		NativeFieldInfoPtr_decorSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, "decorSprite");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr, 100673977);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329359, XrefRangeEnd = 329379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialGroupPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialGroupPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MaterialGroupPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
