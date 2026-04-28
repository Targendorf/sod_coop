using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired;

public sealed class GamepadTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_b;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionBottomRow3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_actionTopRow3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftShoulder1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftBumper;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftShoulder2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightShoulder1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightBumper;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightShoulder2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_back;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_center3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_guide;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStickButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStickButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPadLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_dPad;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0;

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

	public unsafe static int elementId_leftStickX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStickX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStickX, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftStickY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStickY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStickY, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightStickX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStickX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStickX, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightStickY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStickY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStickY, (void*)(&num));
		}
	}

	public unsafe static int elementId_actionBottomRow1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionBottomRow1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionBottomRow1, (void*)(&num));
		}
	}

	public unsafe static int elementId_a
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_a, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_a, (void*)(&num));
		}
	}

	public unsafe static int elementId_actionBottomRow2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionBottomRow2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionBottomRow2, (void*)(&num));
		}
	}

	public unsafe static int elementId_b
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_b, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_b, (void*)(&num));
		}
	}

	public unsafe static int elementId_actionBottomRow3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionBottomRow3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionBottomRow3, (void*)(&num));
		}
	}

	public unsafe static int elementId_c
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_c, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_c, (void*)(&num));
		}
	}

	public unsafe static int elementId_actionTopRow1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionTopRow1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionTopRow1, (void*)(&num));
		}
	}

	public unsafe static int elementId_x
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_x, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_x, (void*)(&num));
		}
	}

	public unsafe static int elementId_actionTopRow2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionTopRow2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionTopRow2, (void*)(&num));
		}
	}

	public unsafe static int elementId_y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_y, (void*)(&num));
		}
	}

	public unsafe static int elementId_actionTopRow3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_actionTopRow3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_actionTopRow3, (void*)(&num));
		}
	}

	public unsafe static int elementId_z
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_z, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_z, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftShoulder1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftShoulder1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftShoulder1, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftBumper
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftBumper, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftBumper, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftShoulder2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftShoulder2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftShoulder2, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftTrigger
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftTrigger, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftTrigger, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightShoulder1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightShoulder1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightShoulder1, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightBumper
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightBumper, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightBumper, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightShoulder2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightShoulder2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightShoulder2, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightTrigger
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightTrigger, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightTrigger, (void*)(&num));
		}
	}

	public unsafe static int elementId_center1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_center1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_center1, (void*)(&num));
		}
	}

	public unsafe static int elementId_back
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_back, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_back, (void*)(&num));
		}
	}

	public unsafe static int elementId_center2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_center2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_center2, (void*)(&num));
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

	public unsafe static int elementId_center3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_center3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_center3, (void*)(&num));
		}
	}

	public unsafe static int elementId_guide
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_guide, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_guide, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftStickButton
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStickButton, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStickButton, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightStickButton
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStickButton, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStickButton, (void*)(&num));
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

	public unsafe static int elementId_leftStick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftStick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftStick, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightStick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightStick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightStick, (void*)(&num));
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

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347185, XrefRangeEnd = 347188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ea
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347188, XrefRangeEnd = 347191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347191, XrefRangeEnd = 347194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eb
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347194, XrefRangeEnd = 347197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347197, XrefRangeEnd = 347200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ec
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347200, XrefRangeEnd = 347203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347203, XrefRangeEnd = 347206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ex
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347206, XrefRangeEnd = 347209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347209, XrefRangeEnd = 347212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347212, XrefRangeEnd = 347215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347215, XrefRangeEnd = 347218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ez
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347218, XrefRangeEnd = 347221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftShoulder1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347221, XrefRangeEnd = 347224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftBumper
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347224, XrefRangeEnd = 347227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftShoulder2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347227, XrefRangeEnd = 347230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftTrigger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347230, XrefRangeEnd = 347233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightShoulder1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347233, XrefRangeEnd = 347236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightBumper
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347236, XrefRangeEnd = 347239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightShoulder2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347239, XrefRangeEnd = 347242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightTrigger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347242, XrefRangeEnd = 347245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347245, XrefRangeEnd = 347248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eback
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347248, XrefRangeEnd = 347251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347251, XrefRangeEnd = 347254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Estart
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347254, XrefRangeEnd = 347257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347257, XrefRangeEnd = 347260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eguide
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347260, XrefRangeEnd = 347263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002EleftStick
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347263, XrefRangeEnd = 347266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002ErightStick
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347266, XrefRangeEnd = 347269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateDPad Rewired_002EIGamepadTemplate_002EdPad
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347269, XrefRangeEnd = 347272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateDPad>(intPtr) : null;
		}
	}

	static GamepadTemplate()
	{
		Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "GamepadTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickX");
		NativeFieldInfoPtr_elementId_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickY");
		NativeFieldInfoPtr_elementId_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickX");
		NativeFieldInfoPtr_elementId_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickY");
		NativeFieldInfoPtr_elementId_actionBottomRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow1");
		NativeFieldInfoPtr_elementId_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_a");
		NativeFieldInfoPtr_elementId_actionBottomRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow2");
		NativeFieldInfoPtr_elementId_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_b");
		NativeFieldInfoPtr_elementId_actionBottomRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionBottomRow3");
		NativeFieldInfoPtr_elementId_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_c");
		NativeFieldInfoPtr_elementId_actionTopRow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow1");
		NativeFieldInfoPtr_elementId_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_x");
		NativeFieldInfoPtr_elementId_actionTopRow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow2");
		NativeFieldInfoPtr_elementId_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_y");
		NativeFieldInfoPtr_elementId_actionTopRow3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_actionTopRow3");
		NativeFieldInfoPtr_elementId_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_z");
		NativeFieldInfoPtr_elementId_leftShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftShoulder1");
		NativeFieldInfoPtr_elementId_leftBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftBumper");
		NativeFieldInfoPtr_elementId_leftShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftShoulder2");
		NativeFieldInfoPtr_elementId_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftTrigger");
		NativeFieldInfoPtr_elementId_rightShoulder1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightShoulder1");
		NativeFieldInfoPtr_elementId_rightBumper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightBumper");
		NativeFieldInfoPtr_elementId_rightShoulder2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightShoulder2");
		NativeFieldInfoPtr_elementId_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightTrigger");
		NativeFieldInfoPtr_elementId_center1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center1");
		NativeFieldInfoPtr_elementId_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_back");
		NativeFieldInfoPtr_elementId_center2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center2");
		NativeFieldInfoPtr_elementId_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_start");
		NativeFieldInfoPtr_elementId_center3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_center3");
		NativeFieldInfoPtr_elementId_guide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_guide");
		NativeFieldInfoPtr_elementId_leftStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStickButton");
		NativeFieldInfoPtr_elementId_rightStickButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStickButton");
		NativeFieldInfoPtr_elementId_dPadUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadUp");
		NativeFieldInfoPtr_elementId_dPadRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadRight");
		NativeFieldInfoPtr_elementId_dPadDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadDown");
		NativeFieldInfoPtr_elementId_dPadLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPadLeft");
		NativeFieldInfoPtr_elementId_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_leftStick");
		NativeFieldInfoPtr_elementId_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_rightStick");
		NativeFieldInfoPtr_elementId_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, "elementId_dPad");
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674594);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_a_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674595);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674596);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_b_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674597);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionBottomRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674598);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_c_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674599);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674600);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_x_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674601);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674602);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_y_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674603);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_actionTopRow3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674604);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_z_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674605);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674606);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674607);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674608);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674609);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674610);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightBumper_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674611);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightShoulder2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674612);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightTrigger_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674613);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674614);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674615);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674616);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_start_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674617);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_center3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674618);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_guide_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674619);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_leftStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674620);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_rightStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674621);
		NativeMethodInfoPtr_Rewired_IGamepadTemplate_get_dPad_Private_Virtual_Final_New_get_IControllerTemplateDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674622);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr, 100674623);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347272, XrefRangeEnd = 347282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GamepadTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GamepadTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
