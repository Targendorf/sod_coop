using System;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_cues;

	private static readonly IntPtr NativeFieldInfoPtr_enableMusic;

	private static readonly IntPtr NativeFieldInfoPtr_silenceBetweenTracks;

	private static readonly IntPtr NativeFieldInfoPtr_currentValidCues;

	private static readonly IntPtr NativeFieldInfoPtr_playedOnceTracks;

	private static readonly IntPtr NativeFieldInfoPtr_isPlaying;

	private static readonly IntPtr NativeFieldInfoPtr_nextTrackTriggerTime;

	private static readonly IntPtr NativeFieldInfoPtr_currentGameState;

	private static readonly IntPtr NativeFieldInfoPtr_currentPlayerSate;

	private static readonly IntPtr NativeFieldInfoPtr_currentPlayerLocation;

	private static readonly IntPtr NativeFieldInfoPtr_previousTracks;

	private static readonly IntPtr NativeFieldInfoPtr_activeTracks;

	private static readonly IntPtr NativeFieldInfoPtr_activeCuePresets;

	private static readonly IntPtr NativeFieldInfoPtr_hyperacusisFilter;

	private static readonly IntPtr NativeFieldInfoPtr_bassReductionFilter;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MusicController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetGameState_Public_Void_MusicTriggerGameState_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerState_Public_Void_MusicTriggerPlayerState_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerLocation_Public_Void_MusicTriggerPlayerLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_MusicTriggerCheck_Public_Void_MusicTriggerEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsTriggerValid_Public_Boolean_MusicTrigger_MusicTriggerEvent_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPreviouslyPlayedBias_Private_Single_MusicCue_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlayNewTrack_Public_Void_MusicCue_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopCurrentTrack_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ForceNextTrack_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AudioFiltersCheck_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartMusicOnlySnapshot_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopMusicOnlySnapshot_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__MusicTriggerCheck_b__22_0_Private_Int32_MusicCue_MusicCue_0;

	public unsafe List<MusicCue> cues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cues);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MusicCue>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool enableMusic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMusic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMusic)) = flag;
		}
	}

	public unsafe Vector2 silenceBetweenTracks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_silenceBetweenTracks);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_silenceBetweenTracks)) = vector;
		}
	}

	public unsafe List<MusicCue> currentValidCues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentValidCues);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MusicCue>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentValidCues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MusicCue> playedOnceTracks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playedOnceTracks);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MusicCue>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playedOnceTracks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool isPlaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlaying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlaying)) = flag;
		}
	}

	public unsafe float nextTrackTriggerTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextTrackTriggerTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextTrackTriggerTime)) = num;
		}
	}

	public unsafe MusicCue.MusicTriggerGameState currentGameState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGameState);
			return *(MusicCue.MusicTriggerGameState*)num;
		}
		set
		{
			*(MusicCue.MusicTriggerGameState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGameState)) = musicTriggerGameState;
		}
	}

	public unsafe MusicCue.MusicTriggerPlayerState currentPlayerSate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlayerSate);
			return *(MusicCue.MusicTriggerPlayerState*)num;
		}
		set
		{
			*(MusicCue.MusicTriggerPlayerState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlayerSate)) = musicTriggerPlayerState;
		}
	}

	public unsafe MusicCue.MusicTriggerPlayerLocation currentPlayerLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlayerLocation);
			return *(MusicCue.MusicTriggerPlayerLocation*)num;
		}
		set
		{
			*(MusicCue.MusicTriggerPlayerLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlayerLocation)) = musicTriggerPlayerLocation;
		}
	}

	public unsafe List<MusicCue> previousTracks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousTracks);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MusicCue>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousTracks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<MusicCue, EventInstance> activeTracks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTracks);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<MusicCue, EventInstance>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTracks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<MusicCue> activeCuePresets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCuePresets);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MusicCue>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCuePresets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AudioController.LoopingSoundInfo hyperacusisFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hyperacusisFilter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hyperacusisFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe AudioController.LoopingSoundInfo bassReductionFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bassReductionFilter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bassReductionFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe static MusicController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MusicController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)musicController));
		}
	}

	public unsafe static MusicController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201512, XrefRangeEnd = 201514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_MusicController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MusicController>(intPtr) : null;
		}
	}

	static MusicController()
	{
		Il2CppClassPointerStore<MusicController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MusicController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicController>.NativeClassPtr);
		NativeFieldInfoPtr_cues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "cues");
		NativeFieldInfoPtr_enableMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "enableMusic");
		NativeFieldInfoPtr_silenceBetweenTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "silenceBetweenTracks");
		NativeFieldInfoPtr_currentValidCues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "currentValidCues");
		NativeFieldInfoPtr_playedOnceTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "playedOnceTracks");
		NativeFieldInfoPtr_isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "isPlaying");
		NativeFieldInfoPtr_nextTrackTriggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "nextTrackTriggerTime");
		NativeFieldInfoPtr_currentGameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "currentGameState");
		NativeFieldInfoPtr_currentPlayerSate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "currentPlayerSate");
		NativeFieldInfoPtr_currentPlayerLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "currentPlayerLocation");
		NativeFieldInfoPtr_previousTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "previousTracks");
		NativeFieldInfoPtr_activeTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "activeTracks");
		NativeFieldInfoPtr_activeCuePresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "activeCuePresets");
		NativeFieldInfoPtr_hyperacusisFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "hyperacusisFilter");
		NativeFieldInfoPtr_bassReductionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "bassReductionFilter");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_MusicController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669257);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669258);
		NativeMethodInfoPtr_SetGameState_Public_Void_MusicTriggerGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669259);
		NativeMethodInfoPtr_SetPlayerState_Public_Void_MusicTriggerPlayerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669260);
		NativeMethodInfoPtr_SetPlayerLocation_Public_Void_MusicTriggerPlayerLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669261);
		NativeMethodInfoPtr_MusicTriggerCheck_Public_Void_MusicTriggerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669262);
		NativeMethodInfoPtr_IsTriggerValid_Public_Boolean_MusicTrigger_MusicTriggerEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669263);
		NativeMethodInfoPtr_GetPreviouslyPlayedBias_Private_Single_MusicCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669264);
		NativeMethodInfoPtr_PlayNewTrack_Public_Void_MusicCue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669265);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669266);
		NativeMethodInfoPtr_StopCurrentTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669267);
		NativeMethodInfoPtr_ForceNextTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669268);
		NativeMethodInfoPtr_AudioFiltersCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669269);
		NativeMethodInfoPtr_StartMusicOnlySnapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669270);
		NativeMethodInfoPtr_StopMusicOnlySnapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669271);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669272);
		NativeMethodInfoPtr__MusicTriggerCheck_b__22_0_Private_Int32_MusicCue_MusicCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicController>.NativeClassPtr, 100669273);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201514, XrefRangeEnd = 201570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 201580, RefRangeEnd = 201583, XrefRangeStart = 201570, XrefRangeEnd = 201580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameState(MusicCue.MusicTriggerGameState newGameState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&newGameState);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameState_Public_Void_MusicTriggerGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201593, RefRangeEnd = 201594, XrefRangeStart = 201583, XrefRangeEnd = 201593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerState(MusicCue.MusicTriggerPlayerState newPlayerState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&newPlayerState);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerState_Public_Void_MusicTriggerPlayerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201604, RefRangeEnd = 201605, XrefRangeStart = 201594, XrefRangeEnd = 201604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerLocation(MusicCue.MusicTriggerPlayerLocation newPlayerLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&newPlayerLocation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerLocation_Public_Void_MusicTriggerPlayerLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 201766, RefRangeEnd = 201773, XrefRangeStart = 201605, XrefRangeEnd = 201766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MusicTriggerCheck(MusicCue.MusicTriggerEvent passEvent = MusicCue.MusicTriggerEvent.none)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&passEvent);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MusicTriggerCheck_Public_Void_MusicTriggerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 202048, RefRangeEnd = 202049, XrefRangeStart = 201773, XrefRangeEnd = 202048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTriggerValid(MusicCue.MusicTrigger trigger, MusicCue.MusicTriggerEvent passEvent, bool debug)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trigger);
		*(MusicCue.MusicTriggerEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &passEvent;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &debug;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTriggerValid_Public_Boolean_MusicTrigger_MusicTriggerEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 202054, RefRangeEnd = 202056, XrefRangeStart = 202049, XrefRangeEnd = 202054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPreviouslyPlayedBias(MusicCue cue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cue);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviouslyPlayedBias_Private_Single_MusicCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 202081, RefRangeEnd = 202082, XrefRangeStart = 202056, XrefRangeEnd = 202081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayNewTrack(MusicCue newTrack, bool interupt = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTrack);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &interupt;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayNewTrack_Public_Void_MusicCue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202082, XrefRangeEnd = 202120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 202157, RefRangeEnd = 202159, XrefRangeStart = 202120, XrefRangeEnd = 202157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopCurrentTrack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopCurrentTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 202159, RefRangeEnd = 202160, XrefRangeStart = 202159, XrefRangeEnd = 202159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceNextTrack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceNextTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 202226, RefRangeEnd = 202228, XrefRangeStart = 202160, XrefRangeEnd = 202226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AudioFiltersCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AudioFiltersCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 202247, RefRangeEnd = 202248, XrefRangeStart = 202228, XrefRangeEnd = 202247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartMusicOnlySnapshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartMusicOnlySnapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 202262, RefRangeEnd = 202265, XrefRangeStart = 202248, XrefRangeEnd = 202262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopMusicOnlySnapshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopMusicOnlySnapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202265, XrefRangeEnd = 202291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MusicController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202291, XrefRangeEnd = 202303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _MusicTriggerCheck_b__22_0(MusicCue p1, MusicCue p2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__MusicTriggerCheck_b__22_0_Private_Int32_MusicCue_MusicCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public MusicController(IntPtr pointer)
		: base(pointer)
	{
	}
}
