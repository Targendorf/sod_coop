using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired;

public sealed class FlightYokeTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotateYoke;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_yokeZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPaddle;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPaddle;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpLeft;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_yoke;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHat;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHat;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

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

	public unsafe static int elementId_rotateYoke
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rotateYoke, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rotateYoke, (void*)(&num));
		}
	}

	public unsafe static int elementId_yokeZ
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_yokeZ, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_yokeZ, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftPaddle
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftPaddle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftPaddle, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightPaddle
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightPaddle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightPaddle, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever1Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever1Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever1Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever1MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever1MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever1MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever2Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever2Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever2Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever2MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever2MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever2MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever3Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever3Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever3Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever3MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever3MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever3MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever4Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever4Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever4Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever4MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever4MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever4MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever5Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever5Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever5Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever5MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever5MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever5MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel1Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel1Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel1Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel1Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel1Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel1Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel1Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel1Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel1Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel2Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel2Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel2Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel2Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel2Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel2Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel2Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel2Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel2Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatUp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatUp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatUp, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatUpRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatDownRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatDown
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatDown, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatDownLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatUpLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatUp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatUp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatUp, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatUpRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatDownRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatDown
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatDown, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatDownLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatUpLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*)(&num));
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

	public unsafe static int elementId_mode1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_mode1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_mode1, (void*)(&num));
		}
	}

	public unsafe static int elementId_mode2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_mode2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_mode2, (void*)(&num));
		}
	}

	public unsafe static int elementId_mode3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_mode3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_mode3, (void*)(&num));
		}
	}

	public unsafe static int elementId_yoke
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_yoke, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_yoke, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever1, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever2, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever3, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever4, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever5, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHat
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHat, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHat
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHat, (void*)(&num));
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftPaddle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347684, XrefRangeEnd = 347687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightPaddle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347687, XrefRangeEnd = 347690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347690, XrefRangeEnd = 347693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347693, XrefRangeEnd = 347696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347696, XrefRangeEnd = 347699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347699, XrefRangeEnd = 347702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347702, XrefRangeEnd = 347705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347705, XrefRangeEnd = 347708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347708, XrefRangeEnd = 347711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347711, XrefRangeEnd = 347714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347714, XrefRangeEnd = 347717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347717, XrefRangeEnd = 347720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347720, XrefRangeEnd = 347723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347723, XrefRangeEnd = 347726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347726, XrefRangeEnd = 347729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347729, XrefRangeEnd = 347732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347732, XrefRangeEnd = 347735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347735, XrefRangeEnd = 347738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347738, XrefRangeEnd = 347741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347741, XrefRangeEnd = 347744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347744, XrefRangeEnd = 347747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347747, XrefRangeEnd = 347750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Up
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347750, XrefRangeEnd = 347753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Down
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347753, XrefRangeEnd = 347756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Press
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347756, XrefRangeEnd = 347759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Up
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347759, XrefRangeEnd = 347762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Down
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347762, XrefRangeEnd = 347765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Press
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347765, XrefRangeEnd = 347768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347768, XrefRangeEnd = 347771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347771, XrefRangeEnd = 347774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347774, XrefRangeEnd = 347777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347777, XrefRangeEnd = 347780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347780, XrefRangeEnd = 347783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347783, XrefRangeEnd = 347786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347786, XrefRangeEnd = 347789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347789, XrefRangeEnd = 347792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347792, XrefRangeEnd = 347795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347795, XrefRangeEnd = 347798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347798, XrefRangeEnd = 347801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347801, XrefRangeEnd = 347804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347804, XrefRangeEnd = 347807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateYoke Rewired_002EIFlightYokeTemplate_002Eyoke
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347807, XrefRangeEnd = 347810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateYoke>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347810, XrefRangeEnd = 347813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347813, XrefRangeEnd = 347816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347816, XrefRangeEnd = 347819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347819, XrefRangeEnd = 347822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347822, XrefRangeEnd = 347825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002EleftGripHat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347825, XrefRangeEnd = 347828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002ErightGripHat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347828, XrefRangeEnd = 347837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	static FlightYokeTemplate()
	{
		Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "FlightYokeTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_rotateYoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rotateYoke");
		NativeFieldInfoPtr_elementId_yokeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_yokeZ");
		NativeFieldInfoPtr_elementId_leftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftPaddle");
		NativeFieldInfoPtr_elementId_rightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightPaddle");
		NativeFieldInfoPtr_elementId_lever1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1Axis");
		NativeFieldInfoPtr_elementId_lever1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1MinDetent");
		NativeFieldInfoPtr_elementId_lever2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2Axis");
		NativeFieldInfoPtr_elementId_lever2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2MinDetent");
		NativeFieldInfoPtr_elementId_lever3Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3Axis");
		NativeFieldInfoPtr_elementId_lever3MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3MinDetent");
		NativeFieldInfoPtr_elementId_lever4Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4Axis");
		NativeFieldInfoPtr_elementId_lever4MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4MinDetent");
		NativeFieldInfoPtr_elementId_lever5Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5Axis");
		NativeFieldInfoPtr_elementId_lever5MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5MinDetent");
		NativeFieldInfoPtr_elementId_leftGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton1");
		NativeFieldInfoPtr_elementId_leftGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton2");
		NativeFieldInfoPtr_elementId_leftGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton3");
		NativeFieldInfoPtr_elementId_leftGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton4");
		NativeFieldInfoPtr_elementId_leftGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton5");
		NativeFieldInfoPtr_elementId_leftGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton6");
		NativeFieldInfoPtr_elementId_rightGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton1");
		NativeFieldInfoPtr_elementId_rightGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton2");
		NativeFieldInfoPtr_elementId_rightGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton3");
		NativeFieldInfoPtr_elementId_rightGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton4");
		NativeFieldInfoPtr_elementId_rightGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton5");
		NativeFieldInfoPtr_elementId_rightGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton6");
		NativeFieldInfoPtr_elementId_centerButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton1");
		NativeFieldInfoPtr_elementId_centerButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton2");
		NativeFieldInfoPtr_elementId_centerButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton3");
		NativeFieldInfoPtr_elementId_centerButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton4");
		NativeFieldInfoPtr_elementId_centerButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton5");
		NativeFieldInfoPtr_elementId_centerButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton6");
		NativeFieldInfoPtr_elementId_centerButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton7");
		NativeFieldInfoPtr_elementId_centerButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton8");
		NativeFieldInfoPtr_elementId_wheel1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Up");
		NativeFieldInfoPtr_elementId_wheel1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Down");
		NativeFieldInfoPtr_elementId_wheel1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Press");
		NativeFieldInfoPtr_elementId_wheel2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Up");
		NativeFieldInfoPtr_elementId_wheel2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Down");
		NativeFieldInfoPtr_elementId_wheel2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Press");
		NativeFieldInfoPtr_elementId_leftGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUp");
		NativeFieldInfoPtr_elementId_leftGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUpRight");
		NativeFieldInfoPtr_elementId_leftGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatRight");
		NativeFieldInfoPtr_elementId_leftGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDownRight");
		NativeFieldInfoPtr_elementId_leftGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDown");
		NativeFieldInfoPtr_elementId_leftGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDownLeft");
		NativeFieldInfoPtr_elementId_leftGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatLeft");
		NativeFieldInfoPtr_elementId_leftGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUpLeft");
		NativeFieldInfoPtr_elementId_rightGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUp");
		NativeFieldInfoPtr_elementId_rightGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUpRight");
		NativeFieldInfoPtr_elementId_rightGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatRight");
		NativeFieldInfoPtr_elementId_rightGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDownRight");
		NativeFieldInfoPtr_elementId_rightGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDown");
		NativeFieldInfoPtr_elementId_rightGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDownLeft");
		NativeFieldInfoPtr_elementId_rightGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatLeft");
		NativeFieldInfoPtr_elementId_rightGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUpLeft");
		NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton1");
		NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton2");
		NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton3");
		NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton4");
		NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton5");
		NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton6");
		NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton7");
		NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton8");
		NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton9");
		NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton10");
		NativeFieldInfoPtr_elementId_mode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode1");
		NativeFieldInfoPtr_elementId_mode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode2");
		NativeFieldInfoPtr_elementId_mode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode3");
		NativeFieldInfoPtr_elementId_yoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_yoke");
		NativeFieldInfoPtr_elementId_lever1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1");
		NativeFieldInfoPtr_elementId_lever2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2");
		NativeFieldInfoPtr_elementId_lever3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3");
		NativeFieldInfoPtr_elementId_lever4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4");
		NativeFieldInfoPtr_elementId_lever5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5");
		NativeFieldInfoPtr_elementId_leftGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHat");
		NativeFieldInfoPtr_elementId_rightGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHat");
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674759);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674760);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674761);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674762);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674763);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674764);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674765);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674766);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674767);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674768);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674769);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674770);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674771);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674772);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674773);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674774);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674775);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674776);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674777);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674778);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674779);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674780);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674781);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674782);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674783);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674784);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674785);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674786);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674787);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674788);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674789);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674790);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674791);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674792);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674793);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674794);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674795);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674796);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674797);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674798);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674799);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674800);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674801);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674802);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674803);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674804);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674805);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674806);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674807);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100674808);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlightYokeTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FlightYokeTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
