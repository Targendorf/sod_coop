using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class NewGameLocation : Controller
{
	[System.Serializable]
	public class TrespassEscalation : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actor;

		private static readonly System.IntPtr NativeFieldInfoPtr_isPlayer;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastEscalationCheck;

		private static readonly System.IntPtr NativeFieldInfoPtr_timeEscalation;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int actor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor)) = num;
			}
		}

		public unsafe bool isPlayer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayer)) = flag;
			}
		}

		public unsafe float lastEscalationCheck
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastEscalationCheck);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastEscalationCheck)) = num;
			}
		}

		public unsafe float timeEscalation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeEscalation);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeEscalation)) = num;
			}
		}

		static TrespassEscalation()
		{
			Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "TrespassEscalation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr);
			NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr, "actor");
			NativeFieldInfoPtr_isPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr, "isPlayer");
			NativeFieldInfoPtr_lastEscalationCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr, "lastEscalationCheck");
			NativeFieldInfoPtr_timeEscalation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr, "timeEscalation");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr, 100665631);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrespassEscalation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrespassEscalation>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TrespassEscalation(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ObjectPlacement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_location;

		private static readonly System.IntPtr NativeFieldInfoPtr_furnParent;

		private static readonly System.IntPtr NativeFieldInfoPtr_existing;

		private static readonly System.IntPtr NativeFieldInfoPtr_subSpawn;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe FurniturePreset.SubObject location
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset.SubObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject));
			}
		}

		public unsafe FurnitureLocation furnParent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnParent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureLocation));
			}
		}

		public unsafe Interactable existing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existing);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		public unsafe Interactable subSpawn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawn);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		static ObjectPlacement()
		{
			Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "ObjectPlacement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr);
			NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr, "location");
			NativeFieldInfoPtr_furnParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr, "furnParent");
			NativeFieldInfoPtr_existing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr, "existing");
			NativeFieldInfoPtr_subSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr, "subSpawn");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr, 100665632);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPlacement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPlacement>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ObjectPlacement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class ObjectPlace : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeFieldInfoPtr_belongsTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_writer;

		private static readonly System.IntPtr NativeFieldInfoPtr_receiver;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedVars;

		private static readonly System.IntPtr NativeFieldInfoPtr_security;

		private static readonly System.IntPtr NativeFieldInfoPtr_ownership;

		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_dontPlaceInRooms;

		public unsafe InteractablePreset interactable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe Human belongsTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human writer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human receiver
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe List<Interactable.Passed> passedVars
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedVars);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable.Passed>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedVars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

		public unsafe InteractablePreset.OwnedPlacementRule ownership
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownership);
				return *(InteractablePreset.OwnedPlacementRule*)num;
			}
			set
			{
				*(InteractablePreset.OwnedPlacementRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownership)) = ownedPlacementRule;
			}
		}

		public unsafe int priority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
			}
		}

		public unsafe Il2CppSystem.Object passedObject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedObject);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe HashSet<NewRoom> dontPlaceInRooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPlaceInRooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewRoom>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontPlaceInRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		static ObjectPlace()
		{
			Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "ObjectPlace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr);
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "interactable");
			NativeFieldInfoPtr_belongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "belongsTo");
			NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "writer");
			NativeFieldInfoPtr_receiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "receiver");
			NativeFieldInfoPtr_passedVars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "passedVars");
			NativeFieldInfoPtr_security = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "security");
			NativeFieldInfoPtr_ownership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "ownership");
			NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "priority");
			NativeFieldInfoPtr_passedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "passedObject");
			NativeFieldInfoPtr_dontPlaceInRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, "dontPlaceInRooms");
		}

		public ObjectPlace(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ObjectPlace()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr))
		{
		}
	}

	public class Placement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_room;

		private static readonly System.IntPtr NativeFieldInfoPtr_furniture;

		private static readonly System.IntPtr NativeFieldInfoPtr_placementClass;

		private static readonly System.IntPtr NativeFieldInfoPtr_subObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_subSpawn;

		private static readonly System.IntPtr NativeFieldInfoPtr_rank;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

		public unsafe FurnitureLocation furniture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureLocation));
			}
		}

		public unsafe SubObjectClassPreset placementClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
			}
		}

		public unsafe FurniturePreset.SubObject subObject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObject);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset.SubObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject));
			}
		}

		public unsafe Interactable subSpawn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawn);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subSpawn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
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

		static Placement()
		{
			Il2CppClassPointerStore<Placement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "Placement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Placement>.NativeClassPtr);
			NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placement>.NativeClassPtr, "room");
			NativeFieldInfoPtr_furniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placement>.NativeClassPtr, "furniture");
			NativeFieldInfoPtr_placementClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placement>.NativeClassPtr, "placementClass");
			NativeFieldInfoPtr_subObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placement>.NativeClassPtr, "subObject");
			NativeFieldInfoPtr_subSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placement>.NativeClassPtr, "subSpawn");
			NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placement>.NativeClassPtr, "rank");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placement>.NativeClassPtr, 100665633);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Placement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Placement>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Placement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass48_0")]
	public sealed class __c__DisplayClass48_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fromNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_toNode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddEntrance_b__0_Internal_Boolean_NodeAccess_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddEntrance_b__1_Internal_Boolean_NewWall_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddEntrance_b__2_Internal_Boolean_NodeAccess_0;

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

		static __c__DisplayClass48_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass48_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr);
			NativeFieldInfoPtr_fromNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr, "fromNode");
			NativeFieldInfoPtr_toNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr, "toNode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr, 100665634);
			NativeMethodInfoPtr__AddEntrance_b__0_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr, 100665635);
			NativeMethodInfoPtr__AddEntrance_b__1_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr, 100665636);
			NativeMethodInfoPtr__AddEntrance_b__2_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr, 100665637);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass48_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass48_0>.NativeClassPtr))
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

		[CallerCount(0)]
		public unsafe bool _AddEntrance_b__2(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddEntrance_b__2_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass48_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass49_0")]
	public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fromNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_toNode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveEntrance_b__1_Internal_Boolean_NodeAccess_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveEntrance_b__0_Internal_Boolean_NodeAccess_0;

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

		static __c__DisplayClass49_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass49_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr);
			NativeFieldInfoPtr_fromNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr, "fromNode");
			NativeFieldInfoPtr_toNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr, "toNode");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr, 100665638);
			NativeMethodInfoPtr__RemoveEntrance_b__1_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr, 100665639);
			NativeMethodInfoPtr__RemoveEntrance_b__0_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr, 100665640);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass49_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass49_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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

		public __c__DisplayClass49_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass51_0")]
	public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeFieldInfoPtr_belongsTo;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObject_b__1_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObject_b__2_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObject_b__3_Internal_Boolean_Interactable_0;

		public unsafe InteractablePreset interactable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe Human belongsTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Il2CppSystem.Predicate<Interactable> __9__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe Il2CppSystem.Predicate<Interactable> __9__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe Il2CppSystem.Predicate<Interactable> __9__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c__DisplayClass51_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass51_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr);
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, "interactable");
			NativeFieldInfoPtr_belongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, "belongsTo");
			NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, "<>9__1");
			NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, "<>9__2");
			NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, "<>9__3");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100665641);
			NativeMethodInfoPtr__PlaceObject_b__1_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100665642);
			NativeMethodInfoPtr__PlaceObject_b__2_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100665643);
			NativeMethodInfoPtr__PlaceObject_b__3_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100665644);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass51_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObject_b__1(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObject_b__1_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82520, XrefRangeEnd = 82530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlaceObject_b__2(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObject_b__2_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObject_b__3(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObject_b__3_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass51_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("NewGameLocation+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__51_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__55_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObject_b__51_0_Internal_Boolean_Passed_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__55_0_Internal_Int32_ObjectPlace_ObjectPlace_0;

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

		public unsafe static Il2CppSystem.Predicate<Interactable.Passed> __9__51_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable.Passed>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__51_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<ObjectPlace> __9__55_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ObjectPlace>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__55_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__51_0");
			NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__55_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665646);
			NativeMethodInfoPtr__PlaceObject_b__51_0_Internal_Boolean_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665647);
			NativeMethodInfoPtr__PlaceObjects_b__55_0_Internal_Int32_ObjectPlace_ObjectPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665648);
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
		public unsafe bool _PlaceObject_b__51_0(Interactable.Passed item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObject_b__51_0_Internal_Boolean_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _PlaceObjects_b__55_0(ObjectPlace p1, ObjectPlace p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)p1));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)p2));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__55_0_Internal_Int32_ObjectPlace_ObjectPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_0")]
	public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractablePreset interactable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		static __c__DisplayClass52_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr);
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr, "interactable");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr, 100665649);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass52_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_1")]
	public sealed class __c__DisplayClass52_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_f;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__0_Internal_Boolean_Interactable_0;

		public unsafe FurnitureLocation f
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureLocation));
			}
		}

		public unsafe __c__DisplayClass52_0 field_Public___c__DisplayClass52_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass52_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass52_));
			}
		}

		static __c__DisplayClass52_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_1>.NativeClassPtr);
			NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_1>.NativeClassPtr, "f");
			NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_1>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_1>.NativeClassPtr, 100665650);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__0_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_1>.NativeClassPtr, 100665651);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82530, XrefRangeEnd = 82533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetBestSpawnLocation_b__0(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__0_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_2")]
	public sealed class __c__DisplayClass52_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_obj;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__1_Internal_Boolean_Interactable_0;

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

		public unsafe __c__DisplayClass52_0 field_Public___c__DisplayClass52_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass52_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass52_));
			}
		}

		static __c__DisplayClass52_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_2>.NativeClassPtr);
			NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_2>.NativeClassPtr, "obj");
			NativeFieldInfoPtr_field_Public___c__DisplayClass52_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_2>.NativeClassPtr, "CS$<>8__locals2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_2>.NativeClassPtr, 100665652);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__1_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_2>.NativeClassPtr, 100665653);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetBestSpawnLocation_b__1(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__1_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_3")]
	public sealed class __c__DisplayClass52_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_placeClass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__2_Internal_Boolean_SubObject_0;

		public unsafe SubObjectClassPreset placeClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
			}
		}

		static __c__DisplayClass52_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_3>.NativeClassPtr);
			NativeFieldInfoPtr_placeClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_3>.NativeClassPtr, "placeClass");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_3>.NativeClassPtr, 100665654);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__2_Internal_Boolean_SubObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_3>.NativeClassPtr, 100665655);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetBestSpawnLocation_b__2(FurniturePreset.SubObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__2_Internal_Boolean_SubObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_4")]
	public sealed class __c__DisplayClass52_4 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_loc;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__3_Internal_Boolean_Interactable_0;

		public unsafe FurniturePreset.SubObject loc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset.SubObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject));
			}
		}

		static __c__DisplayClass52_4()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_4>.NativeClassPtr);
			NativeFieldInfoPtr_loc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_4>.NativeClassPtr, "loc");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_4>.NativeClassPtr, 100665656);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__3_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_4>.NativeClassPtr, 100665657);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_4>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetBestSpawnLocation_b__3(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__3_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_4(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_5")]
	public sealed class __c__DisplayClass52_5 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_placeClass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__4_Internal_Boolean_SubObject_0;

		public unsafe SubObjectClassPreset placeClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
			}
		}

		static __c__DisplayClass52_5()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_5>.NativeClassPtr);
			NativeFieldInfoPtr_placeClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_5>.NativeClassPtr, "placeClass");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_5>.NativeClassPtr, 100665658);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__4_Internal_Boolean_SubObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_5>.NativeClassPtr, 100665659);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_5>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetBestSpawnLocation_b__4(FurniturePreset.SubObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__4_Internal_Boolean_SubObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_5(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_6")]
	public sealed class __c__DisplayClass52_6 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_s;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__5_Internal_Boolean_Interactable_0;

		public unsafe FurniturePreset.SubObject s
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset.SubObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject));
			}
		}

		static __c__DisplayClass52_6()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_6");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_6>.NativeClassPtr);
			NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_6>.NativeClassPtr, "s");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_6>.NativeClassPtr, 100665660);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__5_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_6>.NativeClassPtr, 100665661);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_6()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_6>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetBestSpawnLocation_b__5(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__5_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_6(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_7")]
	public sealed class __c__DisplayClass52_7 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_placeClass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__6_Internal_Boolean_SubObject_0;

		public unsafe SubObjectClassPreset placeClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
			}
		}

		static __c__DisplayClass52_7()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_7>.NativeClassPtr);
			NativeFieldInfoPtr_placeClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_7>.NativeClassPtr, "placeClass");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_7>.NativeClassPtr, 100665662);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__6_Internal_Boolean_SubObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_7>.NativeClassPtr, 100665663);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_7()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_7>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetBestSpawnLocation_b__6(FurniturePreset.SubObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__6_Internal_Boolean_SubObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_7(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass52_8")]
	public sealed class __c__DisplayClass52_8 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_s;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetBestSpawnLocation_b__7_Internal_Boolean_Interactable_0;

		public unsafe FurniturePreset.SubObject s
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset.SubObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject));
			}
		}

		static __c__DisplayClass52_8()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass52_8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_8>.NativeClassPtr);
			NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_8>.NativeClassPtr, "s");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_8>.NativeClassPtr, 100665664);
			NativeMethodInfoPtr__GetBestSpawnLocation_b__7_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_8>.NativeClassPtr, 100665665);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_8()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_8>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetBestSpawnLocation_b__7(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetBestSpawnLocation_b__7_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_8(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass53_0")]
	public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_placeClass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetPutDownLocation_b__0_Internal_Boolean_SubObject_0;

		public unsafe SubObjectClassPreset placeClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
			}
		}

		static __c__DisplayClass53_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass53_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr);
			NativeFieldInfoPtr_placeClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr, "placeClass");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr, 100665666);
			NativeMethodInfoPtr__GetPutDownLocation_b__0_Internal_Boolean_SubObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr, 100665667);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass53_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetPutDownLocation_b__0(FurniturePreset.SubObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetPutDownLocation_b__0_Internal_Boolean_SubObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass53_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass53_1")]
	public sealed class __c__DisplayClass53_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_placeClass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetPutDownLocation_b__1_Internal_Boolean_SubObject_0;

		public unsafe SubObjectClassPreset placeClass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubObjectClassPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObjectClassPreset));
			}
		}

		static __c__DisplayClass53_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass53_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass53_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass53_1>.NativeClassPtr);
			NativeFieldInfoPtr_placeClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass53_1>.NativeClassPtr, "placeClass");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_1>.NativeClassPtr, 100665668);
			NativeMethodInfoPtr__GetPutDownLocation_b__1_Internal_Boolean_SubObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_1>.NativeClassPtr, 100665669);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass53_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass53_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetPutDownLocation_b__1(FurniturePreset.SubObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetPutDownLocation_b__1_Internal_Boolean_SubObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass53_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass53_2")]
	public sealed class __c__DisplayClass53_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_s;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetPutDownLocation_b__2_Internal_Boolean_Interactable_0;

		public unsafe FurniturePreset.SubObject s
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset.SubObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject));
			}
		}

		static __c__DisplayClass53_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass53_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass53_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass53_2>.NativeClassPtr);
			NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass53_2>.NativeClassPtr, "s");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_2>.NativeClassPtr, 100665670);
			NativeMethodInfoPtr__GetPutDownLocation_b__2_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_2>.NativeClassPtr, 100665671);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass53_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass53_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetPutDownLocation_b__2(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetPutDownLocation_b__2_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass53_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass54_0")]
	public sealed class __c__DisplayClass54_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddToPlacementPool_b__0_Internal_Boolean_ObjectPlace_0;

		public unsafe InteractablePreset interactable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		static __c__DisplayClass54_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass54_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass54_0>.NativeClassPtr);
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass54_0>.NativeClassPtr, "interactable");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass54_0>.NativeClassPtr, 100665672);
			NativeMethodInfoPtr__AddToPlacementPool_b__0_Internal_Boolean_ObjectPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass54_0>.NativeClassPtr, 100665673);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass54_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass54_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddToPlacementPool_b__0(ObjectPlace item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)item));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddToPlacementPool_b__0_Internal_Boolean_ObjectPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass54_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass55_0")]
	public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass55_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass55_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass55_0>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_0>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_0>.NativeClassPtr, 100665674);
			NativeMethodInfoPtr__PlaceObjects_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_0>.NativeClassPtr, 100665675);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass55_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass55_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObjects_b__1(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass55_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass55_1")]
	public sealed class __c__DisplayClass55_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__2_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass55_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass55_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass55_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass55_1>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_1>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_1>.NativeClassPtr, 100665676);
			NativeMethodInfoPtr__PlaceObjects_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_1>.NativeClassPtr, 100665677);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass55_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass55_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObjects_b__2(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass55_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass55_2")]
	public sealed class __c__DisplayClass55_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__3_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass55_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass55_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass55_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass55_2>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_2>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_2>.NativeClassPtr, 100665678);
			NativeMethodInfoPtr__PlaceObjects_b__3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_2>.NativeClassPtr, 100665679);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass55_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass55_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObjects_b__3(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass55_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass55_3")]
	public sealed class __c__DisplayClass55_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__4_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass55_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass55_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass55_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass55_3>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_3>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_3>.NativeClassPtr, 100665680);
			NativeMethodInfoPtr__PlaceObjects_b__4_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_3>.NativeClassPtr, 100665681);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass55_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass55_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObjects_b__4(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__4_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass55_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass55_4")]
	public sealed class __c__DisplayClass55_4 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pl;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__6;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__7;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__6_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__7_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__5_Internal_Boolean_ObjectPlace_0;

		public unsafe ObjectPlace pl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pl);
				return new ObjectPlace(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pl), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPlace)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObjectPlace>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Predicate<Interactable> __9__6
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__6);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__6)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe Il2CppSystem.Predicate<Interactable> __9__7
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__7);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__7)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c__DisplayClass55_4()
		{
			Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass55_4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr);
			NativeFieldInfoPtr_pl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr, "pl");
			NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr, "<>9__6");
			NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr, "<>9__7");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr, 100665682);
			NativeMethodInfoPtr__PlaceObjects_b__6_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr, 100665683);
			NativeMethodInfoPtr__PlaceObjects_b__7_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr, 100665684);
			NativeMethodInfoPtr__PlaceObjects_b__5_Internal_Boolean_ObjectPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr, 100665685);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass55_4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass55_4>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82533, XrefRangeEnd = 82543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlaceObjects_b__6(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__6_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObjects_b__7(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__7_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _PlaceObjects_b__5(ObjectPlace item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)item));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__5_Internal_Boolean_ObjectPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass55_4(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewGameLocation+<>c__DisplayClass55_5")]
	public sealed class __c__DisplayClass55_5 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_stackType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlaceObjects_b__8_Internal_Boolean_Interactable_0;

		public unsafe InteractablePreset.SpecialCase stackType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackType);
				return *(InteractablePreset.SpecialCase*)num;
			}
			set
			{
				*(InteractablePreset.SpecialCase*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackType)) = specialCase;
			}
		}

		static __c__DisplayClass55_5()
		{
			Il2CppClassPointerStore<__c__DisplayClass55_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "<>c__DisplayClass55_5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass55_5>.NativeClassPtr);
			NativeFieldInfoPtr_stackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass55_5>.NativeClassPtr, "stackType");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_5>.NativeClassPtr, 100665686);
			NativeMethodInfoPtr__PlaceObjects_b__8_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass55_5>.NativeClassPtr, 100665687);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass55_5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass55_5>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82543, XrefRangeEnd = 82544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlaceObjects_b__8(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlaceObjects_b__8_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass55_5(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_thisAsAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_thisAsStreet;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_district;

	private static readonly System.IntPtr NativeFieldInfoPtr_building;

	private static readonly System.IntPtr NativeFieldInfoPtr_floor;

	private static readonly System.IntPtr NativeFieldInfoPtr_residenceNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLobby;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOutside;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCrimeScene;

	private static readonly System.IntPtr NativeFieldInfoPtr_loggedAsCrimeScene;

	private static readonly System.IntPtr NativeFieldInfoPtr_access;

	private static readonly System.IntPtr NativeFieldInfoPtr_nullRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_rooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentOccupants;

	private static readonly System.IntPtr NativeFieldInfoPtr_designStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_artPieces;

	private static readonly System.IntPtr NativeFieldInfoPtr_placedKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_securityCameras;

	private static readonly System.IntPtr NativeFieldInfoPtr_stacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_telephones;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetBehaviourObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureBelongsTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_entrances;

	private static readonly System.IntPtr NativeFieldInfoPtr_streetAccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_anchorNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearestPublicActionReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_escalation;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerLoiteringTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_evidenceEntry;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectsToPlace;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectPoolPlaced;

	private static readonly System.IntPtr NativeMethodInfoPtr_CommonSetup_Public_Void_Boolean_DistrictController_DesignStylePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewNode_Public_Void_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNode_Public_Void_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNewRoom_Public_Void_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRoom_Public_Void_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOccupant_Public_Virtual_New_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Virtual_New_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainEntrance_Public_NodeAccess_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDesignStyle_Public_Void_DesignStylePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEntrance_Public_Void_NewNode_NewNode_Boolean_AccessType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEntrance_Public_Void_NewNode_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaceObject_Public_Interactable_InteractablePreset_Human_Human_Human_byref_FurnitureLocation_Boolean_PassedVarType_Int32_Boolean_Int32_OwnedPlacementRule_Int32_RetailItemPreset_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaceObject_Public_Interactable_InteractablePreset_Human_Human_Human_byref_FurnitureLocation_List_1_Passed_Boolean_Int32_OwnedPlacementRule_Int32_Object_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBestSpawnLocation_Public_ObjectPlacement_InteractablePreset_Boolean_Human_Human_Human_byref_FurnitureLocation_List_1_Passed_Boolean_Int32_OwnedPlacementRule_Int32_Object_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPutDownLocation_Public_ObjectPlacement_InteractablePreset_byref_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToPlacementPool_Public_Void_InteractablePreset_Human_Human_Human_List_1_Passed_Int32_OwnedPlacementRule_Int32_Object_HashSet_1_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaceObjects_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPublicallyOpen_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEscalation_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditionalEscalation_Public_Int32_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEscalation_Public_Void_Actor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSecurityCamera_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsCrimeScene_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAlarmSystemTarget_Public_Virtual_New_Boolean_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAlarmActive_Public_Virtual_New_Boolean_byref_Single_byref_AlarmTargetMode_byref_List_1_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOutside_Public_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReplicableSeed_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetLoiteringTimer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoiteringPurchase_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEverything_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllInhabitantFurniture_Public_Void_Boolean_RemoveInteractablesOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayAccess_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSQM_Public_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrice_Public_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAIActions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsThisOutside_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowEmployeeDoors_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NewAddress thisAsAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisAsAddress);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisAsAddress)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
		}
	}

	public unsafe StreetController thisAsStreet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisAsStreet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreetController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisAsStreet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streetController));
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

	public unsafe DistrictController district
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_district);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DistrictController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_district)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)districtController));
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

	public unsafe MapAddressButtonController mapButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MapAddressButtonController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapAddressButtonController));
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

	public unsafe bool isCrimeScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCrimeScene);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCrimeScene)) = flag;
		}
	}

	public unsafe float loggedAsCrimeScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loggedAsCrimeScene);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loggedAsCrimeScene)) = num;
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

	public unsafe NewRoom nullRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe List<NewRoom> rooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<NewNode> nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Actor> currentOccupants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOccupants);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Actor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOccupants)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

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

	public unsafe List<ArtPreset> artPieces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artPieces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ArtPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_artPieces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool placedKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placedKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placedKey)) = flag;
		}
	}

	public unsafe List<Interactable> securityCameras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityCameras);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_securityCameras)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> stacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Telephone> telephones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephones);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Telephone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> resetBehaviourObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetBehaviourObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetBehaviourObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<FurnitureClass.OwnershipClass, Dictionary<FurnitureLocation, List<Human>>> furnitureBelongsTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureBelongsTo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<FurnitureClass.OwnershipClass, Dictionary<FurnitureLocation, List<Human>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureBelongsTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
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

	public unsafe NewNode.NodeAccess streetAccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetAccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode.NodeAccess>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetAccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeAccess));
		}
	}

	public unsafe NewNode anchorNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
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

	public unsafe Dictionary<AIActionPreset, List<Interactable>> nearestPublicActionReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestPublicActionReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AIActionPreset, List<Interactable>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearestPublicActionReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Actor, TrespassEscalation> escalation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Actor, TrespassEscalation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float playerLoiteringTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerLoiteringTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerLoiteringTimer)) = num;
		}
	}

	public unsafe EvidenceLocation evidenceEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceEntry);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidenceLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidenceLocation));
		}
	}

	public unsafe List<ObjectPlace> objectsToPlace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToPlace);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ObjectPlace>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToPlace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool objectPoolPlaced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPoolPlaced);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPoolPlaced)) = flag;
		}
	}

	static NewGameLocation()
	{
		Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NewGameLocation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr);
		NativeFieldInfoPtr_thisAsAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "thisAsAddress");
		NativeFieldInfoPtr_thisAsStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "thisAsStreet");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_district = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "district");
		NativeFieldInfoPtr_building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "building");
		NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "floor");
		NativeFieldInfoPtr_residenceNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "residenceNumber");
		NativeFieldInfoPtr_mapButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "mapButton");
		NativeFieldInfoPtr_isLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "isLobby");
		NativeFieldInfoPtr_isOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "isOutside");
		NativeFieldInfoPtr_isCrimeScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "isCrimeScene");
		NativeFieldInfoPtr_loggedAsCrimeScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "loggedAsCrimeScene");
		NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "access");
		NativeFieldInfoPtr_nullRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "nullRoom");
		NativeFieldInfoPtr_rooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "rooms");
		NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "nodes");
		NativeFieldInfoPtr_currentOccupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "currentOccupants");
		NativeFieldInfoPtr_designStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "designStyle");
		NativeFieldInfoPtr_artPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "artPieces");
		NativeFieldInfoPtr_placedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "placedKey");
		NativeFieldInfoPtr_securityCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "securityCameras");
		NativeFieldInfoPtr_stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "stacks");
		NativeFieldInfoPtr_telephones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "telephones");
		NativeFieldInfoPtr_resetBehaviourObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "resetBehaviourObjects");
		NativeFieldInfoPtr_furnitureBelongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "furnitureBelongsTo");
		NativeFieldInfoPtr_entrances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "entrances");
		NativeFieldInfoPtr_streetAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "streetAccess");
		NativeFieldInfoPtr_anchorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "anchorNode");
		NativeFieldInfoPtr_actionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "actionReference");
		NativeFieldInfoPtr_nearestPublicActionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "nearestPublicActionReference");
		NativeFieldInfoPtr_escalation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "escalation");
		NativeFieldInfoPtr_playerLoiteringTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "playerLoiteringTimer");
		NativeFieldInfoPtr_evidenceEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "evidenceEntry");
		NativeFieldInfoPtr_objectsToPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "objectsToPlace");
		NativeFieldInfoPtr_objectPoolPlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, "objectPoolPlaced");
		NativeMethodInfoPtr_CommonSetup_Public_Void_Boolean_DistrictController_DesignStylePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665593);
		NativeMethodInfoPtr_AddNewNode_Public_Void_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665594);
		NativeMethodInfoPtr_RemoveNode_Public_Void_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665595);
		NativeMethodInfoPtr_AddNewRoom_Public_Void_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665596);
		NativeMethodInfoPtr_RemoveRoom_Public_Void_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665597);
		NativeMethodInfoPtr_AddOccupant_Public_Virtual_New_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665598);
		NativeMethodInfoPtr_RemoveOccupant_Public_Virtual_New_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665599);
		NativeMethodInfoPtr_GetMainEntrance_Public_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665600);
		NativeMethodInfoPtr_SetDesignStyle_Public_Void_DesignStylePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665601);
		NativeMethodInfoPtr_AddEntrance_Public_Void_NewNode_NewNode_Boolean_AccessType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665602);
		NativeMethodInfoPtr_RemoveEntrance_Public_Void_NewNode_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665603);
		NativeMethodInfoPtr_PlaceObject_Public_Interactable_InteractablePreset_Human_Human_Human_byref_FurnitureLocation_Boolean_PassedVarType_Int32_Boolean_Int32_OwnedPlacementRule_Int32_RetailItemPreset_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665604);
		NativeMethodInfoPtr_PlaceObject_Public_Interactable_InteractablePreset_Human_Human_Human_byref_FurnitureLocation_List_1_Passed_Boolean_Int32_OwnedPlacementRule_Int32_Object_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665605);
		NativeMethodInfoPtr_GetBestSpawnLocation_Public_ObjectPlacement_InteractablePreset_Boolean_Human_Human_Human_byref_FurnitureLocation_List_1_Passed_Boolean_Int32_OwnedPlacementRule_Int32_Object_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665606);
		NativeMethodInfoPtr_GetPutDownLocation_Public_ObjectPlacement_InteractablePreset_byref_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665607);
		NativeMethodInfoPtr_AddToPlacementPool_Public_Void_InteractablePreset_Human_Human_Human_List_1_Passed_Int32_OwnedPlacementRule_Int32_Object_HashSet_1_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665608);
		NativeMethodInfoPtr_PlaceObjects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665609);
		NativeMethodInfoPtr_IsPublicallyOpen_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665610);
		NativeMethodInfoPtr_AddEscalation_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665611);
		NativeMethodInfoPtr_GetAdditionalEscalation_Public_Int32_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665612);
		NativeMethodInfoPtr_RemoveEscalation_Public_Void_Actor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665613);
		NativeMethodInfoPtr_AddSecurityCamera_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665614);
		NativeMethodInfoPtr_SetAsCrimeScene_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665615);
		NativeMethodInfoPtr_IsAlarmSystemTarget_Public_Virtual_New_Boolean_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665616);
		NativeMethodInfoPtr_IsAlarmActive_Public_Virtual_New_Boolean_byref_Single_byref_AlarmTargetMode_byref_List_1_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665617);
		NativeMethodInfoPtr_IsOutside_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665618);
		NativeMethodInfoPtr_GetReplicableSeed_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665619);
		NativeMethodInfoPtr_ResetLoiteringTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665620);
		NativeMethodInfoPtr_LoiteringPurchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665621);
		NativeMethodInfoPtr_RemoveEverything_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665622);
		NativeMethodInfoPtr_RemoveAllInhabitantFurniture_Public_Void_Boolean_RemoveInteractablesOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665623);
		NativeMethodInfoPtr_DisplayAccess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665624);
		NativeMethodInfoPtr_GetSQM_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665625);
		NativeMethodInfoPtr_GetPrice_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665626);
		NativeMethodInfoPtr_GetAIActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665627);
		NativeMethodInfoPtr_IsThisOutside_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665628);
		NativeMethodInfoPtr_AllowEmployeeDoors_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665629);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr, 100665630);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 82585, RefRangeEnd = 82589, XrefRangeStart = 82544, XrefRangeEnd = 82585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CommonSetup(bool newIsOutside, DistrictController newDistrict, DesignStylePreset newDefaultStyle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&newIsOutside);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newDistrict);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newDefaultStyle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CommonSetup_Public_Void_Boolean_DistrictController_DesignStylePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 82645, RefRangeEnd = 82650, XrefRangeStart = 82589, XrefRangeEnd = 82645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewNode(NewNode newNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewNode_Public_Void_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82653, RefRangeEnd = 82656, XrefRangeStart = 82650, XrefRangeEnd = 82653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveNode(NewNode newNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveNode_Public_Void_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82693, RefRangeEnd = 82696, XrefRangeStart = 82656, XrefRangeEnd = 82693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewRoom(NewRoom newRoom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNewRoom_Public_Void_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 82707, RefRangeEnd = 82712, XrefRangeStart = 82696, XrefRangeEnd = 82707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRoom(NewRoom newRoom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRoom_Public_Void_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82743, RefRangeEnd = 82744, XrefRangeStart = 82712, XrefRangeEnd = 82743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddOccupant(Actor newOcc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newOcc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddOccupant_Public_Virtual_New_Void_Actor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82775, RefRangeEnd = 82776, XrefRangeStart = 82744, XrefRangeEnd = 82775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveOccupant(Actor remOcc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remOcc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveOccupant_Public_Virtual_New_Void_Actor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82822, RefRangeEnd = 82825, XrefRangeStart = 82776, XrefRangeEnd = 82822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode.NodeAccess GetMainEntrance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainEntrance_Public_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode.NodeAccess>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 82865, RefRangeEnd = 82867, XrefRangeStart = 82825, XrefRangeEnd = 82865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDesignStyle(DesignStylePreset newStyle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newStyle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDesignStyle_Public_Void_DesignStylePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82970, RefRangeEnd = 82973, XrefRangeStart = 82867, XrefRangeEnd = 82970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82973, XrefRangeEnd = 83016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 83029, RefRangeEnd = 83038, XrefRangeStart = 83016, XrefRangeEnd = 83029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable PlaceObject(InteractablePreset interactable, Human belongsTo, Human writer, Human reciever, out FurnitureLocation pickedFurn, bool passVariable = false, Interactable.PassedVarType passedVarType = Interactable.PassedVarType.jobID, int passedValue = -1, bool forceSecuritySettings = false, int forcedSecurity = 0, InteractablePreset.OwnedPlacementRule forcedOwnership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int forcedPriority = 0, RetailItemPreset retailItem = null, bool printDebug = false, HashSet<NewRoom> dontPlaceInRooms = null, string loadGUID = null, NewNode placeClosestTo = null, string ddsOverride = "", bool ignoreLimits = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[19];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reciever);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &passVariable;
		*(Interactable.PassedVarType**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &passedVarType;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &passedValue;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSecuritySettings;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedSecurity;
		*(InteractablePreset.OwnedPlacementRule**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedOwnership;
		*(int**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedPriority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)retailItem);
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &printDebug;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dontPlaceInRooms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(loadGUID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placeClosestTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ddsOverride);
		*(bool**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreLimits;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaceObject_Public_Interactable_InteractablePreset_Human_Human_Human_byref_FurnitureLocation_Boolean_PassedVarType_Int32_Boolean_Int32_OwnedPlacementRule_Int32_RetailItemPreset_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		pickedFurn = ((num3 == 0) ? null : new FurnitureLocation(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 83104, RefRangeEnd = 83153, XrefRangeStart = 83038, XrefRangeEnd = 83104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable PlaceObject(InteractablePreset interactable, Human belongsTo, Human writer, Human receiver, out FurnitureLocation pickedFurn, List<Interactable.Passed> passedVars = null, bool forceSecuritySettings = false, int forcedSecurity = 0, InteractablePreset.OwnedPlacementRule forcedOwnership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int forcedPriority = 0, Il2CppSystem.Object passedObject = null, bool printDebug = false, HashSet<NewRoom> dontPlaceInRooms = null, string loadGUID = null, NewNode placeClosestTo = null, string ddsOverride = "", bool ignoreLimits = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[17];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSecuritySettings;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedSecurity;
		*(InteractablePreset.OwnedPlacementRule**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedOwnership;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedPriority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &printDebug;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dontPlaceInRooms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(loadGUID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placeClosestTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ddsOverride);
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreLimits;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaceObject_Public_Interactable_InteractablePreset_Human_Human_Human_byref_FurnitureLocation_List_1_Passed_Boolean_Int32_OwnedPlacementRule_Int32_Object_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		pickedFurn = ((num3 == 0) ? null : new FurnitureLocation(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 83648, RefRangeEnd = 83652, XrefRangeStart = 83153, XrefRangeEnd = 83648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectPlacement GetBestSpawnLocation(InteractablePreset interactable, bool warmItem, Human belongsTo, Human writer, Human receiver, out FurnitureLocation pickedFurn, List<Interactable.Passed> passedVars = null, bool forceSecuritySettings = false, int forcedSecurity = 0, InteractablePreset.OwnedPlacementRule forcedOwnership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int forcedPriority = 0, Il2CppSystem.Object passedObject = null, bool printDebug = false, HashSet<NewRoom> dontPlaceInRooms = null, string loadGUID = null, NewNode placeClosestTo = null, string ddsOverride = "", bool ignoreLimits = false, bool usePutDownPosition = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[19];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &warmItem;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSecuritySettings;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedSecurity;
		*(InteractablePreset.OwnedPlacementRule**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedOwnership;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedPriority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &printDebug;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dontPlaceInRooms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(loadGUID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placeClosestTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ddsOverride);
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreLimits;
		*(bool**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &usePutDownPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBestSpawnLocation_Public_ObjectPlacement_InteractablePreset_Boolean_Human_Human_Human_byref_FurnitureLocation_List_1_Passed_Boolean_Int32_OwnedPlacementRule_Int32_Object_Boolean_HashSet_1_NewRoom_String_NewNode_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		pickedFurn = ((num3 == 0) ? null : new FurnitureLocation(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPlacement>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83761, RefRangeEnd = 83762, XrefRangeStart = 83652, XrefRangeEnd = 83761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectPlacement GetPutDownLocation(InteractablePreset interactable, out FurnitureLocation pickedFurn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPutDownLocation_Public_ObjectPlacement_InteractablePreset_byref_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		pickedFurn = ((num3 == 0) ? null : new FurnitureLocation(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPlacement>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 83800, RefRangeEnd = 83809, XrefRangeStart = 83762, XrefRangeEnd = 83800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToPlacementPool(InteractablePreset interactable, Human belongsTo, Human writer, Human receiver, List<Interactable.Passed> passedVars = null, int security = 0, InteractablePreset.OwnedPlacementRule ownership = InteractablePreset.OwnedPlacementRule.nonOwnedOnly, int priority = 0, Il2CppSystem.Object passedObject = null, HashSet<NewRoom> dontPlaceInRooms = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &security;
		*(InteractablePreset.OwnedPlacementRule**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &ownership;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &priority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dontPlaceInRooms);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToPlacementPool_Public_Void_InteractablePreset_Human_Human_Human_List_1_Passed_Int32_OwnedPlacementRule_Int32_Object_HashSet_1_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85567, RefRangeEnd = 85568, XrefRangeStart = 83809, XrefRangeEnd = 85567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceObjects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaceObjects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 85648, RefRangeEnd = 85658, XrefRangeStart = 85568, XrefRangeEnd = 85648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPublicallyOpen(bool forPlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forPlayer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPublicallyOpen_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 85723, RefRangeEnd = 85726, XrefRangeStart = 85658, XrefRangeEnd = 85723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEscalation(Actor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEscalation_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 85729, RefRangeEnd = 85732, XrefRangeStart = 85726, XrefRangeEnd = 85729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAdditionalEscalation(Actor actor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdditionalEscalation_Public_Int32_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 85765, RefRangeEnd = 85767, XrefRangeStart = 85732, XrefRangeEnd = 85765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEscalation(Actor actor, bool removeAll = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeAll;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEscalation_Public_Void_Actor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85767, XrefRangeEnd = 85771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSecurityCamera(Interactable newInteractable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newInteractable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSecurityCamera_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 85815, RefRangeEnd = 85818, XrefRangeStart = 85771, XrefRangeEnd = 85815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsCrimeScene(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsCrimeScene_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsAlarmSystemTarget(Human human)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsAlarmSystemTarget_Public_Virtual_New_Boolean_Human_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsAlarmActive(out float retAlarmTimer, out NewBuilding.AlarmTargetMode retTargetMode, out List<Human> retTargets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref retAlarmTimer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref retTargetMode);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsAlarmActive_Public_Virtual_New_Boolean_byref_Single_byref_AlarmTargetMode_byref_List_1_Human_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		retTargets = ((num3 == 0) ? null : new List<Human>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsOutside()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsOutside_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85833, RefRangeEnd = 85834, XrefRangeStart = 85818, XrefRangeEnd = 85833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetReplicableSeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReplicableSeed_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ResetLoiteringTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetLoiteringTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85834, XrefRangeEnd = 85836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoiteringPurchase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoiteringPurchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85836, XrefRangeEnd = 85837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEverything()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEverything_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 85846, RefRangeEnd = 85856, XrefRangeStart = 85837, XrefRangeEnd = 85846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85856, XrefRangeEnd = 85904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayAccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayAccess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85921, RefRangeEnd = 85922, XrefRangeStart = 85904, XrefRangeEnd = 85921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSQM(bool print = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&print);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSQM_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 86026, RefRangeEnd = 86029, XrefRangeStart = 85922, XrefRangeEnd = 86026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPrice(bool print = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&print);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrice_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86029, XrefRangeEnd = 86054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAIActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAIActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86054, XrefRangeEnd = 86058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IsThisOutside()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsThisOutside_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86111, RefRangeEnd = 86113, XrefRangeStart = 86058, XrefRangeEnd = 86111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AllowEmployeeDoors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllowEmployeeDoors_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86189, RefRangeEnd = 86191, XrefRangeStart = 86113, XrefRangeEnd = 86189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewGameLocation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewGameLocation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NewGameLocation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
