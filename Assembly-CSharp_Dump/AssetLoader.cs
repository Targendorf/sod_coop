using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AssetLoader : Il2CppSystem.Object
{
	[ObfuscatedName("AssetLoader+<PerformInitialLoadAsync>d__34")]
	public sealed class _PerformInitialLoadAsync_d__34 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__time_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__originalVSync_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr__asyncOperationHandleData_5__4;

		private static readonly System.IntPtr NativeFieldInfoPtr__asyncOperationHandleFloorData_5__5;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__2;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe AssetLoader __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetLoader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assetLoader));
			}
		}

		public unsafe float _time_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__time_5__2);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__time_5__2)) = num;
			}
		}

		public unsafe int _originalVSync_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__originalVSync_5__3);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__originalVSync_5__3)) = num;
			}
		}

		public unsafe AsyncOperationHandle<IList<ScriptableObject>> _asyncOperationHandleData_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__asyncOperationHandleData_5__4);
				return new AsyncOperationHandle<IList<ScriptableObject>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<ScriptableObject>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__asyncOperationHandleData_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncOperationHandle)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<ScriptableObject>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe AsyncOperationHandle<IList<TextAsset>> _asyncOperationHandleFloorData_5__5
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__asyncOperationHandleFloorData_5__5);
				return new AsyncOperationHandle<IList<TextAsset>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<TextAsset>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__asyncOperationHandleFloorData_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncOperationHandle)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<TextAsset>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<ScriptableObject>> __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<ScriptableObject>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<ScriptableObject>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<ScriptableObject>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<TextAsset>> __u__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<TextAsset>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<TextAsset>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<IList<TextAsset>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _PerformInitialLoadAsync_d__34()
		{
			Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "<PerformInitialLoadAsync>d__34");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<time>5__2");
			NativeFieldInfoPtr__originalVSync_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<originalVSync>5__3");
			NativeFieldInfoPtr__asyncOperationHandleData_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<asyncOperationHandleData>5__4");
			NativeFieldInfoPtr__asyncOperationHandleFloorData_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<asyncOperationHandleFloorData>5__5");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<>u__1");
			NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, "<>u__2");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, 100666780);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr, 100666781);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115021, XrefRangeEnd = 115189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115189, XrefRangeEnd = 115193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _PerformInitialLoadAsync_d__34(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _PerformInitialLoadAsync_d__34()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_PerformInitialLoadAsync_d__34>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DATA_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_AMBIENT_ZONES_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MUSIC_CUES_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAPTERS_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACTIONS_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_FLOOR_DATA_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUILDING_DATA_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_FURNITURE_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTABLES_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLOTHES_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_LAYOUT_CONFIG_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_ROOM_CONFIG_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_ROOM_PRESETS_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_DOOR_PAIR_PRESETS_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_allPresets;

	private static readonly System.IntPtr NativeFieldInfoPtr_allAmbientZones;

	private static readonly System.IntPtr NativeFieldInfoPtr_allMusicCues;

	private static readonly System.IntPtr NativeFieldInfoPtr_allChapters;

	private static readonly System.IntPtr NativeFieldInfoPtr_allActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_allFloorData;

	private static readonly System.IntPtr NativeFieldInfoPtr_allBuildingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_allFurniture;

	private static readonly System.IntPtr NativeFieldInfoPtr_allInteractables;

	private static readonly System.IntPtr NativeFieldInfoPtr_allClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_allLayoutConfigurations;

	private static readonly System.IntPtr NativeFieldInfoPtr_allRoomConfigurations;

	private static readonly System.IntPtr NativeFieldInfoPtr_allRoomTypePresets;

	private static readonly System.IntPtr NativeFieldInfoPtr_allDoorPairPresets;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AssetLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortScriptableObject_Private_Void_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeDiff_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeDiffStr_Private_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformInitialLoadAsync_Public_Task_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllPresets_Public_List_1_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllAmbientZones_Public_List_1_AmbientZone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllMusicCues_Public_List_1_MusicCue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllChapters_Public_List_1_ChapterPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllActions_Public_List_1_AIActionPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllFloorData_Public_List_1_TextAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllBuildingPresets_Public_List_1_BuildingPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllFurniture_Public_List_1_FurniturePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllInteractables_Public_List_1_InteractablePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllClothes_Public_List_1_ClothesPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllLayoutConfigurations_Public_List_1_LayoutConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllRoomConfigurations_Public_List_1_RoomConfiguration_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllRoomTypePresets_Public_List_1_RoomTypePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllDoorPairPresets_Public_List_1_DoorPairPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string DATA_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DATA_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DATA_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AMBIENT_ZONES_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AMBIENT_ZONES_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AMBIENT_ZONES_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MUSIC_CUES_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MUSIC_CUES_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MUSIC_CUES_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CHAPTERS_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAPTERS_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAPTERS_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACTIONS_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACTIONS_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACTIONS_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string FLOOR_DATA_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FLOOR_DATA_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FLOOR_DATA_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BUILDING_DATA_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUILDING_DATA_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUILDING_DATA_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string FURNITURE_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FURNITURE_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FURNITURE_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INTERACTABLES_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTABLES_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTABLES_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CLOTHES_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLOTHES_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLOTHES_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LAYOUT_CONFIG_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LAYOUT_CONFIG_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LAYOUT_CONFIG_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ROOM_CONFIG_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ROOM_CONFIG_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ROOM_CONFIG_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ROOM_PRESETS_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ROOM_PRESETS_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ROOM_PRESETS_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DOOR_PAIR_PRESETS_GROUP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOOR_PAIR_PRESETS_GROUP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOOR_PAIR_PRESETS_GROUP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static AssetLoader instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetLoader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)assetLoader));
		}
	}

	public unsafe List<ScriptableObject> allPresets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allPresets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allPresets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AmbientZone> allAmbientZones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allAmbientZones);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AmbientZone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allAmbientZones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MusicCue> allMusicCues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allMusicCues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MusicCue>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allMusicCues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ChapterPreset> allChapters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allChapters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ChapterPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allChapters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AIActionPreset> allActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<TextAsset> allFloorData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allFloorData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextAsset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allFloorData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BuildingPreset> allBuildingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allBuildingData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allBuildingData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FurniturePreset> allFurniture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allFurniture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurniturePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allFurniture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> allInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allInteractables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allInteractables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ClothesPreset> allClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allClothes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allClothes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LayoutConfiguration> allLayoutConfigurations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLayoutConfigurations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LayoutConfiguration>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allLayoutConfigurations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RoomConfiguration> allRoomConfigurations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allRoomConfigurations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allRoomConfigurations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RoomTypePreset> allRoomTypePresets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allRoomTypePresets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allRoomTypePresets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DoorPairPreset> allDoorPairPresets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allDoorPairPresets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DoorPairPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allDoorPairPresets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static AssetLoader Instance
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 115205, RefRangeEnd = 115223, XrefRangeStart = 115193, XrefRangeEnd = 115205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_AssetLoader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AssetLoader>(intPtr) : null;
		}
	}

	static AssetLoader()
	{
		Il2CppClassPointerStore<AssetLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AssetLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr);
		NativeFieldInfoPtr_DATA_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "DATA_GROUP");
		NativeFieldInfoPtr_AMBIENT_ZONES_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "AMBIENT_ZONES_GROUP");
		NativeFieldInfoPtr_MUSIC_CUES_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "MUSIC_CUES_GROUP");
		NativeFieldInfoPtr_CHAPTERS_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "CHAPTERS_GROUP");
		NativeFieldInfoPtr_ACTIONS_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "ACTIONS_GROUP");
		NativeFieldInfoPtr_FLOOR_DATA_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "FLOOR_DATA_GROUP");
		NativeFieldInfoPtr_BUILDING_DATA_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "BUILDING_DATA_GROUP");
		NativeFieldInfoPtr_FURNITURE_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "FURNITURE_GROUP");
		NativeFieldInfoPtr_INTERACTABLES_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "INTERACTABLES_GROUP");
		NativeFieldInfoPtr_CLOTHES_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "CLOTHES_GROUP");
		NativeFieldInfoPtr_LAYOUT_CONFIG_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "LAYOUT_CONFIG_GROUP");
		NativeFieldInfoPtr_ROOM_CONFIG_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "ROOM_CONFIG_GROUP");
		NativeFieldInfoPtr_ROOM_PRESETS_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "ROOM_PRESETS_GROUP");
		NativeFieldInfoPtr_DOOR_PAIR_PRESETS_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "DOOR_PAIR_PRESETS_GROUP");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_allPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allPresets");
		NativeFieldInfoPtr_allAmbientZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allAmbientZones");
		NativeFieldInfoPtr_allMusicCues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allMusicCues");
		NativeFieldInfoPtr_allChapters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allChapters");
		NativeFieldInfoPtr_allActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allActions");
		NativeFieldInfoPtr_allFloorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allFloorData");
		NativeFieldInfoPtr_allBuildingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allBuildingData");
		NativeFieldInfoPtr_allFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allFurniture");
		NativeFieldInfoPtr_allInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allInteractables");
		NativeFieldInfoPtr_allClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allClothes");
		NativeFieldInfoPtr_allLayoutConfigurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allLayoutConfigurations");
		NativeFieldInfoPtr_allRoomConfigurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allRoomConfigurations");
		NativeFieldInfoPtr_allRoomTypePresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allRoomTypePresets");
		NativeFieldInfoPtr_allDoorPairPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, "allDoorPairPresets");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_AssetLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666759);
		NativeMethodInfoPtr_SortScriptableObject_Private_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666760);
		NativeMethodInfoPtr_TimeDiff_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666761);
		NativeMethodInfoPtr_TimeDiffStr_Private_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666762);
		NativeMethodInfoPtr_PerformInitialLoadAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666763);
		NativeMethodInfoPtr_GetAllPresets_Public_List_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666764);
		NativeMethodInfoPtr_GetAllAmbientZones_Public_List_1_AmbientZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666765);
		NativeMethodInfoPtr_GetAllMusicCues_Public_List_1_MusicCue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666766);
		NativeMethodInfoPtr_GetAllChapters_Public_List_1_ChapterPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666767);
		NativeMethodInfoPtr_GetAllActions_Public_List_1_AIActionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666768);
		NativeMethodInfoPtr_GetAllFloorData_Public_List_1_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666769);
		NativeMethodInfoPtr_GetAllBuildingPresets_Public_List_1_BuildingPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666770);
		NativeMethodInfoPtr_GetAllFurniture_Public_List_1_FurniturePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666771);
		NativeMethodInfoPtr_GetAllInteractables_Public_List_1_InteractablePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666772);
		NativeMethodInfoPtr_GetAllClothes_Public_List_1_ClothesPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666773);
		NativeMethodInfoPtr_GetAllLayoutConfigurations_Public_List_1_LayoutConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666774);
		NativeMethodInfoPtr_GetAllRoomConfigurations_Public_List_1_RoomConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666775);
		NativeMethodInfoPtr_GetAllRoomTypePresets_Public_List_1_RoomTypePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666776);
		NativeMethodInfoPtr_GetAllDoorPairPresets_Public_List_1_DoorPairPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666777);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr, 100666778);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115223, XrefRangeEnd = 115242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortScriptableObject(ScriptableObject scriptableObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scriptableObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortScriptableObject_Private_Void_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115242, XrefRangeEnd = 115244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float TimeDiff(float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeDiff_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115256, RefRangeEnd = 115258, XrefRangeStart = 115244, XrefRangeEnd = 115256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TimeDiffStr(float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeDiffStr_Private_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115258, XrefRangeEnd = 115270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task PerformInitialLoadAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformInitialLoadAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115287, RefRangeEnd = 115288, XrefRangeStart = 115270, XrefRangeEnd = 115287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ScriptableObject> GetAllPresets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllPresets_Public_List_1_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115288, XrefRangeEnd = 115305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<AmbientZone> GetAllAmbientZones()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllAmbientZones_Public_List_1_AmbientZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AmbientZone>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115322, RefRangeEnd = 115323, XrefRangeStart = 115305, XrefRangeEnd = 115322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<MusicCue> GetAllMusicCues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllMusicCues_Public_List_1_MusicCue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MusicCue>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115340, RefRangeEnd = 115341, XrefRangeStart = 115323, XrefRangeEnd = 115340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ChapterPreset> GetAllChapters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllChapters_Public_List_1_ChapterPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ChapterPreset>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115358, RefRangeEnd = 115359, XrefRangeStart = 115341, XrefRangeEnd = 115358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<AIActionPreset> GetAllActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllActions_Public_List_1_AIActionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115376, RefRangeEnd = 115377, XrefRangeStart = 115359, XrefRangeEnd = 115376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<TextAsset> GetAllFloorData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllFloorData_Public_List_1_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextAsset>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115394, RefRangeEnd = 115398, XrefRangeStart = 115377, XrefRangeEnd = 115394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<BuildingPreset> GetAllBuildingPresets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllBuildingPresets_Public_List_1_BuildingPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingPreset>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115415, RefRangeEnd = 115417, XrefRangeStart = 115398, XrefRangeEnd = 115415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<FurniturePreset> GetAllFurniture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllFurniture_Public_List_1_FurniturePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurniturePreset>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115434, RefRangeEnd = 115435, XrefRangeStart = 115417, XrefRangeEnd = 115434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<InteractablePreset> GetAllInteractables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllInteractables_Public_List_1_InteractablePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115452, RefRangeEnd = 115453, XrefRangeStart = 115435, XrefRangeEnd = 115452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ClothesPreset> GetAllClothes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllClothes_Public_List_1_ClothesPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115470, RefRangeEnd = 115471, XrefRangeStart = 115453, XrefRangeEnd = 115470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<LayoutConfiguration> GetAllLayoutConfigurations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllLayoutConfigurations_Public_List_1_LayoutConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LayoutConfiguration>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115488, RefRangeEnd = 115489, XrefRangeStart = 115471, XrefRangeEnd = 115488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<RoomConfiguration> GetAllRoomConfigurations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllRoomConfigurations_Public_List_1_RoomConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115506, RefRangeEnd = 115507, XrefRangeStart = 115489, XrefRangeEnd = 115506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<RoomTypePreset> GetAllRoomTypePresets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllRoomTypePresets_Public_List_1_RoomTypePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115524, RefRangeEnd = 115525, XrefRangeStart = 115507, XrefRangeEnd = 115524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DoorPairPreset> GetAllDoorPairPresets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllDoorPairPresets_Public_List_1_DoorPairPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DoorPairPreset>>(intPtr) : null;
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLoader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AssetLoader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
