using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class SideMissionIntroPreset : SoCustomComparison
{
	public enum SideMissionElementType
	{
		playerCallsNumber,
		acquireInformation,
		askStaff,
		spawnItems,
		photoOfItemLocation,
		openedBriefcase,
		postSubmission,
		playerHasCamera,
		setGooseChaseCall,
		setMeeting,
		handDossier,
		setupHomeInvestigation,
		submitToPoster,
		setHomeMeeting,
		setGooseChaseCallIndoorOnly,
		tailBriefcase,
		playerHasItemInPossession,
		leaveItemAtSecretLocation,
		destroyItem,
		playerHasHandcuffs,
		telephoneSubmission,
		placeItemInPosterMailbox,
		placeItemOfTypeInPosterMailbox
	}

	[System.Serializable]
	public class SideMissionObjectiveBlock : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_elementType;

		private static readonly System.IntPtr NativeFieldInfoPtr_dialogReference;

		private static readonly System.IntPtr NativeFieldInfoPtr_tagReference;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawnItems;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableUpdateWhileTalking;

		private static readonly System.IntPtr NativeFieldInfoPtr_objectiveDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr_validItems;

		private static readonly System.IntPtr NativeFieldInfoPtr_validFurniture;

		private static readonly System.IntPtr NativeFieldInfoPtr_disableOnDifficulties;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyCompativleWithIntros;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyCompatibleWithHandIns;

		private static readonly System.IntPtr NativeFieldInfoPtr_triggerFailIfItemDestroyed;

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

		public unsafe SideMissionElementType elementType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementType);
				return *(SideMissionElementType*)num;
			}
			set
			{
				*(SideMissionElementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementType)) = sideMissionElementType;
			}
		}

		public unsafe string dialogReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogReference);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogReference)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe JobPreset.JobTag tagReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagReference);
				return *(JobPreset.JobTag*)num;
			}
			set
			{
				*(JobPreset.JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tagReference)) = jobTag;
			}
		}

		public unsafe List<JobPreset.StartingSpawnItem> spawnItems
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItems);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<JobPreset.StartingSpawnItem>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool enableUpdateWhileTalking
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableUpdateWhileTalking);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableUpdateWhileTalking)) = flag;
			}
		}

		public unsafe float objectiveDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveDelay)) = num;
			}
		}

		public unsafe List<InteractablePreset> validItems
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validItems);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<FurniturePreset> validFurniture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validFurniture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurniturePreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validFurniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<JobPreset.DifficultyTag> disableOnDifficulties
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableOnDifficulties);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<JobPreset.DifficultyTag>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableOnDifficulties)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<SideMissionIntroPreset> onlyCompativleWithIntros
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyCompativleWithIntros);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideMissionIntroPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyCompativleWithIntros)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<SideMissionHandInPreset> onlyCompatibleWithHandIns
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyCompatibleWithHandIns);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideMissionHandInPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyCompatibleWithHandIns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<JobPreset.JobTag> triggerFailIfItemDestroyed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerFailIfItemDestroyed);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<JobPreset.JobTag>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerFailIfItemDestroyed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static SideMissionObjectiveBlock()
		{
			Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SideMissionIntroPreset>.NativeClassPtr, "SideMissionObjectiveBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "name");
			NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "elementType");
			NativeFieldInfoPtr_dialogReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "dialogReference");
			NativeFieldInfoPtr_tagReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "tagReference");
			NativeFieldInfoPtr_spawnItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "spawnItems");
			NativeFieldInfoPtr_enableUpdateWhileTalking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "enableUpdateWhileTalking");
			NativeFieldInfoPtr_objectiveDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "objectiveDelay");
			NativeFieldInfoPtr_validItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "validItems");
			NativeFieldInfoPtr_validFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "validFurniture");
			NativeFieldInfoPtr_disableOnDifficulties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "disableOnDifficulties");
			NativeFieldInfoPtr_onlyCompativleWithIntros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "onlyCompativleWithIntros");
			NativeFieldInfoPtr_onlyCompatibleWithHandIns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "onlyCompatibleWithHandIns");
			NativeFieldInfoPtr_triggerFailIfItemDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, "triggerFailIfItemDestroyed");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr, 100674039);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330207, XrefRangeEnd = 330249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SideMissionObjectiveBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideMissionObjectiveBlock>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SideMissionObjectiveBlock(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_rewardModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_blocks;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int rewardModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardModifier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardModifier)) = num;
		}
	}

	public unsafe List<SideMissionObjectiveBlock> blocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideMissionObjectiveBlock>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SideMissionIntroPreset()
	{
		Il2CppClassPointerStore<SideMissionIntroPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SideMissionIntroPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SideMissionIntroPreset>.NativeClassPtr);
		NativeFieldInfoPtr_rewardModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionIntroPreset>.NativeClassPtr, "rewardModifier");
		NativeFieldInfoPtr_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionIntroPreset>.NativeClassPtr, "blocks");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideMissionIntroPreset>.NativeClassPtr, 100674038);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330249, XrefRangeEnd = 330257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SideMissionIntroPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideMissionIntroPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SideMissionIntroPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
