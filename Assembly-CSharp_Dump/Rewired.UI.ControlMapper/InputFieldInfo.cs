using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Rewired.UI.ControlMapper;

public class InputFieldInfo : UIElementInfo
{
	private static readonly IntPtr NativeFieldInfoPtr__actionId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__axisRange_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__actionElementMapId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__controllerType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__controllerId_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int _actionId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionId_k__BackingField)) = num;
		}
	}

	public unsafe AxisRange _axisRange_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisRange_k__BackingField);
			return *(AxisRange*)num;
		}
		set
		{
			*(AxisRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisRange_k__BackingField)) = axisRange;
		}
	}

	public unsafe int _actionElementMapId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionElementMapId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__actionElementMapId_k__BackingField)) = num;
		}
	}

	public unsafe ControllerType _controllerType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerType_k__BackingField);
			return *(ControllerType*)num;
		}
		set
		{
			*(ControllerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerType_k__BackingField)) = controllerType;
		}
	}

	public unsafe int _controllerId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__controllerId_k__BackingField)) = num;
		}
	}

	public unsafe int actionId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe AxisRange axisRange
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(AxisRange*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int actionElementMapId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ControllerType controllerType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(ControllerType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int controllerId
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354917, RefRangeEnd = 354920, XrefRangeStart = 354917, XrefRangeEnd = 354920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static InputFieldInfo()
	{
		Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "InputFieldInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr);
		NativeFieldInfoPtr__actionId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<actionId>k__BackingField");
		NativeFieldInfoPtr__axisRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<axisRange>k__BackingField");
		NativeFieldInfoPtr__actionElementMapId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<actionElementMapId>k__BackingField");
		NativeFieldInfoPtr__controllerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<controllerType>k__BackingField");
		NativeFieldInfoPtr__controllerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, "<controllerId>k__BackingField");
		NativeMethodInfoPtr_get_actionId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676056);
		NativeMethodInfoPtr_set_actionId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676057);
		NativeMethodInfoPtr_get_axisRange_Public_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676058);
		NativeMethodInfoPtr_set_axisRange_Public_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676059);
		NativeMethodInfoPtr_get_actionElementMapId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676060);
		NativeMethodInfoPtr_set_actionElementMapId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676061);
		NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676062);
		NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676063);
		NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676064);
		NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676065);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr, 100676066);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputFieldInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InputFieldInfo(IntPtr pointer)
		: base(pointer)
	{
	}
}
