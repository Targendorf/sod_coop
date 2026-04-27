using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Rewired.Demos;

public class FallbackJoystickIdentificationDemo : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_windowWidth;

	private static readonly IntPtr NativeFieldInfoPtr_windowHeight;

	private static readonly IntPtr NativeFieldInfoPtr_inputDelay;

	private static readonly IntPtr NativeFieldInfoPtr_identifyRequired;

	private static readonly IntPtr NativeFieldInfoPtr_joysticksToIdentify;

	private static readonly IntPtr NativeFieldInfoPtr_nextInputAllowedTime;

	private static readonly IntPtr NativeFieldInfoPtr_style;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly IntPtr NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0;

	private static readonly IntPtr NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetInputDelay_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float windowWidth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_windowWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_windowWidth, (void*)(&num));
		}
	}

	public unsafe static float windowHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_windowHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_windowHeight, (void*)(&num));
		}
	}

	public unsafe static float inputDelay
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputDelay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputDelay, (void*)(&num));
		}
	}

	public unsafe bool identifyRequired
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyRequired);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyRequired)) = flag;
		}
	}

	public unsafe Queue<Joystick> joysticksToIdentify
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joysticksToIdentify);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Queue<Joystick>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joysticksToIdentify)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe float nextInputAllowedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextInputAllowedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextInputAllowedTime)) = num;
		}
	}

	public unsafe GUIStyle style
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gUIStyle));
		}
	}

	static FallbackJoystickIdentificationDemo()
	{
		Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "FallbackJoystickIdentificationDemo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr);
		NativeFieldInfoPtr_windowWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "windowWidth");
		NativeFieldInfoPtr_windowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "windowHeight");
		NativeFieldInfoPtr_inputDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "inputDelay");
		NativeFieldInfoPtr_identifyRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "identifyRequired");
		NativeFieldInfoPtr_joysticksToIdentify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "joysticksToIdentify");
		NativeFieldInfoPtr_nextInputAllowedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "nextInputAllowedTime");
		NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, "style");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676621);
		NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676622);
		NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676623);
		NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676624);
		NativeMethodInfoPtr_SetInputDelay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676625);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676626);
		NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676627);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676628);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr, 100676629);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364890, XrefRangeEnd = 364910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364910, XrefRangeEnd = 364911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoystickConnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_JoystickDisconnected_Private_Void_ControllerStatusChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 364930, RefRangeEnd = 364933, XrefRangeStart = 364911, XrefRangeEnd = 364930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IdentifyAllJoysticks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IdentifyAllJoysticks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 364935, RefRangeEnd = 364937, XrefRangeStart = 364933, XrefRangeEnd = 364935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInputDelay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputDelay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364937, XrefRangeEnd = 364969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364969, XrefRangeEnd = 365005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawDialogWindow(int windowId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&windowId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawDialogWindow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 365005, RefRangeEnd = 365006, XrefRangeStart = 365005, XrefRangeEnd = 365005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FallbackJoystickIdentificationDemo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackJoystickIdentificationDemo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FallbackJoystickIdentificationDemo(IntPtr pointer)
		: base(pointer)
	{
	}
}
