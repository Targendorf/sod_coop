using System;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.UI;

public class SessionData : MonoBehaviour
{
	public enum TimeSpeed
	{
		slow,
		normal,
		fast,
		veryFast,
		simulation
	}

	public enum TimeOfDay
	{
		morning,
		afternoon,
		evening
	}

	public enum WeekDay
	{
		monday,
		tuesday,
		wednesday,
		thursday,
		friday,
		saturday,
		sunday
	}

	public enum Month
	{
		jan,
		feb,
		mar,
		apr,
		may,
		jun,
		jul,
		aug,
		sep,
		oct,
		nov,
		dec
	}

	[System.Serializable]
	public class WetMaterial : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mat;

		private static readonly System.IntPtr NativeFieldInfoPtr_instancedMat;

		private static readonly System.IntPtr NativeFieldInfoPtr_affectedRenderers;

		private static readonly System.IntPtr NativeFieldInfoPtr_affectRain;

		private static readonly System.IntPtr NativeFieldInfoPtr_rainMinMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_rainMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_affectCityWetness;

		private static readonly System.IntPtr NativeFieldInfoPtr_cityWetnessMinMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_cityWetnessMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_cityWetnessLogScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_affectCitySnow;

		private static readonly System.IntPtr NativeFieldInfoPtr_citySnowMinMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_citySnowMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_affectCoatMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_coatMaskMinMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_coatMaskMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_affectWind;

