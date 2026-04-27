using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Rewired;

public class IRacingWheelTemplate : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_accelerator_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_brake_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_clutch_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shiftDown_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shiftUp_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_wheelButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_consoleButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_shifter10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_reverseGear_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_select_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_systemButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_horn_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_dPad_Public_Abstract_Virtual_New_get_IControllerTemplateDPad_0;

	public unsafe virtual IControllerTemplateAxis wheel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis accelerator
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_accelerator_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis brake
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_brake_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis clutch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_clutch_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shiftDown
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shiftDown_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shiftUp
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shiftUp_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton3
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton4
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton5
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton6
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton7
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton8
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton9
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton wheelButton10
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_wheelButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton3
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton4
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton5
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton6
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton7
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton8
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton9
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton consoleButton10
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_consoleButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter3
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter4
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter5
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter6
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter7
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter8
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter9
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton shifter10
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_shifter10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton reverseGear
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_reverseGear_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton select
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_select_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton start
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton systemButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_systemButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton horn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_horn_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateDPad dPad
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_dPad_Public_Abstract_Virtual_New_get_IControllerTemplateDPad_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateDPad>(intPtr) : null;
		}
	}

	static IRacingWheelTemplate()
	{
		Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "IRacingWheelTemplate");
		NativeMethodInfoPtr_get_wheel_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674371);
		NativeMethodInfoPtr_get_accelerator_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674372);
		NativeMethodInfoPtr_get_brake_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674373);
		NativeMethodInfoPtr_get_clutch_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674374);
		NativeMethodInfoPtr_get_shiftDown_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674375);
		NativeMethodInfoPtr_get_shiftUp_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674376);
		NativeMethodInfoPtr_get_wheelButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674377);
		NativeMethodInfoPtr_get_wheelButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674378);
		NativeMethodInfoPtr_get_wheelButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674379);
		NativeMethodInfoPtr_get_wheelButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674380);
		NativeMethodInfoPtr_get_wheelButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674381);
		NativeMethodInfoPtr_get_wheelButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674382);
		NativeMethodInfoPtr_get_wheelButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674383);
		NativeMethodInfoPtr_get_wheelButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674384);
		NativeMethodInfoPtr_get_wheelButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674385);
		NativeMethodInfoPtr_get_wheelButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674386);
		NativeMethodInfoPtr_get_consoleButton1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674387);
		NativeMethodInfoPtr_get_consoleButton2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674388);
		NativeMethodInfoPtr_get_consoleButton3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674389);
		NativeMethodInfoPtr_get_consoleButton4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674390);
		NativeMethodInfoPtr_get_consoleButton5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674391);
		NativeMethodInfoPtr_get_consoleButton6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674392);
		NativeMethodInfoPtr_get_consoleButton7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674393);
		NativeMethodInfoPtr_get_consoleButton8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674394);
		NativeMethodInfoPtr_get_consoleButton9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674395);
		NativeMethodInfoPtr_get_consoleButton10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674396);
		NativeMethodInfoPtr_get_shifter1_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674397);
		NativeMethodInfoPtr_get_shifter2_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674398);
		NativeMethodInfoPtr_get_shifter3_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674399);
		NativeMethodInfoPtr_get_shifter4_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674400);
		NativeMethodInfoPtr_get_shifter5_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674401);
		NativeMethodInfoPtr_get_shifter6_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674402);
		NativeMethodInfoPtr_get_shifter7_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674403);
		NativeMethodInfoPtr_get_shifter8_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674404);
		NativeMethodInfoPtr_get_shifter9_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674405);
		NativeMethodInfoPtr_get_shifter10_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674406);
		NativeMethodInfoPtr_get_reverseGear_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674407);
		NativeMethodInfoPtr_get_select_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674408);
		NativeMethodInfoPtr_get_start_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674409);
		NativeMethodInfoPtr_get_systemButton_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674410);
		NativeMethodInfoPtr_get_horn_Public_Abstract_Virtual_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674411);
		NativeMethodInfoPtr_get_dPad_Public_Abstract_Virtual_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRacingWheelTemplate>.NativeClassPtr, 100674412);
	}

	public IRacingWheelTemplate(IntPtr pointer)
		: base(pointer)
	{
	}
}
