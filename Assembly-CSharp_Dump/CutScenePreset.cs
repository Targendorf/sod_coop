using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CutScenePreset : SoCustomComparison
{
	[System.Serializable]
	public class CutSceneElement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_disable;

		private static readonly System.IntPtr NativeFieldInfoPtr_elementType;

		private static readonly System.IntPtr NativeFieldInfoPtr_movement;

		private static readonly System.IntPtr NativeFieldInfoPtr_lerpPositionGraph;

		private static readonly System.IntPtr NativeFieldInfoPtr_lerpRotationGraph;

		private static readonly System.IntPtr NativeFieldInfoPtr_ddsMessage;

		private static readonly System.IntPtr NativeFieldInfoPtr_messageDelay;

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

		public unsafe bool disable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable)) = flag;
			}
		}

		public unsafe ElementType elementType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementType);
				return *(ElementType*)num;
			}
			set
			{
				*(ElementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementType)) = elementType;
			}
		}

		public unsafe List<CameraMovement> movement
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movement);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CameraMovement>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe AnimationCurve lerpPositionGraph
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpPositionGraph);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpPositionGraph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
			}
		}

		public unsafe AnimationCurve lerpRotationGraph
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpRotationGraph);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpRotationGraph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
			}
		}

		public unsafe string ddsMessage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessage);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float messageDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageDelay)) = num;
			}
		}

		static CutSceneElement()
		{
			Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "CutSceneElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "name");
			NativeFieldInfoPtr_disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "disable");
			NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "elementType");
			NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "movement");
			NativeFieldInfoPtr_lerpPositionGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "lerpPositionGraph");
			NativeFieldInfoPtr_lerpRotationGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "lerpRotationGraph");
			NativeFieldInfoPtr_ddsMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "ddsMessage");
			NativeFieldInfoPtr_messageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, "messageDelay");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr, 100673870);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneElement>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CutSceneElement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ElementType
	{
		newShot,
		ddsMessage
	}

	public enum OnEndScene
	{
		resumeGameplay,
		startGame,
		endGame
	}

	public enum AnchorType
	{
		blockCorner,
		middle
	}

	[System.Serializable]
	public class CameraMovement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_atDuration;

		private static readonly System.IntPtr NativeFieldInfoPtr_camPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_camEuler;

		private static readonly System.IntPtr NativeFieldInfoPtr_anchor;

		private static readonly System.IntPtr NativeFieldInfoPtr_overridePosGraph;

		private static readonly System.IntPtr NativeFieldInfoPtr_lerpPositionGraphOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideRotGraph;

		private static readonly System.IntPtr NativeFieldInfoPtr_lerpRotationGraphOverride;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float atDuration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atDuration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atDuration)) = num;
			}
		}

		public unsafe Vector3 camPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camPos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camPos)) = vector;
			}
		}

		public unsafe Vector3 camEuler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camEuler);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camEuler)) = vector;
			}
		}

		public unsafe AnchorType anchor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor);
				return *(AnchorType*)num;
			}
			set
			{
				*(AnchorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor)) = anchorType;
			}
		}

		public unsafe bool overridePosGraph
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridePosGraph);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overridePosGraph)) = flag;
			}
		}

		public unsafe AnimationCurve lerpPositionGraphOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpPositionGraphOverride);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpPositionGraphOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
			}
		}

		public unsafe bool overrideRotGraph
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideRotGraph);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideRotGraph)) = flag;
			}
		}

		public unsafe AnimationCurve lerpRotationGraphOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpRotationGraphOverride);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpRotationGraphOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
			}
		}

		static CameraMovement()
		{
			Il2CppClassPointerStore<CameraMovement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "CameraMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr);
			NativeFieldInfoPtr_atDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "atDuration");
			NativeFieldInfoPtr_camPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "camPos");
			NativeFieldInfoPtr_camEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "camEuler");
			NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "anchor");
			NativeFieldInfoPtr_overridePosGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "overridePosGraph");
			NativeFieldInfoPtr_lerpPositionGraphOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "lerpPositionGraphOverride");
			NativeFieldInfoPtr_overrideRotGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "overrideRotGraph");
			NativeFieldInfoPtr_lerpRotationGraphOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, "lerpRotationGraphOverride");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr, 100673871);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraMovement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraMovement>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CameraMovement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_elementList;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeInTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageFadeIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageFadeInSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageFadeOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_imageFadeOutSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableAISpeech;

	private static readonly System.IntPtr NativeFieldInfoPtr_onEnd;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordCurrentPositionToNewShot_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<CutSceneElement> elementList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CutSceneElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool fadeIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeIn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeIn)) = flag;
		}
	}

	public unsafe float fadeInTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeInTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeInTime)) = num;
		}
	}

	public unsafe bool fadeOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOut);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOut)) = flag;
		}
	}

	public unsafe float fadeOutTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOutTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOutTime)) = num;
		}
	}

	public unsafe Sprite displayImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe float imageFadeIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeIn);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeIn)) = num;
		}
	}

	public unsafe float imageFadeInSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeInSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeInSpeed)) = num;
		}
	}

	public unsafe float imageFadeOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeOut);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeOut)) = num;
		}
	}

	public unsafe float imageFadeOutSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeOutSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFadeOutSpeed)) = num;
		}
	}

	public unsafe bool disableAISpeech
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableAISpeech);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableAISpeech)) = flag;
		}
	}

	public unsafe OnEndScene onEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnd);
			return *(OnEndScene*)num;
		}
		set
		{
			*(OnEndScene*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onEnd)) = onEndScene;
		}
	}

	static CutScenePreset()
	{
		Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CutScenePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr);
		NativeFieldInfoPtr_elementList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "elementList");
		NativeFieldInfoPtr_fadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "fadeIn");
		NativeFieldInfoPtr_fadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "fadeInTime");
		NativeFieldInfoPtr_fadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "fadeOut");
		NativeFieldInfoPtr_fadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "fadeOutTime");
		NativeFieldInfoPtr_displayImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "displayImage");
		NativeFieldInfoPtr_imageFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "imageFadeIn");
		NativeFieldInfoPtr_imageFadeInSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "imageFadeInSpeed");
		NativeFieldInfoPtr_imageFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "imageFadeOut");
		NativeFieldInfoPtr_imageFadeOutSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "imageFadeOutSpeed");
		NativeFieldInfoPtr_disableAISpeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "disableAISpeech");
		NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, "onEnd");
		NativeMethodInfoPtr_RecordCurrentPositionToNewShot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, 100673868);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr, 100673869);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordCurrentPositionToNewShot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordCurrentPositionToNewShot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328069, XrefRangeEnd = 328077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CutScenePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutScenePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CutScenePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
