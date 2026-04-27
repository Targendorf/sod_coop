using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class LightingPreset : SoCustomComparison
{
	public enum ShadowMode
	{
		everyFrame,
		onEnable,
		onDemand,
		dynamicSystemStatic,
		dynamicSystemSlowerUpdate
	}

	public enum ShadowResolution
	{
		low,
		medium,
		high,
		ultra
	}

	private static readonly IntPtr NativeFieldInfoPtr_coolColours;

	private static readonly IntPtr NativeFieldInfoPtr_warmColours;

	private static readonly IntPtr NativeFieldInfoPtr_defaultIntensity;

	private static readonly IntPtr NativeFieldInfoPtr_defaultRange;

	private static readonly IntPtr NativeFieldInfoPtr_intensityRoomSizeMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_intensityRange;

	private static readonly IntPtr NativeFieldInfoPtr_fadeOnOff;

	private static readonly IntPtr NativeFieldInfoPtr_fadeSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_onByDefault;

	private static readonly IntPtr NativeFieldInfoPtr_fadeDistance;

	private static readonly IntPtr NativeFieldInfoPtr_useBroadcastMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_useOnMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_useInstancedEmissive;

	private static readonly IntPtr NativeFieldInfoPtr_emissionMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_isAtriumLight;

	private static readonly IntPtr NativeFieldInfoPtr_minimumFloors;

	private static readonly IntPtr NativeFieldInfoPtr_cablePrefab;

	private static readonly IntPtr NativeFieldInfoPtr_bulbPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_endBulbPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_heightInterval;

	private static readonly IntPtr NativeFieldInfoPtr_allowCeilingFans;

	private static readonly IntPtr NativeFieldInfoPtr_enableVolumetrics;

	private static readonly IntPtr NativeFieldInfoPtr_atmosphereMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_enableShadows;

	private static readonly IntPtr NativeFieldInfoPtr_shadowMode;

	private static readonly IntPtr NativeFieldInfoPtr_resolution;

	private static readonly IntPtr NativeFieldInfoPtr_shadowFadeDistance;

	private static readonly IntPtr NativeFieldInfoPtr_chanceOfFlicker;

	private static readonly IntPtr NativeFieldInfoPtr_flickerMultiplierRange;

	private static readonly IntPtr NativeFieldInfoPtr_flickerPulseRange;

	private static readonly IntPtr NativeFieldInfoPtr_flickerIntervalRange;

	private static readonly IntPtr NativeFieldInfoPtr_flickerNormalityIntervalRange;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<CityControls.WindowColour> coolColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coolColours);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CityControls.WindowColour>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coolColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CityControls.WindowColour> warmColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warmColours);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CityControls.WindowColour>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warmColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float defaultIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultIntensity)) = num;
		}
	}

	public unsafe float defaultRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultRange)) = num;
		}
	}

	public unsafe float intensityRoomSizeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensityRoomSizeMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensityRoomSizeMultiplier)) = num;
		}
	}

	public unsafe Vector2 intensityRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensityRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensityRange)) = vector;
		}
	}

	public unsafe bool fadeOnOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOnOff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeOnOff)) = flag;
		}
	}

	public unsafe float fadeSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeSpeed)) = num;
		}
	}

	public unsafe bool onByDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onByDefault);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onByDefault)) = flag;
		}
	}

	public unsafe float fadeDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeDistance)) = num;
		}
	}

	public unsafe bool useBroadcastMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBroadcastMaterial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBroadcastMaterial)) = flag;
		}
	}

	public unsafe Material useOnMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOnMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOnMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe bool useInstancedEmissive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInstancedEmissive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInstancedEmissive)) = flag;
		}
	}

	public unsafe float emissionMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emissionMultiplier)) = num;
		}
	}

	public unsafe bool isAtriumLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAtriumLight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAtriumLight)) = flag;
		}
	}

	public unsafe int minimumFloors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumFloors);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumFloors)) = num;
		}
	}

	public unsafe GameObject cablePrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cablePrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cablePrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject bulbPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulbPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulbPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject endBulbPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endBulbPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endBulbPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float heightInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightInterval)) = num;
		}
	}

	public unsafe bool allowCeilingFans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCeilingFans);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCeilingFans)) = flag;
		}
	}

	public unsafe bool enableVolumetrics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableVolumetrics);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableVolumetrics)) = flag;
		}
	}

	public unsafe float atmosphereMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atmosphereMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atmosphereMultiplier)) = num;
		}
	}

	public unsafe bool enableShadows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableShadows);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableShadows)) = flag;
		}
	}

	public unsafe ShadowMode shadowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowMode);
			return *(ShadowMode*)num;
		}
		set
		{
			*(ShadowMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowMode)) = shadowMode;
		}
	}

	public unsafe ShadowResolution resolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution);
			return *(ShadowResolution*)num;
		}
		set
		{
			*(ShadowResolution*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolution)) = shadowResolution;
		}
	}

	public unsafe float shadowFadeDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowFadeDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowFadeDistance)) = num;
		}
	}

	public unsafe float chanceOfFlicker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfFlicker);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfFlicker)) = num;
		}
	}

	public unsafe Vector2 flickerMultiplierRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerMultiplierRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerMultiplierRange)) = vector;
		}
	}

	public unsafe Vector2 flickerPulseRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerPulseRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerPulseRange)) = vector;
		}
	}

	public unsafe Vector2 flickerIntervalRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerIntervalRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerIntervalRange)) = vector;
		}
	}

	public unsafe Vector2 flickerNormalityIntervalRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerNormalityIntervalRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerNormalityIntervalRange)) = vector;
		}
	}

	static LightingPreset()
	{
		Il2CppClassPointerStore<LightingPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LightingPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr);
		NativeFieldInfoPtr_coolColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "coolColours");
		NativeFieldInfoPtr_warmColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "warmColours");
		NativeFieldInfoPtr_defaultIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "defaultIntensity");
		NativeFieldInfoPtr_defaultRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "defaultRange");
		NativeFieldInfoPtr_intensityRoomSizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "intensityRoomSizeMultiplier");
		NativeFieldInfoPtr_intensityRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "intensityRange");
		NativeFieldInfoPtr_fadeOnOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "fadeOnOff");
		NativeFieldInfoPtr_fadeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "fadeSpeed");
		NativeFieldInfoPtr_onByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "onByDefault");
		NativeFieldInfoPtr_fadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "fadeDistance");
		NativeFieldInfoPtr_useBroadcastMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "useBroadcastMaterial");
		NativeFieldInfoPtr_useOnMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "useOnMaterial");
		NativeFieldInfoPtr_useInstancedEmissive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "useInstancedEmissive");
		NativeFieldInfoPtr_emissionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "emissionMultiplier");
		NativeFieldInfoPtr_isAtriumLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "isAtriumLight");
		NativeFieldInfoPtr_minimumFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "minimumFloors");
		NativeFieldInfoPtr_cablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "cablePrefab");
		NativeFieldInfoPtr_bulbPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "bulbPrefab");
		NativeFieldInfoPtr_endBulbPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "endBulbPrefab");
		NativeFieldInfoPtr_heightInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "heightInterval");
		NativeFieldInfoPtr_allowCeilingFans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "allowCeilingFans");
		NativeFieldInfoPtr_enableVolumetrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "enableVolumetrics");
		NativeFieldInfoPtr_atmosphereMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "atmosphereMultiplier");
		NativeFieldInfoPtr_enableShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "enableShadows");
		NativeFieldInfoPtr_shadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "shadowMode");
		NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "resolution");
		NativeFieldInfoPtr_shadowFadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "shadowFadeDistance");
		NativeFieldInfoPtr_chanceOfFlicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "chanceOfFlicker");
		NativeFieldInfoPtr_flickerMultiplierRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "flickerMultiplierRange");
		NativeFieldInfoPtr_flickerPulseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "flickerPulseRange");
		NativeFieldInfoPtr_flickerIntervalRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "flickerIntervalRange");
		NativeFieldInfoPtr_flickerNormalityIntervalRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, "flickerNormalityIntervalRange");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr, 100673975);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329331, XrefRangeEnd = 329341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LightingPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightingPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LightingPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
