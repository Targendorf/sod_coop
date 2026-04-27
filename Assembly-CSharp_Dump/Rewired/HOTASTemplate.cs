using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired;

public sealed class HOTASTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickRotate;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1X;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2X;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickTriggerStage2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickPinkyButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickPinkyTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickButton10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton11;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickBaseButton12;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1UpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1DownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1DownLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Up_right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Down_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Down_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Up_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Down_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Down_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Up_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Down_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Down_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleButton10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton11;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton12;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton13;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton14;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleBaseButton15;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleSlider4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleDial4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStickPress;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Forward;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Back;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel1Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Forward;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Back;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel2Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Forward;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Back;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleWheel3Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Down_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Down_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Down_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down_Right;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Down_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4Up_Left;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPedal;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPedal;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_slidePedals;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stick;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickMiniStick2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_stickHat4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttle2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleMiniStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_throttleHat4;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

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

	public unsafe static int elementId_stickX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickX, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickY, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickRotate
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickRotate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickRotate, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickMiniStick1X
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick1X, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick1X, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickMiniStick1Y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick1Y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick1Y, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickMiniStick1Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick1Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick1Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickMiniStick2X
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick2X, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick2X, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickMiniStick2Y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick2Y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick2Y, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickMiniStick2Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick2Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick2Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickTrigger
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickTrigger, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickTrigger, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickTriggerStage2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickTriggerStage2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickTriggerStage2, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickPinkyButton
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickPinkyButton, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickPinkyButton, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickPinkyTrigger
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickPinkyTrigger, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickPinkyTrigger, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton9, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickButton10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickButton10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickButton10, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton9, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton10, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton11
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton11, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton11, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickBaseButton12
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickBaseButton12, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickBaseButton12, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1UpRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1UpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1UpRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1DownRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1DownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1DownRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1DownLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1DownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1DownLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1Up_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Up_right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Up_right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Up_right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Down_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Down_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Down_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Down_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Down_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Down_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2Up_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Up_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Up_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Up_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Down_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Down_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Down_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Down_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Down_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Down_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3Up_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Up_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Up_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Up_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Down_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Down_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Down_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Down_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Down_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Down_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4Up_Left, (void*)(&num));
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

	public unsafe static int elementId_throttleButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton9, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleButton10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleButton10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleButton10, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton9, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton10, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton11
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton11, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton11, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton12
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton12, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton12, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton13
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton13, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton13, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton14
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton14, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton14, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleBaseButton15
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleBaseButton15, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleBaseButton15, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleSlider1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleSlider1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleSlider1, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleSlider2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleSlider2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleSlider2, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleSlider3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleSlider3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleSlider3, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleSlider4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleSlider4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleSlider4, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleDial1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleDial1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleDial1, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleDial2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleDial2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleDial2, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleDial3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleDial3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleDial3, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleDial4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleDial4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleDial4, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleMiniStickX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleMiniStickX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleMiniStickX, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleMiniStickY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleMiniStickY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleMiniStickY, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleMiniStickPress
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleMiniStickPress, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleMiniStickPress, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel1Forward
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel1Forward, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel1Forward, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel1Back
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel1Back, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel1Back, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel1Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel1Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel1Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel2Forward
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel2Forward, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel2Forward, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel2Back
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel2Back, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel2Back, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel2Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel2Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel2Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel3Forward
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel3Forward, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel3Forward, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel3Back
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel3Back, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel3Back, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleWheel3Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleWheel3Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleWheel3Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Up_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Up_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Up_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Down_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Down_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Down_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Down_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Down_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Down_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1Up_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Up_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Up_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Up_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Down_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Down_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Down_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Down_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Down_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Down_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2Up_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Up_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Up_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Up_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Down_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Down_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Down_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Down_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Down_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Down_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3Up_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Up_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Up_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Up_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Down_Right
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Down_Right, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Down_Right, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Down_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Down_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Down_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4Up_Left
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4Up_Left, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4Up_Left, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftPedal
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftPedal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftPedal, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightPedal
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightPedal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightPedal, (void*)(&num));
		}
	}

	public unsafe static int elementId_slidePedals
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_slidePedals, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_slidePedals, (void*)(&num));
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

	public unsafe static int elementId_stickMiniStick1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick1, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickMiniStick2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickMiniStick2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickMiniStick2, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat1, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat2, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat3, (void*)(&num));
		}
	}

	public unsafe static int elementId_stickHat4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_stickHat4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_stickHat4, (void*)(&num));
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

	public unsafe static int elementId_throttleMiniStick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleMiniStick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleMiniStick, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat1, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat2, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat3, (void*)(&num));
		}
	}

	public unsafe static int elementId_throttleHat4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_throttleHat4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_throttleHat4, (void*)(&num));
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickTrigger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347414, XrefRangeEnd = 347417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickTriggerStage2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347417, XrefRangeEnd = 347420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickPinkyButton
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347420, XrefRangeEnd = 347423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickPinkyTrigger
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347423, XrefRangeEnd = 347426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347426, XrefRangeEnd = 347429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347429, XrefRangeEnd = 347432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347432, XrefRangeEnd = 347435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347435, XrefRangeEnd = 347438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347438, XrefRangeEnd = 347441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347441, XrefRangeEnd = 347444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347444, XrefRangeEnd = 347447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347447, XrefRangeEnd = 347450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347450, XrefRangeEnd = 347453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347453, XrefRangeEnd = 347456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347456, XrefRangeEnd = 347459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347459, XrefRangeEnd = 347462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347462, XrefRangeEnd = 347465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347465, XrefRangeEnd = 347468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347468, XrefRangeEnd = 347471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347471, XrefRangeEnd = 347474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347474, XrefRangeEnd = 347477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347477, XrefRangeEnd = 347480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347480, XrefRangeEnd = 347483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347483, XrefRangeEnd = 347486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton11
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347486, XrefRangeEnd = 347489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EstickBaseButton12
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347489, XrefRangeEnd = 347492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347492, XrefRangeEnd = 347495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347495, XrefRangeEnd = 347498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002Emode3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347498, XrefRangeEnd = 347501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347501, XrefRangeEnd = 347504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347504, XrefRangeEnd = 347507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347507, XrefRangeEnd = 347510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347510, XrefRangeEnd = 347513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347513, XrefRangeEnd = 347516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347516, XrefRangeEnd = 347519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347519, XrefRangeEnd = 347522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347522, XrefRangeEnd = 347525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347525, XrefRangeEnd = 347528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347528, XrefRangeEnd = 347531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347531, XrefRangeEnd = 347534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347534, XrefRangeEnd = 347537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347537, XrefRangeEnd = 347540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347540, XrefRangeEnd = 347543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347543, XrefRangeEnd = 347546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347546, XrefRangeEnd = 347549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347549, XrefRangeEnd = 347552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347552, XrefRangeEnd = 347555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347555, XrefRangeEnd = 347558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347558, XrefRangeEnd = 347561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton11
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347561, XrefRangeEnd = 347564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton12
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347564, XrefRangeEnd = 347567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton13
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347567, XrefRangeEnd = 347570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton14
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347570, XrefRangeEnd = 347573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleBaseButton15
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347573, XrefRangeEnd = 347576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347576, XrefRangeEnd = 347579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347579, XrefRangeEnd = 347582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347582, XrefRangeEnd = 347585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleSlider4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347585, XrefRangeEnd = 347588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347588, XrefRangeEnd = 347591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347591, XrefRangeEnd = 347594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347594, XrefRangeEnd = 347597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EthrottleDial4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347597, XrefRangeEnd = 347600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Forward
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347600, XrefRangeEnd = 347603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Back
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347603, XrefRangeEnd = 347606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel1Press
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347606, XrefRangeEnd = 347609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Forward
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347609, XrefRangeEnd = 347612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Back
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347612, XrefRangeEnd = 347615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel2Press
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347615, XrefRangeEnd = 347618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Forward
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347618, XrefRangeEnd = 347621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Back
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347621, XrefRangeEnd = 347624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIHOTASTemplate_002EthrottleWheel3Press
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347624, XrefRangeEnd = 347627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EleftPedal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347627, XrefRangeEnd = 347630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002ErightPedal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347630, XrefRangeEnd = 347633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIHOTASTemplate_002EslidePedals
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347633, XrefRangeEnd = 347636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateStick Rewired_002EIHOTASTemplate_002Estick
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347636, XrefRangeEnd = 347639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateStick>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EstickMiniStick1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347639, XrefRangeEnd = 347642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EstickMiniStick2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347642, XrefRangeEnd = 347645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347645, XrefRangeEnd = 347648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347648, XrefRangeEnd = 347651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347651, XrefRangeEnd = 347654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EstickHat4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347654, XrefRangeEnd = 347657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIHOTASTemplate_002Ethrottle1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347657, XrefRangeEnd = 347660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIHOTASTemplate_002Ethrottle2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347660, XrefRangeEnd = 347663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThumbStick Rewired_002EIHOTASTemplate_002EthrottleMiniStick
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347663, XrefRangeEnd = 347666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThumbStick>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347666, XrefRangeEnd = 347669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347669, XrefRangeEnd = 347672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347672, XrefRangeEnd = 347675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIHOTASTemplate_002EthrottleHat4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347675, XrefRangeEnd = 347684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	static HOTASTemplate()
	{
		Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "HOTASTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_stickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickX");
		NativeFieldInfoPtr_elementId_stickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickY");
		NativeFieldInfoPtr_elementId_stickRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickRotate");
		NativeFieldInfoPtr_elementId_stickMiniStick1X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1X");
		NativeFieldInfoPtr_elementId_stickMiniStick1Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1Y");
		NativeFieldInfoPtr_elementId_stickMiniStick1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1Press");
		NativeFieldInfoPtr_elementId_stickMiniStick2X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2X");
		NativeFieldInfoPtr_elementId_stickMiniStick2Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2Y");
		NativeFieldInfoPtr_elementId_stickMiniStick2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2Press");
		NativeFieldInfoPtr_elementId_stickTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickTrigger");
		NativeFieldInfoPtr_elementId_stickTriggerStage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickTriggerStage2");
		NativeFieldInfoPtr_elementId_stickPinkyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickPinkyButton");
		NativeFieldInfoPtr_elementId_stickPinkyTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickPinkyTrigger");
		NativeFieldInfoPtr_elementId_stickButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton1");
		NativeFieldInfoPtr_elementId_stickButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton2");
		NativeFieldInfoPtr_elementId_stickButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton3");
		NativeFieldInfoPtr_elementId_stickButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton4");
		NativeFieldInfoPtr_elementId_stickButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton5");
		NativeFieldInfoPtr_elementId_stickButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton6");
		NativeFieldInfoPtr_elementId_stickButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton7");
		NativeFieldInfoPtr_elementId_stickButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton8");
		NativeFieldInfoPtr_elementId_stickButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton9");
		NativeFieldInfoPtr_elementId_stickButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickButton10");
		NativeFieldInfoPtr_elementId_stickBaseButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton1");
		NativeFieldInfoPtr_elementId_stickBaseButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton2");
		NativeFieldInfoPtr_elementId_stickBaseButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton3");
		NativeFieldInfoPtr_elementId_stickBaseButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton4");
		NativeFieldInfoPtr_elementId_stickBaseButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton5");
		NativeFieldInfoPtr_elementId_stickBaseButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton6");
		NativeFieldInfoPtr_elementId_stickBaseButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton7");
		NativeFieldInfoPtr_elementId_stickBaseButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton8");
		NativeFieldInfoPtr_elementId_stickBaseButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton9");
		NativeFieldInfoPtr_elementId_stickBaseButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton10");
		NativeFieldInfoPtr_elementId_stickBaseButton11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton11");
		NativeFieldInfoPtr_elementId_stickBaseButton12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickBaseButton12");
		NativeFieldInfoPtr_elementId_stickHat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Up");
		NativeFieldInfoPtr_elementId_stickHat1UpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1UpRight");
		NativeFieldInfoPtr_elementId_stickHat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Right");
		NativeFieldInfoPtr_elementId_stickHat1DownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1DownRight");
		NativeFieldInfoPtr_elementId_stickHat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Down");
		NativeFieldInfoPtr_elementId_stickHat1DownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1DownLeft");
		NativeFieldInfoPtr_elementId_stickHat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Left");
		NativeFieldInfoPtr_elementId_stickHat1Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1Up_Left");
		NativeFieldInfoPtr_elementId_stickHat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Up");
		NativeFieldInfoPtr_elementId_stickHat2Up_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Up_right");
		NativeFieldInfoPtr_elementId_stickHat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Right");
		NativeFieldInfoPtr_elementId_stickHat2Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Down_Right");
		NativeFieldInfoPtr_elementId_stickHat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Down");
		NativeFieldInfoPtr_elementId_stickHat2Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Down_Left");
		NativeFieldInfoPtr_elementId_stickHat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Left");
		NativeFieldInfoPtr_elementId_stickHat2Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2Up_Left");
		NativeFieldInfoPtr_elementId_stickHat3Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Up");
		NativeFieldInfoPtr_elementId_stickHat3Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Up_Right");
		NativeFieldInfoPtr_elementId_stickHat3Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Right");
		NativeFieldInfoPtr_elementId_stickHat3Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Down_Right");
		NativeFieldInfoPtr_elementId_stickHat3Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Down");
		NativeFieldInfoPtr_elementId_stickHat3Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Down_Left");
		NativeFieldInfoPtr_elementId_stickHat3Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Left");
		NativeFieldInfoPtr_elementId_stickHat3Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3Up_Left");
		NativeFieldInfoPtr_elementId_stickHat4Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Up");
		NativeFieldInfoPtr_elementId_stickHat4Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Up_Right");
		NativeFieldInfoPtr_elementId_stickHat4Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Right");
		NativeFieldInfoPtr_elementId_stickHat4Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Down_Right");
		NativeFieldInfoPtr_elementId_stickHat4Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Down");
		NativeFieldInfoPtr_elementId_stickHat4Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Down_Left");
		NativeFieldInfoPtr_elementId_stickHat4Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Left");
		NativeFieldInfoPtr_elementId_stickHat4Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4Up_Left");
		NativeFieldInfoPtr_elementId_mode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_mode1");
		NativeFieldInfoPtr_elementId_mode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_mode2");
		NativeFieldInfoPtr_elementId_mode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_mode3");
		NativeFieldInfoPtr_elementId_throttle1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle1Axis");
		NativeFieldInfoPtr_elementId_throttle2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle2Axis");
		NativeFieldInfoPtr_elementId_throttle1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle1MinDetent");
		NativeFieldInfoPtr_elementId_throttle2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle2MinDetent");
		NativeFieldInfoPtr_elementId_throttleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton1");
		NativeFieldInfoPtr_elementId_throttleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton2");
		NativeFieldInfoPtr_elementId_throttleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton3");
		NativeFieldInfoPtr_elementId_throttleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton4");
		NativeFieldInfoPtr_elementId_throttleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton5");
		NativeFieldInfoPtr_elementId_throttleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton6");
		NativeFieldInfoPtr_elementId_throttleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton7");
		NativeFieldInfoPtr_elementId_throttleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton8");
		NativeFieldInfoPtr_elementId_throttleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton9");
		NativeFieldInfoPtr_elementId_throttleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleButton10");
		NativeFieldInfoPtr_elementId_throttleBaseButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton1");
		NativeFieldInfoPtr_elementId_throttleBaseButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton2");
		NativeFieldInfoPtr_elementId_throttleBaseButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton3");
		NativeFieldInfoPtr_elementId_throttleBaseButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton4");
		NativeFieldInfoPtr_elementId_throttleBaseButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton5");
		NativeFieldInfoPtr_elementId_throttleBaseButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton6");
		NativeFieldInfoPtr_elementId_throttleBaseButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton7");
		NativeFieldInfoPtr_elementId_throttleBaseButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton8");
		NativeFieldInfoPtr_elementId_throttleBaseButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton9");
		NativeFieldInfoPtr_elementId_throttleBaseButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton10");
		NativeFieldInfoPtr_elementId_throttleBaseButton11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton11");
		NativeFieldInfoPtr_elementId_throttleBaseButton12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton12");
		NativeFieldInfoPtr_elementId_throttleBaseButton13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton13");
		NativeFieldInfoPtr_elementId_throttleBaseButton14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton14");
		NativeFieldInfoPtr_elementId_throttleBaseButton15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleBaseButton15");
		NativeFieldInfoPtr_elementId_throttleSlider1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider1");
		NativeFieldInfoPtr_elementId_throttleSlider2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider2");
		NativeFieldInfoPtr_elementId_throttleSlider3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider3");
		NativeFieldInfoPtr_elementId_throttleSlider4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleSlider4");
		NativeFieldInfoPtr_elementId_throttleDial1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial1");
		NativeFieldInfoPtr_elementId_throttleDial2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial2");
		NativeFieldInfoPtr_elementId_throttleDial3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial3");
		NativeFieldInfoPtr_elementId_throttleDial4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleDial4");
		NativeFieldInfoPtr_elementId_throttleMiniStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStickX");
		NativeFieldInfoPtr_elementId_throttleMiniStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStickY");
		NativeFieldInfoPtr_elementId_throttleMiniStickPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStickPress");
		NativeFieldInfoPtr_elementId_throttleWheel1Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel1Forward");
		NativeFieldInfoPtr_elementId_throttleWheel1Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel1Back");
		NativeFieldInfoPtr_elementId_throttleWheel1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel1Press");
		NativeFieldInfoPtr_elementId_throttleWheel2Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel2Forward");
		NativeFieldInfoPtr_elementId_throttleWheel2Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel2Back");
		NativeFieldInfoPtr_elementId_throttleWheel2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel2Press");
		NativeFieldInfoPtr_elementId_throttleWheel3Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel3Forward");
		NativeFieldInfoPtr_elementId_throttleWheel3Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel3Back");
		NativeFieldInfoPtr_elementId_throttleWheel3Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleWheel3Press");
		NativeFieldInfoPtr_elementId_throttleHat1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Up");
		NativeFieldInfoPtr_elementId_throttleHat1Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Up_Right");
		NativeFieldInfoPtr_elementId_throttleHat1Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Right");
		NativeFieldInfoPtr_elementId_throttleHat1Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Down_Right");
		NativeFieldInfoPtr_elementId_throttleHat1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Down");
		NativeFieldInfoPtr_elementId_throttleHat1Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Down_Left");
		NativeFieldInfoPtr_elementId_throttleHat1Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Left");
		NativeFieldInfoPtr_elementId_throttleHat1Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1Up_Left");
		NativeFieldInfoPtr_elementId_throttleHat2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Up");
		NativeFieldInfoPtr_elementId_throttleHat2Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Up_Right");
		NativeFieldInfoPtr_elementId_throttleHat2Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Right");
		NativeFieldInfoPtr_elementId_throttleHat2Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Down_Right");
		NativeFieldInfoPtr_elementId_throttleHat2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Down");
		NativeFieldInfoPtr_elementId_throttleHat2Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Down_Left");
		NativeFieldInfoPtr_elementId_throttleHat2Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Left");
		NativeFieldInfoPtr_elementId_throttleHat2Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2Up_Left");
		NativeFieldInfoPtr_elementId_throttleHat3Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Up");
		NativeFieldInfoPtr_elementId_throttleHat3Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Up_Right");
		NativeFieldInfoPtr_elementId_throttleHat3Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Right");
		NativeFieldInfoPtr_elementId_throttleHat3Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Down_Right");
		NativeFieldInfoPtr_elementId_throttleHat3Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Down");
		NativeFieldInfoPtr_elementId_throttleHat3Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Down_Left");
		NativeFieldInfoPtr_elementId_throttleHat3Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Left");
		NativeFieldInfoPtr_elementId_throttleHat3Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3Up_Left");
		NativeFieldInfoPtr_elementId_throttleHat4Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Up");
		NativeFieldInfoPtr_elementId_throttleHat4Up_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Up_Right");
		NativeFieldInfoPtr_elementId_throttleHat4Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Right");
		NativeFieldInfoPtr_elementId_throttleHat4Down_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Down_Right");
		NativeFieldInfoPtr_elementId_throttleHat4Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Down");
		NativeFieldInfoPtr_elementId_throttleHat4Down_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Down_Left");
		NativeFieldInfoPtr_elementId_throttleHat4Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Left");
		NativeFieldInfoPtr_elementId_throttleHat4Up_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4Up_Left");
		NativeFieldInfoPtr_elementId_leftPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_leftPedal");
		NativeFieldInfoPtr_elementId_rightPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_rightPedal");
		NativeFieldInfoPtr_elementId_slidePedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_slidePedals");
		NativeFieldInfoPtr_elementId_stick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stick");
		NativeFieldInfoPtr_elementId_stickMiniStick1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick1");
		NativeFieldInfoPtr_elementId_stickMiniStick2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickMiniStick2");
		NativeFieldInfoPtr_elementId_stickHat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat1");
		NativeFieldInfoPtr_elementId_stickHat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat2");
		NativeFieldInfoPtr_elementId_stickHat3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat3");
		NativeFieldInfoPtr_elementId_stickHat4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_stickHat4");
		NativeFieldInfoPtr_elementId_throttle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle1");
		NativeFieldInfoPtr_elementId_throttle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttle2");
		NativeFieldInfoPtr_elementId_throttleMiniStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleMiniStick");
		NativeFieldInfoPtr_elementId_throttleHat1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat1");
		NativeFieldInfoPtr_elementId_throttleHat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat2");
		NativeFieldInfoPtr_elementId_throttleHat3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat3");
		NativeFieldInfoPtr_elementId_throttleHat4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, "elementId_throttleHat4");
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674669);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickTriggerStage2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674670);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyButton_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674671);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickPinkyTrigger_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674672);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674673);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674674);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674675);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674676);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674677);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674678);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674679);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674680);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674681);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674682);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674683);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674684);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674685);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674686);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674687);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674688);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674689);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674690);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674691);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674692);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674693);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674694);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674695);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674696);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674697);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674698);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674699);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674700);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674701);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674702);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674703);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674704);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674705);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674706);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674707);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674708);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674709);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674710);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674711);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674712);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674713);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674714);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674715);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674716);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674717);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton11_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674718);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton12_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674719);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton13_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674720);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton14_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674721);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleBaseButton15_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674722);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674723);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674724);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674725);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleSlider4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674726);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial1_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674727);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial2_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674728);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial3_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674729);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleDial4_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674730);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674731);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674732);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674733);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674734);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674735);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674736);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Forward_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674737);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Back_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674738);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleWheel3Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674739);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674740);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674741);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_slidePedals_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674742);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stick_Private_Virtual_Final_New_get_IControllerTemplateStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674743);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick1_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674744);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickMiniStick2_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674745);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674746);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674747);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674748);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_stickHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674749);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674750);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttle2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674751);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleMiniStick_Private_Virtual_Final_New_get_IControllerTemplateThumbStick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674752);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat1_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674753);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat2_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674754);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat3_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674755);
		NativeMethodInfoPtr_Rewired_IHOTASTemplate_get_throttleHat4_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674756);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr, 100674757);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HOTASTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HOTASTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HOTASTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
