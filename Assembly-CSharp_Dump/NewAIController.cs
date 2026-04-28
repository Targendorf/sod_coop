using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class NewAIController : MonoBehaviour
{
	[System.Serializable]
	public class TrackingTarget : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actor;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastValidSighting;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorityTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_attractionRank;

		private static readonly System.IntPtr NativeFieldInfoPtr_distance;

		private static readonly System.IntPtr NativeFieldInfoPtr_distanceRank;

		private static readonly System.IntPtr NativeFieldInfoPtr_fovRank;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemRank;

		private static readonly System.IntPtr NativeFieldInfoPtr_lookAtRank;

		private static readonly System.IntPtr NativeFieldInfoPtr_active;

		private static readonly System.IntPtr NativeFieldInfoPtr_spookedByItem;

		private static readonly System.IntPtr NativeFieldInfoPtr_spookTimer;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Actor actor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
			}
		}

		public unsafe float lastValidSighting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastValidSighting);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastValidSighting)) = num;
			}
		}

		public unsafe bool priorityTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorityTarget);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorityTarget)) = flag;
			}
		}

		public unsafe float attractionRank
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractionRank);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractionRank)) = num;
			}
		}

		public unsafe float distance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance)) = num;
			}
		}

		public unsafe float distanceRank
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRank);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceRank)) = num;
			}
		}

		public unsafe float fovRank
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovRank);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fovRank)) = num;
			}
		}

		public unsafe float itemRank
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRank);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRank)) = num;
			}
		}

		public unsafe float lookAtRank
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtRank);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtRank)) = num;
			}
		}

		public unsafe bool active
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active)) = flag;
			}
		}

		public unsafe bool spookedByItem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookedByItem);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookedByItem)) = flag;
			}
		}

		public unsafe int spookTimer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookTimer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookTimer)) = num;
			}
		}

		static TrackingTarget()
		{
			Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "TrackingTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr);
			NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "actor");
			NativeFieldInfoPtr_lastValidSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "lastValidSighting");
			NativeFieldInfoPtr_priorityTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "priorityTarget");
			NativeFieldInfoPtr_attractionRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "attractionRank");
			NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "distance");
			NativeFieldInfoPtr_distanceRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "distanceRank");
			NativeFieldInfoPtr_fovRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "fovRank");
			NativeFieldInfoPtr_itemRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "itemRank");
			NativeFieldInfoPtr_lookAtRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "lookAtRank");
			NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "active");
			NativeFieldInfoPtr_spookedByItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "spookedByItem");
			NativeFieldInfoPtr_spookTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, "spookTimer");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr, 100664598);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackingTarget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackingTarget>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TrackingTarget(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ChaseLogic : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ai;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastSeenPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastSeenNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastSeenDirection;

		private static readonly System.IntPtr NativeFieldInfoPtr_projectedNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_projectedPosition;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLastSeen_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateProjectedNode_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe NewAIController ai
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ai);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ai)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIController));
			}
		}

		public unsafe Vector3 lastSeenPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeenPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeenPosition)) = vector;
			}
		}

		public unsafe NewNode lastSeenNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeenNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeenNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe Vector3 lastSeenDirection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeenDirection);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSeenDirection)) = vector;
			}
		}

		public unsafe NewNode projectedNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectedNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectedNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe Vector3 projectedPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectedPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectedPosition)) = vector;
			}
		}

		static ChaseLogic()
		{
			Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "ChaseLogic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr);
			NativeFieldInfoPtr_ai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, "ai");
			NativeFieldInfoPtr_lastSeenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, "lastSeenPosition");
			NativeFieldInfoPtr_lastSeenNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, "lastSeenNode");
			NativeFieldInfoPtr_lastSeenDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, "lastSeenDirection");
			NativeFieldInfoPtr_projectedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, "projectedNode");
			NativeFieldInfoPtr_projectedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, "projectedPosition");
			NativeMethodInfoPtr_UpdateLastSeen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, 100664599);
			NativeMethodInfoPtr_GenerateProjectedNode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, 100664600);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr, 100664601);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39153, RefRangeEnd = 39154, XrefRangeStart = 39106, XrefRangeEnd = 39153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLastSeen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLastSeen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39321, RefRangeEnd = 39322, XrefRangeStart = 39154, XrefRangeEnd = 39321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateProjectedNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateProjectedNode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChaseLogic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChaseLogic>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ChaseLogic(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum InvestigationUrgency
	{
		walk,
		run
	}

	public enum ReactionState
	{
		none,
		investigatingSight,
		investigatingSound,
		persuing,
		searching
	}

	public enum AITickRate
	{
		veryLow,
		low,
		medium,
		high,
		veryHigh
	}

	public class QueuedAction : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeFieldInfoPtr_actionSetting;

		private static readonly System.IntPtr NativeFieldInfoPtr_delay;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Interactable interactable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		public unsafe InteractablePreset.InteractionAction actionSetting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSetting);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset.InteractionAction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSetting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionAction));
			}
		}

		public unsafe float delay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay)) = num;
			}
		}

		static QueuedAction()
		{
			Il2CppClassPointerStore<QueuedAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "QueuedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueuedAction>.NativeClassPtr);
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedAction>.NativeClassPtr, "interactable");
			NativeFieldInfoPtr_actionSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedAction>.NativeClassPtr, "actionSetting");
			NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedAction>.NativeClassPtr, "delay");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueuedAction>.NativeClassPtr, 100664602);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueuedAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueuedAction>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public QueuedAction(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("NewAIController+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__178_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__178_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__178_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__190_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__200_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__200_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__212_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__214_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__214_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__242_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__263_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__263_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AITick_b__178_2_Internal_Boolean_Murder_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AITick_b__178_0_Internal_Int32_NewAIGoal_NewAIGoal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AITick_b__178_1_Internal_Boolean_Murder_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__MovementUpdate_b__190_0_Internal_Boolean_TrackingTarget_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReachNewPathNode_b__200_0_Internal_Boolean_Actor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReachNewPathNode_b__200_1_Internal_Boolean_Actor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateTrackedTargets_b__212_0_Internal_Int32_TrackingTarget_TrackingTarget_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OnNewTrackTarget_b__214_0_Internal_Boolean_NewAIAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OnNewTrackTarget_b__214_1_Internal_Boolean_NewAIAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Investigate_b__242_0_Internal_Boolean_TrackingTarget_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AnswerPhone_b__263_0_Internal_Boolean_NewAIGoal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AnswerPhone_b__263_1_Internal_Boolean_NewAIAction_0;

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

		public unsafe static Il2CppSystem.Predicate<MurderController.Murder> __9__178_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__178_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<MurderController.Murder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__178_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<NewAIGoal> __9__178_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__178_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<NewAIGoal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__178_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<MurderController.Murder> __9__178_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__178_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<MurderController.Murder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__178_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<TrackingTarget> __9__190_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__190_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<TrackingTarget>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__190_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Actor> __9__200_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__200_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Actor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__200_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Actor> __9__200_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__200_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Actor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__200_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<TrackingTarget> __9__212_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__212_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<TrackingTarget>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__212_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIAction> __9__214_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__214_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIAction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__214_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIAction> __9__214_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__214_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIAction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__214_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<TrackingTarget> __9__242_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__242_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<TrackingTarget>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__242_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIGoal> __9__263_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__263_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIGoal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__263_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIAction> __9__263_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__263_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIAction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__263_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__178_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__178_2");
			NativeFieldInfoPtr___9__178_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__178_0");
			NativeFieldInfoPtr___9__178_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__178_1");
			NativeFieldInfoPtr___9__190_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__190_0");
			NativeFieldInfoPtr___9__200_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__200_0");
			NativeFieldInfoPtr___9__200_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__200_1");
			NativeFieldInfoPtr___9__212_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__212_0");
			NativeFieldInfoPtr___9__214_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__214_0");
			NativeFieldInfoPtr___9__214_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__214_1");
			NativeFieldInfoPtr___9__242_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__242_0");
			NativeFieldInfoPtr___9__263_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__263_0");
			NativeFieldInfoPtr___9__263_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__263_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664604);
			NativeMethodInfoPtr__AITick_b__178_2_Internal_Boolean_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664605);
			NativeMethodInfoPtr__AITick_b__178_0_Internal_Int32_NewAIGoal_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664606);
			NativeMethodInfoPtr__AITick_b__178_1_Internal_Boolean_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664607);
			NativeMethodInfoPtr__MovementUpdate_b__190_0_Internal_Boolean_TrackingTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664608);
			NativeMethodInfoPtr__ReachNewPathNode_b__200_0_Internal_Boolean_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664609);
			NativeMethodInfoPtr__ReachNewPathNode_b__200_1_Internal_Boolean_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664610);
			NativeMethodInfoPtr__UpdateTrackedTargets_b__212_0_Internal_Int32_TrackingTarget_TrackingTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664611);
			NativeMethodInfoPtr__OnNewTrackTarget_b__214_0_Internal_Boolean_NewAIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664612);
			NativeMethodInfoPtr__OnNewTrackTarget_b__214_1_Internal_Boolean_NewAIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664613);
			NativeMethodInfoPtr__Investigate_b__242_0_Internal_Boolean_TrackingTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664614);
			NativeMethodInfoPtr__AnswerPhone_b__263_0_Internal_Boolean_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664615);
			NativeMethodInfoPtr__AnswerPhone_b__263_1_Internal_Boolean_NewAIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664616);
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
		public unsafe bool _AITick_b__178_2(MurderController.Murder item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AITick_b__178_2_Internal_Boolean_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _AITick_b__178_0(NewAIGoal p2, NewAIGoal p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AITick_b__178_0_Internal_Int32_NewAIGoal_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _AITick_b__178_1(MurderController.Murder item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AITick_b__178_1_Internal_Boolean_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39322, XrefRangeEnd = 39333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _MovementUpdate_b__190_0(TrackingTarget item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MovementUpdate_b__190_0_Internal_Boolean_TrackingTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ReachNewPathNode_b__200_0(Actor item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReachNewPathNode_b__200_0_Internal_Boolean_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ReachNewPathNode_b__200_1(Actor item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReachNewPathNode_b__200_1_Internal_Boolean_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _UpdateTrackedTargets_b__212_0(TrackingTarget a1, TrackingTarget a2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateTrackedTargets_b__212_0_Internal_Int32_TrackingTarget_TrackingTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39333, XrefRangeEnd = 39335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnNewTrackTarget_b__214_0(NewAIAction item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnNewTrackTarget_b__214_0_Internal_Boolean_NewAIAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39335, XrefRangeEnd = 39337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnNewTrackTarget_b__214_1(NewAIAction item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnNewTrackTarget_b__214_1_Internal_Boolean_NewAIAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39337, XrefRangeEnd = 39348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Investigate_b__242_0(TrackingTarget item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Investigate_b__242_0_Internal_Boolean_TrackingTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AnswerPhone_b__263_0(NewAIGoal item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AnswerPhone_b__263_0_Internal_Boolean_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39348, XrefRangeEnd = 39350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AnswerPhone_b__263_1(NewAIAction item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AnswerPhone_b__263_1_Internal_Boolean_NewAIAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewAIController+<>c__DisplayClass209_0")]
	public sealed class __c__DisplayClass209_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newTracked;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddTrackedTarget_b__0_Internal_Boolean_TrackingTarget_0;

		public unsafe Actor newTracked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newTracked);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newTracked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
			}
		}

		static __c__DisplayClass209_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass209_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "<>c__DisplayClass209_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass209_0>.NativeClassPtr);
			NativeFieldInfoPtr_newTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass209_0>.NativeClassPtr, "newTracked");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass209_0>.NativeClassPtr, 100664617);
			NativeMethodInfoPtr__AddTrackedTarget_b__0_Internal_Boolean_TrackingTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass209_0>.NativeClassPtr, 100664618);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass209_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass209_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39350, XrefRangeEnd = 39357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AddTrackedTarget_b__0(TrackingTarget item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddTrackedTarget_b__0_Internal_Boolean_TrackingTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass209_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewAIController+<>c__DisplayClass215_0")]
	public sealed class __c__DisplayClass215_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_target;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__IsMuggingValid_b__0_Internal_Boolean_Acquaintance_0;

		public unsafe Human target
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		static __c__DisplayClass215_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass215_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "<>c__DisplayClass215_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass215_0>.NativeClassPtr);
			NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass215_0>.NativeClassPtr, "target");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass215_0>.NativeClassPtr, 100664619);
			NativeMethodInfoPtr__IsMuggingValid_b__0_Internal_Boolean_Acquaintance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass215_0>.NativeClassPtr, 100664620);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass215_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass215_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39357, XrefRangeEnd = 39364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _IsMuggingValid_b__0(Acquaintance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__IsMuggingValid_b__0_Internal_Boolean_Acquaintance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass215_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("NewAIController+<>c__DisplayClass262_0")]
	public sealed class __c__DisplayClass262_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dc;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AnswerDoor_b__0_Internal_Boolean_NewAIGoal_0;

		public unsafe NewDoor dc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewDoor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newDoor));
			}
		}

		static __c__DisplayClass262_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "<>c__DisplayClass262_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr);
			NativeFieldInfoPtr_dc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr, "dc");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr, 100664621);
			NativeMethodInfoPtr__AnswerDoor_b__0_Internal_Boolean_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr, 100664622);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass262_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass262_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39364, XrefRangeEnd = 39369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AnswerDoor_b__0(NewAIGoal item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AnswerDoor_b__0_Internal_Boolean_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass262_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_human;

	private static readonly System.IntPtr NativeFieldInfoPtr_capCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_delta;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_nourishment;

	private static readonly System.IntPtr NativeFieldInfoPtr_hydration;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertness;

	private static readonly System.IntPtr NativeFieldInfoPtr_energy;

	private static readonly System.IntPtr NativeFieldInfoPtr_excitement;

	private static readonly System.IntPtr NativeFieldInfoPtr_chores;

	private static readonly System.IntPtr NativeFieldInfoPtr_hygiene;

	private static readonly System.IntPtr NativeFieldInfoPtr_bladder;

	private static readonly System.IntPtr NativeFieldInfoPtr_heat;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_breath;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_blink;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugSeesPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLastSeesPlayerChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_hearsIllegal;

	private static readonly System.IntPtr NativeFieldInfoPtr_hearTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_goals;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentGoal;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_investigationGoal;

	private static readonly System.IntPtr NativeFieldInfoPtr_patrolGoal;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFurnitureUser;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFurnitureNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextAIAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_kidnapper;

	private static readonly System.IntPtr NativeFieldInfoPtr_confineLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_avoidLocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_pathCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDestinationNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDesitnationNodeCoord;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDestinationPositon;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceToNext;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastMovementRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_doIMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepDistanceCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightFootNext;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTripping;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorCheckDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_openedDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorInteractions;

	private static readonly System.IntPtr NativeFieldInfoPtr_facingActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_facingDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceTransformOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_facingQuat;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookingQuatPrevious;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookingQuatLastFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookingQuatCurrent;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAroundTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAroundPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackedTargets;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTrackTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAtTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAtTransformRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_original;

	private static readonly System.IntPtr NativeFieldInfoPtr_dirXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_forwardXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_dirYZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_forwardYZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentExpression;

	private static readonly System.IntPtr NativeFieldInfoPtr_expressionProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_blinkInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_blinkTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyesOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_bargeTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuitTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_investigateLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_investigatePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_investigatePositionProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_investigateObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_tamperedObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_investigationUrgency;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioFocusAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastInvestigate;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuitUpdateTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuit;

	private static readonly System.IntPtr NativeFieldInfoPtr_seesOnPersuit;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuitChaseLogicUses;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumInvestigationTimeMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_chaseLogic;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionIndicator;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionState;

	private static readonly System.IntPtr NativeFieldInfoPtr_patrolLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_inCombat;

	private static readonly System.IntPtr NativeFieldInfoPtr_inFleeState;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticFromAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_staticAnimationSafetyTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeAttackBar;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_revolverShots;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageColliderCreated;

	private static readonly System.IntPtr NativeFieldInfoPtr_ejectBrassCreated;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackActiveLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_ko;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRagdoll;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragController;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollPositionUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_koTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_koTransitionTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_getUpDelayTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_deadRagdollTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_restrained;

	private static readonly System.IntPtr NativeFieldInfoPtr_outOfBreath;

	private static readonly System.IntPtr NativeFieldInfoPtr_restrainTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWeapon;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWeaponPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponRangeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponRefire;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponAccuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredTickRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousTickRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_tickRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_dueUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayedUntil;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSnore;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeAtCurrentAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkTripCheckTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorCheckProcessTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastGameLocationUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleMovementAnimationLerpRequired;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableTickRateUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayedGoalsForTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayedActionsForTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastMuggingTimestamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedRightItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedLeftItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_customItemSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_usingCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_combatMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_throwItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_throwActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_throwDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontEverCloseDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimsForMurders;

	private static readonly System.IntPtr NativeFieldInfoPtr_killerForMurders;

	private static readonly System.IntPtr NativeFieldInfoPtr_isConvicted;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePointBusyRecursion;

	private static readonly System.IntPtr NativeFieldInfoPtr_closeDoorsNormallyAfterLeaving;

	private static readonly System.IntPtr NativeFieldInfoPtr_putDownItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkIdleTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_restrainedIdleTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_appliedNerveEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_tickActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_spooked;

	private static readonly System.IntPtr NativeFieldInfoPtr_spookCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_spookForgetCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_noPathTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_noPathCorrectionAttempts;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugDestinationPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLastHeardIllegalAudio;

	private static readonly System.IntPtr NativeFieldInfoPtr_rem;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AITick_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewGoal_Public_NewAIGoal_AIGoalPreset_Single_Single_NewNode_Interactable_NewGameLocation_SocialGroup_Murder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewAction_Public_NewAIAction_NewAIGoal_AIActionPreset_Boolean_NewRoom_Interactable_NewNode_SocialGroup_List_1_InteractablePreset_Boolean_Int32_NewAIAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StatusStatUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleteGoal_Public_Void_NewAIGoal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDesiredTickRate_Public_Void_AITickRate_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTickRate_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FrequentUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MovementSpeedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HearingUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StatesUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PersuitUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MovementUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimulateFootprints_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationalLerpValue_Private_Single_Quaternion_Quaternion_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FacingUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttackUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentKillTarget_Public_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KOUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParentPositionToRagdollLimbPosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUpdateEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampNeckRotation_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReachNewPathNode_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoorCheckProcess_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDestinationNode_Public_Void_NewNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DynamicReRoute_Private_Boolean_NewNode_NewNode_NewNode_byref_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFaceTravelDirection_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFacingPosition_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFacingDirection_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFacingTransform_Public_Void_Transform_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLookAtTransform_Public_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTrackedTarget_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrackingSpookCheck_Private_Void_TrackingTarget_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHumanDrawnWeapon_Public_Void_Human_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTrackedTargets_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTrackTarget_Public_Void_TrackingTarget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNewTrackTarget_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMuggingValid_Public_Boolean_Human_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLookAtTargetAt_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnVisibilityChanged_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExpression_Public_Void_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDebugAction_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugTeleportPlayerToLocation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveSleep_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSleep_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveFood_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFood_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveDrink_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrink_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveCaffeine_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCaffeine_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveFun_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFun_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveBladder_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBladder_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveHygiene_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHygiene_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GiveDrunk_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrunk_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MurderButton_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugMovement_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trip_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateProjectedChasePosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HearIllegal_Public_Void_AudioEvent_NewNode_Vector3_Actor_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Investigate_Public_Void_NewNode_Vector3_Actor_ReactionState_Single_Int32_Boolean_Single_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInvestigationUrgency_Public_Void_InvestigationUrgency_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPersue_Public_Void_Actor_Boolean_Int32_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPersueTarget_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelPersue_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPersuit_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSeesOnPersuit_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetInvestigate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Patrol_Public_Void_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartAttack_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowObject_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAttackComplete_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAttackBlock_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAbortAttack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAttackDelay_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndAttack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TalkTo_Public_Void_ConversationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnReturnFromTalkTo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStunned_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDelayed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnswerDoor_Public_Void_NewDoor_NewGameLocation_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnswerPhone_Public_Void_Telephone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwakenPrompt_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayCurrentRoute_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInCombat_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateWeaponStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetKO_Public_Void_Boolean_Vector3_Vector3_Boolean_Single_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOutOfBreath_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRestrained_Public_Void_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReactionState_Public_Void_ReactionState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TriggerReactionIndicator_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugDestinationPosition_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelCombat_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsVictim_Public_Void_Murder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsMurderer_Public_Void_Murder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStaticFromAnimation_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseDoorsNormallyAfterLeavingGamelocation_Public_Void_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCurrentWeapon_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentWeapon_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHeldItems_Public_Void_ActionStateFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DespawnRightItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DespawnLeftItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstantPersuitCheck_Public_Void_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableAI_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConfineLocation_Public_Void_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAvoidLocation_Public_Void_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAvoidLocation_Public_Void_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConfinedLocation_Public_NewGameLocation_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanIgnoreLockedDoors_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpooked_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTrespassingAtActionDestination_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentGoalTriggerTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceNodeReached_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestinationCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenEvidenceFirstName_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenEvidenceName_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenEvidencePhoto_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToggleHumanDebug_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintCurrentNodePosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateGameLocation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugNextJobHours_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__StatusStatUpdate_b__181_0_Private_Boolean_TrackingTarget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SetParentPositionToRagdollLimbPosition_b__197_0_Private_Boolean_ObjectiveTrigger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__DoorCheckProcess_b__201_0_Private_Boolean_NewAIAction_0;

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

	public unsafe CapsuleCollider capCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capCollider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capCollider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)capsuleCollider));
		}
	}

	public unsafe float delta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delta)) = num;
		}
	}

	public unsafe float prevDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevDelta)) = num;
		}
	}

	public unsafe float nourishment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment)) = num;
		}
	}

	public unsafe float hydration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration)) = num;
		}
	}

	public unsafe float alertness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness)) = num;
		}
	}

	public unsafe float energy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy)) = num;
		}
	}

	public unsafe float excitement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement)) = num;
		}
	}

	public unsafe float chores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores)) = num;
		}
	}

	public unsafe float hygiene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene)) = num;
		}
	}

	public unsafe float bladder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder)) = num;
		}
	}

	public unsafe float heat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat)) = num;
		}
	}

	public unsafe float drunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk)) = num;
		}
	}

	public unsafe float breath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath)) = num;
		}
	}

	public unsafe float idleSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleSound);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleSound)) = num;
		}
	}

	public unsafe float blink
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blink);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blink)) = num;
		}
	}

	public unsafe int debugSeesPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugSeesPlayer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugSeesPlayer)) = num;
		}
	}

	public unsafe float debugLastSeesPlayerChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastSeesPlayerChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastSeesPlayerChange)) = num;
		}
	}

	public unsafe float hearsIllegal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearsIllegal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearsIllegal)) = num;
		}
	}

	public unsafe Actor hearTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
		}
	}

	public unsafe List<NewAIGoal> goals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goals);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewAIGoal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe NewAIGoal currentGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGoal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIGoal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIGoal));
		}
	}

	public unsafe NewAIAction currentAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIAction));
		}
	}

	public unsafe NewAIGoal investigationGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigationGoal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIGoal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigationGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIGoal));
		}
	}

	public unsafe NewAIGoal patrolGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_patrolGoal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIGoal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_patrolGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIGoal));
		}
	}

	public unsafe FurnitureLocation currentFurnitureUser
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFurnitureUser);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFurnitureUser)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureLocation));
		}
	}

	public unsafe NewNode currentFurnitureNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFurnitureNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFurnitureNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe Interactable nextAIAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextAIAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextAIAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe Human kidnapper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe NewGameLocation confineLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confineLocation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confineLocation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGameLocation));
		}
	}

	public unsafe List<NewGameLocation> avoidLocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidLocations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewGameLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidLocations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int pathCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathCursor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathCursor)) = num;
		}
	}

	public unsafe NewNode currentDestinationNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDestinationNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDestinationNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe Vector3 currentDesitnationNodeCoord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDesitnationNodeCoord);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDesitnationNodeCoord)) = vector;
		}
	}

	public unsafe Vector3 currentDestinationPositon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDestinationPositon);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDestinationPositon)) = vector;
		}
	}

	public unsafe float movementAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementAmount)) = num;
		}
	}

	public unsafe float distanceToNext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceToNext);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceToNext)) = num;
		}
	}

	public unsafe Quaternion lastMovementRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMovementRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMovementRotation)) = quaternion;
		}
	}

	public unsafe bool doIMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doIMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doIMove)) = flag;
		}
	}

	public unsafe float footStepDistanceCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepDistanceCounter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepDistanceCounter)) = num;
		}
	}

	public unsafe bool rightFootNext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightFootNext);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightFootNext)) = flag;
		}
	}

	public unsafe bool isTripping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTripping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTripping)) = flag;
		}
	}

	public unsafe bool doorCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheck)) = flag;
		}
	}

	public unsafe NewDoor doorCheckDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheckDoor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewDoor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheckDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newDoor));
		}
	}

	public unsafe NewDoor openedDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openedDoor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewDoor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openedDoor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newDoor));
		}
	}

	public unsafe int delayFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayFlag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayFlag)) = num;
		}
	}

	public unsafe List<NewDoor> doorInteractions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorInteractions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewDoor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorInteractions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool facingActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingActive)) = flag;
		}
	}

	public unsafe Vector3 facingDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingDirection)) = vector;
		}
	}

	public unsafe Transform faceTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Vector3 faceTransformOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceTransformOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceTransformOffset)) = vector;
		}
	}

	public unsafe Quaternion facingQuat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingQuat);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facingQuat)) = quaternion;
		}
	}

	public unsafe Quaternion lookingQuatPrevious
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookingQuatPrevious);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookingQuatPrevious)) = quaternion;
		}
	}

	public unsafe Quaternion lookingQuatLastFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookingQuatLastFrame);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookingQuatLastFrame)) = quaternion;
		}
	}

	public unsafe Quaternion lookingQuatCurrent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookingQuatCurrent);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookingQuatCurrent)) = quaternion;
		}
	}

	public unsafe float lookAroundTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAroundTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAroundTimer)) = num;
		}
	}

	public unsafe Vector3 lookAroundPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAroundPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAroundPosition)) = vector;
		}
	}

	public unsafe List<TrackingTarget> trackedTargets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackedTargets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TrackingTarget>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackedTargets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TrackingTarget currentTrackTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTrackTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TrackingTarget>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTrackTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackingTarget));
		}
	}

	public unsafe Transform lookAtTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe float lookAtTransformRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtTransformRank);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtTransformRank)) = num;
		}
	}

	public unsafe Quaternion original
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_original);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_original)) = quaternion;
		}
	}

	public unsafe Vector3 dirXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirXZ);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirXZ)) = vector;
		}
	}

	public unsafe Vector3 forwardXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardXZ);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardXZ)) = vector;
		}
	}

	public unsafe Vector3 dirYZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirYZ);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirYZ)) = vector;
		}
	}

	public unsafe Vector3 forwardYZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardYZ);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardYZ)) = vector;
		}
	}

	public unsafe CitizenOutfitController.ExpressionSetup currentExpression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentExpression);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitizenOutfitController.ExpressionSetup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentExpression)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expressionSetup));
		}
	}

	public unsafe float expressionProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expressionProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expressionProgress)) = num;
		}
	}

	public unsafe bool blinkInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinkInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinkInProgress)) = flag;
		}
	}

	public unsafe float blinkTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinkTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinkTimer)) = num;
		}
	}

	public unsafe float eyesOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyesOpen);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyesOpen)) = num;
		}
	}

	public unsafe float bargeTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bargeTimer)) = num;
		}
	}

	public unsafe Actor persuitTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
		}
	}

	public unsafe NewNode investigateLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateLocation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateLocation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe Vector3 investigatePosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePosition)) = vector;
		}
	}

	public unsafe Vector3 investigatePositionProjection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePositionProjection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePositionProjection)) = vector;
		}
	}

	public unsafe Interactable investigateObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe Interactable tamperedObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperedObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperedObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe InvestigationUrgency investigationUrgency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigationUrgency);
			return *(InvestigationUrgency*)num;
		}
		set
		{
			*(InvestigationUrgency*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigationUrgency)) = investigationUrgency;
		}
	}

	public unsafe NewAIAction audioFocusAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioFocusAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioFocusAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIAction));
		}
	}

	public unsafe float lastInvestigate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInvestigate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInvestigate)) = num;
		}
	}

	public unsafe float persuitUpdateTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitUpdateTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitUpdateTimer)) = num;
		}
	}

	public unsafe bool persuit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuit)) = flag;
		}
	}

	public unsafe bool seesOnPersuit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seesOnPersuit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seesOnPersuit)) = flag;
		}
	}

	public unsafe float persuitChaseLogicUses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitChaseLogicUses);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitChaseLogicUses)) = num;
		}
	}

	public unsafe float minimumInvestigationTimeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumInvestigationTimeMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumInvestigationTimeMultiplier)) = num;
		}
	}

	public unsafe ChaseLogic chaseLogic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chaseLogic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChaseLogic>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chaseLogic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chaseLogic));
		}
	}

	public unsafe ReactionIndicatorController reactionIndicator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionIndicator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReactionIndicatorController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionIndicator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reactionIndicatorController));
		}
	}

	public unsafe ReactionState reactionState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionState);
			return *(ReactionState*)num;
		}
		set
		{
			*(ReactionState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionState)) = reactionState;
		}
	}

	public unsafe NewGameLocation patrolLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_patrolLocation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_patrolLocation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGameLocation));
		}
	}

	public unsafe bool inCombat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inCombat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inCombat)) = flag;
		}
	}

	public unsafe bool inFleeState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inFleeState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inFleeState)) = flag;
		}
	}

	public unsafe bool staticFromAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticFromAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticFromAnimation)) = flag;
		}
	}

	public unsafe float staticAnimationSafetyTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticAnimationSafetyTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staticAnimationSafetyTimer)) = num;
		}
	}

	public unsafe bool attackActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackActive)) = flag;
		}
	}

	public unsafe Actor attackTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
		}
	}

	public unsafe AttackBarController activeAttackBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeAttackBar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttackBarController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeAttackBar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackBarController));
		}
	}

	public unsafe float attackTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTimeout);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTimeout)) = num;
		}
	}

	public unsafe float attackProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackProgress)) = num;
		}
	}

	public unsafe int revolverShots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_revolverShots);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_revolverShots)) = num;
		}
	}

	public unsafe bool damageColliderCreated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageColliderCreated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageColliderCreated)) = flag;
		}
	}

	public unsafe bool ejectBrassCreated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectBrassCreated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectBrassCreated)) = flag;
		}
	}

	public unsafe DamageColliderController damageCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageCollider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DamageColliderController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageCollider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damageColliderController));
		}
	}

	public unsafe float attackDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDelay)) = num;
		}
	}

	public unsafe float attackActiveLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackActiveLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackActiveLength)) = num;
		}
	}

	public unsafe bool ko
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ko);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ko)) = flag;
		}
	}

	public unsafe bool isRagdoll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRagdoll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRagdoll)) = flag;
		}
	}

	public unsafe RigidbodyDragObject dragController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RigidbodyDragObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbodyDragObject));
		}
	}

	public unsafe RagdollPositionUpdater ragdollPositionUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollPositionUpdate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RagdollPositionUpdater>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollPositionUpdate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ragdollPositionUpdater));
		}
	}

	public unsafe float koTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTime)) = num;
		}
	}

	public unsafe float koTransitionTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTransitionTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTransitionTimer)) = num;
		}
	}

	public unsafe float getUpDelayTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpDelayTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpDelayTimer)) = num;
		}
	}

	public unsafe float deadRagdollTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadRagdollTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadRagdollTimer)) = num;
		}
	}

	public unsafe bool restrained
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrained);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrained)) = flag;
		}
	}

	public unsafe bool outOfBreath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outOfBreath);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outOfBreath)) = flag;
		}
	}

	public unsafe float restrainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrainTime)) = num;
		}
	}

	public unsafe Interactable currentWeapon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeapon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeapon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe MurderWeaponPreset currentWeaponPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeaponPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MurderWeaponPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeaponPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)murderWeaponPreset));
		}
	}

	public unsafe float weaponRangeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRangeMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRangeMax)) = num;
		}
	}

	public unsafe float weaponRefire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRefire);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRefire)) = num;
		}
	}

	public unsafe float weaponAccuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponAccuracy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponAccuracy)) = num;
		}
	}

	public unsafe float weaponDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponDamage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponDamage)) = num;
		}
	}

	public unsafe AITickRate desiredTickRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredTickRate);
			return *(AITickRate*)num;
		}
		set
		{
			*(AITickRate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredTickRate)) = aITickRate;
		}
	}

	public unsafe AITickRate previousTickRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousTickRate);
			return *(AITickRate*)num;
		}
		set
		{
			*(AITickRate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousTickRate)) = aITickRate;
		}
	}

	public unsafe AITickRate tickRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tickRate);
			return *(AITickRate*)num;
		}
		set
		{
			*(AITickRate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tickRate)) = aITickRate;
		}
	}

	public unsafe bool dueUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dueUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dueUpdate)) = flag;
		}
	}

	public unsafe float delayedUntil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedUntil);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedUntil)) = num;
		}
	}

	public unsafe float lastUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdated);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdated)) = num;
		}
	}

	public unsafe float lastSnore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSnore);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSnore)) = num;
		}
	}

	public unsafe float timeSinceLastUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSinceLastUpdate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSinceLastUpdate)) = num;
		}
	}

	public unsafe float timeAtCurrentAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAtCurrentAddress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAtCurrentAddress)) = num;
		}
	}

	public unsafe float drunkTripCheckTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkTripCheckTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkTripCheckTimer)) = num;
		}
	}

	public unsafe int doorCheckProcessTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheckProcessTimer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCheckProcessTimer)) = num;
		}
	}

	public unsafe float lastGameLocationUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGameLocationUpdate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGameLocationUpdate)) = num;
		}
	}

	public unsafe bool visibleMovementAnimationLerpRequired
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleMovementAnimationLerpRequired);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleMovementAnimationLerpRequired)) = flag;
		}
	}

	public unsafe bool disableTickRateUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableTickRateUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableTickRateUpdate)) = flag;
		}
	}

	public unsafe Dictionary<AIGoalPreset, float> delayedGoalsForTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedGoalsForTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AIGoalPreset, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedGoalsForTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<AIActionPreset, float> delayedActionsForTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedActionsForTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AIActionPreset, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedActionsForTime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<QueuedAction> queuedActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<QueuedAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float lastMuggingTimestamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMuggingTimestamp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMuggingTimestamp)) = num;
		}
	}

	public unsafe GameObject spawnedRightItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedRightItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedRightItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject spawnedLeftItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedLeftItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedLeftItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe NewAIAction customItemSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customItemSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customItemSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIAction));
		}
	}

	public unsafe bool usingCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usingCarryAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usingCarryAnimation)) = flag;
		}
	}

	public unsafe int combatMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combatMode)) = num;
		}
	}

	public unsafe InteractablePreset throwItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe bool throwActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwActive)) = flag;
		}
	}

	public unsafe float throwDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwDelay)) = num;
		}
	}

	public unsafe bool dontEverCloseDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontEverCloseDoors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontEverCloseDoors)) = flag;
		}
	}

	public unsafe List<MurderController.Murder> victimsForMurders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimsForMurders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderController.Murder>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimsForMurders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MurderController.Murder> killerForMurders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killerForMurders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderController.Murder>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killerForMurders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool isConvicted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConvicted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConvicted)) = flag;
		}
	}

	public unsafe bool usePointBusyRecursion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePointBusyRecursion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePointBusyRecursion)) = flag;
		}
	}

	public unsafe NewGameLocation closeDoorsNormallyAfterLeaving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeDoorsNormallyAfterLeaving);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeDoorsNormallyAfterLeaving)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGameLocation));
		}
	}

	public unsafe List<Interactable> putDownItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDownItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float drunkIdleTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkIdleTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkIdleTimer)) = num;
		}
	}

	public unsafe float restrainedIdleTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrainedIdleTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrainedIdleTimer)) = num;
		}
	}

	public unsafe Dictionary<Human, float> appliedNerveEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedNerveEffect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Human, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedNerveEffect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool tickActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tickActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tickActive)) = flag;
		}
	}

	public unsafe float spooked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spooked);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spooked)) = num;
		}
	}

	public unsafe int spookCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookCounter)) = num;
		}
	}

	public unsafe float spookForgetCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookForgetCounter);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookForgetCounter)) = num;
		}
	}

	public unsafe float noPathTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPathTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPathTimer)) = num;
		}
	}

	public unsafe int noPathCorrectionAttempts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPathCorrectionAttempts);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPathCorrectionAttempts)) = num;
		}
	}

	public unsafe List<string> lastActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> debugDestinationPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDestinationPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDestinationPosition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string jobDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobDebug);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobDebug)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool debugMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMovement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMovement)) = flag;
		}
	}

	public unsafe AudioEvent debugLastHeardIllegalAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastHeardIllegalAudio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastHeardIllegalAudio)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe List<AIActionPreset> rem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static NewAIController()
	{
		Il2CppClassPointerStore<NewAIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NewAIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewAIController>.NativeClassPtr);
		NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "human");
		NativeFieldInfoPtr_capCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "capCollider");
		NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "delta");
		NativeFieldInfoPtr_prevDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "prevDelta");
		NativeFieldInfoPtr_nourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "nourishment");
		NativeFieldInfoPtr_hydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "hydration");
		NativeFieldInfoPtr_alertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "alertness");
		NativeFieldInfoPtr_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "energy");
		NativeFieldInfoPtr_excitement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "excitement");
		NativeFieldInfoPtr_chores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "chores");
		NativeFieldInfoPtr_hygiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "hygiene");
		NativeFieldInfoPtr_bladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "bladder");
		NativeFieldInfoPtr_heat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "heat");
		NativeFieldInfoPtr_drunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "drunk");
		NativeFieldInfoPtr_breath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "breath");
		NativeFieldInfoPtr_idleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "idleSound");
		NativeFieldInfoPtr_blink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "blink");
		NativeFieldInfoPtr_debugSeesPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "debugSeesPlayer");
		NativeFieldInfoPtr_debugLastSeesPlayerChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "debugLastSeesPlayerChange");
		NativeFieldInfoPtr_hearsIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "hearsIllegal");
		NativeFieldInfoPtr_hearTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "hearTarget");
		NativeFieldInfoPtr_goals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "goals");
		NativeFieldInfoPtr_currentGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentGoal");
		NativeFieldInfoPtr_currentAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentAction");
		NativeFieldInfoPtr_investigationGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "investigationGoal");
		NativeFieldInfoPtr_patrolGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "patrolGoal");
		NativeFieldInfoPtr_currentFurnitureUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentFurnitureUser");
		NativeFieldInfoPtr_currentFurnitureNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentFurnitureNode");
		NativeFieldInfoPtr_nextAIAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "nextAIAction");
		NativeFieldInfoPtr_kidnapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "kidnapper");
		NativeFieldInfoPtr_confineLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "confineLocation");
		NativeFieldInfoPtr_avoidLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "avoidLocations");
		NativeFieldInfoPtr_pathCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "pathCursor");
		NativeFieldInfoPtr_currentDestinationNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentDestinationNode");
		NativeFieldInfoPtr_currentDesitnationNodeCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentDesitnationNodeCoord");
		NativeFieldInfoPtr_currentDestinationPositon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentDestinationPositon");
		NativeFieldInfoPtr_movementAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "movementAmount");
		NativeFieldInfoPtr_distanceToNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "distanceToNext");
		NativeFieldInfoPtr_lastMovementRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lastMovementRotation");
		NativeFieldInfoPtr_doIMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "doIMove");
		NativeFieldInfoPtr_footStepDistanceCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "footStepDistanceCounter");
		NativeFieldInfoPtr_rightFootNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "rightFootNext");
		NativeFieldInfoPtr_isTripping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "isTripping");
		NativeFieldInfoPtr_doorCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "doorCheck");
		NativeFieldInfoPtr_doorCheckDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "doorCheckDoor");
		NativeFieldInfoPtr_openedDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "openedDoor");
		NativeFieldInfoPtr_delayFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "delayFlag");
		NativeFieldInfoPtr_doorInteractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "doorInteractions");
		NativeFieldInfoPtr_facingActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "facingActive");
		NativeFieldInfoPtr_facingDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "facingDirection");
		NativeFieldInfoPtr_faceTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "faceTransform");
		NativeFieldInfoPtr_faceTransformOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "faceTransformOffset");
		NativeFieldInfoPtr_facingQuat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "facingQuat");
		NativeFieldInfoPtr_lookingQuatPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lookingQuatPrevious");
		NativeFieldInfoPtr_lookingQuatLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lookingQuatLastFrame");
		NativeFieldInfoPtr_lookingQuatCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lookingQuatCurrent");
		NativeFieldInfoPtr_lookAroundTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lookAroundTimer");
		NativeFieldInfoPtr_lookAroundPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lookAroundPosition");
		NativeFieldInfoPtr_trackedTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "trackedTargets");
		NativeFieldInfoPtr_currentTrackTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentTrackTarget");
		NativeFieldInfoPtr_lookAtTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lookAtTransform");
		NativeFieldInfoPtr_lookAtTransformRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lookAtTransformRank");
		NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "original");
		NativeFieldInfoPtr_dirXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "dirXZ");
		NativeFieldInfoPtr_forwardXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "forwardXZ");
		NativeFieldInfoPtr_dirYZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "dirYZ");
		NativeFieldInfoPtr_forwardYZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "forwardYZ");
		NativeFieldInfoPtr_currentExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentExpression");
		NativeFieldInfoPtr_expressionProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "expressionProgress");
		NativeFieldInfoPtr_blinkInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "blinkInProgress");
		NativeFieldInfoPtr_blinkTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "blinkTimer");
		NativeFieldInfoPtr_eyesOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "eyesOpen");
		NativeFieldInfoPtr_bargeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "bargeTimer");
		NativeFieldInfoPtr_persuitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "persuitTarget");
		NativeFieldInfoPtr_investigateLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "investigateLocation");
		NativeFieldInfoPtr_investigatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "investigatePosition");
		NativeFieldInfoPtr_investigatePositionProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "investigatePositionProjection");
		NativeFieldInfoPtr_investigateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "investigateObject");
		NativeFieldInfoPtr_tamperedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "tamperedObject");
		NativeFieldInfoPtr_investigationUrgency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "investigationUrgency");
		NativeFieldInfoPtr_audioFocusAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "audioFocusAction");
		NativeFieldInfoPtr_lastInvestigate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lastInvestigate");
		NativeFieldInfoPtr_persuitUpdateTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "persuitUpdateTimer");
		NativeFieldInfoPtr_persuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "persuit");
		NativeFieldInfoPtr_seesOnPersuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "seesOnPersuit");
		NativeFieldInfoPtr_persuitChaseLogicUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "persuitChaseLogicUses");
		NativeFieldInfoPtr_minimumInvestigationTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "minimumInvestigationTimeMultiplier");
		NativeFieldInfoPtr_chaseLogic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "chaseLogic");
		NativeFieldInfoPtr_reactionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "reactionIndicator");
		NativeFieldInfoPtr_reactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "reactionState");
		NativeFieldInfoPtr_patrolLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "patrolLocation");
		NativeFieldInfoPtr_inCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "inCombat");
		NativeFieldInfoPtr_inFleeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "inFleeState");
		NativeFieldInfoPtr_staticFromAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "staticFromAnimation");
		NativeFieldInfoPtr_staticAnimationSafetyTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "staticAnimationSafetyTimer");
		NativeFieldInfoPtr_attackActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "attackActive");
		NativeFieldInfoPtr_attackTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "attackTarget");
		NativeFieldInfoPtr_activeAttackBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "activeAttackBar");
		NativeFieldInfoPtr_attackTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "attackTimeout");
		NativeFieldInfoPtr_attackProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "attackProgress");
		NativeFieldInfoPtr_revolverShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "revolverShots");
		NativeFieldInfoPtr_damageColliderCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "damageColliderCreated");
		NativeFieldInfoPtr_ejectBrassCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "ejectBrassCreated");
		NativeFieldInfoPtr_damageCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "damageCollider");
		NativeFieldInfoPtr_attackDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "attackDelay");
		NativeFieldInfoPtr_attackActiveLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "attackActiveLength");
		NativeFieldInfoPtr_ko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "ko");
		NativeFieldInfoPtr_isRagdoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "isRagdoll");
		NativeFieldInfoPtr_dragController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "dragController");
		NativeFieldInfoPtr_ragdollPositionUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "ragdollPositionUpdate");
		NativeFieldInfoPtr_koTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "koTime");
		NativeFieldInfoPtr_koTransitionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "koTransitionTimer");
		NativeFieldInfoPtr_getUpDelayTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "getUpDelayTimer");
		NativeFieldInfoPtr_deadRagdollTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "deadRagdollTimer");
		NativeFieldInfoPtr_restrained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "restrained");
		NativeFieldInfoPtr_outOfBreath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "outOfBreath");
		NativeFieldInfoPtr_restrainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "restrainTime");
		NativeFieldInfoPtr_currentWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentWeapon");
		NativeFieldInfoPtr_currentWeaponPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "currentWeaponPreset");
		NativeFieldInfoPtr_weaponRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "weaponRangeMax");
		NativeFieldInfoPtr_weaponRefire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "weaponRefire");
		NativeFieldInfoPtr_weaponAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "weaponAccuracy");
		NativeFieldInfoPtr_weaponDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "weaponDamage");
		NativeFieldInfoPtr_desiredTickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "desiredTickRate");
		NativeFieldInfoPtr_previousTickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "previousTickRate");
		NativeFieldInfoPtr_tickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "tickRate");
		NativeFieldInfoPtr_dueUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "dueUpdate");
		NativeFieldInfoPtr_delayedUntil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "delayedUntil");
		NativeFieldInfoPtr_lastUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lastUpdated");
		NativeFieldInfoPtr_lastSnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lastSnore");
		NativeFieldInfoPtr_timeSinceLastUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "timeSinceLastUpdate");
		NativeFieldInfoPtr_timeAtCurrentAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "timeAtCurrentAddress");
		NativeFieldInfoPtr_drunkTripCheckTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "drunkTripCheckTimer");
		NativeFieldInfoPtr_doorCheckProcessTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "doorCheckProcessTimer");
		NativeFieldInfoPtr_lastGameLocationUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lastGameLocationUpdate");
		NativeFieldInfoPtr_visibleMovementAnimationLerpRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "visibleMovementAnimationLerpRequired");
		NativeFieldInfoPtr_disableTickRateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "disableTickRateUpdate");
		NativeFieldInfoPtr_delayedGoalsForTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "delayedGoalsForTime");
		NativeFieldInfoPtr_delayedActionsForTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "delayedActionsForTime");
		NativeFieldInfoPtr_queuedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "queuedActions");
		NativeFieldInfoPtr_lastMuggingTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lastMuggingTimestamp");
		NativeFieldInfoPtr_spawnedRightItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "spawnedRightItem");
		NativeFieldInfoPtr_spawnedLeftItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "spawnedLeftItem");
		NativeFieldInfoPtr_customItemSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "customItemSource");
		NativeFieldInfoPtr_usingCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "usingCarryAnimation");
		NativeFieldInfoPtr_combatMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "combatMode");
		NativeFieldInfoPtr_throwItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "throwItem");
		NativeFieldInfoPtr_throwActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "throwActive");
		NativeFieldInfoPtr_throwDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "throwDelay");
		NativeFieldInfoPtr_dontEverCloseDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "dontEverCloseDoors");
		NativeFieldInfoPtr_victimsForMurders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "victimsForMurders");
		NativeFieldInfoPtr_killerForMurders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "killerForMurders");
		NativeFieldInfoPtr_isConvicted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "isConvicted");
		NativeFieldInfoPtr_usePointBusyRecursion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "usePointBusyRecursion");
		NativeFieldInfoPtr_closeDoorsNormallyAfterLeaving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "closeDoorsNormallyAfterLeaving");
		NativeFieldInfoPtr_putDownItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "putDownItems");
		NativeFieldInfoPtr_drunkIdleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "drunkIdleTimer");
		NativeFieldInfoPtr_restrainedIdleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "restrainedIdleTimer");
		NativeFieldInfoPtr_appliedNerveEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "appliedNerveEffect");
		NativeFieldInfoPtr_tickActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "tickActive");
		NativeFieldInfoPtr_spooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "spooked");
		NativeFieldInfoPtr_spookCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "spookCounter");
		NativeFieldInfoPtr_spookForgetCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "spookForgetCounter");
		NativeFieldInfoPtr_noPathTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "noPathTimer");
		NativeFieldInfoPtr_noPathCorrectionAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "noPathCorrectionAttempts");
		NativeFieldInfoPtr_lastActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "lastActions");
		NativeFieldInfoPtr_debugDestinationPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "debugDestinationPosition");
		NativeFieldInfoPtr_jobDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "jobDebug");
		NativeFieldInfoPtr_debugMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "debugMovement");
		NativeFieldInfoPtr_debugLastHeardIllegalAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "debugLastHeardIllegalAudio");
		NativeFieldInfoPtr_rem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, "rem");
		NativeMethodInfoPtr_Setup_Public_Void_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664467);
		NativeMethodInfoPtr_AITick_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664468);
		NativeMethodInfoPtr_CreateNewGoal_Public_NewAIGoal_AIGoalPreset_Single_Single_NewNode_Interactable_NewGameLocation_SocialGroup_Murder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664469);
		NativeMethodInfoPtr_CreateNewAction_Public_NewAIAction_NewAIGoal_AIActionPreset_Boolean_NewRoom_Interactable_NewNode_SocialGroup_List_1_InteractablePreset_Boolean_Int32_NewAIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664470);
		NativeMethodInfoPtr_StatusStatUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664471);
		NativeMethodInfoPtr_OnCompleteGoal_Public_Void_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664472);
		NativeMethodInfoPtr_SetDesiredTickRate_Public_Void_AITickRate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664473);
		NativeMethodInfoPtr_UpdateTickRate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664474);
		NativeMethodInfoPtr_FrequentUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664475);
		NativeMethodInfoPtr_MovementSpeedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664476);
		NativeMethodInfoPtr_HearingUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664477);
		NativeMethodInfoPtr_StatesUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664478);
		NativeMethodInfoPtr_PersuitUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664479);
		NativeMethodInfoPtr_MovementUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664480);
		NativeMethodInfoPtr_SimulateFootprints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664481);
		NativeMethodInfoPtr_GetRotationalLerpValue_Private_Single_Quaternion_Quaternion_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664482);
		NativeMethodInfoPtr_FacingUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664483);
		NativeMethodInfoPtr_AttackUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664484);
		NativeMethodInfoPtr_GetCurrentKillTarget_Public_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664485);
		NativeMethodInfoPtr_KOUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664486);
		NativeMethodInfoPtr_SetParentPositionToRagdollLimbPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664487);
		NativeMethodInfoPtr_SetUpdateEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664488);
		NativeMethodInfoPtr_ClampNeckRotation_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664489);
		NativeMethodInfoPtr_ReachNewPathNode_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664490);
		NativeMethodInfoPtr_DoorCheckProcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664491);
		NativeMethodInfoPtr_SetDestinationNode_Public_Void_NewNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664492);
		NativeMethodInfoPtr_DynamicReRoute_Private_Boolean_NewNode_NewNode_NewNode_byref_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664493);
		NativeMethodInfoPtr_SetFaceTravelDirection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664494);
		NativeMethodInfoPtr_SetFacingPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664495);
		NativeMethodInfoPtr_SetFacingDirection_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664496);
		NativeMethodInfoPtr_SetFacingTransform_Public_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664497);
		NativeMethodInfoPtr_SetLookAtTransform_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664498);
		NativeMethodInfoPtr_AddTrackedTarget_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664499);
		NativeMethodInfoPtr_TrackingSpookCheck_Private_Void_TrackingTarget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664500);
		NativeMethodInfoPtr_UpdateHumanDrawnWeapon_Public_Void_Human_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_UpdateTrackedTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_SetTrackTarget_Public_Void_TrackingTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664503);
		NativeMethodInfoPtr_OnNewTrackTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664504);
		NativeMethodInfoPtr_IsMuggingValid_Public_Boolean_Human_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664505);
		NativeMethodInfoPtr_RemoveLookAtTargetAt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664506);
		NativeMethodInfoPtr_OnVisibilityChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664507);
		NativeMethodInfoPtr_SetExpression_Public_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664508);
		NativeMethodInfoPtr_AddDebugAction_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664509);
		NativeMethodInfoPtr_DebugTeleportPlayerToLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664510);
		NativeMethodInfoPtr_GiveSleep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664511);
		NativeMethodInfoPtr_RemoveSleep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664512);
		NativeMethodInfoPtr_GiveFood_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664513);
		NativeMethodInfoPtr_RemoveFood_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664514);
		NativeMethodInfoPtr_GiveDrink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664515);
		NativeMethodInfoPtr_RemoveDrink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664516);
		NativeMethodInfoPtr_GiveCaffeine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_RemoveCaffeine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_GiveFun_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_RemoveFun_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_GiveBladder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr_RemoveBladder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664522);
		NativeMethodInfoPtr_GiveHygiene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_RemoveHygiene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_GiveDrunk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664525);
		NativeMethodInfoPtr_RemoveDrunk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664526);
		NativeMethodInfoPtr_MurderButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664527);
		NativeMethodInfoPtr_DebugMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664528);
		NativeMethodInfoPtr_Trip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664529);
		NativeMethodInfoPtr_UpdateProjectedChasePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664530);
		NativeMethodInfoPtr_HearIllegal_Public_Void_AudioEvent_NewNode_Vector3_Actor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664531);
		NativeMethodInfoPtr_Investigate_Public_Void_NewNode_Vector3_Actor_ReactionState_Single_Int32_Boolean_Single_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664532);
		NativeMethodInfoPtr_SetInvestigationUrgency_Public_Void_InvestigationUrgency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_SetPersue_Public_Void_Actor_Boolean_Int32_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_SetPersueTarget_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_CancelPersue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_SetPersuit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_SetSeesOnPersuit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_ResetInvestigate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_Patrol_Public_Void_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_StartAttack_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_ThrowObject_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_OnAttackComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_OnAttackBlock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_OnAbortAttack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_SetAttackDelay_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664546);
		NativeMethodInfoPtr_EndAttack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr_TalkTo_Public_Void_ConversationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_OnReturnFromTalkTo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_SetStunned_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_SetDelayed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr_AnswerDoor_Public_Void_NewDoor_NewGameLocation_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_AnswerPhone_Public_Void_Telephone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr_AwakenPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664554);
		NativeMethodInfoPtr_DisplayCurrentRoute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr_SetInCombat_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664556);
		NativeMethodInfoPtr_RecalculateWeaponStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_SetKO_Public_Void_Boolean_Vector3_Vector3_Boolean_Single_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_SetOutOfBreath_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664559);
		NativeMethodInfoPtr_SetRestrained_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664560);
		NativeMethodInfoPtr_SetReactionState_Public_Void_ReactionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_TriggerReactionIndicator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_DebugDestinationPosition_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664563);
		NativeMethodInfoPtr_CancelCombat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664564);
		NativeMethodInfoPtr_SetAsVictim_Public_Void_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664565);
		NativeMethodInfoPtr_SetAsMurderer_Public_Void_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664566);
		NativeMethodInfoPtr_SetStaticFromAnimation_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664567);
		NativeMethodInfoPtr_GetRotationState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664568);
		NativeMethodInfoPtr_CloseDoorsNormallyAfterLeavingGamelocation_Public_Void_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664569);
		NativeMethodInfoPtr_UpdateCurrentWeapon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664570);
		NativeMethodInfoPtr_SetCurrentWeapon_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664571);
		NativeMethodInfoPtr_UpdateHeldItems_Public_Void_ActionStateFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664572);
		NativeMethodInfoPtr_DespawnRightItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664573);
		NativeMethodInfoPtr_DespawnLeftItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664574);
		NativeMethodInfoPtr_InstantPersuitCheck_Public_Void_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664575);
		NativeMethodInfoPtr_EnableAI_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664576);
		NativeMethodInfoPtr_SetConfineLocation_Public_Void_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664577);
		NativeMethodInfoPtr_AddAvoidLocation_Public_Void_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664578);
		NativeMethodInfoPtr_RemoveAvoidLocation_Public_Void_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664579);
		NativeMethodInfoPtr_CheckConfinedLocation_Public_NewGameLocation_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664580);
		NativeMethodInfoPtr_CanIgnoreLockedDoors_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664581);
		NativeMethodInfoPtr_AddSpooked_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664582);
		NativeMethodInfoPtr_IsTrespassingAtActionDestination_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664583);
		NativeMethodInfoPtr_CurrentGoalTriggerTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664584);
		NativeMethodInfoPtr_ForceNodeReached_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664585);
		NativeMethodInfoPtr_DestinationCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664586);
		NativeMethodInfoPtr_OpenEvidenceFirstName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664587);
		NativeMethodInfoPtr_OpenEvidenceName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664588);
		NativeMethodInfoPtr_OpenEvidencePhoto_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664589);
		NativeMethodInfoPtr_ToggleHumanDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664590);
		NativeMethodInfoPtr_PrintCurrentNodePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664591);
		NativeMethodInfoPtr_ForceUpdateGameLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664592);
		NativeMethodInfoPtr_DebugNextJobHours_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664593);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664594);
		NativeMethodInfoPtr__StatusStatUpdate_b__181_0_Private_Boolean_TrackingTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664595);
		NativeMethodInfoPtr__SetParentPositionToRagdollLimbPosition_b__197_0_Private_Boolean_ObjectiveTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr__DoorCheckProcess_b__201_0_Private_Boolean_NewAIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewAIController>.NativeClassPtr, 100664597);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39387, RefRangeEnd = 39388, XrefRangeStart = 39369, XrefRangeEnd = 39387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(Human newParent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newParent);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 39595, RefRangeEnd = 39618, XrefRangeStart = 39388, XrefRangeEnd = 39595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AITick(bool forceUpdatePriorities = false, bool ignoreRepeatDelays = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forceUpdatePriorities);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreRepeatDelays;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AITick_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 39632, RefRangeEnd = 39662, XrefRangeStart = 39618, XrefRangeEnd = 39632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewAIGoal CreateNewGoal(AIGoalPreset newPreset, float newTrigerTime, float newDuration, NewNode newPassedNode = null, Interactable newPassedInteractable = null, NewGameLocation newPassedGameLocation = null, GroupsController.SocialGroup newPassedGroup = null, MurderController.Murder newMurderRef = null, int newPassedVar = -2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newTrigerTime;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newDuration;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedInteractable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedGameLocation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMurderRef);
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &newPassedVar;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewGoal_Public_NewAIGoal_AIGoalPreset_Single_Single_NewNode_Interactable_NewGameLocation_SocialGroup_Murder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIGoal>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 39687, RefRangeEnd = 39700, XrefRangeStart = 39662, XrefRangeEnd = 39687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewAIAction CreateNewAction(NewAIGoal newGoal, AIActionPreset newPreset, bool newInsertedAction = false, NewRoom newPassedRoom = null, Interactable newPassedInteractable = null, NewNode newForcedNode = null, GroupsController.SocialGroup newPassedGroup = null, List<InteractablePreset> newPassedAcquireItems = null, bool newForceRun = false, int newInsertedActionPriority = 3, NewAIAction newCreatedFor = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGoal);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newInsertedAction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedRoom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedInteractable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newForcedNode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPassedAcquireItems);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &newForceRun;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &newInsertedActionPriority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCreatedFor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewAction_Public_NewAIAction_NewAIGoal_AIActionPreset_Boolean_NewRoom_Interactable_NewNode_SocialGroup_List_1_InteractablePreset_Boolean_Int32_NewAIAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAIAction>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 39832, RefRangeEnd = 39834, XrefRangeStart = 39700, XrefRangeEnd = 39832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StatusStatUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StatusStatUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39834, XrefRangeEnd = 39839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCompleteGoal(NewAIGoal completed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)completed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCompleteGoal_Public_Void_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 39842, RefRangeEnd = 39852, XrefRangeStart = 39839, XrefRangeEnd = 39842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDesiredTickRate(AITickRate newRate, bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newRate);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDesiredTickRate_Public_Void_AITickRate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 39869, RefRangeEnd = 39874, XrefRangeStart = 39852, XrefRangeEnd = 39869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTickRate(bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceUpdate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTickRate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 39949, RefRangeEnd = 39953, XrefRangeStart = 39874, XrefRangeEnd = 39949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FrequentUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FrequentUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40115, RefRangeEnd = 40117, XrefRangeStart = 39953, XrefRangeEnd = 40115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MovementSpeedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MovementSpeedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40117, XrefRangeEnd = 40122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HearingUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HearingUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40122, XrefRangeEnd = 40134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StatesUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StatesUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40300, RefRangeEnd = 40302, XrefRangeStart = 40134, XrefRangeEnd = 40300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PersuitUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PersuitUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40603, RefRangeEnd = 40605, XrefRangeStart = 40302, XrefRangeEnd = 40603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MovementUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MovementUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40605, XrefRangeEnd = 40610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SimulateFootprints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimulateFootprints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40610, XrefRangeEnd = 40613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetRotationalLerpValue(Quaternion originalRotation, Quaternion targetRotation, float multiplier, out float angleBetween)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&originalRotation);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetRotation;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &multiplier;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref angleBetween);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationalLerpValue_Private_Single_Quaternion_Quaternion_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40647, RefRangeEnd = 40649, XrefRangeStart = 40613, XrefRangeEnd = 40647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FacingUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FacingUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40954, RefRangeEnd = 40955, XrefRangeStart = 40649, XrefRangeEnd = 40954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AttackUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttackUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40962, RefRangeEnd = 40965, XrefRangeStart = 40955, XrefRangeEnd = 40962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Human GetCurrentKillTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentKillTarget_Public_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41073, RefRangeEnd = 41074, XrefRangeStart = 40965, XrefRangeEnd = 41073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void KOUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KOUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41202, RefRangeEnd = 41204, XrefRangeStart = 41074, XrefRangeEnd = 41202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParentPositionToRagdollLimbPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParentPositionToRagdollLimbPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 41232, RefRangeEnd = 41247, XrefRangeStart = 41204, XrefRangeEnd = 41232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUpdateEnabled(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUpdateEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41267, RefRangeEnd = 41270, XrefRangeStart = 41247, XrefRangeEnd = 41267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClampNeckRotation(bool setNeckAngles = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&setNeckAngles);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampNeckRotation_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41549, RefRangeEnd = 41552, XrefRangeStart = 41270, XrefRangeEnd = 41549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReachNewPathNode(bool scanForNextNodeFurniture = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scanForNextNodeFurniture);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReachNewPathNode_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41653, RefRangeEnd = 41655, XrefRangeStart = 41552, XrefRangeEnd = 41653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoorCheckProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoorCheckProcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41904, RefRangeEnd = 41907, XrefRangeStart = 41655, XrefRangeEnd = 41904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDestinationNode(NewNode newLocation, bool scanForNextNodeFurniture = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLocation);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scanForNextNodeFurniture;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDestinationNode_Public_Void_NewNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41997, RefRangeEnd = 41998, XrefRangeStart = 41907, XrefRangeEnd = 41997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DynamicReRoute(NewNode current, NewNode avoidThis, NewNode beyond, out NewNode bestAvoidanceTile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)current);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)avoidThis);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)beyond);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DynamicReRoute_Private_Boolean_NewNode_NewNode_NewNode_byref_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		bestAvoidanceTile = ((num3 == 0) ? null : new NewNode(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41998, XrefRangeEnd = 41999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFaceTravelDirection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFaceTravelDirection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 42039, RefRangeEnd = 42042, XrefRangeStart = 41999, XrefRangeEnd = 42039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFacingPosition(Vector3 newLookPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLookPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFacingPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42059, RefRangeEnd = 42060, XrefRangeStart = 42042, XrefRangeEnd = 42059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFacingDirection(Vector3 newLookDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLookDirection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFacingDirection_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42060, XrefRangeEnd = 42083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFacingTransform(Transform newLookAt, Vector3 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLookAt);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFacingTransform_Public_Void_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42100, RefRangeEnd = 42102, XrefRangeStart = 42083, XrefRangeEnd = 42100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLookAtTransform(Transform newTarget, float newRank)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTarget);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newRank;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLookAtTransform_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42145, RefRangeEnd = 42146, XrefRangeStart = 42102, XrefRangeEnd = 42145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTrackedTarget(Actor newTracked)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTracked);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTrackedTarget_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 42237, RefRangeEnd = 42240, XrefRangeStart = 42146, XrefRangeEnd = 42237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TrackingSpookCheck(TrackingTarget newTarget, bool seen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTarget);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seen;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrackingSpookCheck_Private_Void_TrackingTarget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42297, RefRangeEnd = 42298, XrefRangeStart = 42240, XrefRangeEnd = 42297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateHumanDrawnWeapon(Human who, bool seen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)who);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seen;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateHumanDrawnWeapon_Public_Void_Human_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42443, RefRangeEnd = 42445, XrefRangeStart = 42298, XrefRangeEnd = 42443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTrackedTargets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTrackedTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42477, RefRangeEnd = 42479, XrefRangeStart = 42445, XrefRangeEnd = 42477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTrackTarget(TrackingTarget newTrackingTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTrackingTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTrackTarget_Public_Void_TrackingTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42680, RefRangeEnd = 42681, XrefRangeStart = 42479, XrefRangeEnd = 42680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNewTrackTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnNewTrackTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42833, RefRangeEnd = 42835, XrefRangeStart = 42681, XrefRangeEnd = 42833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsMuggingValid(Human target, out string debugReason)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMuggingValid_Public_Boolean_Human_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		debugReason = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42839, RefRangeEnd = 42840, XrefRangeStart = 42835, XrefRangeEnd = 42839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveLookAtTargetAt(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveLookAtTargetAt_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnVisibilityChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnVisibilityChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 42843, RefRangeEnd = 42851, XrefRangeStart = 42840, XrefRangeEnd = 42843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExpression(CitizenOutfitController.Expression newExpression)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newExpression);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExpression_Public_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 42868, RefRangeEnd = 42878, XrefRangeStart = 42851, XrefRangeEnd = 42868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDebugAction(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDebugAction_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42878, XrefRangeEnd = 42880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugTeleportPlayerToLocation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugTeleportPlayerToLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42880, XrefRangeEnd = 42881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveSleep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveSleep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42881, XrefRangeEnd = 42882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSleep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSleep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42882, XrefRangeEnd = 42883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveFood()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveFood_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42883, XrefRangeEnd = 42884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFood()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFood_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42884, XrefRangeEnd = 42885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveDrink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveDrink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42885, XrefRangeEnd = 42886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDrink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42886, XrefRangeEnd = 42887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveCaffeine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveCaffeine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42887, XrefRangeEnd = 42888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCaffeine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCaffeine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42888, XrefRangeEnd = 42889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveFun()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveFun_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42889, XrefRangeEnd = 42890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFun()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFun_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void GiveBladder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveBladder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void RemoveBladder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBladder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42890, XrefRangeEnd = 42891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveHygiene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveHygiene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42891, XrefRangeEnd = 42892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveHygiene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveHygiene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42892, XrefRangeEnd = 42893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GiveDrunk()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GiveDrunk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42893, XrefRangeEnd = 42894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDrunk()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrunk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42894, XrefRangeEnd = 42898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MurderButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MurderButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42898, XrefRangeEnd = 42913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42913, XrefRangeEnd = 42928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Trip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42928, XrefRangeEnd = 42930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateProjectedChasePosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateProjectedChasePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43016, RefRangeEnd = 43017, XrefRangeStart = 42930, XrefRangeEnd = 43016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HearIllegal(AudioEvent audioEvent, NewNode newInvestigateNode, Vector3 newInvestigatePosition, Actor newTarget, int escLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newInvestigateNode);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newInvestigatePosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTarget);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &escLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HearIllegal_Public_Void_AudioEvent_NewNode_Vector3_Actor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 43135, RefRangeEnd = 43143, XrefRangeStart = 43017, XrefRangeEnd = 43135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Investigate(NewNode newInvestigateNode, Vector3 newInvestigatePosition, Actor newTarget, ReactionState newReactionState, float minimumInvestiationTimeMP, int escalation, bool setHighUrgency = false, float focusTimeMultiplier = 1f, Interactable newInvesigationObj = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newInvestigateNode);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newInvestigatePosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTarget);
		*(ReactionState**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newReactionState;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minimumInvestiationTimeMP;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &escalation;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &setHighUrgency;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &focusTimeMultiplier;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newInvesigationObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Investigate_Public_Void_NewNode_Vector3_Actor_ReactionState_Single_Int32_Boolean_Single_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetInvestigationUrgency(InvestigationUrgency newUrgency)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newUrgency);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInvestigationUrgency_Public_Void_InvestigationUrgency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 43209, RefRangeEnd = 43224, XrefRangeStart = 43143, XrefRangeEnd = 43209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPersue(Actor newTarget, bool publicFauxPas, int escalation, bool setHighUrgency, float responseRange = 10f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTarget);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &publicFauxPas;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &escalation;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &setHighUrgency;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &responseRange;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPersue_Public_Void_Actor_Boolean_Int32_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 43246, RefRangeEnd = 43251, XrefRangeStart = 43224, XrefRangeEnd = 43246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPersueTarget(Actor newTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPersueTarget_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43263, XrefRangeStart = 43251, XrefRangeEnd = 43260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelPersue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelPersue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 43273, RefRangeEnd = 43278, XrefRangeStart = 43263, XrefRangeEnd = 43273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPersuit(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPersuit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43288, RefRangeEnd = 43290, XrefRangeStart = 43278, XrefRangeEnd = 43288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSeesOnPersuit(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSeesOnPersuit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 43368, RefRangeEnd = 43374, XrefRangeStart = 43290, XrefRangeEnd = 43368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetInvestigate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetInvestigate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43374, XrefRangeEnd = 43377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Patrol(NewGameLocation newPatLoc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPatLoc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Patrol_Public_Void_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43403, RefRangeEnd = 43404, XrefRangeStart = 43377, XrefRangeEnd = 43403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAttack(Actor newAttackTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAttackTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartAttack_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43485, RefRangeEnd = 43486, XrefRangeStart = 43404, XrefRangeEnd = 43485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThrowObject(Actor newAttackTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAttackTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowObject_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 43505, RefRangeEnd = 43508, XrefRangeStart = 43486, XrefRangeEnd = 43505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAttackComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAttackComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43549, RefRangeEnd = 43550, XrefRangeStart = 43508, XrefRangeEnd = 43549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAttackBlock(bool perfect = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&perfect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAttackBlock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 43580, RefRangeEnd = 43585, XrefRangeStart = 43550, XrefRangeEnd = 43580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAbortAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAbortAttack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 43585, RefRangeEnd = 43588, XrefRangeStart = 43585, XrefRangeEnd = 43585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAttackDelay(bool blocked = false, bool blockedPerfect = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&blocked);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blockedPerfect;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAttackDelay_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 43630, RefRangeEnd = 43634, XrefRangeStart = 43588, XrefRangeEnd = 43630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndAttack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 43650, RefRangeEnd = 43653, XrefRangeStart = 43634, XrefRangeEnd = 43650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TalkTo(InteractionController.ConversationType convoType = InteractionController.ConversationType.normal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&convoType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TalkTo_Public_Void_ConversationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43653, XrefRangeEnd = 43745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnReturnFromTalkTo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnReturnFromTalkTo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43745, XrefRangeEnd = 43756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStunned(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStunned_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43758, RefRangeEnd = 43759, XrefRangeStart = 43756, XrefRangeEnd = 43758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDelayed(float seconds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seconds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDelayed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43805, RefRangeEnd = 43806, XrefRangeStart = 43759, XrefRangeEnd = 43805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnswerDoor(NewDoor dc, NewGameLocation where, Actor byWho)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)where);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byWho);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnswerDoor_Public_Void_NewDoor_NewGameLocation_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43806, XrefRangeEnd = 43856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnswerPhone(Telephone where)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)where);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnswerPhone_Public_Void_Telephone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43862, RefRangeEnd = 43863, XrefRangeStart = 43856, XrefRangeEnd = 43862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwakenPrompt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AwakenPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43863, XrefRangeEnd = 43873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayCurrentRoute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayCurrentRoute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43894, RefRangeEnd = 43896, XrefRangeStart = 43873, XrefRangeEnd = 43894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInCombat(bool val, bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInCombat_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 43900, RefRangeEnd = 43902, XrefRangeStart = 43896, XrefRangeEnd = 43900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecalculateWeaponStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateWeaponStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 44012, RefRangeEnd = 44019, XrefRangeStart = 43902, XrefRangeEnd = 44012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetKO(bool val, Vector3 impactPoint = default(Vector3), Vector3 impactDirection = default(Vector3), bool forced = false, float forcedDuration = 0f, bool resetInvesigate = true, float forceMultiplier = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&val);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &impactPoint;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &impactDirection;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forced;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedDuration;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &resetInvesigate;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetKO_Public_Void_Boolean_Vector3_Vector3_Boolean_Single_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44025, RefRangeEnd = 44026, XrefRangeStart = 44019, XrefRangeEnd = 44025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOutOfBreath(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOutOfBreath_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 44084, RefRangeEnd = 44092, XrefRangeStart = 44026, XrefRangeEnd = 44084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRestrained(bool val, float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&val);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRestrained_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 44103, RefRangeEnd = 44113, XrefRangeStart = 44092, XrefRangeEnd = 44103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetReactionState(ReactionState newState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReactionState_Public_Void_ReactionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 44166, RefRangeEnd = 44172, XrefRangeStart = 44113, XrefRangeEnd = 44166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TriggerReactionIndicator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriggerReactionIndicator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 44183, RefRangeEnd = 44211, XrefRangeStart = 44172, XrefRangeEnd = 44183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugDestinationPosition(string input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugDestinationPosition_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 44218, RefRangeEnd = 44222, XrefRangeStart = 44211, XrefRangeEnd = 44218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelCombat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelCombat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44234, RefRangeEnd = 44237, XrefRangeStart = 44222, XrefRangeEnd = 44234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsVictim(MurderController.Murder newMurder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMurder);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsVictim_Public_Void_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44247, RefRangeEnd = 44250, XrefRangeStart = 44237, XrefRangeEnd = 44247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsMurderer(MurderController.Murder newMurderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMurderer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsMurderer_Public_Void_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 44262, RefRangeEnd = 44268, XrefRangeStart = 44250, XrefRangeEnd = 44262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStaticFromAnimation(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStaticFromAnimation_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44268, XrefRangeEnd = 44379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRotationState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44379, RefRangeEnd = 44381, XrefRangeStart = 44379, XrefRangeEnd = 44379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseDoorsNormallyAfterLeavingGamelocation(NewGameLocation afterLeaving)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)afterLeaving);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseDoorsNormallyAfterLeavingGamelocation_Public_Void_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 44421, RefRangeEnd = 44428, XrefRangeStart = 44381, XrefRangeEnd = 44421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCurrentWeapon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCurrentWeapon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44448, RefRangeEnd = 44449, XrefRangeStart = 44428, XrefRangeEnd = 44448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrentWeapon(Interactable obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentWeapon_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 44756, RefRangeEnd = 44772, XrefRangeStart = 44449, XrefRangeEnd = 44756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateHeldItems(AIActionPreset.ActionStateFlag state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateHeldItems_Public_Void_ActionStateFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 44793, RefRangeEnd = 44797, XrefRangeStart = 44772, XrefRangeEnd = 44793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DespawnRightItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DespawnRightItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44818, RefRangeEnd = 44821, XrefRangeStart = 44797, XrefRangeEnd = 44818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DespawnLeftItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DespawnLeftItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44859, RefRangeEnd = 44861, XrefRangeStart = 44821, XrefRangeEnd = 44859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstantPersuitCheck(Actor target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstantPersuitCheck_Public_Void_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 44897, RefRangeEnd = 44905, XrefRangeStart = 44861, XrefRangeEnd = 44897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableAI(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableAI_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 44905, RefRangeEnd = 44913, XrefRangeStart = 44905, XrefRangeEnd = 44905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConfineLocation(NewGameLocation newConfine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newConfine);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConfineLocation_Public_Void_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44918, RefRangeEnd = 44920, XrefRangeStart = 44913, XrefRangeEnd = 44918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAvoidLocation(NewGameLocation newAvoid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAvoid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAvoidLocation_Public_Void_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44920, XrefRangeEnd = 44924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAvoidLocation(NewGameLocation remAvoid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remAvoid);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAvoidLocation_Public_Void_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45026, RefRangeEnd = 45027, XrefRangeStart = 44924, XrefRangeEnd = 45026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewGameLocation CheckConfinedLocation(NewGameLocation desired)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)desired);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckConfinedLocation_Public_NewGameLocation_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45086, RefRangeEnd = 45087, XrefRangeStart = 45027, XrefRangeEnd = 45086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanIgnoreLockedDoors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanIgnoreLockedDoors_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 29534, RefRangeEnd = 29541, XrefRangeStart = 29534, XrefRangeEnd = 29541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpooked(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpooked_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45087, XrefRangeEnd = 45123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IsTrespassingAtActionDestination()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTrespassingAtActionDestination_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45123, XrefRangeEnd = 45151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CurrentGoalTriggerTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentGoalTriggerTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45151, XrefRangeEnd = 45152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceNodeReached()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceNodeReached_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45152, XrefRangeEnd = 45153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestinationCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestinationCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45153, XrefRangeEnd = 45163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenEvidenceFirstName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenEvidenceFirstName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45163, XrefRangeEnd = 45173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenEvidenceName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenEvidenceName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45173, XrefRangeEnd = 45183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenEvidencePhoto()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenEvidencePhoto_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45201, RefRangeEnd = 45203, XrefRangeStart = 45183, XrefRangeEnd = 45201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleHumanDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToggleHumanDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45236, RefRangeEnd = 45237, XrefRangeStart = 45203, XrefRangeEnd = 45236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintCurrentNodePosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintCurrentNodePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45237, XrefRangeEnd = 45239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceUpdateGameLocation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceUpdateGameLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45239, XrefRangeEnd = 45353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugNextJobHours()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugNextJobHours_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45353, XrefRangeEnd = 45439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewAIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewAIController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45439, XrefRangeEnd = 45446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _StatusStatUpdate_b__181_0(TrackingTarget item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StatusStatUpdate_b__181_0_Private_Boolean_TrackingTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _SetParentPositionToRagdollLimbPosition_b__197_0(Objective.ObjectiveTrigger item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetParentPositionToRagdollLimbPosition_b__197_0_Private_Boolean_ObjectiveTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45446, XrefRangeEnd = 45451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _DoorCheckProcess_b__201_0(NewAIAction item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DoorCheckProcess_b__201_0_Private_Boolean_NewAIAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public NewAIController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
