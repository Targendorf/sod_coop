using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class DistrictPreset : SoCustomComparison
{
	public enum AffectStreetAreaLights
	{
		lerp,
		multiply,
		add
	}

	private static readonly IntPtr NativeFieldInfoPtr_generationPriority;

	private static readonly IntPtr NativeFieldInfoPtr_limitToOne;

	private static readonly IntPtr NativeFieldInfoPtr_cityRatio;

	private static readonly IntPtr NativeFieldInfoPtr_minimumSize;

	private static readonly IntPtr NativeFieldInfoPtr_maximumSize;

	private static readonly IntPtr NativeFieldInfoPtr_mustBeOnCoast;

	private static readonly IntPtr NativeFieldInfoPtr_centreWeighting;

	private static readonly IntPtr NativeFieldInfoPtr_aliterationWeight;

	private static readonly IntPtr NativeFieldInfoPtr_prefixOrSuffixChance;

	private static readonly IntPtr NativeFieldInfoPtr_prefixList;

	private static readonly IntPtr NativeFieldInfoPtr_mainChance;

	private static readonly IntPtr NativeFieldInfoPtr_mainNamingList;

	private static readonly IntPtr NativeFieldInfoPtr_suffixList;

	private static readonly IntPtr NativeFieldInfoPtr_minimumDensity;

	private static readonly IntPtr NativeFieldInfoPtr_maximumDensity;

	private static readonly IntPtr NativeFieldInfoPtr_minimumLandValue;

	private static readonly IntPtr NativeFieldInfoPtr_maximumLandValue;

	private static readonly IntPtr NativeFieldInfoPtr_affectEthnicity;

	private static readonly IntPtr NativeFieldInfoPtr_ethnicityFrequencyModifiers;

	private static readonly IntPtr NativeFieldInfoPtr_sceneProfile;

	private static readonly IntPtr NativeFieldInfoPtr_alterStreetAreaLighting;

	private static readonly IntPtr NativeFieldInfoPtr_possibleColours;

	private static readonly IntPtr NativeFieldInfoPtr_lightOperation;

	private static readonly IntPtr NativeFieldInfoPtr_lightAmount;

	private static readonly IntPtr NativeFieldInfoPtr_brightnessModifier;

	private static readonly IntPtr NativeFieldInfoPtr_copyFrom;

	private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 generationPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generationPriority);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generationPriority)) = vector;
		}
	}

	public unsafe bool limitToOne
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToOne);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitToOne)) = flag;
		}
	}

	public unsafe float cityRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityRatio)) = num;
		}
	}

	public unsafe int minimumSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumSize)) = num;
		}
	}

	public unsafe int maximumSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumSize)) = num;
		}
	}

	public unsafe bool mustBeOnCoast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustBeOnCoast);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustBeOnCoast)) = flag;
		}
	}

	public unsafe float centreWeighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centreWeighting);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centreWeighting)) = num;
		}
	}

	public unsafe int aliterationWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aliterationWeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aliterationWeight)) = num;
		}
	}

	public unsafe float prefixOrSuffixChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixOrSuffixChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixOrSuffixChance)) = num;
		}
	}

	public unsafe List<string> prefixList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float mainChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainChance)) = num;
		}
	}

	public unsafe List<string> mainNamingList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainNamingList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainNamingList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> suffixList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suffixList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suffixList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BuildingPreset.Density minimumDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumDensity);
			return *(BuildingPreset.Density*)num;
		}
		set
		{
			*(BuildingPreset.Density*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumDensity)) = density;
		}
	}

	public unsafe BuildingPreset.Density maximumDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumDensity);
			return *(BuildingPreset.Density*)num;
		}
		set
		{
			*(BuildingPreset.Density*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumDensity)) = density;
		}
	}

	public unsafe BuildingPreset.LandValue minimumLandValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLandValue);
			return *(BuildingPreset.LandValue*)num;
		}
		set
		{
			*(BuildingPreset.LandValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumLandValue)) = landValue;
		}
	}

	public unsafe BuildingPreset.LandValue maximumLandValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumLandValue);
			return *(BuildingPreset.LandValue*)num;
		}
		set
		{
			*(BuildingPreset.LandValue*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumLandValue)) = landValue;
		}
	}

	public unsafe bool affectEthnicity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectEthnicity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectEthnicity)) = flag;
		}
	}

	public unsafe List<SocialStatistics.EthnicityFrequency> ethnicityFrequencyModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityFrequencyModifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SocialStatistics.EthnicityFrequency>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityFrequencyModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SessionData.SceneProfile sceneProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfile);
			return *(SessionData.SceneProfile*)num;
		}
		set
		{
			*(SessionData.SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfile)) = sceneProfile;
		}
	}

	public unsafe bool alterStreetAreaLighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alterStreetAreaLighting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alterStreetAreaLighting)) = flag;
		}
	}

	public unsafe List<Color> possibleColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleColours);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AffectStreetAreaLights lightOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOperation);
			return *(AffectStreetAreaLights*)num;
		}
		set
		{
			*(AffectStreetAreaLights*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOperation)) = affectStreetAreaLights;
		}
	}

	public unsafe float lightAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightAmount)) = num;
		}
	}

	public unsafe float brightnessModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightnessModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightnessModifier)) = num;
		}
	}

	public unsafe DistrictPreset copyFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DistrictPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyFrom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)districtPreset));
		}
	}

	static DistrictPreset()
	{
		Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DistrictPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr);
		NativeFieldInfoPtr_generationPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "generationPriority");
		NativeFieldInfoPtr_limitToOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "limitToOne");
		NativeFieldInfoPtr_cityRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "cityRatio");
		NativeFieldInfoPtr_minimumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "minimumSize");
		NativeFieldInfoPtr_maximumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "maximumSize");
		NativeFieldInfoPtr_mustBeOnCoast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "mustBeOnCoast");
		NativeFieldInfoPtr_centreWeighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "centreWeighting");
		NativeFieldInfoPtr_aliterationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "aliterationWeight");
		NativeFieldInfoPtr_prefixOrSuffixChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "prefixOrSuffixChance");
		NativeFieldInfoPtr_prefixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "prefixList");
		NativeFieldInfoPtr_mainChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "mainChance");
		NativeFieldInfoPtr_mainNamingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "mainNamingList");
		NativeFieldInfoPtr_suffixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "suffixList");
		NativeFieldInfoPtr_minimumDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "minimumDensity");
		NativeFieldInfoPtr_maximumDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "maximumDensity");
		NativeFieldInfoPtr_minimumLandValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "minimumLandValue");
		NativeFieldInfoPtr_maximumLandValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "maximumLandValue");
		NativeFieldInfoPtr_affectEthnicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "affectEthnicity");
		NativeFieldInfoPtr_ethnicityFrequencyModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "ethnicityFrequencyModifiers");
		NativeFieldInfoPtr_sceneProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "sceneProfile");
		NativeFieldInfoPtr_alterStreetAreaLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "alterStreetAreaLighting");
		NativeFieldInfoPtr_possibleColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "possibleColours");
		NativeFieldInfoPtr_lightOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "lightOperation");
		NativeFieldInfoPtr_lightAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "lightAmount");
		NativeFieldInfoPtr_brightnessModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "brightnessModifier");
		NativeFieldInfoPtr_copyFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, "copyFrom");
		NativeMethodInfoPtr_CopyFrom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, 100673879);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr, 100673880);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328178, XrefRangeEnd = 328198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyFrom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFrom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328198, XrefRangeEnd = 328225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DistrictPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistrictPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DistrictPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
