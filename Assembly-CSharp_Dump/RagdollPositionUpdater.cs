using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class RagdollPositionUpdater : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_ai;

	private static readonly IntPtr NativeFieldInfoPtr_freeFallForceTimer;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_NewAIController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NewAIController ai
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ai);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NewAIController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ai)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIController));
		}
	}

	public unsafe float freeFallForceTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeFallForceTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeFallForceTimer)) = num;
		}
	}

	static RagdollPositionUpdater()
	{
		Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RagdollPositionUpdater");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr);
		NativeFieldInfoPtr_ai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr, "ai");
		NativeFieldInfoPtr_freeFallForceTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr, "freeFallForceTimer");
		NativeMethodInfoPtr_Setup_Public_Void_NewAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr, 100667672);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr, 100667673);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr, 100667674);
	}

	[CallerCount(73)]
	[CachedScanResults(RefRangeStart = 6766, RefRangeEnd = 6839, XrefRangeStart = 6766, XrefRangeEnd = 6839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(NewAIController newHuman)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHuman);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_NewAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145816, XrefRangeEnd = 145898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RagdollPositionUpdater()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollPositionUpdater>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RagdollPositionUpdater(IntPtr pointer)
		: base(pointer)
	{
	}
}
