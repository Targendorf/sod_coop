using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class FurnitureClass : SoCustomComparison
{
	public enum FurnitureRuleOption
	{
		mustFeature,
		cantFeature,
		canFeature
	}

	public enum WallRule
	{
		nothing,
		wall,
		window,
		windowLarge,
		entrance,
		ventUpper,
		ventLower,
		wallOrUpperVent,
		ventTop,
		entranceDoorOnly,
		entranceToRoomOfType,
		anyWindow,
		entraceDivider,
		securityDoorDivider,
		fence,
		addressEntrance,
		lightswitch
	}

	[System.Serializable]
	public class FurniureWalkSubLocations : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_sublocations;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
			}
		}

		public unsafe List<Vector3> sublocations
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocations);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static FurniureWalkSubLocations()
		{
			Il2CppClassPointerStore<FurniureWalkSubLocations>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "FurniureWalkSubLocations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurniureWalkSubLocations>.NativeClassPtr);
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniureWalkSubLocations>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_sublocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniureWalkSubLocations>.NativeClassPtr, "sublocations");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurniureWalkSubLocations>.NativeClassPtr, 100673913);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328528, RefRangeEnd = 328529, XrefRangeStart = 328521, XrefRangeEnd = 328528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurniureWalkSubLocations()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurniureWalkSubLocations>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FurniureWalkSubLocations(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FurnitureNodeRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_option;

		private static readonly System.IntPtr NativeFieldInfoPtr_anyOccupiedTile;

		private static readonly System.IntPtr NativeFieldInfoPtr_furnitureClass;

		private static readonly System.IntPtr NativeFieldInfoPtr_addScore;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
			}
		}

		public unsafe FurnitureRuleOption option
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option);
				return *(FurnitureRuleOption*)num;
			}
			set
			{
				*(FurnitureRuleOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option)) = furnitureRuleOption;
			}
		}

		public unsafe bool anyOccupiedTile
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyOccupiedTile);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyOccupiedTile)) = flag;
			}
		}

		public unsafe FurnitureClass furnitureClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureClass>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureClass));
			}
		}

		public unsafe int addScore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addScore);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addScore)) = num;
			}
		}

		static FurnitureNodeRule()
		{
			Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "FurnitureNodeRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr);
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr, "option");
			NativeFieldInfoPtr_anyOccupiedTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr, "anyOccupiedTile");
			NativeFieldInfoPtr_furnitureClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr, "furnitureClass");
			NativeFieldInfoPtr_addScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr, "addScore");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr, 100673914);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328529, XrefRangeEnd = 328531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurnitureNodeRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureNodeRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FurnitureNodeRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FurnitureWallRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nodeOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_wallDirection;

		private static readonly System.IntPtr NativeFieldInfoPtr_option;

		private static readonly System.IntPtr NativeFieldInfoPtr_tag;

		private static readonly System.IntPtr NativeFieldInfoPtr_roomType;

		private static readonly System.IntPtr NativeFieldInfoPtr_addScore;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector2 nodeOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeOffset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeOffset)) = vector;
			}
		}

		public unsafe CityData.BlockingDirection wallDirection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallDirection);
				return *(CityData.BlockingDirection*)num;
			}
			set
			{
				*(CityData.BlockingDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallDirection)) = blockingDirection;
			}
		}

		public unsafe FurnitureRuleOption option
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option);
				return *(FurnitureRuleOption*)num;
			}
			set
			{
				*(FurnitureRuleOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option)) = furnitureRuleOption;
			}
		}

		public unsafe WallRule tag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag);
				return *(WallRule*)num;
			}
			set
			{
				*(WallRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag)) = wallRule;
			}
		}

		public unsafe RoomConfiguration roomType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomType);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
			}
		}

		public unsafe int addScore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addScore);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addScore)) = num;
			}
		}

		static FurnitureWallRule()
		{
			Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "FurnitureWallRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr);
			NativeFieldInfoPtr_nodeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr, "nodeOffset");
			NativeFieldInfoPtr_wallDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr, "wallDirection");
			NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr, "option");
			NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr, "tag");
			NativeFieldInfoPtr_roomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr, "roomType");
			NativeFieldInfoPtr_addScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr, "addScore");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr, 100673915);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurnitureWallRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureWallRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FurnitureWallRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class BlockedAccess : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_nodeOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_blockExteriorDiagonals;

		private static readonly System.IntPtr NativeFieldInfoPtr_blocked;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool disabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)) = flag;
			}
		}

		public unsafe Vector2 nodeOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeOffset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeOffset)) = vector;
			}
		}

		public unsafe bool blockExteriorDiagonals
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockExteriorDiagonals);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockExteriorDiagonals)) = flag;
			}
		}

		public unsafe List<CityData.BlockingDirection> blocked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocked);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CityData.BlockingDirection>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static BlockedAccess()
		{
			Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "BlockedAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr);
			NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr, "disabled");
			NativeFieldInfoPtr_nodeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr, "nodeOffset");
			NativeFieldInfoPtr_blockExteriorDiagonals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr, "blockExteriorDiagonals");
			NativeFieldInfoPtr_blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr, "blocked");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr, 100673916);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328539, RefRangeEnd = 328542, XrefRangeStart = 328531, XrefRangeEnd = 328539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockedAccess()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockedAccess>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BlockedAccess(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CustomNodeWeighting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_nodeOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_nodeWeightModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool disabled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)) = flag;
			}
		}

		public unsafe Vector2 nodeOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeOffset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeOffset)) = vector;
			}
		}

		public unsafe float nodeWeightModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeWeightModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeWeightModifier)) = num;
			}
		}

		static CustomNodeWeighting()
		{
			Il2CppClassPointerStore<CustomNodeWeighting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "CustomNodeWeighting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomNodeWeighting>.NativeClassPtr);
			NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomNodeWeighting>.NativeClassPtr, "disabled");
			NativeFieldInfoPtr_nodeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomNodeWeighting>.NativeClassPtr, "nodeOffset");
			NativeFieldInfoPtr_nodeWeightModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomNodeWeighting>.NativeClassPtr, "nodeWeightModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomNodeWeighting>.NativeClassPtr, 100673917);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328542, XrefRangeEnd = 328544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomNodeWeighting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomNodeWeighting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CustomNodeWeighting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class SubObject : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_parent;

		private static readonly System.IntPtr NativeFieldInfoPtr_localPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_localRot;

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

		static SubObject()
		{
			Il2CppClassPointerStore<SubObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "SubObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubObject>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "parent");
			NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "localPos");
			NativeFieldInfoPtr_localRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubObject>.NativeClassPtr, "localRot");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubObject>.NativeClassPtr, 100673918);
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

	public enum OwnershipClass
	{
		none,
		bed,
		desk,
		locker,
		drawers,
		noticeBoard,
		safe,
		mailboxes
	}

	public enum OwnershipSource
	{
		addressInhabitants,
		buildingResidences
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_wallRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockedAccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_customNodeWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_updatePreCalculated;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumZeroNodeWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumZeroNodeWallCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_canFaceDiagonally;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumNumberPerRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumNumberPerAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOnFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitToFloorRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOnFloorRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerBuildingResidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_perBuildingResidences;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitPerJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_perJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_awayFromClasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumNodeDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_tall;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallPiece;

	private static readonly System.IntPtr NativeFieldInfoPtr_useWallSnappingInDecorMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowPiece;

	private static readonly System.IntPtr NativeFieldInfoPtr_occupiesTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOnStairwell;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyOnStairwell;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowIfNoFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingPiece;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresCeiling;

	private static readonly System.IntPtr NativeFieldInfoPtr_blocksCeiling;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowLightswitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_raiseLightswitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitchYOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_noBlocking;

	private static readonly System.IntPtr NativeFieldInfoPtr_noPassThrough;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAccessNeeded;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockDefaultSublocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoreGeometryInPhysicsCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_sublocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiRobberyPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSecurityCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownershipClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownershipSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignBelongsToOwners;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferCouples;

	private static readonly System.IntPtr NativeFieldInfoPtr_copyFromPreviouslyPlacedInCluster;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyPickFromRoomOwners;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipIfNoAddressInhabitants;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignHomelessOwners;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignMailbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_discourageMissionPhotos;

	private static readonly System.IntPtr NativeFieldInfoPtr_copyFrom;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyBlockedAccess_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopySublocations_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlockSolid_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlockAllButFront_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePreCalculatedLimits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<FurnitureWallRule> wallRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureWallRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FurnitureNodeRule> nodeRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureNodeRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BlockedAccess> blockedAccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BlockedAccess>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CustomNodeWeighting> customNodeWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customNodeWeights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CustomNodeWeighting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customNodeWeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool updatePreCalculated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatePreCalculated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatePreCalculated)) = flag;
		}
	}

	public unsafe int minimumZeroNodeWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumZeroNodeWallCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumZeroNodeWallCount)) = num;
		}
	}

	public unsafe int maximumZeroNodeWallCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumZeroNodeWallCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumZeroNodeWallCount)) = num;
		}
	}

	public unsafe bool canFaceDiagonally
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFaceDiagonally);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFaceDiagonally)) = flag;
		}
	}

	public unsafe bool limitPerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerRoom)) = flag;
		}
	}

	public unsafe int maximumNumberPerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumNumberPerRoom);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumNumberPerRoom)) = num;
		}
	}

	public unsafe bool limitPerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerAddress)) = flag;
		}
	}

	public unsafe int maximumNumberPerAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumNumberPerAddress);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumNumberPerAddress)) = num;
		}
	}

	public unsafe bool limitToFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloor)) = flag;
		}
	}

	public unsafe int allowedOnFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloor)) = num;
		}
	}

	public unsafe bool limitToFloorRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloorRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToFloorRange)) = flag;
		}
	}

	public unsafe Vector2 allowedOnFloorRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloorRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnFloorRange)) = vector;
		}
	}

	public unsafe bool limitPerBuildingResidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerBuildingResidence);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerBuildingResidence)) = flag;
		}
	}

	public unsafe int perBuildingResidences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perBuildingResidences);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perBuildingResidences)) = num;
		}
	}

	public unsafe bool limitPerJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerJobs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitPerJobs)) = flag;
		}
	}

	public unsafe int perJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perJobs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perJobs)) = num;
		}
	}

	public unsafe List<FurnitureClass> awayFromClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awayFromClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClass>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awayFromClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float minimumNodeDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumNodeDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumNodeDistance)) = num;
		}
	}

	public unsafe Vector2 objectSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectSize)) = vector;
		}
	}

	public unsafe bool tall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tall);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tall)) = flag;
		}
	}

	public unsafe bool wallPiece
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallPiece);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallPiece)) = flag;
		}
	}

	public unsafe bool useWallSnappingInDecorMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWallSnappingInDecorMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWallSnappingInDecorMode)) = flag;
		}
	}

	public unsafe bool windowPiece
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowPiece);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowPiece)) = flag;
		}
	}

	public unsafe bool occupiesTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupiesTile);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occupiesTile)) = flag;
		}
	}

	public unsafe bool allowedOnStairwell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnStairwell);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOnStairwell)) = flag;
		}
	}

	public unsafe bool onlyOnStairwell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyOnStairwell);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyOnStairwell)) = flag;
		}
	}

	public unsafe bool allowIfNoFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowIfNoFloor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowIfNoFloor)) = flag;
		}
	}

	public unsafe bool ceilingPiece
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingPiece);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingPiece)) = flag;
		}
	}

	public unsafe bool requiresCeiling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresCeiling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresCeiling)) = flag;
		}
	}

	public unsafe bool blocksCeiling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocksCeiling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocksCeiling)) = flag;
		}
	}

	public unsafe bool allowLightswitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLightswitch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLightswitch)) = flag;
		}
	}

	public unsafe bool raiseLightswitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raiseLightswitch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raiseLightswitch)) = flag;
		}
	}

	public unsafe float lightswitchYOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchYOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchYOffset)) = num;
		}
	}

	public unsafe bool noBlocking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noBlocking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noBlocking)) = flag;
		}
	}

	public unsafe bool noPassThrough
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPassThrough);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPassThrough)) = flag;
		}
	}

	public unsafe bool noAccessNeeded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessNeeded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessNeeded)) = flag;
		}
	}

	public unsafe bool blockDefaultSublocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDefaultSublocations);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockDefaultSublocations)) = flag;
		}
	}

	public unsafe bool ignoreGeometryInPhysicsCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreGeometryInPhysicsCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreGeometryInPhysicsCheck)) = flag;
		}
	}

	public unsafe List<FurniureWalkSubLocations> sublocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurniureWalkSubLocations>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int aiRobberyPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiRobberyPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiRobberyPriority)) = num;
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

	public unsafe OwnershipClass ownershipClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipClass);
			return *(OwnershipClass*)num;
		}
		set
		{
			*(OwnershipClass*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipClass)) = ownershipClass;
		}
	}

	public unsafe OwnershipSource ownershipSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipSource);
			return *(OwnershipSource*)num;
		}
		set
		{
			*(OwnershipSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipSource)) = ownershipSource;
		}
	}

	public unsafe int assignBelongsToOwners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignBelongsToOwners);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignBelongsToOwners)) = num;
		}
	}

	public unsafe bool preferCouples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferCouples);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferCouples)) = flag;
		}
	}

	public unsafe bool copyFromPreviouslyPlacedInCluster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFromPreviouslyPlacedInCluster);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFromPreviouslyPlacedInCluster)) = flag;
		}
	}

	public unsafe bool onlyPickFromRoomOwners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyPickFromRoomOwners);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyPickFromRoomOwners)) = flag;
		}
	}

	public unsafe bool skipIfNoAddressInhabitants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfNoAddressInhabitants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfNoAddressInhabitants)) = flag;
		}
	}

	public unsafe bool assignHomelessOwners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignHomelessOwners);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignHomelessOwners)) = flag;
		}
	}

	public unsafe bool assignMailbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignMailbox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignMailbox)) = flag;
		}
	}

	public unsafe bool discourageMissionPhotos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discourageMissionPhotos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discourageMissionPhotos)) = flag;
		}
	}

	public unsafe FurnitureClass copyFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureClass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureClass));
		}
	}

	static FurnitureClass()
	{
		Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FurnitureClass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr);
		NativeFieldInfoPtr_wallRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "wallRules");
		NativeFieldInfoPtr_nodeRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "nodeRules");
		NativeFieldInfoPtr_blockedAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "blockedAccess");
		NativeFieldInfoPtr_customNodeWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "customNodeWeights");
		NativeFieldInfoPtr_updatePreCalculated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "updatePreCalculated");
		NativeFieldInfoPtr_minimumZeroNodeWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "minimumZeroNodeWallCount");
		NativeFieldInfoPtr_maximumZeroNodeWallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "maximumZeroNodeWallCount");
		NativeFieldInfoPtr_canFaceDiagonally = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "canFaceDiagonally");
		NativeFieldInfoPtr_limitPerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "limitPerRoom");
		NativeFieldInfoPtr_maximumNumberPerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "maximumNumberPerRoom");
		NativeFieldInfoPtr_limitPerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "limitPerAddress");
		NativeFieldInfoPtr_maximumNumberPerAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "maximumNumberPerAddress");
		NativeFieldInfoPtr_limitToFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "limitToFloor");
		NativeFieldInfoPtr_allowedOnFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "allowedOnFloor");
		NativeFieldInfoPtr_limitToFloorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "limitToFloorRange");
		NativeFieldInfoPtr_allowedOnFloorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "allowedOnFloorRange");
		NativeFieldInfoPtr_limitPerBuildingResidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "limitPerBuildingResidence");
		NativeFieldInfoPtr_perBuildingResidences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "perBuildingResidences");
		NativeFieldInfoPtr_limitPerJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "limitPerJobs");
		NativeFieldInfoPtr_perJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "perJobs");
		NativeFieldInfoPtr_awayFromClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "awayFromClasses");
		NativeFieldInfoPtr_minimumNodeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "minimumNodeDistance");
		NativeFieldInfoPtr_objectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "objectSize");
		NativeFieldInfoPtr_tall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "tall");
		NativeFieldInfoPtr_wallPiece = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "wallPiece");
		NativeFieldInfoPtr_useWallSnappingInDecorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "useWallSnappingInDecorMode");
		NativeFieldInfoPtr_windowPiece = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "windowPiece");
		NativeFieldInfoPtr_occupiesTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "occupiesTile");
		NativeFieldInfoPtr_allowedOnStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "allowedOnStairwell");
		NativeFieldInfoPtr_onlyOnStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "onlyOnStairwell");
		NativeFieldInfoPtr_allowIfNoFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "allowIfNoFloor");
		NativeFieldInfoPtr_ceilingPiece = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "ceilingPiece");
		NativeFieldInfoPtr_requiresCeiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "requiresCeiling");
		NativeFieldInfoPtr_blocksCeiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "blocksCeiling");
		NativeFieldInfoPtr_allowLightswitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "allowLightswitch");
		NativeFieldInfoPtr_raiseLightswitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "raiseLightswitch");
		NativeFieldInfoPtr_lightswitchYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "lightswitchYOffset");
		NativeFieldInfoPtr_noBlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "noBlocking");
		NativeFieldInfoPtr_noPassThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "noPassThrough");
		NativeFieldInfoPtr_noAccessNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "noAccessNeeded");
		NativeFieldInfoPtr_blockDefaultSublocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "blockDefaultSublocations");
		NativeFieldInfoPtr_ignoreGeometryInPhysicsCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "ignoreGeometryInPhysicsCheck");
		NativeFieldInfoPtr_sublocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "sublocations");
		NativeFieldInfoPtr_aiRobberyPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "aiRobberyPriority");
		NativeFieldInfoPtr_isSecurityCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "isSecurityCamera");
		NativeFieldInfoPtr_ownershipClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "ownershipClass");
		NativeFieldInfoPtr_ownershipSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "ownershipSource");
		NativeFieldInfoPtr_assignBelongsToOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "assignBelongsToOwners");
		NativeFieldInfoPtr_preferCouples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "preferCouples");
		NativeFieldInfoPtr_copyFromPreviouslyPlacedInCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "copyFromPreviouslyPlacedInCluster");
		NativeFieldInfoPtr_onlyPickFromRoomOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "onlyPickFromRoomOwners");
		NativeFieldInfoPtr_skipIfNoAddressInhabitants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "skipIfNoAddressInhabitants");
		NativeFieldInfoPtr_assignHomelessOwners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "assignHomelessOwners");
		NativeFieldInfoPtr_assignMailbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "assignMailbox");
		NativeFieldInfoPtr_discourageMissionPhotos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "discourageMissionPhotos");
		NativeFieldInfoPtr_copyFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, "copyFrom");
		NativeMethodInfoPtr_CopyBlockedAccess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, 100673907);
		NativeMethodInfoPtr_CopySublocations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, 100673908);
		NativeMethodInfoPtr_BlockSolid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, 100673909);
		NativeMethodInfoPtr_BlockAllButFront_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, 100673910);
		NativeMethodInfoPtr_UpdatePreCalculatedLimits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, 100673911);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr, 100673912);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328544, XrefRangeEnd = 328548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyBlockedAccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyBlockedAccess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328548, XrefRangeEnd = 328552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopySublocations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySublocations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328552, XrefRangeEnd = 328578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlockSolid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlockSolid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328578, XrefRangeEnd = 328602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlockAllButFront()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlockAllButFront_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 328633, RefRangeEnd = 328634, XrefRangeStart = 328602, XrefRangeEnd = 328633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePreCalculatedLimits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePreCalculatedLimits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328634, XrefRangeEnd = 328674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FurnitureClass()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureClass>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FurnitureClass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
