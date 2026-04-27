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

public class NewRoom : Controller
{
	[System.Serializable]
	public class RoomDivider : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fromRoom;

		private static readonly System.IntPtr NativeFieldInfoPtr_toRoom;

		private static readonly System.IntPtr NativeFieldInfoPtr_dividerWalls;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe NewRoom fromRoom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromRoom);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
			}
		}

		public unsafe NewRoom toRoom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toRoom);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
			}
		}

		public unsafe List<NewWall> dividerWalls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerWalls);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewWall>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerWalls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static RoomDivider()
		{
			Il2CppClassPointerStore<RoomDivider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "RoomDivider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomDivider>.NativeClassPtr);
			NativeFieldInfoPtr_fromRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomDivider>.NativeClassPtr, "fromRoom");
			NativeFieldInfoPtr_toRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomDivider>.NativeClassPtr, "toRoom");
			NativeFieldInfoPtr_dividerWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomDivider>.NativeClassPtr, "dividerWalls");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomDivider>.NativeClassPtr, 100669114);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoomDivider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomDivider>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public RoomDivider(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class LightZoneData : Il2CppSystem.Object
	{
		public class LightNodeRank : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_node;

			private static readonly System.IntPtr NativeFieldInfoPtr_rank;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe NewNode node
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
				}
			}

			public unsafe float rank
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank);
					return *(float*)num;
				}
				set
				{
					*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank)) = num;
				}
			}

			static LightNodeRank()
			{
				Il2CppClassPointerStore<LightNodeRank>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "LightNodeRank");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightNodeRank>.NativeClassPtr);
				NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightNodeRank>.NativeClassPtr, "node");
				NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightNodeRank>.NativeClassPtr, "rank");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightNodeRank>.NativeClassPtr, 100669120);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LightNodeRank()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightNodeRank>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public LightNodeRank(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[System.Serializable]
		[ObfuscatedName("NewRoom+LightZoneData+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_2;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_3;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FindBestLightPosition_b__15_0_Internal_Boolean_AirDuctSection_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FindBestLightPosition_b__15_1_Internal_Boolean_AirDuctSection_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FindBestLightPosition_b__15_2_Internal_Boolean_FurnitureLocation_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__FindBestLightPosition_b__15_3_Internal_Int32_LightNodeRank_LightNodeRank_0;

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

			public unsafe static Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection> __9__15_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection> __9__15_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<FurnitureLocation> __9__15_2
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FurnitureLocation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Comparison<LightNodeRank> __9__15_3
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<LightNodeRank>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__15_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_0");
				NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_1");
				NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_2");
				NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__15_3");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669122);
				NativeMethodInfoPtr__FindBestLightPosition_b__15_0_Internal_Boolean_AirDuctSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669123);
				NativeMethodInfoPtr__FindBestLightPosition_b__15_1_Internal_Boolean_AirDuctSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669124);
				NativeMethodInfoPtr__FindBestLightPosition_b__15_2_Internal_Boolean_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669125);
				NativeMethodInfoPtr__FindBestLightPosition_b__15_3_Internal_Int32_LightNodeRank_LightNodeRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669126);
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
			public unsafe bool _FindBestLightPosition_b__15_0(AirDuctGroup.AirDuctSection item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindBestLightPosition_b__15_0_Internal_Boolean_AirDuctSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _FindBestLightPosition_b__15_1(AirDuctGroup.AirDuctSection item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindBestLightPosition_b__15_1_Internal_Boolean_AirDuctSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191256, XrefRangeEnd = 191257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindBestLightPosition_b__15_2(FurnitureLocation item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindBestLightPosition_b__15_2_Internal_Boolean_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe int _FindBestLightPosition_b__15_3(LightNodeRank p1, LightNodeRank p2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindBestLightPosition_b__15_3_Internal_Int32_LightNodeRank_LightNodeRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_room;

		private static readonly System.IntPtr NativeFieldInfoPtr_nodeList;

		private static readonly System.IntPtr NativeFieldInfoPtr_centreWorldPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightSpawnPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_centreNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawnedAreaLight;

		private static readonly System.IntPtr NativeFieldInfoPtr_aAdditional;

		private static readonly System.IntPtr NativeFieldInfoPtr_allowLight;

		private static readonly System.IntPtr NativeFieldInfoPtr_bestPosFound;

		private static readonly System.IntPtr NativeFieldInfoPtr_debug;

		private static readonly System.IntPtr NativeFieldInfoPtr_areaLightColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_areaLightBrightness;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NewRoom_List_1_NewNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindBestLightPosition_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateMainLight_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateAreaLight_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAreaLight_Public_Void_0;

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

		public unsafe List<NewNode> nodeList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewNode>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Vector3 centreWorldPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centreWorldPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centreWorldPosition)) = vector;
			}
		}

		public unsafe Vector3 lightSpawnPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightSpawnPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightSpawnPosition)) = vector;
			}
		}

		public unsafe Vector2 worldSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSize);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSize)) = vector;
			}
		}

		public unsafe NewNode centreNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centreNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centreNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe Light spawnedAreaLight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedAreaLight);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedAreaLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
			}
		}

		public unsafe HDAdditionalLightData aAdditional
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aAdditional);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDAdditionalLightData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aAdditional)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hDAdditionalLightData));
			}
		}

		public unsafe bool allowLight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLight);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowLight)) = flag;
			}
		}

		public unsafe bool bestPosFound
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestPosFound);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestPosFound)) = flag;
			}
		}

		public unsafe List<string> debug
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

		public unsafe float areaLightBrightness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightBrightness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaLightBrightness)) = num;
			}
		}

		static LightZoneData()
		{
			Il2CppClassPointerStore<LightZoneData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "LightZoneData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr);
			NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "room");
			NativeFieldInfoPtr_nodeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "nodeList");
			NativeFieldInfoPtr_centreWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "centreWorldPosition");
			NativeFieldInfoPtr_lightSpawnPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "lightSpawnPosition");
			NativeFieldInfoPtr_worldSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "worldSize");
			NativeFieldInfoPtr_centreNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "centreNode");
			NativeFieldInfoPtr_spawnedAreaLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "spawnedAreaLight");
			NativeFieldInfoPtr_aAdditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "aAdditional");
			NativeFieldInfoPtr_allowLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "allowLight");
			NativeFieldInfoPtr_bestPosFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "bestPosFound");
			NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "debug");
			NativeFieldInfoPtr_areaLightColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "areaLightColour");
			NativeFieldInfoPtr_areaLightBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, "areaLightBrightness");
			NativeMethodInfoPtr__ctor_Public_Void_NewRoom_List_1_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, 100669115);
			NativeMethodInfoPtr_FindBestLightPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, 100669116);
			NativeMethodInfoPtr_CreateMainLight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, 100669117);
			NativeMethodInfoPtr_CreateAreaLight_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, 100669118);
			NativeMethodInfoPtr_RemoveAreaLight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr, 100669119);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191350, RefRangeEnd = 191352, XrefRangeStart = 191257, XrefRangeEnd = 191350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightZoneData(NewRoom newRoom, List<NewNode> newNodeList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightZoneData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNodeList);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NewRoom_List_1_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191379, RefRangeEnd = 191381, XrefRangeStart = 191352, XrefRangeEnd = 191379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindBestLightPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBestLightPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191418, RefRangeEnd = 191419, XrefRangeStart = 191381, XrefRangeEnd = 191418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateMainLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMainLight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191419, XrefRangeEnd = 191524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateAreaLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAreaLight_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191540, RefRangeEnd = 191541, XrefRangeStart = 191524, XrefRangeEnd = 191540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAreaLight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAreaLight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LightZoneData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class StaticBatchKey : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_filter;

		private static readonly System.IntPtr NativeFieldInfoPtr_mesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_mat;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_StaticBatchKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StaticBatchKey_StaticBatchKey_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StaticBatchKey_StaticBatchKey_0;

		public unsafe MeshFilter filter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filter);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshFilter));
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

		static StaticBatchKey()
		{
			Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "StaticBatchKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr);
			NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, "filter");
			NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, "mesh");
			NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, "mat");
			NativeMethodInfoPtr_Equals_Public_Boolean_StaticBatchKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, 100669127);
			NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, 100669128);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, 100669129);
			NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StaticBatchKey_StaticBatchKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, 100669130);
			NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StaticBatchKey_StaticBatchKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr, 100669131);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191546, RefRangeEnd = 191548, XrefRangeStart = 191541, XrefRangeEnd = 191546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(StaticBatchKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_StaticBatchKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191548, XrefRangeEnd = 191592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191592, XrefRangeEnd = 191607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191607, XrefRangeEnd = 191608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(StaticBatchKey c1, StaticBatchKey c2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)c1));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)c2));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StaticBatchKey_StaticBatchKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191608, XrefRangeEnd = 191609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(StaticBatchKey c1, StaticBatchKey c2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)c1));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)c2));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StaticBatchKey_StaticBatchKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public StaticBatchKey(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public StaticBatchKey()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticBatchKey>.NativeClassPtr))
		{
		}
	}

	public sealed class PathKey : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_origin;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasHash;

		private static readonly System.IntPtr NativeFieldInfoPtr_hash;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NewNode_NewNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IEquatable_NewRoom_PathKey__Equals_Private_Virtual_Final_New_Boolean_PathKey_0;

		public unsafe NewNode origin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origin);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_origin)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe NewNode destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe bool hasHash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasHash);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasHash)) = flag;
			}
		}

		public unsafe int hash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hash)) = num;
			}
		}

		static PathKey()
		{
			Il2CppClassPointerStore<PathKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "PathKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathKey>.NativeClassPtr);
			NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathKey>.NativeClassPtr, "origin");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathKey>.NativeClassPtr, "destination");
			NativeFieldInfoPtr_hasHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathKey>.NativeClassPtr, "hasHash");
			NativeFieldInfoPtr_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathKey>.NativeClassPtr, "hash");
			NativeMethodInfoPtr__ctor_Public_Void_NewNode_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathKey>.NativeClassPtr, 100669132);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathKey>.NativeClassPtr, 100669133);
			NativeMethodInfoPtr_System_IEquatable_NewRoom_PathKey__Equals_Private_Virtual_Final_New_Boolean_PathKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathKey>.NativeClassPtr, 100669134);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 99872, RefRangeEnd = 99878, XrefRangeStart = 99872, XrefRangeEnd = 99878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathKey(NewNode locOne, NewNode locTwo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathKey>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)locOne);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)locTwo);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NewNode_NewNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191615, RefRangeEnd = 191617, XrefRangeStart = 191609, XrefRangeEnd = 191615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191617, XrefRangeEnd = 191619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_IEquatable_NewRoom_PathKey__Equals(PathKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IEquatable_NewRoom_PathKey__Equals_Private_Virtual_Final_New_Boolean_PathKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public PathKey(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public PathKey()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathKey>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public class CullTreeEntry : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_requiredOpenDoors;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0;

		public unsafe List<int> requiredOpenDoors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredOpenDoors);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredOpenDoors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CullTreeEntry()
		{
			Il2CppClassPointerStore<CullTreeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "CullTreeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullTreeEntry>.NativeClassPtr);
			NativeFieldInfoPtr_requiredOpenDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullTreeEntry>.NativeClassPtr, "requiredOpenDoors");
			NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullTreeEntry>.NativeClassPtr, 100669135);
		}

		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 191619, RefRangeEnd = 191718, XrefRangeStart = 191619, XrefRangeEnd = 191619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CullTreeEntry(List<int> newRequiredDoors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullTreeEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRequiredDoors);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CullTreeEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("NewRoom+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__174_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__199_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__199_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__205_6;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__205_7;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__205_8;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__205_9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__210_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__220_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__248_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetWallMaterialDefault_b__174_0_Internal_Boolean_NewNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddFurniture_b__199_2_Internal_Int32_NewAddress_NewAddress_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddFurniture_b__199_0_Internal_Boolean_FurnitureClass_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__205_6_Internal_Boolean_NewWall_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__205_7_Internal_Boolean_NewWall_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__205_8_Internal_Boolean_NewWall_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__205_9_Internal_Boolean_NewWall_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PickPassword_b__210_0_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetSteam_b__220_0_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetSecondaryLightStatus_b__248_0_Internal_Boolean_Interactable_0;

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

		public unsafe static Il2CppSystem.Func<NewNode, bool> __9__174_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__174_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewNode, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__174_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Comparison<NewAddress> __9__199_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__199_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<NewAddress>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__199_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FurnitureClass> __9__199_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__199_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FurnitureClass>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__199_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewWall> __9__205_6
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__205_6, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewWall>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__205_6, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewWall> __9__205_7
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__205_7, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewWall>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__205_7, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewWall> __9__205_8
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__205_8, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewWall>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__205_8, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewWall> __9__205_9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__205_9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewWall>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__205_9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Human.Trait> __9__210_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__210_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Human.Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__210_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Interactable> __9__220_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__220_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__220_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Interactable> __9__248_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__248_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__248_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__174_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__174_0");
			NativeFieldInfoPtr___9__199_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__199_2");
			NativeFieldInfoPtr___9__199_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__199_0");
			NativeFieldInfoPtr___9__205_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__205_6");
			NativeFieldInfoPtr___9__205_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__205_7");
			NativeFieldInfoPtr___9__205_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__205_8");
			NativeFieldInfoPtr___9__205_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__205_9");
			NativeFieldInfoPtr___9__210_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__210_0");
			NativeFieldInfoPtr___9__220_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__220_0");
			NativeFieldInfoPtr___9__248_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__248_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669137);
			NativeMethodInfoPtr__SetWallMaterialDefault_b__174_0_Internal_Boolean_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669138);
			NativeMethodInfoPtr__AddFurniture_b__199_2_Internal_Int32_NewAddress_NewAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669139);
			NativeMethodInfoPtr__AddFurniture_b__199_0_Internal_Boolean_FurnitureClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669140);
			NativeMethodInfoPtr__AddRandomAirVent_b__205_6_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669141);
			NativeMethodInfoPtr__AddRandomAirVent_b__205_7_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669142);
			NativeMethodInfoPtr__AddRandomAirVent_b__205_8_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669143);
			NativeMethodInfoPtr__AddRandomAirVent_b__205_9_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669144);
			NativeMethodInfoPtr__PickPassword_b__210_0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669145);
			NativeMethodInfoPtr__SetSteam_b__220_0_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669146);
			NativeMethodInfoPtr__GetSecondaryLightStatus_b__248_0_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100669147);
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
		public unsafe bool _SetWallMaterialDefault_b__174_0(NewNode item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetWallMaterialDefault_b__174_0_Internal_Boolean_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191718, XrefRangeEnd = 191720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _AddFurniture_b__199_2(NewAddress p1, NewAddress p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddFurniture_b__199_2_Internal_Int32_NewAddress_NewAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddFurniture_b__199_0(FurnitureClass item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddFurniture_b__199_0_Internal_Boolean_FurnitureClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__205_6(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__205_6_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__205_7(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__205_7_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__205_8(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__205_8_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__205_9(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__205_9_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191720, XrefRangeEnd = 191724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickPassword_b__210_0(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PickPassword_b__210_0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _SetSteam_b__220_0(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetSteam_b__220_0_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GetSecondaryLightStatus_b__248_0(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetSecondaryLightStatus_b__248_0_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass182_0")]
	public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fromNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_toNode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddEntrance_b__0_Internal_Boolean_NodeAccess_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddEntrance_b__1_Internal_Boolean_NewWall_0;

		public unsafe NewNode fromNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe NewNode toNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		static __c__DisplayClass182_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass182_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr);
			NativeFieldInfoPtr_fromNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr, "fromNode");
			NativeFieldInfoPtr_toNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr, "toNode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr, 100669148);
			NativeMethodInfoPtr__AddEntrance_b__0_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr, 100669149);
			NativeMethodInfoPtr__AddEntrance_b__1_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr, 100669150);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass182_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass182_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddEntrance_b__0(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddEntrance_b__0_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddEntrance_b__1(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddEntrance_b__1_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass182_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass183_0")]
	public sealed class __c__DisplayClass183_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fromNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_toNode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveEntrance_b__0_Internal_Boolean_NodeAccess_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveEntrance_b__1_Internal_Boolean_NodeAccess_0;

		public unsafe NewNode fromNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe NewNode toNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		static __c__DisplayClass183_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass183_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr);
			NativeFieldInfoPtr_fromNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr, "fromNode");
			NativeFieldInfoPtr_toNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr, "toNode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr, 100669151);
			NativeMethodInfoPtr__RemoveEntrance_b__0_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr, 100669152);
			NativeMethodInfoPtr__RemoveEntrance_b__1_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr, 100669153);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass183_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass183_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _RemoveEntrance_b__0(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveEntrance_b__0_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _RemoveEntrance_b__1(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveEntrance_b__1_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass183_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass192_0")]
	public sealed class __c__DisplayClass192_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_v2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ConnectNodes_b__0_Internal_Boolean_NewWall_0;

		public unsafe Vector2Int v2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2)) = vector2Int;
			}
		}

		static __c__DisplayClass192_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass192_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr);
			NativeFieldInfoPtr_v2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr, "v2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr, 100669154);
			NativeMethodInfoPtr__ConnectNodes_b__0_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr, 100669155);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass192_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ConnectNodes_b__0(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ConnectNodes_b__0_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass192_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass192_1")]
	public sealed class __c__DisplayClass192_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_offset1;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ConnectNodes_b__1_Internal_Boolean_NewWall_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ConnectNodes_b__2_Internal_Boolean_NewWall_0;

		public unsafe Vector2 offset1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset1);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset1)) = vector;
			}
		}

		public unsafe Vector2 offset2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset2);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset2)) = vector;
			}
		}

		static __c__DisplayClass192_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass192_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr);
			NativeFieldInfoPtr_offset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, "offset1");
			NativeFieldInfoPtr_offset2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, "offset2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, 100669156);
			NativeMethodInfoPtr__ConnectNodes_b__1_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, 100669157);
			NativeMethodInfoPtr__ConnectNodes_b__2_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, 100669158);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass192_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ConnectNodes_b__1(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ConnectNodes_b__1_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ConnectNodes_b__2(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ConnectNodes_b__2_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass192_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass195_0")]
	public sealed class __c__DisplayClass195_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_worldPos;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SpawnDebugCullingObject_b__0_Internal_Boolean_CullingDebugController_0;

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

		static __c__DisplayClass195_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass195_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr);
			NativeFieldInfoPtr_worldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, "worldPos");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, 100669159);
			NativeMethodInfoPtr__SpawnDebugCullingObject_b__0_Internal_Boolean_CullingDebugController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, 100669160);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass195_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191724, XrefRangeEnd = 191728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SpawnDebugCullingObject_b__0(CullingDebugController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SpawnDebugCullingObject_b__0_Internal_Boolean_CullingDebugController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass195_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass199_0")]
	public sealed class __c__DisplayClass199_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_obj;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddFurniture_b__1_Internal_Boolean_FurnitureLocation_0;

		public unsafe FurnitureLocation obj
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureLocation));
			}
		}

		static __c__DisplayClass199_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass199_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass199_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass199_0>.NativeClassPtr);
			NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass199_0>.NativeClassPtr, "obj");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_0>.NativeClassPtr, 100669161);
			NativeMethodInfoPtr__AddFurniture_b__1_Internal_Boolean_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_0>.NativeClassPtr, 100669162);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass199_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass199_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddFurniture_b__1(FurnitureLocation item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddFurniture_b__1_Internal_Boolean_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass199_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass199_1")]
	public sealed class __c__DisplayClass199_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_h;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddFurniture_b__3_Internal_Boolean_Human_0;

		public unsafe Human h
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		static __c__DisplayClass199_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass199_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass199_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass199_1>.NativeClassPtr);
			NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass199_1>.NativeClassPtr, "h");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_1>.NativeClassPtr, 100669163);
			NativeMethodInfoPtr__AddFurniture_b__3_Internal_Boolean_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_1>.NativeClassPtr, 100669164);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass199_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass199_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191728, XrefRangeEnd = 191735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AddFurniture_b__3(Human item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddFurniture_b__3_Internal_Boolean_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass199_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass199_2")]
	public sealed class __c__DisplayClass199_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_human;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddFurniture_b__4_Internal_Boolean_IntegratedInteractable_0;

		public unsafe Human human
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		static __c__DisplayClass199_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass199_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass199_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass199_2>.NativeClassPtr);
			NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass199_2>.NativeClassPtr, "human");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_2>.NativeClassPtr, 100669165);
			NativeMethodInfoPtr__AddFurniture_b__4_Internal_Boolean_IntegratedInteractable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_2>.NativeClassPtr, 100669166);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass199_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass199_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddFurniture_b__4(FurniturePreset.IntegratedInteractable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddFurniture_b__4_Internal_Boolean_IntegratedInteractable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass199_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass199_3")]
	public sealed class __c__DisplayClass199_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rotatedWallOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddFurniture_b__5_Internal_Boolean_NewWall_0;

		public unsafe Vector2 rotatedWallOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotatedWallOffset);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotatedWallOffset)) = vector;
			}
		}

		static __c__DisplayClass199_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass199_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass199_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass199_3>.NativeClassPtr);
			NativeFieldInfoPtr_rotatedWallOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass199_3>.NativeClassPtr, "rotatedWallOffset");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_3>.NativeClassPtr, 100669167);
			NativeMethodInfoPtr__AddFurniture_b__5_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass199_3>.NativeClassPtr, 100669168);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass199_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass199_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddFurniture_b__5(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddFurniture_b__5_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass199_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass205_0")]
	public sealed class __c__DisplayClass205_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_node;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__0_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__1_Internal_Boolean_AirVent_0;

		public unsafe NewNode node
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		static __c__DisplayClass205_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass205_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass205_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass205_0>.NativeClassPtr);
			NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass205_0>.NativeClassPtr, "node");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_0>.NativeClassPtr, 100669169);
			NativeMethodInfoPtr__AddRandomAirVent_b__0_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_0>.NativeClassPtr, 100669170);
			NativeMethodInfoPtr__AddRandomAirVent_b__1_Internal_Boolean_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_0>.NativeClassPtr, 100669171);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass205_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass205_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__0(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__0_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__1(AirDuctGroup.AirVent item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__1_Internal_Boolean_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass205_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass205_1")]
	public sealed class __c__DisplayClass205_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wall;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__2_Internal_Boolean_AirVent_0;

		public unsafe NewWall wall
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wall);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewWall>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newWall));
			}
		}

		static __c__DisplayClass205_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass205_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass205_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass205_1>.NativeClassPtr);
			NativeFieldInfoPtr_wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass205_1>.NativeClassPtr, "wall");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_1>.NativeClassPtr, 100669172);
			NativeMethodInfoPtr__AddRandomAirVent_b__2_Internal_Boolean_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_1>.NativeClassPtr, 100669173);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass205_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass205_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__2(AirDuctGroup.AirVent item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__2_Internal_Boolean_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass205_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass205_2")]
	public sealed class __c__DisplayClass205_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wall;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__3_Internal_Boolean_AirVent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__4_Internal_Boolean_AirVent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddRandomAirVent_b__5_Internal_Boolean_AirVent_0;

		public unsafe NewWall wall
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wall);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewWall>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newWall));
			}
		}

		static __c__DisplayClass205_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass205_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr);
			NativeFieldInfoPtr_wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr, "wall");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr, 100669174);
			NativeMethodInfoPtr__AddRandomAirVent_b__3_Internal_Boolean_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr, 100669175);
			NativeMethodInfoPtr__AddRandomAirVent_b__4_Internal_Boolean_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr, 100669176);
			NativeMethodInfoPtr__AddRandomAirVent_b__5_Internal_Boolean_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr, 100669177);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass205_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass205_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__3(AirDuctGroup.AirVent item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__3_Internal_Boolean_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__4(AirDuctGroup.AirVent item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__4_Internal_Boolean_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AddRandomAirVent_b__5(AirDuctGroup.AirVent item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddRandomAirVent_b__5_Internal_Boolean_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass205_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewRoom+<>c__DisplayClass252_0")]
	public sealed class __c__DisplayClass252_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ls;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteLightswitchesOverrides_b__0_Internal_Boolean_Interactable_0;

		public unsafe StateSaveData.ChangedLightswitch ls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateSaveData.ChangedLightswitch>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)changedLightswitch));
			}
		}

		static __c__DisplayClass252_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass252_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "<>c__DisplayClass252_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass252_0>.NativeClassPtr);
			NativeFieldInfoPtr_ls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass252_0>.NativeClassPtr, "ls");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass252_0>.NativeClassPtr, 100669178);
			NativeMethodInfoPtr__ExecuteLightswitchesOverrides_b__0_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass252_0>.NativeClassPtr, 100669179);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass252_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass252_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ExecuteLightswitchesOverrides_b__0(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ExecuteLightswitchesOverrides_b__0_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass252_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_building;

	private static readonly System.IntPtr NativeFieldInfoPtr_floor;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowerRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureAssignID;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactableAssignID;

	private static readonly System.IntPtr NativeFieldInfoPtr_contentsParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_openPlanElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_entrances;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomDividers;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightZones;

	private static readonly System.IntPtr NativeFieldInfoPtr_middleRoomPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_commonRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentOccupants;

	private static readonly System.IntPtr NativeFieldInfoPtr_streetObjectContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_tamperedInteractables;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAccessNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeConversations;

	private static readonly System.IntPtr NativeFieldInfoPtr_windows;

	private static readonly System.IntPtr NativeFieldInfoPtr_audibleLoopingSounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_heatSources;

	private static readonly System.IntPtr NativeFieldInfoPtr_pipes;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitchOverrides;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomFloorID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignRoomFloorID;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignRoomID;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignWallID;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomType;

	private static readonly System.IntPtr NativeFieldInfoPtr_preset;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_calculatedWorldPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_boundsSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_geometryLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_reachableFromEntrance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOutsideWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNullRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBaseNullRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_featuresStairwell;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueCeilingMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsDead;

	private static readonly System.IntPtr NativeFieldInfoPtr_decorEdit;

	private static readonly System.IntPtr NativeFieldInfoPtr_isVisible;

	private static readonly System.IntPtr NativeFieldInfoPtr_musicPlaying;

	private static readonly System.IntPtr NativeFieldInfoPtr_musicStartedAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowCoving;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorMatKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMatKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultWallMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultWallKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasBeenDecorated;

	private static readonly System.IntPtr NativeFieldInfoPtr_miscKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_colourScheme;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainLightPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainLightStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitches;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitchInteractables;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondaryLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_enabledLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowsWithUVData;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingFans;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideData;

	private static readonly System.IntPtr NativeFieldInfoPtr_actorUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingTree;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorCheckSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonAudioOccludedRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_openDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_closedDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_adjacentRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_aboveRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_belowRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_atriumTop;

	private static readonly System.IntPtr NativeFieldInfoPtr_atriumRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedWalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedWallRend;

	private static readonly System.IntPtr NativeFieldInfoPtr_additionalWalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedFloorRend;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedCeiling;

	private static readonly System.IntPtr NativeFieldInfoPtr_combinedCeilingRend;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientSoundLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_ct;

	private static readonly System.IntPtr NativeFieldInfoPtr_above;

	private static readonly System.IntPtr NativeFieldInfoPtr_below;

	private static readonly System.IntPtr NativeFieldInfoPtr_adj;

	private static readonly System.IntPtr NativeFieldInfoPtr_occ;

	private static readonly System.IntPtr NativeFieldInfoPtr_furniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_individualFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticBatchDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticBatchedGeneratedMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickFurnitureCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_localizedRoomNodeMaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprintUpdateQueued;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedFootprints;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockedAccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialCaseInteractables;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadBelongsTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_belongsTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_explorationLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_airVents;

	private static readonly System.IntPtr NativeFieldInfoPtr_ductGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_passcode;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatter;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamControllingInteractables;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamLastSwitched;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamController;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedBugs;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRoomGassed;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugController;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpdateEmission;

	private static readonly System.IntPtr NativeFieldInfoPtr_completedTreeCull;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLightswitches;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingDebugLoadReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnPathDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_specificRoomCullingDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadedCullTreeFromSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainLightObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugDecor;

	private static readonly System.IntPtr NativeFieldInfoPtr_exteriorWindowDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugAddActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_clustersPlaced;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsPlaced;

	private static readonly System.IntPtr NativeFieldInfoPtr_poolSizeOnPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey1;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey2;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey3;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey4;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey5;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey51;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey52;

	private static readonly System.IntPtr NativeFieldInfoPtr_palcementKey6;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyAtStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_sublocationParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_sublocationDebugObjects;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IEquatable_NewRoom__Equals_Private_Virtual_Final_New_Boolean_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowTint_Public_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupLayoutOnly_Public_Void_NewGameLocation_RoomTypePreset_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAll_Public_Void_NewGameLocation_RoomConfiguration_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConfiguration_Public_Void_RoomConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetType_Public_Void_RoomTypePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_RoomCitySave_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCullingTree_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateColourSchemeAndMaterials_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewNode_Public_Void_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRoomName_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNode_Public_Void_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWorldPositionAndBoundsSize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOpenPlanElement_Public_Void_RoomConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloorMaterial_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCeilingMaterial_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWallMaterialDefault_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleMainLights_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMainLights_Public_Void_Boolean_String_Actor_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSecondaryLight_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEmissionEndOfFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEmissionTex_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMainLight_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSecondaryLight_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEntrance_Public_Void_NewNode_NewNode_Boolean_AccessType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEntrance_Public_Void_NewNode_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRoomStuff_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddForStaticBatching_Public_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddForStaticBatching_Public_Void_GameObject_MeshFilter_Mesh_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteStaticBatching_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueFootprintUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFootprints_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLight_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConnectNodes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBlockedAccess_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCullingTree_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnDebugCullingObject_Private_Void_Vector3_NewRoom_NodeAccess_List_1_Int32_CullDebugType_NewRoom_NodeAccess_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLowerRoom_Public_Void_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFurniture_Public_Void_FurnitureClusterLocation_Boolean_Boolean_Boolean_Boolean_DesignStylePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFurnitureCustom_Public_FurnitureLocation_FurniturePlacement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFurnitureCustom_Public_FurnitureLocation_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFurnitureBlockedAccess_Public_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCustomNodeWeights_Public_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFOVBlock_Private_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRandomAirVent_Public_Boolean_AirVent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadVent_Private_Void_AirVent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDuctGroup_Public_Void_AirDuctGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOwner_Public_Void_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadOwners_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickPassword_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEnvrionment_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExplorationLevel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestForDynamicShadowsUpdate_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSaveData_Public_RoomCitySave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomNode_Public_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomEntranceNode_Public_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAccessAllowed_Public_Boolean_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllInhabitantFurniture_Public_Void_Boolean_RemoveInteractablesOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSteam_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOutside_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdjacentRooms_Public_List_1_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAboveRooms_Public_List_1_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBelowRooms_Public_List_1_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAboveAndBelowRooms_Public_List_1_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplaySublocations_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSublocationsDisplay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugTeleportPlayerToLocation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugCullingDisplay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainLightData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleExteriorWindowDebug_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestFurniturePlacementBlockingCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestFurniturePlacementBlockingCheckIgnoreNoPassthrough_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayNodePositions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNodePositions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWallCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAIActions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractables_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListContainedInteractables_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListActionReferences_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnvironment_Public_SceneProfile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGas_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildCullingTree_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsThisOutside_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnModularRoomElements_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListLoadedFurniture_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadRoomGeometry_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSecondaryLightStatus_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadRoomGeometry_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshGenerationCachePriority_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoomCullingCachePriority_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteLightswitchesOverrides_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListCurrentOccupants_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GenerateCullingTree_b__194_0_Private_Boolean_NodeAccess_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RemoveAllInhabitantFurniture_b__219_0_Private_Boolean_Interactable_0;

	public new unsafe string name
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

	public unsafe NewBuilding building
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewBuilding>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newBuilding));
		}
	}

	public unsafe NewFloor floor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewFloor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFloor));
		}
	}

	public unsafe NewGameLocation gameLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLocation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLocation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGameLocation));
		}
	}

	public unsafe NewRoom lowerRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe int furnitureAssignID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureAssignID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureAssignID)) = num;
		}
	}

	public unsafe int interactableAssignID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableAssignID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableAssignID)) = num;
		}
	}

	public unsafe GameObject contentsParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentsParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentsParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe HashSet<NewNode> nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<RoomConfiguration> openPlanElements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openPlanElements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openPlanElements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<NewNode.NodeAccess> entrances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entrances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewNode.NodeAccess>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entrances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RoomDivider> roomDividers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomDivider>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomDividers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LightZoneData> lightZones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightZones);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LightZoneData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightZones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector3 middleRoomPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleRoomPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleRoomPosition)) = vector;
		}
	}

	public unsafe List<NewRoom> commonRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<Actor> currentOccupants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOccupants);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Actor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOccupants)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe GameObject streetObjectContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetObjectContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetObjectContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe HashSet<Interactable> tamperedInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperedInteractables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperedInteractables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<NewNode> noAccessNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessNodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<Interactable> worldObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<Human.ConversationInstance> activeConversations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeConversations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.ConversationInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeConversations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<NewWall> windows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewWall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AudioController.LoopingSoundInfo> audibleLoopingSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audibleLoopingSounds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AudioController.LoopingSoundInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audibleLoopingSounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<FurniturePreset.FurnitureGroup, int> furnitureGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureGroups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<FurniturePreset.FurnitureGroup, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureGroups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Interactable> heatSources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heatSources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heatSources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe List<StateSaveData.ChangedLightswitch> lightswitchOverrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchOverrides);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StateSaveData.ChangedLightswitch>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchOverrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int roomFloorID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomFloorID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomFloorID)) = num;
		}
	}

	public unsafe static int assignRoomFloorID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assignRoomFloorID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assignRoomFloorID, (void*)(&num));
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

	public unsafe static int assignRoomID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assignRoomID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assignRoomID, (void*)(&num));
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

	public unsafe int assignWallID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignWallID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignWallID)) = num;
		}
	}

	public unsafe RoomTypePreset roomType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomTypePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomTypePreset));
		}
	}

	public unsafe RoomConfiguration preset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
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

	public unsafe bool calculatedWorldPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedWorldPos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calculatedWorldPos)) = flag;
		}
	}

	public unsafe Vector2 boundsSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundsSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundsSize)) = vector;
		}
	}

	public unsafe bool geometryLoaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometryLoaded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometryLoaded)) = flag;
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

	public unsafe bool isNullRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNullRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNullRoom)) = flag;
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

	public unsafe bool featuresStairwell
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresStairwell);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresStairwell)) = flag;
		}
	}

	public unsafe bool uniqueCeilingMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueCeilingMaterial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueCeilingMaterial)) = flag;
		}
	}

	public unsafe bool containsDead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsDead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsDead)) = flag;
		}
	}

	public unsafe bool decorEdit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorEdit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorEdit)) = flag;
		}
	}

	public unsafe bool isVisible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isVisible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isVisible)) = flag;
		}
	}

	public unsafe bool musicPlaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicPlaying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicPlaying)) = flag;
		}
	}

	public unsafe float musicStartedAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicStartedAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_musicStartedAt)) = num;
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

	public unsafe MaterialGroupPreset floorMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
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

	public unsafe Material floorMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe MaterialGroupPreset ceilingMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
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

	public unsafe Material ceilingMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe MaterialGroupPreset defaultWallMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
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

	public unsafe Material wallMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe bool hasBeenDecorated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBeenDecorated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBeenDecorated)) = flag;
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

	public unsafe ColourSchemePreset colourScheme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourScheme);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColourSchemePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourScheme)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colourSchemePreset));
		}
	}

	public unsafe RoomLightingPreset mainLightPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomLightingPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomLightingPreset));
		}
	}

	public unsafe bool mainLightStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightStatus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightStatus)) = flag;
		}
	}

	public unsafe List<NewWall> lightswitches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitches);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewWall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitches)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> lightswitchInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchInteractables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchInteractables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> mainLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> secondaryLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryLights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryLights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool enabledLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabledLights);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enabledLights)) = flag;
		}
	}

	public unsafe List<NewWall> windowsWithUVData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowsWithUVData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewWall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowsWithUVData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int ceilingFans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingFans);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingFans)) = num;
		}
	}

	public unsafe List<GenerationController.OverrideData> overrideData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GenerationController.OverrideData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool actorUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorUpdate)) = flag;
		}
	}

	public unsafe Dictionary<NewRoom, List<CullTreeEntry>> cullingTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingTree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewRoom, List<CullTreeEntry>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingTree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<int> doorCheckSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheckSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheckSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<NewRoom> nonAudioOccludedRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonAudioOccludedRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonAudioOccludedRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<NewDoor> openDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewDoor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<NewDoor> closedDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedDoors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewDoor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedDoors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<NewRoom> adjacentRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjacentRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjacentRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<NewRoom> aboveRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aboveRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aboveRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<NewRoom> belowRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belowRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belowRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe NewRoom atriumTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atriumTop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atriumTop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe List<NewRoom> atriumRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atriumRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atriumRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject combinedWalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedWalls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedWalls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe MeshRenderer combinedWallRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedWallRend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedWallRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe Dictionary<NewBuilding, GameObject> additionalWalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalWalls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewBuilding, GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalWalls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameObject combinedFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedFloor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedFloor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe MeshRenderer combinedFloorRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedFloorRend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedFloorRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe GameObject combinedCeiling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedCeiling);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedCeiling)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe MeshRenderer combinedCeilingRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedCeilingRend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedCeilingRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe int ambientSoundLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientSoundLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientSoundLevel)) = num;
		}
	}

	public unsafe List<CitySaveData.CullTreeSave> ct
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ct);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitySaveData.CullTreeSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ct)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe List<FurnitureClusterLocation> furniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureClusterLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FurnitureLocation> individualFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_individualFurniture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_individualFurniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<StaticBatchKey, List<GameObject>> staticBatchDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticBatchDictionary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StaticBatchKey, List<GameObject>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticBatchDictionary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Mesh> staticBatchedGeneratedMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticBatchedGeneratedMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Mesh>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticBatchedGeneratedMeshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<FurnitureClass, List<FurniturePreset>> pickFurnitureCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickFurnitureCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<FurnitureClass, List<FurniturePreset>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickFurnitureCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Vector3, NewNode> localizedRoomNodeMaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedRoomNodeMaps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector3, NewNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedRoomNodeMaps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool footprintUpdateQueued
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintUpdateQueued);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprintUpdateQueued)) = flag;
		}
	}

	public unsafe List<FootprintController> spawnedFootprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedFootprints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FootprintController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedFootprints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<NewNode, List<NewNode>> blockedAccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewNode, List<NewNode>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedAccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<AIActionPreset, List<Interactable>> actionReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AIActionPreset, List<Interactable>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InteractablePreset.SpecialCase, List<Interactable>> specialCaseInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCaseInteractables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InteractablePreset.SpecialCase, List<Interactable>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCaseInteractables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<int> loadBelongsTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadBelongsTo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadBelongsTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Human> belongsTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int explorationLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explorationLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explorationLevel)) = num;
		}
	}

	public unsafe List<RectTransform> mapDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapDoors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapDoors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AirDuctGroup.AirVent> airVents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AirDuctGroup.AirVent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airVents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AirDuctGroup> ductGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductGroups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AirDuctGroup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductGroups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe List<SpatterSimulation> spatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpatterSimulation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> steamControllingInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamControllingInteractables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamControllingInteractables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool steamOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamOn)) = flag;
		}
	}

	public unsafe float steamLastSwitched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamLastSwitched);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamLastSwitched)) = num;
		}
	}

	public unsafe SteamController steamController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SteamController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamController));
		}
	}

	public unsafe List<BugController> spawnedBugs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedBugs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BugController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedBugs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float gasLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasLevel)) = num;
		}
	}

	public unsafe float lastRoomGassed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRoomGassed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRoomGassed)) = num;
		}
	}

	public unsafe GenerationDebugController debugController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenerationDebugController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)generationDebugController));
		}
	}

	public unsafe Il2CppSystem.Action UpdateEmission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateEmission);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateEmission)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe bool completedTreeCull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedTreeCull);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedTreeCull)) = flag;
		}
	}

	public unsafe List<string> debugLightswitches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLightswitches);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLightswitches)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int cullingDebugLoadReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingDebugLoadReference);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingDebugLoadReference)) = num;
		}
	}

	public unsafe List<CullingDebugController> spawnPathDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPathDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CullingDebugController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPathDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string debugCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCulling);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCulling)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe NewRoom specificRoomCullingDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificRoomCullingDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificRoomCullingDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe bool loadedCullTreeFromSave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedCullTreeFromSave);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedCullTreeFromSave)) = flag;
		}
	}

	public unsafe List<InteractableController> mainLightObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractableController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainLightObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> debugDecor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDecor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDecor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> exteriorWindowDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorWindowDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorWindowDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> nodeDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> debugAddActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugAddActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugAddActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string clustersPlaced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clustersPlaced);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clustersPlaced)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemsPlaced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsPlaced);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsPlaced)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int poolSizeOnPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolSizeOnPlacement);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolSizeOnPlacement)) = num;
		}
	}

	public unsafe string palcementKey1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string palcementKey2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string palcementKey3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey3);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey3)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string palcementKey4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey4);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey4)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string palcementKey5
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey5);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey5)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string palcementKey51
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey51);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey51)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string palcementKey52
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey52);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey52)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string palcementKey6
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey6);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_palcementKey6)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string keyAtStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyAtStart);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyAtStart)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe GameObject sublocationParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocationParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocationParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<GameObject> sublocationDebugObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocationDebugObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sublocationDebugObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static NewRoom()
	{
		Il2CppClassPointerStore<NewRoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NewRoom");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewRoom>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "name");
		NativeFieldInfoPtr_building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "building");
		NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "floor");
		NativeFieldInfoPtr_gameLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "gameLocation");
		NativeFieldInfoPtr_lowerRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "lowerRoom");
		NativeFieldInfoPtr_furnitureAssignID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "furnitureAssignID");
		NativeFieldInfoPtr_interactableAssignID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "interactableAssignID");
		NativeFieldInfoPtr_contentsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "contentsParent");
		NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "nodes");
		NativeFieldInfoPtr_openPlanElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "openPlanElements");
		NativeFieldInfoPtr_entrances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "entrances");
		NativeFieldInfoPtr_roomDividers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "roomDividers");
		NativeFieldInfoPtr_lightZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "lightZones");
		NativeFieldInfoPtr_middleRoomPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "middleRoomPosition");
		NativeFieldInfoPtr_commonRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "commonRooms");
		NativeFieldInfoPtr_currentOccupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "currentOccupants");
		NativeFieldInfoPtr_streetObjectContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "streetObjectContainer");
		NativeFieldInfoPtr_tamperedInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "tamperedInteractables");
		NativeFieldInfoPtr_noAccessNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "noAccessNodes");
		NativeFieldInfoPtr_worldObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "worldObjects");
		NativeFieldInfoPtr_activeConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "activeConversations");
		NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "windows");
		NativeFieldInfoPtr_audibleLoopingSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "audibleLoopingSounds");
		NativeFieldInfoPtr_furnitureGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "furnitureGroups");
		NativeFieldInfoPtr_heatSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "heatSources");
		NativeFieldInfoPtr_pipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "pipes");
		NativeFieldInfoPtr_lightswitchOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "lightswitchOverrides");
		NativeFieldInfoPtr_roomFloorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "roomFloorID");
		NativeFieldInfoPtr_assignRoomFloorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "assignRoomFloorID");
		NativeFieldInfoPtr_roomID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "roomID");
		NativeFieldInfoPtr_assignRoomID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "assignRoomID");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_assignWallID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "assignWallID");
		NativeFieldInfoPtr_roomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "roomType");
		NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "preset");
		NativeFieldInfoPtr_worldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "worldPos");
		NativeFieldInfoPtr_calculatedWorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "calculatedWorldPos");
		NativeFieldInfoPtr_boundsSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "boundsSize");
		NativeFieldInfoPtr_geometryLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "geometryLoaded");
		NativeFieldInfoPtr_reachableFromEntrance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "reachableFromEntrance");
		NativeFieldInfoPtr_isOutsideWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "isOutsideWindow");
		NativeFieldInfoPtr_isNullRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "isNullRoom");
		NativeFieldInfoPtr_isBaseNullRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "isBaseNullRoom");
		NativeFieldInfoPtr_featuresStairwell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "featuresStairwell");
		NativeFieldInfoPtr_uniqueCeilingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "uniqueCeilingMaterial");
		NativeFieldInfoPtr_containsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "containsDead");
		NativeFieldInfoPtr_decorEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "decorEdit");
		NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "isVisible");
		NativeFieldInfoPtr_musicPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "musicPlaying");
		NativeFieldInfoPtr_musicStartedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "musicStartedAt");
		NativeFieldInfoPtr_allowCoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "allowCoving");
		NativeFieldInfoPtr_floorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "floorMaterial");
		NativeFieldInfoPtr_floorMatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "floorMatKey");
		NativeFieldInfoPtr_floorMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "floorMat");
		NativeFieldInfoPtr_ceilingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "ceilingMaterial");
		NativeFieldInfoPtr_ceilingMatKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "ceilingMatKey");
		NativeFieldInfoPtr_ceilingMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "ceilingMat");
		NativeFieldInfoPtr_defaultWallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "defaultWallMaterial");
		NativeFieldInfoPtr_defaultWallKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "defaultWallKey");
		NativeFieldInfoPtr_wallMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "wallMat");
		NativeFieldInfoPtr_hasBeenDecorated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "hasBeenDecorated");
		NativeFieldInfoPtr_miscKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "miscKey");
		NativeFieldInfoPtr_colourScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "colourScheme");
		NativeFieldInfoPtr_mainLightPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "mainLightPreset");
		NativeFieldInfoPtr_mainLightStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "mainLightStatus");
		NativeFieldInfoPtr_lightswitches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "lightswitches");
		NativeFieldInfoPtr_lightswitchInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "lightswitchInteractables");
		NativeFieldInfoPtr_mainLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "mainLights");
		NativeFieldInfoPtr_secondaryLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "secondaryLights");
		NativeFieldInfoPtr_enabledLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "enabledLights");
		NativeFieldInfoPtr_windowsWithUVData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "windowsWithUVData");
		NativeFieldInfoPtr_ceilingFans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "ceilingFans");
		NativeFieldInfoPtr_overrideData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "overrideData");
		NativeFieldInfoPtr_actorUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "actorUpdate");
		NativeFieldInfoPtr_cullingTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "cullingTree");
		NativeFieldInfoPtr_doorCheckSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "doorCheckSet");
		NativeFieldInfoPtr_nonAudioOccludedRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "nonAudioOccludedRooms");
		NativeFieldInfoPtr_openDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "openDoors");
		NativeFieldInfoPtr_closedDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "closedDoors");
		NativeFieldInfoPtr_adjacentRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "adjacentRooms");
		NativeFieldInfoPtr_aboveRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "aboveRooms");
		NativeFieldInfoPtr_belowRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "belowRooms");
		NativeFieldInfoPtr_atriumTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "atriumTop");
		NativeFieldInfoPtr_atriumRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "atriumRooms");
		NativeFieldInfoPtr_combinedWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "combinedWalls");
		NativeFieldInfoPtr_combinedWallRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "combinedWallRend");
		NativeFieldInfoPtr_additionalWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "additionalWalls");
		NativeFieldInfoPtr_combinedFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "combinedFloor");
		NativeFieldInfoPtr_combinedFloorRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "combinedFloorRend");
		NativeFieldInfoPtr_combinedCeiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "combinedCeiling");
		NativeFieldInfoPtr_combinedCeilingRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "combinedCeilingRend");
		NativeFieldInfoPtr_ambientSoundLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "ambientSoundLevel");
		NativeFieldInfoPtr_ct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "ct");
		NativeFieldInfoPtr_above = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "above");
		NativeFieldInfoPtr_below = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "below");
		NativeFieldInfoPtr_adj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "adj");
		NativeFieldInfoPtr_occ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "occ");
		NativeFieldInfoPtr_furniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "furniture");
		NativeFieldInfoPtr_individualFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "individualFurniture");
		NativeFieldInfoPtr_staticBatchDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "staticBatchDictionary");
		NativeFieldInfoPtr_staticBatchedGeneratedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "staticBatchedGeneratedMeshes");
		NativeFieldInfoPtr_pickFurnitureCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "pickFurnitureCache");
		NativeFieldInfoPtr_localizedRoomNodeMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "localizedRoomNodeMaps");
		NativeFieldInfoPtr_footprintUpdateQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "footprintUpdateQueued");
		NativeFieldInfoPtr_spawnedFootprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "spawnedFootprints");
		NativeFieldInfoPtr_blockedAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "blockedAccess");
		NativeFieldInfoPtr_actionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "actionReference");
		NativeFieldInfoPtr_specialCaseInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "specialCaseInteractables");
		NativeFieldInfoPtr_loadBelongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "loadBelongsTo");
		NativeFieldInfoPtr_belongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "belongsTo");
		NativeFieldInfoPtr_explorationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "explorationLevel");
		NativeFieldInfoPtr_mapDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "mapDoors");
		NativeFieldInfoPtr_airVents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "airVents");
		NativeFieldInfoPtr_ductGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "ductGroups");
		NativeFieldInfoPtr_passcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "passcode");
		NativeFieldInfoPtr_spatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "spatter");
		NativeFieldInfoPtr_steamControllingInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "steamControllingInteractables");
		NativeFieldInfoPtr_steamOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "steamOn");
		NativeFieldInfoPtr_steamLastSwitched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "steamLastSwitched");
		NativeFieldInfoPtr_steamController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "steamController");
		NativeFieldInfoPtr_spawnedBugs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "spawnedBugs");
		NativeFieldInfoPtr_gasLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "gasLevel");
		NativeFieldInfoPtr_lastRoomGassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "lastRoomGassed");
		NativeFieldInfoPtr_debugController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "debugController");
		NativeFieldInfoPtr_UpdateEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "UpdateEmission");
		NativeFieldInfoPtr_completedTreeCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "completedTreeCull");
		NativeFieldInfoPtr_debugLightswitches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "debugLightswitches");
		NativeFieldInfoPtr_cullingDebugLoadReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "cullingDebugLoadReference");
		NativeFieldInfoPtr_spawnPathDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "spawnPathDebug");
		NativeFieldInfoPtr_debugCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "debugCulling");
		NativeFieldInfoPtr_specificRoomCullingDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "specificRoomCullingDebug");
		NativeFieldInfoPtr_loadedCullTreeFromSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "loadedCullTreeFromSave");
		NativeFieldInfoPtr_mainLightObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "mainLightObjects");
		NativeFieldInfoPtr_debugDecor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "debugDecor");
		NativeFieldInfoPtr_exteriorWindowDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "exteriorWindowDebug");
		NativeFieldInfoPtr_nodeDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "nodeDebug");
		NativeFieldInfoPtr_debugAddActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "debugAddActions");
		NativeFieldInfoPtr_clustersPlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "clustersPlaced");
		NativeFieldInfoPtr_itemsPlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "itemsPlaced");
		NativeFieldInfoPtr_poolSizeOnPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "poolSizeOnPlacement");
		NativeFieldInfoPtr_palcementKey1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey1");
		NativeFieldInfoPtr_palcementKey2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey2");
		NativeFieldInfoPtr_palcementKey3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey3");
		NativeFieldInfoPtr_palcementKey4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey4");
		NativeFieldInfoPtr_palcementKey5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey5");
		NativeFieldInfoPtr_palcementKey51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey51");
		NativeFieldInfoPtr_palcementKey52 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey52");
		NativeFieldInfoPtr_palcementKey6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "palcementKey6");
		NativeFieldInfoPtr_keyAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "keyAtStart");
		NativeFieldInfoPtr_sublocationParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "sublocationParent");
		NativeFieldInfoPtr_sublocationDebugObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, "sublocationDebugObjects");
		NativeMethodInfoPtr_System_IEquatable_NewRoom__Equals_Private_Virtual_Final_New_Boolean_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669011);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669012);
		NativeMethodInfoPtr_GetShadowTint_Public_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669013);
		NativeMethodInfoPtr_SetupLayoutOnly_Public_Void_NewGameLocation_RoomTypePreset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669014);
		NativeMethodInfoPtr_SetupAll_Public_Void_NewGameLocation_RoomConfiguration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669015);
		NativeMethodInfoPtr_SetConfiguration_Public_Void_RoomConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669016);
		NativeMethodInfoPtr_SetType_Public_Void_RoomTypePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669017);
		NativeMethodInfoPtr_Load_Public_Void_RoomCitySave_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669018);
		NativeMethodInfoPtr_LoadCullingTree_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669019);
		NativeMethodInfoPtr_UpdateColourSchemeAndMaterials_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669020);
		NativeMethodInfoPtr_AddNewNode_Public_Void_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669021);
		NativeMethodInfoPtr_GetName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669022);
		NativeMethodInfoPtr_SetRoomName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669023);
		NativeMethodInfoPtr_RemoveNode_Public_Void_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669024);
		NativeMethodInfoPtr_UpdateWorldPositionAndBoundsSize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669025);
		NativeMethodInfoPtr_AddOpenPlanElement_Public_Void_RoomConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669026);
		NativeMethodInfoPtr_SetFloorMaterial_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669027);
		NativeMethodInfoPtr_SetCeilingMaterial_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669028);
		NativeMethodInfoPtr_SetWallMaterialDefault_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669029);
		NativeMethodInfoPtr_ToggleMainLights_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669030);
		NativeMethodInfoPtr_SetMainLights_Public_Void_Boolean_String_Actor_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669031);
		NativeMethodInfoPtr_SetSecondaryLight_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669032);
		NativeMethodInfoPtr_UpdateEmissionEndOfFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669033);
		NativeMethodInfoPtr_UpdateEmissionTex_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669034);
		NativeMethodInfoPtr_AddMainLight_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669035);
		NativeMethodInfoPtr_AddSecondaryLight_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669036);
		NativeMethodInfoPtr_AddEntrance_Public_Void_NewNode_NewNode_Boolean_AccessType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669037);
		NativeMethodInfoPtr_RemoveEntrance_Public_Void_NewNode_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669038);
		NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669039);
		NativeMethodInfoPtr_LoadRoomStuff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669040);
		NativeMethodInfoPtr_AddForStaticBatching_Public_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669041);
		NativeMethodInfoPtr_AddForStaticBatching_Public_Void_GameObject_MeshFilter_Mesh_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669042);
		NativeMethodInfoPtr_ExecuteStaticBatching_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669043);
		NativeMethodInfoPtr_QueueFootprintUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669044);
		NativeMethodInfoPtr_UpdateFootprints_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669045);
		NativeMethodInfoPtr_EnableLight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669046);
		NativeMethodInfoPtr_ConnectNodes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669047);
		NativeMethodInfoPtr_ApplyBlockedAccess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669048);
		NativeMethodInfoPtr_GenerateCullingTree_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669049);
		NativeMethodInfoPtr_SpawnDebugCullingObject_Private_Void_Vector3_NewRoom_NodeAccess_List_1_Int32_CullDebugType_NewRoom_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669050);
		NativeMethodInfoPtr_SetLowerRoom_Public_Void_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669051);
		NativeMethodInfoPtr_AddOccupant_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669052);
		NativeMethodInfoPtr_RemoveOccupant_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669053);
		NativeMethodInfoPtr_AddFurniture_Public_Void_FurnitureClusterLocation_Boolean_Boolean_Boolean_Boolean_DesignStylePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669054);
		NativeMethodInfoPtr_AddFurnitureCustom_Public_FurnitureLocation_FurniturePlacement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669055);
		NativeMethodInfoPtr_AddFurnitureCustom_Public_FurnitureLocation_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669056);
		NativeMethodInfoPtr_AddFurnitureBlockedAccess_Public_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669057);
		NativeMethodInfoPtr_AddCustomNodeWeights_Public_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669058);
		NativeMethodInfoPtr_AddFOVBlock_Private_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669059);
		NativeMethodInfoPtr_AddRandomAirVent_Public_Boolean_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669060);
		NativeMethodInfoPtr_LoadVent_Private_Void_AirVent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669061);
		NativeMethodInfoPtr_AddDuctGroup_Public_Void_AirDuctGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669062);
		NativeMethodInfoPtr_AddOwner_Public_Void_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669063);
		NativeMethodInfoPtr_LoadOwners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669064);
		NativeMethodInfoPtr_PickPassword_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669065);
		NativeMethodInfoPtr_SetupEnvrionment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669066);
		NativeMethodInfoPtr_SetExplorationLevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669067);
		NativeMethodInfoPtr_TestForDynamicShadowsUpdate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669068);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669069);
		NativeMethodInfoPtr_GenerateSaveData_Public_RoomCitySave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669070);
		NativeMethodInfoPtr_GetRandomNode_Public_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669071);
		NativeMethodInfoPtr_GetRandomEntranceNode_Public_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669072);
		NativeMethodInfoPtr_IsAccessAllowed_Public_Boolean_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669073);
		NativeMethodInfoPtr_RemoveAllInhabitantFurniture_Public_Void_Boolean_RemoveInteractablesOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669074);
		NativeMethodInfoPtr_SetSteam_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669075);
		NativeMethodInfoPtr_IsOutside_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669076);
		NativeMethodInfoPtr_GetAdjacentRooms_Public_List_1_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669077);
		NativeMethodInfoPtr_GetAboveRooms_Public_List_1_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669078);
		NativeMethodInfoPtr_GetBelowRooms_Public_List_1_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669079);
		NativeMethodInfoPtr_GetAboveAndBelowRooms_Public_List_1_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669080);
		NativeMethodInfoPtr_DisplaySublocations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669081);
		NativeMethodInfoPtr_RemoveSublocationsDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669082);
		NativeMethodInfoPtr_DebugTeleportPlayerToLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669083);
		NativeMethodInfoPtr_DebugCullingDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669084);
		NativeMethodInfoPtr_GetMainLightData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669085);
		NativeMethodInfoPtr_ToggleExteriorWindowDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669086);
		NativeMethodInfoPtr_TestFurniturePlacementBlockingCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669087);
		NativeMethodInfoPtr_TestFurniturePlacementBlockingCheckIgnoreNoPassthrough_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669088);
		NativeMethodInfoPtr_DisplayNodePositions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669089);
		NativeMethodInfoPtr_RemoveNodePositions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669090);
		NativeMethodInfoPtr_GetWallCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669091);
		NativeMethodInfoPtr_GetAIActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669092);
		NativeMethodInfoPtr_GetInteractables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669093);
		NativeMethodInfoPtr_ListContainedInteractables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669094);
		NativeMethodInfoPtr_ListActionReferences_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669095);
		NativeMethodInfoPtr_GetEnvironment_Public_SceneProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669096);
		NativeMethodInfoPtr_AddGas_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669097);
		NativeMethodInfoPtr_RebuildCullingTree_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669098);
		NativeMethodInfoPtr_IsThisOutside_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669099);
		NativeMethodInfoPtr_SpawnModularRoomElements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669100);
		NativeMethodInfoPtr_ListLoadedFurniture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669101);
		NativeMethodInfoPtr_UnloadRoomGeometry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669102);
		NativeMethodInfoPtr_GetSecondaryLightStatus_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669103);
		NativeMethodInfoPtr_UnloadRoomGeometry_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669104);
		NativeMethodInfoPtr_GetMeshGenerationCachePriority_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669105);
		NativeMethodInfoPtr_GetRoomCullingCachePriority_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669106);
		NativeMethodInfoPtr_ExecuteLightswitchesOverrides_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669107);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669108);
		NativeMethodInfoPtr_ListCurrentOccupants_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669109);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669110);
		NativeMethodInfoPtr__GenerateCullingTree_b__194_0_Private_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669112);
		NativeMethodInfoPtr__RemoveAllInhabitantFurniture_b__219_0_Private_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewRoom>.NativeClassPtr, 100669113);
	}

	[CallerCount(0)]
	public unsafe virtual bool System_IEquatable_NewRoom__Equals(NewRoom other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IEquatable_NewRoom__Equals_Private_Virtual_Final_New_Boolean_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 191742, RefRangeEnd = 191744, XrefRangeStart = 191735, XrefRangeEnd = 191742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetShadowTint(Color lightColour, float intensity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lightColour);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &intensity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowTint_Public_Color_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 191860, RefRangeEnd = 191865, XrefRangeStart = 191744, XrefRangeEnd = 191860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupLayoutOnly(NewGameLocation newAddress, RoomTypePreset newRoomType, int loadFloorRoomID = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoomType);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadFloorRoomID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupLayoutOnly_Public_Void_NewGameLocation_RoomTypePreset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 191872, RefRangeEnd = 191877, XrefRangeStart = 191865, XrefRangeEnd = 191872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupAll(NewGameLocation newAddress, RoomConfiguration newPreset, int loadFloorRoomID = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadFloorRoomID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupAll_Public_Void_NewGameLocation_RoomConfiguration_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 192013, RefRangeEnd = 192022, XrefRangeStart = 191877, XrefRangeEnd = 192013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConfiguration(RoomConfiguration newPreset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConfiguration_Public_Void_RoomConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 192047, RefRangeEnd = 192050, XrefRangeStart = 192022, XrefRangeEnd = 192047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetType(RoomTypePreset newRoomType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoomType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetType_Public_Void_RoomTypePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 192457, RefRangeEnd = 192459, XrefRangeStart = 192050, XrefRangeEnd = 192457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(CitySaveData.RoomCitySave data, NewGameLocation newGameLoc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGameLoc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_RoomCitySave_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 192557, RefRangeEnd = 192558, XrefRangeStart = 192459, XrefRangeEnd = 192557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadCullingTree()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCullingTree_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 192670, RefRangeEnd = 192672, XrefRangeStart = 192558, XrefRangeEnd = 192670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateColourSchemeAndMaterials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateColourSchemeAndMaterials_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 192805, RefRangeEnd = 192826, XrefRangeStart = 192672, XrefRangeEnd = 192805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewNode(NewNode newNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewNode_Public_Void_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(86)]
	[CachedScanResults(RefRangeStart = 192852, RefRangeEnd = 192938, XrefRangeStart = 192826, XrefRangeEnd = 192852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 192971, RefRangeEnd = 192976, XrefRangeStart = 192938, XrefRangeEnd = 192971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRoomName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRoomName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 193055, RefRangeEnd = 193056, XrefRangeStart = 192976, XrefRangeEnd = 193055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveNode(NewNode newNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveNode_Public_Void_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 193067, RefRangeEnd = 193071, XrefRangeStart = 193056, XrefRangeEnd = 193067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWorldPositionAndBoundsSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWorldPositionAndBoundsSize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 193076, RefRangeEnd = 193077, XrefRangeStart = 193071, XrefRangeEnd = 193076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOpenPlanElement(RoomConfiguration newElement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newElement);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOpenPlanElement_Public_Void_RoomConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 193113, RefRangeEnd = 193117, XrefRangeStart = 193077, XrefRangeEnd = 193113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloorMaterial(MaterialGroupPreset newMat, MaterialGroupPreset.MaterialVariation newVar, bool getNewKey = true, bool getMaterial = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newVar);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &getNewKey;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &getMaterial;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloorMaterial_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 193225, RefRangeEnd = 193228, XrefRangeStart = 193117, XrefRangeEnd = 193225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCeilingMaterial(MaterialGroupPreset newMat, MaterialGroupPreset.MaterialVariation newVar, bool getNewKey = true, bool getMaterial = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newVar);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &getNewKey;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &getMaterial;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCeilingMaterial_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 193275, RefRangeEnd = 193279, XrefRangeStart = 193228, XrefRangeEnd = 193275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWallMaterialDefault(MaterialGroupPreset newMat, MaterialGroupPreset.MaterialVariation newVar, bool getNewKey = true, bool getMaterial = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newVar);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &getNewKey;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &getMaterial;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWallMaterialDefault_Public_Void_MaterialGroupPreset_MaterialVariation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193279, XrefRangeEnd = 193283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleMainLights(Actor actor = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleMainLights_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 193484, RefRangeEnd = 193495, XrefRangeStart = 193283, XrefRangeEnd = 193484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMainLights(bool newVal, string debug, Actor actor = null, bool forceInstant = false, bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&newVal);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(debug);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceInstant;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMainLights_Public_Void_Boolean_String_Actor_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 193523, RefRangeEnd = 193527, XrefRangeStart = 193495, XrefRangeEnd = 193523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSecondaryLight(bool newVal, bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newVal);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSecondaryLight_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 193533, RefRangeEnd = 193537, XrefRangeStart = 193527, XrefRangeEnd = 193533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateEmissionEndOfFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateEmissionEndOfFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193537, XrefRangeEnd = 193608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateEmissionTex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateEmissionTex_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193608, XrefRangeEnd = 193613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMainLight(Interactable newLight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMainLight_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193613, XrefRangeEnd = 193618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSecondaryLight(Interactable newLight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSecondaryLight_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 193663, RefRangeEnd = 193672, XrefRangeStart = 193618, XrefRangeEnd = 193663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEntrance(NewNode fromNode, NewNode toNode, bool forceAccessType = false, NewNode.NodeAccess.AccessType forcedAccessType = NewNode.NodeAccess.AccessType.adjacent, bool forceWalkable = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toNode);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceAccessType;
		*(NewNode.NodeAccess.AccessType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedAccessType;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceWalkable;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEntrance_Public_Void_NewNode_NewNode_Boolean_AccessType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 193734, RefRangeEnd = 193744, XrefRangeStart = 193672, XrefRangeEnd = 193734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEntrance(NewNode fromNode, NewNode toNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEntrance_Public_Void_NewNode_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 194011, RefRangeEnd = 194024, XrefRangeStart = 193744, XrefRangeEnd = 194011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVisible(bool val, bool forceUpdate, bool immediateLoad = false, bool immediatelyLoadStuff = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&val);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUpdate;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &immediateLoad;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &immediatelyLoadStuff;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 194091, RefRangeEnd = 194094, XrefRangeStart = 194024, XrefRangeEnd = 194091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadRoomStuff(bool immediateLoad = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&immediateLoad);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRoomStuff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194094, XrefRangeEnd = 194169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddForStaticBatching(FurnitureLocation loc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddForStaticBatching_Public_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194224, RefRangeEnd = 194226, XrefRangeStart = 194169, XrefRangeEnd = 194224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddForStaticBatching(GameObject obj, MeshFilter objectFilter, Mesh objectMesh, Material objectMat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectFilter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectMesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectMat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddForStaticBatching_Public_Void_GameObject_MeshFilter_Mesh_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194279, RefRangeEnd = 194280, XrefRangeStart = 194226, XrefRangeEnd = 194279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteStaticBatching()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteStaticBatching_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void QueueFootprintUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueFootprintUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194337, RefRangeEnd = 194339, XrefRangeStart = 194280, XrefRangeEnd = 194337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFootprints(bool forceRemoveAll = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceRemoveAll);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFootprints_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194339, XrefRangeEnd = 194361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableLight(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194425, RefRangeEnd = 194427, XrefRangeStart = 194361, XrefRangeEnd = 194425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConnectNodes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConnectNodes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194463, RefRangeEnd = 194464, XrefRangeStart = 194427, XrefRangeEnd = 194463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyBlockedAccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyBlockedAccess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 195920, RefRangeEnd = 195928, XrefRangeStart = 194464, XrefRangeEnd = 195920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateCullingTree(bool debugMode = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&debugMode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCullingTree_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 195995, RefRangeEnd = 195999, XrefRangeStart = 195928, XrefRangeEnd = 195995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnDebugCullingObject(Vector3 worldPos, NewRoom room, NewNode.NodeAccess parentEntrance, List<int> depDoors, CullingDebugController.CullDebugType newType, NewRoom atriumTopOf = null, NewNode.NodeAccess otherEntrance = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&worldPos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentEntrance);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depDoors);
		*(CullingDebugController.CullDebugType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atriumTopOf);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherEntrance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnDebugCullingObject_Private_Void_Vector3_NewRoom_NodeAccess_List_1_Int32_CullDebugType_NewRoom_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 195999, RefRangeEnd = 196000, XrefRangeStart = 195999, XrefRangeEnd = 195999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLowerRoom(NewRoom newRoom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLowerRoom_Public_Void_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196000, XrefRangeEnd = 196009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOccupant(Actor newOcc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newOcc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOccupant_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196024, RefRangeEnd = 196025, XrefRangeStart = 196009, XrefRangeEnd = 196024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOccupant(Actor remOcc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remOcc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveOccupant_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 196169, RefRangeEnd = 196174, XrefRangeStart = 196025, XrefRangeEnd = 196169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFurniture(FurnitureClusterLocation newFurn, bool generateNew, bool addPathBlocking = true, bool immediateSpawn = false, bool ignoreLimitations = false, DesignStylePreset styleOverride = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFurn);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateNew;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &addPathBlocking;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &immediateSpawn;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreLimitations;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)styleOverride);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFurniture_Public_Void_FurnitureClusterLocation_Boolean_Boolean_Boolean_Boolean_DesignStylePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196228, RefRangeEnd = 196229, XrefRangeStart = 196174, XrefRangeEnd = 196228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FurnitureLocation AddFurnitureCustom(PlayerApartmentController.FurniturePlacement newPlacement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPlacement);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFurnitureCustom_Public_FurnitureLocation_FurniturePlacement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 196300, RefRangeEnd = 196302, XrefRangeStart = 196229, XrefRangeEnd = 196300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FurnitureLocation AddFurnitureCustom(FurnitureLocation newPlacement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPlacement);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFurnitureCustom_Public_FurnitureLocation_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196302, XrefRangeEnd = 196410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFurnitureBlockedAccess(FurnitureLocation obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFurnitureBlockedAccess_Public_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196410, XrefRangeEnd = 196434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCustomNodeWeights(FurnitureLocation obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCustomNodeWeights_Public_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196434, XrefRangeEnd = 196471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFOVBlock(FurnitureLocation obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFOVBlock_Private_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196632, RefRangeEnd = 196633, XrefRangeStart = 196471, XrefRangeEnd = 196632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddRandomAirVent(NewAddress.AirVent ventType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ventType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRandomAirVent_Public_Boolean_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196635, RefRangeEnd = 196636, XrefRangeStart = 196633, XrefRangeEnd = 196635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadVent(AirDuctGroup.AirVent vent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadVent_Private_Void_AirVent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 196641, RefRangeEnd = 196644, XrefRangeStart = 196636, XrefRangeEnd = 196641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDuctGroup(AirDuctGroup newGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDuctGroup_Public_Void_AirDuctGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 196680, RefRangeEnd = 196682, XrefRangeStart = 196644, XrefRangeEnd = 196680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOwner(Human newOwner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newOwner);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOwner_Public_Void_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196682, XrefRangeEnd = 196718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadOwners()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadOwners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 196893, RefRangeEnd = 196894, XrefRangeStart = 196718, XrefRangeEnd = 196893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PickPassword()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickPassword_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 196908, RefRangeEnd = 196910, XrefRangeStart = 196894, XrefRangeEnd = 196908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupEnvrionment()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEnvrionment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 197000, RefRangeEnd = 197010, XrefRangeStart = 196910, XrefRangeEnd = 197000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExplorationLevel(int newLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExplorationLevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197010, XrefRangeEnd = 197093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TestForDynamicShadowsUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestForDynamicShadowsUpdate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int CompareTo(NewRoom otherObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 197276, RefRangeEnd = 197279, XrefRangeStart = 197093, XrefRangeEnd = 197276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CitySaveData.RoomCitySave GenerateSaveData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSaveData_Public_RoomCitySave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData.RoomCitySave>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197279, XrefRangeEnd = 197291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode GetRandomNode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomNode_Public_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 197305, RefRangeEnd = 197317, XrefRangeStart = 197291, XrefRangeEnd = 197305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode GetRandomEntranceNode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomEntranceNode_Public_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe bool IsAccessAllowed(Human human)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAccessAllowed_Public_Boolean_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 197389, RefRangeEnd = 197391, XrefRangeStart = 197317, XrefRangeEnd = 197389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllInhabitantFurniture(bool removeSkipAddressInhabitantsFurniture, FurnitureClusterLocation.RemoveInteractablesOption spawnedOnFurnitureRemovalOption)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&removeSkipAddressInhabitantsFurniture);
		*(FurnitureClusterLocation.RemoveInteractablesOption**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &spawnedOnFurnitureRemovalOption;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllInhabitantFurniture_Public_Void_Boolean_RemoveInteractablesOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 197420, RefRangeEnd = 197421, XrefRangeStart = 197391, XrefRangeEnd = 197420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSteam(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSteam_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(71)]
	[CachedScanResults(RefRangeStart = 197421, RefRangeEnd = 197492, XrefRangeStart = 197421, XrefRangeEnd = 197421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsOutside()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOutside_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197492, XrefRangeEnd = 197548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<NewRoom> GetAdjacentRooms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdjacentRooms_Public_List_1_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197548, XrefRangeEnd = 197572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<NewRoom> GetAboveRooms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAboveRooms_Public_List_1_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197572, XrefRangeEnd = 197596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<NewRoom> GetBelowRooms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBelowRooms_Public_List_1_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197596, XrefRangeEnd = 197626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<NewRoom> GetAboveAndBelowRooms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAboveAndBelowRooms_Public_List_1_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197626, XrefRangeEnd = 197723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplaySublocations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplaySublocations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197723, XrefRangeEnd = 197737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSublocationsDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSublocationsDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197737, XrefRangeEnd = 197751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugTeleportPlayerToLocation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugTeleportPlayerToLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197751, XrefRangeEnd = 197768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugCullingDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugCullingDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197768, XrefRangeEnd = 197793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMainLightData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainLightData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197793, XrefRangeEnd = 197863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleExteriorWindowDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleExteriorWindowDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197863, XrefRangeEnd = 197896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestFurniturePlacementBlockingCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestFurniturePlacementBlockingCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197896, XrefRangeEnd = 197929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestFurniturePlacementBlockingCheckIgnoreNoPassthrough()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestFurniturePlacementBlockingCheckIgnoreNoPassthrough_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197929, XrefRangeEnd = 197989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayNodePositions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayNodePositions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197989, XrefRangeEnd = 198003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveNodePositions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveNodePositions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 198012, RefRangeEnd = 198013, XrefRangeStart = 198003, XrefRangeEnd = 198012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetWallCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWallCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198013, XrefRangeEnd = 198038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAIActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAIActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198038, XrefRangeEnd = 198061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInteractables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198061, XrefRangeEnd = 198078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ListContainedInteractables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListContainedInteractables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198078, XrefRangeEnd = 198128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ListActionReferences()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListActionReferences_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 198131, RefRangeEnd = 198132, XrefRangeStart = 198128, XrefRangeEnd = 198131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SessionData.SceneProfile GetEnvironment()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnvironment_Public_SceneProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SessionData.SceneProfile*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 198150, RefRangeEnd = 198154, XrefRangeStart = 198132, XrefRangeEnd = 198150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddGas(float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGas_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198154, XrefRangeEnd = 198178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildCullingTree()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildCullingTree_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198178, XrefRangeEnd = 198183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IsThisOutside()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsThisOutside_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198183, XrefRangeEnd = 198186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnModularRoomElements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnModularRoomElements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198186, XrefRangeEnd = 198216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ListLoadedFurniture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListLoadedFurniture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198216, XrefRangeEnd = 198222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadRoomGeometry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadRoomGeometry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 198238, RefRangeEnd = 198246, XrefRangeStart = 198222, XrefRangeEnd = 198238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetSecondaryLightStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSecondaryLightStatus_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 198533, RefRangeEnd = 198536, XrefRangeStart = 198246, XrefRangeEnd = 198533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadRoomGeometry(int spawnedRoomIndex, bool despawnObjects = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&spawnedRoomIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &despawnObjects;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadRoomGeometry_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 198640, RefRangeEnd = 198642, XrefRangeStart = 198536, XrefRangeEnd = 198640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMeshGenerationCachePriority()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshGenerationCachePriority_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 198746, RefRangeEnd = 198748, XrefRangeStart = 198642, XrefRangeEnd = 198746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRoomCullingCachePriority()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoomCullingCachePriority_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 198781, RefRangeEnd = 198782, XrefRangeStart = 198748, XrefRangeEnd = 198781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteLightswitchesOverrides()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteLightswitchesOverrides_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198782, XrefRangeEnd = 198807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198807, XrefRangeEnd = 198821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ListCurrentOccupants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListCurrentOccupants_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198821, XrefRangeEnd = 199114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewRoom()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewRoom>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199114, XrefRangeEnd = 199117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _GenerateCullingTree_b__194_0(NewNode.NodeAccess item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateCullingTree_b__194_0_Private_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199117, XrefRangeEnd = 199118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _RemoveAllInhabitantFurniture_b__219_0(Interactable item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveAllInhabitantFurniture_b__219_0_Private_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public NewRoom(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
