using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class FootprintController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_INITIAL_POOL_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_RECYCLED_Y_POSITION;

	private static readonly IntPtr NativeFieldInfoPtr_footprintPool;

	private static readonly IntPtr NativeFieldInfoPtr_footprint;

	private static readonly IntPtr NativeFieldInfoPtr_quad;

	private static readonly IntPtr NativeFieldInfoPtr_projector;

	private static readonly IntPtr NativeFieldInfoPtr_human;

	private static readonly IntPtr NativeFieldInfoPtr_useQuad;

	private static readonly IntPtr NativeFieldInfoPtr_scanProgress;

	private static readonly IntPtr NativeFieldInfoPtr_printConfirmed;

	private static readonly IntPtr NativeFieldInfoPtr_printInteractable;

	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Footprint_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetUseQuad_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetScan_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PrintConfirmed_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitialisePool_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNewFootprint_Public_Static_FootprintController_0;

	private static readonly IntPtr NativeMethodInfoPtr_RecycleFootprint_Public_Static_Void_FootprintController_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int INITIAL_POOL_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INITIAL_POOL_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INITIAL_POOL_SIZE, (void*)(&num));
		}
	}

	public unsafe static float RECYCLED_Y_POSITION
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RECYCLED_Y_POSITION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RECYCLED_Y_POSITION, (void*)(&num));
		}
	}

	public unsafe static Queue<FootprintController> footprintPool
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_footprintPool, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Queue<FootprintController>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_footprintPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe GameplayController.Footprint footprint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameplayController.Footprint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)footprint));
		}
	}

	public unsafe MeshRenderer quad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quad);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quad)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe DecalProjector projector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projector);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalProjector));
		}
	}

	public unsafe Human human
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe bool useQuad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useQuad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useQuad)) = flag;
		}
	}

	public unsafe float scanProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scanProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scanProgress)) = num;
		}
	}

	public unsafe bool printConfirmed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printConfirmed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printConfirmed)) = flag;
		}
	}

	public unsafe InteractableController printInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printInteractable);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractableController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_printInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactableController));
		}
	}

	static FootprintController()
	{
		Il2CppClassPointerStore<FootprintController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FootprintController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintController>.NativeClassPtr);
		NativeFieldInfoPtr_INITIAL_POOL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "INITIAL_POOL_SIZE");
		NativeFieldInfoPtr_RECYCLED_Y_POSITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "RECYCLED_Y_POSITION");
		NativeFieldInfoPtr_footprintPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "footprintPool");
		NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "footprint");
		NativeFieldInfoPtr_quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "quad");
		NativeFieldInfoPtr_projector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "projector");
		NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "human");
		NativeFieldInfoPtr_useQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "useQuad");
		NativeFieldInfoPtr_scanProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "scanProgress");
		NativeFieldInfoPtr_printConfirmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "printConfirmed");
		NativeFieldInfoPtr_printInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, "printInteractable");
		NativeMethodInfoPtr_Setup_Public_Void_Footprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669413);
		NativeMethodInfoPtr_SetUseQuad_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669414);
		NativeMethodInfoPtr_ResetScan_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669415);
		NativeMethodInfoPtr_PrintConfirmed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669416);
		NativeMethodInfoPtr_InitialisePool_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669417);
		NativeMethodInfoPtr_GetNewFootprint_Public_Static_FootprintController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669418);
		NativeMethodInfoPtr_RecycleFootprint_Public_Static_Void_FootprintController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669419);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintController>.NativeClassPtr, 100669420);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206538, RefRangeEnd = 206539, XrefRangeStart = 206498, XrefRangeEnd = 206538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(GameplayController.Footprint newFootprint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFootprint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_Footprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206575, RefRangeEnd = 206576, XrefRangeStart = 206539, XrefRangeEnd = 206575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUseQuad(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUseQuad_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ResetScan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetScan_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206597, RefRangeEnd = 206598, XrefRangeStart = 206576, XrefRangeEnd = 206597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintConfirmed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintConfirmed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206624, RefRangeEnd = 206625, XrefRangeStart = 206598, XrefRangeEnd = 206624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitialisePool()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitialisePool_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 206676, RefRangeEnd = 206677, XrefRangeStart = 206625, XrefRangeEnd = 206676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FootprintController GetNewFootprint()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewFootprint_Public_Static_FootprintController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FootprintController>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 206692, RefRangeEnd = 206695, XrefRangeStart = 206677, XrefRangeEnd = 206692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecycleFootprint(FootprintController footprintController)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)footprintController);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecycleFootprint_Public_Static_Void_FootprintController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FootprintController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FootprintController(IntPtr pointer)
		: base(pointer)
	{
	}
}
