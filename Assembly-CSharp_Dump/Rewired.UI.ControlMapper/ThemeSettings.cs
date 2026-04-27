using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[System.Serializable]
public class ThemeSettings : ScriptableObject
{
	[System.Serializable]
	public class SelectableSettings_Base : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__transition;

		private static readonly System.IntPtr NativeFieldInfoPtr__colors;

		private static readonly System.IntPtr NativeFieldInfoPtr__spriteState;

		private static readonly System.IntPtr NativeFieldInfoPtr__animationTriggers;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_transition_Public_get_Transition_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		public unsafe Selectable.Transition _transition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transition);
				return *(Selectable.Transition*)num;
			}
			set
			{
				*(Selectable.Transition*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transition)) = transition;
			}
		}

		public unsafe CustomColorBlock _colors
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__colors);
				return *(CustomColorBlock*)num;
			}
			set
			{
				*(CustomColorBlock*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__colors)) = customColorBlock;
			}
		}

		public unsafe CustomSpriteState _spriteState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spriteState);
				return new CustomSpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customSpriteState)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CustomAnimationTriggers _animationTriggers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__animationTriggers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomAnimationTriggers>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__animationTriggers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customAnimationTriggers));
			}
		}

		public unsafe Selectable.Transition transition
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 349722, RefRangeEnd = 349786, XrefRangeStart = 349722, XrefRangeEnd = 349786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transition_Public_get_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Selectable.Transition*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe CustomColorBlock selectableColors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(CustomColorBlock*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe CustomSpriteState spriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new CustomSpriteState(pointer);
			}
		}

		public unsafe CustomAnimationTriggers animationTriggers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomAnimationTriggers>(intPtr) : null;
			}
		}

		static SelectableSettings_Base()
		{
			Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "SelectableSettings_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr);
			NativeFieldInfoPtr__transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, "_transition");
			NativeFieldInfoPtr__colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, "_colors");
			NativeFieldInfoPtr__spriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, "_spriteState");
			NativeFieldInfoPtr__animationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, "_animationTriggers");
			NativeMethodInfoPtr_get_transition_Public_get_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, 100676234);
			NativeMethodInfoPtr_get_selectableColors_Public_get_CustomColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, 100676235);
			NativeMethodInfoPtr_get_spriteState_Public_get_CustomSpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, 100676236);
			NativeMethodInfoPtr_get_animationTriggers_Public_get_CustomAnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, 100676237);
			NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, 100676238);
			NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr, 100676239);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 360143, RefRangeEnd = 360146, XrefRangeStart = 360116, XrefRangeEnd = 360143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Apply(Selectable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_New_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableSettings_Base()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableSettings_Base>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SelectableSettings_Base(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class SelectableSettings : SelectableSettings_Base
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__imageSettings;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ImageSettings _imageSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__imageSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__imageSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
			}
		}

		public unsafe ImageSettings imageSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
		}

		static SelectableSettings()
		{
			Il2CppClassPointerStore<SelectableSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "SelectableSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableSettings>.NativeClassPtr);
			NativeFieldInfoPtr__imageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableSettings>.NativeClassPtr, "_imageSettings");
			NativeMethodInfoPtr_get_imageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings>.NativeClassPtr, 100676240);
			NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings>.NativeClassPtr, 100676241);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableSettings>.NativeClassPtr, 100676242);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360146, XrefRangeEnd = 360160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Apply(Selectable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SelectableSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class SliderSettings : SelectableSettings_Base
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__handleImageSettings;

		private static readonly System.IntPtr NativeFieldInfoPtr__fillImageSettings;

		private static readonly System.IntPtr NativeFieldInfoPtr__backgroundImageSettings;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_Slider_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ImageSettings _handleImageSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handleImageSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handleImageSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
			}
		}

		public unsafe ImageSettings _fillImageSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillImageSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillImageSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
			}
		}

		public unsafe ImageSettings _backgroundImageSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backgroundImageSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backgroundImageSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
			}
		}

		public unsafe ImageSettings handleImageSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
		}

		public unsafe ImageSettings fillImageSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
		}

		public unsafe ImageSettings backgroundImageSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
		}

		static SliderSettings()
		{
			Il2CppClassPointerStore<SliderSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "SliderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr);
			NativeFieldInfoPtr__handleImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, "_handleImageSettings");
			NativeFieldInfoPtr__fillImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, "_fillImageSettings");
			NativeFieldInfoPtr__backgroundImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, "_backgroundImageSettings");
			NativeMethodInfoPtr_get_handleImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, 100676243);
			NativeMethodInfoPtr_get_fillImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, 100676244);
			NativeMethodInfoPtr_get_backgroundImageSettings_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, 100676245);
			NativeMethodInfoPtr_Apply_Private_Void_Slider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, 100676246);
			NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, 100676247);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr, 100676248);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360204, RefRangeEnd = 360205, XrefRangeStart = 360160, XrefRangeEnd = 360204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(Slider item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_Slider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360205, XrefRangeEnd = 360209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Apply(Selectable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SliderSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ScrollbarSettings : SelectableSettings_Base
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__handleImageSettings;

		private static readonly System.IntPtr NativeFieldInfoPtr__backgroundImageSettings;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ImageSettings _handleImageSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handleImageSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__handleImageSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
			}
		}

		public unsafe ImageSettings _backgroundImageSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backgroundImageSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backgroundImageSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
			}
		}

		public unsafe ImageSettings handle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
		}

		public unsafe ImageSettings background
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
			}
		}

		static ScrollbarSettings()
		{
			Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "ScrollbarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr);
			NativeFieldInfoPtr__handleImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr, "_handleImageSettings");
			NativeFieldInfoPtr__backgroundImageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr, "_backgroundImageSettings");
			NativeMethodInfoPtr_get_handle_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr, 100676249);
			NativeMethodInfoPtr_get_background_Public_get_ImageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr, 100676250);
			NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr, 100676251);
			NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr, 100676252);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr, 100676253);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 360225, RefRangeEnd = 360226, XrefRangeStart = 360209, XrefRangeEnd = 360225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(Scrollbar item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360226, XrefRangeEnd = 360230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Apply(Selectable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Virtual_Void_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollbarSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollbarSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ScrollbarSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ImageSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__color;

		private static readonly System.IntPtr NativeFieldInfoPtr__sprite;

		private static readonly System.IntPtr NativeFieldInfoPtr__materal;

		private static readonly System.IntPtr NativeFieldInfoPtr__type;

		private static readonly System.IntPtr NativeFieldInfoPtr__preserveAspect;

		private static readonly System.IntPtr NativeFieldInfoPtr__fillCenter;

		private static readonly System.IntPtr NativeFieldInfoPtr__fillMethod;

		private static readonly System.IntPtr NativeFieldInfoPtr__fillAmout;

		private static readonly System.IntPtr NativeFieldInfoPtr__fillClockwise;

		private static readonly System.IntPtr NativeFieldInfoPtr__fillOrigin;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_materal_Public_get_Material_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Color _color
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__color);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__color)) = color;
			}
		}

		public unsafe Sprite _sprite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sprite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Material _materal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materal);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe Image.Type _type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type);
				return *(Image.Type*)num;
			}
			set
			{
				*(Image.Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type)) = type;
			}
		}

		public unsafe bool _preserveAspect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preserveAspect);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preserveAspect)) = flag;
			}
		}

		public unsafe bool _fillCenter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillCenter);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillCenter)) = flag;
			}
		}

		public unsafe Image.FillMethod _fillMethod
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillMethod);
				return *(Image.FillMethod*)num;
			}
			set
			{
				*(Image.FillMethod*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillMethod)) = fillMethod;
			}
		}

		public unsafe float _fillAmout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillAmout);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillAmout)) = num;
			}
		}

		public unsafe bool _fillClockwise
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillClockwise);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillClockwise)) = flag;
			}
		}

		public unsafe int _fillOrigin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillOrigin);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fillOrigin)) = num;
			}
		}

		public unsafe Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe Sprite sprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
		}

		public unsafe Material materal
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_materal_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
		}

		public unsafe Image.Type type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Image.Type*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool preserveAspect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool fillCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe Image.FillMethod fillMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Image.FillMethod*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float fillAmout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe bool fillClockwise
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe int fillOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static ImageSettings()
		{
			Il2CppClassPointerStore<ImageSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "ImageSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr);
			NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_color");
			NativeFieldInfoPtr__sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_sprite");
			NativeFieldInfoPtr__materal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_materal");
			NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_type");
			NativeFieldInfoPtr__preserveAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_preserveAspect");
			NativeFieldInfoPtr__fillCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_fillCenter");
			NativeFieldInfoPtr__fillMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_fillMethod");
			NativeFieldInfoPtr__fillAmout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_fillAmout");
			NativeFieldInfoPtr__fillClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_fillClockwise");
			NativeFieldInfoPtr__fillOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, "_fillOrigin");
			NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676254);
			NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676255);
			NativeMethodInfoPtr_get_materal_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676256);
			NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676257);
			NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676258);
			NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676259);
			NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676260);
			NativeMethodInfoPtr_get_fillAmout_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676261);
			NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676262);
			NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676263);
			NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676264);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr, 100676265);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360230, XrefRangeEnd = 360255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Image image)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Image_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe ImageSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ImageSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct CustomColorBlock
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_FadeDuration;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightedColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledHighlightedColor;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_normalColor_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0;

		[FieldOffset(0)]
		public float m_ColorMultiplier;

		[FieldOffset(4)]
		public Color m_DisabledColor;

		[FieldOffset(20)]
		public float m_FadeDuration;

		[FieldOffset(24)]
		public Color m_HighlightedColor;

		[FieldOffset(40)]
		public Color m_NormalColor;

		[FieldOffset(56)]
		public Color m_PressedColor;

		[FieldOffset(72)]
		public Color m_SelectedColor;

		[FieldOffset(88)]
		public Color m_DisabledHighlightedColor;

		public unsafe float colorMultiplier
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 360255, RefRangeEnd = 360345, XrefRangeStart = 360255, XrefRangeEnd = 360255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Color disabledColor
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe float fadeDuration
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Color highlightedColor
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Color normalColor
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalColor_Public_get_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Color pressedColor
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Color selectedColor
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Color disabledHighlightedColor
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static CustomColorBlock()
		{
			Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "CustomColorBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr);
			NativeFieldInfoPtr_m_ColorMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_ColorMultiplier");
			NativeFieldInfoPtr_m_DisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_DisabledColor");
			NativeFieldInfoPtr_m_FadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_FadeDuration");
			NativeFieldInfoPtr_m_HighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_HighlightedColor");
			NativeFieldInfoPtr_m_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_NormalColor");
			NativeFieldInfoPtr_m_PressedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_PressedColor");
			NativeFieldInfoPtr_m_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_SelectedColor");
			NativeFieldInfoPtr_m_DisabledHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, "m_DisabledHighlightedColor");
			NativeMethodInfoPtr_get_colorMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676266);
			NativeMethodInfoPtr_set_colorMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676267);
			NativeMethodInfoPtr_get_disabledColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676268);
			NativeMethodInfoPtr_set_disabledColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676269);
			NativeMethodInfoPtr_get_fadeDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676270);
			NativeMethodInfoPtr_set_fadeDuration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676271);
			NativeMethodInfoPtr_get_highlightedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676272);
			NativeMethodInfoPtr_set_highlightedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676273);
			NativeMethodInfoPtr_get_normalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676274);
			NativeMethodInfoPtr_set_normalColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676275);
			NativeMethodInfoPtr_get_pressedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676276);
			NativeMethodInfoPtr_set_pressedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676277);
			NativeMethodInfoPtr_get_selectedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676278);
			NativeMethodInfoPtr_set_selectedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676279);
			NativeMethodInfoPtr_get_disabledHighlightedColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676280);
			NativeMethodInfoPtr_set_disabledHighlightedColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676281);
			NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, 100676282);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 360348, RefRangeEnd = 360350, XrefRangeStart = 360345, XrefRangeEnd = 360348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ColorBlock(CustomColorBlock item)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_ColorBlock_CustomColorBlock_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ColorBlock*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomColorBlock>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	public sealed class CustomSpriteState : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledSprite;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightedSprite;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedSprite;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedSprite;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledHighlightedSprite;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0;

		public unsafe Sprite m_DisabledSprite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledSprite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Sprite m_HighlightedSprite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightedSprite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightedSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Sprite m_PressedSprite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PressedSprite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PressedSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Sprite m_SelectedSprite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectedSprite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectedSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Sprite m_DisabledHighlightedSprite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledHighlightedSprite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledHighlightedSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		public unsafe Sprite disabledSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 360350, RefRangeEnd = 360352, XrefRangeStart = 360350, XrefRangeEnd = 360350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Sprite highlightedSprite
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 360352, RefRangeEnd = 360354, XrefRangeStart = 360352, XrefRangeEnd = 360352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 360354, RefRangeEnd = 360357, XrefRangeStart = 360354, XrefRangeEnd = 360354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Sprite pressedSprite
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 191619, RefRangeEnd = 191718, XrefRangeStart = 191619, XrefRangeEnd = 191718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Sprite selectedSprite
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe Sprite disabledHighlightedSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59183, XrefRangeStart = 59139, XrefRangeEnd = 59183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static CustomSpriteState()
		{
			Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "CustomSpriteState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr);
			NativeFieldInfoPtr_m_DisabledSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, "m_DisabledSprite");
			NativeFieldInfoPtr_m_HighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, "m_HighlightedSprite");
			NativeFieldInfoPtr_m_PressedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, "m_PressedSprite");
			NativeFieldInfoPtr_m_SelectedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, "m_SelectedSprite");
			NativeFieldInfoPtr_m_DisabledHighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, "m_DisabledHighlightedSprite");
			NativeMethodInfoPtr_get_disabledSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676283);
			NativeMethodInfoPtr_set_disabledSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676284);
			NativeMethodInfoPtr_get_highlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676285);
			NativeMethodInfoPtr_set_highlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676286);
			NativeMethodInfoPtr_get_pressedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676287);
			NativeMethodInfoPtr_set_pressedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676288);
			NativeMethodInfoPtr_get_selectedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676289);
			NativeMethodInfoPtr_set_selectedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676290);
			NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676291);
			NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676292);
			NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr, 100676293);
		}

		[CallerCount(0)]
		public unsafe static implicit operator SpriteState(CustomSpriteState item)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)item));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_SpriteState_CustomSpriteState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new SpriteState(pointer);
		}

		public CustomSpriteState(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CustomSpriteState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSpriteState>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public class CustomAnimationTriggers : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightedTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledHighlightedTrigger;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0;

		public unsafe string m_DisabledTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledTrigger);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string m_HighlightedTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightedTrigger);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighlightedTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string m_NormalTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NormalTrigger);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NormalTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string m_PressedTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PressedTrigger);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PressedTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string m_SelectedTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectedTrigger);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectedTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string m_DisabledHighlightedTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledHighlightedTrigger);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisabledHighlightedTrigger)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string disabledTrigger
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 191619, RefRangeEnd = 191718, XrefRangeStart = 191619, XrefRangeEnd = 191718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe string highlightedTrigger
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe string normalTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59183, XrefRangeStart = 59139, XrefRangeEnd = 59183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe string pressedTrigger
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 353040, RefRangeEnd = 353048, XrefRangeStart = 353040, XrefRangeEnd = 353048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(60)]
			[CachedScanResults(RefRangeStart = 71605, RefRangeEnd = 71665, XrefRangeStart = 71605, XrefRangeEnd = 71665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe string selectedTrigger
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 353048, RefRangeEnd = 353057, XrefRangeStart = 353048, XrefRangeEnd = 353057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 360364, RefRangeEnd = 360388, XrefRangeStart = 360364, XrefRangeEnd = 360364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe string disabledHighlightedTrigger
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 353057, RefRangeEnd = 353062, XrefRangeStart = 353057, XrefRangeEnd = 353062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 360388, RefRangeEnd = 360410, XrefRangeStart = 360388, XrefRangeEnd = 360388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static CustomAnimationTriggers()
		{
			Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "CustomAnimationTriggers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr);
			NativeFieldInfoPtr_m_DisabledTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, "m_DisabledTrigger");
			NativeFieldInfoPtr_m_HighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, "m_HighlightedTrigger");
			NativeFieldInfoPtr_m_NormalTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, "m_NormalTrigger");
			NativeFieldInfoPtr_m_PressedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, "m_PressedTrigger");
			NativeFieldInfoPtr_m_SelectedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, "m_SelectedTrigger");
			NativeFieldInfoPtr_m_DisabledHighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, "m_DisabledHighlightedTrigger");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676294);
			NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676295);
			NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676296);
			NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676297);
			NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676298);
			NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676299);
			NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676300);
			NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676301);
			NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676302);
			NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676303);
			NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676304);
			NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676305);
			NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676306);
			NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr, 100676307);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360357, XrefRangeEnd = 360364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAnimationTriggers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAnimationTriggers>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360410, XrefRangeEnd = 360414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator AnimationTriggers(CustomAnimationTriggers item)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_AnimationTriggers_CustomAnimationTriggers_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr) : null;
		}

		public CustomAnimationTriggers(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class TextSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__color;

		private static readonly System.IntPtr NativeFieldInfoPtr__font;

		private static readonly System.IntPtr NativeFieldInfoPtr__style;

		private static readonly System.IntPtr NativeFieldInfoPtr__sizeMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr__lineSpacing;

		private static readonly System.IntPtr NativeFieldInfoPtr__characterSpacing;

		private static readonly System.IntPtr NativeFieldInfoPtr__wordSpacing;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_chracterSpacing_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Color _color
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__color);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__color)) = color;
			}
		}

		public unsafe TMP_FontAsset _font
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__font);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__font)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_FontAsset));
			}
		}

		public unsafe FontStyleOverride _style
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__style);
				return *(FontStyleOverride*)num;
			}
			set
			{
				*(FontStyleOverride*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__style)) = fontStyleOverride;
			}
		}

		public unsafe float _sizeMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizeMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizeMultiplier)) = num;
			}
		}

		public unsafe float _lineSpacing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lineSpacing);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lineSpacing)) = num;
			}
		}

		public unsafe float _characterSpacing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__characterSpacing);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__characterSpacing)) = num;
			}
		}

		public unsafe float _wordSpacing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wordSpacing);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wordSpacing)) = num;
			}
		}

		public unsafe Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe TMP_FontAsset font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
			}
		}

		public unsafe FontStyleOverride style
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(FontStyleOverride*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float sizeMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float chracterSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_chracterSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		public unsafe float wordSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static TextSettings()
		{
			Il2CppClassPointerStore<TextSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "TextSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSettings>.NativeClassPtr);
			NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "_color");
			NativeFieldInfoPtr__font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "_font");
			NativeFieldInfoPtr__style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "_style");
			NativeFieldInfoPtr__sizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "_sizeMultiplier");
			NativeFieldInfoPtr__lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "_lineSpacing");
			NativeFieldInfoPtr__characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "_characterSpacing");
			NativeFieldInfoPtr__wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, "_wordSpacing");
			NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676308);
			NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676309);
			NativeMethodInfoPtr_get_style_Public_get_FontStyleOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676310);
			NativeMethodInfoPtr_get_sizeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676311);
			NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676312);
			NativeMethodInfoPtr_get_chracterSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676313);
			NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676314);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSettings>.NativeClassPtr, 100676315);
		}

		[CallerCount(0)]
		public unsafe TextSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TextSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum FontStyleOverride
	{
		Default,
		Normal,
		Bold,
		Italic,
		BoldAndItalic
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__mainWindowBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr__popupWindowBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr__areaBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr__selectableSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__buttonSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputGridFieldSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__scrollbarSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__sliderSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__invertToggle;

	private static readonly System.IntPtr NativeFieldInfoPtr__invertToggleDisabledColor;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrationBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrationValueMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrationRawValueMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrationZeroMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrationCalibratedZeroMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr__calibrationDeadzone;

	private static readonly System.IntPtr NativeFieldInfoPtr__textSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__buttonTextSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputGridFieldTextSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyles_FontStyleOverride_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ImageSettings _mainWindowBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainWindowBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainWindowBackground)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe ImageSettings _popupWindowBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__popupWindowBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__popupWindowBackground)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe ImageSettings _areaBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__areaBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__areaBackground)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe SelectableSettings _selectableSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__selectableSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SelectableSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__selectableSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectableSettings));
		}
	}

	public unsafe SelectableSettings _buttonSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buttonSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SelectableSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buttonSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectableSettings));
		}
	}

	public unsafe SelectableSettings _inputGridFieldSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SelectableSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectableSettings));
		}
	}

	public unsafe ScrollbarSettings _scrollbarSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrollbarSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollbarSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrollbarSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scrollbarSettings));
		}
	}

	public unsafe SliderSettings _sliderSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sliderSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SliderSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sliderSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sliderSettings));
		}
	}

	public unsafe ImageSettings _invertToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertToggle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertToggle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe Color _invertToggleDisabledColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertToggleDisabledColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__invertToggleDisabledColor)) = color;
		}
	}

	public unsafe ImageSettings _calibrationBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationBackground)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe ImageSettings _calibrationValueMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationValueMarker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationValueMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe ImageSettings _calibrationRawValueMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationRawValueMarker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationRawValueMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe ImageSettings _calibrationZeroMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationZeroMarker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationZeroMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe ImageSettings _calibrationCalibratedZeroMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationCalibratedZeroMarker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationCalibratedZeroMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe ImageSettings _calibrationDeadzone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationDeadzone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ImageSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__calibrationDeadzone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageSettings));
		}
	}

	public unsafe TextSettings _textSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textSettings));
		}
	}

	public unsafe TextSettings _buttonTextSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buttonTextSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buttonTextSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textSettings));
		}
	}

	public unsafe TextSettings _inputGridFieldTextSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldTextSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputGridFieldTextSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textSettings));
		}
	}

	static ThemeSettings()
	{
		Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "ThemeSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr);
		NativeFieldInfoPtr__mainWindowBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_mainWindowBackground");
		NativeFieldInfoPtr__popupWindowBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_popupWindowBackground");
		NativeFieldInfoPtr__areaBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_areaBackground");
		NativeFieldInfoPtr__selectableSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_selectableSettings");
		NativeFieldInfoPtr__buttonSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_buttonSettings");
		NativeFieldInfoPtr__inputGridFieldSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_inputGridFieldSettings");
		NativeFieldInfoPtr__scrollbarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_scrollbarSettings");
		NativeFieldInfoPtr__sliderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_sliderSettings");
		NativeFieldInfoPtr__invertToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_invertToggle");
		NativeFieldInfoPtr__invertToggleDisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_invertToggleDisabledColor");
		NativeFieldInfoPtr__calibrationBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationBackground");
		NativeFieldInfoPtr__calibrationValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationValueMarker");
		NativeFieldInfoPtr__calibrationRawValueMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationRawValueMarker");
		NativeFieldInfoPtr__calibrationZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationZeroMarker");
		NativeFieldInfoPtr__calibrationCalibratedZeroMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationCalibratedZeroMarker");
		NativeFieldInfoPtr__calibrationDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_calibrationDeadzone");
		NativeFieldInfoPtr__textSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_textSettings");
		NativeFieldInfoPtr__buttonTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_buttonTextSettings");
		NativeFieldInfoPtr__inputGridFieldTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, "_inputGridFieldTextSettings");
		NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676226);
		NativeMethodInfoPtr_Apply_Private_Void_String_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676227);
		NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676228);
		NativeMethodInfoPtr_Apply_Private_Void_String_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676229);
		NativeMethodInfoPtr_Apply_Private_Void_String_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676230);
		NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676231);
		NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyles_FontStyleOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676232);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr, 100676233);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360414, XrefRangeEnd = 360416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply(Il2CppReferenceArray<ThemedElement.ElementInfo> elementInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elementInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Public_Void_Il2CppReferenceArray_1_ElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 360435, RefRangeEnd = 360437, XrefRangeStart = 360416, XrefRangeEnd = 360435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply(string themeClass, Component component)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_String_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 360507, RefRangeEnd = 360508, XrefRangeStart = 360437, XrefRangeEnd = 360507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply(string themeClass, Selectable item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_String_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360508, XrefRangeEnd = 360567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply(string themeClass, Image item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_String_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360567, XrefRangeEnd = 360604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply(string themeClass, TMP_Text item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_String_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360604, XrefRangeEnd = 360632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply(string themeClass, UIImageHelper item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(themeClass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_String_UIImageHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static FontStyles GetFontStyle(FontStyleOverride style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&style);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFontStyle_Private_Static_FontStyles_FontStyleOverride_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FontStyles*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThemeSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ThemeSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
