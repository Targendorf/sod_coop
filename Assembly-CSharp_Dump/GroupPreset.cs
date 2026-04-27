using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class GroupPreset : SoCustomComparison
{
	public enum GroupType
	{
		interestGroup,
		couples,
		cheaters,
		work
	}

	[System.Serializable]
	public class MeetUpVmailThread : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_treeID;

		private static readonly System.IntPtr NativeFieldInfoPtr_sender;

		private static readonly System.IntPtr NativeFieldInfoPtr_recevier;

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

		public unsafe string treeID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeID)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe MeetUpVmailSender sender
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sender);
				return *(MeetUpVmailSender*)num;
			}
			set
			{
				*(MeetUpVmailSender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sender)) = meetUpVmailSender;
			}
		}

		public unsafe MeetUpVmailSender recevier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recevier);
				return *(MeetUpVmailSender*)num;
			}
			set
			{
				*(MeetUpVmailSender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recevier)) = meetUpVmailSender;
			}
		}

		static MeetUpVmailThread()
		{
			Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "MeetUpVmailThread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr, "name");
			NativeFieldInfoPtr_treeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr, "treeID");
			NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr, "sender");
			NativeFieldInfoPtr_recevier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr, "recevier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr, 100673929);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeetUpVmailThread()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeetUpVmailThread>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MeetUpVmailThread(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ClubClue : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawnAt;

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

		public unsafe SpawnAt spawnAt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnAt);
				return *(SpawnAt*)num;
			}
			set
			{
				*(SpawnAt*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnAt)) = spawnAt;
			}
		}

		static ClubClue()
		{
			Il2CppClassPointerStore<ClubClue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "ClubClue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClubClue>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClubClue>.NativeClassPtr, "name");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClubClue>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_spawnAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClubClue>.NativeClassPtr, "spawnAt");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClubClue>.NativeClassPtr, 100673930);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClubClue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClubClue>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ClubClue(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum SpawnAt
	{
		meetingPlace,
		leadersApartment,
		entireGroupsApartments
	}

	public enum MeetUpVmailSender
	{
		groupLeader,
		groupRandom,
		meetupPlace,
		entireGroup,
		prioritiseFaithful
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_groupType;

	private static readonly System.IntPtr NativeFieldInfoPtr_chance;

	private static readonly System.IntPtr NativeFieldInfoPtr_minMembers;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxMembers;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumExtraversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableMeetUps;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysPerWeek;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_meetUpLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_meetUpLocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_meetUpGoal;

	private static readonly System.IntPtr NativeFieldInfoPtr_reserveSeats;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDistanceMultiplierModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_clues;

	private static readonly System.IntPtr NativeFieldInfoPtr_vmails;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GroupType groupType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupType);
			return *(GroupType*)num;
		}
		set
		{
			*(GroupType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupType)) = groupType;
		}
	}

	public unsafe float chance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance)) = num;
		}
	}

	public unsafe int minMembers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMembers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMembers)) = num;
		}
	}

	public unsafe int maxMembers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMembers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMembers)) = num;
		}
	}

	public unsafe List<CharacterTrait> requiredTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float minimumExtraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumExtraversion);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumExtraversion)) = num;
		}
	}

	public unsafe bool enableMeetUps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMeetUps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMeetUps)) = flag;
		}
	}

	public unsafe int daysPerWeek
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysPerWeek);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysPerWeek)) = num;
		}
	}

	public unsafe Vector2 timeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRange)) = vector;
		}
	}

	public unsafe float meetUpLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpLength)) = num;
		}
	}

	public unsafe List<CompanyPreset> meetUpLocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpLocations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpLocations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AIGoalPreset meetUpGoal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpGoal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIGoalPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meetUpGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIGoalPreset));
		}
	}

	public unsafe bool reserveSeats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reserveSeats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reserveSeats)) = flag;
		}
	}

	public unsafe float useDistanceMultiplierModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDistanceMultiplierModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDistanceMultiplierModifier)) = num;
		}
	}

	public unsafe List<ClubClue> clues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClubClue>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MeetUpVmailThread> vmails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmails);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeetUpVmailThread>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmails)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static GroupPreset()
	{
		Il2CppClassPointerStore<GroupPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GroupPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr);
		NativeFieldInfoPtr_groupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "groupType");
		NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "chance");
		NativeFieldInfoPtr_minMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "minMembers");
		NativeFieldInfoPtr_maxMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "maxMembers");
		NativeFieldInfoPtr_requiredTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "requiredTraits");
		NativeFieldInfoPtr_minimumExtraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "minimumExtraversion");
		NativeFieldInfoPtr_enableMeetUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "enableMeetUps");
		NativeFieldInfoPtr_daysPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "daysPerWeek");
		NativeFieldInfoPtr_timeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "timeRange");
		NativeFieldInfoPtr_meetUpLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "meetUpLength");
		NativeFieldInfoPtr_meetUpLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "meetUpLocations");
		NativeFieldInfoPtr_meetUpGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "meetUpGoal");
		NativeFieldInfoPtr_reserveSeats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "reserveSeats");
		NativeFieldInfoPtr_useDistanceMultiplierModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "useDistanceMultiplierModifier");
		NativeFieldInfoPtr_clues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "clues");
		NativeFieldInfoPtr_vmails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, "vmails");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr, 100673928);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328883, XrefRangeEnd = 328909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GroupPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GroupPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
