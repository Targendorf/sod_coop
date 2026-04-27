using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public class PlayerPointerEventData : PointerEventData
{
	private static readonly IntPtr NativeFieldInfoPtr__playerId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__inputSourceIndex_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__mouseSource_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__touchSource_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__sourceType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__buttonIndex_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe int _playerId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId_k__BackingField)) = num;
		}
	}

	public unsafe int _inputSourceIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputSourceIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputSourceIndex_k__BackingField)) = num;
		}
	}

	public unsafe IMouseInputSource _mouseSource_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseSource_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mouseSource_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mouseInputSource));
		}
	}

	public unsafe ITouchInputSource _touchSource_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchSource_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchSource_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)touchInputSource));
		}
	}

	public unsafe PointerEventType _sourceType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sourceType_k__BackingField);
			return *(PointerEventType*)num;
		}
		set
		{
			*(PointerEventType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sourceType_k__BackingField)) = pointerEventType;
		}
	}

	public unsafe int _buttonIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buttonIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buttonIndex_k__BackingField)) = num;
		}
	}

	public unsafe int playerId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int inputSourceIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IMouseInputSource mouseSource
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ITouchInputSource touchSource
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349572, RefRangeEnd = 349573, XrefRangeStart = 349572, XrefRangeEnd = 349572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe PointerEventType sourceType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(PointerEventType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int buttonIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static PlayerPointerEventData()
	{
		Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", "PlayerPointerEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr);
		NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<playerId>k__BackingField");
		NativeFieldInfoPtr__inputSourceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<inputSourceIndex>k__BackingField");
		NativeFieldInfoPtr__mouseSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<mouseSource>k__BackingField");
		NativeFieldInfoPtr__touchSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<touchSource>k__BackingField");
		NativeFieldInfoPtr__sourceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<sourceType>k__BackingField");
		NativeFieldInfoPtr__buttonIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<buttonIndex>k__BackingField");
		NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675067);
		NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675068);
		NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675069);
		NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675070);
		NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675071);
		NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675072);
		NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675073);
		NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675074);
		NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675075);
		NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675076);
		NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675077);
		NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675078);
		NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675079);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100675080);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349573, XrefRangeEnd = 349574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerPointerEventData(EventSystem eventSystem)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventSystem);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349574, XrefRangeEnd = 349642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public PlayerPointerEventData(IntPtr pointer)
		: base(pointer)
	{
	}
}
