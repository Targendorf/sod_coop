using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CitySaveData : Il2CppSystem.Object
{
	[System.Serializable]
	public class DistrictCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_districtID;

		private static readonly System.IntPtr NativeFieldInfoPtr_blocks;

		private static readonly System.IntPtr NativeFieldInfoPtr_averageLandValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_dominantEthnicities;

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

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int districtID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtID)) = num;
			}
		}

		public unsafe List<BlockCitySave> blocks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BlockCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float averageLandValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageLandValue);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageLandValue)) = num;
			}
		}

		public unsafe List<SocialStatistics.EthnicityFrequency> dominantEthnicities
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dominantEthnicities);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SocialStatistics.EthnicityFrequency>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dominantEthnicities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DistrictCitySave()
		{
			Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "DistrictCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_districtID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr, "districtID");
			NativeFieldInfoPtr_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr, "blocks");
			NativeFieldInfoPtr_averageLandValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr, "averageLandValue");
			NativeFieldInfoPtr_dominantEthnicities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr, "dominantEthnicities");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr, 100670317);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241153, XrefRangeEnd = 241165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DistrictCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistrictCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DistrictCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class BlockCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_blockID;

		private static readonly System.IntPtr NativeFieldInfoPtr_averageDensity;

		private static readonly System.IntPtr NativeFieldInfoPtr_averageLandValue;

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

		public unsafe int blockID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockID)) = num;
			}
		}

		public unsafe float averageDensity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageDensity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageDensity)) = num;
			}
		}

		public unsafe float averageLandValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageLandValue);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageLandValue)) = num;
			}
		}

		static BlockCitySave()
		{
			Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "BlockCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_blockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr, "blockID");
			NativeFieldInfoPtr_averageDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr, "averageDensity");
			NativeFieldInfoPtr_averageLandValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr, "averageLandValue");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr, 100670318);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BlockCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CityTileCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_blockID;

		private static readonly System.IntPtr NativeFieldInfoPtr_districtID;

		private static readonly System.IntPtr NativeFieldInfoPtr_cityCoord;

		private static readonly System.IntPtr NativeFieldInfoPtr_building;

		private static readonly System.IntPtr NativeFieldInfoPtr_outsideTiles;

		private static readonly System.IntPtr NativeFieldInfoPtr_density;

		private static readonly System.IntPtr NativeFieldInfoPtr_landValue;

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

		public unsafe int blockID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockID)) = num;
			}
		}

		public unsafe int districtID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtID)) = num;
			}
		}

		public unsafe Vector2Int cityCoord
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCoord);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCoord)) = vector2Int;
			}
		}

		public unsafe BuildingCitySave building
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuildingCitySave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildingCitySave));
			}
		}

		public unsafe List<TileCitySave> outsideTiles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideTiles);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TileCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe BuildingPreset.Density density
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_density);
				return *(BuildingPreset.Density*)num;
			}
			set
			{
				*(BuildingPreset.Density*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_density)) = density;
			}
		}

		public unsafe BuildingPreset.LandValue landValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValue);
				return *(BuildingPreset.LandValue*)num;
			}
			set
			{
				*(BuildingPreset.LandValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValue)) = landValue;
			}
		}

		static CityTileCitySave()
		{
			Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "CityTileCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_blockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "blockID");
			NativeFieldInfoPtr_districtID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "districtID");
			NativeFieldInfoPtr_cityCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "cityCoord");
			NativeFieldInfoPtr_building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "building");
			NativeFieldInfoPtr_outsideTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "outsideTiles");
			NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "density");
			NativeFieldInfoPtr_landValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, "landValue");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr, 100670319);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241165, XrefRangeEnd = 241171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CityTileCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CityTileCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CityTileCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class BuildingCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_buildingID;

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_floors;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_facing;

		private static readonly System.IntPtr NativeFieldInfoPtr_isInaccessible;

		private static readonly System.IntPtr NativeFieldInfoPtr_sideSigns;

		private static readonly System.IntPtr NativeFieldInfoPtr_airDucts;

		private static readonly System.IntPtr NativeFieldInfoPtr_designStyle;

		private static readonly System.IntPtr NativeFieldInfoPtr_wood;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorMatKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMatKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_defaultWallMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_defaultWallKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_extWallMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_extWallKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_colourScheme;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorMatOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMatOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_wallMatOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorMatOverrideB;

		private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMatOverrideB;

		private static readonly System.IntPtr NativeFieldInfoPtr_wallMatOverrideB;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int buildingID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingID)) = num;
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

		public unsafe List<FloorCitySave> floors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floors);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloorCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe NewBuilding.Direction facing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facing);
				return *(NewBuilding.Direction*)num;
			}
			set
			{
				*(NewBuilding.Direction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facing)) = direction;
			}
		}

		public unsafe bool isInaccessible
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInaccessible);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInaccessible)) = flag;
			}
		}

		public unsafe List<NewBuilding.SideSign> sideSigns
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideSigns);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewBuilding.SideSign>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideSigns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<AirDuctGroupCitySave> airDucts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDucts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AirDuctGroupCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDucts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe string designStyle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Color wood
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood)) = color;
			}
		}

		public unsafe string floorMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMaterial);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey floorMatKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string ceilingMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMaterial);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey ceilingMatKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string defaultWallMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterial);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey defaultWallKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string extWallMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallMaterial);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey extWallKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string colourScheme
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourScheme);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourScheme)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string floorMatOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatOverride);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string ceilingMatOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatOverride);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string wallMatOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMatOverride);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMatOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string floorMatOverrideB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatOverrideB);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatOverrideB)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string ceilingMatOverrideB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatOverrideB);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatOverrideB)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string wallMatOverrideB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMatOverrideB);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMatOverrideB)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static BuildingCitySave()
		{
			Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "BuildingCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_buildingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "buildingID");
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "floors");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_facing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "facing");
			NativeFieldInfoPtr_isInaccessible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "isInaccessible");
			NativeFieldInfoPtr_sideSigns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "sideSigns");
			NativeFieldInfoPtr_airDucts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "airDucts");
			NativeFieldInfoPtr_designStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "designStyle");
			NativeFieldInfoPtr_wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "wood");
			NativeFieldInfoPtr_floorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "floorMaterial");
			NativeFieldInfoPtr_floorMatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "floorMatKey");
			NativeFieldInfoPtr_ceilingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "ceilingMaterial");
			NativeFieldInfoPtr_ceilingMatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "ceilingMatKey");
			NativeFieldInfoPtr_defaultWallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "defaultWallMaterial");
			NativeFieldInfoPtr_defaultWallKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "defaultWallKey");
			NativeFieldInfoPtr_extWallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "extWallMaterial");
			NativeFieldInfoPtr_extWallKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "extWallKey");
			NativeFieldInfoPtr_colourScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "colourScheme");
			NativeFieldInfoPtr_floorMatOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "floorMatOverride");
			NativeFieldInfoPtr_ceilingMatOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "ceilingMatOverride");
			NativeFieldInfoPtr_wallMatOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "wallMatOverride");
			NativeFieldInfoPtr_floorMatOverrideB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "floorMatOverrideB");
			NativeFieldInfoPtr_ceilingMatOverrideB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "ceilingMatOverrideB");
			NativeFieldInfoPtr_wallMatOverrideB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, "wallMatOverrideB");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr, 100670320);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241171, XrefRangeEnd = 241183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildingCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BuildingCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AirDuctGroupCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_ext;

		private static readonly System.IntPtr NativeFieldInfoPtr_airVents;

		private static readonly System.IntPtr NativeFieldInfoPtr_airDucts;

		private static readonly System.IntPtr NativeFieldInfoPtr_ventRooms;

		private static readonly System.IntPtr NativeFieldInfoPtr_adjoining;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe bool ext
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ext);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ext)) = flag;
			}
		}

		public unsafe List<int> airVents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVents);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<AirDuctSegmentCitySave> airDucts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDucts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AirDuctSegmentCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDucts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> ventRooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ventRooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ventRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> adjoining
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjoining);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjoining)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static AirDuctGroupCitySave()
		{
			Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "AirDuctGroupCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_ext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr, "ext");
			NativeFieldInfoPtr_airVents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr, "airVents");
			NativeFieldInfoPtr_airDucts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr, "airDucts");
			NativeFieldInfoPtr_ventRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr, "ventRooms");
			NativeFieldInfoPtr_adjoining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr, "adjoining");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr, 100670321);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241200, RefRangeEnd = 241201, XrefRangeStart = 241183, XrefRangeEnd = 241200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirDuctGroupCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirDuctGroupCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AirDuctGroupCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AirDuctSegmentCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_level;

		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeFieldInfoPtr_duct;

		private static readonly System.IntPtr NativeFieldInfoPtr_previous;

		private static readonly System.IntPtr NativeFieldInfoPtr_next;

		private static readonly System.IntPtr NativeFieldInfoPtr_node;

		private static readonly System.IntPtr NativeFieldInfoPtr_peek;

		private static readonly System.IntPtr NativeFieldInfoPtr_addRot;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int level
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level)) = num;
			}
		}

		public unsafe int index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = num;
			}
		}

		public unsafe Vector3Int duct
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct)) = vector3Int;
			}
		}

		public unsafe Vector3Int previous
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previous);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previous)) = vector3Int;
			}
		}

		public unsafe Vector3Int next
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next)) = vector3Int;
			}
		}

		public unsafe Vector3Int node
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)) = vector3Int;
			}
		}

		public unsafe bool peek
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peek);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peek)) = flag;
			}
		}

		public unsafe Vector3Int addRot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addRot);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addRot)) = vector3Int;
			}
		}

		static AirDuctSegmentCitySave()
		{
			Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "AirDuctSegmentCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "level");
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "index");
			NativeFieldInfoPtr_duct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "duct");
			NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "previous");
			NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "next");
			NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "node");
			NativeFieldInfoPtr_peek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "peek");
			NativeFieldInfoPtr_addRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, "addRot");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr, 100670322);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirDuctSegmentCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirDuctSegmentCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AirDuctSegmentCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AirVentSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_ventType;

		private static readonly System.IntPtr NativeFieldInfoPtr_wall;

		private static readonly System.IntPtr NativeFieldInfoPtr_node;

		private static readonly System.IntPtr NativeFieldInfoPtr_rNode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe NewAddress.AirVent ventType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ventType);
				return *(NewAddress.AirVent*)num;
			}
			set
			{
				*(NewAddress.AirVent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ventType)) = airVent;
			}
		}

		public unsafe int wall
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wall);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wall)) = num;
			}
		}

		public unsafe Vector3Int node
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)) = vector3Int;
			}
		}

		public unsafe Vector3Int rNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rNode);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rNode)) = vector3Int;
			}
		}

		static AirVentSave()
		{
			Il2CppClassPointerStore<AirVentSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "AirVentSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_ventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr, "ventType");
			NativeFieldInfoPtr_wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr, "wall");
			NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr, "node");
			NativeFieldInfoPtr_rNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr, "rNode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr, 100670323);
		}

		[CallerCount(0)]
		public unsafe AirVentSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirVentSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AirVentSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FloorCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorID;

		private static readonly System.IntPtr NativeFieldInfoPtr_floor;

		private static readonly System.IntPtr NativeFieldInfoPtr_addresses;

		private static readonly System.IntPtr NativeFieldInfoPtr_tiles;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_defaultFloorHeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_defaultCeilingHeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_layoutIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_echelons;

		private static readonly System.IntPtr NativeFieldInfoPtr_breakerSec;

		private static readonly System.IntPtr NativeFieldInfoPtr_breakerLights;

		private static readonly System.IntPtr NativeFieldInfoPtr_breakerDoors;

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

		public unsafe int floorID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorID)) = num;
			}
		}

		public unsafe int floor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floor);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floor)) = num;
			}
		}

		public unsafe List<AddressCitySave> addresses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addresses);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addresses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<TileCitySave> tiles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiles);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TileCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Vector2 size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = vector;
			}
		}

		public unsafe int defaultFloorHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFloorHeight);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFloorHeight)) = num;
			}
		}

		public unsafe int defaultCeilingHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCeilingHeight);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCeilingHeight)) = num;
			}
		}

		public unsafe int layoutIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutIndex)) = num;
			}
		}

		public unsafe bool echelons
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelons);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelons)) = flag;
			}
		}

		public unsafe int breakerSec
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerSec);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerSec)) = num;
			}
		}

		public unsafe int breakerLights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerLights);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerLights)) = num;
			}
		}

		public unsafe int breakerDoors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerDoors);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerDoors)) = num;
			}
		}

		static FloorCitySave()
		{
			Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "FloorCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_floorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "floorID");
			NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "floor");
			NativeFieldInfoPtr_addresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "addresses");
			NativeFieldInfoPtr_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "tiles");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "size");
			NativeFieldInfoPtr_defaultFloorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "defaultFloorHeight");
			NativeFieldInfoPtr_defaultCeilingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "defaultCeilingHeight");
			NativeFieldInfoPtr_layoutIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "layoutIndex");
			NativeFieldInfoPtr_echelons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "echelons");
			NativeFieldInfoPtr_breakerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "breakerSec");
			NativeFieldInfoPtr_breakerLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "breakerLights");
			NativeFieldInfoPtr_breakerDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, "breakerDoors");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr, 100670324);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241201, XrefRangeEnd = 241213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FloorCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class TileCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_tileID;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorCoord;

		private static readonly System.IntPtr NativeFieldInfoPtr_globalTileCoord;

		private static readonly System.IntPtr NativeFieldInfoPtr_isEdge;

		private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_isEntrance;

		private static readonly System.IntPtr NativeFieldInfoPtr_isMainEntrance;

		private static readonly System.IntPtr NativeFieldInfoPtr_isStairwell;

		private static readonly System.IntPtr NativeFieldInfoPtr_stairwellRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_isElevator;

		private static readonly System.IntPtr NativeFieldInfoPtr_elevatorRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_isTop;

		private static readonly System.IntPtr NativeFieldInfoPtr_isBottom;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int tileID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileID)) = num;
			}
		}

		public unsafe Vector2Int floorCoord
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorCoord);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorCoord)) = vector2Int;
			}
		}

		public unsafe Vector3Int globalTileCoord
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalTileCoord);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalTileCoord)) = vector3Int;
			}
		}

		public unsafe bool isEdge
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEdge);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEdge)) = flag;
			}
		}

		public unsafe int rotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = num;
			}
		}

		public unsafe bool isEntrance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEntrance);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEntrance)) = flag;
			}
		}

		public unsafe bool isMainEntrance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMainEntrance);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMainEntrance)) = flag;
			}
		}

		public unsafe bool isStairwell
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStairwell);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStairwell)) = flag;
			}
		}

		public unsafe int stairwellRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellRotation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellRotation)) = num;
			}
		}

		public unsafe bool isElevator
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isElevator);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isElevator)) = flag;
			}
		}

		public unsafe int elevatorRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorRotation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorRotation)) = num;
			}
		}

		public unsafe bool isTop
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTop);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTop)) = flag;
			}
		}

		public unsafe bool isBottom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBottom);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBottom)) = flag;
			}
		}

		static TileCitySave()
		{
			Il2CppClassPointerStore<TileCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "TileCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_tileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "tileID");
			NativeFieldInfoPtr_floorCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "floorCoord");
			NativeFieldInfoPtr_globalTileCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "globalTileCoord");
			NativeFieldInfoPtr_isEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "isEdge");
			NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "rotation");
			NativeFieldInfoPtr_isEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "isEntrance");
			NativeFieldInfoPtr_isMainEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "isMainEntrance");
			NativeFieldInfoPtr_isStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "isStairwell");
			NativeFieldInfoPtr_stairwellRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "stairwellRotation");
			NativeFieldInfoPtr_isElevator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "isElevator");
			NativeFieldInfoPtr_elevatorRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "elevatorRotation");
			NativeFieldInfoPtr_isTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "isTop");
			NativeFieldInfoPtr_isBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, "isBottom");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr, 100670325);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TileCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class StreetCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_access;

		private static readonly System.IntPtr NativeFieldInfoPtr_rooms;

		private static readonly System.IntPtr NativeFieldInfoPtr_designStyle;

		private static readonly System.IntPtr NativeFieldInfoPtr_streetID;

		private static readonly System.IntPtr NativeFieldInfoPtr_district;

		private static readonly System.IntPtr NativeFieldInfoPtr_tiles;

		private static readonly System.IntPtr NativeFieldInfoPtr_streetSuffix;

		private static readonly System.IntPtr NativeFieldInfoPtr_isAlley;

		private static readonly System.IntPtr NativeFieldInfoPtr_isBackstreet;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedGround;

		private static readonly System.IntPtr NativeFieldInfoPtr_streetTiles;

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

		public unsafe AddressPreset.AccessType access
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access);
				return *(AddressPreset.AccessType*)num;
			}
			set
			{
				*(AddressPreset.AccessType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access)) = accessType;
			}
		}

		public unsafe List<RoomCitySave> rooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe string designStyle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int streetID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetID)) = num;
			}
		}

		public unsafe int district
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_district);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_district)) = num;
			}
		}

		public unsafe List<Vector3Int> tiles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiles);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe string streetSuffix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetSuffix);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetSuffix)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool isAlley
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlley);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlley)) = flag;
			}
		}

		public unsafe bool isBackstreet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBackstreet);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBackstreet)) = flag;
			}
		}

		public unsafe List<int> sharedGround
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedGround);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedGround)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<StreetController.StreetTile> streetTiles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetTiles);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StreetController.StreetTile>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static StreetCitySave()
		{
			Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "StreetCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "access");
			NativeFieldInfoPtr_rooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "rooms");
			NativeFieldInfoPtr_designStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "designStyle");
			NativeFieldInfoPtr_streetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "streetID");
			NativeFieldInfoPtr_district = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "district");
			NativeFieldInfoPtr_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "tiles");
			NativeFieldInfoPtr_streetSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "streetSuffix");
			NativeFieldInfoPtr_isAlley = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "isAlley");
			NativeFieldInfoPtr_isBackstreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "isBackstreet");
			NativeFieldInfoPtr_sharedGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "sharedGround");
			NativeFieldInfoPtr_streetTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, "streetTiles");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr, 100670326);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241226, RefRangeEnd = 241227, XrefRangeStart = 241213, XrefRangeEnd = 241226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StreetCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AddressCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_residenceNumber;

		private static readonly System.IntPtr NativeFieldInfoPtr_isLobby;

		private static readonly System.IntPtr NativeFieldInfoPtr_isOutside;

		private static readonly System.IntPtr NativeFieldInfoPtr_access;

		private static readonly System.IntPtr NativeFieldInfoPtr_rooms;

		private static readonly System.IntPtr NativeFieldInfoPtr_designStyle;

		private static readonly System.IntPtr NativeFieldInfoPtr_neonHor;

		private static readonly System.IntPtr NativeFieldInfoPtr_neonVer;

		private static readonly System.IntPtr NativeFieldInfoPtr_neonVerticalIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_neonColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_neonFont;

		private static readonly System.IntPtr NativeFieldInfoPtr_landValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_passcode;

		private static readonly System.IntPtr NativeFieldInfoPtr_protectedNodes;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_address;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_wood;

		private static readonly System.IntPtr NativeFieldInfoPtr_residence;

		private static readonly System.IntPtr NativeFieldInfoPtr_company;

		private static readonly System.IntPtr NativeFieldInfoPtr_isOutsideAddress;

		private static readonly System.IntPtr NativeFieldInfoPtr_isLobbyAddress;

		private static readonly System.IntPtr NativeFieldInfoPtr_breakerSec;

		private static readonly System.IntPtr NativeFieldInfoPtr_breakerLights;

		private static readonly System.IntPtr NativeFieldInfoPtr_breakerDoors;

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

		public unsafe int residenceNumber
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residenceNumber);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residenceNumber)) = num;
			}
		}

		public unsafe bool isLobby
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLobby);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLobby)) = flag;
			}
		}

		public unsafe bool isOutside
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutside);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutside)) = flag;
			}
		}

		public unsafe AddressPreset.AccessType access
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access);
				return *(AddressPreset.AccessType*)num;
			}
			set
			{
				*(AddressPreset.AccessType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access)) = accessType;
			}
		}

		public unsafe List<RoomCitySave> rooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe string designStyle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_designStyle)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool neonHor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonHor);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonHor)) = flag;
			}
		}

		public unsafe bool neonVer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonVer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonVer)) = flag;
			}
		}

		public unsafe int neonVerticalIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonVerticalIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonVerticalIndex)) = num;
			}
		}

		public unsafe int neonColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonColour);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonColour)) = num;
			}
		}

		public unsafe string neonFont
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonFont);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonFont)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float landValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValue);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValue)) = num;
			}
		}

		public unsafe GameplayController.Passcode passcode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passcode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameplayController.Passcode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passcode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passcode));
			}
		}

		public unsafe List<Vector3> protectedNodes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protectedNodes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protectedNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe string address
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Color wood
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood)) = color;
			}
		}

		public unsafe ResidenceCitySave residence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResidenceCitySave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)residenceCitySave));
			}
		}

		public unsafe CompanyCitySave company
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_company);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompanyCitySave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_company)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)companyCitySave));
			}
		}

		public unsafe bool isOutsideAddress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutsideAddress);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutsideAddress)) = flag;
			}
		}

		public unsafe bool isLobbyAddress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLobbyAddress);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLobbyAddress)) = flag;
			}
		}

		public unsafe int breakerSec
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerSec);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerSec)) = num;
			}
		}

		public unsafe int breakerLights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerLights);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerLights)) = num;
			}
		}

		public unsafe int breakerDoors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerDoors);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakerDoors)) = num;
			}
		}

		static AddressCitySave()
		{
			Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "AddressCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_residenceNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "residenceNumber");
			NativeFieldInfoPtr_isLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "isLobby");
			NativeFieldInfoPtr_isOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "isOutside");
			NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "access");
			NativeFieldInfoPtr_rooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "rooms");
			NativeFieldInfoPtr_designStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "designStyle");
			NativeFieldInfoPtr_neonHor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "neonHor");
			NativeFieldInfoPtr_neonVer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "neonVer");
			NativeFieldInfoPtr_neonVerticalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "neonVerticalIndex");
			NativeFieldInfoPtr_neonColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "neonColour");
			NativeFieldInfoPtr_neonFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "neonFont");
			NativeFieldInfoPtr_landValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "landValue");
			NativeFieldInfoPtr_passcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "passcode");
			NativeFieldInfoPtr_protectedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "protectedNodes");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "address");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "wood");
			NativeFieldInfoPtr_residence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "residence");
			NativeFieldInfoPtr_company = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "company");
			NativeFieldInfoPtr_isOutsideAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "isOutsideAddress");
			NativeFieldInfoPtr_isLobbyAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "isLobbyAddress");
			NativeFieldInfoPtr_breakerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "breakerSec");
			NativeFieldInfoPtr_breakerLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "breakerLights");
			NativeFieldInfoPtr_breakerDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, "breakerDoors");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr, 100670327);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241227, XrefRangeEnd = 241238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddressCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AddressCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ResidenceCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_mail;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int mail
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mail);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mail)) = num;
			}
		}

		static ResidenceCitySave()
		{
			Il2CppClassPointerStore<ResidenceCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "ResidenceCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResidenceCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResidenceCitySave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_mail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResidenceCitySave>.NativeClassPtr, "mail");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResidenceCitySave>.NativeClassPtr, 100670328);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResidenceCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResidenceCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ResidenceCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CompanyCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_companyRoster;

		private static readonly System.IntPtr NativeFieldInfoPtr_shortName;

		private static readonly System.IntPtr NativeFieldInfoPtr_nameAltTags;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedWorkLocation;

		private static readonly System.IntPtr NativeFieldInfoPtr_menuItems;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemCosts;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe List<OccupationCitySave> companyRoster
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyRoster);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyRoster)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe string shortName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe List<string> nameAltTags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameAltTags);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameAltTags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int passedWorkLocation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedWorkLocation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedWorkLocation)) = num;
			}
		}

		public unsafe List<string> menuItems
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuItems);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> itemCosts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemCosts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemCosts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CompanyCitySave()
		{
			Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "CompanyCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_companyRoster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "companyRoster");
			NativeFieldInfoPtr_shortName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "shortName");
			NativeFieldInfoPtr_nameAltTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "nameAltTags");
			NativeFieldInfoPtr_passedWorkLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "passedWorkLocation");
			NativeFieldInfoPtr_menuItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "menuItems");
			NativeFieldInfoPtr_itemCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, "itemCosts");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr, 100670329);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241255, RefRangeEnd = 241256, XrefRangeStart = 241238, XrefRangeEnd = 241255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompanyCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompanyCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CompanyCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class OccupationCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_teamLeader;

		private static readonly System.IntPtr NativeFieldInfoPtr_boss;

		private static readonly System.IntPtr NativeFieldInfoPtr_paygrade;

		private static readonly System.IntPtr NativeFieldInfoPtr_teamID;

		private static readonly System.IntPtr NativeFieldInfoPtr_isOwner;

		private static readonly System.IntPtr NativeFieldInfoPtr_work;

		private static readonly System.IntPtr NativeFieldInfoPtr_tags;

		private static readonly System.IntPtr NativeFieldInfoPtr_shift;

		private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_endTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_workDaysList;

		private static readonly System.IntPtr NativeFieldInfoPtr_salary;

		private static readonly System.IntPtr NativeFieldInfoPtr_salaryString;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
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

		public unsafe bool teamLeader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamLeader);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamLeader)) = flag;
			}
		}

		public unsafe int boss
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boss);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boss)) = num;
			}
		}

		public unsafe float paygrade
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paygrade);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paygrade)) = num;
			}
		}

		public unsafe int teamID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teamID)) = num;
			}
		}

		public unsafe bool isOwner
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOwner);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOwner)) = flag;
			}
		}

		public unsafe OccupationPreset.workType work
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_work);
				return *(OccupationPreset.workType*)num;
			}
			set
			{
				*(OccupationPreset.workType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_work)) = workType;
			}
		}

		public unsafe List<OccupationPreset.workTags> tags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationPreset.workTags>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int shift
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shift);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shift)) = num;
			}
		}

		public unsafe float startTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime)) = num;
			}
		}

		public unsafe float endTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime)) = num;
			}
		}

		public unsafe List<SessionData.WeekDay> workDaysList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workDaysList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SessionData.WeekDay>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workDaysList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float salary
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salary);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salary)) = num;
			}
		}

		public unsafe string salaryString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salaryString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salaryString)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static OccupationCitySave()
		{
			Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "OccupationCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_teamLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "teamLeader");
			NativeFieldInfoPtr_boss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "boss");
			NativeFieldInfoPtr_paygrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "paygrade");
			NativeFieldInfoPtr_teamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "teamID");
			NativeFieldInfoPtr_isOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "isOwner");
			NativeFieldInfoPtr_work = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "work");
			NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "tags");
			NativeFieldInfoPtr_shift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "shift");
			NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "startTime");
			NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "endTime");
			NativeFieldInfoPtr_workDaysList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "workDaysList");
			NativeFieldInfoPtr_salary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "salary");
			NativeFieldInfoPtr_salaryString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, "salaryString");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr, 100670330);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241272, RefRangeEnd = 241273, XrefRangeStart = 241256, XrefRangeEnd = 241272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OccupationCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OccupationCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OccupationCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class RoomCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

		private static readonly System.IntPtr NativeFieldInfoPtr_openPlanElements;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightZones;

		private static readonly System.IntPtr NativeFieldInfoPtr_commonRooms;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorID;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_fID;

		private static readonly System.IntPtr NativeFieldInfoPtr_iID;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_reachableFromEntrance;

		private static readonly System.IntPtr NativeFieldInfoPtr_isOutsideWindow;

		private static readonly System.IntPtr NativeFieldInfoPtr_allowCoving;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorMatKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMatKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_defaultWallMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_defaultWallKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_miscKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_colourScheme;

		private static readonly System.IntPtr NativeFieldInfoPtr_mainLightPreset;

		private static readonly System.IntPtr NativeFieldInfoPtr_isBaseNullRoom;

		private static readonly System.IntPtr NativeFieldInfoPtr_middle;

		private static readonly System.IntPtr NativeFieldInfoPtr_f;

		private static readonly System.IntPtr NativeFieldInfoPtr_owners;

		private static readonly System.IntPtr NativeFieldInfoPtr_airVents;

		private static readonly System.IntPtr NativeFieldInfoPtr_password;

		private static readonly System.IntPtr NativeFieldInfoPtr_cf;

		private static readonly System.IntPtr NativeFieldInfoPtr_cullTree;

		private static readonly System.IntPtr NativeFieldInfoPtr_above;

		private static readonly System.IntPtr NativeFieldInfoPtr_below;

		private static readonly System.IntPtr NativeFieldInfoPtr_adj;

		private static readonly System.IntPtr NativeFieldInfoPtr_occ;

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

		public unsafe List<NodeCitySave> nodes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NodeCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<string> openPlanElements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openPlanElements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openPlanElements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<LightZoneSave> lightZones
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightZones);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightZoneSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightZones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> commonRooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonRooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int floorID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorID)) = num;
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe int fID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fID)) = num;
			}
		}

		public unsafe int iID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iID)) = num;
			}
		}

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool reachableFromEntrance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reachableFromEntrance);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reachableFromEntrance)) = flag;
			}
		}

		public unsafe bool isOutsideWindow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutsideWindow);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutsideWindow)) = flag;
			}
		}

		public unsafe bool allowCoving
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCoving);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCoving)) = flag;
			}
		}

		public unsafe string floorMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMaterial);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey floorMatKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMatKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string ceilingMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMaterial);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey ceilingMatKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMatKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string defaultWallMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterial);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterial)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey defaultWallKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe Toolbox.MaterialKey miscKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miscKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string colourScheme
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourScheme);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourScheme)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string mainLightPreset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightPreset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightPreset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool isBaseNullRoom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBaseNullRoom);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBaseNullRoom)) = flag;
			}
		}

		public unsafe Vector3 middle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middle);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middle)) = vector;
			}
		}

		public unsafe List<FurnitureClusterCitySave> f
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClusterCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> owners
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owners);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<AirVentSave> airVents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVents);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AirVentSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe GameplayController.Passcode password
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameplayController.Passcode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passcode));
			}
		}

		public unsafe int cf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cf);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cf)) = num;
			}
		}

		public unsafe List<CullTreeSave> cullTree
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullTree);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CullTreeSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullTree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> above
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_above);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_above)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> below
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_below);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_below)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> adj
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adj);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> occ
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occ);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occ)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static RoomCitySave()
		{
			Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "RoomCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "name");
			NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "nodes");
			NativeFieldInfoPtr_openPlanElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "openPlanElements");
			NativeFieldInfoPtr_lightZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "lightZones");
			NativeFieldInfoPtr_commonRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "commonRooms");
			NativeFieldInfoPtr_floorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "floorID");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_fID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "fID");
			NativeFieldInfoPtr_iID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "iID");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_reachableFromEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "reachableFromEntrance");
			NativeFieldInfoPtr_isOutsideWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "isOutsideWindow");
			NativeFieldInfoPtr_allowCoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "allowCoving");
			NativeFieldInfoPtr_floorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "floorMaterial");
			NativeFieldInfoPtr_floorMatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "floorMatKey");
			NativeFieldInfoPtr_ceilingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "ceilingMaterial");
			NativeFieldInfoPtr_ceilingMatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "ceilingMatKey");
			NativeFieldInfoPtr_defaultWallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "defaultWallMaterial");
			NativeFieldInfoPtr_defaultWallKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "defaultWallKey");
			NativeFieldInfoPtr_miscKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "miscKey");
			NativeFieldInfoPtr_colourScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "colourScheme");
			NativeFieldInfoPtr_mainLightPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "mainLightPreset");
			NativeFieldInfoPtr_isBaseNullRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "isBaseNullRoom");
			NativeFieldInfoPtr_middle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "middle");
			NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "f");
			NativeFieldInfoPtr_owners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "owners");
			NativeFieldInfoPtr_airVents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "airVents");
			NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "password");
			NativeFieldInfoPtr_cf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "cf");
			NativeFieldInfoPtr_cullTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "cullTree");
			NativeFieldInfoPtr_above = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "above");
			NativeFieldInfoPtr_below = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "below");
			NativeFieldInfoPtr_adj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "adj");
			NativeFieldInfoPtr_occ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, "occ");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr, 100670331);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241329, RefRangeEnd = 241330, XrefRangeStart = 241273, XrefRangeEnd = 241329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoomCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public RoomCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CullTreeSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_r;

		private static readonly System.IntPtr NativeFieldInfoPtr_d;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int r
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r)) = num;
			}
		}

		public unsafe List<int> d
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CullTreeSave()
		{
			Il2CppClassPointerStore<CullTreeSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "CullTreeSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullTreeSave>.NativeClassPtr);
			NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullTreeSave>.NativeClassPtr, "r");
			NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullTreeSave>.NativeClassPtr, "d");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullTreeSave>.NativeClassPtr, 100670332);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CullTreeSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullTreeSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CullTreeSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class LightZoneSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_n;

		private static readonly System.IntPtr NativeFieldInfoPtr_areaLightColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_areaLightBright;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<Vector3Int> n
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Color areaLightColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightColour)) = color;
			}
		}

		public unsafe float areaLightBright
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightBright);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightBright)) = num;
			}
		}

		static LightZoneSave()
		{
			Il2CppClassPointerStore<LightZoneSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "LightZoneSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightZoneSave>.NativeClassPtr);
			NativeFieldInfoPtr_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneSave>.NativeClassPtr, "n");
			NativeFieldInfoPtr_areaLightColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneSave>.NativeClassPtr, "areaLightColour");
			NativeFieldInfoPtr_areaLightBright = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneSave>.NativeClassPtr, "areaLightBright");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightZoneSave>.NativeClassPtr, 100670333);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241330, XrefRangeEnd = 241335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightZoneSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightZoneSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LightZoneSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class NodeCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nc;

		private static readonly System.IntPtr NativeFieldInfoPtr_w;

		private static readonly System.IntPtr NativeFieldInfoPtr_ft;

		private static readonly System.IntPtr NativeFieldInfoPtr_fr;

		private static readonly System.IntPtr NativeFieldInfoPtr_frr;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3Int nc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nc);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nc)) = vector3Int;
			}
		}

		public unsafe List<WallCitySave> w
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WallCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe NewNode.FloorTileType ft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ft);
				return *(NewNode.FloorTileType*)num;
			}
			set
			{
				*(NewNode.FloorTileType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ft)) = floorTileType;
			}
		}

		public unsafe string fr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string frr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frr);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frr)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static NodeCitySave()
		{
			Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "NodeCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_nc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr, "nc");
			NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr, "w");
			NativeFieldInfoPtr_ft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr, "ft");
			NativeFieldInfoPtr_fr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr, "fr");
			NativeFieldInfoPtr_frr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr, "frr");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr, 100670334);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241335, XrefRangeEnd = 241341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NodeCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class WallCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wo;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_p;

		private static readonly System.IntPtr NativeFieldInfoPtr_ow;

		private static readonly System.IntPtr NativeFieldInfoPtr_pw;

		private static readonly System.IntPtr NativeFieldInfoPtr_cw;

		private static readonly System.IntPtr NativeFieldInfoPtr_oo;

		private static readonly System.IntPtr NativeFieldInfoPtr_oa;

		private static readonly System.IntPtr NativeFieldInfoPtr_cl;

		private static readonly System.IntPtr NativeFieldInfoPtr_sw;

		private static readonly System.IntPtr NativeFieldInfoPtr_fr;

		private static readonly System.IntPtr NativeFieldInfoPtr_dm;

		private static readonly System.IntPtr NativeFieldInfoPtr_dmk;

		private static readonly System.IntPtr NativeFieldInfoPtr_ds;

		private static readonly System.IntPtr NativeFieldInfoPtr_ls;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2 wo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wo);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wo)) = vector;
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe string p
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int ow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ow);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ow)) = num;
			}
		}

		public unsafe int pw
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pw);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pw)) = num;
			}
		}

		public unsafe int cw
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cw);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cw)) = num;
			}
		}

		public unsafe bool oo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oo);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oo)) = flag;
			}
		}

		public unsafe bool oa
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oa);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oa)) = flag;
			}
		}

		public unsafe int cl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cl);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cl)) = num;
			}
		}

		public unsafe bool sw
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sw);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sw)) = flag;
			}
		}

		public unsafe List<WallFrontageSave> fr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WallFrontageSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool dm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dm);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dm)) = flag;
			}
		}

		public unsafe Toolbox.MaterialKey dmk
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dmk);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dmk)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe float ds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds)) = num;
			}
		}

		public unsafe float ls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls)) = num;
			}
		}

		static WallCitySave()
		{
			Il2CppClassPointerStore<WallCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "WallCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_wo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "wo");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "p");
			NativeFieldInfoPtr_ow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "ow");
			NativeFieldInfoPtr_pw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "pw");
			NativeFieldInfoPtr_cw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "cw");
			NativeFieldInfoPtr_oo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "oo");
			NativeFieldInfoPtr_oa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "oa");
			NativeFieldInfoPtr_cl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "cl");
			NativeFieldInfoPtr_sw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "sw");
			NativeFieldInfoPtr_fr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "fr");
			NativeFieldInfoPtr_dm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "dm");
			NativeFieldInfoPtr_dmk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "dmk");
			NativeFieldInfoPtr_ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "ds");
			NativeFieldInfoPtr_ls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, "ls");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr, 100670335);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241341, XrefRangeEnd = 241347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WallCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WallCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class WallFrontageSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_str;

		private static readonly System.IntPtr NativeFieldInfoPtr_matKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_o;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string str
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Toolbox.MaterialKey matKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe Vector3 o
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_o);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_o)) = vector;
			}
		}

		static WallFrontageSave()
		{
			Il2CppClassPointerStore<WallFrontageSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "WallFrontageSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallFrontageSave>.NativeClassPtr);
			NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontageSave>.NativeClassPtr, "str");
			NativeFieldInfoPtr_matKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontageSave>.NativeClassPtr, "matKey");
			NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallFrontageSave>.NativeClassPtr, "o");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallFrontageSave>.NativeClassPtr, 100670336);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WallFrontageSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallFrontageSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WallFrontageSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FurnitureClusterCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cluster;

		private static readonly System.IntPtr NativeFieldInfoPtr_anchorNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_angle;

		private static readonly System.IntPtr NativeFieldInfoPtr_objs;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string cluster
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cluster);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cluster)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Vector3Int anchorNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode)) = vector3Int;
			}
		}

		public unsafe int angle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
			}
		}

		public unsafe List<FurnitureClusterObjectCitySave> objs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClusterObjectCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static FurnitureClusterCitySave()
		{
			Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "FurnitureClusterCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr, "cluster");
			NativeFieldInfoPtr_anchorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr, "anchorNode");
			NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr, "angle");
			NativeFieldInfoPtr_objs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr, "objs");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr, 100670337);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241347, XrefRangeEnd = 241353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurnitureClusterCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureClusterCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FurnitureClusterCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FurnitureClusterObjectCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_furnitureClasses;

		private static readonly System.IntPtr NativeFieldInfoPtr_angle;

		private static readonly System.IntPtr NativeFieldInfoPtr_anchorNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_coversNodes;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_furniture;

		private static readonly System.IntPtr NativeFieldInfoPtr_art;

		private static readonly System.IntPtr NativeFieldInfoPtr_up;

		private static readonly System.IntPtr NativeFieldInfoPtr_scale;

		private static readonly System.IntPtr NativeFieldInfoPtr_matKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_artMatKet;

		private static readonly System.IntPtr NativeFieldInfoPtr_owners;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe List<string> furnitureClasses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureClasses);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int angle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
			}
		}

		public unsafe Vector3Int anchorNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode)) = vector3Int;
			}
		}

		public unsafe List<Vector3Int> coversNodes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coversNodes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coversNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Vector3 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
			}
		}

		public unsafe string furniture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniture);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniture)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string art
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_art);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_art)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool up
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up)) = flag;
			}
		}

		public unsafe Vector3 scale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = vector;
			}
		}

		public unsafe Toolbox.MaterialKey matKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe Toolbox.MaterialKey artMatKet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artMatKet);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artMatKet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe List<int> owners
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owners);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static FurnitureClusterObjectCitySave()
		{
			Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "FurnitureClusterObjectCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_furnitureClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "furnitureClasses");
			NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "angle");
			NativeFieldInfoPtr_anchorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "anchorNode");
			NativeFieldInfoPtr_coversNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "coversNodes");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_furniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "furniture");
			NativeFieldInfoPtr_art = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "art");
			NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "up");
			NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "scale");
			NativeFieldInfoPtr_matKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "matKey");
			NativeFieldInfoPtr_artMatKet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "artMatKet");
			NativeFieldInfoPtr_owners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, "owners");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr, 100670338);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241358, RefRangeEnd = 241360, XrefRangeStart = 241353, XrefRangeEnd = 241358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurnitureClusterObjectCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureClusterObjectCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FurnitureClusterObjectCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class HumanCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_humanID;

		private static readonly System.IntPtr NativeFieldInfoPtr_home;

		private static readonly System.IntPtr NativeFieldInfoPtr_speedModifier;

		private static readonly System.IntPtr NativeFieldInfoPtr_job;

		private static readonly System.IntPtr NativeFieldInfoPtr_birthday;

		private static readonly System.IntPtr NativeFieldInfoPtr_societalClass;

		private static readonly System.IntPtr NativeFieldInfoPtr_descriptors;

		private static readonly System.IntPtr NativeFieldInfoPtr_blood;

		private static readonly System.IntPtr NativeFieldInfoPtr_citizenName;

		private static readonly System.IntPtr NativeFieldInfoPtr_firstName;

		private static readonly System.IntPtr NativeFieldInfoPtr_casualName;

		private static readonly System.IntPtr NativeFieldInfoPtr_surName;

		private static readonly System.IntPtr NativeFieldInfoPtr_homeless;

		private static readonly System.IntPtr NativeFieldInfoPtr_slangUsage;

		private static readonly System.IntPtr NativeFieldInfoPtr_genderScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_gender;

		private static readonly System.IntPtr NativeFieldInfoPtr_bGender;

		private static readonly System.IntPtr NativeFieldInfoPtr_sexuality;

		private static readonly System.IntPtr NativeFieldInfoPtr_homosexuality;

		private static readonly System.IntPtr NativeFieldInfoPtr_attractedTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_partner;

		private static readonly System.IntPtr NativeFieldInfoPtr_paramour;

		private static readonly System.IntPtr NativeFieldInfoPtr_anniversary;

		private static readonly System.IntPtr NativeFieldInfoPtr_sleepNeedMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_snoring;

		private static readonly System.IntPtr NativeFieldInfoPtr_snoreDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr_humility;

		private static readonly System.IntPtr NativeFieldInfoPtr_emotionality;

		private static readonly System.IntPtr NativeFieldInfoPtr_extraversion;

		private static readonly System.IntPtr NativeFieldInfoPtr_agreeableness;

		private static readonly System.IntPtr NativeFieldInfoPtr_conscientiousness;

		private static readonly System.IntPtr NativeFieldInfoPtr_creativity;

		private static readonly System.IntPtr NativeFieldInfoPtr_acquaintances;

		private static readonly System.IntPtr NativeFieldInfoPtr_traits;

		private static readonly System.IntPtr NativeFieldInfoPtr_password;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxHealth;

		private static readonly System.IntPtr NativeFieldInfoPtr_recoveryRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_combatSkill;

		private static readonly System.IntPtr NativeFieldInfoPtr_combatHeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxNerve;

		private static readonly System.IntPtr NativeFieldInfoPtr_breathRecovery;

		private static readonly System.IntPtr NativeFieldInfoPtr_handwriting;

		private static readonly System.IntPtr NativeFieldInfoPtr_sightingMemory;

		private static readonly System.IntPtr NativeFieldInfoPtr_favItems;

		private static readonly System.IntPtr NativeFieldInfoPtr_favItemRanks;

		private static readonly System.IntPtr NativeFieldInfoPtr_favCat;

		private static readonly System.IntPtr NativeFieldInfoPtr_favAddresses;

		private static readonly System.IntPtr NativeFieldInfoPtr_outfits;

		private static readonly System.IntPtr NativeFieldInfoPtr_favCol;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int humanID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanID)) = num;
			}
		}

		public unsafe int home
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home)) = num;
			}
		}

		public unsafe float speedModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedModifier)) = num;
			}
		}

		public unsafe int job
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job)) = num;
			}
		}

		public unsafe string birthday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthday);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthday)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float societalClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClass);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClass)) = num;
			}
		}

		public unsafe Descriptors descriptors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptors);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Descriptors>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)descriptors));
			}
		}

		public unsafe Human.BloodType blood
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blood);
				return *(Human.BloodType*)num;
			}
			set
			{
				*(Human.BloodType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blood)) = bloodType;
			}
		}

		public unsafe string citizenName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string firstName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string casualName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_casualName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_casualName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string surName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool homeless
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeless);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeless)) = flag;
			}
		}

		public unsafe float slangUsage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangUsage);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangUsage)) = num;
			}
		}

		public unsafe float genderScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderScale)) = num;
			}
		}

		public unsafe Human.Gender gender
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gender);
				return *(Human.Gender*)num;
			}
			set
			{
				*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gender)) = gender;
			}
		}

		public unsafe Human.Gender bGender
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bGender);
				return *(Human.Gender*)num;
			}
			set
			{
				*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bGender)) = gender;
			}
		}

		public unsafe float sexuality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexuality);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexuality)) = num;
			}
		}

		public unsafe float homosexuality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homosexuality);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homosexuality)) = num;
			}
		}

		public unsafe List<Human.Gender> attractedTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractedTo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.Gender>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractedTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int partner
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partner);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partner)) = num;
			}
		}

		public unsafe int paramour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramour);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramour)) = num;
			}
		}

		public unsafe string anniversary
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anniversary);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anniversary)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float sleepNeedMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepNeedMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepNeedMultiplier)) = num;
			}
		}

		public unsafe float snoring
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoring);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoring)) = num;
			}
		}

		public unsafe float snoreDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoreDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoreDelay)) = num;
			}
		}

		public unsafe float humility
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility)) = num;
			}
		}

		public unsafe float emotionality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality)) = num;
			}
		}

		public unsafe float extraversion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion)) = num;
			}
		}

		public unsafe float agreeableness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness)) = num;
			}
		}

		public unsafe float conscientiousness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness)) = num;
			}
		}

		public unsafe float creativity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity)) = num;
			}
		}

		public unsafe List<AcquaintanceCitySave> acquaintances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquaintances);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AcquaintanceCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquaintances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<CharTraitSave> traits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharTraitSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe GameplayController.Passcode password
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameplayController.Passcode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passcode));
			}
		}

		public unsafe float maxHealth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealth);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealth)) = num;
			}
		}

		public unsafe float recoveryRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRate)) = num;
			}
		}

		public unsafe float combatSkill
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatSkill);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatSkill)) = num;
			}
		}

		public unsafe float combatHeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHeft);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatHeft)) = num;
			}
		}

		public unsafe float maxNerve
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNerve);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNerve)) = num;
			}
		}

		public unsafe float breathRecovery
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRecovery);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRecovery)) = num;
			}
		}

		public unsafe string handwriting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handwriting);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handwriting)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int sightingMemory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingMemory);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingMemory)) = num;
			}
		}

		public unsafe List<string> favItems
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favItems);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> favItemRanks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favItemRanks);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favItemRanks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<CompanyPreset.CompanyCategory> favCat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favCat);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyPreset.CompanyCategory>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favCat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> favAddresses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favAddresses);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favAddresses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<CitizenOutfitController.Outfit> outfits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitizenOutfitController.Outfit>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int favCol
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favCol);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favCol)) = num;
			}
		}

		static HumanCitySave()
		{
			Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "HumanCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_humanID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "humanID");
			NativeFieldInfoPtr_home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "home");
			NativeFieldInfoPtr_speedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "speedModifier");
			NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "job");
			NativeFieldInfoPtr_birthday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "birthday");
			NativeFieldInfoPtr_societalClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "societalClass");
			NativeFieldInfoPtr_descriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "descriptors");
			NativeFieldInfoPtr_blood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "blood");
			NativeFieldInfoPtr_citizenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "citizenName");
			NativeFieldInfoPtr_firstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "firstName");
			NativeFieldInfoPtr_casualName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "casualName");
			NativeFieldInfoPtr_surName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "surName");
			NativeFieldInfoPtr_homeless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "homeless");
			NativeFieldInfoPtr_slangUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "slangUsage");
			NativeFieldInfoPtr_genderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "genderScale");
			NativeFieldInfoPtr_gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "gender");
			NativeFieldInfoPtr_bGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "bGender");
			NativeFieldInfoPtr_sexuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "sexuality");
			NativeFieldInfoPtr_homosexuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "homosexuality");
			NativeFieldInfoPtr_attractedTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "attractedTo");
			NativeFieldInfoPtr_partner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "partner");
			NativeFieldInfoPtr_paramour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "paramour");
			NativeFieldInfoPtr_anniversary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "anniversary");
			NativeFieldInfoPtr_sleepNeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "sleepNeedMultiplier");
			NativeFieldInfoPtr_snoring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "snoring");
			NativeFieldInfoPtr_snoreDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "snoreDelay");
			NativeFieldInfoPtr_humility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "humility");
			NativeFieldInfoPtr_emotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "emotionality");
			NativeFieldInfoPtr_extraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "extraversion");
			NativeFieldInfoPtr_agreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "agreeableness");
			NativeFieldInfoPtr_conscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "conscientiousness");
			NativeFieldInfoPtr_creativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "creativity");
			NativeFieldInfoPtr_acquaintances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "acquaintances");
			NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "traits");
			NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "password");
			NativeFieldInfoPtr_maxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "maxHealth");
			NativeFieldInfoPtr_recoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "recoveryRate");
			NativeFieldInfoPtr_combatSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "combatSkill");
			NativeFieldInfoPtr_combatHeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "combatHeft");
			NativeFieldInfoPtr_maxNerve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "maxNerve");
			NativeFieldInfoPtr_breathRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "breathRecovery");
			NativeFieldInfoPtr_handwriting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "handwriting");
			NativeFieldInfoPtr_sightingMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "sightingMemory");
			NativeFieldInfoPtr_favItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "favItems");
			NativeFieldInfoPtr_favItemRanks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "favItemRanks");
			NativeFieldInfoPtr_favCat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "favCat");
			NativeFieldInfoPtr_favAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "favAddresses");
			NativeFieldInfoPtr_outfits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "outfits");
			NativeFieldInfoPtr_favCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, "favCol");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr, 100670339);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241409, RefRangeEnd = 241410, XrefRangeStart = 241360, XrefRangeEnd = 241409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HumanCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HumanCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CharTraitSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_traitID;

		private static readonly System.IntPtr NativeFieldInfoPtr_trait;

		private static readonly System.IntPtr NativeFieldInfoPtr_reason;

		private static readonly System.IntPtr NativeFieldInfoPtr_date;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int traitID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitID)) = num;
			}
		}

		public unsafe string trait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int reason
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reason);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reason)) = num;
			}
		}

		public unsafe string date
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_date);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_date)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static CharTraitSave()
		{
			Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "CharTraitSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr);
			NativeFieldInfoPtr_traitID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr, "traitID");
			NativeFieldInfoPtr_trait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr, "trait");
			NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr, "reason");
			NativeFieldInfoPtr_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr, "date");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr, 100670340);
		}

		[CallerCount(0)]
		public unsafe CharTraitSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharTraitSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CharTraitSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AcquaintanceCitySave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_from;

		private static readonly System.IntPtr NativeFieldInfoPtr_with;

		private static readonly System.IntPtr NativeFieldInfoPtr_connections;

		private static readonly System.IntPtr NativeFieldInfoPtr_secret;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatible;

		private static readonly System.IntPtr NativeFieldInfoPtr_known;

		private static readonly System.IntPtr NativeFieldInfoPtr_like;

		private static readonly System.IntPtr NativeFieldInfoPtr_dataKeys;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int from
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from)) = num;
			}
		}

		public unsafe int with
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_with);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_with)) = num;
			}
		}

		public unsafe List<Acquaintance.ConnectionType> connections
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connections);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Acquaintance.ConnectionType>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Acquaintance.ConnectionType secret
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secret);
				return *(Acquaintance.ConnectionType*)num;
			}
			set
			{
				*(Acquaintance.ConnectionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secret)) = connectionType;
			}
		}

		public unsafe float compatible
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatible);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatible)) = num;
			}
		}

		public unsafe float known
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_known);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_known)) = num;
			}
		}

		public unsafe float like
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_like);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_like)) = num;
			}
		}

		public unsafe List<Evidence.DataKey> dataKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static AcquaintanceCitySave()
		{
			Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "AcquaintanceCitySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr);
			NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "from");
			NativeFieldInfoPtr_with = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "with");
			NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "connections");
			NativeFieldInfoPtr_secret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "secret");
			NativeFieldInfoPtr_compatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "compatible");
			NativeFieldInfoPtr_known = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "known");
			NativeFieldInfoPtr_like = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "like");
			NativeFieldInfoPtr_dataKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, "dataKeys");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr, 100670341);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241410, XrefRangeEnd = 241422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquaintanceCitySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquaintanceCitySave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AcquaintanceCitySave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class EvidenceStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_page;

		private static readonly System.IntPtr NativeFieldInfoPtr_mpContent;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int page
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page)) = num;
			}
		}

		public unsafe List<EvidenceMultiPage.MultiPageContent> mpContent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpContent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceMultiPage.MultiPageContent>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpContent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static EvidenceStateSave()
		{
			Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "EvidenceStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "page");
			NativeFieldInfoPtr_mpContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "mpContent");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, 100670342);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241428, RefRangeEnd = 241429, XrefRangeStart = 241422, XrefRangeEnd = 241428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EvidenceStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EvidenceStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_build;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityName;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_citySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_population;

	private static readonly System.IntPtr NativeFieldInfoPtr_playersApartment;

	private static readonly System.IntPtr NativeFieldInfoPtr_districts;

	private static readonly System.IntPtr NativeFieldInfoPtr_streets;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityTiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizens;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactables;

	private static readonly System.IntPtr NativeFieldInfoPtr_groups;

	private static readonly System.IntPtr NativeFieldInfoPtr_pipes;

	private static readonly System.IntPtr NativeFieldInfoPtr_criminals;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_metas;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string build
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string cityName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Vector2 citySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySize)) = vector;
		}
	}

	public unsafe int population
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_population);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_population)) = num;
		}
	}

	public unsafe int playersApartment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playersApartment);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playersApartment)) = num;
		}
	}

	public unsafe List<DistrictCitySave> districts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictCitySave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StreetCitySave> streets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StreetCitySave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CityTileCitySave> cityTiles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTiles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CityTileCitySave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HumanCitySave> citizens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizens);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HumanCitySave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizens)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> interactables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GroupsController.SocialGroup> groups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GroupsController.SocialGroup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<PipeConstructor.PipeGroup> pipes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pipes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PipeConstructor.PipeGroup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pipes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<OccupationCitySave> criminals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_criminals);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationCitySave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_criminals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<EvidenceStateSave> multiPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiPage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiPage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MetaObject> metas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MetaObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static CitySaveData()
	{
		Il2CppClassPointerStore<CitySaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CitySaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr);
		NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "build");
		NativeFieldInfoPtr_cityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "cityName");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_citySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "citySize");
		NativeFieldInfoPtr_population = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "population");
		NativeFieldInfoPtr_playersApartment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "playersApartment");
		NativeFieldInfoPtr_districts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "districts");
		NativeFieldInfoPtr_streets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "streets");
		NativeFieldInfoPtr_cityTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "cityTiles");
		NativeFieldInfoPtr_citizens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "citizens");
		NativeFieldInfoPtr_interactables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "interactables");
		NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "groups");
		NativeFieldInfoPtr_pipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "pipes");
		NativeFieldInfoPtr_criminals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "criminals");
		NativeFieldInfoPtr_multiPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "multiPage");
		NativeFieldInfoPtr_metas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, "metas");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr, 100670316);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241493, RefRangeEnd = 241495, XrefRangeStart = 241429, XrefRangeEnd = 241493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CitySaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CitySaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CitySaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
