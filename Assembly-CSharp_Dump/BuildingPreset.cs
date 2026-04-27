using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class BuildingPreset : SoCustomComparison
{
	public enum Density
	{
		low,
		medium,
		high,
		veryHigh
	}

	public enum LandValue
	{
		veryLow,
		low,
		medium,
		high,
		veryHigh
	}

	[System.Serializable]
	public class InteriorFloorSetting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_floorsWithThisSetting;

		private static readonly System.IntPtr NativeFieldInfoPtr_blueprints;

		private static readonly System.IntPtr NativeFieldInfoPtr_airVentMaximumExtrusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_controlRoomVariants;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceShowModel;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceHideModels;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceHideModelsInRooms;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceHideModelsOutside;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideCeilingHeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_newCeilingHeight;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int floorsWithThisSetting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorsWithThisSetting);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorsWithThisSetting)) = num;
			}
		}

		public unsafe List<TextAsset> blueprints
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprints);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextAsset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int airVentMaximumExtrusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVentMaximumExtrusion);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVentMaximumExtrusion)) = num;
			}
		}

		public unsafe List<TextAsset> controlRoomVariants
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlRoomVariants);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextAsset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlRoomVariants)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool forceShowModel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceShowModel);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceShowModel)) = flag;
			}
		}

		public unsafe List<string> forceHideModels
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModels);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<ForceHideModelsForRoom> forceHideModelsInRooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModelsInRooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForceHideModelsForRoom>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModelsInRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<string> forceHideModelsOutside
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModelsOutside);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModelsOutside)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool overrideCeilingHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCeilingHeight);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCeilingHeight)) = flag;
			}
		}

		public unsafe int newCeilingHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newCeilingHeight);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newCeilingHeight)) = num;
			}
		}

		static InteriorFloorSetting()
		{
			Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "InteriorFloorSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr);
			NativeFieldInfoPtr_floorsWithThisSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "floorsWithThisSetting");
			NativeFieldInfoPtr_blueprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "blueprints");
			NativeFieldInfoPtr_airVentMaximumExtrusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "airVentMaximumExtrusion");
			NativeFieldInfoPtr_controlRoomVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "controlRoomVariants");
			NativeFieldInfoPtr_forceShowModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "forceShowModel");
			NativeFieldInfoPtr_forceHideModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "forceHideModels");
			NativeFieldInfoPtr_forceHideModelsInRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "forceHideModelsInRooms");
			NativeFieldInfoPtr_forceHideModelsOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "forceHideModelsOutside");
			NativeFieldInfoPtr_overrideCeilingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "overrideCeilingHeight");
			NativeFieldInfoPtr_newCeilingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, "newCeilingHeight");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr, 100673823);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326930, XrefRangeEnd = 326956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteriorFloorSetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteriorFloorSetting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InteriorFloorSetting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ForceHideModelsForRoom : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_roomConfig;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceHideModels;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe RoomConfiguration roomConfig
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomConfig);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
			}
		}

		public unsafe List<string> forceHideModels
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModels);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceHideModels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static ForceHideModelsForRoom()
		{
			Il2CppClassPointerStore<ForceHideModelsForRoom>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "ForceHideModelsForRoom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceHideModelsForRoom>.NativeClassPtr);
			NativeFieldInfoPtr_roomConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceHideModelsForRoom>.NativeClassPtr, "roomConfig");
			NativeFieldInfoPtr_forceHideModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceHideModelsForRoom>.NativeClassPtr, "forceHideModels");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceHideModelsForRoom>.NativeClassPtr, 100673824);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326956, XrefRangeEnd = 326962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForceHideModelsForRoom()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceHideModelsForRoom>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ForceHideModelsForRoom(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ZoneType
	{
		residential,
		commercial,
		industrial,
		municipal,
		publicProperty,
		privateProperty
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct CableLinkPoint
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_localPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_localRot;

		[FieldOffset(0)]
		public Vector3 localPos;

		[FieldOffset(12)]
		public Vector3 localRot;

		static CableLinkPoint()
		{
			Il2CppClassPointerStore<CableLinkPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "CableLinkPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CableLinkPoint>.NativeClassPtr);
			NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableLinkPoint>.NativeClassPtr, "localPos");
			NativeFieldInfoPtr_localRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CableLinkPoint>.NativeClassPtr, "localRot");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CableLinkPoint>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	public class WindowUVFloor : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_front;

		private static readonly System.IntPtr NativeFieldInfoPtr_back;

		private static readonly System.IntPtr NativeFieldInfoPtr_left;

		private static readonly System.IntPtr NativeFieldInfoPtr_right;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<WindowUVBlock> front
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_front);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WindowUVBlock>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_front)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<WindowUVBlock> back
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_back);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WindowUVBlock>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_back)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<WindowUVBlock> left
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WindowUVBlock>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<WindowUVBlock> right
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WindowUVBlock>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static WindowUVFloor()
		{
			Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "WindowUVFloor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr);
			NativeFieldInfoPtr_front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr, "front");
			NativeFieldInfoPtr_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr, "back");
			NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr, "left");
			NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr, "right");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr, 100673825);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326980, RefRangeEnd = 326981, XrefRangeStart = 326962, XrefRangeEnd = 326980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowUVFloor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowUVFloor>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WindowUVFloor(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class WindowUVBlock : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_originPixel;

		private static readonly System.IntPtr NativeFieldInfoPtr_rectSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_centrePixel;

		private static readonly System.IntPtr NativeFieldInfoPtr_localMeshPositionLeft;

		private static readonly System.IntPtr NativeFieldInfoPtr_localMeshPositionRight;

		private static readonly System.IntPtr NativeFieldInfoPtr_floor;

		private static readonly System.IntPtr NativeFieldInfoPtr_side;

		private static readonly System.IntPtr NativeFieldInfoPtr_horizonal;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2 originPixel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originPixel);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originPixel)) = vector;
			}
		}

		public unsafe Vector2 rectSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectSize);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectSize)) = vector;
			}
		}

		public unsafe Vector2 centrePixel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centrePixel);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centrePixel)) = vector;
			}
		}

		public unsafe Vector3 localMeshPositionLeft
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localMeshPositionLeft);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localMeshPositionLeft)) = vector;
			}
		}

		public unsafe Vector3 localMeshPositionRight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localMeshPositionRight);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localMeshPositionRight)) = vector;
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

		public unsafe Vector2 side
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_side);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_side)) = vector;
			}
		}

		public unsafe int horizonal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizonal);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizonal)) = num;
			}
		}

		static WindowUVBlock()
		{
			Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "WindowUVBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr);
			NativeFieldInfoPtr_originPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "originPixel");
			NativeFieldInfoPtr_rectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "rectSize");
			NativeFieldInfoPtr_centrePixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "centrePixel");
			NativeFieldInfoPtr_localMeshPositionLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "localMeshPositionLeft");
			NativeFieldInfoPtr_localMeshPositionRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "localMeshPositionRight");
			NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "floor");
			NativeFieldInfoPtr_side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "side");
			NativeFieldInfoPtr_horizonal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, "horizonal");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr, 100673826);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowUVBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowUVBlock>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WindowUVBlock(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("BuildingPreset+<>c__DisplayClass71_0")]
	public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_thisBlock;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__1_Internal_Boolean_WindowUVBlock_0;

		public unsafe WindowUVBlock thisBlock
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisBlock);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WindowUVBlock>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisBlock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowUVBlock));
			}
		}

		static __c__DisplayClass71_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "<>c__DisplayClass71_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr);
			NativeFieldInfoPtr_thisBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr, "thisBlock");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr, 100673827);
			NativeMethodInfoPtr__GenerateWindowData_b__1_Internal_Boolean_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr, 100673828);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass71_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326981, XrefRangeEnd = 326985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateWindowData_b__1(WindowUVBlock item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__1_Internal_Boolean_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass71_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("BuildingPreset+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_5;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_6;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_7;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_8;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__71_9;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_0_Internal_Int32_WindowUVBlock_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_2_Internal_Boolean_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_3_Internal_Int32_WindowUVBlock_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_4_Internal_Boolean_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_5_Internal_Int32_WindowUVBlock_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_6_Internal_Boolean_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_7_Internal_Int32_WindowUVBlock_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_8_Internal_Boolean_WindowUVBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateWindowData_b__71_9_Internal_Int32_WindowUVBlock_WindowUVBlock_0;

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

		public unsafe static Il2CppSystem.Comparison<WindowUVBlock> __9__71_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WindowUVBlock> __9__71_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<WindowUVBlock> __9__71_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WindowUVBlock> __9__71_4
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_4, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<WindowUVBlock> __9__71_5
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_5, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WindowUVBlock> __9__71_6
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_6, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_6, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<WindowUVBlock> __9__71_7
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_7, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_7, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WindowUVBlock> __9__71_8
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_8, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_8, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<WindowUVBlock> __9__71_9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__71_9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<WindowUVBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__71_9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__71_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_0");
			NativeFieldInfoPtr___9__71_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_2");
			NativeFieldInfoPtr___9__71_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_3");
			NativeFieldInfoPtr___9__71_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_4");
			NativeFieldInfoPtr___9__71_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_5");
			NativeFieldInfoPtr___9__71_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_6");
			NativeFieldInfoPtr___9__71_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_7");
			NativeFieldInfoPtr___9__71_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_8");
			NativeFieldInfoPtr___9__71_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__71_9");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673830);
			NativeMethodInfoPtr__GenerateWindowData_b__71_0_Internal_Int32_WindowUVBlock_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673831);
			NativeMethodInfoPtr__GenerateWindowData_b__71_2_Internal_Boolean_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673832);
			NativeMethodInfoPtr__GenerateWindowData_b__71_3_Internal_Int32_WindowUVBlock_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673833);
			NativeMethodInfoPtr__GenerateWindowData_b__71_4_Internal_Boolean_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673834);
			NativeMethodInfoPtr__GenerateWindowData_b__71_5_Internal_Int32_WindowUVBlock_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673835);
			NativeMethodInfoPtr__GenerateWindowData_b__71_6_Internal_Boolean_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673836);
			NativeMethodInfoPtr__GenerateWindowData_b__71_7_Internal_Int32_WindowUVBlock_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673837);
			NativeMethodInfoPtr__GenerateWindowData_b__71_8_Internal_Boolean_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673838);
			NativeMethodInfoPtr__GenerateWindowData_b__71_9_Internal_Int32_WindowUVBlock_WindowUVBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100673839);
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
		public unsafe int _GenerateWindowData_b__71_0(WindowUVBlock p1, WindowUVBlock p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_0_Internal_Int32_WindowUVBlock_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateWindowData_b__71_2(WindowUVBlock item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_2_Internal_Boolean_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GenerateWindowData_b__71_3(WindowUVBlock p1, WindowUVBlock p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_3_Internal_Int32_WindowUVBlock_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateWindowData_b__71_4(WindowUVBlock item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_4_Internal_Boolean_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GenerateWindowData_b__71_5(WindowUVBlock p1, WindowUVBlock p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_5_Internal_Int32_WindowUVBlock_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateWindowData_b__71_6(WindowUVBlock item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_6_Internal_Boolean_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GenerateWindowData_b__71_7(WindowUVBlock p1, WindowUVBlock p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_7_Internal_Int32_WindowUVBlock_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateWindowData_b__71_8(WindowUVBlock item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_8_Internal_Boolean_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GenerateWindowData_b__71_9(WindowUVBlock p1, WindowUVBlock p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateWindowData_b__71_9_Internal_Int32_WindowUVBlock_WindowUVBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_disable;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_emissionMapUnlit;

	private static readonly System.IntPtr NativeFieldInfoPtr_emissionMapLit;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightningRodLocalPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultExteriorWallMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_exteriorKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableAlleywayWalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableExteriorQuoins;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideEvidencePhotoSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeCamPhotoPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeCamPhotoEuler;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideDistrictEnvironment;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLostAndFound;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorLayouts;

	private static readonly System.IntPtr NativeFieldInfoPtr_basementLayouts;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlRoomRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceBuildingDesignStyles;

	private static readonly System.IntPtr NativeFieldInfoPtr_stairwellRegular;

	private static readonly System.IntPtr NativeFieldInfoPtr_stairwellLarge;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingFeaturesEchelonFloors;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonFloorStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideGrubiness;

	private static readonly System.IntPtr NativeFieldInfoPtr_grubinessOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayedZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInAllDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedInDistricts;

	private static readonly System.IntPtr NativeFieldInfoPtr_densityMinimum;

	private static readonly System.IntPtr NativeFieldInfoPtr_densityMaximum;

	private static readonly System.IntPtr NativeFieldInfoPtr_landValueMinimum;

	private static readonly System.IntPtr NativeFieldInfoPtr_landValueMaximum;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimum;

	private static readonly System.IntPtr NativeFieldInfoPtr_featureImportance;

	private static readonly System.IntPtr NativeFieldInfoPtr_hardLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_modernity;

	private static readonly System.IntPtr NativeFieldInfoPtr_lobbyPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonEnterable;

	private static readonly System.IntPtr NativeFieldInfoPtr_boundary;

	private static readonly System.IntPtr NativeFieldInfoPtr_boundaryCorner;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideNaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_customDrawOnMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_tex;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_addonMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_sortedWindows;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_cableLinkPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_cableSpawnChanceOverHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideSignPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleNeonSigns;

	private static readonly System.IntPtr NativeFieldInfoPtr_signsPerBuildingRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalSignOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_featuresSmokestack;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_spritePrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsetArrayX4;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateWindowData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateAddonData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateMeshHeight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UvTo3D_Public_Vector3_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Area_Public_Single_Vector2_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloorSetting_Public_InteriorFloorSetting_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResidenceCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool disable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable)) = flag;
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

	public unsafe Texture2D emissionMapUnlit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMapUnlit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMapUnlit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D emissionMapLit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMapLit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMapLit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe float buildingHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingHeight)) = num;
		}
	}

	public unsafe Vector3 lightningRodLocalPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightningRodLocalPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightningRodLocalPos)) = vector;
		}
	}

	public unsafe List<MaterialGroupPreset> defaultExteriorWallMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultExteriorWallMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MaterialGroupPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultExteriorWallMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Toolbox.MaterialKey exteriorKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorKey);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
		}
	}

	public unsafe bool enableAlleywayWalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlleywayWalls);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAlleywayWalls)) = flag;
		}
	}

	public unsafe bool enableExteriorQuoins
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableExteriorQuoins);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableExteriorQuoins)) = flag;
		}
	}

	public unsafe bool overrideEvidencePhotoSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEvidencePhotoSettings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideEvidencePhotoSettings)) = flag;
		}
	}

	public unsafe Vector3 relativeCamPhotoPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos)) = vector;
		}
	}

	public unsafe Vector3 relativeCamPhotoEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler)) = vector;
		}
	}

	public unsafe bool overrideDistrictEnvironment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDistrictEnvironment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDistrictEnvironment)) = flag;
		}
	}

	public unsafe SessionData.SceneProfile sceneProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfile);
			return *(SessionData.SceneProfile*)num;
		}
		set
		{
			*(SessionData.SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfile)) = sceneProfile;
		}
	}

	public unsafe int maxLostAndFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLostAndFound);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLostAndFound)) = num;
		}
	}

	public unsafe List<InteriorFloorSetting> floorLayouts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorLayouts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteriorFloorSetting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorLayouts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteriorFloorSetting> basementLayouts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basementLayouts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteriorFloorSetting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basementLayouts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector2 controlRoomRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlRoomRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlRoomRange)) = vector;
		}
	}

	public unsafe List<DesignStylePreset> forceBuildingDesignStyles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceBuildingDesignStyles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DesignStylePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceBuildingDesignStyles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe StairwellPreset stairwellRegular
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellRegular);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StairwellPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellRegular)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stairwellPreset));
		}
	}

	public unsafe StairwellPreset stairwellLarge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellLarge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StairwellPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairwellLarge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stairwellPreset));
		}
	}

	public unsafe bool buildingFeaturesEchelonFloors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingFeaturesEchelonFloors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingFeaturesEchelonFloors)) = flag;
		}
	}

	public unsafe int echelonFloorStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonFloorStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonFloorStart)) = num;
		}
	}

	public unsafe bool overrideGrubiness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideGrubiness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideGrubiness)) = flag;
		}
	}

	public unsafe float grubinessOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grubinessOverride);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grubinessOverride)) = num;
		}
	}

	public unsafe ZoneType displayedZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayedZone);
			return *(ZoneType*)num;
		}
		set
		{
			*(ZoneType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayedZone)) = zoneType;
		}
	}

	public unsafe bool allowedInAllDistricts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInAllDistricts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedInAllDistricts)) = flag;
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

	public unsafe Density densityMinimum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_densityMinimum);
			return *(Density*)num;
		}
		set
		{
			*(Density*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_densityMinimum)) = density;
		}
	}

	public unsafe Density densityMaximum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_densityMaximum);
			return *(Density*)num;
		}
		set
		{
			*(Density*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_densityMaximum)) = density;
		}
	}

	public unsafe LandValue landValueMinimum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValueMinimum);
			return *(LandValue*)num;
		}
		set
		{
			*(LandValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValueMinimum)) = landValue;
		}
	}

	public unsafe LandValue landValueMaximum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValueMaximum);
			return *(LandValue*)num;
		}
		set
		{
			*(LandValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_landValueMaximum)) = landValue;
		}
	}

	public unsafe int minimum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimum)) = num;
		}
	}

	public unsafe int featureImportance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureImportance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureImportance)) = num;
		}
	}

	public unsafe int hardLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardLimit)) = num;
		}
	}

	public unsafe float desiredRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredRatio)) = num;
		}
	}

	public unsafe int modernity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modernity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modernity)) = num;
		}
	}

	public unsafe AddressPreset lobbyPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lobbyPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AddressPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lobbyPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addressPreset));
		}
	}

	public unsafe bool nonEnterable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonEnterable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonEnterable)) = flag;
		}
	}

	public unsafe bool boundary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundary);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundary)) = flag;
		}
	}

	public unsafe bool boundaryCorner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundaryCorner);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundaryCorner)) = flag;
		}
	}

	public unsafe bool overrideNaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideNaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideNaming)) = flag;
		}
	}

	public unsafe List<string> possibleNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool customDrawOnMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDrawOnMap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customDrawOnMap)) = flag;
		}
	}

	public unsafe Texture2D tex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Mesh captureMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Texture2D windowMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D addonMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addonMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addonMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe List<WindowUVFloor> sortedWindows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedWindows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WindowUVFloor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedWindows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int floorCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorCount)) = num;
		}
	}

	public unsafe float meshHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshHeight)) = num;
		}
	}

	public unsafe List<CableLinkPoint> cableLinkPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cableLinkPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CableLinkPoint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cableLinkPoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AnimationCurve cableSpawnChanceOverHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cableSpawnChanceOverHeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cableSpawnChanceOverHeight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe List<CableLinkPoint> sideSignPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideSignPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CableLinkPoint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideSignPoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> possibleNeonSigns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleNeonSigns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleNeonSigns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector2 signsPerBuildingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signsPerBuildingRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signsPerBuildingRange)) = vector;
		}
	}

	public unsafe Vector3 horizontalSignOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSignOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalSignOffset)) = vector;
		}
	}

	public unsafe bool featuresSmokestack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresSmokestack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresSmokestack)) = flag;
		}
	}

	public unsafe Vector2 spawnInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnInterval);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnInterval)) = vector;
		}
	}

	public unsafe GameObject spritePrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spritePrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spritePrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 spawnOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnOffset)) = vector;
		}
	}

	public unsafe Il2CppStructArray<Vector2> offsetArrayX4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetArrayX4);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetArrayX4)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static BuildingPreset()
	{
		Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BuildingPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr);
		NativeFieldInfoPtr_disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "disable");
		NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "prefab");
		NativeFieldInfoPtr_emissionMapUnlit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "emissionMapUnlit");
		NativeFieldInfoPtr_emissionMapLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "emissionMapLit");
		NativeFieldInfoPtr_buildingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "buildingHeight");
		NativeFieldInfoPtr_lightningRodLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "lightningRodLocalPos");
		NativeFieldInfoPtr_defaultExteriorWallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "defaultExteriorWallMaterial");
		NativeFieldInfoPtr_exteriorKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "exteriorKey");
		NativeFieldInfoPtr_enableAlleywayWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "enableAlleywayWalls");
		NativeFieldInfoPtr_enableExteriorQuoins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "enableExteriorQuoins");
		NativeFieldInfoPtr_overrideEvidencePhotoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "overrideEvidencePhotoSettings");
		NativeFieldInfoPtr_relativeCamPhotoPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "relativeCamPhotoPos");
		NativeFieldInfoPtr_relativeCamPhotoEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "relativeCamPhotoEuler");
		NativeFieldInfoPtr_overrideDistrictEnvironment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "overrideDistrictEnvironment");
		NativeFieldInfoPtr_sceneProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "sceneProfile");
		NativeFieldInfoPtr_maxLostAndFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "maxLostAndFound");
		NativeFieldInfoPtr_floorLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "floorLayouts");
		NativeFieldInfoPtr_basementLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "basementLayouts");
		NativeFieldInfoPtr_controlRoomRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "controlRoomRange");
		NativeFieldInfoPtr_forceBuildingDesignStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "forceBuildingDesignStyles");
		NativeFieldInfoPtr_stairwellRegular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "stairwellRegular");
		NativeFieldInfoPtr_stairwellLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "stairwellLarge");
		NativeFieldInfoPtr_buildingFeaturesEchelonFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "buildingFeaturesEchelonFloors");
		NativeFieldInfoPtr_echelonFloorStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "echelonFloorStart");
		NativeFieldInfoPtr_overrideGrubiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "overrideGrubiness");
		NativeFieldInfoPtr_grubinessOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "grubinessOverride");
		NativeFieldInfoPtr_displayedZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "displayedZone");
		NativeFieldInfoPtr_allowedInAllDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "allowedInAllDistricts");
		NativeFieldInfoPtr_allowedInDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "allowedInDistricts");
		NativeFieldInfoPtr_densityMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "densityMinimum");
		NativeFieldInfoPtr_densityMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "densityMaximum");
		NativeFieldInfoPtr_landValueMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "landValueMinimum");
		NativeFieldInfoPtr_landValueMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "landValueMaximum");
		NativeFieldInfoPtr_minimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "minimum");
		NativeFieldInfoPtr_featureImportance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "featureImportance");
		NativeFieldInfoPtr_hardLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "hardLimit");
		NativeFieldInfoPtr_desiredRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "desiredRatio");
		NativeFieldInfoPtr_modernity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "modernity");
		NativeFieldInfoPtr_lobbyPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "lobbyPreset");
		NativeFieldInfoPtr_nonEnterable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "nonEnterable");
		NativeFieldInfoPtr_boundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "boundary");
		NativeFieldInfoPtr_boundaryCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "boundaryCorner");
		NativeFieldInfoPtr_overrideNaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "overrideNaming");
		NativeFieldInfoPtr_possibleNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "possibleNames");
		NativeFieldInfoPtr_customDrawOnMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "customDrawOnMap");
		NativeFieldInfoPtr_tex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "tex");
		NativeFieldInfoPtr_captureMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "captureMesh");
		NativeFieldInfoPtr_windowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "windowMap");
		NativeFieldInfoPtr_addonMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "addonMap");
		NativeFieldInfoPtr_sortedWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "sortedWindows");
		NativeFieldInfoPtr_floorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "floorCount");
		NativeFieldInfoPtr_meshHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "meshHeight");
		NativeFieldInfoPtr_cableLinkPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "cableLinkPoints");
		NativeFieldInfoPtr_cableSpawnChanceOverHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "cableSpawnChanceOverHeight");
		NativeFieldInfoPtr_sideSignPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "sideSignPoints");
		NativeFieldInfoPtr_possibleNeonSigns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "possibleNeonSigns");
		NativeFieldInfoPtr_signsPerBuildingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "signsPerBuildingRange");
		NativeFieldInfoPtr_horizontalSignOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "horizontalSignOffset");
		NativeFieldInfoPtr_featuresSmokestack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "featuresSmokestack");
		NativeFieldInfoPtr_spawnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "spawnInterval");
		NativeFieldInfoPtr_spritePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "spritePrefab");
		NativeFieldInfoPtr_spawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "spawnOffset");
		NativeFieldInfoPtr_offsetArrayX4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, "offsetArrayX4");
		NativeMethodInfoPtr_GenerateWindowData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673815);
		NativeMethodInfoPtr_GenerateAddonData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673816);
		NativeMethodInfoPtr_CalculateMeshHeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673817);
		NativeMethodInfoPtr_UvTo3D_Public_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673818);
		NativeMethodInfoPtr_Area_Public_Single_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673819);
		NativeMethodInfoPtr_GetFloorSetting_Public_InteriorFloorSetting_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673820);
		NativeMethodInfoPtr_GetResidenceCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673821);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr, 100673822);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326985, XrefRangeEnd = 327425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateWindowData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateWindowData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327425, XrefRangeEnd = 327649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateAddonData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateAddonData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327649, XrefRangeEnd = 327662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateMeshHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateMeshHeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 327685, RefRangeEnd = 327690, XrefRangeStart = 327662, XrefRangeEnd = 327685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 UvTo3D(Vector2 uv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uv);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UvTo3D_Public_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float Area(Vector2 p1, Vector2 p2, Vector2 p3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&p1);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Area_Public_Single_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 327691, RefRangeEnd = 327692, XrefRangeStart = 327690, XrefRangeEnd = 327691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteriorFloorSetting GetFloorSetting(int floor, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&floor);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloorSetting_Public_InteriorFloorSetting_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteriorFloorSetting>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 327747, RefRangeEnd = 327748, XrefRangeStart = 327692, XrefRangeEnd = 327747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetResidenceCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResidenceCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327748, XrefRangeEnd = 327805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuildingPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BuildingPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
