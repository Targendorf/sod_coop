using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SceneCapture : MonoBehaviour
{
	[System.Serializable]
	public class PhotoCache : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_img;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUsed;

		private static readonly System.IntPtr NativeFieldInfoPtr_actorSP;

		private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Texture2D img
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe float lastUsed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsed)) = num;
			}
		}

		public unsafe List<ActorScreenPosition> actorSP
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorSP);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ActorScreenPosition>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorSP)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static PhotoCache()
		{
			Il2CppClassPointerStore<PhotoCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "PhotoCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCache>.NativeClassPtr);
			NativeFieldInfoPtr_img = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCache>.NativeClassPtr, "img");
			NativeFieldInfoPtr_lastUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCache>.NativeClassPtr, "lastUsed");
			NativeFieldInfoPtr_actorSP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCache>.NativeClassPtr, "actorSP");
			NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCache>.NativeClassPtr, 100670823);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCache>.NativeClassPtr, 100670824);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 255964, RefRangeEnd = 255971, XrefRangeStart = 255950, XrefRangeEnd = 255964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255976, RefRangeEnd = 255978, XrefRangeStart = 255971, XrefRangeEnd = 255976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhotoCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCache>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PhotoCache(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class PhotoSaveToDisk : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeFieldInfoPtr_img;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUsed;

		private static readonly System.IntPtr NativeFieldInfoPtr_actorSP;

		private static readonly System.IntPtr NativeFieldInfoPtr_readOnly;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetImage_Public_Texture2D_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Texture2D img
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		public unsafe float lastUsed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsed)) = num;
			}
		}

		public unsafe List<ActorScreenPosition> actorSP
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorSP);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ActorScreenPosition>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actorSP)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool readOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readOnly);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readOnly)) = flag;
			}
		}

		static PhotoSaveToDisk()
		{
			Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "PhotoSaveToDisk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr, "data");
			NativeFieldInfoPtr_img = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr, "img");
			NativeFieldInfoPtr_lastUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr, "lastUsed");
			NativeFieldInfoPtr_actorSP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr, "actorSP");
			NativeFieldInfoPtr_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr, "readOnly");
			NativeMethodInfoPtr_GetImage_Public_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr, 100670825);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr, 100670826);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255991, RefRangeEnd = 255992, XrefRangeStart = 255978, XrefRangeEnd = 255991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetImage_Public_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255992, XrefRangeEnd = 255997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhotoSaveToDisk()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoSaveToDisk>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PhotoSaveToDisk(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class PhotoCacheLinking : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_usedInSaveFiles;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<string> usedInSaveFiles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedInSaveFiles);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedInSaveFiles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static PhotoCacheLinking()
		{
			Il2CppClassPointerStore<PhotoCacheLinking>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "PhotoCacheLinking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCacheLinking>.NativeClassPtr);
			NativeFieldInfoPtr_usedInSaveFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCacheLinking>.NativeClassPtr, "usedInSaveFiles");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCacheLinking>.NativeClassPtr, 100670827);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256003, RefRangeEnd = 256004, XrefRangeStart = 255997, XrefRangeEnd = 256003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhotoCacheLinking()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCacheLinking>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PhotoCacheLinking(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class ActorScreenPosition : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_human;

		private static readonly System.IntPtr NativeFieldInfoPtr_screenPoint;

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

		public unsafe Vector2 screenPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPoint);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenPoint)) = vector;
			}
		}

		static ActorScreenPosition()
		{
			Il2CppClassPointerStore<ActorScreenPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "ActorScreenPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorScreenPosition>.NativeClassPtr);
			NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorScreenPosition>.NativeClassPtr, "human");
			NativeFieldInfoPtr_screenPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorScreenPosition>.NativeClassPtr, "screenPoint");
		}

		public ActorScreenPosition(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ActorScreenPosition()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorScreenPosition>.NativeClassPtr))
		{
		}
	}

	public enum PostProcessingProfile
	{
		captureNormal,
		captureCCTV
	}

	[ObfuscatedName("SceneCapture+<>c__DisplayClass27_0")]
	public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_scene;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetSurveillanceScene_b__0_Internal_Boolean_AirDuctGroup_0;

		public unsafe SceneRecorder.SceneCapture scene
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scene);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneRecorder.SceneCapture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scene)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneCapture));
			}
		}

		static __c__DisplayClass27_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "<>c__DisplayClass27_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr);
			NativeFieldInfoPtr_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, "scene");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100670828);
			NativeMethodInfoPtr__GetSurveillanceScene_b__0_Internal_Boolean_AirDuctGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100670829);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass27_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetSurveillanceScene_b__0(AirDuctGroup item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetSurveillanceScene_b__0_Internal_Boolean_AirDuctGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass27_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_evidenceRenderTexturePrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_surveillanceRenderTexturePrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_evidenceFoV;

	private static readonly System.IntPtr NativeFieldInfoPtr_surveillanceFov;

	private static readonly System.IntPtr NativeFieldInfoPtr_currrentlyViewing;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxEvidenceCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedEvidencePhotos;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedRenders;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCentrePixel;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSurveillanceCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedSurveillancePhotos;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedSurveillance;

	private static readonly System.IntPtr NativeFieldInfoPtr_photoRoomParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SceneCapture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CapturePhotoOfEvidence_Public_Texture2D_Evidence_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurveillanceScene_Public_Texture2D_SceneCapture_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptureScene_Public_Texture2D_Vector3_Vector3_Int32_Boolean_Single_RenderTexture_Single_List_1_Interactable_NewNode_Boolean_Boolean_Boolean_PostProcessingProfile_Boolean_Boolean_Boolean_Boolean_SceneCapture_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptureScene_Public_Texture2D_Vector3_Vector3_Int32_Boolean_Single_RenderTexture_byref_List_1_ActorCapture_byref_List_1_ActorScreenPosition_Single_List_1_Interactable_NewNode_Boolean_Boolean_Boolean_PostProcessingProfile_Boolean_Boolean_Boolean_AirDuctGroup_Boolean_SceneCapture_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearRenderCache_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RenderTexture evidenceRenderTexturePrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceRenderTexturePrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceRenderTexturePrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderTexture));
		}
	}

	public unsafe RenderTexture surveillanceRenderTexturePrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surveillanceRenderTexturePrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surveillanceRenderTexturePrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderTexture));
		}
	}

	public unsafe float evidenceFoV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceFoV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidenceFoV)) = num;
		}
	}

	public unsafe float surveillanceFov
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surveillanceFov);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surveillanceFov)) = num;
		}
	}

	public unsafe SceneRecorder.SceneCapture currrentlyViewing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currrentlyViewing);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneRecorder.SceneCapture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currrentlyViewing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneCapture));
		}
	}

	public unsafe int maxEvidenceCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxEvidenceCache);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxEvidenceCache)) = num;
		}
	}

	public unsafe int cachedEvidencePhotos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedEvidencePhotos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedEvidencePhotos)) = num;
		}
	}

	public unsafe Dictionary<Evidence, PhotoCache> cachedRenders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedRenders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Evidence, PhotoCache>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedRenders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Color lastCentrePixel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCentrePixel);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCentrePixel)) = color;
		}
	}

	public unsafe int maxSurveillanceCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSurveillanceCache);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSurveillanceCache)) = num;
		}
	}

	public unsafe int cachedSurveillancePhotos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSurveillancePhotos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSurveillancePhotos)) = num;
		}
	}

	public unsafe Dictionary<SceneRecorder.SceneCapture, PhotoCache> cachedSurveillance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSurveillance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<SceneRecorder.SceneCapture, PhotoCache>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedSurveillance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameObject photoRoomParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoRoomParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_photoRoomParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Transform cameraTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform itemTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe static SceneCapture _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneCapture>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneCapture));
		}
	}

	public unsafe static SceneCapture Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256004, XrefRangeEnd = 256006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SceneCapture_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneCapture>(intPtr) : null;
		}
	}

	static SceneCapture()
	{
		Il2CppClassPointerStore<SceneCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SceneCapture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr);
		NativeFieldInfoPtr_evidenceRenderTexturePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "evidenceRenderTexturePrefab");
		NativeFieldInfoPtr_surveillanceRenderTexturePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "surveillanceRenderTexturePrefab");
		NativeFieldInfoPtr_evidenceFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "evidenceFoV");
		NativeFieldInfoPtr_surveillanceFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "surveillanceFov");
		NativeFieldInfoPtr_currrentlyViewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "currrentlyViewing");
		NativeFieldInfoPtr_maxEvidenceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "maxEvidenceCache");
		NativeFieldInfoPtr_cachedEvidencePhotos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "cachedEvidencePhotos");
		NativeFieldInfoPtr_cachedRenders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "cachedRenders");
		NativeFieldInfoPtr_lastCentrePixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "lastCentrePixel");
		NativeFieldInfoPtr_maxSurveillanceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "maxSurveillanceCache");
		NativeFieldInfoPtr_cachedSurveillancePhotos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "cachedSurveillancePhotos");
		NativeFieldInfoPtr_cachedSurveillance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "cachedSurveillance");
		NativeFieldInfoPtr_photoRoomParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "photoRoomParent");
		NativeFieldInfoPtr_cameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "cameraTransform");
		NativeFieldInfoPtr_itemTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "itemTransform");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SceneCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670813);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670814);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670815);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670816);
		NativeMethodInfoPtr_CapturePhotoOfEvidence_Public_Texture2D_Evidence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670817);
		NativeMethodInfoPtr_GetSurveillanceScene_Public_Texture2D_SceneCapture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670818);
		NativeMethodInfoPtr_CaptureScene_Public_Texture2D_Vector3_Vector3_Int32_Boolean_Single_RenderTexture_Single_List_1_Interactable_NewNode_Boolean_Boolean_Boolean_PostProcessingProfile_Boolean_Boolean_Boolean_Boolean_SceneCapture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670819);
		NativeMethodInfoPtr_CaptureScene_Public_Texture2D_Vector3_Vector3_Int32_Boolean_Single_RenderTexture_byref_List_1_ActorCapture_byref_List_1_ActorScreenPosition_Single_List_1_Interactable_NewNode_Boolean_Boolean_Boolean_PostProcessingProfile_Boolean_Boolean_Boolean_AirDuctGroup_Boolean_SceneCapture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670820);
		NativeMethodInfoPtr_ClearRenderCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670821);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670822);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256006, XrefRangeEnd = 256043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256043, XrefRangeEnd = 256091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256091, XrefRangeEnd = 256096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 256169, RefRangeEnd = 256170, XrefRangeStart = 256096, XrefRangeEnd = 256169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D CapturePhotoOfEvidence(Evidence ev, bool forceNew = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceNew;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CapturePhotoOfEvidence_Public_Texture2D_Evidence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 256553, RefRangeEnd = 256556, XrefRangeStart = 256170, XrefRangeEnd = 256553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D GetSurveillanceScene(SceneRecorder.SceneCapture scene, bool saveToCache = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scene);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveToCache;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurveillanceScene_Public_Texture2D_SceneCapture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 256563, RefRangeEnd = 256564, XrefRangeStart = 256556, XrefRangeEnd = 256563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D CaptureScene(Vector3 pos, Vector3 euler, int layerMask, bool changeTimeOfDay, float decimalClock, RenderTexture renderPrefab, float fov = 70f, List<Interactable> forceHide = null, NewNode passNode = null, bool useCaptureLight = true, bool basicMode = false, bool ignoreEarlyCapError = false, PostProcessingProfile captureProfile = PostProcessingProfile.captureNormal, bool useFlashlight = false, bool useFlash = false, bool readOnly = true, bool sampleCentrePixel = false, SceneRecorder.SceneCapture sceneRef = null, bool saveToDisk = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[19];
		*ptr = (nint)(&pos);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &euler;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeTimeOfDay;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimalClock;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPrefab);
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &fov;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceHide);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passNode);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCaptureLight;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &basicMode;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreEarlyCapError;
		*(PostProcessingProfile**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &captureProfile;
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFlashlight;
		*(bool**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFlash;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &readOnly;
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleCentrePixel;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneRef);
		*(bool**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveToDisk;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureScene_Public_Texture2D_Vector3_Vector3_Int32_Boolean_Single_RenderTexture_Single_List_1_Interactable_NewNode_Boolean_Boolean_Boolean_PostProcessingProfile_Boolean_Boolean_Boolean_Boolean_SceneCapture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 257155, RefRangeEnd = 257157, XrefRangeStart = 256564, XrefRangeEnd = 257155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D CaptureScene(Vector3 pos, Vector3 euler, int layerMask, bool changeTimeOfDay, float decimalClock, RenderTexture renderPrefab, ref List<SceneRecorder.ActorCapture> humanRef, out List<ActorScreenPosition> actorScreenPointCapture, float fov = 70f, List<Interactable> forceHide = null, NewNode passNode = null, bool useCaptureLight = true, bool basicMode = false, bool ignoreEarlyCapError = false, PostProcessingProfile captureProfile = PostProcessingProfile.captureNormal, bool useFlashlight = false, bool useFlash = false, bool readOnly = true, AirDuctGroup inAirDuctGroup = null, bool sampleCentrePixel = false, SceneRecorder.SceneCapture sceneRef = null, bool saveToDisk = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[22];
		*ptr = (nint)(&pos);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &euler;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeTimeOfDay;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimalClock;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPrefab);
		byte* num = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)humanRef);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &fov;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forceHide);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passNode);
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCaptureLight;
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &basicMode;
		*(bool**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreEarlyCapError;
		*(PostProcessingProfile**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &captureProfile;
		*(bool**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFlashlight;
		*(bool**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFlash;
		*(bool**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(System.IntPtr)))) = &readOnly;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inAirDuctGroup);
		*(bool**)((byte*)ptr + checked((nuint)19u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleCentrePixel;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)20u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneRef);
		*(bool**)((byte*)ptr + checked((nuint)21u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveToDisk;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureScene_Public_Texture2D_Vector3_Vector3_Int32_Boolean_Single_RenderTexture_byref_List_1_ActorCapture_byref_List_1_ActorScreenPosition_Single_List_1_Interactable_NewNode_Boolean_Boolean_Boolean_PostProcessingProfile_Boolean_Boolean_Boolean_AirDuctGroup_Boolean_SceneCapture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		humanRef = ((intPtr4 == (System.IntPtr)0) ? null : new List<SceneRecorder.ActorCapture>(intPtr4));
		nint num4 = num3;
		actorScreenPointCapture = ((num4 == 0) ? null : new List<ActorScreenPosition>(num4));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257157, XrefRangeEnd = 257183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearRenderCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearRenderCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257183, XrefRangeEnd = 257196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneCapture()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SceneCapture(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
