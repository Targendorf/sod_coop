using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuiceController : MonoBehaviour
{
	[System.Serializable]
	public class JuiceElement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_transformElement;

		private static readonly System.IntPtr NativeFieldInfoPtr_imageElement;

		private static readonly System.IntPtr NativeFieldInfoPtr_rawImageElement;

		private static readonly System.IntPtr NativeFieldInfoPtr_renderer;

		private static readonly System.IntPtr NativeFieldInfoPtr_originalColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_getNormalColourAtStart;

		private static readonly System.IntPtr NativeFieldInfoPtr_originalLocalPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_originalLocalRot;

		private static readonly System.IntPtr NativeFieldInfoPtr_originalLocalScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_getNormalTransformAtStart;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe RectTransform transformElement
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformElement);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
			}
		}

		public unsafe Image imageElement
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageElement);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
			}
		}

		public unsafe RawImage rawImageElement
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawImageElement);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RawImage>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawImageElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawImage));
			}
		}

		public unsafe CanvasRenderer renderer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
			}
		}

		public unsafe Color originalColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalColour)) = color;
			}
		}

		public unsafe bool getNormalColourAtStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getNormalColourAtStart);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getNormalColourAtStart)) = flag;
			}
		}

		public unsafe Vector3 originalLocalPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalLocalPos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalLocalPos)) = vector;
			}
		}

		public unsafe Vector3 originalLocalRot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalLocalRot);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalLocalRot)) = vector;
			}
		}

		public unsafe Vector3 originalLocalScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalLocalScale);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalLocalScale)) = vector;
			}
		}

		public unsafe bool getNormalTransformAtStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getNormalTransformAtStart);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getNormalTransformAtStart)) = flag;
			}
		}

		static JuiceElement()
		{
			Il2CppClassPointerStore<JuiceElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "JuiceElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr);
			NativeFieldInfoPtr_transformElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "transformElement");
			NativeFieldInfoPtr_imageElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "imageElement");
			NativeFieldInfoPtr_rawImageElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "rawImageElement");
			NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "renderer");
			NativeFieldInfoPtr_originalColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "originalColour");
			NativeFieldInfoPtr_getNormalColourAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "getNormalColourAtStart");
			NativeFieldInfoPtr_originalLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "originalLocalPos");
			NativeFieldInfoPtr_originalLocalRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "originalLocalRot");
			NativeFieldInfoPtr_originalLocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "originalLocalScale");
			NativeFieldInfoPtr_getNormalTransformAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, "getNormalTransformAtStart");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr, 100671372);
		}

		[CallerCount(0)]
		public unsafe JuiceElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JuiceElement>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public JuiceElement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_elements;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulsateActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulsateScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulsateProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulsateOnStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulsateColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulsateSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_cycle;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashF;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashRepeat;

	private static readonly System.IntPtr NativeFieldInfoPtr_onOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothPulsateOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_nudgeActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_nudgeState;

	private static readonly System.IntPtr NativeFieldInfoPtr_nudgeProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_amountToScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_amountToRotate;

	private static readonly System.IntPtr NativeFieldInfoPtr_nudgeEffectScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_nudgeEffectRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_fancyAppearActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_appearSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_fancyAppearProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_fancyDisappearActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_disappearSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_fancyDisappearProgress;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginalRectSize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Flash_Public_Void_Int32_Boolean_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pulsate_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Nudge_Public_Void_Vector2_Vector2_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FancyAppear_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FancyDisappear_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Flash_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PulsateToggle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Nudge_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Appear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disappear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<JuiceElement> elements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<JuiceElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool pulsateActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateActive)) = flag;
		}
	}

	public unsafe bool pulsateScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateScale)) = flag;
		}
	}

	public unsafe float pulsateProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateProgress)) = num;
		}
	}

	public unsafe bool pulsateOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateOnStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateOnStart)) = flag;
		}
	}

	public unsafe Color pulsateColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateColour)) = color;
		}
	}

	public unsafe float pulsateSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulsateSpeed)) = num;
		}
	}

	public unsafe bool flashActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashActive)) = flag;
		}
	}

	public unsafe float flashSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashSpeed)) = num;
		}
	}

	public unsafe Color flashColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashColour)) = color;
		}
	}

	public unsafe int cycle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cycle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cycle)) = num;
		}
	}

	public unsafe float flashProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashProgress)) = num;
		}
	}

	public unsafe float flashF
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashF);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashF)) = num;
		}
	}

	public unsafe int flashRepeat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashRepeat);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashRepeat)) = num;
		}
	}

	public unsafe bool onOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onOff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onOff)) = flag;
		}
	}

	public unsafe bool smoothPulsateOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothPulsateOff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothPulsateOff)) = flag;
		}
	}

	public unsafe bool nudgeActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeActive)) = flag;
		}
	}

	public unsafe bool nudgeState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeState)) = flag;
		}
	}

	public unsafe float nudgeProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeProgress)) = num;
		}
	}

	public unsafe float amountToScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountToScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountToScale)) = num;
		}
	}

	public unsafe Vector3 desiredScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredScale)) = vector;
		}
	}

	public unsafe float amountToRotate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountToRotate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountToRotate)) = num;
		}
	}

	public unsafe bool nudgeEffectScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeEffectScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeEffectScale)) = flag;
		}
	}

	public unsafe bool nudgeEffectRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeEffectRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nudgeEffectRotation)) = flag;
		}
	}

	public unsafe bool fancyAppearActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyAppearActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyAppearActive)) = flag;
		}
	}

	public unsafe float appearSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appearSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appearSpeed)) = num;
		}
	}

	public unsafe float fancyAppearProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyAppearProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyAppearProgress)) = num;
		}
	}

	public unsafe bool fancyDisappearActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyDisappearActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyDisappearActive)) = flag;
		}
	}

	public unsafe float disappearSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disappearSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disappearSpeed)) = num;
		}
	}

	public unsafe float fancyDisappearProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyDisappearProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fancyDisappearProgress)) = num;
		}
	}

	static JuiceController()
	{
		Il2CppClassPointerStore<JuiceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "JuiceController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JuiceController>.NativeClassPtr);
		NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "elements");
		NativeFieldInfoPtr_pulsateActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "pulsateActive");
		NativeFieldInfoPtr_pulsateScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "pulsateScale");
		NativeFieldInfoPtr_pulsateProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "pulsateProgress");
		NativeFieldInfoPtr_pulsateOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "pulsateOnStart");
		NativeFieldInfoPtr_pulsateColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "pulsateColour");
		NativeFieldInfoPtr_pulsateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "pulsateSpeed");
		NativeFieldInfoPtr_flashActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "flashActive");
		NativeFieldInfoPtr_flashSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "flashSpeed");
		NativeFieldInfoPtr_flashColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "flashColour");
		NativeFieldInfoPtr_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "cycle");
		NativeFieldInfoPtr_flashProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "flashProgress");
		NativeFieldInfoPtr_flashF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "flashF");
		NativeFieldInfoPtr_flashRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "flashRepeat");
		NativeFieldInfoPtr_onOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "onOff");
		NativeFieldInfoPtr_smoothPulsateOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "smoothPulsateOff");
		NativeFieldInfoPtr_nudgeActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "nudgeActive");
		NativeFieldInfoPtr_nudgeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "nudgeState");
		NativeFieldInfoPtr_nudgeProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "nudgeProgress");
		NativeFieldInfoPtr_amountToScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "amountToScale");
		NativeFieldInfoPtr_desiredScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "desiredScale");
		NativeFieldInfoPtr_amountToRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "amountToRotate");
		NativeFieldInfoPtr_nudgeEffectScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "nudgeEffectScale");
		NativeFieldInfoPtr_nudgeEffectRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "nudgeEffectRotation");
		NativeFieldInfoPtr_fancyAppearActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "fancyAppearActive");
		NativeFieldInfoPtr_appearSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "appearSpeed");
		NativeFieldInfoPtr_fancyAppearProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "fancyAppearProgress");
		NativeFieldInfoPtr_fancyDisappearActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "fancyDisappearActive");
		NativeFieldInfoPtr_disappearSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "disappearSpeed");
		NativeFieldInfoPtr_fancyDisappearProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, "fancyDisappearProgress");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671357);
		NativeMethodInfoPtr_GetOriginalRectSize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671358);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671359);
		NativeMethodInfoPtr_Flash_Public_Void_Int32_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671360);
		NativeMethodInfoPtr_Pulsate_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671361);
		NativeMethodInfoPtr_Nudge_Public_Void_Vector2_Vector2_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671362);
		NativeMethodInfoPtr_FancyAppear_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671363);
		NativeMethodInfoPtr_FancyDisappear_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671364);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671365);
		NativeMethodInfoPtr_Flash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671366);
		NativeMethodInfoPtr_PulsateToggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671367);
		NativeMethodInfoPtr_Nudge_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671368);
		NativeMethodInfoPtr_Appear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671369);
		NativeMethodInfoPtr_Disappear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671370);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JuiceController>.NativeClassPtr, 100671371);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267935, XrefRangeEnd = 267984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 268009, RefRangeEnd = 268011, XrefRangeStart = 267984, XrefRangeEnd = 268009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetOriginalRectSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOriginalRectSize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268011, XrefRangeEnd = 268158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268160, RefRangeEnd = 268161, XrefRangeStart = 268158, XrefRangeEnd = 268160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Flash(int newRepeat, bool colourOverride, Color colour = default(Color), float speed = 10f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&newRepeat);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &colourOverride;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colour;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Flash_Public_Void_Int32_Boolean_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 268165, RefRangeEnd = 268205, XrefRangeStart = 268161, XrefRangeEnd = 268165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pulsate(bool toggle, bool smoothOff = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&toggle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &smoothOff;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pulsate_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 268238, RefRangeEnd = 268247, XrefRangeStart = 268205, XrefRangeEnd = 268238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Nudge(Vector2 scaleRange, Vector2 rotationRange, bool updateOriginalPositionFirst = true, bool affectScale = true, bool affectRotation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&scaleRange);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationRange;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateOriginalPositionFirst;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &affectScale;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &affectRotation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Nudge_Public_Void_Vector2_Vector2_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268291, RefRangeEnd = 268292, XrefRangeStart = 268247, XrefRangeEnd = 268291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FancyAppear(float newAppearSpeed = 2f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newAppearSpeed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FancyAppear_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268292, XrefRangeEnd = 268305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FancyDisappear(float newDisappearSpeed = 2f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newDisappearSpeed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FancyDisappear_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268305, XrefRangeEnd = 268344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268344, XrefRangeEnd = 268346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Flash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Flash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268346, XrefRangeEnd = 268347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PulsateToggle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PulsateToggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268348, RefRangeEnd = 268349, XrefRangeStart = 268347, XrefRangeEnd = 268348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Nudge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Nudge_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268349, XrefRangeEnd = 268350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Appear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Appear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268350, XrefRangeEnd = 268363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Disappear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disappear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268363, XrefRangeEnd = 268372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JuiceController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JuiceController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public JuiceController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