		private static readonly System.IntPtr NativeFieldInfoPtr_windMinMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_windMultiplier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Material mat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe Material instancedMat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancedMat);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancedMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe List<MeshRenderer> affectedRenderers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectedRenderers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectedRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool affectRain
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectRain);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectRain)) = flag;
			}
		}

		public unsafe Vector2 rainMinMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainMinMax);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainMinMax)) = vector;
			}
		}

		public unsafe float rainMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainMultiplier)) = num;
			}
		}

		public unsafe bool affectCityWetness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectCityWetness);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectCityWetness)) = flag;
			}
		}

		public unsafe Vector2 cityWetnessMinMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetnessMinMax);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetnessMinMax)) = vector;
			}
		}

		public unsafe float cityWetnessMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetnessMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetnessMultiplier)) = num;
			}
		}

		public unsafe bool cityWetnessLogScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetnessLogScale);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetnessLogScale)) = flag;
			}
		}

		public unsafe bool affectCitySnow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectCitySnow);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectCitySnow)) = flag;
			}
		}

		public unsafe Vector2 citySnowMinMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnowMinMax);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnowMinMax)) = vector;
			}
		}

		public unsafe float citySnowMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnowMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnowMultiplier)) = num;
			}
		}

		public unsafe bool affectCoatMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectCoatMask);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectCoatMask)) = flag;
			}
		}

		public unsafe Vector2 coatMaskMinMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMaskMinMax);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMaskMinMax)) = vector;
			}
		}

		public unsafe float coatMaskMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMaskMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMaskMultiplier)) = num;
			}
		}

		public unsafe bool affectWind
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectWind);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectWind)) = flag;
			}
		}

		public unsafe Vector2 windMinMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windMinMax);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windMinMax)) = vector;
			}
		}

		public unsafe float windMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windMultiplier)) = num;
			}
		}

		static WetMaterial()
		{
			Il2CppClassPointerStore<WetMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "WetMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr);
			NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "mat");
			NativeFieldInfoPtr_instancedMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "instancedMat");
			NativeFieldInfoPtr_affectedRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "affectedRenderers");
			NativeFieldInfoPtr_affectRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "affectRain");
			NativeFieldInfoPtr_rainMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "rainMinMax");
			NativeFieldInfoPtr_rainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "rainMultiplier");
			NativeFieldInfoPtr_affectCityWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "affectCityWetness");
			NativeFieldInfoPtr_cityWetnessMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "cityWetnessMinMax");
			NativeFieldInfoPtr_cityWetnessMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "cityWetnessMultiplier");
			NativeFieldInfoPtr_cityWetnessLogScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "cityWetnessLogScale");
			NativeFieldInfoPtr_affectCitySnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "affectCitySnow");
			NativeFieldInfoPtr_citySnowMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "citySnowMinMax");
			NativeFieldInfoPtr_citySnowMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "citySnowMultiplier");
			NativeFieldInfoPtr_affectCoatMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "affectCoatMask");
			NativeFieldInfoPtr_coatMaskMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "coatMaskMinMax");
			NativeFieldInfoPtr_coatMaskMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "coatMaskMultiplier");
			NativeFieldInfoPtr_affectWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "affectWind");
			NativeFieldInfoPtr_windMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "windMinMax");
			NativeFieldInfoPtr_windMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, "windMultiplier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr, 100666248);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102189, XrefRangeEnd = 102195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WetMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WetMaterial>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WetMaterial(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum SceneProfile
	{
		outdoors,
		indoors,
		grimey,
		clean,
		corporate,
		cbd,
		chinatown,
		industrial,
		residential,
		warm
	}

	[System.Serializable]
	public class SkyboxGradient : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		private static readonly System.IntPtr NativeFieldInfoPtr_skyColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_fogAlbedo;

		private static readonly System.IntPtr NativeFieldInfoPtr_ambientLightTop;

		private static readonly System.IntPtr NativeFieldInfoPtr_ambientLightMiddle;

		private static readonly System.IntPtr NativeFieldInfoPtr_ambientLightBottom;

		private static readonly System.IntPtr NativeFieldInfoPtr_ambientLightingColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_fogColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_seaEmission;

		private static readonly System.IntPtr NativeFieldInfoPtr_smokeEmission;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SkyboxGradient_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = num;
			}
		}

		public unsafe Color skyColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyColour)) = color;
			}
		}

		public unsafe Color fogAlbedo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogAlbedo);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogAlbedo)) = color;
			}
		}

		public unsafe Color ambientLightTop
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightTop);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightTop)) = color;
			}
		}

		public unsafe Color ambientLightMiddle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightMiddle);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightMiddle)) = color;
			}
		}

		public unsafe Color ambientLightBottom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightBottom);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightBottom)) = color;
			}
		}

		public unsafe Color ambientLightingColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightingColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ambientLightingColour)) = color;
			}
		}

		public unsafe Color fogColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogColour)) = color;
			}
		}

		public unsafe Color seaEmission
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaEmission);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaEmission)) = color;
			}
		}

		public unsafe Color smokeEmission
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smokeEmission);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smokeEmission)) = color;
			}
		}

		static SkyboxGradient()
		{
			Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "SkyboxGradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr);
			NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "time");
			NativeFieldInfoPtr_skyColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "skyColour");
			NativeFieldInfoPtr_fogAlbedo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "fogAlbedo");
			NativeFieldInfoPtr_ambientLightTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "ambientLightTop");
			NativeFieldInfoPtr_ambientLightMiddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "ambientLightMiddle");
			NativeFieldInfoPtr_ambientLightBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "ambientLightBottom");
			NativeFieldInfoPtr_ambientLightingColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "ambientLightingColour");
			NativeFieldInfoPtr_fogColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "fogColour");
			NativeFieldInfoPtr_seaEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "seaEmission");
			NativeFieldInfoPtr_smokeEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, "smokeEmission");
			NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SkyboxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, 100666249);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr, 100666250);
		}

		[CallerCount(0)]
		public unsafe virtual int CompareTo(SkyboxGradient otherObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SkyboxGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe SkyboxGradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyboxGradient>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SkyboxGradient(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class TelevisionChannel : Il2CppSystem.Object
	{
		[ObfuscatedName("SessionData+TelevisionChannel+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_apply;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ProcessDynamicShow_b__0_Internal_Boolean_DynamicShowParam_0;

			public unsafe BroadcastPreset.DynamicShowParam apply
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apply);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicShowParam>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apply)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicShowParam));
				}
			}

			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr);
				NativeFieldInfoPtr_apply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, "apply");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100666256);
				NativeMethodInfoPtr__ProcessDynamicShow_b__0_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100666257);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _ProcessDynamicShow_b__0(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProcessDynamicShow_b__0_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass21_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("SessionData+TelevisionChannel+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_test;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_DynamicShowParam_0;

			public unsafe BroadcastPreset.DynamicShowParam test
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_test);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicShowParam>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_test)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicShowParam));
				}
			}

			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr);
				NativeFieldInfoPtr_test = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, "test");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, 100666258);
				NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr, 100666259);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass23_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__0(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass23_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("SessionData+TelevisionChannel+<>c__DisplayClass23_1")]
		public sealed class __c__DisplayClass23_1 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_test;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__1_Internal_Boolean_DynamicShowParam_0;

			public unsafe BroadcastPreset.DynamicShowParam test
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_test);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicShowParam>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_test)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicShowParam));
				}
			}

			static __c__DisplayClass23_1()
			{
				Il2CppClassPointerStore<__c__DisplayClass23_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "<>c__DisplayClass23_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass23_1>.NativeClassPtr);
				NativeFieldInfoPtr_test = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass23_1>.NativeClassPtr, "test");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_1>.NativeClassPtr, 100666260);
				NativeMethodInfoPtr__GetEvent_b__1_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_1>.NativeClassPtr, 100666261);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass23_1>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__1(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__1_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass23_1(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("SessionData+TelevisionChannel+<>c__DisplayClass23_2")]
		public sealed class __c__DisplayClass23_2 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_test;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__2_Internal_Boolean_DynamicShowParam_0;

			public unsafe BroadcastPreset.DynamicShowParam test
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_test);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicShowParam>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_test)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicShowParam));
				}
			}

			static __c__DisplayClass23_2()
			{
				Il2CppClassPointerStore<__c__DisplayClass23_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "<>c__DisplayClass23_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass23_2>.NativeClassPtr);
				NativeFieldInfoPtr_test = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass23_2>.NativeClassPtr, "test");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_2>.NativeClassPtr, 100666262);
				NativeMethodInfoPtr__GetEvent_b__2_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass23_2>.NativeClassPtr, 100666263);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass23_2>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__2(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__2_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass23_2(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[System.Serializable]
		[ObfuscatedName("SessionData+TelevisionChannel+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_3;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_4;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_5;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_6;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_7;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_8;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_10;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_11;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_12;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_13;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_14;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_15;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_16;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_3_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_4_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_5_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_6_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_7_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_8_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_9_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_10_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_11_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_12_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_13_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_14_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_15_Internal_Boolean_DynamicShowParam_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__23_16_Internal_Boolean_DynamicShowParam_0;

			public unsafe static __c __9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_3
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_4
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_4, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_5
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_5, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_6
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_6, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_6, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_7
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_7, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_7, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_8
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_8, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_8, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_10
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_10, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_11
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_11, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_11, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_12
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_12, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_12, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_13
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_13, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_13, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_14
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_14, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_14, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_15
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_15, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_15, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			public unsafe static Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam> __9__23_16
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__23_16, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<BroadcastPreset.DynamicShowParam>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__23_16, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__23_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_3");
				NativeFieldInfoPtr___9__23_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_4");
				NativeFieldInfoPtr___9__23_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_5");
				NativeFieldInfoPtr___9__23_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_6");
				NativeFieldInfoPtr___9__23_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_7");
				NativeFieldInfoPtr___9__23_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_8");
				NativeFieldInfoPtr___9__23_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_9");
				NativeFieldInfoPtr___9__23_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_10");
				NativeFieldInfoPtr___9__23_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_11");
				NativeFieldInfoPtr___9__23_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_12");
				NativeFieldInfoPtr___9__23_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_13");
				NativeFieldInfoPtr___9__23_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_14");
				NativeFieldInfoPtr___9__23_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_15");
				NativeFieldInfoPtr___9__23_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__23_16");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666265);
				NativeMethodInfoPtr__GetEvent_b__23_3_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666266);
				NativeMethodInfoPtr__GetEvent_b__23_4_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666267);
				NativeMethodInfoPtr__GetEvent_b__23_5_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666268);
				NativeMethodInfoPtr__GetEvent_b__23_6_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666269);
				NativeMethodInfoPtr__GetEvent_b__23_7_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666270);
				NativeMethodInfoPtr__GetEvent_b__23_8_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666271);
				NativeMethodInfoPtr__GetEvent_b__23_9_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666272);
				NativeMethodInfoPtr__GetEvent_b__23_10_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666273);
				NativeMethodInfoPtr__GetEvent_b__23_11_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666274);
				NativeMethodInfoPtr__GetEvent_b__23_12_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666275);
				NativeMethodInfoPtr__GetEvent_b__23_13_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666276);
				NativeMethodInfoPtr__GetEvent_b__23_14_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666277);
				NativeMethodInfoPtr__GetEvent_b__23_15_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666278);
				NativeMethodInfoPtr__GetEvent_b__23_16_Internal_Boolean_DynamicShowParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666279);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_3(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_3_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_4(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_4_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_5(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_5_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_6(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_6_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_7(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_7_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_8(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_8_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_9(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_9_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_10(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_10_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_11(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_11_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_12(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_12_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_13(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_13_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_14(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_14_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_15(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_15_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe bool _GetEvent_b__23_16(BroadcastPreset.DynamicShowParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetEvent_b__23_16_Internal_Boolean_DynamicShowParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_currentBroadcastSchedule;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentShow;

		private static readonly System.IntPtr NativeFieldInfoPtr_broadcastMaterialInstanced;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentScheduleIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentShowProgressSeconds;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentShowImageProgress;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentShowEventDescription;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentShowAudioLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentShowImageLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentImageIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_crowdParam;

		private static readonly System.IntPtr NativeFieldInfoPtr_dynamicShowActive;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentDynamicClip;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentDynamicEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentDynamicAudio;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentClipProgressSeconds;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentClipAudioLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentClipEventDescription;

		private static readonly System.IntPtr NativeFieldInfoPtr_clipIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_appliedParameters;

		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTelevisionBroadcast_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDynamicShow_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetNextClip_Public_DynamicClip_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEvent_Public_DynamicClipEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe BroadcastSchedule currentBroadcastSchedule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBroadcastSchedule);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastSchedule>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBroadcastSchedule)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)broadcastSchedule));
			}
		}

		public unsafe BroadcastPreset currentShow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShow);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)broadcastPreset));
			}
		}

		public unsafe Material broadcastMaterialInstanced
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_broadcastMaterialInstanced);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_broadcastMaterialInstanced)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe int currentScheduleIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentScheduleIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentScheduleIndex)) = num;
			}
		}

		public unsafe float currentShowProgressSeconds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowProgressSeconds);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowProgressSeconds)) = num;
			}
		}

		public unsafe float currentShowImageProgress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowImageProgress);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowImageProgress)) = num;
			}
		}

		public unsafe EventDescription currentShowEventDescription
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowEventDescription);
				return *(EventDescription*)num;
			}
			set
			{
				*(EventDescription*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowEventDescription)) = eventDescription;
			}
		}

		public unsafe int currentShowAudioLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowAudioLength);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowAudioLength)) = num;
			}
		}

		public unsafe int currentShowImageLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowImageLength);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentShowImageLength)) = num;
			}
		}

		public unsafe int currentImageIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentImageIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentImageIndex)) = num;
			}
		}

		public unsafe float crowdParam
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crowdParam);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crowdParam)) = num;
			}
		}

		public unsafe bool dynamicShowActive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicShowActive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicShowActive)) = flag;
			}
		}

		public unsafe BroadcastPreset.DynamicClip currentDynamicClip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDynamicClip);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicClip>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDynamicClip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicClip));
			}
		}

		public unsafe BroadcastPreset.DynamicClipEvent currentDynamicEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDynamicEvent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicClipEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDynamicEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicClipEvent));
			}
		}

		public unsafe AudioEvent currentDynamicAudio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDynamicAudio);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentDynamicAudio)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe float currentClipProgressSeconds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentClipProgressSeconds);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentClipProgressSeconds)) = num;
			}
		}

		public unsafe int currentClipAudioLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentClipAudioLength);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentClipAudioLength)) = num;
			}
		}

		public unsafe EventDescription currentClipEventDescription
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentClipEventDescription);
				return *(EventDescription*)num;
			}
			set
			{
				*(EventDescription*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentClipEventDescription)) = eventDescription;
			}
		}

		public unsafe int clipIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipIndex)) = num;
			}
		}

		public unsafe List<BroadcastPreset.DynamicShowParam> appliedParameters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedParameters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BroadcastPreset.DynamicShowParam>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedParameters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static TelevisionChannel()
		{
			Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "TelevisionChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr);
			NativeFieldInfoPtr_currentBroadcastSchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentBroadcastSchedule");
			NativeFieldInfoPtr_currentShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentShow");
			NativeFieldInfoPtr_broadcastMaterialInstanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "broadcastMaterialInstanced");
			NativeFieldInfoPtr_currentScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentScheduleIndex");
			NativeFieldInfoPtr_currentShowProgressSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentShowProgressSeconds");
			NativeFieldInfoPtr_currentShowImageProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentShowImageProgress");
			NativeFieldInfoPtr_currentShowEventDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentShowEventDescription");
			NativeFieldInfoPtr_currentShowAudioLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentShowAudioLength");
			NativeFieldInfoPtr_currentShowImageLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentShowImageLength");
			NativeFieldInfoPtr_currentImageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentImageIndex");
			NativeFieldInfoPtr_crowdParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "crowdParam");
			NativeFieldInfoPtr_dynamicShowActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "dynamicShowActive");
			NativeFieldInfoPtr_currentDynamicClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentDynamicClip");
			NativeFieldInfoPtr_currentDynamicEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentDynamicEvent");
			NativeFieldInfoPtr_currentDynamicAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentDynamicAudio");
			NativeFieldInfoPtr_currentClipProgressSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentClipProgressSeconds");
			NativeFieldInfoPtr_currentClipAudioLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentClipAudioLength");
			NativeFieldInfoPtr_currentClipEventDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "currentClipEventDescription");
			NativeFieldInfoPtr_clipIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "clipIndex");
			NativeFieldInfoPtr_appliedParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, "appliedParameters");
			NativeMethodInfoPtr_ProcessTelevisionBroadcast_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, 100666251);
			NativeMethodInfoPtr_ProcessDynamicShow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, 100666252);
			NativeMethodInfoPtr_GetNextClip_Public_DynamicClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, 100666253);
			NativeMethodInfoPtr_GetEvent_Public_DynamicClipEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, 100666254);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr, 100666255);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102255, RefRangeEnd = 102256, XrefRangeStart = 102195, XrefRangeEnd = 102255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTelevisionBroadcast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessTelevisionBroadcast_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102455, RefRangeEnd = 102456, XrefRangeStart = 102256, XrefRangeEnd = 102455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDynamicShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessDynamicShow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102456, XrefRangeEnd = 102458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BroadcastPreset.DynamicClip GetNextClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextClip_Public_DynamicClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicClip>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102768, RefRangeEnd = 102769, XrefRangeStart = 102458, XrefRangeEnd = 102768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BroadcastPreset.DynamicClipEvent GetEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEvent_Public_DynamicClipEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BroadcastPreset.DynamicClipEvent>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102775, RefRangeEnd = 102776, XrefRangeStart = 102769, XrefRangeEnd = 102775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TelevisionChannel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TelevisionChannel>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TelevisionChannel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum PhysicsSyncType
	{
		now,
		onPlayerMovement,
		both
	}

	public sealed class OnPauseUnPause : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnPauseUnPause()
		{
			Il2CppClassPointerStore<OnPauseUnPause>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "OnPauseUnPause");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPauseUnPause>.NativeClassPtr, 100666280);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPauseUnPause>.NativeClassPtr, 100666281);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPauseUnPause>.NativeClassPtr, 100666282);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPauseUnPause>.NativeClassPtr, 100666283);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 10700, RefRangeEnd = 10709, XrefRangeStart = 10700, XrefRangeEnd = 10709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnPauseUnPause(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnPauseUnPause>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(bool openDesktopMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&openDesktopMode);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102776, XrefRangeEnd = 102780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(bool openDesktopMode, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&openDesktopMode);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OnPauseUnPause(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnPauseUnPause(System.Action<bool> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnPauseUnPause>((System.Delegate)P_0);
		}

		public static OnPauseUnPause operator +(OnPauseUnPause P_0, OnPauseUnPause P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnPauseUnPause>();
		}

		public static OnPauseUnPause operator -(OnPauseUnPause P_0, OnPauseUnPause P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnPauseUnPause>();
			}
			return (OnPauseUnPause)obj;
		}
	}

	public sealed class WeatherChange : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static WeatherChange()
		{
			Il2CppClassPointerStore<WeatherChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "WeatherChange");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherChange>.NativeClassPtr, 100666284);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherChange>.NativeClassPtr, 100666285);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherChange>.NativeClassPtr, 100666286);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherChange>.NativeClassPtr, 100666287);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherChange(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherChange>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11711, RefRangeEnd = 11712, XrefRangeStart = 11711, XrefRangeEnd = 11712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WeatherChange(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator WeatherChange(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<WeatherChange>((System.Delegate)P_0);
		}

		public static WeatherChange operator +(WeatherChange P_0, WeatherChange P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<WeatherChange>();
		}

		public static WeatherChange operator -(WeatherChange P_0, WeatherChange P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<WeatherChange>();
			}
			return (WeatherChange)obj;
		}
	}

	public sealed class HourChange : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static HourChange()
		{
			Il2CppClassPointerStore<HourChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "HourChange");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HourChange>.NativeClassPtr, 100666288);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HourChange>.NativeClassPtr, 100666289);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HourChange>.NativeClassPtr, 100666290);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HourChange>.NativeClassPtr, 100666291);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HourChange(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HourChange>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11711, RefRangeEnd = 11712, XrefRangeStart = 11711, XrefRangeEnd = 11712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HourChange(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator HourChange(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<HourChange>((System.Delegate)P_0);
		}

		public static HourChange operator +(HourChange P_0, HourChange P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<HourChange>();
		}

		public static HourChange operator -(HourChange P_0, HourChange P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<HourChange>();
			}
			return (HourChange)obj;
		}
	}

	public sealed class TutorialNotificationChange : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static TutorialNotificationChange()
		{
			Il2CppClassPointerStore<TutorialNotificationChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "TutorialNotificationChange");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialNotificationChange>.NativeClassPtr, 100666292);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialNotificationChange>.NativeClassPtr, 100666293);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialNotificationChange>.NativeClassPtr, 100666294);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialNotificationChange>.NativeClassPtr, 100666295);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialNotificationChange(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialNotificationChange>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11711, RefRangeEnd = 11712, XrefRangeStart = 11711, XrefRangeEnd = 11712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TutorialNotificationChange(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator TutorialNotificationChange(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<TutorialNotificationChange>((System.Delegate)P_0);
		}

		public static TutorialNotificationChange operator +(TutorialNotificationChange P_0, TutorialNotificationChange P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<TutorialNotificationChange>();
		}

		public static TutorialNotificationChange operator -(TutorialNotificationChange P_0, TutorialNotificationChange P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<TutorialNotificationChange>();
			}
			return (TutorialNotificationChange)obj;
		}
	}

	[ObfuscatedName("SessionData+<>c__DisplayClass169_0")]
	public sealed class __c__DisplayClass169_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newProfile;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetSceneProfile_b__0_Internal_Boolean_PPProfile_0;

		public unsafe SceneProfile newProfile
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newProfile);
				return *(SceneProfile*)num;
			}
			set
			{
				*(SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newProfile)) = sceneProfile;
			}
		}

		static __c__DisplayClass169_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "<>c__DisplayClass169_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr);
			NativeFieldInfoPtr_newProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr, "newProfile");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr, 100666296);
			NativeMethodInfoPtr__SetSceneProfile_b__0_Internal_Boolean_PPProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr, 100666297);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass169_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _SetSceneProfile_b__0(CityControls.PPProfile item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetSceneProfile_b__0_Internal_Boolean_PPProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass169_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("SessionData+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__170_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__214_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__170_0_Internal_Boolean_FileInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetDisplayTutorialText_b__214_0_Internal_Boolean_GameSetting_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FileInfo> __9__170_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__170_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FileInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__170_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<PlayerPrefsController.GameSetting> __9__214_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__214_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<PlayerPrefsController.GameSetting>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__214_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__170_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__170_0");
			NativeFieldInfoPtr___9__214_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__214_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666299);
			NativeMethodInfoPtr__Update_b__170_0_Internal_Boolean_FileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666300);
			NativeMethodInfoPtr__SetDisplayTutorialText_b__214_0_Internal_Boolean_GameSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666301);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102780, XrefRangeEnd = 102783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Update_b__170_0(FileInfo item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__170_0_Internal_Boolean_FileInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102783, XrefRangeEnd = 102787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetDisplayTutorialText_b__214_0(PlayerPrefsController.GameSetting item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetDisplayTutorialText_b__214_0_Internal_Boolean_GameSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_isFloorEdit;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDialogEdit;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCityEdit;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTestScene;

	private static readonly System.IntPtr NativeFieldInfoPtr_dirtyScene;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDecorEdit;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableUserPause;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFirstPersonMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_play;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableTutorialText;

	private static readonly System.IntPtr NativeFieldInfoPtr_tutorialTextTriggered;

	private static readonly System.IntPtr NativeFieldInfoPtr_startedGame;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseUnpauseDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkOscillatorX;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkOscillatorY;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkOscillation;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverOscillatorX;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverOscillatorY;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverOscillation;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkLensProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_headacheProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunShadowFrameCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameTimeDouble;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameTimePassedThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevHour;

	private static readonly System.IntPtr NativeFieldInfoPtr_watchChangeCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_decimalClock;

	private static readonly System.IntPtr NativeFieldInfoPtr_decimalClockDouble;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTimeSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTimeMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_behaviourDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeOfDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_day;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_month;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysInMonths;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_publicYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_leapYearCycle;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameTimeLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentLightning;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredLightning;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFog;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredFog;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherChangeTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthTempMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_temperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightningTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_windDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_windForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearRainSheet;

	private static readonly System.IntPtr NativeFieldInfoPtr_farRainSheet;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearRainAlpha1Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearRainAlpha2Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearRainSpeedThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearRainXTile1Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearRainXTile2Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_farRainAlpha1Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_farRainAlpha2Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_farRainSpeedThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_farRainXTile1Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_farRainXTile2Threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_particalRainCountThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_particalSnowCountThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityWetness;

	private static readonly System.IntPtr NativeFieldInfoPtr_citySnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_wetMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherMaterialsReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_customPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainyWindowFrontageObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoPauseTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoResetTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitchPulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightswitchPulseMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSceneProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredSceneProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_gradientSky;

	private static readonly System.IntPtr NativeFieldInfoPtr_volFog;

	private static readonly System.IntPtr NativeFieldInfoPtr_dof;

	private static readonly System.IntPtr NativeFieldInfoPtr_vignette;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionBlur;

	private static readonly System.IntPtr NativeFieldInfoPtr_grain;

	private static readonly System.IntPtr NativeFieldInfoPtr_toneMapping;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloom;

	private static readonly System.IntPtr NativeFieldInfoPtr_chromaticAberration;

	private static readonly System.IntPtr NativeFieldInfoPtr_lgg;

	private static readonly System.IntPtr NativeFieldInfoPtr_colour;

	private static readonly System.IntPtr NativeFieldInfoPtr_lensDistort;

	private static readonly System.IntPtr NativeFieldInfoPtr_exposure;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelMixer;

	private static readonly System.IntPtr NativeFieldInfoPtr_ssReflection;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyboxGradientIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromSkyboxColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_toSkyboxColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeElevators;

	private static readonly System.IntPtr NativeFieldInfoPtr_particleSystems;

	private static readonly System.IntPtr NativeFieldInfoPtr_broadcastMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_televisionChannels;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseText;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseLensFlare;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseButtonImg;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalSpeedButtonImg;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSpeedButtonImg;

	private static readonly System.IntPtr NativeFieldInfoPtr_veryFastSpeedButtonImg;

	private static readonly System.IntPtr NativeFieldInfoPtr_newWatchTimeText;

	private static readonly System.IntPtr NativeFieldInfoPtr_newWatchDateText;

	private static readonly System.IntPtr NativeFieldInfoPtr_clockText;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayText;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseButtonIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_playIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_interfaceActiveAudio;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugDecimalRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugDayList;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnloadPipes;

	private static readonly System.IntPtr NativeFieldInfoPtr_pipesToUnload;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPauseChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnWeatherChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnHourChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnTutorialNotificationChange;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SessionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnPauseChange_Public_add_Void_OnPauseUnPause_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnPauseChange_Public_rem_Void_OnPauseUnPause_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnWeatherChange_Public_add_Void_WeatherChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnWeatherChange_Public_rem_Void_WeatherChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnHourChange_Public_add_Void_HourChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnHourChange_Public_rem_Void_HourChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnTutorialNotificationChange_Public_add_Void_TutorialNotificationChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnTutorialNotificationChange_Public_rem_Void_TutorialNotificationChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTelevisionChannels_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartTestScene_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGameTime_Public_Void_Int32_Int32_Int32_Int32_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGameTime_Public_Void_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSkyboxGraidentTargets_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeSpeed_Public_Void_TimeSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameSpeedMotionBlurModifier_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSceneProfile_Public_Void_SceneProfile_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGameTimerText_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndDemo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteSyncPhysics_Public_Void_PhysicsSyncType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteWeatherChange_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteWetnessChange_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteWindChange_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeatherAffectedMaterial_Public_Material_Material_MeshRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteLightningStrike_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSceneVisuals_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnablePause_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_WeekDay_byref_Month_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_WeekDay_byref_Int32_byref_Month_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseGameTime_Public_Single_Single_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatDecimal24H_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatMinutes24H_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloatMinutes12H_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecimalToClockString_Public_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecimalToTimeLengthString_Public_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameTimeToClock24String_Public_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameTimeToClock12String_Public_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinutesToClockString_Public_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentTimeString_Public_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShortDateString_Public_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentShortDateString_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LongDateString_Public_String_Single_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentLongDateString_Public_String_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeString_Public_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeStringOnDay_Public_String_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeAndDate_Public_String_Single_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDay_Public_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextOrPreviousGameTimeForThisHour_Public_Single_byref_List_1_WeekDay_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextOrPreviousGameTimeForThisHour_Public_Single_Single_Single_WeekDay_byref_List_1_WeekDay_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeDifference_Public_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTimes_Public_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WeekdayFromInt_Public_WeekDay_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MonthFromInt_Public_Month_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWeather_Public_Void_Single_Single_Single_Single_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWatchText_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWatchDay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TogglePause_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PauseGame_Public_Void_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResumeGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplayTutorialText_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TutorialTrigger_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTutorialNotifications_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteUnloadPipes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSceneExit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugPreviousOrLastTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isFloorEdit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFloorEdit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFloorEdit)) = flag;
		}
	}

	public unsafe bool isDialogEdit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDialogEdit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDialogEdit)) = flag;
		}
	}

	public unsafe bool isCityEdit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCityEdit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCityEdit)) = flag;
		}
	}

	public unsafe bool isTestScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTestScene);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTestScene)) = flag;
		}
	}

	public unsafe bool dirtyScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtyScene);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtyScene)) = flag;
		}
	}

	public unsafe bool isDecorEdit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecorEdit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDecorEdit)) = flag;
		}
	}

	public unsafe bool enableUserPause
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableUserPause);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableUserPause)) = flag;
		}
	}

	public unsafe bool enableFirstPersonMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFirstPersonMap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFirstPersonMap)) = flag;
		}
	}

	public unsafe bool play
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_play);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_play)) = flag;
		}
	}

	public unsafe bool enableTutorialText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTutorialText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTutorialText)) = flag;
		}
	}

	public unsafe HashSet<string> tutorialTextTriggered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialTextTriggered);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorialTextTriggered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe bool startedGame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startedGame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startedGame)) = flag;
		}
	}

	public unsafe int pauseUnpauseDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseUnpauseDelay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseUnpauseDelay)) = num;
		}
	}

	public unsafe float drunkOscillatorX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillatorX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillatorX)) = num;
		}
	}

	public unsafe float drunkOscillatorY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillatorY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillatorY)) = num;
		}
	}

	public unsafe Vector2 drunkOscillation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillation);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkOscillation)) = vector;
		}
	}

	public unsafe float shiverOscillatorX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillatorX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillatorX)) = num;
		}
	}

	public unsafe float shiverOscillatorY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillatorY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillatorY)) = num;
		}
	}

	public unsafe float shiverProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverProgress)) = num;
		}
	}

	public unsafe Vector2 shiverOscillation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillation);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverOscillation)) = vector;
		}
	}

	public unsafe float drunkLensProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensProgress)) = num;
		}
	}

	public unsafe float headacheProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheProgress)) = num;
		}
	}

	public unsafe int sunShadowFrameCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunShadowFrameCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunShadowFrameCounter)) = num;
		}
	}

	public unsafe float gameTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTime)) = num;
		}
	}

	public unsafe double gameTimeDouble
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimeDouble);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimeDouble)) = num;
		}
	}

	public unsafe double gameTimePassedThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimePassedThisFrame);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimePassedThisFrame)) = num;
		}
	}

	public unsafe int prevHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevHour);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevHour)) = num;
		}
	}

	public unsafe double watchChangeCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_watchChangeCounter);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_watchChangeCounter)) = num;
		}
	}

	public unsafe float decimalClock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decimalClock);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decimalClock)) = num;
		}
	}

	public unsafe double decimalClockDouble
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decimalClockDouble);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decimalClockDouble)) = num;
		}
	}

	public unsafe TimeSpeed currentTimeSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTimeSpeed);
			return *(TimeSpeed*)num;
		}
		set
		{
			*(TimeSpeed*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTimeSpeed)) = timeSpeed;
		}
	}

	public unsafe float currentTimeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTimeMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTimeMultiplier)) = num;
		}
	}

	public unsafe float behaviourDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviourDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviourDelay)) = num;
		}
	}

	public unsafe TimeOfDay timeOfDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOfDay);
			return *(TimeOfDay*)num;
		}
		set
		{
			*(TimeOfDay*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOfDay)) = timeOfDay;
		}
	}

	public unsafe int dayInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayInt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayInt)) = num;
		}
	}

	public unsafe WeekDay day
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_day);
			return *(WeekDay*)num;
		}
		set
		{
			*(WeekDay*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_day)) = weekDay;
		}
	}

	public unsafe int dateInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateInt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateInt)) = num;
		}
	}

	public unsafe Month month
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_month);
			return *(Month*)num;
		}
		set
		{
			*(Month*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_month)) = month;
		}
	}

	public unsafe int monthInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthInt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthInt)) = num;
		}
	}

	public unsafe List<int> daysInMonths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysInMonths);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysInMonths)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int yearInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearInt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearInt)) = num;
		}
	}

	public unsafe int publicYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicYear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicYear)) = num;
		}
	}

	public unsafe int leapYearCycle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leapYearCycle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leapYearCycle)) = num;
		}
	}

	public unsafe float gameTimeLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimeLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimeLimit)) = num;
		}
	}

	public unsafe float currentRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRain);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRain)) = num;
		}
	}

	public unsafe float desiredRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredRain);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredRain)) = num;
		}
	}

	public unsafe float currentWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWind);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWind)) = num;
		}
	}

	public unsafe float desiredWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredWind);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredWind)) = num;
		}
	}

	public unsafe float currentSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSnow)) = num;
		}
	}

	public unsafe float desiredSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSnow)) = num;
		}
	}

	public unsafe float currentLightning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLightning);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLightning)) = num;
		}
	}

	public unsafe float desiredLightning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredLightning);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredLightning)) = num;
		}
	}

	public unsafe float currentFog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFog);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFog)) = num;
		}
	}

	public unsafe float desiredFog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredFog);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredFog)) = num;
		}
	}

	public unsafe float transitionSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeed)) = num;
		}
	}

	public unsafe float weatherChangeTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherChangeTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherChangeTimer)) = num;
		}
	}

	public unsafe float monthTempMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthTempMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthTempMultiplier)) = num;
		}
	}

	public unsafe float temperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperature)) = num;
		}
	}

	public unsafe float lightningTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightningTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightningTimer)) = num;
		}
	}

	public unsafe Vector3 windDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windDirection)) = vector;
		}
	}

	public unsafe float windForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windForce)) = num;
		}
	}

	public unsafe float dayProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayProgress)) = num;
		}
	}

	public unsafe RainSheetController nearRainSheet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainSheet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RainSheetController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainSheet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rainSheetController));
		}
	}

	public unsafe RainSheetController farRainSheet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainSheet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RainSheetController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainSheet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rainSheetController));
		}
	}

	public unsafe Vector2 nearRainAlpha1Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainAlpha1Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainAlpha1Threshold)) = vector;
		}
	}

	public unsafe Vector2 nearRainAlpha2Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainAlpha2Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainAlpha2Threshold)) = vector;
		}
	}

	public unsafe Vector2 nearRainSpeedThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainSpeedThreshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainSpeedThreshold)) = vector;
		}
	}

	public unsafe Vector2 nearRainXTile1Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainXTile1Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainXTile1Threshold)) = vector;
		}
	}

	public unsafe Vector2 nearRainXTile2Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainXTile2Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearRainXTile2Threshold)) = vector;
		}
	}

	public unsafe Vector2 farRainAlpha1Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainAlpha1Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainAlpha1Threshold)) = vector;
		}
	}

	public unsafe Vector2 farRainAlpha2Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainAlpha2Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainAlpha2Threshold)) = vector;
		}
	}

	public unsafe Vector2 farRainSpeedThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainSpeedThreshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainSpeedThreshold)) = vector;
		}
	}

	public unsafe Vector2 farRainXTile1Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainXTile1Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainXTile1Threshold)) = vector;
		}
	}

	public unsafe Vector2 farRainXTile2Threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainXTile2Threshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farRainXTile2Threshold)) = vector;
		}
	}

	public unsafe Vector2 particalRainCountThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particalRainCountThreshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particalRainCountThreshold)) = vector;
		}
	}

	public unsafe Vector2 particalSnowCountThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particalSnowCountThreshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particalSnowCountThreshold)) = vector;
		}
	}

	public unsafe float cityWetness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetness)) = num;
		}
	}

	public unsafe float citySnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnow)) = num;
		}
	}

	public unsafe List<WetMaterial> wetMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wetMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WetMaterial>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wetMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<Material, WetMaterial> weatherMaterialsReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherMaterialsReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Material, WetMaterial>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherMaterialsReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<CustomPassVolume> customPasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customPasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CustomPassVolume>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customPasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<GameObject, WallFrontagePreset> rainyWindowFrontageObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainyWindowFrontageObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameObject, WallFrontagePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainyWindowFrontageObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float autoPauseTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPauseTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPauseTimer)) = num;
		}
	}

	public unsafe float autoResetTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoResetTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoResetTimer)) = num;
		}
	}

	public unsafe float lightswitchPulse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchPulse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchPulse)) = num;
		}
	}

	public unsafe bool lightswitchPulseMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchPulseMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightswitchPulseMode)) = flag;
		}
	}

	public unsafe SceneProfile currentProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentProfile);
			return *(SceneProfile*)num;
		}
		set
		{
			*(SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentProfile)) = sceneProfile;
		}
	}

	public unsafe CityControls.PPProfile currentSceneProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSceneProfile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityControls.PPProfile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSceneProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pPProfile));
		}
	}

	public unsafe CityControls.PPProfile desiredSceneProfile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSceneProfile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityControls.PPProfile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSceneProfile)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pPProfile));
		}
	}

	public unsafe Volume globalVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalVolume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Volume>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalVolume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)volume));
		}
	}

	public unsafe GradientSky gradientSky
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradientSky);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GradientSky>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradientSky)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gradientSky));
		}
	}

	public unsafe Fog volFog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volFog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Fog>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volFog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fog));
		}
	}

	public unsafe DepthOfField dof
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dof);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dof)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthOfField));
		}
	}

	public unsafe Vignette vignette
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignette);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Vignette>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignette)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vignette));
		}
	}

	public unsafe MotionBlur motionBlur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlur);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MotionBlur>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlur)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)motionBlur));
		}
	}

	public unsafe FilmGrain grain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grain);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FilmGrain>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filmGrain));
		}
	}

	public unsafe Tonemapping toneMapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toneMapping);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Tonemapping>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toneMapping)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tonemapping));
		}
	}

	public unsafe Bloom bloom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Bloom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bloom));
		}
	}

	public unsafe ChromaticAberration chromaticAberration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAberration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChromaticAberration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAberration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chromaticAberration));
		}
	}

	public unsafe LiftGammaGain lgg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lgg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LiftGammaGain>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lgg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)liftGammaGain));
		}
	}

	public unsafe ColorAdjustments colour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAdjustments));
		}
	}

	public unsafe LensDistortion lensDistort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensDistort);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LensDistortion>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lensDistort)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lensDistortion));
		}
	}

	public unsafe Exposure exposure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposure);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exposure>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposure)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exposure));
		}
	}

	public unsafe ChannelMixer channelMixer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelMixer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChannelMixer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelMixer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)channelMixer));
		}
	}

	public unsafe ScreenSpaceReflection ssReflection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ssReflection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceReflection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ssReflection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenSpaceReflection));
		}
	}

	public unsafe int skyboxGradientIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxGradientIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxGradientIndex)) = num;
		}
	}

	public unsafe SkyboxGradient fromSkyboxColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromSkyboxColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkyboxGradient>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromSkyboxColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skyboxGradient));
		}
	}

	public unsafe SkyboxGradient toSkyboxColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toSkyboxColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkyboxGradient>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toSkyboxColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skyboxGradient));
		}
	}

	public unsafe List<Elevator> activeElevators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeElevators);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Elevator>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeElevators)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractableController> particleSystems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleSystems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractableController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleSystems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Material broadcastMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_broadcastMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_broadcastMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe List<TelevisionChannel> televisionChannels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_televisionChannels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TelevisionChannel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_televisionChannels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TextMeshProUGUI pauseText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe GameObject pauseLensFlare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseLensFlare);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseLensFlare)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Image pauseButtonImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseButtonImg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseButtonImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image normalSpeedButtonImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalSpeedButtonImg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalSpeedButtonImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image fastSpeedButtonImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSpeedButtonImg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSpeedButtonImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image veryFastSpeedButtonImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_veryFastSpeedButtonImg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_veryFastSpeedButtonImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe TextMeshPro newWatchTimeText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newWatchTimeText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newWatchTimeText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshPro));
		}
	}

	public unsafe TextMeshPro newWatchDateText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newWatchDateText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newWatchDateText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshPro));
		}
	}

	public unsafe TextMeshProUGUI clockText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clockText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clockText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI dayText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Image pauseButtonIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseButtonIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseButtonIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Sprite pauseIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite playIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe NewNode startingNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe AudioController.LoopingSoundInfo interfaceActiveAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interfaceActiveAudio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interfaceActiveAudio)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe Vector2 debugDecimalRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDecimalRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDecimalRange)) = vector;
		}
	}

	public unsafe List<WeekDay> debugDayList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDayList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WeekDay>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugDayList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppSystem.Action UnloadPipes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnloadPipes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnloadPipes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe List<PipeConstructor.PipeGroup> pipesToUnload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pipesToUnload);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PipeConstructor.PipeGroup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pipesToUnload)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static SessionData _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SessionData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sessionData));
		}
	}

	public unsafe OnPauseUnPause OnPauseChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPauseChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnPauseUnPause>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPauseChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onPauseUnPause));
		}
	}

	public unsafe WeatherChange OnWeatherChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnWeatherChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeatherChange>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnWeatherChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weatherChange));
		}
	}

	public unsafe HourChange OnHourChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnHourChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HourChange>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnHourChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hourChange));
		}
	}

	public unsafe TutorialNotificationChange OnTutorialNotificationChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTutorialNotificationChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TutorialNotificationChange>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTutorialNotificationChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tutorialNotificationChange));
		}
	}

	public unsafe static SessionData Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102787, XrefRangeEnd = 102789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SessionData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SessionData>(intPtr) : null;
		}
	}

	static SessionData()
	{
		Il2CppClassPointerStore<SessionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SessionData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionData>.NativeClassPtr);
		NativeFieldInfoPtr_isFloorEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "isFloorEdit");
		NativeFieldInfoPtr_isDialogEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "isDialogEdit");
		NativeFieldInfoPtr_isCityEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "isCityEdit");
		NativeFieldInfoPtr_isTestScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "isTestScene");
		NativeFieldInfoPtr_dirtyScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "dirtyScene");
		NativeFieldInfoPtr_isDecorEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "isDecorEdit");
		NativeFieldInfoPtr_enableUserPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "enableUserPause");
		NativeFieldInfoPtr_enableFirstPersonMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "enableFirstPersonMap");
		NativeFieldInfoPtr_play = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "play");
		NativeFieldInfoPtr_enableTutorialText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "enableTutorialText");
		NativeFieldInfoPtr_tutorialTextTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "tutorialTextTriggered");
		NativeFieldInfoPtr_startedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "startedGame");
		NativeFieldInfoPtr_pauseUnpauseDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "pauseUnpauseDelay");
		NativeFieldInfoPtr_drunkOscillatorX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "drunkOscillatorX");
		NativeFieldInfoPtr_drunkOscillatorY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "drunkOscillatorY");
		NativeFieldInfoPtr_drunkOscillation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "drunkOscillation");
		NativeFieldInfoPtr_shiverOscillatorX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "shiverOscillatorX");
		NativeFieldInfoPtr_shiverOscillatorY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "shiverOscillatorY");
		NativeFieldInfoPtr_shiverProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "shiverProgress");
		NativeFieldInfoPtr_shiverOscillation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "shiverOscillation");
		NativeFieldInfoPtr_drunkLensProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "drunkLensProgress");
		NativeFieldInfoPtr_headacheProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "headacheProgress");
		NativeFieldInfoPtr_sunShadowFrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "sunShadowFrameCounter");
		NativeFieldInfoPtr_gameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "gameTime");
		NativeFieldInfoPtr_gameTimeDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "gameTimeDouble");
		NativeFieldInfoPtr_gameTimePassedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "gameTimePassedThisFrame");
		NativeFieldInfoPtr_prevHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "prevHour");
		NativeFieldInfoPtr_watchChangeCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "watchChangeCounter");
		NativeFieldInfoPtr_decimalClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "decimalClock");
		NativeFieldInfoPtr_decimalClockDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "decimalClockDouble");
		NativeFieldInfoPtr_currentTimeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentTimeSpeed");
		NativeFieldInfoPtr_currentTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentTimeMultiplier");
		NativeFieldInfoPtr_behaviourDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "behaviourDelay");
		NativeFieldInfoPtr_timeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "timeOfDay");
		NativeFieldInfoPtr_dayInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "dayInt");
		NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "day");
		NativeFieldInfoPtr_dateInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "dateInt");
		NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "month");
		NativeFieldInfoPtr_monthInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "monthInt");
		NativeFieldInfoPtr_daysInMonths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "daysInMonths");
		NativeFieldInfoPtr_yearInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "yearInt");
		NativeFieldInfoPtr_publicYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "publicYear");
		NativeFieldInfoPtr_leapYearCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "leapYearCycle");
		NativeFieldInfoPtr_gameTimeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "gameTimeLimit");
		NativeFieldInfoPtr_currentRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentRain");
		NativeFieldInfoPtr_desiredRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "desiredRain");
		NativeFieldInfoPtr_currentWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentWind");
		NativeFieldInfoPtr_desiredWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "desiredWind");
		NativeFieldInfoPtr_currentSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentSnow");
		NativeFieldInfoPtr_desiredSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "desiredSnow");
		NativeFieldInfoPtr_currentLightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentLightning");
		NativeFieldInfoPtr_desiredLightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "desiredLightning");
		NativeFieldInfoPtr_currentFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentFog");
		NativeFieldInfoPtr_desiredFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "desiredFog");
		NativeFieldInfoPtr_transitionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "transitionSpeed");
		NativeFieldInfoPtr_weatherChangeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "weatherChangeTimer");
		NativeFieldInfoPtr_monthTempMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "monthTempMultiplier");
		NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "temperature");
		NativeFieldInfoPtr_lightningTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "lightningTimer");
		NativeFieldInfoPtr_windDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "windDirection");
		NativeFieldInfoPtr_windForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "windForce");
		NativeFieldInfoPtr_dayProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "dayProgress");
		NativeFieldInfoPtr_nearRainSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "nearRainSheet");
		NativeFieldInfoPtr_farRainSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "farRainSheet");
		NativeFieldInfoPtr_nearRainAlpha1Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "nearRainAlpha1Threshold");
		NativeFieldInfoPtr_nearRainAlpha2Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "nearRainAlpha2Threshold");
		NativeFieldInfoPtr_nearRainSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "nearRainSpeedThreshold");
		NativeFieldInfoPtr_nearRainXTile1Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "nearRainXTile1Threshold");
		NativeFieldInfoPtr_nearRainXTile2Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "nearRainXTile2Threshold");
		NativeFieldInfoPtr_farRainAlpha1Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "farRainAlpha1Threshold");
		NativeFieldInfoPtr_farRainAlpha2Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "farRainAlpha2Threshold");
		NativeFieldInfoPtr_farRainSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "farRainSpeedThreshold");
		NativeFieldInfoPtr_farRainXTile1Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "farRainXTile1Threshold");
		NativeFieldInfoPtr_farRainXTile2Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "farRainXTile2Threshold");
		NativeFieldInfoPtr_particalRainCountThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "particalRainCountThreshold");
		NativeFieldInfoPtr_particalSnowCountThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "particalSnowCountThreshold");
		NativeFieldInfoPtr_cityWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "cityWetness");
		NativeFieldInfoPtr_citySnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "citySnow");
		NativeFieldInfoPtr_wetMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "wetMaterials");
		NativeFieldInfoPtr_weatherMaterialsReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "weatherMaterialsReference");
		NativeFieldInfoPtr_customPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "customPasses");
		NativeFieldInfoPtr_rainyWindowFrontageObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "rainyWindowFrontageObjects");
		NativeFieldInfoPtr_autoPauseTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "autoPauseTimer");
		NativeFieldInfoPtr_autoResetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "autoResetTimer");
		NativeFieldInfoPtr_lightswitchPulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "lightswitchPulse");
		NativeFieldInfoPtr_lightswitchPulseMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "lightswitchPulseMode");
		NativeFieldInfoPtr_currentProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentProfile");
		NativeFieldInfoPtr_currentSceneProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "currentSceneProfile");
		NativeFieldInfoPtr_desiredSceneProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "desiredSceneProfile");
		NativeFieldInfoPtr_globalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "globalVolume");
		NativeFieldInfoPtr_gradientSky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "gradientSky");
		NativeFieldInfoPtr_volFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "volFog");
		NativeFieldInfoPtr_dof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "dof");
		NativeFieldInfoPtr_vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "vignette");
		NativeFieldInfoPtr_motionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "motionBlur");
		NativeFieldInfoPtr_grain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "grain");
		NativeFieldInfoPtr_toneMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "toneMapping");
		NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "bloom");
		NativeFieldInfoPtr_chromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "chromaticAberration");
		NativeFieldInfoPtr_lgg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "lgg");
		NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "colour");
		NativeFieldInfoPtr_lensDistort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "lensDistort");
		NativeFieldInfoPtr_exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "exposure");
		NativeFieldInfoPtr_channelMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "channelMixer");
		NativeFieldInfoPtr_ssReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "ssReflection");
		NativeFieldInfoPtr_skyboxGradientIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "skyboxGradientIndex");
		NativeFieldInfoPtr_fromSkyboxColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "fromSkyboxColours");
		NativeFieldInfoPtr_toSkyboxColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "toSkyboxColours");
		NativeFieldInfoPtr_activeElevators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "activeElevators");
		NativeFieldInfoPtr_particleSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "particleSystems");
		NativeFieldInfoPtr_broadcastMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "broadcastMaterial");
		NativeFieldInfoPtr_televisionChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "televisionChannels");
		NativeFieldInfoPtr_pauseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "pauseText");
		NativeFieldInfoPtr_pauseLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "pauseLensFlare");
		NativeFieldInfoPtr_pauseButtonImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "pauseButtonImg");
		NativeFieldInfoPtr_normalSpeedButtonImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "normalSpeedButtonImg");
		NativeFieldInfoPtr_fastSpeedButtonImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "fastSpeedButtonImg");
		NativeFieldInfoPtr_veryFastSpeedButtonImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "veryFastSpeedButtonImg");
		NativeFieldInfoPtr_newWatchTimeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "newWatchTimeText");
		NativeFieldInfoPtr_newWatchDateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "newWatchDateText");
		NativeFieldInfoPtr_clockText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "clockText");
		NativeFieldInfoPtr_dayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "dayText");
		NativeFieldInfoPtr_pauseButtonIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "pauseButtonIcon");
		NativeFieldInfoPtr_pauseIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "pauseIcon");
		NativeFieldInfoPtr_playIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "playIcon");
		NativeFieldInfoPtr_startingNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "startingNode");
		NativeFieldInfoPtr_interfaceActiveAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "interfaceActiveAudio");
		NativeFieldInfoPtr_debugDecimalRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "debugDecimalRange");
		NativeFieldInfoPtr_debugDayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "debugDayList");
		NativeFieldInfoPtr_UnloadPipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "UnloadPipes");
		NativeFieldInfoPtr_pipesToUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "pipesToUnload");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "_instance");
		NativeFieldInfoPtr_OnPauseChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "OnPauseChange");
		NativeFieldInfoPtr_OnWeatherChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "OnWeatherChange");
		NativeFieldInfoPtr_OnHourChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "OnHourChange");
		NativeFieldInfoPtr_OnTutorialNotificationChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionData>.NativeClassPtr, "OnTutorialNotificationChange");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666177);
		NativeMethodInfoPtr_add_OnPauseChange_Public_add_Void_OnPauseUnPause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666178);
		NativeMethodInfoPtr_remove_OnPauseChange_Public_rem_Void_OnPauseUnPause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666179);
		NativeMethodInfoPtr_add_OnWeatherChange_Public_add_Void_WeatherChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666180);
		NativeMethodInfoPtr_remove_OnWeatherChange_Public_rem_Void_WeatherChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666181);
		NativeMethodInfoPtr_add_OnHourChange_Public_add_Void_HourChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666182);
		NativeMethodInfoPtr_remove_OnHourChange_Public_rem_Void_HourChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666183);
		NativeMethodInfoPtr_add_OnTutorialNotificationChange_Public_add_Void_TutorialNotificationChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666184);
		NativeMethodInfoPtr_remove_OnTutorialNotificationChange_Public_rem_Void_TutorialNotificationChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666185);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666186);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666187);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666188);
		NativeMethodInfoPtr_SetupTelevisionChannels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666189);
		NativeMethodInfoPtr_StartTestScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666190);
		NativeMethodInfoPtr_SetGameTime_Public_Void_Int32_Int32_Int32_Int32_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666191);
		NativeMethodInfoPtr_SetGameTime_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666192);
		NativeMethodInfoPtr_UpdateSkyboxGraidentTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666193);
		NativeMethodInfoPtr_SetTimeSpeed_Public_Void_TimeSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666194);
		NativeMethodInfoPtr_GetGameSpeedMotionBlurModifier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666195);
		NativeMethodInfoPtr_SetSceneProfile_Public_Void_SceneProfile_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666196);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666197);
		NativeMethodInfoPtr_UpdateGameTimerText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666198);
		NativeMethodInfoPtr_EndDemo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666199);
		NativeMethodInfoPtr_ExecuteSyncPhysics_Public_Void_PhysicsSyncType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666200);
		NativeMethodInfoPtr_ExecuteWeatherChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666201);
		NativeMethodInfoPtr_ExecuteWetnessChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666202);
		NativeMethodInfoPtr_ExecuteWindChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666203);
		NativeMethodInfoPtr_GetWeatherAffectedMaterial_Public_Material_Material_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666204);
		NativeMethodInfoPtr_ExecuteLightningStrike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666205);
		NativeMethodInfoPtr_SetSceneVisuals_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666206);
		NativeMethodInfoPtr_SetEnablePause_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666207);
		NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_WeekDay_byref_Month_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666208);
		NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666209);
		NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_WeekDay_byref_Int32_byref_Month_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666210);
		NativeMethodInfoPtr_ParseGameTime_Public_Single_Single_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666211);
		NativeMethodInfoPtr_FloatDecimal24H_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666212);
		NativeMethodInfoPtr_FloatMinutes24H_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666213);
		NativeMethodInfoPtr_FloatMinutes12H_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666214);
		NativeMethodInfoPtr_DecimalToClockString_Public_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666215);
		NativeMethodInfoPtr_DecimalToTimeLengthString_Public_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666216);
		NativeMethodInfoPtr_GameTimeToClock24String_Public_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666217);
		NativeMethodInfoPtr_GameTimeToClock12String_Public_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666218);
		NativeMethodInfoPtr_MinutesToClockString_Public_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666219);
		NativeMethodInfoPtr_CurrentTimeString_Public_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666220);
		NativeMethodInfoPtr_ShortDateString_Public_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666221);
		NativeMethodInfoPtr_CurrentShortDateString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666222);
		NativeMethodInfoPtr_LongDateString_Public_String_Single_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666223);
		NativeMethodInfoPtr_CurrentLongDateString_Public_String_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666224);
		NativeMethodInfoPtr_TimeString_Public_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666225);
		NativeMethodInfoPtr_TimeStringOnDay_Public_String_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666226);
		NativeMethodInfoPtr_TimeAndDate_Public_String_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666227);
		NativeMethodInfoPtr_OnDay_Public_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666228);
		NativeMethodInfoPtr_GetNextOrPreviousGameTimeForThisHour_Public_Single_byref_List_1_WeekDay_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666229);
		NativeMethodInfoPtr_GetNextOrPreviousGameTimeForThisHour_Public_Single_Single_Single_WeekDay_byref_List_1_WeekDay_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666230);
		NativeMethodInfoPtr_GetTimeDifference_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666231);
		NativeMethodInfoPtr_CompareTimes_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666232);
		NativeMethodInfoPtr_WeekdayFromInt_Public_WeekDay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666233);
		NativeMethodInfoPtr_MonthFromInt_Public_Month_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666234);
		NativeMethodInfoPtr_SetWeather_Public_Void_Single_Single_Single_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666235);
		NativeMethodInfoPtr_UpdateWatchText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666236);
		NativeMethodInfoPtr_UpdateWatchDay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666237);
		NativeMethodInfoPtr_TogglePause_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666238);
		NativeMethodInfoPtr_PauseGame_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666239);
		NativeMethodInfoPtr_ResumeGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666240);
		NativeMethodInfoPtr_SetDisplayTutorialText_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666241);
		NativeMethodInfoPtr_TutorialTrigger_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666242);
		NativeMethodInfoPtr_UpdateTutorialNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666243);
		NativeMethodInfoPtr_ExecuteUnloadPipes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666244);
		NativeMethodInfoPtr_OnSceneExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666245);
		NativeMethodInfoPtr_DebugPreviousOrLastTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666246);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionData>.NativeClassPtr, 100666247);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 102792, RefRangeEnd = 102794, XrefRangeStart = 102789, XrefRangeEnd = 102792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnPauseChange(OnPauseUnPause value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnPauseChange_Public_add_Void_OnPauseUnPause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102794, XrefRangeEnd = 102797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnPauseChange(OnPauseUnPause value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnPauseChange_Public_rem_Void_OnPauseUnPause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102797, XrefRangeEnd = 102800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnWeatherChange(WeatherChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnWeatherChange_Public_add_Void_WeatherChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102800, XrefRangeEnd = 102803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnWeatherChange(WeatherChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnWeatherChange_Public_rem_Void_WeatherChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 102806, RefRangeEnd = 102808, XrefRangeStart = 102803, XrefRangeEnd = 102806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnHourChange(HourChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnHourChange_Public_add_Void_HourChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 102811, RefRangeEnd = 102813, XrefRangeStart = 102808, XrefRangeEnd = 102811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnHourChange(HourChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnHourChange_Public_rem_Void_HourChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102813, XrefRangeEnd = 102816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnTutorialNotificationChange(TutorialNotificationChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnTutorialNotificationChange_Public_add_Void_TutorialNotificationChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102816, XrefRangeEnd = 102819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnTutorialNotificationChange(TutorialNotificationChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnTutorialNotificationChange_Public_rem_Void_TutorialNotificationChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102819, XrefRangeEnd = 103082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103082, XrefRangeEnd = 103171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103171, XrefRangeEnd = 103280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103326, RefRangeEnd = 103327, XrefRangeStart = 103280, XrefRangeEnd = 103326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTelevisionChannels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTelevisionChannels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103460, RefRangeEnd = 103461, XrefRangeStart = 103327, XrefRangeEnd = 103460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartTestScene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartTestScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 103523, RefRangeEnd = 103525, XrefRangeStart = 103461, XrefRangeEnd = 103523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameTime(int newYear, int newMonth, int newDate, int newDay, float newStartingTime, int newLeapYearCycle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&newYear);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newMonth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newDate;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newDay;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newStartingTime;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLeapYearCycle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameTime_Public_Void_Int32_Int32_Int32_Int32_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103552, RefRangeEnd = 103553, XrefRangeStart = 103525, XrefRangeEnd = 103552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameTime(float newGameTime, int newLeapYearCycle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newGameTime);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLeapYearCycle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameTime_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 103569, RefRangeEnd = 103571, XrefRangeStart = 103553, XrefRangeEnd = 103569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSkyboxGraidentTargets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSkyboxGraidentTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 103606, RefRangeEnd = 103614, XrefRangeStart = 103571, XrefRangeEnd = 103606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTimeSpeed(TimeSpeed newTimeSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newTimeSpeed);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTimeSpeed_Public_Void_TimeSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 103614, RefRangeEnd = 103616, XrefRangeStart = 103614, XrefRangeEnd = 103614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGameSpeedMotionBlurModifier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameSpeedMotionBlurModifier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103653, RefRangeEnd = 103654, XrefRangeStart = 103616, XrefRangeEnd = 103653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSceneProfile(SceneProfile newProfile, bool immediate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newProfile);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &immediate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSceneProfile_Public_Void_SceneProfile_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103654, XrefRangeEnd = 104132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 104143, RefRangeEnd = 104145, XrefRangeStart = 104132, XrefRangeEnd = 104143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGameTimerText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateGameTimerText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104145, XrefRangeEnd = 104178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndDemo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndDemo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 104182, RefRangeEnd = 104183, XrefRangeStart = 104178, XrefRangeEnd = 104182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteSyncPhysics(PhysicsSyncType syncType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&syncType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteSyncPhysics_Public_Void_PhysicsSyncType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 104265, RefRangeEnd = 104270, XrefRangeStart = 104183, XrefRangeEnd = 104265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteWeatherChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteWeatherChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 104306, RefRangeEnd = 104310, XrefRangeStart = 104270, XrefRangeEnd = 104306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteWetnessChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteWetnessChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 104313, RefRangeEnd = 104315, XrefRangeStart = 104310, XrefRangeEnd = 104313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteWindChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteWindChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 104344, RefRangeEnd = 104349, XrefRangeStart = 104315, XrefRangeEnd = 104344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material GetWeatherAffectedMaterial(Material inputMat, MeshRenderer inputRenderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputMat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputRenderer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeatherAffectedMaterial_Public_Material_Material_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 104597, RefRangeEnd = 104598, XrefRangeStart = 104349, XrefRangeEnd = 104597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteLightningStrike()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteLightningStrike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 104790, RefRangeEnd = 104793, XrefRangeStart = 104598, XrefRangeEnd = 104790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSceneVisuals(float newDecimalClock)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newDecimalClock);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSceneVisuals_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104793, XrefRangeEnd = 104794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnablePause(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnablePause_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 104804, RefRangeEnd = 104805, XrefRangeStart = 104794, XrefRangeEnd = 104804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseTimeData(float newTime, out float decimalHourOut, out int dayIntOut, out int dateIntOut, out int monthIntOut, out int yearIntOut, out WeekDay dayEnumOut, out Month monthEnumOut, out int leapCycleOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&newTime);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref decimalHourOut);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dayIntOut);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dateIntOut);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref monthIntOut);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yearIntOut);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dayEnumOut);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref monthEnumOut);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref leapCycleOut);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_WeekDay_byref_Month_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 104821, RefRangeEnd = 104839, XrefRangeStart = 104805, XrefRangeEnd = 104821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseTimeData(float newTime, out float decimalHourOut, out int dayIntOut, out int dateIntOut, out int monthIntOut, out int yearIntOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&newTime);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref decimalHourOut);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dayIntOut);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dateIntOut);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref monthIntOut);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yearIntOut);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104839, XrefRangeEnd = 104846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseTimeData(float newTime, out float decimalHourOut, out WeekDay dayEnumOut, out int dateIntOut, out Month monthEnumOut, out int yearIntOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&newTime);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref decimalHourOut);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dayEnumOut);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dateIntOut);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref monthEnumOut);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yearIntOut);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeData_Public_Void_Single_byref_Single_byref_WeekDay_byref_Int32_byref_Month_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 104857, RefRangeEnd = 104858, XrefRangeStart = 104846, XrefRangeEnd = 104857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ParseGameTime(float decimalHourIn, int dateIntIn, int monthIntIn, int yearIntIn, out int dayCount, out int leapYear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&decimalHourIn);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateIntIn;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &monthIntIn;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &yearIntIn;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dayCount);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref leapYear);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseGameTime_Public_Single_Single_Int32_Int32_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104858, XrefRangeEnd = 104859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FloatDecimal24H(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatDecimal24H_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 104863, RefRangeEnd = 104886, XrefRangeStart = 104859, XrefRangeEnd = 104863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FloatMinutes24H(float newTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatMinutes24H_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 104891, RefRangeEnd = 104893, XrefRangeStart = 104886, XrefRangeEnd = 104891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FloatMinutes12H(float newTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloatMinutes12H_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 104895, RefRangeEnd = 104901, XrefRangeStart = 104893, XrefRangeEnd = 104895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string DecimalToClockString(float newTime, bool useZeroHoursMethod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useZeroHoursMethod;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecimalToClockString_Public_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 104921, RefRangeEnd = 104922, XrefRangeStart = 104901, XrefRangeEnd = 104921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string DecimalToTimeLengthString(float newTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecimalToTimeLengthString_Public_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 104925, RefRangeEnd = 104933, XrefRangeStart = 104922, XrefRangeEnd = 104925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GameTimeToClock24String(float newGameTime, bool useZeroHoursMethod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newGameTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useZeroHoursMethod;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameTimeToClock24String_Public_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 104951, RefRangeEnd = 104963, XrefRangeStart = 104933, XrefRangeEnd = 104951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GameTimeToClock12String(float newGameTime, bool useZeroHoursMethod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newGameTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useZeroHoursMethod;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameTimeToClock12String_Public_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 104988, RefRangeEnd = 105011, XrefRangeStart = 104963, XrefRangeEnd = 104988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string MinutesToClockString(float formatted, bool useZeroHoursMethod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&formatted);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useZeroHoursMethod;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinutesToClockString_Public_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105011, XrefRangeEnd = 105014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CurrentTimeString(bool useZeroHoursMethod, bool use12HourClock = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&useZeroHoursMethod);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &use12HourClock;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentTimeString_Public_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 105072, RefRangeEnd = 105082, XrefRangeStart = 105014, XrefRangeEnd = 105072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ShortDateString(float newGameTime, bool shortenYear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newGameTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenYear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortDateString_Public_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105082, XrefRangeEnd = 105083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CurrentShortDateString(bool shortenYear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shortenYear);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentShortDateString_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 105153, RefRangeEnd = 105163, XrefRangeStart = 105083, XrefRangeEnd = 105153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string LongDateString(float newGameTime, bool includeDay, bool shortenDay, bool includeMonth, bool shortenMonth, bool includeDate, bool includeYear, bool shortenYear, bool useCommas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&newGameTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDay;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenDay;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeMonth;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenMonth;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDate;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeYear;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenYear;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCommas;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LongDateString_Public_String_Single_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105163, XrefRangeEnd = 105164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CurrentLongDateString(bool includeDay, bool shortenDay, bool includeMonth, bool shortenMonth, bool includeDate, bool includeYear, bool shortenYear, bool useCommas)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&includeDay);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenDay;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeMonth;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenMonth;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeDate;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeYear;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenYear;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCommas;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentLongDateString_Public_String_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 104925, RefRangeEnd = 104933, XrefRangeStart = 104925, XrefRangeEnd = 104933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TimeString(float newGameTime, bool useZeroHoursMethod)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newGameTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useZeroHoursMethod;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeString_Public_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 105190, RefRangeEnd = 105197, XrefRangeStart = 105164, XrefRangeEnd = 105190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TimeStringOnDay(float newGameTime, bool useZeroHoursMethod, bool shortenDay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&newGameTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useZeroHoursMethod;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenDay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeStringOnDay_Public_String_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 105202, RefRangeEnd = 105208, XrefRangeStart = 105197, XrefRangeEnd = 105202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string TimeAndDate(float newGameTime, bool useZeroHoursMethod, bool shortenDay, bool shortenYear)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&newGameTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useZeroHoursMethod;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenDay;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenYear;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeAndDate_Public_String_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105208, XrefRangeEnd = 105237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string OnDay(int newDay, bool shortenDay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newDay);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortenDay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDay_Public_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105237, XrefRangeEnd = 105238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetNextOrPreviousGameTimeForThisHour(ref List<WeekDay> days, float startHour, float endHour)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)days);
		*ptr = (nint)(&intPtr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startHour;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endHour;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextOrPreviousGameTimeForThisHour_Public_Single_byref_List_1_WeekDay_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		days = ((intPtr4 == (System.IntPtr)0) ? null : new List<WeekDay>(intPtr4));
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 105241, RefRangeEnd = 105249, XrefRangeStart = 105238, XrefRangeEnd = 105241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetNextOrPreviousGameTimeForThisHour(float forThisGameTime, float forThisDecimalHour, WeekDay forThisWeekday, ref List<WeekDay> validWeekDays, float startDecimalHour, float endDecimalHour)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&forThisGameTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forThisDecimalHour;
		*(WeekDay**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forThisWeekday;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validWeekDays);
		*(System.IntPtr**)num = &intPtr;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &startDecimalHour;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &endDecimalHour;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextOrPreviousGameTimeForThisHour_Public_Single_Single_Single_WeekDay_byref_List_1_WeekDay_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		validWeekDays = ((intPtr4 == (System.IntPtr)0) ? null : new List<WeekDay>(intPtr4));
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float GetTimeDifference(float time1, float time2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeDifference_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105249, XrefRangeEnd = 105255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareTimes(float time1, float time2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTimes_Public_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe WeekDay WeekdayFromInt(int weekInt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&weekInt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WeekdayFromInt_Public_WeekDay_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WeekDay*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Month MonthFromInt(int monthInt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&monthInt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MonthFromInt_Public_Month_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Month*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 105317, RefRangeEnd = 105322, XrefRangeStart = 105255, XrefRangeEnd = 105317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWeather(float newRain, float newWind, float newSnow, float newLightning, float newFog, float newTransitionSpeed = 0.1f, bool updateInstantly = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&newRain);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newWind;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSnow;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLightning;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &newFog;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newTransitionSpeed;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateInstantly;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWeather_Public_Void_Single_Single_Single_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 105339, RefRangeEnd = 105347, XrefRangeStart = 105322, XrefRangeEnd = 105339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWatchText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWatchText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 105447, RefRangeEnd = 105455, XrefRangeStart = 105347, XrefRangeEnd = 105447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWatchDay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWatchDay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105455, XrefRangeEnd = 105457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TogglePause(bool openDesktopMode = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&openDesktopMode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TogglePause_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 105479, RefRangeEnd = 105516, XrefRangeStart = 105457, XrefRangeEnd = 105479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PauseGame(bool showPauseText, bool delayOverride = false, bool openDesktopMode = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&showPauseText);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayOverride;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &openDesktopMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PauseGame_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 105669, RefRangeEnd = 105685, XrefRangeStart = 105516, XrefRangeEnd = 105669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResumeGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResumeGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 105726, RefRangeEnd = 105732, XrefRangeStart = 105685, XrefRangeEnd = 105726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDisplayTutorialText(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDisplayTutorialText_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 105773, RefRangeEnd = 105804, XrefRangeStart = 105732, XrefRangeEnd = 105773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TutorialTrigger(string str, bool isSilent = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSilent;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TutorialTrigger_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 105812, RefRangeEnd = 105816, XrefRangeStart = 105804, XrefRangeEnd = 105812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTutorialNotifications()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTutorialNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105816, XrefRangeEnd = 105839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteUnloadPipes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteUnloadPipes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 105843, RefRangeEnd = 105846, XrefRangeStart = 105839, XrefRangeEnd = 105843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSceneExit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSceneExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105846, XrefRangeEnd = 105852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugPreviousOrLastTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugPreviousOrLastTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105852, XrefRangeEnd = 105923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SessionData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SessionData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
