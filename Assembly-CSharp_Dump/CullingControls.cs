using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class CullingControls : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_visibleBuildingFoV;

	private static readonly IntPtr NativeFieldInfoPtr_visibleRoomFoV;

	private static readonly IntPtr NativeFieldInfoPtr_fromOutsideToInsideDistanceMax;

	private static readonly IntPtr NativeFieldInfoPtr_fromInsideToInsideDistanceMax;

	private static readonly IntPtr NativeFieldInfoPtr_outsideDistanceMax;

	private static readonly IntPtr NativeFieldInfoPtr_outsideHeightDistanceBoost;

	private static readonly IntPtr NativeFieldInfoPtr_windowCullingRange;

	private static readonly IntPtr NativeFieldInfoPtr_doorCullingRange;

	private static readonly IntPtr NativeFieldInfoPtr_exteriorDuctCullingRange;

	private static readonly IntPtr NativeFieldInfoPtr_ductRoomCullingRange;

	private static readonly IntPtr NativeFieldInfoPtr_airDuctLODThreshold;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CullingControls_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float visibleBuildingFoV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleBuildingFoV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleBuildingFoV)) = num;
		}
	}

	public unsafe float visibleRoomFoV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleRoomFoV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleRoomFoV)) = num;
		}
	}

	public unsafe float fromOutsideToInsideDistanceMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromOutsideToInsideDistanceMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromOutsideToInsideDistanceMax)) = num;
		}
	}

	public unsafe float fromInsideToInsideDistanceMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromInsideToInsideDistanceMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromInsideToInsideDistanceMax)) = num;
		}
	}

	public unsafe float outsideDistanceMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideDistanceMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideDistanceMax)) = num;
		}
	}

	public unsafe Vector2 outsideHeightDistanceBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideHeightDistanceBoost);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideHeightDistanceBoost)) = vector;
		}
	}

	public unsafe float windowCullingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowCullingRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowCullingRange)) = num;
		}
	}

	public unsafe float doorCullingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCullingRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCullingRange)) = num;
		}
	}

	public unsafe float exteriorDuctCullingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorDuctCullingRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorDuctCullingRange)) = num;
		}
	}

	public unsafe float ductRoomCullingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductRoomCullingRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductRoomCullingRange)) = num;
		}
	}

	public unsafe float airDuctLODThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctLODThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctLODThreshold)) = num;
		}
	}

	public unsafe static CullingControls _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<CullingControls>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cullingControls));
		}
	}

	public unsafe static CullingControls Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331136, XrefRangeEnd = 331138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_CullingControls_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CullingControls>(intPtr) : null;
		}
	}

	static CullingControls()
	{
		Il2CppClassPointerStore<CullingControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CullingControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingControls>.NativeClassPtr);
		NativeFieldInfoPtr_visibleBuildingFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "visibleBuildingFoV");
		NativeFieldInfoPtr_visibleRoomFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "visibleRoomFoV");
		NativeFieldInfoPtr_fromOutsideToInsideDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "fromOutsideToInsideDistanceMax");
		NativeFieldInfoPtr_fromInsideToInsideDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "fromInsideToInsideDistanceMax");
		NativeFieldInfoPtr_outsideDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "outsideDistanceMax");
		NativeFieldInfoPtr_outsideHeightDistanceBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "outsideHeightDistanceBoost");
		NativeFieldInfoPtr_windowCullingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "windowCullingRange");
		NativeFieldInfoPtr_doorCullingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "doorCullingRange");
		NativeFieldInfoPtr_exteriorDuctCullingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "exteriorDuctCullingRange");
		NativeFieldInfoPtr_ductRoomCullingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "ductRoomCullingRange");
		NativeFieldInfoPtr_airDuctLODThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "airDuctLODThreshold");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_CullingControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, 100674090);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, 100674091);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, 100674092);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingControls>.NativeClassPtr, 100674093);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331138, XrefRangeEnd = 331175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331175, XrefRangeEnd = 331196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331196, XrefRangeEnd = 331199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CullingControls()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingControls>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CullingControls(IntPtr pointer)
		: base(pointer)
	{
	}
}
