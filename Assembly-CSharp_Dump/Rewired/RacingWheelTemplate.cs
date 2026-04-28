using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired;

public sealed class RacingWheelTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_accelerator;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_brake;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_clutch;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shiftDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shiftUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheelButton10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_shifter10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_reverseGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_select;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_systemButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_horn;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPad;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

	public unsafe static Il2CppSystem.Guid typeGuid
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Guid result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeGuid, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeGuid, (void*)(&guid));
		}
	}

	public unsafe static int elementId_wheel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel, (void*)(&num));
		}
	}

	public unsafe static int elementId_accelerator
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_accelerator, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_accelerator, (void*)(&num));
		}
	}

	public unsafe static int elementId_brake
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_brake, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_brake, (void*)(&num));
		}
	}

	public unsafe static int elementId_clutch
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_clutch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_clutch, (void*)(&num));
		}
	}

	public unsafe static int elementId_shiftDown
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shiftDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shiftDown, (void*)(&num));
		}
	}

	public unsafe static int elementId_shiftUp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shiftUp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shiftUp, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton9, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheelButton10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheelButton10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheelButton10, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter1, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter2, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter3, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter4, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter5, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter6, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter7, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter8, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter9, (void*)(&num));
		}
	}

	public unsafe static int elementId_shifter10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_shifter10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_shifter10, (void*)(&num));
		}
	}

	public unsafe static int elementId_reverseGear
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_reverseGear, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_reverseGear, (void*)(&num));
		}
	}

	public unsafe static int elementId_select
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_select, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_select, (void*)(&num));
		}
	}

	public unsafe static int elementId_start
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_start, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_start, (void*)(&num));
		}
	}

	public unsafe static int elementId_systemButton
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_systemButton, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_systemButton, (void*)(&num));
		}
	}

	public unsafe static int elementId_horn
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_horn, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_horn, (void*)(&num));
		}
	}

	public unsafe static int elementId_dPadUp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadUp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadUp, (void*)(&num));
		}
	}

	public unsafe static int elementId_dPadRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_dPadDown
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadDown, (void*)(&num));
		}
	}

	public unsafe static int elementId_dPadLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPadLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPadLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_dPad
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_dPad, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_dPad, (void*)(&num));
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Ewheel
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347282, XrefRangeEnd = 347285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Eaccelerator
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347285, XrefRangeEnd = 347288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Ebrake
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347288, XrefRangeEnd = 347291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIRacingWheelTemplate_002Eclutch
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347291, XrefRangeEnd = 347294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EshiftDown
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347294, XrefRangeEnd = 347297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EshiftUp
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347297, XrefRangeEnd = 347300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347300, XrefRangeEnd = 347303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347303, XrefRangeEnd = 347306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347306, XrefRangeEnd = 347309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347309, XrefRangeEnd = 347312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347312, XrefRangeEnd = 347315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347315, XrefRangeEnd = 347318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347318, XrefRangeEnd = 347321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347321, XrefRangeEnd = 347324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347324, XrefRangeEnd = 347327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EwheelButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347327, XrefRangeEnd = 347330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347330, XrefRangeEnd = 347333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347333, XrefRangeEnd = 347336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347336, XrefRangeEnd = 347339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347339, XrefRangeEnd = 347342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347342, XrefRangeEnd = 347345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347345, XrefRangeEnd = 347348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347348, XrefRangeEnd = 347351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347351, XrefRangeEnd = 347354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347354, XrefRangeEnd = 347357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EconsoleButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347357, XrefRangeEnd = 347360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347360, XrefRangeEnd = 347363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347363, XrefRangeEnd = 347366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347366, XrefRangeEnd = 347369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347369, XrefRangeEnd = 347372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347372, XrefRangeEnd = 347375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347375, XrefRangeEnd = 347378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347378, XrefRangeEnd = 347381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347381, XrefRangeEnd = 347384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347384, XrefRangeEnd = 347387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eshifter10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347387, XrefRangeEnd = 347390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EreverseGear
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347390, XrefRangeEnd = 347393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Eselect
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347393, XrefRangeEnd = 347396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Estart
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347396, XrefRangeEnd = 347399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002EsystemButton
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347399, XrefRangeEnd = 347402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIRacingWheelTemplate_002Ehorn
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347402, XrefRangeEnd = 347405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateDPad Rewired_002EIRacingWheelTemplate_002EdPad
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347405, XrefRangeEnd = 347414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateDPad>(intPtr) : null;
		}
	}

	static RacingWheelTemplate()
	{
		Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "RacingWheelTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheel");
		NativeFieldInfoPtr_elementId_accelerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_accelerator");
		NativeFieldInfoPtr_elementId_brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_brake");
		NativeFieldInfoPtr_elementId_clutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_clutch");
		NativeFieldInfoPtr_elementId_shiftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shiftDown");
		NativeFieldInfoPtr_elementId_shiftUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shiftUp");
		NativeFieldInfoPtr_elementId_wheelButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton1");
		NativeFieldInfoPtr_elementId_wheelButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton2");
		NativeFieldInfoPtr_elementId_wheelButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton3");
		NativeFieldInfoPtr_elementId_wheelButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton4");
		NativeFieldInfoPtr_elementId_wheelButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton5");
		NativeFieldInfoPtr_elementId_wheelButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton6");
		NativeFieldInfoPtr_elementId_wheelButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton7");
		NativeFieldInfoPtr_elementId_wheelButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton8");
		NativeFieldInfoPtr_elementId_wheelButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton9");
		NativeFieldInfoPtr_elementId_wheelButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_wheelButton10");
		NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton1");
		NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton2");
		NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton3");
		NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton4");
		NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton5");
		NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton6");
		NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton7");
		NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton8");
		NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton9");
		NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_consoleButton10");
		NativeFieldInfoPtr_elementId_shifter1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter1");
		NativeFieldInfoPtr_elementId_shifter2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter2");
		NativeFieldInfoPtr_elementId_shifter3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter3");
		NativeFieldInfoPtr_elementId_shifter4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter4");
		NativeFieldInfoPtr_elementId_shifter5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter5");
		NativeFieldInfoPtr_elementId_shifter6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter6");
		NativeFieldInfoPtr_elementId_shifter7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter7");
		NativeFieldInfoPtr_elementId_shifter8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter8");
		NativeFieldInfoPtr_elementId_shifter9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter9");
		NativeFieldInfoPtr_elementId_shifter10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_shifter10");
		NativeFieldInfoPtr_elementId_reverseGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_reverseGear");
		NativeFieldInfoPtr_elementId_select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_select");
		NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_start");
		NativeFieldInfoPtr_elementId_systemButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_systemButton");
		NativeFieldInfoPtr_elementId_horn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_horn");
		NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadUp");
		NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadRight");
		NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadDown");
		NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPadLeft");
		NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, "elementId_dPad");
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheel_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674625);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_accelerator_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674626);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_brake_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674627);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_clutch_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674628);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftDown_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674629);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shiftUp_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674630);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674631);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674632);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674633);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674634);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674635);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674636);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674637);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674638);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674639);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_wheelButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674640);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674641);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674642);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674643);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674644);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674645);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674646);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674647);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674648);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674649);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674650);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674651);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674652);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674653);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674654);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674655);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674656);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674657);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674658);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674659);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_shifter10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674660);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_reverseGear_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674661);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_select_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674662);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674663);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_systemButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674664);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_horn_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674665);
		NativeMethodInfoPtr_Rewired_IRacingWheelTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674666);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr, 100674667);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RacingWheelTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RacingWheelTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RacingWheelTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
