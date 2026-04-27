using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class InteractableCreator : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_debugFindID;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_InteractableCreator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCitizenInteractable_Public_Interactable_InteractablePreset_Human_Transform_Evidence_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTransformInteractable_Public_Interactable_InteractablePreset_Transform_Human_Evidence_Vector3_Vector3_List_1_Passed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFurnitureIntegratedInteractable_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_Human_Human_Human_Vector3_Vector3_InteractableID_SubObjectOwnership_LightingPreset_List_1_Passed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFurnitureSpawnedInteractableThreadSafe_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_SubObject_Human_Human_Human_List_1_Passed_LightingPreset_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFurnitureSpawnedInteractable_Public_Interactable_InteractablePreset_FurnitureLocation_SubObject_Human_Human_Human_List_1_Passed_LightingPreset_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorldInteractable_Public_Interactable_InteractablePreset_Human_Human_Human_Vector3_Vector3_List_1_Passed_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorldInteractableFromMetaObject_Public_Interactable_MetaObject_InteractablePreset_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDoorParentedInteractable_Public_Interactable_InteractablePreset_NewDoor_Human_Vector3_Vector3_List_1_Passed_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMainLightInteractable_Public_Interactable_InteractablePreset_NewRoom_Vector3_Vector3_LightingPreset_LightConfiguration_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBookInteractable_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_Human_Vector3_Vector3_BookPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFingerprintInteractable_Public_Interactable_Human_Vector3_Vector3_Print_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFootprintInteractable_Public_Interactable_Human_Vector3_Vector3_Footprint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInteractableLock_Public_Interactable_InteractablePreset_FurnitureLocation_Human_Vector3_Vector3_InteractableID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindInteractable_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSpawnCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListFurnitureParentSpawned_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoomBasedInteractableID_Public_Int32_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFurnitureBasedInteractableID_Public_Int32_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__FindInteractable_b__19_0_Private_Boolean_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ForceSpawnCheck_b__20_0_Private_Boolean_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ListFurnitureParentSpawned_b__21_0_Private_Boolean_Interactable_0;

	public unsafe int debugFindID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFindID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFindID)) = num;
		}
	}

	public unsafe static InteractableCreator _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractableCreator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactableCreator));
		}
	}

	public unsafe static InteractableCreator Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230272, XrefRangeEnd = 230274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_InteractableCreator_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractableCreator>(intPtr) : null;
		}
	}

	static InteractableCreator()
	{
		Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InteractableCreator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr);
		NativeFieldInfoPtr_debugFindID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, "debugFindID");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_InteractableCreator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669963);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669964);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669965);
		NativeMethodInfoPtr_CreateCitizenInteractable_Public_Interactable_InteractablePreset_Human_Transform_Evidence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669966);
		NativeMethodInfoPtr_CreateTransformInteractable_Public_Interactable_InteractablePreset_Transform_Human_Evidence_Vector3_Vector3_List_1_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669967);
		NativeMethodInfoPtr_CreateFurnitureIntegratedInteractable_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_Human_Human_Human_Vector3_Vector3_InteractableID_SubObjectOwnership_LightingPreset_List_1_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669968);
		NativeMethodInfoPtr_CreateFurnitureSpawnedInteractableThreadSafe_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_SubObject_Human_Human_Human_List_1_Passed_LightingPreset_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669969);
		NativeMethodInfoPtr_CreateFurnitureSpawnedInteractable_Public_Interactable_InteractablePreset_FurnitureLocation_SubObject_Human_Human_Human_List_1_Passed_LightingPreset_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669970);
		NativeMethodInfoPtr_CreateWorldInteractable_Public_Interactable_InteractablePreset_Human_Human_Human_Vector3_Vector3_List_1_Passed_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669971);
		NativeMethodInfoPtr_CreateWorldInteractableFromMetaObject_Public_Interactable_MetaObject_InteractablePreset_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669972);
		NativeMethodInfoPtr_CreateDoorParentedInteractable_Public_Interactable_InteractablePreset_NewDoor_Human_Vector3_Vector3_List_1_Passed_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669973);
		NativeMethodInfoPtr_CreateMainLightInteractable_Public_Interactable_InteractablePreset_NewRoom_Vector3_Vector3_LightingPreset_LightConfiguration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669974);
		NativeMethodInfoPtr_CreateBookInteractable_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_Human_Vector3_Vector3_BookPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669975);
		NativeMethodInfoPtr_CreateFingerprintInteractable_Public_Interactable_Human_Vector3_Vector3_Print_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669976);
		NativeMethodInfoPtr_CreateFootprintInteractable_Public_Interactable_Human_Vector3_Vector3_Footprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669977);
		NativeMethodInfoPtr_CreateInteractableLock_Public_Interactable_InteractablePreset_FurnitureLocation_Human_Vector3_Vector3_InteractableID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669978);
		NativeMethodInfoPtr_FindInteractable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669979);
		NativeMethodInfoPtr_ForceSpawnCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669980);
		NativeMethodInfoPtr_ListFurnitureParentSpawned_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669981);
		NativeMethodInfoPtr_GetRoomBasedInteractableID_Public_Int32_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669982);
		NativeMethodInfoPtr_GetFurnitureBasedInteractableID_Public_Int32_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669983);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669984);
		NativeMethodInfoPtr__FindInteractable_b__19_0_Private_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669985);
		NativeMethodInfoPtr__ForceSpawnCheck_b__20_0_Private_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669986);
		NativeMethodInfoPtr__ListFurnitureParentSpawned_b__21_0_Private_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr, 100669987);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230274, XrefRangeEnd = 230311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230311, XrefRangeEnd = 230332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 230357, RefRangeEnd = 230362, XrefRangeStart = 230332, XrefRangeEnd = 230357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateCitizenInteractable(InteractablePreset preset, Human citizen, Transform trans, Evidence evidence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizen);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidence);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCitizenInteractable_Public_Interactable_InteractablePreset_Human_Transform_Evidence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 230371, RefRangeEnd = 230388, XrefRangeStart = 230362, XrefRangeEnd = 230371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateTransformInteractable(InteractablePreset preset, Transform trans, Human belongsTo, Evidence evidence, Vector3 localPos, Vector3 localEuler, List<Interactable.Passed> passedVars)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trans);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidence);
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPos;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &localEuler;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTransformInteractable_Public_Interactable_InteractablePreset_Transform_Human_Evidence_Vector3_Vector3_List_1_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230425, RefRangeEnd = 230426, XrefRangeStart = 230388, XrefRangeEnd = 230425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateFurnitureIntegratedInteractable(InteractablePreset preset, NewRoom room, FurnitureLocation furniture, Human belongsTo, Human writer, Human recevier, Vector3 localPos, Vector3 localEuler, InteractableController.InteractableID pairTo, FurniturePreset.SubObjectOwnership pairToOwner, LightingPreset isLight, List<Interactable.Passed> passedVars)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recevier);
		*(Vector3**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPos;
		*(Vector3**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &localEuler;
		*(InteractableController.InteractableID**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &pairTo;
		*(FurniturePreset.SubObjectOwnership**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &pairToOwner;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isLight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFurnitureIntegratedInteractable_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_Human_Human_Human_Vector3_Vector3_InteractableID_SubObjectOwnership_LightingPreset_List_1_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 230460, RefRangeEnd = 230464, XrefRangeStart = 230426, XrefRangeEnd = 230460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateFurnitureSpawnedInteractableThreadSafe(InteractablePreset preset, NewRoom room, FurnitureLocation furniture, FurniturePreset.SubObject subObject, Human belongsTo, Human writer, Human recevier, List<Interactable.Passed> passedVars, LightingPreset isLight, Il2CppSystem.Object passedObject, string ddsOverride = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recevier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isLight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ddsOverride);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFurnitureSpawnedInteractableThreadSafe_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_SubObject_Human_Human_Human_List_1_Passed_LightingPreset_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 230498, RefRangeEnd = 230504, XrefRangeStart = 230464, XrefRangeEnd = 230498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateFurnitureSpawnedInteractable(InteractablePreset preset, FurnitureLocation furniture, FurniturePreset.SubObject subObject, Human belongsTo, Human writer, Human recevier, List<Interactable.Passed> passedVars, LightingPreset isLight, Il2CppSystem.Object passedObject, string ddsOverride = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recevier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)isLight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ddsOverride);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFurnitureSpawnedInteractable_Public_Interactable_InteractablePreset_FurnitureLocation_SubObject_Human_Human_Human_List_1_Passed_LightingPreset_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(62)]
	[CachedScanResults(RefRangeStart = 230542, RefRangeEnd = 230604, XrefRangeStart = 230504, XrefRangeEnd = 230542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateWorldInteractable(InteractablePreset preset, Human belongsTo, Human writer, Human recevier, Vector3 worldPos, Vector3 worldEuler, List<Interactable.Passed> passedVars, Il2CppSystem.Object passedObject, string ddsOverride = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recevier);
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldEuler;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ddsOverride);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWorldInteractable_Public_Interactable_InteractablePreset_Human_Human_Human_Vector3_Vector3_List_1_Passed_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230634, RefRangeEnd = 230635, XrefRangeStart = 230604, XrefRangeEnd = 230634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateWorldInteractableFromMetaObject(MetaObject meta, InteractablePreset preset, Vector3 worldPos, Vector3 worldEuler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meta);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldEuler;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWorldInteractableFromMetaObject_Public_Interactable_MetaObject_InteractablePreset_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230659, RefRangeEnd = 230660, XrefRangeStart = 230635, XrefRangeEnd = 230659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateDoorParentedInteractable(InteractablePreset preset, NewDoor door, Human belongsTo, Vector3 localPos, Vector3 localEuler, List<Interactable.Passed> passedVars, string ddsOverride = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)door);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPos;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &localEuler;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ddsOverride);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDoorParentedInteractable_Public_Interactable_InteractablePreset_NewDoor_Human_Vector3_Vector3_List_1_Passed_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230660, XrefRangeEnd = 230669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateMainLightInteractable(InteractablePreset preset, NewRoom room, Vector3 worldPos, Vector3 worldEuler, LightingPreset lightPreset, Interactable.LightConfiguration preconfiguredLight, int lightZoneSize = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldEuler;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightPreset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preconfiguredLight);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightZoneSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMainLightInteractable_Public_Interactable_InteractablePreset_NewRoom_Vector3_Vector3_LightingPreset_LightConfiguration_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230680, RefRangeEnd = 230681, XrefRangeStart = 230669, XrefRangeEnd = 230680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateBookInteractable(InteractablePreset preset, NewRoom room, FurnitureLocation furniture, Human belongsTo, Vector3 localPos, Vector3 localEuler, BookPreset book)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPos;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &localEuler;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)book);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBookInteractable_Public_Interactable_InteractablePreset_NewRoom_FurnitureLocation_Human_Vector3_Vector3_BookPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 230705, RefRangeEnd = 230707, XrefRangeStart = 230681, XrefRangeEnd = 230705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateFingerprintInteractable(Human belongsTo, Vector3 worldPos, Vector3 worldEuler, FingerprintScannerController.Print print)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldEuler;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)print);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFingerprintInteractable_Public_Interactable_Human_Vector3_Vector3_Print_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230730, RefRangeEnd = 230731, XrefRangeStart = 230707, XrefRangeEnd = 230730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateFootprintInteractable(Human belongsTo, Vector3 worldPos, Vector3 worldEuler, GameplayController.Footprint print)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPos;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldEuler;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)print);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFootprintInteractable_Public_Interactable_Human_Vector3_Vector3_Footprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230731, XrefRangeEnd = 230740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable CreateInteractableLock(InteractablePreset preset, FurnitureLocation furniture, Human belongsTo, Vector3 localPos, Vector3 localEuler, InteractableController.InteractableID pairTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)belongsTo);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPos;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &localEuler;
		*(InteractableController.InteractableID**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &pairTo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInteractableLock_Public_Interactable_InteractablePreset_FurnitureLocation_Human_Vector3_Vector3_InteractableID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230740, XrefRangeEnd = 230764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindInteractable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindInteractable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230764, XrefRangeEnd = 230834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceSpawnCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSpawnCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230834, XrefRangeEnd = 230923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ListFurnitureParentSpawned()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListFurnitureParentSpawned_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230923, XrefRangeEnd = 230934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRoomBasedInteractableID(NewRoom r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)r);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoomBasedInteractableID_Public_Int32_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetFurnitureBasedInteractableID(FurnitureLocation f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)f);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFurnitureBasedInteractableID_Public_Int32_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractableCreator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableCreator>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _FindInteractable_b__19_0(Interactable item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindInteractable_b__19_0_Private_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _ForceSpawnCheck_b__20_0(Interactable item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ForceSpawnCheck_b__20_0_Private_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _ListFurnitureParentSpawned_b__21_0(Interactable item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ListFurnitureParentSpawned_b__21_0_Private_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public InteractableCreator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
