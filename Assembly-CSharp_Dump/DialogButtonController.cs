using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class DialogButtonController : ButtonController
{
	private static readonly IntPtr NativeFieldInfoPtr_option;

	private static readonly IntPtr NativeFieldInfoPtr_selectable;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_DialogOption_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonText_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSelectable_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe EvidenceWitness.DialogOption option
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EvidenceWitness.DialogOption>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_option)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogOption));
		}
	}

	public unsafe bool selectable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectable)) = flag;
		}
	}

	static DialogButtonController()
	{
		Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DialogButtonController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr);
		NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr, "option");
		NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr, "selectable");
		NativeMethodInfoPtr_Setup_Public_Void_DialogOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr, 100671079);
		NativeMethodInfoPtr_UpdateButtonText_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr, 100671080);
		NativeMethodInfoPtr_SetSelectable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr, 100671081);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr, 100671082);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 262616, RefRangeEnd = 262617, XrefRangeStart = 262615, XrefRangeEnd = 262616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(EvidenceWitness.DialogOption newPreset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_DialogOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262617, XrefRangeEnd = 262674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateButtonText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateButtonText_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 262676, RefRangeEnd = 262678, XrefRangeStart = 262674, XrefRangeEnd = 262676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectable(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262678, XrefRangeEnd = 262679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogButtonController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogButtonController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DialogButtonController(IntPtr pointer)
		: base(pointer)
	{
	}
}
