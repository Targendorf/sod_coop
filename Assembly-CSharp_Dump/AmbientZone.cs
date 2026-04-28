using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class AmbientZone : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_mainEvent;

	private static readonly IntPtr NativeFieldInfoPtr_useOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_maxRange;

	private static readonly IntPtr NativeFieldInfoPtr_canPenetrateClosedDoors;

	private static readonly IntPtr NativeFieldInfoPtr_overrideOcclusionModifier;

	private static readonly IntPtr NativeFieldInfoPtr_occlusionUnitVolumeModifier;

	private static readonly IntPtr NativeFieldInfoPtr_isAirDuctAmbience;

	private static readonly IntPtr NativeFieldInfoPtr_passTimeOfDay;

	private static readonly IntPtr NativeFieldInfoPtr_passWalla;

	private static readonly IntPtr NativeFieldInfoPtr_passPlayerInVent;

	private static readonly IntPtr NativeFieldInfoPtr_passPlayerVentExtInt;

	private static readonly IntPtr NativeFieldInfoPtr_passDistanceToVent;

	private static readonly IntPtr NativeFieldInfoPtr_passRain;

	private static readonly IntPtr NativeFieldInfoPtr_passBasement;

	private static readonly IntPtr NativeFieldInfoPtr_passHeightWindSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_passEdgeDistance;

	private static readonly IntPtr NativeFieldInfoPtr_maxWallaRange;

	private static readonly IntPtr NativeFieldInfoPtr_maxWallaCrowd;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AudioEvent mainEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe bool useOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOcclusion)) = flag;
		}
	}

	public unsafe float maxRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRange)) = num;
		}
	}

	public unsafe bool canPenetrateClosedDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateClosedDoors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPenetrateClosedDoors)) = flag;
		}
	}

	public unsafe bool overrideOcclusionModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOcclusionModifier);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideOcclusionModifier)) = flag;
		}
	}

	public unsafe float occlusionUnitVolumeModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionUnitVolumeModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionUnitVolumeModifier)) = num;
		}
	}

	public unsafe bool isAirDuctAmbience
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAirDuctAmbience);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAirDuctAmbience)) = flag;
		}
	}

	public unsafe bool passTimeOfDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passTimeOfDay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passTimeOfDay)) = flag;
		}
	}

	public unsafe bool passWalla
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passWalla);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passWalla)) = flag;
		}
	}

	public unsafe bool passPlayerInVent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passPlayerInVent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passPlayerInVent)) = flag;
		}
	}

	public unsafe bool passPlayerVentExtInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passPlayerVentExtInt);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passPlayerVentExtInt)) = flag;
		}
	}

	public unsafe bool passDistanceToVent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passDistanceToVent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passDistanceToVent)) = flag;
		}
	}

	public unsafe bool passRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passRain);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passRain)) = flag;
		}
	}

	public unsafe bool passBasement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passBasement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passBasement)) = flag;
		}
	}

	public unsafe bool passHeightWindSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passHeightWindSpeed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passHeightWindSpeed)) = flag;
		}
	}

	public unsafe bool passEdgeDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passEdgeDistance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passEdgeDistance)) = flag;
		}
	}

	public unsafe float maxWallaRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWallaRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWallaRange)) = num;
		}
	}

	public unsafe float maxWallaCrowd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWallaCrowd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWallaCrowd)) = num;
		}
	}

	static AmbientZone()
	{
		Il2CppClassPointerStore<AmbientZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmbientZone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr);
		NativeFieldInfoPtr_mainEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "mainEvent");
		NativeFieldInfoPtr_useOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "useOcclusion");
		NativeFieldInfoPtr_maxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "maxRange");
		NativeFieldInfoPtr_canPenetrateClosedDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "canPenetrateClosedDoors");
		NativeFieldInfoPtr_overrideOcclusionModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "overrideOcclusionModifier");
		NativeFieldInfoPtr_occlusionUnitVolumeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "occlusionUnitVolumeModifier");
		NativeFieldInfoPtr_isAirDuctAmbience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "isAirDuctAmbience");
		NativeFieldInfoPtr_passTimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passTimeOfDay");
		NativeFieldInfoPtr_passWalla = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passWalla");
		NativeFieldInfoPtr_passPlayerInVent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passPlayerInVent");
		NativeFieldInfoPtr_passPlayerVentExtInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passPlayerVentExtInt");
		NativeFieldInfoPtr_passDistanceToVent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passDistanceToVent");
		NativeFieldInfoPtr_passRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passRain");
		NativeFieldInfoPtr_passBasement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passBasement");
		NativeFieldInfoPtr_passHeightWindSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passHeightWindSpeed");
		NativeFieldInfoPtr_passEdgeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "passEdgeDistance");
		NativeFieldInfoPtr_maxWallaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "maxWallaRange");
		NativeFieldInfoPtr_maxWallaCrowd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, "maxWallaCrowd");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr, 100673785);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326687, XrefRangeEnd = 326688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AmbientZone()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientZone>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AmbientZone(IntPtr pointer)
		: base(pointer)
	{
	}
}
