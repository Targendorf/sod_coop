using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired;

public sealed class FlightPedalsTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPedal;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPedal;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_slide;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;

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

	public unsafe static int elementId_slide
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_slide, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_slide, (void*)(&num));
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002EleftPedal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347837, XrefRangeEnd = 347840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002ErightPedal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347840, XrefRangeEnd = 347843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateAxis Rewired_002EIFlightPedalsTemplate_002Eslide
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347843, XrefRangeEnd = 347852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateAxis>(intPtr) : null;
		}
	}

	static FlightPedalsTemplate()
	{
		Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "FlightPedalsTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_leftPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "elementId_leftPedal");
		NativeFieldInfoPtr_elementId_rightPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "elementId_rightPedal");
		NativeFieldInfoPtr_elementId_slide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, "elementId_slide");
		NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100674810);
		NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100674811);
		NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100674812);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100674813);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlightPedalsTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FlightPedalsTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
