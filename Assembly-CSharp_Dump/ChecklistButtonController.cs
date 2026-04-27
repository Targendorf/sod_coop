using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ChecklistButtonController : ButtonController
{
	private static readonly IntPtr NativeFieldInfoPtr_objective;

	private static readonly IntPtr NativeFieldInfoPtr_bgRend;

	private static readonly IntPtr NativeFieldInfoPtr_textRend;

	private static readonly IntPtr NativeFieldInfoPtr_progressBGrend;

	private static readonly IntPtr NativeFieldInfoPtr_barRend;

	private static readonly IntPtr NativeFieldInfoPtr_iconRend;

	private static readonly IntPtr NativeFieldInfoPtr_fadeInProgress;

	private static readonly IntPtr NativeFieldInfoPtr_fadeOut;

	private static readonly IntPtr NativeFieldInfoPtr_strikeThroughProgress;

	private static readonly IntPtr NativeFieldInfoPtr_desiredAnchoredPosition;

	private static readonly IntPtr NativeFieldInfoPtr_checkedSprite;

	private static readonly IntPtr NativeFieldInfoPtr_progressRect;

	private static readonly IntPtr NativeFieldInfoPtr_flash;

	private static readonly IntPtr NativeFieldInfoPtr_childRendereres;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Objective_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnObjectiveProgressChange_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnComplete_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Objective objective
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objective);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objective)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective));
		}
	}

	public unsafe CanvasRenderer bgRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgRend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe CanvasRenderer textRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textRend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe CanvasRenderer progressBGrend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressBGrend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressBGrend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe CanvasRenderer barRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barRend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe CanvasRenderer iconRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconRend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe float fadeInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeInProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeInProgress)) = num;
		}
	}

	public unsafe bool fadeOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOut);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOut)) = flag;
		}
	}

	public unsafe float strikeThroughProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikeThroughProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strikeThroughProgress)) = num;
		}
	}

	public unsafe Vector2 desiredAnchoredPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredAnchoredPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredAnchoredPosition)) = vector;
		}
	}

	public unsafe Sprite checkedSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkedSprite);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkedSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe RectTransform progressRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressRect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe FlashController flash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flash);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FlashController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)flashController));
		}
	}

	public unsafe List<CanvasRenderer> childRendereres
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childRendereres);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CanvasRenderer>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childRendereres)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ChecklistButtonController()
	{
		Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ChecklistButtonController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr);
		NativeFieldInfoPtr_objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "objective");
		NativeFieldInfoPtr_bgRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "bgRend");
		NativeFieldInfoPtr_textRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "textRend");
		NativeFieldInfoPtr_progressBGrend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "progressBGrend");
		NativeFieldInfoPtr_barRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "barRend");
		NativeFieldInfoPtr_iconRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "iconRend");
		NativeFieldInfoPtr_fadeInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "fadeInProgress");
		NativeFieldInfoPtr_fadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "fadeOut");
		NativeFieldInfoPtr_strikeThroughProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "strikeThroughProgress");
		NativeFieldInfoPtr_desiredAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "desiredAnchoredPosition");
		NativeFieldInfoPtr_checkedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "checkedSprite");
		NativeFieldInfoPtr_progressRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "progressRect");
		NativeFieldInfoPtr_flash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "flash");
		NativeFieldInfoPtr_childRendereres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, "childRendereres");
		NativeMethodInfoPtr_Setup_Public_Void_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, 100671020);
		NativeMethodInfoPtr_OnObjectiveProgressChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, 100671021);
		NativeMethodInfoPtr_OnComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, 100671022);
		NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, 100671023);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr, 100671024);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 261454, RefRangeEnd = 261456, XrefRangeStart = 261417, XrefRangeEnd = 261454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(Objective newObjective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newObjective);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 261527, RefRangeEnd = 261528, XrefRangeStart = 261456, XrefRangeEnd = 261527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnObjectiveProgressChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnObjectiveProgressChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 261528, RefRangeEnd = 261530, XrefRangeStart = 261528, XrefRangeEnd = 261528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 261528, RefRangeEnd = 261530, XrefRangeStart = 261528, XrefRangeEnd = 261530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261530, XrefRangeEnd = 261538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChecklistButtonController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChecklistButtonController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChecklistButtonController(IntPtr pointer)
		: base(pointer)
	{
	}
}
