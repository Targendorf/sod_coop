using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired;

public sealed class SixDofControllerTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_positionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_positionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_positionZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotationX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotationY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotationZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_extraAxis4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button11;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button12;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button13;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button14;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button15;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button16;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button17;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button18;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button19;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button20;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button21;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button22;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button23;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button24;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button25;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button26;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button27;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button28;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button29;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button30;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button31;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_button32;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1UpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1DownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1DownLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1UpLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2UpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2DownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2DownLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2UpLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_hat2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stick;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0;

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

	public unsafe static int elementId_positionX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_positionX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_positionX, (void*)(&num));
		}
	}

	public unsafe static int elementId_positionY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_positionY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_positionY, (void*)(&num));
		}
	}

	public unsafe static int elementId_positionZ
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_positionZ, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_positionZ, (void*)(&num));
		}
	}

	public unsafe static int elementId_rotationX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rotationX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rotationX, (void*)(&num));
		}
	}

	public unsafe static int elementId_rotationY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rotationY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rotationY, (void*)(&num));
		}
	}

	public unsafe static int elementId_rotationZ
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rotationZ, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rotationZ, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttle1Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttle1Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttle1Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttle1MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttle1MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttle2Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttle2Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttle2Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttle2MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttle2MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_extraAxis1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_extraAxis1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_extraAxis1, (void*)(&num));
		}
	}

	public unsafe static int elementId_extraAxis2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_extraAxis2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_extraAxis2, (void*)(&num));
		}
	}

	public unsafe static int elementId_extraAxis3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_extraAxis3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_extraAxis3, (void*)(&num));
		}
	}

	public unsafe static int elementId_extraAxis4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_extraAxis4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_extraAxis4, (void*)(&num));
		}
	}

	public unsafe static int elementId_button1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button1, (void*)(&num));
		}
	}

	public unsafe static int elementId_button2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button2, (void*)(&num));
		}
	}

	public unsafe static int elementId_button3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button3, (void*)(&num));
		}
	}

	public unsafe static int elementId_button4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button4, (void*)(&num));
		}
	}

	public unsafe static int elementId_button5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button5, (void*)(&num));
		}
	}

	public unsafe static int elementId_button6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button6, (void*)(&num));
		}
	}

	public unsafe static int elementId_button7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button7, (void*)(&num));
		}
	}

	public unsafe static int elementId_button8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button8, (void*)(&num));
		}
	}

	public unsafe static int elementId_button9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button9, (void*)(&num));
		}
	}

	public unsafe static int elementId_button10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button10, (void*)(&num));
		}
	}

	public unsafe static int elementId_button11
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button11, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button11, (void*)(&num));
		}
	}

	public unsafe static int elementId_button12
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button12, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button12, (void*)(&num));
		}
	}

	public unsafe static int elementId_button13
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button13, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button13, (void*)(&num));
		}
	}

	public unsafe static int elementId_button14
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button14, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button14, (void*)(&num));
		}
	}

	public unsafe static int elementId_button15
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button15, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button15, (void*)(&num));
		}
	}

	public unsafe static int elementId_button16
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button16, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button16, (void*)(&num));
		}
	}

	public unsafe static int elementId_button17
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button17, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button17, (void*)(&num));
		}
	}

	public unsafe static int elementId_button18
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button18, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button18, (void*)(&num));
		}
	}

	public unsafe static int elementId_button19
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button19, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button19, (void*)(&num));
		}
	}

	public unsafe static int elementId_button20
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button20, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button20, (void*)(&num));
		}
	}

	public unsafe static int elementId_button21
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button21, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button21, (void*)(&num));
		}
	}

	public unsafe static int elementId_button22
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button22, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button22, (void*)(&num));
		}
	}

	public unsafe static int elementId_button23
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button23, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button23, (void*)(&num));
		}
	}

	public unsafe static int elementId_button24
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button24, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button24, (void*)(&num));
		}
	}

	public unsafe static int elementId_button25
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button25, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button25, (void*)(&num));
		}
	}

	public unsafe static int elementId_button26
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button26, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button26, (void*)(&num));
		}
	}

	public unsafe static int elementId_button27
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button27, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button27, (void*)(&num));
		}
	}

	public unsafe static int elementId_button28
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button28, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button28, (void*)(&num));
		}
	}

	public unsafe static int elementId_button29
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button29, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button29, (void*)(&num));
		}
	}

	public unsafe static int elementId_button30
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button30, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button30, (void*)(&num));
		}
	}

	public unsafe static int elementId_button31
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button31, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button31, (void*)(&num));
		}
	}

	public unsafe static int elementId_button32
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_button32, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_button32, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1UpRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1UpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1UpRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1DownRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1DownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1DownRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1DownLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1DownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1DownLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1UpLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1UpLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1UpLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2UpRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2UpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2UpRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2DownRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2DownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2DownRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2DownLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2DownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2DownLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2UpLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2UpLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2UpLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat1, (void*)(&num));
		}
	}

	public unsafe static int elementId_hat2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_hat2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_hat2, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttle1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttle1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttle1, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttle2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttle2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttle2, (void*)(&num));
		}
	}

	public unsafe static int elementId_stick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stick, (void*)(&num));
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347852, XrefRangeEnd = 347855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347855, XrefRangeEnd = 347858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347858, XrefRangeEnd = 347861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347861, XrefRangeEnd = 347864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347864, XrefRangeEnd = 347867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347867, XrefRangeEnd = 347870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347870, XrefRangeEnd = 347873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347873, XrefRangeEnd = 347876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347876, XrefRangeEnd = 347879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347879, XrefRangeEnd = 347882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347882, XrefRangeEnd = 347885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347885, XrefRangeEnd = 347888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347888, XrefRangeEnd = 347891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347891, XrefRangeEnd = 347894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton11
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347894, XrefRangeEnd = 347897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton12
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347897, XrefRangeEnd = 347900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton13
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347900, XrefRangeEnd = 347903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton14
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347903, XrefRangeEnd = 347906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton15
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347906, XrefRangeEnd = 347909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton16
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347909, XrefRangeEnd = 347912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton17
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347912, XrefRangeEnd = 347915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton18
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347915, XrefRangeEnd = 347918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton19
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347918, XrefRangeEnd = 347921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton20
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347921, XrefRangeEnd = 347924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton21
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347924, XrefRangeEnd = 347927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton22
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347927, XrefRangeEnd = 347930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton23
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347930, XrefRangeEnd = 347933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton24
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347933, XrefRangeEnd = 347936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton25
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347936, XrefRangeEnd = 347939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton26
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347939, XrefRangeEnd = 347942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton27
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347942, XrefRangeEnd = 347945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton28
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347945, XrefRangeEnd = 347948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton29
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347948, XrefRangeEnd = 347951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton30
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347951, XrefRangeEnd = 347954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton31
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347954, XrefRangeEnd = 347957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton32
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347957, XrefRangeEnd = 347960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EISixDofControllerTemplate_002Ehat1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347960, XrefRangeEnd = 347963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EISixDofControllerTemplate_002Ehat2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347963, XrefRangeEnd = 347966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EISixDofControllerTemplate_002Ethrottle1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347966, XrefRangeEnd = 347969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EISixDofControllerTemplate_002Ethrottle2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347969, XrefRangeEnd = 347972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateStick6D Rewired_002EISixDofControllerTemplate_002Estick
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347972, XrefRangeEnd = 347981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateStick6D>(intPtr) : null;
		}
	}

	static SixDofControllerTemplate()
	{
		Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "SixDofControllerTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_positionX");
		NativeFieldInfoPtr_elementId_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_positionY");
		NativeFieldInfoPtr_elementId_positionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_positionZ");
		NativeFieldInfoPtr_elementId_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_rotationX");
		NativeFieldInfoPtr_elementId_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_rotationY");
		NativeFieldInfoPtr_elementId_rotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_rotationZ");
		NativeFieldInfoPtr_elementId_throttle1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle1Axis");
		NativeFieldInfoPtr_elementId_throttle1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle1MinDetent");
		NativeFieldInfoPtr_elementId_throttle2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle2Axis");
		NativeFieldInfoPtr_elementId_throttle2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle2MinDetent");
		NativeFieldInfoPtr_elementId_extraAxis1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis1");
		NativeFieldInfoPtr_elementId_extraAxis2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis2");
		NativeFieldInfoPtr_elementId_extraAxis3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis3");
		NativeFieldInfoPtr_elementId_extraAxis4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_extraAxis4");
		NativeFieldInfoPtr_elementId_button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button1");
		NativeFieldInfoPtr_elementId_button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button2");
		NativeFieldInfoPtr_elementId_button3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button3");
		NativeFieldInfoPtr_elementId_button4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button4");
		NativeFieldInfoPtr_elementId_button5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button5");
		NativeFieldInfoPtr_elementId_button6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button6");
		NativeFieldInfoPtr_elementId_button7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button7");
		NativeFieldInfoPtr_elementId_button8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button8");
		NativeFieldInfoPtr_elementId_button9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button9");
		NativeFieldInfoPtr_elementId_button10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button10");
		NativeFieldInfoPtr_elementId_button11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button11");
		NativeFieldInfoPtr_elementId_button12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button12");
		NativeFieldInfoPtr_elementId_button13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button13");
		NativeFieldInfoPtr_elementId_button14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button14");
		NativeFieldInfoPtr_elementId_button15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button15");
		NativeFieldInfoPtr_elementId_button16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button16");
		NativeFieldInfoPtr_elementId_button17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button17");
		NativeFieldInfoPtr_elementId_button18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button18");
		NativeFieldInfoPtr_elementId_button19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button19");
		NativeFieldInfoPtr_elementId_button20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button20");
		NativeFieldInfoPtr_elementId_button21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button21");
		NativeFieldInfoPtr_elementId_button22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button22");
		NativeFieldInfoPtr_elementId_button23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button23");
		NativeFieldInfoPtr_elementId_button24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button24");
		NativeFieldInfoPtr_elementId_button25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button25");
		NativeFieldInfoPtr_elementId_button26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button26");
		NativeFieldInfoPtr_elementId_button27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button27");
		NativeFieldInfoPtr_elementId_button28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button28");
		NativeFieldInfoPtr_elementId_button29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button29");
		NativeFieldInfoPtr_elementId_button30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button30");
		NativeFieldInfoPtr_elementId_button31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button31");
		NativeFieldInfoPtr_elementId_button32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_button32");
		NativeFieldInfoPtr_elementId_hat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Up");
		NativeFieldInfoPtr_elementId_hat1UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1UpRight");
		NativeFieldInfoPtr_elementId_hat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Right");
		NativeFieldInfoPtr_elementId_hat1DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1DownRight");
		NativeFieldInfoPtr_elementId_hat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Down");
		NativeFieldInfoPtr_elementId_hat1DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1DownLeft");
		NativeFieldInfoPtr_elementId_hat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1Left");
		NativeFieldInfoPtr_elementId_hat1UpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1UpLeft");
		NativeFieldInfoPtr_elementId_hat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Up");
		NativeFieldInfoPtr_elementId_hat2UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2UpRight");
		NativeFieldInfoPtr_elementId_hat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Right");
		NativeFieldInfoPtr_elementId_hat2DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2DownRight");
		NativeFieldInfoPtr_elementId_hat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Down");
		NativeFieldInfoPtr_elementId_hat2DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2DownLeft");
		NativeFieldInfoPtr_elementId_hat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2Left");
		NativeFieldInfoPtr_elementId_hat2UpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2UpLeft");
		NativeFieldInfoPtr_elementId_hat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat1");
		NativeFieldInfoPtr_elementId_hat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_hat2");
		NativeFieldInfoPtr_elementId_throttle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle1");
		NativeFieldInfoPtr_elementId_throttle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_throttle2");
		NativeFieldInfoPtr_elementId_stick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, "elementId_stick");
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674815);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674816);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674817);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_extraAxis4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674818);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674819);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674820);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674821);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674822);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674823);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674824);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674825);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674826);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674827);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674828);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674829);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674830);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button13_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674831);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button14_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674832);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button15_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674833);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button16_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674834);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button17_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674835);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button18_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674836);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button19_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674837);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button20_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674838);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button21_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674839);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button22_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674840);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button23_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674841);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button24_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674842);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button25_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674843);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button26_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674844);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button27_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674845);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button28_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674846);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button29_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674847);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button30_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674848);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button31_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674849);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_button32_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674850);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674851);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_hat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674852);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674853);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674854);
		NativeMethodInfoPtr_Rewired_ISixDofControllerTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick6D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674855);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr, 100674856);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SixDofControllerTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SixDofControllerTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SixDofControllerTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
