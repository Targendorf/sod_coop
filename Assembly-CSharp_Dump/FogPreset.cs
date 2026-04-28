using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class FogPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_sunRiseHour;

	private static readonly IntPtr NativeFieldInfoPtr_sunSetHour;

	private static readonly IntPtr NativeFieldInfoPtr_daytimeSunIntensityCurve;

	private static readonly IntPtr NativeFieldInfoPtr_sunIntensityBooster;

	private static readonly IntPtr NativeFieldInfoPtr_morningSunColour;

	private static readonly IntPtr NativeFieldInfoPtr_middaySunColour;

	private static readonly IntPtr NativeFieldInfoPtr_eveningSunColour;

	private static readonly IntPtr NativeFieldInfoPtr_sunShadowStrengthCurve;

	private static readonly IntPtr NativeFieldInfoPtr_sunVolumetricDimmer;

	private static readonly IntPtr NativeFieldInfoPtr_sunVolumetricShadowDimmer;

	private static readonly IntPtr NativeFieldInfoPtr_exteriorAmbientIntensityCurve;

	private static readonly IntPtr NativeFieldInfoPtr_ambientExteriorBooster;

	private static readonly IntPtr NativeFieldInfoPtr_interiorAmbientIntensityCurve;

	private static readonly IntPtr NativeFieldInfoPtr_ambientInteriorBooster;

	private static readonly IntPtr NativeFieldInfoPtr_skyboxGradientGrading;

	private static readonly IntPtr NativeFieldInfoPtr_skyColourMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_fogColourMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_ambientLightMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_globalLightIntensityMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_fogDistanceRange;

	private static readonly IntPtr NativeFieldInfoPtr_fogDistanceCurve;

	private static readonly IntPtr NativeFieldInfoPtr_maxFogDistanceRange;

	private static readonly IntPtr NativeFieldInfoPtr_maxFogDistanceCurve;

	private static readonly IntPtr NativeFieldInfoPtr_fogAttenuationCurve;

	private static readonly IntPtr NativeFieldInfoPtr_volumetricFogDistanceCurve;

	private static readonly IntPtr NativeFieldInfoPtr_skylineEmissionCurve;

	private static readonly IntPtr NativeFieldInfoPtr_skylineEmissionColor;

	private static readonly IntPtr NativeFieldInfoPtr_monthSnowChanceCurve;

	private static readonly IntPtr NativeFieldInfoPtr_weatherExtremityCurve;

	private static readonly IntPtr NativeFieldInfoPtr_thunderDelay;

	private static readonly IntPtr NativeFieldInfoPtr_monthTempCurve;

	private static readonly IntPtr NativeFieldInfoPtr_dayTempCurve;

	private static readonly IntPtr NativeFieldInfoPtr_NoRainModifier;

	private static readonly IntPtr NativeFieldInfoPtr_NoWindModifier;

	private static readonly IntPtr NativeFieldInfoPtr_NoSnowModifier;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float sunRiseHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunRiseHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunRiseHour)) = num;
		}
	}

	public unsafe float sunSetHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunSetHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunSetHour)) = num;
		}
	}

	public unsafe AnimationCurve daytimeSunIntensityCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daytimeSunIntensityCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daytimeSunIntensityCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float sunIntensityBooster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunIntensityBooster);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunIntensityBooster)) = num;
		}
	}

	public unsafe Color morningSunColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_morningSunColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_morningSunColour)) = color;
		}
	}

	public unsafe Color middaySunColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middaySunColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middaySunColour)) = color;
		}
	}

	public unsafe Color eveningSunColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eveningSunColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eveningSunColour)) = color;
		}
	}

	public unsafe AnimationCurve sunShadowStrengthCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunShadowStrengthCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunShadowStrengthCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve sunVolumetricDimmer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunVolumetricDimmer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunVolumetricDimmer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve sunVolumetricShadowDimmer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunVolumetricShadowDimmer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunVolumetricShadowDimmer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve exteriorAmbientIntensityCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorAmbientIntensityCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorAmbientIntensityCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float ambientExteriorBooster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientExteriorBooster);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientExteriorBooster)) = num;
		}
	}

	public unsafe AnimationCurve interiorAmbientIntensityCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientIntensityCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientIntensityCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float ambientInteriorBooster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientInteriorBooster);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientInteriorBooster)) = num;
		}
	}

	public unsafe List<SessionData.SkyboxGradient> skyboxGradientGrading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxGradientGrading);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SessionData.SkyboxGradient>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxGradientGrading)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float skyColourMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyColourMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyColourMultiplier)) = num;
		}
	}

	public unsafe float fogColourMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColourMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColourMultiplier)) = num;
		}
	}

	public unsafe float ambientLightMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightMultiplier)) = num;
		}
	}

	public unsafe float globalLightIntensityMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalLightIntensityMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalLightIntensityMultiplier)) = num;
		}
	}

	public unsafe Vector2 fogDistanceRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogDistanceRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogDistanceRange)) = vector;
		}
	}

	public unsafe AnimationCurve fogDistanceCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogDistanceCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogDistanceCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Vector2 maxFogDistanceRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFogDistanceRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFogDistanceRange)) = vector;
		}
	}

	public unsafe AnimationCurve maxFogDistanceCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFogDistanceCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFogDistanceCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve fogAttenuationCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogAttenuationCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogAttenuationCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve volumetricFogDistanceCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumetricFogDistanceCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumetricFogDistanceCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve skylineEmissionCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineEmissionCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineEmissionCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Color skylineEmissionColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineEmissionColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineEmissionColor)) = color;
		}
	}

	public unsafe AnimationCurve monthSnowChanceCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSnowChanceCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthSnowChanceCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve weatherExtremityCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherExtremityCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherExtremityCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float thunderDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thunderDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thunderDelay)) = num;
		}
	}

	public unsafe AnimationCurve monthTempCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthTempCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthTempCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve dayTempCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayTempCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayTempCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float NoRainModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoRainModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoRainModifier)) = num;
		}
	}

	public unsafe float NoWindModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoWindModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoWindModifier)) = num;
		}
	}

	public unsafe float NoSnowModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSnowModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoSnowModifier)) = num;
		}
	}

	static FogPreset()
	{
		Il2CppClassPointerStore<FogPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FogPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogPreset>.NativeClassPtr);
		NativeFieldInfoPtr_sunRiseHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "sunRiseHour");
		NativeFieldInfoPtr_sunSetHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "sunSetHour");
		NativeFieldInfoPtr_daytimeSunIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "daytimeSunIntensityCurve");
		NativeFieldInfoPtr_sunIntensityBooster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "sunIntensityBooster");
		NativeFieldInfoPtr_morningSunColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "morningSunColour");
		NativeFieldInfoPtr_middaySunColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "middaySunColour");
		NativeFieldInfoPtr_eveningSunColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "eveningSunColour");
		NativeFieldInfoPtr_sunShadowStrengthCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "sunShadowStrengthCurve");
		NativeFieldInfoPtr_sunVolumetricDimmer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "sunVolumetricDimmer");
		NativeFieldInfoPtr_sunVolumetricShadowDimmer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "sunVolumetricShadowDimmer");
		NativeFieldInfoPtr_exteriorAmbientIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "exteriorAmbientIntensityCurve");
		NativeFieldInfoPtr_ambientExteriorBooster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "ambientExteriorBooster");
		NativeFieldInfoPtr_interiorAmbientIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "interiorAmbientIntensityCurve");
		NativeFieldInfoPtr_ambientInteriorBooster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "ambientInteriorBooster");
		NativeFieldInfoPtr_skyboxGradientGrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "skyboxGradientGrading");
		NativeFieldInfoPtr_skyColourMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "skyColourMultiplier");
		NativeFieldInfoPtr_fogColourMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "fogColourMultiplier");
		NativeFieldInfoPtr_ambientLightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "ambientLightMultiplier");
		NativeFieldInfoPtr_globalLightIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "globalLightIntensityMultiplier");
		NativeFieldInfoPtr_fogDistanceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "fogDistanceRange");
		NativeFieldInfoPtr_fogDistanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "fogDistanceCurve");
		NativeFieldInfoPtr_maxFogDistanceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "maxFogDistanceRange");
		NativeFieldInfoPtr_maxFogDistanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "maxFogDistanceCurve");
		NativeFieldInfoPtr_fogAttenuationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "fogAttenuationCurve");
		NativeFieldInfoPtr_volumetricFogDistanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "volumetricFogDistanceCurve");
		NativeFieldInfoPtr_skylineEmissionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "skylineEmissionCurve");
		NativeFieldInfoPtr_skylineEmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "skylineEmissionColor");
		NativeFieldInfoPtr_monthSnowChanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "monthSnowChanceCurve");
		NativeFieldInfoPtr_weatherExtremityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "weatherExtremityCurve");
		NativeFieldInfoPtr_thunderDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "thunderDelay");
		NativeFieldInfoPtr_monthTempCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "monthTempCurve");
		NativeFieldInfoPtr_dayTempCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "dayTempCurve");
		NativeFieldInfoPtr_NoRainModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "NoRainModifier");
		NativeFieldInfoPtr_NoWindModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "NoWindModifier");
		NativeFieldInfoPtr_NoSnowModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, "NoSnowModifier");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogPreset>.NativeClassPtr, 100673906);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328507, XrefRangeEnd = 328521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FogPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FogPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
