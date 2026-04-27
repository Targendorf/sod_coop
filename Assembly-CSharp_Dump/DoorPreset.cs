using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class DoorPreset : SoCustomComparison
{
	public enum LockType
	{
		none,
		key,
		keypad
	}

	[System.Serializable]
	public class DoorSign : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_signagePool;

		private static readonly System.IntPtr NativeFieldInfoPtr_ifEntranceToRoom;

		private static readonly System.IntPtr NativeFieldInfoPtr_placeIfFromPublicArea;

		private static readonly System.IntPtr NativeFieldInfoPtr_placeIfFromOutside;

		private static readonly System.IntPtr NativeFieldInfoPtr_placeIfFromInside;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyPlaceIfInhabited;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<GameObject> signagePool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signagePool);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_signagePool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<RoomConfiguration> ifEntranceToRoom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifEntranceToRoom);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifEntranceToRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool placeIfFromPublicArea
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFromPublicArea);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFromPublicArea)) = flag;
			}
		}

		public unsafe bool placeIfFromOutside
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFromOutside);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFromOutside)) = flag;
			}
		}

		public unsafe bool placeIfFromInside
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFromInside);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeIfFromInside)) = flag;
			}
		}

		public unsafe bool onlyPlaceIfInhabited
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyPlaceIfInhabited);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyPlaceIfInhabited)) = flag;
			}
		}

		static DoorSign()
		{
			Il2CppClassPointerStore<DoorSign>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "DoorSign");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorSign>.NativeClassPtr);
			NativeFieldInfoPtr_signagePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSign>.NativeClassPtr, "signagePool");
			NativeFieldInfoPtr_ifEntranceToRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSign>.NativeClassPtr, "ifEntranceToRoom");
			NativeFieldInfoPtr_placeIfFromPublicArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSign>.NativeClassPtr, "placeIfFromPublicArea");
			NativeFieldInfoPtr_placeIfFromOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSign>.NativeClassPtr, "placeIfFromOutside");
			NativeFieldInfoPtr_placeIfFromInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSign>.NativeClassPtr, "placeIfFromInside");
			NativeFieldInfoPtr_onlyPlaceIfInhabited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSign>.NativeClassPtr, "onlyPlaceIfInhabited");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSign>.NativeClassPtr, 100673885);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328280, XrefRangeEnd = 328292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorSign()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorSign>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DoorSign(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ClosingBehaviour
	{
		nothing,
		closeOnCull,
		closeOnDespawn
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_doorModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_handleModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_handlePreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_handleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTransparent;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonRainGlassMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorSignOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorSigns;

	private static readonly System.IntPtr NativeFieldInfoPtr_inheritColouringFromDecor;

	private static readonly System.IntPtr NativeFieldInfoPtr_shareColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_variations;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorOpenSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_openAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_canPeakUnderneath;

	private static readonly System.IntPtr NativeFieldInfoPtr_closeBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockType;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockOffsetFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockOffsetRear;

	private static readonly System.IntPtr NativeFieldInfoPtr_armLockOnClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorStrengthRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockStrengthRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioCloseAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioUnlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioLockedEntryAttempt;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioKnockLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioKnockMed;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioKnockHeavy;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorBargeContact;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorBargeBreak;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject doorModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe InteractablePreset objectPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe GameObject handleModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handleModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handleModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe InteractablePreset handlePreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handlePreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handlePreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe Vector3 handleOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handleOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handleOffset)) = vector;
		}
	}

	public unsafe bool isTransparent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTransparent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTransparent)) = flag;
		}
	}

	public unsafe Material nonRainGlassMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonRainGlassMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonRainGlassMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Vector3 doorSignOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSignOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSignOffset)) = vector;
		}
	}

	public unsafe List<DoorSign> doorSigns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSigns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DoorSign>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorSigns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	public unsafe FurniturePreset.ShareColours shareColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColours);
			return *(FurniturePreset.ShareColours*)num;
		}
		set
		{
			*(FurniturePreset.ShareColours*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shareColours)) = shareColours;
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

	public unsafe float doorOpenSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOpenSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOpenSpeed)) = num;
		}
	}

	public unsafe float openAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openAngle)) = num;
		}
	}

	public unsafe bool canPeakUnderneath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPeakUnderneath);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPeakUnderneath)) = flag;
		}
	}

	public unsafe ClosingBehaviour closeBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeBehaviour);
			return *(ClosingBehaviour*)num;
		}
		set
		{
			*(ClosingBehaviour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeBehaviour)) = closingBehaviour;
		}
	}

	public unsafe LockType lockType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockType);
			return *(LockType*)num;
		}
		set
		{
			*(LockType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockType)) = lockType;
		}
	}

	public unsafe InteractablePreset lockInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockInteractable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe Vector3 lockOffsetFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffsetFront);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffsetFront)) = vector;
		}
	}

	public unsafe Vector3 lockOffsetRear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffsetRear);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockOffsetRear)) = vector;
		}
	}

	public unsafe bool armLockOnClose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armLockOnClose);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armLockOnClose)) = flag;
		}
	}

	public unsafe Vector2 doorStrengthRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorStrengthRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorStrengthRange)) = vector;
		}
	}

	public unsafe Vector2 lockStrengthRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockStrengthRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockStrengthRange)) = vector;
		}
	}

	public unsafe AudioEvent audioOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioOpen);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioOpen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioClose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClose);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClose)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioCloseAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioCloseAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioCloseAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioLock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioLock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioUnlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioUnlock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioUnlock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioLockedEntryAttempt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioLockedEntryAttempt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioLockedEntryAttempt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioKnockLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioKnockLight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioKnockLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioKnockMed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioKnockMed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioKnockMed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent audioKnockHeavy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioKnockHeavy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioKnockHeavy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent doorBargeContact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorBargeContact);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorBargeContact)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent doorBargeBreak
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorBargeBreak);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorBargeBreak)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	static DoorPreset()
	{
		Il2CppClassPointerStore<DoorPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DoorPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr);
		NativeFieldInfoPtr_doorModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "doorModel");
		NativeFieldInfoPtr_objectPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "objectPreset");
		NativeFieldInfoPtr_handleModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "handleModel");
		NativeFieldInfoPtr_handlePreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "handlePreset");
		NativeFieldInfoPtr_handleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "handleOffset");
		NativeFieldInfoPtr_isTransparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "isTransparent");
		NativeFieldInfoPtr_nonRainGlassMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "nonRainGlassMaterial");
		NativeFieldInfoPtr_doorSignOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "doorSignOffset");
		NativeFieldInfoPtr_doorSigns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "doorSigns");
		NativeFieldInfoPtr_inheritColouringFromDecor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "inheritColouringFromDecor");
		NativeFieldInfoPtr_shareColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "shareColours");
		NativeFieldInfoPtr_variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "variations");
		NativeFieldInfoPtr_doorOpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "doorOpenSpeed");
		NativeFieldInfoPtr_openAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "openAngle");
		NativeFieldInfoPtr_canPeakUnderneath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "canPeakUnderneath");
		NativeFieldInfoPtr_closeBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "closeBehaviour");
		NativeFieldInfoPtr_lockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "lockType");
		NativeFieldInfoPtr_lockInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "lockInteractable");
		NativeFieldInfoPtr_lockOffsetFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "lockOffsetFront");
		NativeFieldInfoPtr_lockOffsetRear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "lockOffsetRear");
		NativeFieldInfoPtr_armLockOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "armLockOnClose");
		NativeFieldInfoPtr_doorStrengthRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "doorStrengthRange");
		NativeFieldInfoPtr_lockStrengthRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "lockStrengthRange");
		NativeFieldInfoPtr_audioOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioOpen");
		NativeFieldInfoPtr_audioClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioClose");
		NativeFieldInfoPtr_audioCloseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioCloseAction");
		NativeFieldInfoPtr_audioLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioLock");
		NativeFieldInfoPtr_audioUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioUnlock");
		NativeFieldInfoPtr_audioLockedEntryAttempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioLockedEntryAttempt");
		NativeFieldInfoPtr_audioKnockLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioKnockLight");
		NativeFieldInfoPtr_audioKnockMed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioKnockMed");
		NativeFieldInfoPtr_audioKnockHeavy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "audioKnockHeavy");
		NativeFieldInfoPtr_doorBargeContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "doorBargeContact");
		NativeFieldInfoPtr_doorBargeBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, "doorBargeBreak");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr, 100673884);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328292, XrefRangeEnd = 328306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoorPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoorPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
