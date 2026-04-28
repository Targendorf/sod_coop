using System;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
	[System.Serializable]
	public class AmbientZoneInstance : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_playerDistance;

		private static readonly System.IntPtr NativeFieldInfoPtr_penetrationCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_audibleRoom;

		private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

		private static readonly System.IntPtr NativeFieldInfoPtr_desiredVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_actualVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_desiredWalla;

		private static readonly System.IntPtr NativeFieldInfoPtr_actualWalla;

		private static readonly System.IntPtr NativeFieldInfoPtr_eventData;

		private static readonly System.IntPtr NativeFieldInfoPtr_rooms;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AmbientZone_0;

		public unsafe AmbientZone preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AmbientZone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ambientZone));
			}
		}

		public unsafe float playerDistance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerDistance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerDistance)) = num;
			}
		}

		public unsafe int penetrationCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penetrationCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penetrationCount)) = num;
			}
		}

		public unsafe NewRoom audibleRoom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audibleRoom);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audibleRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
			}
		}

		public unsafe bool isActive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive)) = flag;
			}
		}

		public unsafe float desiredVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredVolume)) = num;
			}
		}

		public unsafe float actualVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualVolume)) = num;
			}
		}

		public unsafe float desiredWalla
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredWalla);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredWalla)) = num;
			}
		}

		public unsafe float actualWalla
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualWalla);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualWalla)) = num;
			}
		}

		public unsafe LoopingSoundInfo eventData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
			}
		}

		public unsafe HashSet<NewRoom> rooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<NewRoom>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		static AmbientZoneInstance()
		{
			Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "AmbientZoneInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_playerDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "playerDistance");
			NativeFieldInfoPtr_penetrationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "penetrationCount");
			NativeFieldInfoPtr_audibleRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "audibleRoom");
			NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "isActive");
			NativeFieldInfoPtr_desiredVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "desiredVolume");
			NativeFieldInfoPtr_actualVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "actualVolume");
			NativeFieldInfoPtr_desiredWalla = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "desiredWalla");
			NativeFieldInfoPtr_actualWalla = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "actualWalla");
			NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "eventData");
			NativeFieldInfoPtr_rooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, "rooms");
			NativeMethodInfoPtr__ctor_Public_Void_AmbientZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr, 100666830);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115534, RefRangeEnd = 115535, XrefRangeStart = 115525, XrefRangeEnd = 115534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientZoneInstance(AmbientZone newPreset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientZoneInstance>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AmbientZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AmbientZoneInstance(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class LoopingSoundInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_init;

		private static readonly System.IntPtr NativeFieldInfoPtr_audioEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_isValid;

		private static readonly System.IntPtr NativeFieldInfoPtr_description;

		private static readonly System.IntPtr NativeFieldInfoPtr_volumeOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_eventPreset;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceLocation;

		private static readonly System.IntPtr NativeFieldInfoPtr_who;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceSuspicious;

		private static readonly System.IntPtr NativeFieldInfoPtr_parameters;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdated;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_pauseWhenGamePaused;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_state;

		private static readonly System.IntPtr NativeFieldInfoPtr_paused;

		private static readonly System.IntPtr NativeFieldInfoPtr_audibleRooms;

		private static readonly System.IntPtr NativeFieldInfoPtr_isBroadcast;

		private static readonly System.IntPtr NativeFieldInfoPtr_occlusionVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_fadeToVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_vol;

		private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugStoppedReason;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactableLoopInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_clipIsValid;

		private static readonly System.IntPtr NativeFieldInfoPtr_clipPaused;

		private static readonly System.IntPtr NativeFieldInfoPtr_clipState;

		private static readonly System.IntPtr NativeFieldInfoPtr_clipAudioEvent;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlayState_Public_PLAYBACK_STATE_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWorldPosition_Public_Void_Vector3_NewNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOcclusion_Public_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetVolumeImmediate_Public_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetVolumeFadeTo_Public_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnPauseChange_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDynamicClip_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PassCrowdReaction_Private_Void_0;

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

		public unsafe bool init
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_init);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_init)) = flag;
			}
		}

		public unsafe EventInstance audioEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvent);
				return *(EventInstance*)num;
			}
			set
			{
				*(EventInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvent)) = eventInstance;
			}
		}

		public unsafe bool isValid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValid);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValid)) = flag;
			}
		}

		public unsafe EventDescription description
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description);
				return *(EventDescription*)num;
			}
			set
			{
				*(EventDescription*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description)) = eventDescription;
			}
		}

		public unsafe float volumeOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeOverride);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeOverride)) = num;
			}
		}

		public unsafe AudioEvent eventPreset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPreset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe NewNode sourceLocation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceLocation);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceLocation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe Actor who
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
			}
		}

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

		public unsafe bool forceSuspicious
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSuspicious);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceSuspicious)) = flag;
			}
		}

		public unsafe List<FMODParam> parameters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FMODParam>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

		public unsafe int currentOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOcclusion);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOcclusion)) = num;
			}
		}

		public unsafe bool pauseWhenGamePaused
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseWhenGamePaused);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseWhenGamePaused)) = flag;
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

		public unsafe PLAYBACK_STATE state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state);
				return *(PLAYBACK_STATE*)num;
			}
			set
			{
				*(PLAYBACK_STATE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state)) = pLAYBACK_STATE;
			}
		}

		public unsafe bool paused
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paused);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paused)) = flag;
			}
		}

		public unsafe List<NewRoom> audibleRooms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audibleRooms);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audibleRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe SessionData.TelevisionChannel isBroadcast
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBroadcast);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SessionData.TelevisionChannel>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBroadcast)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)televisionChannel));
			}
		}

		public unsafe float occlusionVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionVolume)) = num;
			}
		}

		public unsafe float fadeToVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeToVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeToVolume)) = num;
			}
		}

		public unsafe float vol
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vol);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vol)) = num;
			}
		}

		public unsafe bool isActive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive)) = flag;
			}
		}

		public unsafe string debugStoppedReason
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugStoppedReason);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugStoppedReason)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe InteractablePreset.IfSwitchStateSFX interactableLoopInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableLoopInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset.IfSwitchStateSFX>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactableLoopInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ifSwitchStateSFX));
			}
		}

		public unsafe bool clipIsValid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipIsValid);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipIsValid)) = flag;
			}
		}

		public unsafe bool clipPaused
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipPaused);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipPaused)) = flag;
			}
		}

		public unsafe PLAYBACK_STATE clipState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipState);
				return *(PLAYBACK_STATE*)num;
			}
			set
			{
				*(PLAYBACK_STATE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipState)) = pLAYBACK_STATE;
			}
		}

		public unsafe EventInstance clipAudioEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipAudioEvent);
				return *(EventInstance*)num;
			}
			set
			{
				*(EventInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipAudioEvent)) = eventInstance;
			}
		}

		static LoopingSoundInfo()
		{
			Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "LoopingSoundInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "name");
			NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "init");
			NativeFieldInfoPtr_audioEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "audioEvent");
			NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "isValid");
			NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "description");
			NativeFieldInfoPtr_volumeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "volumeOverride");
			NativeFieldInfoPtr_eventPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "eventPreset");
			NativeFieldInfoPtr_sourceLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "sourceLocation");
			NativeFieldInfoPtr_who = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "who");
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "interactable");
			NativeFieldInfoPtr_forceSuspicious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "forceSuspicious");
			NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "parameters");
			NativeFieldInfoPtr_lastUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "lastUpdated");
			NativeFieldInfoPtr_currentOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "currentOcclusion");
			NativeFieldInfoPtr_pauseWhenGamePaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "pauseWhenGamePaused");
			NativeFieldInfoPtr_worldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "worldPos");
			NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "state");
			NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "paused");
			NativeFieldInfoPtr_audibleRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "audibleRooms");
			NativeFieldInfoPtr_isBroadcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "isBroadcast");
			NativeFieldInfoPtr_occlusionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "occlusionVolume");
			NativeFieldInfoPtr_fadeToVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "fadeToVolume");
			NativeFieldInfoPtr_vol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "vol");
			NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "isActive");
			NativeFieldInfoPtr_debugStoppedReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "debugStoppedReason");
			NativeFieldInfoPtr_interactableLoopInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "interactableLoopInfo");
			NativeFieldInfoPtr_clipIsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "clipIsValid");
			NativeFieldInfoPtr_clipPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "clipPaused");
			NativeFieldInfoPtr_clipState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "clipState");
			NativeFieldInfoPtr_clipAudioEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, "clipAudioEvent");
			NativeMethodInfoPtr_UpdatePlayState_Public_PLAYBACK_STATE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666831);
			NativeMethodInfoPtr_UpdateWorldPosition_Public_Void_Vector3_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666832);
			NativeMethodInfoPtr_UpdateOcclusion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666833);
			NativeMethodInfoPtr_SetVolumeImmediate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666834);
			NativeMethodInfoPtr_SetVolumeFadeTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666835);
			NativeMethodInfoPtr_OnPauseChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666836);
			NativeMethodInfoPtr_UpdateDynamicClip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666837);
			NativeMethodInfoPtr_PassCrowdReaction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666838);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr, 100666839);
		}

		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 115539, RefRangeEnd = 115557, XrefRangeStart = 115535, XrefRangeEnd = 115539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PLAYBACK_STATE UpdatePlayState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePlayState_Public_PLAYBACK_STATE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(PLAYBACK_STATE*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115598, RefRangeEnd = 115600, XrefRangeStart = 115557, XrefRangeEnd = 115598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWorldPosition(Vector3 newWorldPos, NewNode newNodePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&newWorldPos);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNodePos);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWorldPosition_Public_Void_Vector3_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 115650, RefRangeEnd = 115658, XrefRangeStart = 115600, XrefRangeEnd = 115650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOcclusion(bool ignoreLastUpdateTime = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&ignoreLastUpdateTime);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateOcclusion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115658, XrefRangeEnd = 115679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolumeImmediate(float vol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&vol);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVolumeImmediate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115679, XrefRangeEnd = 115688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolumeFadeTo(float vol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&vol);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVolumeFadeTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115700, RefRangeEnd = 115701, XrefRangeStart = 115688, XrefRangeEnd = 115700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPauseChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPauseChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115701, XrefRangeEnd = 115763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDynamicClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDynamicClip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115791, RefRangeEnd = 115792, XrefRangeStart = 115763, XrefRangeEnd = 115791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassCrowdReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassCrowdReaction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115798, RefRangeEnd = 115800, XrefRangeStart = 115792, XrefRangeEnd = 115798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoopingSoundInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopingSoundInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LoopingSoundInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ActiveListener : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_listener;

		private static readonly System.IntPtr NativeFieldInfoPtr_soundLevel;

		private static readonly System.IntPtr NativeFieldInfoPtr_escalationLevel;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Actor listener
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listener);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listener)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
			}
		}

		public unsafe float soundLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundLevel);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundLevel)) = num;
			}
		}

		public unsafe int escalationLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevel);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevel)) = num;
			}
		}

		static ActiveListener()
		{
			Il2CppClassPointerStore<ActiveListener>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ActiveListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveListener>.NativeClassPtr);
			NativeFieldInfoPtr_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveListener>.NativeClassPtr, "listener");
			NativeFieldInfoPtr_soundLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveListener>.NativeClassPtr, "soundLevel");
			NativeFieldInfoPtr_escalationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveListener>.NativeClassPtr, "escalationLevel");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveListener>.NativeClassPtr, 100666840);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveListener>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ActiveListener(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DelayedSoundInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_delay;

		private static readonly System.IntPtr NativeFieldInfoPtr_eventPreset;

		private static readonly System.IntPtr NativeFieldInfoPtr_who;

		private static readonly System.IntPtr NativeFieldInfoPtr_location;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_parameters;

		private static readonly System.IntPtr NativeFieldInfoPtr_volumeOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalSources;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceIgnoreOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_is2D;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_List_1_NewNode_Boolean_Boolean_0;

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

		public unsafe AudioEvent eventPreset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPreset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe Actor who
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Actor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor));
			}
		}

		public unsafe NewNode location
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe Vector3 worldPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPosition)) = vector;
			}
		}

		public unsafe List<FMODParam> parameters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FMODParam>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float volumeOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeOverride);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeOverride)) = num;
			}
		}

		public unsafe List<NewNode> additionalSources
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalSources);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewNode>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalSources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool forceIgnoreOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIgnoreOcclusion);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceIgnoreOcclusion)) = flag;
			}
		}

		public unsafe bool is2D
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is2D);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_is2D)) = flag;
			}
		}

		static DelayedSoundInfo()
		{
			Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "DelayedSoundInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr);
			NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "delay");
			NativeFieldInfoPtr_eventPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "eventPreset");
			NativeFieldInfoPtr_who = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "who");
			NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "location");
			NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "worldPosition");
			NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "parameters");
			NativeFieldInfoPtr_volumeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "volumeOverride");
			NativeFieldInfoPtr_additionalSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "additionalSources");
			NativeFieldInfoPtr_forceIgnoreOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "forceIgnoreOcclusion");
			NativeFieldInfoPtr_is2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, "is2D");
			NativeMethodInfoPtr__ctor_Public_Void_Single_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_List_1_NewNode_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr, 100666841);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115800, RefRangeEnd = 115802, XrefRangeStart = 115800, XrefRangeEnd = 115800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayedSoundInfo(float newDelay, AudioEvent newEventPreset, Actor newWho, NewNode newLocation, Vector3 newWorldPosition, List<FMODParam> newParameters = null, float newVolumeOverride = 1f, List<NewNode> newAdditionalSources = null, bool newForceIgnoreOcclusion = false, bool newIs2D = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedSoundInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[10];
			*ptr = (nint)(&newDelay);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newEventPreset);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newWho);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLocation);
			*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newWorldPosition;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newParameters);
			*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &newVolumeOverride;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAdditionalSources);
			*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &newForceIgnoreOcclusion;
			*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &newIs2D;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_List_1_NewNode_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DelayedSoundInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class SoundMaterialOverride : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_concrete;

		private static readonly System.IntPtr NativeFieldInfoPtr_wood;

		private static readonly System.IntPtr NativeFieldInfoPtr_carpet;

		private static readonly System.IntPtr NativeFieldInfoPtr_tile;

		private static readonly System.IntPtr NativeFieldInfoPtr_plaster;

		private static readonly System.IntPtr NativeFieldInfoPtr_fabric;

		private static readonly System.IntPtr NativeFieldInfoPtr_metal;

		private static readonly System.IntPtr NativeFieldInfoPtr_glass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0;

		public unsafe float concrete
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concrete);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concrete)) = num;
			}
		}

		public unsafe float wood
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wood)) = num;
			}
		}

		public unsafe float carpet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carpet);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carpet)) = num;
			}
		}

		public unsafe float tile
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tile);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tile)) = num;
			}
		}

		public unsafe float plaster
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plaster);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plaster)) = num;
			}
		}

		public unsafe float fabric
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fabric);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fabric)) = num;
			}
		}

		public unsafe float metal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metal);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metal)) = num;
			}
		}

		public unsafe float glass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glass);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glass)) = num;
			}
		}

		static SoundMaterialOverride()
		{
			Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "SoundMaterialOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr);
			NativeFieldInfoPtr_concrete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "concrete");
			NativeFieldInfoPtr_wood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "wood");
			NativeFieldInfoPtr_carpet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "carpet");
			NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "tile");
			NativeFieldInfoPtr_plaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "plaster");
			NativeFieldInfoPtr_fabric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "fabric");
			NativeFieldInfoPtr_metal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "metal");
			NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, "glass");
			NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr, 100666842);
		}

		[CallerCount(0)]
		public unsafe SoundMaterialOverride(float newConcrete, float newWood, float newCarpet, float newTile, float newPlaster, float newFabric, float newMetal, float newGlass)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundMaterialOverride>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = (nint)(&newConcrete);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newWood;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newCarpet;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newTile;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newPlaster;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newFabric;
			*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &newMetal;
			*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &newGlass;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SoundMaterialOverride(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum CitizenReaction
	{
		investigate,
		immediatePersue,
		alarm
	}

	public enum SurfaceType
	{
		concrete,
		woodenFloor,
		tile,
		carpet
	}

	public enum StopType
	{
		immediate,
		fade,
		triggerCue
	}

	public sealed class FMODParam : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

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

		public unsafe float value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
			}
		}

		static FMODParam()
		{
			Il2CppClassPointerStore<FMODParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "FMODParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FMODParam>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FMODParam>.NativeClassPtr, "name");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FMODParam>.NativeClassPtr, "value");
		}

		public FMODParam(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FMODParam()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FMODParam>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("AudioController+<>c__DisplayClass112_0")]
	public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_v;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateLoopBasedControllerVibration_b__0_Internal_Boolean_ControllerVibration_0;

		public unsafe InputController.ControllerVibration v
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputController.ControllerVibration>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerVibration));
			}
		}

		static __c__DisplayClass112_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "<>c__DisplayClass112_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr);
			NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, "v");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100666843);
			NativeMethodInfoPtr__UpdateLoopBasedControllerVibration_b__0_Internal_Boolean_ControllerVibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr, 100666844);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass112_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass112_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _UpdateLoopBasedControllerVibration_b__0(InputController.ControllerVibration item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateLoopBasedControllerVibration_b__0_Internal_Boolean_ControllerVibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass112_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("AudioController+<>c__DisplayClass112_1")]
	public sealed class __c__DisplayClass112_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_i;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateLoopBasedControllerVibration_b__1_Internal_Boolean_ControllerVibration_0;

		public unsafe int i
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i)) = num;
			}
		}

		static __c__DisplayClass112_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass112_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "<>c__DisplayClass112_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass112_1>.NativeClassPtr);
			NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass112_1>.NativeClassPtr, "i");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_1>.NativeClassPtr, 100666845);
			NativeMethodInfoPtr__UpdateLoopBasedControllerVibration_b__1_Internal_Boolean_ControllerVibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass112_1>.NativeClassPtr, 100666846);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass112_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass112_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _UpdateLoopBasedControllerVibration_b__1(InputController.ControllerVibration item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateLoopBasedControllerVibration_b__1_Internal_Boolean_ControllerVibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass112_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_playerListener;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedOfSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionUnitVolumeModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_openDoorOcclusionUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_closedDoorOcclusionUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowOcclusionUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_wallOcclusionUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_ceilingOcclusionUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorOcclusionUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_floorDifferenceOcclusionUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopingMaximum;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRoomDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_emulationRolloff;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiHearingThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerHearingThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundIconRangeUnit;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateClosestWindowTicker;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateMixingTicker;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateAmbientZonesTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateClosestWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateMixing;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowAudioPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_closestWindowDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_closestWindowDistanceNormalized;

	private static readonly System.IntPtr NativeFieldInfoPtr_closestWindowDistanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_openMultiplierCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_ventOutdoorsIndoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearbyVent;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorAudioPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_closestDoorDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_closestDoorDistanceNormalized;

	private static readonly System.IntPtr NativeFieldInfoPtr_closestDoorDistanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_edgeDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_edgeDistanceNormalized;

	private static readonly System.IntPtr NativeFieldInfoPtr_edgeDistanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_extWallDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_extWallNormalized;

	private static readonly System.IntPtr NativeFieldInfoPtr_extWallDistanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_passedWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_passedRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_passedCity;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientZones;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientZoneReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientFalloff;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambienceWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambienceRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambiencePA;

	private static readonly System.IntPtr NativeFieldInfoPtr_hapticsPlaying;

	private static readonly System.IntPtr NativeFieldInfoPtr_threatLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopingSounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumeChangingSounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayedSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_footstepLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceFeedbackLoops;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateAmbientZonesAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AudioController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMixing_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartAmbienceTracks_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayWorldFootstep_Public_Boolean_AudioEvent_Actor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerPlayerImpactSound_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayWorldOneShot_Public_EventInstance_AudioEvent_Actor_NewNode_Vector3_Interactable_List_1_FMODParam_Single_List_1_NewNode_Boolean_SoundMaterialOverride_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayOneShotDelayed_Public_Void_Single_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_List_1_NewNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayWorldLooping_Public_LoopingSoundInfo_AudioEvent_Actor_Interactable_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayWorldLoopingStatic_Public_LoopingSoundInfo_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayWorldLooping_Public_LoopingSoundInfo_AudioEvent_Actor_NewNode_Vector3_Interactable_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play2DLooping_Public_LoopingSoundInfo_AudioEvent_List_1_FMODParam_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAllLoopingSoundOcclusion_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateClosestWindowAndDoor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDistanceFromEdge_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassWindowDistance_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassDistanceFromExternalDoor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassWeatherParams_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassIndoorOutdoor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVentIndoorOutdoor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDistanceToVent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassTimeOfDay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassEdgeDistance_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateClosestExteriorWall_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassExteriorWallDistance_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSoundPlaying_Public_Boolean_LoopingSoundInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSoundPlaying_Public_Boolean_EventInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopSound_Public_Void_LoopingSoundInfo_StopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopSound_Public_Void_EventInstance_StopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play2DSound_Public_EventInstance_AudioEvent_List_1_FMODParam_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play2DSoundDelayed_Public_Void_AudioEvent_Single_List_1_FMODParam_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOcculusion_Public_Single_NewNode_NewNode_AudioEvent_Single_Actor_SoundMaterialOverride_byref_Int32_byref_List_1_ActiveListener_byref_Boolean_byref_List_1_NewRoom_byref_Single_List_1_NewNode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAmbientZoneOcculusion_Public_Single_NewNode_AmbientZoneInstance_byref_Single_byref_Int32_byref_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceOutlineCheck_Public_Void_AudioEvent_Interactable_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayersSoundLevel_Public_Single_NewNode_AudioEvent_Single_SoundMaterialOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAmbientZonesOnEndOfFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAmbientZones_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetThis_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVCALevel_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAmbientPlaybackState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopAllSounds_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVolumeChanging_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugWeatherLoopDisplay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextTVShow_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLoopBasedControllerVibration_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StudioListener playerListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerListener);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StudioListener>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerListener)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)studioListener));
		}
	}

	public unsafe float speedOfSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedOfSound);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedOfSound)) = num;
		}
	}

	public unsafe float occlusionUnitVolumeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionUnitVolumeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionUnitVolumeModifier)) = num;
		}
	}

	public unsafe int openDoorOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoorOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoorOcclusionUnits)) = num;
		}
	}

	public unsafe int closedDoorOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedDoorOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedDoorOcclusionUnits)) = num;
		}
	}

	public unsafe int windowOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowOcclusionUnits)) = num;
		}
	}

	public unsafe int wallOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallOcclusionUnits)) = num;
		}
	}

	public unsafe int ceilingOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ceilingOcclusionUnits)) = num;
		}
	}

	public unsafe int floorOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorOcclusionUnits)) = num;
		}
	}

	public unsafe int floorDifferenceOcclusionUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorDifferenceOcclusionUnits);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorDifferenceOcclusionUnits)) = num;
		}
	}

	public unsafe int loopingMaximum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingMaximum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingMaximum)) = num;
		}
	}

	public unsafe int maxRoomDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRoomDistance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRoomDistance)) = num;
		}
	}

	public unsafe AnimationCurve emulationRolloff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emulationRolloff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emulationRolloff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float aiHearingThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHearingThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiHearingThreshold)) = num;
		}
	}

	public unsafe float playerHearingThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHearingThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHearingThreshold)) = num;
		}
	}

	public unsafe float soundIconRangeUnit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundIconRangeUnit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundIconRangeUnit)) = num;
		}
	}

	public unsafe int updateClosestWindowTicker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateClosestWindowTicker);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateClosestWindowTicker)) = num;
		}
	}

	public unsafe int updateMixingTicker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMixingTicker);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMixingTicker)) = num;
		}
	}

	public unsafe float updateAmbientZonesTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAmbientZonesTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAmbientZonesTimer)) = num;
		}
	}

	public unsafe int updateClosestWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateClosestWindow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateClosestWindow)) = num;
		}
	}

	public unsafe int updateMixing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMixing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMixing)) = num;
		}
	}

	public unsafe Vector3 windowAudioPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowAudioPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowAudioPosition)) = vector;
		}
	}

	public unsafe float closestWindowDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestWindowDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestWindowDistance)) = num;
		}
	}

	public unsafe float closestWindowDistanceNormalized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestWindowDistanceNormalized);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestWindowDistanceNormalized)) = num;
		}
	}

	public unsafe float closestWindowDistanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestWindowDistanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestWindowDistanceMultiplier)) = num;
		}
	}

	public unsafe AnimationCurve openMultiplierCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openMultiplierCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openMultiplierCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float ventOutdoorsIndoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ventOutdoorsIndoors);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ventOutdoorsIndoors)) = num;
		}
	}

	public unsafe float nearbyVent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyVent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyVent)) = num;
		}
	}

	public unsafe Vector3 doorAudioPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorAudioPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorAudioPosition)) = vector;
		}
	}

	public unsafe float closestDoorDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestDoorDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestDoorDistance)) = num;
		}
	}

	public unsafe float closestDoorDistanceNormalized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestDoorDistanceNormalized);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestDoorDistanceNormalized)) = num;
		}
	}

	public unsafe float closestDoorDistanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestDoorDistanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closestDoorDistanceMultiplier)) = num;
		}
	}

	public unsafe float edgeDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeDistance)) = num;
		}
	}

	public unsafe float edgeDistanceNormalized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeDistanceNormalized);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeDistanceNormalized)) = num;
		}
	}

	public unsafe float edgeDistanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeDistanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeDistanceMultiplier)) = num;
		}
	}

	public unsafe float extWallDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallDistance)) = num;
		}
	}

	public unsafe float extWallNormalized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallNormalized);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallNormalized)) = num;
		}
	}

	public unsafe float extWallDistanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallDistanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extWallDistanceMultiplier)) = num;
		}
	}

	public unsafe float passedWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedWind);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedWind)) = num;
		}
	}

	public unsafe float passedRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedRain);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedRain)) = num;
		}
	}

	public unsafe float passedCity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedCity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedCity)) = num;
		}
	}

	public unsafe List<AmbientZoneInstance> ambientZones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientZones);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AmbientZoneInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientZones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<AmbientZone, AmbientZoneInstance> ambientZoneReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientZoneReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AmbientZone, AmbientZoneInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientZoneReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe AnimationCurve ambientFalloff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientFalloff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientFalloff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe LoopingSoundInfo ambienceWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambienceWind);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambienceWind)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe LoopingSoundInfo ambienceRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambienceRain);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambienceRain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe LoopingSoundInfo ambiencePA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambiencePA);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambiencePA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe string hapticsPlaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hapticsPlaying);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hapticsPlaying)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe LoopingSoundInfo threatLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threatLoop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threatLoop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe List<LoopingSoundInfo> loopingSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingSounds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoopingSoundInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingSounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<LoopingSoundInfo> volumeChangingSounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeChangingSounds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<LoopingSoundInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeChangingSounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<DelayedSoundInfo> delayedSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayedSoundInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayedSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int footstepLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepLayerMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepLayerMask)) = num;
		}
	}

	public unsafe List<LoopingSoundInfo> forceFeedbackLoops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFeedbackLoops);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoopingSoundInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceFeedbackLoops)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppSystem.Action updateAmbientZonesAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAmbientZonesAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateAmbientZonesAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static AudioController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioController));
		}
	}

	public unsafe static AudioController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115802, XrefRangeEnd = 115804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_AudioController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController>(intPtr) : null;
		}
	}

	static AudioController()
	{
		Il2CppClassPointerStore<AudioController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioController>.NativeClassPtr);
		NativeFieldInfoPtr_playerListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "playerListener");
		NativeFieldInfoPtr_speedOfSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "speedOfSound");
		NativeFieldInfoPtr_occlusionUnitVolumeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "occlusionUnitVolumeModifier");
		NativeFieldInfoPtr_openDoorOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "openDoorOcclusionUnits");
		NativeFieldInfoPtr_closedDoorOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "closedDoorOcclusionUnits");
		NativeFieldInfoPtr_windowOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "windowOcclusionUnits");
		NativeFieldInfoPtr_wallOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "wallOcclusionUnits");
		NativeFieldInfoPtr_ceilingOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ceilingOcclusionUnits");
		NativeFieldInfoPtr_floorOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "floorOcclusionUnits");
		NativeFieldInfoPtr_floorDifferenceOcclusionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "floorDifferenceOcclusionUnits");
		NativeFieldInfoPtr_loopingMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "loopingMaximum");
		NativeFieldInfoPtr_maxRoomDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "maxRoomDistance");
		NativeFieldInfoPtr_emulationRolloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "emulationRolloff");
		NativeFieldInfoPtr_aiHearingThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "aiHearingThreshold");
		NativeFieldInfoPtr_playerHearingThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "playerHearingThreshold");
		NativeFieldInfoPtr_soundIconRangeUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "soundIconRangeUnit");
		NativeFieldInfoPtr_updateClosestWindowTicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "updateClosestWindowTicker");
		NativeFieldInfoPtr_updateMixingTicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "updateMixingTicker");
		NativeFieldInfoPtr_updateAmbientZonesTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "updateAmbientZonesTimer");
		NativeFieldInfoPtr_updateClosestWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "updateClosestWindow");
		NativeFieldInfoPtr_updateMixing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "updateMixing");
		NativeFieldInfoPtr_windowAudioPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "windowAudioPosition");
		NativeFieldInfoPtr_closestWindowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "closestWindowDistance");
		NativeFieldInfoPtr_closestWindowDistanceNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "closestWindowDistanceNormalized");
		NativeFieldInfoPtr_closestWindowDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "closestWindowDistanceMultiplier");
		NativeFieldInfoPtr_openMultiplierCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "openMultiplierCurve");
		NativeFieldInfoPtr_ventOutdoorsIndoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ventOutdoorsIndoors");
		NativeFieldInfoPtr_nearbyVent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "nearbyVent");
		NativeFieldInfoPtr_doorAudioPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "doorAudioPosition");
		NativeFieldInfoPtr_closestDoorDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "closestDoorDistance");
		NativeFieldInfoPtr_closestDoorDistanceNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "closestDoorDistanceNormalized");
		NativeFieldInfoPtr_closestDoorDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "closestDoorDistanceMultiplier");
		NativeFieldInfoPtr_edgeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "edgeDistance");
		NativeFieldInfoPtr_edgeDistanceNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "edgeDistanceNormalized");
		NativeFieldInfoPtr_edgeDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "edgeDistanceMultiplier");
		NativeFieldInfoPtr_extWallDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "extWallDistance");
		NativeFieldInfoPtr_extWallNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "extWallNormalized");
		NativeFieldInfoPtr_extWallDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "extWallDistanceMultiplier");
		NativeFieldInfoPtr_passedWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "passedWind");
		NativeFieldInfoPtr_passedRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "passedRain");
		NativeFieldInfoPtr_passedCity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "passedCity");
		NativeFieldInfoPtr_ambientZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ambientZones");
		NativeFieldInfoPtr_ambientZoneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ambientZoneReference");
		NativeFieldInfoPtr_ambientFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ambientFalloff");
		NativeFieldInfoPtr_ambienceWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ambienceWind");
		NativeFieldInfoPtr_ambienceRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ambienceRain");
		NativeFieldInfoPtr_ambiencePA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "ambiencePA");
		NativeFieldInfoPtr_hapticsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "hapticsPlaying");
		NativeFieldInfoPtr_threatLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "threatLoop");
		NativeFieldInfoPtr_loopingSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "loopingSounds");
		NativeFieldInfoPtr_volumeChangingSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "volumeChangingSounds");
		NativeFieldInfoPtr_delayedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "delayedSound");
		NativeFieldInfoPtr_footstepLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "footstepLayerMask");
		NativeFieldInfoPtr_forceFeedbackLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "forceFeedbackLoops");
		NativeFieldInfoPtr_updateAmbientZonesAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "updateAmbientZonesAction");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666782);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666783);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666784);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666785);
		NativeMethodInfoPtr_UpdateMixing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666786);
		NativeMethodInfoPtr_StartAmbienceTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666787);
		NativeMethodInfoPtr_PlayWorldFootstep_Public_Boolean_AudioEvent_Actor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666788);
		NativeMethodInfoPtr_PlayerPlayerImpactSound_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666789);
		NativeMethodInfoPtr_PlayWorldOneShot_Public_EventInstance_AudioEvent_Actor_NewNode_Vector3_Interactable_List_1_FMODParam_Single_List_1_NewNode_Boolean_SoundMaterialOverride_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666790);
		NativeMethodInfoPtr_PlayOneShotDelayed_Public_Void_Single_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_List_1_NewNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666791);
		NativeMethodInfoPtr_PlayWorldLooping_Public_LoopingSoundInfo_AudioEvent_Actor_Interactable_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666792);
		NativeMethodInfoPtr_PlayWorldLoopingStatic_Public_LoopingSoundInfo_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666793);
		NativeMethodInfoPtr_PlayWorldLooping_Public_LoopingSoundInfo_AudioEvent_Actor_NewNode_Vector3_Interactable_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666794);
		NativeMethodInfoPtr_Play2DLooping_Public_LoopingSoundInfo_AudioEvent_List_1_FMODParam_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666795);
		NativeMethodInfoPtr_UpdateAllLoopingSoundOcclusion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666796);
		NativeMethodInfoPtr_UpdateClosestWindowAndDoor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666797);
		NativeMethodInfoPtr_UpdateDistanceFromEdge_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666798);
		NativeMethodInfoPtr_PassWindowDistance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666799);
		NativeMethodInfoPtr_PassDistanceFromExternalDoor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666800);
		NativeMethodInfoPtr_PassWeatherParams_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666801);
		NativeMethodInfoPtr_PassIndoorOutdoor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666802);
		NativeMethodInfoPtr_UpdateVentIndoorOutdoor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666803);
		NativeMethodInfoPtr_UpdateDistanceToVent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666804);
		NativeMethodInfoPtr_PassTimeOfDay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666805);
		NativeMethodInfoPtr_PassEdgeDistance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666806);
		NativeMethodInfoPtr_UpdateClosestExteriorWall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666807);
		NativeMethodInfoPtr_PassExteriorWallDistance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666808);
		NativeMethodInfoPtr_IsSoundPlaying_Public_Boolean_LoopingSoundInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666809);
		NativeMethodInfoPtr_IsSoundPlaying_Public_Boolean_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666810);
		NativeMethodInfoPtr_StopSound_Public_Void_LoopingSoundInfo_StopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666811);
		NativeMethodInfoPtr_StopSound_Public_Void_EventInstance_StopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666812);
		NativeMethodInfoPtr_Play2DSound_Public_EventInstance_AudioEvent_List_1_FMODParam_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666813);
		NativeMethodInfoPtr_Play2DSoundDelayed_Public_Void_AudioEvent_Single_List_1_FMODParam_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666814);
		NativeMethodInfoPtr_GetOcculusion_Public_Single_NewNode_NewNode_AudioEvent_Single_Actor_SoundMaterialOverride_byref_Int32_byref_List_1_ActiveListener_byref_Boolean_byref_List_1_NewRoom_byref_Single_List_1_NewNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666815);
		NativeMethodInfoPtr_GetAmbientZoneOcculusion_Public_Single_NewNode_AmbientZoneInstance_byref_Single_byref_Int32_byref_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666816);
		NativeMethodInfoPtr_ForceOutlineCheck_Public_Void_AudioEvent_Interactable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666817);
		NativeMethodInfoPtr_GetPlayersSoundLevel_Public_Single_NewNode_AudioEvent_Single_SoundMaterialOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666818);
		NativeMethodInfoPtr_UpdateAmbientZonesOnEndOfFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666819);
		NativeMethodInfoPtr_UpdateAmbientZones_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666820);
		NativeMethodInfoPtr_ResetThis_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666821);
		NativeMethodInfoPtr_SetVCALevel_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666822);
		NativeMethodInfoPtr_UpdateAmbientPlaybackState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666823);
		NativeMethodInfoPtr_StopAllSounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666824);
		NativeMethodInfoPtr_UpdateVolumeChanging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666825);
		NativeMethodInfoPtr_DebugWeatherLoopDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666826);
		NativeMethodInfoPtr_NextTVShow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666827);
		NativeMethodInfoPtr_UpdateLoopBasedControllerVibration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666828);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100666829);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115804, XrefRangeEnd = 115867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115867, XrefRangeEnd = 115888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115888, XrefRangeEnd = 115926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 116046, RefRangeEnd = 116050, XrefRangeStart = 115926, XrefRangeEnd = 116046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMixing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMixing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116062, RefRangeEnd = 116063, XrefRangeStart = 116050, XrefRangeEnd = 116062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAmbienceTracks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartAmbienceTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 116304, RefRangeEnd = 116308, XrefRangeStart = 116063, XrefRangeEnd = 116304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PlayWorldFootstep(AudioEvent eventPreset, Actor actor, bool rightFoot = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actor);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rightFoot;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayWorldFootstep_Public_Boolean_AudioEvent_Actor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116440, RefRangeEnd = 116441, XrefRangeStart = 116308, XrefRangeEnd = 116440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayerPlayerImpactSound(float fallCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fallCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerPlayerImpactSound_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(96)]
	[CachedScanResults(RefRangeStart = 116844, RefRangeEnd = 116940, XrefRangeStart = 116441, XrefRangeEnd = 116844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventInstance PlayWorldOneShot(AudioEvent eventPreset, Actor who, NewNode location, Vector3 worldPosition, Interactable interactable = null, List<FMODParam> parameters = null, float volumeOverride = 1f, List<NewNode> additionalSources = null, bool forceIgnoreOcclusion = false, SoundMaterialOverride surfaceData = null, bool forceSuspicious = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)who);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalSources);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceIgnoreOcclusion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)surfaceData);
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSuspicious;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayWorldOneShot_Public_EventInstance_AudioEvent_Actor_NewNode_Vector3_Interactable_List_1_FMODParam_Single_List_1_NewNode_Boolean_SoundMaterialOverride_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EventInstance*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116964, RefRangeEnd = 116966, XrefRangeStart = 116940, XrefRangeEnd = 116964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayOneShotDelayed(float delay, AudioEvent eventPreset, Actor who, NewNode location, Vector3 worldPosition, List<FMODParam> parameters = null, float volumeOverride = 1f, List<NewNode> additionalSources = null, bool forceIgnoreOcclusion = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&delay);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)who);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location);
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalSources);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceIgnoreOcclusion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayOneShotDelayed_Public_Void_Single_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_List_1_NewNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 116967, RefRangeEnd = 116971, XrefRangeStart = 116966, XrefRangeEnd = 116967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoopingSoundInfo PlayWorldLooping(AudioEvent eventPreset, Actor who, Interactable interactable, List<FMODParam> parameters = null, float volumeOverride = 1f, bool forceSuspicious = false, SessionData.TelevisionChannel isBroadcast = null, InteractablePreset.IfSwitchStateSFX newSwitchInfo = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)who);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSuspicious;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isBroadcast);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSwitchInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayWorldLooping_Public_LoopingSoundInfo_AudioEvent_Actor_Interactable_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116971, XrefRangeEnd = 116972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoopingSoundInfo PlayWorldLoopingStatic(AudioEvent eventPreset, Actor who, NewNode worldNode, Vector3 worldPos, List<FMODParam> parameters = null, float volumeOverride = 1f, bool forceSuspicious = false, SessionData.TelevisionChannel isBroadcast = null, InteractablePreset.IfSwitchStateSFX newSwitchInfo = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)who);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldNode);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSuspicious;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isBroadcast);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSwitchInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayWorldLoopingStatic_Public_LoopingSoundInfo_AudioEvent_Actor_NewNode_Vector3_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 117047, RefRangeEnd = 117067, XrefRangeStart = 116972, XrefRangeEnd = 117047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoopingSoundInfo PlayWorldLooping(AudioEvent eventPreset, Actor who, NewNode worldNode, Vector3 worldPosition, Interactable interactable = null, List<FMODParam> parameters = null, float volumeOverride = 1f, bool forceSuspicious = false, SessionData.TelevisionChannel isBroadcast = null, InteractablePreset.IfSwitchStateSFX newSwitchInfo = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)who);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldNode);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSuspicious;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isBroadcast);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSwitchInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayWorldLooping_Public_LoopingSoundInfo_AudioEvent_Actor_NewNode_Vector3_Interactable_List_1_FMODParam_Single_Boolean_TelevisionChannel_IfSwitchStateSFX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 117114, RefRangeEnd = 117126, XrefRangeStart = 117067, XrefRangeEnd = 117114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoopingSoundInfo Play2DLooping(AudioEvent eventPreset, List<FMODParam> parameters = null, float volumeOverride = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play2DLooping_Public_LoopingSoundInfo_AudioEvent_List_1_FMODParam_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoopingSoundInfo>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117166, RefRangeEnd = 117169, XrefRangeStart = 117126, XrefRangeEnd = 117166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAllLoopingSoundOcclusion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAllLoopingSoundOcclusion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117299, RefRangeEnd = 117302, XrefRangeStart = 117169, XrefRangeEnd = 117299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateClosestWindowAndDoor(bool doorCheckOnly = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&doorCheckOnly);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateClosestWindowAndDoor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117350, RefRangeEnd = 117351, XrefRangeStart = 117302, XrefRangeEnd = 117350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDistanceFromEdge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDistanceFromEdge_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117370, RefRangeEnd = 117371, XrefRangeStart = 117351, XrefRangeEnd = 117370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassWindowDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassWindowDistance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117390, RefRangeEnd = 117391, XrefRangeStart = 117371, XrefRangeEnd = 117390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassDistanceFromExternalDoor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassDistanceFromExternalDoor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 117425, RefRangeEnd = 117429, XrefRangeStart = 117391, XrefRangeEnd = 117425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassWeatherParams()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassWeatherParams_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117453, RefRangeEnd = 117454, XrefRangeStart = 117429, XrefRangeEnd = 117453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassIndoorOutdoor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassIndoorOutdoor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117520, RefRangeEnd = 117523, XrefRangeStart = 117454, XrefRangeEnd = 117520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateVentIndoorOutdoor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVentIndoorOutdoor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117595, RefRangeEnd = 117598, XrefRangeStart = 117523, XrefRangeEnd = 117595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDistanceToVent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDistanceToVent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassTimeOfDay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassTimeOfDay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117598, XrefRangeEnd = 117604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassEdgeDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassEdgeDistance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117677, RefRangeEnd = 117678, XrefRangeStart = 117604, XrefRangeEnd = 117677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateClosestExteriorWall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateClosestExteriorWall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117678, XrefRangeEnd = 117686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PassExteriorWallDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassExteriorWallDistance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117686, XrefRangeEnd = 117688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSoundPlaying(LoopingSoundInfo sound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sound);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSoundPlaying_Public_Boolean_LoopingSoundInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117688, XrefRangeEnd = 117690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSoundPlaying(EventInstance sound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sound);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSoundPlaying_Public_Boolean_EventInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(80)]
	[CachedScanResults(RefRangeStart = 117710, RefRangeEnd = 117790, XrefRangeStart = 117690, XrefRangeEnd = 117710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopSound(LoopingSoundInfo loop, StopType stop)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loop);
		*(StopType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSound_Public_Void_LoopingSoundInfo_StopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117813, RefRangeEnd = 117816, XrefRangeStart = 117790, XrefRangeEnd = 117813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopSound(EventInstance sound, StopType stop)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sound);
		*(StopType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSound_Public_Void_EventInstance_StopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 117850, RefRangeEnd = 117926, XrefRangeStart = 117816, XrefRangeEnd = 117850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventInstance Play2DSound(AudioEvent eventPreset, List<FMODParam> parameters = null, float volumeOverride = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play2DSound_Public_EventInstance_AudioEvent_List_1_FMODParam_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EventInstance*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117926, XrefRangeEnd = 117952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play2DSoundDelayed(AudioEvent eventPreset, float delay, List<FMODParam> parameters = null, float volumeOverride = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventPreset);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumeOverride;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play2DSoundDelayed_Public_Void_AudioEvent_Single_List_1_FMODParam_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 118578, RefRangeEnd = 118582, XrefRangeStart = 117952, XrefRangeEnd = 118578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetOcculusion(NewNode listenerLocation, NewNode sourceLocation, AudioEvent audioEvent, float baseVolume, Actor soundMaker, SoundMaterialOverride detailedMaterialData, out int penetrationCount, out List<ActiveListener> activeListeners, out bool isSuspicious, out List<NewRoom> audibleRooms, out float rangeHearing, List<NewNode> additionalLocations = null, bool forceSuspicious = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listenerLocation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceLocation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseVolume;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundMaker);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detailedMaterialData);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref penetrationCount);
		byte* num = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isSuspicious);
		byte* num3 = (byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rangeHearing);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalLocations);
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceSuspicious;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOcculusion_Public_Single_NewNode_NewNode_AudioEvent_Single_Actor_SoundMaterialOverride_byref_Int32_byref_List_1_ActiveListener_byref_Boolean_byref_List_1_NewRoom_byref_Single_List_1_NewNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num5 = num2;
		activeListeners = ((num5 == 0) ? null : new List<ActiveListener>(num5));
		nint num6 = num4;
		audibleRooms = ((num6 == 0) ? null : new List<NewRoom>(num6));
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118684, RefRangeEnd = 118685, XrefRangeStart = 118582, XrefRangeEnd = 118684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAmbientZoneOcculusion(NewNode listenerLocation, AmbientZoneInstance ambientZone, out float distance, out int penetrationCount, out NewRoom audibleRoom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listenerLocation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ambientZone);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref penetrationCount);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAmbientZoneOcculusion_Public_Single_NewNode_AmbientZoneInstance_byref_Single_byref_Int32_byref_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		audibleRoom = ((num3 == 0) ? null : new NewRoom(num3));
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118725, RefRangeEnd = 118727, XrefRangeStart = 118685, XrefRangeEnd = 118725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceOutlineCheck(AudioEvent audioEvent, Interactable inter, bool forceOff = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inter);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceOff;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceOutlineCheck_Public_Void_AudioEvent_Interactable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118741, RefRangeEnd = 118744, XrefRangeStart = 118727, XrefRangeEnd = 118741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPlayersSoundLevel(NewNode sourceLocation, AudioEvent audioEvent, float occludedVolume, SoundMaterialOverride detailedMaterialData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceLocation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &occludedVolume;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detailedMaterialData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayersSoundLevel_Public_Single_NewNode_AudioEvent_Single_SoundMaterialOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 118762, RefRangeEnd = 118767, XrefRangeStart = 118744, XrefRangeEnd = 118762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAmbientZonesOnEndOfFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAmbientZonesOnEndOfFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118767, XrefRangeEnd = 118793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAmbientZones()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAmbientZones_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118793, XrefRangeEnd = 118797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetThis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetThis_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 118821, RefRangeEnd = 118830, XrefRangeStart = 118797, XrefRangeEnd = 118821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVCALevel(string vcaName, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(vcaName);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVCALevel_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118830, XrefRangeEnd = 118833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAmbientPlaybackState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAmbientPlaybackState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 118874, RefRangeEnd = 118883, XrefRangeStart = 118833, XrefRangeEnd = 118874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopAllSounds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopAllSounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118950, RefRangeEnd = 118951, XrefRangeStart = 118883, XrefRangeEnd = 118950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateVolumeChanging()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVolumeChanging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118951, XrefRangeEnd = 118979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugWeatherLoopDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugWeatherLoopDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118989, RefRangeEnd = 118990, XrefRangeStart = 118979, XrefRangeEnd = 118989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextTVShow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextTVShow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 119111, RefRangeEnd = 119114, XrefRangeStart = 118990, XrefRangeEnd = 119111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLoopBasedControllerVibration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLoopBasedControllerVibration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119114, XrefRangeEnd = 119149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AudioController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
