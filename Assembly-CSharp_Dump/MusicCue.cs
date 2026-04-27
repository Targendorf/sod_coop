using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MusicCue : SoCustomComparison
{
	public enum MusicTriggerGameState
	{
		any,
		menu,
		inGame,
		inCutscene
	}

	public enum MusicTriggerPlayerState
	{
		any,
		safe,
		trespass,
		combat,
		passingTime
	}

	public enum MusicTriggerPlayerLocation
	{
		any,
		outdoors,
		indoors,
		playersApartment
	}

	public enum MusicTriggerEvent
	{
		none,
		newMurderCase,
		caseComplete,
		caseFailed,
		caseUnsolved,
		socialCreditLevelUp,
		resolveScreen,
		arriveAtCrimeScene,
		passingTime
	}

	[System.Serializable]
	public class MusicTrigger : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_onGameState;

		private static readonly System.IntPtr NativeFieldInfoPtr_cutSceneReference;

		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerSate;

		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerLocation;

		private static readonly System.IntPtr NativeFieldInfoPtr_onEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_eventTriggerChance;

		private static readonly System.IntPtr NativeFieldInfoPtr_triggerOnlyOnEvents;

		private static readonly System.IntPtr NativeFieldInfoPtr_ignoreSilentTimeBetweenTracks;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyInDistricts;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleDistricts;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludeDistricts;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludedDistricts;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyInBuildings;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleBuildings;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludeBuildings;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludedBuildings;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyInLocations;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleAddressTypes;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludeLocations;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludedAddressTypes;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyDuringStatuses;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleStatuses;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludeStatuses;

		private static readonly System.IntPtr NativeFieldInfoPtr_excludedStatuses;

		private static readonly System.IntPtr NativeFieldInfoPtr_useDecorGrimeRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_grimeRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_floorRanges;

		private static readonly System.IntPtr NativeFieldInfoPtr_timeRanges;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe MusicTriggerGameState onGameState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onGameState);
				return *(MusicTriggerGameState*)num;
			}
			set
			{
				*(MusicTriggerGameState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onGameState)) = musicTriggerGameState;
			}
		}

		public unsafe CutScenePreset cutSceneReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutSceneReference);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CutScenePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutSceneReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cutScenePreset));
			}
		}

		public unsafe MusicTriggerPlayerState onPlayerSate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPlayerSate);
				return *(MusicTriggerPlayerState*)num;
			}
			set
			{
				*(MusicTriggerPlayerState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPlayerSate)) = musicTriggerPlayerState;
			}
		}

		public unsafe MusicTriggerPlayerLocation onPlayerLocation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPlayerLocation);
				return *(MusicTriggerPlayerLocation*)num;
			}
			set
			{
				*(MusicTriggerPlayerLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPlayerLocation)) = musicTriggerPlayerLocation;
			}
		}

		public unsafe MusicTriggerEvent onEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEvent);
				return *(MusicTriggerEvent*)num;
			}
			set
			{
				*(MusicTriggerEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEvent)) = musicTriggerEvent;
			}
		}

		public unsafe float eventTriggerChance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventTriggerChance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventTriggerChance)) = num;
			}
		}

		public unsafe bool triggerOnlyOnEvents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerOnlyOnEvents);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerOnlyOnEvents)) = flag;
			}
		}

		public unsafe bool ignoreSilentTimeBetweenTracks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreSilentTimeBetweenTracks);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreSilentTimeBetweenTracks)) = flag;
			}
		}

		public unsafe bool onlyInDistricts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInDistricts);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInDistricts)) = flag;
			}
		}

		public unsafe List<DistrictPreset> compatibleDistricts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleDistricts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleDistricts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool excludeDistricts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeDistricts);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeDistricts)) = flag;
			}
		}

		public unsafe List<DistrictPreset> excludedDistricts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedDistricts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedDistricts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool onlyInBuildings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInBuildings);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInBuildings)) = flag;
			}
		}

		public unsafe List<BuildingPreset> compatibleBuildings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleBuildings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool excludeBuildings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeBuildings);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeBuildings)) = flag;
			}
		}

		public unsafe List<BuildingPreset> excludedBuildings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedBuildings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedBuildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool onlyInLocations
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInLocations);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInLocations)) = flag;
			}
		}

		public unsafe List<AddressPreset> compatibleAddressTypes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleAddressTypes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleAddressTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool excludeLocations
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeLocations);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeLocations)) = flag;
			}
		}

		public unsafe List<AddressPreset> excludedAddressTypes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedAddressTypes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedAddressTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool onlyDuringStatuses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyDuringStatuses);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyDuringStatuses)) = flag;
			}
		}

		public unsafe List<StatusPreset> compatibleStatuses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleStatuses);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StatusPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleStatuses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool excludeStatuses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeStatuses);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeStatuses)) = flag;
			}
		}

		public unsafe List<StatusPreset> excludedStatuses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedStatuses);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StatusPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludedStatuses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool useDecorGrimeRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDecorGrimeRange);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDecorGrimeRange)) = flag;
			}
		}

		public unsafe Vector2 grimeRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grimeRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grimeRange)) = vector;
			}
		}

		public unsafe List<Vector2> floorRanges
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorRanges);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorRanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Vector2> timeRanges
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRanges);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static MusicTrigger()
		{
			Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "MusicTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr);
			NativeFieldInfoPtr_onGameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onGameState");
			NativeFieldInfoPtr_cutSceneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "cutSceneReference");
			NativeFieldInfoPtr_onPlayerSate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onPlayerSate");
			NativeFieldInfoPtr_onPlayerLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onPlayerLocation");
			NativeFieldInfoPtr_onEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onEvent");
			NativeFieldInfoPtr_eventTriggerChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "eventTriggerChance");
			NativeFieldInfoPtr_triggerOnlyOnEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "triggerOnlyOnEvents");
			NativeFieldInfoPtr_ignoreSilentTimeBetweenTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "ignoreSilentTimeBetweenTracks");
			NativeFieldInfoPtr_onlyInDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onlyInDistricts");
			NativeFieldInfoPtr_compatibleDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "compatibleDistricts");
			NativeFieldInfoPtr_excludeDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludeDistricts");
			NativeFieldInfoPtr_excludedDistricts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludedDistricts");
			NativeFieldInfoPtr_onlyInBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onlyInBuildings");
			NativeFieldInfoPtr_compatibleBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "compatibleBuildings");
			NativeFieldInfoPtr_excludeBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludeBuildings");
			NativeFieldInfoPtr_excludedBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludedBuildings");
			NativeFieldInfoPtr_onlyInLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onlyInLocations");
			NativeFieldInfoPtr_compatibleAddressTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "compatibleAddressTypes");
			NativeFieldInfoPtr_excludeLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludeLocations");
			NativeFieldInfoPtr_excludedAddressTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludedAddressTypes");
			NativeFieldInfoPtr_onlyDuringStatuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "onlyDuringStatuses");
			NativeFieldInfoPtr_compatibleStatuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "compatibleStatuses");
			NativeFieldInfoPtr_excludeStatuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludeStatuses");
			NativeFieldInfoPtr_excludedStatuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "excludedStatuses");
			NativeFieldInfoPtr_useDecorGrimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "useDecorGrimeRange");
			NativeFieldInfoPtr_grimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "grimeRange");
			NativeFieldInfoPtr_floorRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "floorRanges");
			NativeFieldInfoPtr_timeRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, "timeRanges");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr, 100673999);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329714, XrefRangeEnd = 329762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicTrigger>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MusicTrigger(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_fmodGUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug;

	private static readonly System.IntPtr NativeFieldInfoPtr_playOnce;

	private static readonly System.IntPtr NativeFieldInfoPtr_interrupt;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopOnIncompatibleStateSwitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_avoidRepetition;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggers;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string fmodGUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fmodGUID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fmodGUID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

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

	public unsafe bool debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)) = flag;
		}
	}

	public unsafe bool playOnce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playOnce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playOnce)) = flag;
		}
	}

	public unsafe bool interrupt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interrupt);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interrupt)) = flag;
		}
	}

	public unsafe bool stopOnIncompatibleStateSwitch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopOnIncompatibleStateSwitch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopOnIncompatibleStateSwitch)) = flag;
		}
	}

	public unsafe bool avoidRepetition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRepetition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRepetition)) = flag;
		}
	}

	public unsafe int ambientPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientPriority)) = num;
		}
	}

	public unsafe List<MusicTrigger> triggers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MusicTrigger>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static MusicCue()
	{
		Il2CppClassPointerStore<MusicCue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MusicCue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicCue>.NativeClassPtr);
		NativeFieldInfoPtr_fmodGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "fmodGUID");
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "debug");
		NativeFieldInfoPtr_playOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "playOnce");
		NativeFieldInfoPtr_interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "interrupt");
		NativeFieldInfoPtr_stopOnIncompatibleStateSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "stopOnIncompatibleStateSwitch");
		NativeFieldInfoPtr_avoidRepetition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "avoidRepetition");
		NativeFieldInfoPtr_ambientPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "ambientPriority");
		NativeFieldInfoPtr_triggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, "triggers");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCue>.NativeClassPtr, 100673998);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329762, XrefRangeEnd = 329770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MusicCue()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicCue>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MusicCue(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
